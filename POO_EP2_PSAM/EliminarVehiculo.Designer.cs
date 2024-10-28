namespace POO_EP2_PSAM
{
    partial class EliminarVehiculo
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
            this.TbIDVehiculo = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.BtnEliminarVehiculo = new System.Windows.Forms.Button();
            this.RegresarPrincipal = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // TbIDVehiculo
            // 
            this.TbIDVehiculo.Font = new System.Drawing.Font("Futura Bk BT", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TbIDVehiculo.Location = new System.Drawing.Point(292, 225);
            this.TbIDVehiculo.Name = "TbIDVehiculo";
            this.TbIDVehiculo.Size = new System.Drawing.Size(347, 40);
            this.TbIDVehiculo.TabIndex = 34;
            this.TbIDVehiculo.TextChanged += new System.EventHandler(this.TbIDVehiculo_TextChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.LightCoral;
            this.label2.Location = new System.Drawing.Point(76, 229);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(169, 36);
            this.label2.TabIndex = 29;
            this.label2.Text = "ID Vehículo";
            // 
            // BtnEliminarVehiculo
            // 
            this.BtnEliminarVehiculo.BackColor = System.Drawing.Color.LightBlue;
            this.BtnEliminarVehiculo.Font = new System.Drawing.Font("Futura Md BT", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnEliminarVehiculo.Location = new System.Drawing.Point(418, 509);
            this.BtnEliminarVehiculo.Name = "BtnEliminarVehiculo";
            this.BtnEliminarVehiculo.Size = new System.Drawing.Size(340, 80);
            this.BtnEliminarVehiculo.TabIndex = 28;
            this.BtnEliminarVehiculo.Text = "Eliminar";
            this.BtnEliminarVehiculo.UseVisualStyleBackColor = false;
            this.BtnEliminarVehiculo.Click += new System.EventHandler(this.BtnEliminarVehiculo_Click);
            // 
            // RegresarPrincipal
            // 
            this.RegresarPrincipal.BackColor = System.Drawing.Color.CadetBlue;
            this.RegresarPrincipal.Font = new System.Drawing.Font("Futura Md BT", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.RegresarPrincipal.Location = new System.Drawing.Point(55, 509);
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
            this.label1.Location = new System.Drawing.Point(46, 77);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(807, 51);
            this.label1.TabIndex = 26;
            this.label1.Text = "Ingresa los datos del Vehículo a Eliminar";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // EliminarVehiculo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(907, 678);
            this.Controls.Add(this.TbIDVehiculo);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.BtnEliminarVehiculo);
            this.Controls.Add(this.RegresarPrincipal);
            this.Controls.Add(this.label1);
            this.Name = "EliminarVehiculo";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "EliminarVehiculo";
            this.Load += new System.EventHandler(this.EliminarVehiculo_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TextBox TbIDVehiculo;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button BtnEliminarVehiculo;
        private System.Windows.Forms.Button RegresarPrincipal;
        private System.Windows.Forms.Label label1;
    }
}