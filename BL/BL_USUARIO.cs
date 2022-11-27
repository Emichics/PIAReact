using DAL;
using DTO;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Diagnostics.Contracts;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BL
{
    public class BL_USUARIO
    {
        public static List<ConsultarUSUARIO> Consultar(string P_Cadena)
        {
            List<ConsultarUSUARIO> lstUsuarios = new List<ConsultarUSUARIO>();

            
            DataTable Dt = Contexto.Funcion_StoreDB1(P_Cadena, "spConsultaUsuarios");

            lstUsuarios = (from item in Dt.AsEnumerable()
                           select new ConsultarUSUARIO
                           {
                               IdUsuario = item.Field<int>("idUsuario"),
                               Nombre = item.Field<string>("Nombre"),
                               APaterno = item.Field<string>("APaterno"),
                               AMaterno = item.Field<string>("AMaterno"),
                               Usuario = item.Field<string>("Usuario"),
                               Contra = item.Field<string>("Contra"),
                               IsActivo = item.Field<bool>("IsActivo"),
                               FecRegistro = item.Field<DateTime>("FecRegistro")
                           }
                           ).ToList<ConsultarUSUARIO>();

            return lstUsuarios;

        }
        public static List<string> AgregarUsuario(string P_Cadena, AgregarUSUARIO Usuario)
        {
            List<string> lstValidacion = new List<string>();

            try
            {
                var dpParametros = new
                {
                    nombre = Usuario.Nombre,
                    aPaterno = Usuario.APaterno,
                    aMaterno = Usuario.AMaterno,
                    usuario = Usuario.Usuario,
                    contra = Usuario.Contra
                };

                Contexto.Procedimiento_StoreDB(P_Cadena, "spAgregarUsuario", dpParametros);

                lstValidacion.Add("00");
                lstValidacion.Add("Usuario Guardado con Éxito");
            }
            catch (SqlException e)
            {
                lstValidacion.Add("14");
                lstValidacion.Add(e.Message);
            }

            return lstValidacion;
        }
        public static List<string> ModificarUsuario(string P_Cadena, ModificarUSUARIO Usuario)
        {
            List<string> lstValidacion = new List<string>();

            try
            {
                var dpParametros = new
                {
                    id = Usuario.IdUsuario,
                    nombre = Usuario.Nombre,
                    aPaterno = Usuario.APaterno,
                    aMaterno = Usuario.AMaterno,
                    usuario = Usuario.Usuario,
                    contra = Usuario.Contra
                };

                Contexto.Procedimiento_StoreDB(P_Cadena, "spModificarUsuario", dpParametros);

                lstValidacion.Add("00");
                lstValidacion.Add("Usuario modificado con Éxito");
            }

            catch (SqlException e)
            {
                lstValidacion.Add("14");
                lstValidacion.Add(e.Message);
            }

            return lstValidacion;

        }
        public static List<string> DeshabilitarUsuario(string P_Cadena, int IdUsuario)
        {

            List<string> lstValidacion = new List<string>();

            try
            {
                var dpParametros = new
                {
                    id = IdUsuario,

                };

                Contexto.Procedimiento_StoreDB(P_Cadena, "spDeshabilitarUsuario", dpParametros);

                lstValidacion.Add("00");
                lstValidacion.Add("Usuario Deshabilitado con Éxito");
            }

            catch (SqlException e)
            {
                lstValidacion.Add("14");
                lstValidacion.Add(e.Message);
            }

            return lstValidacion;


        }
        
        
    }
}
