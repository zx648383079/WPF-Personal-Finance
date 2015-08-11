using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;
using WPF_Personal_Finance.Model;

namespace WPF_Personal_Finance.ViewModel
{
    public class MainViewModel:WorkViewModel
    {
        public MainViewModel()
        {
            this.AddCommand = new CommandBase(param=>this.Add());
            Moneys = new ObservableCollection<MoneyInfo>();
        }
        #region 属性

        public static ObservableCollection<MoneyInfo> Moneys
        {
            get;
            set;
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
            AddViewModel addViewModel = new AddViewModel(new View.AddWindow());
            
            
            /*View.AddWindow addWindow = new View.AddWindow();
            AddViewModel addViewModel = new AddViewModel();
            EventHandler handler = null;
            handler = delegate
            {
                addViewModel.RequestClose -= handler;
                addWindow.Close();
            };
            addViewModel.RequestClose += handler;
            addWindow.DataContext = addViewModel;
            addWindow.Show();*/
        }
        
        #endregion
    }
}
