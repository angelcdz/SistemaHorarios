using System.ComponentModel;
using System.Windows.Forms;
using SistemaHorarios.Client.Model;
using SistemaHorarios.Contracts.CadastrarHorarios;
using SistemaHorarios.Contracts.ConsultarDiasPeriodos;
using SistemaHorarios.Contracts.ConsultarDiasSemana;
using SistemaHorarios.Contracts.ConsultarPeriodos;
using SistemaHorarios.Base;
using System.Threading.Tasks;
using System.Collections.Generic;
using System;

namespace SistemaHorarios.Client.ViewModel
{
    public class CadastrarHorarioViewModel : INotifyPropertyChanged
    {
        public CadastrarHorarioViewModel()
        {
            CriarEnabled = true;
            CancelarEnabled = true;
            ActionCommandCriar = new RelayCommand();
            ActionCommandCancelar = new RelayCommand();

            new Task(() =>
            {
                Status = "Consultando dias da semana...";
                var model = new ConsultarDiasPeriodosModel();
                model.Execute(new ConsultarDiasPeriodosRequest());

                if (model.Response.Status == ExecutionStatus.Success)
                {
                    ListaDia = model.Response.Dias;
                    ListaPeriodo = model.Response.Periodos; 
                }
                else MessageBox.Show(string.Concat("Erro ao consultar dias da semana:\n", model.Response.ErrorMessage));

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

        private string _textInicial;
        public string TextInicial
        {
            get { return this._textInicial; }
            set { this._textInicial = value; OnPropertyChanged("TextInicial"); }
        }

        private string _textFinal;
        public string TextFinal
        {
            get { return this._textFinal; }
            set { this._textFinal = value; OnPropertyChanged("TextFinal"); }
        }

        private string _status;
        public string Status
        {
            get { return this._status; }
            set { this._status = value; OnPropertyChanged("Status"); }
        }

        private List<ConsultarDiasSemanaDiaDTO> _listaDia;
        public List<ConsultarDiasSemanaDiaDTO> ListaDia
        {
            get { return this._listaDia; }
            set { this._listaDia = value; OnPropertyChanged("ListaDia"); }
        }

        private List<ConsultarPeriodosPeriodoDTO> _listaPeriodo;
        public List<ConsultarPeriodosPeriodoDTO> ListaPeriodo
        {
            get { return this._listaPeriodo; }
            set { this._listaPeriodo = value; OnPropertyChanged("ListaPeriodo"); }
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
            TimeSpan inicial = TimeSpan.Zero, final = TimeSpan.Zero;

            if (!TimeSpan.TryParse(TextInicial, out inicial)
                || !TimeSpan.TryParse(TextFinal, out final))
            {
                MessageBox.Show("Digite somente numeros para os horários e no seguinte formato:\nXX:XX:XX.");
                return;
            }
            
            var dia = ((object[])obj)[2] as ConsultarDiasSemanaDiaDTO;
            if (dia == null)
            {
                MessageBox.Show("Selecione um dia da semana.");
                return;
            }
            var periodo = ((object[])obj)[3] as ConsultarPeriodosPeriodoDTO;
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

                var model = new CadastrarHorariosModel();
                model.Execute(new CadastrarHorariosRequest()
                {
                    CodigoDiaSemana = dia.CodigoDia,
                    CodigoPeriodo = periodo.Codigo,
                    HoraFinal = final,
                    HoraInicial = inicial
                });

                if (model.Response.Status == ExecutionStatus.Success) MessageBox.Show("Horário criado com sucesso!");
                else MessageBox.Show(string.Concat("Erro ao criar o curso:\n", model.Response.ErrorMessage));

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
            TextInicial = string.Empty;
            TextFinal = string.Empty;
        }

        public event PropertyChangedEventHandler PropertyChanged;
        protected virtual void OnPropertyChanged(string propertyName)
        {
            PropertyChangedEventHandler handler = PropertyChanged;
            if (handler != null) handler(this, new PropertyChangedEventArgs(propertyName));
        }
    }
}
