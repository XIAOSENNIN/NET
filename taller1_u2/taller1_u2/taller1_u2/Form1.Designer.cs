namespace taller1_u2
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txt_rut = new System.Windows.Forms.TextBox();
            this.txt_monto = new System.Windows.Forms.TextBox();
            this.cb_plazo = new System.Windows.Forms.ComboBox();
            this.txt_rutdigito = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.chb_desgravamen = new System.Windows.Forms.CheckBox();
            this.chb_incendio = new System.Windows.Forms.CheckBox();
            this.chb_terremoto = new System.Windows.Forms.CheckBox();
            this.button1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft YaHei UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(63, 58);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(41, 19);
            this.label1.TabIndex = 0;
            this.label1.Text = "RUT :";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft YaHei UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(46, 94);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(58, 19);
            this.label2.TabIndex = 1;
            this.label2.Text = "Monto :";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft YaHei UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(56, 130);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(48, 19);
            this.label3.TabIndex = 2;
            this.label3.Text = "Plazo :";
            // 
            // txt_rut
            // 
            this.txt_rut.Location = new System.Drawing.Point(110, 59);
            this.txt_rut.Name = "txt_rut";
            this.txt_rut.Size = new System.Drawing.Size(120, 20);
            this.txt_rut.TabIndex = 3;
            this.txt_rut.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txt_rut_KeyPress);
            // 
            // txt_monto
            // 
            this.txt_monto.Location = new System.Drawing.Point(110, 95);
            this.txt_monto.Name = "txt_monto";
            this.txt_monto.Size = new System.Drawing.Size(120, 20);
            this.txt_monto.TabIndex = 4;
            this.txt_monto.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txt_monto_KeyPress);
            // 
            // cb_plazo
            // 
            this.cb_plazo.FormattingEnabled = true;
            this.cb_plazo.Items.AddRange(new object[] {
            "12 meses",
            "24 meses",
            "36 meses",
            "48 meses",
            "60 meses"});
            this.cb_plazo.Location = new System.Drawing.Point(109, 131);
            this.cb_plazo.Name = "cb_plazo";
            this.cb_plazo.Size = new System.Drawing.Size(121, 21);
            this.cb_plazo.TabIndex = 5;
            // 
            // txt_rutdigito
            // 
            this.txt_rutdigito.Location = new System.Drawing.Point(257, 59);
            this.txt_rutdigito.Name = "txt_rutdigito";
            this.txt_rutdigito.Size = new System.Drawing.Size(32, 20);
            this.txt_rutdigito.TabIndex = 6;
            this.txt_rutdigito.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txt_rutdigito_KeyPress);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft YaHei UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(236, 56);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(15, 19);
            this.label4.TabIndex = 7;
            this.label4.Text = "-";
            // 
            // chb_desgravamen
            // 
            this.chb_desgravamen.AutoSize = true;
            this.chb_desgravamen.Location = new System.Drawing.Point(347, 61);
            this.chb_desgravamen.Name = "chb_desgravamen";
            this.chb_desgravamen.Size = new System.Drawing.Size(127, 17);
            this.chb_desgravamen.TabIndex = 8;
            this.chb_desgravamen.Text = "Seguro desgravamen";
            this.chb_desgravamen.UseVisualStyleBackColor = true;
            // 
            // chb_incendio
            // 
            this.chb_incendio.AutoSize = true;
            this.chb_incendio.Location = new System.Drawing.Point(347, 95);
            this.chb_incendio.Name = "chb_incendio";
            this.chb_incendio.Size = new System.Drawing.Size(103, 17);
            this.chb_incendio.TabIndex = 9;
            this.chb_incendio.Text = "Seguro incendio";
            this.chb_incendio.UseVisualStyleBackColor = true;
            // 
            // chb_terremoto
            // 
            this.chb_terremoto.AutoSize = true;
            this.chb_terremoto.Location = new System.Drawing.Point(347, 130);
            this.chb_terremoto.Name = "chb_terremoto";
            this.chb_terremoto.Size = new System.Drawing.Size(107, 17);
            this.chb_terremoto.TabIndex = 10;
            this.chb_terremoto.Text = "Seguro terremoto";
            this.chb_terremoto.UseVisualStyleBackColor = true;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(215, 208);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(101, 23);
            this.button1.TabIndex = 11;
            this.button1.Text = "Simular";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(516, 255);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.chb_terremoto);
            this.Controls.Add(this.chb_incendio);
            this.Controls.Add(this.chb_desgravamen);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txt_rutdigito);
            this.Controls.Add(this.cb_plazo);
            this.Controls.Add(this.txt_monto);
            this.Controls.Add(this.txt_rut);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txt_rut;
        private System.Windows.Forms.TextBox txt_monto;
        private System.Windows.Forms.ComboBox cb_plazo;
        private System.Windows.Forms.TextBox txt_rutdigito;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.CheckBox chb_desgravamen;
        private System.Windows.Forms.CheckBox chb_incendio;
        private System.Windows.Forms.CheckBox chb_terremoto;
        private System.Windows.Forms.Button button1;
    }
}

