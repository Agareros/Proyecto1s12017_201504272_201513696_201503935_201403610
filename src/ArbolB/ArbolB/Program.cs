using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArbolB
{
    class Program
    {

        static int contador;
        static Random random;
        static Arbol Raiz;

        static void Main(string[] args)
        {
            random = new Random();
            Raiz = new Arbol(random);
            Insertar();
        }

        private static void Insertar() {
            for (int contador = 0; contador < 5; contador++)
            {
                Nodo Nuevo = new Nodo(contador + "", "Usuario" + contador, "Empresa" + contador, "Ventas", "Hoy :v", "Un siglo", random);
                Raiz.Insertar(ref Raiz.Raiz, Nuevo);
                Raiz.Graficar();
            }
            Console.ReadLine();
        }

    }
}
