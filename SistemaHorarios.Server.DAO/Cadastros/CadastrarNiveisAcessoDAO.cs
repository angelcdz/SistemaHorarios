using SistemaHorarios.Base;
using SistemaHorarios.Contracts.CadastrarNiveisAcesso;
using System;
using System.Linq;

namespace SistemaHorarios.Server.DAO
{
    public class CadastrarNiveisAcessoDAO : BaseDAO<CadastrarNiveisAcessoRequest, CadastrarNiveisAcessoResponse>
    {
        protected override CadastrarNiveisAcessoResponse GetData(CadastrarNiveisAcessoRequest request)
        {
            using (var context = new SistemaHorariosEntities())
            {
                context.NiveisAcesso.Add(new NivelAcesso()
                {
                    Administrador = request.Administrador,
                    Cadastro = request.Cadastro,
                    Consulta = request.Consultas,
                    Descricao = request.Descricao
                });

                context.SaveChanges();

                return new CadastrarNiveisAcessoResponse() { Status = ExecutionStatus.Success };
            }
        }
    }
}