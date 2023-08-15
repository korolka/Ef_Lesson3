using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL_V2.Entity
{
    public class KeyParams
    {
        [Key]
        public int Id { get; set; }
        public int ProductId { get; set; }

        [ForeignKey("ProductId")]
        public Product Product { get; set; }
        public int KeyWordsId { get; set; }
        [ForeignKey("KeyWordsId")]
        public Word KeyWords { get; set; }
    }
}
