# python find_contours.py --image test.jpg --output test2.jpg --kernel 1,1,-1,1,-2,-1,1,1,-1
import cv2 as cv
import numpy as np
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


kernel = args['kernel'].split(",")
print(kernel)
kernel = np.array(kernel, dtype="int").reshape(3, 3)
print(kernel)
row = 0
image = cv.imread(args['image'])
imgray = cv.cvtColor(image, cv.COLOR_BGR2GRAY)
#ret, thresh = cv.threshold(imgray, int(args['threshold']), 255, cv.THRESH_BINARY_INV)
image = cv.filter2D(imgray, -1, kernel)
cv.imwrite(args['output'], image)
cv.waitKey(0)
cv.destroyAllWindows()
