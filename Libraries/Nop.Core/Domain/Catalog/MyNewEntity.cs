using System;
using System.Collections.Generic;
using System.Text;
using Nop.Core.Domain.Localization;
using Nop.Core.Domain.Seo;

namespace Nop.Core.Domain.Catalog
{
	public class MyNewEntity : BaseEntity
	{
		public string MyEntityName { get; set; }

		public string MyEntitySurname { get; set; }
	}
}
