namespace PolaczeniaMiast
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            this.Sprawdzenie = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.NazwaMiasta = new System.Windows.Forms.ComboBox();
            this.Losuj = new System.Windows.Forms.Button();
            this.StacjaZListy = new System.Windows.Forms.CheckBox();
            this.NajkrotszaTrasa = new System.Windows.Forms.Button();
            this.ZmienMape = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // Sprawdzenie
            // 
            this.Sprawdzenie.Font = new System.Drawing.Font("Georgia", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.Sprawdzenie.Location = new System.Drawing.Point(81, 105);
            this.Sprawdzenie.Name = "Sprawdzenie";
            this.Sprawdzenie.Size = new System.Drawing.Size(212, 76);
            this.Sprawdzenie.TabIndex = 0;
            this.Sprawdzenie.Text = "Sprawdź sąsiadów";
            this.Sprawdzenie.UseVisualStyleBackColor = true;
            this.Sprawdzenie.Click += new System.EventHandler(this.button1_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.AllowUserToResizeColumns = false;
            this.dataGridView1.AllowUserToResizeRows = false;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Georgia", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.Black;
            this.dataGridView1.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dataGridView1.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Georgia", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.Desktop;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGridView1.DefaultCellStyle = dataGridViewCellStyle2;
            this.dataGridView1.Location = new System.Drawing.Point(408, 28);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersVisible = false;
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.Size = new System.Drawing.Size(523, 325);
            this.dataGridView1.TabIndex = 1;
            // 
            // NazwaMiasta
            // 
            this.NazwaMiasta.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.NazwaMiasta.FormattingEnabled = true;
            this.NazwaMiasta.Location = new System.Drawing.Point(81, 28);
            this.NazwaMiasta.Name = "NazwaMiasta";
            this.NazwaMiasta.Size = new System.Drawing.Size(212, 33);
            this.NazwaMiasta.TabIndex = 2;
            this.NazwaMiasta.Text = "--Wybierz Miasto--";
            this.NazwaMiasta.SelectedIndexChanged += new System.EventHandler(this.NazwaMiasta_SelectedIndexChanged);
            // 
            // Losuj
            // 
            this.Losuj.Font = new System.Drawing.Font("Georgia", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.Losuj.Location = new System.Drawing.Point(69, 21);
            this.Losuj.Name = "Losuj";
            this.Losuj.Size = new System.Drawing.Size(212, 76);
            this.Losuj.TabIndex = 3;
            this.Losuj.Text = "Losuj Trasę";
            this.Losuj.UseVisualStyleBackColor = true;
            this.Losuj.Click += new System.EventHandler(this.Losuj_Click);
            // 
            // StacjaZListy
            // 
            this.StacjaZListy.AutoSize = true;
            this.StacjaZListy.Font = new System.Drawing.Font("Georgia", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.StacjaZListy.Location = new System.Drawing.Point(21, 103);
            this.StacjaZListy.Name = "StacjaZListy";
            this.StacjaZListy.Size = new System.Drawing.Size(313, 27);
            this.StacjaZListy.TabIndex = 4;
            this.StacjaZListy.Text = "Wybierz stację początkową z listy";
            this.StacjaZListy.UseVisualStyleBackColor = true;
            // 
            // NajkrotszaTrasa
            // 
            this.NajkrotszaTrasa.Enabled = false;
            this.NajkrotszaTrasa.Font = new System.Drawing.Font("Georgia", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.NajkrotszaTrasa.Location = new System.Drawing.Point(81, 359);
            this.NajkrotszaTrasa.Name = "NajkrotszaTrasa";
            this.NajkrotszaTrasa.Size = new System.Drawing.Size(212, 76);
            this.NajkrotszaTrasa.TabIndex = 5;
            this.NajkrotszaTrasa.Text = "Pokaż najkrótszą trasę";
            this.NajkrotszaTrasa.UseVisualStyleBackColor = true;
            this.NajkrotszaTrasa.Click += new System.EventHandler(this.NajkrotszaTrasa_Click);
            // 
            // ZmienMape
            // 
            this.ZmienMape.Font = new System.Drawing.Font("Georgia", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.ZmienMape.Location = new System.Drawing.Point(635, 376);
            this.ZmienMape.Name = "ZmienMape";
            this.ZmienMape.Size = new System.Drawing.Size(132, 59);
            this.ZmienMape.TabIndex = 6;
            this.ZmienMape.Text = "Zmień mapę";
            this.ZmienMape.UseVisualStyleBackColor = true;
            this.ZmienMape.Click += new System.EventHandler(this.ZmienMape_Click);
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Georgia", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.button1.Location = new System.Drawing.Point(799, 376);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(132, 59);
            this.button1.TabIndex = 7;
            this.button1.Text = "Wyjście";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click_1);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.StacjaZListy);
            this.groupBox1.Controls.Add(this.Losuj);
            this.groupBox1.Location = new System.Drawing.Point(12, 200);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(356, 153);
            this.groupBox1.TabIndex = 8;
            this.groupBox1.TabStop = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(957, 455);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.ZmienMape);
            this.Controls.Add(this.NajkrotszaTrasa);
            this.Controls.Add(this.NazwaMiasta);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.Sprawdzenie);
            this.Name = "Form1";
            this.Text = "Wyszukiwanie połączeń";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form1_FormClosing);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button Sprawdzenie;
        private System.Windows.Forms.ComboBox NazwaMiasta;
        private System.Windows.Forms.Button Losuj;
        private System.Windows.Forms.CheckBox StacjaZListy;
        private System.Windows.Forms.Button NajkrotszaTrasa;
        private System.Windows.Forms.Button ZmienMape;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.DataGridView dataGridView1;
    }
}

