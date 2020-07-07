using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using CapaDatos;
using CapaDatos.Clases;
using System.Drawing;

namespace Facturas
{
 
    public partial class Facturacion : System.Web.UI.Page
    {
        GestionBd objBD;
        List<Detfact> auxListado;

        protected void Page_Load(object sender, EventArgs e)
        {
            if (!Page.IsPostBack) 
            {
                cargaDatosGrid();
            }
        }
        //1.METODO CARGAR DATOS 
        void cargaDatosGrid()
        {
            objBD = new GestionBd();
            auxListado = objBD.listadoFactura();
            gridFacturas.DataSource = auxListado;
            gridFacturas.DataBind();
           
        }
        //2.METODO SELECCION DE INDEX DEL DATA GRID
        protected void gridFact_RowDataBound(object sender, GridViewRowEventArgs e)
        {
            if (e.Row.RowType == DataControlRowType.DataRow)
            {
                e.Row.Attributes["onclick"] = Page.ClientScript.GetPostBackClientHyperlink(gridFacturas, "Select$" + e.Row.RowIndex);
            }

        }
        //3.METODO REFRESCAR DATOS SELECCIONADOS
        protected void gridFact_SelectedIndexChanged(object sender, EventArgs e)
        {
            foreach (GridViewRow fila in gridFacturas.Rows)
            {

                if (fila.RowIndex == gridFacturas.SelectedIndex)
                {
                    txtIdFactura.Text = fila.Cells[0].Text; 
                    txtNumlin.Text = fila.Cells[1].Text;
                    txtCodprod.Text = fila.Cells[2].Text;
                    txtDetprod.Text = fila.Cells[3].Text;
                    txtCantprod.Text = fila.Cells[4].Text;
                    txtCostunit.Text = fila.Cells[5].Text;
                    txtTotalin.Text = fila.Cells[6].Text;
                    fila.BackColor = ColorTranslator.FromHtml("#A1DCF2");
                }
                else
                {
                    fila.BackColor = ColorTranslator.FromHtml("#FFFFFF");
                }
            }
            cargaDatosGrid();
        }

    }
}