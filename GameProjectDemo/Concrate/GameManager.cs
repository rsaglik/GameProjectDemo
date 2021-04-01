using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using GameProjectDemo.Abstract;
using GameProjectDemo.Entities;

namespace GameProjectDemo.Concrate
{
    public class GameManager : IGameService
    {
        List<Game> games;
        public GameManager()
        {
            games = new List<Game>();
        }

        public void Add(Game game)
        {
            games.Add(game);
        }

        public void Delete(Game game)
        {
            games.Remove(game);
        }

        public void Update(Game game)
        {
            var updateGame = games.Where(x => x.Id == game.Id).FirstOrDefault();
            if(updateGame != null)
            {
                updateGame.Name = game.Name;
                updateGame.Price = game.Price;
            }
        }

        public List<Game> GetList()
        {
            return games;
        }
    }
}
