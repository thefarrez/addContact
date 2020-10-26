//Farhad Rezai 21/11-2016;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AddContacat
{
    class Contact
    {
        //egenskaper kan ej ha argument.och ändrar set till private för att skydda datan från att bli ändrard.
        //get är public (retunerar värdet. set är private för skydda datan).
        public string FirstName
        { get; private set; }

        public string LastName
        { get; private set; }

        public string PhoneNumber
        { get; private set; }

        //konstruktor gör att klassen Contact måste ha tre argumenter när den instansieras.
        //this.FirstName hämatar firstname från egenskapen som vi tidigare skrev i klassen.För att hjälpa kompilatorn skilja på class FirstName och FirstName från konstruktorn.
        public Contact(string FirstName, string LastName, string PhoneNumber)
        {
            this.FirstName = FirstName;
            this.LastName = LastName;
            this.PhoneNumber = PhoneNumber;
        }

        public override string ToString()
        {
            return LastName + " " + FirstName + " " + PhoneNumber;
        }

    }
}
