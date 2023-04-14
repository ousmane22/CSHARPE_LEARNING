using Microsoft.EntityFrameworkCore;

namespace NdiayeShop.Models
{
    public class PieRepository:IPieRepository
    {
        private readonly NdiayeShopDbContext _ndiayeShopDbContext;

        public PieRepository(NdiayeShopDbContext ndiayeShopDbContext) 
        {
            _ndiayeShopDbContext = ndiayeShopDbContext;
        }

        public IEnumerable<Pie> AllPies
        {
            get
            {
                return _ndiayeShopDbContext.Pies.Include(c=>c.Category);
            }
        }

        public IEnumerable<Pie> PiesOfTheWeeks
        {
            get
            {
                return _ndiayeShopDbContext.Pies.Include(c => c.Category)
                    .Where(p => p.IsPieOfTheWeek);
            }
        }

        public Pie? GetPieById(int pieId)
        {
            return _ndiayeShopDbContext.Pies.Include(c => c.Category).FirstOrDefault(p=>p.PieId == pieId);
        }
    }
}
