function [yi,c]=polNewton(x,y,xi)
% Primul parametru de iesire este yi care reprezinta vectorul valorilor polinomului de interpolare
% in punctele xi (valori calculate cu schema lui Horner)
% Setul de date este memorat in vectorii x, respectiv y
% al doilea parametru de iesire c reprezinta vectorul coeficientilor
% polinomului Newton.
c = difdivizate(x,y);
% se aplica schema lui Horner (sau puteti folosi functia buil-in polyval, dar se schimba implementarea)
n = length(c);
val = c(n);
for j = n-1:-1:1 
val = (xi - x(j)).*val + c(j);
end
yi = val(:);