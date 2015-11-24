using SistemaHorarios.Base;
using System.Collections.Generic;
using System.Runtime.Serialization;

namespace SistemaHorarios.Contracts.AtualizarComposicaoCurso
{
    [DataContract]
    public class AtualizarComposicaoCursoRequest : BaseRequest
    {
        [DataMember]
        public string Nome { get; set; }
    }

    [DataContract]
    public class AtualizarComposicaoCursoResponse : BaseResponse { }
}