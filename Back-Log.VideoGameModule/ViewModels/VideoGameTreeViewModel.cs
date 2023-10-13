using Back_Log.Business.Dto;
using Back_Log.Global.Constants;
using Back_Log.SharedModule.ViewModels;
using Prism.Commands;
using Prism.Regions;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;

namespace Back_Log.VideoGameModule.ViewModels
{
    public class VideoGameTreeViewModel : ViewModelBase
    {
        public IRegionManager _regionManager { get; }

        private ObservableCollection<VideoGameDto> _videoGames;
        
        public ObservableCollection<VideoGameDto> VideoGames
        {
            get { return _videoGames; }
            set { SetProperty(ref _videoGames, value); }
        }

        private VideoGameDto _selectedVideoGame;

        public VideoGameDto SelectedVideoGame
        {
            get { return _selectedVideoGame; }
            set
            {
                SetProperty(ref _selectedVideoGame, value);
                OnLoadDetailsForSelectedGameExecuted();
            }
        }

        public DelegateCommand LoadDetailsForSelectedGame { get; private set; }

        public VideoGameTreeViewModel(IRegionManager regionManager )
        {
            InitializeTestData();
            _regionManager = regionManager;

            LoadDetailsForSelectedGame = new DelegateCommand(OnLoadDetailsForSelectedGameExecuted);
        }

        private void OnLoadDetailsForSelectedGameExecuted()
        {
            if (_selectedVideoGame != null)
            {
                // Navigate to VideoGameDetails view passing the selected VideoGameDto as navigation parameter
                var parameters = new NavigationParameters
                {
                    { "VideoGameDto", _selectedVideoGame }
                };
                var uri = new Uri("VideoGameDetails", UriKind.Relative);
                _regionManager.RequestNavigate("MainContentRegion", uri, parameters);
            }
        }

        private void InitializeTestData()
        {
            VideoGames = new ObservableCollection<VideoGameDto>();

            var games = new List<VideoGameDto>
            {
                CreateVideoGame("Super Mario Odyssey", Enums.VideoGameGenre.Platformer, Enums.ESRBRating.E, true),
                CreateVideoGame("The Legend of Zelda: Breath of the Wild", Enums.VideoGameGenre.ActionAdventure, Enums.ESRBRating.E10Plus, true),
                CreateVideoGame("Animal Crossing: New Horizons", Enums.VideoGameGenre.Simulation, Enums.ESRBRating.E, true),
                CreateVideoGame("Mario Kart 8 Deluxe", Enums.VideoGameGenre.Racing, Enums.ESRBRating.E, true),
                CreateVideoGame("Splatoon 2", Enums.VideoGameGenre.Shooter, Enums.ESRBRating.E10Plus, true),
                CreateVideoGame("Super Smash Bros. Ultimate", Enums.VideoGameGenre.Fighting, Enums.ESRBRating.E10Plus, true),
                CreateVideoGame("Pokémon Sword and Shield", Enums.VideoGameGenre.RPG, Enums.ESRBRating.E, true),
                CreateVideoGame("Metroid Dread", Enums.VideoGameGenre.ActionAdventure, Enums.ESRBRating.T, false),
                CreateVideoGame("Fire Emblem: Three Houses", Enums.VideoGameGenre.Strategy, Enums.ESRBRating.T, true),
                CreateVideoGame("The Legend of Zelda: Link's Awakening", Enums.VideoGameGenre.ActionAdventure, Enums.ESRBRating.E10Plus, true),
                CreateVideoGame("Mario Party Superstars", Enums.VideoGameGenre.Family, Enums.ESRBRating.E, true),
                CreateVideoGame("Luigi's Mansion 3", Enums.VideoGameGenre.ActionAdventure, Enums.ESRBRating.E, true),
                CreateVideoGame("Donkey Kong Country: Tropical Freeze", Enums.VideoGameGenre.Platformer, Enums.ESRBRating.E, true),
                CreateVideoGame("Hyrule Warriors: Age of Calamity", Enums.VideoGameGenre.Action, Enums.ESRBRating.T, true),
                CreateVideoGame("Bayonetta 2", Enums.VideoGameGenre.Action, Enums.ESRBRating.M, true),
                CreateVideoGame("Pokémon Let's Go, Pikachu!/Eevee!", Enums.VideoGameGenre.RPG, Enums.ESRBRating.E, true),
                CreateVideoGame("Xenoblade Chronicles 2", Enums.VideoGameGenre.RPG, Enums.ESRBRating.T, true),
                CreateVideoGame("Octopath Traveler", Enums.VideoGameGenre.RPG, Enums.ESRBRating.T, true),
                CreateVideoGame("Animal Crossing: Happy Home Designer", Enums.VideoGameGenre.Simulation, Enums.ESRBRating.E, true),
                CreateVideoGame("Mario Tennis Aces", Enums.VideoGameGenre.Sports, Enums.ESRBRating.E, true)
            };

            VideoGames.AddRange(games);
        }

        private VideoGameDto CreateVideoGame(string title, Enums.VideoGameGenre genre, Enums.ESRBRating rating, bool isCompleted)
        {
            return new VideoGameDto
            {
                Title = title,
                GameGenre = genre,
                ESRBRating = rating,
                IsCompleted = isCompleted
            };
        }
    }
}
