﻿using System.Collections.Generic;
using MrCMS.Website;
using MrCMS.Website.Optimization;

namespace MrCMS.Web.Areas.Admin.Bundles
{
    public class AdminLibScriptBundle : IScriptBundle
    {
        public string Url
        {
            get { return "~/admin/scripts/lib"; }
        }

        public IEnumerable<string> Files
        {
            get
            {
                yield return "~/Areas/Admin/Content/Scripts/lib/jquery/jquery-1.11.2.min.js";
                yield return "~/Areas/Admin/Content/Scripts/lib/jquery/ui/jquery-ui.js";
                yield return "~/Areas/Admin/Content/Scripts/lib/jquery/ui/jquery-ui-timepicker-addon.js";
                yield return
                    "~/Areas/Admin/Content/Scripts/lib/jquery/ui/i18n/jquery.ui.datepicker-" +
                    CurrentRequestData.CultureInfo.Name + ".js";
                yield return "~/Areas/Admin/Content/Scripts/lib/jquery.signalR-2.2.0.js";
                yield return "~/Areas/Admin/Content/Scripts/lib/store.js";
                yield return "~/Areas/Admin/Content/plugins/sweetalert-master/lib/sweet-alert.min.js";
                yield return "~/Areas/Admin/Content/Scripts/lib/jquery/validate/jquery.validate.js";
                if (!CurrentRequestData.CultureInfo.Name.StartsWith("en"))
                {
                    yield return
                        string.Format(
                            "~/Areas/Admin/Content/Scripts/lib/jquery/validate/localization/messages_{0}.js",
                            CurrentRequestData.CultureInfo.Name.Replace("-", "_"));
                }
                yield return "~/Areas/Admin/Content/Scripts/lib/jquery/validate/jquery.validate.unobtrusive.min.js";
                yield return "~/Areas/Admin/Content/Styles/bootstrap/js/bootstrap.js";
                yield return "~/Areas/Admin/Content/Scripts/lib/tag-it.min.js";
                yield return "~/Areas/Admin/Content/Scripts/lib/jquery.noty.packaged.js";
                yield return "~/Areas/Admin/Content/Scripts/lib/jstree/jstree.js";
                yield return "~/Areas/Admin/Content/Scripts/lib/dropzone.js";
                yield return "~/Areas/Admin/Content/Scripts/lib/featherlight.js";
                yield return "~/Areas/Admin/Content/Scripts/lib/jquery.are-you-sure.js";
            }
        }
    }
}