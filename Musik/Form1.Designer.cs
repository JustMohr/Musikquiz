namespace Musik
{
    partial class Form1
    {
        /// <summary>
        /// Erforderliche Designervariable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Verwendete Ressourcen bereinigen.
        /// </summary>
        /// <param name="disposing">True, wenn verwaltete Ressourcen gelöscht werden sollen; andernfalls False.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Vom Windows Form-Designer generierter Code

        /// <summary>
        /// Erforderliche Methode für die Designerunterstützung.
        /// Der Inhalt der Methode darf nicht mit dem Code-Editor geändert werden.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.countdown = new System.Windows.Forms.Timer(this.components);
            this.StQuiz = new System.Windows.Forms.Button();
            this.StLable = new System.Windows.Forms.Label();
            this.timershow = new System.Windows.Forms.Label();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.btn3 = new System.Windows.Forms.Button();
            this.btn1 = new System.Windows.Forms.Button();
            this.btn2 = new System.Windows.Forms.Button();
            this.panelquizelement = new System.Windows.Forms.Panel();
            this.pnltimer = new System.Windows.Forms.Panel();
            this.rf = new System.Windows.Forms.Label();
            this.pretimeshow = new System.Windows.Forms.Label();
            this.readylbl = new System.Windows.Forms.Label();
            this.drei = new System.Windows.Forms.Label();
            this.zwei = new System.Windows.Forms.Label();
            this.eins = new System.Windows.Forms.Label();
            this.lbltext = new System.Windows.Forms.Label();
            this.endpanel = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.lblr = new System.Windows.Forms.Label();
            this.lblf = new System.Windows.Forms.Label();
            this.lblrichtig = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.tableLayoutPanel1.SuspendLayout();
            this.panelquizelement.SuspendLayout();
            this.pnltimer.SuspendLayout();
            this.endpanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // countdown
            // 
            this.countdown.Interval = 1000;
            // 
            // StQuiz
            // 
            this.StQuiz.Font = new System.Drawing.Font("Microsoft Sans Serif", 30.25F);
            this.StQuiz.Location = new System.Drawing.Point(315, 314);
            this.StQuiz.Name = "StQuiz";
            this.StQuiz.Size = new System.Drawing.Size(284, 125);
            this.StQuiz.TabIndex = 1;
            this.StQuiz.Text = "Start";
            this.StQuiz.UseVisualStyleBackColor = true;
            this.StQuiz.Click += new System.EventHandler(this.StQuiz_Click);
            // 
            // StLable
            // 
            this.StLable.AutoSize = true;
            this.StLable.Font = new System.Drawing.Font("Microsoft Sans Serif", 50.25F);
            this.StLable.Location = new System.Drawing.Point(257, 86);
            this.StLable.Name = "StLable";
            this.StLable.Size = new System.Drawing.Size(401, 76);
            this.StLable.TabIndex = 3;
            this.StLable.Text = "Barock-Quiz";
            // 
            // timershow
            // 
            this.timershow.AutoSize = true;
            this.timershow.Font = new System.Drawing.Font("Microsoft Sans Serif", 25F);
            this.timershow.Location = new System.Drawing.Point(12, 9);
            this.timershow.Name = "timershow";
            this.timershow.Size = new System.Drawing.Size(55, 39);
            this.timershow.TabIndex = 0;
            this.timershow.Text = "70";
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 3;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 294F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 282F));
            this.tableLayoutPanel1.Controls.Add(this.btn3, 2, 0);
            this.tableLayoutPanel1.Controls.Add(this.btn1, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.btn2, 1, 0);
            this.tableLayoutPanel1.Location = new System.Drawing.Point(23, 254);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 1;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(868, 278);
            this.tableLayoutPanel1.TabIndex = 1;
            this.tableLayoutPanel1.Paint += new System.Windows.Forms.PaintEventHandler(this.tableLayoutPanel1_Paint);
            // 
            // btn3
            // 
            this.btn3.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btn3.BackgroundImage")));
            this.btn3.Location = new System.Drawing.Point(589, 3);
            this.btn3.Name = "btn3";
            this.btn3.Size = new System.Drawing.Size(270, 270);
            this.btn3.TabIndex = 2;
            this.btn3.UseVisualStyleBackColor = true;
            this.btn3.Click += new System.EventHandler(this.button3_Click);
            // 
            // btn1
            // 
            this.btn1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btn1.BackgroundImage")));
            this.btn1.Location = new System.Drawing.Point(3, 3);
            this.btn1.Name = "btn1";
            this.btn1.Size = new System.Drawing.Size(270, 270);
            this.btn1.TabIndex = 0;
            this.btn1.UseVisualStyleBackColor = true;
            this.btn1.Click += new System.EventHandler(this.button1_Click);
            // 
            // btn2
            // 
            this.btn2.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btn2.BackgroundImage")));
            this.btn2.Location = new System.Drawing.Point(295, 3);
            this.btn2.Name = "btn2";
            this.btn2.Size = new System.Drawing.Size(270, 270);
            this.btn2.TabIndex = 1;
            this.btn2.UseVisualStyleBackColor = true;
            this.btn2.Click += new System.EventHandler(this.button2_Click);
            // 
            // panelquizelement
            // 
            this.panelquizelement.Controls.Add(this.pnltimer);
            this.panelquizelement.Controls.Add(this.drei);
            this.panelquizelement.Controls.Add(this.tableLayoutPanel1);
            this.panelquizelement.Controls.Add(this.timershow);
            this.panelquizelement.Controls.Add(this.zwei);
            this.panelquizelement.Controls.Add(this.eins);
            this.panelquizelement.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelquizelement.Location = new System.Drawing.Point(0, 0);
            this.panelquizelement.Name = "panelquizelement";
            this.panelquizelement.Size = new System.Drawing.Size(914, 561);
            this.panelquizelement.TabIndex = 4;
            this.panelquizelement.Visible = false;
            // 
            // pnltimer
            // 
            this.pnltimer.Controls.Add(this.endpanel);
            this.pnltimer.Controls.Add(this.readylbl);
            this.pnltimer.Controls.Add(this.rf);
            this.pnltimer.Controls.Add(this.pretimeshow);
            this.pnltimer.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnltimer.Location = new System.Drawing.Point(0, 0);
            this.pnltimer.Name = "pnltimer";
            this.pnltimer.Size = new System.Drawing.Size(914, 561);
            this.pnltimer.TabIndex = 2;
            this.pnltimer.Paint += new System.Windows.Forms.PaintEventHandler(this.pnltimer_Paint);
            // 
            // rf
            // 
            this.rf.AutoSize = true;
            this.rf.Font = new System.Drawing.Font("Microsoft Sans Serif", 60.25F);
            this.rf.Location = new System.Drawing.Point(321, 207);
            this.rf.Name = "rf";
            this.rf.Size = new System.Drawing.Size(254, 92);
            this.rf.TabIndex = 2;
            this.rf.Text = "richtig";
            this.rf.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.rf.Visible = false;
            this.rf.Click += new System.EventHandler(this.rf_Click);
            // 
            // pretimeshow
            // 
            this.pretimeshow.AutoSize = true;
            this.pretimeshow.Font = new System.Drawing.Font("Microsoft Sans Serif", 45.25F);
            this.pretimeshow.Location = new System.Drawing.Point(425, 314);
            this.pretimeshow.Name = "pretimeshow";
            this.pretimeshow.Size = new System.Drawing.Size(64, 70);
            this.pretimeshow.TabIndex = 1;
            this.pretimeshow.Text = "3";
            // 
            // readylbl
            // 
            this.readylbl.AutoSize = true;
            this.readylbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 60.25F);
            this.readylbl.Location = new System.Drawing.Point(298, 100);
            this.readylbl.Name = "readylbl";
            this.readylbl.Size = new System.Drawing.Size(318, 92);
            this.readylbl.TabIndex = 0;
            this.readylbl.Text = "Ready?";
            this.readylbl.Click += new System.EventHandler(this.label1_Click_1);
            // 
            // drei
            // 
            this.drei.AutoSize = true;
            this.drei.Font = new System.Drawing.Font("Microsoft Sans Serif", 48F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.drei.Location = new System.Drawing.Point(529, 9);
            this.drei.Name = "drei";
            this.drei.Size = new System.Drawing.Size(69, 73);
            this.drei.TabIndex = 8;
            this.drei.Text = "3";
            // 
            // zwei
            // 
            this.zwei.AutoSize = true;
            this.zwei.Font = new System.Drawing.Font("Microsoft Sans Serif", 48F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.zwei.Location = new System.Drawing.Point(419, 9);
            this.zwei.Name = "zwei";
            this.zwei.Size = new System.Drawing.Size(69, 73);
            this.zwei.TabIndex = 7;
            this.zwei.Text = "2";
            // 
            // eins
            // 
            this.eins.AutoSize = true;
            this.eins.Font = new System.Drawing.Font("Microsoft Sans Serif", 48F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.eins.Location = new System.Drawing.Point(300, 9);
            this.eins.Name = "eins";
            this.eins.Size = new System.Drawing.Size(69, 73);
            this.eins.TabIndex = 6;
            this.eins.Text = "1";
            // 
            // lbltext
            // 
            this.lbltext.AutoSize = true;
            this.lbltext.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F);
            this.lbltext.Location = new System.Drawing.Point(267, 175);
            this.lbltext.Name = "lbltext";
            this.lbltext.Size = new System.Drawing.Size(381, 31);
            this.lbltext.TabIndex = 5;
            this.lbltext.Text = "Welches Bild passt zur Musik?";
            // 
            // endpanel
            // 
            this.endpanel.Controls.Add(this.button1);
            this.endpanel.Controls.Add(this.lblrichtig);
            this.endpanel.Controls.Add(this.lblf);
            this.endpanel.Controls.Add(this.lblr);
            this.endpanel.Controls.Add(this.label1);
            this.endpanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.endpanel.Location = new System.Drawing.Point(0, 0);
            this.endpanel.Name = "endpanel";
            this.endpanel.Size = new System.Drawing.Size(914, 561);
            this.endpanel.TabIndex = 3;
            this.endpanel.Visible = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 50.25F);
            this.label1.Location = new System.Drawing.Point(215, 55);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(484, 76);
            this.label1.TabIndex = 0;
            this.label1.Text = "Dein Ergebniss";
            // 
            // lblr
            // 
            this.lblr.AutoSize = true;
            this.lblr.Font = new System.Drawing.Font("Microsoft Sans Serif", 30.25F);
            this.lblr.Location = new System.Drawing.Point(374, 237);
            this.lblr.Name = "lblr";
            this.lblr.Size = new System.Drawing.Size(166, 47);
            this.lblr.TabIndex = 1;
            this.lblr.Text = "0 richtig";
            // 
            // lblf
            // 
            this.lblf.AutoSize = true;
            this.lblf.Font = new System.Drawing.Font("Microsoft Sans Serif", 30.25F);
            this.lblf.Location = new System.Drawing.Point(376, 325);
            this.lblf.Name = "lblf";
            this.lblf.Size = new System.Drawing.Size(163, 47);
            this.lblf.TabIndex = 2;
            this.lblf.Text = "0 falsch";
            // 
            // lblrichtig
            // 
            this.lblrichtig.AutoSize = true;
            this.lblrichtig.Font = new System.Drawing.Font("Microsoft Sans Serif", 40.25F);
            this.lblrichtig.Location = new System.Drawing.Point(34, 464);
            this.lblrichtig.Name = "lblrichtig";
            this.lblrichtig.Size = new System.Drawing.Size(171, 63);
            this.lblrichtig.TabIndex = 3;
            this.lblrichtig.Text = "Super";
            this.lblrichtig.Visible = false;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(384, 445);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(161, 66);
            this.button1.TabIndex = 4;
            this.button1.Text = "Fertig";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click_1);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(914, 561);
            this.Controls.Add(this.lbltext);
            this.Controls.Add(this.panelquizelement);
            this.Controls.Add(this.StLable);
            this.Controls.Add(this.StQuiz);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.Text = "Barock-Quiz";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.panelquizelement.ResumeLayout(false);
            this.panelquizelement.PerformLayout();
            this.pnltimer.ResumeLayout(false);
            this.pnltimer.PerformLayout();
            this.endpanel.ResumeLayout(false);
            this.endpanel.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Timer countdown;
        private System.Windows.Forms.Button StQuiz;
        private System.Windows.Forms.Label StLable;
        private System.Windows.Forms.Label timershow;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Button btn3;
        private System.Windows.Forms.Button btn1;
        private System.Windows.Forms.Button btn2;
        private System.Windows.Forms.Panel panelquizelement;
        private System.Windows.Forms.Panel pnltimer;
        private System.Windows.Forms.Label readylbl;
        private System.Windows.Forms.Label pretimeshow;
        private System.Windows.Forms.Label rf;
        private System.Windows.Forms.Label drei;
        private System.Windows.Forms.Label zwei;
        private System.Windows.Forms.Label eins;
        private System.Windows.Forms.Label lbltext;
        private System.Windows.Forms.Panel endpanel;
        private System.Windows.Forms.Label lblf;
        private System.Windows.Forms.Label lblr;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblrichtig;
        private System.Windows.Forms.Button button1;
    }
}

