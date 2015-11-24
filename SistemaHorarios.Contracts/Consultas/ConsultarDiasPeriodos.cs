using SistemaHorarios.Base;
using SistemaHorarios.Contracts.ConsultarDiasSemana;
using SistemaHorarios.Contracts.ConsultarPeriodos;
using System.Collections.Generic;
using System.Runtime.Serialization;

namespace SistemaHorarios.Contracts.ConsultarDiasPeriodos
{
    [DataContract]
    public class ConsultarDiasPeriodosRequest : BaseRequest { }

    [DataContract]
    public class ConsultarDiasPeriodosResponse : BaseResponse
    {
        [DataMember]
        public List<ConsultarDiasSemanaDiaDTO> Dias { get; set; }

        [DataMember]
        public List<ConsultarPeriodosPeriodoDTO> Periodos { get; set; }
    }
}