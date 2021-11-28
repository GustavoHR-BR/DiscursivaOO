using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace Prova_de_Programação_Orientada_a_Objetos
{
    public partial class frmMain : Form
    {
        public frmMain()
        {
            InitializeComponent();
        }

        private void btnCad_Click(object sender, EventArgs e)
        {
            if (!validaNome())
            {
                MessageBox.Show("Nome Já cadastrado", "Alerta", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                if (String.IsNullOrEmpty(edtNome.Text) || edtNome.Text.Length < 6)
                {
                    MessageBox.Show("Nome inválido", "Alerta", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    limpaTela();
                }
                else if (!validaGenero())
                {
                    MessageBox.Show("Gênero inválido", "Alerta", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    int s = 0;
                    if (btnSim.Checked)
                    {
                        s = 1;
                    }
                    Jovem j = new Jovem(
                            edtNome.Text, (Jovem.Generos)cboxGen.SelectedIndex, s
                        );
                    j.Adicionar(j);
                    dgJovens.DataSource = "";
                    dgJovens.DataSource = Jovem.Listar();
                    calculaPercentuais();
                    MessageBox.Show("Cadastrado com sucesso!", ":)", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    limpaTela();
                }
            }
        }

        private Boolean validaNome()
        {
            List<Jovem> list = Jovem.Listar();
            foreach (Jovem j in list)
            {
                if (j.Nome.Equals(edtNome.Text))
                {
                    return false;
                }
            }
            return true;
        }

        private Boolean validaGenero()
        {
            if (cboxGen.Text == Jovem.Generos.Homem.ToString())
            {
                return true;
            }else if (cboxGen.Text == Jovem.Generos.Mulher.ToString())
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        private void limpaTela()
        {
            edtNome.Text = "";
            edtNome.Focus();
            cboxGen.SelectedIndex = 0;
            btnSim.Checked = true;
        }

        private void frmMain_Load(object sender, EventArgs e)
        {
            cboxGen.DataSource = Enum.GetNames(typeof(Jovem.Generos));
            dgJovens.DataSource = Jovem.Listar();
            edtNome.Focus();
            if (Jovem.Listar().Count > 0)
            {
                calculaPercentuais();
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            var nomesHomens = new[] { 
                "Miguel", "Arthur", "Davi", "Heitor", "Gabriel", "Bernardo", 
                "Lorenzo", "Enzo", "Pedro Henrique", "Gustavo Henrique" 
            };

            var nomesMulheres = new[] {
                "Alice", "Valentina", "Helena", "Laura", "Sophia", "Maria", "Júlia", 
                "Cibeli", "Heloísa", "Lívia"
            };

            Random random = new Random();
            int s = 0;
            int nome = 0;

            for (int i = 0; i < 25; i++)
            {
                s = random.Next(0, 2);
                nome = random.Next(0, 9);
                cboxGen.SelectedIndex = 0;

                Jovem j = new Jovem(
                            nomesHomens[nome], (Jovem.Generos)cboxGen.SelectedIndex, s
                        );
                j.Adicionar(j);
                dgJovens.DataSource = "";
                dgJovens.DataSource = Jovem.Listar();
            }

            for (int i = 0; i < 25; i++)
            {
                s = random.Next(0, 2);
                nome = random.Next(0, 9);
                cboxGen.SelectedIndex = 1;

                Jovem j = new Jovem(
                            nomesMulheres[nome], (Jovem.Generos)cboxGen.SelectedIndex, s
                        );
                j.Adicionar(j);
                dgJovens.DataSource = "";
                dgJovens.DataSource = Jovem.Listar();
            }
            limpaTela();
            calculaPercentuais();
        }

        private void calculaPercentuais()
        {
            List<Jovem> list = Jovem.Listar();
            int hEmp = 0, hDes = 0, mEmp = 0, mDes = 0;
            foreach (Jovem j in list)
            {
                if (j.Genero.ToString() == "Homem")
                {
                    if (j.Status == 1)
                    {
                        hEmp++;
                    }
                    else
                    {
                        hDes++;
                    }
                }
                else
                {
                    if (j.Status == 1)
                    {
                        mEmp++;
                    }
                    else
                    {
                        mDes++;
                    }
                }
            }
            progressBarHDes.Value = (hDes * 100) / list.Count;
            porcHDes.Text = progressBarHDes.Value + "%";
            progressBarHEmp.Value = (hEmp * 100) / list.Count;
            porcHEmp.Text = progressBarHEmp.Value + "%";
            progressBarMDes.Value = (mDes * 100) / list.Count;
            porcMDes.Text = progressBarMDes.Value + "%";
            progressBarMEmp.Value = (mEmp * 100) / list.Count;
            porcMEmp.Text = progressBarMEmp.Value + "%";
        }
    }
}
