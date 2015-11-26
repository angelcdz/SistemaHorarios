using SistemaHorarios.Client.ViewModel;
using System.Windows.Controls;
using SistemaHorarios.Client.View.Telas;
using System.Collections.Generic;

namespace SistemaHorarios.Client.View
{
    /// <summary>
    /// Interaction logic for SeletorConsultas.xaml
    /// </summary>
    public partial class SeletorUsuarios : UserControl
    {
        public SeletorUsuarios()
        {
            this.DataContext = new SeletorUsuariosViewModel();
            InitializeComponent();
        }

        private void Combo_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            var choice = (KeyValuePair<string,OperacoesUsuario>)Combo.SelectedItem;
            Lista.Children.Clear();

            switch (choice.Value)
            {
                case OperacoesUsuario.Consultar:
                    Lista.Children.Add(new ConsultarUsuarios());
                    break;
                case OperacoesUsuario.Alterar:
                    Lista.Children.Add(new AlterarUsuarios());
                    break;
                case OperacoesUsuario.Cadastrar:
                    Lista.Children.Add(new CadastrarUsuario());
                    break;
                default:
                    break;
            }
        }
    }
}
