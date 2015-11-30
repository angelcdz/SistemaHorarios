using SistemaHorarios.Base;
using SistemaHorarios.Contracts.ConsultarHorarios;
using System;
using System.Collections.Generic;
using System.Runtime.Serialization;

namespace SistemaHorarios.Contracts.ConsultarHorarioParam
{
    [DataContract]
    public class ConsultarHorarioParamRequest : BaseRequest
    {
        [DataMember]
        public int Codigo { get; set; }
        [DataMember]
        public TimeSpan Inicial { get; set; }
        [DataMember]
        public TimeSpan Final { get; set; }
        [DataMember]
        public int CodigoDia { get; set; }
        [DataMember]
        public int CodigoPeriodo { get; set; }
    }

    [DataContract]
    public class ConsultarHorarioParamResponse : BaseResponse
    {
        [DataMember]
        public List<ConsultarHorariosHorarioDTO> Horarios { get; set; }
    }
}