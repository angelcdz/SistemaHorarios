using SistemaHorarios.Base;
using System.Collections.Generic;
using System.Runtime.Serialization;

namespace SistemaHorarios.Contracts.CadastrarCursos
{
    [DataContract]
    public class CadastrarCursosRequest : BaseRequest
    {
        [DataMember]
        public string Nome { get; set; }

        [DataMember]
        public int CodigoPerido { get; set; }
    }

    [DataContract]
    public class CadastrarCursosResponse : BaseResponse { }
}
