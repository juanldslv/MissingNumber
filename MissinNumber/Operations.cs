using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MissinNumber
{
    public class Operations
    {

        public static List<int?> GetListOfLostNumbers(IList<int?> A, IList<int?> B)
        { //Con este metodo obtenemos los números perdidos.
            List<int?> ListofLostNumbers = new List<int?>();

            int k = 0, j = 0;
            while (k < B.Count)
            {
                if (j < A.Count)
                {
                    int numB = B[k].Value;
                    int numA = A[j].Value;
                    if (numA == numB)
                    {
                        k++;
                        j++;
                    }
                    else
                    {
                        if (!ListofLostNumbers.Contains(numB))
                        {
                            ListofLostNumbers.Add(numB);
                        }
                        k++;
                    }
                }
                else
                {
                    if (!ListofLostNumbers.Contains(B[k]))
                    {
                        ListofLostNumbers.Add(B[k]);
                    }
                    k++;
                }

            }

            ListofLostNumbers.Sort();

            return ListofLostNumbers;
        }
        public static void PrintLostNumbers(List<int?> list)
        {// Con este metodo imprimos los numeros perdidos
            foreach (int? num in list)
            {
                Console.Write(num + " ");
            }
        }

    }
}
