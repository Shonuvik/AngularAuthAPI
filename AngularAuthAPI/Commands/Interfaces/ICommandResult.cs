namespace AngularAuthAPI.Commands.Interfaces
{
    public interface ICommandResult
    {
        /// <summary>
        /// Success
        /// </summary>
        public bool Success { get; set; }

        /// <summary>
        /// Message
        /// </summary>
        public string Message { get; set; }

        /// <summary>
        /// 
        /// </summary>
        public object Result { get; set; }
    }
}
