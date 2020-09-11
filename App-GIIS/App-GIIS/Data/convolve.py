# python convolve.py --image test.jpg --output test2.jpg --kernel 1,1,-1,1,-2,-1,1,1,-1
import cv2 as cv
import numpy as np
from skimage.exposure import rescale_intensity
import argparse


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
    (iH, iW) = image.shape[:2]
    (kH, kW) = kernel.shape[:2]
    pad = (kW - 1) // 2
    image = cv.copyMakeBorder(image, pad, pad, pad, pad,
                               cv.BORDER_REPLICATE)
    output = np.zeros((iH, iW), dtype="float32")
    for y in np.arange(pad, iH + pad):
        for x in np.arange(pad, iW + pad):
            roi = image[y - pad:y + pad + 1, x - pad:x + pad + 1]
            k = (roi * kernel).sum()
            output[y - pad, x - pad] = k
    output = rescale_intensity(output, in_range=(0, 255))
    output = (output * 255).astype("uint8")
    return output

kernel = args['kernel'].split(",")
kernel = np.array(kernel, dtype="int").reshape(3, 3)
print(kernel)
image = cv.imread(args['image'])
imgray = cv.cvtColor(image, cv.COLOR_BGR2GRAY)
image = convolve(imgray, kernel)
cv.imwrite(args['output'], image)
cv.waitKey(0)
cv.destroyAllWindows()