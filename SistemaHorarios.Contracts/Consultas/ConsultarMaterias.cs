using SistemaHorarios.Base;
using System.Collections.Generic;
using System.Runtime.Serialization;

namespace SistemaHorarios.Contracts.ConsultarMaterias
{
    [DataContract]
    public class ConsultarMateriasRequest : BaseRequest { }

    [DataContract]
    public class ConsultarMateriasResponse : BaseResponse
    {
        [DataMember]
        public List<ConsultarMateriasMateriaDTO> Materias { get; set; }
    }

    [DataContract]
    public class ConsultarMateriasMateriaDTO
    {
        [DataMember]
        public int Codigo { get; set; }
        [DataMember]
        public string Nome { get; set; }
    }
}
