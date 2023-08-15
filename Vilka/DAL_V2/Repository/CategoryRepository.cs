using DAL_V2.Entity;
using DAL_V2.Interfaces;
using Microsoft.EntityFrameworkCore;

namespace DAL_V2.Repository
{
    public class CategoryRepository : BaseRepository<Category>, ICategoryRepository
    {
        public async Task<IEnumerable<Category>> SelectIncludeProducts()
        {
            using (EntityDatabase db = new EntityDatabase())
            {
                return await db.Category.Include(p => p.Products).ToListAsync();
            }
        }
    }
}
