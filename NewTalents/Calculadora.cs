using System;
using System.Linq;

namespace NewTalents
{
    public class Calculadora
    {
        private List<string> ListaHistorico;
        private string data;

        public Calculadora(string data)
        {
            ListaHistorico = new List<string>();
            this.data = data;
        }

        public int Somar(int val1, int val2)
        {
            int res = val1 + val2;
            ListaHistorico.Insert(0, "Res: " + res + " - data: " + data);
            return res;
        }

        public int Subtrair(int val1, int val2)
        {
            int res = val1 - val2;
            ListaHistorico.Insert(0, "Res: " + res + " - data: " + data);
            return res;
        }

        public int Multiplicar(int val1, int val2)
        {
            int res = val1 * val2;
            ListaHistorico.Insert(0, "Res: " + res + " - data: " + data);
            return res;
        }

        public int Dividir(int val1, int val2)
        {
            if (val2 == 0)
            {
                throw new DivideByZeroException("Não é possível dividir por zero.");
            }
            int res = val1 / val2;
            ListaHistorico.Insert(0, "Res: " + res + " - data: " + data);
            return res;
        }

        public List<string> Historico()
        {
            if (ListaHistorico.Count > 3)
            {
                ListaHistorico.RemoveRange(3, ListaHistorico.Count - 3);
            }
            return ListaHistorico;
        }
    }
}








