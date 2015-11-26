using SistemaHorarios.Base;
using System.Collections.Generic;
using System.Runtime.Serialization;

namespace SistemaHorarios.Contracts.ConsultarGrade
{
    [DataContract]
    public class ConsultarGradeRequest : BaseRequest
    {
        [DataMember]
        public string Nome { get; set; }
    }

    [DataContract]
    public class ConsultarGradeResponse : BaseResponse { }
}