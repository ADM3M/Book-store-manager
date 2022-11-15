using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Jul.Data
{
    public class Publishers
    {
        public int Id { get; set; }

        public string PublisherName { get; set; }

        public ICollection<Books> PublisherBooks { get; set; }
    }
}
