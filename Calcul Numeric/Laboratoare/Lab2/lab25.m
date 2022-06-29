x=[-10:.05:10];
linie=5.*x;
parabola=x.^2;
expon=exp(x);
modul=abs(x);
subplot(2,2,1);
plot(x,line);
title('aceasta este o linie');
subplot(2,2,2);
plot(x,parabola);
title('aceasta este o parabola');
subplot(2,2,3);
plot(x,expon);
title('aceasta este o exponentiala');
subplot(2,2,4);
plot(x,modul);
title('aceasta este un modul')