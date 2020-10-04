# python sobel_convolve.py --image test.jpg --output test2.jpg --sobel sobel_x
import cv2 as cv
import numpy as np
import argparse
from contextlib import closing
import tqdm

ap = argparse.ArgumentParser()
ap.add_argument("-i", "--image", required=True,
                help="path to the input image")
ap.add_argument("-o", "--output", required=True,
                help="path to the output image image")
ap.add_argument("-s", "--sobel", required=True,
                help="type of sobel operator")
ap.add_argument("-th", "--threshold", required=False,
                help="threshold for find contours")
args = vars(ap.parse_args())

image = cv.imread(args['image'])
imgray = cv.cvtColor(image, cv.COLOR_BGR2GRAY)
# ret, thresh = cv.threshold(imgray, int(args['threshold']), 255, cv.THRESH_BINARY_INV)
if args['sobel'] == "sobel_x":
    image = cv.Sobel(imgray, cv.CV_64F, 1, 0, ksize=3)
elif args['sobel'] == "sobel_y":
    image = cv.Sobel(imgray, cv.CV_64F, 0, 1, ksize=3)
else:
    image = cv.Sobel(imgray, cv.CV_64F, 1, 1, ksize=3)
print("[INFO] Outlines are selected")
cv.imwrite(args['output'], image)
cv.destroyAllWindows()
