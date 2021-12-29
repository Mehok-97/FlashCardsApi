using System.ComponentModel.DataAnnotations;
using Microsoft.EntityFrameworkCore;

namespace FlashCardsApi.Models
{
    
    public class Details
    {
        public int DetailsId { get; set; }
        public string TheKey { get; set; }=string.Empty;
        public string TheValue { get; set; }=string.Empty;
        public int ProductId { get; set; }
        public Product Product { get; set; }
        public Details()
        {
            Product=new Product();
        }
    }
}