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
            if (Context.NivelAcessoLogado != null)
            {
                ShowConsultas = Context.NivelAcessoLogado.Consulta;
                ShowOperacoes = Context.NivelAcessoLogado.Cadastro;
                ShowAdmin = Context.NivelAcessoLogado.Administrador;
            }
            ActionFechar = new RelayCommand();
            ActionClose = new RelayCommand();
        }

        #region Atribs

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

        private bool _showConsultasTab;
        public bool ShowConsultasTab
        {
            get { return this._showConsultasTab; }
            set { this._showConsultasTab = value; OnPropertyChanged("ShowConsultasTab"); }
        }

        private bool _showCadastrosTab;
        public bool ShowCadastrosTab
        {
            get { return this._showCadastrosTab; }
            set { this._showCadastrosTab = value; OnPropertyChanged("ShowCadastrosTab"); }
        }

        private bool _showAlteracoesTab;
        public bool ShowAlteracoesTab
        {
            get { return this._showAlteracoesTab; }
            set { this._showAlteracoesTab = value; OnPropertyChanged("ShowAlteracoesTab"); }
        }

        #endregion

        #region Commands

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
