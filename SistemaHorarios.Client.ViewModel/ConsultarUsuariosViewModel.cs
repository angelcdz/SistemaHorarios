using System.Collections.Generic;
using System.ComponentModel;
using SistemaHorarios.Client.Model;
using SistemaHorarios.Base;
using SistemaHorarios.Contracts.ConsultarUsuarios;
using SistemaHorarios.Contracts.ConsultarUsuariosParam;
using System.Threading.Tasks;
using System.Windows.Input;
using System.Windows.Controls;
using System.Windows.Forms;
using SistemaHorarios.Contracts.ConsultarUsuariosNiveis;
using SistemaHorarios.Contracts.ConsultarNiveisAcesso;

namespace SistemaHorarios.Client.ViewModel
{
    public class ConsultarUsuariosViewModel : INotifyPropertyChanged
    {
        public ConsultarUsuariosViewModel()
        {
            new Task(() =>
            {
                Status = "Consultando...";
                var model = new ConsultarUsuariosNiveisModel();
                model.Execute(new ConsultarUsuariosNiveisRequest());

                if (model.Response.Status == ExecutionStatus.Success)
                {
                    Lista = model.Response.Usuarios;
                    ListaNiveis = model.Response.Niveis;
                    ListaNiveis.Add(new ConsultarNiveisAcessoDTO() { Codigo = 0, Nome = "<Nenhum>" });
                }
                else System.Windows.Forms.MessageBox.Show(string.Concat("Erro ao consultar professores:\n",model.Response.ErrorMessage));

                Status = string.Empty;
            }).Start();

            this.ActionCommand = new RelayCommand();
        }

        private List<ConsultarUsuariosUsuarioDTO> _lista;
        public List<ConsultarUsuariosUsuarioDTO> Lista
        {
            get { return this._lista; }
            set { this._lista = value; OnPropertyChanged("Lista"); }
        }

        private List<ConsultarNiveisAcessoDTO> _listaNiveis;
        public List<ConsultarNiveisAcessoDTO> ListaNiveis
        {
            get { return this._listaNiveis; }
            set { this._listaNiveis = value; OnPropertyChanged("ListaNiveis"); }
        }
        
        private string _status;
        public string Status
        {
            get { return this._status; }
            set { this._status = value; OnPropertyChanged("Status"); }
        }

        private RelayCommand _actionCommand;
        public RelayCommand ActionCommand
        {
            get { return _actionCommand; }
            set
            {
                this._actionCommand = new RelayCommand(obj => true, Executar);
            }

        }
        public void Executar(object obj)
        {
            var param = (object[])obj;

            int cod = 0;
            if (!string.IsNullOrEmpty((string)param[0]) && !int.TryParse((string)param[0], out cod))
            {
                MessageBox.Show("Insira um número no campo de código.");
                return;
            }

            var nome = (string)param[1];
            var nivel = param[2] as ConsultarNiveisAcessoDTO;
            if (nivel == null)
            {
                MessageBox.Show("Selecione um nível de acesso.");
                return;
            }

            new Task(() =>
            {
                Status = "Consultando...";
                var model = new ConsultarUsuariosParamModel();
                var request = new ConsultarUsuariosParamRequest()
                {
                    Codigo = cod,
                    CodigoNivel = nivel.Codigo,
                    Login = nome
                };
                model.Execute(request);

                if (model.Response.Status == ExecutionStatus.Success) this.Lista = model.Response.Usuarios;
                else System.Windows.Forms.MessageBox.Show("Erro ao consultar professores:\n" + model.Response.ErrorMessage);

                Status = string.Empty;
            }).Start();
        }

        public event PropertyChangedEventHandler PropertyChanged;
        protected virtual void OnPropertyChanged(string propertyName)
        {
            PropertyChangedEventHandler handler = PropertyChanged;
            if (handler != null) handler(this, new PropertyChangedEventArgs(propertyName));
        }
    }
}
