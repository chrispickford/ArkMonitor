namespace ArkMonitor.Service
{
    public class MessageOfTheDay
    {
        /// <summary>
        ///     Specifies the duration of the welcome message
        /// </summary>
        public int Duration { get; set; }

        /// <summary>
        ///     Defines a welcome message
        /// </summary>
        public string Message { get; set; }
    }
}