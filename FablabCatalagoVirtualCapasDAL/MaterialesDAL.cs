using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FablabCatalagoVirtualCapasEN;
using System.Data;
using System.Data.SqlClient;
using System.Runtime.InteropServices.WindowsRuntime;
using System.Drawing.Imaging;

namespace FablabCatalagoVirtualCapasDAL
{
    public class MaterialesDAL
    {

        public List<Materiales> regresarLista()
        {
            List<Materiales> lista = new List<Materiales>();//-- definicion de lista 
            SqlCommand cmd = ComunBD.ObtenerComan();
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.CommandText = "SPObtenerTodoMateriales";
            SqlDataReader reader = ComunBD.EjecutarReader(cmd);
            while (reader.Read())
            {
                Materiales Materiales = new Materiales();
                Materiales.Id = reader.GetInt32(0);
                Materiales.NombreMaterial = reader.GetString(1);
                Materiales.X = reader.GetString(2);
                Materiales.Y = reader.GetString(3);
                Materiales.Z = reader.GetString(4);
                Materiales.IdTipoMaterial = reader.GetInt32(5);
                Materiales.Precio = reader.GetDecimal(6);
                lista.Add(Materiales);
            }
            return lista;
        }
        public int guardarMaterial (Materiales pMateriales)
        {
            SqlCommand cmd = ComunBD.ObtenerComan();
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.CommandText = "spAgregarMaterial";
            cmd.Parameters.AddWithValue("@NombreMaterial", pMateriales.NombreMaterial);
			cmd.Parameters.AddWithValue("@X", pMateriales.X);
			cmd.Parameters.AddWithValue("@Y", pMateriales.Y);
			cmd.Parameters.AddWithValue("@Z", pMateriales.Z);
			cmd.Parameters.AddWithValue("@IdTipoMaterial", pMateriales.IdTipoMaterial);
			cmd.Parameters.AddWithValue("@Precio", pMateriales.Precio);
            return ComunBD.EjecutarComand(cmd);
		}
        public int actualizarMaterial (Materiales pMateriales)
        {
			SqlCommand cmd = ComunBD.ObtenerComan();
			cmd.CommandType = CommandType.StoredProcedure;
			cmd.CommandText = "spActualizarMaterial";
			cmd.Parameters.AddWithValue("@Id", pMateriales.Id);
			cmd.Parameters.AddWithValue("@NombreMaterial", pMateriales.NombreMaterial);
			cmd.Parameters.AddWithValue("@X", pMateriales.X);
			cmd.Parameters.AddWithValue("@Y", pMateriales.Y);
			cmd.Parameters.AddWithValue("@Z", pMateriales.Z);
			cmd.Parameters.AddWithValue("@IdTipoMaterial", pMateriales.IdTipoMaterial);
			cmd.Parameters.AddWithValue("@Precio", pMateriales.Precio);
			return ComunBD.EjecutarComand(cmd);
		}
        public int eliminarMateriales (Materiales pMateriales)
        {
            SqlCommand cmd = ComunBD.ObtenerComan();
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.CommandText = "SPEliminarMaterial";
            cmd.Parameters.AddWithValue("@Id", pMateriales.Id);
            return ComunBD.EjecutarComand (cmd);
		}
    }
}
    