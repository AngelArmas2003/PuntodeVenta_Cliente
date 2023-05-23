<%@ Page Title="" Language="C#" MasterPageFile="~/Site3.Master" AutoEventWireup="true" CodeBehind="Tarifas.aspx.cs" Inherits="ParkAutoHome.Pages.Tarifas" %>
<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">

          <div class="jumbotron">
        <h2>Tarifas de Plazas o Centros Comerciales</h2>
        <p class="lead"><span style="color: rgb(85, 85, 85); font-family: &quot;Helvetica Neue&quot;, Helvetica, Arial, sans-serif; font-size: 15px; font-style: normal; font-variant-ligatures: normal; font-variant-caps: normal; font-weight: 400; letter-spacing: normal; orphans: 2; text-align: justify; text-indent: 0px; text-transform: uppercase; white-space: normal; widows: 2; word-spacing: 0px; -webkit-text-stroke-width: 0px; background-color: rgb(232, 239, 245); text-decoration-thickness: initial; text-decoration-style: initial; text-decoration-color: initial; display: inline !important; float: none;">Seleccione una Plaza o Centro Comercial</span></p>



              <asp:Label ID="lblEstamto" runat="server" Text="Estacionamiento">          </asp:Label> &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; <asp:DropDownList ID="ddlEmpresas" runat="server" Height="16px" Width="395px" AutoPostBack="True" OnTextChanged="ddlEmpresas_TextChanged"></asp:DropDownList>
           
              <div class="jumbotron">
        <p class="lead"><span style="color: rgb(9,3,255); font-family: &quot;Helvetica Neue&quot;, Helvetica, Arial, sans-serif; font-size: 15px; font-style: normal; font-variant-ligatures: normal; font-variant-caps: normal; font-weight: 400; letter-spacing: normal; orphans: 2; text-align: justify; text-indent: 0px; text-transform: uppercase; white-space: normal; widows: 2; word-spacing: 0px; -webkit-text-stroke-width: 0px; background-color: rgb(232, 239, 245); text-decoration-thickness: initial; text-decoration-style: initial; text-decoration-color: initial; display: inline !important; float: none;" >Información de Tarifas</span></p>
           <asp:GridView ID="GvTarifas" runat="server" AllowPaging="True" 
            AutoGenerateColumns="false" onpageindexchanging="GvTarifas_PageIndexChanging" 
            onselectedindexchanged="GvTarifas_SelectedIndexChanged"  horizontalalign="Center"  BorderColor="Blue" ForeColor ="Black" >
            <Columns>




                <asp:BoundField DataField="CveTarifa" HeaderText="CveTarifa" >
                <%--<ControlStyle Font-Names="Arial" Font-Size="Medium" />--%>
                <HeaderStyle Font-Names="Arial" Font-Size="Smaller" BackColor ="Blue" ForeColor ="White"  Width="100"  />   
                    <ItemStyle Font-Names="Arial" Font-Size="Smaller" /> 
                </asp:BoundField>
                <asp:BoundField DataField="Minutos" HeaderText="Minutos">
                     <HeaderStyle Font-Names="Arial" Font-Size="Smaller" BackColor ="Blue" ForeColor ="White"  Width="100"/>   
                    <ItemStyle Font-Names="Arial" Font-Size="Smaller" /> 
                    </asp:BoundField>

                <asp:BoundField DataField="ImporteMinutos" HeaderText="ImporteMinutos" >
                    <HeaderStyle Font-Names="Arial" Font-Size="Smaller" BackColor ="Blue" ForeColor ="White" Width="100"/>   
                    <ItemStyle Font-Names="Arial" Font-Size="Smaller" /> 
                    <ItemStyle Width="200px"/>
                    <ControlStyle Width="300px"/>
                    </asp:BoundField>

                <asp:BoundField DataField="MinutoInicial" HeaderText="MinutoInicial" >
                    <HeaderStyle Font-Names="Arial" Font-Size="Smaller" BackColor ="Blue" ForeColor ="White" Width="100"  CssClass="hiddencol"/>   
                    <ItemStyle Font-Names="Arial" Font-Size="Smaller" /> 
                     <ItemStyle Width="400px"/>
                    <ControlStyle Width="500px"/>
                    </asp:BoundField>

                <asp:BoundField DataField="MinutoFinal" HeaderText="MinutoFinal" >
                    <HeaderStyle Font-Names="Arial" Font-Size="Smaller" BackColor ="Blue" ForeColor ="White" Width="100"  CssClass="hiddencol"/>   
                    <ItemStyle Font-Names="Arial" Font-Size="Smaller" /> 
                     <ItemStyle Width="400px"/>
                    <ControlStyle Width="500px"/>
                    </asp:BoundField>
                <asp:BoundField DataField="TotalAcumulado" HeaderText="TotalAcumulado" >
                    <HeaderStyle Font-Names="Arial" Font-Size="Smaller" BackColor ="Blue" ForeColor ="White" Width="100"  CssClass="hiddencol"/>   
                    <ItemStyle Font-Names="Arial" Font-Size="Smaller" /> 
                     <ItemStyle Width="400px"/>
                    <ControlStyle Width="500px"/>
                    </asp:BoundField>

                <asp:BoundField DataField="Determinante" HeaderText="Determinante" >
                    <HeaderStyle Font-Names="Arial" Font-Size="Smaller" BackColor ="Blue" ForeColor ="White" Width="100"  CssClass="hiddencol"/>   
                    <ItemStyle Font-Names="Arial" Font-Size="Smaller" /> 
                     <ItemStyle Width="400px"/>
                    <ControlStyle Width="500px"/>
                    </asp:BoundField>



                
                
                <asp:CommandField ShowSelectButton="True"  HeaderStyle-BackColor ="Blue"   ControlStyle-ForeColor ="Green"    />
            </Columns>
        </asp:GridView>
           
            <br />
            <br />

          <div align="center">
          <asp:Label ID="Label1" runat="server" Text="CveTarifa"></asp:Label>
              &nbsp;&nbsp;&nbsp;&nbsp;
              <asp:TextBox ID="txtCveTarifa" runat="server" Width="47px"></asp:TextBox>
         
      

          &nbsp;&nbsp;&nbsp;&nbsp;
         
      

          <asp:Label ID="Label3" runat="server" Text="Minutos"></asp:Label>
          &nbsp;&nbsp;&nbsp;&nbsp;
          <asp:TextBox ID="txtEstamto" runat="server" Width="51px"  Style="text-transform: uppercase" Height="22px" FilterType="Numbers"></asp:TextBox>
              
              

              &nbsp;<asp:Label ID="Label4" runat="server" Text="Importe por Tiempo"></asp:Label>
&nbsp;&nbsp;
             
              <asp:TextBox ID="txtImporte" runat="server" Width="51px"  Style="text-transform: uppercase"></asp:TextBox>

               &nbsp;<asp:Label ID="Label2" runat="server" Text="Minuto Inicial"></asp:Label>
&nbsp;&nbsp;
             
              <asp:TextBox ID="TextBox1" runat="server" Width="51px"  Style="text-transform: uppercase"></asp:TextBox>
                 &nbsp;<asp:Label ID="Label5" runat="server" Text="Minuto Final"></asp:Label>
&nbsp;&nbsp;
             
              <asp:TextBox ID="TextBox2" runat="server" Width="51px"  Style="text-transform: uppercase"></asp:TextBox>

                 &nbsp;<asp:Label ID="Label6" runat="server" Text="Total Aculudado"></asp:Label>
&nbsp;&nbsp;
             
              <asp:TextBox ID="TextBox4" runat="server" Width="51px"  Style="text-transform: uppercase"></asp:TextBox>

            <br />
           <br />
        
         <br />

              <asp:TextBox ID="txtDecimales" runat="server" Mask="99.99"></asp:TextBox>

         
        
           
                   <asp:Button ID="btnNuevo" runat="server" Height="43px" Text="Nuevo" Width="112px" OnClick="Button2_Click" class="btn btn-primary btn-lg"  />
          &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
          <asp:Button ID="btnGuardar" runat="server" Text="Guardar" Height="43px" OnClick="btnEditar_Click" Width="114px" class="btn btn-primary btn-lg" />


          &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;


          <asp:Button ID="btnEditar" runat="server" Height="43px" Text="Editar" Width="116px" OnClick="Button1_Click" class="btn btn-primary btn-lg"/>
         
          &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
         
          <asp:Button ID="Button1" runat="server" Height="43px" Text="Cancelar" Width="117px" OnClick="Button3_Click" class="btn btn-primary btn-lg"/>
         
          &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
         
           <br />
           <br />
        
        </div>

     <br />

      </div>





          </div>
</asp:Content>
