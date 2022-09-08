using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AikidoSystem.Objects
{
    internal class Practices
    {
        private int hall;        
        private string practiceDay;
        private string practiceTime;
        private string duration;
        private int group;
        private string kartoteka;

        public Practices()
        {
            this.hall = 0;
            this.practiceDay = "";
            this.practiceTime = "";
            this.duration = "";
            this.group = 0;
            this.kartoteka = "";
        }

        public Practices(int hall, string practiceDay, string practiceTime, string duration, int group, string kartoteka)
        {
            this.hall = hall;
            this.practiceDay = practiceDay;
            this.practiceTime = practiceTime;
            this.duration = duration;
            this.group = group;
            this.kartoteka = kartoteka;
        }

        public string PracticeDay { get => practiceDay; set => practiceDay = value; }
        public string PracticeTime { get => practiceTime; set => practiceTime = value; }
        public string Duration { get => duration; set => duration = value; }
        public int Hall { get => hall; set => hall = value; }
        public int Group { get => group; set => group = value; }
        public string Kartoteka { get => kartoteka; set => kartoteka = value; }
    }
}
