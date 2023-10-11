using Microsoft.EntityFrameworkCore;
using System.ComponentModel.DataAnnotations;

namespace Kursovaya
{
    public class Buyer
    {
        [Key]
        public int Buyer_Id { get; set; }
        public string Buyer_Fio { get; set; }
        public string Buyer_Phone { get; set; }
    }
    public class Manager
    {
        [Key]
        public int Manager_Id { get; set; }
        public string Manager_Fio { get; set; }
        public string Manager_Phone { get; set;}
    }
    public class Product
    {
        [Key]
        public int Product_Id { get; set; }
        public string Product_Name { get; set; }
        public string Product_Type { get; set; }
        public int Product_Price { get; set; }
    }
    public class Deal
    {
        [Key]
        public int Deal_Id { get; set; }
        public int Buyer_Id { get; set; }
        public int Manager_Id { get; set; }
        public int Product_Id { get; set; }
    }
    public class BuyerDbContext : DbContext
    {
        public static string sqlstr = "Data Source=(LocalDB)\\MSSQLLocalDB;AttachDbFilename=C:\\Users\\USER\\Documents\\LombardDb.mdf;Integrated Security=True;Connect Timeout=30";
        public DbSet<Buyer> Buyers { get; set; }
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(sqlstr);
        }
        public static void AddBuyer(string BuyerFio, string BuyerPhone)
        {
            using(BuyerDbContext context = new BuyerDbContext())
            {
                Buyer buyer = new Buyer
                {
                    Buyer_Fio = BuyerFio,
                    Buyer_Phone = BuyerPhone
                };
                context.Buyers.Add(buyer);
                context.SaveChanges();
            }
        }
        public static void RemoveBuyer(int BuyerId)
        {
            using(BuyerDbContext context = new BuyerDbContext())
            {
                var buyer = context.Buyers.FirstOrDefault(el => el.Buyer_Id == BuyerId);
                context.Remove(buyer);
                context.SaveChanges();
            }
        }
        public static void EditBuyer(int BuyerId, string BuyerFio, string BuyerPhone)
        {
            using(BuyerDbContext context = new BuyerDbContext())
            {
                var buyer = context.Buyers.FirstOrDefault(el => el.Buyer_Id == BuyerId);
                buyer.Buyer_Fio = BuyerFio;
                buyer.Buyer_Phone = BuyerPhone;
                context.SaveChanges();
            }
        }
    }
    public class ManagerDbContext : DbContext
    {
        public static string sqlstr = "Data Source=(LocalDB)\\MSSQLLocalDB;AttachDbFilename=C:\\Users\\USER\\Documents\\LombardDb.mdf;Integrated Security=True;Connect Timeout=30";
        public DbSet<Manager> Managers { get; set; }
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(sqlstr);
        }
        public static void AddManager(string ManagerFio, string ManagerPhone)
        {
            using(ManagerDbContext context = new ManagerDbContext())
            {
                Manager manager = new Manager
                {
                    Manager_Fio = ManagerFio,
                    Manager_Phone = ManagerPhone
                };
                context.Managers.Add(manager);
                context.SaveChanges();
            }
        }
        public static void RemoveManager(int ManagerId)
        {
            using(ManagerDbContext context = new ManagerDbContext())
            {
                var manager = context.Managers.FirstOrDefault(el => el.Manager_Id == ManagerId);
                context.Remove(manager);
                context.SaveChanges();
            }
        }
        public static void EditManager(int ManagerId, string ManagerFio, string ManagerPhone)
        {
            using(ManagerDbContext context = new ManagerDbContext())
            {
                var manager = context.Managers.FirstOrDefault(el => el.Manager_Id == ManagerId);
                manager.Manager_Fio = ManagerFio;
                manager.Manager_Phone = ManagerPhone;
                context.SaveChanges();
            }
        }
    }
    public class ProductDbContext : DbContext
    {
        public static string sqlstr = "Data Source=(LocalDB)\\MSSQLLocalDB;AttachDbFilename=C:\\Users\\USER\\Documents\\LombardDb.mdf;Integrated Security=True;Connect Timeout=30";
        public DbSet<Product> Products { get; set; }
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(sqlstr);
        }
        public static void AddProduct(string ProductName, string ProductType, int ProductPrice)
        {
            using(ProductDbContext context = new ProductDbContext())
            {
                Product product = new Product
                {
                    Product_Name = ProductName,
                    Product_Type = ProductType,
                    Product_Price = ProductPrice
                };
                context.Add(product);
                context.SaveChanges();
            }
        }
        public static void RemoveProduct(int ProductId)
        {
            using(ProductDbContext context = new ProductDbContext())
            {
                var product = context.Products.FirstOrDefault(el => el.Product_Id == ProductId);
                context.Remove(product);
                context.SaveChanges();
            }
        }
        public static void EditProduct(int ProductId, string ProductName, string ProductType, int ProductPrice)
        {
            using(ProductDbContext context = new ProductDbContext())
            {
                var product = context.Products.FirstOrDefault(el => el.Product_Id == ProductId);
                product.Product_Name = ProductName;
                product.Product_Type = ProductType;
                product.Product_Price = ProductPrice;
                context.SaveChanges();
            }
        }
    }
    public class DealDbContext : DbContext
    {
        public static string sqlstr = "Data Source=(LocalDB)\\MSSQLLocalDB;AttachDbFilename=C:\\Users\\USER\\Documents\\LombardDb.mdf;Integrated Security=True;Connect Timeout=30";
        public DbSet<Deal> Deals { get; set; }
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(sqlstr);
        }
        public static void AddDeal(int BuyerId, int ManagerId, int ProductId)
        {
            using (DealDbContext context = new DealDbContext())
            {
                Deal deal = new Deal
                {
                    Buyer_Id = BuyerId,
                    Manager_Id = ManagerId,
                    Product_Id = ProductId
                };
                context.Add(deal);
                context.SaveChanges();
            }
        }
        public static void RemoveDeal(int DealId)
        {
            using(DealDbContext context = new DealDbContext())
            {
                var deal = context.Deals.FirstOrDefault(el => el.Deal_Id == DealId);
                context.Remove(deal);
                context.SaveChanges();
            }
        }
        public static void EditDeal(int DealId, int BuyerId, int ManagerId, int ProductId)
        {
            using(DealDbContext context = new DealDbContext())
            {
                var deal = context.Deals.FirstOrDefault(el => el.Deal_Id == DealId);
                deal.Buyer_Id = BuyerId;
                deal.Manager_Id = ManagerId;
                deal.Product_Id = ProductId;
                context.SaveChanges();
            }
        }
    }
}