using SPCStockService.Data;
using SPCStockService.Models;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SPCStockService.Services
{
    public class DrugService : IDrugService
    {
        private readonly AppDbContext _context;

        public DrugService(AppDbContext context)
        {
            _context = context;
        }

        public async Task<List<Drug>> SearchDrugsAsync(string name)
        {
            return await Task.FromResult(_context.Drugs
                .Where(d => d.Name.Contains(name))
                .ToList());
        }

        public async Task<Drug> AddDrugAsync(Drug drug)
        {
            _context.Drugs.Add(drug);
            await _context.SaveChangesAsync();
            return drug;
        }
    }
}