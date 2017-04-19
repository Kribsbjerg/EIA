using System;
using System.Drawing;
using System.Windows;
using System.Windows.Forms;

namespace EIAUI
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();

            this.DataContext = new WindowViewModel(this);
        }

        private void Button_MouseEnter(object sender, System.Windows.Input.MouseEventArgs e)
        {

        }

        //    NotifyIcon ni = new NotifyIcon();
        //    ni.Icon = new Icon("Main.ico");
        //    ni.Visible = true;
        //    ni.DoubleClick +=
        //        delegate (object sender, EventArgs args)
        //        {
        //            this.Show();
        //            this.WindowState = WindowState.Normal;
        //        };
        //}


        //protected override void OnStateChanged(EventArgs e)
        //{
        //    if (WindowState == WindowState.Minimized)
        //        this.Hide();

        //    base.OnStateChanged(e);
        //}
    }
}
