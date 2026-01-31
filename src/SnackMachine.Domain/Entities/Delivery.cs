using SnackMachine.Domain.Enums;

namespace SnackMachine.Domain.Entities
{
    public class Delivery
    {
        public int Id { get; private set; }
        public int ProductId { get; private set; }
        public int Quantity { get; private set; }
        public Status status { get; private set; }
        public DateTime CreatedAt { get; private set; }
        public DateTime UpdatedAt { get; private set; }
        private Delivery() { }
        public Delivery(int id, int productId, int quantity, Status status, DateTime createdAt, DateTime updatedAt)
        {
            Id = id;
            ProductId = productId;
            Quantity = quantity;
            this.status = status;
            CreatedAt = createdAt;
            UpdatedAt = updatedAt;
        }
    }
}
