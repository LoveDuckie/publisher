using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Publisher.CLI.Threading
{
    public enum PublisherOperationStates
    {
        Idle = 1,
        Running,
        Stopping,
        Stopped
    }

    /// <summary>
    ///     
    /// </summary>
    public enum PublisherOperationResults
    {
        None = 0,
        Warnings,
        Failed,
        Success
    }

    public sealed class PublisherOperationResult
    {
        #region Fields
        private List<string> messages;
        private PublisherOperationResults result; 
        #endregion

        #region Properties
        public PublisherOperationResults Result { get => result; set => result = value; }
        public List<string> Messages { get => messages; set => messages = value; } 
        #endregion
    }

    public sealed class PublisherOperationAwaitable
    {

    }

    /// <summary>
    /// 
    /// </summary>
    public sealed class PublisherOperation
    {
        public PublisherOperationStates State { get; private set; }
    }
}
