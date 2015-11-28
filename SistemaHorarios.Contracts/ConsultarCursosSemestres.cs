using SistemaHorarios.Base;
using System.Collections.Generic;
using System.Runtime.Serialization;

namespace SistemaHorarios.Contracts.ConsultarCursosSemestres
{
    [DataContract]
    public class ConsultarCursosSemestresRequest : BaseRequest
    {
        [DataMember]
        public string Nome { get; set; }
    }

    [DataContract]
    public class ConsultarCursosSemestresResponse : BaseResponse { }
}