//------------------------------------------------------------------------------
// <auto-generated>
//     Este código se generó a partir de una plantilla.
//
//     Los cambios manuales en este archivo pueden causar un comportamiento inesperado de la aplicación.
//     Los cambios manuales en este archivo se sobrescribirán si se regenera el código.
// </auto-generated>
//------------------------------------------------------------------------------

namespace ProyectoUMGAhorcado
{
    using System;
    using System.Collections.Generic;
    
    public partial class TBL_DIFICULTAD
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public TBL_DIFICULTAD()
        {
            this.TBL_PALABRA = new HashSet<TBL_PALABRA>();
        }
    
        public int IDDIFICULTAD { get; set; }
        public string NOMBREDIFICULTAD { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<TBL_PALABRA> TBL_PALABRA { get; set; }
    }
}