namespace MySystem
{
    partial class Form8
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
            this.txtOutput = new System.Windows.Forms.TextBox();
            this.txtOutput2 = new System.Windows.Forms.TextBox();
            this.btnGet = new System.Windows.Forms.Button();
            this.btnGet2 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txtName = new System.Windows.Forms.TextBox();
            this.txtDate = new System.Windows.Forms.TextBox();
            this.txtDesc = new System.Windows.Forms.TextBox();
            this.btnPost = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.txtName2 = new System.Windows.Forms.TextBox();
            this.txtDesc2 = new System.Windows.Forms.TextBox();
            this.txtBudget2 = new System.Windows.Forms.TextBox();
            this.txtStart2 = new System.Windows.Forms.TextBox();
            this.txtEnd2 = new System.Windows.Forms.TextBox();
            this.txtStat2 = new System.Windows.Forms.TextBox();
            this.btnPost2 = new System.Windows.Forms.Button();
            this.label10 = new System.Windows.Forms.Label();
            this.txtId = new System.Windows.Forms.TextBox();
            this.txtId2 = new System.Windows.Forms.TextBox();
            this.txt = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.pictureBox13 = new System.Windows.Forms.PictureBox();
            this.button2 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox13)).BeginInit();
            this.SuspendLayout();
            // 
            // txtOutput
            // 
            this.txtOutput.Location = new System.Drawing.Point(48, 44);
            this.txtOutput.Multiline = true;
            this.txtOutput.Name = "txtOutput";
            this.txtOutput.Size = new System.Drawing.Size(356, 201);
            this.txtOutput.TabIndex = 0;
            this.txtOutput.TextChanged += new System.EventHandler(this.txtOutput_TextChanged);
            // 
            // txtOutput2
            // 
            this.txtOutput2.Location = new System.Drawing.Point(450, 44);
            this.txtOutput2.Multiline = true;
            this.txtOutput2.Name = "txtOutput2";
            this.txtOutput2.Size = new System.Drawing.Size(347, 201);
            this.txtOutput2.TabIndex = 1;
            this.txtOutput2.TextChanged += new System.EventHandler(this.txtOutput2_TextChanged);
            // 
            // btnGet
            // 
            this.btnGet.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.btnGet.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnGet.Location = new System.Drawing.Point(48, 287);
            this.btnGet.Name = "btnGet";
            this.btnGet.Size = new System.Drawing.Size(356, 55);
            this.btnGet.TabIndex = 2;
            this.btnGet.Text = "GET";
            this.btnGet.UseVisualStyleBackColor = false;
            this.btnGet.Click += new System.EventHandler(this.button1_Click);
            // 
            // btnGet2
            // 
            this.btnGet2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.btnGet2.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnGet2.Location = new System.Drawing.Point(450, 287);
            this.btnGet2.Name = "btnGet2";
            this.btnGet2.Size = new System.Drawing.Size(347, 55);
            this.btnGet2.TabIndex = 3;
            this.btnGet2.Text = "GET";
            this.btnGet2.UseVisualStyleBackColor = false;
            this.btnGet2.Click += new System.EventHandler(this.btnGet2_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label1.Location = new System.Drawing.Point(45, 414);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(69, 13);
            this.label1.TabIndex = 4;
            this.label1.Text = "Event Name:";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label2.Location = new System.Drawing.Point(45, 469);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(33, 13);
            this.label2.TabIndex = 5;
            this.label2.Text = "Date:";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label3.Location = new System.Drawing.Point(48, 524);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(63, 13);
            this.label3.TabIndex = 6;
            this.label3.Text = "Description:";
            // 
            // txtName
            // 
            this.txtName.Location = new System.Drawing.Point(121, 414);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(283, 20);
            this.txtName.TabIndex = 7;
            this.txtName.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // txtDate
            // 
            this.txtDate.ForeColor = System.Drawing.Color.Gray;
            this.txtDate.Location = new System.Drawing.Point(121, 469);
            this.txtDate.Name = "txtDate";
            this.txtDate.Size = new System.Drawing.Size(283, 20);
            this.txtDate.TabIndex = 8;
            this.txtDate.Text = "Ex: 2024-06-15";
            // 
            // txtDesc
            // 
            this.txtDesc.Location = new System.Drawing.Point(121, 524);
            this.txtDesc.Name = "txtDesc";
            this.txtDesc.Size = new System.Drawing.Size(283, 20);
            this.txtDesc.TabIndex = 9;
            // 
            // btnPost
            // 
            this.btnPost.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.btnPost.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnPost.Location = new System.Drawing.Point(48, 647);
            this.btnPost.Name = "btnPost";
            this.btnPost.Size = new System.Drawing.Size(356, 55);
            this.btnPost.TabIndex = 10;
            this.btnPost.Text = "POST";
            this.btnPost.UseVisualStyleBackColor = false;
            this.btnPost.Click += new System.EventHandler(this.btnPost_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label4.Location = new System.Drawing.Point(450, 414);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(74, 13);
            this.label4.TabIndex = 11;
            this.label4.Text = "Project Name:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label5.Location = new System.Drawing.Point(450, 446);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(63, 13);
            this.label5.TabIndex = 12;
            this.label5.Text = "Description:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label6.Location = new System.Drawing.Point(450, 476);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(44, 13);
            this.label6.TabIndex = 13;
            this.label6.Text = "Budget:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label7.Location = new System.Drawing.Point(450, 508);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(32, 13);
            this.label7.TabIndex = 14;
            this.label7.Text = "Start:";
            this.label7.Click += new System.EventHandler(this.label7_Click);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label8.Location = new System.Drawing.Point(450, 547);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(29, 13);
            this.label8.TabIndex = 15;
            this.label8.Text = "End:";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label9.Location = new System.Drawing.Point(450, 576);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(37, 13);
            this.label9.TabIndex = 16;
            this.label9.Text = "Status";
            // 
            // txtName2
            // 
            this.txtName2.Location = new System.Drawing.Point(531, 414);
            this.txtName2.Name = "txtName2";
            this.txtName2.Size = new System.Drawing.Size(266, 20);
            this.txtName2.TabIndex = 17;
            // 
            // txtDesc2
            // 
            this.txtDesc2.Location = new System.Drawing.Point(531, 446);
            this.txtDesc2.Name = "txtDesc2";
            this.txtDesc2.Size = new System.Drawing.Size(266, 20);
            this.txtDesc2.TabIndex = 18;
            // 
            // txtBudget2
            // 
            this.txtBudget2.ForeColor = System.Drawing.Color.DimGray;
            this.txtBudget2.Location = new System.Drawing.Point(531, 476);
            this.txtBudget2.Name = "txtBudget2";
            this.txtBudget2.Size = new System.Drawing.Size(266, 20);
            this.txtBudget2.TabIndex = 19;
            this.txtBudget2.Text = "Ex: 2000.00 (Should be Decimal)";
            this.txtBudget2.TextChanged += new System.EventHandler(this.txtBudget2_TextChanged);
            // 
            // txtStart2
            // 
            this.txtStart2.ForeColor = System.Drawing.Color.DimGray;
            this.txtStart2.Location = new System.Drawing.Point(531, 505);
            this.txtStart2.Name = "txtStart2";
            this.txtStart2.Size = new System.Drawing.Size(266, 20);
            this.txtStart2.TabIndex = 20;
            this.txtStart2.Text = "Ex: 2024-06-15";
            // 
            // txtEnd2
            // 
            this.txtEnd2.ForeColor = System.Drawing.Color.DimGray;
            this.txtEnd2.Location = new System.Drawing.Point(531, 544);
            this.txtEnd2.Name = "txtEnd2";
            this.txtEnd2.Size = new System.Drawing.Size(266, 20);
            this.txtEnd2.TabIndex = 21;
            this.txtEnd2.Text = "Ex: 2024-10-05";
            // 
            // txtStat2
            // 
            this.txtStat2.Location = new System.Drawing.Point(531, 576);
            this.txtStat2.Name = "txtStat2";
            this.txtStat2.Size = new System.Drawing.Size(266, 20);
            this.txtStat2.TabIndex = 22;
            // 
            // btnPost2
            // 
            this.btnPost2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.btnPost2.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnPost2.Location = new System.Drawing.Point(453, 647);
            this.btnPost2.Name = "btnPost2";
            this.btnPost2.Size = new System.Drawing.Size(344, 55);
            this.btnPost2.TabIndex = 23;
            this.btnPost2.Text = "POST";
            this.btnPost2.UseVisualStyleBackColor = false;
            this.btnPost2.Click += new System.EventHandler(this.btnPost2_Click);
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label10.Location = new System.Drawing.Point(48, 575);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(66, 13);
            this.label10.TabIndex = 24;
            this.label10.Text = "Barangay id:";
            // 
            // txtId
            // 
            this.txtId.Location = new System.Drawing.Point(121, 568);
            this.txtId.Name = "txtId";
            this.txtId.Size = new System.Drawing.Size(283, 20);
            this.txtId.TabIndex = 25;
            // 
            // txtId2
            // 
            this.txtId2.Location = new System.Drawing.Point(531, 615);
            this.txtId2.Name = "txtId2";
            this.txtId2.Size = new System.Drawing.Size(266, 20);
            this.txtId2.TabIndex = 26;
            // 
            // txt
            // 
            this.txt.AutoSize = true;
            this.txt.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.txt.Location = new System.Drawing.Point(450, 615);
            this.txt.Name = "txt";
            this.txt.Size = new System.Drawing.Size(67, 13);
            this.txt.TabIndex = 27;
            this.txt.Text = "Barangay Id:";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(39, 13);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(41, 13);
            this.label11.TabIndex = 28;
            this.label11.Text = "label11";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.label12.Location = new System.Drawing.Point(136, 13);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(176, 25);
            this.label12.TabIndex = 29;
            this.label12.Text = "Barangay Events";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label13.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.label13.Location = new System.Drawing.Point(537, 13);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(188, 25);
            this.label13.TabIndex = 30;
            this.label13.Text = "Barangay Projects";
            // 
            // pictureBox13
            // 
            this.pictureBox13.Image = global::MySystem.Properties.Resources.humbs;
            this.pictureBox13.Location = new System.Drawing.Point(899, 247);
            this.pictureBox13.Name = "pictureBox13";
            this.pictureBox13.Size = new System.Drawing.Size(322, 367);
            this.pictureBox13.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox13.TabIndex = 33;
            this.pictureBox13.TabStop = false;
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.button2.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.button2.Location = new System.Drawing.Point(1075, 550);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(133, 55);
            this.button2.TabIndex = 34;
            this.button2.Text = "Go Back";
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // Form8
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.ClientSize = new System.Drawing.Size(1297, 732);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.pictureBox13);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.txt);
            this.Controls.Add(this.txtId2);
            this.Controls.Add(this.txtId);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.btnPost2);
            this.Controls.Add(this.txtStat2);
            this.Controls.Add(this.txtEnd2);
            this.Controls.Add(this.txtStart2);
            this.Controls.Add(this.txtBudget2);
            this.Controls.Add(this.txtDesc2);
            this.Controls.Add(this.txtName2);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.btnPost);
            this.Controls.Add(this.txtDesc);
            this.Controls.Add(this.txtDate);
            this.Controls.Add(this.txtName);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnGet2);
            this.Controls.Add(this.btnGet);
            this.Controls.Add(this.txtOutput2);
            this.Controls.Add(this.txtOutput);
            this.Name = "Form8";
            this.Text = "Add Event or Project Form";
            this.Load += new System.EventHandler(this.Form8_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox13)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtOutput;
        private System.Windows.Forms.TextBox txtOutput2;
        private System.Windows.Forms.Button btnGet;
        private System.Windows.Forms.Button btnGet2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.TextBox txtDate;
        private System.Windows.Forms.TextBox txtDesc;
        private System.Windows.Forms.Button btnPost;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox txtName2;
        private System.Windows.Forms.TextBox txtDesc2;
        private System.Windows.Forms.TextBox txtBudget2;
        private System.Windows.Forms.TextBox txtStart2;
        private System.Windows.Forms.TextBox txtEnd2;
        private System.Windows.Forms.TextBox txtStat2;
        private System.Windows.Forms.Button btnPost2;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox txtId;
        private System.Windows.Forms.TextBox txtId2;
        private System.Windows.Forms.Label txt;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.PictureBox pictureBox13;
        private System.Windows.Forms.Button button2;
    }
}