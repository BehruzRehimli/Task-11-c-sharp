using Dersde_11_Task.Exaption;
using System;

namespace Dersde_11_Task
{
    internal class Program
    {

        static void Main(string[] args)
        {
            #region Dersde etdiklerimiz
            //    Course cr1 = new Course(50);
            //    Student st1 = new Student();
            //    Student st2 = new Student();
            //    Student st3 = new Student();
            //    cr1.AddStudent(st1);
            //    cr1.AddStudent(st2);
            //    cr1.AddStudent(st3);
            //    Console.WriteLine(cr1.SeachStudNo(3));



            //    int num;
            //    Convert1("5", out num);

            //}
            //static void Convert1(string input, out int num)
            //{
            //    try
            //    {
            //        num = Convert.ToInt32(input);
            //    }
            //    catch (Exception ex)
            //    {
            //        num = 0;
            //    }
            #endregion
            string input;
            Store store=new Store();
            do
            {
                Console.WriteLine("1.Product elave et.\n2.Butun productlara bax.\n3.Verilmish nomreli producta bax.\n0.Menyudan cix.");
                input= Console.ReadLine();
                switch (input)
                {
                    case "1":
                        Console.WriteLine("\nYeni mehsulun kateqoriyasini daxil edin: \n");
                        string catagory=Console.ReadLine();
                        Console.WriteLine("\nYeni mehsulun qiymetini daxil edin: \n");
                        bool isokey=false;
                        do
                        {
                            try
                            {
                                double price = Convert.ToInt32(Console.ReadLine());
                                Product product1 = new Product() { Category = catagory, Price = price };
                                store.AddProduct(product1);
                                isokey= true;
                            }
                            catch (PriceCantBeMinusException ex)
                            {
                                Console.WriteLine(ex.Message);
                            }
                            catch (Exception)
                            {
                                Console.WriteLine("\nZehmet olmasa qiymeti duzgun daxil edin.\n");
                            }
                        } while (isokey==false);
                        break;
                    case "2":
                        try
                        {
                            store.ShowAllProduct();
                        }
                        catch (ThereIsNoProductException ex)
                        {
                            Console.WriteLine(ex.Message);
                        }
                        break;
                    case "3":
                        bool Isokey = false;
                        Console.WriteLine("\nNeche nomreli mehsulu axtarirsiz?:\n");
                        do
                        {
                            string str = Console.ReadLine();
                            try
                            {
                                int no = Convert.ToInt32(str);
                                store.GetProductByNo(no).ShowInfo();
                                Isokey = true;
                            }
                            catch (ProductNotFoundException ex)
                            {
                                Isokey = true;
                                Console.WriteLine(ex.Message);
                            }
                            catch (ThereIsNoProductException ex) 
                            {
                                Isokey = true;
                                Console.WriteLine(ex.Message);
                            }
                            catch (Exception)
                            {
                                Console.WriteLine("Zehmet olmasa nomreni duzgun daxil edin");
                            }
                        } while (Isokey == false);
                        break; 
                    case "0":
                        Console.Write("\nEminsiz?(YES-y or NO-n):\n");
                        string i=Console.ReadLine();
                        if (i=="n")
                        {
                            input = "1";
                        }
                        break;
                    default:
                        Console.WriteLine("Sechiminzi duzgun daxil edin.");
                        break;
                }

            } while (input!="0");
        }
    }
}
