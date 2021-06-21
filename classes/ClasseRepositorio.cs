using System.Collections.Generic;

namespace dotflix
{
    public class SerieRepositorio : IRepositorio<Serie>
    {
        private List<Serie> listSerie = new List<Serie>();

        public void Update(int id, Serie objeto)
		{
			listSerie[id] = objeto;
		}

		public void Delete(int id)
		{
			listSerie[id].Delete();
		}

		public void Insert(Serie objeto)
		{
			listSerie.Add(objeto);
		}

		public List<Serie> Lista()
		{
			return listSerie;
		}

		public int NextId()
		{
			return listSerie.Count;
		}

		public Serie ReturnById(int id)
		{
			return listSerie[id];
		}
    }
}