﻿namespace Massive.Tests.TableClasses
{
	public class Category : DynamicModel
	{
		public Category() : this(true)
		{
		}


		public Category(bool includeSchema) :
			base(TestConstants.WriteTestConnectionStringName, includeSchema ? "dbo.Categories" : "Categories", "CategoryID")
		{
		}
	}
}
