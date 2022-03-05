
namespace speedster
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.label1 = new System.Windows.Forms.Label();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.label2 = new System.Windows.Forms.Label();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.showHighestSpeedToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.resetHighestSpeedToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.changeColorDependingOnSpeedToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.timer2 = new System.Windows.Forms.Timer(this.components);
            this.playerToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.p1ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.p2ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.contextMenuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Lucida Console", 74.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(-20, 3);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(462, 99);
            this.label1.TabIndex = 0;
            this.label1.Text = "000Km/h";
            this.label1.MouseDown += new System.Windows.Forms.MouseEventHandler(this.label1_MouseDown);
            // 
            // timer1
            // 
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Lucida Console", 74.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.label2.Location = new System.Drawing.Point(-20, 98);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(462, 99);
            this.label2.TabIndex = 1;
            this.label2.Text = "000Km/h";
            this.label2.MouseDown += new System.Windows.Forms.MouseEventHandler(this.label2_MouseDown);
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.changeColorDependingOnSpeedToolStripMenuItem,
            this.showHighestSpeedToolStripMenuItem,
            this.resetHighestSpeedToolStripMenuItem,
            this.exitToolStripMenuItem,
            this.playerToolStripMenuItem});
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(257, 114);
            // 
            // showHighestSpeedToolStripMenuItem
            // 
            this.showHighestSpeedToolStripMenuItem.CheckOnClick = true;
            this.showHighestSpeedToolStripMenuItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.showHighestSpeedToolStripMenuItem.Name = "showHighestSpeedToolStripMenuItem";
            this.showHighestSpeedToolStripMenuItem.Size = new System.Drawing.Size(256, 22);
            this.showHighestSpeedToolStripMenuItem.Text = "Show highest speed";
            this.showHighestSpeedToolStripMenuItem.CheckedChanged += new System.EventHandler(this.showHighestSpeedToolStripMenuItem_CheckedChanged);
            // 
            // resetHighestSpeedToolStripMenuItem
            // 
            this.resetHighestSpeedToolStripMenuItem.Name = "resetHighestSpeedToolStripMenuItem";
            this.resetHighestSpeedToolStripMenuItem.Size = new System.Drawing.Size(256, 22);
            this.resetHighestSpeedToolStripMenuItem.Text = "Reset highest speed";
            this.resetHighestSpeedToolStripMenuItem.Click += new System.EventHandler(this.resetHighestSpeedToolStripMenuItem_Click);
            // 
            // changeColorDependingOnSpeedToolStripMenuItem
            // 
            this.changeColorDependingOnSpeedToolStripMenuItem.CheckOnClick = true;
            this.changeColorDependingOnSpeedToolStripMenuItem.Name = "changeColorDependingOnSpeedToolStripMenuItem";
            this.changeColorDependingOnSpeedToolStripMenuItem.Size = new System.Drawing.Size(256, 22);
            this.changeColorDependingOnSpeedToolStripMenuItem.Text = "Change color depending on speed";
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.exitToolStripMenuItem.Size = new System.Drawing.Size(256, 22);
            this.exitToolStripMenuItem.Text = "Exit";
            this.exitToolStripMenuItem.Click += new System.EventHandler(this.exitToolStripMenuItem_Click);
            // 
            // timer2
            // 
            this.timer2.Tick += new System.EventHandler(this.timer2_Tick);
            // 
            // playerToolStripMenuItem
            // 
            this.playerToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.p1ToolStripMenuItem,
            this.p2ToolStripMenuItem});
            this.playerToolStripMenuItem.Name = "playerToolStripMenuItem";
            this.playerToolStripMenuItem.Size = new System.Drawing.Size(256, 22);
            this.playerToolStripMenuItem.Text = "Player";
            // 
            // p1ToolStripMenuItem
            // 
            this.p1ToolStripMenuItem.Name = "p1ToolStripMenuItem";
            this.p1ToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.p1ToolStripMenuItem.Text = "p1";
            // 
            // p2ToolStripMenuItem
            // 
            this.p2ToolStripMenuItem.Name = "p2ToolStripMenuItem";
            this.p2ToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.p2ToolStripMenuItem.Text = "p2";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(415, 100);
            this.ContextMenuStrip = this.contextMenuStrip1;
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.Manual;
            this.Text = "SioN\'s Kmh meter";
            this.TopMost = true;
            this.Load += new System.EventHandler(this.Form1_Load_1);
            this.contextMenuStrip1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.ToolStripMenuItem showHighestSpeedToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem resetHighestSpeedToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem changeColorDependingOnSpeedToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
        private System.Windows.Forms.Timer timer2;
        private System.Windows.Forms.ToolStripMenuItem playerToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem p1ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem p2ToolStripMenuItem;
    }
}

