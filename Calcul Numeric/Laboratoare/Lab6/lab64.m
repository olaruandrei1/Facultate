disp('Introduceti numarul de iteratii: ')
n=input(' ')
disp('Introduceti functia dorita: ')
%ce se introduce de la tastatura se memoreaza in variabila s
s=input(' ','s')
%continutul variabilei s este considerat ca definitie pentru
%functia  inline f care depinde de x
f=inline(s,'x')