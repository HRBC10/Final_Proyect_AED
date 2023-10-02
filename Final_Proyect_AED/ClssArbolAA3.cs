using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using System.Drawing;

namespace Final_Proyect_AED
{
    class ClssArbolAA3
    {
        private ClssNodoAA3 raiz { get; set; }
        public ClssArbolAA3()
        {
            this.raiz = null;
        }

        private int compararDatos(int c1, int c2)
        {
            int index = c1;

            if (c1 > c2)
            {
                index = c2;
            }
            int i;
            for (i = 0; i < index; i++)
            {
                if (c1 < c2)
                {
                    return c2;
                }
                else if (c1 > c2)
                {
                    return c1;
                }
            }
            return c2;
        }

        public void insertar(int dato)
        {
            ClssNodoAA3 nuevo = new ClssNodoAA3(dato);

            if (this.raiz == null)
            {
                this.raiz = nuevo;
            }
            else
            {
                if (this.raiz.dato.Equals(dato) == false)
                {
                    if (compararDatos(dato, this.raiz.dato).Equals(dato) == true)
                    {
                        this.raiz.derecho = insertar2(this.raiz.derecho, nuevo);
                    }
                    else if (compararDatos(dato, this.raiz.dato).Equals(this.raiz.dato) == true)
                    {
                        this.raiz.izquierdo = insertar2(this.raiz.izquierdo, nuevo);
                    }
                }
            }
        }

        private ClssNodoAA3 insertar2(ClssNodoAA3 rama, ClssNodoAA3 nuevo)
        {
            if (rama == null)
            {
                rama = nuevo;
            }
            else
            {
                if (rama.dato.Equals(nuevo.dato) == false)
                {
                    if (compararDatos(rama.dato, nuevo.dato).Equals(nuevo.dato) == true)
                    {
                        rama.derecho = insertar2(rama.derecho, nuevo);
                    }
                    else if (compararDatos(rama.dato, nuevo.dato).Equals(rama.dato) == true)
                    {
                        rama.izquierdo = insertar2(rama.izquierdo, nuevo);
                    }
                }

            }
            return rama;
        }

        public string preorden()
        {
            string cadena = "";
            return preorden2(this.raiz, ref cadena);
        }

        private string preorden2(ClssNodoAA3 rama, ref string cadena)
        {
            if (rama != null)
            {
                if (String.IsNullOrEmpty(cadena) == true)
                {
                    cadena += rama.dato;
                }
                else
                {
                    cadena += ", " + rama.dato;
                }

                preorden2(rama.izquierdo, ref cadena);
                preorden2(rama.derecho, ref cadena);
            }

            return cadena;
        }

        public string postorden()
        {
            string cadena = "";
            return postorden2(this.raiz, ref cadena);
        }

        private string postorden2(ClssNodoAA3 rama, ref string cadena)
        {
            if (rama != null)
            {
                postorden2(rama.izquierdo, ref cadena);
                postorden2(rama.derecho, ref cadena);

                if (String.IsNullOrEmpty(cadena) == true)
                {
                    cadena += rama.dato;
                }
                else
                {
                    cadena += ", " + rama.dato;
                }
            }

            return cadena;
        }

        public string inorden()
        {
            string cadena = "";

            return inorden2(this.raiz, ref cadena);
        }

        private string inorden2(ClssNodoAA3 rama, ref string cadena)
        {
            if (rama != null)
            {
                inorden2(rama.izquierdo, ref cadena);

                if (String.IsNullOrEmpty(cadena) == true)
                {
                    cadena += rama.dato;
                }
                else
                {
                    cadena += ", " + rama.dato;
                }

                inorden2(rama.derecho, ref cadena);
            }
            return cadena;
        }

        public ClssNodoAA3 Busqueda(int valor)
        {
            ClssNodoAA3 aux = raiz;
            while (aux.dato != valor)
            {
                if (valor < aux.dato)
                {
                    aux = aux.izquierdo;
                }
                else
                {
                    aux = aux.derecho;
                }
                if (aux == null)
                {
                    return null;
                }
            }
            return aux;
        }

        public Boolean Eliminar(int valor)
        {
            ClssNodoAA3 aux = raiz;
            ClssNodoAA3 Padre = raiz;
            Boolean izquierdo = true;
            while (aux.dato != valor)
            {
                Padre = aux;
                if (valor < aux.dato)
                {
                    izquierdo = true;
                    aux = aux.izquierdo;
                }
                else
                {
                    izquierdo = false;
                    aux = aux.derecho;
                }
                if (aux == null)
                {
                    return false;
                }
            }
            if ((aux.izquierdo == null) && (aux.derecho == null))
            {
                if (aux == raiz)
                {
                    raiz = null;
                }
                else if (izquierdo)
                {
                    Padre.izquierdo = null;
                }
                else
                {
                    Padre.derecho = null;
                }
            }
            else if (aux.derecho == null)
            {
                if (aux == raiz)
                {
                    raiz = aux.izquierdo;
                }
                else if (izquierdo)
                {
                    Padre.izquierdo = aux.izquierdo;
                }
                else
                {
                    Padre.derecho = aux.derecho;
                }
            }
            else if (aux.izquierdo == null)
            {
                if (aux == raiz)
                {
                    raiz = aux.izquierdo;
                }
                else if (izquierdo)
                {
                    Padre.derecho = aux.derecho;
                }
                else
                {
                    Padre.derecho = aux.izquierdo;
                }
            }
            else
            {
                ClssNodoAA3 reemplazo = obtenerRemplazo(aux);
                if (aux == raiz)
                {
                    raiz = reemplazo;
                }
                else if (izquierdo)
                {
                    Padre.izquierdo = reemplazo;
                }
                else
                {
                    Padre.derecho = reemplazo;
                }
                reemplazo.izquierdo = aux.izquierdo;
            }
            return true;
        }

        public ClssNodoAA3 obtenerRemplazo(ClssNodoAA3 nodo)
        {
            ClssNodoAA3 reemplazarPadre = nodo;
            ClssNodoAA3 reemplazo = nodo;
            ClssNodoAA3 aux = nodo.derecho;
            while (aux != null)
            {
                reemplazarPadre = reemplazo;
                reemplazo = aux;
                aux = aux.izquierdo;
            }
            if (reemplazo != nodo.derecho)
            {
                reemplazarPadre.izquierdo = reemplazo.derecho;
                reemplazo.derecho = nodo.derecho;
            }
            return reemplazo;
        }
        public string graficar()
        {
            string dot = "digraph G {\n\nnode [shape = record,height=.1];\nsplines=\"line\";\n\n";
            graficar2(this.raiz, ref dot);
            dot += "}";
            StreamWriter sw = new StreamWriter("C:\\dot.txt");
            sw.Write(dot);
            sw.Close();
            string ruta = "C:\\dot.txt";
            string ruta2 = "C:\\Arbol.png";
            string cmd = "dot -Tpng " + ruta + " -o " + ruta2;
            System.Diagnostics.ProcessStartInfo miProceso = new System.Diagnostics.ProcessStartInfo("cmd", "/c " + cmd);
            System.Diagnostics.Process.Start(miProceso);
            return ruta2;
        }

        private void graficar2(ClssNodoAA3 rama, ref string cadena)
        {
            if (rama != null)
            {
                cadena += "nodo" + rama.dato + "[label = \" <f2>|<f1> " + rama.dato + " |<f0> \"];\n";
                graficar2(rama.izquierdo, ref cadena);
                graficar2(rama.derecho, ref cadena);
                if (rama.izquierdo != null)
                {
                    cadena += "\"nodo" + rama.dato + "\":f2 -> \"nodo" + rama.izquierdo.dato + "\":f1;\n";
                }
                if (rama.derecho != null)
                {
                    cadena += "\"nodo" + rama.dato + "\":f0 -> \"nodo" + rama.derecho.dato + "\":f1;\n";
                }
            }
        }
    }
}
