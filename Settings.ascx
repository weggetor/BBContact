<%@ Control Language="C#" AutoEventWireup="false" Inherits="Bitboxx.DNNModules.BBContact.Settings" Codebehind="Settings.ascx.cs" %>
<%@ Register TagPrefix="dnn" TagName="Label" Src="~/controls/LabelControl.ascx" %>
<div id="bbcontact-settings" class="dnnForm bbcontact-settings dnnClear">
    <fieldset>
        <div class="dnnFormItem">
            <dnn:Label ID="lblBootstrap" runat="server" ControlName="chkBootstrap" Suffix=":"/>
            <asp:CheckBox ID="chkBootstrap" runat="server"/>
        </div>
        <div class="dnnFormItem">
            <dnn:Label ID="lblSenderName" runat="server" ControlName="txtSenderName" Suffix=":"/>
            <asp:TextBox runat="server" ID="txtSenderName"/>
        </div>
        <div class="dnnFormItem">
            <dnn:Label ID="lblSenderEmail" runat="server" ControlName="txtSenderEmail" Suffix=":"/>
            <asp:TextBox runat="server" ID="txtSenderEmail"/>
        </div>
        <div class="dnnFormItem">
            <dnn:Label ID="lblRecipientEmail" runat="server" ControlName="txtRecipientEmail" Suffix=":"/>
            <asp:TextBox runat="server" ID="txtRecipientEmail"/>
        </div>
        <div class="dnnFormItem">
            <dnn:Label ID="lblSendToUser" runat="server" ControlName="chkSendToUser" Suffix=":"/>
            <asp:CheckBox runat="server" ID="chkSendToUser"/>
        </div>
        <div class="dnnFormItem">
            <dnn:Label ID="lblSubject" runat="server" ControlName="txtSubject" Suffix=":"/>
            <asp:TextBox runat="server" ID="txtSubject"/>
        </div>
        <div class="dnnFormItem">
            <dnn:Label ID="lblInterests" runat="server" ControlName="txtInterests" Suffix=":"/>
            <asp:TextBox runat="server" ID="txtInterests" Rows="4" TextMode="MultiLine" Font-Names='courier, "courier new", monospace' />
        </div>
        <div class="dnnFormItem">
            <dnn:Label ID="lblBodytext" runat="server" ControlName="txtBodytext" Suffix=":"/>
            <asp:TextBox runat="server" ID="txtBodytext" Rows="10" TextMode="MultiLine" Font-Names='courier, "courier new", monospace' />
        </div>
        <div class="dnnFormItem">
            <dnn:Label ID="lblFields" runat="server" ControlName="chkFirstnameVisible" Suffix=":"/>
            <table>
                <tr>
                    <th>&nbsp;</th>
                    <th><asp:Label runat="server" ID="lblVisible" Text="visible"/></th> 
                    <th><asp:Label runat="server" ID="lblMandatory" Text="mandatory"/></th> 
                </tr>
                <tr>
                    <td><asp:Label ID="lblFirstname" runat="server" ResourceKey="lblFirstname.Text"/></td>
                    <td><asp:CheckBox runat="server" ID="chkFirstnameVisible"/></td>
                    <td><asp:CheckBox runat="server" ID="chkFirstnameMandatory"/></td>
                </tr>
                <tr>
                    <td><asp:Label ID="lblLastname" runat="server" ResourceKey="lblLastname.Text"/></td>
                    <td><asp:CheckBox runat="server" ID="chkLastnameVisible"/></td>
                    <td><asp:CheckBox runat="server" ID="chkLastnameMandatory"/></td>
                </tr>
                <tr>
                    <td><asp:Label ID="lblOrganization" runat="server" ResourceKey="lblOrganization.Text"/></td>
                    <td><asp:CheckBox runat="server" ID="chkOrganizationVisible"/></td>
                    <td><asp:CheckBox runat="server" ID="chkOrganizationMandatory"/></td>
                </tr>
                <tr>
                    <td><asp:Label ID="lblAddress" runat="server" ResourceKey="lblAddress.Text"/></td>
                    <td><asp:CheckBox runat="server" ID="chkAddressVisible"/></td>
                    <td><asp:CheckBox runat="server" ID="chkAddressMandatory"/></td>
                </tr>
                <tr>
                    <td><asp:Label ID="lblPhone" runat="server" ResourceKey="lblPhone.Text"/></td>
                    <td><asp:CheckBox runat="server" ID="chkPhoneVisible"/></td>
                    <td><asp:CheckBox runat="server" ID="chkPhoneMandatory"/></td>
                </tr>
                <tr>
                    <td><asp:Label ID="lblFax" runat="server" ResourceKey="lblFax.Text"/></td>
                    <td><asp:CheckBox runat="server" ID="chkFaxVisible"/></td>
                    <td><asp:CheckBox runat="server" ID="chkFaxMandatory"/></td>
                </tr>
                <tr>
                    <td><asp:Label ID="lblEmail" runat="server" ResourceKey="lblEmail.Text"/></td>
                    <td><asp:CheckBox runat="server" ID="chkEmailVisible"/></td>
                    <td><asp:CheckBox runat="server" ID="chkEmailMandatory"/></td>
                </tr>
                <tr>
                    <td><asp:Label ID="lblInterest" runat="server" ResourceKey="lblInterest.Text"/></td>
                    <td><asp:CheckBox runat="server" ID="chkInterestVisible"/></td>
                    <td><asp:CheckBox runat="server" ID="chkInterestMandatory"/></td>
                </tr>
                <tr>
                    <td><asp:Label ID="lblProduct" runat="server" ResourceKey="lblProduct.Text"/></td>
                    <td><asp:CheckBox runat="server" ID="chkProductVisible"/></td>
                    <td><dnn:Label runat="server" ID="lblProductHelp" /></td>
                </tr>
                <tr>
                    <td><asp:Label ID="lblRemark" runat="server" ResourceKey="lblRemark.Text"/></td>
                    <td><asp:CheckBox runat="server" ID="chkRemarkVisible"/></td>
                    <td><asp:CheckBox runat="server" ID="chkRemarkMandatory"/></td>
                </tr>
                
            </table>
    </fieldset>
</div>