namespace ProjeSon
{
    partial class CompEmpDate
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
            this.btndatecontinue = new System.Windows.Forms.Button();
            this.lblrandevuisyeri = new System.Windows.Forms.Label();
            this.dtpEmpDate = new System.Windows.Forms.DateTimePicker();
            this.SuspendLayout();
            // 
            // btndatecontinue
            // 
            this.btndatecontinue.BackColor = System.Drawing.Color.Maroon;
            this.btndatecontinue.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btndatecontinue.ForeColor = System.Drawing.Color.Yellow;
            this.btndatecontinue.Location = new System.Drawing.Point(154, 177);
            this.btndatecontinue.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btndatecontinue.Name = "btndatecontinue";
            this.btndatecontinue.Size = new System.Drawing.Size(76, 66);
            this.btndatecontinue.TabIndex = 5;
            this.btndatecontinue.Text = "Devam";
            this.btndatecontinue.UseVisualStyleBackColor = false;
            this.btndatecontinue.Click += new System.EventHandler(this.btndatecontinue_Click);
            // 
            // lblrandevuisyeri
            // 
            this.lblrandevuisyeri.AutoSize = true;
            this.lblrandevuisyeri.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblrandevuisyeri.Location = new System.Drawing.Point(84, 65);
            this.lblrandevuisyeri.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblrandevuisyeri.Name = "lblrandevuisyeri";
            this.lblrandevuisyeri.Size = new System.Drawing.Size(197, 15);
            this.lblrandevuisyeri.TabIndex = 4;
            this.lblrandevuisyeri.Text = "LUTFEN BIR RANDEVU TARIHI SECINIZ";
            // 
            // dtpEmpDate
            // 
            this.dtpEmpDate.Location = new System.Drawing.Point(89, 133);
            this.dtpEmpDate.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.dtpEmpDate.Name = "dtpEmpDate";
            this.dtpEmpDate.Size = new System.Drawing.Size(193, 20);
            this.dtpEmpDate.TabIndex = 3;
            // 
            // CompEmpDate
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(600, 366);
            this.Controls.Add(this.btndatecontinue);
            this.Controls.Add(this.lblrandevuisyeri);
            this.Controls.Add(this.dtpEmpDate);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "CompEmpDate";
            this.Text = "CompEmpDate";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btndatecontinue;
        private System.Windows.Forms.Label lblrandevuisyeri;
        private System.Windows.Forms.DateTimePicker dtpEmpDate;
    }
}