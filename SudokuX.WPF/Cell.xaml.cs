using System;
using System.Collections.Generic;
using System.Diagnostics;
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

namespace SudokuX.WPF
{
    /// <summary>
    /// Interaction logic for Cell.xaml
    /// </summary>
    public partial class Cell : UserControl
    {
        public Cell()
        {
            InitializeComponent();
            Value = (short)(1 + new Random((int)DateTime.Now.Ticks).Next(8));
        }

        public short Value
        {
            get { return (short) GetValue(ValueProperty); }
            set { SetValue(ValueProperty, value);}
        }

        public static DependencyProperty ValueProperty = DependencyProperty.Register("Value", typeof(short), typeof(Cell));


    }
}
