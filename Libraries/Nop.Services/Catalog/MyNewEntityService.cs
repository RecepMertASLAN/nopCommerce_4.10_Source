using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Nop.Core.Data;
using Nop.Core.Domain.Catalog;

namespace Nop.Services.Catalog
{
	public class MyNewEntityService :IMyNewEntityService
	{
		private readonly IRepository<MyNewEntity> _myNewEntityRepository;

		public MyNewEntityService(IRepository<MyNewEntity> myNewEntityRepositor)
		{
			_myNewEntityRepository = myNewEntityRepositor;
		}


		public IList<MyNewEntity> GetAllList()
		{
			var query = _myNewEntityRepository.Table;
			

			return query.ToList();
		}

		public void AddNew(MyNewEntity entity)
		{
			_myNewEntityRepository.Insert(entity);
		}

		public void Delete(MyNewEntity entity)
		{
			_myNewEntityRepository.Delete(entity);
		}

		public MyNewEntity GetById(int id)
		{
			return _myNewEntityRepository.GetById(id);
		}

		public void Update(MyNewEntity entity)
		{
			_myNewEntityRepository.Update(entity);
		}
	}
}
