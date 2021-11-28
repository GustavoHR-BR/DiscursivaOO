
namespace Prova_de_Programação_Orientada_a_Objetos
{
    partial class frmMain
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
            this.label1 = new System.Windows.Forms.Label();
            this.btnCad = new System.Windows.Forms.Button();
            this.cboxGen = new System.Windows.Forms.ComboBox();
            this.btnGeraDados = new System.Windows.Forms.Button();
            this.dgJovens = new System.Windows.Forms.DataGridView();
            this.btnNao = new System.Windows.Forms.RadioButton();
            this.btnSim = new System.Windows.Forms.RadioButton();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.edtNome = new System.Windows.Forms.TextBox();
            this.progressBarHDes = new System.Windows.Forms.ProgressBar();
            this.progressBarHEmp = new System.Windows.Forms.ProgressBar();
            this.progressBarMDes = new System.Windows.Forms.ProgressBar();
            this.progressBarMEmp = new System.Windows.Forms.ProgressBar();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.porcHDes = new System.Windows.Forms.Label();
            this.porcHEmp = new System.Windows.Forms.Label();
            this.porcMDes = new System.Windows.Forms.Label();
            this.porcMEmp = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgJovens)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(35, 46);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(43, 15);
            this.label1.TabIndex = 0;
            this.label1.Text = "Nome:";
            this.label1.TextAlign = System.Drawing.ContentAlignment.BottomLeft;
            // 
            // btnCad
            // 
            this.btnCad.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnCad.Location = new System.Drawing.Point(35, 248);
            this.btnCad.Name = "btnCad";
            this.btnCad.Size = new System.Drawing.Size(75, 30);
            this.btnCad.TabIndex = 1;
            this.btnCad.Text = "Cadastrar";
            this.btnCad.UseVisualStyleBackColor = true;
            this.btnCad.Click += new System.EventHandler(this.btnCad_Click);
            // 
            // cboxGen
            // 
            this.cboxGen.Cursor = System.Windows.Forms.Cursors.Hand;
            this.cboxGen.FormattingEnabled = true;
            this.cboxGen.Location = new System.Drawing.Point(35, 126);
            this.cboxGen.Name = "cboxGen";
            this.cboxGen.Size = new System.Drawing.Size(224, 23);
            this.cboxGen.TabIndex = 3;
            // 
            // btnGeraDados
            // 
            this.btnGeraDados.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnGeraDados.Location = new System.Drawing.Point(168, 248);
            this.btnGeraDados.Name = "btnGeraDados";
            this.btnGeraDados.Size = new System.Drawing.Size(91, 30);
            this.btnGeraDados.TabIndex = 10;
            this.btnGeraDados.Text = "Gerar Dados";
            this.btnGeraDados.UseVisualStyleBackColor = true;
            this.btnGeraDados.Click += new System.EventHandler(this.button1_Click);
            // 
            // dgJovens
            // 
            this.dgJovens.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgJovens.Location = new System.Drawing.Point(296, 199);
            this.dgJovens.Name = "dgJovens";
            this.dgJovens.RowTemplate.Height = 25;
            this.dgJovens.Size = new System.Drawing.Size(427, 153);
            this.dgJovens.TabIndex = 9;
            // 
            // btnNao
            // 
            this.btnNao.AutoSize = true;
            this.btnNao.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnNao.Location = new System.Drawing.Point(95, 199);
            this.btnNao.Name = "btnNao";
            this.btnNao.Size = new System.Drawing.Size(47, 19);
            this.btnNao.TabIndex = 8;
            this.btnNao.Text = "Não";
            this.btnNao.UseVisualStyleBackColor = true;
            // 
            // btnSim
            // 
            this.btnSim.AutoSize = true;
            this.btnSim.Checked = true;
            this.btnSim.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnSim.Location = new System.Drawing.Point(35, 199);
            this.btnSim.Name = "btnSim";
            this.btnSim.Size = new System.Drawing.Size(45, 19);
            this.btnSim.TabIndex = 7;
            this.btnSim.TabStop = true;
            this.btnSim.Text = "Sim";
            this.btnSim.UseVisualStyleBackColor = true;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(35, 179);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(138, 15);
            this.label3.TabIndex = 6;
            this.label3.Text = "Atualmente empregado?";
            this.label3.TextAlign = System.Drawing.ContentAlignment.BottomLeft;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(35, 108);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(45, 15);
            this.label2.TabIndex = 5;
            this.label2.Text = "Gênero";
            this.label2.TextAlign = System.Drawing.ContentAlignment.BottomLeft;
            // 
            // edtNome
            // 
            this.edtNome.Location = new System.Drawing.Point(35, 64);
            this.edtNome.Name = "edtNome";
            this.edtNome.Size = new System.Drawing.Size(224, 23);
            this.edtNome.TabIndex = 4;
            // 
            // progressBarHDes
            // 
            this.progressBarHDes.Location = new System.Drawing.Point(503, 46);
            this.progressBarHDes.Name = "progressBarHDes";
            this.progressBarHDes.Size = new System.Drawing.Size(220, 23);
            this.progressBarHDes.TabIndex = 11;
            // 
            // progressBarHEmp
            // 
            this.progressBarHEmp.Location = new System.Drawing.Point(503, 75);
            this.progressBarHEmp.Name = "progressBarHEmp";
            this.progressBarHEmp.Size = new System.Drawing.Size(220, 23);
            this.progressBarHEmp.TabIndex = 12;
            // 
            // progressBarMDes
            // 
            this.progressBarMDes.Location = new System.Drawing.Point(503, 104);
            this.progressBarMDes.Name = "progressBarMDes";
            this.progressBarMDes.Size = new System.Drawing.Size(220, 23);
            this.progressBarMDes.TabIndex = 13;
            // 
            // progressBarMEmp
            // 
            this.progressBarMEmp.Location = new System.Drawing.Point(503, 133);
            this.progressBarMEmp.Name = "progressBarMEmp";
            this.progressBarMEmp.Size = new System.Drawing.Size(220, 23);
            this.progressBarMEmp.TabIndex = 14;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(295, 54);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(137, 15);
            this.label4.TabIndex = 15;
            this.label4.Text = "Homens Desmpregados:";
            this.label4.TextAlign = System.Drawing.ContentAlignment.BottomLeft;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(295, 83);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(124, 15);
            this.label5.TabIndex = 16;
            this.label5.Text = "Homens Empregados:";
            this.label5.TextAlign = System.Drawing.ContentAlignment.BottomLeft;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(296, 112);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(140, 15);
            this.label6.TabIndex = 17;
            this.label6.Text = "Mulheres Desmpregadas:";
            this.label6.TextAlign = System.Drawing.ContentAlignment.BottomLeft;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(296, 141);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(128, 15);
            this.label7.TabIndex = 18;
            this.label7.Text = "Mulheres Empregados:";
            this.label7.TextAlign = System.Drawing.ContentAlignment.BottomLeft;
            // 
            // porcHDes
            // 
            this.porcHDes.AutoSize = true;
            this.porcHDes.Location = new System.Drawing.Point(453, 54);
            this.porcHDes.Name = "porcHDes";
            this.porcHDes.Size = new System.Drawing.Size(23, 15);
            this.porcHDes.TabIndex = 19;
            this.porcHDes.Text = "0%";
            // 
            // porcHEmp
            // 
            this.porcHEmp.AutoSize = true;
            this.porcHEmp.Location = new System.Drawing.Point(453, 83);
            this.porcHEmp.Name = "porcHEmp";
            this.porcHEmp.Size = new System.Drawing.Size(23, 15);
            this.porcHEmp.TabIndex = 20;
            this.porcHEmp.Text = "0%";
            // 
            // porcMDes
            // 
            this.porcMDes.AutoSize = true;
            this.porcMDes.Location = new System.Drawing.Point(453, 112);
            this.porcMDes.Name = "porcMDes";
            this.porcMDes.Size = new System.Drawing.Size(23, 15);
            this.porcMDes.TabIndex = 21;
            this.porcMDes.Text = "0%";
            // 
            // porcMEmp
            // 
            this.porcMEmp.AutoSize = true;
            this.porcMEmp.Location = new System.Drawing.Point(453, 141);
            this.porcMEmp.Name = "porcMEmp";
            this.porcMEmp.Size = new System.Drawing.Size(23, 15);
            this.porcMEmp.TabIndex = 22;
            this.porcMEmp.Text = "0%";
            // 
            // frmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(737, 368);
            this.Controls.Add(this.porcMEmp);
            this.Controls.Add(this.porcMDes);
            this.Controls.Add(this.porcHEmp);
            this.Controls.Add(this.porcHDes);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.progressBarMEmp);
            this.Controls.Add(this.progressBarMDes);
            this.Controls.Add(this.progressBarHEmp);
            this.Controls.Add(this.progressBarHDes);
            this.Controls.Add(this.btnGeraDados);
            this.Controls.Add(this.dgJovens);
            this.Controls.Add(this.btnNao);
            this.Controls.Add(this.btnSim);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.edtNome);
            this.Controls.Add(this.cboxGen);
            this.Controls.Add(this.btnCad);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "frmMain";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Prova Discursiva";
            this.Load += new System.EventHandler(this.frmMain_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgJovens)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnCad;
        private System.Windows.Forms.ComboBox cboxGen;
        private System.Windows.Forms.TextBox edtNome;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.RadioButton btnSim;
        private System.Windows.Forms.RadioButton btnNao;
        private System.Windows.Forms.DataGridView dgJovens;
        private System.Windows.Forms.Button btnGeraDados;
        private System.Windows.Forms.ProgressBar progressBarHDes;
        private System.Windows.Forms.ProgressBar progressBarHEmp;
        private System.Windows.Forms.ProgressBar progressBarMDes;
        private System.Windows.Forms.ProgressBar progressBarMEmp;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label porcHDes;
        private System.Windows.Forms.Label porcHEmp;
        private System.Windows.Forms.Label porcMDes;
        private System.Windows.Forms.Label porcMEmp;
    }
}

