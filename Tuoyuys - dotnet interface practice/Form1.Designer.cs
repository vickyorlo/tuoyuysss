namespace Tuoyuys___dotnet_interface_practice
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
            this.toyBox = new System.Windows.Forms.ListBox();
            this.volumeUpDown = new System.Windows.Forms.NumericUpDown();
            this.speedUpDown = new System.Windows.Forms.NumericUpDown();
            this.openableCheckbox = new System.Windows.Forms.CheckBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.commitChangesButton = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.createToyCombo = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.createToy = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.speedCreateUpDown = new System.Windows.Forms.NumericUpDown();
            this.volumeCreateUpDown = new System.Windows.Forms.NumericUpDown();
            this.openableCreateCheckbox = new System.Windows.Forms.CheckBox();
            ((System.ComponentModel.ISupportInitialize)(this.volumeUpDown)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.speedUpDown)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.speedCreateUpDown)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.volumeCreateUpDown)).BeginInit();
            this.SuspendLayout();
            // 
            // toyBox
            // 
            this.toyBox.DisplayMember = "Name";
            this.toyBox.FormattingEnabled = true;
            this.toyBox.Location = new System.Drawing.Point(3, 13);
            this.toyBox.Name = "toyBox";
            this.toyBox.Size = new System.Drawing.Size(134, 277);
            this.toyBox.TabIndex = 0;
            this.toyBox.SelectedIndexChanged += new System.EventHandler(this.toyBox_SelectedIndexChanged);
            // 
            // volumeUpDown
            // 
            this.volumeUpDown.Location = new System.Drawing.Point(3, 19);
            this.volumeUpDown.Maximum = new decimal(new int[] {
            10000,
            0,
            0,
            0});
            this.volumeUpDown.Name = "volumeUpDown";
            this.volumeUpDown.Size = new System.Drawing.Size(120, 20);
            this.volumeUpDown.TabIndex = 1;
            // 
            // speedUpDown
            // 
            this.speedUpDown.Location = new System.Drawing.Point(3, 45);
            this.speedUpDown.Maximum = new decimal(new int[] {
            10000,
            0,
            0,
            0});
            this.speedUpDown.Name = "speedUpDown";
            this.speedUpDown.Size = new System.Drawing.Size(120, 20);
            this.speedUpDown.TabIndex = 2;
            // 
            // openableCheckbox
            // 
            this.openableCheckbox.AutoSize = true;
            this.openableCheckbox.Location = new System.Drawing.Point(6, 71);
            this.openableCheckbox.Name = "openableCheckbox";
            this.openableCheckbox.Size = new System.Drawing.Size(52, 17);
            this.openableCheckbox.TabIndex = 3;
            this.openableCheckbox.Text = "Open";
            this.openableCheckbox.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(129, 21);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(69, 13);
            this.label1.TabIndex = 4;
            this.label1.Text = "Volume Filled";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(129, 47);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(38, 13);
            this.label2.TabIndex = 5;
            this.label2.Text = "Speed";
            // 
            // commitChangesButton
            // 
            this.commitChangesButton.Location = new System.Drawing.Point(3, 94);
            this.commitChangesButton.Name = "commitChangesButton";
            this.commitChangesButton.Size = new System.Drawing.Size(195, 23);
            this.commitChangesButton.TabIndex = 6;
            this.commitChangesButton.Text = "Commit Toy Change";
            this.commitChangesButton.UseVisualStyleBackColor = true;
            this.commitChangesButton.Click += new System.EventHandler(this.commitChangesButton_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.commitChangesButton);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.volumeUpDown);
            this.groupBox1.Controls.Add(this.speedUpDown);
            this.groupBox1.Controls.Add(this.openableCheckbox);
            this.groupBox1.Location = new System.Drawing.Point(140, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(205, 122);
            this.groupBox1.TabIndex = 7;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Edit selected toy";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.createToyCombo);
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Controls.Add(this.createToy);
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Controls.Add(this.speedCreateUpDown);
            this.groupBox2.Controls.Add(this.volumeCreateUpDown);
            this.groupBox2.Controls.Add(this.openableCreateCheckbox);
            this.groupBox2.Location = new System.Drawing.Point(140, 140);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(205, 151);
            this.groupBox2.TabIndex = 8;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Create new toy";
            // 
            // createToyCombo
            // 
            this.createToyCombo.DisplayMember = "Name";
            this.createToyCombo.FormattingEnabled = true;
            this.createToyCombo.Location = new System.Drawing.Point(7, 20);
            this.createToyCombo.Name = "createToyCombo";
            this.createToyCombo.Size = new System.Drawing.Size(121, 21);
            this.createToyCombo.TabIndex = 12;
            this.createToyCombo.SelectedIndexChanged += new System.EventHandler(this.createToyCombo_SelectedIndexChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(133, 75);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(38, 13);
            this.label3.TabIndex = 11;
            this.label3.Text = "Speed";
            // 
            // createToy
            // 
            this.createToy.Location = new System.Drawing.Point(7, 121);
            this.createToy.Name = "createToy";
            this.createToy.Size = new System.Drawing.Size(191, 23);
            this.createToy.TabIndex = 0;
            this.createToy.Text = "Create a new toy";
            this.createToy.UseVisualStyleBackColor = true;
            this.createToy.Click += new System.EventHandler(this.createToy_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(133, 49);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(69, 13);
            this.label4.TabIndex = 10;
            this.label4.Text = "Volume Filled";
            // 
            // speedCreateUpDown
            // 
            this.speedCreateUpDown.Location = new System.Drawing.Point(7, 73);
            this.speedCreateUpDown.Maximum = new decimal(new int[] {
            10000,
            0,
            0,
            0});
            this.speedCreateUpDown.Name = "speedCreateUpDown";
            this.speedCreateUpDown.Size = new System.Drawing.Size(120, 20);
            this.speedCreateUpDown.TabIndex = 8;
            // 
            // volumeCreateUpDown
            // 
            this.volumeCreateUpDown.Location = new System.Drawing.Point(7, 47);
            this.volumeCreateUpDown.Maximum = new decimal(new int[] {
            10000,
            0,
            0,
            0});
            this.volumeCreateUpDown.Name = "volumeCreateUpDown";
            this.volumeCreateUpDown.Size = new System.Drawing.Size(120, 20);
            this.volumeCreateUpDown.TabIndex = 7;
            // 
            // openableCreateCheckbox
            // 
            this.openableCreateCheckbox.AutoSize = true;
            this.openableCreateCheckbox.Location = new System.Drawing.Point(7, 98);
            this.openableCreateCheckbox.Name = "openableCreateCheckbox";
            this.openableCreateCheckbox.Size = new System.Drawing.Size(52, 17);
            this.openableCreateCheckbox.TabIndex = 9;
            this.openableCreateCheckbox.Text = "Open";
            this.openableCreateCheckbox.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(357, 296);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.toyBox);
            this.Controls.Add(this.groupBox1);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.volumeUpDown)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.speedUpDown)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.speedCreateUpDown)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.volumeCreateUpDown)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListBox toyBox;
        private System.Windows.Forms.NumericUpDown volumeUpDown;
        private System.Windows.Forms.NumericUpDown speedUpDown;
        private System.Windows.Forms.CheckBox openableCheckbox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button commitChangesButton;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.ComboBox createToyCombo;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button createToy;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.NumericUpDown speedCreateUpDown;
        private System.Windows.Forms.NumericUpDown volumeCreateUpDown;
        private System.Windows.Forms.CheckBox openableCreateCheckbox;
    }
}

