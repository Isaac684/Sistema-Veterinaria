﻿using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Base___V1.Models
{
    public class Mascota
    {
        public int idMascota { get; set; }
		public string nombre {  get; set; }
        public string especie { get; set; }
		public string raza { get; set; }
		public int edad { get; set; }
		public string sexo { get; set; }
		public string color { get; set; }
		public string senias { get; set; }
		public int idDuenio { get; set; }
        public string fechaIngreso { get; set; }
		public string imagen { get; set; }

		public Mascota(int idMascota, string nombre, string especie, string raza, int edad, string sexo, string color, string senias, int idDueño, string fechaIngreso, string imagen)
		{
			this.idMascota = idMascota;
            this.nombre = nombre;
            this.especie = especie;
            this.raza = raza;
            this.edad = edad;
            this.sexo = sexo;
            this.color = color;
            this.senias = senias;
            this.idDuenio = idDueño;
            this.fechaIngreso = fechaIngreso; 
            this.imagen = imagen;
		}
		public Mascota() { }
        public int getIdMascota() {return this.idMascota;}
        public string getNombre() {return this.nombre;}
        public string getEspecie() {return this.especie;}
        public string getRaza() { return this.raza;}
        public string getSenias() {return this.senias;}
        public int getEdad() { return this.edad; }
        public string getSexo() { return this.sexo;}
        public string getColor() {return this.color;}
        public int getIdDuenio() { return this.idDuenio; }
        public string getFechaIngreso() {return this.fechaIngreso; }
		public Image getImagen()
		{
			byte[] imageBytes = Convert.FromBase64String(this.imagen);
			using (MemoryStream memoryStream = new MemoryStream(imageBytes)) { return Image.FromStream(memoryStream); }
		}
		public string getStringImagen() { return this.imagen; }
		public void setIdMascota(int id) { this.idMascota = id;}
        public void setNombre(string nombre) { this.nombre = nombre;}
        public void setEspecie(string especie) { this.especie = especie;}
        public void setRaza(string raza) { this.raza = raza;}
        public void setSenias(string senias) { this.senias = senias;}
        public void setEdad(int edad) {  this.edad = edad;}
        public void setSexo(string sexo) { this.sexo = sexo;}
        public void setColor(string color) { this.color = color;}
        public void setIdDuenio(int id) {this.idDuenio = id;}
        public void setFechaIngreso(string fecha) { this.fechaIngreso = fecha;}
		public void setImagen(Image imagen)
		{
			using (MemoryStream memoryStream = new MemoryStream())
			{
                if(imagen != null)
                {
				    imagen.Save(memoryStream, System.Drawing.Imaging.ImageFormat.Png);
				    byte[] imageBytes = memoryStream.ToArray();
				    this.imagen = Convert.ToBase64String(imageBytes);
                }
			}
		}
		public void setStringImage(String imagen) { this.imagen = imagen; }


	}
}
