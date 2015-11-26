using SistemaHorarios.Client.ViewModel;
using System.Windows.Controls;

namespace SistemaHorarios.Client.View.Telas
{
    /// <summary>
    /// Interaction logic for ConsultaGrade.xaml
    /// </summary>
    public partial class ConsultarGrade : UserControl
    {
        public ConsultarGrade()
        {
            this.DataContext = new ConsultarGradeViewModel();
            InitializeComponent();
        }
    }
}
