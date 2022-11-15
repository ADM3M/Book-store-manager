using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Jul.Data
{
    public class Receipts
    {
        public int Id { get; set; }

        public int CustomerCardId { get; set; }

        public CustomerCards CustomerCard { get; set; }

        public DateTime DateSold { get; set; }
    }
}
