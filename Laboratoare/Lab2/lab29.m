x=[-10:.1:10];
y=[-10:.1:10];
[X,Y]=meshgrid(x,y);
z=X.^2+Y.^2;
mesh(X,Y,z)
##surf(z)
##contour (z)