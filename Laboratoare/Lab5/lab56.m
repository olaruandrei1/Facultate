e=exp(1)
erRel=1;
s=1;
i=1;
t=1;
while erRel>10^(-15)
    t=t/i;
    s=s+t;
    erRel=abs(s-e)/abs(e);
    i=i+1; 
end
i