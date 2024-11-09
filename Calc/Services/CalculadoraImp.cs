using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Calc.Services
{
    
    public class CalculadoraImp
    {
        public CalculadoraImp()
        {
            listahistorico = new List<string>();
        }
        private List<string> listahistorico;
        public int Somar(int n1, int n2)
        {
            int res = n1 + n2;
            listahistorico.Insert(0, "Res: " + res);
            return res;
        }

        public int Subtrair(int n1, int n2)
        {
            int res = n1 - n2;
            listahistorico.Insert(0, "Res: " + res);
            return res;
        }
        public int Multiplicar(int n1, int n2)
        {
            int res = n1 * n2;
            listahistorico.Insert(0, "Res: " + res);
            return res;
        }
        public int Dividir(int n1, int n2)
        {
            int res = n1 / n2;
            listahistorico.Insert(0, "Res: " + res);
            return res;
        }
        public List<string> historico ()
        {
            listahistorico.RemoveRange(3, listahistorico.Count - 3);
            return listahistorico;
        }

    }
}
