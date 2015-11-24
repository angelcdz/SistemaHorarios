using SistemaHorarios.Client.ViewModel;
using System.Windows.Controls;

namespace SistemaHorarios.Client.View.Telas
{
    /// <summary>
    /// Interaction logic for ConsultarPeriodos.xaml
    /// </summary>
    public partial class ConsultarPeriodos : UserControl
    {
        public ConsultarPeriodos()
        {
            this.DataContext = new ConsultarPeriodosViewModel();
            InitializeComponent();
        }
    }
}
