using ClassroomManagement.Domain.Entities;
using System.Linq.Expressions;

namespace ClassroomManagement.Domain.Queries
{
	public static class BaseQueries
	{
		public static Expression<Func<T , bool>> Get<T>(int id) where T : BaseEntiy
		{
			return x => x.Id == id;
		}
	}
}
