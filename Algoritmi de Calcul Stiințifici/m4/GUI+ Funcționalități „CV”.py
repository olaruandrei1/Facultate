import cv2
import numpy as np
from tkinter import *
from PIL import ImageTk, Image
from tkinter import Tk
from tkinter import Button
from tkinter import Label
from tkinter import Image
from tkinter.constants import DISABLED
from PIL import Image
from tkinter import filedialog
import imutils
import cv2 as cv

global image

def SelectImage():
	
    path_image = filedialog .askopenfilename()
    
    if len(path_image) > 0:
        global image
        image = cv2.imread(path_image, -1)
        image = imutils.resize(image, height=200)
        
        imageToShow=imutils.resize(image, width=200)
        imageToShow= cv2.cvtColor(imageToShow, cv2.COLOR_BGR2RGB)
        im = Image.fromarray(imageToShow)
        img = ImageTk.PhotoImage(image=im)
        
        lblInputImage.configure(image=img)
        lblInputImage.image=img
        
image = None
    
    
def myGray():
    grey = cv.cvtColor(image, cv.COLOR_BGR2GRAY)
    
    im = Image.fromarray(grey)
    img= ImageTk.PhotoImage(image=im)
    lblOutputImage.configure(image=img)
    lblOutputImage.image=img

def myThresh():
    ret,thresh1 = cv.threshold(image,157,300,cv.THRESH_BINARY_INV)
    
    im = Image.fromarray(thresh1)
    img= ImageTk.PhotoImage(image=im)
    lblOutputImage.configure(image=img)
    lblOutputImage.image=img
    
def myText():
    imgText=cv.putText(image, text="Aici este un Text", org=(100,100), fontFace = 2, fontScale= 2, color = (0, 0, 255),thickness=2)
    
    im= Image.fromarray(imgText)
    img= ImageTk.PhotoImage(image=im)
    lblOutputImage.configure(image=img)
    lblOutputImage.image=img
    
def myBlur():
    imgBlur = cv.GaussianBlur(image, (3,3), cv.BORDER_DEFAULT)
    
    im= Image.fromarray(imgBlur)
    img= ImageTk.PhotoImage(image=im)
    lblOutputImage.configure(image=img)
    lblOutputImage.image=img

def myCanny():
    imgBlur = cv.GaussianBlur(image, (3,3), cv.BORDER_DEFAULT)
    canny = cv.Canny(imgBlur, 125,175)
    
    im= Image.fromarray(canny)
    img= ImageTk.PhotoImage(image=im)
    lblOutputImage.configure(image=img)
    lblOutputImage.image=img

def myCut():
    imgCut= image[50:1000,50:300]
    
    im= Image.fromarray(imgCut)
    img= ImageTk.PhotoImage(image=im)
    lblOutputImage.configure(image=img)
    lblOutputImage.image=img

def myBila():
    imgBil=cv.bilateralFilter(image,20,100,100)
    
    im= Image.fromarray(imgBil)
    img= ImageTk.PhotoImage(image=im)
    lblOutputImage.configure(image=img)
    lblOutputImage.image=img

def myMirror():
    imgMirror = cv.flip(image, 0) 
    
    im= Image.fromarray(imgMirror)
    img= ImageTk.PhotoImage(image=im)
    lblOutputImage.configure(image=img)
    lblOutputImage.image=img

root = Tk()
root.title("Aplicatie de procesare imagini M4")
root.geometry("800x600")
lblInfo1 = Label(root, text="Aplicație pentru procesarea imaginilor", fg='darkviolet',  font=('Helvetica', 18, 'bold', 'underline') )
lblInfo1.place(x=180, y=10)

lblInputImage = Label(root)
lblInputImage.place(x=200, y=100)

lblOutputImage = Label(root)
lblOutputImage.place(relx=0.7,x=-300, y=100)

button1 = Button(root, text="Efect Alb Negru", command = myGray, width=10, fg='white', bg='darkviolet')
button2 = Button(root, text="Thresh Binary Inverted", command = myThresh, width=10, fg='white', bg='darkviolet')
button3 = Button(root, text="Adauga Text", command = myText, width=10, fg='white', bg='darkviolet')
button4 = Button(root, text="Filtru Blurat", command = myBlur, width=10, fg='white', bg='darkviolet')
button5 = Button(root, text="Filtru Contur", command = myCanny, width=10, fg='white', bg='darkviolet')
button6 = Button(root, text="Taie Imagine", command = myCut, width=10, fg='white', bg='darkviolet')
button7 = Button(root, text="Efect Bilateral", command = myBila, width=10, fg='white', bg='darkviolet')
button8 = Button(root, text="Efect Oglindire", command = myMirror, width=10, fg='white', bg='darkviolet')
buttonalege = Button(root, text="Selecteaza Imaginea" ,command = SelectImage, width= 25, fg='white', bg='red')

button1.place(x=80, y=500, anchor="center")
button2.place(x=180, y=500, anchor="center")
button3.place(x=280, y=500, anchor="center")
button4.place(x=380, y=500, anchor="center")
button5.place(x=480, y=500, anchor="center")
button6.place(x=580, y=500, anchor="center")
button7.place(x=580, y=500, anchor="center")
button8.place(x=680, y=500, anchor="center")
buttonalege.place(x=400, y=400, anchor="center")

cv2.waitKey(0)
cv2.destroyAllWindows()
root.mainloop()