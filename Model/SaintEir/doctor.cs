using System;
using System.Collections.Generic;

#nullable disable

namespace Model.SaintEir
{
    public partial class doctor
    {
        public string 醫師名字 { get; set; }
        public string 電話_手機 { get; set; }
        public string 醫字號 { get; set; }
        public string 管藥證號 { get; set; }
        public string Email { get; set; }
        public string 其他資料 { get; set; }
        public string 名字漢拼 { get; set; }
        public string 醫事人員帳號 { get; set; }
        public string 醫事人員密碼 { get; set; }
        public string 醫事系統信箱 { get; set; }
        public double? IsAlive { get; set; }
    }
}
