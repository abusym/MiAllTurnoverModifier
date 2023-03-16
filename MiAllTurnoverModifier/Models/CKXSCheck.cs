using System;
using SqlSugar;

namespace MiAllTurnoverModifier.Models
{
    /// <summary>
    /// 
    ///</summary>
    [SugarTable("CKXSCheck")]
    public class CKXSCheck
    {
        /// <summary>
        ///  
        ///</summary>
         [SugarColumn(ColumnName="OrderNo" ,IsPrimaryKey = true    )]
         public string OrderNo { get; set; }
        /// <summary>
        ///  
        ///</summary>
         [SugarColumn(ColumnName="OrderDate"     , IsNullable = true)]
         public DateTime? OrderDate { get; set; }
        /// <summary>
        /// 供应商序号 
        ///</summary>
         [SugarColumn(ColumnName="ClientNo"     , IsNullable = true)]
         public string ClientNo { get; set; }
        /// <summary>
        ///  
        ///</summary>
         [SugarColumn(ColumnName="StoreNo"     , IsNullable = true)]
         public string StoreNo { get; set; }
        /// <summary>
        /// 入库方式对JBIInOutType 
        ///</summary>
         [SugarColumn(ColumnName="InOutTypeNo"     , IsNullable = true)]
         public string InOutTypeNo { get; set; }
        /// <summary>
        /// 订单序号 
        ///</summary>
         [SugarColumn(ColumnName="BillOrderNo"     , IsNullable = true)]
         public string BillOrderNo { get; set; }
        /// <summary>
        /// 其他相关单号 
        ///</summary>
         [SugarColumn(ColumnName="RelatedBillNo"     , IsNullable = true)]
         public string RelatedBillNo { get; set; }
        /// <summary>
        /// 部门序号 
        ///</summary>
         [SugarColumn(ColumnName="DepartmentNo"     , IsNullable = true)]
         public string DepartmentNo { get; set; }
        /// <summary>
        /// 业务员序号 
        ///</summary>
         [SugarColumn(ColumnName="EmployeeNo"     , IsNullable = true)]
         public string EmployeeNo { get; set; }
        /// <summary>
        /// 制单人 
        ///</summary>
         [SugarColumn(ColumnName="Operator"     , IsNullable = true)]
         public string Operator { get; set; }
        /// <summary>
        /// 已收金额 
        ///</summary>
         [SugarColumn(ColumnName="PayAmount"     , IsNullable = true)]
         public decimal? PayAmount { get; set; }
        /// <summary>
        /// 调整金额 
        ///</summary>
         [SugarColumn(ColumnName="AdjustAmount"     , IsNullable = true)]
         public decimal? AdjustAmount { get; set; }
        /// <summary>
        /// 出库总金额 
        ///</summary>
         [SugarColumn(ColumnName="CKAmount"     , IsNullable = true)]
         public decimal? CKAmount { get; set; }
        /// <summary>
        /// 销售总金额（税价合计金额） 
        ///</summary>
         [SugarColumn(ColumnName="Amount"     , IsNullable = true)]
         public decimal? Amount { get; set; }
        /// <summary>
        /// 退补总金额 
        ///</summary>
         [SugarColumn(ColumnName="PatchAmount"     , IsNullable = true)]
         public decimal? PatchAmount { get; set; }
        /// <summary>
        /// 审核状态 
        /// 默认值: (0)
        ///</summary>
         [SugarColumn(ColumnName="CheckFlag"     , IsNullable = true)]
         public short? CheckFlag { get; set; }
        /// <summary>
        /// 审核日期 
        ///</summary>
         [SugarColumn(ColumnName="CheckDate"     , IsNullable = true)]
         public DateTime? CheckDate { get; set; }
        /// <summary>
        /// 审核人 
        ///</summary>
         [SugarColumn(ColumnName="CheckMan"     , IsNullable = true)]
         public string CheckMan { get; set; }
        /// <summary>
        ///  
        ///</summary>
         [SugarColumn(ColumnName="RePayType"     , IsNullable = true)]
         public string RePayType { get; set; }
        /// <summary>
        ///  
        ///</summary>
         [SugarColumn(ColumnName="CollateType"     , IsNullable = true)]
         public short? CollateType { get; set; }
        /// <summary>
        /// 记录数 
        ///</summary>
         [SugarColumn(ColumnName="RecordCount"     , IsNullable = true)]
         public int? RecordCount { get; set; }
        /// <summary>
        ///  
        ///</summary>
         [SugarColumn(ColumnName="Memo"     , IsNullable = true)]
         public string Memo { get; set; }
        /// <summary>
        ///  
        /// 默认值: (0)
        ///</summary>
         [SugarColumn(ColumnName="RedFlag"     , IsNullable = true)]
         public short? RedFlag { get; set; }
        /// <summary>
        ///  
        ///</summary>
         [SugarColumn(ColumnName="RedDate"     , IsNullable = true)]
         public DateTime? RedDate { get; set; }
        /// <summary>
        ///  
        ///</summary>
         [SugarColumn(ColumnName="RedMan"     , IsNullable = true)]
         public string RedMan { get; set; }
        /// <summary>
        ///  
        /// 默认值: (0)
        ///</summary>
         [SugarColumn(ColumnName="HasRed"     , IsNullable = true)]
         public short? HasRed { get; set; }
        /// <summary>
        ///  
        ///</summary>
         [SugarColumn(ColumnName="XSReceiveOrderNo"     , IsNullable = true)]
         public string XSReceiveOrderNo { get; set; }
        /// <summary>
        ///  
        ///</summary>
         [SugarColumn(ColumnName="ThisPayAmount"     , IsNullable = true)]
         public decimal? ThisPayAmount { get; set; }
        /// <summary>
        ///  
        ///</summary>
         [SugarColumn(ColumnName="ThisAdjAmount"     , IsNullable = true)]
         public decimal? ThisAdjAmount { get; set; }
        /// <summary>
        ///  
        ///</summary>
         [SugarColumn(ColumnName="OrderPreAmt"     , IsNullable = true)]
         public decimal? OrderPreAmt { get; set; }
        /// <summary>
        ///  
        ///</summary>
         [SugarColumn(ColumnName="ThisPatchAmount"     , IsNullable = true)]
         public decimal? ThisPatchAmount { get; set; }
        /// <summary>
        ///  
        ///</summary>
         [SugarColumn(ColumnName="changeamt"     , IsNullable = true)]
         public decimal? Changeamt { get; set; }
        /// <summary>
        ///  
        ///</summary>
         [SugarColumn(ColumnName="ClientPay"     , IsNullable = true)]
         public decimal? ClientPay { get; set; }
    }
}
