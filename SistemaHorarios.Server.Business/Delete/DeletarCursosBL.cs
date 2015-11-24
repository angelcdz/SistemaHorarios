using SistemaHorarios.Base;
using SistemaHorarios.Contracts.DeletarCursos;
using SistemaHorarios.Server.DAO;
using System;

namespace SistemaHorarios.Server.Business
{
    public class DeletarCursosBL : BaseBL<DeletarCursosRequest, DeletarCursosResponse>
    {
        public override DeletarCursosResponse Execute(DeletarCursosRequest request)
        {
            return new DeletarCursosDAO().Execute(request);
        }
    }
}