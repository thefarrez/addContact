//Farhad Rezai 21/11-2016;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AddContacat
{
    public partial class Form1 : Form
    {
        //deklarerar ett objekt.
        PhoneBook phonebook;

        public Form1()
        {
            InitializeComponent();
            //Här instansierar ett objekt
            phonebook = new PhoneBook();

        }

        private void button1_Click(object sender, EventArgs e)//saveknappen
        {


            if (phonebook.Add(txtNewContact.Text, chkIsSecret.Checked))
            {
                Updatelist();
            }
            else
            {
                MessageBox.Show("To save a contact, you have to enter it in the following form: firstname, lastname, phonenumber ");
            }
        }


        //här kontrollerar vi om användaren har skickat in rätt format av input.
        //kontakten läggs till i listboxen och sedan delas den upp i tre delar förname. efternamn, och telefonnummer.
        private void lstContacts_SelectedIndexChanged(object sender, EventArgs e)
        {
            Contact kontakt2 = (Contact)lstContacts.SelectedItem;
            if (kontakt2 != null)
            {
                txtFirstName.Text = kontakt2.FirstName;
                txtLastName.Text = kontakt2.LastName;
                txtPhoneNumber.Text = kontakt2.PhoneNumber;
            }
            else
            {
                Clear();
            }
        }

        //De markerade kontakt(kontakt2) kommer att tas bort från listbox och de andra 3 rutorna. 
        //Sedan uppdateras listan.
        private void btnDeleteContact_Click(object sender, EventArgs e)//deleteknappen
        {

            Contact kontakt2 = (Contact)lstContacts.SelectedItem;
            if (phonebook.Remove(kontakt2))
            {
                Updatelist();
                Clear();
            }

            else
            {
                MessageBox.Show("Please choose a contact to delete");
            }
        }


        private void chkIsSecret_CheckedChanged(object sender, EventArgs e)//hemlig
        {

        }


        /// <summary>
        /// Metoden updatelist, updaterar kontaktlistan då vi sparar nya kontakter.
        /// </summary>
        //för att undvika upprepning av koden gör vi en metod av koden och sedan anroppar vi metoden där det behövs.
        private void Updatelist()
        {
            lstContacts.Items.Clear();
            List<Contact> allcontacts = phonebook.GetAll();
            for (int i = 0; i < allcontacts.Count; i++)
            {
                lstContacts.Items.Add(allcontacts[i]);
            }
        }

        /// <summary>
        /// Metoden Clear används för att ta bort inkorrekt inmatining av data
        /// </summary>
        private void Clear()
        {
            txtFirstName.Clear();
            txtLastName.Clear();
            txtPhoneNumber.Clear();
        }
    }
}
