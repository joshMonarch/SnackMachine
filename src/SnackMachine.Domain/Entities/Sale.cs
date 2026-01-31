using SnackMachine.Domain.Enums;

namespace SnackMachine.Domain.Entities
{
    public class Sale
    {
        public int Id { get; private set; }
        public int UserId { get; private set; }
        public int ProductId { get; private set; }
        public int Quantity { get; private set; }
        public Status Status { get; private set; }
        public decimal TotalPrice { get; private set; }
        public DateTime CreatedAt { get; private set; }
        public DateTime UpdatedAt { get; private set; }
        public User? UserNavigation { get; private set; }
        public Product? ProductNavigation { get; private set; }
        private Sale() { }
        public Sale(int userId, int productId, int quantity, Status status, decimal totalPrice)
        {
            UserId = userId;
            ProductId = productId;
            Quantity = quantity;
            Status = status;
            TotalPrice = totalPrice;
        }
    }
}
