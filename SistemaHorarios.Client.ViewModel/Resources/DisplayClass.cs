using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SistemaHorarios.Client.ViewModel.Resources
{
    public class DisplayHorario
    {
        public string DisplayName { get; set; }
        public int CodHorario { get; set; }
    }
    public class DisplayCurso
    {
        public string DisplayName { get; set; }
        public int CodCurso { get; set; }
        public int CodPeriodo { get; set; }
    }
}
