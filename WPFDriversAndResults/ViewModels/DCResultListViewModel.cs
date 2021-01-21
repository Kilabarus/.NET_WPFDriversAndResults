using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Data;
using System.Windows.Input;
using WPFDriversAndResults.Comands;
using WPFDriversAndResults.Models;

namespace WPFDriversAndResults.ViewModels
{
    public class DCResultListViewModel : INotifyPropertyChanged
    {
        public ObservableCollection<DCResultViewModel> DCResultList { get; set; }
        public ICollectionView DCResultsView { get; set; }

        private DCResultViewModel _selectedDCResult;
        public DCResultViewModel SelectedDCResult 
        { 
            get => _selectedDCResult;
            set
            {
                _selectedDCResult = value;
                OnPropertyChanged("SelectedDCResult");
            }
        }

        private bool _isGroupedByDrivers = false;
        public bool IsGroupedByDrivers
        {
            get => _isGroupedByDrivers;
            set
            {
                _isGroupedByDrivers = value;
                GroupUnGroup(value, "DriverFullName");
                OnPropertyChanged("IsGroupedByDrivers");
            }
        }

        private bool _isGroupedByRacingSeries = false;
        public bool IsGroupedByRacingSeries
        {
            get => _isGroupedByRacingSeries;
            set
            {
                _isGroupedByRacingSeries = value;
                GroupUnGroup(value, "RacingSeries");
                OnPropertyChanged("IsGroupedByRacingSeries");
            }
        }

        Dictionary<string, PropertyGroupDescription> groupByAttributes = new Dictionary<string, PropertyGroupDescription>()
        {
            { "DriverFullName",  new PropertyGroupDescription("DriverFullName")},
            { "RacingSeries",  new PropertyGroupDescription("RacingSeries")}
        };

        private void GroupUnGroup(bool shouldGroup, string attribute)
        {                                                 
            if (shouldGroup)
            {
                DCResultsView.GroupDescriptions.Add(groupByAttributes[attribute]);
            }
            else
            {
                DCResultsView.GroupDescriptions.Remove(groupByAttributes[attribute]);
            }
        }

        public DCResultListViewModel()
        {
            DCResultList = new ObservableCollection<DCResultViewModel>();

            Initialize();
            InitializeGrouppedView();
            InitializeCommands();
        }

        private void InitializeGrouppedView()
        {
            DCResultsView = CollectionViewSource.GetDefaultView(DCResultList);
        }

        public ICommand DeleteCommand { get; set; }
        private void InitializeCommands()
        {
            DeleteCommand = new RelayCommand(DeleteDCResult, CanExecuteDeleteDCResult);
        }

        private void Initialize()
        {
            DCResultList.Add(new DCResultViewModel(
                new DCResult()
                {
                    Place = 2,
                    Points = 380,
                    Wins = 10,
                    Team = Enums.Team.Mercedes,
                    
                    Driver = new Driver()
                    {
                        FullName = "Льюис Хэмильтон",
                        Country = Enums.Country.UK
                    },

                    Championship = new Championship()
                    {
                        Year = 2016,
                        RacingSeries = Enums.RacingSeries.F1,
                    }
                }
                ));
            DCResultList.Add(new DCResultViewModel(
                new DCResult()
                {
                    Place = 1,
                    Points = 363,
                    Wins = 9,
                    Team = Enums.Team.Mercedes,

                    Driver = new Driver()
                    {
                        FullName = "Льюис Хэмильтон",
                        Country = Enums.Country.UK
                    },

                    Championship = new Championship()
                    {
                        Year = 2017,
                        RacingSeries = Enums.RacingSeries.F1,
                    }
                }
                ));
            DCResultList.Add(new DCResultViewModel(
                new DCResult()
                {
                    Place = 1,
                    Points = 408,
                    Wins = 11,
                    Team = Enums.Team.Mercedes,

                    Driver = new Driver()
                    {
                        FullName = "Льюис Хэмильтон",
                        Country = Enums.Country.UK
                    },

                    Championship = new Championship()
                    {
                        Year = 2018,
                        RacingSeries = Enums.RacingSeries.F1,
                    }
                }
                ));
            DCResultList.Add(new DCResultViewModel(
                new DCResult() 
                {
                    Place = 10,
                    Points = 42,
                    Wins = 0,
                    Team = Enums.Team.McLaren,

                    Driver = new Driver()
                    {
                        FullName = "Фернандо Алонсо",
                        Country = Enums.Country.UK
                    },

                    Championship = new Championship()
                    {
                        Year = 2016,
                        RacingSeries = Enums.RacingSeries.F1,
                    }
                }
                ));
            DCResultList.Add(new DCResultViewModel(
                new DCResult() 
                {
                    Place = 15,
                    Points = 17,
                    Wins = 0,
                    Team = Enums.Team.McLaren,

                    Driver = new Driver()
                    {
                        FullName = "Фернандо Алонсо",
                        Country = Enums.Country.Spain
                    },

                    Championship = new Championship()
                    {
                        Year = 2017,
                        RacingSeries = Enums.RacingSeries.F1,
                    }
                }
                ));
            DCResultList.Add(new DCResultViewModel(
                new DCResult()
                {
                    Place = 11,
                    Points = 50,
                    Wins = 0,
                    Team = Enums.Team.Renault,

                    Driver = new Driver()
                    {
                        FullName = "Фернандо Алонсо",
                        Country = Enums.Country.Spain
                    },

                    Championship = new Championship()
                    {
                        Year = 2018,
                        RacingSeries = Enums.RacingSeries.F1,
                    }
                }
                ));
            DCResultList.Add(new DCResultViewModel(
                new DCResult()
                {
                    Place = 4,
                    Points = 212,
                    Wins = 0,
                    Team = Enums.Team.Ferrari,

                    Driver = new Driver()
                    {
                        FullName = "Себастьян Феттель",
                        Country = Enums.Country.Germany
                    },

                    Championship = new Championship()
                    {
                        Year = 2016,
                        RacingSeries = Enums.RacingSeries.F1,
                    }
                }
                ));
            DCResultList.Add(new DCResultViewModel(
                new DCResult()
                {
                    Place = 2,
                    Points = 317,
                    Wins = 5,
                    Team = Enums.Team.Ferrari,

                    Driver = new Driver()
                    {
                        FullName = "Себастьян Феттель",
                        Country = Enums.Country.Germany
                    },

                    Championship = new Championship()
                    {
                        Year = 2017,
                        RacingSeries = Enums.RacingSeries.F1,
                    }
                }
                ));
            DCResultList.Add(new DCResultViewModel(
                new DCResult()
                {
                    Place = 2,
                    Points = 317,
                    Wins = 5,
                    Team = Enums.Team.Ferrari,

                    Driver = new Driver()
                    {
                        FullName = "Себастьян Феттель",
                        Country = Enums.Country.Germany
                    },

                    Championship = new Championship()
                    {
                        Year = 2017,
                        RacingSeries = Enums.RacingSeries.F1,
                    }
                }
                ));
            DCResultList.Add(new DCResultViewModel(
                new DCResult()
                {
                    Place = 1,
                    Points = 282,
                    Wins = 10,
                    Team = Enums.Team.Prema,

                    Driver = new Driver()
                    {
                        FullName = "Шарль Леклер",
                        Country = Enums.Country.Monaco
                    },

                    Championship = new Championship()
                    {
                        Year = 2017,
                        RacingSeries = Enums.RacingSeries.F2,
                    }
                }
                ));
            DCResultList.Add(new DCResultViewModel(
                new DCResult()
                {
                    Place = 4,
                    Points = 254,
                    Wins = 2,
                    Team = Enums.Team.Ferrari,

                    Driver = new Driver()
                    {
                        FullName = "Шарль Леклер",
                        Country = Enums.Country.Monaco
                    },

                    Championship = new Championship()
                    {
                        Year = 2019,
                        RacingSeries = Enums.RacingSeries.F1,
                    }
                }
                ));
            DCResultList.Add(new DCResultViewModel(
                new DCResult()
                {
                    Place = 8,
                    Points = 98,
                    Wins = 0,
                    Team = Enums.Team.Ferrari,

                    Driver = new Driver()
                    {
                        FullName = "Шарль Леклер",
                        Country = Enums.Country.Monaco
                    },

                    Championship = new Championship()
                    {
                        Year = 2020,
                        RacingSeries = Enums.RacingSeries.F1,
                    }
                }
                ));
            DCResultList.Add(new DCResultViewModel(
                new DCResult()
                {
                    Place = 3,
                    Points = 212,
                    Wins = 4,
                    Team = Enums.Team.RedBull,

                    Driver = new Driver()
                    {
                        FullName = "Александр Албон",
                        Country = Enums.Country.Netherlands
                    },

                    Championship = new Championship()
                    {
                        Year = 2018,
                        RacingSeries = Enums.RacingSeries.F2,
                    }
                }
                ));
        }

        public void DeleteDCResult(object dcresult)
        {
            DCResultList.Remove(dcresult as DCResultViewModel);
            SelectedDCResult = DCResultList.FirstOrDefault();            
        }

        public bool CanExecuteDeleteDCResult(object dcresult)
        {
            return dcresult != null && dcresult is DCResultViewModel;
        }

        public event PropertyChangedEventHandler PropertyChanged;
        private void OnPropertyChanged(string changedProperty = "")
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(changedProperty));
        }
    }
}
