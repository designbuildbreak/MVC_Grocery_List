using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.Entity;


namespace MVC_Grocery_List.Models
{
    public class GroceryItem
    {
        public int ID { get; set; }
        public string Name { get; set; }
        public string FoodGroup { get; set; }
        public decimal Price { get; set; }
    }

    public class GroceryListDBContext : DbContext
    {
        public DbSet<GroceryItem> GroceryItems { get; set; } //Looks like the database table is named GroceryItems.mdf
    }
}