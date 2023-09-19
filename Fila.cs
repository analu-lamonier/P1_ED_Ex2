using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace caProvaEx2
{
    internal class Fila
    {
        private NohFila INICIO; 
        private NohFila FIM;

        public Fila()
        {
            INICIO = null;
            FIM = null;
        }

        internal NohFila INICIO1 { get => INICIO; set => INICIO = value; }
        internal NohFila FIM1 { get => FIM; set => FIM = value; }

        public bool EstaVazia()
        {
            if (INICIO == null & FIM == null)
                return true;
            else return false;
        }

        public void Insere(int n)
        {
            NohFila novoNoh = new NohFila(n);
            if (EstaVazia())
            {
                INICIO = novoNoh;
                FIM = novoNoh;
            }
            else
            {
                FIM.Proximo = novoNoh;
                FIM = novoNoh;
            }
        }

        public int Remove()
        {
            int temp = INICIO.Info;
            INICIO = INICIO.Proximo;

            return temp;
        }

        public NohFila EncontraNoh(int n)
        {
            NohFila temp = INICIO;

            while (temp != null)
            {
                if (temp.Info == n)
                    return temp;
                temp = temp.Proximo;
            }


            return null;
        }
        public void FuraFila(int n, int t)
        {
            NohFila deixaFuraFila = EncontraNoh(t);
            NohFila furadorDeFila = new NohFila(n);

            furadorDeFila.Proximo = deixaFuraFila.Proximo;
            deixaFuraFila.Proximo = furadorDeFila;
            
        }

        public void Imprime()
        {
            if (EstaVazia())
                Console.WriteLine("Fila Vazia");

            else
            {

                NohFila temp = INICIO;

                while (temp != null)
                {
                    Console.WriteLine(temp.Info + " ");
                    temp = temp.Proximo;
                }
            }
        }

















    }
}
