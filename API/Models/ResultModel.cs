using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Threading.Tasks;

namespace API.Models
{
    public class ResultModel
    {
        public object Result { get; set; } = "";

        public string Status { get; set; } = "ok";

        public string Message { get; set; }

    }
}
