using System;
using System.Collections.Generic;
using System.Data;

namespace ProductReviewManagementLinq
{
   public class Program
    {
       public static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");

            Console.WriteLine("Welcome to product review management");

            //UC1
            List<ProductReview> productReviewList = new List<ProductReview>()
            {
                new ProductReview(){ProducID=1,UserID=1,Rating=2,Review="Good",isLike=true},
                new ProductReview(){ProducID=2,UserID=1,Rating=4,Review="Good",isLike=true},
                new ProductReview(){ProducID=3,UserID=1,Rating=5,Review="Good",isLike=true},
                new ProductReview(){ProducID=4,UserID=1,Rating=6,Review="Good",isLike=false},
                new ProductReview(){ProducID=5,UserID=1,Rating=2,Review="nice",isLike=true},
                new ProductReview(){ProducID=6,UserID=1,Rating=1,Review="bas",isLike=true},
                new ProductReview(){ProducID=8,UserID=1,Rating=1,Review="Good",isLike=false},
                new ProductReview(){ProducID=8,UserID=1,Rating=9,Review="nice",isLike=true},
                new ProductReview(){ProducID=2,UserID=1,Rating=10,Review="nice",isLike=true},
                new ProductReview(){ProducID=10,UserID=1,Rating=8,Review="nice",isLike=true},
                new ProductReview(){ProducID=11,UserID=1,Rating=3,Review="nice",isLike=true}

            };

            //foreach (var list in productReviewList)
            //{
              //  Console.WriteLine("ProductID:- " + list.ProducID + " " + "UserID:- " + list.UserID
                //    + " " + "Rating:- " + list.Rating + " " + "Review:- " + list.Review + " " + "isLike:- " + list.isLike);
            //}

            //UC2
            Management management = new Management();
            //  management.TopRecords(productReviewList);

            //UC3
            //management.SelectedRecords(productReviewList);

            //UC4
            //management.RetrieveCountOfRecords(productReviewList);
            //Console.ReadKey();

            //UC5
            //management.RetrieveProductIDAndReviewFromList(productReviewList);

            //UC6
            //management.DisplayUnskippedRecords(productReviewList);

            //UC7
            //management.SelectProductIDAndReviews(productReviewList);

            //UC9
            //Console.WriteLine("\n*****************************DataTable Operations*************************");
            //ProductReviewDataTable reviewDataTable = new ProductReviewDataTable();
            //DataTable table = reviewDataTable.CreateDataBleAndAddDefaultValues();
            //reviewDataTable.DisplayDataTableRecordsWithIsLikeValueTrue(table);

            //UC10
            //reviewDataTable.FindAverageRatingOfEachProductID(table);

            //UC11
            //reviewDataTable.RetrievRecordsWhoseReviewIsNice(table);

            //UC12
            //reviewDataTable.RetrievRecordsOfPerticularUserID(table);

        }
    }
}
