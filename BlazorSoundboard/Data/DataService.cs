using System.Collections.Generic;
using BlazorSoundboard.Data.Interfaces;
using BlazorSoundboard.Data.Models;

namespace BlazorSoundboard.Data
{
    public class DataService : IDataService
    {
        public IEnumerable<TileInfo> GetTileInfos()
        {
            return new[]
            {
                new TileInfo {Name = "Bruh", Description = "Some description here"},
                new TileInfo {Name = "DoIt", Description = "JUST DO IT!"},
                new TileInfo {Name = "Horns", Description = "BWAAAAAA"},
                new TileInfo {Name = "Leeroy", Description = "OMG did he just go in?"},
                new TileInfo {Name = "Sparta", Description = "A simple offering of dirt and water"},
                new TileInfo {Name = "Wow", Description = "Eddy Wally was a hero"},
            };
        }
    }
}