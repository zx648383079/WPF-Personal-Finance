using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Input;

namespace WPF_Personal_Finance.ViewModel
{
    public class AccountViewModel:WorkViewModel
    {
        public AccountViewModel(Window win)
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
            Model.AccountInfo account = new Model.AccountInfo(this.AddTime, this.Money, this.Remark);
            //MainViewModel.Moneys.Add(account);
            this.CloseCommand.Execute(null);
        }

        #endregion
    }
}
