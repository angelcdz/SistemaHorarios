using SistemaHorarios.Base;
using SistemaHorarios.Contracts.ConsultarGrade;
using System;
using System.Linq;

namespace SistemaHorarios.Server.DAO
{
    public class ConsultarGradeDAO : BaseDAO<ConsultarGradeRequest, ConsultarGradeResponse>
    {
        protected override ConsultarGradeResponse GetData(ConsultarGradeRequest request)
        {
            throw new NotImplementedException();
        }
    }
}