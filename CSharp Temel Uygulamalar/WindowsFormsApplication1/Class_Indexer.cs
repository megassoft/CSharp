using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace WindowsFormsApplication1
{
    class Class_Indexer
    {

        int[] indeks;

        public int lenght;
        public bool error;

        public Class_Indexer(int size)
        {
            indeks = new int[size];
            lenght = size;
        }

        public int this[int index]
        {
            get {
                
                if (index >= 0 & index < lenght)
                {
                    error = false;
                    return indeks[index];
                }
                else
                {
                    error = true;
                    return 0;
                }

            }

            set { 
            
                if (index >= 0 & index < lenght)
                {

                    indeks[index] = value;
                    error = false;
                }
                else
                {
                    error = true;
                }

            }
        }



    }
}
