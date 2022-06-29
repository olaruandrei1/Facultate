#include <stdio.h>
#include <iostream>
#include <cstdlib>
#include <vector>
#include <string>


using namespace std;

class Medic{
private:
    string Nume;
    string Prenume;
    string Specializare;
    int OraLibera;
public:
    Medic(string Nume,string Prenume,string Specializare,int OraLibera);
    ~Medic();

    void citire(istream &in);
    void afisare(ostream &out);
    friend istream& operator>>(istream &in,Medic& m);
    friend ostream& operator<<(ostream &out,Medic& m);

    string GetNume(){return Nume+" "+Prenume;}
    string GetSpecializare(){return Specializare;}
    int GetOra(){return OraLibera;}
    void UpdateProgram(){OraLibera++;}
};

Medic::Medic(string Nume="",string Prenume="",string Specializare="",int OraLibera=-1)
{
    this->Nume=Nume;
    this->Prenume=Prenume;
    this->Specializare=Specializare;
    this->OraLibera=OraLibera;
}

Medic::~Medic()
{
    Nume="";
    Prenume="";
    Specializare="";
    OraLibera=-1;
}

void Medic::citire(istream &in){
    cout<<"Introduceti numele de familie al medicului: "<<endl;
    cin>>Nume;
    cout<<"Introduceti prenumele medicului: "<<endl;
    cin>>Prenume;
    cout<<"Introduceti specializarea medicului: "<<endl;
    cin>>Specializare;
    cout<<"Introduceti ora la care va avea medicul liber programul: "<<endl;
    cin>>OraLibera;
}

istream& operator>>(istream& in,Medic& m){
    m.citire(in);
    return in;
}

void Medic::afisare(ostream &out){
    cout<<"Nume:"<<Nume<<" "<<Prenume<<endl;
    cout<<"Specializare:"<<Specializare<<endl;
    cout<<"Medicul va avea programul liber la ora:"<<OraLibera<<":00"<<endl;
}

ostream& operator<<(ostream& out, Medic& m){
    m.afisare(out);
    return out;
}


class Operatie{
private:
    string NumePacient;
    string PrenumePacient;
    string Diagnostic;
    string NumeMedic;
    int cnpPacient;
    int oraOperatie;
    int pretOperatie;
    static int NrOperatii;
    vector<Medic> Medici;
public:
    Operatie(string NumePacient,string PrenumePacient,string Diagnostic,string NumeMedic, int cnpPacient, int oraOperatie, int pretOperatie);
    Operatie(Operatie&);
    ~Operatie();
    void citire(istream &in);
    void afisare(ostream &out);
    friend istream& operator>>(istream &in, Operatie& z);
    friend ostream& operator<<(ostream &out, Operatie& z);
    Operatie& operator=(Operatie &z);

    void IntroducereMedici(vector<Medic> ListaMedici){this->Medici=ListaMedici;}
    static void NumarOperatii(){cout<<NrOperatii;}
};

int Operatie::NrOperatii;

Operatie::Operatie(string NumePacient="",string PrenumePacient="",string Diagnostic="",string NumeMedic="",int cnpPacient=0, int oraOperatie=0, int pretOperatie=0){
try
	{
		if(cnpPacient<0)
			throw cnpPacient;
		else if(oraOperatie<0)
		{
			throw oraOperatie;
		}
		else if(pretOperatie<0)
		{
			throw pretOperatie;
		}
	}
	catch (int x)
    {
        cout<<"Eroare in constructor, nu se pot introduce valori negative.\n";
        exit(EXIT_FAILURE);
    }

        this->NumePacient=NumePacient;
        this->PrenumePacient=PrenumePacient;
        this->Diagnostic=Diagnostic;
        this->NumeMedic=NumeMedic;
        this->cnpPacient=cnpPacient;
        this->pretOperatie=pretOperatie;
        NrOperatii++;
}

Operatie::Operatie(Operatie &z){
    this->NumePacient=z.NumePacient;
    this->Diagnostic=z.Diagnostic;
    this->NumeMedic=z.NumeMedic;
    this->cnpPacient=z.cnpPacient;
    this->oraOperatie=z.oraOperatie;
    this->pretOperatie=z.pretOperatie;
}

Operatie::~Operatie(){
        NumePacient="";
        cnpPacient=0;
        oraOperatie=0;
        pretOperatie=-1;
}

void Operatie::citire(istream &in){
    cout<<"Introduceti numele de familie al pacientului: "<<endl;
    cin>>NumePacient;
    cout<<"Introduceti prenumele pacientului: "<<endl;
    cin>>PrenumePacient;
    cout<<"Introduceti Codul Numeric Personal al pacientului: "<<endl;
    cin>>cnpPacient;
    cout<<"Introduceti diagnosticul (: "<<endl;
    cin>>Diagnostic;

    int nrmedic;
    cout<<"Medici disponibili: "<<endl;
    vector<Medic>::iterator ptr;
    for(ptr=Medici.begin();ptr!=Medici.end();++ptr)
    {
            cout<<*ptr;
            cout<<endl;
    }

    bool ok=false;
    while(ok==false)    //verifica daca a fost ales un medic care se specializeaza in domeniul respectiv
    {
        cout<<"Introduceti numarul medicului care va face operatia :"<<endl;
        cin>>nrmedic;

        if(((Diagnostic=="Glaucom") || (Diagnostic=="Conjunctivita")||(Diagnostic=="glaucom")||(Diagnostic=="conjunctivita"))&&(Medici[nrmedic-1].GetSpecializare()!="Oftalmolog"))
            cout<<"Medicul nu se specializeaza in acest domeniu"<<endl;
        else if(((Diagnostic=="Varice")||(Diagnostic=="varice")||(Diagnostic=="Ampendicita")||(Diagnostic=="ampendicita"))&&(Medici[nrmedic-1].GetSpecializare()!="Chirurg"))
            cout<<"Medicul nu se specializeaza in acest domeniu"<<endl;
        else ok=true;
    }

    NumeMedic=Medici[nrmedic-1].GetNume();
    oraOperatie=Medici[nrmedic-1].GetOra();
    Medici[nrmedic-1].UpdateProgram();      // nu se updateaza ora

    cout<<"Introduceti pretul operatiei:"<<endl;
    cin>>pretOperatie;
}

istream& operator>>(istream& in,Operatie& z){
    z.citire(in);
    return in;
}
void Operatie::afisare(ostream &out){
    cout<<"Nume pacient: "<<NumePacient<<" "<<PrenumePacient<<endl;
    cout<<"CNP: "<<cnpPacient<<endl;
    cout<<"Diagnostic: "<<Diagnostic<<endl;
    cout<<"Medicul ce va sustine operatia: "<<NumeMedic<<endl;
    cout<<"Ora la care incepe operatia: "<<oraOperatie<<":00"<<endl;
    cout<<"Pretul operatie este de: "<<pretOperatie<<" EURO"<<endl;
}
ostream& operator<<(ostream& out,Operatie& z){
    z.afisare(out);
    return out;
}
Operatie& Operatie::operator=(Operatie &z){
    if(this!=&z)
    {
	 this->NumeMedic=z.NumeMedic;
	 this->NumePacient=z.NumePacient;
	 this->Diagnostic=z.Diagnostic;
	 this->cnpPacient=z.cnpPacient;
	 this->oraOperatie=z.oraOperatie;
	 this->pretOperatie=z.pretOperatie;
	 this->oraOperatie=z.oraOperatie;
    }
    return *this;
}

void menu_output(int Contor)
{
    cout<<"\n Programare Operatii: \n";
    cout<<"\n\t MENIU:";
    cout<<"\n===========================================\n";
    if(Contor>0)
    {


    }
    else
        cout<<"Nu a fost programata inca nicio operatie";

    cout<<endl;
    cout<<"1. Citire informatii operatie";
    cout<<endl;
    cout<<"2. Afisare informatii operatie";
    cout<<endl;
    cout<<endl;
    cout<<"0. Iesire."; cout<<"\n";
}
void menu()
{
    int option;///optiunea aleasa din meniu
    option=0;
    int Contor=0;
    vector<Operatie*> Operatii;
    Operatie *OP = 0;
    bool AFostCitita[100] = {false};

    vector<Medic> ListaMedici;
    Medic *M;

    int nrmedici;
    cout<<"Introduceti numarul de medici disponibili:"<<endl;
    cin>>nrmedici;

    for(int i=0;i<nrmedici;i++)
    {
        M= new Medic();
        cin>>*M;
        ListaMedici.push_back(*M);
    }

    system("cls");

    do
    {
        menu_output(Contor);

        cout<<"\nIntroduceti numarul actiunii: ";
        scanf("%d", &option);

        if (option==1)            //1. Citire informatii
        {
                OP=new Operatie();
                OP->IntroducereMedici(ListaMedici);
                cin>>*OP;
                Operatii.push_back(OP);
                AFostCitita[Contor]=true;
                Contor++;

            cout<<endl;
            cout<<"Au fost citite datele pentru ";
            Operatie::NumarOperatii();
            cout<<" operatii"<<endl;
        }


        if (option==2)           //2.Afisare informatii
        {
            cout<<"Au fost citite datele pentru ";
            Operatie::NumarOperatii();
            cout<<" operatii"<<endl;

            int nrafisat;
            cout<<"Introduceti numarul operatie pentru care sa se afiseze informatiile ";
            cin>>nrafisat;
            if (AFostCitita[nrafisat-1]==true && nrafisat>0)
            {
                cout<<endl;
                cout<<"Informatiile pentru operatia "<<nrafisat<<" sunt: "<<endl;
                cout<<*Operatii[nrafisat-1];
            }

            else
            cout<<"Datele operatiei cu numarul "<<nrafisat<<" nu au fost introduse";
        }
        if (option==0)
        {
            cout<<endl;
            cout<<"EXIT!"<<endl;

       for(int i=0;i<Contor;i++)
                delete Operatii[i];

        }

        if (option<0||option>2)
        {
            cout<<endl;
            cout<<"Selectie invalida"<<endl;
        }
        cout<<endl;
        system("pause");
        system("cls");
    }
    while(option!=0);
}

int main()
{
    menu();
    return 0;
}
