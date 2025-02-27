namespace BangazonBE.Models.cs
{
    public class Orders
    {
        public int Id { get; set; }
        public int CustomerId { get; set; }
        public int ProductId { get; set; }
        public int SellerId { get; set; }
        public string PaymentType { get; set; }
        public int TotalPrice { get; set; }
        public bool Sold { get; set; }

    }
}
