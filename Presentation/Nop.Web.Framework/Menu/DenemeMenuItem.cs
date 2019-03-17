using System;
using System.Collections.Generic;
using System.Text;
using Nop.Core.Plugins;

namespace Nop.Web.Framework.Menu
{
	public class DenemeMenuItem :IAdminMenuPlugin
	{
		public string GetConfigurationPageUrl()
		{
			//throw new NotImplementedException();
			return "RMA";
		}

		public PluginDescriptor PluginDescriptor { get; set; }
		public void Install()
		{
			//throw new NotImplementedException();
		}

		public void Uninstall()
		{
			//throw new NotImplementedException();
		}

		public void ManageSiteMap(SiteMapNode rootNode)
		{
		//	throw new NotImplementedException();
		}
	}
}
