using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Switch
{
    class Program
    {
        static void Main(string[] args)
        {
            int s = 30;
            switch (s) //goto
            {
                case 1: /*действие*/;
                    break;//go from switch
                case 2: /*действие*/; ;
                    break;//go from switch
                case 4: /*действие*/;
                    break;//go from switch
                case 5: /*действие*/;
                    break;//go from switch
                default:/*действие*/;
                    break;//go from switch
            }
        }
    }
}
