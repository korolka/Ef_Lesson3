using DAL_V2.Entity;
using DAL_V2.Repository;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Design;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System;
using System.IO;
using Microsoft.Extensions.Configuration;



namespace DAL_V2
{
    public class EntityDatabase : DbContext
    {
        public DbSet<Category> Category { get; set; }
        public DbSet<User> User { get; set; }
        public DbSet<Product> Product { get; set; }
        public DbSet<Cart> Cart { get; set; }
        public DbSet<Word> Words { get; set; }
        public DbSet<KeyParams> KeyLink { get; set; }

        //public EntityDatabase(DbContextOptions<EntityDatabase> options) : base(options)
        //{
        //    Database.EnsureCreated();
        //}

        public EntityDatabase()
        {
            Database.EnsureCreated();
        }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(@"Server=(localdb)\MSSQLLocalDB;Database=EfLesson3;Trusted_Connection=True;");
        }


        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {

            User user1 = new User() { Id = 1, Name = "Vlad", Login = "HorseInPalto", Password = "qwerty", Email = "SobakaBarabaka@gmail.com" };
            User user2 = new User() { Id = 2, Name = "Andrew", Login = "Gyci", Password = "ytrewq", Email = "Gyci2021@gmail.com" };


            Category category1 = new Category() { Id = 1, Name = "Smartphone", Icon = "https://cdn.samsungshop.com.ua/products/7699/cover/133269/SM-A346_Galaxy-A34-5G_Awesome-Graphite_Front2.png" };
            Category category2 = new Category() { Id = 2, Name = "Car", Icon = "https://img.freepik.com/premium-vector/smiling-red-car-cartoon-white_29190-4845.jpg" };
            Category category3 = new Category() { Id = 3, Name = "Kettle", Icon = "https://etno-shop.ru/upload/iblock/d3a/s1200.jpg" };


            Word word1 = new Word() { Id = 1, KeyWord = "Gadget", Header = "iditional Info" };
            Word word2 = new Word() { Id = 2, KeyWord = "6s", Header = "Model" };
            Word word3 = new Word() { Id = 3, KeyWord = "Pro 13", Header = "Model" };
            Word word4 = new Word() { Id = 4, KeyWord = "H 1.6", Header = "Model" };
            Word word5 = new Word() { Id = 5, KeyWord = "1.8 tsi", Header = "Model" };
            Word word6 = new Word() { Id = 6, KeyWord = "TWK3P420", Header = "Model" };
            Word word7 = new Word() { Id = 7, KeyWord = "HENDI", Header = "name" };
            Word word8 = new Word() { Id = 8, KeyWord = "Profi Cook", Header = "name" };
            Word word9 = new Word() { Id = 9, KeyWord = "PC-HWS 1168", Header = "Model" };
            Word word10 = new Word() { Id = 10, KeyWord = "Color:Чорний", Header = "color" };


            Product product1 = new Product() { Id = 1, Name = "Iphone", Price = 10000, ActionPrice = 9500, DescriptionField1 = "Modern phone. This item was designed in 2016", DescriptionField2 = "It has 8 mp camera", ImageUrl = "https://support.apple.com/library/APPLE/APPLECARE_ALLGEOS/SP726/SP726-iphone6s-gray-select-2015.png", CategoryId = 1 };
            Product product2 = new Product() { Id = 2, Name = "MacBook", Price = 50000, ActionPrice = 550000, DescriptionField1 = "New Computer for all", DescriptionField2 = "a lot of features", ImageUrl = "https://ilounge.ua/files/articles/macbook-pro-2021-promo.jpg", CategoryId = 1 };
            Product product3 = new Product() { Id = 3, Name = "Opel Astra", Price = 100000, ActionPrice = 4500, DescriptionField1 = "Very comfortable car for family", DescriptionField2 = "5 doors", ImageUrl = "https://i.infocar.ua/i/12/187/1400x936.jpg", CategoryId = 2 };
            Product product4 = new Product() { Id = 4, Name = "Volkswagen Jetta", Price = 15000, ActionPrice = 10000, DescriptionField1 = "Big sedan for family", DescriptionField2 = "have very strong engine", ImageUrl = "https://cdn.motor1.com/images/mgl/JYjbJ/s1/4x3/2019-volkswagen-jetta-gli-live.webp", CategoryId = 2 };
            Product product5 = new Product() { Id = 5, Name = "Електрочайник BOSCH", Price = 1799, ActionPrice = 1499, DescriptionField1 = "Шкала рівня води\r\nЗі шкалою\r\nЗахист\r\nВимкнення при знятті з бази\r\nВід перегріву\r\nВід увімкнення без води", DescriptionField2 = "Тип нагрівального елемента\r\nПрихований (диск)\r\nТип\r\nЗвичайний\r\n", ImageUrl = "https://content.rozetka.com.ua/goods/images/big/18592642.jpg", CategoryId = 3 };
            Product product6 = new Product() { Id = 6, Name = "Машина для заварювання", Price = 12285, ActionPrice = 12285, DescriptionField1 = "Шкала рівня води\r\nЗі шкалою\r\nТип нагрівального елемента\r\nПрихований (диск)", DescriptionField2 = "Тип\r\nМашина для заварювання", ImageUrl = "https://content2.rozetka.com.ua/goods/images/big/13239860.jpg", CategoryId = 3 };
            Product product7 = new Product() { Id = 7, Name = "Диспенсер-нагрівач води", Price = 4900, ActionPrice = 3999, DescriptionField1 = "Тип нагрівального елемента\r\nПрихований (диск)", DescriptionField2 = "Тип\r\nДиспенсер-нагрівач води", ImageUrl = "Тип\r\nДиспенсер-нагрівач води", CategoryId = 3 };


            KeyParams keyParams1 = new KeyParams() { Id = 1, ProductId = 1, KeyWordsId = 1 };
            KeyParams keyParams2 = new KeyParams() { Id = 2, ProductId = 1, KeyWordsId = 2 };
            KeyParams keyParams3 = new KeyParams() { Id = 3, ProductId = 2, KeyWordsId = 3 };
            KeyParams keyParams4 = new KeyParams() { Id = 4, ProductId = 3, KeyWordsId = 4 };
            KeyParams keyParams5 = new KeyParams() { Id = 5, ProductId = 4, KeyWordsId = 5 };
            KeyParams keyParams6 = new KeyParams() { Id = 6, ProductId = 5, KeyWordsId = 6 };
            KeyParams keyParams7 = new KeyParams() { Id = 7, ProductId = 6, KeyWordsId = 7 };
            KeyParams keyParams8 = new KeyParams() { Id = 8, ProductId = 7, KeyWordsId = 8 };
            KeyParams keyParams9 = new KeyParams() { Id = 9, ProductId = 7, KeyWordsId = 9 };
            KeyParams keyParams10 = new KeyParams() { Id =10,ProductId = 7, KeyWordsId = 10 };



            Cart cart1 = new Cart() { ID = 1, UserId = 1,  ProductId = 2 };
            Cart cart2 = new Cart() { ID = 2, UserId  = 1, ProductId = 3 };
            Cart cart3 = new Cart() { ID = 3, UserId  = 2, ProductId = 4 };
            Cart cart5 = new Cart() { ID = 4, UserId  = 1, ProductId = 5 };
            Cart cart6 = new Cart() { ID = 5, UserId  = 1, ProductId = 6 };
            Cart cart7 = new Cart() { ID = 6, UserId  = 2, ProductId = 1 };
            Cart cart4 = new Cart() { ID = 7, UserId  = 2, ProductId = 7 };
            modelBuilder.Entity<User>().HasData(user1, user2);

            modelBuilder.Entity<Category>().HasData(category1, category2, category3);

            modelBuilder.Entity<Word>().HasData(word1, word2, word3, word4, word5, word6, word7, word8, word9, word10);

            modelBuilder.Entity<Product>().HasData(product1, product2, product3, product4, product5, product6, product7);

            modelBuilder.Entity<KeyParams>().HasData(keyParams1, keyParams2, keyParams3, keyParams4, keyParams5, keyParams6, keyParams7, keyParams8, keyParams9, keyParams10);

            modelBuilder.Entity<Cart>().HasData(cart1, cart2, cart3, cart4, cart5, cart6, cart7);

        }

    
    }
    //public class SampleContextFactory : IDesignTimeDbContextFactory<EntityDatabase>
    //{
    //    public EntityDatabase CreateDbContext(string[] args)
    //    {
    //        var optionsBuilder = new DbContextOptionsBuilder<EntityDatabase>();

    //        // получаем конфигурацию из файла appsettings.json
    //        ConfigurationBuilder builder = new ConfigurationBuilder();
    //        builder.SetBasePath(Directory.GetCurrentDirectory());
    //        builder.AddJsonFile("appsettings.json");
    //        IConfigurationRoot config = builder.Build();

    //        // получаем строку подключения из файла appsettings.json
    //        string connectionString = config.GetConnectionString("DefaultConnection");
    //        optionsBuilder.UseSqlServer(connectionString, opts => opts.CommandTimeout((int)TimeSpan.FromMinutes(10).TotalSeconds));
    //        return new EntityDatabase(optionsBuilder.Options);
    //    }
    //}
}
