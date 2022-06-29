import matplotlib.pyplot as plt
import numpy as np
import cv2
from numpy import linalg as la
from sklearn.decomposition import TruncatedSVD

nrPixeli = 10304
nrPersoane = 10
nrPozeAntrenare = 5
nrTotalPozeAntrenare = nrPersoane * nrPozeAntrenare
k = 0
A = np.zeros([nrPixeli, nrTotalPozeAntrenare])
caleBDpoza_cautata = r'C:\Users\olaru\Desktop\Facultate\Restante\ACS\m0Poze'
poza_cautata = np.array(cv2.imread(caleBDpoza_cautata, 0))
plt.imshow(poza_cautata.reshape(112, 92), cmap='gray')
plt.show()
pozaCautataVector = poza_cautata.reshape(nrPixeli, )
# print(pozaCautataVector)

caleBD = r'C:\Users\olaru\Desktop\Facultate\Restante\ACS\m0Poze'

for i in range(1, nrPersoane + 1):  # Popularea matricii de antrenare
    caleFolderPers = caleBD + '\s' + str(i) + '\\'
    for j in range(1, nrPozeAntrenare + 1):
        calePozaAntrenare = caleFolderPers + str(j) + '.pgm'
        pozaAntrenare = np.array(cv2.imread(calePozaAntrenare, 0))
        pozaVect = pozaAntrenare.reshape(nrPixeli, )
        A[:, k] = pozaVect
        k += 1

media = np.mean(A, axis=1) #calculam poza medie pe axa orizontala

print(media)
poz = np.reshape(media,(112, 92))
plt.imshow(poz, cmap='gray')
plt.show()


B = A
A = (A.T - media).T

# L = np.dot(A.T, A) # calculul pnt matricea de covarianta a pix
# d, v = np.linalg.eig(L)
# v = np.dot(A, v)

# vsorted = np.argsort(d)
# k = input("Introduceti k:")

# while k not in ['20', '40', '60', '80', '100']:
#     k = input("Alegeti una din valorile urmatoare: 20, 40, 60, 80, 100")
# else:
#     k = int(k)

# vsorted = vsorted[-1:-k - 1:-1]
# HQPB = np.zeros([nrPixeli, k])
# for n in range(0, k):
#     HQPB[:, n] = v[:, vsorted[n]] 

#     #proiectam pozele din A pe HQPB
# proiectii = np.dot(A.T, HQPB)
# A = B
# pozacautata = pozaCautataVector - media #centram poza cautata in jurul mediei
# proiectie_cautata = np.dot(pozacautata, HQPB)
#------------------------------------------------------------adaugat pentru Tehnici de Optimizare: Tema 2---------------------------------------------------------
svd = TruncatedSVD(20)
A_transf = svd.fit_transform(A.T)
s = svd.singular_values
S = np.diag(s)
VT = svd.components_S
print(VT.T)
print(A_transf)
#-----------------------------------------------------------Sfasitul pentru Tehnici de Optimizare: Tema 2---------------------------------------------------------

# def NN(A, poza_cautata, norma):
#     z = np.zeros(([1, len(A[0])]), dtype=float)

#     for i in range(0, len(A[0])):

#         if norma == '1':
#             diferenta = poza_cautata - A[:, i]
#             z[0, i] = la.norm(diferenta, 1)
#         elif norma == '2':
#             diferenta = poza_cautata - A[:, i]
#             z[0, i] = la.norm(diferenta, 2)
#         elif norma == 'infinit':
#             diferenta = poza_cautata - A[:, i]
#             z[0, i] = la.norm(diferenta, np.inf)
#         elif norma == 'cosinus':
#             numarator = np.dot(poza_cautata, A[:, i])
#             numitor = la.norm(poza_cautata) * la.norm(A[:, i])
#             z[0, i] = (1 - numarator) / numitor
#         else:
#             exit()

#     imagine = B[:, np.argmin(z)]
#     print(imagine)
#     poza = np.reshape(imagine, (112, 92))
#     plt.imshow(poza, cmap='gray')
#     plt.show()


# if __name__ == "__main__":
#     norma = input("Alegeti una din urm norme: 1, 2, infinit, cosinus")
#     while norma not in ['1', '2', 'infinit', 'cosinus']:
#         norma = input("Va rog sa alegeti una din urm norme: 1, 2, infinit, cosinus")
#     else:
#         NN(proiectii.T, proiectie_cautata, norma)
