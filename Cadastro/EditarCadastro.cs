using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Cadastro {
    public partial class EditarCadastro : Form {
        public string nome;
        public int idade;
        public string cpf;
        public string sexo;
        public bool EditRegister;
        public EditarCadastro(string nome, int idade, string cpf, string sexo) {
            InitializeComponent();
            txtNome.Text = this.nome = nome;
            this.idade = idade;
            txtIdade.Text = idade.ToString();
            txtCPF.Text = this.cpf = cpf;
            if (sexo == "masculino") {
                Masculino.Checked = true;
            }
            else {
                Feminino.Checked = true;
            }
        }

        private void btnCancel_Click(object sender, EventArgs e) {
            EditRegister = false;
            this.Close();
        }

        private void btnConfirm_Click(object sender, EventArgs e) {
            EditRegister = true;
            this.nome = txtNome.Text;
            this.idade = UInt16.Parse(txtIdade.Text);
            this.cpf = txtCPF.Text;
            if (Masculino.Checked) {
                this.sexo = "masculino";
            }
            else {
                this.sexo = "feminino";
            }
            this.Hide();
        }
    }
}
