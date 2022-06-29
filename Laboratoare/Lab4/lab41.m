screen_size = get(0,'ScreenSize')
pozitia_fig1 = [10, 2/3*screen_size(4) + 10,screen_size(3)/2 -2*10, screen_size(4)/3 -(60+10)];
pozitia_fig2 = [pozitia_fig1(1) + screen_size(3)/2, pozitia_fig1(2),pozitia_fig1(3), pozitia_fig1(4)];
h1 = figure(1);
peaks;
h2 = figure(2);
peaks(20);
set(h1, 'Position', pozitia_fig1)
set(h2, 'Position', pozitia_fig2)