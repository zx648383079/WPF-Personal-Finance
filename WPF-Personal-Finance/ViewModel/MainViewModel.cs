using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;

namespace WPF_Personal_Finance.ViewModel
{
    public class MainViewModel:WorkViewModel
    {
        public MainViewModel()
        {
            this.AddCommand = new CommandBase(param=>this.Add());
            this.Name = "测试";
        }
        #region 属性

        private string _name;

        
        public string Name
        {
            get { return _name; }
            set
            {
                base.SetProperty(ref this._name,value);
            }
        }
        #endregion

        #region 命令

        /// <summary>
        /// 
        /// </summary>
        public ICommand AddCommand { get; set; }
        #endregion

        #region 方法

        /// <summary>
        /// 初始化方法
        /// </summary>
        private void Add()
        {
            this.Name += "整的";
            View.AddWindow addWindow = new View.AddWindow();
            AddViewModel addViewModel = new AddViewModel();
            EventHandler handler = null;
            handler = delegate
            {
                addViewModel.RequestClose -= handler;
                addWindow.Close();
            };
            addViewModel.RequestClose += handler;
            addWindow.DataContext = addViewModel;
            addWindow.Show();
        }
        
        #endregion
    }
}
