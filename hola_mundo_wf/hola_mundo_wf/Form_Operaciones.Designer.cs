namespace hola_mundo_wf
{
    partial class Form_Operaciones
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
            this.label2 = new System.Windows.Forms.Label();
            this.txt_op1 = new System.Windows.Forms.TextBox();
            this.txt_op2 = new System.Windows.Forms.TextBox();
            this.btn_resultado = new System.Windows.Forms.Button();
            this.rbtn_sumar = new System.Windows.Forms.RadioButton();
            this.rbtn_resta = new System.Windows.Forms.RadioButton();
            this.rbtn_mult = new System.Windows.Forms.RadioButton();
            this.rbtn_div = new System.Windows.Forms.RadioButton();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(32, 74);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(64, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "operando 1:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(32, 119);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(64, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "operando 2:";
            // 
            // txt_op1
            // 
            this.txt_op1.Location = new System.Drawing.Point(102, 71);
            this.txt_op1.Name = "txt_op1";
            this.txt_op1.Size = new System.Drawing.Size(100, 20);
            this.txt_op1.TabIndex = 2;
            // 
            // txt_op2
            // 
            this.txt_op2.Location = new System.Drawing.Point(102, 116);
            this.txt_op2.Name = "txt_op2";
            this.txt_op2.Size = new System.Drawing.Size(100, 20);
            this.txt_op2.TabIndex = 3;
            // 
            // btn_resultado
            // 
            this.btn_resultado.Location = new System.Drawing.Point(158, 183);
            this.btn_resultado.Name = "btn_resultado";
            this.btn_resultado.Size = new System.Drawing.Size(75, 23);
            this.btn_resultado.TabIndex = 4;
            this.btn_resultado.Text = "resultado";
            this.btn_resultado.UseVisualStyleBackColor = true;
            this.btn_resultado.Click += new System.EventHandler(this.button1_Res_Click);
            // 
            // rbtn_sumar
            // 
            this.rbtn_sumar.AutoSize = true;
            this.rbtn_sumar.Checked = true;
            this.rbtn_sumar.Location = new System.Drawing.Point(270, 74);
            this.rbtn_sumar.Name = "rbtn_sumar";
            this.rbtn_sumar.Size = new System.Drawing.Size(53, 17);
            this.rbtn_sumar.TabIndex = 5;
            this.rbtn_sumar.TabStop = true;
            this.rbtn_sumar.Text = "sumar";
            this.rbtn_sumar.UseVisualStyleBackColor = true;
            // 
            // rbtn_resta
            // 
            this.rbtn_resta.AutoSize = true;
            this.rbtn_resta.Location = new System.Drawing.Point(270, 97);
            this.rbtn_resta.Name = "rbtn_resta";
            this.rbtn_resta.Size = new System.Drawing.Size(48, 17);
            this.rbtn_resta.TabIndex = 6;
            this.rbtn_resta.Text = "resta";
            this.rbtn_resta.UseVisualStyleBackColor = true;
            // 
            // rbtn_mult
            // 
            this.rbtn_mult.AutoSize = true;
            this.rbtn_mult.Location = new System.Drawing.Point(270, 120);
            this.rbtn_mult.Name = "rbtn_mult";
            this.rbtn_mult.Size = new System.Drawing.Size(88, 17);
            this.rbtn_mult.TabIndex = 7;
            this.rbtn_mult.TabStop = true;
            this.rbtn_mult.Text = "multiplicacion";
            this.rbtn_mult.UseVisualStyleBackColor = true;
            // 
            // rbtn_div
            // 
            this.rbtn_div.AutoSize = true;
            this.rbtn_div.Location = new System.Drawing.Point(270, 143);
            this.rbtn_div.Name = "rbtn_div";
            this.rbtn_div.Size = new System.Drawing.Size(60, 17);
            this.rbtn_div.TabIndex = 8;
            this.rbtn_div.TabStop = true;
            this.rbtn_div.Text = "division";
            this.rbtn_div.UseVisualStyleBackColor = true;
            // 
            // Form_Operaciones
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(390, 233);
            this.Controls.Add(this.rbtn_div);
            this.Controls.Add(this.rbtn_mult);
            this.Controls.Add(this.rbtn_resta);
            this.Controls.Add(this.rbtn_sumar);
            this.Controls.Add(this.btn_resultado);
            this.Controls.Add(this.txt_op2);
            this.Controls.Add(this.txt_op1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Form_Operaciones";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form_Operaciones";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txt_op1;
        private System.Windows.Forms.TextBox txt_op2;
        private System.Windows.Forms.Button btn_resultado;
        private System.Windows.Forms.RadioButton rbtn_sumar;
        private System.Windows.Forms.RadioButton rbtn_resta;
        private System.Windows.Forms.RadioButton rbtn_mult;
        private System.Windows.Forms.RadioButton rbtn_div;
    }
}