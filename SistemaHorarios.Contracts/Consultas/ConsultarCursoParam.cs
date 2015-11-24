using SistemaHorarios.Base;
using SistemaHorarios.Contracts.ConsultarCursos;
using System.Collections.Generic;
using System.Runtime.Serialization;

namespace SistemaHorarios.Contracts.ConsultarCursoParam
{
    [DataContract]
    public class ConsultarCursoParamRequest : BaseRequest
    {
        [DataMember]
        public int Codigo { get; set; }
        [DataMember]
        public string Nome { get; set; }
        [DataMember]
        public int CodigoPeriodo { get; set; }
    }

    [DataContract]
    public class ConsultarCursoParamResponse : BaseResponse
    {
        [DataMember]
        public List<ConsultarCursosCursoDTO> Cursos { get; set; }
    }
}