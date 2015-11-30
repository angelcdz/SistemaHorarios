using SistemaHorarios.Base;
using SistemaHorarios.Contracts.ConsultarCursos;
using SistemaHorarios.Contracts.ConsultarDiasSemana;
using SistemaHorarios.Contracts.ConsultarSemestres;
using System.Collections.Generic;
using System.Runtime.Serialization;

namespace SistemaHorarios.Contracts.ConsultarCursosPeriodosSemestres
{
    [DataContract]
    public class ConsultarCursosPeriodosSemestresRequest : BaseRequest
    {
    }

    [DataContract]
    public class ConsultarCursosPeriodosSemestresResponse : BaseResponse
    {
        [DataMember]
        public List<ConsultarCursosCursoDTO> Cursos { get; set; }
        [DataMember]
        public List<ConsultarSemestresSemestreDTO> Semestres { get; set; }
        [DataMember]
        public List<ConsultarDiasSemanaDiaDTO> DiasSemana { get; set; }
    }
}