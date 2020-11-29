namespace HIMBotTwitch
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
            this.components = new System.ComponentModel.Container();
            this.btnConnect = new System.Windows.Forms.Button();
            this.btnIsLogging = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.btnMsgSent = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.btnPanzer = new System.Windows.Forms.Button();
            this.numericUpDown1 = new System.Windows.Forms.NumericUpDown();
            this.fileSystemWatcher1 = new System.IO.FileSystemWatcher();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.btnAnnounce = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.btnFollow = new System.Windows.Forms.Button();
            this.btnDiscord = new System.Windows.Forms.Button();
            this.btnKappa = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fileSystemWatcher1)).BeginInit();
            this.SuspendLayout();
            // 
            // btnConnect
            // 
            this.btnConnect.Location = new System.Drawing.Point(223, 11);
            this.btnConnect.Name = "btnConnect";
            this.btnConnect.Size = new System.Drawing.Size(117, 32);
            this.btnConnect.TabIndex = 0;
            this.btnConnect.Text = "Connect";
            this.btnConnect.UseVisualStyleBackColor = true;
            this.btnConnect.Click += new System.EventHandler(this.button1_Click);
            // 
            // btnIsLogging
            // 
            this.btnIsLogging.AllowDrop = true;
            this.btnIsLogging.Location = new System.Drawing.Point(346, 11);
            this.btnIsLogging.Name = "btnIsLogging";
            this.btnIsLogging.Size = new System.Drawing.Size(116, 32);
            this.btnIsLogging.TabIndex = 2;
            this.btnIsLogging.Text = "Logs off";
            this.btnIsLogging.UseVisualStyleBackColor = true;
            this.btnIsLogging.Click += new System.EventHandler(this.btnIsLogging_Click);
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(5, 429);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(370, 20);
            this.textBox1.TabIndex = 3;
            this.textBox1.Text = "Chat Message...";
            this.textBox1.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // btnMsgSent
            // 
            this.btnMsgSent.Location = new System.Drawing.Point(381, 429);
            this.btnMsgSent.Name = "btnMsgSent";
            this.btnMsgSent.Size = new System.Drawing.Size(75, 23);
            this.btnMsgSent.TabIndex = 4;
            this.btnMsgSent.Text = "Submit";
            this.btnMsgSent.UseVisualStyleBackColor = true;
            this.btnMsgSent.Click += new System.EventHandler(this.btnMsgSent_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Red;
            this.panel1.Location = new System.Drawing.Point(116, 12);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(100, 16);
            this.panel1.TabIndex = 5;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(12, 12);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(45, 16);
            this.label1.TabIndex = 1;
            this.label1.Text = "Offline";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(13, 34);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(81, 16);
            this.label2.TabIndex = 6;
            this.label2.Text = "Not Logging";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.Red;
            this.panel2.Location = new System.Drawing.Point(117, 34);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(100, 16);
            this.panel2.TabIndex = 7;
            this.panel2.Paint += new System.Windows.Forms.PaintEventHandler(this.panel2_Paint);
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(61, 4);
            // 
            // textBox2
            // 
            this.textBox2.AllowDrop = true;
            this.textBox2.BackColor = System.Drawing.SystemColors.MenuText;
            this.textBox2.ForeColor = System.Drawing.Color.LimeGreen;
            this.textBox2.HideSelection = false;
            this.textBox2.Location = new System.Drawing.Point(468, 11);
            this.textBox2.Multiline = true;
            this.textBox2.Name = "textBox2";
            this.textBox2.ReadOnly = true;
            this.textBox2.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.textBox2.Size = new System.Drawing.Size(254, 438);
            this.textBox2.TabIndex = 9;
            this.textBox2.TextChanged += new System.EventHandler(this.textBox2_TextChanged);
            // 
            // btnPanzer
            // 
            this.btnPanzer.Location = new System.Drawing.Point(19, 312);
            this.btnPanzer.Name = "btnPanzer";
            this.btnPanzer.Size = new System.Drawing.Size(75, 23);
            this.btnPanzer.TabIndex = 10;
            this.btnPanzer.Text = "PANZER!";
            this.btnPanzer.UseVisualStyleBackColor = true;
            this.btnPanzer.Click += new System.EventHandler(this.btnPanzer_Click);
            // 
            // numericUpDown1
            // 
            this.numericUpDown1.Location = new System.Drawing.Point(305, 201);
            this.numericUpDown1.Maximum = new decimal(new int[] {
            600,
            0,
            0,
            0});
            this.numericUpDown1.Name = "numericUpDown1";
            this.numericUpDown1.Size = new System.Drawing.Size(35, 20);
            this.numericUpDown1.TabIndex = 11;
            this.numericUpDown1.Value = new decimal(new int[] {
            60,
            0,
            0,
            0});
            this.numericUpDown1.ValueChanged += new System.EventHandler(this.numericUpDown1_ValueChanged);
            // 
            // fileSystemWatcher1
            // 
            this.fileSystemWatcher1.EnableRaisingEvents = true;
            this.fileSystemWatcher1.SynchronizingObject = this;
            // 
            // textBox3
            // 
            this.textBox3.Location = new System.Drawing.Point(223, 146);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(233, 20);
            this.textBox3.TabIndex = 12;
            this.textBox3.Text = "Announcement...";
            this.textBox3.TextChanged += new System.EventHandler(this.textBox3_TextChanged);
            // 
            // btnAnnounce
            // 
            this.btnAnnounce.Location = new System.Drawing.Point(223, 172);
            this.btnAnnounce.Name = "btnAnnounce";
            this.btnAnnounce.Size = new System.Drawing.Size(117, 23);
            this.btnAnnounce.TabIndex = 13;
            this.btnAnnounce.Text = "Add Announcment";
            this.btnAnnounce.UseVisualStyleBackColor = true;
            this.btnAnnounce.Click += new System.EventHandler(this.button1_Click_1);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Location = new System.Drawing.Point(225, 203);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(74, 13);
            this.label3.TabIndex = 14;
            this.label3.Text = "Repeat every ";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(346, 203);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(46, 13);
            this.label4.TabIndex = 15;
            this.label4.Text = "minutes.";
            // 
            // btnFollow
            // 
            this.btnFollow.Location = new System.Drawing.Point(346, 85);
            this.btnFollow.Name = "btnFollow";
            this.btnFollow.Size = new System.Drawing.Size(75, 23);
            this.btnFollow.TabIndex = 16;
            this.btnFollow.Text = "Follow";
            this.btnFollow.UseVisualStyleBackColor = true;
            this.btnFollow.Click += new System.EventHandler(this.btnFollow_Click);
            // 
            // btnDiscord
            // 
            this.btnDiscord.Location = new System.Drawing.Point(265, 85);
            this.btnDiscord.Name = "btnDiscord";
            this.btnDiscord.Size = new System.Drawing.Size(75, 23);
            this.btnDiscord.TabIndex = 17;
            this.btnDiscord.Text = "Discord";
            this.btnDiscord.UseVisualStyleBackColor = true;
            this.btnDiscord.Click += new System.EventHandler(this.btnDiscord_Click);
            // 
            // btnKappa
            // 
            this.btnKappa.Location = new System.Drawing.Point(19, 341);
            this.btnKappa.Name = "btnKappa";
            this.btnKappa.Size = new System.Drawing.Size(75, 23);
            this.btnKappa.TabIndex = 18;
            this.btnKappa.Text = "Kappa";
            this.btnKappa.UseVisualStyleBackColor = true;
            this.btnKappa.Click += new System.EventHandler(this.btnKappa_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(734, 461);
            this.Controls.Add(this.btnKappa);
            this.Controls.Add(this.btnDiscord);
            this.Controls.Add(this.btnFollow);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.btnAnnounce);
            this.Controls.Add(this.textBox3);
            this.Controls.Add(this.numericUpDown1);
            this.Controls.Add(this.btnPanzer);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.btnMsgSent);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.btnIsLogging);
            this.Controls.Add(this.btnConnect);
            this.Name = "Form1";
            this.Text = "HIM BOT";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fileSystemWatcher1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnConnect;
        private System.Windows.Forms.Button btnIsLogging;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Button btnMsgSent;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Button btnPanzer;
        private System.Windows.Forms.NumericUpDown numericUpDown1;
        private System.IO.FileSystemWatcher fileSystemWatcher1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btnAnnounce;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button btnFollow;
        private System.Windows.Forms.Button btnDiscord;
        private System.Windows.Forms.Button btnKappa;
    }
}

