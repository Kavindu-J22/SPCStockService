namespace SPCStockService.Models
{
    public class Order
    {
        public int Id { get; set; }
        public int DrugId { get; set; }
        public int Quantity { get; set; }
        public int PharmacyId { get; set; }
    }
}