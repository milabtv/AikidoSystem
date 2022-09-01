using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AikidoSystem.Objects
{
    internal class Group
    {
        private int id;
        private string name;

        public Group(int id, string name)
        {
            this.id = id;
            this.name = name;
        }
        public Group()
        {
            this.id = 0;
            this.name ="";
        }

        public int Id { get => id; set => id = value; }
        public string Name { get => name; set => name = value; }
    }
}

