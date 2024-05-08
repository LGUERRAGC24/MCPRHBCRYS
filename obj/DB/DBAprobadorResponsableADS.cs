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
  internal  class DBAprobadorResponsableADS
    {
        private string _xError = string.Empty;

        public string Error() => this._xError;

        public Collection<TOAprobadorResponsableADS> ListarAprobadorResponsableADS()
        {
            DBConexion dbConexion = new DBConexion();
            SqlDataReader sqlDataReader = (SqlDataReader)null;
            SqlCommand sqlCommand = new SqlCommand();
            Collection<TOAprobadorResponsableADS> collection = new Collection<TOAprobadorResponsableADS>();
            this._xError = string.Empty;
            try
            {
                sqlCommand.CommandType = CommandType.StoredProcedure;
                sqlCommand.CommandText = "que_AprobadorResponsableADS";
                sqlCommand.Connection = dbConexion.AbrirModoLectura();
                sqlDataReader = sqlCommand.ExecuteReader();
                while (sqlDataReader.Read())
                    collection.Add(new TOAprobadorResponsableADS()
                    {
                        InId = sqlDataReader[0].ToString(),
                        InIdADS = sqlDataReader[1].ToString(),
                        InIdProceso = sqlDataReader[2].ToString(),
                        InIdPaso = sqlDataReader[3].ToString(),
                        InIdPerfilPuesto = sqlDataReader[4].ToString(),
                        InIdPersonal = sqlDataReader[5].ToString(),
                        VcActualizacionPaso = sqlDataReader[6].ToString(),
                        ChUltimoActualizador = sqlDataReader[7].ToString(),
                        vcUsuarioCrea = sqlDataReader[8].ToString(),
                        VcUsuarioModifica = sqlDataReader[9].ToString(),
                        dtFechaRegistro = sqlDataReader[10].ToString(),
                        dtFechaModificacion = sqlDataReader[11].ToString()
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

        public bool RegistrarAprobadorResponsableADS(TOAprobadorResponsableADS pParametro)
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
                sqlCommand.CommandText = "ins_AprobadorResponsableADS";
                sqlCommand.Connection = dbConexion.AbrirModoLectura();

                sqlCommand.Parameters.Add("@inId", SqlDbType.VarChar).Value = (object)pParametro.InId;
                sqlCommand.Parameters.Add("@inIdADS", SqlDbType.VarChar).Value = (object)pParametro.InIdADS;
                sqlCommand.Parameters.Add("@InIdProceso ", SqlDbType.VarChar).Value = (object)pParametro.InIdProceso;
                sqlCommand.Parameters.Add("@InIdPaso", SqlDbType.VarChar).Value = (object)pParametro.InIdPaso;
                sqlCommand.Parameters.Add("@InIdPerfilPuesto", SqlDbType.VarChar).Value = (object)pParametro.InIdPerfilPuesto;
                sqlCommand.Parameters.Add("@InIdPersonal", SqlDbType.VarChar).Value = (object)pParametro.InIdPersonal;
                sqlCommand.Parameters.Add("@VcActualizacionPaso", SqlDbType.VarChar).Value = (object)pParametro.VcActualizacionPaso;
                sqlCommand.Parameters.Add("@VcActualizacionPaso", SqlDbType.VarChar).Value = (object)pParametro.VcActualizacionPaso;
                sqlCommand.Parameters.Add("@vcUsuarioCrea", SqlDbType.VarChar).Value = (object)pParametro.vcUsuarioCrea;
                sqlCommand.Parameters.Add("@VcUsuarioModifica", SqlDbType.VarChar).Value = (object)pParametro.VcUsuarioModifica;
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

        public bool ActualizarAprobadorResponsableADS(TOAprobadorResponsableADS actParametro)
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
                sqlCommand.CommandText = "upd_AprobadorResponsableADS";
                sqlCommand.Connection = dbConexion.AbrirModoEscritura();

                sqlCommand.Parameters.Add("@inId", SqlDbType.VarChar).Value = (object)actParametro.InId;
                sqlCommand.Parameters.Add("@inIdADS", SqlDbType.VarChar).Value = (object)actParametro.InIdADS;
                sqlCommand.Parameters.Add("@InIdProceso ", SqlDbType.VarChar).Value = (object)actParametro.InIdProceso;
                sqlCommand.Parameters.Add("@InIdPaso", SqlDbType.VarChar).Value = (object)actParametro.InIdPaso;
                sqlCommand.Parameters.Add("@InIdPerfilPuesto", SqlDbType.VarChar).Value = (object)actParametro.InIdPerfilPuesto;
                sqlCommand.Parameters.Add("@InIdPersonal", SqlDbType.VarChar).Value = (object)actParametro.InIdPersonal;
                sqlCommand.Parameters.Add("@VcActualizacionPaso", SqlDbType.VarChar).Value = (object)actParametro.VcActualizacionPaso;
                sqlCommand.Parameters.Add("@VcActualizacionPaso", SqlDbType.VarChar).Value = (object)actParametro.VcActualizacionPaso;
                sqlCommand.Parameters.Add("@vcUsuarioCrea", SqlDbType.VarChar).Value = (object)actParametro.vcUsuarioCrea;
                sqlCommand.Parameters.Add("@VcUsuarioModifica", SqlDbType.VarChar).Value = (object)actParametro.VcUsuarioModifica;
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


        public int EliminarAprobadoresADS(TOAprobadorResponsableADS inId)
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
                    sqlCommand.CommandText = "del_AprobadorResponsableADS"; // Replace with your actual stored procedure name
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


   


