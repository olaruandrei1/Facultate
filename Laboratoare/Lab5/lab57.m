s=1;
t=1;
for i=1:9
    t=t/i;
    s=s+t;
end

s1=1;
t=1;
fr=sqrt(5)-floor(sqrt(5));
for i=1:9
    t=t*fr/i; 
    s1=s1+t;
end

aprox=s^floor(sqrt(5))*s1
valExacta=exp(sqrt(5))