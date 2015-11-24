using System;
using System.ComponentModel;
using SistemaHorarios.Contracts.AutenticarUsuario;
using System.Windows.Controls;
using System.Windows;
using System.Threading.Tasks;
using SistemaHorarios.Client.Model;
using SistemaHorarios.Client.ViewModel.Autenticacao;

namespace SistemaHorarios.Client.ViewModel
{
    public class LoginViewModel : INotifyPropertyChanged
    {
        public LoginViewModel()
        {
            LoginEnabled = true;
            ActionCommandLogin = new RelayCommand();
            ActionCommandCancelar = new RelayCommand();
        }

        private bool _loginEnabled;
        public bool LoginEnabled
        {
            get { return this._loginEnabled; }
            set { this._loginEnabled = value; OnPropertyChanged("LoginEnabled"); }
        }

        private string _status;
        public string Status
        {
            get { return this._status; }
            set { this._status = value; OnPropertyChanged("Status"); }
        }

        private string _flag;
        public string Flag
        {
            get { return this._flag; }
            set { this._flag = value; OnPropertyChanged("Flag"); }
        }

        private RelayCommand _actionCommandLogin;
        public RelayCommand ActionCommandLogin
        {
            get { return _actionCommandLogin; }
            set
            {
                this._actionCommandLogin = new RelayCommand(obj => true, ExecutarLogin);
            }

        }
        public void ExecutarLogin(object obj)
        {
            var login = (string)((object[])obj)[0];
            if (string.IsNullOrEmpty(login))
            {
                MessageBox.Show("Insira um nome de login.");
                return;
            }

            var pass = ((object[])obj)[1] as PasswordBox;
            if (string.IsNullOrEmpty(pass.Password))
            {
                MessageBox.Show("Insira uma senha.");
                return;
            }

            new Task(() =>
            {
                LoginEnabled = false;
                Status = "Autenticando...";

                var model = new AutenticarUsuarioModel();
                model.Execute(new AutenticarUsuarioRequest()
                {
                    Login = login, Senha = pass.Password
                });

                if (model.Response.Status != Base.ExecutionStatus.Success)
                    MessageBox.Show(string.Concat("Erro ao autenticar:\n", model.Response.ErrorMessage));
                else if (!model.Response.Existe)
                    MessageBox.Show(string.Concat("Usuário não existe."));
                else if (!model.Response.Autenticado)
                    MessageBox.Show(string.Concat("Usuário e/ou senha inválidos."));
                else
                {
                    Flag = string.Concat(Flag,"x");
                    Usuario.NivelAcessoLogado = new Usuario.NivelAcesso()
                    {
                        Administrador = model.Response.NivelAcesso.Administrador,
                        Cadastro = model.Response.NivelAcesso.Cadastro,
                        Consulta = model.Response.NivelAcesso.Consulta,
                        Nome = model.Response.NivelAcesso.Nome
                    };
                }

                Status = string.Empty;
                LoginEnabled = true;
            }).Start();
        }

        private RelayCommand _actionCommandCancelar;
        public RelayCommand ActionCommandCancelar
        {
            get { return _actionCommandCancelar; }
            set
            {
                this._actionCommandCancelar = new RelayCommand(obj => true, ExecutarCancelar);
            }

        }
        public void ExecutarCancelar(object obj)
        {
            Environment.Exit(0);
        }

        public event PropertyChangedEventHandler PropertyChanged;
        protected virtual void OnPropertyChanged(string propertyName)
        {
            PropertyChangedEventHandler handler = PropertyChanged;
            if (handler != null) handler(this, new PropertyChangedEventArgs(propertyName));
        }
    }
}
