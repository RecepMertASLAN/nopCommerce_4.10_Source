using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Nop.Core.Domain.Catalog;
using Nop.Services.Catalog;
using Nop.Web.Areas.Admin.Models.Catalog;

namespace Nop.Web.Areas.Admin.Factories
{
	public class MyNewEntityModelFactory : IMyNewEntityModelFactory
	{
		private IMyNewEntityService _myNewEntityService;

		public MyNewEntityModelFactory(IMyNewEntityService myNewEntityService)
		{
			_myNewEntityService = myNewEntityService;
		}


		public IList<MyNewEntity> GetList()
		{
			return _myNewEntityService.GetAllList();
		}

		public void AddNew(MyNewEntity entity)
		{
			_myNewEntityService.AddNew(entity);
		}

		public void Delete(MyNewEntity entity)
		{
			_myNewEntityService.Delete(entity);
		}

		public MyNewEntity GetById(int id)
		{
			return _myNewEntityService.GetById(id);
		}

		public void Update(MyNewEntity entity)
		{
			_myNewEntityService.Update(entity);
		}
	}
}
