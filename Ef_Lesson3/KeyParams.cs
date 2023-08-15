using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ef_Lesson3
{
    public class KeyParams
    {
        public Guid Id { get; set; }
        public Product Product { get; set; }
        public Word KeyWords { get; set; }
    }
}
