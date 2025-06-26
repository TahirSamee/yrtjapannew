using YRTJapan.Core;
using YRTJapan.Core.Entities;

namespace YRTJapan.DataAccess.Repository.IRepository
{
    public interface ICountryRepository : IRepository<YRTCountry>
    {
        void Update(YRTCountry country);
    }
}
