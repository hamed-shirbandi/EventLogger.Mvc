﻿#pragma warning disable 1591
//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace EventLogger.Mvc.Views
{
    using System;
    using System.Collections.Generic;
    using System.IO;
    using System.Linq;
    using System.Net;
    using System.Text;
    using System.Web;
    using System.Web.Helpers;
    using System.Web.Mvc;
    using System.Web.Mvc.Ajax;
    using System.Web.Mvc.Html;
    using System.Web.Optimization;
    using System.Web.Routing;
    using System.Web.Security;
    using System.Web.UI;
    using System.Web.WebPages;
    using EventLogger.Mvc;
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("RazorGenerator", "2.0.0.0")]
    [System.Web.WebPages.PageVirtualPathAttribute("~/Views/EventLogs/Details.cshtml")]
    public partial class Details : System.Web.Mvc.WebViewPage<EventLogger.Service.EventLogs.Dto.EventLogOutput>
    {
        public Details()
        {
        }
        public override void Execute()
        {
            
            #line 3 "..\..\Views\EventLogs\Details.cshtml"
  
    ViewBag.Title = "Details";
    Layout = "~/Views/Shared/_LoggerMainLayout.cshtml";


            
            #line default
            #line hidden
WriteLiteral("\r\n<div");

WriteLiteral(" style=\"margin-top:20px;\"");

WriteLiteral(">\r\n\r\n");

            
            #line 10 "..\..\Views\EventLogs\Details.cshtml"
    
            
            #line default
            #line hidden
            
            #line 10 "..\..\Views\EventLogs\Details.cshtml"
     if (Model.EventLogType == EventLogger.Enums.EventLogType.Error)
    {

            
            #line default
            #line hidden
WriteLiteral("        <div");

WriteLiteral(" class=\"\"");

WriteLiteral(">\r\n            <strong>Source :</strong>\r\n            <h2> ");

            
            #line 14 "..\..\Views\EventLogs\Details.cshtml"
            Write(Model.Source);

            
            #line default
            #line hidden
WriteLiteral(" </h2>\r\n            <hr />\r\n        </div>\r\n");

WriteLiteral("        <div");

WriteLiteral(" class=\"\"");

WriteLiteral(">\r\n            <strong>StatusCode :</strong>\r\n");

WriteLiteral("            ");

            
            #line 19 "..\..\Views\EventLogs\Details.cshtml"
       Write(Model.StatusCode);

            
            #line default
            #line hidden
WriteLiteral("\r\n            <hr />\r\n        </div>\r\n");

WriteLiteral("        <div");

WriteLiteral(" class=\"\"");

WriteLiteral(">\r\n            <strong>Message :</strong>\r\n            <p> ");

            
            #line 24 "..\..\Views\EventLogs\Details.cshtml"
           Write(Model.Message);

            
            #line default
            #line hidden
WriteLiteral(" </p>\r\n            <hr />\r\n        </div>\r\n");

WriteLiteral("        <div");

WriteLiteral(" class=\"\"");

WriteLiteral(">\r\n            <strong>StackTrace :</strong>\r\n            <p");

WriteLiteral(" class=\"alert alert-warning\"");

WriteLiteral(">\r\n");

WriteLiteral("                ");

            
            #line 30 "..\..\Views\EventLogs\Details.cshtml"
           Write(Model.StackTrace);

            
            #line default
            #line hidden
WriteLiteral("\r\n            </p>\r\n            <hr />\r\n        </div>\r\n");

WriteLiteral("        <div");

WriteLiteral(" class=\"\"");

WriteLiteral(">\r\n            <strong>InnerMessage :</strong>\r\n");

WriteLiteral("            ");

            
            #line 36 "..\..\Views\EventLogs\Details.cshtml"
       Write(Model.InnerMessage);

            
            #line default
            #line hidden
WriteLiteral("\r\n            <hr />\r\n        </div>\r\n");

WriteLiteral("        <div");

WriteLiteral(" class=\"\"");

WriteLiteral(">\r\n            <strong>HelpLink :</strong>\r\n");

WriteLiteral("            ");

            
            #line 41 "..\..\Views\EventLogs\Details.cshtml"
       Write(Model.HelpLink);

            
            #line default
            #line hidden
WriteLiteral("\r\n            <hr />\r\n        </div>\r\n");

WriteLiteral("        <div");

WriteLiteral(" class=\"\"");

WriteLiteral(">\r\n            <strong>HResult :</strong>\r\n");

WriteLiteral("            ");

            
            #line 46 "..\..\Views\EventLogs\Details.cshtml"
       Write(Model.HResult);

            
            #line default
            #line hidden
WriteLiteral("\r\n            <hr />\r\n        </div>\r\n");

            
            #line 49 "..\..\Views\EventLogs\Details.cshtml"

    }

            
            #line default
            #line hidden
WriteLiteral("    <div");

WriteLiteral(" class=\"\"");

WriteLiteral(">\r\n        <strong>Date Time :</strong>\r\n");

WriteLiteral("        ");

            
            #line 53 "..\..\Views\EventLogs\Details.cshtml"
   Write(Model.CreateDateTime);

            
            #line default
            #line hidden
WriteLiteral("\r\n        <hr />\r\n    </div>\r\n    <div");

WriteLiteral(" class=\"\"");

WriteLiteral(">\r\n        <strong>User :</strong>\r\n");

WriteLiteral("        ");

            
            #line 58 "..\..\Views\EventLogs\Details.cshtml"
   Write(Model.UserName);

            
            #line default
            #line hidden
WriteLiteral("\r\n        <hr />\r\n    </div>\r\n    <div");

WriteLiteral(" class=\"\"");

WriteLiteral(">\r\n        <strong>Url :</strong>\r\n");

WriteLiteral("        ");

            
            #line 63 "..\..\Views\EventLogs\Details.cshtml"
   Write(Model.Url);

            
            #line default
            #line hidden
WriteLiteral("\r\n        <hr />\r\n    </div>\r\n    <div");

WriteLiteral(" class=\"\"");

WriteLiteral(">\r\n        <strong>UserAgent :</strong>\r\n");

WriteLiteral("        ");

            
            #line 68 "..\..\Views\EventLogs\Details.cshtml"
   Write(Model.UserAgent);

            
            #line default
            #line hidden
WriteLiteral("\r\n        <hr />\r\n    </div>\r\n    <div");

WriteLiteral(" class=\"\"");

WriteLiteral(">\r\n        <strong>Controller :</strong>\r\n");

WriteLiteral("        ");

            
            #line 73 "..\..\Views\EventLogs\Details.cshtml"
   Write(Model.Controller);

            
            #line default
            #line hidden
WriteLiteral("\r\n        <hr />\r\n    </div>\r\n    <div");

WriteLiteral(" class=\"\"");

WriteLiteral(">\r\n        <strong>Action :</strong>\r\n");

WriteLiteral("        ");

            
            #line 78 "..\..\Views\EventLogs\Details.cshtml"
   Write(Model.Action);

            
            #line default
            #line hidden
WriteLiteral("\r\n        <hr />\r\n    </div>\r\n    <div");

WriteLiteral(" class=\"\"");

WriteLiteral(">\r\n        <strong>RouteValues :</strong>\r\n");

WriteLiteral("        ");

            
            #line 83 "..\..\Views\EventLogs\Details.cshtml"
   Write(Model.RouteValues);

            
            #line default
            #line hidden
WriteLiteral("\r\n        <hr />\r\n    </div>\r\n    <div");

WriteLiteral(" class=\"\"");

WriteLiteral(">\r\n        <strong>PathInfo :</strong>\r\n");

WriteLiteral("        ");

            
            #line 88 "..\..\Views\EventLogs\Details.cshtml"
   Write(Model.PathInfo);

            
            #line default
            #line hidden
WriteLiteral("\r\n        <hr />\r\n    </div>\r\n    <div");

WriteLiteral(" class=\"\"");

WriteLiteral(">\r\n        <strong>QueryString :</strong>\r\n");

WriteLiteral("        ");

            
            #line 93 "..\..\Views\EventLogs\Details.cshtml"
   Write(Model.QueryString);

            
            #line default
            #line hidden
WriteLiteral("\r\n    </div>\r\n\r\n</div>\r\n");

        }
    }
}
#pragma warning restore 1591
