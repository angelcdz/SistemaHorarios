using SistemaHorarios.Base;
using System.Collections.Generic;
using System.Runtime.Serialization;

namespace SistemaHorarios.Contracts.DeletarNiveisAcesso
{
    [DataContract]
    public class DeletarNiveisAcessoRequest : BaseRequest
    {
        [DataMember]
        public int Codigo { get; set; }
    }

    [DataContract]
    public class DeletarNiveisAcessoResponse : BaseResponse { }
}