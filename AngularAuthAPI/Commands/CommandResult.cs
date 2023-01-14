using AngularAuthAPI.Commands.Interfaces;

namespace AngularAuthAPI.Commands
{
    public class CommandResult : ICommandResult
    {

        public bool Success { get; set; }
        public string Message { get; set; }
        public object Result { get; set; }

        public CommandResult(bool success, string message, object result = null)
        {
            Success = success;
            Message = message;
            Result = result;
        }
    }
}
