
namespace FrmMenu
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
            this.btn_Taller = new System.Windows.Forms.Button();
            this.btn_Deposito = new System.Windows.Forms.Button();
            this.btn_Salir = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btn_Taller
            // 
            this.btn_Taller.Location = new System.Drawing.Point(61, 130);
            this.btn_Taller.Name = "btn_Taller";
            this.btn_Taller.Size = new System.Drawing.Size(157, 38);
            this.btn_Taller.TabIndex = 0;
            this.btn_Taller.Text = "TALLER";
            this.btn_Taller.UseVisualStyleBackColor = true;
            this.btn_Taller.Click += new System.EventHandler(this.btn_Taller_Click);
            // 
            // btn_Deposito
            // 
            this.btn_Deposito.Location = new System.Drawing.Point(61, 192);
            this.btn_Deposito.Name = "btn_Deposito";
            this.btn_Deposito.Size = new System.Drawing.Size(157, 39);
            this.btn_Deposito.TabIndex = 1;
            this.btn_Deposito.Text = "DEPOSITO";
            this.btn_Deposito.UseVisualStyleBackColor = true;
            // 
            // btn_Salir
            // 
            this.btn_Salir.Location = new System.Drawing.Point(61, 252);
            this.btn_Salir.Name = "btn_Salir";
            this.btn_Salir.Size = new System.Drawing.Size(157, 41);
            this.btn_Salir.TabIndex = 2;
            this.btn_Salir.Text = "SALIR";
            this.btn_Salir.UseVisualStyleBackColor = true;
            this.btn_Salir.Click += new System.EventHandler(this.btn_Salir_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(291, 427);
            this.Controls.Add(this.btn_Salir);
            this.Controls.Add(this.btn_Deposito);
            this.Controls.Add(this.btn_Taller);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btn_Taller;
        private System.Windows.Forms.Button btn_Deposito;
        private System.Windows.Forms.Button btn_Salir;
    }
}

