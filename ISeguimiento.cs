using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
/*
 * Tipos de datos:
 * n = navegador
 * */
namespace CoffeShop
{
    interface ISeguimiento
    {
        Navegadores Navegador { get; set; }
        void IniciarSesion(Navegadores n);
    }
}
