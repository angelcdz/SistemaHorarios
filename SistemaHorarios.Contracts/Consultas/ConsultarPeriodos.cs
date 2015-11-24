using SistemaHorarios.Base;
using System.Collections.Generic;
using System.Runtime.Serialization;

namespace SistemaHorarios.Contracts.ConsultarPeriodos
{
    [DataContract]
    public class ConsultarPeriodosRequest : BaseRequest { }

    [DataContract]
    public class ConsultarPeriodosResponse : BaseResponse
    {
        [DataMember]
        public List<ConsultarPeriodosPeriodoDTO> Periodos { get; set; }
    }

    [DataContract]
    public class ConsultarPeriodosPeriodoDTO
    {
        [DataMember]
        public int Codigo { get; set; }
        [DataMember]
        public string Nome { get; set; }
    }
}
