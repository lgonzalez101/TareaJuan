//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Tarea1_CRUD
{
    using System;
    using System.Collections.Generic;
    
    public partial class Empleado
    {
        public int Id { get; set; }
        public string Nombre { get; set; }
        public string Apellido { get; set; }
        public System.DateTime FechaNacimiento { get; set; }
        public Nullable<decimal> Sueldo { get; set; }
        public Nullable<int> IdDepto { get; set; }
    
        public virtual Departamento Departamento { get; set; }
    }
}
