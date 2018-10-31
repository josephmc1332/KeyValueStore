using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KeyValueStore
{
    struct KeyValues<T>
    {
        public readonly string key;
        public readonly T value;


        public KeyValues(string initialKey, T initialValue)
        {
            key = initialKey;
            value = initialValue;
        }
    }

    public class MyDictionary
    {
       
        KeyValues<int>[] keyValues = new KeyValues<int>[2];
        int count = 0;


        public object this[string keySearch]
        {
            get
            {
                for(int i = 0; i < keyValues.Length; i ++)
                {
                    if(keySearch == keyValues[i].key)
                    {
                        return keyValues[i].value;
                    }
                }
                throw new KeyNotFoundException("That key does not exist in our library");
            }
            set
            {
                for(int i = 0; i < keyValues.Length; i++)
                {
                    if (keyValues[i].key == keySearch)
                    {
                        keyValues[i] = new KeyValues<int>();
                    }
                    if (keyValues[i].key != keySearch)
                    {
                        keyValues[count] = new KeyValues<int>(keySearch, (int)value);
                      
                    }
                  
                }
                count++;
            }
        }
    }
    
}
