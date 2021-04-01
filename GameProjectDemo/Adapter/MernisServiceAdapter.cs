using System;
using System.Collections.Generic;
using System.Text;
using GameProjectDemo.Abstract;
using GameProjectDemo.Entities;
using MernisServiceReference;

namespace GameProjectDemo.Adapter
{
    public class MernisServiceAdapter : IPlayerValidationService
    {
        public bool Validate(Player player)
        {
            KPSPublicSoapClient client = new KPSPublicSoapClient(KPSPublicSoapClient.EndpointConfiguration.KPSPublicSoap);
            return client.TCKimlikNoDogrulaAsync(Convert.ToInt64(player.IdentityNumber), player.FirstName.ToUpper(), player.LastName.ToUpper(), player.DateOfBirth.Year).Result.Body.TCKimlikNoDogrulaResult;
        }
    }
}
