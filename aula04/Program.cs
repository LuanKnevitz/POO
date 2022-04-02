using System;
using aula04;

namespace aula04
{
    class Program
    {
        static void Main(string[] args){   
            Agenda agenda=new Agenda();
            Contato luan=new Contato("Luan","51 995964947");
            Contato diogo=new Contato("Diogo","51 921234131");
            Contato ines=new Contato("Ines","51 942424212");
            Contato lucas=new Contato("Lucas","51 944445555");
            agenda.addContato(luan);
            agenda.addContato(diogo);
            agenda.addContato(ines);
            agenda.addContato(lucas);
            Console.WriteLine(agenda.getByName("luan").toString());
            
            
        }
    }

}
