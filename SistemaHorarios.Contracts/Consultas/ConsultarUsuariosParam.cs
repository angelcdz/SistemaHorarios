using SistemaHorarios.Base;
using SistemaHorarios.Contracts.ConsultarUsuarios;
using System.Collections.Generic;
using System.Runtime.Serialization;

namespace SistemaHorarios.Contracts.ConsultarUsuariosParam
{
    [DataContract]
    public class ConsultarUsuariosParamRequest : BaseRequest
    {
        [DataMember]
        public int Codigo { get; set; }
        [DataMember]
        public string Login { get; set; }
        [DataMember]
        public int CodigoNivel { get; set; }
    }

    [DataContract]
    public class ConsultarUsuariosParamResponse : BaseResponse
    {
        [DataMember]
        public List<ConsultarUsuariosUsuarioDTO> Usuarios { get; set; }
    }
}