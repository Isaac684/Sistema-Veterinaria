using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Base___V1.Models
{
	public class Ventas
	{
		public int Id{ get; set; }
		public int IdProducto { get; set; }  
		public int Cantidad { get; set; } 
		public double Total { get; set; }

		public Ventas() { }

		public Ventas(int idProducto, int cantidad, double total)
		{
			IdProducto = idProducto;
			Cantidad = cantidad;
			Total = total;
		}
	}

}
