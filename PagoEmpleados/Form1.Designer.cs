namespace PagoEmpleados
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txtEMPLEADO = new System.Windows.Forms.TextBox();
            this.txtHORAS = new System.Windows.Forms.TextBox();
            this.txtCH = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.button3 = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.lblMONTOBRUTO = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.lblDESCUENTO = new System.Windows.Forms.Label();
            this.lblMONTONETO = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(371, 10);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(0, 15);
            this.label1.TabIndex = 0;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(53, 64);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(63, 15);
            this.label2.TabIndex = 1;
            this.label2.Text = "Empleado:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(53, 104);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(41, 15);
            this.label3.TabIndex = 2;
            this.label3.Text = "Horas:";
            // 
            // txtEMPLEADO
            // 
            this.txtEMPLEADO.Location = new System.Drawing.Point(137, 62);
            this.txtEMPLEADO.Name = "txtEMPLEADO";
            this.txtEMPLEADO.Size = new System.Drawing.Size(593, 23);
            this.txtEMPLEADO.TabIndex = 3;
            // 
            // txtHORAS
            // 
            this.txtHORAS.Location = new System.Drawing.Point(137, 96);
            this.txtHORAS.Name = "txtHORAS";
            this.txtHORAS.Size = new System.Drawing.Size(234, 23);
            this.txtHORAS.TabIndex = 4;
            this.txtHORAS.TextChanged += new System.EventHandler(this.textBox2_TextChanged);
            // 
            // txtCH
            // 
            this.txtCH.Location = new System.Drawing.Point(472, 96);
            this.txtCH.Name = "txtCH";
            this.txtCH.Size = new System.Drawing.Size(258, 23);
            this.txtCH.TabIndex = 5;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(394, 104);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(75, 15);
            this.label4.TabIndex = 6;
            this.label4.Text = "Costo Horas:";
            this.label4.Click += new System.EventHandler(this.label4_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(53, 147);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 7;
            this.button1.Text = "PROCESAR";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(655, 147);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 8;
            this.button2.Text = "LIMPIAR";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.lblMONTONETO);
            this.groupBox1.Controls.Add(this.lblDESCUENTO);
            this.groupBox1.Controls.Add(this.label8);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.lblMONTOBRUTO);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Location = new System.Drawing.Point(53, 199);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(677, 139);
            this.groupBox1.TabIndex = 9;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "CUADRO DE RESUMEN ";
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(53, 390);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(75, 23);
            this.button3.TabIndex = 10;
            this.button3.Text = "SALIR";
            this.button3.UseVisualStyleBackColor = true;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(60, 29);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(89, 15);
            this.label5.TabIndex = 0;
            this.label5.Text = "MONTO BRUTO";
            // 
            // lblMONTOBRUTO
            // 
            this.lblMONTOBRUTO.AutoSize = true;
            this.lblMONTOBRUTO.Location = new System.Drawing.Point(60, 93);
            this.lblMONTOBRUTO.Name = "lblMONTOBRUTO";
            this.lblMONTOBRUTO.Size = new System.Drawing.Size(38, 15);
            this.lblMONTOBRUTO.TabIndex = 1;
            this.lblMONTOBRUTO.Text = "label6";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(345, 29);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(118, 15);
            this.label7.TabIndex = 2;
            this.label7.Text = "MONTO DESCUENTO";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(563, 29);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(82, 15);
            this.label8.TabIndex = 3;
            this.label8.Text = "MONTO NETO";
            // 
            // lblDESCUENTO
            // 
            this.lblDESCUENTO.AutoSize = true;
            this.lblDESCUENTO.Location = new System.Drawing.Point(345, 93);
            this.lblDESCUENTO.Name = "lblDESCUENTO";
            this.lblDESCUENTO.Size = new System.Drawing.Size(38, 15);
            this.lblDESCUENTO.TabIndex = 4;
            this.lblDESCUENTO.Text = "label9";
            // 
            // lblMONTONETO
            // 
            this.lblMONTONETO.AutoSize = true;
            this.lblMONTONETO.Location = new System.Drawing.Point(563, 93);
            this.lblMONTONETO.Name = "lblMONTONETO";
            this.lblMONTONETO.Size = new System.Drawing.Size(44, 15);
            this.lblMONTONETO.TabIndex = 5;
            this.lblMONTONETO.Text = "label10";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Impact", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label11.Location = new System.Drawing.Point(333, 25);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(175, 17);
            this.label11.TabIndex = 11;
            this.label11.Text = "Control de pago de empleados";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txtCH);
            this.Controls.Add(this.txtHORAS);
            this.Controls.Add(this.txtEMPLEADO);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Control de pago de empleados";
            this.Load += new System.EventHandler(this.Form1_Load_1);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private TextBox txtEMPLEADO;
        private TextBox txtHORAS;
        private TextBox txtCH;
        private Label label4;
        private Button button1;
        private Button button2;
        private GroupBox groupBox1;
        private Label lblMONTONETO;
        private Label lblDESCUENTO;
        private Label label8;
        private Label label7;
        private Label lblMONTOBRUTO;
        private Label label5;
        private Button button3;
        private Label label11;
    }
}