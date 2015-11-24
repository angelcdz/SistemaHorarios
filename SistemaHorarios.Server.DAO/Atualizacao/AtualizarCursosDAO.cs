using SistemaHorarios.Base;
using SistemaHorarios.Contracts.AtualizarCursos;
using System;
using System.Linq;

namespace SistemaHorarios.Server.DAO
{
    public class AtualizarCursosDAO : BaseDAO<AtualizarCursosRequest, AtualizarCursosResponse>
    {
        protected override AtualizarCursosResponse GetData(AtualizarCursosRequest request)
        {
            throw new NotImplementedException();
        }
    }
}