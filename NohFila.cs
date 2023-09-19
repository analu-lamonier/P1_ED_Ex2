using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace caProvaEx2
{
    internal class NohFila
    {
        private int info;
        private NohFila proximo;


        public NohFila() { }

        public NohFila(int _info)
        {
            info = _info;
            proximo = null;
        }

        public NohFila(int _info, NohFila _proximo)
        {
            info = _info;
            proximo = _proximo;
        }

        public int Info { get => info; set => info = value; }
        internal NohFila Proximo { get => proximo; set => proximo = value; }
    }
}
