using BlazorTutorial.CoreBusiness;

namespace BlazorTutorial.UseCases.Inventories.Interfaces
{
    public interface IAddInventoryUseCase
    {
        Task ExecuteAsync(Inventory inventory);
    }
}