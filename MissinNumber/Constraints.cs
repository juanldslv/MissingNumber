using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MissinNumber
{
    class Constraints
    {
        //En esta clase tenemos las condiciones que van a validar las diferentes entradas del usuario.
        public static bool Validatesizeoflist(IList<int?> lst)
        {
            //Con este metodo validamos que el tamaño de las listas sea mayor que 1 y menor que 2x10⁵
            double Maxsizelst = 2 * Math.Pow(10, 5);
            if (lst.Count >= 1 && lst.Count <= Maxsizelst)
                return true;
            else
                return false;
            
        }
        public static bool Comparesizeoflists(int? nsize, int? msize)
        {
            //Con este metodo comparamos el tamaño de las listas que debe ser n<=m.
            if (nsize <= msize)
                return true;
            else
                return false;
     
        }
        public static bool Validateelementsoflist(IList<int?> lst)
        {
            //Con este metodo validamos que los valores de la list B esten en el rango 
            //1 <= x <= 10⁴, x ε B
            bool result = false;
            double Maxvalueallowed = Math.Pow(10, 4);
            foreach (int x in lst)
            { 
                if (x>=1 && x<=Maxvalueallowed)
                {
                    result=true;
                }
                else
                {
                    result = false;
                    break;
                }

            }
            return result;
        }
        public static bool ValidateMaxAndMin(IList<int?> lst)

        {
            //Con este metodo validamos la condición Xmax-Xmin<101
            int IMax = lst.Max(r=>r.Value);
            int IMin = lst.Min(r => r.Value);
            if ((IMax - IMin) > 100)
                return false;
            else
                return true;
        }


      
    }

    

}
