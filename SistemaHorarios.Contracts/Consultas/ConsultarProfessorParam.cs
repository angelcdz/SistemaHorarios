using SistemaHorarios.Base;
using SistemaHorarios.Contracts.ConsultarProfessores;
using System.Collections.Generic;
using System.Runtime.Serialization;

namespace SistemaHorarios.Contracts.ConsultarProfessorParam
{
    [DataContract]
    public class ConsultarProfessorParamRequest : BaseRequest
    {
        [DataMember]
        public int Codigo { get; set; }
        [DataMember]
        public string Nome { get; set; }
    }

    [DataContract]
    public class ConsultarProfessorParamResponse : BaseResponse
    {
        [DataMember]
        public List<ConsultarProfessoresProfessorDTO> Professores { get; set; }
    }
}