namespace AlgoritmoGenetico
{
    partial class TelaPrincipal
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
            this.components = new System.ComponentModel.Container();
            this.zedPopulacao = new ZedGraph.ZedGraphControl();
            this.zedMediaPopulacao = new ZedGraph.ZedGraphControl();
            this.txtMelhoresIndividuos = new System.Windows.Forms.RichTextBox();
            this.txtPioresIndividuos = new System.Windows.Forms.RichTextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.txtTaxaCrossover = new System.Windows.Forms.MaskedTextBox();
            this.txtTaxaMutacao = new System.Windows.Forms.MaskedTextBox();
            this.txtEvolucoes = new System.Windows.Forms.MaskedTextBox();
            this.btnCriarPop = new System.Windows.Forms.Button();
            this.btnExecutarAG = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // zedPopulacao
            // 
            this.zedPopulacao.Location = new System.Drawing.Point(12, 147);
            this.zedPopulacao.Name = "zedPopulacao";
            this.zedPopulacao.ScrollGrace = 0D;
            this.zedPopulacao.ScrollMaxX = 0D;
            this.zedPopulacao.ScrollMaxY = 0D;
            this.zedPopulacao.ScrollMaxY2 = 0D;
            this.zedPopulacao.ScrollMinX = 0D;
            this.zedPopulacao.ScrollMinY = 0D;
            this.zedPopulacao.ScrollMinY2 = 0D;
            this.zedPopulacao.Size = new System.Drawing.Size(650, 350);
            this.zedPopulacao.TabIndex = 0;
            // 
            // zedMediaPopulacao
            // 
            this.zedMediaPopulacao.Location = new System.Drawing.Point(708, 147);
            this.zedMediaPopulacao.Name = "zedMediaPopulacao";
            this.zedMediaPopulacao.ScrollGrace = 0D;
            this.zedMediaPopulacao.ScrollMaxX = 0D;
            this.zedMediaPopulacao.ScrollMaxY = 0D;
            this.zedMediaPopulacao.ScrollMaxY2 = 0D;
            this.zedMediaPopulacao.ScrollMinX = 0D;
            this.zedMediaPopulacao.ScrollMinY = 0D;
            this.zedMediaPopulacao.ScrollMinY2 = 0D;
            this.zedMediaPopulacao.Size = new System.Drawing.Size(650, 350);
            this.zedMediaPopulacao.TabIndex = 1;
            // 
            // txtMelhoresIndividuos
            // 
            this.txtMelhoresIndividuos.Location = new System.Drawing.Point(12, 555);
            this.txtMelhoresIndividuos.Name = "txtMelhoresIndividuos";
            this.txtMelhoresIndividuos.Size = new System.Drawing.Size(650, 96);
            this.txtMelhoresIndividuos.TabIndex = 2;
            this.txtMelhoresIndividuos.Text = "";
            // 
            // txtPioresIndividuos
            // 
            this.txtPioresIndividuos.Location = new System.Drawing.Point(708, 555);
            this.txtPioresIndividuos.Name = "txtPioresIndividuos";
            this.txtPioresIndividuos.Size = new System.Drawing.Size(650, 96);
            this.txtPioresIndividuos.TabIndex = 3;
            this.txtPioresIndividuos.Text = "";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 522);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(100, 13);
            this.label1.TabIndex = 4;
            this.label1.Text = "Melhores individuos";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(708, 522);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(86, 13);
            this.label2.TabIndex = 5;
            this.label2.Text = "Piores individuos";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 13);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(95, 13);
            this.label3.TabIndex = 6;
            this.label3.Text = "Taxa de crossover";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(12, 52);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(90, 13);
            this.label4.TabIndex = 7;
            this.label4.Text = "Taxa de mutação";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(12, 89);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(57, 13);
            this.label5.TabIndex = 8;
            this.label5.Text = "Evoluções";
            // 
            // txtTaxaCrossover
            // 
            this.txtTaxaCrossover.Location = new System.Drawing.Point(114, 13);
            this.txtTaxaCrossover.Mask = "0.00";
            this.txtTaxaCrossover.Name = "txtTaxaCrossover";
            this.txtTaxaCrossover.Size = new System.Drawing.Size(100, 20);
            this.txtTaxaCrossover.TabIndex = 9;
            this.txtTaxaCrossover.Text = "080";
            // 
            // txtTaxaMutacao
            // 
            this.txtTaxaMutacao.Location = new System.Drawing.Point(114, 49);
            this.txtTaxaMutacao.Mask = "0.00";
            this.txtTaxaMutacao.Name = "txtTaxaMutacao";
            this.txtTaxaMutacao.Size = new System.Drawing.Size(100, 20);
            this.txtTaxaMutacao.TabIndex = 10;
            this.txtTaxaMutacao.Text = "001";
            // 
            // txtEvolucoes
            // 
            this.txtEvolucoes.Location = new System.Drawing.Point(114, 86);
            this.txtEvolucoes.Mask = "00000";
            this.txtEvolucoes.Name = "txtEvolucoes";
            this.txtEvolucoes.Size = new System.Drawing.Size(100, 20);
            this.txtEvolucoes.TabIndex = 11;
            this.txtEvolucoes.Text = "100";
            this.txtEvolucoes.ValidatingType = typeof(int);
            // 
            // btnCriarPop
            // 
            this.btnCriarPop.Location = new System.Drawing.Point(264, 11);
            this.btnCriarPop.Name = "btnCriarPop";
            this.btnCriarPop.Size = new System.Drawing.Size(108, 23);
            this.btnCriarPop.TabIndex = 12;
            this.btnCriarPop.Text = "Criar população";
            this.btnCriarPop.UseVisualStyleBackColor = true;
            this.btnCriarPop.Click += new System.EventHandler(this.btnCriarPop_Click);
            // 
            // btnExecutarAG
            // 
            this.btnExecutarAG.Location = new System.Drawing.Point(264, 84);
            this.btnExecutarAG.Name = "btnExecutarAG";
            this.btnExecutarAG.Size = new System.Drawing.Size(166, 23);
            this.btnExecutarAG.TabIndex = 13;
            this.btnExecutarAG.Text = "Executar Algoritmo Genético";
            this.btnExecutarAG.UseVisualStyleBackColor = true;
            this.btnExecutarAG.Click += new System.EventHandler(this.btnExecutarAG_Click);
            // 
            // TelaPrincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1370, 746);
            this.Controls.Add(this.btnExecutarAG);
            this.Controls.Add(this.btnCriarPop);
            this.Controls.Add(this.txtEvolucoes);
            this.Controls.Add(this.txtTaxaMutacao);
            this.Controls.Add(this.txtTaxaCrossover);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtPioresIndividuos);
            this.Controls.Add(this.txtMelhoresIndividuos);
            this.Controls.Add(this.zedMediaPopulacao);
            this.Controls.Add(this.zedPopulacao);
            this.Name = "TelaPrincipal";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Algortimo Genético";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.TelaPrincipal_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private ZedGraph.ZedGraphControl zedPopulacao;
        private ZedGraph.ZedGraphControl zedMediaPopulacao;
        private System.Windows.Forms.RichTextBox txtMelhoresIndividuos;
        private System.Windows.Forms.RichTextBox txtPioresIndividuos;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.MaskedTextBox txtTaxaCrossover;
        private System.Windows.Forms.MaskedTextBox txtTaxaMutacao;
        private System.Windows.Forms.MaskedTextBox txtEvolucoes;
        private System.Windows.Forms.Button btnCriarPop;
        private System.Windows.Forms.Button btnExecutarAG;
    }
}