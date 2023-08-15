using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ef_Lesson3
{
    public class Cart
    {
        public Guid ID { get; set; }
        public User User { get; set; }
        public Product Product { get; set; }
    }
}
