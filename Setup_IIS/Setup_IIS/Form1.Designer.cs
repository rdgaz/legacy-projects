namespace Setup_IIS
{
    partial class FormAddSite
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormAddSite));
            this.button1 = new System.Windows.Forms.Button();
            this.tbxNomeSite = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.tbxPorta = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.tbxCaminhoZip = new System.Windows.Forms.TextBox();
            this.btnAdicionar = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label4 = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 5.5F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(218, 144);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(44, 20);
            this.button1.TabIndex = 0;
            this.button1.Text = "...";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // tbxNomeSite
            // 
            this.tbxNomeSite.AccessibleRole = System.Windows.Forms.AccessibleRole.None;
            this.tbxNomeSite.Location = new System.Drawing.Point(8, 95);
            this.tbxNomeSite.Name = "tbxNomeSite";
            this.tbxNomeSite.Size = new System.Drawing.Size(198, 20);
            this.tbxNomeSite.TabIndex = 1;
            this.tbxNomeSite.Text = "wscigamgestor";
            this.tbxNomeSite.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tbxNomeSite_KeyPress);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Klondike Bold", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(8, 79);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(90, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Nome do Site:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Klondike Bold", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(216, 79);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(46, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Porta:";
            // 
            // tbxPorta
            // 
            this.tbxPorta.Location = new System.Drawing.Point(214, 95);
            this.tbxPorta.MaxLength = 5;
            this.tbxPorta.Name = "tbxPorta";
            this.tbxPorta.Size = new System.Drawing.Size(50, 20);
            this.tbxPorta.TabIndex = 4;
            this.tbxPorta.Text = "8090";
            this.tbxPorta.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.tbxPorta.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tbxPorta_KeyPress);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Klondike Bold", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(8, 127);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(53, 13);
            this.label3.TabIndex = 5;
            this.label3.Text = "Arquivo";
            // 
            // tbxCaminhoZip
            // 
            this.tbxCaminhoZip.AccessibleRole = System.Windows.Forms.AccessibleRole.None;
            this.tbxCaminhoZip.Location = new System.Drawing.Point(11, 144);
            this.tbxCaminhoZip.Name = "tbxCaminhoZip";
            this.tbxCaminhoZip.Size = new System.Drawing.Size(195, 20);
            this.tbxCaminhoZip.TabIndex = 6;
            this.tbxCaminhoZip.Text = "WsCigam.zip";
            // 
            // btnAdicionar
            // 
            this.btnAdicionar.Font = new System.Drawing.Font("Klondike Bold", 6F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAdicionar.Location = new System.Drawing.Point(8, 175);
            this.btnAdicionar.Name = "btnAdicionar";
            this.btnAdicionar.Size = new System.Drawing.Size(61, 24);
            this.btnAdicionar.TabIndex = 7;
            this.btnAdicionar.Text = "+ Adcionar";
            this.btnAdicionar.UseVisualStyleBackColor = true;
            this.btnAdicionar.Click += new System.EventHandler(this.btnAdicionar_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Location = new System.Drawing.Point(11, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(251, 52);
            this.groupBox1.TabIndex = 8;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Serviço IIS";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(15, 25);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(35, 13);
            this.label4.TabIndex = 0;
            this.label4.Text = "label4";
            this.label4.Click += new System.EventHandler(this.label4_Click);
            // 
            // FormAddSite
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(268, 203);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.btnAdicionar);
            this.Controls.Add(this.tbxCaminhoZip);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.tbxPorta);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.tbxNomeSite);
            this.Controls.Add(this.button1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FormAddSite";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "...";
            this.Load += new System.EventHandler(this.FormAddSite_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox tbxNomeSite;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox tbxPorta;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox tbxCaminhoZip;
        private System.Windows.Forms.Button btnAdicionar;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label4;
    }
}

