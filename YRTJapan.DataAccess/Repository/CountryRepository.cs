using YRTJapan.DataAccess.Data;
using YRTJapan.DataAccess.Repository.IRepository;
using YRTJapan.Core;
using YRTJapan.Core.Entities;

namespace YRTJapan.DataAccess.Repository
{
    public class CountryRepository : Repository<YRTCountry>, ICountryRepository
    {
        private ApplicationDbContext _db;

        public CountryRepository(ApplicationDbContext db) : base(db)
        {
            _db = db;
        }

        public void Update(YRTCountry country)
        {
            _db.YRTCountry.Update(country);
        }
    }
}
