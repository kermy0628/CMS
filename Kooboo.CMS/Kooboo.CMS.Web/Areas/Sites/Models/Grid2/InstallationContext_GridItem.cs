﻿using Kooboo.CMS.Sites.Extension.ModuleArea.Management;
using Kooboo.Common.Web.Grid;
using Kooboo.Common.Web.Grid;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Kooboo.CMS.Web.Areas.Sites.Models.Grid2
{
    public class InstallationContext_GridItem : GridItem
    {
        public InstallationContext_GridItem(IGridModel gridModel, object dataItem, int dataIndex)
            : base(gridModel, dataItem, dataIndex)
        {

        }
        public override bool IsCheckable
        {
            get
            {
                var installationContext = (InstallationContext)this.DataItem;
                IInstallationFileManager moduleVersioning = Kooboo.Common.ObjectContainer.EngineContext.Current.Resolve<IInstallationFileManager>();
                return moduleVersioning.IsInstallationFileExists(installationContext);
            }
        }
    }
}