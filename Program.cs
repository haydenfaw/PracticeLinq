using System;
using System.Collections.Generic;
using System.Linq;

namespace PracticeLinq
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Video Game List
            var videoGameList = new List<string>() {"Zelda: Breath of the Wild", "Blitz 2000", "Bomberman", "Starcraft II", "AdventureQuest" };
            
            //OrberBy()
            var sortedVideoGameList = videoGameList.OrderByDescending(game => game.Length);
            foreach (var game in sortedVideoGameList)
            {
                Console.WriteLine(game);
            }
            Console.WriteLine("-----------------------");
            //Where()
            Console.WriteLine("Where() Linq Method");
            Console.WriteLine($"Where game contains a space:");
            var containsVideoGameList = videoGameList.Where(game => game.Contains(" "));
            foreach (var game in containsVideoGameList)
            {
                Console.WriteLine(game);
            }
            Console.WriteLine("-----------------------");
            //Count()
            Console.WriteLine("Count() Linq Method:");
            var countVideoGameList = videoGameList.Count();
            Console.WriteLine($"There are {countVideoGameList} video games in our list");
            Console.WriteLine("-----------------------");
            //Append()
            Console.WriteLine("Append() Linq Method:");
            var appendVideoGameList = videoGameList.Append("Maplestory");
            foreach (var game in appendVideoGameList)
            {
                Console.WriteLine(game);
            }
            Console.WriteLine("-----------------------");
            //TheBy()
            Console.WriteLine("ThenBy() Linq Method:");
            var ascendingVideoGameList = videoGameList.OrderBy(game => game.Length).ThenBy(game => game);
            foreach (var game in ascendingVideoGameList)
            {
                Console.WriteLine(game);
            }
            Console.WriteLine("-----------------------");
            //Take()
            Console.WriteLine("Take() Linq Method:");
            var takeVideoGameList = videoGameList.Take(3);
            foreach (var game in takeVideoGameList)
            {
                Console.WriteLine(game);
            }
            Console.WriteLine("-----------------------");
            //Slect()
            Console.WriteLine("Select() Linq Method:");
            var selectVideoGameList = videoGameList.Select(x => x + " - Video Game");
            foreach (var game in selectVideoGameList)
            {
                Console.WriteLine(game);
            }
            //Generate Video Game  / Scores
            var zelda = new Game();
            var blitz = new Game();
            var bomberman = new Game();
            var starcraft = new Game();
            var adventurequest = new Game();

            //Game Names
            zelda.GameName = "Zelda: Breath of the Wild";
            blitz.GameName = "Blitz 2000";
            bomberman.GameName = "Bomberman";
            starcraft.GameName = "Starcraft II";
            adventurequest.GameName = "Adventure Quest";

            //Game Scores
            zelda.Score = 97;
            blitz.Score = 88;
            bomberman.Score = 77;
            starcraft.Score = 93;
            adventurequest.Score = 75;
            var gameList = new List <Game>() { zelda, blitz, bomberman, starcraft, adventurequest };
            var gameScores = new List<int>() { zelda.Score, blitz.Score, bomberman.Score, starcraft.Score, adventurequest.Score };
            Console.WriteLine("-----------------------");
            //Display Games and Scores
            Console.WriteLine("Video Game Score List:");
            foreach (var game in gameList)
            {
                Console.WriteLine($"{game.GameName} : {game.Score}");
            }
            //Average()            
            Console.WriteLine("-----------------------");
            Console.WriteLine("Average() Linq Method:");
            Console.WriteLine($"The Average Game Score on our List: {gameScores.Average()}");
            //Min()            
            Console.WriteLine("-----------------------");
            Console.WriteLine("Min() Linq Method:");
            Console.WriteLine($"The Minimum Score on our List: {gameScores.Min()}");
            //Max()            
            Console.WriteLine("-----------------------");
            Console.WriteLine("Max() Linq Method:");
            Console.WriteLine($"The Maximum Score on our List: {gameScores.Max()}");
            //Sum()            
            Console.WriteLine("-----------------------");
            Console.WriteLine("Sum() Linq Method:");
            Console.WriteLine($"The Sum of all Scores on our List: {gameScores.Sum()}");
        }
    }
}
