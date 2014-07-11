﻿#region License
// 
// Copyright (c) 2013, Kooboo team
// 
// Licensed under the BSD License
// See the file LICENSE.txt for details.
// 
#endregion
using Kooboo.Common.Web.Menu;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Web.Mvc;

namespace Kooboo.CMS.Sites.Extension.UI.GlobalSidebarMenu
{
    public class GlobalSidebarMenuItemContainer : IMenuItemContainer
    {
        public IEnumerable<MenuItem> GetItems(string areaName, System.Web.Mvc.ControllerContext controllerContext)
        {
            var globalMenuItemProvider = Kooboo.Common.ObjectContainer.EngineContext.Current.ResolveAll<IGlobalSidebarMenuItemProvider>();
            
            return globalMenuItemProvider.SelectMany(it => it.GetMenuItems(controllerContext));
        }
    }
}
