<%@ Page Title="Home Page" Language="C#" MasterPageFile="~/Site.master" AutoEventWireup="true"
    CodeBehind="Default.aspx.cs" Inherits="BitcubeEval._Default" %>

<asp:Content ID="HeaderContent" runat="server" ContentPlaceHolderID="HeadContent">
</asp:Content>
<asp:Content ID="BodyContent" runat="server" ContentPlaceHolderID="MainContent">
    
    <div>
       <p>
       
           Enter Lecture Name<asp:TextBox ID="TxtLecturerName" 
               runat="server"></asp:TextBox>
               <br />
           Enter lecture  Email&nbsp; <asp:TextBox ID="TxtLecturerEmail" runat="server"></asp:TextBox>
       </p>
       <p>
           <asp:Button ID="btnView" runat="server" Text="Submit" onclick="btnView_Click" />
  
            
            <asp:GridView ID="gvdStudent" runat="server" AutoGenerateColumns="False" 
               BackColor="White" BorderColor="#3366CC" BorderStyle="None" BorderWidth="1px" 
               CellPadding="4" onselectedindexchanged="gvdStudent_SelectedIndexChanged">
                <Columns>
                    <asp:BoundField DataField="surname" HeaderText="Surname" />
                    <asp:BoundField DataField="forename" HeaderText="Name" />
                    <asp:BoundField DataField="degreeName" HeaderText="Degree" />
                </Columns>
                <FooterStyle BackColor="#99CCCC" ForeColor="#003399" />
                <HeaderStyle BackColor="#003399" Font-Bold="True" ForeColor="#CCCCFF" />
                <PagerStyle BackColor="#99CCCC" ForeColor="#003399" HorizontalAlign="Left" />
                <RowStyle BackColor="White" ForeColor="#003399" />
                <SelectedRowStyle BackColor="#009999" Font-Bold="True" ForeColor="#CCFF99" />
                <SortedAscendingCellStyle BackColor="#EDF6F6" />
                <SortedAscendingHeaderStyle BackColor="#0D4AC4" />
                <SortedDescendingCellStyle BackColor="#D6DFDF" />
                <SortedDescendingHeaderStyle BackColor="#002876" />
            </asp:GridView> 

            
       
       </p>
    </div>
  
            
                   
</asp:Content>
