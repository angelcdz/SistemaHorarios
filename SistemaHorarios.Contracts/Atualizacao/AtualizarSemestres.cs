using SistemaHorarios.Base;
using System.Collections.Generic;
using System.Runtime.Serialization;

namespace SistemaHorarios.Contracts.AtualizarSemestres
{
    [DataContract]
    public class AtualizarSemestresRequest : BaseRequest
    {
        [DataMember]
        public string Nome { get; set; }
    }

    [DataContract]
    public class AtualizarSemestresResponse : BaseResponse { }
}