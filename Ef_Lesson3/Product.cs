using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace Ef_Lesson3
{
    public class Product
    {
        public Guid Id { get; set; }
        public string Name { get; set; }
        public double Price { get; set; }
        public double ActionPrice { get; set; }

        public string DescriptionField1 { get; set; }
        public string DescriptionField2 { get; set; }
        public string ImageUrl { get; set; }
        public Category Category { get; set; }
        public List<Cart> Cart { get; set; }
        public List<KeyParams> KeyWords{ get; set; }
    }
}
