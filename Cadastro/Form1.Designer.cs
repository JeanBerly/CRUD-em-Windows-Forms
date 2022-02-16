namespace Cadastro
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
            this.label1 = new System.Windows.Forms.Label();
            this.nomeCadastro = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.idadeCadastro = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.masculino = new System.Windows.Forms.RadioButton();
            this.feminino = new System.Windows.Forms.RadioButton();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnFinalizarCadastro = new System.Windows.Forms.Button();
            this.cpfCadastro = new System.Windows.Forms.MaskedTextBox();
            this.Excluir = new System.Windows.Forms.Button();
            this.Limpar = new System.Windows.Forms.Button();
            this.tabelaBD = new System.Windows.Forms.DataGridView();
            this.NOME = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.IDADE = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CPF = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.SEXO = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tabelaBD)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(5, 2);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(125, 31);
            this.label1.TabIndex = 0;
            this.label1.Text = "Cadastro";
            // 
            // nomeCadastro
            // 
            this.nomeCadastro.Location = new System.Drawing.Point(72, 61);
            this.nomeCadastro.Name = "nomeCadastro";
            this.nomeCadastro.Size = new System.Drawing.Size(100, 20);
            this.nomeCadastro.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(11, 59);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(55, 20);
            this.label2.TabIndex = 2;
            this.label2.Text = "Nome:";
            // 
            // idadeCadastro
            // 
            this.idadeCadastro.Location = new System.Drawing.Point(72, 87);
            this.idadeCadastro.Name = "idadeCadastro";
            this.idadeCadastro.Size = new System.Drawing.Size(100, 20);
            this.idadeCadastro.TabIndex = 3;
            this.idadeCadastro.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.isNumber);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(11, 87);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(54, 20);
            this.label3.TabIndex = 5;
            this.label3.Text = "Idade:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(12, 113);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(44, 20);
            this.label4.TabIndex = 6;
            this.label4.Text = "CPF:";
            // 
            // masculino
            // 
            this.masculino.AutoSize = true;
            this.masculino.Location = new System.Drawing.Point(51, 31);
            this.masculino.Name = "masculino";
            this.masculino.Size = new System.Drawing.Size(98, 24);
            this.masculino.TabIndex = 7;
            this.masculino.TabStop = true;
            this.masculino.Text = "Masculino";
            this.masculino.UseVisualStyleBackColor = true;
            // 
            // feminino
            // 
            this.feminino.AutoSize = true;
            this.feminino.Location = new System.Drawing.Point(51, 54);
            this.feminino.Name = "feminino";
            this.feminino.Size = new System.Drawing.Size(92, 24);
            this.feminino.TabIndex = 8;
            this.feminino.TabStop = true;
            this.feminino.Text = "Feminino";
            this.feminino.UseVisualStyleBackColor = true;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.masculino);
            this.groupBox1.Controls.Add(this.feminino);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(16, 148);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(200, 100);
            this.groupBox1.TabIndex = 9;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Sexo:";
            // 
            // btnFinalizarCadastro
            // 
            this.btnFinalizarCadastro.Location = new System.Drawing.Point(350, 202);
            this.btnFinalizarCadastro.Name = "btnFinalizarCadastro";
            this.btnFinalizarCadastro.Size = new System.Drawing.Size(115, 43);
            this.btnFinalizarCadastro.TabIndex = 10;
            this.btnFinalizarCadastro.Text = "Finalizar Cadastro";
            this.btnFinalizarCadastro.UseVisualStyleBackColor = true;
            this.btnFinalizarCadastro.Click += new System.EventHandler(this.btnFinalizarCadastro_Click);
            // 
            // cpfCadastro
            // 
            this.cpfCadastro.Culture = new System.Globalization.CultureInfo("pt-BR");
            this.cpfCadastro.InsertKeyMode = System.Windows.Forms.InsertKeyMode.Insert;
            this.cpfCadastro.Location = new System.Drawing.Point(72, 113);
            this.cpfCadastro.Mask = "00000000000";
            this.cpfCadastro.Name = "cpfCadastro";
            this.cpfCadastro.Size = new System.Drawing.Size(100, 20);
            this.cpfCadastro.TabIndex = 11;
            // 
            // Excluir
            // 
            this.Excluir.Location = new System.Drawing.Point(530, 205);
            this.Excluir.Name = "Excluir";
            this.Excluir.Size = new System.Drawing.Size(115, 43);
            this.Excluir.TabIndex = 14;
            this.Excluir.Text = "Excluir";
            this.Excluir.UseVisualStyleBackColor = true;
            this.Excluir.Click += new System.EventHandler(this.Excluir_Click);
            // 
            // Limpar
            // 
            this.Limpar.Location = new System.Drawing.Point(673, 205);
            this.Limpar.Name = "Limpar";
            this.Limpar.Size = new System.Drawing.Size(115, 43);
            this.Limpar.TabIndex = 15;
            this.Limpar.Text = "Limpar";
            this.Limpar.UseVisualStyleBackColor = true;
            // 
            // tabelaBD
            // 
            this.tabelaBD.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.tabelaBD.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.NOME,
            this.IDADE,
            this.CPF,
            this.SEXO});
            this.tabelaBD.Location = new System.Drawing.Point(201, 288);
            this.tabelaBD.Name = "tabelaBD";
            this.tabelaBD.ReadOnly = true;
            this.tabelaBD.Size = new System.Drawing.Size(444, 150);
            this.tabelaBD.TabIndex = 16;
            // 
            // NOME
            // 
            this.NOME.HeaderText = "NOME";
            this.NOME.Name = "NOME";
            this.NOME.ReadOnly = true;
            // 
            // IDADE
            // 
            this.IDADE.HeaderText = "IDADE";
            this.IDADE.Name = "IDADE";
            this.IDADE.ReadOnly = true;
            // 
            // CPF
            // 
            this.CPF.HeaderText = "CPF";
            this.CPF.Name = "CPF";
            this.CPF.ReadOnly = true;
            // 
            // SEXO
            // 
            this.SEXO.HeaderText = "SEXO";
            this.SEXO.Name = "SEXO";
            this.SEXO.ReadOnly = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.tabelaBD);
            this.Controls.Add(this.Limpar);
            this.Controls.Add(this.Excluir);
            this.Controls.Add(this.cpfCadastro);
            this.Controls.Add(this.btnFinalizarCadastro);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.idadeCadastro);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.nomeCadastro);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tabelaBD)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox nomeCadastro;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox idadeCadastro;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.RadioButton masculino;
        private System.Windows.Forms.RadioButton feminino;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btnFinalizarCadastro;
        private System.Windows.Forms.MaskedTextBox cpfCadastro;
        private System.Windows.Forms.Button Excluir;
        private System.Windows.Forms.Button Limpar;
        private System.Windows.Forms.DataGridView tabelaBD;
        private System.Windows.Forms.DataGridViewTextBoxColumn NOME;
        private System.Windows.Forms.DataGridViewTextBoxColumn IDADE;
        private System.Windows.Forms.DataGridViewTextBoxColumn CPF;
        private System.Windows.Forms.DataGridViewTextBoxColumn SEXO;
    }
}

