namespace KeySender
{
    partial class frmKeyPresser
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.lblTextSource = new System.Windows.Forms.Label();
            this.rbSpecifyText = new System.Windows.Forms.RadioButton();
            this.rbClipboard = new System.Windows.Forms.RadioButton();
            this.txtSpecified = new System.Windows.Forms.TextBox();
            this.lblHotkey = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(17, 109);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(35, 18);
            this.label1.TabIndex = 0;
            this.label1.Text = "Text";
            // 
            // lblTextSource
            // 
            this.lblTextSource.AutoSize = true;
            this.lblTextSource.Font = new System.Drawing.Font("Arial", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblTextSource.Location = new System.Drawing.Point(17, 11);
            this.lblTextSource.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblTextSource.Name = "lblTextSource";
            this.lblTextSource.Size = new System.Drawing.Size(124, 24);
            this.lblTextSource.TabIndex = 1;
            this.lblTextSource.Text = "Text Source";
            // 
            // rbClipboard
            // 
            this.rbClipboard.AutoSize = true;
            this.rbClipboard.Checked = true;
            this.rbClipboard.Location = new System.Drawing.Point(17, 39);
            this.rbClipboard.Name = "rbClipboard";
            this.rbClipboard.Size = new System.Drawing.Size(95, 22);
            this.rbClipboard.TabIndex = 2;
            this.rbClipboard.TabStop = true;
            this.rbClipboard.Text = "Clipboard";
            this.rbClipboard.UseVisualStyleBackColor = true;
            // 
            // rbSpecifyText
            // 
            this.rbSpecifyText.AutoSize = true;
            this.rbSpecifyText.Checked = false;
            this.rbSpecifyText.Location = new System.Drawing.Point(17, 67);
            this.rbSpecifyText.Name = "rbSpecifyText";
            this.rbSpecifyText.Size = new System.Drawing.Size(109, 22);
            this.rbSpecifyText.TabIndex = 2;
            this.rbSpecifyText.TabStop = true;
            this.rbSpecifyText.Text = "Specify Text";
            this.rbSpecifyText.UseVisualStyleBackColor = true;
            // 
            // txtSpecified
            // 
            this.txtSpecified.Location = new System.Drawing.Point(59, 106);
            this.txtSpecified.Name = "txtSpecified";
            this.txtSpecified.Size = new System.Drawing.Size(247, 26);
            this.txtSpecified.TabIndex = 3;
            // 
            // lblHotkey
            // 
            this.lblHotkey.AutoSize = true;
            this.lblHotkey.Location = new System.Drawing.Point(12, 189);
            this.lblHotkey.Name = "lblHotkey";
            this.lblHotkey.Size = new System.Drawing.Size(341, 18);
            this.lblHotkey.TabIndex = 4;
            this.lblHotkey.Text = "Press \"Ctrl+I\" to enter text in another application.";
            // 
            // frmKeyPresser
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Window;
            this.ClientSize = new System.Drawing.Size(356, 216);
            this.Controls.Add(this.lblHotkey);
            this.Controls.Add(this.txtSpecified);
            this.Controls.Add(this.rbClipboard);
            this.Controls.Add(this.rbSpecifyText);
            this.Controls.Add(this.lblTextSource);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "frmKeyPresser";
            this.Text = "Key Presser";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblTextSource;
        private System.Windows.Forms.RadioButton rbClipboard;
        private System.Windows.Forms.RadioButton rbSpecifyText;
        private System.Windows.Forms.TextBox txtSpecified;
        private System.Windows.Forms.Label lblHotkey;
    }
}

