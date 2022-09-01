using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AikidoSystem.Objects
{
    internal class Exams
    {
        private string examDate;
        private string Instructor;
        private KyuLevels level;

        
        public Exams(string examDate, string instructor, KyuLevels level)
        {
            this.examDate = examDate;
            Instructor = instructor;
            this.level = level;
        }
        public Exams()
        {
            this.examDate = "";
            Instructor = "";
            this.level = new KyuLevels();
        }
        public string ExamDate { get => examDate; set => examDate = value; }
        public string Instructor1 { get => Instructor; set => Instructor = value; }
        internal KyuLevels Level { get => level; set => level = value; }

    }
}
