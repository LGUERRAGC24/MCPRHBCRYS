using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Chinalco.Shared;
using System.ComponentModel;
using System.Data.SqlClient;
using System.Web.Configuration;



namespace MCPRHBCRYS.DB.DAO
{
{
    internal class DBConexion : Component
    {
        private string xSqlRead = "";
        private string xSqlWrite = "";
      //  private string xSrvApps = "";
        private string xSrvApps = "az-vm-app-eu-pr";
        private string xSrvDB = "BD_RHReclutamientoSeleccion";
        //private string mUserR = "User Id=spappwayra;Password=1ntr4n3tW4yr4;";
        //private string mUserW = "User Id=spappwayra;Password=1ntr4n3tW4yr4;";
        //private string mUserR = "User Id=sa_outsystems;Password=s4_09tsyst3m$14;";
        //private string mUserW = "User Id=sa_outsystems;Password=s4_09tsyst3m$14;";
        private string mUserR = "User Id= dbRS;Password= dbRS;";
        private string mUserW = "User Id= dbRS;Password= dbRS;";
        private SqlConnection oCn = new SqlConnection();
        private Container components;

        public DBConexion(IContainer container)
        {
            container.Add((IComponent)this);
            this.InitializeComponent();
            this.xSrvApps = this.SQLServerName();
        }

        public DBConexion()
        {
            this.InitializeComponent();
            this.xSrvApps = this.SQLServerName();
        }

        public SqlConnection AbrirModoLectura()
        {
            this.oCn = new SqlConnection();
            if (this.xSrvApps != "")
            {
                this.xSqlRead = "Data Source=" + this.xSrvApps + ";Initial Catalog=" + this.xSrvDB + ";" + this.mUserR + "Connection Timeout=50;";
                this.oCn.ConnectionString = this.xSqlRead;
                try
                {
                    this.oCn.Open();
                }
                catch (Exception ex)
                {
                    Comun.EventosGrabar("MCPOutSystems", "DBConexion.AbrirModoLectura", ex);
                }
            }
            return this.oCn;
        }

        public SqlConnection AbrirModoEscritura()
        {
            this.oCn = new SqlConnection();
            this.xSqlWrite = "Data Source=" + this.xSrvApps + ";Initial Catalog=" + this.xSrvDB + ";" + this.mUserW + "Connection Timeout=30;";
            this.oCn.ConnectionString = this.xSqlWrite;
            try
            {
                this.oCn.Open();
            }
            catch (Exception ex)
            {
                Comun.EventosGrabar("MCPOutSystems", "DBConexion.AbrirModoLectura", ex);
            }
            return this.oCn;
        }

        private void InitializeComponent() => this.components = new Container();

        protected override void Dispose(bool disposing)
        {
            if (disposing && this.components != null)
                this.components.Dispose();
            if (this.oCn != null)
            {
                this.oCn.Close();
                this.oCn.Dispose();
            }
            base.Dispose(disposing);
        }

        private string SQLServerName() => WebConfigurationManager.AppSettings[nameof(SQLServerName)];
    }
}


}

