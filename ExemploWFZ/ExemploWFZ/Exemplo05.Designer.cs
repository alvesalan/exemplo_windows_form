namespace Exemplo05
{
    partial class Form1
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
            this.cb_leu = new System.Windows.Forms.CheckBox();
            this.cb_comprou = new System.Windows.Forms.CheckBox();
            this.button1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // cb_leu
            // 
            this.cb_leu.AutoSize = true;
            this.cb_leu.Location = new System.Drawing.Point(42, 28);
            this.cb_leu.Name = "cb_leu";
            this.cb_leu.Size = new System.Drawing.Size(138, 17);
            this.cb_leu.TabIndex = 0;
            this.cb_leu.Text = "Confirma que leu tudo ?";
            this.cb_leu.UseVisualStyleBackColor = true;
            // 
            // cb_comprou
            // 
            this.cb_comprou.AutoSize = true;
            this.cb_comprou.Location = new System.Drawing.Point(42, 61);
            this.cb_comprou.Name = "cb_comprou";
            this.cb_comprou.Size = new System.Drawing.Size(149, 17);
            this.cb_comprou.TabIndex = 1;
            this.cb_comprou.Text = "Você comprou o WinRar?";
            this.cb_comprou.UseVisualStyleBackColor = true;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(72, 103);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 2;
            this.button1.Text = "Salvar";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(715, 429);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.cb_comprou);
            this.Controls.Add(this.cb_leu);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.CheckBox cb_leu;
        private System.Windows.Forms.CheckBox cb_comprou;
        private System.Windows.Forms.Button button1;
    }
}

