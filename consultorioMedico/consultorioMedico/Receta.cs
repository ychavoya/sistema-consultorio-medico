//------------------------------------------------------------------------------
// <auto-generated>
//    This code was generated from a template.
//
//    Manual changes to this file may cause unexpected behavior in your application.
//    Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace consultorioMedico
{
    using System;
    using System.Collections.Generic;
    
    public partial class Receta
    {
        public Receta()
        {
            this.MedicamentoReceta = new List<MedicamentoReceta>();
        }
    
        public int ID { get; set; }
        public int ID_Paciente { get; set; }
        public int ID_Medico { get; set; }
        public bool status { get; set; }
        public string recomendaciones { get; set; }
    
        public   List<MedicamentoReceta> MedicamentoReceta { get; set; }
        public   Medico Medico { get; set; }
        public   Paciente Paciente { get; set; }
    }
}