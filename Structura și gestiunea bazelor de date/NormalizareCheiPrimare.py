from tkinter import Tk, messagebox
from tkinter import *

import psycopg2

from getpass import getpass
from psycopg2 import Error


window = Tk()


#Functia de refresh a ferestrei de vizualizare
def refresh(fereastra, nume_tabela):
    fereastra.destroy()
    vizualizare(nume_tabela)
    
    
    
#Functia de inchidere a aplicatiei si deconectare de la baza de date
def inchidere():
    try:
        conn.close()
    except:
        pass
    window.destroy()
        
    
#Functia care verifica daca cheia primara dintr-o tabela este normalizata
def verificare(parent_window, nume_tabela):
    lista_chei_primare = []
    
    comanda_afisare_coloane = "select column_name from information_schema.columns where table_schema = 'public' and table_name='" + nume_tabela + "';"
    #Realizam conexiunea
    conn = psycopg2.connect(
    host='127.0.0.1',
    user = 'postgres',
    password = 'leucoplast',
    database = 'bazadedatesgbd'
    )

    curr = conn.cursor()
    curr.execute(comanda_afisare_coloane)

    sql= "SELECT c.column_name, c.data_type FROM information_schema.table_constraints tc JOIN information_schema.constraint_column_usage AS ccu USING (constraint_schema, constraint_name)  JOIN information_schema.columns AS c ON c.table_schema = tc.constraint_schema AND tc.table_name = c.table_name AND ccu.column_name = c.column_name WHERE constraint_type = 'PRIMARY KEY' and tc.table_name = '" + nume_tabela + "';"
    curr.execute(sql)
    x = curr.fetchall()
    lista_chei_primare.append(x)
    
    if len(lista_chei_primare[0]) == 0:
        messagebox.showinfo(parent = parent_window, title = "Verificare " + nume_tabela, message = "Nu exista cheie primara")
     
    #Exista cheie primara pe o singura coloana care nu este numerica
    elif len(lista_chei_primare[0]) == 1 and lista_chei_primare[0][0][1] != 'integer':
        
        messagebox.showinfo(parent = parent_window, title = "Verificare " + nume_tabela, message = "Exista cheie primara pe o singura coloana care nu este numerica")
   
    #Exista cheie primara cu mai multe atribute (cel putin 2)
    elif len(lista_chei_primare[0]) > 1:
        #Folosim variabila "numerica" pentru a verifica daca toate atributele sunt numerice
        numerica = 0
        for cheie_primara in lista_chei_primare[0]:
            if(cheie_primara[1] ==  'integer'):
                numerica =numerica+1
                   
        if numerica == 0:
            messagebox.showinfo(parent = parent_window, title = "Verificare " + nume_tabela, message = "Nu exista chei primare numerice")
        elif numerica == 1:
            messagebox.showinfo(parent = parent_window, title = "Verificare " + nume_tabela, message = "Exista cheie primara numerica pe " + str(len(lista_chei_primare[0])) + " atribute, dar unul sau mai multe dintre acestea nu sunt numerice")
        else:
            messagebox.showinfo(parent = parent_window, title = "Verificare " + nume_tabela, message = "Exista cheie primara numerica pe " + str(len(lista_chei_primare[0])) + " atribute")
    
    else:
        messagebox.showinfo(parent = parent_window, title = "Verificare " + nume_tabela, message = "Cheia primara este normalizata")



#Functia care normalizeaza cheia primara a unei tabele
def normalizare(nume_tabela):
    #Realizam conexiunea
    conn = psycopg2.connect(
    host='127.0.0.1',
    user = 'postgres',
    password = 'leucoplast',
    database = 'bazadedatesgbd'
    )
    curr = conn.cursor()
    #Obtinem lista tabelelor in care se face referinta la cheia primara din tabela pe care o normalizam
    #curr.execute("SELECT TABLE_NAME FROM INFORMATION_SCHEMA.KEY_COLUMN_USAGE WHERE REFERENCED_TABLE_SCHEMA = 'bazadedatesgbd' AND REFERENCED_TABLE_NAME = '" + nume_tabela + "';")
    curr.execute("SELECT tc.table_schema, tc.constraint_name, tc.table_name, kcu.column_name, ccu.table_schema AS foreign_table_schema, ccu.table_name AS foreign_table_name, ccu.column_name AS foreign_column_name FROM  information_schema.table_constraints AS tc JOIN information_schema.key_column_usage AS kcu ON tc.constraint_name = kcu.constraint_name AND tc.table_schema = kcu.table_schema JOIN information_schema.constraint_column_usage AS ccu ON ccu.constraint_name = tc.constraint_name AND ccu.table_schema = tc.table_schema WHERE tc.constraint_type = 'FOREIGN KEY' AND tc.table_name= '" + nume_tabela + "';")
    lista_tabele = curr.fetchall()
    print(lista_tabele)
    lista_chei_primary = []
    cauta_k_primare= "SELECT c.column_name, c.data_type FROM information_schema.table_constraints tc JOIN information_schema.constraint_column_usage AS ccu USING (constraint_schema, constraint_name)  JOIN information_schema.columns AS c ON c.table_schema = tc.constraint_schema AND tc.table_name = c.table_name AND ccu.column_name = c.column_name WHERE constraint_type = 'PRIMARY KEY' and tc.table_name = '" + nume_tabela + "';"
    curr.execute(cauta_k_primare)
    k_primare = curr.fetchall()
    lista_chei_primary.append(k_primare)



    for tabela in lista_tabele:
        
        #Obtinem lista cheilor straine care fac referinta la tabela pe care lucram, pentru fiecare tabela
        curr.execute("SELECT column_name FROM information_schema.table_constraints JOIN information_schema.key_column_usage USING (constraint_catalog, constraint_schema, constraint_name, table_catalog, table_schema, table_name) WHERE constraint_type = 'FOREIGN KEY' AND (table_schema, table_name) = ('public', '" + nume_tabela + "') ORDER BY ordinal_position;")
        lista_chei_straine = curr.fetchall()
        
        
        #Pentru fiecare cheie straina trebuie sa ii eliminam constrangerea, sa eliminam coloana iar apoi sa adaugam noua coloana
        for cheie_straina in lista_chei_straine:
            try:
                curr.execute("ALTER TABLE " + tabela[2] + " DROP FOREIGN KEY " + cheie_straina[1] + ";")
            except:
                pass
            try:
                curr.execute("ALTER TABLE " + tabela[2] + " DROP " + cheie_straina[1] + ";")
            except:
                pass
        try:
            curr.execute("ALTER TABLE " + tabela[2] + " ADD COLUMN id_ceva_" + nume_tabela + " INTEGER;")
        except:
            pass
    
    cursor = conn.cursor()
    
    cursor.execute("ALTER TABLE "+ nume_tabela + " DROP CONSTRAINT " + nume_tabela + "_pkey CASCADE;")
    conn.commit()
    cursor.execute("ALTER TABLE " + nume_tabela + " ADD COLUMN id_coloana_" + nume_tabela + " SERIAL;")
    conn.commit()
    cursor.execute("ALTER TABLE " + nume_tabela + " ADD PRIMARY KEY (id_coloana_" + nume_tabela + ");")
    conn.commit()
    #Adaugam constrangerea de cheie straina la noile coloane adaugate mai devreme
    print(lista_tabele)
    for tabela in lista_tabele:
        curr.execute("ALTER TABLE " + tabela[2] + " ADD CONSTRAINT fk_coloana_" + tabela[3] + " FOREIGN KEY (" + tabela[3] +") REFERENCES "+ tabela[5] +"("+tabela[6]+");")
        conn.commit()

#Functia care se apeleaza atunci cand apasam butonul de normalizare
def buton_normalizare(parent_window, nume_tabela):
    #Realizam conexiunea
    conn = psycopg2.connect(
    host='127.0.0.1',
    user = 'postgres',
    password = 'leucoplast',
    database = 'bazadedatesgbd'
    )
    curr = conn.cursor()
    
    lista_chei_primare = []
    
    comanda_afisare_coloane = "select column_name from information_schema.columns where table_schema = 'public' and table_name='" + nume_tabela + "';" 
    curr.execute(comanda_afisare_coloane)
   
   
    caut_k_primare= "SELECT c.column_name, c.data_type FROM information_schema.table_constraints tc JOIN information_schema.constraint_column_usage AS ccu USING (constraint_schema, constraint_name)  JOIN information_schema.columns AS c ON c.table_schema = tc.constraint_schema AND tc.table_name = c.table_name AND ccu.column_name = c.column_name WHERE constraint_type = 'PRIMARY KEY' and tc.table_name = '" + nume_tabela + "';"
    curr.execute(caut_k_primare)
    kp = curr.fetchall()
    lista_chei_primare.append(kp)
            
    if len(lista_chei_primare[0]) == 0:
        messagebox.showinfo(parent = parent_window, title = "Normalizare " + nume_tabela, message = "Nu exista cheie primara, se adauga...")
        
        curr.execute("ALTER TABLE " + nume_tabela + " ADD COLUMN id_coloana_" + nume_tabela + " SERIAL")
        curr.execute("ALTER TABLE " + nume_tabela + " ADD PRIMARY KEY (id_coloana_" + nume_tabela + ");")
        conn.commit()
       
        refresh(parent_window, nume_tabela)
        
    elif len(lista_chei_primare[0]) == 1 and lista_chei_primare[0][0][1] != 'integer':
        messagebox.showinfo(parent = parent_window, title = "Normalizare " + nume_tabela, message = "Exista cheie primara pe o singura coloana care nu este numerica, se inlocuieste...")
        
        normalizare(nume_tabela)
        
        refresh(parent_window, nume_tabela)
        
    elif len(lista_chei_primare[0]) > 1: 
        #Folosim variabila "numerica" pentru a verifica daca toate atributele sunt numerice
        numerica = 0
        for cheie_primara in lista_chei_primare[0]:
            if(cheie_primara[1] ==  'integer'):
                numerica = numerica + 1
                
        if numerica == 0:
            messagebox.showinfo(parent = parent_window, title = "Normalizare " + nume_tabela, message = "Exista cheie primara numerica pe " + str(len(lista_chei_primare[0])) + " atribute, dar unul sau mai multe dintre acestea nu sunt numerice")
            
        else:
            messagebox.showinfo(parent = parent_window, title = "Normalizare " + nume_tabela, message = "Exista cheie primara numerica pe " + str(len(lista_chei_primare[0])) + " atribute, se inlocuieste")
           
            normalizare(nume_tabela)
            
            refresh(parent_window, nume_tabela)
            
    else:
        messagebox.showinfo(parent = parent_window, title = "Normalizare " + nume_tabela, message = "Cheia primara este deja normalizata")
        
  

#Functia de verificare pentru toate tabelele bazei de date      
def buton_verificare_completa(parent_window):
    #Obtinem numele tuturor tabelelor din baza de date
    curr.execute("Show tables;")  
    tables = curr.fetchall()
    
    for tabela in tables:
        verificare(parent_window, tabela[0])
    
    
    
#Functia de normalizare pentru toate tabelele bazei de date 
def buton_normalizare_completa(parent_window):
    #Obtinem numele tuturor tabelelor din baza de date
    curr.execute("Show tables;")  
    tables = curr.fetchall()
    
    for tabela in tables:
        nume_tabela = tabela[0]
        
        lista_chei_primare = []
    
        comanda_afisare_coloane = "SHOW columns FROM " + nume_tabela + ";"
            
        curr.execute(comanda_afisare_coloane)
        coloane_tabel = curr.fetchall()
                
    
        for coloana in coloane_tabel:
            if(coloana[3] == "PRI"):
                lista_chei_primare.append((coloana[0], coloana[1]))
                
        if len(lista_chei_primare) == 0:
            messagebox.showinfo(parent = parent_window, title = "Normalizare " + nume_tabela, message = "Nu exista cheie primara, se adauga...")
            
            curr.execute("ALTER TABLE " + nume_tabela + " ADD COLUMN id_" + nume_tabela + " SERIAL, ADD PRIMARY KEY (id_" + nume_tabela + ");")#int(10) AUTO_INCREMENT FIRSTs
            
        elif len(lista_chei_primare) == 1 and lista_chei_primare[0][1] != b'int':
            messagebox.showinfo(parent = parent_window, title = "Normalizare " + nume_tabela, message = "Exista cheie primara pe o singura coloana care nu este numerica, se inlocuieste...")
            
            normalizare(nume_tabela)

        elif len(lista_chei_primare) > 1: 
            #Folosim variabila "numerica" pentru a verifica daca toate atributele sunt numerice
            numerica = 1
            for cheie_primara in lista_chei_primare:
                if(cheie_primara[1] !=  b'int'):
                    numerica = 0
                    
            if numerica == 0:
                messagebox.showinfo(parent = parent_window, title = "Normalizare " + nume_tabela, message = "Exista cheie primara numerica pe " + str(len(lista_chei_primare)) + " atribute, dar unul sau mai multe dintre acestea nu sunt numerice")
                
            else:
                messagebox.showinfo(parent = parent_window, title = "Normalizare " + nume_tabela, message = "Exista cheie primara numerica pe " + str(len(lista_chei_primare)) + " atribute, se inlocuieste")
               
                normalizare(nume_tabela)
                
        else:
            messagebox.showinfo(parent = parent_window, title = "Normalizare " + nume_tabela, message = "Cheia primara este deja normalizata")
        
        
        
#Functia de vizualizare a bazei de date        
def vizualizare(nume_tabela): 
    if nume_tabela:
        try:
            #Interogarile SQL pentru afisarea numelor coloanelor respectiv a datelor din tabela
            comanda_afisare_coloane = "select column_name from information_schema.columns where table_schema = 'public' and table_name='" + nume_tabela + "';"
            comanda_afisare_tabela = "SELECT * FROM " + nume_tabela + ";"
            
            #Realizam conexiunea
            conn = psycopg2.connect(
            host='127.0.0.1',
            user = 'postgres',
            password = 'leucoplast',
            database = 'bazadedatesgbd'
            )
            
            #Cream un cursor pe care il vom folosi pentru a executa comenzile SQL
            curr = conn.cursor()
            curr.execute(comanda_afisare_coloane)
            coloane_tabel = [row[0] for row in curr]
            
            curr.execute(comanda_afisare_tabela)
            tabela = curr.fetchall()
             
            #Deschidem o alta fereastra pentru vizualizarea bazei de date
            windowBD = Toplevel(window)           
            windowBD.title(nume_tabela)
            windowBD.geometry("800x500")
            
            cauta_chei_primare="SELECT column_name FROM information_schema.table_constraints JOIN information_schema.key_column_usage USING (constraint_catalog, constraint_schema, constraint_name, table_catalog, table_schema, table_name) WHERE constraint_type = 'PRIMARY KEY' AND (table_schema, table_name) = ('public', '" + nume_tabela + "') ORDER BY ordinal_position;"
            curr.execute(cauta_chei_primare)
            x = curr.fetchall()
            cauta_chei_straine ="SELECT column_name FROM information_schema.table_constraints JOIN information_schema.key_column_usage USING (constraint_catalog, constraint_schema, constraint_name, table_catalog, table_schema, table_name) WHERE constraint_type = 'FOREIGN KEY' AND (table_schema, table_name) = ('public', '" + nume_tabela + "') ORDER BY ordinal_position;"
            curr.execute(cauta_chei_straine)
            ks = curr.fetchall()
            j = 0
            for coloana in coloane_tabel:
                cheie = coloana
                for i in x:
                    if cheie in i:
                        cheie = coloana + " PK"
                for u in ks:
                    if cheie in u:
                        cheie =  coloana + " FK"
                casuta = Entry(windowBD, width = int(120/len(coloane_tabel)))
                casuta.grid(row= 0, column= j) 
                casuta.insert(END, cheie)
                casuta.config(state = "readonly")
                j=j+1

                
            #Afisam datele din tabela
            i = 1
            for linie in tabela: 
                for coloana in range(len(linie)):
                    casuta1 = Entry(windowBD, width = int(120/len(coloane_tabel)))
                    casuta1.grid(row=i, column=coloana) 
                    casuta1.insert(END, linie[coloana])
                    casuta1.config(state = "readonly")
                i=i+1
                
                
            #Dupa afisarea datelor apar si butoanele pentru verificare/normalizare a cheilor primare
            butonVerificare = Button(windowBD, text ='Verificare cheie primara', fg='white', bg = '#f5a442', command = lambda:verificare(windowBD, nume_tabela), width = 20, height = 2) 
            butonVerificare.bind("<Enter>", lambda e: butonVerificare.config(fg='#caf0f8', bg='#fcb762'))
            butonVerificare.bind("<Leave>", lambda e: butonVerificare.config(fg='white', bg='#f5a442'))
            butonVerificare.place(relx=.35, rely = .9, anchor="center")
            
            
            butonNormalizare = Button(windowBD, text ='Normalizare cheie primara', fg='white', bg = '#f5a442', command = lambda:buton_normalizare(windowBD, nume_tabela), width = 20, height = 2) 
            butonNormalizare.bind("<Enter>", lambda e: butonNormalizare.config(fg='#caf0f8', bg='#fcb762'))
            butonNormalizare.bind("<Leave>", lambda e: butonNormalizare.config(fg='white', bg='#f5a442'))
            butonNormalizare.place(relx=.65, rely = .9, anchor="center")

        except psycopg2.Error as err:
            messagebox.showerror("Eroare", err)
            enter_tabela.delete(0, 'end')
    else:
        messagebox.showerror("Eroare", "Introduceti numele unei tabele")
        
       
            
#Functia care preia informatiile bazei de date si face legatura       
def enter():
    global conn
    global curr
    
    #Luam informatiile introduse
    nume_bd = enter1.get()
    utilizator = enter2.get()
    parola = enter3.get()
    
    if not(nume_bd):
        messagebox.showerror("Eroare", "Nu ati introdus numele bazei de date")
        
    elif not(utilizator):
        messagebox.showerror("Eroare", "Nu ati introdus nume utilizator")
        
    elif not(parola):
        messagebox.showerror("Eroare", "Nu ati introdus parola")
        
    else:
        try:
            #Realizam conexiunea
            conn = psycopg2.connect(
            host="localhost",
            user = utilizator,
            password = parola,
            database = nume_bd
            )
            curr = conn.cursor()

            curr.execute("SELECT table_name FROM information_schema.tables WHERE table_schema='public' AND table_type='BASE TABLE';")
            tables = curr.fetchall()

            contor = 0
            pozitie = 0.1
            for x in tables:
                contor = contor + 1
        
            Label(window, text= "Tabelele din " + nume_bd, fg='black', font=("Helvetica", 28)).place(relx= 0.5, rely = 0.6, anchor="center")
            
            for tabel in tables:
                Label(window, text= tabel, fg='black', font=("Helvetica", int(100/contor))).place(relx= pozitie, rely = 0.7, anchor="center")
                pozitie = pozitie + 0.9/contor
            
            
            butonVerificareCompleta = Button(window, text ='Verificare chei primare', fg='white', bg = '#f5a442', command = lambda:buton_verificare_completa(window), width = 20, height = 2) 
            butonVerificareCompleta.bind("<Enter>", lambda e: butonVerificareCompleta.config(fg='#caf0f8', bg='#fcb762'))
            butonVerificareCompleta.bind("<Leave>", lambda e: butonVerificareCompleta.config(fg='white', bg='#f5a442'))
            butonVerificareCompleta.place(relx=.4, rely = .9, anchor="center")
            
            butonNormalizareCompleta = Button(window, text ='Normalizare chei primare', fg='white', bg = '#f5a442', command = lambda:buton_normalizare_completa(window), width = 20, height = 2) 
            butonNormalizareCompleta.bind("<Enter>", lambda e: butonNormalizareCompleta.config(fg='#caf0f8', bg='#fcb762'))
            butonNormalizareCompleta.bind("<Leave>", lambda e: butonNormalizareCompleta.config(fg='white', bg='#f5a442'))
            butonNormalizareCompleta.place(relx=.6, rely = .9, anchor="center")
                
        except psycopg2.Error as err:
            messagebox.showerror("Eroare", "Date de logare invalide",err)
            enter1.delete(0, 'end')
            enter2.delete(0, 'end')
            enter3.delete(0, 'end')



#Un label pentru textul din partea de sus a aplicatiei
titlu = Label(window, text="Proiect Structura si Gestiunea Bazelor de Date", fg='magenta', font=("Helvetica", 32))
titlu.place(relx=.5, y = 50, anchor="center")
titlu = Label(window, text="Tematica proiect : Normalizarea Chei Primare", fg='magenta', font=("Helvetica", 18))
titlu.place(relx=.5, y = 560, anchor="center")


#Alegerea bazei de date
Label(window, text="Numele bazei de date(bazadedatesgbd)", fg='magenta').place(relx=.075, y = 115, anchor="center")
Label(window, text="Nume utilizator(postgres)", fg='magenta').place(relx=.075, y = 165, anchor="center")
Label(window, text="Parola(leucoplast)", fg='magenta').place(relx=.075, y = 215, anchor="center")

enter1 = Entry(window)
enter1.place(relx=.2, y = 115, anchor="center")
enter2 = Entry(window)
enter2.place(relx=.2, y = 165, anchor="center")
enter3 = Entry(window)
enter3.place(relx=.2, y = 215, anchor="center")

butonText = Button(window, text ='Conectare', fg='white', bg = 'magenta', command = lambda:enter(), width = 12, height = 1) 
butonText.bind("<Enter>", lambda e: butonText.config(fg='#caf0f8', bg='#fcb762'))
butonText.bind("<Leave>", lambda e: butonText.config(fg='white', bg='#f5a442'))
butonText.place(relx=.2, y = 250, anchor="center")



#Vizualizarea unei tabele
Label(window, text="Cauta tabela", font=("Helvetica", 20), fg='cyan').place(relx=.65, rely = 0.18, anchor="center")
enter_tabela = Entry(window, width = 25)
enter_tabela.place(relx=.65, y = 165, anchor="center")

butonTabela = Button(window, text ='Cauta tabela', fg='white', bg = 'magenta', command = lambda:vizualizare(enter_tabela.get()), width = 16, height = 2) 
butonTabela.bind("<Enter>", lambda e: butonTabela.config(fg='#caf0f8', bg='magenta'))
butonTabela.bind("<Leave>", lambda e: butonTabela.config(fg='white', bg='magenta'))
butonTabela.place(relx=.65, rely = 0.3, anchor="center")
     
    
      

window.title('Aplicatie normalizare chei primare')
window.geometry("1100x700+10+10")
window.iconbitmap(r'cheieprimara.ico')
window.iconbitmap(default = r'cheieprimara.ico')
window.protocol('WM_DELETE_WINDOW', inchidere)
window.mainloop()