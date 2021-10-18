using System;
using System.Collections.Generic;
using System.Text;

namespace Homework7._2
{
    class Product
    {
        private string name;
        public string Name
        {
            set
            {
                try
                {
                    name = value;
                }
                catch(FormatException ex)
                {
                    Console.WriteLine(ex.Message);
                }
            }
            get
            {
                return name;
            }

        }
        private double weight;
        public double Weight
        {
            set
            {
                try
                {
                    weight = value;
                }
                catch (FormatException ex)
                {
                    Console.WriteLine(ex.Message);
                }
            }
            get
            {
                return weight;
            }

        }
        private double price;
        public double Price
        {
            set
            {
                try
                {
                    price = value;
                }
                catch (FormatException ex)
                {
                    Console.WriteLine(ex.Message);
                }
            }
            get
            {
                return price;
            }

        }

        Product()
        {
            name = "-";
            price = 0;
            weight = 0;
        }

        public Product(string in_name, double in_price,double in_weight)
        {
            name = in_name;
            price = in_price;
            weight = in_weight;
        }

    }
}
