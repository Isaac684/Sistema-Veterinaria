using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Base___V1.Models
{
	public class Cita
	{
		public int Id { get; set; }
		public int IdMascota { get; set; }
		public string Fecha { get; set; }
		public string Descripcion { get; set; }
		public Dueño Dueño { get; set; }
	 
		public Cita() { }

		public Cita(int idMascota, string fecha, string descripcion)
		{
			IdMascota = idMascota;
			Fecha = fecha;
			Descripcion = descripcion;
		}
	}
}
