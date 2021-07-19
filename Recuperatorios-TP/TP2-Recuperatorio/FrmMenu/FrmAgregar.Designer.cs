
namespace FrmMenu
{
    partial class FrmAgregar
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
            this.comboBoxArticulo = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.txt_Talle = new System.Windows.Forms.TextBox();
            this.txt_CodigoDeBarra = new System.Windows.Forms.TextBox();
            this.comboBoxTipo = new System.Windows.Forms.ComboBox();
            this.comboBoxColor = new System.Windows.Forms.ComboBox();
            this.btn_Aceptar = new System.Windows.Forms.Button();
            this.btn_Cancelar = new System.Windows.Forms.Button();
            this.listBox_lista = new System.Windows.Forms.ListBox();
            this.btn_descoser = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // comboBoxArticulo
            // 
            this.comboBoxArticulo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxArticulo.FormattingEnabled = true;
            this.comboBoxArticulo.Items.AddRange(new object[] {
            "Pantalon",
            "Remera"});
            this.comboBoxArticulo.Location = new System.Drawing.Point(12, 57);
            this.comboBoxArticulo.Name = "comboBoxArticulo";
            this.comboBoxArticulo.Size = new System.Drawing.Size(121, 21);
            this.comboBoxArticulo.TabIndex = 0;
            this.comboBoxArticulo.SelectedIndexChanged += new System.EventHandler(this.comboBoxArticulo_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(35, 41);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(80, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Ingrese Articulo";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(60, 81);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(30, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Talle";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(28, 120);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(87, 13);
            this.label3.TabIndex = 3;
            this.label3.Text = "Codigo de barras";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(28, 159);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(31, 13);
            this.label4.TabIndex = 4;
            this.label4.Text = "Color";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(87, 159);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(28, 13);
            this.label5.TabIndex = 5;
            this.label5.Text = "Tipo";
            // 
            // txt_Talle
            // 
            this.txt_Talle.Location = new System.Drawing.Point(61, 97);
            this.txt_Talle.Name = "txt_Talle";
            this.txt_Talle.Size = new System.Drawing.Size(29, 20);
            this.txt_Talle.TabIndex = 6;
            // 
            // txt_CodigoDeBarra
            // 
            this.txt_CodigoDeBarra.Location = new System.Drawing.Point(15, 136);
            this.txt_CodigoDeBarra.Name = "txt_CodigoDeBarra";
            this.txt_CodigoDeBarra.Size = new System.Drawing.Size(119, 20);
            this.txt_CodigoDeBarra.TabIndex = 7;
            // 
            // comboBoxTipo
            // 
            this.comboBoxTipo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxTipo.FormattingEnabled = true;
            this.comboBoxTipo.Items.AddRange(new object[] {
            "Corto",
            "Largo"});
            this.comboBoxTipo.Location = new System.Drawing.Point(81, 175);
            this.comboBoxTipo.Name = "comboBoxTipo";
            this.comboBoxTipo.Size = new System.Drawing.Size(55, 21);
            this.comboBoxTipo.TabIndex = 8;
            this.comboBoxTipo.SelectedIndexChanged += new System.EventHandler(this.comboBoxTipo_SelectedIndexChanged);
            // 
            // comboBoxColor
            // 
            this.comboBoxColor.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxColor.FormattingEnabled = true;
            this.comboBoxColor.Items.AddRange(new object[] {
            "Negro",
            "Azul",
            "Verde"});
            this.comboBoxColor.Location = new System.Drawing.Point(15, 175);
            this.comboBoxColor.Name = "comboBoxColor";
            this.comboBoxColor.Size = new System.Drawing.Size(60, 21);
            this.comboBoxColor.TabIndex = 9;
            this.comboBoxColor.SelectedIndexChanged += new System.EventHandler(this.comboBoxColor_SelectedIndexChanged);
            // 
            // btn_Aceptar
            // 
            this.btn_Aceptar.Location = new System.Drawing.Point(15, 212);
            this.btn_Aceptar.Name = "btn_Aceptar";
            this.btn_Aceptar.Size = new System.Drawing.Size(75, 23);
            this.btn_Aceptar.TabIndex = 10;
            this.btn_Aceptar.Text = "ACEPTAR";
            this.btn_Aceptar.UseVisualStyleBackColor = true;
            this.btn_Aceptar.Click += new System.EventHandler(this.btn_Aceptar_Click);
            // 
            // btn_Cancelar
            // 
            this.btn_Cancelar.Location = new System.Drawing.Point(15, 241);
            this.btn_Cancelar.Name = "btn_Cancelar";
            this.btn_Cancelar.Size = new System.Drawing.Size(75, 23);
            this.btn_Cancelar.TabIndex = 11;
            this.btn_Cancelar.Text = "CANCELAR";
            this.btn_Cancelar.UseVisualStyleBackColor = true;
            this.btn_Cancelar.Click += new System.EventHandler(this.btn_Cancelar_Click);
            // 
            // listBox_lista
            // 
            this.listBox_lista.FormattingEnabled = true;
            this.listBox_lista.Location = new System.Drawing.Point(142, 42);
            this.listBox_lista.Name = "listBox_lista";
            this.listBox_lista.Size = new System.Drawing.Size(442, 251);
            this.listBox_lista.TabIndex = 12;
            // 
            // btn_descoser
            // 
            this.btn_descoser.Location = new System.Drawing.Point(15, 270);
            this.btn_descoser.Name = "btn_descoser";
            this.btn_descoser.Size = new System.Drawing.Size(75, 23);
            this.btn_descoser.TabIndex = 13;
            this.btn_descoser.Text = "DESCOSER";
            this.btn_descoser.UseVisualStyleBackColor = true;
            this.btn_descoser.Click += new System.EventHandler(this.btn_descoser_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft YaHei", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(280, 9);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(218, 28);
            this.label6.TabIndex = 14;
            this.label6.Text = "LISTA DE PRENDAS";
            // 
            // FrmAgregar
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(596, 302);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.btn_descoser);
            this.Controls.Add(this.listBox_lista);
            this.Controls.Add(this.btn_Cancelar);
            this.Controls.Add(this.btn_Aceptar);
            this.Controls.Add(this.comboBoxColor);
            this.Controls.Add(this.comboBoxTipo);
            this.Controls.Add(this.txt_CodigoDeBarra);
            this.Controls.Add(this.txt_Talle);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.comboBoxArticulo);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FrmAgregar";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FrmAgregar";
            this.Load += new System.EventHandler(this.FrmAgregar_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox comboBoxArticulo;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txt_Talle;
        private System.Windows.Forms.TextBox txt_CodigoDeBarra;
        private System.Windows.Forms.ComboBox comboBoxTipo;
        private System.Windows.Forms.ComboBox comboBoxColor;
        private System.Windows.Forms.Button btn_Aceptar;
        private System.Windows.Forms.Button btn_Cancelar;
        private System.Windows.Forms.ListBox listBox_lista;
        private System.Windows.Forms.Button btn_descoser;
        private System.Windows.Forms.Label label6;
    }
}