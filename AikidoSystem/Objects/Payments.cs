using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AikidoSystem.Objects
{
    internal class Payments
    {
        private int id;
        private string paymentDate;
        private string paymentMonth;
        private int paymentType;

        public Payments(int id, string paymentDate, string paymentMonth, int paymentType)
        {
            this.id = id;
            this.paymentDate = paymentDate;
            this.paymentMonth = paymentMonth;
            this.paymentType = paymentType;
        }
        public Payments()
        {
            this.id = 0;
            this.paymentDate = "";
            this.paymentMonth = "";
            this.paymentType = 0;
        }

        public int Id { get => id; set => id = value; }
        public string PaymentDate { get => paymentDate; set => paymentDate = value; }
        public string PaymentMonth { get => paymentMonth; set => paymentMonth = value; }
        public int PaymentType { get => paymentType; set => paymentType = value; }
    }
}
