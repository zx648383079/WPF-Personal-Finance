﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WPF_Personal_Finance.Model
{
    public class MoneyInfo
    {
        private DateTime _addTime;

        public DateTime AddTime
        {
            get { return _addTime; }
            set { _addTime = value; }
        }

        private int _kind;

        public int Kind
        {
            get { return _kind; }
            set { _kind = value; }
        }

        private int _account;

        public int Account
        {
            get { return _account; }
            set { _account = value; }
        }



        private double _money;

        public double Money
        {
            get { return _money; }
            set { _money = value; }
        }

        private string _remark;

        public string Remark
        {
            get { return _remark; }
            set { _remark = value; }
        }

        public MoneyInfo()
        {

        }

        public MoneyInfo(DateTime addtime,int kind,int account,double money,string remark)
        {
            this.AddTime = addtime;
            this.Kind = kind;
            this.Account = account;
            this.Money = money;
            this.Remark = remark;
        }
    }
}
