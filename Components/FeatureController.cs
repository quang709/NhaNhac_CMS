/*
' Copyright (c) 2022 huecit.vn
'  All rights reserved.
' 
' THE SOFTWARE IS PROVIDED "AS IS", WITHOUT WARRANTY OF ANY KIND, EXPRESS OR IMPLIED, INCLUDING BUT NOT LIMITED
' TO THE WARRANTIES OF MERCHANTABILITY, FITNESS FOR A PARTICULAR PURPOSE AND NONINFRINGEMENT. IN NO EVENT SHALL
' THE AUTHORS OR COPYRIGHT HOLDERS BE LIABLE FOR ANY CLAIM, DAMAGES OR OTHER LIABILITY, WHETHER IN AN ACTION OF
' CONTRACT, TORT OR OTHERWISE, ARISING FROM, OUT OF OR IN CONNECTION WITH THE SOFTWARE OR THE USE OR OTHER
' DEALINGS IN THE SOFTWARE.
' 
*/

using System.Collections.Generic;
//using System.Xml;
using DotNetNuke.Entities.Modules;
using DotNetNuke.Services.Search;

namespace HueCIT.Modules.NhaNhac_CMS.Components
{

    /// -----------------------------------------------------------------------------
    /// <summary>
    /// The Controller class for NhaNhac_CMS
    /// 
    /// The FeatureController class is defined as the BusinessController in the manifest file (.dnn)
    /// DotNetNuke will poll this class to find out which Interfaces the class implements. 
    /// 
    /// The IPortable interface is used to import/export content from a DNN module
    /// 
    /// The ISearchable interface is used by DNN to index the content of a module
    /// 
    /// The IUpgradeable interface allows module developers to execute code during the upgrade 
    /// process for a module.
    /// 
    /// Below you will find stubbed out implementations of each, uncomment and populate with your own data
    /// </summary>
    /// -----------------------------------------------------------------------------

    //uncomment the interfaces to add the support.
    public class FeatureController //: IPortable, ISearchable, IUpgradeable
    {


        #region Optional Interfaces

        /// -----------------------------------------------------------------------------
        /// <summary>
        /// ExportModule implements the IPortable ExportModule Interface
        /// </summary>
        /// <param name="ModuleID">The Id of the module to be exported</param>
        /// -----------------------------------------------------------------------------
        //public string ExportModule(int ModuleID)
        //{
        //string strXML = "";

        //List<NhaNhac_CMSInfo> colNhaNhac_CMSs = GetNhaNhac_CMSs(ModuleID);
        //if (colNhaNhac_CMSs.Count != 0)
        //{
        //    strXML += "<NhaNhac_CMSs>";

        //    foreach (NhaNhac_CMSInfo objNhaNhac_CMS in colNhaNhac_CMSs)
        //    {
        //        strXML += "<NhaNhac_CMS>";
        //        strXML += "<content>" + DotNetNuke.Common.Utilities.XmlUtils.XMLEncode(objNhaNhac_CMS.Content) + "</content>";
        //        strXML += "</NhaNhac_CMS>";
        //    }
        //    strXML += "</NhaNhac_CMSs>";
        //}

        //return strXML;

        //	throw new System.NotImplementedException("The method or operation is not implemented.");
        //}

        /// -----------------------------------------------------------------------------
        /// <summary>
        /// ImportModule implements the IPortable ImportModule Interface
        /// </summary>
        /// <param name="ModuleID">The Id of the module to be imported</param>
        /// <param name="Content">The content to be imported</param>
        /// <param name="Version">The version of the module to be imported</param>
        /// <param name="UserId">The Id of the user performing the import</param>
        /// -----------------------------------------------------------------------------
        //public void ImportModule(int ModuleID, string Content, string Version, int UserID)
        //{
        //XmlNode xmlNhaNhac_CMSs = DotNetNuke.Common.Globals.GetContent(Content, "NhaNhac_CMSs");
        //foreach (XmlNode xmlNhaNhac_CMS in xmlNhaNhac_CMSs.SelectNodes("NhaNhac_CMS"))
        //{
        //    NhaNhac_CMSInfo objNhaNhac_CMS = new NhaNhac_CMSInfo();
        //    objNhaNhac_CMS.ModuleId = ModuleID;
        //    objNhaNhac_CMS.Content = xmlNhaNhac_CMS.SelectSingleNode("content").InnerText;
        //    objNhaNhac_CMS.CreatedByUser = UserID;
        //    AddNhaNhac_CMS(objNhaNhac_CMS);
        //}

        //	throw new System.NotImplementedException("The method or operation is not implemented.");
        //}

        /// -----------------------------------------------------------------------------
        /// <summary>
        /// GetSearchItems implements the ISearchable Interface
        /// </summary>
        /// <param name="ModInfo">The ModuleInfo for the module to be Indexed</param>
        /// -----------------------------------------------------------------------------
        //public DotNetNuke.Services.Search.SearchItemInfoCollection GetSearchItems(DotNetNuke.Entities.Modules.ModuleInfo ModInfo)
        //{
        //SearchItemInfoCollection SearchItemCollection = new SearchItemInfoCollection();

        //List<NhaNhac_CMSInfo> colNhaNhac_CMSs = GetNhaNhac_CMSs(ModInfo.ModuleID);

        //foreach (NhaNhac_CMSInfo objNhaNhac_CMS in colNhaNhac_CMSs)
        //{
        //    SearchItemInfo SearchItem = new SearchItemInfo(ModInfo.ModuleTitle, objNhaNhac_CMS.Content, objNhaNhac_CMS.CreatedByUser, objNhaNhac_CMS.CreatedDate, ModInfo.ModuleID, objNhaNhac_CMS.ItemId.ToString(), objNhaNhac_CMS.Content, "ItemId=" + objNhaNhac_CMS.ItemId.ToString());
        //    SearchItemCollection.Add(SearchItem);
        //}

        //return SearchItemCollection;

        //	throw new System.NotImplementedException("The method or operation is not implemented.");
        //}

        /// -----------------------------------------------------------------------------
        /// <summary>
        /// UpgradeModule implements the IUpgradeable Interface
        /// </summary>
        /// <param name="Version">The current version of the module</param>
        /// -----------------------------------------------------------------------------
        //public string UpgradeModule(string Version)
        //{
        //	throw new System.NotImplementedException("The method or operation is not implemented.");
        //}

        #endregion

    }

}
