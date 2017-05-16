using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Forms;
using System.Windows.Input;
using System.Windows.Media.Animation;

namespace EIAUI
{
    class WindowViewModel : BaseViewModel
    {
        #region Private Members

        /// <summary>
        /// The window this viewmodel controls
        /// </summary>
        private Window _window;

        /// <summary>
        /// The margin around the window to allow for a drop shadow
        /// </summary>
        private int _outerMarginSize = 10; //10;

        /// <summary>
        /// The radius of the edges of the windows
        /// </summary>
        private int _windowRadius = 0;

        NotifyIcon ni = new NotifyIcon();

        #endregion

        #region Constructors

        /// <summary>
        /// Default Constructor
        /// </summary>
        /// <param name="window"></param>
        public WindowViewModel(Window window)
        {
            _window = window;

            //_window.Topmost = true;

            // Listen out for the window resizing
            _window.StateChanged += (sender, e) =>
            {
                // Fire off events for all properties that are affected by a resize
                //OnPropertyChanged(nameof(ResizeBorderThickness));
                OnPropertyChanged(nameof(OuterMarginSize));
                OnPropertyChanged(nameof(OuterMarginSizeThickness));
                OnPropertyChanged(nameof(WindowRadius));
                OnPropertyChanged(nameof(WindowCornerRadius));
            };

            // Create commands
            // SeachCommand + new RelayCommand(() => );
            // NotificationCommand + new RelayCommand(() => );
            // UserCommand + new RelayCommand(() => );
            MinimizeCommand = new RelayCommand(() => SlideOutAndMinimizeAnimation()); //_window.WindowState = WindowState.Minimized
            MaximizeCommand = new RelayCommand(() => _window.WindowState ^= WindowState.Maximized);
            CloseCommand = new RelayCommand(() => _window.Close());
            SearchCommand = new RelayCommand(() => ActivateSearchDialog());

            ni.Icon = new Icon("Main.ico");
            ni.Click +=
                delegate (object sender, EventArgs args)
                {
                    ShowAndSlideInAnimation();
                };

            var a = new HotKey(Key.Space, KeyModifier.Win | KeyModifier.Alt, OnHotKeyHandler);
        }

        private void ActivateSearchDialog()
        {
            SearchActivated = !SearchActivated;

        }

        private void OnHotKeyHandler(HotKey hotKey)
        {
            if (_window.WindowState == WindowState.Minimized)
                ShowAndSlideInAnimation();
            else if (_window.IsActive)
                SlideOutAndMinimizeAnimation();
            else
                _window.Activate();
        }

        #endregion

        #region Public Properties

        /// <summary>
        /// The margin around the window to allow for a drop shadow
        /// </summary>
        public int OuterMarginSize
        {
            get
            {
                return _window.WindowState == WindowState.Maximized ? 0 : _outerMarginSize;
            }
            set
            {
                _outerMarginSize = value;
            }
        }

        /// <summary>
        /// The margin around the window to allow for a drop shadow
        /// </summary>
        public Thickness OuterMarginSizeThickness { get { return new Thickness(OuterMarginSize, 0, 0, 0); } }

        /// <summary>
        /// The radius of the edges of the window
        /// </summary>
        public int WindowRadius
        {
            get
            {
                return _window.WindowState == WindowState.Maximized ? 0 : _windowRadius;
            }
            set
            {
                _windowRadius = value;
            }
        }

        /// <summary>
        /// The radius of the edges of the window
        /// </summary>
        public CornerRadius WindowCornerRadius { get { return new CornerRadius(WindowRadius); } }

        /// <summary>
        /// The height of the title bar / caption of the window
        /// </summary>
        public int TitleHeight { get; set; } = 30;

        /// <summary>
        /// The height of the title bar / caption of the window
        /// </summary>
        public GridLength TitleHeightGridLength { get { return new GridLength(TitleHeight); } }

        /// <summary>
        /// The smallest width the window can go to
        /// </summary>
        public double WindowMinimumWidth { get; set; } = 1000;

        /// <summary>
        /// The smallest height the window can go to
        /// </summary>
        public double WindowMinimumHeight => SystemParameters.PrimaryScreenHeight;

        public double WindowLeftPosition => SystemParameters.PrimaryScreenWidth - WindowMinimumWidth;

        public bool SearchActivated { get; set; }

        #endregion

        #region Commands

        /// <summery>
        /// The command to search
        /// </summery>
        public ICommand SearchCommand { get; set; }

        /// <summery>
        /// The command to open notifications
        /// </summery>
        public ICommand NotificationCommand { get; set; }

        /// <summery>
        /// The command to open user
        /// </summery>
        public ICommand UserCommand{ get; set; }

        /// <summary>
        /// The command to minimize the window
        /// </summary>
        public ICommand MinimizeCommand { get; set; }

        /// <summary>
        /// The command to maximize the window
        /// </summary>
        public ICommand MaximizeCommand { get; set; }

        /// <summary>
        /// The command to close the window
        /// </summary>
        public ICommand CloseCommand { get; set; }

        #endregion

        #region Animation Methods

        private async void SlideOutAndMinimizeAnimation()
        {
            SearchActivated = false;
            await SlideOutAnimation();
            _window.WindowState = WindowState.Minimized;
            _window.Hide();
            ni.Visible = true;
        }

        private async Task SlideOutAnimation()
        {
            DoubleAnimation slideOut = new DoubleAnimation();

            slideOut.From = 1520;
            slideOut.To = 1920;
            slideOut.Duration = new Duration(TimeSpan.FromSeconds(0.8));

            _window.BeginAnimation(Window.LeftProperty, slideOut);

            await Task.Delay(800);
        }

        private async void ShowAndSlideInAnimation()
        {
            _window.Show();
            _window.WindowState = WindowState.Normal;
            _window.Activate();
            await SlideInAnimation();
            ni.Visible = false;
        }

        private async Task SlideInAnimation()
        {
            DoubleAnimation slideOut = new DoubleAnimation();

            slideOut.From = 1920;
            slideOut.To = 1520;
            slideOut.Duration = new Duration(TimeSpan.FromSeconds(0.8));

            _window.BeginAnimation(Window.LeftProperty, slideOut);

            await Task.Delay(800);
        }

        #endregion

    }
}