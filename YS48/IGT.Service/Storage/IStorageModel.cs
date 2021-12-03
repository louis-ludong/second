using System;
using System.Collections.Generic;
using System.Text;

namespace IGT.Service.Storage
{
    /// <summary>
    /// 表示用于存储的Model
    /// </summary>
    interface IStorageModel : IDisposable 
    {
        /// <summary>
        /// 保存所有修改
        /// </summary>
        /// <param name="io">要写入的IO代理</param>
        void SaveChanges(SerialPortsUtils.Agents.Agent io);
        /// <summary>
        /// 取消所有修改
        /// </summary>
        void CancelChanges();
        ///// <summary>
        ///// 为已发生的修改创建镜像，这样在调用SaveChanges是能避免多线程读写
        ///// </summary>
        //void CreateGhostForSaveChanges();
    }
    /// <summary>
    /// 表示用于存储的Model
    /// </summary>
    /// <typeparam name="T">要存储的Model类型</typeparam>
    interface IStorageModel<T> : IStorageModel
    {
        /// <summary>
        /// 分离模型从此实例
        /// </summary>
        /// <returns>分离后的Model</returns>
        T Detaching();
        /// <summary>
        /// 附加模型到此实例
        /// </summary>
        /// <param name="model">要附加的Model</param>
        void Attach(T model);
    }
}
