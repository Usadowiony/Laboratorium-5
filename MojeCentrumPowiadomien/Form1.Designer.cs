namespace MojeCentrumPowiadomien
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
            this.checkBoxPolicja = new System.Windows.Forms.CheckBox();
            this.btnSend = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.textBoxZawiadomienie = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.textBoxPolicja = new System.Windows.Forms.TextBox();
            this.textBoxPogotowieMedyczne = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.checkBoxPogotowieMedyczne = new System.Windows.Forms.CheckBox();
            this.textBoxStrazPozarna = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.checkBox3StrazPozarna = new System.Windows.Forms.CheckBox();
            this.clearPolicja = new System.Windows.Forms.Button();
            this.clearStrazPozarna = new System.Windows.Forms.Button();
            this.clearPogotowieRatownicze = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // checkBoxPolicja
            // 
            this.checkBoxPolicja.AutoSize = true;
            this.checkBoxPolicja.Location = new System.Drawing.Point(54, 195);
            this.checkBoxPolicja.Name = "checkBoxPolicja";
            this.checkBoxPolicja.Size = new System.Drawing.Size(122, 17);
            this.checkBoxPolicja.TabIndex = 0;
            this.checkBoxPolicja.Text = "zawiadom jednostkę";
            this.checkBoxPolicja.UseVisualStyleBackColor = true;
            this.checkBoxPolicja.CheckedChanged += new System.EventHandler(this.checkBoxPolicja_CheckedChanged);
            // 
            // btnSend
            // 
            this.btnSend.Location = new System.Drawing.Point(232, 94);
            this.btnSend.Name = "btnSend";
            this.btnSend.Size = new System.Drawing.Size(89, 28);
            this.btnSend.TabIndex = 3;
            this.btnSend.Text = "Wyślij";
            this.btnSend.UseVisualStyleBackColor = true;
            this.btnSend.Click += new System.EventHandler(this.btnSend_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(52, 177);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(38, 13);
            this.label1.TabIndex = 4;
            this.label1.Text = "Policja";
            // 
            // textBoxZawiadomienie
            // 
            this.textBoxZawiadomienie.Location = new System.Drawing.Point(46, 64);
            this.textBoxZawiadomienie.Multiline = true;
            this.textBoxZawiadomienie.Name = "textBoxZawiadomienie";
            this.textBoxZawiadomienie.Size = new System.Drawing.Size(180, 91);
            this.textBoxZawiadomienie.TabIndex = 7;
            this.textBoxZawiadomienie.TextChanged += new System.EventHandler(this.textBoxZawiadomienie_TextChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(45, 46);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(88, 13);
            this.label4.TabIndex = 11;
            this.label4.Text = "Treść zgłoszenia";
            this.label4.Click += new System.EventHandler(this.label4_Click);
            // 
            // textBoxPolicja
            // 
            this.textBoxPolicja.Location = new System.Drawing.Point(51, 237);
            this.textBoxPolicja.Multiline = true;
            this.textBoxPolicja.Name = "textBoxPolicja";
            this.textBoxPolicja.Size = new System.Drawing.Size(180, 204);
            this.textBoxPolicja.TabIndex = 12;
            // 
            // textBoxPogotowieMedyczne
            // 
            this.textBoxPogotowieMedyczne.Location = new System.Drawing.Point(439, 237);
            this.textBoxPogotowieMedyczne.Multiline = true;
            this.textBoxPogotowieMedyczne.Name = "textBoxPogotowieMedyczne";
            this.textBoxPogotowieMedyczne.Size = new System.Drawing.Size(180, 204);
            this.textBoxPogotowieMedyczne.TabIndex = 15;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(439, 177);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(108, 13);
            this.label2.TabIndex = 14;
            this.label2.Text = "Pogotowie medyczne";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // checkBoxPogotowieMedyczne
            // 
            this.checkBoxPogotowieMedyczne.AutoSize = true;
            this.checkBoxPogotowieMedyczne.Location = new System.Drawing.Point(439, 195);
            this.checkBoxPogotowieMedyczne.Name = "checkBoxPogotowieMedyczne";
            this.checkBoxPogotowieMedyczne.Size = new System.Drawing.Size(122, 17);
            this.checkBoxPogotowieMedyczne.TabIndex = 13;
            this.checkBoxPogotowieMedyczne.Text = "zawiadom jednostkę";
            this.checkBoxPogotowieMedyczne.UseVisualStyleBackColor = true;
            this.checkBoxPogotowieMedyczne.CheckedChanged += new System.EventHandler(this.checkBoxPogotowieMedyczne_CheckedChanged);
            // 
            // textBoxStrazPozarna
            // 
            this.textBoxStrazPozarna.Location = new System.Drawing.Point(245, 237);
            this.textBoxStrazPozarna.Multiline = true;
            this.textBoxStrazPozarna.Name = "textBoxStrazPozarna";
            this.textBoxStrazPozarna.Size = new System.Drawing.Size(180, 204);
            this.textBoxStrazPozarna.TabIndex = 18;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(246, 177);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(72, 13);
            this.label3.TabIndex = 17;
            this.label3.Text = "Straż pożarna";
            // 
            // checkBox3StrazPozarna
            // 
            this.checkBox3StrazPozarna.AutoSize = true;
            this.checkBox3StrazPozarna.Location = new System.Drawing.Point(248, 195);
            this.checkBox3StrazPozarna.Name = "checkBox3StrazPozarna";
            this.checkBox3StrazPozarna.Size = new System.Drawing.Size(122, 17);
            this.checkBox3StrazPozarna.TabIndex = 16;
            this.checkBox3StrazPozarna.Text = "zawiadom jednostkę";
            this.checkBox3StrazPozarna.UseVisualStyleBackColor = true;
            this.checkBox3StrazPozarna.CheckedChanged += new System.EventHandler(this.checkBox3StrazPozarna_CheckedChanged);
            // 
            // clearPolicja
            // 
            this.clearPolicja.Location = new System.Drawing.Point(52, 213);
            this.clearPolicja.Name = "clearPolicja";
            this.clearPolicja.Size = new System.Drawing.Size(89, 21);
            this.clearPolicja.TabIndex = 19;
            this.clearPolicja.Text = "Wyczyść";
            this.clearPolicja.UseVisualStyleBackColor = true;
            this.clearPolicja.Click += new System.EventHandler(this.clearPolicja_Click);
            // 
            // clearStrazPozarna
            // 
            this.clearStrazPozarna.Location = new System.Drawing.Point(246, 213);
            this.clearStrazPozarna.Name = "clearStrazPozarna";
            this.clearStrazPozarna.Size = new System.Drawing.Size(89, 21);
            this.clearStrazPozarna.TabIndex = 20;
            this.clearStrazPozarna.Text = "Wyczyść";
            this.clearStrazPozarna.UseVisualStyleBackColor = true;
            this.clearStrazPozarna.Click += new System.EventHandler(this.clearStrazPozarna_Click);
            // 
            // clearPogotowieRatownicze
            // 
            this.clearPogotowieRatownicze.Location = new System.Drawing.Point(439, 213);
            this.clearPogotowieRatownicze.Name = "clearPogotowieRatownicze";
            this.clearPogotowieRatownicze.Size = new System.Drawing.Size(89, 21);
            this.clearPogotowieRatownicze.TabIndex = 21;
            this.clearPogotowieRatownicze.Text = "Wyczyść";
            this.clearPogotowieRatownicze.UseVisualStyleBackColor = true;
            this.clearPogotowieRatownicze.Click += new System.EventHandler(this.clearPogotowieRatownicze_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(664, 450);
            this.Controls.Add(this.clearPogotowieRatownicze);
            this.Controls.Add(this.clearStrazPozarna);
            this.Controls.Add(this.clearPolicja);
            this.Controls.Add(this.textBoxStrazPozarna);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.checkBox3StrazPozarna);
            this.Controls.Add(this.textBoxPogotowieMedyczne);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.checkBoxPogotowieMedyczne);
            this.Controls.Add(this.textBoxPolicja);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.textBoxZawiadomienie);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnSend);
            this.Controls.Add(this.checkBoxPolicja);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.CheckBox checkBoxPolicja;
        private System.Windows.Forms.Button btnSend;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBoxZawiadomienie;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox textBoxPolicja;
        private System.Windows.Forms.TextBox textBoxPogotowieMedyczne;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.CheckBox checkBoxPogotowieMedyczne;
        private System.Windows.Forms.TextBox textBoxStrazPozarna;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.CheckBox checkBox3StrazPozarna;
        private System.Windows.Forms.Button clearPolicja;
        private System.Windows.Forms.Button clearStrazPozarna;
        private System.Windows.Forms.Button clearPogotowieRatownicze;
    }
}

