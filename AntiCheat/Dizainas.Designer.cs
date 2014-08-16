namespace AntiCheat
{
    partial class AntiCheat
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AntiCheat));
            this.slapyvardis = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.slaptazodis = new System.Windows.Forms.TextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.yslapt = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.Jungtis = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.lstat = new System.Windows.Forms.Label();
            this.lrez = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.label4 = new System.Windows.Forms.Label();
            this.tray = new System.Windows.Forms.NotifyIcon(this.components);
            this.tray_meniu = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.atkurtiToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.išjungtiToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.tray_meniu.SuspendLayout();
            this.SuspendLayout();
            // 
            // slapyvardis
            // 
            this.slapyvardis.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(186)));
            this.slapyvardis.Location = new System.Drawing.Point(142, 33);
            this.slapyvardis.Name = "slapyvardis";
            this.slapyvardis.Size = new System.Drawing.Size(111, 22);
            this.slapyvardis.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(186)));
            this.label1.Location = new System.Drawing.Point(6, 36);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(63, 16);
            this.label1.TabIndex = 1;
            this.label1.Text = "Your nick";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(186)));
            this.label2.Location = new System.Drawing.Point(6, 92);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(115, 16);
            this.label2.TabIndex = 3;
            this.label2.Text = "Given secret word";
            // 
            // slaptazodis
            // 
            this.slaptazodis.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(186)));
            this.slaptazodis.Location = new System.Drawing.Point(142, 89);
            this.slaptazodis.Name = "slaptazodis";
            this.slaptazodis.PasswordChar = '*';
            this.slaptazodis.Size = new System.Drawing.Size(111, 22);
            this.slaptazodis.TabIndex = 2;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.yslapt);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.Jungtis);
            this.groupBox1.Controls.Add(this.slaptazodis);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.slapyvardis);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(186)));
            this.groupBox1.Location = new System.Drawing.Point(12, 112);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(260, 152);
            this.groupBox1.TabIndex = 4;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Connection data";
            // 
            // yslapt
            // 
            this.yslapt.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(186)));
            this.yslapt.Location = new System.Drawing.Point(142, 61);
            this.yslapt.Name = "yslapt";
            this.yslapt.PasswordChar = '*';
            this.yslapt.Size = new System.Drawing.Size(111, 22);
            this.yslapt.TabIndex = 5;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(186)));
            this.label5.Location = new System.Drawing.Point(6, 64);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(98, 16);
            this.label5.TabIndex = 6;
            this.label5.Text = "Your password";
            // 
            // Jungtis
            // 
            this.Jungtis.Location = new System.Drawing.Point(162, 118);
            this.Jungtis.Name = "Jungtis";
            this.Jungtis.Size = new System.Drawing.Size(92, 28);
            this.Jungtis.TabIndex = 4;
            this.Jungtis.Text = "Connect";
            this.Jungtis.UseVisualStyleBackColor = true;
            this.Jungtis.Click += new System.EventHandler(this.Jungtis_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(186)));
            this.label3.Location = new System.Drawing.Point(6, 30);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(83, 16);
            this.label3.TabIndex = 5;
            this.label3.Text = "Game status";
            // 
            // lstat
            // 
            this.lstat.AutoSize = true;
            this.lstat.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(186)));
            this.lstat.ForeColor = System.Drawing.Color.LightCoral;
            this.lstat.Location = new System.Drawing.Point(174, 30);
            this.lstat.Name = "lstat";
            this.lstat.Size = new System.Drawing.Size(25, 16);
            this.lstat.TabIndex = 6;
            this.lstat.Text = "off";
            // 
            // lrez
            // 
            this.lrez.AutoSize = true;
            this.lrez.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(186)));
            this.lrez.ForeColor = System.Drawing.Color.LightCoral;
            this.lrez.Location = new System.Drawing.Point(174, 56);
            this.lrez.Name = "lrez";
            this.lrez.Size = new System.Drawing.Size(25, 16);
            this.lrez.TabIndex = 8;
            this.lrez.Text = "off";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(186)));
            this.label6.Location = new System.Drawing.Point(6, 56);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(74, 16);
            this.label6.TabIndex = 7;
            this.label6.Text = "Safe mode";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.label6);
            this.groupBox2.Controls.Add(this.lrez);
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Controls.Add(this.lstat);
            this.groupBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(186)));
            this.groupBox2.Location = new System.Drawing.Point(12, 12);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(260, 83);
            this.groupBox2.TabIndex = 9;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Status";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(186)));
            this.label4.Location = new System.Drawing.Point(66, 274);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(145, 15);
            this.label4.TabIndex = 10;
            this.label4.Text = "© http://www.coderland.lt";
            this.label4.Click += new System.EventHandler(this.label4_Click);
            // 
            // tray
            // 
            this.tray.ContextMenuStrip = this.tray_meniu;
            this.tray.Icon = ((System.Drawing.Icon)(resources.GetObject("tray.Icon")));
            this.tray.Text = "AntiCheat";
            this.tray.Visible = true;
            this.tray.DoubleClick += new System.EventHandler(this.tray_DoubleClick);
            // 
            // tray_meniu
            // 
            this.tray_meniu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.atkurtiToolStripMenuItem,
            this.išjungtiToolStripMenuItem});
            this.tray_meniu.Name = "tray_meniu";
            this.tray_meniu.Size = new System.Drawing.Size(114, 48);
            // 
            // atkurtiToolStripMenuItem
            // 
            this.atkurtiToolStripMenuItem.Name = "atkurtiToolStripMenuItem";
            this.atkurtiToolStripMenuItem.Size = new System.Drawing.Size(113, 22);
            this.atkurtiToolStripMenuItem.Text = "Atkurti";
            this.atkurtiToolStripMenuItem.Click += new System.EventHandler(this.atkurtiToolStripMenuItem_Click);
            // 
            // išjungtiToolStripMenuItem
            // 
            this.išjungtiToolStripMenuItem.Name = "išjungtiToolStripMenuItem";
            this.išjungtiToolStripMenuItem.Size = new System.Drawing.Size(113, 22);
            this.išjungtiToolStripMenuItem.Text = "Išjungti";
            this.išjungtiToolStripMenuItem.Click += new System.EventHandler(this.išjungtiToolStripMenuItem_Click);
            // 
            // AntiCheat
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(283, 298);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.groupBox1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(299, 336);
            this.MinimumSize = new System.Drawing.Size(299, 336);
            this.Name = "AntiCheat";
            this.Text = "AntiCheat";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.AntiCheat_FormClosing);
            this.Load += new System.EventHandler(this.AntiCheat_Load);
            this.Resize += new System.EventHandler(this.AntiCheat_Resize);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.tray_meniu.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox slapyvardis;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox slaptazodis;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button Jungtis;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label lstat;
        private System.Windows.Forms.Label lrez;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.NotifyIcon tray;
        private System.Windows.Forms.ContextMenuStrip tray_meniu;
        private System.Windows.Forms.ToolStripMenuItem atkurtiToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem išjungtiToolStripMenuItem;
        private System.Windows.Forms.TextBox yslapt;
        private System.Windows.Forms.Label label5;
    }
}

