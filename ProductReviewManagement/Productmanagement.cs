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
        public static void GetData(List<ProductReview> productreview)
        {
            var productdata = from products in productreview
                              where (products.ProductId == 1 && products.rating > 3) ||
                              (products.ProductId == 4 && products.rating > 3) ||
                              (products.ProductId == 9 && products.rating > 3)
                              select products;
            foreach (var products in productdata)
            {
                Console.WriteLine(products.ProductId + " | " + products.UserId + " | " +
                                  products.rating + " | " + products.review + " | " + products.islike);
            }
        }
    }
}
