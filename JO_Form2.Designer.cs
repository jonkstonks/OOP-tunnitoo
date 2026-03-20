namespace JO_Kursuse
{
    partial class JO_Form2
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
            this.components = new System.ComponentModel.Container();
            this.JO_panel1 = new System.Windows.Forms.Panel();
            this.JO_btnUus = new System.Windows.Forms.Button();
            this.JO_timer1 = new System.Windows.Forms.Timer(this.components);
            this.JO_timer2 = new System.Windows.Forms.Timer(this.components);
            this.SuspendLayout();
            // 
            // JO_panel1
            // 
            this.JO_panel1.BackColor = System.Drawing.Color.Thistle;
            this.JO_panel1.Location = new System.Drawing.Point(100, 117);
            this.JO_panel1.Margin = new System.Windows.Forms.Padding(4);
            this.JO_panel1.Name = "JO_panel1";
            this.JO_panel1.Size = new System.Drawing.Size(684, 439);
            this.JO_panel1.TabIndex = 1;
            // 
            // JO_btnUus
            // 
            this.JO_btnUus.Location = new System.Drawing.Point(100, 31);
            this.JO_btnUus.Margin = new System.Windows.Forms.Padding(4);
            this.JO_btnUus.Name = "JO_btnUus";
            this.JO_btnUus.Size = new System.Drawing.Size(196, 59);
            this.JO_btnUus.TabIndex = 2;
            this.JO_btnUus.Text = "Uus mäng";
            this.JO_btnUus.UseVisualStyleBackColor = true;
            this.JO_btnUus.Click += new System.EventHandler(this.JO_btnUus_Click);
            // 
            // JO_timer1
            // 
            this.JO_timer1.Tick += new System.EventHandler(this.JO_timer1_Tick);
            // 
            // JO_timer2
            // 
            this.JO_timer2.Tick += new System.EventHandler(this.JO_timer2_Tick);
            // 
            // JO_Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 19F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(893, 624);
            this.Controls.Add(this.JO_btnUus);
            this.Controls.Add(this.JO_panel1);
            this.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "JO_Form2";
            this.Text = "JO_Form2";
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Panel JO_panel1;
        private System.Windows.Forms.Button JO_btnUus;
        private System.Windows.Forms.Timer JO_timer1;
        private System.Windows.Forms.Timer JO_timer2;
    }
}