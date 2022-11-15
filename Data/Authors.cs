using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Jul.Data
{
    public class Authors
    {
        public int Id { get; set; }

        public string AuthorName { get; set; }

        public ICollection<Books> AuthorBooks { get; set; }
    }
}
