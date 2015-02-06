using System;
using System.Net.Mail;
using DotNetNuke.Common;
using DotNetNuke.Services.Exceptions;
using DotNetNuke.Entities.Modules;
using DotNetNuke.UI.Skins.Controls;

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
                    valEmailOK.ValidationExpression = Globals.glbEmailRegEx;

                    if (!String.IsNullOrEmpty((string) Settings["VisibleFirstname"]) && Convert.ToBoolean(Settings["VisibleFirstname"]))
                    {
                        if (!String.IsNullOrEmpty((string) Settings["EnsureFirstname"]) && Convert.ToBoolean(Settings["EnsureFirstname"]))
                        {
                            pnlFirstname.CssClass += " dnnFormRequired";
                            txtFirstname.CssClass += " dnnFormRequired";
                            valFirstname.Visible = true;
                        }
                    }
                    else
                    {
                        pnlFirstname.Visible = false;
                    }

                    if (!String.IsNullOrEmpty((string)Settings["VisibleLastname"]) && Convert.ToBoolean(Settings["VisibleLastname"]))
                    {
                        if (!String.IsNullOrEmpty((string) Settings["EnsureLastname"]) && Convert.ToBoolean(Settings["EnsureLastname"]))
                        {
                            pnlLastname.CssClass += " dnnFormRequired";
                            txtLastname.CssClass += " dnnFormRequired";
                            valLastname.Visible = true;
                        }
                    }
                    else
                    {
                        pnlLastname.Visible = false;
                    }

                    if (!String.IsNullOrEmpty((string)Settings["VisibleOrganization"]) && Convert.ToBoolean(Settings["VisibleOrganization"]))
                    {
                        if (!String.IsNullOrEmpty((string) Settings["EnsureOrganization"]) && Convert.ToBoolean(Settings["EnsureOrganization"]))
                        {
                            pnlOrganization.CssClass += " dnnFormRequired";
                            txtOrganization.CssClass += " dnnFormRequired";
                            valOrganization.Visible = true;
                        }
                    }
                    else
                    {
                        pnlOrganization.Visible = false;
                    }

                    if (!String.IsNullOrEmpty((string)Settings["VisibleAddress"]) && Convert.ToBoolean(Settings["VisibleAddress"]))
                    {
                        if (!String.IsNullOrEmpty((string) Settings["EnsureAddress"]) && Convert.ToBoolean(Settings["EnsureAddress"]))
                        {
                            pnlAddress.CssClass += " dnnFormRequired";
                            txtAddress.CssClass += " dnnFormRequired";
                            valAddress.Visible = true;
                        }
                    }
                    else
                    {
                        pnlAddress.Visible = false;
                    }

                    if (!String.IsNullOrEmpty((string)Settings["VisiblePhone"]) && Convert.ToBoolean(Settings["VisiblePhone"]))
                    {
                        if (!String.IsNullOrEmpty((string) Settings["EnsurePhone"]) && Convert.ToBoolean(Settings["EnsurePhone"]))
                        {
                            pnlPhone.CssClass += " dnnFormRequired";
                            txtPhone.CssClass += " dnnFormRequired";
                            valPhone.Visible = true;
                        }
                    }
                    else
                    {
                        pnlPhone.Visible = false;
                    }

                    if (!String.IsNullOrEmpty((string)Settings["VisibleFax"]) && Convert.ToBoolean(Settings["VisibleFax"]))
                    {
                        if (!String.IsNullOrEmpty((string) Settings["EnsureFax"]) && Convert.ToBoolean(Settings["EnsureFax"]))
                        {
                            pnlFax.CssClass += " dnnFormRequired";
                            txtFax.CssClass += " dnnFormRequired";
                            valFax.Visible = true;
                        }
                    }
                    else
                    {
                        pnlFax.Visible = false;
                    }

                    if (!String.IsNullOrEmpty((string)Settings["VisibleEmail"]) && Convert.ToBoolean(Settings["VisibleEmail"]))
                    {
                        if (!String.IsNullOrEmpty((string) Settings["EnsureEmail"]) && Convert.ToBoolean(Settings["EnsureEmail"]))
                        {
                            pnlEmail.CssClass += " dnnFormRequired";
                            txtEmail.CssClass += " dnnFormRequired";
                            valEmail.Visible = true;
                        }
                    }
                    else
                    {
                        pnlEmail.Visible = false;
                    }

                    if (!String.IsNullOrEmpty((string)Settings["VisibleRemark"]) && Convert.ToBoolean(Settings["VisibleRemark"]))
                    {
                        if (!String.IsNullOrEmpty((string) Settings["EnsureRemark"]) && Convert.ToBoolean(Settings["EnsureRemark"]))
                        {
                            pnlRemark.CssClass += " dnnFormRequired";
                            txtRemark.CssClass += " dnnFormRequired";
                            valRemark.Visible = true;
                        }
                    }
                    else
                    {
                        pnlRemark.Visible = false;
                    }
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
                }
            }
            catch (Exception ex)
            {
                DotNetNuke.UI.Skins.Skin.AddModuleMessage(this, String.Format(LocalizeString("ResultError.Text"),ex.Message), ModuleMessage.ModuleMessageType.RedError);
            }
        }


        internal void SendContactMail()
        {
            string senderMail = (string)Settings["SenderEmail"];
            senderMail = String.IsNullOrWhiteSpace(senderMail) ? "[EMAIL]" : senderMail;
            senderMail = senderMail.Replace("[EMAIL]", txtEmail.Text.Trim());

            string senderName = (string)Settings["SenderName"];
            senderName = String.IsNullOrWhiteSpace(senderName) ? "[FIRSTNAME] [LASTNAME]" : senderName;
            senderName = senderName.Replace("[FIRSTNAME]", txtFirstname.Text.Trim())
                    .Replace("[LASTNAME]", txtLastname.Text.Trim())
                    .Replace("[ORGANIZATION]", txtOrganization.Text.Trim())
                    .Replace("[ADDRESS]", txtAddress.Text.Trim())
                    .Replace("[PHONE]", txtPhone.Text.Trim())
                    .Replace("[FAX]", txtFax.Text.Trim())
                    .Replace("[EMAIL]", txtEmail.Text.Trim())
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
                    .Replace("[REMARK]", txtRemark.Text.Trim());

                mail.Body = ((string)Settings["Bodytext"])
                    .Replace("[FIRSTNAME]", txtFirstname.Text.Trim())
                    .Replace("[LASTNAME]", txtLastname.Text.Trim())
                    .Replace("[ORGANIZATION]", txtOrganization.Text.Trim())
                    .Replace("[ADDRESS]", txtAddress.Text.Trim())
                    .Replace("[PHONE]", txtPhone.Text.Trim())
                    .Replace("[FAX]", txtFax.Text.Trim())
                    .Replace("[EMAIL]", txtEmail.Text.Trim())
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
