using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace _3
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {

            InitializeComponent();
        }

       

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            try
            {

                ModeWindow window = new ModeWindow(tb_header.Text,

                    Convert.ToInt32(tb_coor_x.Text), Convert.ToInt32(tb_coor_y.Text), Convert.ToInt32(tb_horizont.Text),
                    Convert.ToInt32(tb_vertical.Text), tb_color.Text,Convert.ToBoolean(cb_isvisible.IsChecked));
                    if (!Convert.ToBoolean(cb_isvisible.IsChecked)) window.Hide();





            }

            catch (Exception ex) { MessageBox.Show($"Введен неверный формат поля/полей. Подробнее:  {ex}"); }






        }







    }
}