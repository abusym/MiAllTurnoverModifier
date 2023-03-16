using SqlSugar;

namespace MiAllTurnoverModifier.Models
{
    /// <summary>
    /// 
    ///</summary>
    [SugarTable("CKXSCheckDetail")]
    public class CKXSCheckDetail
    {
        /// <summary>
        /// 单号 
        ///</summary>
         [SugarColumn(ColumnName="OrderNo" ,IsPrimaryKey = true    )]
         public string OrderNo { get; set; }
        /// <summary>
        /// 序号 
        ///</summary>
         [SugarColumn(ColumnName="SerialNo" ,IsPrimaryKey = true    )]
         public int SerialNo { get; set; }
        /// <summary>
        /// 商品编号 
        ///</summary>
         [SugarColumn(ColumnName="GoodsNo"     )]
         public string GoodsNo { get; set; }
        /// <summary>
        /// 小件数 
        ///</summary>
         [SugarColumn(ColumnName="SUnitQuantity"     , IsNullable = true)]
         public decimal? SUnitQuantity { get; set; }
        /// <summary>
        /// 大件数 
        ///</summary>
         [SugarColumn(ColumnName="MUnitQuantity"     , IsNullable = true)]
         public decimal? MUnitQuantity { get; set; }
        /// <summary>
        /// 中件数 
        ///</summary>
         [SugarColumn(ColumnName="UnitQuantity"     , IsNullable = true)]
         public decimal? UnitQuantity { get; set; }
        /// <summary>
        ///  
        ///</summary>
         [SugarColumn(ColumnName="UnitPrice"     , IsNullable = true)]
         public decimal? UnitPrice { get; set; }
        /// <summary>
        /// 中件合计数 三类合计 
        ///</summary>
         [SugarColumn(ColumnName="Quantity"     , IsNullable = true)]
         public decimal? Quantity { get; set; }
        /// <summary>
        /// 默认价格 
        ///</summary>
         [SugarColumn(ColumnName="OrigPrice"     , IsNullable = true)]
         public decimal? OrigPrice { get; set; }
        /// <summary>
        /// 入库单价 
        ///</summary>
         [SugarColumn(ColumnName="Price"     , IsNullable = true)]
         public decimal? Price { get; set; }
        /// <summary>
        ///  
        ///</summary>
         [SugarColumn(ColumnName="Discount"     , IsNullable = true)]
         public decimal? Discount { get; set; }
        /// <summary>
        ///  
        ///</summary>
         [SugarColumn(ColumnName="SaleAmount"     , IsNullable = true)]
         public decimal? SaleAmount { get; set; }
        /// <summary>
        ///  
        ///</summary>
         [SugarColumn(ColumnName="TaxRate"     , IsNullable = true)]
         public decimal? TaxRate { get; set; }
        /// <summary>
        /// 税额 
        ///</summary>
         [SugarColumn(ColumnName="TaxAmount"     , IsNullable = true)]
         public decimal? TaxAmount { get; set; }
        /// <summary>
        /// 入库金额 
        ///</summary>
         [SugarColumn(ColumnName="Amount"     , IsNullable = true)]
         public decimal? Amount { get; set; }
        /// <summary>
        /// 订单单价 
        ///</summary>
         [SugarColumn(ColumnName="CKPrice"     , IsNullable = true)]
         public decimal? CKPrice { get; set; }
        /// <summary>
        /// 订单金额 
        ///</summary>
         [SugarColumn(ColumnName="CKAmount"     , IsNullable = true)]
         public decimal? CKAmount { get; set; }
        /// <summary>
        /// 退补单价 
        ///</summary>
         [SugarColumn(ColumnName="PatchPrice"     , IsNullable = true)]
         public decimal? PatchPrice { get; set; }
        /// <summary>
        /// 退补金额 
        ///</summary>
         [SugarColumn(ColumnName="PatchAmount"     , IsNullable = true)]
         public decimal? PatchAmount { get; set; }
        /// <summary>
        /// 单位 
        ///</summary>
         [SugarColumn(ColumnName="Unit"     , IsNullable = true)]
         public string Unit { get; set; }
        /// <summary>
        /// 复合单位 
        ///</summary>
         [SugarColumn(ColumnName="MixUnit"     , IsNullable = true)]
         public string MixUnit { get; set; }
        /// <summary>
        ///  
        ///</summary>
         [SugarColumn(ColumnName="UnitRate"     , IsNullable = true)]
         public string UnitRate { get; set; }
        /// <summary>
        /// 相关单号 
        ///</summary>
         [SugarColumn(ColumnName="RelatedOrderNo"     , IsNullable = true)]
         public string RelatedOrderNo { get; set; }
        /// <summary>
        ///  
        ///</summary>
         [SugarColumn(ColumnName="OrderSerialNo"     , IsNullable = true)]
         public int? OrderSerialNo { get; set; }
        /// <summary>
        ///  
        ///</summary>
         [SugarColumn(ColumnName="Memo"     , IsNullable = true)]
         public string Memo { get; set; }
        /// <summary>
        ///  
        ///</summary>
         [SugarColumn(ColumnName="LastPrice"     , IsNullable = true)]
         public decimal? LastPrice { get; set; }
    }
}
