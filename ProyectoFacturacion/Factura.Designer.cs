
namespace ProyectoFacturacion
{
    partial class Factura
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Factura));
            this.TxtNum = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.TxtIdEmp = new System.Windows.Forms.TextBox();
            this.TxtCant = new System.Windows.Forms.TextBox();
            this.TxtIdArti = new System.Windows.Forms.TextBox();
            this.TxtComent = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.dtpFecha = new System.Windows.Forms.DateTimePicker();
            this.TxtPrecio = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.btnguardar3 = new System.Windows.Forms.Button();
            this.btnFactu = new System.Windows.Forms.Button();
            this.btnRegresar5 = new System.Windows.Forms.Button();
            this.btnFormaPa = new System.Windows.Forms.Button();
            this.label8 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.cbxPago = new System.Windows.Forms.ComboBox();
            this.txtIdCliente = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // TxtNum
            // 
            this.TxtNum.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(94)))), ((int)(((byte)(129)))));
            this.TxtNum.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.TxtNum.ForeColor = System.Drawing.SystemColors.Window;
            this.TxtNum.Location = new System.Drawing.Point(47, 126);
            this.TxtNum.Margin = new System.Windows.Forms.Padding(4);
            this.TxtNum.Name = "TxtNum";
            this.TxtNum.Size = new System.Drawing.Size(405, 22);
            this.TxtNum.TabIndex = 51;
            this.TxtNum.TextChanged += new System.EventHandler(this.TxtNum_TextChanged);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.ForeColor = System.Drawing.SystemColors.Window;
            this.label9.Location = new System.Drawing.Point(43, 101);
            this.label9.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(128, 21);
            this.label9.TabIndex = 50;
            this.label9.Text = "Num. Factura:";
            // 
            // TxtIdEmp
            // 
            this.TxtIdEmp.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(94)))), ((int)(((byte)(129)))));
            this.TxtIdEmp.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.TxtIdEmp.ForeColor = System.Drawing.SystemColors.Window;
            this.TxtIdEmp.Location = new System.Drawing.Point(47, 219);
            this.TxtIdEmp.Margin = new System.Windows.Forms.Padding(4);
            this.TxtIdEmp.Name = "TxtIdEmp";
            this.TxtIdEmp.Size = new System.Drawing.Size(405, 22);
            this.TxtIdEmp.TabIndex = 49;
            this.TxtIdEmp.TextChanged += new System.EventHandler(this.TxtIdEmp_TextChanged);
            // 
            // TxtCant
            // 
            this.TxtCant.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(94)))), ((int)(((byte)(129)))));
            this.TxtCant.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.TxtCant.ForeColor = System.Drawing.SystemColors.Window;
            this.TxtCant.Location = new System.Drawing.Point(52, 528);
            this.TxtCant.Margin = new System.Windows.Forms.Padding(4);
            this.TxtCant.Name = "TxtCant";
            this.TxtCant.Size = new System.Drawing.Size(405, 22);
            this.TxtCant.TabIndex = 48;
            this.TxtCant.TextChanged += new System.EventHandler(this.TxtCant_TextChanged);
            // 
            // TxtIdArti
            // 
            this.TxtIdArti.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(94)))), ((int)(((byte)(129)))));
            this.TxtIdArti.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.TxtIdArti.ForeColor = System.Drawing.SystemColors.Window;
            this.TxtIdArti.Location = new System.Drawing.Point(47, 283);
            this.TxtIdArti.Margin = new System.Windows.Forms.Padding(4);
            this.TxtIdArti.Name = "TxtIdArti";
            this.TxtIdArti.Size = new System.Drawing.Size(405, 22);
            this.TxtIdArti.TabIndex = 47;
            this.TxtIdArti.TextChanged += new System.EventHandler(this.textBox4_TextChanged);
            // 
            // TxtComent
            // 
            this.TxtComent.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(94)))), ((int)(((byte)(129)))));
            this.TxtComent.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.TxtComent.ForeColor = System.Drawing.SystemColors.Window;
            this.TxtComent.Location = new System.Drawing.Point(47, 348);
            this.TxtComent.Margin = new System.Windows.Forms.Padding(4);
            this.TxtComent.Multiline = true;
            this.TxtComent.Name = "TxtComent";
            this.TxtComent.Size = new System.Drawing.Size(403, 89);
            this.TxtComent.TabIndex = 46;
            this.TxtComent.TextChanged += new System.EventHandler(this.textBox3_TextChanged);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.SystemColors.Window;
            this.label6.Location = new System.Drawing.Point(46, 503);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(97, 21);
            this.label6.TabIndex = 44;
            this.label6.Text = "Cantidad:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.SystemColors.Window;
            this.label5.Location = new System.Drawing.Point(46, 461);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(67, 21);
            this.label5.TabIndex = 43;
            this.label5.Text = "Fecha:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.SystemColors.Window;
            this.label4.Location = new System.Drawing.Point(43, 324);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(114, 21);
            this.label4.TabIndex = 42;
            this.label4.Text = "Comentario:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.SystemColors.Window;
            this.label3.Location = new System.Drawing.Point(43, 258);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(100, 21);
            this.label3.TabIndex = 41;
            this.label3.Text = "Id Articulo:";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.SystemColors.Window;
            this.label2.Location = new System.Drawing.Point(43, 194);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(122, 21);
            this.label2.TabIndex = 40;
            this.label2.Text = "Id Empleado:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.Window;
            this.label1.Location = new System.Drawing.Point(43, 162);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(150, 21);
            this.label1.TabIndex = 38;
            this.label1.Text = "Forma de pago: ";
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(61, 4);
            // 
            // dtpFecha
            // 
            this.dtpFecha.Location = new System.Drawing.Point(133, 460);
            this.dtpFecha.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dtpFecha.Name = "dtpFecha";
            this.dtpFecha.Size = new System.Drawing.Size(324, 22);
            this.dtpFecha.TabIndex = 56;
            this.dtpFecha.ValueChanged += new System.EventHandler(this.dtpFecha_ValueChanged);
            // 
            // TxtPrecio
            // 
            this.TxtPrecio.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(94)))), ((int)(((byte)(129)))));
            this.TxtPrecio.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.TxtPrecio.ForeColor = System.Drawing.SystemColors.Window;
            this.TxtPrecio.Location = new System.Drawing.Point(50, 581);
            this.TxtPrecio.Margin = new System.Windows.Forms.Padding(4);
            this.TxtPrecio.Name = "TxtPrecio";
            this.TxtPrecio.Size = new System.Drawing.Size(405, 22);
            this.TxtPrecio.TabIndex = 58;
            this.TxtPrecio.TextChanged += new System.EventHandler(this.TxtPrecio_TextChanged);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.SystemColors.Window;
            this.label7.Location = new System.Drawing.Point(48, 556);
            this.label7.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(134, 21);
            this.label7.TabIndex = 57;
            this.label7.Text = "Precio Unitario:";
            // 
            // btnguardar3
            // 
            this.btnguardar3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(97)))), ((int)(((byte)(238)))));
            this.btnguardar3.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnguardar3.ForeColor = System.Drawing.SystemColors.Window;
            this.btnguardar3.Location = new System.Drawing.Point(38, 699);
            this.btnguardar3.Margin = new System.Windows.Forms.Padding(4);
            this.btnguardar3.Name = "btnguardar3";
            this.btnguardar3.Size = new System.Drawing.Size(360, 57);
            this.btnguardar3.TabIndex = 61;
            this.btnguardar3.Text = "Guardar";
            this.btnguardar3.UseVisualStyleBackColor = false;
            this.btnguardar3.Click += new System.EventHandler(this.btnguardar3_Click);
            // 
            // btnFactu
            // 
            this.btnFactu.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(97)))), ((int)(((byte)(238)))));
            this.btnFactu.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnFactu.ForeColor = System.Drawing.SystemColors.Window;
            this.btnFactu.Location = new System.Drawing.Point(625, 406);
            this.btnFactu.Margin = new System.Windows.Forms.Padding(4);
            this.btnFactu.Name = "btnFactu";
            this.btnFactu.Size = new System.Drawing.Size(151, 44);
            this.btnFactu.TabIndex = 60;
            this.btnFactu.Text = "Ver";
            this.btnFactu.UseVisualStyleBackColor = false;
            this.btnFactu.Click += new System.EventHandler(this.btnFactu_Click);
            // 
            // btnRegresar5
            // 
            this.btnRegresar5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(97)))), ((int)(((byte)(238)))));
            this.btnRegresar5.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRegresar5.ForeColor = System.Drawing.SystemColors.Window;
            this.btnRegresar5.Location = new System.Drawing.Point(774, 699);
            this.btnRegresar5.Margin = new System.Windows.Forms.Padding(4);
            this.btnRegresar5.Name = "btnRegresar5";
            this.btnRegresar5.Size = new System.Drawing.Size(201, 48);
            this.btnRegresar5.TabIndex = 59;
            this.btnRegresar5.Text = "Regresar";
            this.btnRegresar5.UseVisualStyleBackColor = false;
            this.btnRegresar5.Click += new System.EventHandler(this.btnRegresar5_Click);
            // 
            // btnFormaPa
            // 
            this.btnFormaPa.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(97)))), ((int)(((byte)(238)))));
            this.btnFormaPa.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnFormaPa.ForeColor = System.Drawing.SystemColors.Window;
            this.btnFormaPa.Location = new System.Drawing.Point(458, 699);
            this.btnFormaPa.Margin = new System.Windows.Forms.Padding(4);
            this.btnFormaPa.Name = "btnFormaPa";
            this.btnFormaPa.Size = new System.Drawing.Size(209, 57);
            this.btnFormaPa.TabIndex = 62;
            this.btnFormaPa.Text = "Forma de pago ";
            this.btnFormaPa.UseVisualStyleBackColor = false;
            this.btnFormaPa.Click += new System.EventHandler(this.btnFormaPa_Click);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Century Gothic", 23.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.SystemColors.Window;
            this.label8.Location = new System.Drawing.Point(276, 11);
            this.label8.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(322, 45);
            this.label8.TabIndex = 63;
            this.label8.Text = "Generar factura";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.ForeColor = System.Drawing.SystemColors.Window;
            this.label10.Location = new System.Drawing.Point(567, 374);
            this.label10.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(243, 30);
            this.label10.TabIndex = 64;
            this.label10.Text = "¿Visualizar factura?";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(572, 108);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(225, 236);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 65;
            this.pictureBox1.TabStop = false;
            // 
            // cbxPago
            // 
            this.cbxPago.FormattingEnabled = true;
            this.cbxPago.Location = new System.Drawing.Point(200, 163);
            this.cbxPago.Name = "cbxPago";
            this.cbxPago.Size = new System.Drawing.Size(250, 24);
            this.cbxPago.TabIndex = 66;
            this.cbxPago.SelectedIndexChanged += new System.EventHandler(this.cbxPago_SelectedIndexChanged);
            // 
            // txtIdCliente
            // 
            this.txtIdCliente.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(94)))), ((int)(((byte)(129)))));
            this.txtIdCliente.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtIdCliente.ForeColor = System.Drawing.SystemColors.Window;
            this.txtIdCliente.Location = new System.Drawing.Point(50, 645);
            this.txtIdCliente.Margin = new System.Windows.Forms.Padding(4);
            this.txtIdCliente.Name = "txtIdCliente";
            this.txtIdCliente.Size = new System.Drawing.Size(405, 22);
            this.txtIdCliente.TabIndex = 68;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.ForeColor = System.Drawing.SystemColors.Window;
            this.label11.Location = new System.Drawing.Point(48, 620);
            this.label11.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(124, 21);
            this.label11.TabIndex = 67;
            this.label11.Text = "Id del cliente:";
            // 
            // Factura
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(59)))), ((int)(((byte)(104)))));
            this.ClientSize = new System.Drawing.Size(1155, 816);
            this.Controls.Add(this.txtIdCliente);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.cbxPago);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.btnFormaPa);
            this.Controls.Add(this.btnguardar3);
            this.Controls.Add(this.btnFactu);
            this.Controls.Add(this.btnRegresar5);
            this.Controls.Add(this.TxtPrecio);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.dtpFecha);
            this.Controls.Add(this.TxtNum);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.TxtIdEmp);
            this.Controls.Add(this.TxtCant);
            this.Controls.Add(this.TxtIdArti);
            this.Controls.Add(this.TxtComent);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "Factura";
            this.Load += new System.EventHandler(this.Factura_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox TxtNum;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox TxtIdEmp;
        private System.Windows.Forms.TextBox TxtCant;
        private System.Windows.Forms.TextBox TxtIdArti;
        private System.Windows.Forms.TextBox TxtComent;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.DateTimePicker dtpFecha;
        private System.Windows.Forms.TextBox TxtPrecio;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button btnguardar3;
        private System.Windows.Forms.Button btnFactu;
        private System.Windows.Forms.Button btnRegresar5;
        private System.Windows.Forms.Button btnFormaPa;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.ComboBox cbxPago;
        private System.Windows.Forms.TextBox txtIdCliente;
        private System.Windows.Forms.Label label11;
    }
}