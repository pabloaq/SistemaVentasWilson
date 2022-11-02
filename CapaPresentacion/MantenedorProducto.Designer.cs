﻿namespace MantenedorProducto
{
    partial class MantenedorProducto
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.btn_agregar = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.dgv_listaProductos = new System.Windows.Forms.DataGridView();
            this.panel2 = new System.Windows.Forms.Panel();
            this.txt_codCategoria = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.dt_fechaCaducidad = new System.Windows.Forms.DateTimePicker();
            this.txt_codProducto = new System.Windows.Forms.TextBox();
            this.Nombre = new System.Windows.Forms.Label();
            this.txt_stockProducto = new System.Windows.Forms.TextBox();
            this.txt_nomProducto = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.panel3 = new System.Windows.Forms.Panel();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.btn_atras = new System.Windows.Forms.Button();
            this.btn_consultaStock = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_listaProductos)).BeginInit();
            this.panel2.SuspendLayout();
            this.panel3.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(2)))), ((int)(((byte)(105)))), ((int)(((byte)(58)))));
            this.panel1.Controls.Add(this.btn_consultaStock);
            this.panel1.Controls.Add(this.btn_agregar);
            this.panel1.Controls.Add(this.groupBox1);
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Location = new System.Drawing.Point(12, 12);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1259, 338);
            this.panel1.TabIndex = 0;
            // 
            // btn_agregar
            // 
            this.btn_agregar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(254)))), ((int)(((byte)(159)))), ((int)(((byte)(7)))));
            this.btn_agregar.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(254)))), ((int)(((byte)(159)))), ((int)(((byte)(7)))));
            this.btn_agregar.FlatAppearance.BorderSize = 0;
            this.btn_agregar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_agregar.Location = new System.Drawing.Point(296, 281);
            this.btn_agregar.Name = "btn_agregar";
            this.btn_agregar.Size = new System.Drawing.Size(99, 34);
            this.btn_agregar.TabIndex = 13;
            this.btn_agregar.Text = "Agregar";
            this.btn_agregar.UseVisualStyleBackColor = false;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.dgv_listaProductos);
            this.groupBox1.Font = new System.Drawing.Font("Sitka Banner", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.ForeColor = System.Drawing.Color.White;
            this.groupBox1.Location = new System.Drawing.Point(290, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(957, 222);
            this.groupBox1.TabIndex = 12;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Lista de Productos";
            // 
            // dgv_listaProductos
            // 
            this.dgv_listaProductos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_listaProductos.Location = new System.Drawing.Point(6, 32);
            this.dgv_listaProductos.Name = "dgv_listaProductos";
            this.dgv_listaProductos.RowHeadersWidth = 51;
            this.dgv_listaProductos.RowTemplate.Height = 24;
            this.dgv_listaProductos.Size = new System.Drawing.Size(945, 180);
            this.dgv_listaProductos.TabIndex = 0;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.txt_codCategoria);
            this.panel2.Controls.Add(this.label4);
            this.panel2.Controls.Add(this.label1);
            this.panel2.Controls.Add(this.label3);
            this.panel2.Controls.Add(this.dt_fechaCaducidad);
            this.panel2.Controls.Add(this.txt_codProducto);
            this.panel2.Controls.Add(this.Nombre);
            this.panel2.Controls.Add(this.txt_stockProducto);
            this.panel2.Controls.Add(this.txt_nomProducto);
            this.panel2.Controls.Add(this.label2);
            this.panel2.Location = new System.Drawing.Point(12, 12);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(272, 310);
            this.panel2.TabIndex = 11;
            // 
            // txt_codCategoria
            // 
            this.txt_codCategoria.Location = new System.Drawing.Point(13, 275);
            this.txt_codCategoria.Name = "txt_codCategoria";
            this.txt_codCategoria.Size = new System.Drawing.Size(200, 22);
            this.txt_codCategoria.TabIndex = 9;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label4.Location = new System.Drawing.Point(13, 256);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(170, 16);
            this.label4.TabIndex = 8;
            this.label4.Text = "Codigo Categoria Producto";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label1.Location = new System.Drawing.Point(13, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(108, 16);
            this.label1.TabIndex = 0;
            this.label1.Text = "Codigo Producto";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label3.Location = new System.Drawing.Point(13, 196);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(133, 16);
            this.label3.TabIndex = 7;
            this.label3.Text = "Fecha de Caducidad";
            // 
            // dt_fechaCaducidad
            // 
            this.dt_fechaCaducidad.Location = new System.Drawing.Point(13, 215);
            this.dt_fechaCaducidad.Name = "dt_fechaCaducidad";
            this.dt_fechaCaducidad.Size = new System.Drawing.Size(241, 22);
            this.dt_fechaCaducidad.TabIndex = 6;
            // 
            // txt_codProducto
            // 
            this.txt_codProducto.Location = new System.Drawing.Point(13, 32);
            this.txt_codProducto.Name = "txt_codProducto";
            this.txt_codProducto.Size = new System.Drawing.Size(174, 22);
            this.txt_codProducto.TabIndex = 1;
            // 
            // Nombre
            // 
            this.Nombre.AutoSize = true;
            this.Nombre.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.Nombre.Location = new System.Drawing.Point(13, 72);
            this.Nombre.Name = "Nombre";
            this.Nombre.Size = new System.Drawing.Size(113, 16);
            this.Nombre.TabIndex = 2;
            this.Nombre.Text = "Nombre Producto";
            // 
            // txt_stockProducto
            // 
            this.txt_stockProducto.Location = new System.Drawing.Point(13, 152);
            this.txt_stockProducto.Name = "txt_stockProducto";
            this.txt_stockProducto.Size = new System.Drawing.Size(174, 22);
            this.txt_stockProducto.TabIndex = 5;
            // 
            // txt_nomProducto
            // 
            this.txt_nomProducto.Location = new System.Drawing.Point(13, 91);
            this.txt_nomProducto.Name = "txt_nomProducto";
            this.txt_nomProducto.Size = new System.Drawing.Size(174, 22);
            this.txt_nomProducto.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label2.Location = new System.Drawing.Point(13, 133);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(98, 16);
            this.label2.TabIndex = 4;
            this.label2.Text = "Stock Producto";
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.label6);
            this.panel3.Controls.Add(this.label5);
            this.panel3.Location = new System.Drawing.Point(1071, 356);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(200, 69);
            this.panel3.TabIndex = 1;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.label5.Location = new System.Drawing.Point(10, 12);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(187, 16);
            this.label5.TabIndex = 0;
            this.label5.Text = "Av. España 1970. Trujillo. Peru";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.label6.Location = new System.Drawing.Point(119, 40);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(78, 16);
            this.label6.TabIndex = 1;
            this.label6.Text = "(044)678102";
            // 
            // btn_atras
            // 
            this.btn_atras.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(254)))), ((int)(((byte)(159)))), ((int)(((byte)(7)))));
            this.btn_atras.FlatAppearance.BorderSize = 0;
            this.btn_atras.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_atras.Location = new System.Drawing.Point(12, 387);
            this.btn_atras.Name = "btn_atras";
            this.btn_atras.Size = new System.Drawing.Size(89, 34);
            this.btn_atras.TabIndex = 2;
            this.btn_atras.Text = "Atras";
            this.btn_atras.UseVisualStyleBackColor = false;
            this.btn_atras.Click += new System.EventHandler(this.button1_Click);
            // 
            // btn_consultaStock
            // 
            this.btn_consultaStock.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(254)))), ((int)(((byte)(159)))), ((int)(((byte)(7)))));
            this.btn_consultaStock.FlatAppearance.BorderSize = 0;
            this.btn_consultaStock.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_consultaStock.Location = new System.Drawing.Point(401, 281);
            this.btn_consultaStock.Name = "btn_consultaStock";
            this.btn_consultaStock.Size = new System.Drawing.Size(99, 34);
            this.btn_consultaStock.TabIndex = 14;
            this.btn_consultaStock.Text = "Stock";
            this.btn_consultaStock.UseVisualStyleBackColor = false;
            // 
            // MantenedorProducto
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(7)))), ((int)(((byte)(59)))), ((int)(((byte)(11)))));
            this.ClientSize = new System.Drawing.Size(1283, 439);
            this.Controls.Add(this.btn_atras);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel1);
            this.Name = "MantenedorProducto";
            this.Text = "MantenedorProducto";
            this.Load += new System.EventHandler(this.MantenedorProducto_Load);
            this.panel1.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgv_listaProductos)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btn_agregar;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.DataGridView dgv_listaProductos;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.TextBox txt_codCategoria;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DateTimePicker dt_fechaCaducidad;
        private System.Windows.Forms.TextBox txt_codProducto;
        private System.Windows.Forms.Label Nombre;
        private System.Windows.Forms.TextBox txt_stockProducto;
        private System.Windows.Forms.TextBox txt_nomProducto;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button btn_atras;
        private System.Windows.Forms.Button btn_consultaStock;
    }
}