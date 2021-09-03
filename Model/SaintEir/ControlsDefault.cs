using System;
using System.Collections.Generic;

#nullable disable

namespace Model.SaintEir
{
    public partial class ControlsDefault
    {
        public int Id { get; set; }
        public string ControlsGroup { get; set; }
        public string ControlsID { get; set; }
        public string DefaultValue { get; set; }
        public string DefaultText { get; set; }
        public string Comment { get; set; }
        public int OrderBy { get; set; }
        public string Icon { get; set; }
    }
}
