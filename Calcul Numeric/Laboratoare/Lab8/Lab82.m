% acest script compara diverse interpolari cu functia predefinita interp1
% datele noastre sunt:
x = 0:pi/10:2*pi;
y = sin(2.*x);
% inchidem toate ferestrele grafice anterioare
close all;
xi = 0:pi/100:2*pi;
yi = interp1(x, y, xi, 'nearest');
plot(x, y, 'yo', xi, yi,'r'), title('Diverse tipuri de interpolare cu functii predefinite')
hold on
yi = interp1(x, y, xi, 'cubic');
plot(xi, yi,'g')
yi = interp1(x, y, xi, 'spline');
plot(xi, yi,'b')
yi = interp1(x, y, xi, 'linear');
plot(xi, yi,'k')
% semnul "..." atentioneaza compilatorul ca instructiunea continua pe linia
% urmatoare
legend('datele noastre','interpolare de tip nearest',...
'interpolare cubica','interpolare spline','interpolare liniara') 