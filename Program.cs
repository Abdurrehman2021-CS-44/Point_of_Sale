using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PointOfSale.BL;

namespace PointOfSale
{
    class Program
    {
        static int productCount = 0;
        static void Main(string[] args)
        {
            productInfo[] Product = new productInfo[10];
            string option;
            option = " ";
            while (true)
            {
                option = menu();
                if (option == "1")
                {
                    Product[productCount] = addProduct();
                    productCount++;
                }
                else if (option == "2")
                {
                    Console.WriteLine("ID\t\tName\t\tPrice\tCatg\tBrand Name\tCountry");
                    for (int i = 0; i < productCount; i++)
                    {
                        viewProduct(Product, i);
                    }
                }
                else if (option == "3")
                {
                    total(Product);
                }
                else if (option == "4")
                {
                    Console.Clear();
                    break;
                }
                else
                {
                    Console.WriteLine("Invalid Input");
                    Console.Write("Press any key to continue...");
                    Console.ReadKey();
                    continue;
                }
                Console.Write("Press any key to continue...");
                Console.ReadKey();
            }
        }
        static string menu()
        {
            Console.WriteLine("1. Add Product");
            Console.WriteLine("2. Show Product");
            Console.WriteLine("3. Product Worth");
            Console.WriteLine("4. Exit");
            Console.Write("Your Option...");
            string option;
            option = Console.ReadLine();
            return option;
        }
        static productInfo addProduct()
        {
            productInfo P = new productInfo();
            Console.Write("Product ID : ");
            P.pID = Console.ReadLine();
            Console.Write("Product Name : ");
            P.pName = Console.ReadLine();
            Console.Write("Product Price : ");
            P.pPrice = float.Parse(Console.ReadLine());
            Console.Write("Product Category : ");
            P.pCateg = Console.ReadLine();
            Console.Write("Product Brand Name : ");
            P.pBrandName = Console.ReadLine();
            Console.Write("Product Country : ");
            P.pCountry = Console.ReadLine();
            return P;
        }
        static void viewProduct(productInfo[] P, int i)
        {
            Console.WriteLine(P[i].pID + "\t\t" + P[i].pName + "\t\t" + P[i].pPrice + "\t" + P[i].pCateg + "\t\t" + P[i].pBrandName + "\t\t" + P[i].pCountry);
        }
        static void total(productInfo[] P)
        {
            float sum = 0;
            for(int i = 0; i < productCount; i++)
            {
                sum = sum + P[i].pPrice;
            }
            Console.WriteLine("Total Product : " + productCount);
            Console.WriteLine("Products Worth : " + sum);
        }
    }
}
