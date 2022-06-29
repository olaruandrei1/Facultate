% m=moviein(7)% moviein nu mai este necesar dela MATLAB6.5
x=-pi/2:pi/100:pi/2;
for i=1:7
  h1_line=plot(x,tan(i*x))
  set(h1_line,'Linewidth',1.5,'Color','r')
  grid
  title('Functia tg ')
  h=get(gca,'title')
  set(h,'Fontsize',12)
  xlabel('Axa Ox')
  k=num2str(i)
  if i>1 s=strcat('tg(',k,'x)')
    else s='tg x'
  end
  ylabel(s)
  h=get(gca,'ylabel')
  set(h,'Fontsize',12)
  m(:,i)=getframe;
  pause(0.5)
end
movie(m)

