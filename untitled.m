function varargout = untitled(varargin)
% UNTITLED MATLAB code for untitled.fig
%      UNTITLED, by itself, creates a new UNTITLED or raises the existing
%      singleton*.
%
%      H = UNTITLED returns the handle to a new UNTITLED or the handle to
%      the existing singleton*.
%
%      UNTITLED('CALLBACK',hObject,eventData,handles,...) calls the local
%      function named CALLBACK in UNTITLED.M with the given input arguments.
%
%      UNTITLED('Property','Value',...) creates a new UNTITLED or raises the
%      existing singleton*.  Starting from the left, property value pairs are
%      applied to the GUI before untitled_OpeningFcn gets called.  An
%      unrecognized property name or invalid value makes property application
%      stop.  All inputs are passed to untitled_OpeningFcn via varargin.
%
%      *See GUI Options on GUIDE's Tools menu.  Choose "GUI allows only one
%      instance to run (singleton)".
%
% See also: GUIDE, GUIDATA, GUIHANDLES

% Edit the above text to modify the response to help untitled

% Last Modified by GUIDE v2.5 09-Jun-2020 18:34:54

% Begin initialization code - DO NOT EDIT
gui_Singleton = 1;
gui_State = struct('gui_Name',       mfilename, ...
                   'gui_Singleton',  gui_Singleton, ...
                   'gui_OpeningFcn', @untitled_OpeningFcn, ...
                   'gui_OutputFcn',  @untitled_OutputFcn, ...
                   'gui_LayoutFcn',  [] , ...
                   'gui_Callback',   []);
if nargin && ischar(varargin{1})
    gui_State.gui_Callback = str2func(varargin{1});
end

if nargout
    [varargout{1:nargout}] = gui_mainfcn(gui_State, varargin{:});
else
    gui_mainfcn(gui_State, varargin{:});
end
% End initialization code - DO NOT EDIT


% --- Executes just before untitled is made visible.
function untitled_OpeningFcn(hObject, eventdata, handles, varargin)
% This function has no output args, see OutputFcn.
% hObject    handle to figure
% eventdata  reserved - to be defined in a future version of MATLAB
% handles    structure with handles and user data (see GUIDATA)
% varargin   command line arguments to untitled (see VARARGIN)

% Choose default command line output for untitled
handles.output = hObject;

% Update handles structure
guidata(hObject, handles);

% UIWAIT makes untitled wait for user response (see UIRESUME)
% uiwait(handles.figure1);


% --- Outputs from this function are returned to the command line.
function varargout = untitled_OutputFcn(hObject, eventdata, handles) 
% varargout  cell array for returning output args (see VARARGOUT);
% hObject    handle to figure
% eventdata  reserved - to be defined in a future version of MATLAB
% handles    structure with handles and user data (see GUIDATA)

% Get default command line output from handles structure
varargout{1} = handles.output;



function functie_Callback(hObject, eventdata, handles)
% hObject    handle to functie (see GCBO)
% eventdata  reserved - to be defined in a future version of MATLAB
% handles    structure with handles and user data (see GUIDATA)

% Hints: get(hObject,'String') returns contents of functie as text
%        str2double(get(hObject,'String')) returns contents of functie as a double


% --- Executes during object creation, after setting all properties.
function functie_CreateFcn(hObject, eventdata, handles)
% hObject    handle to functie (see GCBO)
% eventdata  reserved - to be defined in a future version of MATLAB
% handles    empty - handles not created until after all CreateFcns called

% Hint: edit controls usually have a white background on Windows.
%       See ISPC and COMPUTER.
if ispc && isequal(get(hObject,'BackgroundColor'), get(0,'defaultUicontrolBackgroundColor'))
    set(hObject,'BackgroundColor','white');
end



function intervalA_Callback(hObject, eventdata, handles)
% hObject    handle to intervalA (see GCBO)
% eventdata  reserved - to be defined in a future version of MATLAB
% handles    structure with handles and user data (see GUIDATA)

% Hints: get(hObject,'String') returns contents of intervalA as text
%        str2double(get(hObject,'String')) returns contents of intervalA as a double


% --- Executes during object creation, after setting all properties.
function intervalA_CreateFcn(hObject, eventdata, handles)
% hObject    handle to intervalA (see GCBO)
% eventdata  reserved - to be defined in a future version of MATLAB
% handles    empty - handles not created until after all CreateFcns called

% Hint: edit controls usually have a white background on Windows.
%       See ISPC and COMPUTER.
if ispc && isequal(get(hObject,'BackgroundColor'), get(0,'defaultUicontrolBackgroundColor'))
    set(hObject,'BackgroundColor','white');
end



function intervalB_Callback(hObject, eventdata, handles)
% hObject    handle to intervalB (see GCBO)
% eventdata  reserved - to be defined in a future version of MATLAB
% handles    structure with handles and user data (see GUIDATA)

% Hints: get(hObject,'String') returns contents of intervalB as text
%        str2double(get(hObject,'String')) returns contents of intervalB as a double


% --- Executes during object creation, after setting all properties.
function intervalB_CreateFcn(hObject, eventdata, handles)
% hObject    handle to intervalB (see GCBO)
% eventdata  reserved - to be defined in a future version of MATLAB
% handles    empty - handles not created until after all CreateFcns called

% Hint: edit controls usually have a white background on Windows.
%       See ISPC and COMPUTER.
if ispc && isequal(get(hObject,'BackgroundColor'), get(0,'defaultUicontrolBackgroundColor'))
    set(hObject,'BackgroundColor','white');
end


% --- Executes on button press in radiobutton1.
function radiobutton1_Callback(hObject, eventdata, handles)
% hObject    handle to radiobutton1 (see GCBO)
% eventdata  reserved - to be defined in a future version of MATLAB
% handles    structure with handles and user data (see GUIDATA)

% Hint: get(hObject,'Value') returns toggle state of radiobutton1


% --- Executes on button press in radiobutton2.
function radiobutton2_Callback(hObject, eventdata, handles)
% hObject    handle to radiobutton2 (see GCBO)
% eventdata  reserved - to be defined in a future version of MATLAB
% handles    structure with handles and user data (see GUIDATA)

% Hint: get(hObject,'Value') returns toggle state of radiobutton2



function decizie_Callback(hObject, eventdata, handles)
% hObject    handle to decizie (see GCBO)
% eventdata  reserved - to be defined in a future version of MATLAB
% handles    structure with handles and user data (see GUIDATA)

% Hints: get(hObject,'String') returns contents of decizie as text
%        str2double(get(hObject,'String')) returns contents of decizie as a double


% --- Executes during object creation, after setting all properties.
function decizie_CreateFcn(hObject, eventdata, handles)
% hObject    handle to decizie (see GCBO)
% eventdata  reserved - to be defined in a future version of MATLAB
% handles    empty - handles not created until after all CreateFcns called

% Hint: edit controls usually have a white background on Windows.
%       See ISPC and COMPUTER.
if ispc && isequal(get(hObject,'BackgroundColor'), get(0,'defaultUicontrolBackgroundColor'))
    set(hObject,'BackgroundColor','white');
end


% --- Executes on selection change in popupmenu2.
function popupmenu2_Callback(hObject, eventdata, handles)
% hObject    handle to popupmenu2 (see GCBO)
% eventdata  reserved - to be defined in a future version of MATLAB
% handles    structure with handles and user data (see GUIDATA)

% Hints: contents = cellstr(get(hObject,'String')) returns popupmenu2 contents as cell array
%        contents{get(hObject,'Value')} returns selected item from popupmenu2


% --- Executes during object creation, after setting all properties.
function popupmenu2_CreateFcn(hObject, eventdata, handles)
% hObject    handle to popupmenu2 (see GCBO)
% eventdata  reserved - to be defined in a future version of MATLAB
% handles    empty - handles not created until after all CreateFcns called

% Hint: popupmenu controls usually have a white background on Windows.
%       See ISPC and COMPUTER.
if ispc && isequal(get(hObject,'BackgroundColor'), get(0,'defaultUicontrolBackgroundColor'))
    set(hObject,'BackgroundColor','white');
end


% --- Executes on button press in sterge.
function sterge_Callback(hObject, eventdata, handles)
set(handles.edit6, 'String', '')
set(handles.text13, 'String', '')
set(handles.functie, 'String', '')
set(handles.intervalA, 'String', '')
set(handles.intervalB, 'String', '')
set(handles.decizie, 'String', '')
cla(handles.axe,'reset')
% hObject    handle to sterge (see GCBO)
% eventdata  reserved - to be defined in a future version of MATLAB
% handles    structure with handles and user data (see GUIDATA)


% --- Executes on button press in calculeaza.
function calculeaza_Callback(hObject, eventdata, handles)
s = get(handles.functie, 'String');
if isempty(s)
    msgbox('Introduceti o functie')
    return;
end
f = inline(s);
f = vectorize(f);
a = get(handles.intervalA, 'String');
if isempty(a)
    msgbox('Introduceti capatul a')
    return;
end
a = str2double(a);
if isnan(a)
    msgbox('Capatul a nu este un numar')
    return;
end
b = get(handles.intervalB, 'String');
if isempty(b)
    msgbox('Introduceti capatul b')
    return;
end
b = str2double(b);
if isnan(b)
    msgbox('Capatul b nu este un numar')
    return;
end
if b < a
    set(handles.intervalA, 'String', b)
    set(handles.intervalB, 'String', a)
    temp = a;
    a = b;
    b = temp;
end
x = a:0.1:b;
y = f(x);
metoda = get(handles.popupmenu2, 'Value');
decizie = get(handles.radiobutton1, 'Value');
iteratiiEroare = get(handles.decizie, 'String');
if isempty(iteratiiEroare)
    if decizie == 1
        msgbox('Introduceti eroarea')
        return;
    end
    if decizie == 0
        msgbox('Introduceti numarul de iteratii')
        return;
    end
end
iteratiiEroare = str2num(iteratiiEroare);
if isempty(iteratiiEroare)
    if decizie == 0
        msgbox('Introduceti un numar in campul de iteratii')
        return;
    end
    if decizie == 1
        msgbox('Introduceti un numar in campul de eroare')
        return;
    end
end
if decizie == 0 && (floor(iteratiiEroare) ~= iteratiiEroare || iteratiiEroare <= 0)
    msgbox('Introduceti un numar pozitiv si natural pentru numarul de iteratii')
    return;
end
if decizie == 1 && (iteratiiEroare >= 1 || iteratiiEroare < 0)
    msgbox('Introduceti un numar subunitar')
    return;
end
plot(handles.axe, x, y)
if decizie == 1
    if metoda == 1
        tic;
        rez = metodaBisectiei_eroare(f, a, b, iteratiiEroare, handles.axe);
        timp = toc;
        timp = num2str(timp);
        set(handles.edit6, 'String', timp);
        set(handles.text13, 'String', rez);
    elseif metoda == 2
        tic;
        rez = metodaCoardei_eroare(get(handles.functie, 'String'), a, b, iteratiiEroare, handles.axe);
        timp = toc;
        timp = num2str(timp);
        set(handles.edit6, 'String', timp);
        set(handles.text13, 'String', rez);
    elseif metoda == 3
        tic;
        rez = metodaTangentei_eroare(get(handles.functie, 'String'), a, b, iteratiiEroare, handles.axe);
        timp = toc;
        timp = num2str(timp);
        set(handles.edit6, 'String', timp);
        set(handles.text13, 'String', rez);
    else
        tic;
        rez = principiulContractiilor_eroare(get(handles.functie, 'String'), a, b, iteratiiEroare, handles.axe);
        timp = toc;
        timp = num2str(timp);
        set(handles.edit6, 'String', timp);
        set(handles.text13, 'String', rez);
    end
else
    if metoda == 1
        tic;
        rez = metodaBisectiei_iteratie(f, a, b, iteratiiEroare, handles.axe);
        timp = toc;
        timp = num2str(timp);
        set(handles.edit6, 'String', timp)
        set(handles.text13, 'String', rez)
    elseif metoda == 2
        tic;
        rez = metodaCoardei_iteratie(get(handles.functie, 'String'), a, b, iteratiiEroare, handles.axe);
        timp = toc;
        timp = num2str(timp);
        set(handles.edit6, 'String', timp)
        set(handles.text13, 'String', rez)
    elseif metoda == 3
        tic;
        rez = metodaTangentei_iteratie(get(handles.functie, 'String'), a, b, iteratiiEroare, handles.axe);
        timp = toc;
        timp = num2str(timp);
        set(handles.edit6, 'String', timp)
        set(handles.text13, 'String', rez)
    else
        tic;
        rez = principiulContractiilor_iteratie(get(handles.functie, 'String'), a, b, iteratiiEroare, handles.axe);
        timp = toc;
        timp = num2str(timp);
        set(handles.edit6, 'String', timp)
        set(handles.text13, 'String', rez)
    end
end

% hObject    handle to calculeaza (see GCBO)
% eventdata  reserved - to be defined in a future version of MATLAB
% handles    structure with handles and user data (see GUIDATA)


% --- Executes on button press in Fisier.
function Fisier_Callback(hObject, eventdata, handles)
fisier = fopen('Date.txt', 'r');
linie = fgetl(fisier);
set(handles.functie, 'String', linie);
linie = fgetl(fisier);
set(handles.intervalA, 'String', linie);
linie = fgetl(fisier);
set(handles.intervalB, 'String', linie);
linie = fgetl(fisier);
set(handles.decizie, 'String', linie);
fclose(fisier);




% hObject    handle to Fisier (see GCBO)
% eventdata  reserved - to be defined in a future version of MATLAB
% handles    structure with handles and user data (see GUIDATA)


% --- Executes during object creation, after setting all properties.
function edit6_CreateFcn(hObject, eventdata, handles)
% hObject    handle to edit6 (see GCBO)
% eventdata  reserved - to be defined in a future version of MATLAB
% handles    empty - handles not created until after all CreateFcns called
