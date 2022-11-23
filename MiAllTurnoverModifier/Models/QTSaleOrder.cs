using SqlSugar;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MiAllTurnoverModifier.Models
{
    [SugarTable("QTSaleOrder")]
    internal class QTSaleOrder
    {
        [SugarColumn(IsPrimaryKey = true)]
        public string OrderNo { get; set; }

        public decimal Amount { get; set; }

        public DateTime OrderDate { get; set; }
    }
}