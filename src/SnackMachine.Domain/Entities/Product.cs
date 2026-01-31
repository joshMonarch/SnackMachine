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
        private Product() { }
        public Product(string? name, decimal price, int stock)
        {
            Name = name;
            Price = price;
            Stock = stock;
        }
    
    }
}
