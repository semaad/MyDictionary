using System;
using System.Collections.Generic;
using System.Text;

namespace MyDictionary
{
    class MyDict<S, A>
    {
        S[] arrayKey;
        S[] tempKey;
        A[] arrayValue;
        A[] tempValue;

        public MyDict()
        {
            arrayKey = new S[0];
            arrayValue = new A[0];

        }
        public void Add(S key, A value)
        {
            tempKey = arrayKey;
            tempValue = arrayValue;
            arrayKey = new S[arrayKey.Length + 1];
            arrayValue = new A[arrayValue.Length + 1];

            for (int i = 0; i < tempKey.Length; i++)
            {
                arrayKey[i] = tempKey[i];
            }
            for (int i = 0; i < tempValue.Length; i++)
            {
                arrayValue[i] = tempValue[i];

            }
            arrayKey[arrayKey.Length - 1] = key;
            arrayValue[arrayValue.Length - 1] = value;

            for (int i = 0; i < arrayKey.Length; i++)

            {
                Console.WriteLine("Stock:" + arrayKey[i] + "Kitap Adı:" + arrayValue[i]);

            }
            Console.WriteLine(".....................");
        
        }



    }

}
