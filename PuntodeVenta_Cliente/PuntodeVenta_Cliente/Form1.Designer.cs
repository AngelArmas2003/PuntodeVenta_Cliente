
namespace PuntodeVenta_Cliente
{
    partial class Form1
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.button1 = new System.Windows.Forms.Button();
            this.txtBoleto = new System.Windows.Forms.TextBox();
            this.txtTerminal = new System.Windows.Forms.TextBox();
            this.txtTranaccion = new System.Windows.Forms.TextBox();
            this.txtTienda = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.txtJsonConsulta = new System.Windows.Forms.TextBox();
            this.button2 = new System.Windows.Forms.Button();
            this.txtValidacion = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.RbIdBoletoOK = new System.Windows.Forms.RadioButton();
            this.radioButton2 = new System.Windows.Forms.RadioButton();
            this.radioButton3 = new System.Windows.Forms.RadioButton();
            this.radioButton4 = new System.Windows.Forms.RadioButton();
            this.radioButton5 = new System.Windows.Forms.RadioButton();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.textBox4 = new System.Windows.Forms.TextBox();
            this.textBox5 = new System.Windows.Forms.TextBox();
            this.textBox6 = new System.Windows.Forms.TextBox();
            this.radioButton1 = new System.Windows.Forms.RadioButton();
            this.button3 = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.button4 = new System.Windows.Forms.Button();
            this.txtReversoRequest = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.button5 = new System.Windows.Forms.Button();
            this.label8 = new System.Windows.Forms.Label();
            this.button6 = new System.Windows.Forms.Button();
            this.textBox7 = new System.Windows.Forms.TextBox();
            this.button7 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(301, 55);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(85, 81);
            this.button1.TabIndex = 0;
            this.button1.Text = "Arma Json Consulta";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // txtBoleto
            // 
            this.txtBoleto.Location = new System.Drawing.Point(90, 60);
            this.txtBoleto.Name = "txtBoleto";
            this.txtBoleto.Size = new System.Drawing.Size(155, 20);
            this.txtBoleto.TabIndex = 1;
            this.txtBoleto.Text = "12012622142030557234";
            // 
            // txtTerminal
            // 
            this.txtTerminal.Location = new System.Drawing.Point(90, 94);
            this.txtTerminal.Name = "txtTerminal";
            this.txtTerminal.Size = new System.Drawing.Size(155, 20);
            this.txtTerminal.TabIndex = 2;
            this.txtTerminal.Text = "001";
            // 
            // txtTranaccion
            // 
            this.txtTranaccion.Location = new System.Drawing.Point(90, 123);
            this.txtTranaccion.Name = "txtTranaccion";
            this.txtTranaccion.Size = new System.Drawing.Size(155, 20);
            this.txtTranaccion.TabIndex = 3;
            this.txtTranaccion.Text = "00001";
            // 
            // txtTienda
            // 
            this.txtTienda.Location = new System.Drawing.Point(90, 155);
            this.txtTienda.Name = "txtTienda";
            this.txtTienda.Size = new System.Drawing.Size(155, 20);
            this.txtTienda.TabIndex = 4;
            this.txtTienda.Text = "5572";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(27, 64);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(46, 13);
            this.label1.TabIndex = 5;
            this.label1.Text = "IdBoleto";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(27, 94);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(47, 13);
            this.label2.TabIndex = 6;
            this.label2.Text = "Terminal";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(7, 123);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(66, 13);
            this.label3.TabIndex = 7;
            this.label3.Text = "Transaccion";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(33, 158);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(40, 13);
            this.label4.TabIndex = 8;
            this.label4.Text = "Tienda";
            this.label4.Click += new System.EventHandler(this.label4_Click);
            // 
            // txtJsonConsulta
            // 
            this.txtJsonConsulta.Location = new System.Drawing.Point(410, 39);
            this.txtJsonConsulta.Multiline = true;
            this.txtJsonConsulta.Name = "txtJsonConsulta";
            this.txtJsonConsulta.Size = new System.Drawing.Size(270, 100);
            this.txtJsonConsulta.TabIndex = 9;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(695, 45);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(126, 94);
            this.button2.TabIndex = 10;
            this.button2.Text = "Valida Json con Servicio Método : consultaBoletoRequest";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // txtValidacion
            // 
            this.txtValidacion.Location = new System.Drawing.Point(847, 36);
            this.txtValidacion.Multiline = true;
            this.txtValidacion.Name = "txtValidacion";
            this.txtValidacion.Size = new System.Drawing.Size(353, 107);
            this.txtValidacion.TabIndex = 11;
            this.txtValidacion.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(417, 23);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(173, 13);
            this.label5.TabIndex = 12;
            this.label5.Text = "Armar Json ConsultaBoletoRequest";
            // 
            // RbIdBoletoOK
            // 
            this.RbIdBoletoOK.AutoSize = true;
            this.RbIdBoletoOK.Location = new System.Drawing.Point(12, 300);
            this.RbIdBoletoOK.Name = "RbIdBoletoOK";
            this.RbIdBoletoOK.Size = new System.Drawing.Size(79, 17);
            this.RbIdBoletoOK.TabIndex = 13;
            this.RbIdBoletoOK.TabStop = true;
            this.RbIdBoletoOK.Text = "IdBoletoOK";
            this.RbIdBoletoOK.UseVisualStyleBackColor = true;
            this.RbIdBoletoOK.CheckedChanged += new System.EventHandler(this.RbIdBoletoOK_CheckedChanged);
            // 
            // radioButton2
            // 
            this.radioButton2.AutoSize = true;
            this.radioButton2.Location = new System.Drawing.Point(12, 409);
            this.radioButton2.Name = "radioButton2";
            this.radioButton2.Size = new System.Drawing.Size(113, 17);
            this.radioButton2.TabIndex = 14;
            this.radioButton2.TabStop = true;
            this.radioButton2.Text = "Determinante Error";
            this.radioButton2.UseVisualStyleBackColor = true;
            this.radioButton2.CheckedChanged += new System.EventHandler(this.radioButton2_CheckedChanged);
            // 
            // radioButton3
            // 
            this.radioButton3.AutoSize = true;
            this.radioButton3.Location = new System.Drawing.Point(12, 381);
            this.radioButton3.Name = "radioButton3";
            this.radioButton3.Size = new System.Drawing.Size(73, 17);
            this.radioButton3.TabIndex = 15;
            this.radioButton3.TabStop = true;
            this.radioButton3.Text = "Hora Error";
            this.radioButton3.UseVisualStyleBackColor = true;
            this.radioButton3.CheckedChanged += new System.EventHandler(this.radioButton3_CheckedChanged);
            // 
            // radioButton4
            // 
            this.radioButton4.AutoSize = true;
            this.radioButton4.Location = new System.Drawing.Point(12, 350);
            this.radioButton4.Name = "radioButton4";
            this.radioButton4.Size = new System.Drawing.Size(80, 17);
            this.radioButton4.TabIndex = 16;
            this.radioButton4.TabStop = true;
            this.radioButton4.Text = "Fecha Error";
            this.radioButton4.UseVisualStyleBackColor = true;
            this.radioButton4.CheckedChanged += new System.EventHandler(this.radioButton4_CheckedChanged);
            // 
            // radioButton5
            // 
            this.radioButton5.AutoSize = true;
            this.radioButton5.Location = new System.Drawing.Point(12, 323);
            this.radioButton5.Name = "radioButton5";
            this.radioButton5.Size = new System.Drawing.Size(101, 17);
            this.radioButton5.TabIndex = 17;
            this.radioButton5.TabStop = true;
            this.radioButton5.Text = "Proveedor  error";
            this.radioButton5.UseVisualStyleBackColor = true;
            this.radioButton5.CheckedChanged += new System.EventHandler(this.radioButton5_CheckedChanged);
            // 
            // textBox1
            // 
            this.textBox1.Enabled = false;
            this.textBox1.Location = new System.Drawing.Point(127, 297);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(155, 20);
            this.textBox1.TabIndex = 18;
            this.textBox1.Text = "12012622142030557234";
            // 
            // textBox2
            // 
            this.textBox2.Enabled = false;
            this.textBox2.Location = new System.Drawing.Point(127, 323);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(155, 20);
            this.textBox2.TabIndex = 19;
            this.textBox2.Text = "99071121111230557234";
            // 
            // textBox3
            // 
            this.textBox3.Enabled = false;
            this.textBox3.Location = new System.Drawing.Point(127, 349);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(155, 20);
            this.textBox3.TabIndex = 20;
            this.textBox3.Text = "12241121111230557234";
            // 
            // textBox4
            // 
            this.textBox4.Enabled = false;
            this.textBox4.Location = new System.Drawing.Point(127, 375);
            this.textBox4.Name = "textBox4";
            this.textBox4.Size = new System.Drawing.Size(155, 20);
            this.textBox4.TabIndex = 21;
            this.textBox4.Text = "12071121116530557234";
            // 
            // textBox5
            // 
            this.textBox5.Enabled = false;
            this.textBox5.Location = new System.Drawing.Point(127, 405);
            this.textBox5.Name = "textBox5";
            this.textBox5.Size = new System.Drawing.Size(155, 20);
            this.textBox5.TabIndex = 22;
            this.textBox5.Text = "12071121111230558234";
            // 
            // textBox6
            // 
            this.textBox6.Enabled = false;
            this.textBox6.Location = new System.Drawing.Point(127, 438);
            this.textBox6.Name = "textBox6";
            this.textBox6.Size = new System.Drawing.Size(155, 20);
            this.textBox6.TabIndex = 23;
            this.textBox6.Text = "12071121111230557209";
            // 
            // radioButton1
            // 
            this.radioButton1.AutoSize = true;
            this.radioButton1.Location = new System.Drawing.Point(12, 438);
            this.radioButton1.Name = "radioButton1";
            this.radioButton1.Size = new System.Drawing.Size(87, 17);
            this.radioButton1.TabIndex = 24;
            this.radioButton1.TabStop = true;
            this.radioButton1.Text = "Emisora Error";
            this.radioButton1.UseVisualStyleBackColor = true;
            this.radioButton1.CheckedChanged += new System.EventHandler(this.radioButton1_CheckedChanged);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(28, 5);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(85, 40);
            this.button3.TabIndex = 25;
            this.button3.Text = "Iniciar";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(821, 20);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(199, 13);
            this.label6.TabIndex = 26;
            this.label6.Text = "Response del Servicio Payment Service ";
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(125, 226);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(155, 23);
            this.button4.TabIndex = 27;
            this.button4.Text = "Arma Cadena Tiempo Real";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // txtReversoRequest
            // 
            this.txtReversoRequest.Location = new System.Drawing.Point(424, 266);
            this.txtReversoRequest.Multiline = true;
            this.txtReversoRequest.Name = "txtReversoRequest";
            this.txtReversoRequest.Size = new System.Drawing.Size(260, 100);
            this.txtReversoRequest.TabIndex = 28;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(438, 250);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(184, 13);
            this.label7.TabIndex = 29;
            this.label7.Text = "Armar Json revBoletoPagadoRequest";
            // 
            // button5
            // 
            this.button5.Location = new System.Drawing.Point(301, 266);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(89, 85);
            this.button5.TabIndex = 30;
            this.button5.Text = "Armas request reverso";
            this.button5.UseVisualStyleBackColor = true;
            this.button5.Click += new System.EventHandler(this.button5_Click);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(857, 240);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(175, 13);
            this.label8.TabIndex = 32;
            this.label8.Text = "Response del Servicio PaymentPay";
            // 
            // button6
            // 
            this.button6.Location = new System.Drawing.Point(704, 266);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(138, 100);
            this.button6.TabIndex = 33;
            this.button6.Text = "Valida Json con Servicio Método revBoletoPagadoRequest";
            this.button6.UseVisualStyleBackColor = true;
            this.button6.Click += new System.EventHandler(this.button6_Click);
            // 
            // textBox7
            // 
            this.textBox7.Location = new System.Drawing.Point(860, 259);
            this.textBox7.Multiline = true;
            this.textBox7.Name = "textBox7";
            this.textBox7.Size = new System.Drawing.Size(353, 107);
            this.textBox7.TabIndex = 34;
            this.textBox7.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // button7
            // 
            this.button7.Location = new System.Drawing.Point(127, 259);
            this.button7.Name = "button7";
            this.button7.Size = new System.Drawing.Size(155, 23);
            this.button7.TabIndex = 37;
            this.button7.Text = "Arma Cadena  17 min";
            this.button7.UseVisualStyleBackColor = true;
            this.button7.Click += new System.EventHandler(this.button7_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1225, 582);
            this.Controls.Add(this.button7);
            this.Controls.Add(this.textBox7);
            this.Controls.Add(this.button6);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.button5);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.txtReversoRequest);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.radioButton1);
            this.Controls.Add(this.textBox6);
            this.Controls.Add(this.textBox5);
            this.Controls.Add(this.textBox4);
            this.Controls.Add(this.textBox3);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.radioButton5);
            this.Controls.Add(this.radioButton4);
            this.Controls.Add(this.radioButton3);
            this.Controls.Add(this.radioButton2);
            this.Controls.Add(this.RbIdBoletoOK);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.txtValidacion);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.txtJsonConsulta);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtTienda);
            this.Controls.Add(this.txtTranaccion);
            this.Controls.Add(this.txtTerminal);
            this.Controls.Add(this.txtBoleto);
            this.Controls.Add(this.button1);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "PUNTO DE VENTA";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox txtBoleto;
        private System.Windows.Forms.TextBox txtTerminal;
        private System.Windows.Forms.TextBox txtTranaccion;
        private System.Windows.Forms.TextBox txtTienda;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtJsonConsulta;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.TextBox txtValidacion;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.RadioButton RbIdBoletoOK;
        private System.Windows.Forms.RadioButton radioButton2;
        private System.Windows.Forms.RadioButton radioButton3;
        private System.Windows.Forms.RadioButton radioButton4;
        private System.Windows.Forms.RadioButton radioButton5;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.TextBox textBox4;
        private System.Windows.Forms.TextBox textBox5;
        private System.Windows.Forms.TextBox textBox6;
        private System.Windows.Forms.RadioButton radioButton1;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.TextBox txtReversoRequest;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Button button6;
        private System.Windows.Forms.TextBox textBox7;
        private System.Windows.Forms.Button button7;
    }
}

