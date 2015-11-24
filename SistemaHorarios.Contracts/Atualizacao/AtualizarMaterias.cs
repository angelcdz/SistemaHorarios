using SistemaHorarios.Base;
using System.Collections.Generic;
using System.Runtime.Serialization;

namespace SistemaHorarios.Contracts.AtualizarMaterias
{
    [DataContract]
    public class AtualizarMateriasRequest : BaseRequest
    {
        [DataMember]
        public string Nome { get; set; }
    }

    [DataContract]
    public class AtualizarMateriasResponse : BaseResponse { }
}