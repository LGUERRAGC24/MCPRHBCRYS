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
    
    internal class  DBSolicitudHC
    {

        private string _xError = string.Empty;

        public string Error() => this._xError;


        public Collection<TOSolicitudHC> ListarSolicitudHC()
        {
            DBConexion dbConexion = new DBConexion();
            SqlDataReader sqlDataReader = (SqlDataReader)null;
            SqlCommand sqlCommand = new SqlCommand();
            Collection<TOSolicitudHC> collection = new Collection<TOSolicitudHC>();
            this._xError = string.Empty;
            try
            {
                sqlCommand.CommandType = CommandType.StoredProcedure;
                sqlCommand.CommandText = "que_SolicitudHC";
                sqlCommand.Connection = dbConexion.AbrirModoLectura();
                sqlDataReader = sqlCommand.ExecuteReader();
                while (sqlDataReader.Read())
                    collection.Add(new TOSolicitudHC()
                    {
                        inIdSolicitudHC  = sqlDataReader[0].ToString(),
                        inReferencia  = sqlDataReader[1].ToString(),
                        vcReferencia = sqlDataReader[2].ToString(),
                        inIdPersonalSolicitante  = sqlDataReader[3].ToString(),
                        inIdPersonalVParea  = sqlDataReader[4].ToString(),
                        idPersonalGerenteArea  = sqlDataReader[5].ToString(),
                         inTipoSolicitud   = sqlDataReader[6].ToString(),
                          inIdPosicion  = sqlDataReader[7].ToString(),
                          vcSustento = sqlDataReader[8].ToString(),
                        inCantidadPosiciones =  sqlDataReader[9].ToString(),
                        inIdJefeReporta  = sqlDataReader[10].ToString(),
                        inIdLugarTrabajo  = sqlDataReader[11].ToString(),
                        inIdTipoContrato = sqlDataReader[12].ToString(),
                        inTiempoContrato = sqlDataReader[13].ToString(),
                        chDeclaracionJurada = sqlDataReader[14].ToString(),
                        inIdEstado  = sqlDataReader[15].ToString(),
                        inOrden  = sqlDataReader[16].ToString(),
                        inCantAprobadores  = sqlDataReader[17].ToString(),
                        chAtipico  = sqlDataReader[18].ToString(),
                        dtFecIicioActPerfil = sqlDataReader[19].ToString(),
                        dtFecFinActPerfil = sqlDataReader[20].ToString(),
                        vcPuesto = sqlDataReader[21].ToString(),
                        vcusuarioCrea = sqlDataReader[22].ToString(),
                        vcUsuarioModifica = sqlDataReader[20].ToString(),
                        dtFechaRegistro = sqlDataReader[21].ToString(),
                        dtFechaModificacion = sqlDataReader[22].ToString()
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
        public bool RegistrarSolicitudHC(TOSolicitudHC actParametro)
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
                sqlCommand.CommandText = "ins_SolivitudHC";
                sqlCommand.Connection = dbConexion.AbrirModoLectura();

                sqlCommand.Parameters.Add("@inIdSolicitudHC", SqlDbType.VarChar).Value = (object)actParametro.inIdSolicitudHC;
                sqlCommand.Parameters.Add("@inReferencia", SqlDbType.VarChar).Value = (object)actParametro.inReferencia;
                sqlCommand.Parameters.Add("@vcReferencia", SqlDbType.VarChar).Value = (object)actParametro.vcReferencia;
                sqlCommand.Parameters.Add("@inIdPersonalSolicitante", SqlDbType.VarChar).Value = (object)actParametro.inIdPersonalSolicitante;
                sqlCommand.Parameters.Add("@inIdPersonalVParea", SqlDbType.VarChar).Value = (object)actParametro.inIdPersonalVParea;
                sqlCommand.Parameters.Add("@idPersonalGerenteArea", SqlDbType.VarChar).Value = (object)actParametro.idPersonalGerenteArea;
                sqlCommand.Parameters.Add("@inTipoSolicitud", SqlDbType.VarChar).Value = (object)actParametro.inTipoSolicitud;
                sqlCommand.Parameters.Add("@inIdPosicion", SqlDbType.VarChar).Value = (object)actParametro.inIdPosicion;
                sqlCommand.Parameters.Add("@vcSustento", SqlDbType.VarChar).Value = (object)actParametro.vcSustento;
                sqlCommand.Parameters.Add("@inCantidadPosiciones", SqlDbType.VarChar).Value = (object)actParametro.inCantidadPosiciones;
                sqlCommand.Parameters.Add("@inIdJefeReporta", SqlDbType.VarChar).Value = (object)actParametro.inIdJefeReporta;
                sqlCommand.Parameters.Add("@IinIdLugarTrabajo", SqlDbType.VarChar).Value = (object)actParametro.inIdLugarTrabajo;
                sqlCommand.Parameters.Add("@inIdRegimenTrabajo", SqlDbType.VarChar).Value = (object)actParametro.inIdRegimenTrabajo;
                sqlCommand.Parameters.Add("@inIdTipoContrato", SqlDbType.VarChar).Value = (object)actParametro.inIdTipoContrato;
                sqlCommand.Parameters.Add("@IinTiempoContrato", SqlDbType.VarChar).Value = (object)actParametro.inTiempoContrato;
                sqlCommand.Parameters.Add("@chDeclaracionJurada", SqlDbType.VarChar).Value = (object)actParametro.chDeclaracionJurada;
                sqlCommand.Parameters.Add("@inIdEstado", SqlDbType.VarChar).Value = (object)actParametro.inIdEstado;
                sqlCommand.Parameters.Add("@inOrden", SqlDbType.VarChar).Value = (object)actParametro.inOrden;
                sqlCommand.Parameters.Add("@inCantAprobadores", SqlDbType.VarChar).Value = (object)actParametro.inCantAprobadores;
                sqlCommand.Parameters.Add("@chAtipico", SqlDbType.VarChar).Value = (object)actParametro.chAtipico;
                sqlCommand.Parameters.Add("@dtFecIicioActPerfil", SqlDbType.VarChar).Value = (object)actParametro.dtFecIicioActPerfil;
                sqlCommand.Parameters.Add("@dtFecFinActPerfil", SqlDbType.VarChar).Value = (object)actParametro.dtFecFinActPerfil;
                sqlCommand.Parameters.Add("@vcPuesto", SqlDbType.VarChar).Value = (object)actParametro.vcPuesto;
                sqlCommand.Parameters.Add("@vcusuarioCrea", SqlDbType.VarChar).Value = (object)actParametro.vcusuarioCrea;
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

        public bool ActualizarSolicitudHC(TOSolicitudHC actParametro)
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
                sqlCommand.CommandText = "upd_SolicitudHC";
                sqlCommand.Connection = dbConexion.AbrirModoEscritura();
                sqlCommand.Parameters.Add("@inIdSolicitudHC", SqlDbType.VarChar).Value = (object)actParametro.inIdSolicitudHC;
                sqlCommand.Parameters.Add("@inReferencia", SqlDbType.VarChar).Value = (object)actParametro.inReferencia;
                sqlCommand.Parameters.Add("@vcReferencia", SqlDbType.VarChar).Value = (object)actParametro.vcReferencia;
                sqlCommand.Parameters.Add("@inIdPersonalSolicitante", SqlDbType.VarChar).Value = (object)actParametro.inIdPersonalSolicitante;
                sqlCommand.Parameters.Add("@inIdPersonalVParea", SqlDbType.VarChar).Value = (object)actParametro.inIdPersonalVParea;
                sqlCommand.Parameters.Add("@idPersonalGerenteArea", SqlDbType.VarChar).Value = (object)actParametro.idPersonalGerenteArea;
                sqlCommand.Parameters.Add("@inTipoSolicitud", SqlDbType.VarChar).Value = (object)actParametro.inTipoSolicitud;
                sqlCommand.Parameters.Add("@inIdPosicion", SqlDbType.VarChar).Value = (object)actParametro.inIdPosicion;
                sqlCommand.Parameters.Add("@vcSustento", SqlDbType.VarChar).Value = (object)actParametro.vcSustento;
                sqlCommand.Parameters.Add("@inCantidadPosiciones", SqlDbType.VarChar).Value = (object)actParametro.inCantidadPosiciones;
                sqlCommand.Parameters.Add("@inIdJefeReporta", SqlDbType.VarChar).Value = (object)actParametro.inIdJefeReporta;
                sqlCommand.Parameters.Add("@IinIdLugarTrabajo", SqlDbType.VarChar).Value = (object)actParametro.inIdLugarTrabajo;
                sqlCommand.Parameters.Add("@inIdRegimenTrabajo", SqlDbType.VarChar).Value = (object)actParametro.inIdRegimenTrabajo;
                sqlCommand.Parameters.Add("@inIdTipoContrato", SqlDbType.VarChar).Value = (object)actParametro.inIdTipoContrato;
                sqlCommand.Parameters.Add("@IinTiempoContrato", SqlDbType.VarChar).Value = (object)actParametro.inTiempoContrato;
                sqlCommand.Parameters.Add("@chDeclaracionJurada", SqlDbType.VarChar).Value = (object)actParametro.chDeclaracionJurada;
                sqlCommand.Parameters.Add("@inIdEstado", SqlDbType.VarChar).Value = (object)actParametro.inIdEstado;
                sqlCommand.Parameters.Add("@inOrden", SqlDbType.VarChar).Value = (object)actParametro.inOrden;
                sqlCommand.Parameters.Add("@inCantAprobadores", SqlDbType.VarChar).Value = (object)actParametro.inCantAprobadores;
                sqlCommand.Parameters.Add("@chAtipico", SqlDbType.VarChar).Value = (object)actParametro.chAtipico;
                sqlCommand.Parameters.Add("@dtFecIicioActPerfil", SqlDbType.VarChar).Value = (object)actParametro.dtFecIicioActPerfil;
                sqlCommand.Parameters.Add("@dtFecFinActPerfil", SqlDbType.VarChar).Value = (object)actParametro.dtFecFinActPerfil;
                sqlCommand.Parameters.Add("@vcPuesto", SqlDbType.VarChar).Value = (object)actParametro.vcPuesto;
                sqlCommand.Parameters.Add("@vcusuarioCrea", SqlDbType.VarChar).Value = (object)actParametro.vcusuarioCrea;
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

        public int EliminarSolicitudHC(TOSolicitudHC inIdSolicitudHC)
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
                    sqlCommand.CommandText = "del_SolicitudHC"; // Replace with your actual stored procedure name
                    sqlCommand.Connection = dbConexion.AbrirModoEscritura();

                    sqlCommand.Parameters.Add("@inIdSolicitudHC", SqlDbType.Int).Value = inIdSolicitudHC;

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



