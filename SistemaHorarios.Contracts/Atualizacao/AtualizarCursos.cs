using SistemaHorarios.Base;
using System.Collections.Generic;
using System.Runtime.Serialization;

namespace SistemaHorarios.Contracts.AtualizarCursos
{
    [DataContract]
    public class AtualizarCursosRequest : BaseRequest
    {
        [DataMember]
        public string Nome { get; set; }
    }

    [DataContract]
    public class AtualizarCursosResponse : BaseResponse { }
}