function rezultat = principiulContractiilor_iteratie(f, a, b, nr_iteratii, axe)
hold on
f = inline(f);
if(f(a)*f(b) > 0)
    disp('Nu s-a gasit radacina')
    rezultat = 'nu exista solutie'
    return;
else
    if(f(a) ~= 0)
        r = a;
    else
        r = b;
    end
    plot(r, f(r), 'r*')
    hold on
    for i = 1 : nr_iteratii
        if(f(r) == 0)
            disp(i)
            break
        end
        r = f(r);
        plot(r, f(r), 'r*')
        hold on
    end
    rezultat = r
end