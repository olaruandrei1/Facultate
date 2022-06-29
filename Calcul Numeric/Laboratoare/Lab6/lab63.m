function rad=bisectie1(a,b,err)
  fa=f(a);
  fb=f(b);
  if (sign(fa)==sign(fb)) 
    error('Nu exista radacina in intervalul considerat');
  end
  while (abs(fa)>err & abs(fb)>err)
    x=(a+b)/2;
    fx=f(x);
    if(sign(fa)==sign(fx))
    %noul interval va fi [x,b]
    a=x;
    fa=fx;
  else
    %noul interval va fi [a,x]
    b=x;
    fb=fx;
  end
end
if (abs(fa)<=err)
  %fa este mai aproape de 0, deci radacina este a
  rad=a   
else% fb este mai aproape de 0, deci radacina este b
  rad=b
  end
end
end
