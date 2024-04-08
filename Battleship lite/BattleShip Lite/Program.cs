using BattleShip_Lite_Library;
using BattleShip_Lite_Library.Model;

namespace BattleShip_Lite
{
    internal class Program
    {
        static void Main(string[] args)
        {
            PlayerInfoModel activePlayer = CreatePlayer("Player 1");
            PlayerInfoModel opponent = CreatePlayer("Player 2");
            PlayerInfoModel winner = null;
            do
            {
               DisplayShotGrid(activePlayer);
               RecordPlayerShot(activePlayer, opponent);
               bool doesGameContinue = GameLogic.PlayerStillActive(opponent);
               if (doesGameContinue == true)
                {
                    (activePlayer, opponent) = (opponent, activePlayer);
                }
                else
                {
                    winner = activePlayer;
                    Console.WriteLine($"{activePlayer.UserName} won the game!");
                }
            } while (winner == null);
        }

        private static void RecordPlayerShot(PlayerInfoModel activePlayer, PlayerInfoModel opponent)
        {
            bool isValidShot = false;
            bool isRepeatedShot = true;
            string row = "";
            int column = 0;
            do
            {
                string shot = AskForShot();
                try
                {
                   (row, column) = GameLogic.SplitLocationToRowColumn(shot);
                   isValidShot = GameLogic.ValidateShipLocation(activePlayer, row, column);
                   isRepeatedShot = GameLogic.CheckIfChooseSpotBefore(activePlayer, row, column);
                }
                catch (Exception ex)
                {
                    Console.WriteLine("Error: " + ex.Message);
                    isValidShot = false;
                }
                if (isRepeatedShot == true)
                {
                    Console.WriteLine("You have already fired here. Please try again.");
                }
                if (isValidShot == false)
                {
                    Console.WriteLine("Invalid shot location. Please try again.");
                }
            } while (!isValidShot|| isRepeatedShot);
            bool isHit = GameLogic.IdentifyShotResult(opponent, row, column);
            GameLogic.MarkShotResult(activePlayer, row, column, isHit);
            DisplayShotResult( row, column, isHit);
        }

        private static void DisplayShotResult(string row, int column, bool isHit)
        {
            if (isHit)
            {
                Console.WriteLine($"You hit A Ship in {row}{column}!");
            }
            else
            {
                Console.WriteLine($"{row}{column} was a miss.");
            }

        }

        private static string AskForShot()
        {
            Console.WriteLine();
            Console.Write("Where do you want to shoot? : ");
            string shot = Console.ReadLine();
            return shot;
        }

        private static void DisplayShotGrid(PlayerInfoModel activePlayer)
        {
            Console.WriteLine($"{activePlayer.UserName}'s shot grid");
            string currentRow = activePlayer.ShotGrid[0].SpotLetter;
            foreach (var gridSpot in activePlayer.ShotGrid)
            {
                if (gridSpot.SpotLetter != currentRow)
                {
                    Console.WriteLine();
                    currentRow = gridSpot.SpotLetter;
                }
                if (gridSpot.SpotStatus == GridSpotStatus.Empty)
                {
                   Console.Write(gridSpot.SpotLetter + gridSpot.SpotNumber + " ");
                }
                else if (gridSpot.SpotStatus == GridSpotStatus.Hit)
                {
                    Console.Write(" X ");
                }
                else if (gridSpot.SpotStatus == GridSpotStatus.Miss)
                {
                    Console.Write(" O ");
                }
                else
                {
                    Console.Write(" ? ");
                }
            }
        }

        private static PlayerInfoModel CreatePlayer(string v)
        {
            Console.WriteLine($"Information for {v}");
            PlayerInfoModel player = new PlayerInfoModel();
            player.UserName = AskForName();
            GameLogic.InitalizeGrid(player);
            AskForShipLocation(player);
            Console.Clear();
            return player;
        }

        private static List<GridSpotModel> AskForShipLocation(PlayerInfoModel player)
        {
            string row = "";
            int column = 0;
            List<GridSpotModel> output = new List<GridSpotModel>();

            do
            {
              Console.Write($"Where do you want to place your ship number {player.ShipLocation.Count + 1}? : ");
              string location = Console.ReadLine();
              (row, column) = GameLogic.SplitLocationToRowColumn(location);
                bool isValidLocation = false;
                 try
                {
                    isValidLocation = GameLogic.ValidateShipLocation(player, row, column);
                }
                catch (Exception ex)
                {
                    Console.WriteLine("Error: " + ex.Message);
                }
              bool isSpotOccupied = GameLogic.CheckIfSpotIsOccupied(player, row, column);
              if (isValidLocation && !isSpotOccupied)
                {
                    output.Add(new GridSpotModel { SpotLetter = row, SpotNumber = column , SpotStatus = GridSpotStatus.PlaceShip});
                    player.ShipLocation.Add(output.Last());
                }
            } while (player.ShipLocation.Count < 5);
            return output;
        }

        private static string AskForName()
        {
            Console.Write("What is your name? : ");
            string name = Console.ReadLine();
            return name;
        }
    }
}
