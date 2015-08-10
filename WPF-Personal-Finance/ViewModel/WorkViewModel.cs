using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;

namespace WPF_Personal_Finance.ViewModel
{
    /// <summary>
    /// 关闭
    /// </summary>
    public abstract class WorkViewModel:ViewModelBase
    {
        #region Fields

        CommandBase _closeCommand;

        #endregion // Fields

        #region Constructor

        protected WorkViewModel()
        {
        }

        #endregion // Constructor

        #region CloseCommand

        /// <summary>
        /// Returns the command that, when invoked, attempts
        /// to remove this workspace from the user interface.
        /// </summary>
        public ICommand CloseCommand
        {
            get
            {
                if (_closeCommand == null)
                    _closeCommand = new CommandBase(param => this.OnRequestClose());

                return _closeCommand;
            }
        }

        #endregion // CloseCommand

        #region RequestClose [event]

        /// <summary>
        /// Raised when this workspace should be removed from the UI.
        /// </summary>
        public event EventHandler RequestClose;

        void OnRequestClose()
        {
            EventHandler handler = this.RequestClose;
            if (handler != null)
                handler(this, EventArgs.Empty);
        }

        #endregion // RequestClose [event]
    }
}
