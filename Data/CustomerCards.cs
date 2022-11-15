using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Jul.Data
{
    public class CustomerCards
    {
        public int Id { get; set; }

        public int CustomerId { get; set; }

        public Customers Customer { get; set; }

        public int BookId { get; set; }

        public Books Book { get; set; }

        public DateTime DateLanded { get; set; }
    }
}
