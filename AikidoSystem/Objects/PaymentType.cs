using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AikidoSystem.Objects
{
    internal class PaymentType
    {
        private int id;
        private string typeName;
        private double price;

        public PaymentType(int id, string typeName, double price)
        {
            this.id = id;
            this.typeName = typeName;
            this.price = price;
        }
        public PaymentType()
        {
            this.id = 0;
            this.typeName = "";
            this.price = 0;
        }
        public int Id { get => id; set => id = value; }
        public string TypeName { get => typeName; set => typeName = value; }
        public double Price { get => price; set => price = value; }
    }
}
