using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections.ObjectModel;
using System.Data;
using System.Data.SqlClient;

using MCPRHBCRYS.TO;


namespace MCPRHBCRYS.DB.DAO
{
    class DBADSPublicacion
    {
        private string _xError = string.Empty;

        public string Error() => this._xError;

        public Collection<TOADSPublicacion> ListarADSPublicacion()
        {
            DBConexion dbConexion = new DBConexion();
            SqlDataReader sqlDataReader = (SqlDataReader)null;
            SqlCommand sqlCommand = new SqlCommand();
            Collection<TOADSPublicacion> collection = new Collection<TOADSPublicacion>();
            this._xError = string.Empty;
            try
            {
                sqlCommand.CommandType = CommandType.StoredProcedure;
                sqlCommand.CommandText = "que_ADSPublicacion";
                sqlCommand.Connection = dbConexion.AbrirModoLectura();
                sqlDataReader = sqlCommand.ExecuteReader();
                while (sqlDataReader.Read())
                    collection.Add(new TOADSPublicacion()
                    {
                        inId = sqlDataReader[0].ToString(),
                        inIdADS = sqlDataReader[1].ToString(),
                        inIdTipoADS = sqlDataReader[2].ToString(),
                        vcUrl = sqlDataReader[3].ToString(),
                        chPublicado = sqlDataReader[4].ToString(),
                        dtPublicado = sqlDataReader[5].ToString(),
                        dtEjecucion = sqlDataReader[6].ToString(),
                        vcTiempoExRPA = sqlDataReader[7].ToString(),
                        vcExcepcionRPA = sqlDataReader[8].ToString(),
                        vcEtapa = sqlDataReader[9].ToString(),
                        vcEstadoRPA = sqlDataReader[9].ToString(),
                        vcObservacionRPA = sqlDataReader[9].ToString(),
                        chReprocesarRPA = sqlDataReader[9].ToString(),
                        dtInicioVigencia = sqlDataReader[9].ToString(),
                        dtFinVigencia = sqlDataReader[9].ToString(),
                        dtRegistro = sqlDataReader[9].ToString(),
                        vcUsuarioCrea = sqlDataReader[10].ToString(),
                        vcUsuarioModifica = sqlDataReader[11].ToString(),
                        dtFechaRegistro = sqlDataReader[12].ToString(),
                        dtFechaModificacion = sqlDataReader[13].ToString()
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

        public bool RegistrarADSPublicacion(TOADSPublicacion pParametro)
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
                sqlCommand.CommandText = "ins_ADSPublicacion";
                sqlCommand.Connection = dbConexion.AbrirModoLectura();

                sqlCommand.Parameters.Add("@inId", SqlDbType.VarChar).Value = (object)pParametro.inId;
                sqlCommand.Parameters.Add("@InIdADS", SqlDbType.VarChar).Value = (object)pParametro.inIdADS;
                sqlCommand.Parameters.Add("@inIdTipoADS", SqlDbType.VarChar).Value = (object)pParametro.inIdTipoADS;
                sqlCommand.Parameters.Add("@vcUrl", SqlDbType.VarChar).Value = (object)pParametro.vcUrl;
                sqlCommand.Parameters.Add("@chPublicado", SqlDbType.VarChar).Value = (object)pParametro.chPublicado;
                sqlCommand.Parameters.Add("@dtPublicado", SqlDbType.VarChar).Value = (object)pParametro.dtPublicado;
                sqlCommand.Parameters.Add("@vcTiempoExRPA", SqlDbType.VarChar).Value = (object)pParametro.vcTiempoExRPA;
                sqlCommand.Parameters.Add("@vcExcepcionRPA", SqlDbType.VarChar).Value = (object)pParametro.vcExcepcionRPA;
                sqlCommand.Parameters.Add("@vcEtapa", SqlDbType.VarChar).Value = (object)pParametro.vcEtapa;
                sqlCommand.Parameters.Add("@vcEstadoRPA", SqlDbType.VarChar).Value = (object)pParametro.vcEstadoRPA;
               sqlCommand.Parameters.Add("@vcObservacion", SqlDbType.VarChar).Value = (object) pParametro.vcObservacionRPA;
               sqlCommand.Parameters.Add("@chReprocesarRPA", SqlDbType.VarChar).Value = (object)pParametro.chReprocesarRPA;
                sqlCommand.Parameters.Add("@dtInicioVigencia", SqlDbType.VarChar).Value = (object)pParametro.dtInicioVigencia;
                sqlCommand.Parameters.Add("@dtFinVigencia", SqlDbType.VarChar).Value = (object)pParametro.dtFinVigencia;
                sqlCommand.Parameters.Add("@dtRegistro", SqlDbType.VarChar).Value = (object)pParametro.dtRegistro;
                sqlCommand.Parameters.Add("@vcUsuarioCrea", SqlDbType.VarChar).Value = (object)pParametro.vcUsuarioCrea;
                sqlCommand.Parameters.Add("@vcUsuarioModifica", SqlDbType.VarChar).Value = (object)pParametro.vcUsuarioModifica;
                sqlCommand.Parameters.Add("@dtFechaRegistro", SqlDbType.VarChar).Value = (object)pParametro.dtFechaRegistro;
                sqlCommand.Parameters.Add("@dtFechaModificacion", SqlDbType.VarChar).Value = (object)pParametro.dtFechaModificacion;
                
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
        public bool ActualizarADSpublicacion(TOADSPublicacion actParametro)
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
                sqlCommand.CommandText = "upd_ADSPublicacion";
                sqlCommand.Connection = dbConexion.AbrirModoEscritura();

                sqlCommand.Parameters.Add("@inId", SqlDbType.VarChar).Value = (object)actParametro.inId;
                sqlCommand.Parameters.Add("@InIdADS", SqlDbType.VarChar).Value = (object)actParametro.inIdADS;
                sqlCommand.Parameters.Add("@inIdTipoADS", SqlDbType.VarChar).Value = (object)actParametro.inIdTipoADS;
                sqlCommand.Parameters.Add("@vcUrl", SqlDbType.VarChar).Value = (object)actParametro.vcUrl;
                sqlCommand.Parameters.Add("@chPublicado", SqlDbType.VarChar).Value = (object)actParametro.chPublicado;
                sqlCommand.Parameters.Add("@dtPublicado", SqlDbType.VarChar).Value = (object)actParametro.dtPublicado;
                sqlCommand.Parameters.Add("@vcTiempoExRPA", SqlDbType.VarChar).Value = (object)actParametro.vcTiempoExRPA;
                sqlCommand.Parameters.Add("@vcExcepcionRPA", SqlDbType.VarChar).Value = (object)actParametro.vcExcepcionRPA;
                sqlCommand.Parameters.Add("@vcEtapa", SqlDbType.VarChar).Value = (object)actParametro.vcEtapa;
                sqlCommand.Parameters.Add("@vcEstadoRPA", SqlDbType.VarChar).Value = (object)actParametro.vcEstadoRPA;
                sqlCommand.Parameters.Add("@vcObservacion", SqlDbType.VarChar).Value = (object)actParametro.vcObservacionRPA;
                sqlCommand.Parameters.Add("@chReprocesarRPA", SqlDbType.VarChar).Value = (object)actParametro.chReprocesarRPA;
                sqlCommand.Parameters.Add("@dtInicioVigencia", SqlDbType.VarChar).Value = (object)actParametro.dtInicioVigencia;
                sqlCommand.Parameters.Add("@dtFinVigencia", SqlDbType.VarChar).Value = (object)actParametro.dtFinVigencia;
                sqlCommand.Parameters.Add("@dtRegistro", SqlDbType.VarChar).Value = (object)actParametro.dtRegistro;
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

        public int EliminarAprobadoresADS(TOADSPublicacion inId)
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
                    sqlCommand.CommandText = "del_ADSPublicacion"; // Replace with your actual stored procedure name
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
