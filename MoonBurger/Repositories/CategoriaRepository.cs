using MoonBurger.Context;
using MoonBurger.Models;
using MoonBurger.Repositories.Interfaces;
using System.Xml;

namespace MoonBurger.Repositories
{
    public class CategoriaRepository : ICategoriaRepository 
    {
        private readonly AppDbContext _context;

        public CategoriaRepository(AppDbContext context)
        {
            _context = context;
        }

        public IEnumerable<Categoria> Categorias => _context.Categorias;
    }
}
