using System;
using System.Collections.Generic;
using System.Text;

namespace Repository.Exceptions
{
    public class CustomExceptions : Exception
    {
        public CustomExceptions(string msj) : base(msj) { }
    }
}
