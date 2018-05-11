namespace ExemploWFZ
{
    partial class Exemplo02
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
            this.Nome = new System.Windows.Forms.Label();
            this.txtNome = new System.Windows.Forms.TextBox();
            this.txtValorHora = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtQuantidadeHora = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.radioButton1 = new System.Windows.Forms.RadioButton();
            this.RbFemea = new System.Windows.Forms.RadioButton();
            this.label1 = new System.Windows.Forms.Label();
            this.cbUnidadeFederativa = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.txtCpmplemento = new System.Windows.Forms.TextBox();
            this.txtNumero = new System.Windows.Forms.TextBox();
            this.txtBairro = new System.Windows.Forms.TextBox();
            this.txtLogadouro = new System.Windows.Forms.TextBox();
            this.dtpDataNascimento = new System.Windows.Forms.DateTimePicker();
            this.txtCidade = new System.Windows.Forms.TextBox();
            this.Cadastrar = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // Nome
            // 
            this.Nome.AutoSize = true;
            this.Nome.Location = new System.Drawing.Point(69, 15);
            this.Nome.Name = "Nome";
            this.Nome.Size = new System.Drawing.Size(35, 13);
            this.Nome.TabIndex = 0;
            this.Nome.Text = "Nome";
            // 
            // txtNome
            // 
            this.txtNome.Location = new System.Drawing.Point(110, 12);
            this.txtNome.Name = "txtNome";
            this.txtNome.Size = new System.Drawing.Size(310, 20);
            this.txtNome.TabIndex = 1;
            // 
            // txtValorHora
            // 
            this.txtValorHora.Location = new System.Drawing.Point(110, 38);
            this.txtValorHora.Name = "txtValorHora";
            this.txtValorHora.Size = new System.Drawing.Size(310, 20);
            this.txtValorHora.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(49, 45);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(57, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Valor Hora";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // txtQuantidadeHora
            // 
            this.txtQuantidadeHora.Location = new System.Drawing.Point(110, 64);
            this.txtQuantidadeHora.Name = "txtQuantidadeHora";
            this.txtQuantidadeHora.Size = new System.Drawing.Size(310, 20);
            this.txtQuantidadeHora.TabIndex = 5;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(49, 78);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(0, 13);
            this.label3.TabIndex = 4;
            // 
            // radioButton1
            // 
            this.radioButton1.AutoSize = true;
            this.radioButton1.Location = new System.Drawing.Point(493, 11);
            this.radioButton1.Name = "radioButton1";
            this.radioButton1.Size = new System.Drawing.Size(58, 17);
            this.radioButton1.TabIndex = 6;
            this.radioButton1.TabStop = true;
            this.radioButton1.Text = "Macho";
            this.radioButton1.UseVisualStyleBackColor = true;
            // 
            // RbFemea
            // 
            this.RbFemea.AutoSize = true;
            this.RbFemea.Location = new System.Drawing.Point(582, 11);
            this.RbFemea.Name = "RbFemea";
            this.RbFemea.Size = new System.Drawing.Size(57, 17);
            this.RbFemea.TabIndex = 7;
            this.RbFemea.TabStop = true;
            this.RbFemea.Text = "Fêmea";
            this.RbFemea.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(-2, 71);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(106, 13);
            this.label1.TabIndex = 8;
            this.label1.Text = "Quantidade de horas";
            // 
            // cbUnidadeFederativa
            // 
            this.cbUnidadeFederativa.FormattingEnabled = true;
            this.cbUnidadeFederativa.Items.AddRange(new object[] {
            "AC",
            "AL",
            "AP",
            "AM",
            "BA",
            "CE",
            "DF",
            "ES",
            "GO",
            "MA",
            "MT",
            "MS",
            "MG",
            "PA",
            "PB",
            "PR",
            "PR",
            "PI",
            "RJ",
            "RN",
            "RS",
            "RO",
            "PR",
            "SC",
            "SP",
            "SE",
            "TO"});
            this.cbUnidadeFederativa.Location = new System.Drawing.Point(7, 130);
            this.cbUnidadeFederativa.Name = "cbUnidadeFederativa";
            this.cbUnidadeFederativa.Size = new System.Drawing.Size(121, 21);
            this.cbUnidadeFederativa.TabIndex = 9;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(4, 114);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(100, 13);
            this.label4.TabIndex = 10;
            this.label4.Text = "Unidade Federativa";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(154, 114);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(40, 13);
            this.label5.TabIndex = 12;
            this.label5.Text = "Cidade";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(12, 171);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(34, 13);
            this.label6.TabIndex = 14;
            this.label6.Text = "Bairro";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(154, 171);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(61, 13);
            this.label7.TabIndex = 16;
            this.label7.Text = "Logradouro";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(12, 230);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(44, 13);
            this.label8.TabIndex = 18;
            this.label8.Text = "Número";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(12, 290);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(71, 13);
            this.label9.TabIndex = 20;
            this.label9.Text = "Complemento";
            // 
            // txtCpmplemento
            // 
            this.txtCpmplemento.Location = new System.Drawing.Point(15, 306);
            this.txtCpmplemento.Multiline = true;
            this.txtCpmplemento.Name = "txtCpmplemento";
            this.txtCpmplemento.Size = new System.Drawing.Size(488, 150);
            this.txtCpmplemento.TabIndex = 21;
            // 
            // txtNumero
            // 
            this.txtNumero.Location = new System.Drawing.Point(15, 246);
            this.txtNumero.Name = "txtNumero";
            this.txtNumero.Size = new System.Drawing.Size(310, 20);
            this.txtNumero.TabIndex = 22;
            // 
            // txtBairro
            // 
            this.txtBairro.Location = new System.Drawing.Point(15, 188);
            this.txtBairro.Name = "txtBairro";
            this.txtBairro.Size = new System.Drawing.Size(103, 20);
            this.txtBairro.TabIndex = 23;
            // 
            // txtLogadouro
            // 
            this.txtLogadouro.Location = new System.Drawing.Point(157, 187);
            this.txtLogadouro.Name = "txtLogadouro";
            this.txtLogadouro.Size = new System.Drawing.Size(168, 20);
            this.txtLogadouro.TabIndex = 24;
            // 
            // dtpDataNascimento
            // 
            this.dtpDataNascimento.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpDataNascimento.Location = new System.Drawing.Point(552, 230);
            this.dtpDataNascimento.Name = "dtpDataNascimento";
            this.dtpDataNascimento.Size = new System.Drawing.Size(100, 20);
            this.dtpDataNascimento.TabIndex = 25;
            // 
            // txtCidade
            // 
            this.txtCidade.Location = new System.Drawing.Point(157, 131);
            this.txtCidade.Name = "txtCidade";
            this.txtCidade.Size = new System.Drawing.Size(168, 20);
            this.txtCidade.TabIndex = 26;
            // 
            // Cadastrar
            // 
            this.Cadastrar.Location = new System.Drawing.Point(552, 349);
            this.Cadastrar.Name = "Cadastrar";
            this.Cadastrar.Size = new System.Drawing.Size(105, 70);
            this.Cadastrar.TabIndex = 27;
            this.Cadastrar.Text = "Cadastrar";
            this.Cadastrar.UseVisualStyleBackColor = true;
            this.Cadastrar.Click += new System.EventHandler(this.Cadastrar_Click);
            // 
            // Exemplo2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(836, 468);
            this.Controls.Add(this.Cadastrar);
            this.Controls.Add(this.txtCidade);
            this.Controls.Add(this.dtpDataNascimento);
            this.Controls.Add(this.txtLogadouro);
            this.Controls.Add(this.txtBairro);
            this.Controls.Add(this.txtNumero);
            this.Controls.Add(this.txtCpmplemento);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.cbUnidadeFederativa);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.RbFemea);
            this.Controls.Add(this.radioButton1);
            this.Controls.Add(this.txtQuantidadeHora);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtValorHora);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtNome);
            this.Controls.Add(this.Nome);
            this.Name = "Exemplo2";
            this.Text = "Exemplo2";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label Nome;
        private System.Windows.Forms.TextBox txtNome;
        private System.Windows.Forms.TextBox txtValorHora;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtQuantidadeHora;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.RadioButton radioButton1;
        private System.Windows.Forms.RadioButton RbFemea;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cbUnidadeFederativa;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox txtCpmplemento;
        private System.Windows.Forms.TextBox txtNumero;
        private System.Windows.Forms.TextBox txtBairro;
        private System.Windows.Forms.TextBox txtLogadouro;
        private System.Windows.Forms.DateTimePicker dtpDataNascimento;
        private System.Windows.Forms.TextBox txtCidade;
        private System.Windows.Forms.Button Cadastrar;
    }
}