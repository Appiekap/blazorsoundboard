using System.Collections.Generic;
using BlazorSoundboard.Data.Models;

namespace BlazorSoundboard.Data.Interfaces
{
    public interface IDataService
    {
        IEnumerable<TileInfo> GetTileInfos();
    }
}