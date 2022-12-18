using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TheNorthwind.Business
{
    public class CommandResult
    {
        public bool IsSucces { get; set; }
        public string Message { get; set; }

        public string ErrorMessage { get; set; }

        //overload bir static metot yazarım sadece başarılı yazar aşağıdaki successi çağırır
        public static CommandResult Success(string message)
        {
            var commandResult = new CommandResult();
            commandResult.IsSucces = true;
            commandResult.Message = message;
            return commandResult;
        }

        public static CommandResult Failure(string message, Exception exception)
        {
            return new CommandResult()
            {
                IsSucces = false,
                Message = message,
                ErrorMessage = exception.ToString()
            };
        }

    }
}

