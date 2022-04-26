namespace PolaczeniaMiast
{
    partial class OknoWyboru
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(OknoWyboru));
            this.label1 = new System.Windows.Forms.Label();
            this.USA = new System.Windows.Forms.Button();
            this.Euro = new System.Windows.Forms.Button();
            this.Skandynawia = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label1.Location = new System.Drawing.Point(275, 28);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(299, 45);
            this.label1.TabIndex = 0;
            this.label1.Text = "Wybierz planszę";
            // 
            // USA
            // 
            this.USA.Image = ((System.Drawing.Image)(resources.GetObject("USA.Image")));
            this.USA.Location = new System.Drawing.Point(319, 91);
            this.USA.Name = "USA";
            this.USA.Size = new System.Drawing.Size(200, 200);
            this.USA.TabIndex = 2;
            this.USA.UseVisualStyleBackColor = false;
            this.USA.Click += new System.EventHandler(this.USA_Click);
            // 
            // Euro
            // 
            this.Euro.Image = ((System.Drawing.Image)(resources.GetObject("Euro.Image")));
            this.Euro.Location = new System.Drawing.Point(33, 91);
            this.Euro.Name = "Euro";
            this.Euro.Size = new System.Drawing.Size(200, 200);
            this.Euro.TabIndex = 1;
            this.Euro.UseVisualStyleBackColor = true;
            this.Euro.Click += new System.EventHandler(this.button1_Click);
            // 
            // Skandynawia
            // 
            this.Skandynawia.Image = ((System.Drawing.Image)(resources.GetObject("Skandynawia.Image")));
            this.Skandynawia.Location = new System.Drawing.Point(607, 91);
            this.Skandynawia.Name = "Skandynawia";
            this.Skandynawia.Size = new System.Drawing.Size(200, 200);
            this.Skandynawia.TabIndex = 3;
            this.Skandynawia.UseVisualStyleBackColor = true;
            this.Skandynawia.Click += new System.EventHandler(this.button1_Click_1);
            // 
            // OknoWyboru
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(850, 542);
            this.Controls.Add(this.Skandynawia);
            this.Controls.Add(this.USA);
            this.Controls.Add(this.Euro);
            this.Controls.Add(this.label1);
            this.Name = "OknoWyboru";
            this.Text = "Wybór tras";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button Euro;
        private System.Windows.Forms.Button USA;
        private System.Windows.Forms.Button Skandynawia;
    }
}