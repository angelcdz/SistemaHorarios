using SistemaHorarios.Base;
using System.Collections.Generic;
using System.Runtime.Serialization;

namespace SistemaHorarios.Contracts.CadastrarUsuarios
{
    [DataContract]
    public class CadastrarUsuariosRequest : BaseRequest
    {
        [DataMember]
        public string Login { get; set; }

        [DataMember]
        public string Senha { get; set; }

        [DataMember]
        public int CodigoNivelAcesso { get; set; }
    }

    [DataContract]
    public class CadastrarUsuariosResponse : BaseResponse { }
}
