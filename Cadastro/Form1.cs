using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace Cadastro
{
    public partial class Form1 : Form
    {   // use your username here:
        private static readonly string usernameDataBase = "root";
        // Use your database password here:
        private static readonly string passwordDataBase = "123";
        // Use your database name here:
        private static readonly string dataBaseName = "bdTeste";

        private string data_source = String.Format("datasource=localhost;username={0};password={1};database={2}", usernameDataBase, passwordDataBase, dataBaseName);
        public Form1()
        {
            InitializeComponent();
        }
        private void isNumber(object sender, KeyPressEventArgs e)
        {
            // Verify that the pressed key is a digit and not a control.
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && (e.KeyChar != '.'))
            {
                e.Handled = true;
            }
        }
        private void btnFinalizarCadastro_Click(object sender, EventArgs e)
        {
            // Verificar se os campos estão preenchidos se não estiverem retornar;
            if (!validInput()) {
                MessageBox.Show("Preencha todos os campos de maneira válida!");
                return;
            }
            if (cpfAlreadyExists(cpfCadastro.Text)) {
                MessageBox.Show("CPF JA EXISTE");
                return;
            }
            int intIdade = UInt16.Parse(idadeCadastro.Text); 
            if (feminino.Checked)
            {
                addDataBase("feminino");
            }
            else
            {
                addDataBase("masculino");
            }
            limpaCampos();
            tabelaBD.Rows.Clear();
            populateDataGrid();
        }

        private void Excluir_Click(object sender, EventArgs e) {
            MessageBox.Show("Cadastro excluído!");
            int cpfColumn = 2;
            int rowIndex = tabelaBD.CurrentCell.RowIndex;
            string cpf = tabelaBD[cpfColumn, rowIndex].Value.ToString();
            excluirCadastro(cpf);
            tabelaBD.Rows.Clear();
            populateDataGrid();
        }
        private string insertRegister() {
            return "INSERT INTO usuarios (NOME, IDADE, CPF, SEXO) VALUES (@NOME, @IDADE, @CPF, @SEXO)";
        }
        private bool validInput() {
            if (idadeCadastro.Text.Length == 0 || nomeCadastro.Text.Length == 0 || cpfCadastro.Text.Length == 0 || !(masculino.Checked || feminino.Checked)) return false;
            return true;
        }

        private void Form1_Load(object sender, EventArgs e) {
            populateDataGrid();
        }
        private void populateDataGrid() {
            MySqlConnection Connection = new MySqlConnection(data_source);
            try {
                Connection.Open();
                MySqlCommand query = new MySqlCommand();
                query.Connection = Connection;
                query.CommandText = "SELECT * FROM usuarios;";
                using (MySqlDataReader dr = query.ExecuteReader()) {
                    while (dr.Read()) {
                        string[] row = { dr[0].ToString(), dr[1].ToString(), dr[2].ToString(), dr[3].ToString() };
                        tabelaBD.Rows.Add(row);
                    }
                    dr.Close();
                }

            }
            catch (Exception ex) {
                MessageBox.Show(ex.Message);
            }
            finally {
                Connection.Close();
            }
        }
        private void addDataBase(string gender) {
            using (MySqlConnection Connection = new MySqlConnection(data_source)) {
                try {
                    Connection.Open();
                    string command = insertRegister();
                    MySqlCommand insert = new MySqlCommand(command, Connection);
                    if (UInt16.TryParse(idadeCadastro.Text, out ushort intIdade)) {
                        insert.Parameters.AddWithValue("@NOME", nomeCadastro.Text);
                        insert.Parameters.AddWithValue("@IDADE", idadeCadastro.Text);
                        insert.Parameters.AddWithValue("@CPF", cpfCadastro.Text);
                        if (gender == "masculino") {
                            insert.Parameters.AddWithValue("@SEXO", "masculino");
                        }
                        else {
                            insert.Parameters.AddWithValue("@SEXO", "feminino");
                        }
                        insert.ExecuteNonQuery();
                    }
                }   
                catch (Exception ex) {
                    MessageBox.Show(ex.Message);
                }
                finally {
                    Connection.Close();
                }
            }
        }
        private void limpaCampos() {
            nomeCadastro.Text = "";
            idadeCadastro.Text = "";
            cpfCadastro.Text = "";
            feminino.Checked = false;
            masculino.Checked = false;
        }
        private void excluirCadastro(string cpf) {
            using (MySqlConnection Connection = new MySqlConnection(data_source)) {
                try {
                    Connection.Open();
                    MySqlCommand delete = new MySqlCommand();
                    delete.Connection = Connection;
                    // delete with CPF as a paramater because two users cannot have the same CPF(primary key);
                    delete.CommandText = String.Format("DELETE FROM usuarios WHERE CPF = '{0}';", cpf);
                    delete.ExecuteNonQuery();
                }
                catch (Exception ex) {
                    MessageBox.Show(ex.Message);
                }
                finally {
                    Connection.Close();
                }
            }
        }
        private bool cpfAlreadyExists(string cpf) {
            using (MySqlConnection Connection = new MySqlConnection(data_source)) {
                try {
                    Connection.Open();
                    string commandSearch = "SELECT * FROM usuarios WHERE CPF = @CPF";
                    MySqlCommand search = new MySqlCommand(commandSearch, Connection);
                    search.Parameters.AddWithValue("@CPF", cpf);
                    using (MySqlDataReader reader = search.ExecuteReader()) {
                        while (reader.Read()) {
                            return true;
                        }
                    }
                }
                catch (Exception ex) {
                    MessageBox.Show(ex.Message);
                }
                finally {
                    Connection.Close();
                }
                // In case it didn't find a cpf return false;
                return false;
            }       
        }
        private void updateRegister(string cpf,string newName, int newAge, string newCpf, string newGender) {
            using (MySqlConnection Connection = new MySqlConnection(data_source)) {
                try {
                    Connection.Open();
                    string updateCommand = "UPDATE usuarios SET NOME = @NEWNAME, IDADE = @NEWAGE, CPF = @NEWCPF, SEXO = @NEWGENDER  WHERE CPF = @CPF";
                    MySqlCommand updateCpf = new MySqlCommand(updateCommand, Connection);
                    updateCpf.Parameters.AddWithValue("@NEWNAME", newName);
                    updateCpf.Parameters.AddWithValue("@NEWAGE", newAge);
                    updateCpf.Parameters.AddWithValue("@NEWCPF", newCpf);
                    updateCpf.Parameters.AddWithValue("@NEWGENDER", newGender);
                    updateCpf.Parameters.AddWithValue("@CPF", cpf);
                    updateCpf.ExecuteNonQuery();
                }
                catch (Exception ex) {
                    MessageBox.Show(ex.Message);
                }
                finally {
                    Connection.Close();
                }
            }
        }
        private void EditarCadastro_Click(object sender, EventArgs e) {
            int rowIndex = tabelaBD.CurrentCell.RowIndex;
            string nome = tabelaBD[0, rowIndex].Value.ToString();
            string idade = tabelaBD[1, rowIndex].Value.ToString();
            string cpf = tabelaBD[2, rowIndex].Value.ToString();
            string sexo = tabelaBD[3, rowIndex].Value.ToString();
            EditarCadastro editarCadastro = new EditarCadastro(nome, UInt16.Parse(idade), cpf, sexo);
            this.Hide();
            editarCadastro.ShowDialog();
            if (editarCadastro.EditRegister) {
                // change in DATABASE;
                if (!cpfAlreadyExists(editarCadastro.cpf)) {
                    updateRegister(cpf, editarCadastro.nome, editarCadastro.idade, editarCadastro.cpf, editarCadastro.sexo);
                }
                else {
                    MessageBox.Show("Você tentou alterar para um CPF que já existe, verifique com o administrador do sistema para resolver este problema!");
                }

                // populate gridview again;
                tabelaBD.Rows.Clear();
                populateDataGrid();
            }
            this.Show();
        }
    }
}
