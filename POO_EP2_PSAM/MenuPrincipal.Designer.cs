namespace POO_EP2_PSAM
{
    partial class MenuPrincipal
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
            this.label1 = new System.Windows.Forms.Label();
            this.btnAgregarVehiculo = new System.Windows.Forms.Button();
            this.btnEliminarVehiculo = new System.Windows.Forms.Button();
            this.btnMostrarVehiculos = new System.Windows.Forms.Button();
            this.btnActualizarVehiculo = new System.Windows.Forms.Button();
            this.button5 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Futura Md BT", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.IndianRed;
            this.label1.Location = new System.Drawing.Point(118, 66);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(706, 72);
            this.label1.TabIndex = 0;
            this.label1.Text = "Cátalogo de Vehículos";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btnAgregarVehiculo
            // 
            this.btnAgregarVehiculo.Font = new System.Drawing.Font("Futura Md BT", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAgregarVehiculo.ForeColor = System.Drawing.Color.DarkSlateGray;
            this.btnAgregarVehiculo.Location = new System.Drawing.Point(312, 210);
            this.btnAgregarVehiculo.Name = "btnAgregarVehiculo";
            this.btnAgregarVehiculo.Size = new System.Drawing.Size(340, 80);
            this.btnAgregarVehiculo.TabIndex = 1;
            this.btnAgregarVehiculo.Text = "Agregar Vehículo";
            this.btnAgregarVehiculo.UseVisualStyleBackColor = true;
            this.btnAgregarVehiculo.Click += new System.EventHandler(this.button1_Click);
            // 
            // btnEliminarVehiculo
            // 
            this.btnEliminarVehiculo.Font = new System.Drawing.Font("Futura Md BT", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEliminarVehiculo.ForeColor = System.Drawing.Color.DarkSlateGray;
            this.btnEliminarVehiculo.Location = new System.Drawing.Point(312, 296);
            this.btnEliminarVehiculo.Name = "btnEliminarVehiculo";
            this.btnEliminarVehiculo.Size = new System.Drawing.Size(340, 80);
            this.btnEliminarVehiculo.TabIndex = 2;
            this.btnEliminarVehiculo.Text = "Eliminar Vehículo";
            this.btnEliminarVehiculo.UseVisualStyleBackColor = true;
            this.btnEliminarVehiculo.Click += new System.EventHandler(this.button2_Click);
            // 
            // btnMostrarVehiculos
            // 
            this.btnMostrarVehiculos.Font = new System.Drawing.Font("Futura Md BT", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnMostrarVehiculos.ForeColor = System.Drawing.Color.DarkSlateGray;
            this.btnMostrarVehiculos.Location = new System.Drawing.Point(312, 382);
            this.btnMostrarVehiculos.Name = "btnMostrarVehiculos";
            this.btnMostrarVehiculos.Size = new System.Drawing.Size(340, 80);
            this.btnMostrarVehiculos.TabIndex = 3;
            this.btnMostrarVehiculos.Text = "Mostrar lista de Vehículos";
            this.btnMostrarVehiculos.UseVisualStyleBackColor = true;
            this.btnMostrarVehiculos.Click += new System.EventHandler(this.button3_Click);
            // 
            // btnActualizarVehiculo
            // 
            this.btnActualizarVehiculo.Font = new System.Drawing.Font("Futura Md BT", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnActualizarVehiculo.ForeColor = System.Drawing.Color.DarkSlateGray;
            this.btnActualizarVehiculo.Location = new System.Drawing.Point(312, 468);
            this.btnActualizarVehiculo.Name = "btnActualizarVehiculo";
            this.btnActualizarVehiculo.Size = new System.Drawing.Size(340, 80);
            this.btnActualizarVehiculo.TabIndex = 4;
            this.btnActualizarVehiculo.Text = "Actualizar Información de un Vehículo";
            this.btnActualizarVehiculo.UseVisualStyleBackColor = true;
            this.btnActualizarVehiculo.Click += new System.EventHandler(this.button4_Click);
            // 
            // button5
            // 
            this.button5.BackColor = System.Drawing.Color.CadetBlue;
            this.button5.Font = new System.Drawing.Font("Futura Md BT", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button5.Location = new System.Drawing.Point(312, 554);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(340, 80);
            this.button5.TabIndex = 5;
            this.button5.Text = "Salir\r\n";
            this.button5.UseVisualStyleBackColor = false;
            this.button5.Click += new System.EventHandler(this.button5_Click);
            // 
            // MenuPrincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(980, 727);
            this.Controls.Add(this.button5);
            this.Controls.Add(this.btnActualizarVehiculo);
            this.Controls.Add(this.btnMostrarVehiculos);
            this.Controls.Add(this.btnEliminarVehiculo);
            this.Controls.Add(this.btnAgregarVehiculo);
            this.Controls.Add(this.label1);
            this.Name = "MenuPrincipal";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnAgregarVehiculo;
        private System.Windows.Forms.Button btnEliminarVehiculo;
        private System.Windows.Forms.Button btnMostrarVehiculos;
        private System.Windows.Forms.Button btnActualizarVehiculo;
        private System.Windows.Forms.Button button5;
    }
}

