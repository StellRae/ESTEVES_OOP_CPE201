namespace ESTEVES_OOP_CPE201
{
    partial class EXAMPLE_6
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
            this.numTimesDisplayTextbox = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.show_btn = new System.Windows.Forms.Button();
            this.countryComboBox = new System.Windows.Forms.ComboBox();
            this.displayListbox = new System.Windows.Forms.ListBox();
            this.SuspendLayout();
            // 
            // numTimesDisplayTextbox
            // 
            this.numTimesDisplayTextbox.Location = new System.Drawing.Point(134, 23);
            this.numTimesDisplayTextbox.Name = "numTimesDisplayTextbox";
            this.numTimesDisplayTextbox.Size = new System.Drawing.Size(119, 20);
            this.numTimesDisplayTextbox.TabIndex = 0;
            this.numTimesDisplayTextbox.TextChanged += new System.EventHandler(this.num_txtbox_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(13, 23);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(115, 16);
            this.label1.TabIndex = 1;
            this.label1.Text = "Enter a number:";
            // 
            // show_btn
            // 
            this.show_btn.Location = new System.Drawing.Point(269, 18);
            this.show_btn.Name = "show_btn";
            this.show_btn.Size = new System.Drawing.Size(93, 29);
            this.show_btn.TabIndex = 2;
            this.show_btn.Text = "SHOW";
            this.show_btn.UseVisualStyleBackColor = true;
            this.show_btn.Click += new System.EventHandler(this.button1_Click);
            // 
            // countryComboBox
            // 
            this.countryComboBox.FormattingEnabled = true;
            this.countryComboBox.Location = new System.Drawing.Point(36, 64);
            this.countryComboBox.Name = "countryComboBox";
            this.countryComboBox.Size = new System.Drawing.Size(306, 21);
            this.countryComboBox.TabIndex = 3;
            this.countryComboBox.SelectedIndexChanged += new System.EventHandler(this.countryComboBox_SelectedIndexChanged);
            // 
            // displayListbox
            // 
            this.displayListbox.FormattingEnabled = true;
            this.displayListbox.Location = new System.Drawing.Point(36, 102);
            this.displayListbox.Name = "displayListbox";
            this.displayListbox.Size = new System.Drawing.Size(306, 264);
            this.displayListbox.TabIndex = 4;
            // 
            // EXAMPLE_6
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(391, 397);
            this.Controls.Add(this.displayListbox);
            this.Controls.Add(this.countryComboBox);
            this.Controls.Add(this.show_btn);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.numTimesDisplayTextbox);
            this.Name = "EXAMPLE_6";
            this.Text = "Form3";
            this.Load += new System.EventHandler(this.EXAMPLE_6_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox numTimesDisplayTextbox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button show_btn;
        private System.Windows.Forms.ComboBox countryComboBox;
        private System.Windows.Forms.ListBox displayListbox;
    }
}