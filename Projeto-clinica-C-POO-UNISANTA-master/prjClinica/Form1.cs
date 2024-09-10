using System.Text;

namespace prjClinica
{
    public partial class frmIMC : Form
    {
        public static List<Paciente> pacientes = new List<Paciente>();
        public frmIMC()
        {
            InitializeComponent();
        }

    
       

        private string Relatorio()
        {
            StringBuilder ret = new StringBuilder();

            foreach (Paciente p in pacientes)
            {
                ret.AppendLine(p.ToString()); // eu i casca di bala eu i casca de bala, um amigo meu gosta de uma vaqueijada e eu um amigo meu gosta de uma vaqueijada, eu i
            }
            return ret.ToString();
        }

        private void Limpa_Tela()
        {
            txtAltura.Text =
            txtCPF.Text =
            txtDataNasc.Text =
            txtEmail.Text =
            txtMatricula.Text =
            txtNome.Text =
            txtPeso.Text = String.Empty;

            rbFeminino.Checked =
            rbMasc.Checked =
            rbOutro.Checked = false;
            lbMensagem.Text = String.Empty;
        }

        private void lbTitulo_Click(object sender, EventArgs e)
        {

        }

        private void rbMasc_CheckedChanged(object sender, EventArgs e)
        {

        }
        private void mostraPaciente(Paciente paciente)
        {
            txtAltura.Text = paciente.altura().ToString();
            txtCPF.Text = paciente.cpf;
            txtDataNasc.Text = paciente.dataNascimento.ToString("dd/MM/yyyy");
            txtEmail.Text = paciente.email;
            txtMatricula.Text = paciente.matricula; //desnecessario ma pode ser util lariho dps
            txtNome.Text= paciente.nome;
            txtPeso.Text = paciente.peso().ToString();

            rbFeminino.Checked = paciente.sexo == 'F';
            rbMasc.Checked = paciente.sexo == 'M';
            rbOutro.Checked= paciente.sexo == 'O';
        }
        private static bool editando = false;
        private void btOK_Click_1(object sender, EventArgs e)
        {
            if (txtMatricula.Text.Trim().Length != 6)
            {
                lbMensagem.Text = "*É obrigatorio escrever a matricula com 6 digitos";
                return;
            }
            if (!editando)
            {
                foreach (Paciente paciente in pacientes)
                {
                    if (paciente.matricula == txtMatricula.Text)
                    {
                        mostraPaciente(paciente);
                        editando = true;
                        txtMatricula.ReadOnly = true;
                        return;
                    }
                }
            }

            if (txtNome.Text.Trim() == String.Empty)
            {
                lbMensagem.Text = "*É obrigatorio escrever o nome.";
                editando = false;
                txtMatricula.ReadOnly = false;
                return;
            }
            if (txtCPF.Text.Trim().Length != 11)
            {
                lbMensagem.Text = "*É obrigatorio escrever o CPF com 11 digitos.";
                editando = false;
                txtMatricula.ReadOnly = false;
                return;
            }
            DateTime dataNasc;
            if (!DateTime.TryParse(txtDataNasc.Text, out dataNasc))
            {
                lbMensagem.Text = "*Data de nascimento invalida.";
                editando = false;
                txtMatricula.ReadOnly = false;
                return;
            }
            DateTime hoje = DateTime.Now;
            if (dataNasc.Date > hoje.AddYears(-16))
            {
                lbMensagem.Text = "idade invalida";
                editando = false;
                txtMatricula.ReadOnly = false;
                return;
            }
           
            float peso, altura;
            if (!float.TryParse(txtPeso.Text, out peso) || peso > 180 || peso < 40)
            {
                lbMensagem.Text = "Peso digitado invalido";
                editando = false;
                txtMatricula.ReadOnly = false;
                return;
            }
            if (!float.TryParse(txtAltura.Text, out altura) || altura > 2.2 || altura < 1.2)
            {
                lbMensagem.Text = "Altura digitado invalido";
                editando = false;
                txtMatricula.ReadOnly = false;
                return;
            }
            if (!rbFeminino.Checked && !rbMasc.Checked && !rbOutro.Checked)
            {
                lbMensagem.Text = "Você precisa selecionar algum genero.";
                editando = false;
                txtMatricula.ReadOnly = false;
                return;
            }
            char sexo = 'O';
            if (rbFeminino.Checked) sexo = 'F';
            if (rbMasc.Checked) sexo = 'M';
            Paciente p = new Paciente(txtNome.Text, dataNasc, sexo, txtCPF.Text, peso, altura, txtMatricula.Text);
            p.email = txtEmail.Text;

            
            if (editando)
            {
                for(int i = 0; i < pacientes.Count; i++)
                {
                    if(txtMatricula.Text == pacientes[i].matricula)
                    {
                        pacientes[i] = p;
                        editando=false;
                        txtMatricula.ReadOnly=false;
                        break;
                    }
                }
            }
            else
            {
                pacientes.Add(p);
            }

            

            txtRelatorio.Text = Relatorio();
            Limpa_Tela();
            lbMensagem.Text = String.Empty;

            // lbMensagem.Text = " " + p.ToString(); // + ": " + p.valorIMC();

        }

        private void btLimpar_Click(object sender, EventArgs e)
        {
            Limpa_Tela();
            editando = false;
            txtMatricula.ReadOnly = false;
            return;
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }
    }
}