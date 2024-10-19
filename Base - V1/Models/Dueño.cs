using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Base___V1.Models
{
    public class Dueño
    {
        public int idDueno {get;set;}
        public string nombre {get;set;}
        public string direccion {get;set;}
        public string correo {get;set;}
        public string telefono { get; set; }

        public Dueño(int idDueno, string nombre, string direccion, string correo, string telefono)
        {
            this.idDueno = idDueno;
            this.nombre = nombre;
            this.direccion = direccion;
            this.correo = correo;
            this.telefono = telefono;
        }
        public Dueño() { }
        public int getIdDueno() { return this.idDueno; } 
        public string getNombre() { return this.nombre; }
        public string getDireccion() { return this.direccion; }
        public string getCorreo() { return this.correo; }
        public string getTelefono() { return this.telefono; }
        
        public void setIdDueno(int id)
        {
            this.idDueno = id;
        }
        public void setNombre(string nombre)
        {
            this.nombre = nombre;
        }
        public void setDireccion(string direccion) { this.direccion = direccion;}
        public void setCorreo(string correo) {  this.correo = correo; }
        public void setTelefono(string telefono) { this.telefono= telefono;}
    }
}
