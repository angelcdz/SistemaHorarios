using SistemaHorarios.Base;
using System.Collections.Generic;
using System.Runtime.Serialization;

namespace SistemaHorarios.Contracts.CadastrarMaterias
{
    [DataContract]
    public class CadastrarMateriasRequest : BaseRequest
    {
        [DataMember]
        public string Nome { get; set; }
    }

    [DataContract]
    public class CadastrarMateriasResponse : BaseResponse { }
}
