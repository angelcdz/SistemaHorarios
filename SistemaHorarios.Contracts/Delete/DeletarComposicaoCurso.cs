using SistemaHorarios.Base;
using System.Collections.Generic;
using System.Runtime.Serialization;

namespace SistemaHorarios.Contracts.DeletarComposicaoCurso
{
    [DataContract]
    public class DeletarComposicaoCursoRequest : BaseRequest
    {
        [DataMember]
        public int Codigo { get; set; }
    }

    [DataContract]
    public class DeletarComposicaoCursoResponse : BaseResponse { }
}