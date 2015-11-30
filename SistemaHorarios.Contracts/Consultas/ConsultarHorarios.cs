using SistemaHorarios.Base;
using SistemaHorarios.Contracts.ConsultarPeriodos;
using System.Collections.Generic;
using System.Runtime.Serialization;

namespace SistemaHorarios.Contracts.ConsultarHorarios
{
    [DataContract]
    public class ConsultarHorariosRequest : BaseRequest { }

    [DataContract]
    public class ConsultarHorariosResponse : BaseResponse
    {
        [DataMember]
        public List<ConsultarHorariosHorarioDTO> Horarios { get; set; }
    }

    [DataContract]
    public class ConsultarHorariosHorarioDTO
    {
        [DataMember]
        public int Codigo { get; set; }
        [DataMember]
        public System.TimeSpan HoraInicial { get; set; }
        [DataMember]
        public System.TimeSpan HoraFinal { get; set; }
        [DataMember]
        public ConsultarHorariosDiaDTO DiaSemana { get; set; }
        [DataMember]
        public ConsultarPeriodosPeriodoDTO Periodo { get; set; }
    }

    [DataContract]
    public class ConsultarHorariosDiaDTO
    {
        [DataMember]
        public int Codigo { get; set; }
        [DataMember]
        public string Nome { get; set; }
    }
}
