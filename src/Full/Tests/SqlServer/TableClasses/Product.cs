namespace Massive.Tests.TableClasses
{
	public class Product : DynamicModel
	{
		public Product() : this(includeSchema:true)
		{
		}


		public Product(bool includeSchema) :
			base(TODO, TODO, tableName: includeSchema ? "dbo.Products" : "Products", primaryKeyField: "ProductID")
		{
		}
	}
}
