using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL_V2.Entity
{
    public class Word
    {
        [Key]
        public int Id { get; set; }
        public string Header { get; set; }
        public string KeyWord { get; set; }
        public List<KeyParams> ProductLink { get; set; }
    }
}
