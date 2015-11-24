using SistemaHorarios.Base;
using System.Collections.Generic;
using System.Runtime.Serialization;

namespace SistemaHorarios.Contracts.CadastrarHorarios
{
    [DataContract]
    public class CadastrarHorariosRequest : BaseRequest
    {
        [DataMember]
        public System.TimeSpan HoraInicial { get; set; }

        [DataMember]
        public System.TimeSpan HoraFinal { get; set; }

        [DataMember]
        public int CodigoDiaSemana { get; set; }

        [DataMember]
        public int CodigoPeriodo { get; set; }
    }

    [DataContract]
    public class CadastrarHorariosResponse : BaseResponse { }
}
