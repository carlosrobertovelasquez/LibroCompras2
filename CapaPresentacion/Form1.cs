using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using CapaNegocio;
using System.Globalization;
namespace CapaPresentacion
{
    public partial class FrmLibroCompras : Form
    {
        CN_LibroCompras objetoCN = new CapaNegocio.CN_LibroCompras();
        private Boolean Editar = false;
        private string idfactura = null;
        public FrmLibroCompras()
        {
            InitializeComponent();
        }

        private void ExportarDataGridViewExcel()
        {
            if (dataGridView1.DataSource != null)
            {
                SaveFileDialog fichero = new SaveFileDialog();
                fichero.Filter = "Excel (*.xls)|*.xls";
                if (fichero.ShowDialog() == DialogResult.OK)
                {
                    Microsoft.Office.Interop.Excel.Application aplicacion;
                    Microsoft.Office.Interop.Excel.Workbook libros_trabajo;
                    Microsoft.Office.Interop.Excel.Worksheet hoja_trabajo;
                    aplicacion = new Microsoft.Office.Interop.Excel.Application();
                    libros_trabajo = aplicacion.Workbooks.Add();
                    hoja_trabajo = (Microsoft.Office.Interop.Excel.Worksheet)libros_trabajo.Worksheets.get_Item(1);

                    //exportar cabeceras dgvLog
                    for (int i = 1; i <= this.dataGridView1.Columns.Count - 1; i++)
                    {
                        hoja_trabajo.Cells[1, i] = this.dataGridView1.Columns[i - 1].HeaderText;

                    }

                    //Recorremos el DataGridView rellenando la hoja de trabajo con los datos
                    for (int i = 0; i < this.dataGridView1.Rows.Count; i++)
                    {
                        for (int j = 0; j < this.dataGridView1.Columns.Count - 1; j++)
                        {
                            //hoja_trabajo.Cells[i + 2, j + 1] = this.dataGridView1.Rows[i].Cells[j].Value.ToString();
                            hoja_trabajo.Cells[i + 2, j + 1] = this.dataGridView1.Rows[i].Cells[j].FormattedValue;
                        }
                    }

                    libros_trabajo.SaveAs(fichero.FileName, Microsoft.Office.Interop.Excel.XlFileFormat.xlWorkbookNormal);
                    hoja_trabajo.Columns.AutoFit();
                    libros_trabajo.Close(true);
                    MessageBox.Show("Se Exporto Con Exito");
                    aplicacion.Quit();
                }
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            this.Location = Screen.PrimaryScreen.WorkingArea.Location;
            this.Size = Screen.PrimaryScreen.WorkingArea.Size;


            DateTime hoy = DateTime.Now;
            //string vano = Convert.ToString(hoy.Year);
            //string vmes = Convert.ToString(hoy.Month);




            MostrarLibro(Convert.ToString(hoy.Month), Convert.ToString(hoy.Year));
            CargarMes();
            ListarAno();
            LimpiarTextbox();

            CmbLibro.Items.Add("S");
            CmbLibro.Items.Add("N");
            

            CmbDentroCA.Items.Add("S");
            CmbDentroCA.Items.Add("N");
            

            CmbTipoDoc.Items.Add("FAC");
            CmbTipoDoc.Items.Add("EXP");
            CmbTipoDoc.Items.Add("N/C");
            CmbTipoDoc.Items.Add("RET");

            CmbLibro.SelectedItem = "S";
            CmbDentroCA.SelectedItem = "S";
            CmbTipoDoc.SelectedItem = "FAC";



        }


        private void MostrarLibro(string vmes,string vano)
        {
            dataGridView1.DataSource = objetoCN.MostrarLibroCompra(vmes,vano );
        }

        private void consultar()
        {
            dataGridView1.DataSource = null;
            dataGridView1.Rows.Clear();
            dataGridView1.DataSource = null;
            dataGridView1.Refresh();
            dataGridView1.Rows.Clear();
            string vmes = CmbMes.SelectedValue.ToString();
            string vano = CmbAno.SelectedItem.ToString();
            MostrarLibro(vmes, vano);
        }

        private void LimpiarTextbox()
        {
            TxtCompExtImport.Text = "0.00";
            TxtCompExtInter.Text = "0.00";
            TxtCompExtLocales.Text = "0.00";
            TxtCompGraLocales.Text = "0.00";
            TxtCompGrInternacionales.Text = "0.00";
            TxtCompGraImportaciones.Text = "0.00";
            TxtCreditoFiscal.Text = "0.00";
            TxtTotalCompras.Text = "0.00";
            TxtIvaUnoPorcientoRetenido.Text = "0.00";
            TxtRet_Suj_Exc_Cal_Contri.Text = "0.00";
            TxtComprasExcluidas.Text = "0.00";
            TxtRetencionATerceros.Text = "0.00";
            TxtConsTrans.Text = "0.00";
            TxtFovial.Text = "0.00";
            TxtImpuEspe.Text = "0.00";
            TxtNumDoc.Text = "";
            TxtNumRegistro.Text = "";
            TxtIdExcl.Text = "";
            TxtNomProv.Text = "";
            TxtFechaEmision.Focus();
        }

        private void CargarMes()
        {
            this.CmbMes.DisplayMember = "Text";
            this.CmbMes.ValueMember = "Value";

            var months = new[]
            {
            new { Text = "Enero", Value = 1 },
            new { Text = "Febrero", Value = 2 },
            new { Text = "Marzo", Value = 3 },
            new { Text = "Abril", Value = 4 },
            new { Text = "Mayo", Value = 5 },
            new { Text = "Junio", Value = 6 },
            new { Text = "Julio", Value = 7 },
            new { Text = "Agosto", Value = 8 },
            new { Text = "Septiembre", Value = 9 },
            new { Text = "Octubre", Value = 10 },
            new { Text = "Noviembre", Value = 11 },
            new { Text = "Diciembre", Value = 12 }
        };
            this.CmbMes.DataSource = months;

            DateTime now = DateTime.Now;
            int monthValue = now.Month;
            //CmbMes.Items.Add("Select");
            CmbMes.SelectedIndex = monthValue - 1;
        }

        private void ListarAno()
        {
            {
                try
                {
                    //clear all data from combobox
                    CmbAno.Items.Clear();
                    //add default item
                    CmbAno.Items.Add("Select");
                    //loop array for add items
                    for (int i = DateTime.Now.Year; i < DateTime.Now.Year + 15; i++)
                    {
                        CmbAno.Items.Add(i);
                    }
                    //set selected item for display on startup
                    CmbAno.Text = DateTime.Now.Year.ToString();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message.ToString());
                }
            }
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label13_Click(object sender, EventArgs e)
        {

        }

        private void textBox6_TextChanged(object sender, EventArgs e)
        {
           
        }

        private void textBox6_Leave(object sender, EventArgs e)
        {
           
        }

        private void textBox6_KeyDown(object sender, KeyEventArgs e)
        {
            
            
        }

        private void textBox6_KeyPress(object sender, KeyPressEventArgs e)
        {
            ValidarTextBox.NumerosDecimales(e);
        }

        private void TxtCompExtLocales_KeyPress(object sender, KeyPressEventArgs e)
        {
            ValidarTextBox.NumerosDecimales(e);
        }

        private void TxtCompExtImport_KeyPress(object sender, KeyPressEventArgs e)
        {
            ValidarTextBox.NumerosDecimales(e);
        }

        private void TxtCompExtInter_KeyPress(object sender, KeyPressEventArgs e)
        {
            ValidarTextBox.NumerosDecimales(e);
        }

        private void TxtCompGraLocales_KeyPress(object sender, KeyPressEventArgs e)
        {
            ValidarTextBox.NumerosDecimales(e);
        }

        private void TxtCompGraImportaciones_KeyPress(object sender, KeyPressEventArgs e)
        {
            ValidarTextBox.NumerosDecimales(e);
        }

        private void TxtCompGrInternacionales_KeyPress(object sender, KeyPressEventArgs e)
        {
            ValidarTextBox.NumerosDecimales(e);
        }

        private void TxtTotalCompras_KeyPress(object sender, KeyPressEventArgs e)
        {
            ValidarTextBox.NumerosDecimales(e);
        }

        private void TxtIvaUnoPorcientoRetenido_KeyPress(object sender, KeyPressEventArgs e)
        {
            ValidarTextBox.NumerosDecimales(e);
        }

        private void TxtRet_Suj_Exc_Cal_Contri_KeyPress(object sender, KeyPressEventArgs e)
        {
            ValidarTextBox.NumerosDecimales(e);
        }

        private void TxtComprasExcluidas_KeyPress(object sender, KeyPressEventArgs e)
        {
            ValidarTextBox.NumerosDecimales(e);
        }

        private void TxtRetencionATerceros_KeyPress(object sender, KeyPressEventArgs e)
        {
            ValidarTextBox.NumerosDecimales(e);
        }

        private void TxtFovial_KeyPress(object sender, KeyPressEventArgs e)
        {
            ValidarTextBox.NumerosDecimales(e);
        }

        private void TxtConsTrans_KeyPress(object sender, KeyPressEventArgs e)
        {
            ValidarTextBox.NumerosDecimales(e);
        }

        private void TxtFechaEmision_KeyPress(object sender, KeyPressEventArgs e)
        {
        }

        private void label15_Click(object sender, EventArgs e)
        {

        }

        private void TxtFechaEmision_Enter(object sender, EventArgs e)
        {
            TxtFechaEmision.BackColor = Color.MediumAquamarine;
        }

        private void textBox1_Enter(object sender, EventArgs e)
        {
            TxtNumDoc.BackColor = Color.MediumAquamarine; 
        }

        private void textBox1_Leave(object sender, EventArgs e)
        {
            TxtNumDoc.BackColor = Color.White;
        }

        private void TxtCompExtLocales_Leave(object sender, EventArgs e)
        {

            TxtCompExtLocales.BackColor = Color.White;
        }

        private void textBox2_Enter(object sender, EventArgs e)
        {
            TxtNumRegistro.BackColor = Color.MediumAquamarine; 
        }

        private void textBox2_Leave(object sender, EventArgs e)
        {
            TxtNumRegistro.BackColor = Color.White;
        }

        private void textBox3_Enter(object sender, EventArgs e)
        {

            TxtIdExcl.BackColor = Color.MediumAquamarine;
        }

        private void textBox3_Leave(object sender, EventArgs e)
        {

            TxtIdExcl.BackColor = Color.White;
        }

        private void textBox4_Enter(object sender, EventArgs e)
        {

            TxtNomProv.BackColor = Color.MediumAquamarine;
        }

        private void textBox4_Leave(object sender, EventArgs e)
        {

            TxtNomProv.BackColor = Color.White;
        }

        private void textBox5_Enter(object sender, EventArgs e)
        {

            TxtImpuEspe.BackColor = Color.MediumAquamarine;
        }

        private void textBox5_Leave(object sender, EventArgs e)
        {

            TxtImpuEspe.BackColor = Color.White;
        }

        private void TxtCompExtLocales_Enter(object sender, EventArgs e)
        {

            TxtCompExtLocales.BackColor = Color.MediumAquamarine;
        }

        private void TxtCompExtImport_Enter(object sender, EventArgs e)
        {
            TxtCompExtImport.BackColor = Color.MediumAquamarine;
        }

        private void TxtCompExtImport_Leave(object sender, EventArgs e)
        {
            TxtCompExtImport.BackColor = Color.White;
        }

        private void TxtCompExtInter_Enter(object sender, EventArgs e)
        {
            TxtCompExtInter.BackColor = Color.MediumAquamarine;
        }

        private void TxtCompExtInter_Leave(object sender, EventArgs e)
        {
            TxtCompExtInter.BackColor = Color.White;
        }

        private void TxtCompGraImportaciones_Enter(object sender, EventArgs e)
        {
            TxtCompGraImportaciones.BackColor = Color.MediumAquamarine;
        }

        private void TxtCompGraImportaciones_Leave(object sender, EventArgs e)
        {
            TxtCompGraImportaciones.BackColor = Color.White;
        }

        private void TxtCompGrInternacionales_Enter(object sender, EventArgs e)
        {
            TxtCompGrInternacionales.BackColor = Color.MediumAquamarine;
        }

        private void TxtCompGrInternacionales_Leave(object sender, EventArgs e)
        {
            TxtCompGrInternacionales.BackColor = Color.White;
        }

        private void TxtTotalCompras_Enter(object sender, EventArgs e)
        {
            TxtTotalCompras.BackColor = Color.MediumAquamarine;
        }

        private void TxtTotalCompras_Leave(object sender, EventArgs e)
        {
            TxtTotalCompras.BackColor = Color.White;
        }

        private void TxtIvaUnoPorcientoRetenido_Enter(object sender, EventArgs e)
        {
            TxtIvaUnoPorcientoRetenido.BackColor = Color.MediumAquamarine;
        }

        private void TxtIvaUnoPorcientoRetenido_Leave(object sender, EventArgs e)
        {
            TxtIvaUnoPorcientoRetenido.BackColor = Color.White;
        }

        private void TxtRet_Suj_Exc_Cal_Contri_Enter(object sender, EventArgs e)
        {
            TxtRet_Suj_Exc_Cal_Contri.BackColor = Color.MediumAquamarine;
        }

        private void TxtRet_Suj_Exc_Cal_Contri_Leave(object sender, EventArgs e)
        {
            TxtRet_Suj_Exc_Cal_Contri.BackColor = Color.White;
        }

        private void TxtComprasExcluidas_Enter(object sender, EventArgs e)
        {
            TxtComprasExcluidas.BackColor = Color.MediumAquamarine;
        }

        private void TxtComprasExcluidas_Leave(object sender, EventArgs e)
        {
            TxtComprasExcluidas.BackColor = Color.White;
        }

        private void TxtRetencionATerceros_Enter(object sender, EventArgs e)
        {
            TxtRetencionATerceros.BackColor = Color.MediumAquamarine;
        }

        private void TxtRetencionATerceros_Leave(object sender, EventArgs e)
        {
            TxtRetencionATerceros.BackColor = Color.White;
        }

        private void TxtFovial_Enter(object sender, EventArgs e)
        {
            TxtFovial.BackColor = Color.MediumAquamarine;
        }

        private void TxtFovial_Leave(object sender, EventArgs e)
        {
            TxtFovial.BackColor = Color.White;
        }

        private void TxtConsTrans_Enter(object sender, EventArgs e)
        {
            TxtConsTrans.BackColor = Color.MediumAquamarine;
        }

        private void TxtConsTrans_Leave(object sender, EventArgs e)
        {
            TxtConsTrans.BackColor = Color.White;
        }

        private void comboBox1_Enter(object sender, EventArgs e)
        {
            CmbDentroCA.BackColor = Color.MediumAquamarine;
        }

        private void comboBox1_Leave(object sender, EventArgs e)
        {
            CmbDentroCA.BackColor = Color.White;
        }

        private void TxtCompGraLocales_Enter(object sender, EventArgs e)
        {
            TxtCompGraLocales.BackColor = Color.MediumAquamarine;
        }

        private void TxtCompGraLocales_Leave(object sender, EventArgs e)
        {
            TxtCompGraLocales.BackColor = Color.White;
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label21_Click(object sender, EventArgs e)
        {

        }

        private void TxtCreditoFiscal_KeyPress(object sender, KeyPressEventArgs e)
        {
            ValidarTextBox.NumerosDecimales(e);
        }

        private void TxtCompGrInternacionales_TextChanged(object sender, EventArgs e)
        {

        }

        private void TxtCreditoFiscal_Enter(object sender, EventArgs e)
        {
            TxtCreditoFiscal.BackColor = Color.MediumAquamarine;
        }

        private void TxtCreditoFiscal_Leave(object sender, EventArgs e)
        {
            TxtCreditoFiscal.BackColor = Color.White;
        }

        private void CmbLibro_Enter(object sender, EventArgs e)
        {
            CmbLibro.BackColor = Color.MediumAquamarine;
        }

        private void CmbLibro_Leave(object sender, EventArgs e)
        {
            CmbLibro.BackColor = Color.White;
        }

        private void BtnGuardar_Click(object sender, EventArgs e)
        {

            if (Editar == false)
            {
                string vorigen = "LC";
                string vpais = "SAL";
                string vlocal = "S";
                string vsubtipo = "1";
                string vano2 = Convert.ToString(TxtFechaEmision.Value.Year);
                string vmes2 = Convert.ToString(TxtFechaEmision.Value.Month);
                try
                {
                    if(TxtNumDoc != null)
                    {
                        objetoCN.InsertarRegistro(TxtFechaEmision.Text, TxtNumDoc.Text, TxtNumRegistro.Text, TxtNomProv.Text, Convert.ToDecimal(TxtCompExtLocales.Text), Convert.ToDecimal(TxtCompExtImport.Text), Convert.ToDecimal(TxtCompExtInter.Text), Convert.ToDecimal(TxtCompGraLocales.Text), Convert.ToDecimal(TxtCompGraImportaciones.Text), Convert.ToDecimal(TxtCompGraImportaciones.Text), Convert.ToDecimal(TxtCreditoFiscal.Text), Convert.ToDecimal(TxtTotalCompras.Text), Convert.ToDecimal(TxtIvaUnoPorcientoRetenido.Text), Convert.ToDecimal(TxtRet_Suj_Exc_Cal_Contri.Text), Convert.ToDecimal(TxtComprasExcluidas.Text), Convert.ToDecimal(TxtRetencionATerceros.Text), vmes2, vano2, vorigen, Convert.ToDecimal(TxtFovial.Text), Convert.ToDecimal(TxtConsTrans.Text), vpais, vlocal, vsubtipo, CmbLibro.Text, CmbDentroCA.Text, CmbLibro.Text, CmbLibro.Text, CmbTipoDoc.Text, CmbDentroCA.Text);
                        MessageBox.Show("Registro Ingresado");
                        LimpiarTextbox();
                        consultar();
                    }
                    else
                    {
                        MessageBox.Show("Requiere que se llene los Campos Obligatorios");
                    }
                    
                    
                }
                catch (Exception ex)
                {

                    MessageBox.Show("No se puedo Insertar Los datos!" + ex);
                }


            }
            if (Editar == true)
            {
             //   try
               // {
                    string vorigen = "LC";
                    string vano2 = Convert.ToString(TxtFechaEmision.Value.Year);
                    string vmes2 = Convert.ToString(TxtFechaEmision.Value.Month);
                                                                                                                 //                                                                                                                                                                                                                                                                                                                                                                
                    objetoCN.EditarRegistro(TxtFechaEmision.Text, TxtNumDoc.Text, TxtNumRegistro.Text, TxtNomProv.Text, TxtIdExcl.Text, Convert.ToDecimal(TxtImpuEspe.Text), Convert.ToDecimal(TxtCompExtLocales.Text), Convert.ToDecimal(TxtCompExtImport.Text), Convert.ToDecimal(TxtCompExtInter.Text), Convert.ToDecimal(TxtCompGraLocales.Text), Convert.ToDecimal(TxtCompGraImportaciones.Text), Convert.ToDecimal(TxtCompGrInternacionales.Text), Convert.ToDecimal(TxtCreditoFiscal.Text), Convert.ToDecimal(TxtTotalCompras.Text), Convert.ToDecimal(TxtIvaUnoPorcientoRetenido.Text), Convert.ToDecimal(TxtRet_Suj_Exc_Cal_Contri.Text), Convert.ToDecimal(TxtComprasExcluidas.Text), Convert.ToDecimal(TxtRetencionATerceros.Text),vmes2,vano2, Convert.ToDecimal(TxtFovial.Text), Convert.ToDecimal(TxtConsTrans.Text), CmbLibro.Text,CmbTipoDoc.Text,CmbDentroCA.Text,  idfactura);
                    MessageBox.Show("Registro Editado");
                    LimpiarTextbox();
                    consultar();

                //}
                //catch (Exception ex)
               // {

                 //   MessageBox.Show("No se puedo Editar Los datos!" + ex);
               // }
            }
            

        }

        private void CmbTipoDoc_Enter(object sender, EventArgs e)
        {
            CmbTipoDoc.BackColor = Color.MediumAquamarine;
        }

        private void CmbTipoDoc_Leave(object sender, EventArgs e)
        {
            CmbTipoDoc.BackColor = Color.White;
        }

        private void TxtFechaEmision_Leave(object sender, EventArgs e)
        {
            TxtNumDoc.BackColor = Color.White;
        }

        private void BtnConsultar_Click(object sender, EventArgs e)
        {

                        consultar();

        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedRows.Count > 0)
            {
                 Editar = true;
                TxtFechaEmision.Text = dataGridView1.CurrentRow.Cells["FechaEmision"].Value.ToString();
                TxtNumDoc.Text= dataGridView1.CurrentRow.Cells["NumerodeDoc"].Value.ToString();
                TxtNumRegistro.Text= dataGridView1.CurrentRow.Cells["NumeroRegistro"].Value.ToString();
                TxtIdExcl.Text= dataGridView1.CurrentRow.Cells["IdentifExclu"].Value.ToString();
                TxtNomProv.Text= dataGridView1.CurrentRow.Cells["NombreProveedor"].Value.ToString();
                TxtImpuEspe.Text= dataGridView1.CurrentRow.Cells["ImpuestosEspecificos"].Value.ToString();
                TxtCompExtLocales.Text= dataGridView1.CurrentRow.Cells["CEX_Locales"].Value.ToString();
                TxtCompExtImport.Text= dataGridView1.CurrentRow.Cells["CEX_Importaciones"].Value.ToString();
                TxtCompExtInter.Text= dataGridView1.CurrentRow.Cells["CEX_Internaciones"].Value.ToString();
                TxtCompGraLocales.Text= dataGridView1.CurrentRow.Cells["CGR_Locales"].Value.ToString();
                TxtCompGrInternacionales.Text= dataGridView1.CurrentRow.Cells["CGR_Internacionales"].Value.ToString();
                TxtCompGraImportaciones.Text= dataGridView1.CurrentRow.Cells["CGR_Importaciones"].Value.ToString();
                TxtCreditoFiscal.Text= dataGridView1.CurrentRow.Cells["CreditoFiscal"].Value.ToString();
                TxtTotalCompras.Text= dataGridView1.CurrentRow.Cells["TotalCompras"].Value.ToString();
                TxtIvaUnoPorcientoRetenido.Text= dataGridView1.CurrentRow.Cells["IvaUnoPorCientoRetenido"].Value.ToString();
                TxtRet_Suj_Exc_Cal_Contri.Text= dataGridView1.CurrentRow.Cells["Ret_Suj_Exc_Cal_Cont"].Value.ToString();
                TxtComprasExcluidas.Text= dataGridView1.CurrentRow.Cells["ComprasExcluidas"].Value.ToString();
                TxtRetencionATerceros.Text= dataGridView1.CurrentRow.Cells["RetencionATerceros"].Value.ToString();
                TxtConsTrans.Text= dataGridView1.CurrentRow.Cells["COTRANS"].Value.ToString();
                TxtFovial.Text= dataGridView1.CurrentRow.Cells["FOVIAL"].Value.ToString();
                CmbDentroCA.Text= dataGridView1.CurrentRow.Cells["DENTROCA"].Value.ToString();
                CmbLibro.Text= dataGridView1.CurrentRow.Cells["LIBRO"].Value.ToString();
                CmbTipoDoc.Text= dataGridView1.CurrentRow.Cells["TIPO"].Value.ToString();
                TxtImpuEspe.Text= dataGridView1.CurrentRow.Cells["ImpuestosEspecificos"].Value.ToString();
                idfactura = dataGridView1.CurrentRow.Cells["ID"].Value.ToString();

            }
            else
            {
                MessageBox.Show("Seleciones una Fila por favor");
            }
        }

        private void CmdExcel_Click(object sender, EventArgs e)
        {
            ExportarDataGridViewExcel();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedRows.Count > 0)
            {
                idfactura = dataGridView1.CurrentRow.Cells["ID"].Value.ToString();
                objetoCN.EliminaDoc(idfactura);
                MessageBox.Show("Eliminado Corretamente");
                consultar();
            }
            else
            {
                MessageBox.Show("Selecione una Fila Por Favor");
            }
        }

        private void TxtNumDoc_Validated(object sender, EventArgs e)
        {
            if (TxtNumDoc.Text.Trim() == "")
            {
                errorProvider1.SetError(TxtNumDoc, "Introduce Numero Doc...");
                TxtNumDoc.Focus();
            }
            else
            {
                errorProvider1.Clear();
            }
        }

        private void TxtNomProv_TextChanged(object sender, EventArgs e)
        {
                    }

        private void TxtNomProv_Validated(object sender, EventArgs e)
        {
            if (TxtNomProv.Text.Trim() == "")
            {
                errorProvider1.SetError(TxtNomProv, "Introduce Nombre Proveedor...");
                TxtNomProv.Focus();
            }
            else
            {
                errorProvider1.Clear();
            }

        }

        private void TxtCompExtImport_TextChanged(object sender, EventArgs e)
        {
            //double total = Convert.ToInt32(TxtCompExtLocales.Text) + Convert.ToInt32(TxtCompExtImport.Text);
             //TxtTotalCompras.Text = total;
        }
    }
}
