using App.TissueMes.Models.Entities;
using App.TissueMes.Models.Entities.Operation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace App.TissueMes.IService.Operation.Papermaking.Basic
{
    public interface ITax0024Service: IOperationService
    {
        #region CRUD
        void Insert(Tax0024 tax0024);
        List<Tax0024> Query(Tax0024 tax1015);
        void Update(Tax0024 tax1015);
        void Delete(Tax0024 tax1015);
        #endregion

        /// <summary>
        ///  根据复卷机台和sku 获取对应的系数 获取补刀返回1
        /// </summary>
        /// <param name="machine">复卷机台</param>
        /// <param name="sku">sku</param>
        /// <returns></returns>
        decimal GetTax0024(string machine, string sku);
    }
}
