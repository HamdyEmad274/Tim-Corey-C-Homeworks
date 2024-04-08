using BattleShip_Lite_Library.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BattleShip_Lite_Library
{
    public static class GameLogic
    {
        public static bool CheckIfChooseSpotBefore(PlayerInfoModel activePlayer, string row, int column)
        {
            bool isReapeat = false;
            foreach (var spot in activePlayer.ShotGrid)
            {
                if (spot.SpotLetter == row.ToUpper() && spot.SpotNumber == column)
                {
                    if (spot.SpotStatus == GridSpotStatus.Hit || spot.SpotStatus == GridSpotStatus.Miss)
                    {
                        isReapeat = true;
                    }
                }
            }
            return isReapeat;
        }

        public static bool CheckIfSpotIsOccupied(PlayerInfoModel player, string row, int column)
        {
            bool spotIsOccupied = false;
            foreach (var spot in player.ShipLocation)
            {
                if (spot.SpotLetter == row && spot.SpotNumber == column)
                {
                    if (spot.SpotStatus != GridSpotStatus.Empty)
                    {
                        spotIsOccupied = true;
                        Console.WriteLine("The location is occupied");
                    }
                }
            }
            return spotIsOccupied;
        }

        public static bool IdentifyShotResult(PlayerInfoModel opponent, string row, int column)
        {
             bool isHit = false;
            foreach (var ship in opponent.ShipLocation)
            {
                if (ship.SpotLetter == row.ToUpper() && ship.SpotNumber == column)
                {
                    isHit = true;
                    ship.SpotStatus = GridSpotStatus.Sink;
                }
            }
            return isHit;
        }

        public static void InitalizeGrid(PlayerInfoModel player)
        {
            List<string> letters = ["A", "B", "C", "D", "E"];
            List<int> numbers = [1, 2, 3, 4, 5];
            foreach (var letter in letters)
            {
                foreach (var number in numbers)
                {
                    AddSpotToGrid(player, letter, number);
                    Console.Write(letter + number + " ");
                }
                Console.WriteLine();
            }
        }

        public static void MarkShotResult(PlayerInfoModel Player, string row, int column, bool isHit)
        {
            foreach (var gridSpot in Player.ShotGrid)
            {
                if (gridSpot.SpotLetter == row.ToUpper() && gridSpot.SpotNumber == column)
                {
                    if (isHit)
                    {
                        gridSpot.SpotStatus = GridSpotStatus.Hit;
                    }
                    else
                    {
                        gridSpot.SpotStatus = GridSpotStatus.Miss;
                    }
                }
            }
        }

        public static bool PlayerStillActive(PlayerInfoModel opponent)
        {
             bool isActive = false;
            foreach (var ship in opponent.ShipLocation)
            {
                if (ship.SpotStatus != GridSpotStatus.Sink)
                {
                    isActive = true;
                }
            }
            return isActive;
        }

        public static (string row, int column) SplitLocationToRowColumn(string location)
        {
            string row = "";
            int column = 0;
            if (location.Length == 2)
            {
                location = location.ToUpper();
                 row = location.Substring(0, 1);
                string columnText = int.TryParse(location.Substring(1) , out column) ? location.Substring(1) : "Not Valid Column";
            }
            
            return (row, column);
        }

        public static bool ValidateShipLocation(PlayerInfoModel player, string row, int column)
        {
           bool isValid = false;
           foreach (var spot in player.ShotGrid)
            {
                if (spot.SpotLetter == row && spot.SpotNumber == column)
                {
                    isValid = true;

                }
            }
            if (isValid == false)
            {
                Console.WriteLine("The location is not valid");
            }
            return isValid;
        }

        private static void AddSpotToGrid(PlayerInfoModel player, string letter, int number)
        {
            GridSpotModel newSpot = new GridSpotModel() { 
            SpotLetter = letter,
            SpotNumber = number,
            SpotStatus = GridSpotStatus.Empty
            };
            player.ShotGrid.Add(newSpot);

        }
    }
}