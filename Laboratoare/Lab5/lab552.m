e=exp(1);
tic
s=1;
t=1;
for i=1:9
    t=t/i;
    s=s+t;
end
timp=toc 
errabs=abs(e-s)
errrel=abs(e-s)/abs(e)