using SistemaHorarios.Base;
using SistemaHorarios.Contracts.CadastrarCursos;
using SistemaHorarios.Server.DAO;
using System;

namespace SistemaHorarios.Server.Business
{
    public class CadastrarCursosBL : BaseBL<CadastrarCursosRequest, CadastrarCursosResponse>
    {
        public override CadastrarCursosResponse Execute(CadastrarCursosRequest request)
        {
            return new CadastrarCursosDAO().Execute(request);
        }
    }
}