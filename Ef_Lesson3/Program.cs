using Microsoft.EntityFrameworkCore;
using Microsoft.IdentityModel.Tokens;
using System.Text;

namespace Ef_Lesson3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = Encoding.Unicode;
            using (DatabaseContext context = new DatabaseContext())
            {
                User user1 = new User() { Name = "Vlad", Login = "HorseInPalto", Password = "qwerty", Email = "SobakaBarabaka@gmail.com" };
                User user2 = new User() { Name = "Andrew", Login = "Gyci", Password = "ytrewq", Email = "Gyci2021@gmail.com" };

                context.Users.AddRange(user1,user2);

                Category category1 = new Category() { Name = "Smartphone", Icon = "https://cdn.samsungshop.com.ua/products/7699/cover/133269/SM-A346_Galaxy-A34-5G_Awesome-Graphite_Front2.png" };
                Category category2 = new Category() { Name = "Car", Icon = "https://img.freepik.com/premium-vector/smiling-red-car-cartoon-white_29190-4845.jpg" };
                Category category3 = new Category() { Name = "Kettle", Icon = "https://etno-shop.ru/upload/iblock/d3a/s1200.jpg" };

                context.Categories.AddRange(category1,category2,category3);

                Product product1 = new Product() { Name = "Iphone", Price = 10000, ActionPrice = 9500, DescriptionField1 = "Modern phone. This item was designed in 2016", DescriptionField2 = "It has 8 mp camera", ImageUrl = "https://support.apple.com/library/APPLE/APPLECARE_ALLGEOS/SP726/SP726-iphone6s-gray-select-2015.png", Category = category1 };
                Product product2 = new Product() { Name = "MacBook", Price = 50000, ActionPrice = 550000, DescriptionField1 = "New Computer for all", DescriptionField2 = "a lot of features", ImageUrl = "https://ilounge.ua/files/articles/macbook-pro-2021-promo.jpg", Category = category1 };
                Product product3 = new Product() { Name = "Opel Astra", Price = 100000, ActionPrice = 4500, DescriptionField1 = "Very comfortable car for family", DescriptionField2 = "5 doors", ImageUrl = "https://i.infocar.ua/i/12/187/1400x936.jpg", Category = category2 };
                Product product4 = new Product() { Name = "Volkswagen Jetta", Price = 15000, ActionPrice = 10000, DescriptionField1 = "Big sedan for family", DescriptionField2 = "have very strong engine", ImageUrl = "https://cdn.motor1.com/images/mgl/JYjbJ/s1/4x3/2019-volkswagen-jetta-gli-live.webp", Category = category2 };
                Product product5 = new Product() { Name = "Електрочайник BOSCH", Price = 1799, ActionPrice = 1499, DescriptionField1 = "Шкала рівня води\r\nЗі шкалою\r\nЗахист\r\nВимкнення при знятті з бази\r\nВід перегріву\r\nВід увімкнення без води", DescriptionField2 = "Тип нагрівального елемента\r\nПрихований (диск)\r\nТип\r\nЗвичайний\r\n", ImageUrl = "https://content.rozetka.com.ua/goods/images/big/18592642.jpg", Category = category3 };
                Product product6 = new Product() { Name = "Машина для заварювання", Price = 12285, ActionPrice = 12285, DescriptionField1 = "Шкала рівня води\r\nЗі шкалою\r\nТип нагрівального елемента\r\nПрихований (диск)", DescriptionField2 = "Тип\r\nМашина для заварювання", ImageUrl = "https://content2.rozetka.com.ua/goods/images/big/13239860.jpg", Category = category3 };
                Product product7 = new Product() { Name = "Диспенсер-нагрівач води", Price = 4900, ActionPrice = 3999, DescriptionField1 = "Тип нагрівального елемента\r\nПрихований (диск)", DescriptionField2 = "Тип\r\nДиспенсер-нагрівач води", ImageUrl = "Тип\r\nДиспенсер-нагрівач води", Category = category3 };

                context.Products.AddRange(product1,product2,product3,product4,product5,product6,product7);

                Cart cart1 = new Cart() { User = user1, Product = product2 };
                Cart cart2 = new Cart() { User = user1, Product = product3 };
                Cart cart3 = new Cart() { User = user2, Product = product4 };
                Cart cart5 = new Cart() { User = user1, Product = product5 };
                Cart cart6 = new Cart() { User = user1, Product = product6 };
                Cart cart7 = new Cart() { User = user2, Product = product1 };
                Cart cart4 = new Cart() { User = user2, Product = product7 };

                context.Carts.AddRange(cart1,cart2,cart3,cart4,cart5,cart6,cart7);

                Word word1 = new Word() { KeyWord = "Gadget",Header ="iditional Info" };
                Word word2 = new Word() { KeyWord = "6s",Header="Model" };
                Word word3 = new Word() { KeyWord = "Pro 13",Header ="Model" };
                Word word4 = new Word() { KeyWord = "H 1.6" , Header = "Model" };
                Word word5 = new Word() { KeyWord = "1.8 tsi" , Header = "Model" };
                Word word6 = new Word() { KeyWord = "TWK3P420",Header = "Model" };
                Word word7 = new Word() { KeyWord = "HENDI" , Header = "name" };
                Word word8 = new Word() { KeyWord = "Profi Cook" , Header = "name"  };
                Word word9 = new Word() { KeyWord = "PC-HWS 1168",Header = "Model" };
                Word word10 = new Word() { KeyWord = "Color:Чорний", Header ="color" };

                context.Words.AddRange(word1,word2,word3,word4,word5,word6,word7,word8,word9,word10);

                KeyParams keyParams1 = new KeyParams() { Product = product1 , KeyWords = word1};
                KeyParams keyParams2 = new KeyParams() { Product = product1, KeyWords = word2 };
                KeyParams keyParams3 = new KeyParams() { Product = product2, KeyWords = word3 };
                KeyParams keyParams4 = new KeyParams() { Product = product3, KeyWords = word4 };
                KeyParams keyParams5 = new KeyParams() { Product = product4, KeyWords = word5 };
                KeyParams keyParams6 = new KeyParams() { Product = product5, KeyWords = word6 };
                KeyParams keyParams7 = new KeyParams() { Product = product6, KeyWords = word7 };
                KeyParams keyParams8 = new KeyParams() { Product = product7, KeyWords = word8 };
                KeyParams keyParams9 = new KeyParams() { Product = product7, KeyWords = word9 };
                KeyParams keyParams10 = new KeyParams() { Product = product7, KeyWords = word10 };

                context.KeyParams.AddRange(keyParams1, keyParams2, keyParams3, keyParams4, keyParams5, keyParams6, keyParams7, keyParams8, keyParams9, keyParams10);
                context.SaveChanges();
            }//initialize

            //using (DatabaseContext databaseContext = new DatabaseContext())
            //{
            //    var users = databaseContext.Users.Include(c => c.Cart).ThenInclude(p => p.Product).ThenInclude(k => k.KeyWords).ThenInclude(k => k.KeyWords);
            //    Console.WriteLine("User ");
            //    foreach (var user in users)
            //    {
            //        Console.ForegroundColor = ConsoleColor.Blue;
            //        Console.WriteLine($"-{user.Name}");
            //        Console.ForegroundColor = ConsoleColor.Gray;
            //        foreach (var cart in user.Cart)
            //        {
            //            Console.Write($"--{cart.Product.Name}");
            //            foreach (var keyword in cart.Product.KeyWords)
            //            {
            //                Console.ForegroundColor = ConsoleColor.Green;
            //                Console.Write($"({keyword.KeyWords.KeyWord})\n");
            //                Console.ForegroundColor = ConsoleColor.Gray;
            //            }
            //        }

            //    }
            //}

            //using (DatabaseContext databaseContext1 = new DatabaseContext())
            //{
            //    StringBuilder builder = new StringBuilder();
            //    var categories = databaseContext1.Categories.Include(p => p.Products).ThenInclude(k => k.KeyWords).ThenInclude(k => k.KeyWords);
            //    foreach (var category in categories)
            //    {
            //        Console.ForegroundColor = ConsoleColor.Blue;
            //        builder.AppendLine($"-{category.Name}");
            //        Console.ForegroundColor = ConsoleColor.Gray;
            //        foreach (var product in category.Products)
            //        {
            //            builder.Append($"--{product.Name}");
            //            builder.Append("(");
            //            foreach (var keyWord in product.KeyWords)
            //            {
            //                Console.ForegroundColor = ConsoleColor.Green;
            //                builder.Append($"{keyWord.KeyWords.KeyWord}|");
            //                Console.ForegroundColor= ConsoleColor.Gray;
            //            }
            //            builder.Append(")");
            //            builder.AppendLine(Environment.NewLine);
            //        }
            //    }
            //    Console.WriteLine(builder.ToString());
            //}
        }
    }
}