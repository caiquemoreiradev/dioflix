using System;

namespace dotflix {
    public class Serie : EntidadeBase {
        
        // Atributos
        private Genre genre { get; set; }
        private string title { get; set; }
        private string description { get; set; }
        private int year { get; set; }
         private bool Deleted {get; set;}

        public Serie(int id, Genre genre, string title, string description, int year) {
            this.id = id;
            this.genre = genre;
            this.title = title;
            this.description = description;
            this.year = year;
            this.Deleted = false;
        }

          public override string ToString()
		{
            string retorno = "";
            retorno += "Gênero: " + this.genre + Environment.NewLine;
            retorno += "Titulo: " + this.title + Environment.NewLine;
            retorno += "Descrição: " + this.description + Environment.NewLine;
            retorno += "Ano de Início: " + this.year + Environment.NewLine;
            retorno += "Excluido: " + this.Deleted;
			return retorno;
		}

        public string returnTitle() {
            return this.title;
        }

        public int returnId() {
            return this.id;
        }

           public bool returnDeleted()
		{
			return this.Deleted;
		}
        public void Delete() {
            this.Deleted = true;
        }
    }
}