using SistemaHorarios.Base;
using System.Collections.Generic;
using System.Runtime.Serialization;

namespace SistemaHorarios.Contracts.AtualizarNiveisAcesso
{
    [DataContract]
    public class AtualizarNiveisAcessoRequest : BaseRequest
    {
        [DataMember]
        public string Nome { get; set; }
    }

    [DataContract]
    public class AtualizarNiveisAcessoResponse : BaseResponse { }
}