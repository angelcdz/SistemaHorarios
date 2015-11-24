using SistemaHorarios.Base;
using System.Collections.Generic;
using System.Runtime.Serialization;

namespace SistemaHorarios.Contracts.CadastrarComposicoesHorario
{
    [DataContract]
    public class CadastrarComposicoesHorarioRequest : BaseRequest
    {
        [DataMember]
        public int CodigoComposicaoCurso { get; set; }

        [DataMember]
        public int CodigoHorario { get; set; }
    }

    [DataContract]
    public class CadastrarComposicoesHorarioResponse : BaseResponse { }
}
