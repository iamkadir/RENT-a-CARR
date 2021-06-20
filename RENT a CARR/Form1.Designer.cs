
namespace RENT_a_CARR
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
            this.girisYapButton = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.kaydolButton = new System.Windows.Forms.Button();
            this.sifremiUnuttumButton = new System.Windows.Forms.Button();
            this.kullaniciTextBox = new System.Windows.Forms.TextBox();
            this.sifreTextBox = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // girisYapButton
            // 
            this.girisYapButton.BackColor = System.Drawing.Color.PaleGreen;
            this.girisYapButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.girisYapButton.FlatAppearance.BorderSize = 0;
            this.girisYapButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.girisYapButton.Font = new System.Drawing.Font("Franklin Gothic Book", 12F);
            this.girisYapButton.Location = new System.Drawing.Point(46, 225);
            this.girisYapButton.Margin = new System.Windows.Forms.Padding(4);
            this.girisYapButton.Name = "girisYapButton";
            this.girisYapButton.Size = new System.Drawing.Size(267, 44);
            this.girisYapButton.TabIndex = 0;
            this.girisYapButton.Text = "GİRİŞ YAP";
            this.girisYapButton.UseVisualStyleBackColor = false;
            this.girisYapButton.Click += new System.EventHandler(this.girisYapButton_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Franklin Gothic Book", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(43, 47);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(60, 21);
            this.label1.TabIndex = 1;
            this.label1.Text = "E-posta";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Franklin Gothic Book", 12F);
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(43, 126);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(41, 21);
            this.label2.TabIndex = 2;
            this.label2.Text = "Şifre";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // kaydolButton
            // 
            this.kaydolButton.BackColor = System.Drawing.Color.Coral;
            this.kaydolButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.kaydolButton.FlatAppearance.BorderSize = 0;
            this.kaydolButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.kaydolButton.Font = new System.Drawing.Font("Franklin Gothic Book", 12F);
            this.kaydolButton.Location = new System.Drawing.Point(67, 359);
            this.kaydolButton.Margin = new System.Windows.Forms.Padding(4);
            this.kaydolButton.Name = "kaydolButton";
            this.kaydolButton.Size = new System.Drawing.Size(225, 44);
            this.kaydolButton.TabIndex = 5;
            this.kaydolButton.Text = "Kaydol";
            this.kaydolButton.UseVisualStyleBackColor = false;
            this.kaydolButton.Click += new System.EventHandler(this.button4_Click);
            // 
            // sifremiUnuttumButton
            // 
            this.sifremiUnuttumButton.BackColor = System.Drawing.Color.IndianRed;
            this.sifremiUnuttumButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.sifremiUnuttumButton.FlatAppearance.BorderSize = 0;
            this.sifremiUnuttumButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.sifremiUnuttumButton.Font = new System.Drawing.Font("Franklin Gothic Book", 12F);
            this.sifremiUnuttumButton.Location = new System.Drawing.Point(67, 295);
            this.sifremiUnuttumButton.Margin = new System.Windows.Forms.Padding(4);
            this.sifremiUnuttumButton.Name = "sifremiUnuttumButton";
            this.sifremiUnuttumButton.Size = new System.Drawing.Size(225, 44);
            this.sifremiUnuttumButton.TabIndex = 6;
            this.sifremiUnuttumButton.Text = "Şifremi Unuttum";
            this.sifremiUnuttumButton.UseVisualStyleBackColor = false;
            this.sifremiUnuttumButton.Click += new System.EventHandler(this.button5_Click);
            // 
            // kullaniciTextBox
            // 
            this.kullaniciTextBox.Location = new System.Drawing.Point(46, 74);
            this.kullaniciTextBox.Margin = new System.Windows.Forms.Padding(4);
            this.kullaniciTextBox.Name = "kullaniciTextBox";
            this.kullaniciTextBox.Size = new System.Drawing.Size(265, 27);
            this.kullaniciTextBox.TabIndex = 7;
            // 
            // sifreTextBox
            // 
            this.sifreTextBox.Location = new System.Drawing.Point(46, 151);
            this.sifreTextBox.Margin = new System.Windows.Forms.Padding(4);
            this.sifreTextBox.Name = "sifreTextBox";
            this.sifreTextBox.Size = new System.Drawing.Size(265, 27);
            this.sifreTextBox.TabIndex = 8;
            this.sifreTextBox.UseSystemPasswordChar = true;
            this.sifreTextBox.TextChanged += new System.EventHandler(this.sifreTextBox_TextChanged);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.Transparent;
            this.button1.BackgroundImage = global::RENT_a_CARR.Properties.Resources.closeIcon;
            this.button1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.button1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button1.FlatAppearance.BorderSize = 0;
            this.button1.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.button1.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Location = new System.Drawing.Point(347, 18);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(51, 50);
            this.button1.TabIndex = 31;
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 19F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.BackgroundImage = global::RENT_a_CARR.Properties.Resources.bg;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(410, 464);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.sifreTextBox);
            this.Controls.Add(this.kullaniciTextBox);
            this.Controls.Add(this.sifremiUnuttumButton);
            this.Controls.Add(this.kaydolButton);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.girisYapButton);
            this.Font = new System.Drawing.Font("Corbel", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Giriş Ekranı";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.MouseDown += new System.Windows.Forms.MouseEventHandler(this.Form1_MouseDown);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button girisYapButton;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button kaydolButton;
        private System.Windows.Forms.Button sifremiUnuttumButton;
        private System.Windows.Forms.TextBox kullaniciTextBox;
        private System.Windows.Forms.TextBox sifreTextBox;
        private System.Windows.Forms.Button button1;
    }
}

