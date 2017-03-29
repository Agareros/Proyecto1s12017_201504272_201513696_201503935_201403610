using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ArbolB
{
    public class Pagina
    {
        public Nodo[] Nodos;
        public Pagina[] Ramas;
        public int Cuenta;

        public Pagina()
        {
            Nodos = new Nodo[5];
            Ramas = new Pagina[5];
            Cuenta = 0;
        }

        public Boolean isFull() {
            return Cuenta == 4;
        }

        public Boolean isEmpty() {
            return Cuenta == 0;
        }

    }
}