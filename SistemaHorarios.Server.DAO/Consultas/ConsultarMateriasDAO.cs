using SistemaHorarios.Base;
using SistemaHorarios.Contracts.ConsultarMaterias;
using System.Linq;

namespace SistemaHorarios.Server.DAO
{
    public class ConsultarMateriasDAO : BaseDAO<ConsultarMateriasRequest, ConsultarMateriasResponse>
    {
        protected override ConsultarMateriasResponse GetData(ConsultarMateriasRequest request)
        {
            var response = new ConsultarMateriasResponse()
            {
                Materias = new System.Collections.Generic.List<ConsultarMateriasMateriaDTO>(),
                Status = ExecutionStatus.Success
            };
            new SistemaHorariosEntities()
                .Materias
                .ToList()
                .ForEach(
                materia =>
                    response.Materias.Add(new ConsultarMateriasMateriaDTO()
                    {
                        Codigo = materia.CodigoMateria,
                        Nome = UppercaseWords(materia.NomeMateria)
                    }));
            return response;
        }
    }
}
