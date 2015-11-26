using SistemaHorarios.Client.ViewModel;
using System.Windows.Controls;
using SistemaHorarios.Client.View.Telas;
using System.Collections.Generic;

namespace SistemaHorarios.Client.View
{
    /// <summary>
    /// Interaction logic for SeletorConsultas.xaml
    /// </summary>
    public partial class SeletorNiveis : UserControl
    {
        public SeletorNiveis()
        {
            this.DataContext = new SeletorNiveisViewModel();
            InitializeComponent();
        }

        private void Combo_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            var choice = (KeyValuePair<string,OperacoesNivel>)Combo.SelectedItem;
            Lista.Children.Clear();

            switch (choice.Value)
            {
                case OperacoesNivel.Consultar:
                    Lista.Children.Add(new ConsultarNiveisAcesso());
                    break;
                case OperacoesNivel.Alterar:
                    Lista.Children.Add(new AlterarNiveisAcesso());
                    break;
                case OperacoesNivel.Cadastrar:
                    Lista.Children.Add(new CadastrarNiveisAcesso());
                    break;
                default:
                    break;
            }
        }
    }
}
