namespace Traductor
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.btnTranslate = new System.Windows.Forms.Button();
            this.txtTranslator1 = new System.Windows.Forms.TextBox();
            this.txtTranslator2 = new System.Windows.Forms.TextBox();
            this.cmbLanguage = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // btnTranslate
            // 
            this.btnTranslate.Location = new System.Drawing.Point(505, 228);
            this.btnTranslate.Name = "btnTranslate";
            this.btnTranslate.Size = new System.Drawing.Size(75, 23);
            this.btnTranslate.TabIndex = 0;
            this.btnTranslate.Text = "Traducir";
            this.btnTranslate.UseVisualStyleBackColor = true;
            this.btnTranslate.Click += new System.EventHandler(this.btnTranslate_Click);
            // 
            // txtTranslator1
            // 
            this.txtTranslator1.Location = new System.Drawing.Point(12, 12);
            this.txtTranslator1.Multiline = true;
            this.txtTranslator1.Name = "txtTranslator1";
            this.txtTranslator1.Size = new System.Drawing.Size(281, 210);
            this.txtTranslator1.TabIndex = 1;
            // 
            // txtTranslator2
            // 
            this.txtTranslator2.Location = new System.Drawing.Point(299, 12);
            this.txtTranslator2.Multiline = true;
            this.txtTranslator2.Name = "txtTranslator2";
            this.txtTranslator2.Size = new System.Drawing.Size(281, 210);
            this.txtTranslator2.TabIndex = 2;
            // 
            // cmbLanguage
            // 
            this.cmbLanguage.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbLanguage.FormattingEnabled = true;
            this.cmbLanguage.Items.AddRange(new object[] {
            "English/Spanish",
            "Spanish/English"});
            this.cmbLanguage.Location = new System.Drawing.Point(12, 230);
            this.cmbLanguage.Name = "cmbLanguage";
            this.cmbLanguage.Size = new System.Drawing.Size(281, 21);
            this.cmbLanguage.TabIndex = 39;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(585, 256);
            this.Controls.Add(this.cmbLanguage);
            this.Controls.Add(this.txtTranslator2);
            this.Controls.Add(this.txtTranslator1);
            this.Controls.Add(this.btnTranslate);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.Text = "Traductor";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnTranslate;
        private System.Windows.Forms.TextBox txtTranslator1;
        private System.Windows.Forms.TextBox txtTranslator2;
        private System.Windows.Forms.ComboBox cmbLanguage;
    }
}

