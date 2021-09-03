using System;
using System.Collections.Generic;

#nullable disable

namespace Model.SaintEir
{
    public partial class SaintEir_ParameterControl
    {
        public SaintEir_ParameterControl()
        {
            SaintEir_Parameters = new HashSet<SaintEir_Parameter>();
        }

        public int Id { get; set; }
        public string Type { get; set; }
        public string Description { get; set; }

        public virtual ICollection<SaintEir_Parameter> SaintEir_Parameters { get; set; }
    }
}
