using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpAssignment1
{
    internal class Taxi
    {
        private decimal taxiId;
        public decimal TaxiId
        {
            get
            {
                return this.taxiId;
            }
            set
            {
                this.taxiId = value;
            }
        }

        public Taxi(decimal taxiId)
        {
            this.TaxiId = taxiId;
        }
    }
}
