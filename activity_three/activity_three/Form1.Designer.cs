namespace activity_three
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
            this.japanCheckBox = new System.Windows.Forms.CheckBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.philippinesCheckBox = new System.Windows.Forms.CheckBox();
            this.thailandCheckBox = new System.Windows.Forms.CheckBox();
            this.austriliaCheckBox = new System.Windows.Forms.CheckBox();
            this.othersLabel = new System.Windows.Forms.Label();
            this.othersTextBox = new System.Windows.Forms.TextBox();
            this.submitBtn = new System.Windows.Forms.Button();
            this.closeBtn = new System.Windows.Forms.Button();
            this.othersCheckBox = new System.Windows.Forms.CheckBox();
            this.SuspendLayout();
            // 
            // japanCheckBox
            // 
            this.japanCheckBox.AutoSize = true;
            this.japanCheckBox.Location = new System.Drawing.Point(28, 112);
            this.japanCheckBox.Name = "japanCheckBox";
            this.japanCheckBox.Size = new System.Drawing.Size(55, 17);
            this.japanCheckBox.TabIndex = 0;
            this.japanCheckBox.Text = "Japan";
            this.japanCheckBox.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(23, 26);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(85, 25);
            this.label1.TabIndex = 1;
            this.label1.Text = "Survey";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Tai Le", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(24, 79);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(266, 21);
            this.label2.TabIndex = 2;
            this.label2.Text = "What country would you like to visit?";
            // 
            // philippinesCheckBox
            // 
            this.philippinesCheckBox.AutoSize = true;
            this.philippinesCheckBox.Location = new System.Drawing.Point(28, 135);
            this.philippinesCheckBox.Name = "philippinesCheckBox";
            this.philippinesCheckBox.Size = new System.Drawing.Size(76, 17);
            this.philippinesCheckBox.TabIndex = 3;
            this.philippinesCheckBox.Text = "Philippines";
            this.philippinesCheckBox.UseVisualStyleBackColor = true;
            // 
            // thailandCheckBox
            // 
            this.thailandCheckBox.AutoSize = true;
            this.thailandCheckBox.Location = new System.Drawing.Point(148, 112);
            this.thailandCheckBox.Name = "thailandCheckBox";
            this.thailandCheckBox.Size = new System.Drawing.Size(67, 17);
            this.thailandCheckBox.TabIndex = 4;
            this.thailandCheckBox.Text = "Thailand";
            this.thailandCheckBox.UseVisualStyleBackColor = true;
            // 
            // austriliaCheckBox
            // 
            this.austriliaCheckBox.AutoSize = true;
            this.austriliaCheckBox.Location = new System.Drawing.Point(148, 135);
            this.austriliaCheckBox.Name = "austriliaCheckBox";
            this.austriliaCheckBox.Size = new System.Drawing.Size(62, 17);
            this.austriliaCheckBox.TabIndex = 5;
            this.austriliaCheckBox.Text = "Austrilia";
            this.austriliaCheckBox.UseVisualStyleBackColor = true;
            // 
            // othersLabel
            // 
            this.othersLabel.AutoSize = true;
            this.othersLabel.Font = new System.Drawing.Font("Microsoft Tai Le", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.othersLabel.Location = new System.Drawing.Point(24, 206);
            this.othersLabel.Name = "othersLabel";
            this.othersLabel.Size = new System.Drawing.Size(178, 21);
            this.othersLabel.TabIndex = 6;
            this.othersLabel.Text = "If Others, Please Specify:";
            this.othersLabel.Visible = false;
            // 
            // othersTextBox
            // 
            this.othersTextBox.Location = new System.Drawing.Point(25, 241);
            this.othersTextBox.Name = "othersTextBox";
            this.othersTextBox.Size = new System.Drawing.Size(262, 20);
            this.othersTextBox.TabIndex = 7;
            this.othersTextBox.Visible = false;
            // 
            // submitBtn
            // 
            this.submitBtn.Location = new System.Drawing.Point(23, 280);
            this.submitBtn.Name = "submitBtn";
            this.submitBtn.Size = new System.Drawing.Size(75, 23);
            this.submitBtn.TabIndex = 8;
            this.submitBtn.Text = "Submit";
            this.submitBtn.UseVisualStyleBackColor = true;
            this.submitBtn.Click += new System.EventHandler(this.submitBtn_Click);
            // 
            // closeBtn
            // 
            this.closeBtn.Location = new System.Drawing.Point(131, 280);
            this.closeBtn.Name = "closeBtn";
            this.closeBtn.Size = new System.Drawing.Size(75, 23);
            this.closeBtn.TabIndex = 9;
            this.closeBtn.Text = "Close";
            this.closeBtn.UseVisualStyleBackColor = true;
            this.closeBtn.Click += new System.EventHandler(this.closeBtn_Click);
            // 
            // othersCheckBox
            // 
            this.othersCheckBox.AutoSize = true;
            this.othersCheckBox.Location = new System.Drawing.Point(28, 170);
            this.othersCheckBox.Name = "othersCheckBox";
            this.othersCheckBox.Size = new System.Drawing.Size(57, 17);
            this.othersCheckBox.TabIndex = 10;
            this.othersCheckBox.Text = "Others";
            this.othersCheckBox.UseVisualStyleBackColor = true;
            this.othersCheckBox.CheckedChanged += new System.EventHandler(this.othersCheckBox_CheckedChanged);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(614, 477);
            this.Controls.Add(this.othersCheckBox);
            this.Controls.Add(this.closeBtn);
            this.Controls.Add(this.submitBtn);
            this.Controls.Add(this.othersTextBox);
            this.Controls.Add(this.othersLabel);
            this.Controls.Add(this.austriliaCheckBox);
            this.Controls.Add(this.thailandCheckBox);
            this.Controls.Add(this.philippinesCheckBox);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.japanCheckBox);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.CheckBox japanCheckBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.CheckBox philippinesCheckBox;
        private System.Windows.Forms.CheckBox thailandCheckBox;
        private System.Windows.Forms.CheckBox austriliaCheckBox;
        private System.Windows.Forms.Label othersLabel;
        private System.Windows.Forms.TextBox othersTextBox;
        private System.Windows.Forms.Button submitBtn;
        private System.Windows.Forms.Button closeBtn;
        private System.Windows.Forms.CheckBox othersCheckBox;
    }
}

