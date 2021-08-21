using System;


namespace WebSalesMvc.Services.Exceptions
{
    public class NotFoundExceptions : ApplicationException
    {
        public NotFoundExceptions(string message) : base(message)
        {

        }

    }
}
