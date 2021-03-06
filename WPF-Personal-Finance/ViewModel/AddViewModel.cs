﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Input;

namespace WPF_Personal_Finance.ViewModel
{
    public class AddViewModel:WorkViewModel
    {
        public AddViewModel(Window win)
        {
            this.SavaCommand = new CommandBase(param => this.Sava());
            this.AddTime = DateTime.Now;
            this.Money = 0;

            this.OpenWindow(win);
        }
        #region 数据
        private DateTime _addTime;
        /// <summary>
        /// 日期
        /// </summary>
        public DateTime AddTime
        {
            get { return _addTime; }
            set
            {
                this.SetProperty(ref this._addTime, value);
            }
        }

        private int _kind;

        public int Kind
        {
            get { return _kind; }
            set { this.SetProperty(ref this._kind, value); }
        }

        private int _account;

        public int Account
        {
            get { return _account; }
            set { this.SetProperty(ref this._account, value); }
        }

        private double _money;
        /// <summary>
        /// 金额
        /// </summary>
        public double Money
        {
            get { return _money; }
            set
            {
                this.SetProperty(ref this._money, value);
            }
        }

        private string _remark;
        /// <summary>
        /// 备注
        /// </summary>
        public string Remark
        {
            get { return _remark; }
            set
            {
                this.SetProperty(ref this._remark, value);
            }
        }
        #endregion

        #region 事件

        public ICommand SavaCommand { get; set; }

        private void Sava()
        {
            Model.MoneyInfo moneys = new Model.MoneyInfo(this.AddTime, this.Kind , this.Account, this.Money, this.Remark);
            MainViewModel.Moneys.Add(moneys);
            this.CloseCommand.Execute(null);
        }
        

        #endregion
    }

    

    
}
