using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Services;

namespace BasicAuthWS
{
    public class ServizioAuth : System.Web.Services.WebService
    {
        [WebMethod]
        public string HelloWorld()
        {
            return "Hello World";
        }

        [WebMethod]
        public int Aggiungi(int x, int y)
        {
            return x + y;
        }
    }
}