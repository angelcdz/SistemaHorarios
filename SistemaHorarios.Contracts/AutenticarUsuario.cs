using SistemaHorarios.Base;
using System.Collections.Generic;
using System.Runtime.Serialization;

namespace SistemaHorarios.Contracts.AutenticarUsuario
{
    [DataContract]
    public class AutenticarUsuarioRequest : BaseRequest
    {
        [DataMember]
        public string Login { get; set; }
        [DataMember]
        public string Senha { get; set; }
    }

    [DataContract]
    public class AutenticarUsuarioResponse : BaseResponse
    {
        [DataMember]
        public bool Existe { get; set; }
        [DataMember]
        public bool Autenticado { get; set; }
        [DataMember]
        public AutenticarUsuarioNivelAcessoDTO NivelAcesso { get; set; }
    }

    [DataContract]
    public class AutenticarUsuarioNivelAcessoDTO
    {
        [DataMember]
        public string Nome { get; set; }
        [DataMember]
        public bool Administrador { get; set; }
        [DataMember]
        public bool Cadastro { get; set; }
        [DataMember]
        public bool Consulta { get; set; }
    }
}