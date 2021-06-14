
namespace FrmMenu
{
    partial class FrmInformacion
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.richTextBox_Informacion = new System.Windows.Forms.RichTextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btn_Cargar = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // richTextBox_Informacion
            // 
            this.richTextBox_Informacion.Location = new System.Drawing.Point(12, 65);
            this.richTextBox_Informacion.Name = "richTextBox_Informacion";
            this.richTextBox_Informacion.Size = new System.Drawing.Size(371, 221);
            this.richTextBox_Informacion.TabIndex = 1;
            this.richTextBox_Informacion.Text = "";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Sitka Display", 27.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))));
            this.label1.Location = new System.Drawing.Point(68, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(261, 53);
            this.label1.TabIndex = 2;
            this.label1.Text = "INFORMACION";
            // 
            // btn_Cargar
            // 
            this.btn_Cargar.Font = new System.Drawing.Font("Sitka Display", 27.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))));
            this.btn_Cargar.Location = new System.Drawing.Point(77, 292);
            this.btn_Cargar.Name = "btn_Cargar";
            this.btn_Cargar.Size = new System.Drawing.Size(251, 66);
            this.btn_Cargar.TabIndex = 3;
            this.btn_Cargar.Text = "CARGAR";
            this.btn_Cargar.UseVisualStyleBackColor = true;
            this.btn_Cargar.Click += new System.EventHandler(this.btn_Cargar_Click);
            // 
            // FrmInformacion
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ClientSize = new System.Drawing.Size(398, 385);
            this.Controls.Add(this.btn_Cargar);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.richTextBox_Informacion);
            this.Name = "FrmInformacion";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Baccaro.Lucas.2A";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.RichTextBox richTextBox_Informacion;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btn_Cargar;
    }
}