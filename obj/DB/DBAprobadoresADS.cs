using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
//using Chinalco.Shared;
using System.Collections.ObjectModel;
using System.Data;
using System.Data.SqlClient;
using MCPRHBCRYS.TO;

namespace MCPRHBCRYS.DB.DAO
{
  internal  class DBAprobadoresADS
    {
        private string _xError = string.Empty;

        public string Error() => this._xError;

        public Collection<TOAprobadoresADS> ListarAprobadoresADS()
        {
            DBConexion dbConexion = new DBConexion();
            SqlDataReader sqlDataReader = (SqlDataReader)null;
            SqlCommand sqlCommand = new SqlCommand();
            Collection<TOAprobadoresADS> collection = new Collection<TOAprobadoresADS>();
            this._xError = string.Empty;
            try
            {
                sqlCommand.CommandType = CommandType.StoredProcedure;
                sqlCommand.CommandText = "que_AprobadoresADS";
                sqlCommand.Connection = dbConexion.AbrirModoLectura();
                sqlDataReader = sqlCommand.ExecuteReader();
                while (sqlDataReader.Read())
                    collection.Add(new TOAprobadoresADS()
                    {
                        inId = sqlDataReader[0].ToString(),
                        inIdADS = sqlDataReader[1].ToString(),
                        inIdPaso = sqlDataReader[2].ToString(),
                        inIdPersonal = sqlDataReader[3].ToString(),
                        inIdEstadoAprobacion = sqlDataReader[4].ToString(),
                        inOrden = sqlDataReader[5].ToString(),
                        vcMotivo = sqlDataReader[6].ToString(),
                        vcUsuarioCrea = sqlDataReader[7].ToString(),
                        vcUsuarioModifica = sqlDataReader[8].ToString(),
                        dtFechaRegistro = sqlDataReader[9].ToString(),
                        dtFechaModificacion = sqlDataReader[10].ToString()
                    });
            }
            catch (Exception ex)
            {
                this._xError = ex.Message;
                //  Comun.EventosGrabar("MCPOutSystems", "DBPersonal.ListarPosicion(x,y)", ex);
            }
            finally
            {
                sqlDataReader?.Dispose();
                sqlCommand.Dispose();
                dbConexion.Dispose();
            }
            return collection;

        }

        public bool RegistrarAprobadoresADS(TOAprobadoresADS actParametro)
        {
            DBConexion dbConexion = new DBConexion();
            SqlDataReader sqlDataReader = (SqlDataReader)null;
            SqlCommand sqlCommand = new SqlCommand();
            //Collection<TODatosGenericos> collection = new Collection<TODatosGenericos>();
            this._xError = string.Empty;

            bool chIndicador = false;

            try
            {
                sqlCommand.CommandType = CommandType.StoredProcedure;
                sqlCommand.CommandText = "ins_AprobadoresADS";
                sqlCommand.Connection = dbConexion.AbrirModoLectura();

                sqlCommand.Parameters.Add("@inId", SqlDbType.VarChar).Value = (object)actParametro.inId;
                sqlCommand.Parameters.Add("@inIdADS", SqlDbType.VarChar).Value = (object)actParametro.inIdADS;
                sqlCommand.Parameters.Add("@inIdPaso", SqlDbType.VarChar).Value = (object)actParametro.inIdPaso;
                sqlCommand.Parameters.Add("@inIdPersonal", SqlDbType.VarChar).Value = (object)actParametro.inIdPersonal;
                sqlCommand.Parameters.Add("@inIdEstadoAprobacion", SqlDbType.VarChar).Value = (object)actParametro.inIdEstadoAprobacion;
                sqlCommand.Parameters.Add("@inOrden", SqlDbType.VarChar).Value = (object)actParametro.inOrden;
                sqlCommand.Parameters.Add("@vcMotivo", SqlDbType.VarChar).Value = (object)actParametro.vcMotivo;
                sqlCommand.Parameters.Add("@vcUsuarioCrea", SqlDbType.VarChar).Value = (object)actParametro.vcUsuarioCrea;
                sqlCommand.Parameters.Add("@vcUsuarioModifica", SqlDbType.VarChar).Value = (object)actParametro.vcUsuarioModifica;
                sqlCommand.Parameters.Add("@dtFechaRegistro", SqlDbType.VarChar).Value = (object)actParametro.dtFechaRegistro;
                sqlCommand.Parameters.Add("@dtFechaModificacion", SqlDbType.VarChar).Value = (object)actParametro.dtFechaModificacion;



                sqlDataReader = sqlCommand.ExecuteReader();

                if (sqlDataReader.HasRows)
                {
                    chIndicador = true;
                }

            }
            catch (Exception ex)
            {
                this._xError = ex.Message;
                // Comun.EventosGrabar("MCPOutSystems", "DBPersonal.RegistrarDatosGenericos(x,y)", ex);
            }
            finally
            {
                sqlDataReader?.Dispose();
                sqlCommand.Dispose();
                dbConexion.Dispose();
            }
            return chIndicador;
        }

        public bool ActualizarAprobadoresADS(TOAprobadoresADS actParametro)
        {
            DBConexion dbConexion = new DBConexion();
            SqlDataReader sqlDataReader = (SqlDataReader)null;
            SqlCommand sqlCommand = new SqlCommand();
            //Collection<TODatosGenericos> collection = new Collection<TODatosGenericos>();
            this._xError = string.Empty;

            bool chIndicador = false;

            try
            {
                sqlCommand.CommandType = CommandType.StoredProcedure;
                sqlCommand.CommandText = "upd_AprobadoresADS";
                sqlCommand.Connection = dbConexion.AbrirModoEscritura();

                sqlCommand.Parameters.Add("@inId", SqlDbType.VarChar).Value = (object)actParametro.inId;
                sqlCommand.Parameters.Add("@inIdADS", SqlDbType.VarChar).Value = (object)actParametro.inIdADS;
                sqlCommand.Parameters.Add("@inIdPaso", SqlDbType.VarChar).Value = (object)actParametro.inIdPaso;
                sqlCommand.Parameters.Add("@inIdPersonal", SqlDbType.VarChar).Value = (object)actParametro.inIdPersonal;
                sqlCommand.Parameters.Add("@inIdEstadoAprobacion", SqlDbType.VarChar).Value = (object)actParametro.inIdEstadoAprobacion;
                sqlCommand.Parameters.Add("@inOrden", SqlDbType.VarChar).Value = (object)actParametro.inOrden;
                sqlCommand.Parameters.Add("@vcMotivo", SqlDbType.VarChar).Value = (object)actParametro.vcMotivo;
                sqlCommand.Parameters.Add("@vcUsuarioCrea", SqlDbType.VarChar).Value = (object)actParametro.vcUsuarioCrea;
                sqlCommand.Parameters.Add("@vcUsuarioModifica", SqlDbType.VarChar).Value = (object)actParametro.vcUsuarioModifica;
                sqlCommand.Parameters.Add("@dtFechaRegistro", SqlDbType.VarChar).Value = (object)actParametro.dtFechaRegistro;
                sqlCommand.Parameters.Add("@dtFechaModificacion", SqlDbType.VarChar).Value = (object)actParametro.dtFechaModificacion;

                sqlDataReader = sqlCommand.ExecuteReader();

                if (sqlDataReader.HasRows)
                {
                    chIndicador = true;
                }
            }
            catch (Exception ex)
            {
                this._xError = ex.Message;
                //  Comun.EventosGrabar("MCPOutSystems", "DBPersonal.ActualizarDatosGenericos(x,y)", ex);
            }
            finally
            {
                sqlDataReader?.Dispose();
                sqlCommand.Dispose();
                dbConexion.Dispose();
            }
            return chIndicador;
        }


        public int EliminarAprobadoresADS(TOAprobadoresADS inId)
        {

            int rowsAffected = 0;

            DBConexion dbConexion = new DBConexion();
            //DBConexion dbConexion = new DBConexion();
            // SqlDataReader sqlDataReader = (SqlDataReader)null;
            SqlCommand sqlCommand = new SqlCommand();
            //Collection<TODatosGenericos> collection = new Collection<TODatosGenericos>();
            this._xError = string.Empty;
            //  int chIndicador = false;
            try
            {
                //using (SqlCommand sqlCommand = new SqlCommand())
                {
                    sqlCommand.CommandType = CommandType.StoredProcedure;
                    sqlCommand.CommandText = "del_AprobadoresADS"; // Replace with your actual stored procedure name
                    sqlCommand.Connection = dbConexion.AbrirModoEscritura();

                    sqlCommand.Parameters.Add("@inId", SqlDbType.Int).Value = inId;

                    sqlCommand.ExecuteNonQuery();
                }
            }
            catch (Exception ex)
            {
                _xError = ex.Message;
                //  Comun.EventosGrabar("MCPOutSystems", "DBEstrategia.EliminarEstrategia(idEstrategia)", ex);
            }
            finally
            {
                dbConexion.Dispose();
            }

            return rowsAffected;
        }


    }
}
