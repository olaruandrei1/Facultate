% acest script realizeaza interpolare cu functia predefinita interp1
% datele noastre sunt:
x = 0:pi/10:2*pi;
y = sin(2.*x);
% inchidem toate ferestrele grafice anterioare
close all;
xi = 0:pi/100:2*pi;
yi = interp1(x, y, xi, 'nearest');
plot(x, y, 'yo', xi, yi,'r'), title('Interpolare cu functia predefinita interp1 de tip nearest') 