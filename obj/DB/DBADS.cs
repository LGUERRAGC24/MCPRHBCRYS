using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//using Chinalco.Outsystems.TO;
using MCPRHBCRYS.TO;
//using Chinalco.Shared;
using System.Collections.ObjectModel;
using System.Data;
using System.Data.SqlClient;

namespace MCPRHBCRYS.DB.DAO
{
    internal class DBADS
    {
        private string _xError = string.Empty;

        public string Error() => this._xError;

        public Collection<TOADS> ListarPosicion()
        {
            DBConexion dbConexion = new DBConexion();
            SqlDataReader sqlDataReader = (SqlDataReader)null;
            SqlCommand sqlCommand = new SqlCommand();
            Collection<TOADS> collection = new Collection<TOADS>();
            this._xError = string.Empty;
            try
            {
                sqlCommand.CommandType = CommandType.StoredProcedure;
                sqlCommand.CommandText = "que_ADS";
                sqlCommand.Connection = dbConexion.AbrirModoLectura();
                sqlDataReader = sqlCommand.ExecuteReader();
                while (sqlDataReader.Read())
                    collection.Add(new TOADS()
                    {
                        InId = sqlDataReader[0].ToString(),
                        InIdADS = sqlDataReader[1].ToString(),
                        InIdSolicitudHC = sqlDataReader[2].ToString(),
                        InIdPerfilPuesto = sqlDataReader[3].ToString(),
                        InIdPuesto = sqlDataReader[4].ToString(),
                        ChCubiertaPorComunidad = sqlDataReader[5].ToString(),
                        VcCubiertaPorComunidad = sqlDataReader[6].ToString(),
                        VcFechaInicio = sqlDataReader[7].ToString(),
                        VcFechaFin = sqlDataReader[8].ToString(),
                        InIdPersonalClienteInterno = sqlDataReader[9].ToString(),
                        InidPersonalGerenteArea = sqlDataReader[10].ToString(),
                        InidPersonalVicepresidenteArea = sqlDataReader[11].ToString(),
                        IndPersonalRegistro = sqlDataReader[12].ToString(),
                        InidEstado = sqlDataReader[13].ToString(),
                        InidVP = sqlDataReader[14].ToString(),
                        InIdDepartamento = sqlDataReader[15].ToString(),
                        ChHabilitarGerente = sqlDataReader[16].ToString(),
                        ChHabilitarVP = sqlDataReader[17].ToString(),
                        InIdTipoADS = sqlDataReader[18].ToString(),
                        VcUsuarioCrea = sqlDataReader[19].ToString(),
                        VcUsuarioModifica = sqlDataReader[20].ToString(),
                        VcFechaRegistro = sqlDataReader[21].ToString(),
                        VcFechaModificacion = sqlDataReader[22].ToString()
                    }) ;
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


        public bool RegistrarADS(TOADS pParametro)
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
                sqlCommand.CommandText = "ins_ADS";
                sqlCommand.Connection = dbConexion.AbrirModoLectura();

                sqlCommand.Parameters.Add("@InId", SqlDbType.VarChar).Value = (object)pParametro.InId;
                sqlCommand.Parameters.Add("@InIdADS", SqlDbType.VarChar).Value = (object)pParametro.InIdADS;
                sqlCommand.Parameters.Add("@InIdSolicitudHC", SqlDbType.VarChar).Value = (object)pParametro.InIdSolicitudHC;
                sqlCommand.Parameters.Add("@InIdPerfilPuesto", SqlDbType.VarChar).Value = (object)pParametro.InIdPerfilPuesto;
                sqlCommand.Parameters.Add("@InIdPuesto ", SqlDbType.VarChar).Value = (object)pParametro.InIdPuesto;
                sqlCommand.Parameters.Add("@ChCubiertaInternamente", SqlDbType.VarChar).Value = (object)pParametro.ChCubiertaInternamente;
                sqlCommand.Parameters.Add("@VcCubiertaInternamente ", SqlDbType.VarChar).Value = (object)pParametro.VcCubiertaInternamente;
                sqlCommand.Parameters.Add("@ChCubiertaPorComunidad", SqlDbType.VarChar).Value = (object)pParametro.ChCubiertaPorComunidad;
                sqlCommand.Parameters.Add("@VcCubiertaPorComunidad", SqlDbType.VarChar).Value = (object)pParametro.VcCubiertaPorComunidad;
                sqlCommand.Parameters.Add("@VcFechaInicio", SqlDbType.VarChar).Value = (object)pParametro.VcFechaInicio;
                sqlCommand.Parameters.Add("@VcFechaFin", SqlDbType.VarChar).Value = (object)pParametro.VcFechaFin;
                sqlCommand.Parameters.Add("@InIdPersonalClienteInterno", SqlDbType.VarChar).Value = (object)pParametro.InIdPersonalClienteInterno;
                sqlCommand.Parameters.Add("@InidPersonalGerenteArea", SqlDbType.VarChar).Value = (object)pParametro.InidPersonalGerenteArea;
                sqlCommand.Parameters.Add("@InidPersonalVicepresidenteArea ", SqlDbType.VarChar).Value = (object)pParametro.InidPersonalVicepresidenteArea;
                sqlCommand.Parameters.Add("@IndPersonalRegistro", SqlDbType.VarChar).Value = (object)pParametro.IndPersonalRegistro;
                sqlCommand.Parameters.Add("@ChActivo", SqlDbType.VarChar).Value = (object)pParametro.ChActivo;
                sqlCommand.Parameters.Add("@InIdEstado", SqlDbType.VarChar).Value = (object)pParametro.InidEstado;
                sqlCommand.Parameters.Add("@InIdVP", SqlDbType.VarChar).Value = (object)pParametro.InidVP;
                sqlCommand.Parameters.Add("@InIdDepartamento", SqlDbType.VarChar).Value = (object)pParametro.InIdDepartamento;
                sqlCommand.Parameters.Add("@ChHabilitarGerente", SqlDbType.VarChar).Value = (object)pParametro.ChHabilitarGerente;
                sqlCommand.Parameters.Add("@ChHabilitarVP", SqlDbType.VarChar).Value = (object)pParametro.ChHabilitarVP;
                sqlCommand.Parameters.Add("@InIdTipoADS", SqlDbType.VarChar).Value = (object)pParametro.InIdTipoADS;
                sqlCommand.Parameters.Add("@VcUsuarioCrea", SqlDbType.VarChar).Value = (object)pParametro.VcUsuarioCrea;
                sqlCommand.Parameters.Add("@VcUsuarioModifica", SqlDbType.VarChar).Value = (object)pParametro.VcUsuarioModifica;
                sqlCommand.Parameters.Add("@VcFechaRegistro", SqlDbType.VarChar).Value = (object)pParametro.VcFechaRegistro;
                sqlCommand.Parameters.Add("@VcFechaModificacion", SqlDbType.VarChar).Value = (object)pParametro.VcFechaModificacion;



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

        public bool ActualizarADS(TOADS actParametro)
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
                sqlCommand.CommandText = "upd_ADS";
                sqlCommand.Connection = dbConexion.AbrirModoEscritura();

                sqlCommand.Parameters.Add("@InId", SqlDbType.VarChar).Value = (object)actParametro.InId;
                sqlCommand.Parameters.Add("@InIdADS", SqlDbType.VarChar).Value = (object)actParametro.InIdADS;
                sqlCommand.Parameters.Add("@InIdSolicitudHC", SqlDbType.VarChar).Value = (object)actParametro.InIdSolicitudHC;
                sqlCommand.Parameters.Add("@InIdPerfilPuesto", SqlDbType.VarChar).Value = (object)actParametro.InIdPerfilPuesto;
                sqlCommand.Parameters.Add("@InIdPuesto ", SqlDbType.VarChar).Value = (object)actParametro.InIdPuesto;
                sqlCommand.Parameters.Add("@ChCubiertaInternamente", SqlDbType.VarChar).Value = (object)actParametro.ChCubiertaInternamente;
                sqlCommand.Parameters.Add("@VcCubiertaInternamente ", SqlDbType.VarChar).Value = (object)actParametro.VcCubiertaInternamente;
                sqlCommand.Parameters.Add("@ChCubiertaPorComunidad", SqlDbType.VarChar).Value = (object)actParametro.ChCubiertaPorComunidad;
                sqlCommand.Parameters.Add("@VcCubiertaPorComunidad", SqlDbType.VarChar).Value = (object)actParametro.VcCubiertaPorComunidad;
                sqlCommand.Parameters.Add("@VcFechaInicio", SqlDbType.VarChar).Value = (object)actParametro.VcFechaInicio;
                sqlCommand.Parameters.Add("@VcFechaFin", SqlDbType.VarChar).Value = (object)actParametro.VcFechaFin;
                sqlCommand.Parameters.Add("@InIdPersonalClienteInterno", SqlDbType.VarChar).Value = (object)actParametro.InIdPersonalClienteInterno;
                sqlCommand.Parameters.Add("@InidPersonalGerenteArea", SqlDbType.VarChar).Value = (object)actParametro.InidPersonalGerenteArea;
                sqlCommand.Parameters.Add("@InidPersonalVicepresidenteArea ", SqlDbType.VarChar).Value = (object)actParametro.InidPersonalVicepresidenteArea;
                sqlCommand.Parameters.Add("@IndPersonalRegistro", SqlDbType.VarChar).Value = (object)actParametro.IndPersonalRegistro;
                sqlCommand.Parameters.Add("@ChActivo", SqlDbType.VarChar).Value = (object)actParametro.ChActivo;
                sqlCommand.Parameters.Add("@InIdEstado", SqlDbType.VarChar).Value = (object)actParametro.InidEstado;
                sqlCommand.Parameters.Add("@InIdVP", SqlDbType.VarChar).Value = (object)actParametro.InidVP;
                sqlCommand.Parameters.Add("@InIdDepartamento", SqlDbType.VarChar).Value = (object)actParametro.InIdDepartamento;
                sqlCommand.Parameters.Add("@ChHabilitarGerente", SqlDbType.VarChar).Value = (object)actParametro.ChHabilitarGerente;
                sqlCommand.Parameters.Add("@ChHabilitarVP", SqlDbType.VarChar).Value = (object)actParametro.ChHabilitarVP;
                sqlCommand.Parameters.Add("@InIdTipoADS", SqlDbType.VarChar).Value = (object)actParametro.InIdTipoADS;
                sqlCommand.Parameters.Add("@VcUsuarioCrea", SqlDbType.VarChar).Value = (object)actParametro.VcUsuarioCrea;
                sqlCommand.Parameters.Add("@VcUsuarioModifica", SqlDbType.VarChar).Value = (object)actParametro.VcUsuarioModifica;
                sqlCommand.Parameters.Add("@VcFechaRegistro", SqlDbType.VarChar).Value = (object)actParametro.VcFechaRegistro;
                sqlCommand.Parameters.Add("@VcFechaModificacion", SqlDbType.VarChar).Value = (object)actParametro.VcFechaModificacion;

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



        public int EliminarADS(TOADS  InIdADS )
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
                    sqlCommand.CommandText = "del_ADS"; // Replace with your actual stored procedure name
                    sqlCommand.Connection = dbConexion.AbrirModoEscritura();

                    sqlCommand.Parameters.Add("@inIdADS", SqlDbType.Int).Value = InIdADS;

                    sqlCommand.ExecuteNonQuery();
                }
            }
            catch (Exception ex)
            {
                _xError = ex.Message;
                Comun.EventosGrabar("MCPOutSystems", "DBEstrategia.EliminarEstrategia(idEstrategia)", ex);
            }
            finally
            {
                dbConexion.Dispose();
            }

            return rowsAffected;
        }




    }


}
