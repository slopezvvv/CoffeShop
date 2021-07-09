using System;
using System.Data;
using System.Linq;
using System.Threading;

namespace CoffeShop
{
    public partial class index : System.Web.UI.Page
    {
        private static ISeguimiento _seguimiento;

        internal static ISeguimiento Seguimiento { get => _seguimiento; }

        
        protected void Page_Load(object sender, EventArgs e)
        {
            Tick();
            _seguimiento = new Seguimiento(Session);
        }
        protected void Page_LoadComplete(object sender, EventArgs e)
        {
            string n = Request.Browser.Browser.Where(x => x.ToString() == "Firefox").ToString();
            Seguimiento.IniciarSesion(n != string.Empty ? Navegadores.FIREFOX : Navegadores.SIN_ESPECIFICAR);
            //new Thread(x => Tick()).Start();
        }

       private void Tick()
        {
            //_laHora.Text = "hola mundo!";
            //_laHora.Text = string.Format("{0} : {1} : {2}", dt.Hour, dt.Minute, dt.Second);
            _laHora.Text = DateTime.Now.ToString("hh:mm:ss");
        }
    }
}




/*
DataSet1TableAdapters.ClientesTableAdapter adapter = new DataSet1TableAdapters.ClientesTableAdapter();
DataSet1 dataSet = new DataSet1();
DataSet1.ClientesDataTable dt = new DataSet1.ClientesDataTable();
adapter.ObtenerClientes(dt);
//GVClientes.DataSource = dataTable;
GVClientes.DataSource = dt;
GVClientes.DataBind();
List<DataSet1.ClientesRow> list = dt.ToList();
list.Select(x => x.Id).Where(id => id == 0);
var resultados = from usuario in list
                 where usuario.Id >= 1
                 select usuario;
_out.Text = list[0].nombre;
*/