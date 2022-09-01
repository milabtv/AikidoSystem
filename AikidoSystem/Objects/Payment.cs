using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AikidoSystem.Objects
{
    internal class Payment
    {
        private int id;
        private string paymentDate;
        private string paymentMonth;
        private PaymentType paymentType;

        public Payment(int id, string paymentDate, string paymentMonth, PaymentType paymentType)
        {
            this.id = id;
            this.paymentDate = paymentDate;
            this.paymentMonth = paymentMonth;
            this.paymentType = paymentType;
        }
        public Payment()
        {
            this.id = 0;
            this.paymentDate = "";
            this.paymentMonth = "";
            this.paymentType = new PaymentType();
        }

        public int Id { get => id; set => id = value; }
        public string PaymentDate { get => paymentDate; set => paymentDate = value; }
        public string PaymentMonth { get => paymentMonth; set => paymentMonth = value; }
        internal PaymentType PaymentType { get => paymentType; set => paymentType = value; }
    }
}
