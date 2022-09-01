using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AikidoSystem.Objects
{
    internal class KyuLevels
    {
        private int id;
        private string name;
        private string levelType;

        public KyuLevels(int id, string name)
        {
            this.id = id;
            this.name = name;
        }
        public KyuLevels()
        {
            this.id = 0;
            this.name = "";
        }

        public int Id { get => id; set => id = value; }
        public string Name { get => name; set => name = value; }

        

    }
}
