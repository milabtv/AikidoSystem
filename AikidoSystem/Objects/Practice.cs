using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AikidoSystem.Objects
{
    internal class Practice
    {
        private Hall hall;
        private GroupList groupList;
        private string practiceDay;
        private string practiceTime;
        private string duration;

        public Practice(Hall hall, GroupList groupList, string practiceDay, string practiceTime, string duration)
        {
            this.hall = hall;
            this.groupList = groupList;
            this.practiceDay = practiceDay;
            this.practiceTime = practiceTime;
            this.duration = duration;
        }
        public Practice()
        {
            this.hall = new Hall();
            this.groupList = new GroupList();
            this.practiceDay = "";
            this.practiceTime = "";
            this.duration = "";
        }

        public string PracticeDay { get => practiceDay; set => practiceDay = value; }
        public string PracticeTime { get => practiceTime; set => practiceTime = value; }
        public string Duration { get => duration; set => duration = value; }
        internal Hall Hall { get => hall; set => hall = value; }
        internal GroupList GroupList { get => groupList; set => groupList = value; }
    }
}
