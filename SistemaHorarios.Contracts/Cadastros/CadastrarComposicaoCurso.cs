using SistemaHorarios.Base;
using System.Collections.Generic;
using System.Runtime.Serialization;

namespace SistemaHorarios.Contracts.CadastrarComposicaoCurso
{
    [DataContract]
    public class CadastrarComposicaoCursoRequest : BaseRequest
    {
        [DataMember]
        public int CodigoCurso { get; set; }

        [DataMember]
        public int CodigoMateria { get; set; }

        [DataMember]
        public int CodigoProfessor { get; set; }

        [DataMember]
        public int CodigoSemestre { get; set; }
    }

    [DataContract]
    public class CadastrarComposicaoCursoResponse : BaseResponse { }
}
