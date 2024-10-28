namespace POO_EP2_PSAM
{
    partial class AgregarBici
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
            this.TbTipo = new System.Windows.Forms.TextBox();
            this.TbAño = new System.Windows.Forms.TextBox();
            this.TbModelo = new System.Windows.Forms.TextBox();
            this.TbMarca = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.CrearVehículo = new System.Windows.Forms.Button();
            this.RegresarPrincipal = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.TbIDBicicleta = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // TbTipo
            // 
            this.TbTipo.Font = new System.Drawing.Font("Futura Bk BT", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TbTipo.Location = new System.Drawing.Point(371, 461);
            this.TbTipo.Name = "TbTipo";
            this.TbTipo.Size = new System.Drawing.Size(504, 40);
            this.TbTipo.TabIndex = 36;
            this.TbTipo.TextChanged += new System.EventHandler(this.TbTipo_TextChanged);
            // 
            // TbAño
            // 
            this.TbAño.Font = new System.Drawing.Font("Futura Bk BT", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TbAño.Location = new System.Drawing.Point(371, 395);
            this.TbAño.Name = "TbAño";
            this.TbAño.Size = new System.Drawing.Size(504, 40);
            this.TbAño.TabIndex = 35;
            this.TbAño.TextChanged += new System.EventHandler(this.TbAño_TextChanged);
            // 
            // TbModelo
            // 
            this.TbModelo.Font = new System.Drawing.Font("Futura Bk BT", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TbModelo.Location = new System.Drawing.Point(371, 262);
            this.TbModelo.Name = "TbModelo";
            this.TbModelo.Size = new System.Drawing.Size(504, 40);
            this.TbModelo.TabIndex = 34;
            this.TbModelo.TextChanged += new System.EventHandler(this.TbModelo_TextChanged);
            // 
            // TbMarca
            // 
            this.TbMarca.Font = new System.Drawing.Font("Futura Bk BT", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TbMarca.Location = new System.Drawing.Point(371, 328);
            this.TbMarca.Name = "TbMarca";
            this.TbMarca.Size = new System.Drawing.Size(504, 40);
            this.TbMarca.TabIndex = 33;
            this.TbMarca.TextChanged += new System.EventHandler(this.TbMarca_TextChanged);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.LightCoral;
            this.label5.Location = new System.Drawing.Point(13, 475);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(74, 36);
            this.label5.TabIndex = 32;
            this.label5.Text = "Tipo";
            this.label5.Click += new System.EventHandler(this.label5_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.LightCoral;
            this.label4.Location = new System.Drawing.Point(28, 409);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(70, 36);
            this.label4.TabIndex = 31;
            this.label4.Text = "Año";
            this.label4.Click += new System.EventHandler(this.label4_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.LightCoral;
            this.label3.Location = new System.Drawing.Point(28, 342);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(97, 36);
            this.label3.TabIndex = 30;
            this.label3.Text = "Marca";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.LightCoral;
            this.label2.Location = new System.Drawing.Point(28, 276);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(114, 36);
            this.label2.TabIndex = 29;
            this.label2.Text = "Modelo";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // CrearVehículo
            // 
            this.CrearVehículo.BackColor = System.Drawing.Color.LightBlue;
            this.CrearVehículo.Font = new System.Drawing.Font("Futura Md BT", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CrearVehículo.Location = new System.Drawing.Point(434, 536);
            this.CrearVehículo.Name = "CrearVehículo";
            this.CrearVehículo.Size = new System.Drawing.Size(340, 80);
            this.CrearVehículo.TabIndex = 28;
            this.CrearVehículo.Text = "Crear";
            this.CrearVehículo.UseVisualStyleBackColor = false;
            this.CrearVehículo.Click += new System.EventHandler(this.CrearVehículo_Click);
            // 
            // RegresarPrincipal
            // 
            this.RegresarPrincipal.BackColor = System.Drawing.Color.CadetBlue;
            this.RegresarPrincipal.Font = new System.Drawing.Font("Futura Md BT", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.RegresarPrincipal.Location = new System.Drawing.Point(71, 536);
            this.RegresarPrincipal.Name = "RegresarPrincipal";
            this.RegresarPrincipal.Size = new System.Drawing.Size(340, 80);
            this.RegresarPrincipal.TabIndex = 27;
            this.RegresarPrincipal.Text = "Regresar a Principal";
            this.RegresarPrincipal.UseVisualStyleBackColor = false;
            this.RegresarPrincipal.Click += new System.EventHandler(this.RegresarPrincipal_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Futura Md BT", 25.8F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.IndianRed;
            this.label1.Location = new System.Drawing.Point(100, 95);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(630, 51);
            this.label1.TabIndex = 26;
            this.label1.Text = "Ingresa los datos de la Bicicleta";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // TbIDBicicleta
            // 
            this.TbIDBicicleta.Font = new System.Drawing.Font("Futura Bk BT", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TbIDBicicleta.Location = new System.Drawing.Point(371, 204);
            this.TbIDBicicleta.Name = "TbIDBicicleta";
            this.TbIDBicicleta.Size = new System.Drawing.Size(504, 40);
            this.TbIDBicicleta.TabIndex = 38;
            this.TbIDBicicleta.TextChanged += new System.EventHandler(this.TbIDBicicleta_TextChanged);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.LightCoral;
            this.label6.Location = new System.Drawing.Point(28, 218);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(163, 36);
            this.label6.TabIndex = 37;
            this.label6.Text = "ID Bicicleta";
            // 
            // AgregarBici
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(929, 697);
            this.Controls.Add(this.TbIDBicicleta);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.TbTipo);
            this.Controls.Add(this.TbAño);
            this.Controls.Add(this.TbModelo);
            this.Controls.Add(this.TbMarca);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.CrearVehículo);
            this.Controls.Add(this.RegresarPrincipal);
            this.Controls.Add(this.label1);
            this.Name = "AgregarBici";
            this.Load += new System.EventHandler(this.AgregarBici_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox TbTipo;
        private System.Windows.Forms.TextBox TbAño;
        private System.Windows.Forms.TextBox TbModelo;
        private System.Windows.Forms.TextBox TbMarca;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button CrearVehículo;
        private System.Windows.Forms.Button RegresarPrincipal;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox TbIDBicicleta;
        private System.Windows.Forms.Label label6;
    }
}