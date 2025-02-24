namespace SPCStockService.Models
{
    public class Warehouse
    {
        public int Id { get; set; }
        public string Name { get; set; } = string.Empty;
        public string Location { get; set; } = string.Empty;
        public int DrugId { get; set; }
        public int Quantity { get; set; }
    }
}