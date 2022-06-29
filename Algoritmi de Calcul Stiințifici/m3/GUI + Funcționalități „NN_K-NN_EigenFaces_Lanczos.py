from tkinter.ttk import Combobox
import cv2 as cv
import numpy as np
from tkinter import *
from PIL import ImageTk, Image
from tkinter.constants import DISABLED
from tkinter import filedialog
import imutils
from numpy import linalg as la
import matplotlib.pyplot as plt

A = np.zeros([10304, 320])
nrPersoane = 40

def configurareA():
    caleBD=r'm0poze'
    for i in range(1,nrPersoane+1):
        caleFolderPers=caleBD+'\s'+str(i)+'\\'
        for j in range(1,nrPozeAntrenare+1):
            calePozaAntrenare=caleFolderPers+str(j)+'.pgm'
            pozaAntrenare=np.array(cv.imread(calePozaAntrenare,0))
            pozaVect=pozaAntrenare.reshape(10304,) 
            A[:,nrPozeAntrenare*(i-1)+j-1] = pozaVect


def norma_dif(x,y,norma):
    cases = {
        '1': la.norm(x-y,1),
        '2': la.norm(x-y),
        'inf': la.norm(x-y,np.inf),
        'cos': 1-np.dot(x,y)/(la.norm(x)*la.norm(y))
    }
    return cases.get(norma)


def nn(A,pozaCautata,norma):
	z=np.zeros(len(A[0]))
	for i in range(len(z)):
		z[i]=norma_dif(A[:,i],pozaCautata,norma)
	pozitia=np.argmin(z)
	return pozitia


def knn(A,pozaCautata,norma):
	global nrPozeAntrenare
	global k
	nrPozeAntrenare=int(nrPozeAntrenare)
	k = int(k)
	z=np.zeros(len(A[0]))
	for i in range(len(z)):
		z[i]=norma_dif(A[:,i],pozaCautata,norma)
	pozitii=np.argsort(z)
	pozitii=pozitii[:k]
	vecini=pozitii//nrPozeAntrenare
	vecin=int(st.mode(vecini))
	return vecin*nrPozeAntrenare


def preprocEigenfaces(A,pozaCautata,norma):
	global k
	global media
	global HQPB
	global proiectii
	print("Preprocesare Eigenfaces: ")
	k = int(k)
	media = np.mean(A,axis=1)
	A=(A.T-media).T
	L=np.dot(A.T,A)
	d,v=la.eig(L)
	v=np.dot(A,v)
	indx=np.argsort(d)
	indx=indx[:-k-1:-1]
	HQPB=v[:,indx]
	proiectii=np.dot(A.T,HQPB)


def interEigenfaces(A,pozaCautata,norma):
	global media
	global HQPB
	global proiectii
	print("Interogare Eigenfaces: ")
	pozaCautata=pozaCautata-media
	prCautata=np.dot(pozaCautata.T,HQPB)
	pozitia=nn(proiectii.T,prCautata,norma)
	return pozitia


def cautare():
	
	pozaCautata=np.array(path_image = filedialog .askopenfilename())
	plt.imshow(pozaCautata, cmap='gray', vmin=0, vmax=255)
	plt.show() 
	pozaCautata=pozaCautata.reshape(10304,)
	pozitia=nn(A,pozaCautata,'1') 
	plt.imshow(A[:,pozitia].reshape(112,92), cmap='gray', vmin=0, vmax=255)
	plt.show()



root = Tk()

a = IntVar()
b = IntVar()
c = IntVar()

root.title("M3")
root.geometry("400x600")

lblInfo1 = Label(root, text="Configurare bază de date ", fg='darkred',  font=('Helvetica', 12, 'bold' ) )
lblInfo1.place(relx=0.7, x=-270, y=50)
btn1=Radiobutton(root, text="60% training", variable=a, value=1)
btn1.place(relx=0.7, x=-270, y=80) 
btn2=Radiobutton(root, text="80% training", variable=a, value=2) 
btn2.place(relx=0.7, x=-270, y=100) 
btn3=Radiobutton(root, text="90% training", variable=a, value=3) 
btn3.place(relx=0.7, x=-270, y=120) 

lblInfo1 = Label(root, text="Algoritm: ", fg='darkred',  font=('Helvetica', 12, 'bold' ) )
lblInfo1.place(relx=0.7, x=-270, y=160)
btn4=Radiobutton(root, text="NN",command=nn ,variable=b , value=4)
btn4.place(relx=0.7, x=-270, y=190)  
btn5=Radiobutton(root, text="kNN        Pentru kNN, k = ", variable=b, value=5) 
btn5.place(relx=0.7, x=-270, y=210)

optionkNN = [
    "3",
    "5",
    "7",
    "9"
]
btnbox1=Combobox(root, value=optionkNN, width=2)
btnbox1.place(relx=0.7, x= -110, y=210)

btn6=Radiobutton(root, text="Eigenfaces      Pentru algoritmii proiectivi, k = ", command = knn, variable=b, value=6) 
btn6.place(relx=0.7, x=-270, y=230) 

optionEigenfaces = [
    "20",
    "40",
    "60",
    "80",
    "100"
]
btnbox2=Combobox(root, value=optionEigenfaces, width=3)
btnbox2.place(relx=0.7, x= -3, y=232)

btn7=Radiobutton(root, text="Eigenfaces cu reprezentanti de clasa", command = preprocEigenfaces, variable=b, value=7) 
btn7.place(relx=0.7, x= -270, y=250) 
btn8=Radiobutton(root, text="Lanczos", variable=b, value=8) 
btn8.place(relx=0.7, x= -270, y=270) 
btn9=Radiobutton(root, text="Tensori", variable=b, value=9) 
btn9.place(relx=0.7, x= -270, y=290) 

lblInfo1 = Label(root, text="Norma: ", fg='darkred', font=('Helvetica', 12, 'bold') )
lblInfo1.place(relx=0.7, x= -270, y=320)
btn10=Radiobutton(root, text="norma 1 (Manhattan)", command= norma_dif, variable=c, value=1) 
btn10.place(relx=0.7, x= -270, y=350) 
btn11=Radiobutton(root, text="norma 2 (Euclidian)", command= norma_dif, variable=c, value=2) 
btn11.place(relx=0.7, x= -270, y=370) 
btn12=Radiobutton(root, text="norma infinit (INF)", command= norma_dif, variable=c, value=3) 
btn12.place(relx=0.7, x= -270, y=390) 
btn13=Radiobutton(root, text="norma cosinus (COS)", command= norma_dif, variable=c, value=4) 
btn13.place(relx=0.7, x= -270, y=410) 

btn14=Button(root, text="Caută", command =cautare ,width=16, fg='white', bg='darkred')
btn14.place(relx=0.7, x= -150, y=500) 



cv.waitKey(0)
cv.destroyAllWindows()
root.mainloop()


