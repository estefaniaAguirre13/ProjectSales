using Sales.Shared.Entities;

namespace Sales.API.Data
{
    public class SeedDb
    {
        private readonly DataContext _context;

        public SeedDb(DataContext context)
        {
            _context = context;
        }

        public async Task SeedAsync()
        {
            await _context.Database.EnsureCreatedAsync();
            await CheckCountriesAsync();
            await CheckCategoriesAsync();
        }

        private async Task CheckCountriesAsync()
        {
            if (!_context.Countries.Any())
            {
                _context.Countries.Add(new Country { Name = "Colombia" });
                _context.Countries.Add(new Country { Name = "Argentina" });
                _context.Countries.Add(new Country { Name = "México" });
                await _context.SaveChangesAsync();
            }
        }

        private async Task CheckCategoriesAsync()
        {
            if (!_context.Categories.Any())
            {
                _context.Categories.Add(new Category { Name = "Comida" });
                _context.Categories.Add(new Category { Name = "Deporte" });
                _context.Categories.Add(new Category { Name = "Baile" });
                _context.Categories.Add(new Category { Name = "Libros" });
                _context.Categories.Add(new Category { Name = "Música" });
                _context.Categories.Add(new Category { Name = "Dulces" });
                _context.Categories.Add(new Category { Name = "Camisas" });
                _context.Categories.Add(new Category { Name = "Pantalones" });
                _context.Categories.Add(new Category { Name = "Zapatos" });
                _context.Categories.Add(new Category { Name = "Viajes" });
                await _context.SaveChangesAsync();
            }
        }
    }
}
