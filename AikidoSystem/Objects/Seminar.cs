using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AikidoSystem.Objects
{
    internal class Seminar
    {
        private int id;
        private string instructorName;
        private string placeOfSeminar;
        private string city;
        private string startDate;
        private string endDate;

        public Seminar(int id, string instructorName, string placeOfSeminar, string city, string startDate, string endDate)
        {
            this.id = id;
            this.instructorName = instructorName;
            this.placeOfSeminar = placeOfSeminar;
            this.city = city;
            this.startDate = startDate;
            this.endDate = endDate;
        }
        public Seminar()
        {
            this.id =0;
            this.instructorName = "";
            this.placeOfSeminar = "";
            this.city = "";
            this.startDate = "";
            this.endDate = "";
        }

        public int Id { get => id; set => id = value; }
        public string InstructorName { get => instructorName; set => instructorName = value; }
        public string PlaceOfSeminar { get => placeOfSeminar; set => placeOfSeminar = value; }
        public string City { get => city; set => city = value; }
        public string StartDate { get => startDate; set => startDate = value; }
        public string EndDate { get => endDate; set => endDate = value; }
    }
}
