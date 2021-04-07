using GalaSoft.MvvmLight;
using GalaSoft.MvvmLight.Command;

namespace SISP.ViewModel
{
    public class MainViewModel : ViewModelBase
    {
        #region UI Variable
        private int _FileManagerHeight;
        public int FileManagerHeight
        {
            get => _FileManagerHeight;
            set => Set(ref _FileManagerHeight, value);
        }

        private bool _IsOpenFileManager;
        public bool IsOpenFileManager
        {
            get => _IsOpenFileManager;
            set => Set(ref _IsOpenFileManager, value);
        }

        #endregion

        #region Command
        public RelayCommand<object> ButtonClickCommand { get; private set; }
        public RelayCommand<System.Windows.SizeChangedEventArgs> WindowSizeChangedCommand { get; private set; }

        private void InitRelayCommand()
        {
            ButtonClickCommand = new RelayCommand<object>(OnMenuClick);
            WindowSizeChangedCommand = new RelayCommand<System.Windows.SizeChangedEventArgs>(OnWindowSizeChanged);
        }

        #region Command Action
        private void OnMenuClick(object param)
        {
            switch (param.ToString())
            {
                case "OpenFileManager":
                    OpenFileManager();
                    break;
                case "Exit":

                    break;
                case "EdgeDetection":
                    ;
                    break;
            }
        }

        private void OpenFileManager()
        {
            IsOpenFileManager = true;
        }

        private void OnWindowSizeChanged(System.Windows.SizeChangedEventArgs e)
        {
            FileManagerHeight = (int)(e.NewSize.Height * 0.6);
        }
        #endregion
        #endregion

        public MainViewModel()
        {
            InitRelayCommand();
            FileManagerHeight = 400;
        }
    }
}