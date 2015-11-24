using SistemaHorarios.Base;
using System.Collections.Generic;
using System.Runtime.Serialization;

namespace SistemaHorarios.Contracts.CadastrarSemestres
{
    [DataContract]
    public class CadastrarSemestresRequest : BaseRequest
    {
        [DataMember]
        public int Numero { get; set; }
    }

    [DataContract]
    public class CadastrarSemestresResponse : BaseResponse { }
}
