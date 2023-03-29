using BlazortTutorial.UseCases.Inventories.PluginInterfaces;
using BlazorTutorial.CoreBusiness;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BlazortTutorial.UseCases.Inventories
{
    public class ViewInventoriesByNameUseCase
    {
        private readonly IInventoryRepository inventoryRepository;
        public ViewInventoriesByNameUseCase(IInventoryRepository inventoryRepository) 
        {
            this.inventoryRepository = inventoryRepository;
        }
        public async Task<IEnumerable<Inventory>> ExecuteAsync(string name = "")
        {
            return await inventoryRepository.GetInventoriesByName(name);
        }
    }
}
