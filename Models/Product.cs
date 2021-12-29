using Microsoft.EntityFrameworkCore;

namespace FlashCardsApi.Models
{
    public class Product
    {
        public int ProductId { get; set; }
        public string EnglishName { get; set; }=string.Empty;
        public string ArabicName { get; set; }=string.Empty;
        public DateTime CreationDate { get; set; }
        public DateTime StartDate { get; set; }
        public int Duration { get; set; }
        public double Price { get; set; }
        public int CategoryId { get; set; }
        public Category Category { get; set; }
        public List<Details> Details { get; set; }
                public Product()
        {
            Category=new Category();
            Details=new List<Details>();
        }
    }
}