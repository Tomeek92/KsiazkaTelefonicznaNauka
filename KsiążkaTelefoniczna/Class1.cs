using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KsiążkaTelefoniczna
{
    public class KlasaGeneryczna<T>
    {
        private T genericMember;
        public KlasaGeneryczna(T value)
        {
            genericMember = value;
        }
        public T pobierzGenericMember()
        {
            return genericMember;  
        }

    }
}
