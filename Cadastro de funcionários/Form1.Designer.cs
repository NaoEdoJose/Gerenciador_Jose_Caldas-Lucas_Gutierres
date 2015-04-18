namespace Cadastro_de_funcionarios
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
            this.Funcionários = new System.Windows.Forms.ListBox();
            this.nome = new System.Windows.Forms.TextBox();
            this.idade = new System.Windows.Forms.TextBox();
            this.profissão = new System.Windows.Forms.TextBox();
            this.salario = new System.Windows.Forms.TextBox();
            this.endereço = new System.Windows.Forms.TextBox();
            this.email = new System.Windows.Forms.TextBox();
            this.tel = new System.Windows.Forms.TextBox();
            this.confirmar = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.Verificar = new System.Windows.Forms.Button();
            this.sexo = new System.Windows.Forms.ComboBox();
            this.tiposanguineo = new System.Windows.Forms.ComboBox();
            this.editar = new System.Windows.Forms.Button();
            this.label12 = new System.Windows.Forms.Label();
            this.Deletar = new System.Windows.Forms.Button();
            this.relacionamento = new System.Windows.Forms.ComboBox();
            this.label13 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            this.numdefilhos = new System.Windows.Forms.ComboBox();
            this.label16 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // Funcionários
            // 
            this.Funcionários.FormattingEnabled = true;
            this.Funcionários.Location = new System.Drawing.Point(441, 12);
            this.Funcionários.Name = "Funcionários";
            this.Funcionários.Size = new System.Drawing.Size(215, 433);
            this.Funcionários.TabIndex = 0;
            // 
            // nome
            // 
            this.nome.Location = new System.Drawing.Point(12, 80);
            this.nome.Name = "nome";
            this.nome.Size = new System.Drawing.Size(361, 20);
            this.nome.TabIndex = 1;
            this.nome.TextChanged += new System.EventHandler(this.Nome_TextChanged);
            // 
            // idade
            // 
            this.idade.Location = new System.Drawing.Point(379, 80);
            this.idade.Name = "idade";
            this.idade.Size = new System.Drawing.Size(45, 20);
            this.idade.TabIndex = 2;
            this.idade.TextChanged += new System.EventHandler(this.Nome_TextChanged);
            // 
            // profissão
            // 
            this.profissão.Location = new System.Drawing.Point(124, 123);
            this.profissão.Name = "profissão";
            this.profissão.Size = new System.Drawing.Size(148, 20);
            this.profissão.TabIndex = 4;
            this.profissão.TextChanged += new System.EventHandler(this.Nome_TextChanged);
            // 
            // salario
            // 
            this.salario.Location = new System.Drawing.Point(278, 123);
            this.salario.Name = "salario";
            this.salario.Size = new System.Drawing.Size(147, 20);
            this.salario.TabIndex = 5;
            this.salario.TextChanged += new System.EventHandler(this.Nome_TextChanged);
            // 
            // endereço
            // 
            this.endereço.Location = new System.Drawing.Point(12, 216);
            this.endereço.Name = "endereço";
            this.endereço.Size = new System.Drawing.Size(410, 20);
            this.endereço.TabIndex = 9;
            this.endereço.TextChanged += new System.EventHandler(this.Nome_TextChanged);
            // 
            // email
            // 
            this.email.Location = new System.Drawing.Point(12, 260);
            this.email.Name = "email";
            this.email.Size = new System.Drawing.Size(410, 20);
            this.email.TabIndex = 10;
            this.email.TextChanged += new System.EventHandler(this.Nome_TextChanged);
            // 
            // tel
            // 
            this.tel.Location = new System.Drawing.Point(12, 299);
            this.tel.Name = "tel";
            this.tel.Size = new System.Drawing.Size(193, 20);
            this.tel.TabIndex = 11;
            this.tel.TextChanged += new System.EventHandler(this.Nome_TextChanged);
            // 
            // confirmar
            // 
            this.confirmar.Location = new System.Drawing.Point(167, 422);
            this.confirmar.Name = "confirmar";
            this.confirmar.Size = new System.Drawing.Size(75, 23);
            this.confirmar.TabIndex = 12;
            this.confirmar.Text = "Confirmar";
            this.confirmar.UseVisualStyleBackColor = true;
            this.confirmar.Click += new System.EventHandler(this.confirm_click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Location = new System.Drawing.Point(12, 63);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(35, 13);
            this.label1.TabIndex = 15;
            this.label1.Text = "Nome";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Location = new System.Drawing.Point(376, 63);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(34, 13);
            this.label2.TabIndex = 16;
            this.label2.Text = "Idade";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Location = new System.Drawing.Point(16, 107);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(31, 13);
            this.label3.TabIndex = 17;
            this.label3.Text = "Sexo";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Location = new System.Drawing.Point(124, 107);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(50, 13);
            this.label4.TabIndex = 18;
            this.label4.Text = "Profissão";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.Transparent;
            this.label5.Location = new System.Drawing.Point(275, 107);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(59, 13);
            this.label5.TabIndex = 19;
            this.label5.Text = "Salário(R$)";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.Transparent;
            this.label6.Location = new System.Drawing.Point(43, 162);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(62, 13);
            this.label6.TabIndex = 20;
            this.label6.Text = "Estado Civil";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.BackColor = System.Drawing.Color.Transparent;
            this.label7.Location = new System.Drawing.Point(189, 162);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(64, 13);
            this.label7.TabIndex = 21;
            this.label7.Text = "N° de Filhos";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.BackColor = System.Drawing.Color.Transparent;
            this.label8.Location = new System.Drawing.Point(275, 162);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(82, 13);
            this.label8.TabIndex = 22;
            this.label8.Text = "Tipo sanguíneo";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.BackColor = System.Drawing.Color.Transparent;
            this.label9.Location = new System.Drawing.Point(9, 200);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(53, 13);
            this.label9.TabIndex = 23;
            this.label9.Text = "Endereço";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.BackColor = System.Drawing.Color.Transparent;
            this.label10.Location = new System.Drawing.Point(9, 244);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(32, 13);
            this.label10.TabIndex = 24;
            this.label10.Text = "Email";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.BackColor = System.Drawing.Color.Transparent;
            this.label11.Location = new System.Drawing.Point(9, 283);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(49, 13);
            this.label11.TabIndex = 25;
            this.label11.Text = "Telefone";
            // 
            // Verificar
            // 
            this.Verificar.Location = new System.Drawing.Point(82, 422);
            this.Verificar.Name = "Verificar";
            this.Verificar.Size = new System.Drawing.Size(75, 23);
            this.Verificar.TabIndex = 26;
            this.Verificar.Text = "Verificar";
            this.Verificar.UseVisualStyleBackColor = true;
            this.Verificar.Click += new System.EventHandler(this.Verificar_Click);
            // 
            // sexo
            // 
            this.sexo.FormattingEnabled = true;
            this.sexo.Items.AddRange(new object[] {
            "M",
            "F",
            "Outro"});
            this.sexo.Location = new System.Drawing.Point(19, 123);
            this.sexo.Name = "sexo";
            this.sexo.Size = new System.Drawing.Size(86, 21);
            this.sexo.TabIndex = 27;
            // 
            // tiposanguineo
            // 
            this.tiposanguineo.FormattingEnabled = true;
            this.tiposanguineo.Items.AddRange(new object[] {
            "A+",
            "A-",
            "AB+",
            "AB-",
            "B+",
            "B-",
            "O+",
            "O-"});
            this.tiposanguineo.Location = new System.Drawing.Point(278, 178);
            this.tiposanguineo.Name = "tiposanguineo";
            this.tiposanguineo.Size = new System.Drawing.Size(79, 21);
            this.tiposanguineo.TabIndex = 28;
            // 
            // editar
            // 
            this.editar.Location = new System.Drawing.Point(259, 422);
            this.editar.Name = "editar";
            this.editar.Size = new System.Drawing.Size(75, 23);
            this.editar.TabIndex = 29;
            this.editar.Text = "Editar";
            this.editar.UseVisualStyleBackColor = true;
            this.editar.Click += new System.EventHandler(this.Editar_Click);
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.ForeColor = System.Drawing.SystemColors.Control;
            this.label12.Location = new System.Drawing.Point(31, 374);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(216, 13);
            this.label12.TabIndex = 30;
            this.label12.Text = "Todos os campos devem estar preenchidos.";
            // 
            // Deletar
            // 
            this.Deletar.Location = new System.Drawing.Point(349, 422);
            this.Deletar.Name = "Deletar";
            this.Deletar.Size = new System.Drawing.Size(75, 23);
            this.Deletar.TabIndex = 31;
            this.Deletar.Text = "Deletar";
            this.Deletar.UseVisualStyleBackColor = true;
            this.Deletar.Click += new System.EventHandler(this.Deletar_Click);
            // 
            // relacionamento
            // 
            this.relacionamento.FormattingEnabled = true;
            this.relacionamento.Items.AddRange(new object[] {
            "Casado(a)",
            "Solteiro(a)",
            "Divorciado(a)",
            "Viúvo(a)"});
            this.relacionamento.Location = new System.Drawing.Point(46, 177);
            this.relacionamento.Name = "relacionamento";
            this.relacionamento.Size = new System.Drawing.Size(116, 21);
            this.relacionamento.TabIndex = 32;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.ForeColor = System.Drawing.SystemColors.Control;
            this.label13.Location = new System.Drawing.Point(33, 341);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(74, 13);
            this.label13.TabIndex = 33;
            this.label13.Text = "Email inválido.";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.ForeColor = System.Drawing.SystemColors.Control;
            this.label14.Location = new System.Drawing.Point(31, 354);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(76, 13);
            this.label14.TabIndex = 34;
            this.label14.Text = "Idade inválida.";
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.ForeColor = System.Drawing.SystemColors.Control;
            this.label15.Location = new System.Drawing.Point(31, 387);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(91, 13);
            this.label15.TabIndex = 35;
            this.label15.Text = "Telefone inválido.";
            // 
            // numdefilhos
            // 
            this.numdefilhos.FormattingEnabled = true;
            this.numdefilhos.Items.AddRange(new object[] {
            "0",
            "1",
            "2",
            "3",
            "4+"});
            this.numdefilhos.Location = new System.Drawing.Point(192, 178);
            this.numdefilhos.Name = "numdefilhos";
            this.numdefilhos.Size = new System.Drawing.Size(61, 21);
            this.numdefilhos.TabIndex = 36;
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.BackColor = System.Drawing.Color.Transparent;
            this.label16.Font = new System.Drawing.Font("Microsoft Sans Serif", 27.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label16.Location = new System.Drawing.Point(120, 12);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(170, 42);
            this.label16.TabIndex = 37;
            this.label16.Text = "Cadastro";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(668, 463);
            this.Controls.Add(this.label16);
            this.Controls.Add(this.numdefilhos);
            this.Controls.Add(this.label15);
            this.Controls.Add(this.label14);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.relacionamento);
            this.Controls.Add(this.Deletar);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.editar);
            this.Controls.Add(this.tiposanguineo);
            this.Controls.Add(this.sexo);
            this.Controls.Add(this.Verificar);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.confirmar);
            this.Controls.Add(this.tel);
            this.Controls.Add(this.email);
            this.Controls.Add(this.endereço);
            this.Controls.Add(this.salario);
            this.Controls.Add(this.profissão);
            this.Controls.Add(this.idade);
            this.Controls.Add(this.nome);
            this.Controls.Add(this.Funcionários);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(684, 502);
            this.MinimumSize = new System.Drawing.Size(684, 502);
            this.Name = "Form1";
            this.Text = "Gerenciador de Funcionários ";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox Funcionários;
        private System.Windows.Forms.TextBox nome;
        private System.Windows.Forms.TextBox idade;
        private System.Windows.Forms.TextBox profissão;
        private System.Windows.Forms.TextBox salario;
        private System.Windows.Forms.TextBox endereço;
        private System.Windows.Forms.TextBox email;
        private System.Windows.Forms.TextBox tel;
        private System.Windows.Forms.Button confirmar;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Button Verificar;
        private System.Windows.Forms.ComboBox sexo;
        private System.Windows.Forms.ComboBox tiposanguineo;
        private System.Windows.Forms.Button editar;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Button Deletar;
        private System.Windows.Forms.ComboBox relacionamento;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.ComboBox numdefilhos;
        private System.Windows.Forms.Label label16;

    }
}

