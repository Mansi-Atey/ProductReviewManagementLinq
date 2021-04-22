using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;

namespace ProductReviewManagementLinq
{
   public class Management
    {
     
        //public readonly DataTable dataTable = new DataTable();
        public void TopRecords(List<ProductReview> listProductReview)
        {
            var recordedData = (from productReviews in listProductReview
                                orderby productReviews.Rating descending
                                select productReviews).Take(3);

            foreach (var list in recordedData)
            {
                Console.WriteLine("ProductID:- " + list.ProducID + " " + "UserID:- " + list.UserID
                    + " " + "Rating:- " + list.Rating + " " + "Review:- " + list.Review + " " + "isLike:- " + list.isLike);
            }

        }

        public void SelectedRecords(List<ProductReview> listProductReview)
        {
            var recordedData = from productReviews in listProductReview
                               where (productReviews.ProducID == 1 || productReviews.ProducID == 4 || productReviews.ProducID == 9)
                               && productReviews.Rating > 3
                               select productReviews;

            foreach (var list in recordedData)
            {
                Console.WriteLine("ProductID:- " + list.ProducID + " " + "UserID:- " + list.UserID
                    + " " + "Rating:- " + list.Rating + " " + "Review:- " + list.Review + " " + "isLike:- " + list.isLike);
            }

        }
        //UC4
        public void RetrieveCountOfRecords(List<ProductReview> listProductReview)
        {
            var recordedData = listProductReview.GroupBy(x => x.ProducID).Select(x => new { ProductID = x.Key, Count = x.Count() });


            foreach (var list in recordedData)
            {
                Console.WriteLine(list.ProductID + "--------" + list.Count);

            }
        }

        //UC5
        public void RetrieveProductIDAndReviewFromList(List<ProductReview> listProductReview)
        {
            var recordData = listProductReview.Select(x => new { ProductID = x.ProducID, ProductReview = x.Review });
            Console.WriteLine("\nFollowing is List of Product Id and its Review ");
            foreach (var list in recordData)
            {

                Console.WriteLine("ProductID : " + list.ProductID + "\tProduct Review : " + list.ProductReview);
            }
          Console.WriteLine("\n******************************************************");
        }

        //UC6
        public void DisplayUnskippedRecords(List<ProductReview> listProductReview)
        {
            var recordData = (from productReviews in listProductReview
                              select productReviews).Skip(5).ToList();
            Console.WriteLine("\nFollowing is List of records after skiping first 5 records");
            DisplayRecords(recordData);
        }
        public void DisplayRecords(List<ProductReview> records)
        {
            foreach (var list in records)
            {
                Console.WriteLine("\n-----------------");
                Console.Write("ProductID " + list.ProducID + "UserID " + list.UserID + "Rating " + list.Rating + "Review " + list.Review + "isLike " + list.isLike);
                Console.WriteLine("\n-----------------");
            }
            Console.WriteLine("\n******************************************************");

        }

        //UC7
        public void SelectProductIDAndReviews(List<ProductReview> listProductReview)
        {
            var recordedData = listProductReview.Select(x => new { x.ProducID, x.Review });
            foreach (var list in recordedData)
            {
                Console.WriteLine(list.ProducID + " " + list.Review);
            }
        }
    }
}
