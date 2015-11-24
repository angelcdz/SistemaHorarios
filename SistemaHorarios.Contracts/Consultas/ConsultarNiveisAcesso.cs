using SistemaHorarios.Base;
using System.Collections.Generic;
using System.Runtime.Serialization;

namespace SistemaHorarios.Contracts.ConsultarNiveisAcesso
{
    [DataContract]
    public class ConsultarNiveisAcessoRequest : BaseRequest { }

    [DataContract]
    public class ConsultarNiveisAcessoResponse : BaseResponse
    {
        [DataMember]
        public List<ConsultarNiveisAcessoDTO> Niveis { get; set; }
    }

    [DataContract]
    public class ConsultarNiveisAcessoDTO
    {
        [DataMember]
        public int Codigo { get; set; }
        [DataMember]
        public string Nome { get; set; }
        [DataMember]
        public bool? Administrador { get; set; }
        [DataMember]
        public bool? Consultas { get; set; }
        [DataMember]
        public bool? Operacoes { get; set; }
    }
}