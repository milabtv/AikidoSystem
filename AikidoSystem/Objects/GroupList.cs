using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AikidoSystem.Objects
{
    internal class GroupList
    {
        private List<Kartoteka> kartotekaList;
        private Group group;

        public GroupList(List<Kartoteka> kartotekaList, Group group)
        {
            this.kartotekaList = kartotekaList;
            this.group = group;
        }
        public GroupList()
        {
            this.kartotekaList = new List<Kartoteka>();
            this.group = new Group();
        }
    }
}
