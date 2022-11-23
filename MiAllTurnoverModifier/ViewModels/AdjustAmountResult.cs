using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MiAllTurnoverModifier.ViewModels
{
    internal class AdjustAmountResult
    {
        public bool Success { get; set; }
        public string Message { get; set; }

        private AdjustAmountResult(bool success, string message)
        {
            Success = success;
            Message = message;
        }

        public static AdjustAmountResult SuccessResult()
        {
            return new AdjustAmountResult(true, null);
        }

        public static AdjustAmountResult FailResult(string message)
        {
            return new AdjustAmountResult(false, message);
        }
    }
}
