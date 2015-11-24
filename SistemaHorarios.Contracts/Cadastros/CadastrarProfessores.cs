using SistemaHorarios.Base;
using System.Collections.Generic;
using System.Runtime.Serialization;

namespace SistemaHorarios.Contracts.CadastrarProfessores
{
    [DataContract]
    public class CadastrarProfessoresRequest : BaseRequest
    {
        [DataMember]
        public string Nome { get; set; }
    }

    [DataContract]
    public class CadastrarProfessoresResponse : BaseResponse { }
}
