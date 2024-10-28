namespace POO_EP2_PSAM
{
    partial class MenuAgregarVehiculo
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
            this.RegresarPrincipal = new System.Windows.Forms.Button();
            this.btnAgregarBici = new System.Windows.Forms.Button();
            this.btnAgregarMoto = new System.Windows.Forms.Button();
            this.btnAgregarAuto = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // RegresarPrincipal
            // 
            this.RegresarPrincipal.BackColor = System.Drawing.Color.CadetBlue;
            this.RegresarPrincipal.Font = new System.Drawing.Font("Futura Md BT", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.RegresarPrincipal.Location = new System.Drawing.Point(319, 501);
            this.RegresarPrincipal.Name = "RegresarPrincipal";
            this.RegresarPrincipal.Size = new System.Drawing.Size(340, 80);
            this.RegresarPrincipal.TabIndex = 11;
            this.RegresarPrincipal.Text = "Regresar a Principal";
            this.RegresarPrincipal.UseVisualStyleBackColor = false;
            this.RegresarPrincipal.Click += new System.EventHandler(this.RegresarPrincipal_Click);
            // 
            // btnAgregarBici
            // 
            this.btnAgregarBici.Font = new System.Drawing.Font("Futura Md BT", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAgregarBici.ForeColor = System.Drawing.Color.DarkSlateGray;
            this.btnAgregarBici.Location = new System.Drawing.Point(319, 415);
            this.btnAgregarBici.Name = "btnAgregarBici";
            this.btnAgregarBici.Size = new System.Drawing.Size(340, 80);
            this.btnAgregarBici.TabIndex = 10;
            this.btnAgregarBici.Text = "Bicicleta";
            this.btnAgregarBici.UseVisualStyleBackColor = true;
            this.btnAgregarBici.Click += new System.EventHandler(this.btnAgregarBici_Click);
            // 
            // btnAgregarMoto
            // 
            this.btnAgregarMoto.Font = new System.Drawing.Font("Futura Md BT", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAgregarMoto.ForeColor = System.Drawing.Color.DarkSlateGray;
            this.btnAgregarMoto.Location = new System.Drawing.Point(319, 329);
            this.btnAgregarMoto.Name = "btnAgregarMoto";
            this.btnAgregarMoto.Size = new System.Drawing.Size(340, 80);
            this.btnAgregarMoto.TabIndex = 9;
            this.btnAgregarMoto.Text = "Motocicleta";
            this.btnAgregarMoto.UseVisualStyleBackColor = true;
            this.btnAgregarMoto.Click += new System.EventHandler(this.btnAgregarMoto_Click);
            // 
            // btnAgregarAuto
            // 
            this.btnAgregarAuto.Font = new System.Drawing.Font("Futura Md BT", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAgregarAuto.ForeColor = System.Drawing.Color.DarkSlateGray;
            this.btnAgregarAuto.Location = new System.Drawing.Point(319, 243);
            this.btnAgregarAuto.Name = "btnAgregarAuto";
            this.btnAgregarAuto.Size = new System.Drawing.Size(340, 80);
            this.btnAgregarAuto.TabIndex = 8;
            this.btnAgregarAuto.Text = "Auto";
            this.btnAgregarAuto.UseVisualStyleBackColor = true;
            this.btnAgregarAuto.Click += new System.EventHandler(this.btnAgregarAuto_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Futura Md BT", 36F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.IndianRed;
            this.label1.Location = new System.Drawing.Point(184, 110);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(625, 72);
            this.label1.TabIndex = 6;
            this.label1.Text = "Selecciona el Vehículo";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // MenuAgregarVehiculo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(989, 725);
            this.Controls.Add(this.RegresarPrincipal);
            this.Controls.Add(this.btnAgregarBici);
            this.Controls.Add(this.btnAgregarMoto);
            this.Controls.Add(this.btnAgregarAuto);
            this.Controls.Add(this.label1);
            this.Name = "MenuAgregarVehiculo";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "MenuAgregarVehiculo";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button RegresarPrincipal;
        private System.Windows.Forms.Button btnAgregarBici;
        private System.Windows.Forms.Button btnAgregarMoto;
        private System.Windows.Forms.Button btnAgregarAuto;
        private System.Windows.Forms.Label label1;
    }
}