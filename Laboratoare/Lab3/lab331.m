hold on
y1=-x.^3+2*x.^2
y2=abs(y1)
y3=sqrt(y2)
y4=log(.1+x)./log(3)
y5=2.^x
y6=sin(2*x-.73)
plot(x,y1)
figure
plot(x,y2)
figure
plot(x ,y3)
figure
plot(x ,y4)
figure
plot(x ,y5)
figure
plot(x ,y6)