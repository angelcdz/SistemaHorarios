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
    public class PrincipalViewModel : INotifyPropertyChanged
    {
        public PrincipalViewModel()
        {
            if (Usuario.NivelAcessoLogado != null)
            {
                ShowConsultas = Usuario.NivelAcessoLogado.Consulta;
                ShowOperacoes = Usuario.NivelAcessoLogado.Cadastro;
                ShowAdmin = Usuario.NivelAcessoLogado.Administrador;
            }
            ActionFechar = new RelayCommand();
            ActionClose = new RelayCommand();
        }

        private bool _showConsultas;
        public bool ShowConsultas
        {
            get { return this._showConsultas; }
            set { this._showConsultas = value; OnPropertyChanged("ShowConsultas"); }
        }

        private bool _showOperacoes;
        public bool ShowOperacoes
        {
            get { return this._showOperacoes; }
            set { this._showOperacoes = value; OnPropertyChanged("ShowOperacoes"); }
        }

        private bool _showAdmin;
        public bool ShowAdmin
        {
            get { return this._showAdmin; }
            set { this._showAdmin = value; OnPropertyChanged("ShowAdmin"); }
        }

        #region Commands

        //private RelayCommand _actionSair;
        //public RelayCommand ActionSair
        //{
        //    get { return this._actionSair; }
        //    set
        //    {
        //        this._actionSair = new RelayCommand(obj => true, ExecutarSair);
        //    }

        //}
        //public void ExecutarSair(object obj)
        //{
        //    ShowWindow = Visibility.Hidden;
        //}

        private RelayCommand _actionFechar;
        public RelayCommand ActionFechar
        {
            get { return this._actionFechar; }
            set
            {
                this._actionFechar = new RelayCommand(obj => true, ExecutarFechar);
            }

        }
        public void ExecutarFechar(object obj)
        {
            Environment.Exit(0);
        }

        private RelayCommand _actionClose;
        public RelayCommand ActionClose
        {
            get { return this._actionClose; }
            set
            {
                this._actionClose = new RelayCommand(obj => true, ExecutarClose);
            }

        }
        public void ExecutarClose(object obj)
        {
            Environment.Exit(0);
        }

        public event PropertyChangedEventHandler PropertyChanged;
        protected virtual void OnPropertyChanged(string propertyName)
        {
            PropertyChangedEventHandler handler = PropertyChanged;
            if (handler != null) handler(this, new PropertyChangedEventArgs(propertyName));
        } 

        #endregion
    }
}
