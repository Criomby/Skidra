namespace Skidra
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
            this.button9 = new System.Windows.Forms.Button();
            this.linkLabel1 = new System.Windows.Forms.LinkLabel();
            this.label1 = new System.Windows.Forms.Label();
            this.linkLabel2 = new System.Windows.Forms.LinkLabel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.checkBoxExcel = new System.Windows.Forms.CheckBox();
            this.checkBox2 = new System.Windows.Forms.CheckBox();
            this.checkBoxLeads = new System.Windows.Forms.CheckBox();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.checkBoxTop = new System.Windows.Forms.CheckBox();
            this.checkBoxInd = new System.Windows.Forms.CheckBox();
            this.checkBoxLeadInd = new System.Windows.Forms.CheckBox();
            this.checkBoxPit = new System.Windows.Forms.CheckBox();
            this.checkBoxRej = new System.Windows.Forms.CheckBox();
            this.richTextBox1 = new System.Windows.Forms.RichTextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.label2 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.SuspendLayout();
            // 
            // button9
            // 
            this.button9.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(249)))), ((int)(((byte)(246)))), ((int)(((byte)(242)))));
            this.button9.Location = new System.Drawing.Point(40, 238);
            this.button9.Name = "button9";
            this.button9.Size = new System.Drawing.Size(296, 58);
            this.button9.TabIndex = 1;
            this.button9.Text = "Select file";
            this.button9.UseVisualStyleBackColor = false;
            this.button9.Click += new System.EventHandler(this.button9_Click);
            // 
            // linkLabel1
            // 
            this.linkLabel1.AutoSize = true;
            this.linkLabel1.Location = new System.Drawing.Point(184, 9);
            this.linkLabel1.Name = "linkLabel1";
            this.linkLabel1.Size = new System.Drawing.Size(60, 20);
            this.linkLabel1.TabIndex = 12;
            this.linkLabel1.TabStop = true;
            this.linkLabel1.Text = "GitHub";
            this.linkLabel1.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLabel1_LinkClicked);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.ForeColor = System.Drawing.SystemColors.ControlDark;
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(167, 20);
            this.label1.TabIndex = 10;
            this.label1.Text = "Copyright 2022 Braum";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // linkLabel2
            // 
            this.linkLabel2.AutoSize = true;
            this.linkLabel2.Location = new System.Drawing.Point(250, 9);
            this.linkLabel2.Name = "linkLabel2";
            this.linkLabel2.Size = new System.Drawing.Size(67, 20);
            this.linkLabel2.TabIndex = 13;
            this.linkLabel2.TabStop = true;
            this.linkLabel2.Text = "Website";
            this.linkLabel2.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLabel2_LinkClicked);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(106, 54);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(160, 160);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.pictureBox1.TabIndex = 12;
            this.pictureBox1.TabStop = false;
            // 
            // checkBoxExcel
            // 
            this.checkBoxExcel.AutoSize = true;
            this.checkBoxExcel.BackColor = System.Drawing.Color.Transparent;
            this.checkBoxExcel.Location = new System.Drawing.Point(16, 38);
            this.checkBoxExcel.Name = "checkBoxExcel";
            this.checkBoxExcel.Size = new System.Drawing.Size(145, 24);
            this.checkBoxExcel.TabIndex = 2;
            this.checkBoxExcel.Text = "Generate Excel";
            this.checkBoxExcel.UseVisualStyleBackColor = false;
            this.checkBoxExcel.CheckedChanged += new System.EventHandler(this.checkBoxExcel_CheckedChanged);
            // 
            // checkBox2
            // 
            this.checkBox2.AutoSize = true;
            this.checkBox2.Location = new System.Drawing.Point(188, 38);
            this.checkBox2.Name = "checkBox2";
            this.checkBox2.Size = new System.Drawing.Size(64, 24);
            this.checkBox2.TabIndex = 3;
            this.checkBox2.Text = "ALL";
            this.checkBox2.UseVisualStyleBackColor = true;
            this.checkBox2.CheckedChanged += new System.EventHandler(this.checkBox2_CheckedChanged);
            // 
            // checkBoxLeads
            // 
            this.checkBoxLeads.AutoSize = true;
            this.checkBoxLeads.Location = new System.Drawing.Point(188, 102);
            this.checkBoxLeads.Name = "checkBoxLeads";
            this.checkBoxLeads.Size = new System.Drawing.Size(79, 24);
            this.checkBoxLeads.TabIndex = 5;
            this.checkBoxLeads.Text = "Leads";
            this.checkBoxLeads.UseVisualStyleBackColor = true;
            this.checkBoxLeads.CheckedChanged += new System.EventHandler(this.checkBoxLeads_CheckedChanged);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(211)))), ((int)(((byte)(228)))), ((int)(((byte)(205)))));
            this.button1.ForeColor = System.Drawing.Color.Black;
            this.button1.Location = new System.Drawing.Point(40, 622);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(296, 62);
            this.button1.TabIndex = 11;
            this.button1.Text = "Process";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.WhiteSmoke;
            this.button2.Location = new System.Drawing.Point(21, 232);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(255, 42);
            this.button2.TabIndex = 10;
            this.button2.Text = "Reset";
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // checkBoxTop
            // 
            this.checkBoxTop.AutoSize = true;
            this.checkBoxTop.Location = new System.Drawing.Point(188, 143);
            this.checkBoxTop.Name = "checkBoxTop";
            this.checkBoxTop.Size = new System.Drawing.Size(100, 24);
            this.checkBoxTop.TabIndex = 7;
            this.checkBoxTop.Text = "Topleads";
            this.checkBoxTop.UseVisualStyleBackColor = true;
            this.checkBoxTop.CheckedChanged += new System.EventHandler(this.checkBoxTop_CheckedChanged);
            // 
            // checkBoxInd
            // 
            this.checkBoxInd.AutoSize = true;
            this.checkBoxInd.Location = new System.Drawing.Point(16, 102);
            this.checkBoxInd.Name = "checkBoxInd";
            this.checkBoxInd.Size = new System.Drawing.Size(105, 24);
            this.checkBoxInd.TabIndex = 4;
            this.checkBoxInd.Text = "Industries";
            this.checkBoxInd.UseVisualStyleBackColor = true;
            this.checkBoxInd.CheckedChanged += new System.EventHandler(this.checkBoxInd_CheckedChanged);
            // 
            // checkBoxLeadInd
            // 
            this.checkBoxLeadInd.AutoSize = true;
            this.checkBoxLeadInd.Location = new System.Drawing.Point(16, 143);
            this.checkBoxLeadInd.Name = "checkBoxLeadInd";
            this.checkBoxLeadInd.Size = new System.Drawing.Size(108, 24);
            this.checkBoxLeadInd.TabIndex = 6;
            this.checkBoxLeadInd.Text = "Leads/ind.";
            this.checkBoxLeadInd.UseVisualStyleBackColor = true;
            this.checkBoxLeadInd.CheckedChanged += new System.EventHandler(this.checkBoxLeadInd_CheckedChanged);
            // 
            // checkBoxPit
            // 
            this.checkBoxPit.AutoSize = true;
            this.checkBoxPit.Location = new System.Drawing.Point(16, 186);
            this.checkBoxPit.Name = "checkBoxPit";
            this.checkBoxPit.Size = new System.Drawing.Size(87, 24);
            this.checkBoxPit.TabIndex = 8;
            this.checkBoxPit.Text = "Pitches";
            this.checkBoxPit.UseVisualStyleBackColor = true;
            this.checkBoxPit.CheckedChanged += new System.EventHandler(this.checkBoxPit_CheckedChanged);
            // 
            // checkBoxRej
            // 
            this.checkBoxRej.AutoSize = true;
            this.checkBoxRej.Location = new System.Drawing.Point(188, 186);
            this.checkBoxRej.Name = "checkBoxRej";
            this.checkBoxRej.Size = new System.Drawing.Size(99, 24);
            this.checkBoxRej.TabIndex = 9;
            this.checkBoxRej.Text = "Reasons";
            this.checkBoxRej.UseVisualStyleBackColor = true;
            this.checkBoxRej.CheckedChanged += new System.EventHandler(this.checkBoxRej_CheckedChanged);
            // 
            // richTextBox1
            // 
            this.richTextBox1.BackColor = System.Drawing.SystemColors.InactiveBorder;
            this.richTextBox1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.richTextBox1.Location = new System.Drawing.Point(376, 9);
            this.richTextBox1.Name = "richTextBox1";
            this.richTextBox1.ReadOnly = true;
            this.richTextBox1.Size = new System.Drawing.Size(790, 680);
            this.richTextBox1.TabIndex = 24;
            this.richTextBox1.Text = "";
            this.richTextBox1.ZoomFactor = 1.2F;
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.Transparent;
            this.groupBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.groupBox1.Controls.Add(this.checkBoxRej);
            this.groupBox1.Controls.Add(this.checkBoxExcel);
            this.groupBox1.Controls.Add(this.checkBox2);
            this.groupBox1.Controls.Add(this.button2);
            this.groupBox1.Controls.Add(this.checkBoxInd);
            this.groupBox1.Controls.Add(this.checkBoxPit);
            this.groupBox1.Controls.Add(this.checkBoxLeads);
            this.groupBox1.Controls.Add(this.checkBoxTop);
            this.groupBox1.Controls.Add(this.checkBoxLeadInd);
            this.groupBox1.Location = new System.Drawing.Point(40, 312);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(296, 292);
            this.groupBox1.TabIndex = 25;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Options";
            // 
            // pictureBox2
            // 
            this.pictureBox2.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pictureBox2.BackgroundImage")));
            this.pictureBox2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.pictureBox2.Location = new System.Drawing.Point(62, 389);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(165, 10);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.pictureBox2.TabIndex = 26;
            this.pictureBox2.TabStop = false;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.ForeColor = System.Drawing.SystemColors.ControlDark;
            this.label2.Location = new System.Drawing.Point(324, 9);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(38, 20);
            this.label2.TabIndex = 27;
            this.label2.Text = "v1.3";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1179, 702);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.richTextBox1);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.linkLabel2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.linkLabel1);
            this.Controls.Add(this.button9);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form1";
            this.Text = "Skidra";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button button9;
        private System.Windows.Forms.LinkLabel linkLabel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.LinkLabel linkLabel2;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.CheckBox checkBoxExcel;
        private System.Windows.Forms.CheckBox checkBox2;
        private System.Windows.Forms.CheckBox checkBoxLeads;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.CheckBox checkBoxTop;
        private System.Windows.Forms.CheckBox checkBoxInd;
        private System.Windows.Forms.CheckBox checkBoxLeadInd;
        private System.Windows.Forms.CheckBox checkBoxPit;
        private System.Windows.Forms.CheckBox checkBoxRej;
        private System.Windows.Forms.RichTextBox richTextBox1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Label label2;
    }
}

