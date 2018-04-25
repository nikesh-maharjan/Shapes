using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Shapes
{
    public class LessThanZeroException : Exception
    {
        public LessThanZeroException(){}

        public LessThanZeroException(string message) : base(message) { }

        public LessThanZeroException(string message, Exception inner) : base(message, inner){ }
    }

    public class LessThanOrEqualToZeroException: Exception
    {
        public LessThanOrEqualToZeroException() { }
        public LessThanOrEqualToZeroException(string message) : base(message) { }
        public LessThanOrEqualToZeroException(string message, Exception inner) : base(message, inner) { }
    }
}

