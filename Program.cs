using System;
using System.Collections.Generic;
using System.Linq;

namespace ProductReviewManagement
{
    public class Program
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("WELCOME TO PRODUCT REVIEW MANAGEMENT PROBLEM");
            //UC1
            List<ProductReview> productReviewList = new List<ProductReview>()
            {
                new ProductReview(){ProductID = 1,UserID=1,Rating=5,Review="Good",Islike=true},
                new ProductReview(){ProductID = 2,UserID=2,Rating=4,Review="Good",Islike=true},
                new ProductReview(){ProductID = 3,UserID=3,Rating=3,Review="Bad",Islike=false},
                new ProductReview(){ProductID = 4,UserID=3,Rating=5,Review="Good",Islike=true},
                new ProductReview(){ProductID = 5,UserID=1,Rating=5,Review="Good",Islike=true},
                new ProductReview(){ProductID = 6,UserID=2,Rating=4,Review="Good",Islike=true},
                new ProductReview(){ProductID = 7,UserID=3,Rating=1,Review="Bad",Islike=false},
                new ProductReview(){ProductID = 8,UserID=4,Rating=5,Review="Good",Islike=true},
                new ProductReview(){ProductID = 9,UserID=2,Rating=4,Review="nice",Islike=true},
                new ProductReview(){ProductID = 10,UserID=1,Rating=2,Review="nice",Islike=false},
            };
            //foreach(var list in productReviewList)
            //{
            //    Console.WriteLine("Product ID: "+ list.ProductID +" User ID: "+list.UserID+" Rating: "+list.Rating+" Review: "+list.Review+" IsLike: "+list.Islike);
            //}
            Management managementobj=new Management();
            //UC2
            //managementobj.TopRecords(productReviewList);
            //UC3
            managementobj.SelectedRecords(productReviewList);
        }
    }
}
