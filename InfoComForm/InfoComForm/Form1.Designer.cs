namespace InfoComForm
{
    partial class Form1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.CbSetor = new System.Windows.Forms.ComboBox();
            this.TbNome = new System.Windows.Forms.TextBox();
            this.TbEmail = new System.Windows.Forms.TextBox();
            this.TbRamal = new System.Windows.Forms.TextBox();
            this.BtnOk = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // CbSetor
            // 
            this.CbSetor.FormattingEnabled = true;
            this.CbSetor.Items.AddRange(new object[] {
            "Área Técnica",
            "Comercial",
            "Desenvolvimento",
            "Financeiro",
            "Qualidade",
            "RH \\ Recpção",
            "HelpDesk",
            "Treinamento"});
            this.CbSetor.Location = new System.Drawing.Point(18, 127);
            this.CbSetor.Name = "CbSetor";
            this.CbSetor.Size = new System.Drawing.Size(136, 21);
            this.CbSetor.TabIndex = 0;
            this.CbSetor.Text = "Nenhum";
            this.CbSetor.SelectedIndexChanged += new System.EventHandler(this.CbSetor_SelectedIndexChanged);
            // 
            // TbNome
            // 
            this.TbNome.Location = new System.Drawing.Point(18, 25);
            this.TbNome.MaxLength = 20;
            this.TbNome.Name = "TbNome";
            this.TbNome.Size = new System.Drawing.Size(179, 20);
            this.TbNome.TabIndex = 1;
            // 
            // TbEmail
            // 
            this.TbEmail.Location = new System.Drawing.Point(17, 76);
            this.TbEmail.MaxLength = 35;
            this.TbEmail.Name = "TbEmail";
            this.TbEmail.Size = new System.Drawing.Size(180, 20);
            this.TbEmail.TabIndex = 2;
            this.TbEmail.TextChanged += new System.EventHandler(this.TbEmail_TextChanged);
            // 
            // TbRamal
            // 
            this.TbRamal.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.TbRamal.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TbRamal.Location = new System.Drawing.Point(18, 181);
            this.TbRamal.MaxLength = 4;
            this.TbRamal.Multiline = true;
            this.TbRamal.Name = "TbRamal";
            this.TbRamal.Size = new System.Drawing.Size(69, 32);
            this.TbRamal.TabIndex = 3;
            this.TbRamal.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.TbRamal.TextChanged += new System.EventHandler(this.TbRamal_TextChanged);
            this.TbRamal.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TbRamal_KeyPress);
            // 
            // BtnOk
            // 
            this.BtnOk.Location = new System.Drawing.Point(103, 181);
            this.BtnOk.Name = "BtnOk";
            this.BtnOk.Size = new System.Drawing.Size(94, 32);
            this.BtnOk.TabIndex = 4;
            this.BtnOk.Text = "Ok";
            this.BtnOk.UseVisualStyleBackColor = true;
            this.BtnOk.Click += new System.EventHandler(this.BtnOk_Click_1);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(15, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(38, 13);
            this.label1.TabIndex = 5;
            this.label1.Text = "Nome:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(15, 60);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(82, 13);
            this.label2.TabIndex = 6;
            this.label2.Text = "Email Completo:";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(15, 111);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(35, 13);
            this.label3.TabIndex = 7;
            this.label3.Text = "Setor:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(15, 165);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(40, 13);
            this.label4.TabIndex = 8;
            this.label4.Text = "Ramal:";
            this.label4.Click += new System.EventHandler(this.label4_Click);
            // 
            // Form1
            // 
            this.AllowDrop = true;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(226, 230);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.BtnOk);
            this.Controls.Add(this.TbRamal);
            this.Controls.Add(this.TbEmail);
            this.Controls.Add(this.TbNome);
            this.Controls.Add(this.CbSetor);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Info Pc";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox CbSetor;
        private System.Windows.Forms.TextBox TbNome;
        private System.Windows.Forms.TextBox TbEmail;
        private System.Windows.Forms.TextBox TbRamal;
        private System.Windows.Forms.Button BtnOk;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
    }
}

