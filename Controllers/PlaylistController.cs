using System.Collections.Generic;
using Microsoft.AspNetCore.Mvc;
using System.Linq;
using Models;

namespace Controllers
{
    [Produces("application/json")]
    [Route("playlists")]
    public class PlaylistController
    {
        Playlist[] playlists = new Playlist[]
        {
            new Playlist {artist = "The Frights", default_size = 20, pid = "1"},
            new Playlist {artist = "The Killers", default_size = 20, pid = "2"},
            new Playlist {artist = "Josiah and the Bonnevilles", default_size = 20, pid = "3"}
        };

        [HttpGet]
        public IEnumerable<Playlist> getAllPlaylists()
        {   
            return playlists;
        }

        [HttpGet("pid/{pid}")]
        public IEnumerable<Playlist> getPlaylistByPid(string pid)
        {
             IEnumerable<Playlist> retVal =
                from g in playlists 
                where g.pid.Equals(pid) 
                select g;

            return retVal;

        }
    }
}