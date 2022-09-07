using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AikidoSystem.Objects
{
    internal class Kartotekas
    {
        private string firstName;
        private string middleName;
        private string lastName;
        private string email;
        private string egn;
        private string phoneNumber;
        private string addres;
        public Kartotekas()
        {
            this.firstName = "";
            this.middleName = "";
            this.lastName = "";
            this.email = "";
            this.egn = "";
            this.phoneNumber = "";
            this.addres = "";
        }

        public Kartotekas(string firstName, string middleName, string lastName, string email, string egn, string phoneNumber, string address)
        {
            this.firstName = firstName;
            this.middleName = middleName;
            this.lastName = lastName;
            this.email = email;
            this.egn = egn;
            this.phoneNumber = phoneNumber;
            this.addres = address;
        }

        public string FirstName { get => firstName; set => firstName = value; }
        public string MiddleName { get => middleName; set => middleName = value; }
        public string LastName { get => lastName; set => lastName = value; }
        public string Email { get => email; set => email = value; }
        public string Egn { get => egn; set => egn = value; }
        public string PhoneNumber { get => phoneNumber; set => phoneNumber = value; }
        public string Address { get => addres; set => addres = value; }


    }
}
