namespace Nasljeđivanje
{
    partial class FormKupac
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
            this.textBoxImePrezime = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.textBoxAdresaDostave = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.buttonOK = new System.Windows.Forms.Button();
            this.textBoxWithDefault1 = new Nasljeđivanje.TextBoxWithDefault();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(24, 27);
            this.label1.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(145, 25);
            this.label1.TabIndex = 0;
            this.label1.Text = "&Ime i prezime:";
            // 
            // textBoxImePrezime
            // 
            this.textBoxImePrezime.Location = new System.Drawing.Point(230, 21);
            this.textBoxImePrezime.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.textBoxImePrezime.Name = "textBoxImePrezime";
            this.textBoxImePrezime.Size = new System.Drawing.Size(432, 31);
            this.textBoxImePrezime.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(24, 88);
            this.label2.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(168, 25);
            this.label2.TabIndex = 2;
            this.label2.Text = "&Adresa dostave:";
            // 
            // textBoxAdresaDostave
            // 
            this.textBoxAdresaDostave.Location = new System.Drawing.Point(230, 83);
            this.textBoxAdresaDostave.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.textBoxAdresaDostave.Name = "textBoxAdresaDostave";
            this.textBoxAdresaDostave.Size = new System.Drawing.Size(432, 31);
            this.textBoxAdresaDostave.TabIndex = 3;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(24, 150);
            this.label3.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(158, 25);
            this.label3.TabIndex = 4;
            this.label3.Text = "Adresa &računa:";
            // 
            // buttonOK
            // 
            this.buttonOK.Location = new System.Drawing.Point(516, 275);
            this.buttonOK.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.buttonOK.Name = "buttonOK";
            this.buttonOK.Size = new System.Drawing.Size(150, 44);
            this.buttonOK.TabIndex = 6;
            this.buttonOK.Text = "OK";
            this.buttonOK.UseVisualStyleBackColor = true;
            // 
            // textBoxWithDefault1
            // 
            this.textBoxWithDefault1.Location = new System.Drawing.Point(230, 144);
            this.textBoxWithDefault1.Name = "textBoxWithDefault1";
            this.textBoxWithDefault1.Size = new System.Drawing.Size(432, 31);
            this.textBoxWithDefault1.TabIndex = 7;
            // 
            // FormKupac
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(690, 342);
            this.Controls.Add(this.textBoxWithDefault1);
            this.Controls.Add(this.buttonOK);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.textBoxAdresaDostave);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.textBoxImePrezime);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.Name = "FormKupac";
            this.Text = "Podaci o kupcu";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBoxImePrezime;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textBoxAdresaDostave;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button buttonOK;
        private TextBoxWithDefault textBoxWithDefault1;
    }
}

