using SistemaHorarios.Base;
using SistemaHorarios.Contracts.ConsultarNiveisAcesso;
using SistemaHorarios.Contracts.ConsultarUsuarios;
using System.Collections.Generic;
using System.Runtime.Serialization;

namespace SistemaHorarios.Contracts.ConsultarUsuariosNiveis
{
    [DataContract]
    public class ConsultarUsuariosNiveisRequest : BaseRequest
    {
    }

    [DataContract]
    public class ConsultarUsuariosNiveisResponse : BaseResponse
    {
        [DataMember]
        public List<ConsultarUsuariosUsuarioDTO> Usuarios { get; set; }
        [DataMember]
        public List<ConsultarNiveisAcessoDTO> Niveis { get; set; }
    }
}