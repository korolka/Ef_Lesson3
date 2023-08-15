using DAL_V2.Entity;
using DAL_V2.Interfaces;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL_V2.Repository
{
    public class WordRepository :BaseRepository<Word>, IWordRepository
    {
        public async Task<IEnumerable<Word>> SelectIncludeKeyParamsProducts()
        {
            using (EntityDatabase db = new EntityDatabase())
            {
                return await db.Words.Include(k => k.ProductLink).ThenInclude(n => n.Product).ToListAsync();
            }
        }

    }
}
