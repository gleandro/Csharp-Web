using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using WebApplication1.Models;

namespace WebApplication1.Models
{
    public class AreaModel
    {

        DataEmpresaDataContext contexto = new DataEmpresaDataContext();

        public List<object> listarArea_sql()
        {
            Conexion cn = new Conexion();
            string sql= "select * from area";
            DataTable dato = cn.Ejecutar(sql);
            SqlCommand sql_conn;
            foreach (var area in dato)
            {
                area.
            }

            return List<object>;
        }


        public List<area> listarArea()
        {
            List<area> lista = new List<area>();
            var consulta = contexto.SP_Listar_Area();

            foreach (var area in consulta)
            {
                area a = new area();
                a.are_cod = area.are_cod;
                a.are_des = area.are_des;
                lista.Add(a);
            }

            return lista;
        }

        public area BuscarArea(int codigo)
        {
            area a = new area();

            try
            {
                var consulta = contexto.SP_Buscar_Area(codigo);
                foreach (var area in consulta)
                {
                    a.are_cod = area.are_cod;
                    a.are_des = area.are_des;
                }
            }
            catch (Exception)
            {
                throw;
            }
            return a;
        }

        public string InsertarArea(area a)
        {
            string resultado = string.Empty;
            try
            {
                var consulta = contexto.SP_Insertar_Area(a.are_des);
                resultado = "ok";
            }
            catch (Exception e)
            {
                resultado = e.Message;
            }
            return resultado;
        }

        public string ActualizarArea(area a)
        {
            string resultado = string.Empty;
            try
            {
                var consulta = contexto.SP_Actualiza_Area(a.are_cod,a.are_des);
                resultado = "ok";
            }
            catch (Exception e)
            {
                resultado = e.Message;
            }
            return resultado;
        }

        public string EliminarArea(int codigo)
        {
            string resultado = string.Empty;
            try
            {
                var consulta = contexto.SP_Eliminar_Area(codigo);
                resultado = "ok";
            }
            catch (Exception e)
            {
                resultado = e.Message;
            }
            return resultado;
        }

    }
}