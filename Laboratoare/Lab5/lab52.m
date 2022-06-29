x=5/7
u=0.714251  
v=98765.9
w=0.1111111*10-4
flx=0.71428
flu=0.71425
flv=0.98765*10^5
flw=0.111111*10^-4
sprintf('Operatie   Rezultat   Val. exacta   Er. abs.   Er. rel')
sprintf(' -   %10.10f   %10.10f   %10.10f   %10.10f ', flx-flu, x-u, abs(x-u-(flx-flu)), abs(x-u-(flx-flu))/abs(x-u))