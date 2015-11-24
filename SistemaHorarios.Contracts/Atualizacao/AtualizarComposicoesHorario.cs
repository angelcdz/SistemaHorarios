using SistemaHorarios.Base;
using System.Collections.Generic;
using System.Runtime.Serialization;

namespace SistemaHorarios.Contracts.AtualizarComposicoesHorario
{
    [DataContract]
    public class AtualizarComposicoesHorarioRequest : BaseRequest
    {
        [DataMember]
        public string Nome { get; set; }
    }

    [DataContract]
    public class AtualizarComposicoesHorarioResponse : BaseResponse { }
}