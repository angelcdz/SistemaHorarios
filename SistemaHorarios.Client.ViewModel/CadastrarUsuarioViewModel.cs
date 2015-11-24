using System.ComponentModel;
using System.Windows.Forms;
using SistemaHorarios.Client.Model;
using SistemaHorarios.Contracts.CadastrarNiveisAcesso;
using SistemaHorarios.Base;
using System.Threading.Tasks;
using System.Collections.Generic;
using SistemaHorarios.Contracts.ConsultarNiveisAcesso;
using System.Windows.Controls;
using SistemaHorarios.Contracts.CadastrarUsuarios;

namespace SistemaHorarios.Client.ViewModel
{
    public class CadastrarUsuarioViewModel : INotifyPropertyChanged
    {
        public CadastrarUsuarioViewModel()
        {
            CriarEnabled = true;
            CancelarEnabled = true;
            ActionCommandCriar = new RelayCommand();
            ActionCommandCancelar = new RelayCommand();

            new Task(() =>
            {
                Status = "Consultando níveis de acesso...";
                var model = new ConsultarNiveisAcessoModel();
                model.Execute(new ConsultarNiveisAcessoRequest());

                if (model.Response.Status == ExecutionStatus.Success) Lista = model.Response.Niveis;
                else MessageBox.Show(string.Concat("Erro ao consultar os períodos:\n", model.Response.ErrorMessage));

                Status = string.Empty;
            }).Start();
        }

        private bool _criarEnabled;
        public bool CriarEnabled
        {
            get { return this._criarEnabled; }
            set { this._criarEnabled = value; OnPropertyChanged("CriarEnabled"); }
        }

        private bool _cancelarEnabled;
        public bool CancelarEnabled
        {
            get { return this._cancelarEnabled; }
            set { this._cancelarEnabled = value; OnPropertyChanged("CancelarEnabled"); }
        }

        private List<ConsultarNiveisAcessoDTO> _lista;
        public List<ConsultarNiveisAcessoDTO> Lista
        {
            get { return this._lista; }
            set { this._lista = value; OnPropertyChanged("Lista"); }
        }

        private string _text;
        public string Text
        {
            get { return this._text; }
            set { this._text = value; OnPropertyChanged("Text"); }
        }

        private string _status;
        public string Status
        {
            get { return this._status; }
            set { this._status = value; OnPropertyChanged("Status"); }
        }

        private RelayCommand _actionCommandCriar;
        public RelayCommand ActionCommandCriar
        {
            get { return _actionCommandCriar; }
            set
            {
                this._actionCommandCriar = new RelayCommand(obj => true, ExecutarCriar);
            }

        }
        public void ExecutarCriar(object obj)
        {
            var login = (string)((object[])obj)[0];
            if (string.IsNullOrEmpty(login))
            {
                MessageBox.Show("Insira um login para o novo usuário.");
                return;
            }

            var pass = ((object[])obj)[1] as PasswordBox;
            if (string.IsNullOrEmpty(pass.Password))
            {
                MessageBox.Show("Insira uma senha para o novo usuário.");
                return;
            }

            var nivel = ((object[])obj)[2] as ConsultarNiveisAcessoDTO;
            if (nivel == null)
            {
                MessageBox.Show("Selecione um nível de acesso.");
                return;
            }

            new Task(() =>
            {
                CriarEnabled = false;
                CancelarEnabled = false;
                Status = "Criando...";

                var model = new CadastrarUsuariosModel();
                model.Execute(new CadastrarUsuariosRequest()
                {
                    CodigoNivelAcesso = nivel.Codigo,
                    Login = login,
                    Senha = pass.Password
                });

                if (model.Response.Status == ExecutionStatus.Success) MessageBox.Show("Usuário criado com sucesso!");
                else MessageBox.Show(string.Concat("Erro ao criar o usuário:\n", model.Response.ErrorMessage));

                CriarEnabled = true;
                CancelarEnabled = true;
                Status = string.Empty;
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
            Text = string.Empty;
        }

        public event PropertyChangedEventHandler PropertyChanged;
        protected virtual void OnPropertyChanged(string propertyName)
        {
            PropertyChangedEventHandler handler = PropertyChanged;
            if (handler != null) handler(this, new PropertyChangedEventArgs(propertyName));
        }
    }
}
