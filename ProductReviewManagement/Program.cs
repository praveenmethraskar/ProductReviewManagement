

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
                new ProductReview(){ProductId = 2, UserId = 2,rating=2,review="bad",islike=true},
                new ProductReview(){ProductId = 3, UserId = 3,rating=5,review="good",islike=true},
                new ProductReview(){ProductId = 4, UserId = 4,rating=4,review="bad",islike=true},
                new ProductReview(){ProductId = 5, UserId = 5,rating=3,review="good",islike=true},
                 new ProductReview() { ProductId = 6, UserId = 6, rating = 5, review = "Good", islike = true },
                 new ProductReview() { ProductId = 7, UserId = 7, rating = 4, review = "fine", islike = false },
                 new ProductReview() { ProductId = 8, UserId = 8, rating = 3, review = "very good", islike = true },
                 new ProductReview() { ProductId = 9, UserId = 9, rating = 2, review = "bad", islike = false },
                 new ProductReview() { ProductId = 10, UserId = 10, rating = 1, review = "Excellent", islike = true },
                 new ProductReview() { ProductId = 11, UserId = 11, rating = 2, review = "Wrost", islike = false },
                 new ProductReview() { ProductId = 12, UserId = 12, rating = 3, review = "Good", islike = true },
                 new ProductReview() { ProductId = 13, UserId = 13, rating = 2, review = "Bad", islike = true },
                 new ProductReview() { ProductId = 14, UserId = 14, rating = 5, review = "Very Good", islike = false },
                 new ProductReview() { ProductId = 15, UserId = 15, rating = 4, review = "Excellent", islike = true }
            };

            bool check = true;
            while (check)
            {
                Console.WriteLine("1) Display All The Product Details\n" +
                                  "2) Retrieve top 3 records from the list who’s rating is high");
                int option = int.Parse(Console.ReadLine());
                switch (option)
                {
                    case 1:
                        foreach (var products in productreviewlist)
                        {
                            Console.WriteLine("------------------------------------");
                            Console.WriteLine(products.ProductId + " | " + products.UserId + " | " +
                                              products.rating + " | " + products.review + " | " + products.islike);
                            Console.WriteLine("------------------------------------");
                        }
                        break;
                    case 2:
                        Console.WriteLine("------------------------------------");
                        Productmanagement.Top3Records(productreviewlist);
                        Console.WriteLine("------------------------------------");
                        break;
                    case 3:
                        Console.WriteLine("------------------------------------");
                        Productmanagement.GetData(productreviewlist);
                        Console.WriteLine("------------------------------------");
                        break;
                }
            }
        }
    }
}