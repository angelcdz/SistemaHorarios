using SistemaHorarios.Base;
using System.Collections.Generic;
using System.Runtime.Serialization;

namespace SistemaHorarios.Contracts.AtualizarPeriodos
{
    [DataContract]
    public class AtualizarPeriodosRequest : BaseRequest
    {
        [DataMember]
        public string Nome { get; set; }
    }

    [DataContract]
    public class AtualizarPeriodosResponse : BaseResponse { }
}