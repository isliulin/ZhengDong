﻿using System;
using System.Collections.Generic;
using System.Text;
using System.Data;


namespace FishBll.Bll
{
    public class FunCodeBll
    {
        private readonly Dao.FunCodeDao dal=new Dao.FunCodeDao();
        public FunCodeBll()
		{}
		#region  BasicMethod
		/// <summary>
		/// 是否存在该记录
		/// </summary>
		public bool Exists(int funid)
		{
			return dal.Exists(funid);
		}

        public bool Exists(String code)
        {
            return dal.Exists(code);
        }
		/// <summary>
		/// 增加一条数据
		/// </summary>
		public bool Add(FishEntity.FunCodeEntity model)
		{
			return dal.Add(model);
		}

		/// <summary>
		/// 更新一条数据
		/// </summary>
		public bool Update(FishEntity.FunCodeEntity model)
		{
			return dal.Update(model);
		}

		/// <summary>
		/// 删除一条数据
		/// </summary>
		public bool Delete(int funid)
		{
			
			return dal.Delete(funid);
		}
		/// <summary>
		/// 删除一条数据
		/// </summary>
		public bool DeleteList(string funidlist )
		{
			return dal.DeleteList(funidlist );
		}

		/// <summary>
		/// 得到一个对象实体
		/// </summary>
		public FishEntity.FunCodeEntity GetModel(int funid)
		{
			
			return dal.GetModel(funid);
		}
		/// <summary>
		/// 获得数据列表
		/// </summary>
		public DataSet GetList(string strWhere)
		{
			return dal.GetList(strWhere);
		}
		/// <summary>
		/// 获得数据列表
		/// </summary>
		public List<FishEntity.FunCodeEntity> GetModelList(string strWhere)
		{
			DataSet ds = dal.GetList(strWhere);
			return DataTableToList(ds.Tables[0]);
		}
		/// <summary>
		/// 获得数据列表
		/// </summary>
		public List<FishEntity.FunCodeEntity> DataTableToList(DataTable dt)
		{
			List<FishEntity.FunCodeEntity> modelList = new List<FishEntity.FunCodeEntity>();
			int rowsCount = dt.Rows.Count;
			if (rowsCount > 0)
			{
				FishEntity.FunCodeEntity model;
				for (int n = 0; n < rowsCount; n++)
				{
					model = dal.DataRowToModel(dt.Rows[n]);
					if (model != null)
					{
						modelList.Add(model);
					}
				}
			}
			return modelList;
		}

		/// <summary>
		/// 获得数据列表
		/// </summary>
		public DataSet GetAllList()
		{
			return GetList("");
		}

		/// <summary>
		/// 分页获取数据列表
		/// </summary>
		public int GetRecordCount(string strWhere)
		{
			return dal.GetRecordCount(strWhere);
		}
		/// <summary>
		/// 分页获取数据列表
		/// </summary>
		public DataSet GetListByPage(string strWhere, string orderby, int startIndex, int endIndex)
		{
			return dal.GetListByPage( strWhere,  orderby,  startIndex,  endIndex);
		}
		/// <summary>
		/// 分页获取数据列表
		/// </summary>
		//public DataSet GetList(int PageSize,int PageIndex,string strWhere)
		//{
			//return dal.GetList(PageSize,PageIndex,strWhere);
		//}

		#endregion  BasicMethod
		#region  ExtensionMethod

		#endregion  ExtensionMethod
    }
}
