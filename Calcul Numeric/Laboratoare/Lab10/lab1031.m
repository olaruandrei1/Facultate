timp=[0 15];
cond_initiale=[0;0;0;25];
[t,x]=ode45('insulina',timp,cond_initiale)

subplot(2,2,1)
plot(t,x(:,1))
title('Concentratia de insulina din sange')

subplot(2,2,2)
plot(t,x(:,2))
title('Concentratia de insulina din rinichi')

subplot(2,2,3)
plot(t,x(:,3))
title('Concentratia de insulina din pancreas')

subplot(2,2,4)
plot(t,x(:,4))
title('Concentratia de insulina din abdomen')

figure(2)

plot(t,x(:,1))
title('Concentratia de insulina din sange') 