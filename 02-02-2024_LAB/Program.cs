using _02_02_2024_LAB;

//List<Product> products = new List<Product>();

//products.Add(new Product("Milk", 11, new DateTime(2023, 12, 30)));
//products.Add(new Product("Chocholate", 14, new DateTime(2024, 10, 30)));
//products.Add(new Product("Meat", 33, new DateTime(2022, 02, 27)));
//products.Add(new Product("Egg", 11, new DateTime(2024, 02, 22)));

//List<Product> passedExpireDate= new List<Product>();

//var expiredProductList = products.FindAll(x => x.ExpireDate < DateTime.Now);

//ShowAll(expiredProductList);

//static void ShowAll(List<Product> products)
//{
//    foreach (var item in products)
//    {
//        Console.WriteLine(item);
//    }
//}

//var MoreThan10 = products.FindAll(x => x.Price > 10 && (x.ExpireDate - DateTime.Now).TotalDays < 30 && !CheckExpDate(x.ExpireDate));


//static bool CheckExpDate(DateTime date)
//{
//    return date < DateTime.Now;
//}
//static void PassExpiredAndLess1Month(List<Product> products)
//{
//    foreach (var item in products)
//    {
//        Console.WriteLine(item);
//    }
//}

//Console.WriteLine("=====More Than 10 and Passed Expire Date=====\n");
//PassExpiredAndLess1Month(MoreThan10);



//var RemovePassedExpireDate = products.RemoveAll(x => CheckExpDate(x.ExpireDate));

//foreach (var item in products)
//{
//    Console.WriteLine(item);
//}


//string opt;
//do
//{
//    Console.WriteLine("\t\tMENU\n");
//    Console.WriteLine("1. Add");
//    Console.WriteLine("2. Remove By No");
//    Console.WriteLine("3. Show By No");
//    Console.WriteLine("4. Remove Expired Products");
//    Console.WriteLine("5. Search Products");
//    Console.WriteLine("0. Exit");

//    Console.WriteLine("Select Option: ");
//    opt = Console.ReadLine();

//    switch (opt)
//    {
//        case "1":
//            string name;
//            do
//            {
//                Console.WriteLine("Product Name: ");
//                name = Console.ReadLine();
//            } while (String.IsNullOrWhiteSpace(name));

//            double price;
//            string priceStr;
//            do
//            {
//                Console.WriteLine("Enter Price: ");
//                priceStr = Console.ReadLine();
//            } while (!double.TryParse(priceStr, out price));


//            DateTime exDate;
//            string exDateStr;
//            do
//            {
//                Console.WriteLine("Enter ExpireDate(Year-Month-Day): ");
//                exDateStr = Console.ReadLine();
//            } while (!DateTime.TryParse(exDateStr,out exDate));

//            foreach (var item in products)
//            {
//                if (item.Name == name)
//                {
//                    Console.WriteLine("Product already exists");
//                    break;
//                }
//            }

//            products.Add(new Product(name, price, exDate));
//            Console.WriteLine("Added Successfully");

//            break;
//        case "2":
//            ShowAll(products);
//            string noStr;
//            int no;
//            do
//            {
//                Console.WriteLine("Enter No: ");
//                noStr = Console.ReadLine();
//            } while (!int.TryParse(noStr, out no));


//            bool foundProduct = false;
//            foreach (var item in products)
//            {
//                if (item.No == no)
//                {
//                    foundProduct = true;
//                    products.Remove(item);
//                    break;
//                }
//            }
//            if (foundProduct)
//            {

//                Console.WriteLine("Removed Succesfully");
//            }
//            else
//            {
//                Console.WriteLine("Product Not found!");
//            }
//            break;
//        case "3":
//            string strNo;
//            int No;
//            do
//            {
//                Console.WriteLine("Enter No: ");
//                strNo = Console.ReadLine();
//            } while (!int.TryParse(strNo, out No));

//            bool foundProductNo = false;
//            foreach (var item in products)
//            {
//                if (item.No == No)
//                {
//                    foundProductNo = true;
//                    Console.WriteLine(item);
//                }
//            }
//            if (!foundProductNo)
//            {
//                Console.WriteLine("Product Not Found!");
//            }
//            break;
//        case "4":
//            var RemovePassedExpireDate = products.RemoveAll(x => CheckExpDate(x.ExpireDate));
//            Console.WriteLine("Last Version Of Products:\n");
//            ShowAll(products);
//            break;
//        case "5":
//            string str;
//            do
//            {
//                Console.WriteLine("Search: ");
//                str = Console.ReadLine();
//            } while (String.IsNullOrWhiteSpace(str));

//            var SearchedProducts = products.FindAll(x => x.Name.ToLower().Contains(str.ToLower()));
//            Console.WriteLine("Products: \n");
//            ShowAll(SearchedProducts);
//            break;
//        case "0":
//            Console.WriteLine("Program Finished");
//            break;
//        default:
//            Console.WriteLine("Invalid Choice! Select Again");
//            break;
//    }

//} while (opt != "0");

Store store= new Store();
store.products.Add(new Product("Milk", 11, new DateTime(2023, 12, 30)));
store.products.Add(new Product("Chocholate", 14, new DateTime(2024, 10, 30)));
store.products.Add(new Product("Meat", 33, new DateTime(2022, 02, 27)));
store.products.Add(new Product("Egg", 11, new DateTime(2024, 02, 22)));


static void ShowAll(List<Product> products)
{
    foreach (var item in products)
    {
        Console.WriteLine(item);
    }
}

ShowAll(store.products);

void ShowProfit(List<Product> products)
{
    foreach (var item in products)
    {
        Console.WriteLine($"{item.No}.Profit - {item.SellPrice - item.CostPrice}");
    }
}

ShowProfit(store.products);