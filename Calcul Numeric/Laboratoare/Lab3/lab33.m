hold on
y1=-x.^3+2*x.^2
y2=abs(y1)
y3=sqrt(y2)
y4=log(.1+x)./log(3)
y5=2.^x
y6=sin(2*x-.73)
subplot(2,3,1)
plot(x,y1)
subplot(2,3,2)
plot(x,y2)
subplot(2,3,3)
plot(x ,y3)
subplot(2,3,4)
plot(x ,y4)
subplot(2,3,5)
plot(x ,y5)
subplot(2,3,6)
plot(x ,y6)