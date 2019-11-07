using System;
using System.Collections.Generic;
using System.Linq.Expressions;

namespace ApplicationCore.Interfaces
{
    public interface ISpecification<T>
    {
        /// <summary>
        /// 标准，基准
        /// </summary>
        Expression<Func<T, bool>> Criteria { get; }
        /// <summary>
        /// 包含
        /// </summary>
        List<Expression<Func<T, object>>> Includes { get; }
        /// <summary>
        /// 包含的字符串集合
        /// </summary>
        List<string> IncludeStrings { get; }
        /// <summary>
        /// 升序排序
        /// </summary>
        Expression<Func<T, object>> OrderBy { get; }
        /// <summary>
        /// 倒叙排序
        /// </summary>
        Expression<Func<T, object>> OrderByDescending { get; }
        /// <summary>
        /// 分组
        /// </summary>
        Expression<Func<T, object>> GroupBy { get; }

        int Take { get; }
        int Skip { get; }
        bool IsPagingEnabled { get; }
    }
}
