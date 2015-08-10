using System;
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

        private string _kind;

        public string Kind
        {
            get { return _kind; }
            set { _kind = value; }
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

        public MoneyInfo(DateTime addtime,string kind,double money,string remark)
        {
            this.AddTime = addtime;
            this.Kind = kind;
            this.Money = money;
            this.Remark = remark;
        }
    }
}
