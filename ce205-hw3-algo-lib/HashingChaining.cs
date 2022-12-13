using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;

namespace ce205_hw3_algo_lib
{
    public class HashingChaining
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
        public LinkedList<hashnode>[] table;

        public HashingChaining(int size, string type)
        {
            table = new LinkedList<hashnode>[size];
        }
        /// <summary>
        /// Sorting with linked list logic makes index placement
        /// </summary>
        /// <param name="key"></param>
        /// <param name="data"></param>
        /// <param name="n"></param>
        public void HashingChainingLinearProbingInsert(int key, string data, int n)
        {
            int index = key % n;
            while (table[index] != null)
            {
                index = (index + 1) % n;
            }
            table[index] = new LinkedList<hashnode>();
            table[index].AddFirst(new hashnode(key, data));
        }
    }
}
