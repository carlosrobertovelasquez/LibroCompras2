using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;
using CapaDatos;
namespace CapaNegocio
{
   public class CN_LibroCompras
    {
        private CD_LibroCompras objetoCD = new CD_LibroCompras();

        public DataTable MostrarLibroCompra( string vmes,string vano)
        {
            DataTable tabla = new DataTable();
             tabla = objetoCD.Mostrar(vmes,vano);
            return tabla;

        }


        public DataTable ConsultaID(int ID)
        {
            DataTable tablaConsulta = new DataTable();
            tablaConsulta = objetoCD.ConsultarID(ID);
            return tablaConsulta;

        }

        public void InsertarRegistro( string FechaEmision, string NumerodeDoc, string NumeroRegistro, string NombreProveedor, decimal CEX_local, decimal CEX_Importaciones,decimal CEX_Iternacionales, decimal CGR_locales, decimal CGR_Importaciones, decimal CGR_iternacionales, decimal creditoFiscal, decimal TotalCompras, decimal IvaUnoPorCientoRetendio, decimal Ret_Suj_Exc_Cal_Cont, decimal ComprasExcluidas, decimal RetencionATerceros, string Mes, string ano, string origen, decimal FOVIAL, decimal COTRANS, string pais, string local, string Sutipo,  string TIPO, string DENTROCA, string LIBRO,string libro,string tipo,string dentroca)
        {
            objetoCD.Insertar( FechaEmision, NumerodeDoc, NumeroRegistro, NombreProveedor,  CEX_local, CEX_Importaciones, CEX_Iternacionales, CGR_locales, CGR_Importaciones, CGR_iternacionales, creditoFiscal, TotalCompras, IvaUnoPorCientoRetendio, Ret_Suj_Exc_Cal_Cont, ComprasExcluidas, RetencionATerceros, Mes, ano, origen, FOVIAL, COTRANS, pais, local, Sutipo,libro,tipo,dentroca);
        }

        public void EditarRegistro(string FechaEmision, string NumerodeDoc, string NumeroRegistro, string NombreProveedor, string IdentifExclu, decimal ImpuestosEspecificos, decimal CEX_Locales, decimal CEX_Importaciones, decimal CEX_Iternacionales, decimal CGR_Locales, decimal CGR_Importaciones, decimal CGR_Iternacionales, decimal CreditoFiscal, decimal TotalCompras, decimal IvaUnoPorCientoRetenido, decimal Ret_Suj_Exc_Cal_Cont, decimal ComprasExcluidas, decimal RetencionATerceros, string Mes, string Ano, decimal FOVIAL, decimal COTRANS, string LIBRO, string TIPO, string DENTROCA, string ID)
        {

            objetoCD.editar(FechaEmision,  NumerodeDoc,  NumeroRegistro,  NombreProveedor,  IdentifExclu,  ImpuestosEspecificos,  CEX_Locales,  CEX_Importaciones,  CEX_Iternacionales,  CGR_Locales,  CGR_Importaciones,  CGR_Iternacionales,  CreditoFiscal,  TotalCompras,  IvaUnoPorCientoRetenido,  Ret_Suj_Exc_Cal_Cont, ComprasExcluidas,  RetencionATerceros,  Mes,  Ano,  FOVIAL,  COTRANS,  LIBRO,  TIPO,  DENTROCA,  ID);
        }
        public void EliminaDoc(string id)
        {
            objetoCD.elimianDoc(Convert.ToInt32(id));
        }
         

    }


}
