using System;
using System.Collections.Generic;
using System.Text;

namespace Template.Domain.Entities
{
    public class Anuncio
    {
		public int ID { get; set; }
		public string marca { get; set; }
		public string modelo { get; set; }
		public string versao { get; set; }
		public int ano { get; set; }
		public int quilometragem { get; set; }
		public string observacao { get; set; }
	}
}
