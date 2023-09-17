using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task1.Exceptions
{
    /*
     * Standard Exception Class for displaying errors if the triangle does not exist.
     */
    public class ShapeException : Exception
    {
        public ShapeException(string message) : base(message) { }
    }
}
