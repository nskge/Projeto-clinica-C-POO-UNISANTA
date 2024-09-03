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

        private void btOK_Click(object sender, EventArgs e)
        {
            if (txtNome.Text.Trim() == String.Empty)
            {
                lbMensagem.Text = "*É obrigatorio escrever o nome.";
                return;
            }
            if (txtCPF.Text.Trim().Length != 11)
            {
                lbMensagem.Text = "*É obrigatorio escrever o CPF com 11 digitos.";
                return;
            }
            DateTime dataNasc;
            if (!DateTime.TryParse(txtDataNasc.Text, out dataNasc))
            {
                lbMensagem.Text = "*Data de nascimento invalida.";
                return;
            }
            DateTime hoje = DateTime.Now;
            if (dataNasc.Date > hoje.AddYears(-16))
            {
                lbMensagem.Text = "idade invalida";
                return;
            }
            if (txtMatricula.Text.Trim().Length != 6)
            {
                lbMensagem.Text = "*É obrigatorio escrever a matricula com 6 digitos";
                return;
            }
            float peso, altura;
            if (!float.TryParse(txtPeso.Text, out peso) || peso > 180 || peso < 40)
            {
                lbMensagem.Text = "Peso digitado invalido";
                return;
            }
            if (!float.TryParse(txtAltura.Text, out altura) || altura > 2.2 || altura < 1.2)
            {
                lbMensagem.Text = "Altura digitado invalido";
                return;
            }
            if (!rbFeminino.Checked && !rbMasc.Checked && !rbOutro.Checked)
            {
                lbMensagem.Text = "Você precisa selecionar algum genero.";
                return;
            }
            char sexo = 'O';
            if (rbFeminino.Checked) sexo = 'F';
            if (rbMasc.Checked) sexo = 'M';
            Paciente p = new Paciente(txtNome.Text, dataNasc, sexo, txtCPF.Text, peso, altura, txtMatricula.Text);
            p.email = txtEmail.Text;

            Limpa_Tela();

            pacientes.Add(p);

            txtRelatorio.Text = Relatorio();
            lbMensagem.Text = String.Empty;

            // lbMensagem.Text = " " + p.ToString(); // + ": " + p.valorIMC();

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
        }

        private void lbTitulo_Click(object sender, EventArgs e)
        {

        }

        private void rbMasc_CheckedChanged(object sender, EventArgs e)
        {

        }
    }
}