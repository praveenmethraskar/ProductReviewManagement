using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProductReviewManagement
{
    public class Productmanagement
    {
        public static void Top3Records(List<ProductReview> ProductReview)
        {
            var prodcutdata = (from Product in ProductReview orderby Product.rating descending select Product).Take(3);
            foreach (var products in prodcutdata)
            {
                Console.WriteLine(products.ProductId+" | "+products.UserId+" | "+products.rating+" | "+products.review+" | "+products.islike);
            }
        }
    }
}
