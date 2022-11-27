using DAL;
using DTO;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BL
{
    public class BL_BITACORA
    {
        public static List<string> EstablecerPCompra(string P_Cadena, PrecioCompra movimiento)
        {
            List<string> lstValidacion = new List<string>();

            try
            {
                var dpParametros = new
                {
                    monto = movimiento.Monto,
                    idusuario = movimiento.IdUsuario
                };

                Contexto.Procedimiento_StoreDB(P_Cadena, "spPrecioCompra", dpParametros);

                lstValidacion.Add("00");
                lstValidacion.Add("Precio de la Compra Establecido con Éxito");
            }
            catch (SqlException e)
            {
                lstValidacion.Add("14");
                lstValidacion.Add(e.Message);
            }

            return lstValidacion;
        }
        public static List<string> EstablecerPVenta(string P_Cadena, PrecioVenta movimiento)
        {
            List<string> lstValidacion = new List<string>();

            try
            {
                var dpParametros = new
                {
                    monto = movimiento.Monto,
                    idusuario = movimiento.IdUsuario
                };

                Contexto.Procedimiento_StoreDB(P_Cadena, "spPrecioVenta", dpParametros);

                lstValidacion.Add("00");
                lstValidacion.Add("Precio de la Venta Establecido con Éxito");
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
