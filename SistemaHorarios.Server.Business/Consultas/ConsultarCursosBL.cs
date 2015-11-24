using SistemaHorarios.Base;
using SistemaHorarios.Contracts.ConsultarCursos;
using SistemaHorarios.Server.DAO;
using System;

namespace SistemaHorarios.Server.Business
{
    public class ConsultarCursosBL : BaseBL<ConsultarCursosRequest, ConsultarCursosResponse>
    {
        public override ConsultarCursosResponse Execute(ConsultarCursosRequest request)
        {
            return new ConsultarCursosDAO().Execute(request);
        }
    }
}
