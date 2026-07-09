using Microsoft.AspNetCore.Http;
using SMConsulting.BL.Exceptions.Common;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SMConsulting.BL.Exceptions
{
    public class NotFoundException : Exception, IBaseException
    {
        public int StatusCode => StatusCodes.Status404NotFound;

        public string ErrorMessage { get; }
        public NotFoundException(string message) : base(message)
        {
            ErrorMessage = message;
        }
    }
    public class NotFoundException<T> : NotFoundException
    {
        public NotFoundException() : base(typeof(T).Name + " not found")
        {

        }
    }
}
