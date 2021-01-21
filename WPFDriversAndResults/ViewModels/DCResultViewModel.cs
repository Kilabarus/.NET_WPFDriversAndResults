using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WPFDriversAndResults.Models;

namespace WPFDriversAndResults.ViewModels
{
    public class DCResultViewModel : INotifyPropertyChanged
    {
        private readonly DCResult _DCResult;        

        public DCResultViewModel(DCResult DCResult)
        {
            _DCResult = DCResult;
        }

        public int Year
        {
            get => _DCResult.Championship.Year;
            set
            {
                _DCResult.Championship.Year = value;
                OnPropertyChanged("Year");
            }
        }

        public Enums.RacingSeries RacingSeries 
        {
            get => _DCResult.Championship.RacingSeries;
            set
            {
                _DCResult.Championship.RacingSeries = value;                    
                OnPropertyChanged("RacingSeries");
            }
        }

        public string DriverFullName
        {
            get => _DCResult.Driver.FullName;
            set
            {
                _DCResult.Driver.FullName = value;
                OnPropertyChanged("DriverFullName");
            }
        }

        public Enums.Team Team
        {
            get => _DCResult.Team;
            set
            {
                _DCResult.Team = value;
                OnPropertyChanged("Team");
            }
        }

        public int Wins
        {
            get => _DCResult.Wins;
            set
            {
                _DCResult.Wins = value;
                OnPropertyChanged("Wins");
            }
        }

        public int Points
        {
            get => _DCResult.Points;
            set
            {
                _DCResult.Points = value;
                OnPropertyChanged("Points");
            }
        }

        public int Place
        {
            get => _DCResult.Place;
            set 
            {
                _DCResult.Place = value;
                OnPropertyChanged("Place");
            }
        }

        public event PropertyChangedEventHandler PropertyChanged;
        private void OnPropertyChanged(string changedProperty = "")
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(changedProperty));            
        }
    }
}
