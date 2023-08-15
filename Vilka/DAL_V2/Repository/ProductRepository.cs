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
    public class ProductRepository : BaseRepository<Product> ,IProductRepository
    {
        public async Task<IEnumerable<Product>> GetByIdIncludWord(string name)
        {
            using (EntityDatabase db = new EntityDatabase())
            {
                return await db.Product.Include(k => k.KeyWords).ThenInclude(w => w.KeyWords).ThenInclude(kw => kw.KeyWord == name).ToListAsync();
            }
        }

        public async Task<IEnumerable<Product>> SelectIncludeCategory()
        {
            using (EntityDatabase db = new EntityDatabase())
            {
                return await db.Product.Include(c => c.Category).ToListAsync();
            }
        }

    }
}
