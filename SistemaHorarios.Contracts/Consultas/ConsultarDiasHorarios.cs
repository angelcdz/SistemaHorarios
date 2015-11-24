using SistemaHorarios.Base;
using SistemaHorarios.Contracts.ConsultarDiasSemana;
using SistemaHorarios.Contracts.ConsultarHorarios;
using System.Collections.Generic;
using System.Runtime.Serialization;

namespace SistemaHorarios.Contracts.ConsultarDiasHorarios
{
    [DataContract]
    public class ConsultarDiasHorariosRequest : BaseRequest
    {
    }

    [DataContract]
    public class ConsultarDiasHorariosResponse : BaseResponse
    {
        [DataMember]
        public List<ConsultarDiasSemanaDiaDTO> Dias { get; set; }
        [DataMember]
        public List<ConsultarHorariosHorarioDTO> Horarios { get; set; }
    }
}