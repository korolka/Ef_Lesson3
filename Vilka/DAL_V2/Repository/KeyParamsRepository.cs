using DAL_V2.Entity;
using DAL_V2.Interfaces;
using Microsoft.EntityFrameworkCore;

namespace DAL_V2.Repository
{
    public class KeyParamsRepository :BaseRepository<KeyParams>, IKeyParamsRepository
    {
        public async Task<IEnumerable<KeyParams>> SelectIncludeWords()
        {
            using (EntityDatabase db = new EntityDatabase())
            {
                return await db.KeyLink.Include(k => k.KeyWords).ToListAsync();
            }
        }
    }
}
