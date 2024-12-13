namespace WinFormsApp4
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            components = new System.ComponentModel.Container();
            pcbLogosenac = new PictureBox();
            gpbDadosPessoais = new GroupBox();
            txtNome = new TextBox();
            lblNome = new Label();
            txtEmail = new TextBox();
            lblEmail = new Label();
            txtCPF = new TextBox();
            lblCPF = new Label();
            gpbSexo = new GroupBox();
            rbdNaodizer = new RadioButton();
            rbdFeminino = new RadioButton();
            rbdMasculino = new RadioButton();
            gpbHobbies = new GroupBox();
            chbredessociais = new CheckBox();
            chbModa = new CheckBox();
            chbJogos = new CheckBox();
            chbCulinaria = new CheckBox();
            chbLeitura = new CheckBox();
            chbEsportes = new CheckBox();
            chbSeries = new CheckBox();
            chbFilmes = new CheckBox();
            chbEstudar = new CheckBox();
            gpbCursos = new GroupBox();
            lblMesInicio = new Label();
            lstMeses = new ListBox();
            lstPeriodos = new ListBox();
            cbbCursos = new ComboBox();
            btnSalvar = new Button();
            btnLimpar = new Button();
            btnSair = new Button();
            menuStrip1 = new MenuStrip();
            arquivoToolStripMenuItem = new ToolStripMenuItem();
            sobreToolStripMenuItem = new ToolStripMenuItem();
            lblCadastroAlunos = new Label();
            toolTip1 = new ToolTip(components);
            ((System.ComponentModel.ISupportInitialize)pcbLogosenac).BeginInit();
            gpbDadosPessoais.SuspendLayout();
            gpbSexo.SuspendLayout();
            gpbHobbies.SuspendLayout();
            gpbCursos.SuspendLayout();
            menuStrip1.SuspendLayout();
            SuspendLayout();
            // 
            // pcbLogosenac
            // 
            pcbLogosenac.BackColor = Color.White;
            pcbLogosenac.Image = Properties.Resources.senac_logo;
            pcbLogosenac.Location = new Point(0, 27);
            pcbLogosenac.Name = "pcbLogosenac";
            pcbLogosenac.Size = new Size(183, 110);
            pcbLogosenac.SizeMode = PictureBoxSizeMode.Zoom;
            pcbLogosenac.TabIndex = 0;
            pcbLogosenac.TabStop = false;
            pcbLogosenac.Click += pcbLogosenac_Click;
            // 
            // gpbDadosPessoais
            // 
            gpbDadosPessoais.BackColor = Color.White;
            gpbDadosPessoais.Controls.Add(txtNome);
            gpbDadosPessoais.Controls.Add(lblNome);
            gpbDadosPessoais.Controls.Add(txtEmail);
            gpbDadosPessoais.Controls.Add(lblEmail);
            gpbDadosPessoais.Controls.Add(txtCPF);
            gpbDadosPessoais.Controls.Add(lblCPF);
            gpbDadosPessoais.Location = new Point(12, 163);
            gpbDadosPessoais.Name = "gpbDadosPessoais";
            gpbDadosPessoais.Size = new Size(392, 122);
            gpbDadosPessoais.TabIndex = 1;
            gpbDadosPessoais.TabStop = false;
            gpbDadosPessoais.Text = "Dados Pessoais";
            // 
            // txtNome
            // 
            txtNome.Location = new Point(60, 80);
            txtNome.Name = "txtNome";
            txtNome.Size = new Size(267, 23);
            txtNome.TabIndex = 5;
            // 
            // lblNome
            // 
            lblNome.AutoSize = true;
            lblNome.Location = new Point(17, 85);
            lblNome.Name = "lblNome";
            lblNome.Size = new Size(43, 15);
            lblNome.TabIndex = 4;
            lblNome.Text = "Nome:";
            // 
            // txtEmail
            // 
            txtEmail.Location = new Point(60, 51);
            txtEmail.Name = "txtEmail";
            txtEmail.Size = new Size(207, 23);
            txtEmail.TabIndex = 3;
            // 
            // lblEmail
            // 
            lblEmail.AutoSize = true;
            lblEmail.Location = new Point(13, 54);
            lblEmail.Name = "lblEmail";
            lblEmail.Size = new Size(44, 15);
            lblEmail.TabIndex = 2;
            lblEmail.Text = "E-mail:";
            // 
            // txtCPF
            // 
            txtCPF.Location = new Point(47, 22);
            txtCPF.Name = "txtCPF";
            txtCPF.Size = new Size(153, 23);
            txtCPF.TabIndex = 1;
            toolTip1.SetToolTip(txtCPF, "Digite apenas números");
            // 
            // lblCPF
            // 
            lblCPF.AutoSize = true;
            lblCPF.Location = new Point(13, 28);
            lblCPF.Name = "lblCPF";
            lblCPF.Size = new Size(31, 15);
            lblCPF.TabIndex = 0;
            lblCPF.Text = "CPF:";
            // 
            // gpbSexo
            // 
            gpbSexo.Controls.Add(rbdNaodizer);
            gpbSexo.Controls.Add(rbdFeminino);
            gpbSexo.Controls.Add(rbdMasculino);
            gpbSexo.Location = new Point(12, 291);
            gpbSexo.Name = "gpbSexo";
            gpbSexo.Size = new Size(200, 100);
            gpbSexo.TabIndex = 2;
            gpbSexo.TabStop = false;
            gpbSexo.Text = "Sexo";
            // 
            // rbdNaodizer
            // 
            rbdNaodizer.AutoSize = true;
            rbdNaodizer.Location = new Point(11, 68);
            rbdNaodizer.Name = "rbdNaodizer";
            rbdNaodizer.Size = new Size(96, 19);
            rbdNaodizer.TabIndex = 2;
            rbdNaodizer.TabStop = true;
            rbdNaodizer.Text = "Não Informar";
            rbdNaodizer.UseVisualStyleBackColor = true;
            // 
            // rbdFeminino
            // 
            rbdFeminino.AutoSize = true;
            rbdFeminino.Location = new Point(11, 45);
            rbdFeminino.Name = "rbdFeminino";
            rbdFeminino.Size = new Size(75, 19);
            rbdFeminino.TabIndex = 1;
            rbdFeminino.TabStop = true;
            rbdFeminino.Text = "Feminino";
            rbdFeminino.UseVisualStyleBackColor = true;
            // 
            // rbdMasculino
            // 
            rbdMasculino.AutoSize = true;
            rbdMasculino.Location = new Point(11, 22);
            rbdMasculino.Name = "rbdMasculino";
            rbdMasculino.Size = new Size(80, 19);
            rbdMasculino.TabIndex = 0;
            rbdMasculino.TabStop = true;
            rbdMasculino.Text = "Masculino";
            rbdMasculino.UseVisualStyleBackColor = true;
            // 
            // gpbHobbies
            // 
            gpbHobbies.Controls.Add(chbredessociais);
            gpbHobbies.Controls.Add(chbModa);
            gpbHobbies.Controls.Add(chbJogos);
            gpbHobbies.Controls.Add(chbCulinaria);
            gpbHobbies.Controls.Add(chbLeitura);
            gpbHobbies.Controls.Add(chbEsportes);
            gpbHobbies.Controls.Add(chbSeries);
            gpbHobbies.Controls.Add(chbFilmes);
            gpbHobbies.Controls.Add(chbEstudar);
            gpbHobbies.Location = new Point(366, 291);
            gpbHobbies.Name = "gpbHobbies";
            gpbHobbies.Size = new Size(274, 100);
            gpbHobbies.TabIndex = 3;
            gpbHobbies.TabStop = false;
            gpbHobbies.Text = "Hobbies";
            // 
            // chbredessociais
            // 
            chbredessociais.AutoSize = true;
            chbredessociais.Location = new Point(156, 68);
            chbredessociais.Name = "chbredessociais";
            chbredessociais.Size = new Size(96, 19);
            chbredessociais.TabIndex = 8;
            chbredessociais.Text = "Redes Sociais";
            chbredessociais.UseVisualStyleBackColor = true;
            // 
            // chbModa
            // 
            chbModa.AutoSize = true;
            chbModa.Location = new Point(156, 46);
            chbModa.Name = "chbModa";
            chbModa.Size = new Size(57, 19);
            chbModa.TabIndex = 7;
            chbModa.Text = "Moda";
            chbModa.UseVisualStyleBackColor = true;
            // 
            // chbJogos
            // 
            chbJogos.AutoSize = true;
            chbJogos.Location = new Point(157, 23);
            chbJogos.Name = "chbJogos";
            chbJogos.Size = new Size(56, 19);
            chbJogos.TabIndex = 6;
            chbJogos.Text = "Jogos";
            chbJogos.UseVisualStyleBackColor = true;
            // 
            // chbCulinaria
            // 
            chbCulinaria.AutoSize = true;
            chbCulinaria.Location = new Point(80, 67);
            chbCulinaria.Name = "chbCulinaria";
            chbCulinaria.Size = new Size(73, 19);
            chbCulinaria.TabIndex = 5;
            chbCulinaria.Text = "Culinária";
            chbCulinaria.UseVisualStyleBackColor = true;
            // 
            // chbLeitura
            // 
            chbLeitura.AutoSize = true;
            chbLeitura.Location = new Point(81, 45);
            chbLeitura.Name = "chbLeitura";
            chbLeitura.Size = new Size(62, 19);
            chbLeitura.TabIndex = 4;
            chbLeitura.Text = "Leitura";
            chbLeitura.UseVisualStyleBackColor = true;
            // 
            // chbEsportes
            // 
            chbEsportes.AutoSize = true;
            chbEsportes.Location = new Point(80, 22);
            chbEsportes.Name = "chbEsportes";
            chbEsportes.Size = new Size(70, 19);
            chbEsportes.TabIndex = 3;
            chbEsportes.Text = "Esportes";
            chbEsportes.UseVisualStyleBackColor = true;
            // 
            // chbSeries
            // 
            chbSeries.AutoSize = true;
            chbSeries.Location = new Point(8, 67);
            chbSeries.Name = "chbSeries";
            chbSeries.Size = new Size(56, 19);
            chbSeries.TabIndex = 2;
            chbSeries.Text = "Séries";
            chbSeries.UseVisualStyleBackColor = true;
            // 
            // chbFilmes
            // 
            chbFilmes.AutoSize = true;
            chbFilmes.Location = new Point(8, 43);
            chbFilmes.Name = "chbFilmes";
            chbFilmes.Size = new Size(60, 19);
            chbFilmes.TabIndex = 1;
            chbFilmes.Text = "Filmes";
            chbFilmes.UseVisualStyleBackColor = true;
            // 
            // chbEstudar
            // 
            chbEstudar.AutoSize = true;
            chbEstudar.Location = new Point(8, 21);
            chbEstudar.Name = "chbEstudar";
            chbEstudar.Size = new Size(65, 19);
            chbEstudar.TabIndex = 0;
            chbEstudar.Text = "Estudar";
            chbEstudar.UseVisualStyleBackColor = true;
            // 
            // gpbCursos
            // 
            gpbCursos.Controls.Add(lblMesInicio);
            gpbCursos.Controls.Add(lstMeses);
            gpbCursos.Controls.Add(lstPeriodos);
            gpbCursos.Controls.Add(cbbCursos);
            gpbCursos.Location = new Point(23, 417);
            gpbCursos.Name = "gpbCursos";
            gpbCursos.Size = new Size(524, 189);
            gpbCursos.TabIndex = 4;
            gpbCursos.TabStop = false;
            gpbCursos.Text = "Cursos";
            // 
            // lblMesInicio
            // 
            lblMesInicio.AutoSize = true;
            lblMesInicio.Location = new Point(295, 23);
            lblMesInicio.Name = "lblMesInicio";
            lblMesInicio.Size = new Size(74, 15);
            lblMesInicio.TabIndex = 3;
            lblMesInicio.Text = "Mês Inicio->";
            // 
            // lstMeses
            // 
            lstMeses.FormattingEnabled = true;
            lstMeses.ItemHeight = 15;
            lstMeses.Location = new Point(373, 34);
            lstMeses.Name = "lstMeses";
            lstMeses.Size = new Size(120, 94);
            lstMeses.TabIndex = 2;
            // 
            // lstPeriodos
            // 
            lstPeriodos.FormattingEnabled = true;
            lstPeriodos.ItemHeight = 15;
            lstPeriodos.Location = new Point(12, 74);
            lstPeriodos.Name = "lstPeriodos";
            lstPeriodos.Size = new Size(120, 94);
            lstPeriodos.TabIndex = 1;
            // 
            // cbbCursos
            // 
            cbbCursos.FormattingEnabled = true;
            cbbCursos.Items.AddRange(new object[] { "Técnico em Desenvolvimentos de Sistemas", "Técnico em Informática para Internet", "Técnico em Desing Gráfico" });
            cbbCursos.Location = new Point(12, 34);
            cbbCursos.Name = "cbbCursos";
            cbbCursos.Size = new Size(277, 23);
            cbbCursos.TabIndex = 0;
            cbbCursos.SelectedIndexChanged += cbbCursos_SelectedIndexChanged;
            // 
            // btnSalvar
            // 
            btnSalvar.BackColor = SystemColors.ActiveCaption;
            btnSalvar.Image = Properties.Resources.checkmark_icon_2797531_640_resized;
            btnSalvar.Location = new Point(163, 638);
            btnSalvar.Name = "btnSalvar";
            btnSalvar.Size = new Size(116, 130);
            btnSalvar.TabIndex = 5;
            btnSalvar.Text = "Salvar";
            btnSalvar.TextAlign = ContentAlignment.BottomCenter;
            toolTip1.SetToolTip(btnSalvar, "Salvar Informações");
            btnSalvar.UseVisualStyleBackColor = false;
            btnSalvar.Click += btnSalvar_Click;
            // 
            // btnLimpar
            // 
            btnLimpar.BackColor = Color.Cornsilk;
            btnLimpar.Image = Properties.Resources.vassoura_png_resized;
            btnLimpar.Location = new Point(366, 638);
            btnLimpar.Name = "btnLimpar";
            btnLimpar.Size = new Size(116, 130);
            btnLimpar.TabIndex = 6;
            btnLimpar.Text = "Limpar";
            btnLimpar.TextAlign = ContentAlignment.BottomCenter;
            toolTip1.SetToolTip(btnLimpar, "Limpar Informações");
            btnLimpar.UseVisualStyleBackColor = false;
            btnLimpar.Click += btnLimpar_Click;
            // 
            // btnSair
            // 
            btnSair.BackColor = Color.MediumPurple;
            btnSair.Image = Properties.Resources.icons8_saída_de_emergência_100;
            btnSair.Location = new Point(565, 638);
            btnSair.Name = "btnSair";
            btnSair.Size = new Size(116, 130);
            btnSair.TabIndex = 7;
            btnSair.Text = "Sair";
            btnSair.TextAlign = ContentAlignment.BottomCenter;
            toolTip1.SetToolTip(btnSair, "Sair do site");
            btnSair.UseVisualStyleBackColor = false;
            btnSair.Click += btnSair_Click;
            // 
            // menuStrip1
            // 
            menuStrip1.Items.AddRange(new ToolStripItem[] { arquivoToolStripMenuItem });
            menuStrip1.Location = new Point(0, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Size = new Size(920, 24);
            menuStrip1.TabIndex = 8;
            menuStrip1.Text = "menuStrip1";
            // 
            // arquivoToolStripMenuItem
            // 
            arquivoToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { sobreToolStripMenuItem });
            arquivoToolStripMenuItem.Name = "arquivoToolStripMenuItem";
            arquivoToolStripMenuItem.Size = new Size(61, 20);
            arquivoToolStripMenuItem.Text = "Arquivo";
            // 
            // sobreToolStripMenuItem
            // 
            sobreToolStripMenuItem.Name = "sobreToolStripMenuItem";
            sobreToolStripMenuItem.Size = new Size(180, 22);
            sobreToolStripMenuItem.Text = "Sobre";
            sobreToolStripMenuItem.Click += sobreToolStripMenuItem_Click;
            // 
            // lblCadastroAlunos
            // 
            lblCadastroAlunos.AutoSize = true;
            lblCadastroAlunos.Font = new Font("Segoe UI", 26.25F, FontStyle.Bold, GraphicsUnit.Point);
            lblCadastroAlunos.ForeColor = Color.MidnightBlue;
            lblCadastroAlunos.Location = new Point(412, 50);
            lblCadastroAlunos.Name = "lblCadastroAlunos";
            lblCadastroAlunos.Size = new Size(344, 47);
            lblCadastroAlunos.TabIndex = 9;
            lblCadastroAlunos.Text = "Cadastro De Alunos";
            // 
            // toolTip1
            // 
            toolTip1.IsBalloon = true;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(920, 804);
            Controls.Add(lblCadastroAlunos);
            Controls.Add(btnLimpar);
            Controls.Add(btnSair);
            Controls.Add(btnSalvar);
            Controls.Add(gpbCursos);
            Controls.Add(gpbHobbies);
            Controls.Add(gpbSexo);
            Controls.Add(gpbDadosPessoais);
            Controls.Add(pcbLogosenac);
            Controls.Add(menuStrip1);
            MainMenuStrip = menuStrip1;
            Name = "Form1";
            Text = " ";
            Load += Form1_Load;
            ((System.ComponentModel.ISupportInitialize)pcbLogosenac).EndInit();
            gpbDadosPessoais.ResumeLayout(false);
            gpbDadosPessoais.PerformLayout();
            gpbSexo.ResumeLayout(false);
            gpbSexo.PerformLayout();
            gpbHobbies.ResumeLayout(false);
            gpbHobbies.PerformLayout();
            gpbCursos.ResumeLayout(false);
            gpbCursos.PerformLayout();
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private PictureBox pcbLogosenac;
        private GroupBox gpbDadosPessoais;
        private TextBox txtNome;
        private Label lblNome;
        private TextBox txtEmail;
        private Label lblEmail;
        private TextBox txtCPF;
        private Label lblCPF;
        private GroupBox gpbSexo;
        private RadioButton rbdNaodizer;
        private RadioButton rbdFeminino;
        private RadioButton rbdMasculino;
        private GroupBox gpbHobbies;
        private CheckBox chbredessociais;
        private CheckBox chbModa;
        private CheckBox chbJogos;
        private CheckBox chbCulinaria;
        private CheckBox chbLeitura;
        private CheckBox chbEsportes;
        private CheckBox chbSeries;
        private CheckBox chbFilmes;
        private CheckBox chbEstudar;
        private GroupBox gpbCursos;
        private Label lblMesInicio;
        private ListBox lstMeses;
        private ListBox lstPeriodos;
        private ComboBox cbbCursos;
        private Button btnSalvar;
        private Button btnLimpar;
        private Button btnSair;
        private MenuStrip menuStrip1;
        private ToolStripMenuItem arquivoToolStripMenuItem;
        private ToolStripMenuItem sobreToolStripMenuItem;
        private Label lblCadastroAlunos;
        private ToolTip toolTip1;
    }
}