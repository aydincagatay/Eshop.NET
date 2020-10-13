using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.Entity;

namespace ecom.Entity
{
    public class DataInitializer: DropCreateDatabaseIfModelChanges<DataContext>
    {
        protected override void Seed(DataContext context)
        {
            var categories = new List<Category>() {
                new Category(){Name="Elbise", Description="Elbise ürünleri"},
                new Category(){Name="Aksesuar", Description="Aksesuar ürünleri"}
            };
            foreach(var category in categories)
            {
                context.Categories.Add(category);
            }
            context.SaveChanges();
            var product = new List<Product>()
            {

                new Product(){Name="Koton Elbise",Description="Koton Elbise ürünü", Price =50, Stock=50,IsHome=true,CategoryID=1,Image="koton.jpg", IsApproved=true,IsFeatured=false},
                new Product(){Name="Colins Şapka",Description="Colins Şapka ürünü", Price =45, Stock=45,IsHome=false,CategoryID=2,Image="colins.jpg", IsApproved=true,IsFeatured=false},
                new Product(){Name="USPA tshirt",Description="USPA tshirt ürünü", Price =40, Stock=40,IsHome=true,CategoryID=1,Image="uspa.jpg", IsApproved=true,IsFeatured=false},
            };
            foreach (var p in product)
            {
                context.Products.Add(p);
            }
            context.SaveChanges();
            base.Seed(context);
        }
    }
}