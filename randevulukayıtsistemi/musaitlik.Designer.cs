namespace ProjeSon
{
    partial class musaitlik
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
            this.dgwAppComp = new System.Windows.Forms.DataGridView();
            this.button1 = new System.Windows.Forms.Button();
            this.txtCompEmpAppAv = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgwAppComp)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.Location = new System.Drawing.Point(102, 26);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(341, 15);
            this.label1.TabIndex = 0;
            this.label1.Text = "Müsaıt olmayan randevuları belirlemek için talımatları izleyınız.";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // dgwAppComp
            // 
            this.dgwAppComp.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgwAppComp.Location = new System.Drawing.Point(36, 80);
            this.dgwAppComp.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.dgwAppComp.Name = "dgwAppComp";
            this.dgwAppComp.RowHeadersWidth = 51;
            this.dgwAppComp.RowTemplate.Height = 24;
            this.dgwAppComp.Size = new System.Drawing.Size(471, 165);
            this.dgwAppComp.TabIndex = 1;
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.Maroon;
            this.button1.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.button1.ForeColor = System.Drawing.Color.Yellow;
            this.button1.Location = new System.Drawing.Point(364, 346);
            this.button1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(115, 53);
            this.button1.TabIndex = 2;
            this.button1.Text = "button1";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // txtCompEmpAppAv
            // 
            this.txtCompEmpAppAv.Location = new System.Drawing.Point(63, 363);
            this.txtCompEmpAppAv.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txtCompEmpAppAv.Name = "txtCompEmpAppAv";
            this.txtCompEmpAppAv.Size = new System.Drawing.Size(135, 20);
            this.txtCompEmpAppAv.TabIndex = 3;
            // 
            // musaitlik
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(775, 524);
            this.Controls.Add(this.txtCompEmpAppAv);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.dgwAppComp);
            this.Controls.Add(this.label1);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "musaitlik";
            this.Text = "musaitlik";
            this.Load += new System.EventHandler(this.musaitlik_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgwAppComp)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dgwAppComp;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox txtCompEmpAppAv;
    }
}