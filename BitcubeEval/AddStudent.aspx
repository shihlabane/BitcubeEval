<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="AddStudent.aspx.cs" Inherits="BitcubeEval.AddStudent" %>
<asp:Content ID="Content1" ContentPlaceHolderID="HeadContent" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="MainContent" runat="server">

 <div>
        
     <p style="font-size:medium"><asp:Label ID="lbllecturerName" runat="server" Text="lblLecturerName"></asp:Label>   
       <br />
     <asp:Label ID="lbllecturerEmail" runat="server" Text="LblLecturerEmail"></asp:Label></p>  
      <hr />
  </div>


  <div id="form">
  
  <ul>
  
    <li><asp:TextBox ID="Txtforename" runat="server" placeholder="forename"></asp:TextBox>
      <asp:RequiredFieldValidator ID="RequiredFieldValidator1" runat="server" 
          ControlToValidate="Txtforename" ErrorMessage="Required" ForeColor="Red" >*</asp:RequiredFieldValidator>
          </li>
      <li>      
      <asp:TextBox ID="TxtSurname" runat="server" placeholder="Surname"></asp:TextBox>
      <asp:RequiredFieldValidator ID="RequiredFieldValidator3" runat="server" 
          ControlToValidate="TxtSurname" ErrorMessage="Required" ForeColor="Red">*</asp:RequiredFieldValidator>
      </li>
            
       <li> 
      <asp:TextBox ID="TxtEmail" runat="server" placeholder="Email Address"></asp:TextBox>
      <asp:RegularExpressionValidator ID="RegularExpressionValidator1" runat="server" 
          ControlToValidate="TxtEmail" ErrorMessage="Not email format" ForeColor="Red" 
          ValidationExpression="\w+([-+.']\w+)*@\w+([-.]\w+)*\.\w+([-.]\w+)*">*</asp:RegularExpressionValidator>
      <asp:RequiredFieldValidator ID="RequiredFieldValidator4" runat="server" 
          ControlToValidate="TxtEmail" ErrorMessage="Required" ForeColor="Red">*</asp:RequiredFieldValidator>
      </li>
      <li>
    <asp:TextBox ID="TxtDateOfBirth" runat="server" placeholder="Month/Day/Year"></asp:TextBox>
      <asp:RequiredFieldValidator ID="RequiredFieldValidator5" runat="server" 
          ControlToValidate="TxtDateOfBirth" ErrorMessage="Required" ForeColor="Red">*</asp:RequiredFieldValidator>
          </li>
          <li>
      <asp:Button runat="server" Text="Submit" ID="btnSubmitStudent" 
                  onclick="btnSubmitStudent_Click" />
      </li>
          </ul>
  </div>


</asp:Content>
