function lab51()
  figure
  uicontrol('style','text','string','sin','units','normalized','position',[.1 .6 .1 .1])
  uicontrol('style','edit','tag','introducere','units','normalized','position',[.2 .6 .1 .1])
  uicontrol('tag','calculeaza','string','=','units','normalized','position',[.3 .6 .1 .1],'callback',@oneandonly)
  uicontrol('style','edit','tag','afisare','units','normalized','position',[.4 .6 .1 .1])
  uicontrol('tag','sterge','string','Reset','units','normalized','position',[.25 .4 .1 .1],'callback',@oneandonly) 
endfunction
function oneandonly(hObject,eventdata)
  switch(gcbo)
  case guihandles.calculeaza
    set(guihandles.afisare,'string',rezultat())
    %calculeaza_callback(hObject,eventdata)
  case guihandles.sterge
    set(guihandles.introducere,'string','')
    set(guihandles.afisare,'string','')
    %sterge_callback(hObject,eventdata)
  endswitch
endfunction

function b=rezultat()
  a=get(guihandles.introducere,'string')
  aa=str2num(a)
  bb=sin(aa)
  b=num2str(bb)
endfunction