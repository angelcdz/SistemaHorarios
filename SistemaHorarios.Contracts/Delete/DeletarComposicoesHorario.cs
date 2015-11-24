using SistemaHorarios.Base;
using System.Collections.Generic;
using System.Runtime.Serialization;

namespace SistemaHorarios.Contracts.DeletarComposicoesHorario
{
    [DataContract]
    public class DeletarComposicoesHorarioRequest : BaseRequest
    {
        [DataMember]
        public int Codigo { get; set; }
    }

    [DataContract]
    public class DeletarComposicoesHorarioResponse : BaseResponse { }
}