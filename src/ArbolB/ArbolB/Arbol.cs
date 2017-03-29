using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Web;

namespace ArbolB
{
    public class Arbol
    {
        public Pagina Raiz;
        private Random random;

        public Arbol(Random random)
        {
            this.random = random;
            Raiz = new Pagina();
        }

        private Boolean BuscarNodo(ref Pagina Actual, String ID, ref int Indice)
        {
            Boolean Encontrado = false;
            if (String.Compare(ID, Actual.Nodos[1].ID) < 0)
            {
                Indice = 0;
            }
            else
            {
                Indice = Actual.Cuenta;
                while (String.Compare(ID, Actual.Nodos[Indice].ID) < 0 && Indice > 1)
                {
                    Indice--;
                }
                Encontrado = String.Equals(ID, Actual.Nodos[Indice].ID, StringComparison.Ordinal);
            }
            return Encontrado;
        }
        /* REALIZA BÚSQUEDA POR NIVELES, RECORRIENDO LA PÁGINA 'Actual' RETORNANDO SI FUE ENCONTRADA O NO. */

        public Pagina Buscar(ref Pagina Actual, String ID, ref int Indice)
        {
            if (Actual == null)
            {
                return Actual;
            }
            else
            {
                Boolean Esta = BuscarNodo(ref Actual, ID, ref Indice);
                if (Esta)
                {
                    return Actual;
                }
                else
                {
                    return Buscar(ref Actual.Ramas[Indice], ID, ref Indice);
                }
            }
        }
        /* REALIZA BÚSQUEDA POR ALTURA, UTILIZANDO LA BÚSQUEDA POR NIVELES PARA VERIFICAR SI EXISTE O NO EN UNA PÁGINA, RETORNAN_
         * DO LA PÁGINA SI FUE ENCONTRADA Y 'null' SI NO. */

        public void Insertar(ref Pagina Raiz, Nodo Nuevo)
        {
            Boolean HayQueSubir = false;
            Nodo Mediana = new Nodo(random);
            Pagina Nueva = new Pagina();
            Empujar(ref Raiz, Nuevo, ref HayQueSubir, ref Mediana, ref Nueva);
            if (HayQueSubir)
            {
                Pagina Auxiliar = new Pagina();
                Auxiliar.Cuenta = 1;
                Auxiliar.Nodos[1] = Mediana;
                Auxiliar.Ramas[0] = Raiz;
                Auxiliar.Ramas[1] = Nueva;
                Raiz = Auxiliar;
            }
        }
        /* VERIFICA SI HAY QUE SUBIR UN NIVEL UN NODO, UTILIZANDO EL MÉTODO 'Empujar', Y LO HACE SI ES EL CASO. */

        private void Empujar(ref Pagina Actual, Nodo Nuevo, ref Boolean HayQueSubir, ref Nodo Mediana, ref Pagina Nueva)
        {
            int Indice = 0;
            if (Actual == null || Actual.isEmpty())
            {
                HayQueSubir = true;
                Mediana = Nuevo;
                Actual = null;
                Nueva = null;
            }
            else
            {
                Boolean Esta = BuscarNodo(ref Actual, Nuevo.ID, ref Indice);
                if (Esta)
                {
                    Console.WriteLine("Dato duplicado.");
                    HayQueSubir = false;
                    Actual = null;
                    return;
                }
                Empujar(ref Actual.Ramas[Indice], Nuevo, ref HayQueSubir, ref Mediana, ref Nueva);
                if (HayQueSubir)
                {
                    if (Actual.isFull()) { 
                        Pagina Auxiliar = new Pagina();
                        DividirNodo(ref Actual, Mediana, ref Nueva, Indice, ref Mediana, ref Auxiliar);
                    }
                    else
                    {
                        HayQueSubir = false;
                        InsertarEnHoja(ref Actual, Mediana, Nueva, Indice);
                    }
                }
            }
        }
        /* REALIZA VERIFICACIONES PARA COMPROBAR SI HAY QUE SUBIR DE NIVEL O NO; SI NO HAY QUE HACERLO, INSERTA EL NUEVO DATO. */

        private void DividirNodo(ref Pagina Actual, Nodo Nuevo, ref Pagina Auxiliar, int Indice, ref Nodo Mediana, ref Pagina Nueva)
        {
            int i;
            int posMdna = (Indice <= 5 / 2) ? 5 / 2 : 5 / 2 + 1;
            Nueva = new Pagina();
            for (i = posMdna + 1; i < 5; i++)
            {
                Nueva.Nodos[i - posMdna] = Actual.Nodos[i];
                Nueva.Ramas[i - posMdna] = Actual.Ramas[i];
            }
            Nueva.Cuenta = 4 - posMdna;
            Actual.Cuenta = posMdna;
            if (Indice <= 5 / 2)
            {
                InsertarEnHoja(ref Actual, Nuevo, Auxiliar, Indice);
            }
            else
            {
                InsertarEnHoja(ref Nueva, Nuevo, Auxiliar, Indice - posMdna);
            }
            Mediana = Actual.Nodos[Actual.Cuenta];
            Nueva.Ramas[0] = Actual.Ramas[Actual.Cuenta];
            Actual.Cuenta--;
        }
        /* DIVIDE LA PÁGINA 'Actual' EN TRES PARTES: A LA IZQUIERDA ESTARÁ LA PÁGINA QUE SE TENÍA ANTES, PERO SIN EL DATO QUE SE
         * DEBE SUBIR DE NIVEL; EL NODO 'Mediana' SE CONVERTIRÁ LA RAIZ, PUES ES EL VALOR MEDIO, EL QUE SE DEBE SUBIR DE NIVEL;
         * POR ÚLTIMO, A LA DERECHA SE TENDRÁ UNA PÁGINA 'Nueva' QUE CONTENDRÁ LOS DATOS QUE SE TENÍAN ANTES "A LA DERECHA DEL
         * VALOR MEDIO" EN LA PÁGINA QUE SE DIVIDIÓ. */

        private void InsertarEnHoja(ref Pagina Actual, Nodo Nuevo, Pagina Auxiliar, int Indice)
        {
            int PosicionActual;
            for (PosicionActual = Actual.Cuenta; PosicionActual >= Indice + 1; PosicionActual--)
            {
                Actual.Nodos[PosicionActual + 1] = Actual.Nodos[PosicionActual];
                Actual.Ramas[PosicionActual + 1] = Actual.Ramas[PosicionActual];
            }
            Actual.Nodos[Indice + 1] = Nuevo;
            Actual.Ramas[PosicionActual + 1] = Auxiliar;
            Actual.Cuenta++;
        }
        /* INSERTA EL NODO 'Nuevo' EN LA PÁGINA 'Actual', CUANDO ESTA SE ENCUENTRA EN EL ÚLTIMO NIVEL DEL ÁRBOL. */
        
        public void Eliminar(ref Pagina Raiz, String ID)
        {
            Boolean Encontrado = false;
            EliminarNodo(ref Raiz, ID, ref Encontrado);
            if (Encontrado)
            {
                Console.Write("Dato "+ ID + " fue eliminada.");
                if (Raiz.Cuenta == 0)
                {
                    Raiz = Raiz.Ramas[0];
                }
            }
            else
            {
                Console.Write("No existe en el árbol.");
            }
        }
        /* MANDA A ELIMINAR EL NODO CON EL ID SOLICITADO E IMPRIME EN CONSOLA SI FUE ELIMINADO O NO. */

        private void EliminarNodo(ref Pagina Actual, String ID, ref Boolean Encontrado)
        {
            int Indice = 0;
            if (Actual != null)
            {
                Encontrado = BuscarNodo(ref Actual, ID, ref Indice);
                if (Encontrado)
                {
                    if (Actual.Ramas[Indice - 1] == null)
                        Remover(ref Actual, Indice);
                    else
                    {
                        PorSucesor(ref Actual, Indice);
                        EliminarNodo(ref Actual.Ramas[Indice], Actual.Nodos[Indice].ID, ref Encontrado);
                    }
                }
                else {
                    EliminarNodo(ref Actual.Ramas[Indice], ID, ref Encontrado);
                }
                if (Actual.Ramas[Indice] != null && Actual.Ramas[Indice].Cuenta < 5 / 2)
                {
                    Restaurar(ref Actual, Indice);
                }
            }
            else
            {
                Encontrado = false;
            }
        }
        /* BUSCA EL NODO QUE CONTIENE EL 'ID' DESEADO Y VERIFICA SI SE ENCUENTRA EN UNA PÁGINA QUE CUMPLE CON SER UN NODO HOJA
         * DEL ÁRBOL, SI ES ASÍ SÓLO LO REMUEVE DE DICHA HOJA, SI NO DEBE ELIMINAR EL NODO DESEADO Y SUSTITUIR POR EL NODO SU_
         * CESOR, POR ÚLTIMO VERIFICA QUE LA PÁGINA SIGA CUMPLIENDO CON LAS RESTRICCIONES POR HOJA Y SI NO ES ASÍ, SE DEBE RES_
         * TAURAR EL SUBARBOL QUE TIENE EN LA PÁGINA 'Actual'. */

        private void Remover(ref Pagina Actual, int Indice)
        {
            for (int j = Indice + 1; j <= Actual.Cuenta; j++)
            {
                Actual.Nodos[j - 1] = Actual.Nodos[j];
                Actual.Ramas[j - 1] = Actual.Ramas[j];
            }
            Actual.Cuenta--;
        }
        /* QUITA EL NODO EN LA POSICIÓN 'Indice' Y REALIZA UN CORRIMIENTO DE DATOS. */

        private void PorSucesor(ref Pagina Actual, int Indice)
        {
            Pagina Auxiliar = Actual.Ramas[Indice];
            while (Auxiliar.Ramas[0] != null)
            {
                Auxiliar = Auxiliar.Ramas[0];
            }
            Actual.Nodos[Indice] = Auxiliar.Nodos[1];
        }
        /* BUSCA EL NODO SUCESOR DE LA PÁGINA 'Actual' (EL MÁS A LA IZQUIERDA DE LOS NODOS QUE SE ENCUENTRAN A LA DERECHA). */

        private void Restaurar(ref Pagina Actual, int Indice)
        {
            if (Indice > 0)
            {
                if (Actual.Ramas[Indice - 1].Cuenta > 5 / 2)
                {
                    MovimientoDerecha(ref Actual, Indice);
                }
                else
                {
                    Combinar(Actual, Indice);
                }
            }
            else
            {
                if (Actual.Ramas[1].Cuenta > 5 / 2)
                {
                    MovimientoIzquierda(ref Actual, 1);
                }
                else
                {
                    Combinar(Actual, 1);
                }
            }
        }
        /* VERIFICA SI LA PÁGINA 'Actual', DEL LADO IZQUIERDO O DERECHO POSEE HIJOS APARTE DE LA RAMA QUE AHORA SE ENCUENTRA
         * DESEQUILIBRADA, SI ES ASÍ, REALIZA UN MOVIMIENTO EN UNA DIRECCIÓN QUE DEPENDERÁ DE DONDE ESTÉN SU(S) HERMANO(S):
         *      SI POSEE ALGÚN HERMANO DEL LADO IZQUIERDO, REALIZARÁ UN MOVIMIENTO HACIA LA DERECHA
         *      Y SI SÓLO TIENE HERMANOS A LA DERECHA, REALIZARÁ UN MOVIMIENTO A LA IZQUIERDA.
         * EN AMBOS CASOS SI NO SE CUMPLE QUE LA CANTIDAD DE NODOS EN LA PÁGINA SEA MAYOR A M/2, SE MANDA A COMBINAR LAS PÁ_
         * GINAS MANDÁNDOLE EL ÍNDICE. */

        private void MovimientoDerecha(ref Pagina Actual, int Indice)
        {
            Pagina Problema = Actual.Ramas[Indice];
            Pagina Izquierda = Actual.Ramas[Indice - 1];
            for (int j = Problema.Cuenta; j >= 1; j--)
            { 
                Problema.Nodos[j + 1] = Problema.Nodos[j];
                Problema.Ramas[j + 1] = Problema.Ramas[j];
            }
            Problema.Cuenta++;
            Problema.Ramas[1] = Problema.Ramas[0];
            Problema.Nodos[1] = Actual.Nodos[Indice];
            Actual.Nodos[Indice] = Izquierda.Nodos[Izquierda.Cuenta];
            Problema.Ramas[0] = Izquierda.Ramas[Izquierda.Cuenta];
            Izquierda.Cuenta--;
        }
        /* ESTABLECE LA PÁGINA 'Problema' Y SU HERMANO 'Izquierda', PROCEDE A MOVER A LOS NODOS DE LA PÁGINA 'Problema' PARA DE_
         * JAR UN ESPACIO PARA METER EL ÚLTIMO NODO DE SU HERMANO 'Izquierda'. */

        private void MovimientoIzquierda(ref Pagina Actual, int Indice)
        {
            Pagina Problema = Actual.Ramas[Indice - 1];
            Pagina Derecha = Actual.Ramas[Indice];
            Problema.Cuenta++;
            Problema.Nodos[Problema.Cuenta] = Actual.Nodos[Indice];
            Problema.Ramas[Problema.Cuenta] = Derecha.Ramas[0];
            Actual.Nodos[Indice] = Derecha.Nodos[1];
            Derecha.Ramas[1] = Derecha.Ramas[0];
            Derecha.Cuenta--;
            for (int j = 1; j <= Derecha.Cuenta; j++)
            {
                Derecha.Nodos[j] = Derecha.Nodos[j + 1];
                Derecha.Ramas[j] = Derecha.Ramas[j + 1];
            }
        }
        /* ESTABLECE LA PÁGINA 'Problema' Y SU HERMANO 'Derecha', PROCEDE A MOVER A LOS NODOS DE LA PÁGINA 'Problema' PARA DE_
         * JAR UN ESPACIO PARA METER EL ÚLTIMO NODO DE SU HERMANO 'Derecha'. */

        private void Combinar(Pagina Padre, int Indice)
        {
            int j;
            Pagina Izquierdo, Auxiliar;
            Auxiliar = Padre.Ramas[Indice];
            Izquierdo = Padre.Ramas[Indice - 1];
            Izquierdo.Cuenta++;
            Izquierdo.Nodos[Izquierdo.Cuenta] = Padre.Nodos[Indice];
            Izquierdo.Ramas[Izquierdo.Cuenta] = Auxiliar.Ramas[0];
            for (j = 1; j <= Auxiliar.Cuenta; j++)
            {
                Izquierdo.Cuenta++;
                Izquierdo.Nodos[Izquierdo.Cuenta] = Auxiliar.Nodos[j];
                Izquierdo.Ramas[Izquierdo.Cuenta] = Auxiliar.Ramas[j];
            }
            for (j = Indice; j <= Padre.Cuenta - 1; j++)
            {
                Padre.Nodos[j] = Padre.Nodos[j + 1];
                Padre.Ramas[j] = Padre.Ramas[j + 1];
            }
            Padre.Cuenta--;
        }
        /* SE COMBINAN DOS PÁGINAS DE LA PÁGINA 'Padre' LOCALIZADAS EN LA POSICIÓN 'Indice - 1' E 'Indice'. SE ALINEAN LOS NODOS
         * Y LAS PÁGINAS QUE TIENE DE HIJOS LOS NODOS MOVIDOS, ESTO SE DEBE A QUE ANTES SE BAJA DEL PADRE EL NODO EN LA POSICION
         * 'Indice', QUE ES LA CLAVE MEDIA. */

        public void Graficar()
        {
            if (Raiz == null || Raiz.isEmpty())
            {
                return;
            }
            String Grafo = "digraph ArbolB{\n\trankdir = UD;\n\tgraph [ratio = fill];\n\tnode [shape = plaintext]\n\t";
            Grafo = Enlistar(Raiz, Grafo);
            Grafo += "\n\n\t";
            Grafo = Enlazar(Raiz, Grafo);
            Grafo += "\n}";
            String Path = @"C:\Salidas";
            if (!Directory.Exists(Path))
            {
                Directory.CreateDirectory(Path);
            }
            Path = System.IO.Path.Combine(Path, "ArbolB.dot");
            StreamWriter Archivo = new StreamWriter(Path, false);
            Archivo.WriteLine(Grafo);
            Archivo.Close();
        }
        /* CREA EL ARCHIVO '*.dot' ESCRIBIENDO EN EL LA LISTA DE NODOS Y LUEGO LOS ENLACES QUE TIENEN. */

        private String Enlistar(Pagina Actual, String Grafo)
        {
            if(Actual == null || Actual.isEmpty())
            {
                return Grafo;
            }
            int Contador;
            Grafo += "N" + Actual.Nodos[1].ID + " [label=<\n";
            Grafo += "  <TABLE ALIGN = \"LEFT\">\n";
            Grafo += "      <TR>\n";
            for (Contador = 1; Contador < 5; Contador++)
            {
                if (Contador <= Actual.Cuenta)
                {
                    Grafo += "          <TD>" +
                        "ID = \"" + Actual.Nodos[Contador].ID + "\"<BR></BR>" +
                        "IDActivo = \"" + Actual.Nodos[Contador].Activo + "\"<BR></BR>" +
                        "Usuario = \"" + Actual.Nodos[Contador].Usuario + "\"<BR></BR>" +
                        "Empresa = \"" + Actual.Nodos[Contador].Empresa + "\"<BR></BR>" +
                        "Departamento = \"" + Actual.Nodos[Contador].Departamento + "\"<BR></BR>" +
                        "Fecha = \"" + Actual.Nodos[Contador].Fecha + "\"<BR></BR>" +
                        "Tiempo = \"" + Actual.Nodos[Contador].Tiempo + "\"" +
                        "           </TD>\n";
                }
                else
                {
                    Grafo += "          <TD>" +
                        "           </TD>\n";
                }
            }
            Grafo += "      </TR>\n";
            Grafo += "  </TABLE>\n";
            Grafo += ">, ];\n\t";
            foreach (Pagina Auxiliar in Actual.Ramas)
            {
                Grafo = Enlistar(Auxiliar, Grafo);
            }
            return Grafo;
        }
        /* ENLISTA LAS PÁGINAS PARA LUEGO PODER ENLAZARLAS. EN CADA PÁGINA SE METEN LOS DATOS DE SUS NODOS. */

        private String Enlazar(Pagina Actual, String Grafo)
        {
            if (Actual == null || Actual.isEmpty())
            {
                return Grafo;
            }
            foreach (Pagina Auxiliar in Actual.Ramas)
            {
                Grafo = Enlazar(Auxiliar, Grafo);
                if(Auxiliar != null)
                {
                    Grafo += "N" + Actual.Nodos[1].ID + " -> N" + Auxiliar.Nodos[1].ID;
                }
                
            }
            return Grafo;
        }
        /* ENLAZA LAS PÁGINAS YA LISTADAS RECORRIENDO HASTA LAS HOJAS PARA APUNTAR A LOS HIJOS. */

    }
}