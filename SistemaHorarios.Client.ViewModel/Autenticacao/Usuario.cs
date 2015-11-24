namespace SistemaHorarios.Client.ViewModel.Autenticacao
{
    public class Usuario
    {
        public static NivelAcesso NivelAcessoLogado { get; set; }

        public class NivelAcesso
        {
            public string Nome { get; set; }
            public bool Administrador { get; set; }
            public bool Cadastro { get; set; }
            public bool Consulta { get; set; }
        }
    }
}
