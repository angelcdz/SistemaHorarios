using SistemaHorarios.Base;
using System.Collections.Generic;
using System.Runtime.Serialization;

namespace SistemaHorarios.Contracts.CadastrarNiveisAcesso
{
    [DataContract]
    public class CadastrarNiveisAcessoRequest : BaseRequest
    {
        [DataMember]
        public string Descricao { get; set; }

        [DataMember]
        public bool Consultas { get; set; }

        [DataMember]
        public bool Cadastro { get; set; }

        [DataMember]
        public bool Administrador { get; set; }
    }

    [DataContract]
    public class CadastrarNiveisAcessoResponse : BaseResponse { }
}
