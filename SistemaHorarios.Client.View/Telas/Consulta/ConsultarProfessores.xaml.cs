using SistemaHorarios.Client.ViewModel;
using System.Windows.Controls;

namespace SistemaHorarios.Client.View.Telas
{
    /// <summary>
    /// Interaction logic for ConsultarProfessores.xaml
    /// </summary>
    public partial class ConsultarProfessores : UserControl
    {
        public ConsultarProfessores()
        {
            this.DataContext = new ConsultarProfessoresViewModel();
            InitializeComponent();
        }
    }
}
