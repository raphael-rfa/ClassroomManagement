using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassroomManagement.Domain.Exceptions
{
    public class EqualZeroException : Exception
    {
        private const string DEFAULT_ERROR_MESSAGE = "Valor igual a zero";

        public EqualZeroException(string message = DEFAULT_ERROR_MESSAGE) : base(message)
        {}
    }
}
