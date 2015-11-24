using SistemaHorarios.Base;
using SistemaHorarios.Contracts.ConsultarSemestres;
using System.Linq;

namespace SistemaHorarios.Server.DAO
{
    public class ConsultarSemestresDAO : BaseDAO<ConsultarSemestresRequest, ConsultarSemestresResponse>
    {
        protected override ConsultarSemestresResponse GetData(ConsultarSemestresRequest request)
        {
            var response = new ConsultarSemestresResponse()
            {
                Semestres = new System.Collections.Generic.List<ConsultarSemestresSemestreDTO>(),
                Status = ExecutionStatus.Success
            };
            new SistemaHorariosEntities()
                .Semestres
                .ToList()
                .ForEach(
                semestre => 
                    response.Semestres.Add(new ConsultarSemestresSemestreDTO()
                    {
                        Codigo = semestre.CodigoSemestre,
                        Numero = semestre.NumeroSemestre
                    }));
            return response;
        }
    }
}
