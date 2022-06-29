z=[0:pi/50:10*pi]
x=exp(-.2.*z).*cos(z);
y=exp(-.2.*z).*sin(z);
plot3(x,y,z);
grid on
xlabel('axa x');
ylabel('axa y');
zlabel('axa z');
title('Ceva mai complicat')