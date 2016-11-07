<%@ Page Title="Home Page" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Default.aspx.cs" Inherits="registration_validation._Default" %>

<asp:Content ID="BodyContent" ContentPlaceHolderID="MainContent" runat="server">

  <table>
      <tr>
      <td style="width:200px">FirstName</td>
      <td style="width:200px">
          <asp:TextBox ID="txtFirstName" runat="server"></asp:TextBox>
      </td>
          <td>
            <asp:RequiredFieldValidator ID="rqdFirstNameValidator" ControlToValidate="txtFirstName" runat="server" ErrorMessage="FirstName is required"></asp:RequiredFieldValidator>
          </td></tr>
       <tr>
      <td style="width:200px">LastName</td>
      <td style="width:200px">
          <asp:TextBox ID="txtLastName" runat="server"></asp:TextBox>
      </td>
           <td style="width:200px">
                 <asp:RequiredFieldValidator ID="rqdLastName" ControlToValidate="txtLastName" runat="server" ErrorMessage="LastName is required"></asp:RequiredFieldValidator>
           </td>
          </tr>
       <tr>
      <td style="width:200px">DateOfBirth</td>
      <td style="width:200px">
          <asp:TextBox ID="txtDOB" runat="server"></asp:TextBox>
      </td>
           <td style="width:200px">
                <asp:RequiredFieldValidator ID="rqdDOB" ControlToValidate="txtDOB" runat="server" ErrorMessage="DOB is required"></asp:RequiredFieldValidator>
           </td>
          </tr>
       <tr>
      <td style="width:200px">Age</td>
      <td style="width:200px">
          <asp:TextBox ID="txtAge" runat="server"></asp:TextBox>
      </td>
            <td style="width:200px">
           <asp:RequiredFieldValidator ID="rqdAge" ControlToValidate="txtAge" runat="server" ErrorMessage="Age is required"></asp:RequiredFieldValidator>
           <asp:RangeValidator ID="RangeValidator1" runat="server"  ControlToValidate="txtAge" ErrorMessage="Age must be in between 10 and 70" MinimumValue="10" MaximumValue="70"></asp:RangeValidator>
        
           </td>
          </tr>
       <tr>
      <td style="width:200px">Gender</td>
      <td style="width:200px">
          <asp:TextBox ID="txtGender" runat="server"></asp:TextBox>
      </td>
           
           <td style="width:200px">
                <asp:RequiredFieldValidator ID="rqdGender" ControlToValidate="txtGender" runat="server" ErrorMessage="Gender is required"></asp:RequiredFieldValidator>
           </td>
          </tr>
       <tr>
      <td style="width:200px">Email</td>
      <td style="width:200px">
          <asp:TextBox ID="txtEmail" runat="server"></asp:TextBox>
      </td>
           
           <td style="width:200px">
                <asp:RequiredFieldValidator ID="rqdEmail" ControlToValidate="txtEmail" runat="server" ErrorMessage="Email Id is required"></asp:RequiredFieldValidator>
           </td>
          </tr>
           <tr>
      <td style="width:200px">Email Confirm</td>
      <td style="width:200px">
          <asp:TextBox ID="txtEmailConfirm" runat="server"></asp:TextBox>
      </td>
           
           <td style="width:200px">
                <asp:RegularExpressionValidator ID="RegularExpressionValidator1" runat="server" ControlToValidate="txtEmail" ErrorMessage="Enter valid email" ValidationExpression="\w+([-+.']\w+)*@\w+([-.]\w+)*\.\w+([-.]\w+)*"></asp:RegularExpressionValidator>
                <br />
                <asp:CompareValidator ID="CompareValidator1" runat="server" ControlToCompare="txtEmail" ControlToValidate="txtEmailConfirm" ErrorMessage="Please enter same email id"></asp:CompareValidator>
                <asp:RequiredFieldValidator ID="RequiredFieldValidator1" ControlToValidate="txtEmail" runat="server" ErrorMessage="Reenter Email Id"></asp:RequiredFieldValidator>
             
                </td>
          </tr>
       <tr>
      <td style="width:200px">PhoneNo</td>
      <td style="width:200px">
          <asp:TextBox ID="txtphoneNo" runat="server"></asp:TextBox>
      </td>
           
           <td style="width:200px"></td>
           </tr>
             <tr>
      <td style="width:200px">Location</td>
      <td style="width:200px">
          <asp:TextBox ID="txtLocation" runat="server"></asp:TextBox>
      </td> 
                 
           <td style="width:200px">
                <asp:RequiredFieldValidator ID="rqdLocation" ControlToValidate="txtLocation" runat="server" ErrorMessage="Location is required"></asp:RequiredFieldValidator>
           </td>
             </tr>   
       <tr>
      <td style="width:200px">Address</td>
      <td style="width:200px">
          <asp:TextBox ID="txtAddress" runat="server"></asp:TextBox>
      </td>
           
           <td style="width:200px">
                <asp:RequiredFieldValidator ID="rqdAddress" ControlToValidate="txtAddress" runat="server" ErrorMessage="Address is required"></asp:RequiredFieldValidator>
           </td>
          </tr> 
      <tr>
      <td colspan="3">
          <asp:Button ID="btnSave" CausesValidation="true" runat="server" OnClick="btnSave_Click" Text="Save"> </asp:Button>
      </td>
          </tr> 
  </table>
</asp:Content>
