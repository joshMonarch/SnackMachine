namespace SnackMachine.Domain.Entities
{
    public class Product
    {
        public int Id { get; private set; }
        public string? Name { get; private set; }
        public decimal Price { get; private set; }
        public int Stock { get; private set; }
        public DateTime CreatedAt { get; private set; }
        public DateTime UpdatedAt { get; private set; }
    }
}
