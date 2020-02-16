namespace Services
{
    using NLog;
    public abstract class AbstractService
    {
        /// <summary>
        /// Logger
        /// </summary>
        protected static Logger logger = LogManager.GetCurrentClassLogger();
    }
}
