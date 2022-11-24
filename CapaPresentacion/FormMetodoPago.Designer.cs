namespace CapaPresentacion
{
    partial class FormMetodoPago
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
            this.txtMetodoPago = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.btnModificarMetodoPago = new System.Windows.Forms.Button();
            this.btnEliminarMetodoPago = new System.Windows.Forms.Button();
            this.btnAgregarMetodoPago = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.dgvMetodoPago = new System.Windows.Forms.DataGridView();
            this.txtDescripcionMetodoPago = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtNombreMetodoPago = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.cbCategoriaMetodoPago = new System.Windows.Forms.ComboBox();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvMetodoPago)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(2)))), ((int)(((byte)(106)))), ((int)(((byte)(58)))));
            this.panel1.Controls.Add(this.cbCategoriaMetodoPago);
            this.panel1.Controls.Add(this.txtMetodoPago);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.btnModificarMetodoPago);
            this.panel1.Controls.Add(this.btnEliminarMetodoPago);
            this.panel1.Controls.Add(this.btnAgregarMetodoPago);
            this.panel1.Controls.Add(this.button1);
            this.panel1.Controls.Add(this.dgvMetodoPago);
            this.panel1.Controls.Add(this.txtDescripcionMetodoPago);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.txtNombreMetodoPago);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Location = new System.Drawing.Point(-3, -4);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(813, 397);
            this.panel1.TabIndex = 1;
            // 
            // txtMetodoPago
            // 
            this.txtMetodoPago.Location = new System.Drawing.Point(22, 46);
            this.txtMetodoPago.Name = "txtMetodoPago";
            this.txtMetodoPago.Size = new System.Drawing.Size(231, 20);
            this.txtMetodoPago.TabIndex = 13;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.White;
            this.label4.Location = new System.Drawing.Point(19, 22);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(153, 18);
            this.label4.TabIndex = 12;
            this.label4.Text = "Metodo de Pago ID";
            // 
            // btnModificarMetodoPago
            // 
            this.btnModificarMetodoPago.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(254)))), ((int)(((byte)(159)))), ((int)(((byte)(7)))));
            this.btnModificarMetodoPago.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnModificarMetodoPago.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnModificarMetodoPago.Location = new System.Drawing.Point(661, 335);
            this.btnModificarMetodoPago.Name = "btnModificarMetodoPago";
            this.btnModificarMetodoPago.Size = new System.Drawing.Size(108, 36);
            this.btnModificarMetodoPago.TabIndex = 10;
            this.btnModificarMetodoPago.Text = "Modificar";
            this.btnModificarMetodoPago.UseVisualStyleBackColor = false;
            this.btnModificarMetodoPago.Click += new System.EventHandler(this.btnModificarMetodoPago_Click);
            // 
            // btnEliminarMetodoPago
            // 
            this.btnEliminarMetodoPago.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(254)))), ((int)(((byte)(159)))), ((int)(((byte)(7)))));
            this.btnEliminarMetodoPago.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEliminarMetodoPago.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEliminarMetodoPago.Location = new System.Drawing.Point(492, 335);
            this.btnEliminarMetodoPago.Name = "btnEliminarMetodoPago";
            this.btnEliminarMetodoPago.Size = new System.Drawing.Size(100, 36);
            this.btnEliminarMetodoPago.TabIndex = 9;
            this.btnEliminarMetodoPago.Text = "Eliminar";
            this.btnEliminarMetodoPago.UseVisualStyleBackColor = false;
            this.btnEliminarMetodoPago.Click += new System.EventHandler(this.btnEliminarMetodoPago_Click);
            // 
            // btnAgregarMetodoPago
            // 
            this.btnAgregarMetodoPago.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(254)))), ((int)(((byte)(159)))), ((int)(((byte)(7)))));
            this.btnAgregarMetodoPago.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAgregarMetodoPago.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAgregarMetodoPago.Location = new System.Drawing.Point(314, 335);
            this.btnAgregarMetodoPago.Name = "btnAgregarMetodoPago";
            this.btnAgregarMetodoPago.Size = new System.Drawing.Size(94, 36);
            this.btnAgregarMetodoPago.TabIndex = 8;
            this.btnAgregarMetodoPago.Text = "Agregar";
            this.btnAgregarMetodoPago.UseVisualStyleBackColor = false;
            this.btnAgregarMetodoPago.Click += new System.EventHandler(this.btnAgregarMetodoPago_Click);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(254)))), ((int)(((byte)(159)))), ((int)(((byte)(7)))));
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(722, 9);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(69, 31);
            this.button1.TabIndex = 7;
            this.button1.Text = "Atras";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // dgvMetodoPago
            // 
            this.dgvMetodoPago.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvMetodoPago.Location = new System.Drawing.Point(270, 46);
            this.dgvMetodoPago.Name = "dgvMetodoPago";
            this.dgvMetodoPago.Size = new System.Drawing.Size(521, 283);
            this.dgvMetodoPago.TabIndex = 6;
            // 
            // txtDescripcionMetodoPago
            // 
            this.txtDescripcionMetodoPago.Location = new System.Drawing.Point(22, 212);
            this.txtDescripcionMetodoPago.Multiline = true;
            this.txtDescripcionMetodoPago.Name = "txtDescripcionMetodoPago";
            this.txtDescripcionMetodoPago.Size = new System.Drawing.Size(231, 160);
            this.txtDescripcionMetodoPago.TabIndex = 5;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(19, 185);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(108, 18);
            this.label3.TabIndex = 4;
            this.label3.Text = "Descripcion :";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(19, 78);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(197, 18);
            this.label2.TabIndex = 2;
            this.label2.Text = "Categoria Metodo Pago :";
            // 
            // txtNombreMetodoPago
            // 
            this.txtNombreMetodoPago.Location = new System.Drawing.Point(22, 150);
            this.txtNombreMetodoPago.Name = "txtNombreMetodoPago";
            this.txtNombreMetodoPago.Size = new System.Drawing.Size(231, 20);
            this.txtNombreMetodoPago.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(19, 129);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(78, 18);
            this.label1.TabIndex = 0;
            this.label1.Text = "Nombre :";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::CapaPresentacion.Properties.Resources.logo;
            this.pictureBox1.Location = new System.Drawing.Point(15, 395);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(59, 54);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 2;
            this.pictureBox1.TabStop = false;
            // 
            // cbCategoriaMetodoPago
            // 
            this.cbCategoriaMetodoPago.FormattingEnabled = true;
            this.cbCategoriaMetodoPago.Location = new System.Drawing.Point(22, 99);
            this.cbCategoriaMetodoPago.Name = "cbCategoriaMetodoPago";
            this.cbCategoriaMetodoPago.Size = new System.Drawing.Size(226, 21);
            this.cbCategoriaMetodoPago.TabIndex = 14;
            // 
            // FormMetodoPago
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(254)))), ((int)(((byte)(159)))), ((int)(((byte)(7)))));
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FormMetodoPago";
            this.Text = "MantenedorMetodoPago";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvMetodoPago)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TextBox txtMetodoPago;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button btnModificarMetodoPago;
        private System.Windows.Forms.Button btnEliminarMetodoPago;
        private System.Windows.Forms.Button btnAgregarMetodoPago;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.DataGridView dgvMetodoPago;
        private System.Windows.Forms.TextBox txtDescripcionMetodoPago;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtNombreMetodoPago;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.ComboBox cbCategoriaMetodoPago;
    }
}