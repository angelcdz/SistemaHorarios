using SistemaHorarios.Base;
using System.Collections.Generic;
using System.Runtime.Serialization;

namespace SistemaHorarios.Contracts.ConsultarComposicoesCurso
{
    [DataContract]
    public class ConsultarComposicoesCursoRequest : BaseRequest
    {
        [DataMember]
        public string Nome { get; set; }
    }

    [DataContract]
    public class ConsultarComposicoesCursoResponse : BaseResponse { }
}