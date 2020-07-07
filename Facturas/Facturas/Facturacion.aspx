<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Facturacion.aspx.cs" Inherits="Facturas.Facturacion" EnableEventValidation="false"  %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>

            <!--TABLA-->
            <table>
                <tr>
                    <td>Id_Factura</td>
                    <td><asp:TextBox ID="txtIdFactura" runat="server"></asp:TextBox></td>
                </tr>
                 <tr>
                    <td>Num_linea</td>
                    <td><asp:TextBox ID="txtNumlin" runat="server"></asp:TextBox></td>
                </tr>
                 <tr>
                    <td>Cod_Producto</td>
                    <td><asp:TextBox ID="txtCodprod" runat="server"></asp:TextBox></td>
                </tr>
                 <tr>
                    <td>Detalle_Producto</td>
                    <td><asp:TextBox ID="txtDetprod" runat="server"></asp:TextBox></td>
                </tr>
                <tr>
                    <td>Cant_Producto</td>
                    <td><asp:TextBox ID="txtCantprod" runat="server"></asp:TextBox></td>
                </tr>
                <tr>
                    <td>Costo_Unitario</td>
                    <td><asp:TextBox ID="txtCostunit" runat="server"></asp:TextBox></td>
                </tr>
                <tr>
                    <td>Total_Linea</td>
                    <td><asp:TextBox ID="txtTotalin" runat="server"></asp:TextBox></td>
                </tr>
            </table>

            <br />


            <asp:GridView ID="gridFacturas" runat="server" 
                AutoGenerateColumns="false"  
                DataKeyNames="idFactura" 
                BackColor="White" 
                BorderColor="#999999" 
                BorderStyle="None" 
                BorderWidth="1px" 
                CellPadding="3" 
                GridLines="Vertical" 
                OnRowDataBound="gridFact_RowDataBound" OnSelectedIndexChanged="gridFact_SelectedIndexChanged">


                <Columns>
                    <asp:BoundField DataField="idFactura" HeaderText="Id_Factura" />
                    <asp:BoundField DataField="numLinea" HeaderText="Num_linea" />
                    <asp:BoundField DataField="codProducto" HeaderText="Cod_Producto" />
                    <asp:BoundField DataField="detProducto" HeaderText="Detalle_Producto" />
                    <asp:BoundField DataField="cantProducto" HeaderText="Cant_Producto" />
                    <asp:BoundField DataField="costUnitario" HeaderText="Costo_Unitario" />
                    <asp:BoundField DataField="totalLinea" HeaderText="Total_Linea" />
                </Columns>

                <AlternatingRowStyle BackColor="#DCDCDC" />
                <FooterStyle BackColor="#CCCCCC" ForeColor="Black" />
                <HeaderStyle BackColor="#000084" Font-Bold="True" ForeColor="White" />
                <PagerStyle BackColor="#999999" ForeColor="Black" HorizontalAlign="Center" />
                <RowStyle BackColor="#EEEEEE" ForeColor="Black" />
                <SelectedRowStyle BackColor="#008A8C" Font-Bold="True" ForeColor="White" />
                <SortedAscendingCellStyle BackColor="#F1F1F1" />
                <SortedAscendingHeaderStyle BackColor="#0000A9" />
                <SortedDescendingCellStyle BackColor="#CAC9C9" />
                <SortedDescendingHeaderStyle BackColor="#000065" />
            </asp:GridView>
        </div>
    </form>
</body>
</html>
