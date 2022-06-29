

f=inline('x.^2.*sin(x)','x');
a = 0;
b = 1;
x=a:.1:b;
plot(x,f(x),'cs');
title('Functia de aproximat')
hold on;

for n=1:20
   bernstein = zeros(1,length(x));
        for k=0:n
            bernstein = bernstein+f(k/n).*nchoosek(n,k).*(x.^k).*((1-x).^(n-k));
        end
    plot(x,bernstein,'k-');
    title(['Polinomul Bernstein de ordin',num2str(n)])
    m(:,n)=getframe; 
    pause(.5);
end