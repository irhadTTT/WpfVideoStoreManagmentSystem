using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WpfAppVideoteka
{
    public class IznajmljivanjeDal
    {
        public List<Iznajmljivanje> vratiIzn()
        {
            using (VideotekaEntities db = new VideotekaEntities())
            {
                return db.Iznajmljivanjes.ToList();
            }
        }

        public List<PrikaziIznajmljivanja_Result> prikazIz()
        {
            using (VideotekaEntities db = new VideotekaEntities())
            {
                return db.PrikaziIznajmljivanja().ToList();
            }
        }

        public Iznajmljivanje vratiIz(int id)
        {
            using (VideotekaEntities db = new VideotekaEntities())
            {

                return db.Iznajmljivanjes.Find(id);
            }
        }

        public int ubaciIz(Iznajmljivanje iz)
        {
            using (VideotekaEntities db = new VideotekaEntities())
            {
                try
                {
                    db.Iznajmljivanjes.Add(iz);
                    db.SaveChanges();
                    return 0;
                }
                catch (Exception)
                {
                    return -1;
                }
            }
        }

        public int promijenIz(Iznajmljivanje iz)
        {
            using (VideotekaEntities db=new VideotekaEntities())
            {
                try
                {
                    Iznajmljivanje izn = db.Iznajmljivanjes.Find(iz.IznajmljivanjeID);
                    izn.Cijena = iz.Cijena;
                    izn.ClanID = iz.ClanID;
                    izn.DatumIznajmljivanja = iz.DatumIznajmljivanja;
                    izn.DatumVracanja = iz.DatumVracanja;
                    izn.FilmId = iz.FilmId;
                    db.SaveChanges();
                    return 0;
                }
                catch (Exception)
                {
                    return -1;
                }
            }
        }

        public int obrisiIz(Iznajmljivanje iz)
        {
            using (VideotekaEntities db=new VideotekaEntities())
            {
                try
                {
                    Iznajmljivanje izn = db.Iznajmljivanjes.Find(iz.IznajmljivanjeID);
                    db.Iznajmljivanjes.Remove(izn);
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
