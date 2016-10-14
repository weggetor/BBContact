<%@ Control language="C#" Inherits="Bitboxx.DNNModules.BBContact.View" AutoEventWireup="true" Codebehind="View.ascx.cs" %>
<%@ Register TagPrefix="dnn" TagName="Label" Src="~/controls/LabelControl.ascx" %>
<div id="pnlBBContact" class="bbcontact-view" runat="server">
    <fieldset>
        <asp:Panel id="pnlFirstname" runat="server">
            <Label ID="lblFirstname" runat="server" for="txtFirstname" />
            <asp:TextBox runat="server" ID="txtFirstname" />
            <asp:RequiredFieldValidator runat="server" ID="valFirstname" ControlToValidate="txtFirstname" Display="Dynamic" ResourceKey="valFirstname.Text" Visible="False"/>
        </asp:Panel>
        <asp:Panel id="pnlLastname" runat="server">
            <Label ID="lblLastname" runat="server" for="txtLastname" />
            <asp:TextBox runat="server" ID="txtLastname" />
            <asp:RequiredFieldValidator runat="server" ID="valLastname" ControlToValidate="txtLastname" Display="Dynamic" ResourceKey="valLastname.Text"  Visible="False"/>
        </asp:Panel>
        <asp:Panel id="pnlOrganization" runat="server">
            <Label ID="lblOrganization" runat="server" for="txtOrganization" />
            <asp:TextBox runat="server" ID="txtOrganization"/>
            <asp:RequiredFieldValidator runat="server" ID="valOrganization" ControlToValidate="txtOrganization" Display="Dynamic" ResourceKey="valOrganization.Text" Visible="False"/>
        </asp:Panel>
        <asp:Panel id="pnlAddress" runat="server">
            <Label ID="lblAddress" runat="server" for="txtAddress" />
            <asp:TextBox runat="server" ID="txtAddress" Rows="5" TextMode="MultiLine" />
            <asp:RequiredFieldValidator runat="server" ID="valAddress" ControlToValidate="txtAddress" Display="Dynamic" ResourceKey="valAddress.Text" Visible="False"/>
        </asp:Panel>
        <asp:Panel id="pnlPhone" runat="server">
            <Label ID="lblPhone" runat="server" for="txtPhone" />
            <asp:TextBox runat="server" ID="txtPhone" />
            <asp:RequiredFieldValidator runat="server" ID="valPhone" ControlToValidate="txtPhone" Display="Dynamic" ResourceKey="valPhone.Text" Visible="False"/>
        </asp:Panel>
         <asp:Panel id="pnlFax" runat="server">
            <Label ID="lblFax" runat="server" for="txtFax" />
            <asp:TextBox runat="server" ID="txtFax" />
            <asp:RequiredFieldValidator runat="server" ID="valFax" ControlToValidate="txtFax" Display="Dynamic" ResourceKey="valFax.Text" Visible="False"/>
        </asp:Panel>
        <asp:Panel id="pnlEmail" runat="server">
            <Label ID="lblEmail" runat="server" for="txtEmail" />
            <asp:TextBox runat="server" ID="txtEmail" />
            <asp:RequiredFieldValidator runat="server" ID="valEmail" ControlToValidate="txtEmail" Display="Dynamic" ResourceKey="valEmail.Text" Visible="False"/>
            <asp:RegularExpressionValidator runat="server" ID="valEmailOK" ControlToValidate="txtEmail" Display="Dynamic" ResourceKey="valEmailOK.Text"   />
        </asp:Panel>
        <asp:Panel runat="server" ID="pnlInterest">
            <Label ID="lblInterest" runat="server" for="ddlInterest" />
            <asp:DropDownList runat="server" ID="ddlInterest"/>
            <asp:RequiredFieldValidator runat="server" ID="valInterest" ControlToValidate="ddlInterest" Display="Dynamic" ResourceKey="valInterest.Text" Visible="False"/>
        </asp:Panel>
        <asp:Panel runat="server" ID="pnlProduct">
            <Label ID="lblProduct" runat="server" for="imgProduct" />
            <asp:Image runat="server" ID="imgProduct"/>
            <asp:HiddenField runat="server" ID="hidProduct"/>
        </asp:Panel>
        <asp:Panel id="pnlRemark" runat="server">
            <Label ID="lblRemark" runat="server" for="txtRemark" />
            <asp:TextBox runat="server" ID="txtRemark" Rows="5" TextMode="MultiLine" />
            <asp:RequiredFieldValidator runat="server" ID="valRemark" ControlToValidate="txtRemark" Display="Dynamic" ResourceKey="valRemark.Text" Visible="False"/>
        </asp:Panel>
        <asp:Panel runat="server" ID="pnlSendButtonDnn">
            <div class="dnnFormItem">
                <dnn:Label ID="lblDummy" runat="server" ControlName="cmdSend" />
                <ul class="dnnActions dnnClear">
                    <li><asp:LinkButton CssClass="dnnPrimaryAction" ID="cmdSendDnn" runat="server" OnClick="cmdSend_Click" ResourceKey="cmdSend" /></li>
                </ul>
            </div>
        </asp:Panel>
        <asp:Panel runat="server" ID="pnlSendButtonBootstrap">
            <asp:LinkButton CssClass="btn btn-primary" ID="cmdSendBootstrap" runat="server" OnClick="cmdSend_Click" ResourceKey="cmdSend" />
        </asp:Panel>
        <div class="spamdefend">
            <asp:TextBox runat="server" ID="txtSpamVerification"/>
        </div>

    </fieldset>
</div>
