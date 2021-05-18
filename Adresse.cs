using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AT11_Exemple
{
    [Serializable]
    public class Adresse
    {
        public string rue { get; set; }
        public string ville { get; set; }
        public string pays { get; set; }
    }
}
