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
    }
}
