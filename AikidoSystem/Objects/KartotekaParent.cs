using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AikidoSystem.Objects
{
    internal class KartotekaParent
    {
        private string firstName;
        private string middleName;
        private string lastName;
        private string email;
        private string phoneNumber;
        private string address;
        private Kartotekas kartoteka;
                
        public KartotekaParent(string firstName, string middleName, string lastName, string email, string phoneNumber, string addres, Kartotekas kartoteka)
        {
            this.firstName = firstName;
            this.middleName = middleName;
            this.lastName = lastName;
            this.email = email;
            this.phoneNumber = phoneNumber;
            this.address = addres;
            this.kartoteka = kartoteka;
        }
        public KartotekaParent()
        {
            this.firstName = "";
            this.middleName = "";
            this.lastName = "";
            this.email = "";
            this.phoneNumber = "";
            this.address = "";
            this.kartoteka = new Kartotekas();
        }

        public string FirstName { get => firstName; set => firstName = value; }
        public string MiddleName { get => middleName; set => middleName = value; }
        public string LastName { get => lastName; set => lastName = value; }
        public string Email { get => email; set => email = value; }
        public string PhoneNumber { get => phoneNumber; set => phoneNumber = value; }
        public string Address { get => address; set => address = value; }
        internal Kartotekas Kartoteka { get => kartoteka; set => kartoteka = value; }
    }
}
