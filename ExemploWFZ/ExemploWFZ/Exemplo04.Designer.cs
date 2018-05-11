namespace Exemplo04
{
    partial class Exemplo04
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
            this.rb_sim = new System.Windows.Forms.RadioButton();
            this.rb_nao = new System.Windows.Forms.RadioButton();
            this.rb_leagueoffrancisco = new System.Windows.Forms.RadioButton();
            this.rb_franscisnite = new System.Windows.Forms.RadioButton();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.gb_gostadejogo = new System.Windows.Forms.GroupBox();
            this.gb_nomedojogo = new System.Windows.Forms.GroupBox();
            this.gb_gostadejogo.SuspendLayout();
            this.gb_nomedojogo.SuspendLayout();
            this.SuspendLayout();
            // 
            // rb_sim
            // 
            this.rb_sim.AutoSize = true;
            this.rb_sim.Checked = true;
            this.rb_sim.Location = new System.Drawing.Point(6, 29);
            this.rb_sim.Name = "rb_sim";
            this.rb_sim.Size = new System.Drawing.Size(42, 17);
            this.rb_sim.TabIndex = 0;
            this.rb_sim.TabStop = true;
            this.rb_sim.Text = "Sim";
            this.rb_sim.UseVisualStyleBackColor = true;
            this.rb_sim.CheckedChanged += new System.EventHandler(this.rb_sim_CheckedChanged);
            // 
            // rb_nao
            // 
            this.rb_nao.AutoSize = true;
            this.rb_nao.Location = new System.Drawing.Point(6, 63);
            this.rb_nao.Name = "rb_nao";
            this.rb_nao.Size = new System.Drawing.Size(45, 17);
            this.rb_nao.TabIndex = 1;
            this.rb_nao.TabStop = true;
            this.rb_nao.Text = "Não";
            this.rb_nao.UseVisualStyleBackColor = true;
            // 
            // rb_leagueoffrancisco
            // 
            this.rb_leagueoffrancisco.AutoSize = true;
            this.rb_leagueoffrancisco.Location = new System.Drawing.Point(6, 63);
            this.rb_leagueoffrancisco.Name = "rb_leagueoffrancisco";
            this.rb_leagueoffrancisco.Size = new System.Drawing.Size(122, 17);
            this.rb_leagueoffrancisco.TabIndex = 2;
            this.rb_leagueoffrancisco.TabStop = true;
            this.rb_leagueoffrancisco.Text = "League of Francisco";
            this.rb_leagueoffrancisco.UseVisualStyleBackColor = true;
            // 
            // rb_franscisnite
            // 
            this.rb_franscisnite.AutoSize = true;
            this.rb_franscisnite.Checked = true;
            this.rb_franscisnite.Location = new System.Drawing.Point(6, 29);
            this.rb_franscisnite.Name = "rb_franscisnite";
            this.rb_franscisnite.Size = new System.Drawing.Size(81, 17);
            this.rb_franscisnite.TabIndex = 3;
            this.rb_franscisnite.TabStop = true;
            this.rb_franscisnite.Text = "Franscisnite";
            this.rb_franscisnite.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(25, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(76, 13);
            this.label1.TabIndex = 4;
            this.label1.Text = "Gosta de Jogo";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(317, 13);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(78, 13);
            this.label2.TabIndex = 5;
            this.label2.Text = "Nome Do Jogo";
            // 
            // gb_gostadejogo
            // 
            this.gb_gostadejogo.Controls.Add(this.rb_sim);
            this.gb_gostadejogo.Controls.Add(this.rb_nao);
            this.gb_gostadejogo.Location = new System.Drawing.Point(28, 53);
            this.gb_gostadejogo.Name = "gb_gostadejogo";
            this.gb_gostadejogo.Size = new System.Drawing.Size(138, 117);
            this.gb_gostadejogo.TabIndex = 6;
            this.gb_gostadejogo.TabStop = false;
            // 
            // gb_nomedojogo
            // 
            this.gb_nomedojogo.Controls.Add(this.rb_franscisnite);
            this.gb_nomedojogo.Controls.Add(this.rb_leagueoffrancisco);
            this.gb_nomedojogo.Location = new System.Drawing.Point(320, 53);
            this.gb_nomedojogo.Name = "gb_nomedojogo";
            this.gb_nomedojogo.Size = new System.Drawing.Size(133, 117);
            this.gb_nomedojogo.TabIndex = 7;
            this.gb_nomedojogo.TabStop = false;
            // 
            // Exemplo04
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(751, 426);
            this.Controls.Add(this.gb_nomedojogo);
            this.Controls.Add(this.gb_gostadejogo);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Exemplo04";
            this.Text = "Exemplo04";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.gb_gostadejogo.ResumeLayout(false);
            this.gb_gostadejogo.PerformLayout();
            this.gb_nomedojogo.ResumeLayout(false);
            this.gb_nomedojogo.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.RadioButton rb_sim;
        private System.Windows.Forms.RadioButton rb_nao;
        private System.Windows.Forms.RadioButton rb_leagueoffrancisco;
        private System.Windows.Forms.RadioButton rb_franscisnite;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.GroupBox gb_gostadejogo;
        private System.Windows.Forms.GroupBox gb_nomedojogo;
    }
}

