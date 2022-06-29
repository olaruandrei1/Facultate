x=1:.01:3;
y=exp(x);
x2=0:pi
y2=sin(x2)
y3=cos(x2)
plot(x,y)
hold on
plot(x2,y2)
plot(x2,y3)
##plot(x,y,x2,y2,x2,y3)
legend('exponentiala','sinus','cosinus')
