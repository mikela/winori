namespace Winori
{
    partial class MainForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.mouseKeyEventProvider1 = new MouseKeyboardActivityMonitor.Controls.MouseKeyEventProvider();
            this.label1 = new System.Windows.Forms.Label();
            this.notifyIcon = new System.Windows.Forms.NotifyIcon(this.components);
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.label2 = new System.Windows.Forms.Label();
            this.pictureBoxCC = new System.Windows.Forms.PictureBox();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.panelDL = new System.Windows.Forms.Panel();
            this.labelDL = new System.Windows.Forms.Label();
            this.buttonDL = new System.Windows.Forms.Button();
            this.panelDR = new System.Windows.Forms.Panel();
            this.labelDR = new System.Windows.Forms.Label();
            this.buttonDR = new System.Windows.Forms.Button();
            this.panelUL = new System.Windows.Forms.Panel();
            this.labelUL = new System.Windows.Forms.Label();
            this.buttonUL = new System.Windows.Forms.Button();
            this.panelUR = new System.Windows.Forms.Panel();
            this.labelUR = new System.Windows.Forms.Label();
            this.buttonUR = new System.Windows.Forms.Button();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxCC)).BeginInit();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            this.panelDL.SuspendLayout();
            this.panelDR.SuspendLayout();
            this.panelUL.SuspendLayout();
            this.panelUR.SuspendLayout();
            this.tabPage2.SuspendLayout();
            this.SuspendLayout();
            // 
            // mouseKeyEventProvider1
            // 
            this.mouseKeyEventProvider1.Enabled = false;
            this.mouseKeyEventProvider1.HookType = MouseKeyboardActivityMonitor.Controls.HookType.Global;
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(86, 25);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(107, 35);
            this.label1.TabIndex = 1;
            this.label1.Text = "Winori v1.0 \r\nby Mikel Anabitarte";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // notifyIcon
            // 
            this.notifyIcon.BalloonTipIcon = System.Windows.Forms.ToolTipIcon.Info;
            this.notifyIcon.BalloonTipText = "Double click here to configure";
            this.notifyIcon.BalloonTipTitle = "Winori";
            this.notifyIcon.Icon = ((System.Drawing.Icon)(resources.GetObject("notifyIcon.Icon")));
            this.notifyIcon.Text = "Winori";
            this.notifyIcon.Visible = true;
            this.notifyIcon.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.notifyIcon_MouseDoubleClick);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(108, 56);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(66, 15);
            this.label2.TabIndex = 4;
            this.label2.Text = "and others";
            this.toolTip1.SetToolTip(this.label2, resources.GetString("label2.ToolTip"));
            // 
            // pictureBoxCC
            // 
            this.pictureBoxCC.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pictureBoxCC.Image = ((System.Drawing.Image)(resources.GetObject("pictureBoxCC.Image")));
            this.pictureBoxCC.Location = new System.Drawing.Point(96, 97);
            this.pictureBoxCC.Name = "pictureBoxCC";
            this.pictureBoxCC.Size = new System.Drawing.Size(89, 32);
            this.pictureBoxCC.TabIndex = 2;
            this.pictureBoxCC.TabStop = false;
            this.toolTip1.SetToolTip(this.pictureBoxCC, "CC BY SA");
            this.pictureBoxCC.Click += new System.EventHandler(this.pictureBoxCC_Click);
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Location = new System.Drawing.Point(1, 2);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(292, 192);
            this.tabControl1.TabIndex = 6;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.tableLayoutPanel1);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(284, 166);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Configuration";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.BackColor = System.Drawing.SystemColors.InactiveBorder;
            this.tableLayoutPanel1.CellBorderStyle = System.Windows.Forms.TableLayoutPanelCellBorderStyle.Single;
            this.tableLayoutPanel1.ColumnCount = 2;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Controls.Add(this.panelDL, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.panelDR, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.panelUL, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.panelUR, 1, 0);
            this.tableLayoutPanel1.Location = new System.Drawing.Point(6, 6);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 2;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(272, 153);
            this.tableLayoutPanel1.TabIndex = 3;
            // 
            // panelDL
            // 
            this.panelDL.Controls.Add(this.labelDL);
            this.panelDL.Controls.Add(this.buttonDL);
            this.panelDL.Location = new System.Drawing.Point(4, 80);
            this.panelDL.Name = "panelDL";
            this.panelDL.Size = new System.Drawing.Size(128, 69);
            this.panelDL.TabIndex = 3;
            // 
            // labelDL
            // 
            this.labelDL.Location = new System.Drawing.Point(4, 4);
            this.labelDL.Name = "labelDL";
            this.labelDL.Size = new System.Drawing.Size(123, 37);
            this.labelDL.TabIndex = 1;
            this.labelDL.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // buttonDL
            // 
            this.buttonDL.Location = new System.Drawing.Point(31, 44);
            this.buttonDL.Name = "buttonDL";
            this.buttonDL.Size = new System.Drawing.Size(75, 23);
            this.buttonDL.TabIndex = 0;
            this.buttonDL.Text = "Change";
            this.buttonDL.UseVisualStyleBackColor = true;
            this.buttonDL.Click += new System.EventHandler(this.buttonDL_Click);
            // 
            // panelDR
            // 
            this.panelDR.Controls.Add(this.labelDR);
            this.panelDR.Controls.Add(this.buttonDR);
            this.panelDR.Location = new System.Drawing.Point(139, 80);
            this.panelDR.Name = "panelDR";
            this.panelDR.Size = new System.Drawing.Size(128, 69);
            this.panelDR.TabIndex = 2;
            // 
            // labelDR
            // 
            this.labelDR.Location = new System.Drawing.Point(4, 4);
            this.labelDR.Name = "labelDR";
            this.labelDR.Size = new System.Drawing.Size(123, 37);
            this.labelDR.TabIndex = 1;
            this.labelDR.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // buttonDR
            // 
            this.buttonDR.Location = new System.Drawing.Point(31, 44);
            this.buttonDR.Name = "buttonDR";
            this.buttonDR.Size = new System.Drawing.Size(75, 23);
            this.buttonDR.TabIndex = 0;
            this.buttonDR.Text = "Change";
            this.buttonDR.UseVisualStyleBackColor = true;
            this.buttonDR.Click += new System.EventHandler(this.buttonDR_Click);
            // 
            // panelUL
            // 
            this.panelUL.Controls.Add(this.labelUL);
            this.panelUL.Controls.Add(this.buttonUL);
            this.panelUL.Location = new System.Drawing.Point(4, 4);
            this.panelUL.Name = "panelUL";
            this.panelUL.Size = new System.Drawing.Size(128, 69);
            this.panelUL.TabIndex = 0;
            // 
            // labelUL
            // 
            this.labelUL.Location = new System.Drawing.Point(4, 4);
            this.labelUL.Name = "labelUL";
            this.labelUL.Size = new System.Drawing.Size(123, 37);
            this.labelUL.TabIndex = 1;
            this.labelUL.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // buttonUL
            // 
            this.buttonUL.Location = new System.Drawing.Point(31, 44);
            this.buttonUL.Name = "buttonUL";
            this.buttonUL.Size = new System.Drawing.Size(75, 23);
            this.buttonUL.TabIndex = 0;
            this.buttonUL.Text = "Change";
            this.buttonUL.UseVisualStyleBackColor = true;
            this.buttonUL.Click += new System.EventHandler(this.buttonUL_Click);
            // 
            // panelUR
            // 
            this.panelUR.Controls.Add(this.labelUR);
            this.panelUR.Controls.Add(this.buttonUR);
            this.panelUR.Location = new System.Drawing.Point(139, 4);
            this.panelUR.Name = "panelUR";
            this.panelUR.Size = new System.Drawing.Size(128, 69);
            this.panelUR.TabIndex = 1;
            // 
            // labelUR
            // 
            this.labelUR.Location = new System.Drawing.Point(4, 4);
            this.labelUR.Name = "labelUR";
            this.labelUR.Size = new System.Drawing.Size(123, 37);
            this.labelUR.TabIndex = 1;
            this.labelUR.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // buttonUR
            // 
            this.buttonUR.Location = new System.Drawing.Point(31, 44);
            this.buttonUR.Name = "buttonUR";
            this.buttonUR.Size = new System.Drawing.Size(75, 23);
            this.buttonUR.TabIndex = 0;
            this.buttonUR.Text = "Change";
            this.buttonUR.UseVisualStyleBackColor = true;
            this.buttonUR.Click += new System.EventHandler(this.buttonUR_Click);
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.label1);
            this.tabPage2.Controls.Add(this.pictureBoxCC);
            this.tabPage2.Controls.Add(this.label2);
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(284, 166);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "License";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(292, 194);
            this.Controls.Add(this.tabControl1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(308, 233);
            this.MinimumSize = new System.Drawing.Size(308, 233);
            this.Name = "MainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Winori";
            this.Resize += new System.EventHandler(this.MainForm_Resize);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxCC)).EndInit();
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.panelDL.ResumeLayout(false);
            this.panelDR.ResumeLayout(false);
            this.panelUL.ResumeLayout(false);
            this.panelUR.ResumeLayout(false);
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private MouseKeyboardActivityMonitor.Controls.MouseKeyEventProvider mouseKeyEventProvider1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox pictureBoxCC;
        private System.Windows.Forms.NotifyIcon notifyIcon;
        private System.Windows.Forms.ToolTip toolTip1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.Panel panelUL;
        private System.Windows.Forms.Label labelUL;
        private System.Windows.Forms.Button buttonUL;
        private System.Windows.Forms.Panel panelDR;
        private System.Windows.Forms.Label labelDR;
        private System.Windows.Forms.Button buttonDR;
        private System.Windows.Forms.Panel panelUR;
        private System.Windows.Forms.Label labelUR;
        private System.Windows.Forms.Button buttonUR;
        private System.Windows.Forms.Panel panelDL;
        private System.Windows.Forms.Label labelDL;
        private System.Windows.Forms.Button buttonDL;
    }
}

