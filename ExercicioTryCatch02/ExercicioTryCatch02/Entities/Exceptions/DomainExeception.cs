using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExercicioTryCatch02.Entities.Exceptions
{
    class DomainExeception : ApplicationException
    {
        public DomainExeception(string message) : base(message) { }
    }
}
