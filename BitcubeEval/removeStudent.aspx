<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="removeStudent.aspx.cs" Inherits="BitcubeEval.removeStudent" %>
<asp:Content ID="Content1" ContentPlaceHolderID="HeadContent" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="MainContent" runat="server">


    <div>
        
     <p style="font-size:medium"><asp:Label ID="lbllecturerName" runat="server" Text="lblLecturerName"></asp:Label>   
       <br />
     <asp:Label ID="lbllecturerEmail" runat="server" Text="LblLecturerEmail"></asp:Label></p>  
      <hr />
   </div>
   <br />
    <h2>Remove Student from Degree</h2>
    <br />
    <br />

     

     

    Enter Degree Name<asp:TextBox ID="txtdegree" runat="server"></asp:TextBox>
    <br />
    Enter Student Name<asp:TextBox ID="txtstudentEmail" runat="server"></asp:TextBox>
    <br />
    <br />
    <asp:Button ID="BtnRemoveStudent" runat="server" Text="Submit" 
        onclick="BtnRemoveStudent_Click" />


</asp:Content>
