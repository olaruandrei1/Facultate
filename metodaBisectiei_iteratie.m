function rezultat = metodaBisectiei_iteratie(f, a, b, nr_iteratii, axe)
disp(nr_iteratii)
hold on
if(f(a)*f(b) > 0)
    rezultat = 'Nu s-a gasit radacina'
elseif(f(a) == 0)
    rezultat = a;
elseif(f(b) == 0)
    rezultat = b;
elseif(nr_iteratii == 0)
    if(abs(f(a)) <= abs(f(b)))
        rezultat = a;
    else
        rezultat = b;
    end
else
    x = (a + b) / 2;
    plot(x, f(x),'r*')
    if(f(a)*f(x) < 0)
        rezultat = metodaBisectiei_iteratie(f, a, x, nr_iteratii-1, axe);
    elseif(f(x)*f(b) < 0)
        rezultat = metodaBisectiei_iteratie(f, x, b, nr_iteratii-1, axe);
    end
end