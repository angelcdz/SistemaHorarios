using SistemaHorarios.Base;
using System.Collections.Generic;
using System.Runtime.Serialization;

namespace SistemaHorarios.Contracts.ConsultarDiasSemana
{
    [DataContract]
    public class ConsultarDiasSemanaRequest : BaseRequest { }

    [DataContract]
    public class ConsultarDiasSemanaResponse : BaseResponse
    {
        [DataMember]
        public List<ConsultarDiasSemanaDiaDTO> Dias { get; set; }
    }

    [DataContract]
    public class ConsultarDiasSemanaDiaDTO
    {
        [DataMember]
        public int CodigoDia { get; set; }
        [DataMember]
        public string Nome { get; set; }
    }
}
