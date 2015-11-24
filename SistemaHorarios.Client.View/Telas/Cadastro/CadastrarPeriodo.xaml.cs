using SistemaHorarios.Client.ViewModel;
using System.Windows.Controls;

namespace SistemaHorarios.Client.View.Telas
{
    /// <summary>
    /// Interaction logic for CadastrarPeriodo.xaml
    /// </summary>
    public partial class CadastrarPeriodo : UserControl
    {
        public CadastrarPeriodo()
        {
            this.DataContext = new CadastrarPeriodoViewModel();
            InitializeComponent();
        }
    }
}
