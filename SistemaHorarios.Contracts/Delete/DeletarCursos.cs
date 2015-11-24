using SistemaHorarios.Base;
using System.Collections.Generic;
using System.Runtime.Serialization;

namespace SistemaHorarios.Contracts.DeletarCursos
{
    [DataContract]
    public class DeletarCursosRequest : BaseRequest
    {
        [DataMember]
        public int Codigo { get; set; }
    }

    [DataContract]
    public class DeletarCursosResponse : BaseResponse { }
}