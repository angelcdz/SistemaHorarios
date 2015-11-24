using SistemaHorarios.Base;
using System.Collections.Generic;
using System.Runtime.Serialization;

namespace SistemaHorarios.Contracts.ConsultarCursos
{
    [DataContract]
    public class ConsultarCursosRequest : BaseRequest { }

    [DataContract]
    public class ConsultarCursosResponse : BaseResponse
    {
        [DataMember]
        public List<ConsultarCursosCursoDTO> Cursos { get; set; }
    }

    [DataContract]
    public class ConsultarCursosCursoDTO
    {
        [DataMember]
        public int Codigo { get; set; }
        [DataMember]
        public string Nome { get; set; }
        [DataMember]
        public ConsultarCursosPeriodoDTO Periodo { get; set; }
    }

    public class ConsultarCursosPeriodoDTO
    {
        [DataMember]
        public int Codigo { get; set; }
        [DataMember]
        public string NomePeriodo { get; set; }
    }
}
