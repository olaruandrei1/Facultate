function rezultat = metodaTangentei_eroare(f, a, b, eroare, axe)
hold on
f = sym(f);
y = diff(f,1);
d = y;
if y == 0
    rezultat = 'Nu exista solutie';
    return;
end
y = diff(f,2);
if y == 0
    rezultat = 'Nu exista solutie';
    return;
end
f = inline(f);
d = inline(d);
if(f(a)*f(b) >= 0 )
    rezultat = 'Nu exista solutie';
else
    if(f(a)*d(a) ~= 0)
        r = a;
    else
        r = b;
    end
    plot(r, f(r), 'r*')
    hold on
    while(abs(f(r)) > eroare)
        r = r - f(r)/d(r);
        plot(r, f(r), 'r*')
        hold on
    end
    rezultat = r
end
