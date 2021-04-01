using GameProjectDemo.Abstract;
using GameProjectDemo.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace GameProjectDemo.Concrate
{
    public class PlayserCheckService : IPlayerValidationService
    {
        public bool Validate(Player player)
        {
            return true;
        }
    }
}
