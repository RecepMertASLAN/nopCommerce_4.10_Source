using System;
using System.Collections.Generic;
using System.Text;
using Nop.Core.Domain.Catalog;

namespace Nop.Services.Catalog
{
	public interface IMyNewEntityService
	{
		IList<MyNewEntity> GetAllList();
		void AddNew(MyNewEntity entity);
		void Delete(MyNewEntity entity);
		MyNewEntity GetById(int id);
		void Update(MyNewEntity entity);
	}
}
