using SistemaHorarios.Base;
using SistemaHorarios.Contracts.ConsultarCursos;
using SistemaHorarios.Contracts.ConsultarDiasSemana;
using SistemaHorarios.Contracts.ConsultarMaterias;
using SistemaHorarios.Contracts.ConsultarProfessores;
using SistemaHorarios.Contracts.ConsultarSemestres;
using System.Collections.Generic;
using System.Runtime.Serialization;

namespace SistemaHorarios.Contracts.ConsultarParametrosCadastroGrade
{
    [DataContract]
    public class ConsultarParametrosCadastroGradeRequest : BaseRequest
    { }

    [DataContract]
    public class ConsultarParametrosCadastroGradeResponse : BaseResponse
    {
        [DataMember]
        public List<ConsultarMateriasMateriaDTO> Materias { get; set; }
        [DataMember]
        public List<ConsultarProfessoresProfessorDTO> Professores { get; set; }
        [DataMember]
        public List<ConsultarSemestresSemestreDTO> Semestres { get; set; }
        [DataMember]
        public List<ConsultarCursosCursoDTO> Cursos { get; set; }
        [DataMember]
        public List<ConsultarDiasSemanaDiaDTO> Dias { get; set; }
    }
}