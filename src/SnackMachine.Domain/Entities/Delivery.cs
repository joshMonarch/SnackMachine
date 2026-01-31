using SnackMachine.Domain.Enums;

namespace SnackMachine.Domain.Entities
{
    public class Delivery
    {
        public int Id { get; private set; }
        public int ProductId { get; private set; }
        public int Quantity { get; private set; }
        public Status Status { get; private set; }
        public DateTime CreatedAt { get; private set; }
        public DateTime UpdatedAt { get; private set; }
        public User? UserNavigation { get; private set; }
        public IEnumerable<Product>? ProductsNavigation { get; private set; }
        private Delivery() { }
        public Delivery(int productId, int quantity, Status status)
        {

            ProductId = productId;
            Quantity = quantity;
            Status = status;
        }
    }
}
