using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProductReviewManagement
{
    public class ProductReview
    {
        public int ProductId { get; set; }

        public int UserId { get; set; }

        public int rating { get; set; }
        public string review { get; set; }
        public bool islike { get; set; }    
    }
}
