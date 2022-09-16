

namespace ProductReviewManagement
{
    public class Program
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Product review management");
            List<ProductReview> productreviewlist = new List<ProductReview>()
            {
                new ProductReview(){ProductId = 1, UserId = 1,rating=5,review="good",islike=true},
                new ProductReview(){ProductId = 2, UserId = 1,rating=2,review="bad",islike=true},
                new ProductReview(){ProductId = 3, UserId = 1,rating=5,review="good",islike=true},
                new ProductReview(){ProductId = 4, UserId = 1,rating=4,review="bad",islike=true},
                new ProductReview(){ProductId = 5, UserId = 1,rating=3,review="good",islike=true}
            };

            foreach(var products in productreviewlist)
            {
                Console.WriteLine("------------------------------------");
                Console.WriteLine(products.ProductId+" | "+products.UserId+" | "+products.rating+" | "+products.review+" | "+products.islike);

            }
        }
    }
}