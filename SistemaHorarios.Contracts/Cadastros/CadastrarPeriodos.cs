using SistemaHorarios.Base;
using System.Collections.Generic;
using System.Runtime.Serialization;

namespace SistemaHorarios.Contracts.CadastrarPeriodos
{
    [DataContract]
    public class CadastrarPeriodosRequest : BaseRequest
    {
        [DataMember]
        public string Nome { get; set; }
    }

    [DataContract]
    public class CadastrarPeriodosResponse : BaseResponse { }
}
