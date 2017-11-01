using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace SXBIN.Web
{
    public class DataJsonResult
    {

        public string ErrorMessage { get; set; }

        public string ReturnCode {
            get
            {
                return string.IsNullOrWhiteSpace(ErrorMessage)?"200":"500";
            }
            set
            {
                ReturnCode = string.IsNullOrWhiteSpace(ErrorMessage) ? "200" : "500";
            }
        }

        public bool Success
        {
            get { return string.IsNullOrWhiteSpace(ErrorMessage); }
            set
            {
                Success = string.IsNullOrWhiteSpace(ErrorMessage);
            }
        }

        public Object Data { get; set; }
    }
}