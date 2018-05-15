namespace ExemploWFZ
{
    partial class Exemplo06
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
            this.lb_ValorTotal1 = new System.Windows.Forms.Label();
            this.btn_Execultar = new System.Windows.Forms.Button();
            this.nud_Quantidade1 = new System.Windows.Forms.NumericUpDown();
            this.mtb_Valor1 = new System.Windows.Forms.MaskedTextBox();
            ((System.ComponentModel.ISupportInitialize)(this.nud_Quantidade1)).BeginInit();
            this.SuspendLayout();
            // 
            // lb_ValorTotal1
            // 
            this.lb_ValorTotal1.AutoSize = true;
            this.lb_ValorTotal1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_ValorTotal1.Location = new System.Drawing.Point(275, 79);
            this.lb_ValorTotal1.Name = "lb_ValorTotal1";
            this.lb_ValorTotal1.Size = new System.Drawing.Size(45, 16);
            this.lb_ValorTotal1.TabIndex = 0;
            this.lb_ValorTotal1.Text = "label1";
            // 
            // btn_Execultar
            // 
            this.btn_Execultar.Location = new System.Drawing.Point(110, 34);
            this.btn_Execultar.Name = "btn_Execultar";
            this.btn_Execultar.Size = new System.Drawing.Size(75, 23);
            this.btn_Execultar.TabIndex = 2;
            this.btn_Execultar.Text = "dfgdg";
            this.btn_Execultar.UseVisualStyleBackColor = true;
            // 
            // nud_Quantidade1
            // 
            this.nud_Quantidade1.Location = new System.Drawing.Point(29, 78);
            this.nud_Quantidade1.Name = "nud_Quantidade1";
            this.nud_Quantidade1.Size = new System.Drawing.Size(120, 20);
            this.nud_Quantidade1.TabIndex = 4;
            // 
            // mtb_Valor1
            // 
            this.mtb_Valor1.Location = new System.Drawing.Point(155, 78);
            this.mtb_Valor1.Name = "mtb_Valor1";
            this.mtb_Valor1.Size = new System.Drawing.Size(100, 20);
            this.mtb_Valor1.TabIndex = 5;
            // 
            // Exemplo06
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlDark;
            this.ClientSize = new System.Drawing.Size(472, 427);
            this.Controls.Add(this.mtb_Valor1);
            this.Controls.Add(this.nud_Quantidade1);
            this.Controls.Add(this.btn_Execultar);
            this.Controls.Add(this.lb_ValorTotal1);
            this.Name = "Exemplo06";
            this.Text = "Exemplo06";
            ((System.ComponentModel.ISupportInitialize)(this.nud_Quantidade1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lb_ValorTotal1;
        private System.Windows.Forms.Button btn_Execultar;
        private System.Windows.Forms.NumericUpDown nud_Quantidade1;
        private System.Windows.Forms.MaskedTextBox mtb_Valor1;
    }
}