using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProductReviewManagement
{
    public class Management
    {
        public readonly DataTable dataTable = new DataTable();
        //UC2
        public void TopRecords(List<ProductReview> listProductReview)
        {
            var recordData = (from productReviews in listProductReview
                              orderby productReviews.Rating descending
                              select productReviews).Take(3);
            foreach (var record in recordData)
            {
                Console.WriteLine("Product ID: "+record.ProductID+" User ID: "+record.UserID+" Rating: "+record.Rating+" Review: "+record.Review+" IsLike:"+record.Islike);
            }
        }
        //UC3
        public void SelectedRecords(List<ProductReview> listProductReview)
        {
            var recordData= (from productReviews in listProductReview
                             where (productReviews.ProductID==1 || productReviews.ProductID==4 || productReviews.ProductID==9)
                             && productReviews.Rating > 3
                             select productReviews);
            foreach (var record in recordData)
            {
                Console.WriteLine("Product ID: " + record.ProductID + " User ID: " + record.UserID + " Rating: " + record.Rating + " Review: " + record.Review + " IsLike:" + record.Islike);
            }
        }
        //UC4
        public void RetrieveCountOfRecords(List<ProductReview> listProductReview)
        {
            var recordData=listProductReview.GroupBy(x => x.ProductID).Select(x => new {ProductID = x.Key,Count = x.Count()});
            foreach (var record in recordData)
            {
                Console.WriteLine(record.ProductID+"------"+record.Count);
            }
        }
        //UC5
        public void GetProductIDAndReview(List<ProductReview> listProductReview)
        {
            foreach(var record in listProductReview)
            {
                Console.WriteLine(record.ProductID+"-----"+record.Review);
            }
        }
        //UC6
        public void SkipTop5Records(List<ProductReview> listProductReview)
        {
            var recordData = (from productReviews in listProductReview
                              orderby productReviews.Rating descending
                              select productReviews).Skip(5);
            foreach (var record in recordData)
            {
                Console.WriteLine("Product ID: " + record.ProductID + " User ID: " + record.UserID + " Rating: " + record.Rating + " Review: " + record.Review + " IsLike:" + record.Islike);
            }
        }
        //UC9
        public void RetrieveIslikeTrue(List<ProductReview> listProductReview)
        {
            var recordData = (from productReviews in listProductReview
                              where productReviews.Islike == true
                              select productReviews);
            foreach (var record in recordData)
            {
                Console.WriteLine("Product ID: " + record.ProductID + " User ID: " + record.UserID + " Rating: " + record.Rating + " Review: " + record.Review + " IsLike:" + record.Islike);
            }

        }



    }
}
