﻿using System;
using Hi.DALFactory;
using Hi.IDAL;
using Hi.Model;

namespace Hi.BLL
{
    [Serializable]
    public class DataAuto : MarshalByRefObject
    {
        private readonly IDataAuto _dal = DataAccess.CreateDataAuto();

        #region 成员方法

        public bool Exists(string strWhere)
        {
            return _dal.Exists(strWhere);
        }

        public bool Add(BasDataAuto model)
        {
            return _dal.Add(model);
        }

        #endregion
    }
}
