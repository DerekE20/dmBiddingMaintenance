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
using System.Collections.ObjectModel;


namespace xBiddingMaintenance_1.ViewModel
{
     public class BidsViewModel : WorkspaceViewModel, INotifyPropertyChanged
    {
         public BidsViewModel() 
        {
            this.Methods = GetMethods();
            this.Stages = GetStages();
            this.Bids = GetBids();
        }
        public IList<method> GetMethods()
        {
            IList<method> _methods = (from method in ctx.methods select method).ToList();
            return _methods;
        }
        private IList<method> _methods;
        public IList<method> Methods
        {
            get { return _methods; }
            set
            {
                _methods = value;
            }
        }
        // Local version of Stages
        private IList<stage> _stages;
        public IList<stage> Stages
        {
            get { return _stages; }
            set
            {
                _stages = value;
            }
        }
        public IList<stage> GetStages()
        {
            IList<stage> _stages = (from stage in ctx.stages select stage).ToList();
            
            return _stages;
        }
        // Local version of Bids
        public IList<bid> GetBids()
        {
            // Need to use local variables in LINQ "where" statement.
            if (SelectedMethod == null)
            { SelectedMethod = this.Methods.First(); }
            int _methodId = SelectedMethod.MethodId;

            if (SelectedStage == null)
            { SelectedStage = this.Stages.First(); }
            int _stageId  = SelectedStage.StageId;

            List < bid> _bids = (from bid in ctx.bids where bid.MethodRef == _methodId where bid.StageRef ==_stageId select bid).ToList();
            return _bids;
        }
        private IList<bid> _bids;
        public IList<bid> Bids
        {
            get { return _bids; }
            set
            {
                _bids = value;
            }
        }
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
               
               this.Bids=GetBids();
               NotifyPropertyChanged("Bids");
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
                this.Bids=GetBids();
                NotifyPropertyChanged("Bids");
            }
        }
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