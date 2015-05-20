/*
 * Creado por SharpDevelop.
 * Usuario: Martin Ayón
 * Fecha: 05/05/2015
 * Hora: 05:11 p.m.
 * 
 * Para cambiar esta plantilla use Herramientas | Opciones | Codificación | Editar Encabezados Estándar
 */
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;

namespace Libreria
{
	/// <summary>
	/// Description of MainForm.
	/// </summary>
	/// 
	public partial class MainForm : Form
	{
		MySQL conexion = new MySQL();
		Libro libroModificado;
		public MainForm()
		{
			//
			// The InitializeComponent() call is required for Windows Forms designer support.
			//
			InitializeComponent();
			
			//
			// TODO: Add constructor code after the InitializeComponent() call.
			//
		}
		void BtnAgregarADDClick(object sender, EventArgs e)
		{
			this.insertarLibro();
	
		}
		
		void BtnLimpiarADDClick(object sender, EventArgs e)
		{
			this.limpiarAgregar();
	
		}
		
		
		private void limpiarAgregar(){
			this.tbAutorADD.ResetText();
			this.tbTituloADD.ResetText();
			this.tbDescripcionADD.ResetText();
			this.dateTimeFechaADD.ResetText();
		}
		
		public int erroresAgregar(){
			int error = 0;
			if (tbAutorADD.Text.Length <= 1){
				error++;
				errores.SetError(tbAutorADD,"El Autor No Puede Ser Nulo");
			}
			if (tbTituloADD.Text.Length <= 1){
				error ++;
				errores.SetError(tbTituloADD,"El Titulo No Puede Ser Nulo");
			}
			
			if(tbDescripcionADD.Text.Length <= 1){
				error++;
				errores.SetError(tbDescripcionADD,"Debes Hacer una breve dercipcion");
			}
			return error;
		}
		
		public int erroresModificar(){
			int error=0;
			
			if (tbAutorMOD.Text.Length <=1){
				error++;
				errores.SetError(tbAutorADD,"El Autor No Puede Ser Nulo");
			}
			
			if (tbTituloMOD.Text.Length <=1){
				error++;
				errores.SetError(tbTituloMOD,"El Titulo No Puede Ser Nulo");
			}
			
			if (tbDescripcionMOD.Text.Length <=1){
				error++;
				errores.SetError(tbDescripcionMOD,"Debes Hacer una breve dercipcion");
			}
			return error;
		}
		
		public Libro crearLibro(){
			Libro lib = new Libro();
			string fecha = dateTimeFechaADD.Value.Year + "-" + dateTimeFechaADD.Value.Month + "-" + 
				dateTimeFechaADD.Value.Day;
			lib.setAutor(tbAutorADD.Text.Trim());
			lib.setTitulo(tbTituloADD.Text.Trim());
			lib.setFecha(fecha);
			lib.setDescripcion(tbDescripcionADD.Text.Trim());
			return lib;
			
		}
		
		public Libro crearLibroMod(string id){
			if (id.Length > 0){
				try{
					int ids = int.Parse(id);
					Libro librMod;
					librMod = conexion.buscarLibroPorId(id);
					return librMod;
					
				}
				catch{
					errores.SetError(tbIdLibroMOD,"Debes ingresar solo numeros");
				}
			}
			return new Libro();
		}
		
		public void insertarLibro(){
			
			if (this.erroresAgregar() == 0){
				if(conexion.insertarLibro(this.crearLibro())){
					MessageBox.Show("Se agrego con exito","LISTO",MessageBoxButtons.OK,MessageBoxIcon.Information);
					this.limpiarAgregar();
				}
				else
				MessageBox.Show("NO SE agrego","ERROR",MessageBoxButtons.OK,MessageBoxIcon.Exclamation);
			}
			
		}
		
		void ControPestañasSelected(object sender, TabControlEventArgs e)
		{
			this.dataGridLibros.DataSource = conexion.obtenerLibros();
			dataGridLibros.DataMember = "libro";
		}
		
		void BtnBuscarMODClick(object sender, EventArgs e)
		{
			libroModificado = crearLibroMod(tbIdLibroMOD.Text);
			llenarDatosLibro(libroModificado);
	
		}
		
		public void llenarDatosLibro(Libro libroMod){
			tbAutorMOD.Text = libroMod.getAutor();
			tbDescripcionMOD.Text = libroMod.getDescripcion();
			tbTituloMOD.Text= libroMod.getTitulo();
			dateTimeFechaMOD.Text = libroMod.getFecha();
		}
		
	}
}
