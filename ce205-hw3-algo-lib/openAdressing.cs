using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ce205_hw3_algo_lib
{
    public class OpenAddressing
    {
        public class hashnode
        {
            public int key;
            public string data;

            public hashnode(int key, string data)
            {
                this.key = key;
                this.data = data;
            }
        }
        public hashnode[] table;
        public OpenAddressing(int size)
        {
            table = new hashnode[size];
        }
        /// <summary>
        /// The array is sorted by the remainder, taking into account the length of the array.
        /// </summary>
        /// <param name="key"></param>
        /// <param name="data"></param>
        /// <param name="n"></param>
        public void OpenAddressingLinearProbingInsert(int key, string data, int n)
        {
            int index = key % n;
            while (table[index] != null)
            {
                index = (index + 1) % n;
            }
            table[index] = new hashnode(key, data);
        }
        /// <summary>
        /// The array is sorted by the remainder, taking into account the length of the array.
        /// </summary>
        /// <param name="key"></param>
        /// <param name="data"></param>
        /// <param name="n"></param>
        public void OpenAddressingQuadraticProbingInsert(int key, string data, int n)
        {
            int index = key % n;
            int i = 1;
            while (table[index] != null)
            {
                index = (index + i * i) % n;
                i++;
            }
            table[index] = new hashnode(key, data);
        }
        /// <summary>
        /// The array is sorted by the remainder, taking into account the length of the array
        /// The code starts by creating an integer variable called index that will hold the position of the current key in the table.
        /// </summary>
        /// <param name="key"></param>
        /// <param name="data"></param>
        /// <param name="n"></param>
        public void OpenAddressingDoubleProbingInsert(int key, string data, int n)
        {
            
            int index = key % n;
            int i = 1;
            int prime = 0;
            while (table[index] != null)
            {
                for (int j = 0; j < n; j++)
                {
                    if (table[index] != null)
                    {
                        prime++;
                    }
                }
                index = (index + i * (prime - (key % prime)) % n);
                i++;
            }
            table[index] = new hashnode(key, data);
        }
    }
}
