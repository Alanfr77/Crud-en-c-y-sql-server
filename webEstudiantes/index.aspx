<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="index.aspx.cs" Inherits="webEstudiantes.index" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <link href="https://cdn.jsdelivr.net/npm/bootstrap@5.3.3/dist/css/bootstrap.min.css" rel="stylesheet">
    <link href="form.css" rel="stylesheet" />
    <title></title>
</head>
<body>
    <main>
        <div>
            <form id="form1" class="contenedorForm" runat="server" autocomplete="off">
                <div>
                    <h4>Sistema control de alumnos</h4>
                    <br />
                    <asp:Label ID="Label1" runat="server" Text="Carnet:"></asp:Label><br />
                    <asp:TextBox ID="Textcarnet" CssClass="form-control" runat="server"></asp:TextBox>
                    <br />

                    <asp:Label ID="Label2" runat="server" Text="Nombre:"></asp:Label><br />
                    <asp:TextBox ID="Textnombre" CssClass="form-control" runat="server"></asp:TextBox>
                    <br />

                    <asp:Label ID="Label3" runat="server" Text="Dirección:"></asp:Label><br />
                    <asp:TextBox ID="Textdireccion" CssClass="form-control" runat="server"></asp:TextBox>
                    <br />
                    <asp:Label ID="LabelInfo" runat="server" Text=""></asp:Label>
                    <br /><br />

                    <asp:Button ID="Btnagregar" CssClass="btn btn-primary" runat="server" Text="Agregar" OnClick="Btnagregar_click" />
                    <asp:Button ID="Btneditar" CssClass="btn btn-success" runat="server" Text="Modificar" OnClick="Btneditar_click" />
                    <asp:Button ID="Btneliminar" CssClass="btn btn-danger" runat="server" Text="Eliminar" OnClick="Btneliminar_click" />
                    <asp:Button ID="Btnconsultar" CssClass="btn btn-warning" runat="server" Text="Consultar" OnClick="Btnconsultar_click" />
                    <asp:Button ID="Btngeneral" CssClass="btn btn-info" runat="server" Text="Consulta general" OnClick="Btngeneral_click"/>
                    <br /><br />

                    <table class="table">
                      <thead>
                        <tr>
                          <th scope="col">Carnet</th>
                          <th scope="col">Nombre</th>
                          <th scope="col">Direccion</th>
                        </tr>
                      </thead>
                      <tbody>
                        <tr>
                          <td><asp:Label ID="showCarnetTable" runat="server" Text=""></asp:Label></td>
                          <td><asp:Label ID="showNombreTable" runat="server" Text=""></asp:Label></td>
                          <td><asp:Label ID="showDireccionTable" runat="server" Text=""></asp:Label></td>
                        </tr>
                      </tbody>
                    </table>

                    <asp:GridView ID="GridView1" CssClass="gridView" runat="server" AutoGenerateColumns="True"></asp:GridView>

                </div>
            </form>
        </div>
    </main>
    <script src="https://cdn.jsdelivr.net/npm/bootstrap@5.3.3/dist/js/bootstrap.bundle.min.js"></script>
</body>
</html>