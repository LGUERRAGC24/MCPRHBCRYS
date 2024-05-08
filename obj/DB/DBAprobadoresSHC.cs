using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MCPRHBCRYS.TO;
//using Chinalco.Shared;
using System.Collections.ObjectModel;
using System.Data;
using System.Data.SqlClient;



namespace MCPRHBCRYS.DB.DAO
{
   
    internal  class DBAprobadoresSHC
    {
        private string _xError = string.Empty;

        public string Error() => this._xError;

        public Collection<TOAprobadoresSHC> ListarAprobadoresSHC()
        {
            DBConexion dbConexion = new DBConexion();
            SqlDataReader sqlDataReader = (SqlDataReader)null;
            SqlCommand sqlCommand = new SqlCommand();
            Collection<TOAprobadoresSHC> collection = new Collection<TOAprobadoresSHC>();
            this._xError = string.Empty;
            try
            {
                sqlCommand.CommandType = CommandType.StoredProcedure;
                sqlCommand.CommandText = "que_AprobadoresSHC";
                sqlCommand.Connection = dbConexion.AbrirModoLectura();
                sqlDataReader = sqlCommand.ExecuteReader();
                while (sqlDataReader.Read())
                    collection.Add(new TOAprobadoresSHC()
                    {
                        InIdAprobadoresHC = sqlDataReader[0].ToString(),
                        InIdSolicitudHC = sqlDataReader[1].ToString(),
                        InIdPaso = sqlDataReader[2].ToString(),
                        InIdPersonal = sqlDataReader[3].ToString(),
                        InIdEstadoAprobacion = sqlDataReader[4].ToString(),
                        InTipoSolicitante = sqlDataReader[5].ToString(),
                        InOrden = sqlDataReader[6].ToString(),
                        VcMotivo = sqlDataReader[7].ToString(),
                        VcsuarioCrea = sqlDataReader[8].ToString(),
                        VcUsuarioModifica = sqlDataReader[9].ToString(),
                        DtFechaRegistro = sqlDataReader[10].ToString(),
                        DtFechaModificacion = sqlDataReader[11].ToString()
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


        public bool RegistrarAprobadoresSHC(TOAprobadoresSHC pParametro)
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
                sqlCommand.CommandText = "ins_AprobadoresSHC";
                sqlCommand.Connection = dbConexion.AbrirModoLectura();

                sqlCommand.Parameters.Add("@InIdAprobadoresHC", SqlDbType.VarChar).Value = (object)pParametro.InIdAprobadoresHC;
                sqlCommand.Parameters.Add("@InIdSolicitudHC", SqlDbType.VarChar).Value = (object)pParametro.InIdSolicitudHC;
                sqlCommand.Parameters.Add("@InIdPaso", SqlDbType.VarChar).Value = (object)pParametro.InIdPaso;
                sqlCommand.Parameters.Add("@InIdPersonal", SqlDbType.VarChar).Value = (object)pParametro.InIdPersonal;
                sqlCommand.Parameters.Add("@InIdEstadoAprobacion", SqlDbType.VarChar).Value = (object)pParametro.InIdEstadoAprobacion;
                sqlCommand.Parameters.Add("@InTipoSolicitante", SqlDbType.VarChar).Value = (object)pParametro.InTipoSolicitante;
                sqlCommand.Parameters.Add("@InOrden", SqlDbType.VarChar).Value = (object)pParametro.InOrden;
                sqlCommand.Parameters.Add("@VcMotivo", SqlDbType.VarChar).Value = (object)pParametro.VcMotivo;
                sqlCommand.Parameters.Add("@VcsuarioCrea", SqlDbType.VarChar).Value = (object)pParametro.VcsuarioCrea;
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

        public bool ActualizarAprobadoresSHC(TOAprobadoresSHC pParametro)
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
                sqlCommand.CommandText = "upd_AprobadoresSHC";
                sqlCommand.Connection = dbConexion.AbrirModoEscritura();

                sqlCommand.Parameters.Add("@InIdAprobadoresHC", SqlDbType.VarChar).Value = (object)pParametro.InIdAprobadoresHC;
                sqlCommand.Parameters.Add("@InIdSolicitudHC", SqlDbType.VarChar).Value = (object)pParametro.InIdSolicitudHC;
                sqlCommand.Parameters.Add("@InIdPaso", SqlDbType.VarChar).Value = (object)pParametro.InIdPaso;
                sqlCommand.Parameters.Add("@InIdPersonal", SqlDbType.VarChar).Value = (object)pParametro.InIdPersonal;
                sqlCommand.Parameters.Add("@InIdEstadoAprobacion", SqlDbType.VarChar).Value = (object)pParametro.InIdEstadoAprobacion;
                sqlCommand.Parameters.Add("@InTipoSolicitante", SqlDbType.VarChar).Value = (object)pParametro.InTipoSolicitante;
                sqlCommand.Parameters.Add("@InOrden", SqlDbType.VarChar).Value = (object)pParametro.InOrden;
                sqlCommand.Parameters.Add("@VcMotivo", SqlDbType.VarChar).Value = (object)pParametro.VcMotivo;
                sqlCommand.Parameters.Add("@VcsuarioCrea", SqlDbType.VarChar).Value = (object)pParametro.VcsuarioCrea;
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

        public int EliminarAprobadoresADS(TOAprobadoresSHC InIdAprobadoresHC)
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
                    sqlCommand.CommandText = "del_AprobadoresSHC"; // Replace with your actual stored procedure name
                    sqlCommand.Connection = dbConexion.AbrirModoEscritura();

                    sqlCommand.Parameters.Add("@InIdAprobadoresHC", SqlDbType.Int).Value = InIdAprobadoresHC;

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
