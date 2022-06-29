% acest script ilustreaza faptul ca polinoamele de interpolare nu au neaparat si
% proprietatea de aproximare
% Ploteaza functia 1/(1 + x^2) si polinoamele sale de interpolare de grad
% n-1.
m = input('Introduceti numarul de polinoame de interpolare');
for k=1:m
n = input('Introduceti gradul fiecarui polinom de interpolare ');
hold on
x = linspace(-5,5,n);
y = 1./(1 + x.*x);
z = linspace(-5.5,5.5);
t = 1./(1 + z.^2);
h1_line = plot(z,t,'-.');
set(h1_line, 'LineWidth',1.25)
t = polNewton(x,y,z);
h2_line = plot(z,t,'r');
set(h2_line,'LineWidth',1.3,'Color',[0 0 0])
axis([-5.5 5.5 -.5 1])
title(sprintf('Exemplu de divergenta (n = %2.0f)',n))
xlabel('x')
ylabel('y')
legend('y = 1/(1+x^2)','interpolant')
hold off
end 