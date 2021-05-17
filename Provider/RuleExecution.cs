﻿using System;
using System.Linq.Expressions;

namespace Provider
{
    public static class RuleExecution
    {
		public static Expression BuildExpr<T>(Rule r, ParameterExpression param)
		{
			var left = MemberExpression.Property(param, r.MemberName);
			var tProp = typeof(T).GetProperty(r.MemberName).PropertyType;
			ExpressionType tBinary;
			if (ExpressionType.TryParse(r.Operator, out tBinary))
			{
				var right = Expression.Constant(Convert.ChangeType(r.TargetValue, tProp));
				// use a binary operation, e.g. 'Equal' -> 'u.Age == 15'
				return Expression.MakeBinary(tBinary, left, right);
			}
			else
			{
				var method = tProp.GetMethod(r.Operator);
				var tParam = method.GetParameters()[0].ParameterType;
				var right = Expression.Constant(Convert.ChangeType(r.TargetValue, tParam));
				// use a method call, e.g. 'Contains' -> 'u.Tags.Contains(some_tag)'
				return Expression.Call(left, method, right);
			}
		}
	}
}
