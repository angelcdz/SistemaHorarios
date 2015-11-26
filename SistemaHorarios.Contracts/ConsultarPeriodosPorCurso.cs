using SistemaHorarios.Base;
using System.Collections.Generic;
using System.Runtime.Serialization;

namespace SistemaHorarios.Contracts.ConsultarPeriodosPorCurso
{
    [DataContract]
    public class ConsultarPeriodosPorCursoRequest : BaseRequest
    {
        [DataMember]
        public string Nome { get; set; }
    }

    [DataContract]
    public class ConsultarPeriodosPorCursoResponse : BaseResponse { }
}