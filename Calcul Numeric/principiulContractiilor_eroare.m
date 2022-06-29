\function rezultat = principiulContractiilor_eroare(f, a, b, eroare, axe)
hold on
f = inline(f);
if(f(a)*f(b) > 0)
    disp('Nu s-a gasit radacina')
    rezultat = 'nu exista solutie'
    return;
elseif(abs(f(a)) <= eroare)
    rezultat = a;
elseif(abs(f(b)) <= eroare)
    rezultat = b;
else
    if(f(a) ~= 0)
        r = a;
    else
        r = b;
    end
    plot(r, f(r), 'r*')
    hold on
    err = 3;
    while(err > eroare)
        xi = r;
        r = f(r);
        err = abs(r - xi);
        plot(r, f(r), 'r*')
        hold on
    end
    rezultat = r
end
