using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WPF_Personal_Finance.Model
{
    public class AccountInfo
    {
        private DateTime _addTime;

        public DateTime AddTime
        {
            get { return _addTime; }
            set { _addTime = value; }
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

        public AccountInfo()
        {

        }

        public AccountInfo(DateTime addtime, double money, string remark)
        {
            this.AddTime = addtime;
            this.Money = money;
            this.Remark = remark;
        }
    }
}
