using SistemaHorarios.Base;
using System.Collections.Generic;
using System.Runtime.Serialization;

namespace SistemaHorarios.Contracts.ConsultarComposicoesHorario
{
    [DataContract]
    public class ConsultarComposicoesHorarioRequest : BaseRequest
    {
        [DataMember]
        public string Nome { get; set; }
    }

    [DataContract]
    public class ConsultarComposicoesHorarioResponse : BaseResponse { }
}