using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Genericsİnto
{
    class MyList<T>
    {
        T[] items;
        public MyList()
        {
            items = new T[0];      //newlemek önceki referans numaarsını atar ve o verilere tekrar ulaşamayız
        }
        public void Add(T item)
        {
            T[] tempArray = items; //ÖNCEKİ REFERANS NUMAARSINI GEÇİCİ OLARAK TUTAR.
            items = new T[items.Length + 1];
            for (int i = 0; i < tempArray.Length; i++)
            {
                items[i] = tempArray[i];
            }
            items[items.Length - 1] = item;

        }
        
    }
}
