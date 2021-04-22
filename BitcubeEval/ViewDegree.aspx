<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="ViewDegree.aspx.cs" Inherits="BitcubeEval.ViewDegree" %>
<asp:Content ID="Content1" ContentPlaceHolderID="HeadContent" runat="server">
</asp:Content>

<asp:Content ID="Content2" ContentPlaceHolderID="MainContent" runat="server">

   <div>
        
     <p style="font-size:medium"><asp:Label ID="lbllecturerName" runat="server" Text="lblLecturerName"></asp:Label>   
       <br />
     <asp:Label ID="lbllecturerEmail" runat="server" Text="LblLecturerEmail"></asp:Label></p>  
      <hr />
   </div>


    <asp:Button ID="btnViewDegree" runat="server" Text="View Degree" 
        onclick="btnViewDegree_Click" />

        <br />

   <div class="gridview">
   <asp:GridView ID="gvdDegree" runat="server" AutoGenerateColumns="False" 
           BackColor="White" BorderColor="#3366CC" BorderStyle="None" BorderWidth="1px" 
           CellPadding="4" onselectedindexchanged="gvdDegree_SelectedIndexChanged">
       <Columns>
           <asp:ButtonField ButtonType="Button" CommandName="Select" ShowHeader="True" 
               Text="Select" />
           <asp:BoundField DataField="degreeName" HeaderText="Degree" />
           <asp:BoundField DataField="degreeDurationInYear" 
               HeaderText="Duration In Years" />
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
   <asp:GridView ID="gvdCourse" runat="server" AutoGenerateColumns="False" 
           BackColor="White" BorderColor="#3366CC" BorderStyle="None" BorderWidth="1px" 
           CellPadding="4">
       <Columns>
           <asp:BoundField DataField="courseName" HeaderText="Course" />
           <asp:BoundField DataField="courseDurationInMonths" 
               HeaderText="Duration In Months" />
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
   </div>
    
</asp:Content>
