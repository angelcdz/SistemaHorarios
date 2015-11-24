using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;
using SistemaHorarios.Client.ViewModel;

namespace SistemaHorarios.Client.View.Telas
{
    /// <summary>
    /// Interaction logic for ConsultarMaterias.xaml
    /// </summary>
    public partial class ConsultarMaterias : UserControl
    {
        public ConsultarMaterias()
        {
            this.DataContext = new ConsultarMateriasViewModel();
            InitializeComponent();
        }
    }
}
