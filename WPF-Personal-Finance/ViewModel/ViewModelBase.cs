using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace WPF_Personal_Finance.ViewModel
{
    public abstract class ViewModelBase: INotifyPropertyChanged, IDisposable
    {
        public event PropertyChangedEventHandler PropertyChanged;
        public bool IsInDesignMode;
        /// <summary> 显示名称 </summary> 
        public virtual string DisplayName { get; protected set; }

        #region 构造

        protected ViewModelBase()
        {

        }
        #endregion

        private void OnPropertyChanged(string propertyName)
        {
            if (this.PropertyChanged != null)
            {
                this.PropertyChanged(this, new PropertyChangedEventArgs(propertyName));
            }
        }
        private static string GetProperyName(string methodName)
        {
            if (methodName.StartsWith("get_") || methodName.StartsWith("set_") ||
                methodName.StartsWith("put_"))
            {
                return methodName.Substring(4);
            }
            throw new Exception(methodName + " not a method of Property");
        }

        protected void SetProperty<T>(ref T name, T value)
        {
            if (object.Equals(name, value)) return;
            name = value;
            string propertyName = GetProperyName(new System.Diagnostics.StackTrace(true).GetFrame(1).GetMethod().Name);
            this.OnPropertyChanged(propertyName);
        }

        #region IDisposable Members
        public void Dispose()
        {
            this.OnDispose();
        }
        /// <summary> 
        /// 若支持IDisposable，请重写此方法，当被调用Dispose时会执行此方法。 
        /// </summary> 
        protected virtual void OnDispose()
        {
        }
        #endregion
    }
}
