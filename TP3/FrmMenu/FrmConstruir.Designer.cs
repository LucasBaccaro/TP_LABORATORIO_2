
namespace FrmMenu
{
    partial class FrmConstruir
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
            this.components = new System.ComponentModel.Container();
            this.btn_Atras = new System.Windows.Forms.Button();
            this.btn_Construir = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.txt_Color = new System.Windows.Forms.TextBox();
            this.comboBoxArticulo = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txt_CodigoSerie = new System.Windows.Forms.TextBox();
            this.comboBox_Tipo = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.btn_Remover = new System.Windows.Forms.Button();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.txt_talle = new System.Windows.Forms.TextBox();
            this.txt_Ancho = new System.Windows.Forms.TextBox();
            this.txt_Largo = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.Ancho = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.btn_Guardar = new System.Windows.Forms.Button();
            this.listbox_deposito = new System.Windows.Forms.ListBox();
            this.txt_Guardar = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // btn_Atras
            // 
            this.btn_Atras.Font = new System.Drawing.Font("Sitka Display", 8.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))));
            this.btn_Atras.Location = new System.Drawing.Point(12, 279);
            this.btn_Atras.Name = "btn_Atras";
            this.btn_Atras.Size = new System.Drawing.Size(163, 23);
            this.btn_Atras.TabIndex = 1;
            this.btn_Atras.Text = "ATRAS";
            this.btn_Atras.UseVisualStyleBackColor = true;
            this.btn_Atras.Click += new System.EventHandler(this.btn_Atras_Click);
            // 
            // btn_Construir
            // 
            this.btn_Construir.Font = new System.Drawing.Font("Sitka Display", 8.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))));
            this.btn_Construir.Location = new System.Drawing.Point(12, 250);
            this.btn_Construir.Name = "btn_Construir";
            this.btn_Construir.Size = new System.Drawing.Size(163, 23);
            this.btn_Construir.TabIndex = 2;
            this.btn_Construir.Text = "CONSTRUIR Y AGREGAR";
            this.btn_Construir.UseVisualStyleBackColor = true;
            this.btn_Construir.Click += new System.EventHandler(this.btn_Construir_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Sitka Display", 8.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))));
            this.label1.Location = new System.Drawing.Point(8, 224);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(32, 16);
            this.label1.TabIndex = 3;
            this.label1.Text = "Color";
            // 
            // txt_Color
            // 
            this.txt_Color.Location = new System.Drawing.Point(89, 224);
            this.txt_Color.Name = "txt_Color";
            this.txt_Color.Size = new System.Drawing.Size(86, 20);
            this.txt_Color.TabIndex = 4;
            // 
            // comboBoxArticulo
            // 
            this.comboBoxArticulo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxArticulo.FormattingEnabled = true;
            this.comboBoxArticulo.Items.AddRange(new object[] {
            "Pantalón",
            "Remera"});
            this.comboBoxArticulo.Location = new System.Drawing.Point(87, 68);
            this.comboBoxArticulo.Name = "comboBoxArticulo";
            this.comboBoxArticulo.Size = new System.Drawing.Size(88, 21);
            this.comboBoxArticulo.TabIndex = 5;
            this.comboBoxArticulo.SelectedIndexChanged += new System.EventHandler(this.comboBoxArticulo_SelectedIndexChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Sitka Display", 8.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(9, 68);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(45, 16);
            this.label2.TabIndex = 6;
            this.label2.Text = "Articulo";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Sitka Display", 8.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))));
            this.label3.Location = new System.Drawing.Point(9, 198);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(39, 16);
            this.label3.TabIndex = 7;
            this.label3.Text = "Codigo";
            // 
            // txt_CodigoSerie
            // 
            this.txt_CodigoSerie.Location = new System.Drawing.Point(89, 198);
            this.txt_CodigoSerie.Name = "txt_CodigoSerie";
            this.txt_CodigoSerie.Size = new System.Drawing.Size(86, 20);
            this.txt_CodigoSerie.TabIndex = 8;
            // 
            // comboBox_Tipo
            // 
            this.comboBox_Tipo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox_Tipo.FormattingEnabled = true;
            this.comboBox_Tipo.Items.AddRange(new object[] {
            "Algodón",
            "Terciopelo"});
            this.comboBox_Tipo.Location = new System.Drawing.Point(87, 95);
            this.comboBox_Tipo.Name = "comboBox_Tipo";
            this.comboBox_Tipo.Size = new System.Drawing.Size(88, 21);
            this.comboBox_Tipo.TabIndex = 9;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Sitka Display", 8.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))));
            this.label4.Location = new System.Drawing.Point(9, 95);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(27, 16);
            this.label4.TabIndex = 10;
            this.label4.Text = "Tela";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Sitka Display", 27.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(12, 9);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(148, 53);
            this.label5.TabIndex = 11;
            this.label5.Text = "TALLER";
            this.label5.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Sitka Display", 27.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))));
            this.label6.Location = new System.Drawing.Point(350, 9);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(365, 53);
            this.label6.TabIndex = 14;
            this.label6.Text = "LISTA DE ARTICULOS";
            // 
            // btn_Remover
            // 
            this.btn_Remover.Font = new System.Drawing.Font("Sitka Display", 8.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))));
            this.btn_Remover.Location = new System.Drawing.Point(12, 337);
            this.btn_Remover.Name = "btn_Remover";
            this.btn_Remover.Size = new System.Drawing.Size(163, 23);
            this.btn_Remover.TabIndex = 16;
            this.btn_Remover.Text = "REMOVER";
            this.btn_Remover.UseVisualStyleBackColor = true;
            this.btn_Remover.Click += new System.EventHandler(this.btn_Remover_Click);
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(61, 4);
            // 
            // txt_talle
            // 
            this.txt_talle.Location = new System.Drawing.Point(119, 172);
            this.txt_talle.Name = "txt_talle";
            this.txt_talle.Size = new System.Drawing.Size(24, 20);
            this.txt_talle.TabIndex = 21;
            // 
            // txt_Ancho
            // 
            this.txt_Ancho.Location = new System.Drawing.Point(119, 146);
            this.txt_Ancho.Name = "txt_Ancho";
            this.txt_Ancho.Size = new System.Drawing.Size(24, 20);
            this.txt_Ancho.TabIndex = 22;
            // 
            // txt_Largo
            // 
            this.txt_Largo.Location = new System.Drawing.Point(119, 122);
            this.txt_Largo.Name = "txt_Largo";
            this.txt_Largo.Size = new System.Drawing.Size(24, 20);
            this.txt_Largo.TabIndex = 23;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Sitka Display", 8.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))));
            this.label9.Location = new System.Drawing.Point(9, 172);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(30, 16);
            this.label9.TabIndex = 24;
            this.label9.Text = "Talle";
            // 
            // Ancho
            // 
            this.Ancho.AutoSize = true;
            this.Ancho.Font = new System.Drawing.Font("Sitka Display", 8.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))));
            this.Ancho.Location = new System.Drawing.Point(9, 146);
            this.Ancho.Name = "Ancho";
            this.Ancho.Size = new System.Drawing.Size(36, 16);
            this.Ancho.TabIndex = 25;
            this.Ancho.Text = "Ancho";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Sitka Display", 8.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))));
            this.label11.Location = new System.Drawing.Point(12, 122);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(35, 16);
            this.label11.TabIndex = 26;
            this.label11.Text = "Largo";
            // 
            // btn_Guardar
            // 
            this.btn_Guardar.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btn_Guardar.Font = new System.Drawing.Font("Sitka Display", 8.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))));
            this.btn_Guardar.Location = new System.Drawing.Point(12, 308);
            this.btn_Guardar.Name = "btn_Guardar";
            this.btn_Guardar.Size = new System.Drawing.Size(163, 23);
            this.btn_Guardar.TabIndex = 28;
            this.btn_Guardar.Text = "GUARDAR";
            this.btn_Guardar.UseVisualStyleBackColor = true;
            this.btn_Guardar.Click += new System.EventHandler(this.btn_Guardar_Click);
            // 
            // listbox_deposito
            // 
            this.listbox_deposito.FormattingEnabled = true;
            this.listbox_deposito.Location = new System.Drawing.Point(335, 71);
            this.listbox_deposito.Name = "listbox_deposito";
            this.listbox_deposito.Size = new System.Drawing.Size(525, 290);
            this.listbox_deposito.TabIndex = 33;
            // 
            // txt_Guardar
            // 
            this.txt_Guardar.Location = new System.Drawing.Point(181, 311);
            this.txt_Guardar.Name = "txt_Guardar";
            this.txt_Guardar.Size = new System.Drawing.Size(100, 20);
            this.txt_Guardar.TabIndex = 34;
            // 
            // FrmConstruir
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(872, 378);
            this.Controls.Add(this.txt_Guardar);
            this.Controls.Add(this.listbox_deposito);
            this.Controls.Add(this.btn_Guardar);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.Ancho);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.txt_Largo);
            this.Controls.Add(this.txt_Ancho);
            this.Controls.Add(this.txt_talle);
            this.Controls.Add(this.btn_Remover);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.comboBox_Tipo);
            this.Controls.Add(this.txt_CodigoSerie);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.comboBoxArticulo);
            this.Controls.Add(this.txt_Color);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btn_Construir);
            this.Controls.Add(this.btn_Atras);
            this.Name = "FrmConstruir";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Baccaro.Lucas.2A";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button btn_Atras;
        private System.Windows.Forms.Button btn_Construir;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txt_Color;
        private System.Windows.Forms.ComboBox comboBoxArticulo;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txt_CodigoSerie;
        private System.Windows.Forms.ComboBox comboBox_Tipo;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button btn_Remover;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.TextBox txt_talle;
        private System.Windows.Forms.TextBox txt_Ancho;
        private System.Windows.Forms.TextBox txt_Largo;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label Ancho;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Button btn_Guardar;
        private System.Windows.Forms.ListBox listbox_deposito;
        private System.Windows.Forms.TextBox txt_Guardar;
    }
}