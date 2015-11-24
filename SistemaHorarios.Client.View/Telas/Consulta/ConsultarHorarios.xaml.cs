using SistemaHorarios.Client.ViewModel;
using System.Windows.Controls;

namespace SistemaHorarios.Client.View.Telas
{
    /// <summary>
    /// Interaction logic for ConsultarHorarios.xaml
    /// </summary>
    public partial class ConsultarHorarios : UserControl
    {
        public ConsultarHorarios()
        {
            this.DataContext = new ConsultarHorariosViewModel();
            InitializeComponent();
        }
    }
}
