using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AikidoSystem.Objects
{
    internal class Hall
    {
        private int id;
        private string name;
        private string address;

        public Hall(int id, string name, string address)
        {
            this.id = id;
            this.name = name;
            this.address = address;
        }
        public Hall()
        {
            this.id = 0;
            this.name = "";
            this.address = "";
        }
        public int Id { get => id; set => id = value; }
        public string Name { get => name; set => name = value; }
        public string Address { get => address; set => address = value; }
    }
}
