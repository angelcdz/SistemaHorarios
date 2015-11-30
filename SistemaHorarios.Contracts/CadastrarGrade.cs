using SistemaHorarios.Base;
using System.Collections.Generic;
using System.Runtime.Serialization;

namespace SistemaHorarios.Contracts.CadastrarGrade
{
    [DataContract]
    public class CadastrarGradeRequest : BaseRequest
    {
        [DataMember]
        public int CodigoCurso { get; set; }
        [DataMember]
        public int CodigoMateria { get; set; }
        [DataMember]
        public int CodigoProfessor { get; set; }
        [DataMember]
        public int CodigoSemestre { get; set; }
        [DataMember]
        public int CodigoDia { get; set; }
        [DataMember]
        public int CodigoHorario { get; set; }
    }

    [DataContract]
    public class CadastrarGradeResponse : BaseResponse { }
}