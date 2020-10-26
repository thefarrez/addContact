//Farhad Rezai 21/11-2016;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AddContacat
{
    class PhoneBook
    {


        //För att lägga till kontakter (hur många vi vill!) gör vi en lista av contact detta skulle inte vara möjligt med array.
        List<Contact> kontakter = new List<Contact>();
        /// <summary>
        /// userinput syftar på det som användare skriver in. och Detta ska kontrolleras så att inputen är rätt.
        /// </summary>
        //om antal sträng är lika med tre = gilltig inmatning.
        public bool Add(string userInput, bool ischeked)
        {
            string[] kontaktlist = userInput.Split(',');
            if (kontaktlist.Length == 3)
            {
                string FirstName = kontaktlist[0].Trim();
                string LastName = kontaktlist[1].Trim();
                string PhoneNumber = kontaktlist[2].Trim();
                //om user vill ha hemligt nummer kommer detta att hämtas från secretcontact.
                if (ischeked == true)
                {
                    SecretContact hemligtnummer = new SecretContact(FirstName, LastName, PhoneNumber);
                    kontakter.Add(hemligtnummer);
                }

                    //I alla andra fall kommer de fullständiga kontaktinfon att visas i listboxen.
                else
                {
                    Contact kontakt = new Contact(FirstName, LastName, PhoneNumber);
                    kontakter.Add(kontakt);
                }
                return true;
            }
            else
            {
                return false;
            }
        }

        /// <summary>
        /// Tar bort markerade kontakt från listbox
        /// </summary>
        /// <param name="kontakt"></param>
        /// <returns></returns>
        public bool Remove(Contact kontakt)
        {
            if (kontakt == null)
            {
                return false;
            }
            else
            {
                kontakter.Remove(kontakt);
                return true;
            }
        }

        //retunera alla kontakter.
        public List<Contact> GetAll()
        {
            return kontakter;
        }

    }
}
