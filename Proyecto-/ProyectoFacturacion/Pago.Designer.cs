
namespace ProyectoFacturacion
{
    partial class Pago
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Pago));
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.TxtMonto = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.TxtPlazo = new System.Windows.Forms.TextBox();
            this.TxtCodCliente = new System.Windows.Forms.TextBox();
            this.btnguardar1 = new System.Windows.Forms.Button();
            this.btnPago = new System.Windows.Forms.Button();
            this.btnRegresar4 = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.TxtCodPago = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.cbxPago = new System.Windows.Forms.ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.Window;
            this.label1.Location = new System.Drawing.Point(68, 229);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(128, 21);
            this.label1.TabIndex = 0;
            this.label1.Text = "Tipo de pago:";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.SystemColors.Window;
            this.label2.Location = new System.Drawing.Point(61, 307);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(71, 21);
            this.label2.TabIndex = 7;
            this.label2.Text = "Monto:";
            // 
            // TxtMonto
            // 
            this.TxtMonto.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(94)))), ((int)(((byte)(129)))));
            this.TxtMonto.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.TxtMonto.ForeColor = System.Drawing.SystemColors.Window;
            this.TxtMonto.Location = new System.Drawing.Point(65, 338);
            this.TxtMonto.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.TxtMonto.Name = "TxtMonto";
            this.TxtMonto.Size = new System.Drawing.Size(405, 22);
            this.TxtMonto.TabIndex = 8;
            this.TxtMonto.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.SystemColors.Window;
            this.label3.Location = new System.Drawing.Point(60, 92);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(116, 21);
            this.label3.TabIndex = 9;
            this.label3.Text = "Cod Cliente:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Century Gothic", 23.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.SystemColors.Window;
            this.label4.Location = new System.Drawing.Point(193, 11);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(444, 45);
            this.label4.TabIndex = 11;
            this.label4.Text = "Condiciones de pago ";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.SystemColors.Window;
            this.label5.Location = new System.Drawing.Point(61, 380);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(137, 21);
            this.label5.TabIndex = 12;
            this.label5.Text = "Plazo de pago:";
            // 
            // TxtPlazo
            // 
            this.TxtPlazo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(94)))), ((int)(((byte)(129)))));
            this.TxtPlazo.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.TxtPlazo.ForeColor = System.Drawing.SystemColors.Window;
            this.TxtPlazo.Location = new System.Drawing.Point(65, 403);
            this.TxtPlazo.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.TxtPlazo.Name = "TxtPlazo";
            this.TxtPlazo.Size = new System.Drawing.Size(405, 22);
            this.TxtPlazo.TabIndex = 13;
            this.TxtPlazo.TextChanged += new System.EventHandler(this.TxtPlazo_TextChanged);
            // 
            // TxtCodCliente
            // 
            this.TxtCodCliente.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(94)))), ((int)(((byte)(129)))));
            this.TxtCodCliente.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.TxtCodCliente.ForeColor = System.Drawing.SystemColors.Window;
            this.TxtCodCliente.Location = new System.Drawing.Point(65, 121);
            this.TxtCodCliente.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.TxtCodCliente.Name = "TxtCodCliente";
            this.TxtCodCliente.Size = new System.Drawing.Size(405, 22);
            this.TxtCodCliente.TabIndex = 14;
            this.TxtCodCliente.TextChanged += new System.EventHandler(this.TxtCodCliente_TextChanged);
            // 
            // btnguardar1
            // 
            this.btnguardar1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(97)))), ((int)(((byte)(238)))));
            this.btnguardar1.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnguardar1.ForeColor = System.Drawing.SystemColors.Window;
            this.btnguardar1.Location = new System.Drawing.Point(27, 481);
            this.btnguardar1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnguardar1.Name = "btnguardar1";
            this.btnguardar1.Size = new System.Drawing.Size(477, 57);
            this.btnguardar1.TabIndex = 37;
            this.btnguardar1.Text = "Guardar";
            this.btnguardar1.UseVisualStyleBackColor = false;
            this.btnguardar1.Click += new System.EventHandler(this.btnguardar1_Click);
            // 
            // btnPago
            // 
            this.btnPago.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(97)))), ((int)(((byte)(238)))));
            this.btnPago.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPago.ForeColor = System.Drawing.SystemColors.Window;
            this.btnPago.Location = new System.Drawing.Point(590, 381);
            this.btnPago.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnPago.Name = "btnPago";
            this.btnPago.Size = new System.Drawing.Size(151, 44);
            this.btnPago.TabIndex = 36;
            this.btnPago.Text = "Ver";
            this.btnPago.UseVisualStyleBackColor = false;
            this.btnPago.Click += new System.EventHandler(this.btnPago_Click);
            // 
            // btnRegresar4
            // 
            this.btnRegresar4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(97)))), ((int)(((byte)(238)))));
            this.btnRegresar4.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRegresar4.ForeColor = System.Drawing.SystemColors.Window;
            this.btnRegresar4.Location = new System.Drawing.Point(660, 539);
            this.btnRegresar4.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnRegresar4.Name = "btnRegresar4";
            this.btnRegresar4.Size = new System.Drawing.Size(165, 39);
            this.btnRegresar4.TabIndex = 35;
            this.btnRegresar4.Text = "Regresar";
            this.btnRegresar4.UseVisualStyleBackColor = false;
            this.btnRegresar4.Click += new System.EventHandler(this.btnRegresar4_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.SystemColors.Window;
            this.label6.Location = new System.Drawing.Point(489, 338);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(339, 23);
            this.label6.TabIndex = 38;
            this.label6.Text = "¿Visualizar condiciones de pago?";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(539, 92);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(221, 210);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 39;
            this.pictureBox1.TabStop = false;
            // 
            // TxtCodPago
            // 
            this.TxtCodPago.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(94)))), ((int)(((byte)(129)))));
            this.TxtCodPago.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.TxtCodPago.ForeColor = System.Drawing.SystemColors.Window;
            this.TxtCodPago.Location = new System.Drawing.Point(65, 182);
            this.TxtCodPago.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.TxtCodPago.Name = "TxtCodPago";
            this.TxtCodPago.Size = new System.Drawing.Size(405, 22);
            this.TxtCodPago.TabIndex = 41;
            this.TxtCodPago.TextChanged += new System.EventHandler(this.TxtCodPago_TextChanged);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.SystemColors.Window;
            this.label7.Location = new System.Drawing.Point(60, 154);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(156, 21);
            this.label7.TabIndex = 40;
            this.label7.Text = "Codigo de pago:";
            this.label7.Click += new System.EventHandler(this.label7_Click);
            // 
            // cbxPago
            // 
            this.cbxPago.FormattingEnabled = true;
            this.cbxPago.Location = new System.Drawing.Point(65, 262);
            this.cbxPago.Name = "cbxPago";
            this.cbxPago.Size = new System.Drawing.Size(405, 24);
            this.cbxPago.TabIndex = 42;
            this.cbxPago.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // Pago
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(59)))), ((int)(((byte)(104)))));
            this.ClientSize = new System.Drawing.Size(840, 593);
            this.Controls.Add(this.cbxPago);
            this.Controls.Add(this.TxtCodPago);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.btnguardar1);
            this.Controls.Add(this.btnPago);
            this.Controls.Add(this.btnRegresar4);
            this.Controls.Add(this.TxtCodCliente);
            this.Controls.Add(this.TxtPlazo);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.TxtMonto);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "Pago";
            this.Text = "Pago";
            this.Load += new System.EventHandler(this.Pago_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox TxtMonto;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox TxtPlazo;
        private System.Windows.Forms.TextBox TxtCodCliente;
        private System.Windows.Forms.Button btnguardar1;
        private System.Windows.Forms.Button btnPago;
        private System.Windows.Forms.Button btnRegresar4;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.TextBox TxtCodPago;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.ComboBox cbxPago;
    }
}