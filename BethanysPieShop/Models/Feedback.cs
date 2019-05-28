using Microsoft.AspNetCore.Mvc.ModelBinding;
using System.ComponentModel.DataAnnotations;

namespace BethanysPieShop.Models
{
    public class Feedback
    {
        [BindNever]
        public int FeedBackId { get; set; }

        [Required]
        public string Name { get; set; }

        [DataType(DataType.EmailAddress)]
        public string Email { get; set; }

        public string Message { get; set; }

        public bool ContactMe { get; set; }
    }
}
