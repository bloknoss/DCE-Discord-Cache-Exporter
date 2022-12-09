namespace Discord_Cache_Exporter
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
            this.exportBtn = new System.Windows.Forms.Button();
            this.logger = new System.Windows.Forms.RichTextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.sourcetxt = new System.Windows.Forms.TextBox();
            this.desttxt = new System.Windows.Forms.TextBox();
            this.source = new System.Windows.Forms.FolderBrowserDialog();
            this.destination = new System.Windows.Forms.FolderBrowserDialog();
            this.srcBtn = new System.Windows.Forms.Button();
            this.destBtn = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // exportBtn
            // 
            this.exportBtn.Location = new System.Drawing.Point(12, 582);
            this.exportBtn.Name = "exportBtn";
            this.exportBtn.Size = new System.Drawing.Size(387, 23);
            this.exportBtn.TabIndex = 0;
            this.exportBtn.Text = "Export";
            this.exportBtn.UseVisualStyleBackColor = true;
            this.exportBtn.Click += new System.EventHandler(this.exportCache);
            // 
            // logger
            // 
            this.logger.Location = new System.Drawing.Point(12, 140);
            this.logger.Name = "logger";
            this.logger.Size = new System.Drawing.Size(387, 345);
            this.logger.TabIndex = 1;
            this.logger.Text = "";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Book Antiqua", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(144, 41);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(255, 64);
            this.label1.TabIndex = 3;
            this.label1.Text = "DISCORD CACHE\r\nEXPORTER";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 497);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(44, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "Source:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 536);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(60, 13);
            this.label3.TabIndex = 5;
            this.label3.Text = "Destination";
            // 
            // sourcetxt
            // 
            this.sourcetxt.Location = new System.Drawing.Point(13, 515);
            this.sourcetxt.Name = "sourcetxt";
            this.sourcetxt.ReadOnly = true;
            this.sourcetxt.Size = new System.Drawing.Size(358, 20);
            this.sourcetxt.TabIndex = 6;
            // 
            // desttxt
            // 
            this.desttxt.Location = new System.Drawing.Point(11, 555);
            this.desttxt.Name = "desttxt";
            this.desttxt.ReadOnly = true;
            this.desttxt.Size = new System.Drawing.Size(358, 20);
            this.desttxt.TabIndex = 7;
            // 
            // srcBtn
            // 
            this.srcBtn.Location = new System.Drawing.Point(377, 513);
            this.srcBtn.Name = "srcBtn";
            this.srcBtn.Size = new System.Drawing.Size(24, 23);
            this.srcBtn.TabIndex = 8;
            this.srcBtn.Text = "...";
            this.srcBtn.UseVisualStyleBackColor = true;
            this.srcBtn.Click += new System.EventHandler(this.sourceButton);
            // 
            // destBtn
            // 
            this.destBtn.Location = new System.Drawing.Point(375, 553);
            this.destBtn.Name = "destBtn";
            this.destBtn.Size = new System.Drawing.Size(24, 23);
            this.destBtn.TabIndex = 9;
            this.destBtn.Text = "...";
            this.destBtn.UseVisualStyleBackColor = true;
            this.destBtn.Click += new System.EventHandler(this.destButton);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::Discord_Cache_Exporter.Properties.Resources._636e0a6a49cf127bf92de1e2_icon_clyde_blurple_RGB;
            this.pictureBox1.Location = new System.Drawing.Point(12, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(126, 119);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 2;
            this.pictureBox1.TabStop = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(413, 613);
            this.Controls.Add(this.destBtn);
            this.Controls.Add(this.srcBtn);
            this.Controls.Add(this.desttxt);
            this.Controls.Add(this.sourcetxt);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.logger);
            this.Controls.Add(this.exportBtn);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form1";
            this.Text = "Discord Cache Exporter";
            this.Shown += new System.EventHandler(this.loadFunctions);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button exportBtn;
        private System.Windows.Forms.RichTextBox logger;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox sourcetxt;
        private System.Windows.Forms.TextBox desttxt;
        private System.Windows.Forms.FolderBrowserDialog source;
        private System.Windows.Forms.FolderBrowserDialog destination;
        private System.Windows.Forms.Button srcBtn;
        private System.Windows.Forms.Button destBtn;
    }
}

