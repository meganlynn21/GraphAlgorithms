namespace GraphAlgorithms
{
    partial class Form1
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
            this.lst = new System.Windows.Forms.ListBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.fromTxtBox = new System.Windows.Forms.TextBox();
            this.toTxtBox = new System.Windows.Forms.TextBox();
            this.searchBtn = new System.Windows.Forms.Button();
            this.AllFlightsBtn = new System.Windows.Forms.Button();
            this.connectingFlightsBtn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lst
            // 
            this.lst.FormattingEnabled = true;
            this.lst.ItemHeight = 25;
            this.lst.Location = new System.Drawing.Point(397, 47);
            this.lst.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.lst.Name = "lst";
            this.lst.Size = new System.Drawing.Size(733, 629);
            this.lst.TabIndex = 0;
            this.lst.SelectedIndexChanged += new System.EventHandler(this.lstBox_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(13, 142);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(42, 25);
            this.label1.TabIndex = 1;
            this.label1.Text = "To: ";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label2.Location = new System.Drawing.Point(13, 47);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(65, 25);
            this.label2.TabIndex = 1;
            this.label2.Text = "From: ";
            // 
            // fromTxtBox
            // 
            this.fromTxtBox.Location = new System.Drawing.Point(84, 47);
            this.fromTxtBox.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.fromTxtBox.Name = "fromTxtBox";
            this.fromTxtBox.Size = new System.Drawing.Size(224, 31);
            this.fromTxtBox.TabIndex = 2;
            // 
            // toTxtBox
            // 
            this.toTxtBox.Location = new System.Drawing.Point(84, 139);
            this.toTxtBox.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.toTxtBox.Name = "toTxtBox";
            this.toTxtBox.Size = new System.Drawing.Size(224, 31);
            this.toTxtBox.TabIndex = 2;
            // 
            // searchBtn
            // 
            this.searchBtn.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.searchBtn.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.searchBtn.Location = new System.Drawing.Point(214, 330);
            this.searchBtn.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.searchBtn.Name = "searchBtn";
            this.searchBtn.Size = new System.Drawing.Size(150, 46);
            this.searchBtn.TabIndex = 3;
            this.searchBtn.Text = "Direct Flights";
            this.searchBtn.UseVisualStyleBackColor = false;
            this.searchBtn.Click += new System.EventHandler(this.searchBtn_Click);
            // 
            // AllFlightsBtn
            // 
            this.AllFlightsBtn.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.AllFlightsBtn.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.AllFlightsBtn.Location = new System.Drawing.Point(112, 197);
            this.AllFlightsBtn.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.AllFlightsBtn.Name = "AllFlightsBtn";
            this.AllFlightsBtn.Size = new System.Drawing.Size(140, 89);
            this.AllFlightsBtn.TabIndex = 3;
            this.AllFlightsBtn.Text = "All Flights";
            this.AllFlightsBtn.UseVisualStyleBackColor = false;
            this.AllFlightsBtn.Click += new System.EventHandler(this.AllFlightsBtn_Click);
            // 
            // connectingFlightsBtn
            // 
            this.connectingFlightsBtn.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.connectingFlightsBtn.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.connectingFlightsBtn.Location = new System.Drawing.Point(13, 330);
            this.connectingFlightsBtn.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.connectingFlightsBtn.Name = "connectingFlightsBtn";
            this.connectingFlightsBtn.Size = new System.Drawing.Size(179, 46);
            this.connectingFlightsBtn.TabIndex = 3;
            this.connectingFlightsBtn.Text = "Connecting Flights";
            this.connectingFlightsBtn.UseVisualStyleBackColor = false;
            this.connectingFlightsBtn.Click += new System.EventHandler(this.connectingFlightsBtn_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.ClientSize = new System.Drawing.Size(1143, 750);
            this.Controls.Add(this.AllFlightsBtn);
            this.Controls.Add(this.connectingFlightsBtn);
            this.Controls.Add(this.searchBtn);
            this.Controls.Add(this.toTxtBox);
            this.Controls.Add(this.fromTxtBox);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lst);
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox lst;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        public System.Windows.Forms.TextBox fromTxtBox;
        public System.Windows.Forms.TextBox toTxtBox;
        private System.Windows.Forms.Button searchBtn;
        private System.Windows.Forms.Button AllFlightsBtn;
        private System.Windows.Forms.Button connectingFlightsBtn;
    }
}
