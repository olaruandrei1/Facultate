e=exp(1)
s=1;
for i=1:4
    s=s+1/factorial(i);
end
erAbs=abs(e-s)
erRel=erAbs/abs(e) 


tic
s=1;
for i=1:9
    s=s+1/factorial(i);
end
erAbs=abs(e-s)
erRel=erAbs/abs(e)
timp=toc


tic
s=1;
t=1;
for i=1:9
    t=t/i;
    s=s+t;
end
erAbs=abs(e-s)
erRel=erAbs/abs(e)
timp2=toc