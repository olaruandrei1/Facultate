function derivate=insulina(t,x)
kin=2;
k12=1;
k21=1.5;
k13=2;
k31=1.75

% scriem ecuatiile pentru vitezele de transfer ale insulinei; dx/dt va fi
% diferenta dintre fluxul care intra si fluxul care iese din
% compartimentul respectiv; fluxul este produsul dintre viteza de transfer k si
% concentratia x(i)

% ecuatia curgerii pentru insulina din sange
derivate(1)=kin*x(4)+k31*x(3)+k21*x(2)-k13*x(1)-k12*x(1);

% ecuatia curgerii pentru insulina din rinichi
derivate(2)=k12*x(1)-k21*x(2);

% ecuatia curgerii pentru insulina din pancreas
derivate(3)=k13*x(1)-k31*x(3);

% ecuatia curgerii pentru insulina din abdomen
derivate(4)=-kin*x(4);

derivate=[derivate(1);derivate(2);derivate(3);derivate(4)] 