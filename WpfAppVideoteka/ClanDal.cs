using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WpfAppVideoteka
{
    public class ClanDal
    {
        public List<Clan> vratiClanove()
        {
            using (VideotekaEntities db=new VideotekaEntities())
            {
                return db.Clans.ToList();
            }
        }

        public int UbaciClana(Clan clan)
        {
            using (VideotekaEntities db=new VideotekaEntities())
            {
                try
                {
                    db.Clans.Add(clan);
                    db.SaveChanges();
                    return 0;
                }
                catch (Exception)
                {
                    return -1;
                }
            }
        }

        public int PromijeniClana(Clan c)
        {
            using (VideotekaEntities db=new VideotekaEntities())
            {
                try
                {
                    Clan clan = db.Clans.Find(c.ClanID);
                    clan.Adresa = c.Adresa;
                    clan.Ime = c.Ime;
                    clan.Prezime = c.Prezime;
                    clan.JMBG = c.JMBG;
                    clan.Telefon = c.Telefon;
                    db.SaveChanges();
                    return 0;
                }
                catch (Exception)
                {
                    return -1;
                }
            }
        }

        public int ObrisiClana(Clan c)
        {
            using (VideotekaEntities db=new VideotekaEntities())
            {
                try
                {
                    Clan clan = db.Clans.Find(c.ClanID);
                    db.Clans.Remove(clan);
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
