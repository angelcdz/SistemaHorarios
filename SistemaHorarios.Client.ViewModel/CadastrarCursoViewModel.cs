using System.ComponentModel;
using System.Windows.Forms;
using SistemaHorarios.Client.Model;
using SistemaHorarios.Contracts.CadastrarNiveisAcesso;
using SistemaHorarios.Contracts.ConsultarPeriodos;
using SistemaHorarios.Contracts.CadastrarCursos;
using SistemaHorarios.Base;
using System.Threading.Tasks;
using System.Collections.Generic;

namespace SistemaHorarios.Client.ViewModel
{
    public class CadastrarCursoViewModel : INotifyPropertyChanged
    {
        public CadastrarCursoViewModel()
        {
            CriarEnabled = true;
            CancelarEnabled = true;
            ActionCommandCriar = new RelayCommand();
            ActionCommandCancelar = new RelayCommand();

            new Task(() =>
            {
                Status = "Consultando Períodos...";
                var model = new ConsultarPeriodosModel();
                model.Execute(new ConsultarPeriodosRequest());

                if (model.Response.Status == ExecutionStatus.Success) Lista = model.Response.Periodos;
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

        private List<ConsultarPeriodosPeriodoDTO> _lista;
        public List<ConsultarPeriodosPeriodoDTO> Lista
        {
            get { return this._lista; }
            set { this._lista = value; OnPropertyChanged("Lista"); }
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
            var text = (string)((object[])obj)[0];
            if (string.IsNullOrEmpty(text))
            {
                MessageBox.Show("Insira um nome para o novo curso.");
                return;
            }

            var periodo = ((object[])obj)[1] as ConsultarPeriodosPeriodoDTO;
            if (periodo == null)
            {
                MessageBox.Show("Selecione um período.");
                return;
            }

            new Task(() =>
            {
                CriarEnabled = false;
                CancelarEnabled = false;
                Status = "Criando...";

                var model = new CadastrarCursosModel();
                model.Execute(new CadastrarCursosRequest()
                {
                    CodigoPerido = periodo.Codigo,
                    Nome = text
                });

                if (model.Response.Status == ExecutionStatus.Success) MessageBox.Show("Curso criado com sucesso!");
                else MessageBox.Show(string.Concat("Erro ao criar o curso:\n", model.Response.ErrorMessage));

                CriarEnabled = true;
                CancelarEnabled = true;
                Status = "";
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
