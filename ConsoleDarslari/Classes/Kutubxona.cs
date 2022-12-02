using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleDarslari.Classes
{
    public class Kutubxona
    {
        public List<Kitob> Kitoblar { get; set; }

        public Kutubxona()
        {
            Kitoblar = new List<Kitob>();
        }
        public void SetKitob(Kitob kitob)
        {
            Kitoblar.Add(kitob);
        }

        public int GetCountKitob()
        {
            return Kitoblar.Count;
        }


        public void SetObjects(List<Kitob> kitoblar)
        {
            Kitoblar = kitoblar;
        }
        public Kitob SearchById(int id)
        {
            return Kitoblar.FirstOrDefault(x => x.Id == id);
        }

        public Kitob SearchByName(string name)
        {
            return Kitoblar.FirstOrDefault(x => x.Name == name);
        }

        public List<Kitob> SearchInterval(int first, int lates)
        {
            List<Kitob> list = new List<Kitob>();
            foreach (var item in Kitoblar)
            {
                if(item.Id <= first && item.Id <= lates)
                    list.Add(item);
            }

            return list;
        }

        public void SortById()
        {
            Kitoblar = Kitoblar.OrderBy(x => x.Id).ToList();
        }

        public Kitob Update(Kitob kitob, int id)
        {
            var entity = SearchById(id);
            Kitoblar.Remove(entity);

            entity.Name = kitob.Name;
            entity.Autor = kitob.Autor;

            Kitoblar.Add(entity);

            return entity;
        }
    }
}
