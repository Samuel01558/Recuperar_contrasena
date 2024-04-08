namespace Recuperar_contrasena
{
    partial class RecuperarUsuario
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            tbxUsuario = new TextBox();
            tbxNombreCompleto = new TextBox();
            tbxTelefono = new TextBox();
            tbxNuevaContrasena = new TextBox();
            tbxRepetirContrasena = new TextBox();
            btn_Confirmar = new Button();
            SuspendLayout();
            // 
            // tbxUsuario
            // 
            tbxUsuario.Location = new Point(99, 54);
            tbxUsuario.Name = "tbxUsuario";
            tbxUsuario.Size = new Size(336, 23);
            tbxUsuario.TabIndex = 0;
            tbxUsuario.Text = "Usuario";
            // 
            // tbxNombreCompleto
            // 
            tbxNombreCompleto.Location = new Point(99, 98);
            tbxNombreCompleto.Name = "tbxNombreCompleto";
            tbxNombreCompleto.Size = new Size(336, 23);
            tbxNombreCompleto.TabIndex = 1;
            tbxNombreCompleto.Text = "Nombre Completo";
            // 
            // tbxTelefono
            // 
            tbxTelefono.Location = new Point(99, 154);
            tbxTelefono.Name = "tbxTelefono";
            tbxTelefono.Size = new Size(336, 23);
            tbxTelefono.TabIndex = 2;
            tbxTelefono.Text = "Telefono";
            // 
            // tbxNuevaContrasena
            // 
            tbxNuevaContrasena.Location = new Point(99, 200);
            tbxNuevaContrasena.Name = "tbxNuevaContrasena";
            tbxNuevaContrasena.Size = new Size(336, 23);
            tbxNuevaContrasena.TabIndex = 3;
            tbxNuevaContrasena.Text = "Nueva contrasena";
            // 
            // tbxRepetirContrasena
            // 
            tbxRepetirContrasena.Location = new Point(99, 255);
            tbxRepetirContrasena.Name = "tbxRepetirContrasena";
            tbxRepetirContrasena.Size = new Size(336, 23);
            tbxRepetirContrasena.TabIndex = 4;
            tbxRepetirContrasena.Text = "Repetir Contrasena";
            // 
            // btn_Confirmar
            // 
            btn_Confirmar.Location = new Point(205, 328);
            btn_Confirmar.Name = "btn_Confirmar";
            btn_Confirmar.Size = new Size(75, 23);
            btn_Confirmar.TabIndex = 5;
            btn_Confirmar.Text = "Confirmar";
            btn_Confirmar.UseVisualStyleBackColor = true;
            btn_Confirmar.Click += btn_Confirmar_Click;
            // 
            // RecuperarUsuario
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(btn_Confirmar);
            Controls.Add(tbxRepetirContrasena);
            Controls.Add(tbxNuevaContrasena);
            Controls.Add(tbxTelefono);
            Controls.Add(tbxNombreCompleto);
            Controls.Add(tbxUsuario);
            Name = "RecuperarUsuario";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox tbxUsuario;
        private TextBox tbxNombreCompleto;
        private TextBox tbxTelefono;
        private TextBox tbxNuevaContrasena;
        private TextBox tbxRepetirContrasena;
        private Button btn_Confirmar;
    }
}