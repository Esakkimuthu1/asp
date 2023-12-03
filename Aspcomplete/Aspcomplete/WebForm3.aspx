<%@ Page Title="" Language="C#" MasterPageFile="~/Site1.Master" AutoEventWireup="true" CodeBehind="WebForm3.aspx.cs" Inherits="Aspcomplete.WebForm3" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <link href="sigin.css" rel="stylesheet" />
     <h1> Welome to Signup </h1>
    <br /> 
       <br /> 
       <br /> 
   <div>
      
       <asp:Label ID="Label1" runat="server" Text="User Name"></asp:Label>
       <asp:TextBox ID="TextBox1" runat="server"></asp:TextBox>
       <br /> 
       <br /> 
       <br /> 
       <asp:Label ID="Label2" runat="server" Text="Password"></asp:Label>
       <asp:TextBox ID="TextBox2" runat="server"></asp:TextBox>
        <br /> 
       <br /> 
       <br />

       <asp:Button ID="Button1" runat="server" Text="Signup" OnClick="Button1_Click" />
       <asp:Button ID="Button2" runat="server" Text="View data" OnClick="Button2_Click" />
       <asp:GridView ID="GridView1" runat="server" BackColor="White" BorderColor="#999999" BorderStyle="None" BorderWidth="1px" CellPadding="3" GridLines="Vertical" Height="183px" Width="599px">
           <AlternatingRowStyle BackColor="Gainsboro" />
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
       <p id="p">

       </p>
   </div>
</asp:Content>
