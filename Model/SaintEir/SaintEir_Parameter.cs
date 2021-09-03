using System;
using System.Collections.Generic;

#nullable disable

namespace Model.SaintEir
{
    public partial class SaintEir_Parameter
    {
        public int Id { get; set; }
        public string Type { get; set; }
        public string Name { get; set; }
        public int OrderNo { get; set; }
        public int Flag { get; set; }

        public virtual SaintEir_ParameterControl TypeNavigation { get; set; }
    }
}
