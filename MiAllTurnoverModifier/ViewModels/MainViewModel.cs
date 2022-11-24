using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows;
using MiAllTurnoverModifier.Db;
using MiAllTurnoverModifier.Models;
using Prism.Commands;
using Prism.Mvvm;
using SqlSugar;
using Telerik.Windows.Controls;
using DelegateCommand = Prism.Commands.DelegateCommand;

namespace MiAllTurnoverModifier.ViewModels
{
    internal class MainViewModel : BindableBase
    {
        private readonly BackgroundWorker _queryCurrentAmountBackgroundWorker;
        private readonly BackgroundWorker _adjustAmountBackgroundWorker;

        public MainViewModel()
        {
            YearOptions = new List<int>()
            {
                DateTime.Now.Year - 1,
                DateTime.Now.Year
            };

            MonthOptions = new List<int>()
            {
                1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11, 12
            };

            Year = DateTime.Now.Year;
            Month = DateTime.Now.Month;

            _queryCurrentAmountBackgroundWorker = new BackgroundWorker();
            _queryCurrentAmountBackgroundWorker.DoWork += _queryCurrentAmountBackgroundWorkerDoWork;

            _adjustAmountBackgroundWorker = new BackgroundWorker();
            _adjustAmountBackgroundWorker.DoWork += _adjustAmountBackgroundWorker_DoWork;
            _adjustAmountBackgroundWorker.RunWorkerCompleted += _adjustAmountBackgroundWorker_RunWorkerCompleted;
        }

        private string _busyText;

        public string BusyText
        {
            get => _busyText;
            set => SetProperty(ref _busyText, value);
        }

        private bool _isBusy;

        public bool IsBusy
        {
            get => _isBusy;
            set => SetProperty(ref _isBusy, value);
        }

        private List<int> _yearOptions;

        public List<int> YearOptions
        {
            get => _yearOptions;
            set => SetProperty(ref _yearOptions, value);
        }

        private List<int> _monthOptions;

        public List<int> MonthOptions
        {
            get => _monthOptions;
            set => SetProperty(ref _monthOptions, value);
        }

        private int _year;

        public int Year
        {
            get => _year;
            set => SetProperty(ref _year, value);
        }

        private int _month;

        public int Month
        {
            get => _month;
            set => SetProperty(ref _month, value);
        }

        private decimal _currentAmount;

        public decimal CurrentAmount
        {
            get => _currentAmount;
            set => SetProperty(ref _currentAmount, value);
        }

        private decimal _targetAmount;

        public decimal TargetAmount
        {
            get => _targetAmount;
            set => SetProperty(ref _targetAmount, value);
        }


        private decimal _queryCurrentAmount()
        {
            var beginDate = new DateTime(Year, Month, 1);
            var endDate = beginDate.AddMonths(1);

            return SqlSugarHelper.Db.Queryable<QTSaleOrder>()
                .Where(o => o.OrderDate >= beginDate && o.OrderDate < endDate)
                .Sum(o => o.Amount);
        }

        private void _queryCurrentAmountBackgroundWorkerDoWork(object sender, DoWorkEventArgs e)
        {
            try
            {
                BusyText = "正在加载营业额";
                IsBusy = true;
                CurrentAmount = decimal.Round(_queryCurrentAmount(), 2);
            }
            finally
            {
                IsBusy = false;
            }
        }

        private void _adjustAmountBackgroundWorker_DoWork(object sender, DoWorkEventArgs e)
        {
            try
            {
                BusyText = "正在调整中";
                IsBusy = true;
                var total = decimal.Round(_queryCurrentAmount(), 2);

                if (total <= TargetAmount)
                {
                    e.Result = AdjustAmountResult.FailResult("目标金额必须大于原营业总额");
                    return;
                }

                var beginDate = new DateTime(Year, Month, 1);
                var endDate = beginDate.AddMonths(1);

                var currentAmount = total;
                for (var multiple = 10; multiple > 0; --multiple)
                {
                    var orders = SqlSugarHelper.Db.SqlQueryable<QTSaleOrder>(
                        $"SELECT [OrderNo],[Amount],[OrderDate] FROM [QTSaleOrder] where OrderDate>='{beginDate.ToString("yyyy-MM-dd")}' and OrderDate<'{endDate.ToString("yyyy-MM-dd")}' and OrderNo like '%{multiple}'").ToList();

                    foreach (var order in orders)
                    {
                        SqlSugarHelper.Db.Ado.ExecuteCommand(
                            $"delete QTSaleOrderDetail where OrderNo='{order.OrderNo}'");
                        SqlSugarHelper.Db.Deleteable(order).ExecuteCommand();

                        currentAmount -= order.Amount;
                        BusyText = $"正在调整中({decimal.Round(currentAmount, 2)})";

                        if (currentAmount < TargetAmount)
                        {
                            e.Result = AdjustAmountResult.SuccessResult();
                            return;
                        }
                    }
                }

                e.Result = AdjustAmountResult.SuccessResult();
            }
            catch (Exception exp)
            {
                e.Result = AdjustAmountResult.FailResult("执行失败：" + exp.Message);
            }
            finally
            {
                IsBusy = false;
            }
        }

        private void _adjustAmountBackgroundWorker_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
        {
            if (e.Result is AdjustAmountResult result)
            {
                RadWindow.Alert(new DialogParameters
                {
                    Content = result.Success ? "调整结束，请在管理后台查询验证" : result.Message,
                    Owner = Application.Current.MainWindow
                });

                if (result.Success) _queryCurrentAmountBackgroundWorker.RunWorkerAsync();
            }
        }

        public DelegateCommand CommandQueryCurrentAmount => new DelegateCommand(() =>
        {
            if (!_queryCurrentAmountBackgroundWorker.IsBusy)
            {
                _queryCurrentAmountBackgroundWorker.RunWorkerAsync();
            }
        });

        public DelegateCommand CommandAdjustAmount => new DelegateCommand(() =>
        {
            RadWindow.Confirm(new DialogParameters
            {
                Content = "确认要调整营业额吗？",
                Owner = Application.Current.MainWindow,
                Closed = (sender, e) =>
                {
                    if (e.DialogResult ?? false)
                    {
                        if (!_adjustAmountBackgroundWorker.IsBusy)
                        {
                            _adjustAmountBackgroundWorker.RunWorkerAsync();
                        }
                    }
                }
            });
        });
    }
}