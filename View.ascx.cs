using System;
using System.Drawing;
using System.IO;
using System.Net.Mail;
using System.Net.Mime;
using DotNetNuke.Common;
using DotNetNuke.Services.Exceptions;
using DotNetNuke.Entities.Modules;
using DotNetNuke.UI.Skins.Controls;
using FileInfo = DotNetNuke.Services.FileSystem.FileInfo;

namespace Bitboxx.DNNModules.BBContact
{

    /// <summary>
    /// The View class displays the content
    /// </summary>

    [DNNtc.PackageProperties("BBContact", 1, "BBContact", "BBContact", "BBContact.png", "Torsten Weggen", "bitboxx solutions", "http://www.bitboxx.net", "info@bitboxx.net", true)]
    [DNNtc.ModuleProperties("BBContact", "BBContact", 0)]
    [DNNtc.ModuleDependencies(DNNtc.ModuleDependency.CoreVersion, "06.01.00")]
    [DNNtc.ModuleControlProperties("", "BBContact", DNNtc.ControlType.View, "", true, false)]
    public partial class View : PortalModuleBase
    {

        #region Event Handlers

        /// <summary>
        /// Runs when the control is loaded
        /// </summary>
        private void Page_Load(object sender, EventArgs e)
        {
            try
            {
                if (!Page.IsPostBack)
                {
                    bool bootstrap = Convert.ToBoolean(Settings["Bootstrap"]);
                    pnlSendButtonBootstrap.Visible = bootstrap;
                    pnlSendButtonDnn.Visible = !bootstrap;

                    string formGroupClass = "dnnFormItem";
                    string formInputClass = "dnnFormInput";
                    string formSubmitClass = "dnnPrimaryAction";
                    string formLabelClass = "dnnLabel";
                    string formRequiredClass = " dnnFormRequired";
                    string formErrorClass = "dnnFormMessage dnnFormError";
                    if (bootstrap)
                    {
                        formGroupClass = "form-group";
                        formInputClass = "form-control";
                        formSubmitClass = "btn btn-primary";
                        formLabelClass = "";
                        formRequiredClass = "";
                        formErrorClass = "valError";
                    }
                    else
                    {
                        pnlBBContact.Attributes["class"] += "dnnForm dnnClear";
                    }
                    
                    valEmailOK.ValidationExpression = Globals.glbEmailRegEx;

                    if (!String.IsNullOrEmpty((string) Settings["VisibleFirstname"]) && Convert.ToBoolean(Settings["VisibleFirstname"]))
                    {
                        pnlFirstname.CssClass = formGroupClass;
                        txtFirstname.CssClass = formInputClass;
                        lblFirstname.Attributes["class"] = formLabelClass;
                        lblFirstname.InnerText = LocalizeString("lblFirstname.Text");
                        if (!String.IsNullOrEmpty((string) Settings["EnsureFirstname"]) && Convert.ToBoolean(Settings["EnsureFirstname"]))
                        {
                            pnlFirstname.CssClass += formRequiredClass;
                            txtFirstname.CssClass += formRequiredClass;
                            txtFirstname.Attributes["required"] = "required";
                            lblFirstname.Attributes["class"] += formRequiredClass;
                            valFirstname.Visible = true;
                            valFirstname.Attributes["class"] += formErrorClass;
                        }
                    }
                    else
                    {
                        pnlFirstname.Visible = false;
                    }

                    if (!String.IsNullOrEmpty((string)Settings["VisibleLastname"]) && Convert.ToBoolean(Settings["VisibleLastname"]))
                    {
                        pnlLastname.CssClass = formGroupClass;
                        txtLastname.CssClass = formInputClass;
                        lblLastname.Attributes["class"] = formLabelClass;
                        lblLastname.InnerText = LocalizeString("lblLastname.Text");
                        if (!String.IsNullOrEmpty((string) Settings["EnsureLastname"]) && Convert.ToBoolean(Settings["EnsureLastname"]))
                        {
                            pnlLastname.CssClass += formRequiredClass;
                            txtLastname.CssClass += formRequiredClass;
                            txtLastname.Attributes["required"] = "required";
                            lblLastname.Attributes["class"] += formRequiredClass;
                            valLastname.Visible = true;
                            valLastname.Attributes["class"] += formErrorClass;
                        }
                    }
                    else
                    {
                        pnlLastname.Visible = false;
                    }

                    if (!String.IsNullOrEmpty((string)Settings["VisibleOrganization"]) && Convert.ToBoolean(Settings["VisibleOrganization"]))
                    {
                        pnlOrganization.CssClass = formGroupClass;
                        txtOrganization.CssClass = formInputClass;
                        lblOrganization.Attributes["class"] = formLabelClass;
                        lblOrganization.InnerText = LocalizeString("lblOrganization.Text");
                        if (!String.IsNullOrEmpty((string) Settings["EnsureOrganization"]) && Convert.ToBoolean(Settings["EnsureOrganization"]))
                        {
                            pnlOrganization.CssClass += formRequiredClass;
                            txtOrganization.CssClass += formRequiredClass;
                            txtOrganization.Attributes["required"] = "required";
                            lblOrganization.Attributes["class"] += formRequiredClass;
                            valOrganization.Visible = true;
                            valOrganization.Attributes["class"] += formErrorClass;
                        }
                    }
                    else
                    {
                        pnlOrganization.Visible = false;
                    }

                    if (!String.IsNullOrEmpty((string)Settings["VisibleAddress"]) && Convert.ToBoolean(Settings["VisibleAddress"]))
                    {
                        pnlAddress.CssClass = formGroupClass;
                        txtAddress.CssClass = formInputClass;
                        lblAddress.Attributes["class"] = formLabelClass;
                        lblAddress.InnerText = LocalizeString("lblAddress.Text");
                        if (!String.IsNullOrEmpty((string) Settings["EnsureAddress"]) && Convert.ToBoolean(Settings["EnsureAddress"]))
                        {
                            pnlAddress.CssClass += formRequiredClass;
                            txtAddress.CssClass += formRequiredClass;
                            txtAddress.Attributes["required"] = "required";
                            lblAddress.Attributes["class"] += formRequiredClass;
                            valAddress.Visible = true;
                            valAddress.Attributes["class"] += formErrorClass;
                        }
                    }
                    else
                    {
                        pnlAddress.Visible = false;
                    }

                    if (!String.IsNullOrEmpty((string)Settings["VisiblePhone"]) && Convert.ToBoolean(Settings["VisiblePhone"]))
                    {
                        pnlPhone.CssClass = formGroupClass;
                        txtPhone.CssClass = formInputClass;
                        lblPhone.Attributes["class"] = formLabelClass;
                        lblPhone.InnerText = LocalizeString("lblPhone.Text");
                        if (!String.IsNullOrEmpty((string) Settings["EnsurePhone"]) && Convert.ToBoolean(Settings["EnsurePhone"]))
                        {
                            pnlPhone.CssClass += formRequiredClass;
                            txtPhone.CssClass += formRequiredClass;
                            txtPhone.Attributes["required"] = "required";
                            lblPhone.Attributes["class"] += formRequiredClass;
                            valPhone.Visible = true;
                            valPhone.Attributes["class"] += formErrorClass;
                        }
                    }
                    else
                    {
                        pnlPhone.Visible = false;
                    }

                    if (!String.IsNullOrEmpty((string)Settings["VisibleFax"]) && Convert.ToBoolean(Settings["VisibleFax"]))
                    {
                        pnlFax.CssClass = formGroupClass;
                        txtFax.CssClass = formInputClass;
                        lblFax.Attributes["class"] = formLabelClass;
                        lblFax.InnerText = LocalizeString("lblFax.Text");
                        if (!String.IsNullOrEmpty((string) Settings["EnsureFax"]) && Convert.ToBoolean(Settings["EnsureFax"]))
                        {
                            pnlFax.CssClass += formRequiredClass;
                            txtFax.CssClass += formRequiredClass;
                            txtFax.Attributes["required"] = "required";
                            lblFax.Attributes["class"] += formRequiredClass;
                            valFax.Visible = true;
                            valFax.Attributes["class"] += formErrorClass;
                        }
                    }
                    else
                    {
                        pnlFax.Visible = false;
                    }

                    if (!String.IsNullOrEmpty((string)Settings["VisibleEmail"]) && Convert.ToBoolean(Settings["VisibleEmail"]))
                    {
                        pnlEmail.CssClass = formGroupClass;
                        txtEmail.CssClass = formInputClass;
                        lblEmail.Attributes["class"] = formLabelClass;
                        lblEmail.InnerText = LocalizeString("lblEmail.Text");
                        if (!String.IsNullOrEmpty((string) Settings["EnsureEmail"]) && Convert.ToBoolean(Settings["EnsureEmail"]))
                        {
                            pnlEmail.CssClass += formRequiredClass;
                            txtEmail.CssClass += formRequiredClass;
                            txtEmail.Attributes["required"] = "required";
                            lblEmail.Attributes["class"] += formRequiredClass;
                            valEmail.Visible = true;
                            valEmail.Attributes["class"] += formErrorClass;
                            valEmailOK.Attributes["class"] += formErrorClass;
                        }
                    }
                    else
                    {
                        pnlEmail.Visible = false;
                    }

                    if (!String.IsNullOrEmpty((string)Settings["VisibleInterest"]) && Convert.ToBoolean(Settings["VisibleInterest"]))
                    {
                        string[] interestValues = ((string) Settings["Interest"]).Split(',');
                        ddlInterest.DataSource = interestValues;
                        ddlInterest.DataBind();
                        ddlInterest.SelectedIndex = 0;
                        
                        pnlInterest.CssClass = formGroupClass;
                        ddlInterest.CssClass = formInputClass;
                        lblInterest.Attributes["class"] = formLabelClass;
                        lblInterest.InnerText = LocalizeString("lblInterest.Text");
                        if (!String.IsNullOrEmpty((string)Settings["EnsureInterest"]) && Convert.ToBoolean(Settings["EnsureInterest"]))
                        {
                            pnlInterest.CssClass += formRequiredClass;
                            ddlInterest.CssClass += formRequiredClass;
                            ddlInterest.Attributes["required"] = "required";
                            lblInterest.Attributes["class"] += formRequiredClass;
                            valInterest.Visible = true;
                            valInterest.Attributes["class"] += formErrorClass;
                        }
                    }
                    else
                    {
                        pnlInterest.Visible = false;
                    }

                    pnlProduct.Visible = false;
                    if (!String.IsNullOrEmpty((string) Settings["VisibleProduct"]) && Convert.ToBoolean(Settings["VisibleProduct"]))
                    {
                        pnlProduct.CssClass = formGroupClass;
                        lblProduct.Attributes["class"] = formLabelClass;
                        lblProduct.InnerText = LocalizeString("lblProduct.Text");

                        string imgFile = "~" + PortalSettings.HomeDirectory + "Images/BBContact/Standard-" + ModuleId.ToString() + ".png";
                        if (!File.Exists(MapPath(imgFile)))
                            imgFile = "~" + PortalSettings.HomeDirectory + "Images/BBContact/Standard.png";

                        if (Request["product"] != null)
                        {
                            hidProduct.Value = Request["product"];
                            imgFile = "~" + PortalSettings.HomeDirectory + "Images/BBContact/" + Request["product"].Trim() + ".png";
                        }
                        if (File.Exists(MapPath(imgFile)))
                        {
                            System.Drawing.Image img = System.Drawing.Image.FromFile(MapPath(imgFile));
                            imgProduct.Style.Add("width", "100%");
                            imgProduct.Attributes.Add("alt",Request["product"] ?? "");
                            imgProduct.ImageUrl = imgFile;
                            pnlProduct.Visible = true;
                        }
                    }

                    if (!String.IsNullOrEmpty((string)Settings["VisibleRemark"]) && Convert.ToBoolean(Settings["VisibleRemark"]))
                    {
                        pnlRemark.CssClass = formGroupClass;
                        txtRemark.CssClass = formInputClass;
                        lblRemark.Attributes["class"] = formLabelClass;
                        lblRemark.InnerText = LocalizeString("lblRemark.Text");
                        if (!String.IsNullOrEmpty((string) Settings["EnsureRemark"]) && Convert.ToBoolean(Settings["EnsureRemark"]))
                        {
                            pnlRemark.CssClass += formRequiredClass;
                            txtRemark.CssClass += formRequiredClass;
                            txtRemark.Attributes["required"] = "required";
                            lblRemark.Attributes["class"] += formRequiredClass;
                            valRemark.Visible = true;
                            valRemark.Attributes["class"] += formErrorClass;
                        }
                    }
                    else
                    {
                        pnlRemark.Visible = false;
                    }

                    cmdSendDnn.CssClass = formSubmitClass;
                    cmdSendBootstrap.CssClass = formSubmitClass;
                }
            }
            catch (Exception exc) //Module failed to load
            {
                Exceptions.ProcessModuleLoadException(this, exc);
            }
        }

        #endregion

        protected void cmdSend_Click(object sender, EventArgs e)
        {
            try
            {
                if (String.IsNullOrWhiteSpace(txtSpamVerification.Text))
                {
                    SendContactMail();
                    DotNetNuke.UI.Skins.Skin.AddModuleMessage(this, LocalizeString("ResultOK.Text"), ModuleMessage.ModuleMessageType.GreenSuccess);
                    txtFirstname.Text = "";
                    txtLastname.Text = "";
                    txtOrganization.Text = "";
                    txtAddress.Text = "";
                    txtPhone.Text = "";
                    txtFax.Text = "";
                    txtEmail.Text = "";
                    txtRemark.Text = "";
                    pnlProduct.Visible = false;
                }
            }
            catch (Exception ex)
            {
                DotNetNuke.UI.Skins.Skin.AddModuleMessage(this, String.Format(LocalizeString("ResultError.Text"),ex.Message), ModuleMessage.ModuleMessageType.RedError);
                var objEventLog = new DotNetNuke.Services.Log.EventLog.EventLogController();
                objEventLog.AddLog("Error sending form", ex.ToString(), PortalSettings, UserId, DotNetNuke.Services.Log.EventLog.EventLogController.EventLogType.ADMIN_ALERT);
            }
        }

        internal void SendContactMail()
        {
            string senderMail = (string)Settings["SenderEmail"];
            senderMail = String.IsNullOrWhiteSpace(senderMail) ? "[EMAIL]" : senderMail;
            senderMail = senderMail.Replace("[EMAIL]", txtEmail.Text.Trim());

            string interest = ddlInterest.SelectedIndex > -1 ? ddlInterest.SelectedValue.Trim() : "";

            string senderName = (string)Settings["SenderName"];
            senderName = String.IsNullOrWhiteSpace(senderName) ? "[FIRSTNAME] [LASTNAME]" : senderName;
            senderName = senderName.Replace("[FIRSTNAME]", txtFirstname.Text.Trim())
                    .Replace("[LASTNAME]", txtLastname.Text.Trim())
                    .Replace("[ORGANIZATION]", txtOrganization.Text.Trim())
                    .Replace("[ADDRESS]", txtAddress.Text.Trim())
                    .Replace("[PHONE]", txtPhone.Text.Trim())
                    .Replace("[FAX]", txtFax.Text.Trim())
                    .Replace("[EMAIL]", txtEmail.Text.Trim())
                    .Replace("[INTEREST]", interest)
                    .Replace("[PRODUCT]", hidProduct.Value)
                    .Replace("[REMARK]", txtRemark.Text.Trim());

            string subject = (string)Settings["Subject"] ?? "Contact form submission from [EMAIL]";
            string recipientEmail = (string)Settings["RecipientEmail"] ?? "";

            try
            {
                // http://www.systemnetmail.com

                MailMessage mail = new MailMessage();

                //set the addresses
                string smtpServer = DotNetNuke.Entities.Host.Host.SMTPServer;
                string smtpAuthentication = DotNetNuke.Entities.Host.Host.SMTPAuthentication;
                string smtpUsername = DotNetNuke.Entities.Host.Host.SMTPUsername;
                string smtpPassword = DotNetNuke.Entities.Host.Host.SMTPPassword;

                mail.From = new MailAddress("\"" + senderName.Trim() + "\" <" + senderMail.Trim() + ">");
                mail.To.Add(recipientEmail);
                if (Settings["SendToUser"] != null && Convert.ToBoolean(Settings["SendToUser"]))
                    mail.To.Add(txtEmail.Text.Trim());

                mail.Subject = subject.Replace("[FIRSTNAME]", txtFirstname.Text.Trim())
                    .Replace("[LASTNAME]", txtLastname.Text.Trim())
                    .Replace("[ORGANIZATION]", txtOrganization.Text.Trim())
                    .Replace("[ADDRESS]", txtAddress.Text.Trim())
                    .Replace("[PHONE]", txtPhone.Text.Trim())
                    .Replace("[FAX]", txtFax.Text.Trim())
                    .Replace("[EMAIL]", txtEmail.Text.Trim())
                    .Replace("[INTEREST]", interest)
                    .Replace("[PRODUCT]", hidProduct.Value)
                    .Replace("[REMARK]", txtRemark.Text.Trim());

                mail.Body = ((string)Settings["Bodytext"])
                    .Replace("[FIRSTNAME]", txtFirstname.Text.Trim())
                    .Replace("[LASTNAME]", txtLastname.Text.Trim())
                    .Replace("[ORGANIZATION]", txtOrganization.Text.Trim())
                    .Replace("[ADDRESS]", txtAddress.Text.Trim())
                    .Replace("[PHONE]", txtPhone.Text.Trim())
                    .Replace("[FAX]", txtFax.Text.Trim())
                    .Replace("[EMAIL]", txtEmail.Text.Trim())
                    .Replace("[INTEREST]", interest)
                    .Replace("[PRODUCT]", hidProduct.Value)
                    .Replace("[REMARK]", txtRemark.Text.Trim());
                

                SmtpClient emailClient = new SmtpClient(smtpServer);
                if (smtpAuthentication == "1")
                {
                    System.Net.NetworkCredential SMTPUserInfo = new System.Net.NetworkCredential(smtpUsername, smtpPassword);
                    emailClient.UseDefaultCredentials = false;
                    emailClient.Credentials = SMTPUserInfo;
                }
                emailClient.Send(mail);
            }
            catch (SmtpException sex)
            {
                Exceptions.LogException(sex);
                throw;
            }
            catch (Exception ex)
            {
                Exceptions.LogException(ex);
                throw;
            }
        }
    }
}
