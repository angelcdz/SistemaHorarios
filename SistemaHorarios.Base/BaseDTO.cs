using System;
using System.Runtime.Serialization;
namespace SistemaHorarios.Base
{
    [DataContract]
    public abstract class BaseRequest
    {
        [DataMember]
        public Guid TransactionId = Guid.NewGuid();
    }

    [DataContract]
    public abstract class BaseResponse
    {
        [DataMember]
        public string ErrorMessage { get; set; }
        [DataMember]
        public string ErrorCode { get; set; }
        [DataMember]
        public ExecutionStatus Status { get; set; }
    }

    public enum ExecutionStatus
    {
        [EnumMember]
        NotExecuted,
        [EnumMember]
        TechnicalError,
        [EnumMember]
        BusinessError,
        [EnumMember]
        Success
    }
    
}
