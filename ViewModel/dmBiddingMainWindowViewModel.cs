using System;
using System.Windows;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel;
using System.Runtime.CompilerServices;
using System.Windows.Data;
using System.Data.Entity;
using System.Globalization;


namespace xBiddingMaintenance_1.ViewModel
{
     public class dmBiddingMainWindowViewModel : WorkspaceViewModel
    {
        public dmBiddingEntities4 ctx = new dmBiddingEntities4();
        //dmBiddingEntities context = new dmBiddingEntities();
        //CollectionViewSource bidsViewSource;
        CollectionViewSource bidstagesViewSource;
        System.Windows.Data.CollectionViewSource methodViewSource = ((System.Windows.Data.CollectionViewSource)(App.Current.MainWindow.FindResource("methodViewSource")));
        System.Windows.Data.CollectionViewSource stageViewSource = ((System.Windows.Data.CollectionViewSource)(App.Current.MainWindow.FindResource("stageViewSource")));

        private ICollectionView _methodView;
        private ICollectionView _stageView;

        public ICollectionView methodView
        {
            get { return _methodView; }
        }
        public ICollectionView stageView
        {
            get { return _stageView; }
        }

         public dmBiddingMainWindowViewModel(string _route)
        { 
            // route: Bids or Actions?
            string _chosenroute = _route;
            
            IList<method> Methods = GetMethods();
            IList<stage> Stages = GetStages();
            _methodView = CollectionViewSource.GetDefaultView(Methods);
            _stageView = CollectionViewSource.GetDefaultView(Stages);
        }
        public IList<method> GetMethods()
        {
            IList<method> _methods = (from method in ctx.methods select method).ToList();

            return _methods;
        }
        private List<method> _methods;

        public List<method> Methods
        {
            get { return _methods; }
            set
            {
                _methods = value;
                NotifyPropertyChanged();
            }
        }
        private List<stage> _stages;

        public List<stage> Stages
        {
            get { return _stages; }
            set
            {
                _stages = value;
                NotifyPropertyChanged();
            }
        }


        public IList<stage> GetStages()
        {
            //dmBiddingEntities4 _ctx = new dmBiddingEntities4();
            IList<stage> stages = (from stage in ctx.stages select stage).ToList();
            return stages;
        }

        //###################
        /*public class DistinctConverter : IValueConverter
        {
            private List<stage> xStages = new List<stage>();
            //dmBiddingEntities ctx = new dmBiddingEntities();
            //CollectionViewSource bidsViewSource;
            private List<stage> GetDistinctStages()
            {
                dmBiddingEntities _ctx = new dmBiddingEntities();
                
                xStages = (from StageDescription in _ctx.stages select StageDescription).ToList();
                return xStages;
            }
            public object Convert(
                object value, Type targetType, object parameter, CultureInfo culture)
            {
                //var values = value as IEnumerable<Type>;
                //var values = value as CollectionView;
                var _values = GetDistinctStages();
                if (_values == null)
                    return null;
                //return values.Cast<object>().Distinct();
                return _values;
            }

            public object ConvertBack(
                object value, Type targetType, object parameter, CultureInfo culture)
            {
                throw new NotSupportedException();
            }
        }
        */
        //###################
        /*public dmBiddingMainWindowViewModel()
        {

            //FillStages();
            //**NOTE: Application.Curremt.FindResource DOES NOT WORK: You must define the more precise location...in this case MainWindow.
            bidstagesViewSource = (CollectionViewSource)Application.Current.MainWindow.FindResource("bidstagesViewSource");
            //bidsViewSource.Filter += new FilterEventHandler(ShowSelectedStageFilter);
            //bidstagesViewSource.Filter += new FilterEventHandler(bidstagesViewSource_Filter);


        }
        /*private void bidstagesViewSource_Filter(object sender, FilterEventArgs e)
        {
            bid _bid = e.Item as bid;
            if ((_bid != null ) & (SelectedSystem !=null) & (SelectedStage != null))
            {
                // Filter out products with price 25 or above
                string s = SelectedSystem.SystemDescription;
                string s1 = SelectedStage.StageDescription;
                int i = SelectedSystem.SystemId;
                int j = SelectedStage.StageId;
                if ((_bid.SystemRef == i) & (_bid.StageRef == j))
                {
                    e.Accepted = true;
                }
                else
                {
                    e.Accepted = false;
                }
            }
        }*/
        //bidstagesViewSource_Filter

        /*private void FillStages()
        {
            var q = (from a in ctx.stages select a).ToList();
        }

        private List<stage> _stages;

        public List<stage> Stages
        {
            get { return _stages; }
            set {
                _stages = value;
                NotifyPropertyChanged();
            }
        }
        public List<stage> xStages = new List<stage>();
        public List<stage> GetDistinctStages()
        { 
            xStages = (from StageDescription in ctx.stages select StageDescription).ToList();
            return xStages;
        }
        */
        /*private void FillSystems()
       {
           var q = (from a in ctx.systems
                    select a).ToList();
           this.Systems = q;
       }
       private List<System> _systems;
       public List<System> Systems
       {
           get
           {
               return _systems;
           }
           set
           {
               _systems = value;
               NotifyPropertyChanged();
           }
       }

       */
       private method _selectedMethod;
       public method SelectedMethod
       {
           get
           {
               return _selectedMethod;
           }
           set
           {
               _selectedMethod = value;
               NotifyPropertyChanged();
               //FillBid();
           }
       }
        private stage _selectedStage;
        public stage SelectedStage
        {
            get
            {
                return _selectedStage;
            }
            set
            {
                _selectedStage = value;
                NotifyPropertyChanged();
                //FillBid();
            }
        }


        /*private void FillBid()
        {
            System system = this.SelectedSystem;

            var q = (from bid in ctx.bids
                     orderby bid.StageRef
                     where bid.SystemRef== System.SystemId
                     select book).ToList();

            this.Bids = q;
        }

        private List<Bid> _bids;
        public List<Bid> Bids
        {
            get
            {
                return _bids;
            }
            set
            {
                _bids = value;
                NotifyPropertyChanged();
            }
        }

        private Bid _selectedBid
        public Bid SelectedBid
        {
            get
            {
                return _selectedBid;
            }
            set
            {
                _selectedBid = value;
                NotifyPropertyChanged();
            }
        }*/
        public event PropertyChangedEventHandler PropertyChanged;
        
        private void NotifyPropertyChanged([CallerMemberName] String propertyName = "")
        {
            if (PropertyChanged != null)
            {
                PropertyChanged(this, new PropertyChangedEventArgs(propertyName));
            }
        }
    }
 
}