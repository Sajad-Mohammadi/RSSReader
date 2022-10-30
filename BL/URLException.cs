using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BL
{
    public class URLException : Exception
    {
        public URLException(string message) : base(message)
        {
            Console.WriteLine(message);
        }
    }
}
