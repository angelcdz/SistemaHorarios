using SistemaHorarios.Base;
using System.Collections.Generic;
using System.Runtime.Serialization;

namespace SistemaHorarios.Contracts.ConsultarSemestres
{
    [DataContract]
    public class ConsultarSemestresRequest : BaseRequest { }

    [DataContract]
    public class ConsultarSemestresResponse : BaseResponse
    {
        [DataMember]
        public List<ConsultarSemestresSemestreDTO> Semestres { get; set; }
    }

    [DataContract]
    public class ConsultarSemestresSemestreDTO
    {
        [DataMember]
        public int Codigo { get; set; }
        [DataMember]
        public int Numero { get; set; }
    }
}
