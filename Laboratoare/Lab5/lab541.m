%var1
f=[1 -6.1 3.2 1.5];
x=4.71;
s=0;
for i=1:length(f)
    s=s+f(i)*x^(length(f)-i) 
end

%var2
%f=[1 -6.1 3.2 1.5];
%x=4.71;
%v=[x^3 x^2 x 1];
%val=f*v'

%var3
x=4.71;
horn=(((x-6.1)*x)+3.2)*x+1.5

%var4
f=[1 -6.1 3.2 1.5];
x=4.71;
built_in=polyval(f,x)

%impartire f la g
g=[1 1 1];
[cat rest]=deconv(f,g)

