namespace PLoops
{
    partial class frmExercício1
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
            this.btnBranco = new System.Windows.Forms.Button();
            this.btnR = new System.Windows.Forms.Button();
            this.btnParLetras = new System.Windows.Forms.Button();
            this.rchtxtFrase = new System.Windows.Forms.RichTextBox();
            this.SuspendLayout();
            // 
            // btnBranco
            // 
            this.btnBranco.Location = new System.Drawing.Point(12, 183);
            this.btnBranco.Name = "btnBranco";
            this.btnBranco.Size = new System.Drawing.Size(158, 67);
            this.btnBranco.TabIndex = 0;
            this.btnBranco.Text = "Espaços em Branco";
            this.btnBranco.UseVisualStyleBackColor = true;
            this.btnBranco.Click += new System.EventHandler(this.btnBranco_Click);
            // 
            // btnR
            // 
            this.btnR.Location = new System.Drawing.Point(245, 183);
            this.btnR.Name = "btnR";
            this.btnR.Size = new System.Drawing.Size(158, 67);
            this.btnR.TabIndex = 1;
            this.btnR.Text = "Quantidade de R";
            this.btnR.UseVisualStyleBackColor = true;
            this.btnR.Click += new System.EventHandler(this.btnR_Click);
            // 
            // btnParLetras
            // 
            this.btnParLetras.Location = new System.Drawing.Point(479, 183);
            this.btnParLetras.Name = "btnParLetras";
            this.btnParLetras.Size = new System.Drawing.Size(158, 67);
            this.btnParLetras.TabIndex = 2;
            this.btnParLetras.Text = "Par de Letras";
            this.btnParLetras.UseVisualStyleBackColor = true;
            // 
            // rchtxtFrase
            // 
            this.rchtxtFrase.Location = new System.Drawing.Point(112, 12);
            this.rchtxtFrase.Name = "rchtxtFrase";
            this.rchtxtFrase.Size = new System.Drawing.Size(433, 96);
            this.rchtxtFrase.TabIndex = 3;
            this.rchtxtFrase.Text = "";
            this.rchtxtFrase.TextChanged += new System.EventHandler(this.rchtxtFrase_TextChanged);
            // 
            // frmExercício1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(649, 262);
            this.Controls.Add(this.rchtxtFrase);
            this.Controls.Add(this.btnParLetras);
            this.Controls.Add(this.btnR);
            this.Controls.Add(this.btnBranco);
            this.Name = "frmExercício1";
            this.Text = "frmExercício1";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnBranco;
        private System.Windows.Forms.Button btnR;
        private System.Windows.Forms.Button btnParLetras;
        private System.Windows.Forms.RichTextBox rchtxtFrase;
    }
}