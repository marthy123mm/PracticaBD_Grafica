
using System;
namespace Libreria
{
	public class Libro{
		int id;
		String titulo;
		String autor;
		String fecha;
		String descripcion;

		public Libro(){
		}
	
		public Libro(int id, String titulo, String autor,String fecha,String descripcion){
			this.titulo=titulo;
			this.autor=autor;
			this.fecha=fecha;
			this.descripcion=descripcion;
		}
		
		public void setId(int id){
			this.id = id;
		}
		
		public void setTitulo(String titulo){
			this.titulo = titulo;
		}
		
		public void setAutor (String autor){
			this.autor = autor;
		}
			
		public void setFecha (String fecha){
			this.fecha = fecha;
		}
		
		public void setDescripcion(String descripcion){
			this.descripcion = descripcion;
		}
		
		public int getId(){
			return id;
		}
			
		public String getTitulo(){
			return titulo;
		}
			
		public String getAutor (){
			return autor;
		}
			
		public String getFecha (){
			return fecha;
		}
			
		public String getDescripcion(){
			return descripcion;
		}
		
		public String stringInsert(){
			return 	"default"+ "," +
					"'" + titulo + "'" + "," +
					"'" + autor + "'" + "," +
					"'" + descripcion + "'" + "," +
					"'" + fecha + "'";
		}
		
		public String stringUpdate(){
			return 	"id libro = " + "'" + id + "'" + "," +
					"titlo = " + "'" + titulo + "'" + "," +
					"autor = " + "'" + autor + "'" + "," +
					"fecha = " + "'" + fecha + "'" + "," +
					"descripcion = " + "'" + descripcion + "'" ;
		}




}
}
