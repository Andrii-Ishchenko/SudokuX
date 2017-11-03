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

namespace SudokuX.WPF
{
    /// <summary>
    /// Interaction logic for SudokuGrid.xaml
    /// </summary>
    public partial class SudokuGrid : UserControl
    {
        public SudokuGrid()
        {
            InitializeComponent();
            CreateStyledGrid();
        }

        private void CreateStyledGrid()
        {
            for (int i = 0; i < 9; i++)
            {
                for (int j = 0; j < 9; j++)
                {
                    var border = new Border()
                    {
                        BorderBrush = Brushes.Black,
                        BorderThickness = GetBorderThickness(i, j, 0.25, 1),
                        HorizontalAlignment = HorizontalAlignment.Stretch,
                        VerticalAlignment = VerticalAlignment.Stretch
                    };

                    Cell cell = new Cell();
                    border.Child = cell;
                    Grid.SetRow(border, i);
                    Grid.SetColumn(border, j);
                    rootGrid.Children.Add(border);
                }
            }


        }

        private Thickness GetBorderThickness(int i, int j, double thin, double thick)
        {
            var top = i%3 == 0 ? thick : thin;
            var bottom = i%3 == 2 ? thick : thin;
            var left = j%3 == 0 ? thick : thin;
            var right = j%3 == 2 ? thick : thin;
            return  new Thickness(left, top, right, bottom);
        }
    }
}
