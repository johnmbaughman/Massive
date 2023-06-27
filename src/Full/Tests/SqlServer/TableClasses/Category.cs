using System.Data.Common;

namespace Massive.Tests.TableClasses
{
	public class Category : DynamicModel
	{
		public Category(DbConnection connection, bool includeSchema) :
			base(connection: connection, tableName: includeSchema ? "dbo.Categories" : "Categories", primaryKeyField: "CategoryID")
		{
		}
	}
}
