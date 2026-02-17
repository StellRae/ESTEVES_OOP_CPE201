namespace ESTEVES_OOP_CPE201
{
    partial class PrintForm
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
            this.priDisplaListBox = new System.Windows.Forms.ListBox();
            this.SuspendLayout();
            // 
            // priDisplaListBox
            // 
            this.priDisplaListBox.FormattingEnabled = true;
            this.priDisplaListBox.Location = new System.Drawing.Point(12, 12);
            this.priDisplaListBox.Name = "priDisplaListBox";
            this.priDisplaListBox.Size = new System.Drawing.Size(327, 420);
            this.priDisplaListBox.TabIndex = 0;
            // 
            // PrintForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(351, 450);
            this.Controls.Add(this.priDisplaListBox);
            this.Name = "PrintForm";
            this.Text = "Form3";
            this.Load += new System.EventHandler(this.PrintForm_Load);
            this.ResumeLayout(false);

        }

        #endregion

        internal System.Windows.Forms.ListBox priDisplaListBox;
    }
}