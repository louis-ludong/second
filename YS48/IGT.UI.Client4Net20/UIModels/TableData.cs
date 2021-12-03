using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace IGT.UI.Client.UIModels
{
    /// <summary>
    /// 表格数据
    /// </summary>
    public class TableData
    {
        /// <summary>
        /// 列索引
        /// </summary>
        public int ColumnIndex { get; set; }
        /// <summary>
        /// 行索引
        /// </summary>
        public int RowIndex { get; set; }
        /// <summary>
        /// 值
        /// </summary>
        public byte Value { get; set; }//LDC MAP修改<Sbyte>改为<byte>
    }
}
