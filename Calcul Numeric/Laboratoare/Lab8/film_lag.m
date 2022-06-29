
f=inline(input('Introduceti functia: ','s'),'x');
x=3:0.1:10;
a=x(1);
b=x(length(x));
plot(x,f(x),'cs');
title('Functia de interplol');
hold on;
lagrange=zeros(length(x),1);
for n=2:10
    step=(b-a)/(n-1);
    xi=a:step:b;
    yi=f(xi);
        for t=1:length(x)
        lagrange(t)=0;
        for j=1:n 
            numarator=1;
            numitor=1;
            for i=[1:j-1, j+1:n]
                numarator*(x(t)-xi(i));
                numitor*(xi(j)-xi(i));
            end
                lj=numarator/numitor;
                lagrange(t)=lagrange(t)+f(xi(j))*lj
        end 
    end 
    plot(xi,yi,'ro',x,lagrange,'k-');
    title(['Pol de inter de grad' num2str(n-1)]);
    m(:,n)=getframe;
    pause(.5);
        
end

                