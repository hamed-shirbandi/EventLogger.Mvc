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
    [System.Web.WebPages.PageVirtualPathAttribute("~/Views/EventLogs/_ErrorLogs.cshtml")]
    public partial class _ErrorLogs : System.Web.Mvc.WebViewPage<IEnumerable<EventLogger.Service.EventLogs.Dto.EventLogOutput>>
    {
        public _ErrorLogs()
        {
        }
        public override void Execute()
        {
            
            #line 2 "..\..\Views\EventLogs\_ErrorLogs.cshtml"
  

            
            #line default
            #line hidden
WriteLiteral("\r\n\r\n<thead");

WriteLiteral(" class=\"thead-inverse\"");

WriteLiteral(">\r\n    <tr>\r\n        <th>Log Id</th>\r\n        ");

WriteLiteral("\r\n        <th>Error</th>\r\n        <th>Source</th>\r\n        <th>User</th>\r\n       " +
" <th>Date Time</th>\r\n        <th></th>\r\n    </tr>\r\n</thead>\r\n<tbody>\r\n");

            
            #line 17 "..\..\Views\EventLogs\_ErrorLogs.cshtml"
    
            
            #line default
            #line hidden
            
            #line 17 "..\..\Views\EventLogs\_ErrorLogs.cshtml"
     foreach (var item in Model)
    {

            
            #line default
            #line hidden
WriteLiteral("        <tr>\r\n            <th");

WriteLiteral(" scope=\"row\"");

WriteLiteral(">");

            
            #line 20 "..\..\Views\EventLogs\_ErrorLogs.cshtml"
                       Write(item.Id);

            
            #line default
            #line hidden
WriteLiteral("</th>\r\n            ");

WriteLiteral("\r\n            <td");

WriteLiteral(" style=\"max-width:250px;text-overflow:ellipsis;white-space: nowrap;overflow: hidd" +
"en;;\"");

WriteLiteral(">");

            
            #line 22 "..\..\Views\EventLogs\_ErrorLogs.cshtml"
                                                                                                 Write(item.Message);

            
            #line default
            #line hidden
WriteLiteral("</td>\r\n            <td>");

            
            #line 23 "..\..\Views\EventLogs\_ErrorLogs.cshtml"
           Write(item.Source);

            
            #line default
            #line hidden
WriteLiteral("</td>\r\n            <td>");

            
            #line 24 "..\..\Views\EventLogs\_ErrorLogs.cshtml"
           Write(item.UserName);

            
            #line default
            #line hidden
WriteLiteral("</td>\r\n            <td>\r\n");

WriteLiteral("                ");

            
            #line 26 "..\..\Views\EventLogs\_ErrorLogs.cshtml"
           Write(item.CreateDateTime.ToShortDateString());

            
            #line default
            #line hidden
WriteLiteral("\r\n                <br />\r\n");

WriteLiteral("                ");

            
            #line 28 "..\..\Views\EventLogs\_ErrorLogs.cshtml"
           Write(item.CreateDateTime.ToShortTimeString());

            
            #line default
            #line hidden
WriteLiteral("\r\n            </td>\r\n            <td>");

            
            #line 30 "..\..\Views\EventLogs\_ErrorLogs.cshtml"
           Write(Html.ActionLink(linkText: "Details", actionName: "Details", controllerName: "EventLogs", routeValues: new { id = item.Id }, htmlAttributes: new { @class = "", target = "_blank" }));

            
            #line default
            #line hidden
WriteLiteral("</td>\r\n        </tr>\r\n");

            
            #line 32 "..\..\Views\EventLogs\_ErrorLogs.cshtml"
    }

            
            #line default
            #line hidden
WriteLiteral("</tbody>");

        }
    }
}
#pragma warning restore 1591
