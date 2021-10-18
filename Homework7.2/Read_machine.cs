using System;
using System.Collections.Generic;
using System.Text;
using System.IO;
using System.Text;

namespace Homework7._2
{
    class Read_machine
    {
        public List<Product> products_list = new List<Product>();// = new List<Product>();

        public Read_machine()
        {
           
        }

        public void read_method()
        {

            using (StreamReader file = new StreamReader(@"C:\Users\Ruslanchik\source\repos\Homework7.2\Menu.txt"))
            {
                int counter = 0;
                string ln;


                while ((ln = file.ReadLine()) != null)
                {

                    bool check = true;
                    string[] temp_ln = ln.Split(' ');
                    if (ln.Split(' ').Length == 2)
                    {
                        //int i = products_list.Count - 1;
                        for (int i = 0; i < products_list.Count; i++)
                        {
                            if (products_list[i].Name == temp_ln[0])
                            {
                                products_list[i].Weight += double.Parse(temp_ln[1]);
                                check = false;
                            }
                        }
                        if (check)
                        {
                            check = true;
                            Product temp = new Product(temp_ln[0], 0, double.Parse(temp_ln[1]));
                            products_list.Add(temp);

                        }
                    }

                }

            }
            using (StreamReader file = new StreamReader(@"C:\Users\Ruslanchik\source\repos\Homework7.2\Price.txt"))
            {
                string ln;
                while ((ln = file.ReadLine()) != null)
                {
                    bool check = false;
                    string[] temp_ln = ln.Split(' ');
                    try
                    {
                        for (int i = 0; i < products_list.Count; i++)
                        {
                            if (products_list[i].Name == temp_ln[0])
                            {
                                products_list[i].Price = products_list[i].Weight * double.Parse(temp_ln[1]);
                                check = true;
                            }

                        }
                        if (!check)
                        {
                            throw new Exception("Product doesnt exist in list");
                        }
                    }
                    catch (Exception ex)
                    {
                        Console.WriteLine(ex.Message);
                    }
                }
            }
        }
    }
}
 
 
