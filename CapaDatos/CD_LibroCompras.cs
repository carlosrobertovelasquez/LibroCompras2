using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;

namespace CapaDatos
{
  public  class CD_LibroCompras
    {
        private CD_Conexion conexion = new CD_Conexion();
        SqlDataReader leer;
        DataTable tabla = new DataTable();
        DataTable tablaConsulta = new DataTable();
        SqlCommand comando = new SqlCommand();


        public void CargarDoc(string ano)
        {
            comando.Parameters.Clear();
            comando.Connection = conexion.AbrirConexion();
            comando.CommandText = "cincoh.CargarLibroCompra";
            comando.CommandType = CommandType.StoredProcedure;
            comando.Parameters.AddWithValue("@YEAR", SqlDbType.VarChar).Value=ano;
           comando.ExecuteNonQuery();
            comando.Parameters.Clear();
            conexion.CerrarConexion();

        }

        public DataTable Mostrar( string vmes,string vano)
        {
            comando.Parameters.Clear();
           // leer.Close();
            tabla.Clear();
            SqlCommand comado = new SqlCommand ();
            comando.Connection = conexion.AbrirConexion();
            // comando.CommandText = "select  TIPO, FECHAEMISION,NUMERODEDOC,NUMEROREGISTRO,NOMBREPROVEEDOR,isnull(CONVERT(VARCHAR, CONVERT(VARCHAR, CAST(CEX_Locales  AS MONEY), 1)),0.00) as CEX_LOCALES , isnull(CONVERT(VARCHAR, CONVERT(VARCHAR, CAST(CEX_importaciones  AS MONEY), 1)),0.00) as CEX_IMPORTACIONES , isnull(CONVERT(VARCHAR, CONVERT(VARCHAR, CAST(cex_iternacionales  AS MONEY), 1)),0.00) as CEX_INTERNACIONES,isnull(CONVERT(VARCHAR, CONVERT(VARCHAR, CAST(CGR_locales  AS MONEY), 1)),0.00) as CGR_LOCALES,isnull(CONVERT(VARCHAR, CONVERT(VARCHAR, CAST(CGR_importaciones  AS MONEY), 1)),0.00) as CGR_IMPORTACIONES,isnull(CONVERT(VARCHAR, CONVERT(VARCHAR, CAST(CGR_Importaciones  AS MONEY), 1)),0.00) as CGR_INTERNACIONALES,isnull(CONVERT(VARCHAR, CONVERT(VARCHAR, CAST(CGR_Iternacionales  AS MONEY), 1)),0.00) as CGR_INTERNACIONES,isnull(CONVERT(VARCHAR, CONVERT(VARCHAR, CAST(creditoFiscal  AS MONEY), 1)),0.00) as CREDITOFISCAL,isnull(CONVERT(VARCHAR, CONVERT(VARCHAR, CAST(TotalCompras  AS MONEY), 1)),0.00) as TOTALCOMPRAS,isnull(CONVERT(VARCHAR, CONVERT(VARCHAR, CAST(IvaUnoPorCientoRetenido  AS MONEY), 1)),0.00) as IVAUNOPORCIENTORETENIDO,isnull(CONVERT(VARCHAR, CONVERT(VARCHAR, CAST(Ret_Suj_Exc_Cal_Cont  AS MONEY), 1)),0.00) as Ret_Suj_Exc_Cal_Cont,isnull(CONVERT(VARCHAR, CONVERT(VARCHAR, CAST(ComprasExcluidas  AS MONEY), 1)),0.00) as COMPRASEXCLUIDAS,isnull(CONVERT(VARCHAR, CONVERT(VARCHAR, CAST(RetencionATerceros  AS MONEY), 1)),0.00) as RETENCIONATERCEROS,ID,IDENTIFEXCLU,isnull(CONVERT(VARCHAR, CONVERT(VARCHAR, CAST(COTRANS  AS MONEY), 1)),0.00) as COTRANS  ,isnull(CONVERT(VARCHAR, CONVERT(VARCHAR, CAST(FOVIAL  AS MONEY), 1)),0.00) as FOVIAL  ,DENTROCA,LIBRO,isnull(CONVERT(VARCHAR, CONVERT(VARCHAR, CAST(ImpuestosEspecificos  AS MONEY), 1)),0.00) as IMPUESTOSESPECIFICOS from cincoh.librocompras where mes=@Mes and ano=@Ano order by FechaEmision ";
            comando.CommandText = "cincoh.consultarLibroCompras";
            comando.CommandType = CommandType.StoredProcedure;
            comando.Parameters.Add("@mes", SqlDbType.VarChar).Value = vmes;
            comando.Parameters.Add("@year", SqlDbType.VarChar).Value = vano;
            leer = comando.ExecuteReader();
            tabla.Clear();
            tabla.Load(leer);
            conexion.CerrarConexion();
            return tabla;
        }

        


        public void Insertar( string FechaEmision, string NumerodeDoc,  string NumeroRegistro, string IdentifExclu, string  NombreProveedor, decimal ImpuestosEspecificos,  decimal CEX_local, decimal CEX_Importaciones, decimal CEX_Iternacionales, decimal CGR_locales, decimal CGR_Importaciones, decimal CGR_iternacionales , decimal creditoFiscal, decimal TotalCompras, decimal IvaUnoPorCientoRetendio, decimal Ret_Suj_Exc_Cal_Cont, decimal ComprasExcluidas , decimal RetencionATerceros, string Mes,  string ano, string  origen, decimal FOVIAL, decimal COTRANS , string pais, string local, string Sutipo,string libro,string tipo, string dentroca )
        {
            comando.Parameters.Clear();
            comando.Connection = conexion.AbrirConexion();
            // comando.CommandText = "select  TIPO, FECHAEMISION,NUMERODEDOC,NUMEROREGISTRO,NOMBREPROVEEDOR,isnull(CONVERT(VARCHAR, CONVERT(VARCHAR, CAST(CEX_Locales  AS MONEY), 1)),0.00) as CEX_LOCALES , isnull(CONVERT(VARCHAR, CONVERT(VARCHAR, CAST(CEX_importaciones  AS MONEY), 1)),0.00) as CEX_IMPORTACIONES , isnull(CONVERT(VARCHAR, CONVERT(VARCHAR, CAST(cex_iternacionales  AS MONEY), 1)),0.00) as CEX_INTERNACIONES,isnull(CONVERT(VARCHAR, CONVERT(VARCHAR, CAST(CGR_locales  AS MONEY), 1)),0.00) as CGR_LOCALES,isnull(CONVERT(VARCHAR, CONVERT(VARCHAR, CAST(CGR_importaciones  AS MONEY), 1)),0.00) as CGR_IMPORTACIONES,isnull(CONVERT(VARCHAR, CONVERT(VARCHAR, CAST(CGR_Importaciones  AS MONEY), 1)),0.00) as CGR_INTERNACIONALES,isnull(CONVERT(VARCHAR, CONVERT(VARCHAR, CAST(CGR_Iternacionales  AS MONEY), 1)),0.00) as CGR_INTERNACIONES,isnull(CONVERT(VARCHAR, CONVERT(VARCHAR, CAST(creditoFiscal  AS MONEY), 1)),0.00) as CREDITOFISCAL,isnull(CONVERT(VARCHAR, CONVERT(VARCHAR, CAST(TotalCompras  AS MONEY), 1)),0.00) as TOTALCOMPRAS,isnull(CONVERT(VARCHAR, CONVERT(VARCHAR, CAST(IvaUnoPorCientoRetenido  AS MONEY), 1)),0.00) as IVAUNOPORCIENTORETENIDO,isnull(CONVERT(VARCHAR, CONVERT(VARCHAR, CAST(Ret_Suj_Exc_Cal_Cont  AS MONEY), 1)),0.00) as Ret_Suj_Exc_Cal_Cont,isnull(CONVERT(VARCHAR, CONVERT(VARCHAR, CAST(ComprasExcluidas  AS MONEY), 1)),0.00) as COMPRASEXCLUIDAS,isnull(CONVERT(VARCHAR, CONVERT(VARCHAR, CAST(RetencionATerceros  AS MONEY), 1)),0.00) as RETENCIONATERCEROS,ID,IDENTIFEXCLU,isnull(CONVERT(VARCHAR, CONVERT(VARCHAR, CAST(COTRANS  AS MONEY), 1)),0.00) as COTRANS  ,isnull(CONVERT(VARCHAR, CONVERT(VARCHAR, CAST(FOVIAL  AS MONEY), 1)),0.00) as FOVIAL  ,DENTROCA,LIBRO,isnull(CONVERT(VARCHAR, CONVERT(VARCHAR, CAST(ImpuestosEspecificos  AS MONEY), 1)),0.00) as IMPUESTOSESPECIFICOS from cincoh.librocompras where mes=@Mes and ano=@Ano order by FechaEmision ";
            comando.CommandText = "CINCOH.AdicionarDocLibroCompras";
            comando.CommandType = CommandType.StoredProcedure;
            comando.Parameters.Add("@FechaEmision", SqlDbType.DateTime).Value = FechaEmision;
            comando.Parameters.Add("@NumerodeDoc", SqlDbType.VarChar).Value = NumerodeDoc;
            comando.Parameters.Add("@NumeroRegistro", SqlDbType.VarChar).Value = NumeroRegistro;
            comando.Parameters.Add("@NombreProveedor", SqlDbType.VarChar).Value = NombreProveedor;
            comando.Parameters.Add("@IdentifExclu", SqlDbType.VarChar).Value = IdentifExclu;
            comando.Parameters.Add("@ImpuestosEspecificos", SqlDbType.Decimal).Value =ImpuestosEspecificos;
            comando.Parameters.Add("@CEX_Locales", SqlDbType.Decimal).Value = CEX_local;
            comando.Parameters.Add("@CEX_Importaciones", SqlDbType.Decimal).Value = CEX_Importaciones;
            comando.Parameters.Add("@CEX_Iternacionales", SqlDbType.Decimal).Value = CEX_Iternacionales;
            comando.Parameters.Add("@CGR_Locales", SqlDbType.Decimal).Value = CGR_locales;
            comando.Parameters.Add("@CGR_Importaciones", SqlDbType.Decimal).Value = CGR_Importaciones;
            comando.Parameters.Add("@CGR_Iternacionales", SqlDbType.Decimal).Value = CGR_iternacionales;
            comando.Parameters.Add("@CreditoFiscal", SqlDbType.Decimal).Value = creditoFiscal;
            comando.Parameters.Add("@TotalCompras", SqlDbType.Decimal).Value = TotalCompras;
            comando.Parameters.Add("@IvaUnoPorCientoRetenido", SqlDbType.Decimal).Value = IvaUnoPorCientoRetendio;
            comando.Parameters.Add("@Ret_Suj_Exc_Cal_Cont", SqlDbType.Decimal).Value = Ret_Suj_Exc_Cal_Cont;
            comando.Parameters.Add("@ComprasExcluidas", SqlDbType.Decimal).Value = ComprasExcluidas;
            comando.Parameters.Add("@RetencionATerceros", SqlDbType.Decimal).Value = RetencionATerceros;
            comando.Parameters.Add("@Mes", SqlDbType.VarChar).Value = Mes;
            comando.Parameters.Add("@Ano", SqlDbType.VarChar).Value = ano;
            comando.Parameters.Add("@FOVIAL", SqlDbType.Decimal).Value = FOVIAL;
            comando.Parameters.Add("@COTRANS", SqlDbType.Decimal).Value = COTRANS;
            comando.Parameters.Add("@LIBRO", SqlDbType.VarChar).Value = libro;
            comando.Parameters.Add("@TIPO", SqlDbType.VarChar).Value = tipo;
            comando.Parameters.Add("@DENTROCA", SqlDbType.VarChar).Value = dentroca;
            comando.Parameters.Add("@ORIGEN", SqlDbType.VarChar).Value = "LC";
            comando.Parameters.Add("@PAIS", SqlDbType.VarChar).Value = "SAL";
            comando.Parameters.Add("@LOCAL", SqlDbType.VarChar).Value = "L";
            comando.Parameters.Add("@SUBTIPO", SqlDbType.VarChar).Value =Sutipo;
            comando.ExecuteNonQuery();

        }

        public void editar(string FechaEmision, string NumerodeDoc, string NumeroRegistro, string NombreProveedor , string IdentifExclu, decimal ImpuestosEspecificos, decimal CEX_Locales,decimal CEX_Importaciones, decimal CEX_Iternacionales, decimal CGR_Locales, decimal CGR_Importaciones, decimal CGR_Iternacionales, decimal CreditoFiscal, decimal TotalCompras, decimal IvaUnoPorCientoRetenido ,decimal Ret_Suj_Exc_Cal_Cont, decimal ComprasExcluidas, decimal RetencionATerceros,string Mes,string Ano, decimal FOVIAL,decimal COTRANS, string LIBRO, string TIPO, string DENTROCA, string id)
//             decimal CEX_local, decimal CEX_Importaciones, decimal CEX_Iternacionales, decimal CGR_locales, decimal CGR_Importaciones, decimal CGR_iternacionales, decimal creditoFiscal, decimal TotalCompras, decimal IvaUnoPorCientoRetendio, decimal Ret_Suj_Exc_Cal_Cont, decimal ComprasExcluidas, decimal RetencionATerceros, string Mes, string ano, string origen, decimal FOVIAL, decimal COTRANS, string pais, string local, string Sutipo, string libro, string tipo, string dentroca, string id)
        {

            comando.Parameters.Clear();
            comando.Connection = conexion.AbrirConexion();
            comando.CommandText = "CINCOH.EditarLibro";
            comando.CommandType = CommandType.StoredProcedure;
            comando.Parameters.Add("@FechaEmision", SqlDbType.DateTime).Value = FechaEmision;
            comando.Parameters.Add("@NumerodeDoc", SqlDbType.VarChar).Value = NumerodeDoc;
            comando.Parameters.Add("@NumeroRegistro", SqlDbType.VarChar).Value = NumeroRegistro;
            comando.Parameters.Add("@NombreProveedor", SqlDbType.VarChar).Value = NombreProveedor;
            comando.Parameters.Add("@IdentifExclu", SqlDbType.VarChar).Value = IdentifExclu;
            comando.Parameters.Add("@ImpuestosEspecificos", SqlDbType.Decimal).Value = ImpuestosEspecificos;
            comando.Parameters.Add("@CEX_Locales", SqlDbType.Decimal).Value = CEX_Locales;
            comando.Parameters.Add("@CEX_Importaciones", SqlDbType.Decimal).Value = CEX_Importaciones;
            comando.Parameters.Add("@CEX_Iternacionales", SqlDbType.Decimal).Value = CEX_Iternacionales;
            comando.Parameters.Add("@CGR_Locales", SqlDbType.Decimal).Value = CGR_Locales;
            comando.Parameters.Add("@CGR_Importaciones", SqlDbType.Decimal).Value = CGR_Importaciones;
            comando.Parameters.Add("@CGR_Iternacionales", SqlDbType.Decimal).Value = CGR_Iternacionales;
            comando.Parameters.Add("@CreditoFiscal", SqlDbType.Decimal).Value = CreditoFiscal;
            comando.Parameters.Add("@TotalCompras", SqlDbType.Decimal).Value = TotalCompras;
            comando.Parameters.Add("@IvaUnoPorCientoRetenido", SqlDbType.Decimal).Value = IvaUnoPorCientoRetenido;
            comando.Parameters.Add("@Ret_Suj_Exc_Cal_Cont", SqlDbType.Decimal).Value = Ret_Suj_Exc_Cal_Cont;
            comando.Parameters.Add("@ComprasExcluidas", SqlDbType.Decimal).Value = ComprasExcluidas;
            comando.Parameters.Add("@RetencionATerceros", SqlDbType.Decimal).Value = RetencionATerceros;
            comando.Parameters.Add("@Mes", SqlDbType.VarChar).Value = Mes;
            comando.Parameters.Add("@Ano", SqlDbType.VarChar).Value = Ano;
            comando.Parameters.Add("@FOVIAL", SqlDbType.Decimal).Value = FOVIAL;
            comando.Parameters.Add("@COTRANS", SqlDbType.Decimal).Value = COTRANS;
            comando.Parameters.Add("@LIBRO", SqlDbType.VarChar).Value = LIBRO;
            comando.Parameters.Add("@TIPO", SqlDbType.VarChar).Value = TIPO;
            comando.Parameters.Add("@DENTROCA", SqlDbType.VarChar).Value = DENTROCA;
            comando.Parameters.Add("@id", SqlDbType.Int).Value = id;
            comando.ExecuteNonQuery();
             comando.Parameters.Clear();
        }

        public void elimianDoc(int ID)
        {
            comando.Parameters.Clear();
            comando.Connection = conexion.AbrirConexion();
            comando.CommandText = "CINCOH.BorrarDocLibroCompras";
            comando.CommandType = CommandType.StoredProcedure;
            comando.Parameters.Add("@id", SqlDbType.Int).Value = ID;
            comando.ExecuteNonQuery();
            comando.Parameters.Clear();
        }
    }
}
