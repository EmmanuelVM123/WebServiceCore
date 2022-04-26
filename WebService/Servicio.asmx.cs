using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Services;

namespace WebService
{
    /// <summary>
    /// Descripción breve de WebService1
    /// </summary>
    [WebService(Namespace = "http://tempuri.org/")]
    [WebServiceBinding(ConformsTo = WsiProfiles.BasicProfile1_1)]
    [System.ComponentModel.ToolboxItem(false)]
    // Para permitir que se llame a este servicio web desde un script, usando ASP.NET AJAX, quite la marca de comentario de la línea siguiente. 
    // [System.Web.Script.Services.ScriptService]
    public class WebService1 : System.Web.Services.WebService
    {
        Nota nota = new Nota();
        List<Nota> notaList = new List<Nota>();

        [WebMethod]
        public string HelloWorld()
        {
            return "Hola a todos";
        }

        [WebMethod]
        public string Saludo(string nombre) 
        { 
            return "Saludos " + nombre + " bienvenido a un servio web en XML"; 
        }

        [WebMethod]
        public float Suma (float a, float b)
        {
            return a + b;
        }

        [WebMethod]
        public float OperacionesBasicas(float n1, string operador, float n2)
        {
            float result = 0;
            switch (operador)
            {
                case "+":
                    result = n1 + n2;
                    break;
                case "-":
                    result = n1 - n2;
                    break ;
                    case "*":   
                    result = n1 * n2;
                    break;
                case "/":
                    result = n1 / n2;
                    break;
            }
            return result;

        }

        [WebMethod]
        public string InsertaNota(string Titulo, string Contenido)
        {
            string result = "";
            try
            {
                Nota n = new Nota();
                n.Titulo = Titulo;
                n.Contenido = Contenido;
                n.FechaHora = DateTime.Now;
                using(var db = new PADMEntities())
                        {
                    db.Nota.Add(n);
                    db.SaveChanges();
                    result = "¡Se insertó el registro correctamente!";
                }
            }
            catch
            {
                result = "¡Error al registrar un registro!";
            }
            return result; 
        }  

        [WebMethod]
        public List<Nota> SelectNota()
        {
            using(var db = new PADMEntities())
            {
                return db.Nota.ToList();
            }
        }
    }
}
