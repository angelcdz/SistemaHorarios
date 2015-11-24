using SistemaHorarios.Client.ViewModel;
using System.Windows.Controls;

namespace SistemaHorarios.Client.View.Telas
{
    /// <summary>
    /// Interaction logic for ConsultarCursos.xaml
    /// </summary>
    public partial class ConsultarCursos : UserControl
    {
        public ConsultarCursos()
        {
            this.DataContext = new ConsultarCursosViewModel();
            InitializeComponent();
        }
    }
}
