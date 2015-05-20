using EjemploASP.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EjemploASP
{
    public class BDService
    {
         MusicStoreEntities db;

         public BDService()
         {
             db = new MusicStoreEntities();
         }

        public  List<Album> GetAlbums()
        {
            return db.Albums.ToList();
        }

        public List<Artist> GetArtist()
        {
            return db.Artists.ToList();
        }

        public List<Genre> GetGenres()
        {
            return db.Genres.ToList();
        }

        public List<Album> GetAlbumsFromGenre(Genre genre)
        {
            return db.Albums.Where(a=>a.GenreId == genre.GenreId).ToList();
        }

        public List<Album> GetAlbumsFromIdGenre(int idGenre)
        {
            return db.Albums.Where(a => a.GenreId == idGenre).ToList();
        }
    }
}
