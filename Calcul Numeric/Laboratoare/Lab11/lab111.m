%prin acest script se rezolva un sistem cu matricea tridiagonala prin EG fara
% pivotari
% de remarcat ca pentru n mai mare sau egal cu 60 erorile de calcul sunt
% inacceptabile
clear all
n=input('Introduceti dimensiunea sistemului\n')
%n=input(' ')
for i=1:n
  b(i)=15;
end
b(1)=7;
b(n)=14;
b=b'
a=8*diag(ones(n-1,1),-1)+6*diag(ones(1,n))+diag(ones(1,n-1),1);
a
x_ex=ones(n,1);
x_exx=zeros(n,1);
% se executa pasii de EG
for i=1:n-1
  m=a(i+1,i)/a(i,i);
  b(i+1)=b(i+1)-m*b(i);
  % in acest caz, doar pe linia i+1 trebuie sa anulam pozitia desub
  % pivot; restul sunt deja 0
  a(i+1,i:i+1)=a(i+1,i:i+1)-m*a(i,i:i+1);
end
% se rezolva sistemul prin substitutie inapoi; (ultima) matrice are doar
% diagonala principala si diagonala de deasupra diagonalei principale
% nenule; restul elementelorsunt 0
x(n)=b(n)/a(n,n);
for i=n-1:-1:1
  x(i)=(b(i)-a(i,i+1)*x(i+1))/a(i,i);
end
format long
x
%x=x'
m=size(x);
k=size(x_ex);
% eroarea in norma euclidiana (diferenta dintre solutia exacta x_ex si cea calculata
% cu EG clasic) este:
eroare=norm(x-x_ex)
 