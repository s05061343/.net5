using Microsoft.AspNetCore.Http;
using System.Collections.Generic;
using System.IO;

namespace Web.Request
{
    public class AuthLoginRequest
    {
        public string userId { get; set; }
        public string password { get; set; }
        //public Dictionary<string, Stream> imageset { get; set; }
        public List<IFormFile> imageset { get; set; }
    }
}
