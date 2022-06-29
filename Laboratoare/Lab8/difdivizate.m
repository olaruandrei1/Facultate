function c = difdivizate(x,y)
% calculeaza diferentele divizate folosind vectorii x si y
n = length(x);
% pentru fiecare i se calculeaza diferenta divizata de ordin i
for i=1:n-2
y(i+1:n) = (y(i+1:n) - y(i))./(x(i+1:n) - x(i));
end
c = y(:); 