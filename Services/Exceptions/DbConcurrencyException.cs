using System;

namespace CRUD.Services.Exceptions
{
    public class DbConcurrencyException : ApplicationException
    {
        public DbConcurrencyException(string message) : base()
        {

        }
    }
}
