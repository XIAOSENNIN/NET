namespace EJERCICIO_30_04
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
            this.label2 = new System.Windows.Forms.Label();
            this.rb_peleador = new System.Windows.Forms.RadioButton();
            this.rb_futbolista = new System.Windows.Forms.RadioButton();
            this.label1 = new System.Windows.Forms.Label();
            this.tb_tiempo = new System.Windows.Forms.TextBox();
            this.tb_peso = new System.Windows.Forms.TextBox();
            this.cb_opc = new System.Windows.Forms.ComboBox();
            this.bt_resultado = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 103);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(42, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Tiempo";
            // 
            // rb_peleador
            // 
            this.rb_peleador.AutoSize = true;
            this.rb_peleador.Checked = true;
            this.rb_peleador.Location = new System.Drawing.Point(60, 15);
            this.rb_peleador.Name = "rb_peleador";
            this.rb_peleador.Size = new System.Drawing.Size(83, 17);
            this.rb_peleador.TabIndex = 2;
            this.rb_peleador.TabStop = true;
            this.rb_peleador.Text = "PELEADOR";
            this.rb_peleador.UseVisualStyleBackColor = true;
            // 
            // rb_futbolista
            // 
            this.rb_futbolista.AutoSize = true;
            this.rb_futbolista.Location = new System.Drawing.Point(60, 38);
            this.rb_futbolista.Name = "rb_futbolista";
            this.rb_futbolista.Size = new System.Drawing.Size(91, 17);
            this.rb_futbolista.TabIndex = 3;
            this.rb_futbolista.TabStop = true;
            this.rb_futbolista.Text = "FUTBOLISTA";
            this.rb_futbolista.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 77);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(31, 13);
            this.label1.TabIndex = 4;
            this.label1.Text = "Peso";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // tb_tiempo
            // 
            this.tb_tiempo.Location = new System.Drawing.Point(60, 100);
            this.tb_tiempo.Name = "tb_tiempo";
            this.tb_tiempo.Size = new System.Drawing.Size(127, 20);
            this.tb_tiempo.TabIndex = 5;
            this.tb_tiempo.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tb_tiempo_KeyPress);
            // 
            // tb_peso
            // 
            this.tb_peso.Location = new System.Drawing.Point(60, 74);
            this.tb_peso.Name = "tb_peso";
            this.tb_peso.Size = new System.Drawing.Size(127, 20);
            this.tb_peso.TabIndex = 6;
            this.tb_peso.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tb_peso_KeyPress);
            // 
            // cb_opc
            // 
            this.cb_opc.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest;
            this.cb_opc.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.cb_opc.BackColor = System.Drawing.Color.White;
            this.cb_opc.FormattingEnabled = true;
            this.cb_opc.Items.AddRange(new object[] {
            "Segundos",
            "Minutos",
            "Horas"});
            this.cb_opc.Location = new System.Drawing.Point(60, 126);
            this.cb_opc.Name = "cb_opc";
            this.cb_opc.Size = new System.Drawing.Size(127, 21);
            this.cb_opc.TabIndex = 7;
            // 
            // bt_resultado
            // 
            this.bt_resultado.Location = new System.Drawing.Point(68, 162);
            this.bt_resultado.Name = "bt_resultado";
            this.bt_resultado.Size = new System.Drawing.Size(105, 32);
            this.bt_resultado.TabIndex = 8;
            this.bt_resultado.Text = "Resultado";
            this.bt_resultado.UseVisualStyleBackColor = true;
            this.bt_resultado.Click += new System.EventHandler(this.bt_resultado_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(223, 206);
            this.Controls.Add(this.bt_resultado);
            this.Controls.Add(this.cb_opc);
            this.Controls.Add(this.tb_peso);
            this.Controls.Add(this.tb_tiempo);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.rb_futbolista);
            this.Controls.Add(this.rb_peleador);
            this.Controls.Add(this.label2);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.RadioButton rb_peleador;
        private System.Windows.Forms.RadioButton rb_futbolista;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox tb_tiempo;
        private System.Windows.Forms.TextBox tb_peso;
        private System.Windows.Forms.ComboBox cb_opc;
        private System.Windows.Forms.Button bt_resultado;
    }
}

