using GameProjectDemo.Abstract;
using GameProjectDemo.Entities;
using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;

namespace GameProjectDemo.Concrate
{
    public class PlayerManager : IPlayerService
    {
        IPlayerValidationService _playerValidationService;

        List<Player> players;
        public PlayerManager(IPlayerValidationService playerValidationService)
        {
            players = new List<Player>();
            _playerValidationService = playerValidationService;
        }

        public void Add(Player player)
        {
            if (_playerValidationService.Validate(player))
            { 
                players.Add(player);
                Console.WriteLine("Player added...");
            }
            else
                throw new Exception("Not a valid player");
        }

        public void Delete(Player player)
        {
            players.Remove(player);
        }

        public void Update(Player player)
        {
            var updatePlayer = players.Where(x => x.Id == player.Id).FirstOrDefault();
            if(updatePlayer != null)
            {
                updatePlayer.FirstName = player.FirstName;
                updatePlayer.LastName = player.LastName;
                updatePlayer.DateOfBirth = player.DateOfBirth;
                updatePlayer.IdentityNumber = player.IdentityNumber;
            }
        }

        public List<Player> GetList()
        {
            return players;
        }
    }
}
