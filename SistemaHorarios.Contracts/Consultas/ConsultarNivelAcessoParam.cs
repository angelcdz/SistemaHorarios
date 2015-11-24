using SistemaHorarios.Base;
using SistemaHorarios.Contracts.ConsultarNiveisAcesso;
using System.Collections.Generic;
using System.Runtime.Serialization;

namespace SistemaHorarios.Contracts.ConsultarNivelAcessoParam
{
    [DataContract]
    public class ConsultarNivelAcessoParamRequest : BaseRequest
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

    [DataContract]
    public class ConsultarNivelAcessoParamResponse : BaseResponse
    {
        [DataMember]
        public List<ConsultarNiveisAcessoDTO> Niveis { get; set; }
    }
}