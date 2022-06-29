x=[3:.05:10];
plot(x,exp(x));
grid on
hold on
plot(x,exp(.9.*x),'r');
plot(x,exp(1.1.*x),'b');
plot(x,exp(.8.*x),'g');
plot(x,exp(.7.*x),'y');
plot(x,exp(1.2.*x),'k');
xlabel('Axa Ox');
ylabel('Axa Oy');
title('Comparatii intre functii exponentiale')