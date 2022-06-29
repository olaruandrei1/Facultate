import pandas as pd
import numpy as np
#import matplotlib.pyplot as plt
#from sklearn import linear_model, datasets
from sklearn.linear_model import LinearRegression
#from sklearn.metrics import mean_squared_error, r2_score
#from sklearn.preprocessing import PolynomialFeatures
from sklearn import metrics
from sklearn.model_selection import  train_test_split



dataset = pd.read_csv("bd_regresie_tema1.csv", usecols=['bodyfat', 'age', 'cest', 'hip', 'forearm'])
print(np.shape(dataset))
print(dataset.describe())
print(dataset.info)
#nr obs pnt sample size
m = len(dataset)
#atr/predictori/variabile independente:
t1 = np.array(dataset['bodyfat'])
t1 = t1.reshape(m,1)
t2 = np.array(dataset['age'])
t2 = t2.reshape(m,1)
t3 = np.array(dataset['cest'])
t3 = t3.reshape(m,1)
t4 = np.array(dataset['hip'])
t4 = t4.reshape(m,1)

b = np.array(dataset['forearm'])
b = b.reshape(m, 1)

A = np.ones((m,1))
A = np.hstack((A,t1))
A = np.hstack((A,t2))
A = np.hstack((A,t3))
A = np.hstack((A,t4))

A = A[:, 1:] #LinearRegression
X_train, X_test, y_train, y_test = train_test_split(A, b, shuffle=True, train_size=0.5)
model = LinearRegression().fit(X_train, y_train)
coefs = np.hstack((model.coef_[0,::-1], model.intercept_))
y_pred = model.predict(X_train)#date training; =X_train*coefs
y_pred2= model.predict(X_test)#date test; =X_test*coefs

#training sample size
m1 = len(X_train)
print(m1)
#test
m2 = len(X_test)
print(m2)
SSE=np.linalg.norm(y_test - y_pred2)**2
MAE=metrics.mean_absolute_error(y_test, y_pred2)
MAE2=np.linalg.norm(y_test-y_pred2,1)/m2
MSE=metrics.mean_squared_error(y_test, y_pred2)
MSE2=SSE/m2
print('MAE:' +str(MAE)+' MAE2:'+str(MAE2))
print('MSE:'+str(MSE)+' MSE2:'+str(MSE2))
RMSE =np.sqrt(MSE)
#scor de regresie/coeficient de determinare
r_sq=model.score(X_train, y_train)#R^2 training-
r_sq2=model.score(X_test, y_test)#R^2 test
print('r_sq:'+str(r_sq)+' r_sq2:'+str(r_sq2))


A = np.ones((m,1))
A = np.hstack((A, t1))
A = np.hstack((A, t2))
A = np.hstack((A, t3))
A = np.hstack((A, t4))
A = np.hstack((A, t1**2))
A = np.hstack((A, t1*t2))
A = np.hstack((A, t2**2))
A = np.hstack((A, t2*t3))
A = np.hstack((A, t3**2))
A = np.hstack((A, t3*t4))
A = np.hstack((A, t4**2))

A = A[:, 1:] #LinearRegression
X_train, X_test, y_train, y_test = train_test_split(A, b, shuffle=True, train_size=0.5)
model = LinearRegression().fit(X_train, y_train)
coefs = np.hstack((model.coef_[0,::-1], model.intercept_))
y_pred = model.predict(X_train)#date training; =X_train*coefs
y_pred2= model.predict(X_test)#date test; =X_test*coefs

#training sample size
m1 = len(X_train)
#print(m1)
#test
m2 = len(X_test)
#print(m2)
SSE=np.linalg.norm(y_test-y_pred2)**2
MAE=metrics.mean_absolute_error(y_test, y_pred2)
MAE2=np.linalg.norm(y_test-y_pred2,1)/m2
MSE=metrics.mean_squared_error(y_test, y_pred2)
MSE2=SSE/m2
print('MAE:' +str(MAE)+' MAE2:'+str(MAE2))
print('MSE:'+str(MSE)+' MSE2:'+str(MSE2))
RMSE =np.sqrt(MSE)
r_sq=model.score(X_train, y_train)#R^2 training
r_sq2=model.score(X_test, y_test)#R^2 test
print('r_sq:'+str(r_sq)+' r_sq2:'+str(r_sq2))

#Matrice polinomiala constructie
#A = np.ones((m,1))
#A = np.hstack((A, t1))
#A = np.hstack((A, t2))
#A = np.hstack((A, t3))
#A = np.hstack((A, t4))
#A = np.hstack((A, t1**2))
#A= np.hstack((A, t1*t2))
#A = np.hstack((A, t2**2))
#A= np.hstack((A, t2*t3))
#A = np.hstack((A, t3**2))
#A= np.hstack((A, t3*t4))
#A = np.hstack((A, t4**2))


#fig = plt.figure()
#ax = plt.axes(projection='3d')
#ax = plt.axes(projection='3d')
#ax.scatter3D(t1,t1, t2, t3, t4, b)
#t1_plt = np.linspace(np.min(t1), np.max(t1),50)
#t2_plt = np.linspace(np.min(t2), np.max(t2),50)
#t3_plt = np.linspace(np.min(t3), np.max(t3),50)
#t4_plt = np.linspace(np.min(t4), np.max(t4),50)
#X, Y = np.meshgrid(t1_plt, t2_plt, t3_plt, t4_plt)
#coefs = np.hstack((model.intercept_, model.coef_[0,:]))
#y_pred_plt = place(X, Y, coefs)
#ax.plot_surface(X, Y, y_pred_plt, rstride=1, cstride=1, cmap='viridis', edgecolor='none')
#ax.set_title('Regresie surface')
#ax.view_init(60, 35)#cota de 60 grade(pe plan x-y) si 35 grade azimuth
