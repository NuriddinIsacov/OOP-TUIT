using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleDarslari.Classes
{
    public class DokonPoyabzal
    {
        public List<Poyabzal> Poyabzallar { get; set; }
        public string CharmMarket { get; set; }

        public DokonPoyabzal()
        {
            Poyabzallar = new List<Poyabzal>();

        }

        public void SetObject(List<Poyabzal> listPoyabzal)
        {
            foreach (Poyabzal item in listPoyabzal)
                Poyabzallar.Add(item);
        }

        public Poyabzal SearchByName (string name)
        {
            Poyabzal nameObject = null;

            foreach (var item in Poyabzallar)
            {
                if (item.Name == name)
                    nameObject = item;
            }

            return nameObject;
        }

        public Poyabzal SearchById(int id)
        {
            return Poyabzallar.Find(x => x.Id == id);
        }

        public List<Poyabzal> SearchInterval(int first, int latest)
        {
            List<Poyabzal> result = new List<Poyabzal>();
            foreach (var item in Poyabzallar)
            {
                if(item.Id >= first && item.Id <= latest)
                    result.Add(item);
            }

            return result;
        }

        public  Poyabzal Update(Poyabzal poyabzal, int id)
        {
            var entity = SearchById(id);
            entity.MatoTuri = poyabzal.MatoTuri;
            entity.Name = poyabzal.Name;

            return entity;
        }

        public void SortById()
        {
            Poyabzallar = Poyabzallar.OrderBy(p => p.Id).ToList();
        }
    }
}
