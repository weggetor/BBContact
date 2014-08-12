using DotNetNuke.Common;
using DotNetNuke.Common.Utilities;
using DotNetNuke.Data;
using DotNetNuke.Entities.Modules;
using DotNetNuke.Services.Search;
using System.Collections.Generic;
using System.Linq;
using System.Xml;

namespace Bitboxx.DNNModules.BBContact
{

    /// ----------------------------------------------------------------------------- 
    /// <summary> 
    /// The Controller class for BBContact 
    /// </summary> 
    /// <remarks> 
    /// </remarks> 
    /// <history> 
    /// </history> 
    /// ----------------------------------------------------------------------------- 

    // [DNNtc.UpgradeEventMessage("01.01.01,04.00.02,04.01.00")]
    [DNNtc.BusinessControllerClass()]
    public class BBContactController // : ISearchable, IPortable
    {
        #region "Public Methods"
        

        #endregion

        //#region Implementation of ISearchable

        ///// ----------------------------------------------------------------------------- 
        ///// <summary> 
        ///// GetSearchItems implements the ISearchable Interface 
        ///// </summary> 
        ///// <remarks> 
        ///// </remarks> 
        ///// <param name="module">The ModuleInfo for the module to be Indexed</param> 
        ///// <history> 
        ///// </history> 
        ///// ----------------------------------------------------------------------------- 
        //public DotNetNuke.Services.Search.SearchItemInfoCollection GetSearchItems(ModuleInfo module)
        //{ 
        //    
        //    SearchItemInfoCollection SearchItemCollection = new SearchItemInfoCollection(); 
        //    
        //    IEnumerable<TableInfo> colBBContacts = GetAllBBContacts(module.ModuleID); 
        //    foreach ( TableInfo objBBContact in colBBContacts) 
        //    { 
        //        SearchItemInfo searchItem = new SearchItemInfo(module.ModuleTitle, 
        //				objBBContact.Name,
        //				objBBContact.CreatedByUserID ?? -1,
        //				objBBContact.CreatedOnDate, 
        //				module.ModuleID, 
        //				objBBContact.TableId.ToString(), 
        //				objBBContact.Name, 
        //				"ItemId=" + objBBContact.TableId.ToString()); 
        //        SearchItemCollection.Add(searchItem); 
        //    } 
        //    return SearchItemCollection; 
        //    
        //}

        //#endregion

        //#region Implementation of IPortable

        ///// ----------------------------------------------------------------------------- 
        ///// <summary> 
        ///// ExportModule implements the IPortable ExportModule Interface 
        ///// </summary> 
        ///// <remarks> 
        ///// </remarks> 
        ///// <param name="moduleID">The Id of the module to be exported</param> 
        ///// <history> 
        ///// </history> 
        ///// ----------------------------------------------------------------------------- 
        //public string ExportModule(int moduleID) 
        //{ 
        //    IEnumerable<TableInfo> colBBContacts = GetAllBBContacts(moduleID); 
        //    string strXML = "<BBContacts>"; 
        //    foreach ( TableInfo objBBContact in colBBContacts) 
        //    { 
        //        strXML += "<BBContact>"; 
        //        strXML += "<name>" +XmlUtils.XMLEncode(objBBContact.Name) + "</name>"; 
        //        strXML += "</BBContact>"; 
        //    } 
        //    strXML += "</BBContacts>"; 
        //    return strXML; 
        //}

        ///// ----------------------------------------------------------------------------- 
        ///// <summary> 
        ///// ImportModule implements the IPortable ImportModule Interface 
        ///// </summary> 
        ///// <remarks> 
        ///// </remarks> 
        ///// <param name="moduleID">The Id of the module to be imported</param> 
        ///// <param name="name">The name to be imported</param> 
        ///// <param name="version">The version of the module to be imported</param> 
        ///// <param name="userId">The Id of the user performing the import</param> 
        ///// <history> 
        ///// </history> 
        ///// ----------------------------------------------------------------------------- 
        //public void ImportModule(int moduleID, string name, string version, int userId) 
        //{ 
        //    
        //    XmlNode xmlBBContacts = Globals.GetContent(name, "BBContacts"); 
        //    foreach ( XmlNode xmlBBContact in xmlBBContacts.SelectNodes("BBContact")) 
        //    { 
        //        TableInfo objBBContact = new TableInfo(); 
        //        objBBContact.ModuleId = moduleID; 
        //        objBBContact.Name = xmlBBContact.SelectSingleNode("name").InnerText; 
        //        objBBContact.CreatedByUserID = userId; 
        //        InsertBBContact(objBBContact); 
        //    } 
        //}

        //#endregion

    }
}