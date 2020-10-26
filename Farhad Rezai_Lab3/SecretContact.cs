//Farhad Rezai 21/11-2016;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AddContacat
{
    //klassen secretcontact ärver från klassen contact men bara de publica eller protected variablerna.
    class SecretContact : Contact
    {
        //base innebär att konstruktorn ärver från sin basklass.
        public SecretContact(string firstname, string lastname, string phonenumber)
            : base(firstname, lastname, phonenumber)
        {
        }

        //ifall checkboxen är chekad kommer följande form att visas i listan.
        public override string ToString()
        {
            return LastName + ", " + FirstName + ", " + "XX-XXXXXXXX";
        }
    }
}
