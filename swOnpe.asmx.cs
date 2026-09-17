using swOnpe.Controllers.swOnpe.Controllers;
using swOnpe.Models;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Web;
using System.Web.Services;

namespace swOnpe
{
    /// <summary>
    /// Descripción breve de swOnpe
    /// </summary>
    [WebService(Namespace = "http://tempuri.org/")]
    [WebServiceBinding(ConformsTo = WsiProfiles.BasicProfile1_1)]
    [System.ComponentModel.ToolboxItem(false)]
    // Para permitir que se llame a este servicio web desde un script, usando ASP.NET AJAX, quite la marca de comentario de la línea siguiente. 
    // [System.Web.Script.Services.ScriptService]
    public class swOnpe : System.Web.Services.WebService
    {
        OnpeController controller = new OnpeController();

        [WebMethod]
        public DataTable departamentos()
        {
            return controller.getDepartamentos();
        }

        [WebMethod]
        public DataTable provincias(int id)
        {
            return controller.getProvincias(id);
        }

        [WebMethod]
        public DataTable distritos(int id)
        {
            return controller.getDistritos(id);
        }

        [WebMethod]
        public DataTable locales(int id)
        {
            return controller.getLocalesVotacion(id);
        }

        [WebMethod]
        public DataTable gruposVotacion(int id)
        {
            return controller.getGruposVotacion(id);
        }



        [WebMethod]
        public DataTable acta(string id)
        {
            return controller.getGrupoVotacion(id);
        }

        [WebMethod]
        public List<Actas> actaModel(string id)
        {
            return controller.getGrupoVotacionModel(id);
        }



        [WebMethod]
        public DataTable participacionNacional()
        {
            return controller.getVotos(1, 25);
        }

        [WebMethod]
        public DataTable participacionExtranjero()
        {
            return controller.getVotos(26, 30);
        }

        [WebMethod]
        public DataTable participacionDepartamento(string departamento)
        {
            return controller.getVotosDepartamento(departamento);
        }

        [WebMethod]
        public DataTable participacionProvincia(string provincia)
        {
            return controller.getVotosProvincia(provincia);
        }

    }
}
