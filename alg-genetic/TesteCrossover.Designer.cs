namespace AlgoritmoGenetico
{
    partial class TesteCrossover
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
            this.txtPai = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtMae = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtFilhoPai = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtFilhoMae = new System.Windows.Forms.TextBox();
            this.btnGerar = new System.Windows.Forms.Button();
            this.txtPop = new System.Windows.Forms.RichTextBox();
            this.btnIterar = new System.Windows.Forms.Button();
            this.lblMedia = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(13, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(22, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Pai";
            // 
            // txtPai
            // 
            this.txtPai.Location = new System.Drawing.Point(12, 29);
            this.txtPai.Name = "txtPai";
            this.txtPai.Size = new System.Drawing.Size(759, 20);
            this.txtPai.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 52);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(28, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Mãe";
            // 
            // txtMae
            // 
            this.txtMae.Location = new System.Drawing.Point(12, 68);
            this.txtMae.Name = "txtMae";
            this.txtMae.Size = new System.Drawing.Size(759, 20);
            this.txtMae.TabIndex = 3;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 91);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(47, 13);
            this.label3.TabIndex = 4;
            this.label3.Text = "Filho Pai";
            // 
            // txtFilhoPai
            // 
            this.txtFilhoPai.Location = new System.Drawing.Point(12, 107);
            this.txtFilhoPai.Name = "txtFilhoPai";
            this.txtFilhoPai.Size = new System.Drawing.Size(759, 20);
            this.txtFilhoPai.TabIndex = 5;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(12, 130);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(53, 13);
            this.label4.TabIndex = 6;
            this.label4.Text = "Filho Mãe";
            // 
            // txtFilhoMae
            // 
            this.txtFilhoMae.Location = new System.Drawing.Point(12, 146);
            this.txtFilhoMae.Name = "txtFilhoMae";
            this.txtFilhoMae.Size = new System.Drawing.Size(759, 20);
            this.txtFilhoMae.TabIndex = 7;
            // 
            // btnGerar
            // 
            this.btnGerar.Location = new System.Drawing.Point(352, 463);
            this.btnGerar.Name = "btnGerar";
            this.btnGerar.Size = new System.Drawing.Size(75, 23);
            this.btnGerar.TabIndex = 8;
            this.btnGerar.Text = "GERAR";
            this.btnGerar.UseVisualStyleBackColor = true;
            this.btnGerar.Click += new System.EventHandler(this.btnGerar_Click);
            // 
            // txtPop
            // 
            this.txtPop.Location = new System.Drawing.Point(12, 172);
            this.txtPop.Name = "txtPop";
            this.txtPop.Size = new System.Drawing.Size(759, 285);
            this.txtPop.TabIndex = 9;
            this.txtPop.Text = "";
            // 
            // btnIterar
            // 
            this.btnIterar.Location = new System.Drawing.Point(433, 463);
            this.btnIterar.Name = "btnIterar";
            this.btnIterar.Size = new System.Drawing.Size(75, 23);
            this.btnIterar.TabIndex = 10;
            this.btnIterar.Text = "ITERAR";
            this.btnIterar.UseVisualStyleBackColor = true;
            this.btnIterar.Click += new System.EventHandler(this.btnIterar_Click);
            // 
            // lblMedia
            // 
            this.lblMedia.AutoSize = true;
            this.lblMedia.Location = new System.Drawing.Point(514, 468);
            this.lblMedia.Name = "lblMedia";
            this.lblMedia.Size = new System.Drawing.Size(36, 13);
            this.lblMedia.TabIndex = 11;
            this.lblMedia.Text = "Media";
            // 
            // TesteCrossover
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(783, 498);
            this.Controls.Add(this.lblMedia);
            this.Controls.Add(this.btnIterar);
            this.Controls.Add(this.txtPop);
            this.Controls.Add(this.btnGerar);
            this.Controls.Add(this.txtFilhoMae);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txtFilhoPai);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtMae);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtPai);
            this.Controls.Add(this.label1);
            this.Name = "TesteCrossover";
            this.Text = "TesteCrossover";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtPai;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtMae;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtFilhoPai;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtFilhoMae;
        private System.Windows.Forms.Button btnGerar;
        private System.Windows.Forms.RichTextBox txtPop;
        private System.Windows.Forms.Button btnIterar;
        private System.Windows.Forms.Label lblMedia;
    }
}