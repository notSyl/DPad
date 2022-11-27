using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net.Mime;
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
using Microsoft.Win32;

namespace Dpad
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

        private void ScrollZoom(object sender, MouseWheelEventArgs e)
        {
            
            if (Keyboard.IsKeyDown(Key.LeftCtrl) && e.Delta > 0)
            {
                Textbox.FontSize += 1;
            }
            else if (Keyboard.IsKeyDown(Key.LeftCtrl) && e.Delta < 0)
            {
                if (Textbox.FontSize > 1)
                {
                    Textbox.FontSize -= 1;
                }
            }
        }
        private void btnSaveFile_Click(object sender, RoutedEventArgs e)
        {
            SaveFileDialog saveFileDialog = new SaveFileDialog();
            if(saveFileDialog.ShowDialog() == true)
                File.WriteAllText(saveFileDialog.FileName, Textbox.Text);
        }

        private void btnSaveFile_Key(object sender, KeyboardEventArgs e)
        {
            if (e.KeyboardDevice.IsKeyDown(Key.LeftCtrl) && e.KeyboardDevice.IsKeyDown(Key.S))
            {
                SaveFileDialog saveFileDialog = new SaveFileDialog();
                if(saveFileDialog.ShowDialog() == true)
                    File.WriteAllText(saveFileDialog.FileName, Textbox.Text);
            }
            
        }
    }
}