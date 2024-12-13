namespace WinFormsApp4
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void cbbCursos_SelectedIndexChanged(object sender, EventArgs e)
        {
            int Cursos = cbbCursos.SelectedIndex;

            switch (Cursos)
            {
                case 0:
                    lstMeses.Visible = true;
                    lstMeses.Items.Clear();
                    lstMeses.Items.Add("Agosto");
                    lstMeses.Items.Add("Novembro");

                    lstPeriodos.Visible = true;
                    lstPeriodos.Items.Clear();
                    lstPeriodos.Items.Add("Manhã");
                    lstPeriodos.Items.Add("Tarde");
                    break;

                case 1:
                    lstMeses.Visible = true;
                    lstMeses.Items.Clear();
                    lstMeses.Items.Add("Setembro");
                    lstMeses.Items.Add("Outubro");

                    lstPeriodos.Visible = true;
                    lstPeriodos.Items.Clear();
                    lstPeriodos.Items.Add("Tarde");
                    lstPeriodos.Items.Add("Noite");
                    break;

                case 2:
                    lstMeses.Visible = true;
                    lstMeses.Items.Clear();
                    lstMeses.Items.Add("Setembro");
                    lstMeses.Items.Add("Outubro");
                    lstMeses.Items.Add("Novembro");

                    lstPeriodos.Visible = true;
                    lstPeriodos.Items.Clear();
                    lstPeriodos.Items.Add("Manhã");
                    lstPeriodos.Items.Add("Tarde");
                    lstPeriodos.Items.Add("Noite");
                    break;
            }
        }

        private void btnLimpar_Click(object sender, EventArgs e)
        {
            txtCPF.Clear();
            txtEmail.Clear();
            txtNome.Clear();
            rbdMasculino.Checked = false;
            rbdFeminino.Checked = false;
            rbdNaodizer.Checked = false;
            chbJogos.Checked = false;
            chbCulinaria.Checked = false;
            chbEsportes.Checked = false;
            chbFilmes.Checked = false;
            chbModa.Checked = false;
            chbredessociais.Checked = false;
            chbSeries.Checked = false;
            chbEstudar.Checked = false;
            chbLeitura.Checked = false;
            lstMeses.Items.Clear();
            lstPeriodos.Items.Clear();
            cbbCursos.SelectedIndex = -1;
        }

        private void btnSalvar_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Suas Informações foram Salvas");
            Application.Exit();
        }

        private void btnSair_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Tem certeza que deseja sair?");
            Application.Exit();
        }

        private void sobreToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmSobre sobre = new frmSobre();
            sobre.ShowDialog();
        }

        private void pcbLogosenac_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}