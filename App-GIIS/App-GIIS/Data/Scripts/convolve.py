# python convolve.py --image test.jpg --output test2.jpg --kernel 1,1,-1,1,-2,-1,1,1,-1 --threshold 145
import cv2 as cv
import numpy as np
from skimage.exposure import rescale_intensity
import argparse
import tqdm


ap = argparse.ArgumentParser()
ap.add_argument("-i", "--image", required=True,
                help="path to the input image")
ap.add_argument("-o", "--output", required=True,
                help="path to the output image image")
ap.add_argument("-k", "--kernel", required=True,
                help="mask-kernel for find contours")
ap.add_argument("-th", "--threshold", required=False,
                help="threshold for find contours")
args = vars(ap.parse_args())


def convolve(image, kernel):
    # grab the spatial dimensions of the image, along with
    # the spatial dimensions of the kernel
    (iH, iW) = image.shape[:2]
    (kH, kW) = kernel.shape[:2]
    # allocate memory for the output image, taking care to
    # "pad" the borders of the input image so the spatial
    # size (i.e., width and height) are not reduced
    pad = (kW - 1) // 2
    image = cv.copyMakeBorder(image, pad, pad, pad, pad,
                               cv.BORDER_REPLICATE)
    output = np.zeros((iH, iW), dtype="float32")
    # loop over the input image, "sliding" the kernel across
    # each (x, y)-coordinate from left-to-right and top to
    # bottom
    for y in tqdm.tqdm(np.arange(pad, iH + pad), desc="Processed data"):
        for x in np.arange(pad, iW + pad):
            # extract the ROI of the image by extracting the
            # *center* region of the current (x, y)-coordinates
            # dimensions
            roi = image[y - pad:y + pad + 1, x - pad:x + pad + 1]
            # perform the actual convolution by taking the
            # element-wise multiplicate between the ROI and
            # the kernel, then summing the matrix
            k = (roi * kernel).sum()
            # store the convolved value in the output (x,y)-
            # coordinate of the output image
            if(k > int(args['threshold'])):
                output[y - pad, x - pad] = 255
            else: output[y - pad, x - pad] = 0
            # output[y - pad, x - pad] = k
    # rescale the output image to be in the range [0, 255]
    print(output)
    # output = rescale_intensity(output, in_range=(0, 255))
    # output = (output * 255).astype("uint8")
    # return the output image
    return output

kernel = args['kernel'].split(",")
kernel = np.array(kernel, dtype="int").reshape(3, 3)
image = cv.imread(args['image'])
imgray = cv.cvtColor(image, cv.COLOR_BGR2GRAY)
image = convolve(imgray, kernel)
cv.imwrite(args['output'], image)
cv.waitKey(0)
cv.destroyAllWindows()
