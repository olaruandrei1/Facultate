/* Initializez tabele: */
CREATE TABLE IF NOT EXISTS Sediu(
    ID_Sediu INT NOT NULL,
    Denumire_strada VARCHAR(100),
    Oras VARCHAR(100),
    Localitate VARCHAR(100),
    Tara_Sediu_Principal VARCHAR(100),
    PRIMARY KEY(ID_Sediu)
);
CREATE TABLE IF NOT EXISTS Asociatii(
    Denumire_Asociatie VARCHAR(100),
    ID_Sediu INT NOT NULL,
    FOREIGN KEY(ID_Sediu) REFERENCES Sediu(ID_Sediu),
    PRIMARY KEY(Denumire_Asociatie)
);
CREATE TABLE IF NOT EXISTS Personal(
    Nume_Angajat VARCHAR(100) NOT NULL,
    Prenume_Angajat VARCHAR(100) NOT NULL,
    Denumire_Asociatie VARCHAR(100) NOT NULL,
    DataAngajare DATE NOT NULL,
    Salariu INT NOT NULL,
    NumarTelefon INT NOT NULL,
    FOREIGN KEY(Denumire_Asociatie) REFERENCES Asociatii(Denumire_Asociatie),
    PRIMARY KEY(Nume_Angajat, Prenume_Angajat)
);
CREATE TABLE IF NOT EXISTS Clienti(
    CNP_Client INT NOT NULL,
    Serie_Card_Fidelitate INT NOT NULL,
    Denumire_Asociatie VARCHAR(100) NOT NULL,
    Nume_Client VARCHAR(100) NOT NULL,
    Prenume_Client VARCHAR(100) NOT NULL,
    NumarTelefonC INT NOT NULL,
    FOREIGN KEY(Denumire_Asociatie) REFERENCES Asociatii(Denumire_Asociatie),
    PRIMARY KEY(CNP_Client, Serie_Card_Fidelitate)
);
CREATE TABLE IF NOT EXISTS CasaDeMarcat(
    Denumire_Casa_Marcat VARCHAR(100) NOT NULL,
    PretTotal INT NOT NULL,
    PRIMARY KEY(Denumire_Casa_Marcat)
);
CREATE TABLE IF NOT EXISTS FacturiG(
    ID_Factura INT NOT NULL,
    Serie_Card_Fidelitate INT NOT NULL,
    CNP_Client INT NOT NULL,
    Denumire_Casa_Marcat VARCHAR(100) NOT NULL,
    Data_Intocmire_F DATE NOT NULL,
    FOREIGN KEY(Serie_Card_Fidelitate, CNP_Client) REFERENCES Clienti(Serie_Card_Fidelitate, CNP_Client),
    FOREIGN KEY(Denumire_Casa_Marcat) REFERENCES CasaDeMarcat(Denumire_Casa_Marcat),
    PRIMARY KEY(ID_Factura)
);
CREATE TABLE IF NOT EXISTS CasaDeMarcatPOS(
    Denumire_POS VARCHAR(100) NOT NULL,
    PretTotal INT
);

/* Inserez date in tabelele generate: */

/* Inserez date in tabelul --Sediu-- */
INSERT INTO Sediu(ID_Sediu, Denumire_strada, Oras, Localitate, Tara_Sediu_Principal)
VALUES(1, 'Strada Crinului 102', 'Constanta', 'Constanta', 'Romania');

INSERT INTO Sediu(ID_Sediu, Denumire_strada, Oras, Localitate, Tara_Sediu_Principal)
VALUES(2, 'Strada Titus Cergau 36', 'Constanta', 'Constanta', 'Romania');

INSERT INTO Sediu(ID_Sediu, Denumire_strada, Oras, Localitate, Tara_Sediu_Principal)
VALUES(3, 'Strada Anina 9', 'Cluj', 'ClujNapoca', 'Romania');

INSERT INTO Sediu(ID_Sediu, Denumire_strada, Oras, Localitate, Tara_Sediu_Principal)
VALUES(4, 'Strada Predeal 6', 'Cluj', 'ClujNapoca', 'Roma');

INSERT INTO Sediu(ID_Sediu, Denumire_strada, Oras, Localitate, Tara_Sediu_Principal)
VALUES(5, 'Strada 1 Decembrie 1918 12', 'Timis', 'Timisoara', 'USA');

INSERT INTO Sediu(ID_Sediu, Denumire_strada, Oras, Localitate, Tara_Sediu_Principal)
VALUES(6, 'Bulevardul 21 Decembrie 1989 82', 'Cluj', 'ClujNapoca', 'Romania');

INSERT INTO Sediu(ID_Sediu, Denumire_strada, Oras, Localitate, Tara_Sediu_Principal)
VALUES(7, 'Strada Semnului 3', 'Iasi', 'Iasi', 'Belgia');

INSERT INTO Sediu(ID_Sediu, Denumire_strada, Oras, Localitate, Tara_Sediu_Principal)
VALUES(8, 'Strada Calarasi 12', 'Iasi', 'Iasi', 'Romania');

INSERT INTO Sediu(ID_Sediu, Denumire_strada, Oras, Localitate, Tara_Sediu_Principal)
VALUES(9, 'Strada Tatarasi Nord 92', 'Iasi', 'Iasi', 'Romania');

INSERT INTO Sediu(ID_Sediu, Denumire_strada, Oras, Localitate, Tara_Sediu_Principal)
VALUES(10, 'Calea Rahovei 62', 'Bucuresti', 'Bucuresti', 'Norvegia');
-- /*
-- /* Inserez date in tabelul --Asociatii-- */

-- INSERT INTO Asociatii(Denumire_Asociatie, ID_Sediu)
-- VALUES('IBM ROMANIA SRL', 1);

-- INSERT INTO Asociatii(Denumire_Asociatie, ID_Sediu)
-- VALUES('ORACLE ROMANIA SRL', 2);

-- INSERT INTO Asociatii(Denumire_Asociatie, ID_Sediu)
-- VALUES('ERICSSON TELECOMMUNICATIONS ROMANIA SRL', 3);

-- INSERT INTO Asociatii(Denumire_Asociatie, ID_Sediu)
-- VALUES('ENDAVA ROMANIA SRL', 4);

-- INSERT INTO Asociatii(Denumire_Asociatie, ID_Sediu)
-- VALUES('ATOS IT SOLUTIONS AND SERVICES SRL', 5);

-- INSERT INTO Asociatii(Denumire_Asociatie, ID_Sediu)
-- VALUES('MICROSOFT ROMANIA SRL', 6);

-- INSERT INTO Asociatii(Denumire_Asociatie, ID_Sediu)
-- VALUES('AMAZON DEVELOPMENT CENTER RO SRL', 7);

-- INSERT INTO Asociatii(Denumire_Asociatie, ID_Sediu)
-- VALUES('ORACLE GLOBAL SERVICES RO SRL', 8);

-- INSERT INTO Asociatii(Denumire_Asociatie, ID_Sediu)
-- VALUES('METRO SYSTEMS ROMANIA SRL', 9);

-- INSERT INTO Asociatii(Denumire_Asociatie, ID_Sediu)
-- VALUES('MOVIALROMANIA SRL', 10);

-- /* Inserez date in tabelul --Personal--*/
-- INSERT INTO Personal(Nume_Angajat, Prenume_Angajat, Denumire_Asociatie, DataAngajare, Salariu, NumarTelefon)
-- VALUES('Iepure', 'Antonio', 'MICROSOFT ROMANIA SRL', '2016-07-29', '7985', '0772654442');

-- INSERT INTO Personal(Nume_Angajat, Prenume_Angajat, Denumire_Asociatie, DataAngajare, Salariu, NumarTelefon)
-- VALUES('Olaru', 'Andrei', 'AMAZON DEVELOPMENT CENTER RO SRL', '2022-08-15', '4000', '0725994150');

-- INSERT INTO Personal(Nume_Angajat, Prenume_Angajat, Denumire_Asociatie, DataAngajare, Salariu, NumarTelefon)
-- VALUES('Raducanu', 'Matei', 'ORACLE GLOBAL SERVICES RO SRL', '2021-02-19', '5620', '0725597050');

-- INSERT INTO Personal(Nume_Angajat, Prenume_Angajat, Denumire_Asociatie, DataAngajare, Salariu, NumarTelefon)
-- VALUES('Arsenie', 'Roxana', 'IBM ROMANIA SRL', '2019-11-30', '6000', '0784256371');

-- INSERT INTO Personal(Nume_Angajat, Prenume_Angajat, Denumire_Asociatie, DataAngajare, Salariu, NumarTelefon)
-- VALUES('Andrei', 'Andreea', 'ERICSSON TELECOMMUNICATIONS ROMANIA SRL', '2018-03-01', '9000', '0799132456');

-- INSERT INTO Personal(Nume_Angajat, Prenume_Angajat, Denumire_Asociatie, DataAngajare, Salariu, NumarTelefon)
-- VALUES('Petre', 'Diana', 'ENDAVA ROMANIA SRL', '2015-01-31', '10000', '0722321654');

-- /*Inserez date in tabelul --Clienti--*/
-- INSERT INTO Clienti(CNP_Client, Serie_Card_Fidelitate, Denumire_Asociatie, Nume_Client, Prenume_Client, NumarTelefonC)
-- VALUES(1098013245631, 9556, 'ENDAVA ROMANIA SRL', 'Tigru', 'Ion', '0732921634');

-- INSERT INTO Clienti(CNP_Client, Serie_Card_Fidelitate, Denumire_Asociatie, Nume_Client, Prenume_Client, NumarTelefonC)
-- VALUES(1088095735628, 8543, 'ATOS IT SOLUTIONS AND SERVICES SRL', 'Rava', 'Aurelian', '0749535634');

-- INSERT INTO Clienti(CNP_Client, Serie_Card_Fidelitate, Denumire_Asociatie, Nume_Client, Prenume_Client, NumarTelefonC)
-- VALUES(2067195486331, 2356, 'ENDAVA ROMANIA SRL', 'Luca', 'Adriana', '0732921634');

-- INSERT INTO Clienti(CNP_Client, Serie_Card_Fidelitate, Denumire_Asociatie, Nume_Client, Prenume_Client, NumarTelefonC)
-- VALUES(2098013245631, 8246, 'METRO SYSTEMS ROMANIA SRL', 'Petrut', 'Adriana', '0757391186');

-- INSERT INTO Clienti(CNP_Client, Serie_Card_Fidelitate, Denumire_Asociatie, Nume_Client, Prenume_Client, NumarTelefonC)
-- VALUES(1074961325631, 1686, 'ORACLE GLOBAL SERVICES RO SRL', 'Alexandrescu', 'George', '0725664338');

-- INSERT INTO Clienti(CNP_Client, Serie_Card_Fidelitate, Denumire_Asociatie, Nume_Client, Prenume_Client, NumarTelefonC)
-- VALUES(2086135798135, 1783, 'AMAZON DEVELOPMENT CENTER RO SRL', 'Alexandru', 'Alexandra', '0733589124');
-- */