//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace SistemaHorarios.Server.DAO
{
    using System;
    using System.Collections.Generic;
    
    public partial class ComposicaoCurso
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public ComposicaoCurso()
        {
            this.ComposicoesHorario = new HashSet<ComposicaoHorario>();
        }
    
        public int CodigoComposicaoCurso { get; set; }
    
        public virtual Curso Curso { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<ComposicaoHorario> ComposicoesHorario { get; set; }
        public virtual Materia Materia { get; set; }
        public virtual Professor Professor { get; set; }
        public virtual Semestre Semestre { get; set; }
    }
}