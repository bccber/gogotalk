using CCWin;

namespace GoGoTalk
{
    /// <summary>
    /// 支持换肤的基础窗体。
    /// </summary>
    public partial class BaseForm : CCSkinMain
    {
        public BaseForm()
        {
            InitializeComponent();
            CheckForIllegalCrossThreadCalls = false;
        }
    }
}
