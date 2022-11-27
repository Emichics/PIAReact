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
    public class BL_MOVIMIENTO
    {
        public static List<string> HacerCompra(string P_Cadena, COMPRA movimiento)
        {
            List<string> lstValidacion = new List<string>();

            try
            {
                var dpParametros = new
                {
                    cantDolares = movimiento.CantDolares,
                    pago = movimiento.Pago,
                    idUsuario = movimiento.IdUsuario
                };

                Contexto.Procedimiento_StoreDB(P_Cadena, "spCompra", dpParametros);

                lstValidacion.Add("00");
                lstValidacion.Add("Compra Realizada con Éxito");
            }
            catch (SqlException e)
            {
                lstValidacion.Add("14");
                lstValidacion.Add(e.Message);
            }

            return lstValidacion;
        }
        public static List<string> HacerVenta(string P_Cadena, VENTA movimiento)
        {
            List<string> lstValidacion = new List<string>();

            try
            {
                var dpParametros = new
                {
                    cantDolares = movimiento.CantDolares,
                    pago = movimiento.Pago,
                    idUsuario = movimiento.IdUsuario
                };

                Contexto.Procedimiento_StoreDB(P_Cadena, "spVenta", dpParametros);

                lstValidacion.Add("00");
                lstValidacion.Add("Venta Realizada con Éxito");
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
