using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace TwoFish.WebUI.Models
{
    public class FishData : Fish
    {
        private EncloypediaEntities db = new EncloypediaEntities();

        public void MaptoFishData(Fish obj)
        {
            this.FishID = obj.FishID;
            this.Type = obj.Type;
            this.Weight = obj.Weight;
            this.History = obj.Weight;
            this.Picture = obj.Picture;

          }
    }
}