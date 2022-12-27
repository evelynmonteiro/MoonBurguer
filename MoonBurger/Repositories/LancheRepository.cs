using Microsoft.EntityFrameworkCore;
using MoonBurger.Context;
using MoonBurger.Models;
using MoonBurger.Repositories.Interfaces;

namespace MoonBurger.Repositories
{
    public class LancheRepository : ILancheRepository
    {
        private readonly AppDbContext _context;
        public LancheRepository(AppDbContext context) {
            _context = context;
        }

        public IEnumerable<Lanche> Lanches => _context.Lanches.Include(c => c.Categoria);
        public IEnumerable<Lanche> LanchesPreferidos => _context.Lanches
                                                    .Where(l => l.IsLanchePreferido == true)
                                                    .Include(c => c.Categoria);
        public Lanche GetLancheById(int lancheId)
        {
            return _context.Lanches.FirstOrDefault(l => l.LancheId == lancheId);
        }

    }
}
