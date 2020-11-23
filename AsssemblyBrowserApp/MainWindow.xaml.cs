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

namespace AsssemblyBrowserApp
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        static TreeViewItem item;
        static public void Show(TreeView tree)
        {
            //DataSet datasSet = Class.GetDS();

            /*for (int i = 0; dsSet.Tables[0].Rows.Count > i; i++)
            {
                item = new TreeViewItem();
                //item.Header = dsSet.Tables[0].Rows[i][1];

                for (int j = 0; j < 2; j++)
                {
                    item.Items.Add("Monitor");
                    item.Items.Add("LapTop");
                }
                tree.Items.Add(item);
            }*/
        }
        //Show(treeView);

        public MainWindow()
        {
            InitializeComponent();

            
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {

        }
    }
}
