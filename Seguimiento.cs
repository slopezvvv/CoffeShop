using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.SessionState;
namespace CoffeShop
{
    public class Seguimiento : ISeguimiento
    {
        private static HttpSessionState _session;
        private Navegadores _navegador;

        // get y set
        // custom
        public Seguimiento(HttpSessionState session) {
            _session = session;
        }
        public HttpSessionState Session { get; }
        public Navegadores Navegador { get => _navegador; set => _navegador = value; }

        public void IniciarSesion(Navegadores navegador)
        {
            Navegador = navegador;
        }
    }
}