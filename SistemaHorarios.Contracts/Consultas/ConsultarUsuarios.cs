using SistemaHorarios.Base;
using System.Collections.Generic;
using System.Runtime.Serialization;

namespace SistemaHorarios.Contracts.ConsultarUsuarios
{
    [DataContract]
    public class ConsultarUsuariosRequest : BaseRequest { }

    [DataContract]
    public class ConsultarUsuariosResponse : BaseResponse
    {
        [DataMember]
        public List<ConsultarUsuariosUsuarioDTO> Usuarios { get; set; }
    }

    [DataContract]
    public class ConsultarUsuariosUsuarioDTO
    {
        [DataMember]
        public int Codigo { get; set; }
        [DataMember]
        public string Login { get; set; }
        [DataMember]
        public System.DateTime? UltimoLogin { get; set; }
        [DataMember]
        public ConsultarUsuariosNivelAcessoDTO NivelAcesso { get; set; }
    }

    [DataContract]
    public class ConsultarUsuariosNivelAcessoDTO
    {
        [DataMember]
        public int Codigo { get; set; }
        [DataMember]
        public string Descricao { get; set; }
        [DataMember]
        public bool? Consulta { get; set; }
        [DataMember]
        public bool? Cadastro { get; set; }
        [DataMember]
        public bool? Administrador { get; set; }
    }
}
