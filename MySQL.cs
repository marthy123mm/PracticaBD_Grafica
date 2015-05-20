using System;
using MySql.Data.MySqlClient;
using System.Data;
using System.Windows.Forms;


namespace Libreria
{
	public class MySQL
	{
		protected MySqlConnection myConnection;
		
        public MySQL ()
		{
		}
		
		protected void abrirConexion(){
			string connectionString =
          		"Server = localhost;" + 
	          	"Database = libreria;" + 
	          	"User ID = root;" + 
	          	"Password = marthy123mm;" +
	          	"Pooling = false;"; 
	       this.myConnection = new MySqlConnection(connectionString);
	       this.myConnection.Open();
		}
		
		protected void cerrarConexion(){
			this.myConnection.Close(); 
			this.myConnection = null;
		}
        
        
        public bool insertarLibro(Libro libro){
        	this.abrirConexion();
        	string sql = "insert into libro values ( " + libro.stringInsert() + ")";
        	if ( ejecutarComando(sql)>0){
        		this.cerrarConexion();
        		return true;
        	}
        	
        	else {
        		this.cerrarConexion();
        		return false;
        	}
        	
        
        }
        
        private int ejecutarComando(string sql){
			MySqlCommand myCommand = new MySqlCommand(sql,this.myConnection);
			int afectadas = myCommand.ExecuteNonQuery();
			myCommand.Dispose();
			myCommand = null;
			return afectadas;
		}
        
        public Libro buscarLibroPorId(String id){
        	this.abrirConexion();
        	string sql = "select * from libro where id_libro = " + "'" + id + "'";
        	
        	MySqlCommand myCommand = new MySqlCommand(sql, myConnection);
                    MySqlDataReader myReader = myCommand.ExecuteReader();
                    while (myReader.Read())
                    {
                    	//this.cerrarConexion();
                    	return new Libro (int.Parse(myReader["id_libro"].ToString()),
                    	                  myReader["titulo"].ToString(),
                    	                  myReader["autor"].ToString(),
                    	                  myReader["fecha"].ToString(),
                    	                  myReader["descripcion"].ToString());
                    	              
                    }
                    
        	this.cerrarConexion();
        	return new Libro();
        }
        
        public DataSet obtenerLibros(){
        	this.abrirConexion();
        	string sql= "select * from libro";
        	MySqlDataAdapter datosLibros = new MySqlDataAdapter(sql, this.myConnection);
            DataSet dsLibro = new DataSet();
            datosLibros.Fill(dsLibro, "libro");
            this.cerrarConexion();
            return dsLibro;
        	
        }

	}
}