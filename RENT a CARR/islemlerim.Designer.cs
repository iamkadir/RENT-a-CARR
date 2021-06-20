
namespace RENT_a_CARR
{
    partial class islemlerim
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
            this.islemlerimGrid = new System.Windows.Forms.DataGridView();
            this.odemeTamamla_button = new System.Windows.Forms.Button();
            this.label99 = new System.Windows.Forms.Label();
            this.odemeDurumuLabel = new System.Windows.Forms.Label();
            this.odemeDurumuID = new System.Windows.Forms.Label();
            this.odemeDurumuToplamFiyat = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.pictureBox13 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.islemlerimGrid)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox13)).BeginInit();
            this.SuspendLayout();
            // 
            // islemlerimGrid
            // 
            this.islemlerimGrid.AllowUserToAddRows = false;
            this.islemlerimGrid.AllowUserToDeleteRows = false;
            this.islemlerimGrid.AllowUserToResizeColumns = false;
            this.islemlerimGrid.AllowUserToResizeRows = false;
            this.islemlerimGrid.BackgroundColor = System.Drawing.Color.Black;
            this.islemlerimGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.islemlerimGrid.GridColor = System.Drawing.Color.Brown;
            this.islemlerimGrid.Location = new System.Drawing.Point(12, 195);
            this.islemlerimGrid.MultiSelect = false;
            this.islemlerimGrid.Name = "islemlerimGrid";
            this.islemlerimGrid.ReadOnly = true;
            this.islemlerimGrid.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.islemlerimGrid.Size = new System.Drawing.Size(597, 326);
            this.islemlerimGrid.TabIndex = 0;
            this.islemlerimGrid.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            this.islemlerimGrid.CellEnter += new System.Windows.Forms.DataGridViewCellEventHandler(this.islemlerimGrid_CellEnter);
            // 
            // odemeTamamla_button
            // 
            this.odemeTamamla_button.BackColor = System.Drawing.Color.Green;
            this.odemeTamamla_button.Cursor = System.Windows.Forms.Cursors.Hand;
            this.odemeTamamla_button.FlatAppearance.BorderSize = 0;
            this.odemeTamamla_button.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.odemeTamamla_button.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.odemeTamamla_button.ForeColor = System.Drawing.Color.White;
            this.odemeTamamla_button.Location = new System.Drawing.Point(417, 96);
            this.odemeTamamla_button.Name = "odemeTamamla_button";
            this.odemeTamamla_button.Size = new System.Drawing.Size(192, 49);
            this.odemeTamamla_button.TabIndex = 1;
            this.odemeTamamla_button.Text = "ÖDEMEYİ TAMAMLA";
            this.odemeTamamla_button.UseVisualStyleBackColor = false;
            this.odemeTamamla_button.Click += new System.EventHandler(this.odemeTamamla_button_Click);
            // 
            // label99
            // 
            this.label99.AutoSize = true;
            this.label99.BackColor = System.Drawing.Color.Black;
            this.label99.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label99.ForeColor = System.Drawing.Color.White;
            this.label99.Location = new System.Drawing.Point(27, 109);
            this.label99.Name = "label99";
            this.label99.Size = new System.Drawing.Size(179, 20);
            this.label99.TabIndex = 2;
            this.label99.Text = "ÖDENME DURUMU :";
            // 
            // odemeDurumuLabel
            // 
            this.odemeDurumuLabel.AutoSize = true;
            this.odemeDurumuLabel.BackColor = System.Drawing.Color.Black;
            this.odemeDurumuLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.odemeDurumuLabel.ForeColor = System.Drawing.Color.Gold;
            this.odemeDurumuLabel.Location = new System.Drawing.Point(224, 112);
            this.odemeDurumuLabel.Name = "odemeDurumuLabel";
            this.odemeDurumuLabel.Size = new System.Drawing.Size(13, 17);
            this.odemeDurumuLabel.TabIndex = 3;
            this.odemeDurumuLabel.Text = "-";
            // 
            // odemeDurumuID
            // 
            this.odemeDurumuID.AutoSize = true;
            this.odemeDurumuID.Location = new System.Drawing.Point(28, 148);
            this.odemeDurumuID.Name = "odemeDurumuID";
            this.odemeDurumuID.Size = new System.Drawing.Size(35, 13);
            this.odemeDurumuID.TabIndex = 4;
            this.odemeDurumuID.Text = "label1";
            // 
            // odemeDurumuToplamFiyat
            // 
            this.odemeDurumuToplamFiyat.AutoSize = true;
            this.odemeDurumuToplamFiyat.Location = new System.Drawing.Point(88, 148);
            this.odemeDurumuToplamFiyat.Name = "odemeDurumuToplamFiyat";
            this.odemeDurumuToplamFiyat.Size = new System.Drawing.Size(35, 13);
            this.odemeDurumuToplamFiyat.TabIndex = 5;
            this.odemeDurumuToplamFiyat.Text = "label1";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Brown;
            this.panel1.Location = new System.Drawing.Point(-8, -6);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1283, 30);
            this.panel1.TabIndex = 6;
            // 
            // pictureBox13
            // 
            this.pictureBox13.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox13.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pictureBox13.Image = global::RENT_a_CARR.Properties.Resources.goBack;
            this.pictureBox13.Location = new System.Drawing.Point(31, 30);
            this.pictureBox13.Name = "pictureBox13";
            this.pictureBox13.Size = new System.Drawing.Size(55, 46);
            this.pictureBox13.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox13.TabIndex = 68;
            this.pictureBox13.TabStop = false;
            this.pictureBox13.Click += new System.EventHandler(this.pictureBox13_Click);
            // 
            // islemlerim
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Black;
            this.ClientSize = new System.Drawing.Size(623, 533);
            this.Controls.Add(this.pictureBox13);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.odemeDurumuToplamFiyat);
            this.Controls.Add(this.odemeDurumuID);
            this.Controls.Add(this.odemeDurumuLabel);
            this.Controls.Add(this.label99);
            this.Controls.Add(this.odemeTamamla_button);
            this.Controls.Add(this.islemlerimGrid);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "islemlerim";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "islemlerim";
            this.Load += new System.EventHandler(this.islemlerim_Load);
            ((System.ComponentModel.ISupportInitialize)(this.islemlerimGrid)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox13)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView islemlerimGrid;
        private System.Windows.Forms.Button odemeTamamla_button;
        private System.Windows.Forms.Label label99;
        private System.Windows.Forms.Label odemeDurumuLabel;
        private System.Windows.Forms.Label odemeDurumuID;
        private System.Windows.Forms.Label odemeDurumuToplamFiyat;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.PictureBox pictureBox13;
    }
}