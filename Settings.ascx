<%@ Control Language="C#" AutoEventWireup="false" Inherits="Bitboxx.DNNModules.BBContact.Settings" Codebehind="Settings.ascx.cs" %>
<%@ Register TagPrefix="dnn" TagName="Label" Src="~/controls/LabelControl.ascx" %>
<div id="bbcontact-settings" class="dnnForm bbcontact-settings dnnClear">
    <fieldset>
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
            <dnn:Label ID="lblBodyText" runat="server" ControlName="txtBodyText" Suffix=":"/>
            <asp:TextBox runat="server" ID="txtBodyText" Rows="10" TextMode="MultiLine"/>
        </div>
 </fieldset>
    <fieldset>
        <div class="dnnFormItem">
            <dnn:Label ID="lblFirstname" runat="server" ControlName="chkFirstnameMandatory" Suffix=":"/>
            <asp:CheckBox runat="server" ID="chkFirstnameVisible"/>
            <asp:CheckBox runat="server" ID="chkFirstnameMandatory"/>
        </div>
        <div class="dnnFormItem">
            <dnn:Label ID="lblLastname" runat="server" ControlName="chkLastnameMandatory" Suffix=":"/>
            <asp:CheckBox runat="server" ID="chkLastnameVisible"/>
            <asp:CheckBox runat="server" ID="chkLastnameMandatory"/>
        </div>
        <div class="dnnFormItem">
            <dnn:Label ID="lblOrganization" runat="server" ControlName="chkOrganizationMandatory" Suffix=":"/>
            <asp:CheckBox runat="server" ID="chkOrganizationVisible"/>
            <asp:CheckBox runat="server" ID="chkOrganizationMandatory"/>
        </div>
        <div class="dnnFormItem">
            <dnn:Label ID="lblAddress" runat="server" ControlName="chkAddressMandatory" Suffix=":"/>
            <asp:CheckBox runat="server" ID="chkAddressVisible"/>
            <asp:CheckBox runat="server" ID="chkAddressMandatory" />
        </div>
        <div class="dnnFormItem">
            <dnn:Label ID="lblPhone" runat="server" ControlName="chkPhoneMandatory" Suffix=":"/>
            <asp:CheckBox runat="server" ID="chkPhoneVisible"/>
            <asp:CheckBox runat="server" ID="chkPhoneMandatory"/>
        </div>
         <div class="dnnFormItem">
            <dnn:Label ID="lblFax" runat="server" ControlName="chkFaxMandatory" Suffix=":"/>
             <asp:CheckBox runat="server" ID="chkFaxVisible"/>
            <asp:CheckBox runat="server" ID="chkFaxMandatory"/>
        </div>
        <div class="dnnFormItem">
            <dnn:Label ID="lblEmail" runat="server" ControlName="chkEmailMandatory" Suffix=":"/>
            <asp:CheckBox runat="server" ID="chkEmailVisible"/>
            <asp:CheckBox runat="server" ID="chkEmailMandatory"/>
        </div>
        <div class="dnnFormItem">
            <dnn:Label ID="lblRemark" runat="server" ControlName="chkRemarkMandatory" Suffix=":"/>
            <asp:CheckBox runat="server" ID="chkRemarkVisible"/>
            <asp:CheckBox runat="server" ID="chkRemarkMandatory" />
        </div>
    </fieldset>
</div>