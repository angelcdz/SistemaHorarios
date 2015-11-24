using SistemaHorarios.Base;
using SistemaHorarios.Contracts.ConsultarMaterias;
using System.Collections.Generic;
using System.Runtime.Serialization;

namespace SistemaHorarios.Contracts.ConsultarMateriaParam
{
    [DataContract]
    public class ConsultarMateriaParamRequest : BaseRequest
    {
        [DataMember]
        public int Codigo { get; set; }
        [DataMember]
        public string Nome { get; set; }
    }

    [DataContract]
    public class ConsultarMateriaParamResponse : BaseResponse
    {
        [DataMember]
        public List<ConsultarMateriasMateriaDTO> Materias { get; set; }
    }
}