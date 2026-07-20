using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WpfAppVideoteka
{
    public class FilmDal
    {
        public List<Film> vratiFilmove()
        {
            using (VideotekaEntities db=new VideotekaEntities())
            {
                return db.Films.ToList();
            }
        }

        public int ubaciFilm(Film film)
        {
            using (VideotekaEntities db=new VideotekaEntities())
            {
                try
                {
                    db.Films.Add(film);
                    db.SaveChanges();
                    return 0;
                }
                catch (Exception)
                {
                    return -1;
                }
            }
        }

        public int promijeniFilm(Film f)
        {
            using (VideotekaEntities db=new VideotekaEntities())
            {
                try
                {
                    Film film = db.Films.Find(f.FilmId);
                    film.NazivFilma = f.NazivFilma;
                    film.Trajanje = f.Trajanje;
                    film.Zanr = f.Zanr;
                    db.SaveChanges();
                    return 0;
                }
                catch (Exception)
                {
                    return -1;
                }
            }
        }

        public int obrisiFilm(Film f)
        {
            using (VideotekaEntities db=new VideotekaEntities())
            {
                try
                {
                    Film film = db.Films.Find(f.FilmId);
                    db.Films.Remove(film);
                    db.SaveChanges();
                    return 0;
                }
                catch (Exception)
                {
                    return -1;
                }
            }
        }
    }
}
