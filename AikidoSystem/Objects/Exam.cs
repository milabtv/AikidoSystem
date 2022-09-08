using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AikidoSystem.Objects
{
    internal class Exam
    {
        private string examDate;
        private string Instructor;
        private int level;

        
        public Exam(string examDate, string instructor, int level)
        {
            this.examDate = examDate;
            Instructor = instructor;
            this.level = level;
        }
        public Exam()
        {
            this.examDate = "";
            Instructor = "";
            this.level = 0;
        }
        public string ExamDate { get => examDate; set => examDate = value; }
        public string Instructor1 { get => Instructor; set => Instructor = value; }
        public int Level { get => level; set => level = value; }

    }
}
