/*
 * Creado por SharpDevelop.
 * Usuario: Martin Ayón
 * Fecha: 05/05/2015
 * Hora: 05:11 p.m.
 * 
 * Para cambiar esta plantilla use Herramientas | Opciones | Codificación | Editar Encabezados Estándar
 */
namespace Libreria
{
	partial class MainForm
	{
		/// <summary>
		/// Designer variable used to keep track of non-visual components.
		/// </summary>
		private System.ComponentModel.IContainer components = null;
		private System.Windows.Forms.Label lbDatosADD;
		private System.Windows.Forms.Label lbTitulo;
		private System.Windows.Forms.DateTimePicker dateTimeFechaADD;
		private System.Windows.Forms.TextBox tbTituloADD;
		private System.Windows.Forms.TextBox tbAutorADD;
		private System.Windows.Forms.TextBox tbDescripcionADD;
		private System.Windows.Forms.Button btnAgregarADD;
		private System.Windows.Forms.Button btnLimpiarADD;
		private System.Windows.Forms.TabControl ControPestañas;
		private System.Windows.Forms.TabPage Agregar;
		private System.Windows.Forms.TabPage Modificar;
		private System.Windows.Forms.TabPage Eliminar;
		private System.Windows.Forms.TabPage Ver_Libros;
		private System.Windows.Forms.TextBox tbIdLibroMOD;
		private System.Windows.Forms.Button btnCancelarMOD;
		private System.Windows.Forms.Button btnBuscarMOD;
		private System.Windows.Forms.Button btnAceptarMOD;
		private System.Windows.Forms.TextBox tbDescripcionMOD;
		private System.Windows.Forms.TextBox tbAutorMOD;
		private System.Windows.Forms.TextBox tbTituloMOD;
		private System.Windows.Forms.DateTimePicker dateTimeFechaMOD;
		private System.Windows.Forms.Label lbDatosMOD;
		private System.Windows.Forms.Button btnEliminarELI;
		private System.Windows.Forms.TextBox tbIdLibroELI;
		private System.Windows.Forms.Label lbIdLibroELI;
		private System.Windows.Forms.DataGridView dataGridLibros;
		private System.Windows.Forms.ErrorProvider errores;
		
		/// <summary>
		/// Disposes resources used by the form.
		/// </summary>
		/// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
		protected override void Dispose(bool disposing)
		{
			if (disposing) {
				if (components != null) {
					components.Dispose();
				}
			}
			base.Dispose(disposing);
		}
		
		/// <summary>
		/// This method is required for Windows Forms designer support.
		/// Do not change the method contents inside the source code editor. The Forms designer might
		/// not be able to load this method if it was changed manually.
		/// </summary>
		private void InitializeComponent()
		{
			this.components = new System.ComponentModel.Container();
			this.ControPestañas = new System.Windows.Forms.TabControl();
			this.Agregar = new System.Windows.Forms.TabPage();
			this.btnLimpiarADD = new System.Windows.Forms.Button();
			this.btnAgregarADD = new System.Windows.Forms.Button();
			this.tbDescripcionADD = new System.Windows.Forms.TextBox();
			this.tbAutorADD = new System.Windows.Forms.TextBox();
			this.tbTituloADD = new System.Windows.Forms.TextBox();
			this.dateTimeFechaADD = new System.Windows.Forms.DateTimePicker();
			this.lbDatosADD = new System.Windows.Forms.Label();
			this.Modificar = new System.Windows.Forms.TabPage();
			this.tbIdLibroMOD = new System.Windows.Forms.TextBox();
			this.btnCancelarMOD = new System.Windows.Forms.Button();
			this.btnBuscarMOD = new System.Windows.Forms.Button();
			this.btnAceptarMOD = new System.Windows.Forms.Button();
			this.tbDescripcionMOD = new System.Windows.Forms.TextBox();
			this.tbAutorMOD = new System.Windows.Forms.TextBox();
			this.tbTituloMOD = new System.Windows.Forms.TextBox();
			this.dateTimeFechaMOD = new System.Windows.Forms.DateTimePicker();
			this.lbDatosMOD = new System.Windows.Forms.Label();
			this.Eliminar = new System.Windows.Forms.TabPage();
			this.btnEliminarELI = new System.Windows.Forms.Button();
			this.tbIdLibroELI = new System.Windows.Forms.TextBox();
			this.lbIdLibroELI = new System.Windows.Forms.Label();
			this.Ver_Libros = new System.Windows.Forms.TabPage();
			this.dataGridLibros = new System.Windows.Forms.DataGridView();
			this.lbTitulo = new System.Windows.Forms.Label();
			this.errores = new System.Windows.Forms.ErrorProvider(this.components);
			this.ControPestañas.SuspendLayout();
			this.Agregar.SuspendLayout();
			this.Modificar.SuspendLayout();
			this.Eliminar.SuspendLayout();
			this.Ver_Libros.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.dataGridLibros)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.errores)).BeginInit();
			this.SuspendLayout();
			// 
			// ControPestañas
			// 
			this.ControPestañas.Controls.Add(this.Agregar);
			this.ControPestañas.Controls.Add(this.Modificar);
			this.ControPestañas.Controls.Add(this.Eliminar);
			this.ControPestañas.Controls.Add(this.Ver_Libros);
			this.ControPestañas.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.ControPestañas.Location = new System.Drawing.Point(47, 50);
			this.ControPestañas.Name = "ControPestañas";
			this.ControPestañas.SelectedIndex = 0;
			this.ControPestañas.Size = new System.Drawing.Size(432, 410);
			this.ControPestañas.TabIndex = 0;
			this.ControPestañas.Selected += new System.Windows.Forms.TabControlEventHandler(this.ControPestañasSelected);
			// 
			// Agregar
			// 
			this.Agregar.Controls.Add(this.btnLimpiarADD);
			this.Agregar.Controls.Add(this.btnAgregarADD);
			this.Agregar.Controls.Add(this.tbDescripcionADD);
			this.Agregar.Controls.Add(this.tbAutorADD);
			this.Agregar.Controls.Add(this.tbTituloADD);
			this.Agregar.Controls.Add(this.dateTimeFechaADD);
			this.Agregar.Controls.Add(this.lbDatosADD);
			this.Agregar.Location = new System.Drawing.Point(4, 27);
			this.Agregar.Name = "Agregar";
			this.Agregar.Padding = new System.Windows.Forms.Padding(3);
			this.Agregar.Size = new System.Drawing.Size(424, 379);
			this.Agregar.TabIndex = 0;
			this.Agregar.Text = "Agregar";
			this.Agregar.UseVisualStyleBackColor = true;
			// 
			// btnLimpiarADD
			// 
			this.btnLimpiarADD.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btnLimpiarADD.Location = new System.Drawing.Point(266, 340);
			this.btnLimpiarADD.Name = "btnLimpiarADD";
			this.btnLimpiarADD.Size = new System.Drawing.Size(96, 26);
			this.btnLimpiarADD.TabIndex = 14;
			this.btnLimpiarADD.Text = "Limpiar";
			this.btnLimpiarADD.UseVisualStyleBackColor = true;
			this.btnLimpiarADD.Click += new System.EventHandler(this.BtnLimpiarADDClick);
			// 
			// btnAgregarADD
			// 
			this.btnAgregarADD.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btnAgregarADD.Location = new System.Drawing.Point(141, 340);
			this.btnAgregarADD.Name = "btnAgregarADD";
			this.btnAgregarADD.Size = new System.Drawing.Size(101, 26);
			this.btnAgregarADD.TabIndex = 13;
			this.btnAgregarADD.Text = "Agregar";
			this.btnAgregarADD.UseVisualStyleBackColor = true;
			this.btnAgregarADD.Click += new System.EventHandler(this.BtnAgregarADDClick);
			// 
			// tbDescripcionADD
			// 
			this.tbDescripcionADD.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.tbDescripcionADD.Location = new System.Drawing.Point(141, 148);
			this.tbDescripcionADD.Multiline = true;
			this.tbDescripcionADD.Name = "tbDescripcionADD";
			this.tbDescripcionADD.Size = new System.Drawing.Size(221, 166);
			this.tbDescripcionADD.TabIndex = 12;
			// 
			// tbAutorADD
			// 
			this.tbAutorADD.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.tbAutorADD.Location = new System.Drawing.Point(141, 75);
			this.tbAutorADD.Name = "tbAutorADD";
			this.tbAutorADD.Size = new System.Drawing.Size(221, 24);
			this.tbAutorADD.TabIndex = 10;
			// 
			// tbTituloADD
			// 
			this.tbTituloADD.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.tbTituloADD.Location = new System.Drawing.Point(141, 41);
			this.tbTituloADD.Name = "tbTituloADD";
			this.tbTituloADD.Size = new System.Drawing.Size(221, 24);
			this.tbTituloADD.TabIndex = 8;
			// 
			// dateTimeFechaADD
			// 
			this.dateTimeFechaADD.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.dateTimeFechaADD.Location = new System.Drawing.Point(141, 113);
			this.dateTimeFechaADD.Name = "dateTimeFechaADD";
			this.dateTimeFechaADD.Size = new System.Drawing.Size(221, 24);
			this.dateTimeFechaADD.TabIndex = 11;
			// 
			// lbDatosADD
			// 
			this.lbDatosADD.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lbDatosADD.Location = new System.Drawing.Point(44, 44);
			this.lbDatosADD.Name = "lbDatosADD";
			this.lbDatosADD.Size = new System.Drawing.Size(91, 130);
			this.lbDatosADD.TabIndex = 7;
			this.lbDatosADD.Text = "Titulo\r\n\r\nAutor\r\n\r\nFecha\r\n\r\nDescripción\r\n";
			// 
			// Modificar
			// 
			this.Modificar.Controls.Add(this.tbIdLibroMOD);
			this.Modificar.Controls.Add(this.btnCancelarMOD);
			this.Modificar.Controls.Add(this.btnBuscarMOD);
			this.Modificar.Controls.Add(this.btnAceptarMOD);
			this.Modificar.Controls.Add(this.tbDescripcionMOD);
			this.Modificar.Controls.Add(this.tbAutorMOD);
			this.Modificar.Controls.Add(this.tbTituloMOD);
			this.Modificar.Controls.Add(this.dateTimeFechaMOD);
			this.Modificar.Controls.Add(this.lbDatosMOD);
			this.Modificar.Location = new System.Drawing.Point(4, 27);
			this.Modificar.Name = "Modificar";
			this.Modificar.Padding = new System.Windows.Forms.Padding(3);
			this.Modificar.Size = new System.Drawing.Size(424, 379);
			this.Modificar.TabIndex = 1;
			this.Modificar.Text = "Modificar";
			this.Modificar.UseVisualStyleBackColor = true;
			// 
			// tbIdLibroMOD
			// 
			this.tbIdLibroMOD.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.tbIdLibroMOD.Location = new System.Drawing.Point(142, 29);
			this.tbIdLibroMOD.Name = "tbIdLibroMOD";
			this.tbIdLibroMOD.Size = new System.Drawing.Size(132, 24);
			this.tbIdLibroMOD.TabIndex = 23;
			// 
			// btnCancelarMOD
			// 
			this.btnCancelarMOD.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btnCancelarMOD.Location = new System.Drawing.Point(262, 348);
			this.btnCancelarMOD.Name = "btnCancelarMOD";
			this.btnCancelarMOD.Size = new System.Drawing.Size(101, 26);
			this.btnCancelarMOD.TabIndex = 22;
			this.btnCancelarMOD.Text = "Cancelar";
			this.btnCancelarMOD.UseVisualStyleBackColor = true;
			// 
			// btnBuscarMOD
			// 
			this.btnBuscarMOD.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btnBuscarMOD.Location = new System.Drawing.Point(289, 27);
			this.btnBuscarMOD.Name = "btnBuscarMOD";
			this.btnBuscarMOD.Size = new System.Drawing.Size(74, 26);
			this.btnBuscarMOD.TabIndex = 21;
			this.btnBuscarMOD.Text = "Buscar";
			this.btnBuscarMOD.UseVisualStyleBackColor = true;
			this.btnBuscarMOD.Click += new System.EventHandler(this.BtnBuscarMODClick);
			// 
			// btnAceptarMOD
			// 
			this.btnAceptarMOD.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btnAceptarMOD.Location = new System.Drawing.Point(142, 348);
			this.btnAceptarMOD.Name = "btnAceptarMOD";
			this.btnAceptarMOD.Size = new System.Drawing.Size(101, 26);
			this.btnAceptarMOD.TabIndex = 20;
			this.btnAceptarMOD.Text = "Aceptar";
			this.btnAceptarMOD.UseVisualStyleBackColor = true;
			// 
			// tbDescripcionMOD
			// 
			this.tbDescripcionMOD.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.tbDescripcionMOD.Location = new System.Drawing.Point(142, 172);
			this.tbDescripcionMOD.Multiline = true;
			this.tbDescripcionMOD.Name = "tbDescripcionMOD";
			this.tbDescripcionMOD.Size = new System.Drawing.Size(221, 166);
			this.tbDescripcionMOD.TabIndex = 19;
			// 
			// tbAutorMOD
			// 
			this.tbAutorMOD.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.tbAutorMOD.Location = new System.Drawing.Point(142, 99);
			this.tbAutorMOD.Name = "tbAutorMOD";
			this.tbAutorMOD.Size = new System.Drawing.Size(221, 24);
			this.tbAutorMOD.TabIndex = 17;
			// 
			// tbTituloMOD
			// 
			this.tbTituloMOD.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.tbTituloMOD.Location = new System.Drawing.Point(142, 65);
			this.tbTituloMOD.Name = "tbTituloMOD";
			this.tbTituloMOD.Size = new System.Drawing.Size(221, 24);
			this.tbTituloMOD.TabIndex = 16;
			// 
			// dateTimeFechaMOD
			// 
			this.dateTimeFechaMOD.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.dateTimeFechaMOD.Location = new System.Drawing.Point(142, 137);
			this.dateTimeFechaMOD.Name = "dateTimeFechaMOD";
			this.dateTimeFechaMOD.Size = new System.Drawing.Size(221, 24);
			this.dateTimeFechaMOD.TabIndex = 18;
			// 
			// lbDatosMOD
			// 
			this.lbDatosMOD.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lbDatosMOD.Location = new System.Drawing.Point(45, 31);
			this.lbDatosMOD.Name = "lbDatosMOD";
			this.lbDatosMOD.Size = new System.Drawing.Size(91, 169);
			this.lbDatosMOD.TabIndex = 15;
			this.lbDatosMOD.Text = "ID_Libro\r\n\r\nTitulo\r\n\r\nAutor\r\n\r\nFecha\r\n\r\nDescripción\r\n\r\n";
			// 
			// Eliminar
			// 
			this.Eliminar.Controls.Add(this.btnEliminarELI);
			this.Eliminar.Controls.Add(this.tbIdLibroELI);
			this.Eliminar.Controls.Add(this.lbIdLibroELI);
			this.Eliminar.Location = new System.Drawing.Point(4, 27);
			this.Eliminar.Name = "Eliminar";
			this.Eliminar.Padding = new System.Windows.Forms.Padding(3);
			this.Eliminar.Size = new System.Drawing.Size(424, 379);
			this.Eliminar.TabIndex = 2;
			this.Eliminar.Text = "Eliminar";
			this.Eliminar.UseVisualStyleBackColor = true;
			// 
			// btnEliminarELI
			// 
			this.btnEliminarELI.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btnEliminarELI.Location = new System.Drawing.Point(305, 65);
			this.btnEliminarELI.Name = "btnEliminarELI";
			this.btnEliminarELI.Size = new System.Drawing.Size(74, 26);
			this.btnEliminarELI.TabIndex = 22;
			this.btnEliminarELI.Text = "Eliminar";
			this.btnEliminarELI.UseVisualStyleBackColor = true;
			// 
			// tbIdLibroELI
			// 
			this.tbIdLibroELI.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.tbIdLibroELI.Location = new System.Drawing.Point(128, 67);
			this.tbIdLibroELI.Name = "tbIdLibroELI";
			this.tbIdLibroELI.Size = new System.Drawing.Size(159, 24);
			this.tbIdLibroELI.TabIndex = 1;
			// 
			// lbIdLibroELI
			// 
			this.lbIdLibroELI.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lbIdLibroELI.Location = new System.Drawing.Point(41, 71);
			this.lbIdLibroELI.Name = "lbIdLibroELI";
			this.lbIdLibroELI.Size = new System.Drawing.Size(100, 23);
			this.lbIdLibroELI.TabIndex = 0;
			this.lbIdLibroELI.Text = "ID_LIBRO";
			// 
			// Ver_Libros
			// 
			this.Ver_Libros.Controls.Add(this.dataGridLibros);
			this.Ver_Libros.Location = new System.Drawing.Point(4, 27);
			this.Ver_Libros.Name = "Ver_Libros";
			this.Ver_Libros.Padding = new System.Windows.Forms.Padding(3);
			this.Ver_Libros.Size = new System.Drawing.Size(424, 379);
			this.Ver_Libros.TabIndex = 3;
			this.Ver_Libros.Text = "Ver Libros";
			this.Ver_Libros.UseVisualStyleBackColor = true;
			// 
			// dataGridLibros
			// 
			this.dataGridLibros.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.dataGridLibros.Location = new System.Drawing.Point(6, 41);
			this.dataGridLibros.Name = "dataGridLibros";
			this.dataGridLibros.Size = new System.Drawing.Size(412, 337);
			this.dataGridLibros.TabIndex = 0;
			// 
			// lbTitulo
			// 
			this.lbTitulo.Font = new System.Drawing.Font("Stencil", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lbTitulo.Location = new System.Drawing.Point(184, 9);
			this.lbTitulo.Name = "lbTitulo";
			this.lbTitulo.Size = new System.Drawing.Size(220, 29);
			this.lbTitulo.TabIndex = 10;
			this.lbTitulo.Text = "LIBRERIA CAT";
			// 
			// errores
			// 
			this.errores.ContainerControl = this;
			// 
			// MainForm
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(528, 472);
			this.Controls.Add(this.lbTitulo);
			this.Controls.Add(this.ControPestañas);
			this.Name = "MainForm";
			this.Text = "Libreria";
			this.ControPestañas.ResumeLayout(false);
			this.Agregar.ResumeLayout(false);
			this.Agregar.PerformLayout();
			this.Modificar.ResumeLayout(false);
			this.Modificar.PerformLayout();
			this.Eliminar.ResumeLayout(false);
			this.Eliminar.PerformLayout();
			this.Ver_Libros.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)(this.dataGridLibros)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.errores)).EndInit();
			this.ResumeLayout(false);

		}
	}
}
