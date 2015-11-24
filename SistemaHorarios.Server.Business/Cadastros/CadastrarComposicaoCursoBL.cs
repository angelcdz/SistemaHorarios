using SistemaHorarios.Base;
using SistemaHorarios.Contracts.CadastrarComposicaoCurso;
using SistemaHorarios.Server.DAO;
using System;

namespace SistemaHorarios.Server.Business
{
    public class CadastrarComposicaoCursoBL : BaseBL<CadastrarComposicaoCursoRequest, CadastrarComposicaoCursoResponse>
    {
        public override CadastrarComposicaoCursoResponse Execute(CadastrarComposicaoCursoRequest request)
        {
            return new CadastrarComposicaoCursoDAO().Execute(request);
        }
    }
}