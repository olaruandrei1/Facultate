function m=ProblemaA(nIn,mIn)
  %m=ProblemaA(nIn, mIn); 
  %nIn: valoarea lui n pentru primul cadru al filmului
  %mIn: valoarea lui n pentru ultimul cadru al filmului
  %m  : norma diferentei dintre solutia exacta si cea aproximativa (pentru ultimul cadru al filmului)
  
  % pentru Octave, rulati: pkg load symbolicfor 
  
 for i=nIn:mIn
  n=i;
    h=1/(n+1);
    xi=0:h:1;
    A=diag(ones(n,1).*(2+h^2)) + diag(ones(n-1,1).*(h-1),1) + diag(ones(n-1,1).*(-1-h),-1);
    b=h^2 .* (ones(n,1) .* (-(xi(2:n+1)'.^3 )-3 .* xi(2:n+1)' + 4));
    v=inv(A)*b;
  
    syms x;v1 = subs('x*(1-x)',x,xi(2:n+1));
    norma = norm(v'-v1,inf);
    fprintf('norma=%f\n',double(norma)); 
  % conversia la double a fost necesara pentru ca fprintf nu accepta argumente simbolice
      fprintf('i        xi         Uex(i)        wi         ||Uex(i) -wi||\n'); 
      for k=1:n
        fprintf('%d  %f   %f       %f             %f\n', k, xi(k+1), double(v1(k)), v(k), double(norm(v(k)-double(v1(k)),inf))); 
    % acelasi comentariu legat de necesitatea conversiei la double
    end
    plotHandle = plot(xi(2:n+1), v,'-r');
    set(plotHandle,'LineWidth',1.5);
    
    h=get(gca,'title');
    set(h,'Fontsize',12)
    xlabel('Axa x');
    ylabel('Axa y');
    
    hold on;
    plot(xi(2:n+1),double(v1));
    hold off;
    movie1(:,i-nIn+1) = getframe;
    
    m=A*double(v1)'-b;
    m=A*v-b;
    m=norm(double(v1)-v',inf);
    
  pause(0.1);
end
if (mIn-nIn>0)
  movie(movie1,2); % ruleaza film de 2 oriend
end
