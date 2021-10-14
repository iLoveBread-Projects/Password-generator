
namespace PasswordGenerator
{
    partial class frmPassGen
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmPassGen));
            this.chbxUpper = new System.Windows.Forms.CheckBox();
            this.chbxNumbers = new System.Windows.Forms.CheckBox();
            this.chbxSpecial = new System.Windows.Forms.CheckBox();
            this.btnCreate = new System.Windows.Forms.Button();
            this.txtPassword = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.cbxAmount = new System.Windows.Forms.ComboBox();
            this.btnCopy = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // chbxUpper
            // 
            this.chbxUpper.AutoSize = true;
            this.chbxUpper.Location = new System.Drawing.Point(13, 13);
            this.chbxUpper.Name = "chbxUpper";
            this.chbxUpper.Size = new System.Drawing.Size(78, 17);
            this.chbxUpper.TabIndex = 0;
            this.chbxUpper.Text = "Uppercase";
            this.chbxUpper.UseVisualStyleBackColor = true;
            this.chbxUpper.CheckedChanged += new System.EventHandler(this.chbxUpper_CheckedChanged);
            // 
            // chbxNumbers
            // 
            this.chbxNumbers.AutoSize = true;
            this.chbxNumbers.Location = new System.Drawing.Point(13, 37);
            this.chbxNumbers.Name = "chbxNumbers";
            this.chbxNumbers.Size = new System.Drawing.Size(68, 17);
            this.chbxNumbers.TabIndex = 1;
            this.chbxNumbers.Text = "Numbers";
            this.chbxNumbers.UseVisualStyleBackColor = true;
            this.chbxNumbers.CheckedChanged += new System.EventHandler(this.chbxNumbers_CheckedChanged);
            // 
            // chbxSpecial
            // 
            this.chbxSpecial.AutoSize = true;
            this.chbxSpecial.Location = new System.Drawing.Point(13, 61);
            this.chbxSpecial.Name = "chbxSpecial";
            this.chbxSpecial.Size = new System.Drawing.Size(65, 17);
            this.chbxSpecial.TabIndex = 2;
            this.chbxSpecial.Text = "Symbols";
            this.chbxSpecial.UseVisualStyleBackColor = true;
            this.chbxSpecial.CheckedChanged += new System.EventHandler(this.chbxSpecial_CheckedChanged);
            // 
            // btnCreate
            // 
            this.btnCreate.Location = new System.Drawing.Point(144, 60);
            this.btnCreate.Name = "btnCreate";
            this.btnCreate.Size = new System.Drawing.Size(84, 23);
            this.btnCreate.TabIndex = 5;
            this.btnCreate.Text = "Create";
            this.btnCreate.UseVisualStyleBackColor = true;
            this.btnCreate.Click += new System.EventHandler(this.btnCreate_Click_1);
            // 
            // txtPassword
            // 
            this.txtPassword.Location = new System.Drawing.Point(13, 104);
            this.txtPassword.Name = "txtPassword";
            this.txtPassword.ReadOnly = true;
            this.txtPassword.Size = new System.Drawing.Size(215, 20);
            this.txtPassword.TabIndex = 6;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(141, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(87, 13);
            this.label1.TabIndex = 4;
            this.label1.Text = "Amount of chars:";
            // 
            // cbxAmount
            // 
            this.cbxAmount.FormattingEnabled = true;
            this.cbxAmount.Items.AddRange(new object[] {
            "4",
            "6",
            "8"});
            this.cbxAmount.Location = new System.Drawing.Point(144, 33);
            this.cbxAmount.MaxLength = 3;
            this.cbxAmount.Name = "cbxAmount";
            this.cbxAmount.Size = new System.Drawing.Size(84, 21);
            this.cbxAmount.TabIndex = 3;
            // 
            // btnCopy
            // 
            this.btnCopy.Location = new System.Drawing.Point(13, 131);
            this.btnCopy.Name = "btnCopy";
            this.btnCopy.Size = new System.Drawing.Size(215, 23);
            this.btnCopy.TabIndex = 7;
            this.btnCopy.Text = "Copy Password";
            this.btnCopy.UseVisualStyleBackColor = true;
            this.btnCopy.Click += new System.EventHandler(this.btnCopy_Click);
            // 
            // frmPassGen
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(242, 164);
            this.Controls.Add(this.btnCopy);
            this.Controls.Add(this.txtPassword);
            this.Controls.Add(this.btnCreate);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.cbxAmount);
            this.Controls.Add(this.chbxSpecial);
            this.Controls.Add(this.chbxNumbers);
            this.Controls.Add(this.chbxUpper);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmPassGen";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "PassGen";
            this.Load += new System.EventHandler(this.frmPassGen_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.CheckBox chbxUpper;
        private System.Windows.Forms.CheckBox chbxNumbers;
        private System.Windows.Forms.CheckBox chbxSpecial;
        private System.Windows.Forms.Button btnCreate;
        private System.Windows.Forms.TextBox txtPassword;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cbxAmount;
        private System.Windows.Forms.Button btnCopy;
    }
}

