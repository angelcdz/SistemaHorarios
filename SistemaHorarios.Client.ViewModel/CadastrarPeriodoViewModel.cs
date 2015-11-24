using System.ComponentModel;
using System.Windows.Forms;
using SistemaHorarios.Client.Model;
using SistemaHorarios.Contracts.CadastrarPeriodos;
using SistemaHorarios.Base;
using System.Threading.Tasks;

namespace SistemaHorarios.Client.ViewModel
{
    public class CadastrarPeriodoViewModel : INotifyPropertyChanged
    {
        public CadastrarPeriodoViewModel()
        {
            CriarEnabled = true;
            CancelarEnabled = true;
            ActionCommandCriar = new RelayCommand();
            ActionCommandCancelar = new RelayCommand();
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
            var text = (string)obj;
            if (string.IsNullOrEmpty(text))
            {
                MessageBox.Show("Insira um nome para o novo período.");
                return;
            }

            var task = new Task(() =>
            {
                CriarEnabled = false;
                CancelarEnabled = false;
                Status = "Criando...";

                var model = new CadastrarPeriodosModel();
                model.Execute(new CadastrarPeriodosRequest()
                {
                    Nome = text
                });

                if (model.Response.Status == ExecutionStatus.Success) MessageBox.Show("Período criado com sucesso!");
                else MessageBox.Show(string.Concat("Erro ao criar o período:\n", model.Response.ErrorMessage));

                CriarEnabled = true;
                CancelarEnabled = true;
                Status = "";
            });

            task.Start();
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
