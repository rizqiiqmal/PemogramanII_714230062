﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace P4_1_714230062
{
    internal class ProductTest_714230062
    {
        static void Main(string[] args)
        {
            //Product_714230062 myProduct = new Product_714230062();

            //jawaban no 14 sehingga bisa running
            //Console.WriteLine(myProduct.GetMyType());

            //myProduct.MyType = "DVD";

            //Console.WriteLine(myProduct.MyType);

            Book_714230062 product1 = new Book_714230062("Book", "C# Object Oriented Solution", "300");
            DVD_714230069 product2 = new DVD_714230069("Ethernal Sunshine Of The Spotless Mind", "145");

            product1.DisplayInfo();
            product2.DisplayInfo();


        }
    }
}
