using SistemaHorarios.Client.ViewModel;
using System.Windows.Controls;

namespace SistemaHorarios.Client.View.Telas
{
    /// <summary>
    /// Interaction logic for CadastrarHorario.xaml
    /// </summary>
    public partial class CadastrarHorario : UserControl
    {
        public CadastrarHorario()
        {
            this.DataContext = new CadastrarHorarioViewModel();
            InitializeComponent();
        }
    }
}
