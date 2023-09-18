namespace MVC_LAP.Models
{
    public  static class  ListofProducts
    {
        public static List<Products> productss { get; set; }
       
        static ListofProducts()
        {
            productss = new List<Products>();
            productss.Add(new Products { id = 1, Name = "APPLE", Description = "Best Selar", price = 8000, imgurl = "1.PNG" });
            productss.Add(new Products { id = 2, Name = "IPhone", Description = "Less Selar", price = 3000, imgurl = "2.PNG" });
            productss.Add(new Products { id = 3, Name = "IPAD", Description = "Less Selar", price = 2000, imgurl = "3.PNG" });
            productss.Add(new Products { id = 4, Name = "Mac", Description = "Best Selar", price = 10000, imgurl = "4.PNG" });

        }
     

    }
}
