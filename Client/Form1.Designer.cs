namespace Client
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
            this.btnKeo = new System.Windows.Forms.Button();
            this.btnBao = new System.Windows.Forms.Button();
            this.btnBua = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtChoice = new System.Windows.Forms.TextBox();
            this.txtKq = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtSVC = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // btnKeo
            // 
            this.btnKeo.Location = new System.Drawing.Point(59, 123);
            this.btnKeo.Name = "btnKeo";
            this.btnKeo.Size = new System.Drawing.Size(75, 73);
            this.btnKeo.TabIndex = 0;
            this.btnKeo.Text = "Kéo";
            this.btnKeo.UseVisualStyleBackColor = true;
            this.btnKeo.Click += new System.EventHandler(this.btnKeo_Click);
            // 
            // btnBao
            // 
            this.btnBao.Location = new System.Drawing.Point(220, 123);
            this.btnBao.Name = "btnBao";
            this.btnBao.Size = new System.Drawing.Size(75, 73);
            this.btnBao.TabIndex = 1;
            this.btnBao.Text = "Bao";
            this.btnBao.UseVisualStyleBackColor = true;
            this.btnBao.Click += new System.EventHandler(this.btnBao_Click);
            // 
            // btnBua
            // 
            this.btnBua.Location = new System.Drawing.Point(397, 123);
            this.btnBua.Name = "btnBua";
            this.btnBua.Size = new System.Drawing.Size(75, 73);
            this.btnBua.TabIndex = 2;
            this.btnBua.Text = "Búa";
            this.btnBua.UseVisualStyleBackColor = true;
            this.btnBua.Click += new System.EventHandler(this.btnBua_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(28, 20);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(76, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "Your Selection";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(28, 282);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(62, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "Your Result";
            // 
            // txtChoice
            // 
            this.txtChoice.Location = new System.Drawing.Point(110, 20);
            this.txtChoice.Name = "txtChoice";
            this.txtChoice.Size = new System.Drawing.Size(180, 20);
            this.txtChoice.TabIndex = 5;
            // 
            // txtKq
            // 
            this.txtKq.Location = new System.Drawing.Point(115, 275);
            this.txtKq.Name = "txtKq";
            this.txtKq.Size = new System.Drawing.Size(180, 20);
            this.txtKq.TabIndex = 6;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(28, 218);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(74, 13);
            this.label3.TabIndex = 7;
            this.label3.Text = "Server Choice";
            // 
            // txtSVC
            // 
            this.txtSVC.Location = new System.Drawing.Point(115, 215);
            this.txtSVC.Name = "txtSVC";
            this.txtSVC.Size = new System.Drawing.Size(175, 20);
            this.txtSVC.TabIndex = 8;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(543, 322);
            this.Controls.Add(this.txtSVC);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtKq);
            this.Controls.Add(this.txtChoice);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnBua);
            this.Controls.Add(this.btnBao);
            this.Controls.Add(this.btnKeo);
            this.Name = "Form1";
            this.Text = "Client";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Client);
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnKeo;
        private System.Windows.Forms.Button btnBao;
        private System.Windows.Forms.Button btnBua;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtChoice;
        private System.Windows.Forms.TextBox txtKq;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtSVC;
    }
}

