using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AikidoSystem.Objects
{
    internal class GroupList
    {
        private List<Kartotekas> kartotekaList;
        private Group group;

        public GroupList(List<Kartotekas> kartotekaList, Group group)
        {
            this.kartotekaList = kartotekaList;
            this.group = group;
        }
        public GroupList()
        {
            this.kartotekaList = new List<Kartotekas>();
            this.group = new Group();
        }
    }
}
