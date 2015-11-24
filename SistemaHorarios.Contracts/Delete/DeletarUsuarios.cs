using SistemaHorarios.Base;
using System.Collections.Generic;
using System.Runtime.Serialization;

namespace SistemaHorarios.Contracts.DeletarUsuarios
{
    [DataContract]
    public class DeletarUsuariosRequest : BaseRequest
    {
        [DataMember]
        public int Codigo { get; set; }
    }

    [DataContract]
    public class DeletarUsuariosResponse : BaseResponse { }
}