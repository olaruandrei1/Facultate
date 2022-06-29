% acest script rezolva un sistem cu matricea tridiagonala prin EG cu
% pivotare partiala
% de remarcat ca pentru n mai mare sau egal cu 110 erorile de calcul sunt
% inacceptabile
sym n;
n=input('Introduceti dimensiunea sistemului\n')
%n=input(' ')
for i=1:n
  b(i)=15;
end
b(1)=7;
b(n)=14;
b=b'a=8*diag(ones(n-1,1),-1)+6*diag(ones(1,n))+diag(ones(1,n-1),1);
a
x_ex=ones(n,1);
x_ex
x=zeros(n,1);
%incepem EG cu pivotare partiala
% ipiv va reprezenta indicele de linie pentru (eventualul) nou pivot
aux=zeros(n,1);
 bux=0;
 for i=1:n-1
   piv=abs(a(i,i));
   ipiv=i;
   %piv=max(abs(a(i+1:n,i)));
   for j=i+1:n
     if abs(a(j,i))>piv
       piv=abs(a(j,i))
       ipiv=j;
     end
   end
   %permutam liniile i si ipiv daca este cazul (inclusiv pozitiile
   %corespunzatoare din termenul liber)
   if i~=ipiv
     aux=a(i,:);
     a(i,:)=a(ipiv,:);
     a(ipiv,:)=aux;
     bux=b(i);
     b(i)=b(ipiv);
     b(ipiv)=bux;
   end
   % aplicam pasul de EG
   m=a(i+1,i)/a(i,i);
   b(i+1)=b(i+1)-m*b(i);
   a(i+1,i:n)=a(i+1,i:n)-m*a(i,i:n);
 end
 a
 b
 % se rezolva sistemul prin substitutie inapoi
 x(n)=b(n)/a(n,n);
 for i=n-1:-1:1
   s=0;
   for j=i+1:n
     s=s+a(i,j)*x(j);
     endx(i)=(b(i)-s)/a(i,i);
   end
   format long
   x
   %x=x'
   m=size(x);
   k=size(x_ex);
   eroare=norm(x-x_ex)
