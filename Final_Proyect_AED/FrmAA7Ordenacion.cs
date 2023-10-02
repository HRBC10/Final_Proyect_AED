using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Final_Proyect_AED
{
    public partial class FrmAA7Ordenacion : Form
    {
        FrmMenu Volver;
        public FrmAA7Ordenacion()
        {
            InitializeComponent();
        }

        //Declaraciones Globales
        int[] Numeros;
        int aux, N = 0;
        int mayor_pasos, menor_pasos, señal_pasos, sacudida_pasos, shell_pasos, quick_pasos, directa_pasos, p_head_pasos;

        //Función ImprimirA
        void ImprimirA(string Metodo) 
        {
            string Cadena = "";
            for(int i = 0; i < N; i++)
            {
                Cadena += Numeros[i] + " ";
            }
            lbOrdenados.Items.Add(Metodo + " -> " + Cadena);
        }

        //Función Imprimir1 Menores
        void Imprimir1() 
        {
            for (int i = 0; i < N; i++)
            {
                txtMenor.Text = txtMenor.Text + Numeros[i] + " ";
            }
            Task.Delay(1000).Wait();
            txtMenor.Text = txtMenor.Text + "\r\n";
        }

        //Función Imprimir2 para imprimir Mayores
        void Imprimir2() 
        {
            for (int i = 0; i < N; i++)
            {
                txtMayor.Text = txtMayor.Text + Numeros[i] + " ";
            }
            Task.Delay(1000).Wait();
            txtMayor.Text = txtMayor.Text + "\r\n";
        }

        //Función Imprimir3 para imprimir por Señal
        void Imprimir3()
        {
            for (int i = 0; i < N; i++)
            {
                txtSeñal.Text = txtSeñal.Text + Numeros[i] + " ";
            }
            Task.Delay(1000).Wait();
            txtSeñal.Text = txtSeñal.Text + "\r\n";
        }

        void Imprimir4()
        {
            for(int i = 0; i<N;i++)
            {
                txtSacudida.Text = txtSacudida.Text + (Numeros[i] + " ");
            }
            Task.Delay(1000).Wait();
            txtSacudida.Text = txtSacudida.Text + "\r\n";
        }
        void Imprimir5()
        {
            for (int i = 0; i < N; i++)
            {
                txtDirecta.Text = txtDirecta.Text + (Numeros[i] + " ");
            }
            Task.Delay(1000).Wait();
            txtDirecta.Text = txtDirecta.Text + "\r\n";
        }
        void Imprimir6()
        {
            for (int i = 0; i < N; i++)
            {
                txtShell.Text = txtShell.Text + (Numeros[i] + " ");
            }
            Task.Delay(1000).Wait();
            txtShell.Text = txtShell.Text + "\r\n";
        }

         void Imprimir7()
        {
            for (int i = 0; i < N; i++)
            {
                txtQuick.Text = txtQuick.Text + (Numeros[i] + " ");
            }
            Task.Delay(1000).Wait();
            txtQuick.Text = txtQuick.Text + "\r\n";
        }
        void Imprimir8()
        {
            for (int i = 0; i < N; i++)
            {
                txtHeap.Text = txtHeap.Text + (Numeros[i] + " ");
            }
            Task.Delay(1000).Wait();
            txtHeap.Text = txtHeap.Text + "\r\n";
        }
        //Evento KeyPress del txtNumero
        private void txtNumero_KeyPress(object sender, KeyPressEventArgs e)
        {
            if(e.KeyChar == 13 && txtNumero.Text !="")
            {
                Array.Resize(ref Numeros, N + 1);
                int Num = int.Parse(txtNumero.Text);
                Numeros[N] = Num;
                lbNumeros.Items.Add(Num);
                txtNumero.Text = "";
                txtNumero.Focus();
                N = N + 1;
                
            }
        }

        //Evento click del item Mayor
        private void mayorToolStripMenuItem_Click(object sender, EventArgs e)
        {
            txtMayor.Text = txtMayor.Text + "--------------------------\r\n";
            int i = 0;

            foreach (int Elemento in lbNumeros.Items)
            {
                Numeros[i] = Elemento;
                i++;
            }

            Imprimir2();

            mayor_pasos = 0;
            for (i = N - 1; i > 0; i--)
            {
                for (int j = 0; j < i; j++)
                {
                    if (Numeros[j] > Numeros[j + 1])
                    {
                        aux = Numeros[j];
                        Numeros[j] = Numeros[j + 1];
                        Numeros[j + 1] = aux;
                    }
                }
                Imprimir2();
                mayor_pasos++;
            }
            ImprimirA("Burbuja Mayor");
            Mayor.Text = mayor_pasos.ToString();
        }

        //Evento click del item Con Señal
        private void conSeñalToolStripMenuItem_Click(object sender, EventArgs e)
        {
            txtSeñal.Text = txtSeñal.Text + "--------------------------\r\n";
            int i = 0;
            bool Band = false;

            foreach (int Elemento in lbNumeros.Items)
            {
                Numeros[i] = Elemento;
                i++;
            }

            Imprimir3();
            señal_pasos = 0;
            i = 0;

            while (i < N - 1 && Band == false)
            {
                Band = true;

                for(int j = 0; j < N - 1; j++)
                {
                    if(Numeros[j] > Numeros[j + 1])
                    {
                        aux = Numeros[j];
                        Numeros[j] = Numeros[j + 1];
                        Numeros[j + 1] = aux;
                        Band = false;
                    }
                }
                Imprimir3();
                señal_pasos++;
                i = i + 1;
            }
            Señal.Text = señal_pasos.ToString();
            ImprimirA("Señal");
        }
        private void shakerSortToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if(Numeros==null)
            {
                txtSacudida.Text = txtSacudida.Text + "--------------------------\r\n";
                int intercambios = 0, Comparaciones = 0;
                int i = 0, izq, der, k, aux;
                izq = 1;
                der = Numeros.Length - 1;
                k = Numeros.Length - 1;
                sacudida_pasos = 0;
                foreach (int Elemento in lbNumeros.Items)
                {
                    Numeros[i] = Elemento;
                    i++;
                }
                while (izq <= der)
                {
                    for (i = der; i >= izq; i--)
                    {
                        Comparaciones++;
                        if (Numeros[i - 1] > Numeros[i])
                        {
                            intercambios++;
                            aux = Numeros[i - 1];
                            Numeros[i - 1] = Numeros[i];
                            Numeros[i] = aux;
                            k = i;
                        }
                    }
                    izq = k + 1;

                    for (i = izq; i <= der; i++)
                    {
                        Comparaciones++;
                        if (Numeros[i - 1] > Numeros[i])
                        {
                            intercambios++;
                            aux = Numeros[i - 1];
                            Numeros[i - 1] = Numeros[i];
                            Numeros[i] = aux;
                            k = i;
                        }
                    }
                    der = k - 1;
                    Imprimir4();
                    sacudida_pasos++;
                }
                Shake.Text = sacudida_pasos.ToString();
                ImprimirA("Sacudidad");
            }
        }

        private void inserciónDirectaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if(N!=0)
            {
                txtDirecta.Text = txtDirecta.Text + "--------------------------\r\n";
                int i = 0, j;
                directa_pasos = 0;
                foreach (int Elemento in lbNumeros.Items)
                {
                    Numeros[i] = Elemento;
                    i++;
                }
                for (i = 1; i < Numeros.Length; i++)
                {
                    aux = Numeros[i];
                    j = i - 1;
                    while ((j >= 0) && (aux < Numeros[j]))
                    {
                        Numeros[j + 1] = Numeros[j];
                        j--;
                    }
                    Numeros[j + 1] = aux;
                    Imprimir5();
                    directa_pasos++;
                }
                Directa.Text = directa_pasos.ToString();
                ImprimirA("Inserccion Directa");
            }

        }

        private void shellToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (N != 0)
            {
                txtShell.Text = txtShell.Text + "--------------------------\r\n";
                int inta, i, aux;
                bool band;
                inta = Numeros.Length;
                shell_pasos = 0;
                while (inta > 0)
                {
                    inta = inta / 2;
                    band = true;
                    while (band)
                    {
                        band = false;
                        i = 0;
                        while ((i + inta) <= Numeros.Length - 1)
                        {
                            if (Numeros[i] > Numeros[i + inta])
                            {
                                aux = Numeros[i];
                                Numeros[i] = Numeros[i + inta];
                                Numeros[i + inta] = aux;
                                band = true;
                            }
                            i++;
                        }
                        Imprimir6();
                        shell_pasos++;
                    }

                }
                Shell.Text = shell_pasos.ToString();
                ImprimirA("Shell");
            }
        }

        private void TxtNumero_TextChanged(object sender, EventArgs e)
        {

        }
        private void Quicksort(int INI, int FIN)
        {
            int IZQ, DER, POS, AUX;
            bool BAND;

            IZQ = INI;
            DER = FIN;
            POS = INI;
            BAND = true;

            while (BAND == true)
            {
                BAND = false;
                
                while (Numeros[POS] <= Numeros[DER] && POS != DER)
                {
                    DER = DER - 1;
                }

                if (POS != DER)
                {
                    AUX = Numeros[POS];
                    Numeros[POS] = Numeros[DER];
                    Numeros[DER] = AUX;
                    POS = DER;

                    while (Numeros[POS] >= Numeros[IZQ] && POS != IZQ)
                    {
                        IZQ = IZQ + 1;
                    }

                    if (POS != IZQ)
                    {
                        BAND = true;
                        AUX = Numeros[POS];
                        Numeros[POS] = Numeros[IZQ];
                        Numeros[IZQ] = AUX;
                        POS = IZQ;
                    }
                    Imprimir7();
                    quick_pasos++;
                }
            }

            if (POS - 1 >= INI)
            {
                Quicksort(INI, POS - 1);
            }

            if (FIN >= POS + 1)
            {
                Quicksort(POS + 1, FIN);
            }


        }
        private void QuicksortToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if(N!=0)
            {
                txtQuick.Text = txtQuick.Text + "--------------------------\r\n";
                int i = 0;
                quick_pasos = 0;
                foreach (int Elemento in lbNumeros.Items)
                {
                    Numeros[i] = Elemento;
                    i++;
                }
                Imprimir7();

                Quicksort(0, Numeros.Length - 1);
                Quick.Text = quick_pasos.ToString();
                ImprimirA("Ordenamiento rapido");

            }
        }

        private void TxtMenor_TextChanged(object sender, EventArgs e)
        {

        }

       private void HeapSort()
       {

            int I, K, AUX;
            bool BAND;

            for (I = 1; I < N; I++)
            {
                K = I;
                BAND = true;

                while ((K > 0) && (BAND == true))
                {
                    BAND = false;

                    if (Numeros[K] > Numeros[K / 2])
                    {
                        AUX = Numeros[K / 2];
                        Numeros[K / 2] = Numeros[K];
                        Numeros[K] = AUX;
                        K = K / 2;
                        BAND = true;
                    }
                }

            }
            Imprimir8();
            p_head_pasos++;
            Maximos();
        }


            
        private void Maximos()
        {
            int I, AUX, IZQ, DER, K, AP;
            int MAYOR;
            bool BOOL;

            for (I = N - 1; I >= 1; I--)
            {
                AUX = Numeros[I];
                Numeros[I] = Numeros[0];
                IZQ = 1;
                DER = 2;
                K = 0;
                BOOL = true;

                while (IZQ < I && BOOL == true)
                {
                    MAYOR = Numeros[IZQ];
                    AP = IZQ;

                    if (MAYOR < Numeros[DER] && DER != I)
                    {
                        MAYOR = Numeros[DER];
                        AP = DER;
                    }

                    if (AUX < MAYOR)
                    {
                        Numeros[K] = Numeros[AP];
                        K = AP;
                    }
                    else
                    {
                        BOOL = false;
                    }

                    IZQ = K * 2;
                    DER = IZQ + 1;
                }

                Numeros[K] = AUX;

                Imprimir8();
                p_head_pasos++;
            }
        }
        private void HeapSortToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if(N!=0)
            {
                txtHeap.Text = txtHeap.Text + "--------------------------\r\n";
                int i = 0;
                p_head_pasos = 0;
                foreach (int Elemento in lbNumeros.Items)
                {
                    Numeros[i] = Elemento;
                    i++;
                }
                Imprimir8();
                HeapSort();
                Heap.Text = p_head_pasos.ToString();
                ImprimirA("Montículos");
            }
            
        }

        private void lbQuickSort_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void lbNumeros_SelectedIndexChanged(object sender, EventArgs e)
        {
           
        }

        private void definicionesToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void mayorToolStripMenuItem1_Click(object sender, EventArgs e)
        {

        }

        private void porIntercambioDirectoToolStripMenuItem1_Click(object sender, EventArgs e)
        {

        }

        private void shakerSortToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            Definicion.Text =
"                                                Sacudida\n" +
"1.Hacer IZQ < -2, DER < -N y K<-N\n" +
"2.Mientras(DER >= IZQ) Repetir\n" +
"    2.1 Repetir con I desde DER hasta IZQ { Ciclo descendente}\n" +
"            2.1.1 Si(A[I - 1] > A[I]) entonces\n" +
"                     Hacer AUX < -A[I - 1], Hacer A[I - 1] < -A[I], Hacer A[I] < -AUX, Hacer K<-I\n" +
"           2.1.2 { Fin del condicional del paso 2.1.1}\n" +
"            2.2 { Fin del ciclo del paso 2.1}\n" +
"            Hacer IZQ<-K + 1\n" +
"    2.3 Repetir con I desde IZQ hasta DER { Ciclo ascendente}\n" +
"            2.3.1 Si(A[I - 1] > A[I])\n" +
"                       Hacer AUX<-A[I - 1], Hacer A[I - 1] < -A[I], Hacer A[I] < -AUX, Hacer K<-I\n" +
"          2.3.2 { Fin del condicional del paso 2.2.1}\n" +
"            2.4 { Fin del ciclo del paso 2.3}\n" +
"            Hacer DER<-K - 1\n" +
"3. { Fin del ciclo 2}\n"
;
        }

        private void shellToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            Definicion.Text =
"                                                          Shell\n" +
"1.Hacer INT & lt; -N + 2\n" +
"2.Mientras(INT & gt; 1) Repetir\n" +
"         Hacer INT & lt; -parte entera(INT / 2) y BAND &lt; -VERDADERO\n" +
"     2.1 Mientras(BAND = VERDADERO) Repetir\n" +
"           Hacer BAND & lt; -FALSO e I &lt; \n" +
" 2.1.1 Mientras((I + INT) & lt;= N) Repetir\n" +
"                    2.1.1.1 Si A[I] &gt; A[I + INT] entonces\n" +
"                                 Hacer AUX & lt; -A[I], A[I] & lt; -A[I + INT], A[I + INT] & lt; -AUX, BAND & lt; -BAND\n" +
"                   2.1.1.2 { Fin del condicional del paso 2.1.1.1}\n" +
"2.1.2 { Fin del ciclo del paso 2.1.1}\n" +
 "           2.2 { Fin del ciclo del paso 2.1}\n" +
 "           3. { Fin del ciclo del paso 2}\n"
             ;
        }

        private void conSeñalToolStripMenuItem1_Click(object sender, EventArgs e)
        {

            Definicion.Text =
"           Intercambio Directo por Señal\n" +
"1.Hacer I & lt; -1 y BAND &lt; -Falso\n" +
"2.Mientras((I & lt;= N - 1) y(BAND = FALSO)) Repetir\n" +
"           Hacer BAND & lt; -VERDADERO\n" +
"    2.1 Repetir con J desde 1 hasta N -1\n" +
"          2.1.1 Si(A[J] & gt; A[J + 1]) entonces\n" +
"                    Hacer AUX & lt; -A[J],\n" +
"                        Hacer A[J] &lt; -A[J + 1],\n" +
"                        Hacer A[J + 1] &lt; -AUX,\n" +
"                        Hacer BAND &lt; -FALSE\n" +
"           2.1.2 { Fin del condicional del paso 2.1.1}\n" +
"            2.2 { Fin del ciclo del paso 2.1}\n" +
"            3. { Fin del ciclo del paso 2}\n"
            ;

        }

        private void quickSortToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            Definicion.Text =
"           Rápido_recursivo(A, N)\n" +
"1.Llamar al algoritmo Reduce_recursivo con 1 y N\n" +
"Reduce_recursivo(INI, FIN)\n" +
"1.Hacer IZQ & lt; -INI, DER & lt; -FIN, POS & lt; -INI y BAND &lt; -VERDADERO\n" +
"2.Mientras(BAND = VERDADERO) Repetir\n" +
"           Hacer BAND & lt; -FALSO\n" +
"  2.1 Mientras((A[POS] & lt;= A[DER]) y(POS != DER)) Repetir\n" +
"             Hacer DER & lt; -DER - 1\n" +
"    2.2 { Fin del ciclo del paso 2.1}\n" +
"            2.3 Si(POS != DER) entonces\n" +
"                     Hacer AUX & lt; -A[POS], A[POS] & lt; -A[DER], A[DER] & lt; -AUX y POS &lt; -DER\n" +
"           2.3.1 Mientras((A[POS] & gt;= A[IZQ]) y(POS != IZQ)) Repetir\n" +
"                          Hacer IZQ & lt; -IZQ + 1\n" +
"           2.3.2 { Fin del ciclo del paso 2.3.1}\n" +
"            2.3.3 Si(POS != IZQ) entonces\n" +
"                         Hacer BAND & lt; -VERDADERO, AUX & lt; -A[POS], A[POS] & lt; -A[IZQ],\n" +
"                         A[IZQ] & lt; -AUX, POS & lt; -IZQ\n" +
"           2.3.4 { Fin del condicional del paso 2.3.3}\n" +
"            2.4 { Fin del condicional del paso 2.3}\n" +
"            3. { Fin del ciclo del paso 2}\n" +
"            4.Si((POS - 1) & gt; INI) entonces\n" +
"                             Regresar a Reduce_recursivo con INI y(POS - 1) { Llamada recursiva}\n" +
"            5. { Fin del ciclo del paso 4}\n" +
"            6.Si(FIN & gt; (POS + 1)) entonces\n" +
"                             Regresar a Reduce_recursivo con(POS + 1) y FIN { Llamada recursiva}\n" +
"            7. { Fin del ciclo del paso 6}\n" 
;
        }

        private void menorToolStripMenuItem1_Click(object sender, EventArgs e)
        {

            Definicion.Text =
"            Intercambio Directo Menor\n" +
"1.Repetir con I desde 2 hasta N\n" +
"    1.1 Repetir con J desde N hasta I\n" +
"          1.1.1 Si A(J -1) &gt; A[J] entonces\n" +
"                  Hacer AUX & lt; -A[J - 1],\n" +
"                    Hacer A[J - 1] &lt; -A[I],\n" +
"           1.1.2 { Fin del condicional del paso 1.1.1}\n" +
"            1.2 { Fin del ciclo del paso 1.1}\n" +
"            2. { Fin del ciclo del paso 1}\n" 

            ;
        }

        private void mayorToolStripMenuItem1_Click_1(object sender, EventArgs e)
        {
            Definicion.Text =
"Intercambio Directo Mayor\n" +
"1.Repetir con I desde(N - 1) hasta 1\n" +
"    1.1 Repetir con J desde 1 hasta I\n" +
"          1.1.1 Si A[J] &gt; A[J + 1] entonces\n" +
"                   Hacer AUX & lt; -A[J],\n" +
"                    Hacer A[J] &lt; -A[J + 1],\n" +
"                    Hacer A[J + 1] &lt; -AUX\n" +
"           1.1.2 { Fin del condicional del paso 1.1.1}\n" +
"            1.2 { Fin del ciclo del paso 1.1}\n" +
"            2. { Fin del ciclo del paso 1}\n"

;

        }

        private void inserccionDirectaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Definicion.Text =
"            Inserción Directa\n" +
"1.Repetir con I desde 2 hasta N\n" +
"             Hacer AUX &lt; -A[I]\n" +
"             Hacer K &lt; -I - 1\n" +
"    1.1 Mientras((K & gt;= 1) y(AUX & lt; A[K])) Repetir\n" +
"                  Hacer A[K + 1] & lt; -A[K]\n" +
"                   Hacer K &lt; -K - 1\n" +
"    1.2 { Fin del ciclo del paso 1.2}\n" +
"            Hacer A[K + 1] &lt; -AUX\n" +
"2. { Fin del ciclo del paso 1}\n" 
            ;

        }

        private void heapSortToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            Definicion.Text =

"Inserta_montículo(A, N)\n" +
"1.Repetir con I desde 2 hasta N\n" +
"          Hacer K &lt; -I y BAND &lt; -VERDADERO\n" +
"              Hacer BAND & lt; -FALSO\n" +
"           1.1.1 Si(A[K] & gt; A[parte entero(K entre 2)]) entonces\n" +
"                             Hacer AUX & lt; -A[parte entero(k entre 2)],\n" +
"                             A[parte entera(k entre 2)] & lt; -A[K], A[K] & lt; -AUX,\n" +
"                             K & lt; -parte entera(k entre 2) y BAND &lt; -VERDADERO\n" +
"           1.1.2 { Fin del condicional del paso 1.1.1}\n" +
"            1.2 { Fin del ciclo del paso 1.1}\n" +
"            2. { Fin del ciclo del paso 1}    \n" +
"Eliminar_montículo(A, N)\n" +
"1.Repetir con I desde 2 hasta N\n" +
"         Hacer AUX & lt; -A[I], A[I] & lt; -A[1], IZQ & lt; -2,\n" +
"          DER & lt; -3, K & lt; -1 y BOOL &lt; -VERDADERO\n" +
"     1.1 Mientras((IZQ & lt; 1) y((BOOL = VERDADERO)) Repetir\n" +
"              Hacer MAYOR & lt; -A[IZQ] y AP &lt; -IZQ\n" +
"           1.1.1 Si((MAYOR & lt; A[DER]) y DER != 1) entonces\n" +
"                             Hacer MAYOR & lt; -A[DER] y AP &lt; -IZQ\n" +
"           1.1.2 { Fin del condicional del paso 1.1.1}\n" +
"            1.1.3 Si(AUX & lt; MAYOR)\n" +
"                     entonces\n" +
"                              Hacer A[K] & lt; -A[AP] y K &lt; -AP\n" +
"                     si no\n" +
"                              Hacer BOOL &lt; -FALSO\n" +
"           1.1.4 { Fin del condicional del paso 1.1.3}\n" +
"            Hacer IZQ &lt; -K * 2 y DER &lt; -IZQ + 1\n" +
"     1.2 { Fin del ciclo del paso 1.1}]\n" +
"                Hacer A[K] &lt; -AUX\n" +
"2. { Fin del ciclo del paso 1}\n" 
            ;
        }

        private void inserccionDirectaToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            Definicion.Text =
            "El ordenamiento de burbuja bidireccional (cocktail sort en inglés) es un algoritmo \n" +
"de ordenamiento que surge como una mejora del algoritmo ordenamiento de burbuja.\n" +
"\n" +
"Ejemplo de la operativa paso a paso\n" +
"La manera de trabajar de este algoritmo es ir ordenando al mismo tiempo por los \n" +
"dos extremos del vector. De manera que tras la primera iteración, tanto el menor\n" +
"como el mayor elemento estarán en sus posiciones finales. De esta manera se \n" +
"reduce el número de comparaciones aunque la complejidad del algoritmo sigue siendo O(n²).\n"
;
        }

        private void shakerSortToolStripMenuItem2_Click(object sender, EventArgs e)
        {

        }

        private void shakerSortToolStripMenuItem2_Click_1(object sender, EventArgs e)
        {
            Definicion.Text =
"El ordenamiento por inserción (insertion sort en inglés)\n" +
"                     es una manera \n" +
"muy natural de ordenar para un ser humano, y puede usarse\n" +
"fácilmente para ordenar un mazo de cartas numeradas en \n" +
"forma arbitraria. Requiere O(n^2 )operaciones para ordenar\n" +
"              una lista de n elementos.\n"
;
        }

        private void porIntercambioDirectoToolStripMenuItem2_Click(object sender, EventArgs e)
        {
            Definicion.Text =
"es un sencillo algoritmo de ordenamiento. Funciona revisando cada\n" +
"elemento de la lista que va a ser ordenada con el siguiente,\n" +
"intercambiándolos de posición si están en el orden equivocado.\n" +
"Es necesario revisar varias veces toda la lista hasta que no se \n" +
"necesiten más intercambios, lo cual significa que la lista está ordenada. \n" +
"Este algoritmo obtiene su nombre de la forma con la que suben por la lista\n" +
"los elementos durante los intercambios, como si fueran pequeñas burbujas.\n"
;
        }

        private void shelToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Definicion.Text =
"El ordenamiento Shell (Shell sort en inglés) es un algoritmo \n" +
"de ordenamiento. El método se denomina Shell en honor de su \n" +
"inventor Donald Shell. Su implementación original, requiere \n" +
"O(n2) comparaciones e intercambios en el peor caso. Un cambio \n" +
"menor presentado en el libro de V. Pratt produce una implementación\n" +
"con un rendimiento de O(n log2 n) en el peor caso. Esto es mejor que las \n" +
"O(n2) comparaciones requeridas por algoritmos simples pero peor que el óptimo\n" +
"O(n log n). Aunque es fácil desarrollar un sentido intuitivo de cómo funciona \n" +
"este algoritmo, es muy difícil analizar su tiempo de ejecución.\n"
;
        }

        private void quickSortToolStripMenuItem2_Click(object sender, EventArgs e)
        {
            Definicion.Text =

                        "El algoritmo trabaja de la siguiente forma:\n" +
            "\n" +
            "Elegir un elemento del conjunto de elementos a ordenar, al que llamaremos pivote.\n" +
            "Resituar los demás elementos de la lista a cada lado del pivote, de manera que a \n" +
            "un lado queden todos los menores que él, y al otro los mayores. Los elementos \n" +
            "iguales al pivote pueden ser colocados tanto a su derecha como a su izquierda, \n" +
            "dependiendo de la implementación deseada. En este momento, el pivote ocupa \n" +
            "exactamente el lugar que le corresponderá en la lista ordenada.\n" +
            "La lista queda separada en dos sublistas, una formada por los elementos \n" +
            "a la izquierda del pivote, y otra por los elementos a su derecha.\n" +
            "Repetir este proceso de forma recursiva para cada sublista mientras \n" +
            "éstas contengan más de un elemento. Una vez terminado este proceso \n" +
            "todos los elementos estarán ordenados\n"
            ;
        }

        private void heapSortToolStripMenuItem2_Click(object sender, EventArgs e)
        {
            Definicion.Text =
            "Este algoritmo consiste en almacenar todos los elementos del vector \n" +
"a ordenar en un montículo (heap), y luego extraer el nodo que queda \n" +
"como nodo raíz del montículo (cima) en sucesivas iteraciones obteniendo \n" +
"el conjunto ordenado. Basa su funcionamiento en una propiedad de los \n" +
"montículos, por la cual, la cima contiene siempre el menor elemento \n" +
"(o el mayor, según se haya definido el montículo) de todos los almacenados\n" +
"en él. El algoritmo, después de cada extracción, recoloca en el nodo raíz\n" +
"o cima, la última hoja por la derecha del último nivel. Lo cual destruye \n" +
"la propiedad heap del árbol. Pero, a continuación realiza un proceso \n" +
"de descenso del número insertado de forma que se elige a cada \n" +
"movimiento el mayor de sus dos hijos, con el que se intercambia. \n" +
"Este intercambio, realizado sucesivamente hunde el nodo en el \n" +
"árbol restaurando la propiedad montículo del árbol y dejando paso \n" +
"a la siguiente extracción del nodo raíz.\n"
;
        }

        private void volverToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Volver = new FrmMenu();
            Volver.Show();
            this.Hide();
        }

        private void lbOrdenados_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            txtDirecta.Clear();
            txtHeap.Clear();
            txtMayor.Clear();
            txtMenor.Clear();
            txtNumero.Clear();
            txtQuick.Clear();
            txtSacudida.Clear();
            txtSeñal.Clear();
            txtShell.Clear();
            Definicion.Text = "...";
            Mayor.Text = "...";
            Menor.Text = "...";
            Shake.Text = "...";
            Señal.Text = "...";
            Directa.Text = "...";
            Shell.Text = "...";
            Quick.Text = "...";
            Heap.Text = "...";
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void menuStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            lbNumeros.Items.Clear();
            lbOrdenados.Items.Clear();
            txtDirecta.Clear();
            txtHeap.Clear();
            txtMayor.Clear();
            txtMenor.Clear();
            txtNumero.Clear();
            txtQuick.Clear();
            txtSacudida.Clear();
            txtSeñal.Clear();
            Definicion.Text = "...";
            Mayor.Text = "...";
            Menor.Text = "...";
            Shake.Text = "...";
            Señal.Text = "...";
            Directa.Text = "...";
            Shell.Text = "...";
            Quick.Text = "...";
            Heap.Text = "...";
            txtShell.Clear();
            N = 0;
        }

        private void txtDirecta_TextChanged(object sender, EventArgs e)
        {

        }

        private void label12_Click(object sender, EventArgs e)
        {

        }

        //Evento click del item Menor
        private void menorToolStripMenuItem_Click(object sender, EventArgs e)
        {
            txtMenor.Text = txtMenor.Text + "--------------------------\r\n";
            int i = 0;
         
            foreach(int Elemento in lbNumeros.Items)
            {
                Numeros[i] = Elemento;
                i++;
            }

            menor_pasos = 0;

            for(i = 0; i < N-1; i++)
            {
                for (int j = N-1; j > 0; j--)
                {
                    if (Numeros[j - 1] > Numeros[j])
                    {
                        aux = Numeros[j - 1];
                        Numeros[j - 1] = Numeros[j];
                        Numeros[j] = aux;
                    }
                }
                Imprimir1();
                menor_pasos++;
            }
            ImprimirA("Burbuja Menor");
            Menor.Text = menor_pasos.ToString();
        }
    }
}
