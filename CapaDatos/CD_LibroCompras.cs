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

        public DataTable Mostrar( string vmes,string vano)
        {
            comando.Parameters.Clear();
            comando.Connection = conexion.AbrirConexion();
            comando.CommandText = "select  TIPO, FECHAEMISION,NUMERODEDOC,NUMEROREGISTRO,NOMBREPROVEEDOR,isnull(CONVERT(VARCHAR, CONVERT(VARCHAR, CAST(CEX_Locales  AS MONEY), 1)),0.00) as CEX_LOCALES , isnull(CONVERT(VARCHAR, CONVERT(VARCHAR, CAST(CEX_importaciones  AS MONEY), 1)),0.00) as CEX_IMPORTACIONES , isnull(CONVERT(VARCHAR, CONVERT(VARCHAR, CAST(cex_iternacionales  AS MONEY), 1)),0.00) as CEX_INTERNACIONES,isnull(CONVERT(VARCHAR, CONVERT(VARCHAR, CAST(CGR_locales  AS MONEY), 1)),0.00) as CGR_LOCALES,isnull(CONVERT(VARCHAR, CONVERT(VARCHAR, CAST(CGR_importaciones  AS MONEY), 1)),0.00) as CGR_IMPORTACIONES,isnull(CONVERT(VARCHAR, CONVERT(VARCHAR, CAST(CGR_Importaciones  AS MONEY), 1)),0.00) as CGR_INTERNACIONALES,isnull(CONVERT(VARCHAR, CONVERT(VARCHAR, CAST(CGR_Iternacionales  AS MONEY), 1)),0.00) as CGR_INTERNACIONES,isnull(CONVERT(VARCHAR, CONVERT(VARCHAR, CAST(creditoFiscal  AS MONEY), 1)),0.00) as CREDITOFISCAL,isnull(CONVERT(VARCHAR, CONVERT(VARCHAR, CAST(TotalCompras  AS MONEY), 1)),0.00) as TOTALCOMPRAS,isnull(CONVERT(VARCHAR, CONVERT(VARCHAR, CAST(IvaUnoPorCientoRetenido  AS MONEY), 1)),0.00) as IVAUNOPORCIENTORETENIDO,isnull(CONVERT(VARCHAR, CONVERT(VARCHAR, CAST(Ret_Suj_Exc_Cal_Cont  AS MONEY), 1)),0.00) as Ret_Suj_Exc_Cal_Cont,isnull(CONVERT(VARCHAR, CONVERT(VARCHAR, CAST(ComprasExcluidas  AS MONEY), 1)),0.00) as COMPRASEXCLUIDAS,isnull(CONVERT(VARCHAR, CONVERT(VARCHAR, CAST(RetencionATerceros  AS MONEY), 1)),0.00) as RETENCIONATERCEROS,ID,IDENTIFEXCLU,isnull(CONVERT(VARCHAR, CONVERT(VARCHAR, CAST(COTRANS  AS MONEY), 1)),0.00) as COTRANS  ,isnull(CONVERT(VARCHAR, CONVERT(VARCHAR, CAST(FOVIAL  AS MONEY), 1)),0.00) as FOVIAL  ,DENTROCA,LIBRO,isnull(CONVERT(VARCHAR, CONVERT(VARCHAR, CAST(ImpuestosEspecificos  AS MONEY), 1)),0.00) as IMPUESTOSESPECIFICOS from cincoh.librocompras where mes=@Mes and ano=@Ano order by FechaEmision ";
            comando.Parameters.Add("@Mes", SqlDbType.VarChar).Value = vmes;
            comando.Parameters.Add("@Ano", SqlDbType.VarChar).Value = vano;
            leer = comando.ExecuteReader();
            tabla.Clear();
            tabla.Load(leer);
            conexion.CerrarConexion();
            return tabla;
        }

        public DataTable ConsultarID( int ID)
        {
            comando.Parameters.Clear();
            comando.Connection = conexion.AbrirConexion();
            comando.CommandText = "select  tipo, FechaEmision,NumerodeDoc,NumeroRegistro,NombreProveedor,isnull(CEX_locales,0) as CEX_locales , isnull(CEX_importaciones,0) as CEX_importaciones , isnull( cex_iternacionales,0) as cex_internaciones,isnull(CGR_locales,0) as CGR_locales, isnull(CGR_importaciones,0) as CGR_importaciones,   isnull(CGR_Iternacionales,0) as CGR_Internaciones , creditoFiscal,TotalCompras, IvaUnoPorCientoRetenido,Ret_Suj_Exc_Cal_Cont ,ComprasExcluidas , RetencionATerceros,ID   from cincoh.librocompras where ID=@ID   ";
            comando.Parameters.Add("@ID", SqlDbType.Int).Value = ID;
            leer = comando.ExecuteReader();
            tablaConsulta.Clear();
            tablaConsulta.Load(leer);
            conexion.CerrarConexion();
            comando.Parameters.Clear();
            return tablaConsulta;
        }


        public void Insertar( string FechaEmision, string NumerodeDoc,  string NumeroRegistro, string  NombreProveedor, decimal CEX_local, decimal CEX_Importaciones, decimal CEX_Iternacionales, decimal CGR_locales, decimal CGR_Importaciones, decimal CGR_iternacionales , decimal creditoFiscal, decimal TotalCompras, decimal IvaUnoPorCientoRetendio, decimal Ret_Suj_Exc_Cal_Cont, decimal ComprasExcluidas , decimal RetencionATerceros, string Mes,  string ano, string  origen, decimal FOVIAL, decimal COTRANS , string pais, string local, string Sutipo,string libro,string tipo, string dentroca )
        {
          //  string format = "yyyy-MM-dd HH:mm:ss";
            comando.Connection = conexion.AbrirConexion();
            comando.CommandText = "Insert into cincoh.libroCompras(FechaEmision,  NumerodeDoc,   NumeroRegistro,  NombreProveedor,  CEX_locales,  CEX_Importaciones, CEX_Iternacionales,  CGR_locales, CGR_Importaciones, CGR_iternacionales , creditoFiscal, TotalCompras,IvaUnoPorCientoRetenido,Ret_Suj_Exc_Cal_Cont,ComprasExcluidas ,RetencionATerceros,Mes,ano,origen,FOVIAL,COTRANS ,pais,local,Subtipo,libro,tipo,dentroca)" +
                                    "values( '"+ FechaEmision + "','" + NumerodeDoc + "',  '" + NumeroRegistro + "', '" + NombreProveedor + "',  '" + CEX_local + "',  '" + CEX_Importaciones + "', '" + CEX_Iternacionales + "', '" +  CGR_locales + "','" + CGR_Importaciones + "','" + CGR_iternacionales + "' , '" + creditoFiscal + "', '" + TotalCompras + "', '" + IvaUnoPorCientoRetendio + "', '" + Ret_Suj_Exc_Cal_Cont + "', '" + ComprasExcluidas + "' , '" + RetencionATerceros + "', '" + Mes + "', '" + ano + "', '" + origen + "', '" + FOVIAL + "', '" + COTRANS + "' ,'" + pais + "', '" + local + "', '" + Sutipo + "','" + libro + "','" + tipo + "','" + dentroca + "');";
            comando.ExecuteNonQuery();
            comando.Parameters.Clear();
        }

        public void editar(string FechaEmision, string NumerodeDoc, string NumeroRegistro, string NombreProveedor , string IdentifExclu, decimal ImpuestosEspecificos, decimal CEX_Locales,decimal CEX_Importaciones, decimal CEX_Iternacionales, decimal CGR_Locales, decimal CGR_Importaciones, decimal CGR_Iternacionales, decimal CreditoFiscal, decimal TotalCompras, decimal IvaUnoPorCientoRetenido ,decimal Ret_Suj_Exc_Cal_Cont, decimal ComprasExcluidas, decimal RetencionATerceros,string Mes,string Ano, decimal FOVIAL,decimal COTRANS, string LIBRO, string TIPO, string DENTROCA, string id)
//             decimal CEX_local, decimal CEX_Importaciones, decimal CEX_Iternacionales, decimal CGR_locales, decimal CGR_Importaciones, decimal CGR_iternacionales, decimal creditoFiscal, decimal TotalCompras, decimal IvaUnoPorCientoRetendio, decimal Ret_Suj_Exc_Cal_Cont, decimal ComprasExcluidas, decimal RetencionATerceros, string Mes, string ano, string origen, decimal FOVIAL, decimal COTRANS, string pais, string local, string Sutipo, string libro, string tipo, string dentroca, string id)
        {
            comando.Connection = conexion.AbrirConexion();
            comando.CommandText = "update cincoh.libroCompras set FechaEmision= '" + FechaEmision + "', NumerodeDoc='"+NumerodeDoc + "', NumeroRegistro='"+NumeroRegistro +"',NombreProveedor='" + NombreProveedor+ "',IdentifExclu='"+IdentifExclu + "',ImpuestosEspecificos='"+ImpuestosEspecificos+ "', CEX_Locales='"+ CEX_Locales + "', CEX_Importaciones='"+ CEX_Importaciones + "',CEX_Iternacionales='"+ CEX_Iternacionales + "',CGR_Locales='"+ CGR_Locales + "' ,CGR_Importaciones='"+ CGR_Importaciones + "' , CGR_Iternacionales='"+ CGR_Iternacionales + "',CreditoFiscal='"+ CreditoFiscal + "',TotalCompras='"+ TotalCompras + "' ,IvaUnoPorCientoRetenido='"+ IvaUnoPorCientoRetenido + "',Ret_Suj_Exc_Cal_Cont='"+ Ret_Suj_Exc_Cal_Cont + "',ComprasExcluidas='"+ ComprasExcluidas + "',RetencionATerceros='"+ RetencionATerceros + "',Mes='"+ Mes + "',Ano='"+ Ano + "',FOVIAL='"+ FOVIAL + "',COTRANS='"+ COTRANS + "',LIBRO='"+ LIBRO + "',TIPO='"+ TIPO + "',DENTROCA='"+ DENTROCA + "'  where ID='" + id+"';";
            comando.ExecuteNonQuery();
            comando.Parameters.Clear();
        }
        public void elimianDoc(int ID)
        {
            comando.Connection = conexion.AbrirConexion();
            comando.CommandText="delete cincoh.librocompras where ID='"+ID+"'";
            comando.ExecuteNonQuery();
            comando.Parameters.Clear();
        }
    }
}
