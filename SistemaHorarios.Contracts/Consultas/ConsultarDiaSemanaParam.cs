using SistemaHorarios.Base;
using System.Collections.Generic;
using System.Runtime.Serialization;

namespace SistemaHorarios.Contracts.ConsultarDiaSemanaParam
{
    [DataContract]
    public class ConsultarDiaSemanaParamRequest : BaseRequest
    {
        [DataMember]
        public string Nome { get; set; }
    }

    [DataContract]
    public class ConsultarDiaSemanaParamResponse : BaseResponse { }
}