using SistemaHorarios.Base;
using SistemaHorarios.Contracts.AtualizarCursos;
using SistemaHorarios.Server.DAO;
using System;

namespace SistemaHorarios.Server.Business
{
    public class AtualizarCursosBL : BaseBL<AtualizarCursosRequest, AtualizarCursosResponse>
    {
        public override AtualizarCursosResponse Execute(AtualizarCursosRequest request)
        {
            return new AtualizarCursosDAO().Execute(request);
        }
    }
}