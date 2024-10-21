using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Base___V1.Models
{
	public class Inventario
	{
		public int Id { get; set; }
		public string Codigo { get; set; }
		public string Nombre { get; set; }  
		public string Descripcion { get; set; } 
		public int Stock { get; set; }
		public double PrecioCompra { get; set; } 
		public double PrecioVenta { get; set; } 
		public int AvisoMin { get; set; }

		public Inventario(string codigo, string nombre, string descripcion, int stock, double precioCompra, int precioVenta, int avisoMin)
		{
			Codigo = codigo;
			Nombre = nombre;
			Descripcion = descripcion;
			Stock = stock;
			PrecioCompra = precioCompra;
			PrecioVenta = precioVenta;
			AvisoMin = avisoMin;
		}
		public Inventario() { }
	}

}
