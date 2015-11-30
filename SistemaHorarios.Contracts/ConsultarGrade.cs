using SistemaHorarios.Base;
using System;
using System.Collections.Generic;
using System.Runtime.Serialization;

namespace SistemaHorarios.Contracts.ConsultarGrade
{
    [DataContract]
    public class ConsultarGradeRequest : BaseRequest
    {
        [DataMember]
        public int CodPeriodo { get; set; }
        [DataMember]
        public int CodCurso { get; set; }
        [DataMember]
        public int CodSemestre { get; set; }
        [DataMember]
        public int CodDia { get; set; }
    }

    [DataContract]
    public class ConsultarGradeResponse : BaseResponse
    {
        [DataMember]
        public List<ConsultarGradeHorarioDTO> Horarios { get; set; }
    }

    [DataContract]
    public class ConsultarGradeHorarioDTO
    {
        [DataMember]
        public int CodHorario { get; set; }
        [DataMember]
        public TimeSpan HorarioInicial { get; set; }
        [DataMember]
        public TimeSpan HorarioFinal { get; set; }
        [DataMember]
        public ConsultarGradeHorarioMateriaDTO Materia { get; set; }
    }

    [DataContract]
    public class ConsultarGradeHorarioMateriaDTO
    {
        [DataMember]
        public string Materia { get; set; }
        [DataMember]
        public string Professor { get; set; }
    }
}