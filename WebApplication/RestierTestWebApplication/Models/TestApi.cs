using Microsoft.Restier.EntityFramework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace RestierTestWebApplication.Models
{
	public class TestApi : DbApi<TestEntities>
	{
		public TestEntities Context
		{
			get
			{
				return DbContext;
			}
		}
	}
}