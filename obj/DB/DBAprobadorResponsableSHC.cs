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
   internal class DBAprobadorResponsableSHC
    {
        private string _xError = string.Empty;

        public string Error() => this._xError;

        public Collection<TOAprobadorResponsableSHC> ListarAprobadorResponsableSHCS()
        {
            DBConexion dbConexion = new DBConexion();
            SqlDataReader sqlDataReader = (SqlDataReader)null;
            SqlCommand sqlCommand = new SqlCommand();
            Collection<TOAprobadorResponsableSHC> collection = new Collection<TOAprobadorResponsableSHC>();
            this._xError = string.Empty;
            try
            {
                sqlCommand.CommandType = CommandType.StoredProcedure;
                sqlCommand.CommandText = "que_AprobadorResponsableSHC";
                sqlCommand.Connection = dbConexion.AbrirModoLectura();
                sqlDataReader = sqlCommand.ExecuteReader();
                while (sqlDataReader.Read())
                    collection.Add(new TOAprobadorResponsableSHC()
                    {
                        InIdAprobadorRespHC = sqlDataReader[0].ToString(),
                        InIdSolicitud = sqlDataReader[1].ToString(),
                        InIdTipoSolicitud = sqlDataReader[2].ToString(),
                        InIdEstadoSolicitud = sqlDataReader[3].ToString(),
                        InIdPaso  = sqlDataReader[4].ToString(),
                        InIdPosicion = sqlDataReader[5].ToString(),
                        InIdPersonal = sqlDataReader[6].ToString(),
                        InIdEstadoAprobacion = sqlDataReader[7].ToString(),
                        DtActualizacionPaso = sqlDataReader[8].ToString(),
                        ChUltimoActualizador = sqlDataReader[9].ToString(),
                        vcUsuarioCrea = sqlDataReader[10].ToString(),
                        VcUsuarioModifica = sqlDataReader[11].ToString(),
                        DtFechaRegistro = sqlDataReader[12].ToString(),
                        DtFechaModificacion = sqlDataReader[13].ToString()
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


        public bool RegistrarAprobadorResponsableSHC(TOAprobadorResponsableSHC pParametro)
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
                sqlCommand.CommandText = "ins_AprobadorResponsableSHC";
                sqlCommand.Connection = dbConexion.AbrirModoLectura();

                sqlCommand.Parameters.Add("@InIdAprobadorRespHC", SqlDbType.VarChar).Value = (object)pParametro.InIdAprobadorRespHC;
                sqlCommand.Parameters.Add("@InIdSolicitud", SqlDbType.VarChar).Value = (object)pParametro.InIdSolicitud;
                sqlCommand.Parameters.Add("@InIdTipoSolicitud", SqlDbType.VarChar).Value = (object)pParametro.InIdTipoSolicitud;
                sqlCommand.Parameters.Add("@InIdEstadoSolicitud",SqlDbType.VarChar).Value = (object)pParametro.InIdEstadoSolicitud;
                sqlCommand.Parameters.Add("@InIdPaso ", SqlDbType.VarChar).Value = (object)pParametro.InIdPaso;
                sqlCommand.Parameters.Add("@InIdPosicion", SqlDbType.VarChar).Value = (object)pParametro.InIdPosicion;
                sqlCommand.Parameters.Add("@InIdPersonal", SqlDbType.VarChar).Value = (object)pParametro.InIdPersonal;
                sqlCommand.Parameters.Add("@InIdEstadoAprobacion", SqlDbType.VarChar).Value = (object)pParametro.InIdEstadoAprobacion;
                sqlCommand.Parameters.Add("@DtActualizacionPaso", SqlDbType.VarChar).Value = (object)pParametro.DtActualizacionPaso;
                sqlCommand.Parameters.Add("@ChUltimoActualizador", SqlDbType.VarChar).Value = (object)pParametro.ChUltimoActualizador;                   
                sqlCommand.Parameters.Add("@vcUsuarioCrea", SqlDbType.VarChar).Value = (object)pParametro.vcUsuarioCrea;
                sqlCommand.Parameters.Add("@VcUsuarioModifica", SqlDbType.VarChar).Value = (object)pParametro.VcUsuarioModifica;
                sqlCommand.Parameters.Add("@DtFechaRegistro", SqlDbType.VarChar).Value = (object)pParametro.DtFechaRegistro;
                sqlCommand.Parameters.Add("@DtFechaModificacion", SqlDbType.VarChar).Value = (object)pParametro.DtFechaModificacion;



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

        public bool ActualizarAprobadorResponsableSHC(TOAprobadorResponsableSHC actParametro)
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
                sqlCommand.CommandText = "upd_AprobadorResponsableSHC";
                sqlCommand.Connection = dbConexion.AbrirModoEscritura();

                sqlCommand.Parameters.Add("@InIdAprobadorRespHC", SqlDbType.VarChar).Value = (object)actParametro.InIdAprobadorRespHC;
                sqlCommand.Parameters.Add("@InIdSolicitud", SqlDbType.VarChar).Value = (object)actParametro.InIdSolicitud;
                sqlCommand.Parameters.Add("@InIdTipoSolicitud", SqlDbType.VarChar).Value = (object)actParametro.InIdTipoSolicitud;
                sqlCommand.Parameters.Add("@InIdEstadoSolicitud", SqlDbType.VarChar).Value = (object)actParametro.InIdEstadoSolicitud;
                sqlCommand.Parameters.Add("@InIdPaso ", SqlDbType.VarChar).Value = (object)actParametro.InIdPaso;
                sqlCommand.Parameters.Add("@InIdPosicion", SqlDbType.VarChar).Value = (object)actParametro.InIdPosicion;
                sqlCommand.Parameters.Add("@InIdPersonal", SqlDbType.VarChar).Value = (object)actParametro.InIdPersonal;
                sqlCommand.Parameters.Add("@InIdEstadoAprobacion", SqlDbType.VarChar).Value = (object)actParametro.InIdEstadoAprobacion;
                sqlCommand.Parameters.Add("@DtActualizacionPaso", SqlDbType.VarChar).Value = (object)actParametro.DtActualizacionPaso;
                sqlCommand.Parameters.Add("@ChUltimoActualizador", SqlDbType.VarChar).Value = (object)actParametro.ChUltimoActualizador;
                sqlCommand.Parameters.Add("@vcUsuarioCrea", SqlDbType.VarChar).Value = (object)actParametro.vcUsuarioCrea;
                sqlCommand.Parameters.Add("@VcUsuarioModifica", SqlDbType.VarChar).Value = (object)actParametro.VcUsuarioModifica;
                sqlCommand.Parameters.Add("@DtFechaRegistro", SqlDbType.VarChar).Value = (object)actParametro.DtFechaRegistro;
                sqlCommand.Parameters.Add("@DtFechaModificacion", SqlDbType.VarChar).Value = (object)actParametro.DtFechaModificacion;



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

        public int EliminarAprobadoresADS(TOAprobadorResponsableSHC InIdAprobadorRespHC)
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
                    sqlCommand.CommandText = "del_AprobadorResponsableSHC"; // Replace with your actual stored procedure name
                    sqlCommand.Connection = dbConexion.AbrirModoEscritura();

                    sqlCommand.Parameters.Add("@InIdAprobadorRespHC", SqlDbType.Int).Value = InIdAprobadorRespHC;

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
