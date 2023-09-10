using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace Autorizate
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }
        bool pass_focus = false;
        private void Menu_MouseEnter(object sender, MouseEventArgs e)
        {
            Image image = sender as Image;
            image.Opacity = 100;
        }

        private void Menu_MouseLeave(object sender, MouseEventArgs e)
        {
            Image image = sender as Image;
            image.Opacity = 0.3;
            Mouse.OverrideCursor = null;
        }

        private void Grid_MouseDown(object sender, MouseButtonEventArgs e)
        {
            if (e.LeftButton == MouseButtonState.Pressed)
            {
                if (e.GetPosition(this).Y <= 15)
                    DragMove();
            }
        }

        private void Closed_MouseLeftButtonDown(object sender, MouseButtonEventArgs e)
        {
            Close();
        }

        private void Resize_MouseLeftButtonDown(object sender, MouseButtonEventArgs e)
        {
            WindowState = WindowState.Minimized;
        }

        private void Login_GotFocus(object sender, RoutedEventArgs e)
        {
            pass_focus = false;
            if (Hide_password.Visibility == Visibility.Visible)
            {
                if (Password.Password == "" && Password_block.Text != "")
                    Password_block.Text = "";
            }
            if (Show_password.Visibility == Visibility.Visible)
            {
                if (Password_block.Text == "" && Password.Password != "")
                    Password.Password = "";
            }
            if (Password_block.Text == "" && Password.Password == "")
            {
                Password_block.Text = "Password";
                Password.Visibility = Visibility.Hidden;
                Password_block.Visibility = Visibility.Visible;
            }
            if (Login.Text == "Login")
            {
                Login.Text = "";
                Login.CaretIndex = 0;
            }
        }

        private void Login_LostFocus(object sender, RoutedEventArgs e)
        {
            if (Login.Text == "")
                Login.Text = "Login";
        }

        private void Loading_Click(object sender, RoutedEventArgs e)
        {
            MessageBox.Show("Вы авторизировались.", "Успех!");
        }

        private void Loading_MouseLeave(object sender, MouseEventArgs e)
        {
            Border loadingBorder = Loading.Template.FindName("Loading_Border", Loading) as Border;
            loadingBorder.Opacity = 0.2;
            Mouse.OverrideCursor = null;
        }

        private void Loading_MouseEnter(object sender, MouseEventArgs e)
        {
            Border loadingBorder = Loading.Template.FindName("Loading_Border", Loading) as Border;
            loadingBorder.Opacity = 0.8;
        }

        private void Image_MouseLeftButtonDown(object sender, MouseButtonEventArgs e)
        {
            if (Hide_password.Visibility == Visibility.Visible)
            {
                if (Password.Password == "" && Password_block.Text != "")
                    Password_block.Text = "";
            }
            if (Show_password.Visibility == Visibility.Visible)
            {
                if (Password_block.Text == "" && Password.Password != "")
                    Password.Password = "";
            }
            if (Password_block.Text == "Password" && Password.Password == "")
            {
                Hide_password.Visibility = Visibility.Hidden;
                Show_password.Visibility = Visibility.Visible;
                Password_block.Visibility = Visibility.Visible;
                Password.Visibility = Visibility.Hidden;
                pass_focus = false;
                Password_block_LostFocus(null, null);
                bugs_fix.Focus();
            }
            else
            {
                Hide_password.Visibility = Visibility.Hidden;
                Show_password.Visibility = Visibility.Visible;
                Password_block.Visibility = Visibility.Visible;
                Password.Visibility = Visibility.Hidden;
                pass_focus = false;
                Password_block.Text = Password.Password;
                Password_block_LostFocus(null, null);
                bugs_fix.Focus();
            }
        }

        private void Show_password_MouseLeftButtonDown(object sender, MouseButtonEventArgs e)
        {
            if (Hide_password.Visibility == Visibility.Visible)
            {
                if (Password.Password == "" && Password_block.Text != "")
                    Password_block.Text = "";
            }
            if (Show_password.Visibility == Visibility.Visible)
            {
                if (Password_block.Text == "" && Password.Password != "")
                    Password.Password = "";
            }
            if (Password_block.Text == "Password" && Password.Password == "")
            {
                Hide_password.Visibility = Visibility.Visible;
                Show_password.Visibility = Visibility.Hidden;
                Password_block.Visibility = Visibility.Visible;
                Password.Visibility = Visibility.Hidden;
                pass_focus = false;
                Password_block_LostFocus(null, null);
                bugs_fix.Focus();
            }
            else
            {
                Hide_password.Visibility = Visibility.Visible;
                Show_password.Visibility = Visibility.Hidden;
                Password_block.Visibility = Visibility.Hidden;
                Password.Visibility = Visibility.Visible;
                pass_focus = false;
                Password.Password = Password_block.Text;
                Password_block_LostFocus(null, null);
                bugs_fix.Focus();
            }
        }

        private void Password_block_GotFocus(object sender, RoutedEventArgs e)
        {
            if (Show_password.Visibility == Visibility.Visible)
            {
                if (Password_block.Text == "Password" && Password.Password == "")
                {
                    Password_block.Text = "";
                    Password_block.Focus();
                }
            }
            if (Hide_password.Visibility == Visibility.Visible)
            {
                if (Password_block.Text == "Password" && Password.Password == "")
                {
                    Password_block.Text = "";
                    Password_block.Visibility = Visibility.Hidden;
                    Password.Visibility = Visibility.Visible;
                    pass_focus = true;
                    Password.Focus();
                }
            }
        }

        private void Password_block_LostFocus(object sender, RoutedEventArgs e)
        {
            if (pass_focus == true)
            {
                return;
            }
            else
            {
                if (Show_password.Visibility == Visibility.Visible)
                {
                    if (Password_block.Text == "" && Password.Password == "")
                    {
                        Password_block.Text = "Password";
                        Password.Visibility = Visibility.Hidden;
                        Password_block.Visibility = Visibility.Visible;
                    }
                }
                if (Hide_password.Visibility == Visibility.Visible)
                {
                    if (Password_block.Text == "" && Password.Password == "")
                    {
                        Password_block.Text = "Password";
                        Password.Visibility = Visibility.Hidden;
                        Password_block.Visibility = Visibility.Visible;
                    }
                }
            }
        }
    }
}
