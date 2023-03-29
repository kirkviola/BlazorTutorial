namespace BlazorTutorial.CoreBusiness
{
    public class Inventory
    {
        public int InventoryId { get; set; }
        public string InventoryName { get; set; } = string.Empty;
        public int Quantity { get; set; }
        public double Cost { get; set; }
    }
}