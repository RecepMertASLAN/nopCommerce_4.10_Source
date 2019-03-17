using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Nop.Core.Domain.Catalog;
using Nop.Web.Areas.Admin.Models.Catalog;

namespace Nop.Web.Areas.Admin.Factories
{
	public interface IMyNewEntityModelFactory
	{
		IList<MyNewEntity> GetList();

		void AddNew(MyNewEntity entity);
		void Delete(MyNewEntity entity);
		MyNewEntity GetById(int id);
		void Update(MyNewEntity entity);
	}
}
