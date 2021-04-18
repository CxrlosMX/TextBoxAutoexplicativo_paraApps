
namespace Testcontrol
{
    partial class Form1
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.nombre = new TextBoxAutoexplicativo.txtAutoexplicativo();
            this.correo = new TextBoxAutoexplicativo.txtAutoexplicativo();
            this.contraseña = new TextBoxAutoexplicativo.txtAutoexplicativo();
            this.SuspendLayout();
            // 
            // nombre
            // 
            this.nombre.ColorTextoVacio = System.Drawing.Color.Gray;
            this.nombre.Location = new System.Drawing.Point(34, 27);
            this.nombre.Name = "nombre";
            this.nombre.Size = new System.Drawing.Size(255, 20);
            this.nombre.TabIndex = 0;
            this.nombre.TextoVacio = "Nombre";
            this.nombre.TextChanged += new System.EventHandler(this.nombre_TextChanged);
            // 
            // correo
            // 
            this.correo.ColorTextoVacio = System.Drawing.Color.Gray;
            this.correo.Location = new System.Drawing.Point(34, 53);
            this.correo.Name = "correo";
            this.correo.Size = new System.Drawing.Size(255, 20);
            this.correo.TabIndex = 1;
            this.correo.TextoVacio = "E-mail";
            // 
            // contraseña
            // 
            this.contraseña.ColorTextoVacio = System.Drawing.Color.Gray;
            this.contraseña.Location = new System.Drawing.Point(34, 79);
            this.contraseña.Name = "contraseña";
            this.contraseña.Size = new System.Drawing.Size(255, 20);
            this.contraseña.TabIndex = 2;
            this.contraseña.TextoVacio = "Contraseña";
            this.contraseña.TextChanged += new System.EventHandler(this.contraseña_TextChanged);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(339, 157);
            this.Controls.Add(this.contraseña);
            this.Controls.Add(this.correo);
            this.Controls.Add(this.nombre);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private TextBoxAutoexplicativo.txtAutoexplicativo nombre;
        private TextBoxAutoexplicativo.txtAutoexplicativo correo;
        private TextBoxAutoexplicativo.txtAutoexplicativo contraseña;
    }
}

