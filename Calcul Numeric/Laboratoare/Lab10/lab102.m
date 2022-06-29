function yprim=ecdif2(t,y)
  yprim=zeros(2,1);
  % notam cu Y1=y si cu Y2=Y1'=y'
  % atunci Y'=(Y1',Y2')=(Y2,y'')=(Y2,-y)=(Y2,-Y1)
  ydm=y(2);
  yprim(1)=ydm;
  yprim(2)=-y(1);