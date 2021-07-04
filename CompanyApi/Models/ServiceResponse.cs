using CustomTypes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace CompanyApi.Models
{
    public class ServiceResponse
    {
        public int Code { get; internal set; }
        public object Data { get; internal set; }
        public string Exception { get; internal set; }
    }
}