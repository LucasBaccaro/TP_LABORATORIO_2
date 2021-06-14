
namespace FrmMenu
{
    partial class FrmMenu
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
            this.btn_Taller = new System.Windows.Forms.Button();
            this.btn_Salir = new System.Windows.Forms.Button();
            this.button_Informacion = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btn_Taller
            // 
            this.btn_Taller.Font = new System.Drawing.Font("Sitka Display", 27.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))));
            this.btn_Taller.Location = new System.Drawing.Point(61, 72);
            this.btn_Taller.Name = "btn_Taller";
            this.btn_Taller.Size = new System.Drawing.Size(317, 72);
            this.btn_Taller.TabIndex = 0;
            this.btn_Taller.Text = "TALLER";
            this.btn_Taller.UseVisualStyleBackColor = true;
            this.btn_Taller.Click += new System.EventHandler(this.btn_Taller_Click);
            // 
            // btn_Salir
            // 
            this.btn_Salir.Font = new System.Drawing.Font("Sitka Display", 27.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))));
            this.btn_Salir.Location = new System.Drawing.Point(61, 228);
            this.btn_Salir.Name = "btn_Salir";
            this.btn_Salir.Size = new System.Drawing.Size(317, 72);
            this.btn_Salir.TabIndex = 2;
            this.btn_Salir.Text = "SALIR";
            this.btn_Salir.UseVisualStyleBackColor = true;
            this.btn_Salir.Click += new System.EventHandler(this.btn_Salir_Click);
            // 
            // button_Informacion
            // 
            this.button_Informacion.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.button_Informacion.Font = new System.Drawing.Font("Sitka Display", 27.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))));
            this.button_Informacion.Location = new System.Drawing.Point(61, 150);
            this.button_Informacion.Name = "button_Informacion";
            this.button_Informacion.Size = new System.Drawing.Size(317, 72);
            this.button_Informacion.TabIndex = 3;
            this.button_Informacion.Text = "INFORMACION";
            this.button_Informacion.UseVisualStyleBackColor = true;
            this.button_Informacion.Click += new System.EventHandler(this.button_Informacion_Click);
            // 
            // FrmMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(437, 367);
            this.Controls.Add(this.button_Informacion);
            this.Controls.Add(this.btn_Salir);
            this.Controls.Add(this.btn_Taller);
            this.Name = "FrmMenu";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Baccaro.Lucas.2A";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btn_Taller;
        private System.Windows.Forms.Button btn_Salir;
        private System.Windows.Forms.Button button_Informacion;
    }
}

