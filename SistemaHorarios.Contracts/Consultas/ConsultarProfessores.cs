using SistemaHorarios.Base;
using System.Collections.Generic;
using System.Runtime.Serialization;

namespace SistemaHorarios.Contracts.ConsultarProfessores
{
    [DataContract]
    public class ConsultarProfessoresRequest : BaseRequest { }

    [DataContract]
    public class ConsultarProfessoresResponse : BaseResponse
    {
        [DataMember]
        public List<ConsultarProfessoresProfessorDTO> Professores { get; set; }
    }

    [DataContract]
    public class ConsultarProfessoresProfessorDTO
    {
        [DataMember]
        public int Codigo { get; set; }
        [DataMember]
        public string Nome { get; set; }
    }
}
