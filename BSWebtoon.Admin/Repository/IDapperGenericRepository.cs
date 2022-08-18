using System.Collections.Generic;

namespace BSWebtoon.Admin.Repository
{
	/// <summary>
	/// 每個repo都有 五個基本方法，但實作/型別不同，所以用【泛型介面】規範
	/// </summary>
	/// <typeparam name="T">資料表模型</typeparam>
	public interface IDapperGenericRepository<T> where T : class
	{
		/// <summary>
		/// C，回傳受影響資料列數
		/// </summary>
		int Create(T entity);

		/// <summary>
		/// U，回傳受影響資料列數
		/// </summary>
		int Update(T entity);

		

		/// <summary>
		/// D，回傳受影響資料列數
		/// </summary>
		int Delete(T entity);

		/// <summary>
		/// R全部(多筆)
		/// </summary>
		IEnumerable<T> SelectAll();

		/// <summary>
		/// 用ID R單筆
		/// </summary>
		T SelectById(int id);
	}
}
