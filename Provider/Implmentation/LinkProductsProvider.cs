using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using System.Text;
using EntityFramework.Entity;

namespace Provider.Implmentation
{
    public class LinkProductsProvider
    {
		public Func<T, bool> CompileRule<T>(Rule r)
		{
			var paramUser = Expression.Parameter(typeof(ProductOrderMapping));
			Expression expr = RuleExecution.BuildExpr<T>(r, paramUser);
			return Expression.Lambda<Func<T, bool>>(expr, paramUser).Compile();
		}
	}
}
