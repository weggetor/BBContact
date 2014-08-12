<%@ Control language="C#" Inherits="Bitboxx.DNNModules.BBContact.View" AutoEventWireup="true" Codebehind="View.ascx.cs" %>
<%@ Register TagPrefix="dnn" TagName="Label" Src="~/controls/LabelControl.ascx" %>
<div id="bbcontact-view" class="dnnForm bbcontact-view dnnClear">
    <fieldset>
        <asp:Panel CssClass="dnnFormItem" id="pnlFirstname" runat="server">
            <dnn:Label ID="lblFirstname" runat="server" ControlName="txtFirstname" Suffix=":"/>
            <asp:TextBox runat="server" ID="txtFirstname" CssClass="dnnFormInput"/>
            <asp:RequiredFieldValidator runat="server" ID="valFirstname" ControlToValidate="txtFirstname" Display="Dynamic" ResourceKey="valFirstname.Text" CssClass="dnnFormMessage dnnFormError" Visible="False"/>
        </asp:Panel>
        <asp:Panel CssClass="dnnFormItem" id="pnlLastname" runat="server">
            <dnn:Label ID="lblLastname" runat="server" ControlName="txtLastname" Suffix=":"/>
            <asp:TextBox runat="server" ID="txtLastname" CssClass="dnnFormInput"/>
            <asp:RequiredFieldValidator runat="server" ID="valLastname" ControlToValidate="txtLastname" Display="Dynamic" ResourceKey="valLastname.Text" CssClass="dnnFormMessage dnnFormError" Visible="False"/>
        </asp:Panel>
        <asp:Panel CssClass="dnnFormItem" id="pnlOrganization" runat="server">
            <dnn:Label ID="lblOrganization" runat="server" ControlName="txtOrganization" Suffix=":"/>
            <asp:TextBox runat="server" ID="txtOrganization" CssClass="dnnFormInput"/>
            <asp:RequiredFieldValidator runat="server" ID="valOrganization" ControlToValidate="txtOrganization" Display="Dynamic" ResourceKey="valOrganization.Text" CssClass="dnnFormMessage dnnFormError" Visible="False"/>
        </asp:Panel>
        <asp:Panel CssClass="dnnFormItem" id="pnlAddress" runat="server">
            <dnn:Label ID="lblAddress" runat="server" ControlName="txtAddress" Suffix=":"/>
            <asp:TextBox runat="server" ID="txtAddress" Rows="5" TextMode="MultiLine" CssClass="dnnFormInput"/>
            <asp:RequiredFieldValidator runat="server" ID="valAddress" ControlToValidate="txtAddress" Display="Dynamic" ResourceKey="valAddress.Text" CssClass="dnnFormMessage dnnFormError" Visible="False"/>
        </asp:Panel>
        <asp:Panel CssClass="dnnFormItem" id="pnlPhone" runat="server">
            <dnn:Label ID="lblPhone" runat="server" ControlName="txtPhone" Suffix=":"/>
            <asp:TextBox runat="server" ID="txtPhone" CssClass="dnnFormInput"/>
            <asp:RequiredFieldValidator runat="server" ID="valPhone" ControlToValidate="txtPhone" Display="Dynamic" ResourceKey="valPhone.Text" CssClass="dnnFormMessage dnnFormError" Visible="False"/>
        </asp:Panel>
         <asp:Panel CssClass="dnnFormItem" id="pnlFax" runat="server">
            <dnn:Label ID="lblFax" runat="server" ControlName="txtFax" Suffix=":"/>
            <asp:TextBox runat="server" ID="txtFax" CssClass="dnnFormInput"/>
            <asp:RequiredFieldValidator runat="server" ID="valFax" ControlToValidate="txtFax" Display="Dynamic" ResourceKey="valFax.Text" CssClass="dnnFormMessage dnnFormError" Visible="False"/>
        </asp:Panel>
        <asp:Panel CssClass="dnnFormItem" id="pnlEmail" runat="server">
            <dnn:Label ID="lblEmail" runat="server" ControlName="txtEmail" Suffix=":"/>
            <asp:TextBox runat="server" ID="txtEmail" CssClass="dnnFormInput"/>
            <asp:RequiredFieldValidator runat="server" ID="valEmail" ControlToValidate="txtEmail" Display="Dynamic" ResourceKey="valEmail.Text" CssClass="dnnFormMessage dnnFormError" Visible="False"/>
            <asp:RegularExpressionValidator runat="server" ID="valEmailOK" ControlToValidate="txtEmail" Display="Dynamic" ResourceKey="valEmailOK.Text" CssClass="dnnFormMessage dnnFormError"  />
        </asp:Panel>
        <asp:Panel CssClass="dnnFormItem" id="pnlRemark" runat="server">
            <dnn:Label ID="lblRemark" runat="server" ControlName="txtRemark" Suffix=":"/>
            <asp:TextBox runat="server" ID="txtRemark" Rows="5" TextMode="MultiLine" CssClass="dnnFormInput"/>
            <asp:RequiredFieldValidator runat="server" ID="valRemark" ControlToValidate="txtRemark" Display="Dynamic" ResourceKey="valRemark.Text" CssClass="dnnFormMessage dnnFormError" Visible="False"/>
        </asp:Panel>
        <div class="dnnFormItem">
            <dnn:Label ID="lblDummy" runat="server" ControlName="cmdSend" />
            <ul class="dnnActions dnnClear">
                <li><asp:LinkButton CssClass="dnnPrimaryAction" ID="cmdSend" runat="server" OnClick="cmdSend_Click" ResourceKey="cmdSend" /></li>
            </ul>
        </div>
    </fieldset>
</div>