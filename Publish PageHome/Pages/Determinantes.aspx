<%@ Page Title="" Language="C#" MasterPageFile="~/Site3.Master" AutoEventWireup="true" CodeBehind="Determinantes.aspx.cs" Inherits="ParkAutoHome.Pages.Determinantes" %>
<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">
             
          <div class="jumbotron">
        <h2>Plazas y Determinantes</h2>
        <p class="lead"><span style="color: rgb(9,3,255); font-family: &quot;Helvetica Neue&quot; Helvetica, Arial, sans-serif; font-size: 15px; font-style: normal; font-variant-ligatures: normal; font-variant-caps: normal; font-weight: 400; letter-spacing: normal; orphans: 2; text-align: justify; text-indent: 0px; text-transform: uppercase; white-space: normal; widows: 2; word-spacing: 0px; -webkit-text-stroke-width: 0px; background-color: rgb(232, 239, 245); text-decoration-thickness: initial; text-decoration-style: initial; text-decoration-color: initial; display: inline !important; float: none;" >Activación de Plazas y Determinantes</span></p>
           <asp:GridView ID="GvDeterminantes" runat="server" AllowPaging="True" 
            AutoGenerateColumns="false" onpageindexchanging="GvDeterminantes_PageIndexChanging" 
            onselectedindexchanged="GvDeterminantes_SelectedIndexChanged"  horizontalalign="Center"  BorderColor="Blue" ForeColor ="Black" >
            <Columns>

                 <asp:BoundField DataField="Id" HeaderText="Id" >
                <%--<ControlStyle Font-Names="Arial" Font-Size="Medium" />--%>
                <HeaderStyle Font-Names="Arial" Font-Size="Smaller" BackColor ="Blue" ForeColor ="White"  Width="40"  />   
                    <ItemStyle Font-Names="Arial" Font-Size="Smaller" /> 
                </asp:BoundField>
                
               

                <asp:BoundField DataField="Codigo_Proveedor" HeaderText="Proveedor" >
                <%--<ControlStyle Font-Names="Arial" Font-Size="Medium" />--%>
                <HeaderStyle Font-Names="Arial" Font-Size="Smaller" BackColor ="Blue" ForeColor ="White"  Width="30"  />   
                    <ItemStyle Font-Names="Arial" Font-Size="Smaller" /> 
                </asp:BoundField>

      


                 <asp:BoundField DataField="CveEmpresa" HeaderText="CveEmpresa">
                     <HeaderStyle Font-Names="Arial" Font-Size="Smaller" BackColor ="Blue" ForeColor ="White"  Width="50"/>   
                    <ItemStyle Font-Names="Arial" Font-Size="Smaller" /> 
                    </asp:BoundField>

                 <asp:BoundField DataField="Nombre_Empresa" HeaderText="Nombre_Empresa">
                     <HeaderStyle Font-Names="Arial" Font-Size="Smaller" BackColor ="Blue" ForeColor ="White"  Width="450"/>   
                    <ItemStyle Font-Names="Arial" Font-Size="Smaller" /> 
                    </asp:BoundField>


                    <asp:BoundField DataField="CveEstamto" HeaderText="CveEstamto" >
                    <HeaderStyle Font-Names="Arial" Font-Size="Smaller" BackColor ="Blue" ForeColor ="White" Width="50"  CssClass="hiddencol"/>   
                    <ItemStyle Font-Names="Arial" Font-Size="Smaller" /> 
                     <ItemStyle Width="100px"/>
                    <ControlStyle Width="500px"/>
                    </asp:BoundField>

                
                <asp:BoundField DataField="Estacionamiento" HeaderText="Estacionamiento">
                     <HeaderStyle Font-Names="Arial" Font-Size="Smaller" BackColor ="Blue" ForeColor ="White"  Width="350"/>   
                    <ItemStyle Font-Names="Arial" Font-Size="Smaller" /> 
                    </asp:BoundField>



               

                <asp:BoundField DataField="Determinante" HeaderText="Determinante" >
                    <HeaderStyle Font-Names="Arial" Font-Size="Smaller" BackColor ="Blue" ForeColor ="White" Width="50"/>   
                    <ItemStyle Font-Names="Arial" Font-Size="Smaller" /> 
                    <ItemStyle Width="100"/>
                    <ControlStyle Width="300px"/>
                    </asp:BoundField>

              

                <asp:BoundField DataField="Activo" HeaderText="Activo" >
                    <HeaderStyle Font-Names="Arial" Font-Size="Smaller" BackColor ="Blue" ForeColor ="White" Width="100"/>   
                    <ItemStyle Font-Names="Arial" Font-Size="Smaller" /> 
                    </asp:BoundField>

               
                
                <asp:CommandField ShowSelectButton="True"  HeaderStyle-BackColor ="Blue"   ControlStyle-ForeColor ="Green"    />
            </Columns>
        </asp:GridView>
           
            <br />
            <br />

          <div align="center">



              <asp:Label ID="Proveedor" runat="server" Text="Codigo Proveedor"></asp:Label>

              &nbsp;&nbsp;&nbsp;

           <asp:TextBox ID="txtProveedor" runat="server" Width="38px"></asp:TextBox>

              &nbsp;&nbsp;&nbsp;&nbsp;

              <asp:Label ID="Label2" runat="server" Text="Empresa"></asp:Label>
              &nbsp;&nbsp;&nbsp;
              <asp:DropDownList ID="ddlEmpresa" runat="server" Height="17px" Width="310px"></asp:DropDownList>

              &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
              <asp:Label ID="Label5" runat="server" Text="Estacionamiento"></asp:Label>

              &nbsp;&nbsp;&nbsp;

              <asp:DropDownList ID="ddlEstamto" runat="server" Height="16px" Width="296px"></asp:DropDownList>

              <br />
              <br />


             <asp:Label ID="Label3" runat="server" Text="Determinante"></asp:Label>
          &nbsp;&nbsp;&nbsp;&nbsp;
          <asp:TextBox ID="txtDeterminante" runat="server" Width="47px" Style="text-transform: uppercase"></asp:TextBox>

               &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;

               <asp:CheckBox ID="ckEstatus" runat="server"  Text ="  Estatus" Font-Size="Large" TextAlign="right" Font-Bold="false"/>

            <br />
           <br />
        
         <br />
         
        
           
        
           <asp:Button ID="btnNuevo" runat="server" Height="43px" Text="Nuevo" Width="112px" OnClick="Button2_Click" class="btn btn-primary btn-lg"  />
          &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
          <asp:Button ID="btnGuardar" runat="server" Text="Guardar" Height="43px" OnClick="btnEditar_Click" Width="114px" class="btn btn-primary btn-lg" />


          &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;


          <asp:Button ID="btnEditar" runat="server" Height="43px" Text="Editar" Width="116px" OnClick="Button1_Click" class="btn btn-primary btn-lg"/>
         
          &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
         
          <asp:Button ID="Button1" runat="server" Height="43px" Text="Cancelar" Width="117px" OnClick="Button3_Click" class="btn btn-primary btn-lg"/>
           <br />
           <br />
        
        </div>

            
               

     

     <br />



      </div>




</asp:Content>
