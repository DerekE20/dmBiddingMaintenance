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
using System.Data.Entity;
using xBiddingMaintenance_1.ViewModel;

namespace xBiddingMaintenance_1
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        // Define connection object context (see app.config for name)
        //dmBiddingEntities4 context = new dmBiddingEntities4();
      
         public MainWindow()
        {
            InitializeComponent();
            
            //These two lines borrowed from app.xaml.cs to avoid two widows being launched, the first one having no data context.           
            var viewModel = new dmBiddingMainWindowViewModel();
            this.DataContext = viewModel;
        }


        private void Window_Loaded(object sender, RoutedEventArgs e)
        {
            //context.methods.Load();
        }

        private void methodDescriptionComboBox_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            object _SelectedMethod = sender;
            /*bidstagesViewSource = (CollectionViewSource)Application.Current.MainWindow.FindResource("bidstagesViewSource");
            //methodViewSource = (CollectionViewSource)Application.Current.MainWindow.FindResource("methodViewSource");
            
            SelectedMethod = (method)methodDescriptionComboBox.SelectedItem;

            bidstagesViewSource.Filter += new FilterEventHandler(bidstagesViewSource_Filter);
            methodactionsViewSource.Filter += new FilterEventHandler(methodActionsViewSource_Filter);
            */
        }
        /*private void bidstagesViewSource_Filter(object sender, FilterEventArgs e)
        {
            bid _bid = e.Item as bid;
            if ((_bid != null) & (SelectedMethod != null) & (SelectedStage !=null))
            {
                // Filter logic here
                if ((_bid.MethodRef == SelectedMethod.MethodId) & (_bid.StageRef==SelectedStage.StageId))
                {
                    e.Accepted = true;
                }
                else
                {
                    e.Accepted = false;
                }
            }
        }
        private void methodActionsViewSource_Filter(object sender, FilterEventArgs e)
        {
            action _action = e.Item as action;
            if ((_action != null) & (SelectedMethod != null) & (SelectedStage != null))
            {
                // Filter logic here
                if ((_action.MethodRef == SelectedMethod.MethodId) & (_action.StageRef == SelectedStage.StageId))
                {
                    e.Accepted = true;
                }
                else
                {
                    e.Accepted = false;
                }
            }
        }

        */
        //Repeat for stage selection combobox.
        private void stageDescriptionComboBox_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            object _SelectedStage = sender;
            /*stageViewSource = (CollectionViewSource)Application.Current.MainWindow.FindResource("stageViewSource");
            //methodViewSource = (CollectionViewSource)Application.Current.MainWindow.FindResource("methodViewSource");
            
            SelectedStage = (stage)stageDescriptionComboBox.SelectedItem;

            bidstagesViewSource.Filter += new FilterEventHandler(bidstagesViewSource_Filter);
            //******************REPLACE THIS SOMEHOW methodactionsViewSource.Filter += new FilterEventHandler(methodActionsViewSource_Filter);
            */
        }


        /*private void stageViewSource_Filter(object sender, FilterEventArgs e)
        {
            bid _bid = e.Item as bid;
            if ((_bid != null) & (SelectedMethod != null))
            {
                // Filter logic here
                if (_bid.MethodRef == SelectedMethod.MethodId)
                {
                    e.Accepted = true;
                }
                else
                {
                    e.Accepted = false;
                }
            }*/
    }
}


