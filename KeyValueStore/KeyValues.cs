using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KeyValueStore
{
    struct KeyValues
    {
        public readonly string key;
        public readonly object value;


        public KeyValues(string initialKey, object initialValue)
        {
            key = initialKey;
            value = initialValue;
        }
    }

    public class MyDictionary
    {
        private KeyValues[] keyValues = new KeyValues[2];
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
                        keyValues[i] = new KeyValues();
                    }
                    if (keyValues[i].key != keySearch)
                    {
                        keyValues[count] = new KeyValues(keySearch, value);
                      
                    }
                  
                }
                count++;
            }
        }
    }
    
}
