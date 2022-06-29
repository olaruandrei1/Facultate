function rezultat = metodaCoardei_eroare(f, a, b, eroare, axe)
hold on
f = sym(f);
y = diff(f,1);
if y == 0
    rezultat = 'Nu exista solutie';
end
y = diff(f,2);
if y == 0
    rezultat = 'Nu exista solutie';
end
f = inline(f);
y = inline(y);
if(f(a)*f(b) >= 0 || f(a)*y(a) == 0)
    rezultat = 'Nu exista solutie';
else
    if(f(a)*y(a) < 0)
        r = a;
        plot(r, f(r), 'r*')
        hold on
        while(abs(f(r)) > eroare)
            r = r - f(r)/(f(r)-f(b)) * (r - b);
            plot(r, f(r), 'r*')
            hold on
        end
        rezultat = r
    else
        r = b;
        plot(r, f(r), 'r*')
        hold on
        while(abs(f(r)) > eroare)
            r = r - f(r)/(f(r)-f(a)) * (r - a);
            plot(r, f(r), 'r*')
            hold on
        end
        rezultat = r
    end
end
