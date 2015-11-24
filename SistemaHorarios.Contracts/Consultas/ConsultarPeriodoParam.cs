using SistemaHorarios.Base;
using System.Collections.Generic;
using System.Runtime.Serialization;

namespace SistemaHorarios.Contracts.ConsultarPeriodoParam
{
    [DataContract]
    public class ConsultarPeriodoParamRequest : BaseRequest
    {
        [DataMember]
        public string Nome { get; set; }
    }

    [DataContract]
    public class ConsultarPeriodoParamResponse : BaseResponse { }
}