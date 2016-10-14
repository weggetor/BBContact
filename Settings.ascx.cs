using System;
using DotNetNuke.Entities.Host;
using DotNetNuke.Services.Exceptions;
using DotNetNuke.Entities.Modules;


namespace Bitboxx.DNNModules.BBContact
{

    /// -----------------------------------------------------------------------------
    /// <summary>
    /// The Settings class manages Module Settings
    /// </summary>
    /// -----------------------------------------------------------------------------
    [DNNtc.PackageProperties("BBContact")]
    [DNNtc.ModuleProperties("BBContact")]
    [DNNtc.ModuleControlProperties("Settings", "Configure settings", DNNtc.ControlType.Edit, "", true, true)]
    public partial class Settings : ModuleSettingsBase
    {

        #region Base Method Implementations

        /// -----------------------------------------------------------------------------
        /// <summary>
        /// LoadSettings loads the settings from the Database and displays them
        /// </summary>
        /// -----------------------------------------------------------------------------
        public override void LoadSettings()
        {
            try
            {
                if (!Page.IsPostBack)
                {
                    if (Settings["SenderName"] != null)
                        txtSenderName.Text = (string) Settings["SenderName"];

                    if (Settings["SenderEmail"] != null)
                        txtSenderEmail.Text = (string) Settings["SenderEmail"];
                    else
                        txtSenderEmail.Text = Host.HostEmail;

                    if (Settings["RecipientEmail"] != null)
                        txtRecipientEmail.Text = (string)Settings["RecipientEmail"];

                    if (Settings["Interest"] != null)
                        txtInterests.Text = (string)Settings["Interest"];

                    if (Settings["Subject"] != null)
                        txtSubject.Text = (string) Settings["Subject"];
                    else
                        txtSubject.Text = "Contact form submission from [EMAIL]";

                    if (Settings["SendToUser"] != null)
                        chkFirstnameVisible.Checked = Convert.ToBoolean(Settings["SendToUser"]);

                    if (Settings["Bootstrap"] != null)
                        chkBootstrap.Checked = Convert.ToBoolean(Settings["Bootstrap"]);

                    if (Settings["Bodytext"] != null)
                        txtBodytext.Text = (string) Settings["Bodytext"];
                    else
                        txtBodytext.Text = "Contact form submission :\r\n\r\n" +
                                          "Firstname    : [FIRSTNAME]\r\n" +
                                          "Lastname     : [LASTNAME]\r\n" +
                                          "Organization : [ORGANIZATION]\r\n" +
                                          "Address      : [ADDRESS]\r\n" +
                                          "Phone        : [PHONE]\r\n" +
                                          "Fax          : [FAX]\r\n" +
                                          "Email        : [EMAIL]\r\n" +
                                          "Interest     : [INTEREST]\r\n" +
                                          "Product      : [PRODUCT]\r\n" +
                                          "Remarks      : [REMARK]";
                    if (Settings["VisibleFirstname"] != null)
                        chkFirstnameVisible.Checked = Convert.ToBoolean(Settings["VisibleFirstname"]);
                    if (Settings["VisibleLastname"] != null)
                        chkLastnameVisible.Checked = Convert.ToBoolean(Settings["VisibleLastname"]);
                    if (Settings["VisibleOrganization"] != null)
                        chkOrganizationVisible.Checked = Convert.ToBoolean(Settings["VisibleOrganization"]);
                    if (Settings["VisibleAddress"] != null)
                        chkAddressVisible.Checked = Convert.ToBoolean(Settings["VisibleAddress"]);
                    if (Settings["VisiblePhone"] != null)
                        chkPhoneVisible.Checked = Convert.ToBoolean(Settings["VisiblePhone"]);
                    if (Settings["VisibleFax"] != null)
                        chkFaxVisible.Checked = Convert.ToBoolean(Settings["VisibleFax"]);
                    if (Settings["VisibleEmail"] != null)
                        chkEmailVisible.Checked = Convert.ToBoolean(Settings["VisibleEmail"]);
                    if (Settings["VisibleRemark"] != null)
                        chkRemarkVisible.Checked = Convert.ToBoolean(Settings["VisibleRemark"]);
                    if (Settings["VisibleInterest"] != null)
                        chkInterestVisible.Checked = Convert.ToBoolean(Settings["VisibleInterest"]);
                    if (Settings["VisibleProduct"] != null)
                        chkProductVisible.Checked = Convert.ToBoolean(Settings["VisibleProduct"]);
                    
                    if (Settings["EnsureFirstname"] != null)
                        chkFirstnameMandatory.Checked = Convert.ToBoolean(Settings["EnsureFirstname"]);
                    if (Settings["EnsureLastname"] != null)
                        chkLastnameMandatory.Checked = Convert.ToBoolean(Settings["EnsureLastname"]);
                    if (Settings["EnsureOrganization"] != null)
                        chkOrganizationMandatory.Checked = Convert.ToBoolean(Settings["EnsureOrganization"]);
                    if (Settings["EnsureAddress"] != null)
                        chkAddressMandatory.Checked = Convert.ToBoolean(Settings["EnsureAddress"]);
                    if (Settings["EnsurePhone"] != null)
                        chkPhoneMandatory.Checked = Convert.ToBoolean(Settings["EnsurePhone"]);
                    if (Settings["EnsureFax"] != null)
                        chkFaxMandatory.Checked = Convert.ToBoolean(Settings["EnsureFax"]);
                    if (Settings["EnsureEmail"] != null)
                        chkEmailMandatory.Checked = Convert.ToBoolean(Settings["EnsureEmail"]);
                    if (Settings["EnsureRemark"] != null)
                        chkRemarkMandatory.Checked = Convert.ToBoolean(Settings["EnsureRemark"]);
                    if (Settings["EnsureInterest"] != null)
                        chkInterestMandatory.Checked = Convert.ToBoolean(Settings["EnsureInterest"]);
                    
                }
            }
            catch (Exception exc) //Module failed to load
            {
                Exceptions.ProcessModuleLoadException(this, exc);
            }
        }

        /// -----------------------------------------------------------------------------
        /// <summary>
        /// UpdateSettings saves the modified settings to the Database
        /// </summary>
        /// -----------------------------------------------------------------------------
        public override void UpdateSettings()
        {
            try
            {
                ModuleController modules = new ModuleController();
                modules.UpdateModuleSetting(this.ModuleId, "Bootstrap", chkBootstrap.Checked.ToString());
                modules.UpdateModuleSetting(this.ModuleId, "SenderName", txtSenderName.Text.Trim());
                modules.UpdateModuleSetting(this.ModuleId, "SenderEmail", txtSenderEmail.Text.Trim());
                modules.UpdateModuleSetting(this.ModuleId, "RecipientEmail", txtRecipientEmail.Text.Trim());
                modules.UpdateModuleSetting(this.ModuleId, "Subject", txtSubject.Text.Trim());
                modules.UpdateModuleSetting(this.ModuleId, "SendToUser", chkSendToUser.Checked.ToString());
                modules.UpdateModuleSetting(this.ModuleId, "Bodytext", txtBodytext.Text.Trim());
                modules.UpdateModuleSetting(this.ModuleId, "Interest", txtInterests.Text.Trim());

                modules.UpdateModuleSetting(this.ModuleId, "VisibleFirstname", chkFirstnameVisible.Checked.ToString());
                modules.UpdateModuleSetting(this.ModuleId, "VisibleLastname", chkLastnameVisible.Checked.ToString());
                modules.UpdateModuleSetting(this.ModuleId, "VisibleOrganization", chkOrganizationVisible.Checked.ToString());
                modules.UpdateModuleSetting(this.ModuleId, "VisibleAddress", chkAddressVisible.Checked.ToString());
                modules.UpdateModuleSetting(this.ModuleId, "VisiblePhone", chkPhoneVisible.Checked.ToString());
                modules.UpdateModuleSetting(this.ModuleId, "VisibleFax", chkFaxVisible.Checked.ToString());
                modules.UpdateModuleSetting(this.ModuleId, "VisibleEmail", chkEmailVisible.Checked.ToString());
                modules.UpdateModuleSetting(this.ModuleId, "VisibleRemark", chkRemarkVisible.Checked.ToString());
                modules.UpdateModuleSetting(this.ModuleId, "VisibleInterest", chkInterestVisible.Checked.ToString());
                modules.UpdateModuleSetting(this.ModuleId, "VisibleProduct", chkProductVisible.Checked.ToString());

                modules.UpdateModuleSetting(this.ModuleId, "EnsureFirstname", chkFirstnameMandatory.Checked.ToString());
                modules.UpdateModuleSetting(this.ModuleId, "EnsureLastname", chkLastnameMandatory.Checked.ToString());
                modules.UpdateModuleSetting(this.ModuleId, "EnsureOrganization", chkOrganizationMandatory.Checked.ToString());
                modules.UpdateModuleSetting(this.ModuleId, "EnsureAddress", chkAddressMandatory.Checked.ToString());
                modules.UpdateModuleSetting(this.ModuleId, "EnsurePhone", chkPhoneMandatory.Checked.ToString());
                modules.UpdateModuleSetting(this.ModuleId, "EnsureFax", chkFaxMandatory.Checked.ToString());
                modules.UpdateModuleSetting(this.ModuleId, "EnsureEmail", chkEmailMandatory.Checked.ToString());
                modules.UpdateModuleSetting(this.ModuleId, "EnsureRemark", chkRemarkMandatory.Checked.ToString());
                modules.UpdateModuleSetting(this.ModuleId, "EnsureInterest", chkInterestMandatory.Checked.ToString());
            }
            catch (Exception exc) //Module failed to load
            {
                Exceptions.ProcessModuleLoadException(this, exc);
            }
        }

        #endregion

    }

}

