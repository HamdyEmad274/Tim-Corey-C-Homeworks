using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BattleShip_Lite_Library.Model
{
    public class PlayerInfoModel
    {
        public string UserName { get; set; }
        public List<GridSpotModel> ShipLocation { get; set; } = new List<GridSpotModel>();

        public List<GridSpotModel> ShotGrid { get; set; } = new List<GridSpotModel>();

    }
}
