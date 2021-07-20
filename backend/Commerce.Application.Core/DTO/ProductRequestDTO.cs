namespace Commerce.Application.Core.DTO
{
    public class ProductRequestDTO
    {
        public string Name { get; set; }

        public double Price { get; set; }

        public string PhotoUri { get; set; }

        public int Quantity { get; set; }

        public string Description { get; set; }
    }
}
