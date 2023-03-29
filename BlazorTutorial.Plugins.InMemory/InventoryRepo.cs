using BlazorTutorial.CoreBusiness;
using BlazorTutorial.UseCases.PluginInterfaces;

namespace BlazorTutorial.Plugins.InMemory
{
    public class InventoryRepo : IInventoryRepository
    {
        private List<Inventory> _inventories;

        public InventoryRepo()
        {
            _inventories = new List<Inventory>() 
            { 
                new Inventory { InventoryId = 1, InventoryName = "Bike Seat", Quantity = 10, Cost = 2},
                new Inventory { InventoryId = 2, InventoryName = "Bike Body", Quantity = 10, Cost = 15},
                new Inventory { InventoryId = 3, InventoryName = "Bike Wheels", Quantity = 20, Cost = 8},
                new Inventory { InventoryId = 4, InventoryName = "Bike Pedals", Quantity = 20, Cost = 1},
            };
        }
        public async Task<IEnumerable<Inventory>> GetInventoriesByNameAsync(string name)
        {
            if (string.IsNullOrWhiteSpace(name)) return await Task.FromResult(_inventories);

            return _inventories.Where(x => x.InventoryName.Contains(name, StringComparison.OrdinalIgnoreCase)).ToList();
        }
    }
}