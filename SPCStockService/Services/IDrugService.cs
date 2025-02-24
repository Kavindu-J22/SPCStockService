using SPCStockService.Models;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace SPCStockService.Services
{
    public interface IDrugService
    {
        Task<List<Drug>> SearchDrugsAsync(string name);
        Task<Drug> AddDrugAsync(Drug drug);
    }
}