using System.Collections.Generic;
using System.Linq;

namespace BethanysPieShop.Models
{
    public class PieRepository : IPieRepository
    {
        private readonly AppDbContext _context;

        public PieRepository(AppDbContext context)
        {
            _context = context;
        }
        public IEnumerable<Pie> GetAllPies()
        {
            return _context.Pies;
        }

        public Pie GetPieById(int pieId)
        {
            return _context.Pies.FirstOrDefault(x => x.Id == pieId);
        }
    }
}
