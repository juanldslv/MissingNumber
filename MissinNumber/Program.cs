using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MissinNumber
{
    class Program
    {
        //Metodo principal 
        static void Main()
        {
            


            
            try
            {
                //Capturamos los datos de entrada por parte del usario. En Este caso el tamaño o cantidad de elementos que llevará la lista A seguido de un enter.
                Console.WriteLine("Please type the size of the list A");
                int nsize = Convert.ToInt32(Console.ReadLine());
                //Capturamos cada uno de los elementos que el usuario digita para llenar lista
                List<int?> ListA = new List<int?>();
                Console.WriteLine("Please type the elements of list A");
                //Utilizamos el ciclo for para llenar la lista.
                for (int i = 0; i < nsize; i++)
                {
                    ListA.Add(Convert.ToInt32(Console.ReadLine()));
                }
                //Capturamos los datos de entrada por parte del usario. En Este caso el tamaño o cantidad de elementos que llevará la lista A seguido de un enter.
                Console.WriteLine("Please type the size of the list B");
                int msize = Convert.ToInt32(Console.ReadLine());
                //Capturamos cada uno de los elementos que el usuario digita para llenar lista
                List<int?> ListB = new List<int?>();
                Console.WriteLine("Please type the elements of list B");
                //Utilizamos el ciclo for para llenar la lista.
                for (int i = 0; i < msize; i++)
                {
                    ListB.Add(Convert.ToInt32(Console.ReadLine()));
                }
                //Con estas funciones ordenamos las listas 
                ListA.OrderBy(x => x.Value);
                ListB.OrderBy(x => x.Value);
                if (Constraints.Validatesizeoflist(ListA))
                {
                    if (Constraints.Validatesizeoflist(ListB))
                    {
                        if (Constraints.Comparesizeoflists(nsize, msize))
                        {
                            if (Constraints.Validateelementsoflist(ListB))
                            {
                                if (Constraints.ValidateMaxAndMin(ListA))
                                {
                                    if (Constraints.ValidateMaxAndMin(ListB))
                                    {
                                        //Llenamos esta lista con los números que están perdidos.
                                        List<int?> ListLostnumbers = Operations.GetListOfLostNumbers(ListA, ListB);
                                        if (ListLostnumbers.Count>0)
                                        {
                                            Operations.PrintLostNumbers(ListLostnumbers);

                                        }
                                        else
                                        {
                                            Console.WriteLine("no missing numbers were found");
                                        }

                                    }
                                    else
                                    {
                                        Console.WriteLine("the list B does not meet the condition");
                                    }
                                }
                                else
                                {
                                    Console.WriteLine("the list A does not meet the condition");
                                }
                            }
                            else
                            {
                                Console.WriteLine("The list b does not meet the condition: 1 <= x <= 10⁴, x ε B");
                            }
                        }
                        else
                        {
                            Console.WriteLine("The list does not meet the condition: n <= m");
                        }
                    }
                    else
                    {
                        Console.WriteLine("The List B does not meet the condition: 1 <= n,m, <= 2 * 10⁵");
                    }
                }
                else
                {
                    Console.WriteLine("The List A does not meet the condition: 1 <= n,m, <= 2 * 10⁵");
                }


            }
            catch (Exception ex)
            {

                Console.WriteLine(ex.Message);
            }
            finally
            {
                Console.WriteLine("Press any key for finish");
                Console.ReadKey();
            }




         





    }
        
    }
}
