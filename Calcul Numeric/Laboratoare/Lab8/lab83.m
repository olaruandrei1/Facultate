% acest script interpoleaza liniar pe domeniul [-1,1]^2 o functie de 2
% variabile reale
[x, y] = meshgrid(-1:.25:1);
z = sin(x.^2 + y.^2);
[xi, yi] = meshgrid(-1:.05:1);
zi = interp2(x, y, z, xi, yi, 'linear');
surf(xi, yi, zi), title('Interpolare biliniara pentru functia sin(x^2 + y^2)') 