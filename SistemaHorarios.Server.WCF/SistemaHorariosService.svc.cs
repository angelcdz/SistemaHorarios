using SistemaHorarios.Server.Business;

namespace SistemaHorarios.Server.WCF
{
    public class SistemaHorariosService : SistemaHorarios.Base.BaseService, ISistemaHorariosService
    {
        public Contracts.ConsultarCursos.ConsultarCursosResponse ConsultarCursos(Contracts.ConsultarCursos.ConsultarCursosRequest request)
        {
            return this.ExecuteBusiness(new ConsultarCursosBL(), request);
        }

        public Contracts.ConsultarDiasSemana.ConsultarDiasSemanaResponse ConsultarDiasSemana(Contracts.ConsultarDiasSemana.ConsultarDiasSemanaRequest request)
        {
            return this.ExecuteBusiness(new ConsultarDiasSemanaBL(), request);
        }

        public Contracts.ConsultarHorarios.ConsultarHorariosResponse ConsultarHorarios(Contracts.ConsultarHorarios.ConsultarHorariosRequest request)
        {
            return this.ExecuteBusiness(new ConsultarHorariosBL(), request);
        }

        public Contracts.ConsultarMaterias.ConsultarMateriasResponse ConsultarMaterias(Contracts.ConsultarMaterias.ConsultarMateriasRequest request)
        {
            return this.ExecuteBusiness(new ConsultarMateriasBL(), request);
        }

        public Contracts.ConsultarPeriodos.ConsultarPeriodosResponse ConsultarPeriodos(Contracts.ConsultarPeriodos.ConsultarPeriodosRequest request)
        {
            return this.ExecuteBusiness(new ConsultarPeriodosBL(), request);
        }

        public Contracts.ConsultarProfessores.ConsultarProfessoresResponse ConsultarProfessores(Contracts.ConsultarProfessores.ConsultarProfessoresRequest request)
        {
            return this.ExecuteBusiness(new ConsultarProfessoresBL(), request);
        }

        public Contracts.ConsultarSemestres.ConsultarSemestresResponse ConsultarSemestres(Contracts.ConsultarSemestres.ConsultarSemestresRequest request)
        {
            return this.ExecuteBusiness(new ConsultarSemestresBL(), request);
        }

        public Contracts.ConsultarUsuarios.ConsultarUsuariosResponse ConsultarUsuarios(Contracts.ConsultarUsuarios.ConsultarUsuariosRequest request)
        {
            return this.ExecuteBusiness(new ConsultarUsuariosBL(), request);
        }

        public Contracts.CadastrarComposicaoCurso.CadastrarComposicaoCursoResponse CadastrarComposicaoCurso(Contracts.CadastrarComposicaoCurso.CadastrarComposicaoCursoRequest request)
        {
            return this.ExecuteBusiness(new CadastrarComposicaoCursoBL(), request);
        }

        public Contracts.CadastrarComposicoesHorario.CadastrarComposicoesHorarioResponse CadastrarComposicoesHorario(Contracts.CadastrarComposicoesHorario.CadastrarComposicoesHorarioRequest request)
        {
            return this.ExecuteBusiness(new CadastrarComposicoesHorarioBL(), request);
        }

        public Contracts.CadastrarCursos.CadastrarCursosResponse CadastrarCursos(Contracts.CadastrarCursos.CadastrarCursosRequest request)
        {
            return this.ExecuteBusiness(new CadastrarCursosBL(), request);
        }

        public Contracts.CadastrarHorarios.CadastrarHorariosResponse CadastrarHorarios(Contracts.CadastrarHorarios.CadastrarHorariosRequest request)
        {
            return this.ExecuteBusiness(new CadastrarHorariosBL(), request);
        }

        public Contracts.CadastrarMaterias.CadastrarMateriasResponse CadastrarMaterias(Contracts.CadastrarMaterias.CadastrarMateriasRequest request)
        {
            return this.ExecuteBusiness(new CadastrarMateriasBL(), request);
        }

        public Contracts.CadastrarNiveisAcesso.CadastrarNiveisAcessoResponse CadastrarNiveisAcesso(Contracts.CadastrarNiveisAcesso.CadastrarNiveisAcessoRequest request)
        {
            return this.ExecuteBusiness(new CadastrarNiveisAcessoBL(), request);
        }

        public Contracts.CadastrarPeriodos.CadastrarPeriodosResponse CadastrarPeriodos(Contracts.CadastrarPeriodos.CadastrarPeriodosRequest request)
        {
            return this.ExecuteBusiness(new CadastrarPeriodosBL(), request);
        }

        public Contracts.CadastrarProfessores.CadastrarProfessoresResponse CadastrarProfessores(Contracts.CadastrarProfessores.CadastrarProfessoresRequest request)
        {
            return this.ExecuteBusiness(new CadastrarProfessoresBL(), request);
        }

        public Contracts.CadastrarSemestres.CadastrarSemestresResponse CadastrarSemestres(Contracts.CadastrarSemestres.CadastrarSemestresRequest request)
        {
            return this.ExecuteBusiness(new CadastrarSemestresBL(), request);
        }

        public Contracts.CadastrarUsuarios.CadastrarUsuariosResponse CadastrarUsuarios(Contracts.CadastrarUsuarios.CadastrarUsuariosRequest request)
        {
            return this.ExecuteBusiness(new CadastrarUsuariosBL(), request);
        }

        public Contracts.ConsultarComposicoesCurso.ConsultarComposicoesCursoResponse ConsultarComposicoesCurso(Contracts.ConsultarComposicoesCurso.ConsultarComposicoesCursoRequest request)
        {
            return this.ExecuteBusiness(new ConsultarComposicoesCursoBL(), request);
        }

        public Contracts.ConsultarComposicoesHorario.ConsultarComposicoesHorarioResponse ConsultarComposicoesHorario(Contracts.ConsultarComposicoesHorario.ConsultarComposicoesHorarioRequest request)
        {
            return this.ExecuteBusiness(new ConsultarComposicoesHorarioBL(), request);
        }

        public Contracts.AtualizarComposicaoCurso.AtualizarComposicaoCursoResponse AtualizarComposicaoCurso(Contracts.AtualizarComposicaoCurso.AtualizarComposicaoCursoRequest request)
        {
            return this.ExecuteBusiness(new AtualizarComposicaoCursoBL(), request);
        }

        public Contracts.AtualizarComposicoesHorario.AtualizarComposicoesHorarioResponse AtualizarComposicoesHorario(Contracts.AtualizarComposicoesHorario.AtualizarComposicoesHorarioRequest request)
        {
            return this.ExecuteBusiness(new AtualizarComposicoesHorarioBL(), request);
        }

        public Contracts.AtualizarCursos.AtualizarCursosResponse AtualizarCursos(Contracts.AtualizarCursos.AtualizarCursosRequest request)
        {
            return this.ExecuteBusiness(new AtualizarCursosBL(), request);
        }

        public Contracts.AtualizarHorarios.AtualizarHorariosResponse AtualizarHorarios(Contracts.AtualizarHorarios.AtualizarHorariosRequest request)
        {
            return this.ExecuteBusiness(new AtualizarHorariosBL(), request);
        }

        public Contracts.AtualizarMaterias.AtualizarMateriasResponse AtualizarMaterias(Contracts.AtualizarMaterias.AtualizarMateriasRequest request)
        {
            return this.ExecuteBusiness(new AtualizarMateriasBL(), request);
        }

        public Contracts.AtualizarNiveisAcesso.AtualizarNiveisAcessoResponse AtualizarNiveisAcesso(Contracts.AtualizarNiveisAcesso.AtualizarNiveisAcessoRequest request)
        {
            return this.ExecuteBusiness(new AtualizarNiveisAcessoBL(), request);
        }

        public Contracts.AtualizarPeriodos.AtualizarPeriodosResponse AtualizarPeriodos(Contracts.AtualizarPeriodos.AtualizarPeriodosRequest request)
        {
            return this.ExecuteBusiness(new AtualizarPeriodosBL(), request);
        }

        public Contracts.AtualizarProfessores.AtualizarProfessoresResponse AtualizarProfessores(Contracts.AtualizarProfessores.AtualizarProfessoresRequest request)
        {
            return this.ExecuteBusiness(new AtualizarProfessoresBL(), request);
        }

        public Contracts.AtualizarSemestres.AtualizarSemestresResponse AtualizarSemestres(Contracts.AtualizarSemestres.AtualizarSemestresRequest request)
        {
            return this.ExecuteBusiness(new AtualizarSemestresBL(), request);
        }

        public Contracts.AtualizarUsuarios.AtualizarUsuariosResponse AtualizarUsuarios(Contracts.AtualizarUsuarios.AtualizarUsuariosRequest request)
        {
            return this.ExecuteBusiness(new AtualizarUsuariosBL(), request);
        }

        public Contracts.DeletarComposicaoCurso.DeletarComposicaoCursoResponse DeletarComposicaoCurso(Contracts.DeletarComposicaoCurso.DeletarComposicaoCursoRequest request)
        {
            return this.ExecuteBusiness(new DeletarComposicaoCursoBL(), request);
        }

        public Contracts.DeletarComposicoesHorario.DeletarComposicoesHorarioResponse DeletarComposicoesHorario(Contracts.DeletarComposicoesHorario.DeletarComposicoesHorarioRequest request)
        {
            return this.ExecuteBusiness(new DeletarComposicoesHorarioBL(), request);
        }

        public Contracts.DeletarCursos.DeletarCursosResponse DeletarCursos(Contracts.DeletarCursos.DeletarCursosRequest request)
        {
            return this.ExecuteBusiness(new DeletarCursosBL(), request);
        }

        public Contracts.DeletarHorarios.DeletarHorariosResponse DeletarHorarios(Contracts.DeletarHorarios.DeletarHorariosRequest request)
        {
            return this.ExecuteBusiness(new DeletarHorariosBL(), request);
        }

        public Contracts.DeletarMaterias.DeletarMateriasResponse DeletarMaterias(Contracts.DeletarMaterias.DeletarMateriasRequest request)
        {
            return this.ExecuteBusiness(new DeletarMateriasBL(), request);
        }

        public Contracts.DeletarNiveisAcesso.DeletarNiveisAcessoResponse DeletarNiveisAcesso(Contracts.DeletarNiveisAcesso.DeletarNiveisAcessoRequest request)
        {
            return this.ExecuteBusiness(new DeletarNiveisAcessoBL(), request);
        }

        public Contracts.DeletarPeriodos.DeletarPeriodosResponse DeletarPeriodos(Contracts.DeletarPeriodos.DeletarPeriodosRequest request)
        {
            return this.ExecuteBusiness(new DeletarPeriodosBL(), request);
        }

        public Contracts.DeletarProfessores.DeletarProfessoresResponse DeletarProfessores(Contracts.DeletarProfessores.DeletarProfessoresRequest request)
        {
            return this.ExecuteBusiness(new DeletarProfessoresBL(), request);
        }

        public Contracts.DeletarSemestres.DeletarSemestresResponse DeletarSemestres(Contracts.DeletarSemestres.DeletarSemestresRequest request)
        {
            return this.ExecuteBusiness(new DeletarSemestresBL(), request);
        }

        public Contracts.DeletarUsuarios.DeletarUsuariosResponse DeletarUsuarios(Contracts.DeletarUsuarios.DeletarUsuariosRequest request)
        {
            return this.ExecuteBusiness(new DeletarUsuariosBL(), request);
        }

        public Contracts.ConsultarProfessorParam.ConsultarProfessorParamResponse ConsultarProfessorParam(Contracts.ConsultarProfessorParam.ConsultarProfessorParamRequest request)
        {
            return this.ExecuteBusiness(new ConsultarProfessorParamBL(), request);
        }

        public Contracts.ConsultarCursoParam.ConsultarCursoParamResponse ConsultarCursoParam(Contracts.ConsultarCursoParam.ConsultarCursoParamRequest request)
        {
            return this.ExecuteBusiness(new ConsultarCursoParamBL(), request);
        }

        public Contracts.ConsultarPeriodoParam.ConsultarPeriodoParamResponse ConsultarPeriodoParam(Contracts.ConsultarPeriodoParam.ConsultarPeriodoParamRequest request)
        {
            return this.ExecuteBusiness(new ConsultarPeriodoParamBL(), request);
        }

        public Contracts.ConsultarHorarioParam.ConsultarHorarioParamResponse ConsultarHorarioParam(Contracts.ConsultarHorarioParam.ConsultarHorarioParamRequest request)
        {
            return this.ExecuteBusiness(new ConsultarHorarioParamBL(), request);
        }

        public Contracts.ConsultarMateriaParam.ConsultarMateriaParamResponse ConsultarMateriaParam(Contracts.ConsultarMateriaParam.ConsultarMateriaParamRequest request)
        {
            return this.ExecuteBusiness(new ConsultarMateriaParamBL(), request);
        }

        public Contracts.ConsultarDiaSemanaParam.ConsultarDiaSemanaParamResponse ConsultarDiaSemanaParam(Contracts.ConsultarDiaSemanaParam.ConsultarDiaSemanaParamRequest request)
        {
            return this.ExecuteBusiness(new ConsultarDiaSemanaParamBL(), request);
        }

        public Contracts.ConsultarNivelAcessoParam.ConsultarNivelAcessoParamResponse ConsultarNivelAcessoParam(Contracts.ConsultarNivelAcessoParam.ConsultarNivelAcessoParamRequest request)
        {
            return this.ExecuteBusiness(new ConsultarNivelAcessoParamBL(), request);
        }

        public Contracts.ConsultarNiveisAcesso.ConsultarNiveisAcessoResponse ConsultarNiveisAcesso(Contracts.ConsultarNiveisAcesso.ConsultarNiveisAcessoRequest request)
        {
            return this.ExecuteBusiness(new ConsultarNiveisAcessoBL(), request);
        }

        public Contracts.ConsultarDiasPeriodos.ConsultarDiasPeriodosResponse ConsultarDiasPeriodos(Contracts.ConsultarDiasPeriodos.ConsultarDiasPeriodosRequest request)
        {
            return this.ExecuteBusiness(new ConsultarDiasPeriodosBL(), request);
        }

        public Contracts.ConsultarDiasHorarios.ConsultarDiasHorariosResponse ConsultarDiasHorarios(Contracts.ConsultarDiasHorarios.ConsultarDiasHorariosRequest request)
        {
            return this.ExecuteBusiness(new ConsultarDiasHorariosBL(), request);
        }

        public Contracts.ConsultarUsuariosParam.ConsultarUsuariosParamResponse ConsultarUsuariosParam(Contracts.ConsultarUsuariosParam.ConsultarUsuariosParamRequest request)
        {
            return this.ExecuteBusiness(new ConsultarUsuariosParamBL(), request);
        }

        public Contracts.ConsultarUsuariosNiveis.ConsultarUsuariosNiveisResponse ConsultarUsuariosNiveis(Contracts.ConsultarUsuariosNiveis.ConsultarUsuariosNiveisRequest request)
        {
            return this.ExecuteBusiness(new ConsultarUsuariosNiveisBL(), request);
        }

        public Contracts.AutenticarUsuario.AutenticarUsuarioResponse AutenticarUsuario(Contracts.AutenticarUsuario.AutenticarUsuarioRequest request)
        {
            return this.ExecuteBusiness(new AutenticarUsuarioBL(), request);
        }

        public Contracts.ConsultarGrade.ConsultarGradeResponse ConsultarGrade(Contracts.ConsultarGrade.ConsultarGradeRequest request)
        {
            return this.ExecuteBusiness(new ConsultarGradeBL(), request);
        }

        public Contracts.ConsultarPeriodosPorCurso.ConsultarPeriodosPorCursoResponse ConsultarPeriodosPorCurso(Contracts.ConsultarPeriodosPorCurso.ConsultarPeriodosPorCursoRequest request)
        {
            return this.ExecuteBusiness(new ConsultarPeriodosPorCursoBL(), request);
        }

        public Contracts.ConsultarCursosSemestres.ConsultarCursosSemestresResponse ConsultarCursosSemestres(Contracts.ConsultarCursosSemestres.ConsultarCursosSemestresRequest request)
        {
            return this.ExecuteBusiness(new ConsultarCursosSemestresBL(), request);
        }

        public Contracts.ConsultarCursosPeriodosSemestres.ConsultarCursosPeriodosSemestresResponse ConsultarCursosPeriodosSemestres(Contracts.ConsultarCursosPeriodosSemestres.ConsultarCursosPeriodosSemestresRequest request)
        {
            return this.ExecuteBusiness(new ConsultarCursosPeriodosSemestresBL(), request);
        }

        public Contracts.ConsultarParametrosCadastroGrade.ConsultarParametrosCadastroGradeResponse ConsultarParametrosCadastroGrade(Contracts.ConsultarParametrosCadastroGrade.ConsultarParametrosCadastroGradeRequest request)
        {
            return this.ExecuteBusiness(new ConsultarParametrosCadastroGradeBL(), request);
        }

        public Contracts.CadastrarGrade.CadastrarGradeResponse CadastrarGrade(Contracts.CadastrarGrade.CadastrarGradeRequest request)
        {
            return this.ExecuteBusiness(new CadastrarGradeBL(), request);
        }
    }
}
