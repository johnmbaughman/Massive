using Massive;
using Massive.Tests;

namespace PostgreSql.TableClasses
{
	public class Customer : DynamicModel
	{
		public Customer()
			: this(includeSchema: true)
		{
		}


		public Customer(bool includeSchema) :
			base(TestConstants.ReadWriteTestConnectionStringName, includeSchema ? "public.customers" : "customers", "customerid")
		{
		}
	}
}
