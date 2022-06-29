function rezultat = metodaBisectiei_eroare(f, a, b, eroare, axe)
hold on
if(f(a)*f(b) > 0)
    disp('Nu s-a gasit radacina')
    rezultat = 'nu exista solutie'
    return;
elseif(abs(f(a)) <= eroare)
    rezultat = a;
elseif(abs(f(b)) <= eroare)
    rezultat = b;
else
    x = (a + b) / 2;
    plot(x,f(x),'r*')
    if(f(a)*f(x) < 0)
        rezultat = metodaBisectiei_eroare(f, a, x, eroare, axe);
    elseif(f(x)*f(b) < 0)
        rezultat = metodaBisectiei_eroare(f, x, b, eroare, axe);
    end
end
