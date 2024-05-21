namespace Tic_Tac_Toe
{
    partial class TicTacToeForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(TicTacToeForm));
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.newGameToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.aboutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.a1 = new System.Windows.Forms.Button();
            this.a2 = new System.Windows.Forms.Button();
            this.a3 = new System.Windows.Forms.Button();
            this.b1 = new System.Windows.Forms.Button();
            this.b2 = new System.Windows.Forms.Button();
            this.b3 = new System.Windows.Forms.Button();
            this.c1 = new System.Windows.Forms.Button();
            this.c2 = new System.Windows.Forms.Button();
            this.c3 = new System.Windows.Forms.Button();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem,
            this.aboutToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Padding = new System.Windows.Forms.Padding(6, 3, 0, 3);
            this.menuStrip1.Size = new System.Drawing.Size(658, 25);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.newGameToolStripMenuItem,
            this.exitToolStripMenuItem});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(37, 19);
            this.fileToolStripMenuItem.Text = "File";
            // 
            // newGameToolStripMenuItem
            // 
            this.newGameToolStripMenuItem.Name = "newGameToolStripMenuItem";
            this.newGameToolStripMenuItem.Size = new System.Drawing.Size(132, 22);
            this.newGameToolStripMenuItem.Text = "New Game";
            this.newGameToolStripMenuItem.Click += new System.EventHandler(this.newGameToolStripMenuItem_Click);
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.exitToolStripMenuItem.Size = new System.Drawing.Size(132, 22);
            this.exitToolStripMenuItem.Text = "Exit";
            this.exitToolStripMenuItem.Click += new System.EventHandler(this.exitToolStripMenuItem_Click);
            // 
            // aboutToolStripMenuItem
            // 
            this.aboutToolStripMenuItem.Name = "aboutToolStripMenuItem";
            this.aboutToolStripMenuItem.Size = new System.Drawing.Size(52, 19);
            this.aboutToolStripMenuItem.Text = "About";
            this.aboutToolStripMenuItem.Click += new System.EventHandler(this.aboutToolStripMenuItem_Click);
            // 
            // a1
            // 
            this.a1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.a1.FlatAppearance.BorderColor = System.Drawing.Color.Red;
            this.a1.FlatAppearance.CheckedBackColor = System.Drawing.Color.Cyan;
            this.a1.Font = new System.Drawing.Font("Microsoft YaHei", 72F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.a1.Location = new System.Drawing.Point(10, 55);
            this.a1.Name = "a1";
            this.a1.Size = new System.Drawing.Size(207, 163);
            this.a1.TabIndex = 1;
            this.a1.UseVisualStyleBackColor = true;
            this.a1.Click += new System.EventHandler(this.Button_Click);
            // 
            // a2
            // 
            this.a2.Cursor = System.Windows.Forms.Cursors.Hand;
            this.a2.FlatAppearance.BorderColor = System.Drawing.Color.Red;
            this.a2.FlatAppearance.CheckedBackColor = System.Drawing.Color.Cyan;
            this.a2.Font = new System.Drawing.Font("Microsoft YaHei", 72F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.a2.Location = new System.Drawing.Point(223, 55);
            this.a2.Name = "a2";
            this.a2.Size = new System.Drawing.Size(207, 163);
            this.a2.TabIndex = 1;
            this.a2.UseVisualStyleBackColor = true;
            this.a2.Click += new System.EventHandler(this.Button_Click);
            // 
            // a3
            // 
            this.a3.Cursor = System.Windows.Forms.Cursors.Hand;
            this.a3.FlatAppearance.BorderColor = System.Drawing.Color.Red;
            this.a3.FlatAppearance.CheckedBackColor = System.Drawing.Color.Cyan;
            this.a3.Font = new System.Drawing.Font("Microsoft YaHei", 72F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.a3.Location = new System.Drawing.Point(433, 55);
            this.a3.Name = "a3";
            this.a3.Size = new System.Drawing.Size(207, 163);
            this.a3.TabIndex = 1;
            this.a3.UseVisualStyleBackColor = true;
            this.a3.Click += new System.EventHandler(this.Button_Click);
            // 
            // b1
            // 
            this.b1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.b1.FlatAppearance.BorderColor = System.Drawing.Color.Red;
            this.b1.FlatAppearance.CheckedBackColor = System.Drawing.Color.Cyan;
            this.b1.Font = new System.Drawing.Font("Microsoft YaHei", 72F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.b1.Location = new System.Drawing.Point(10, 224);
            this.b1.Name = "b1";
            this.b1.Size = new System.Drawing.Size(207, 163);
            this.b1.TabIndex = 1;
            this.b1.UseVisualStyleBackColor = true;
            this.b1.Click += new System.EventHandler(this.Button_Click);
            // 
            // b2
            // 
            this.b2.Cursor = System.Windows.Forms.Cursors.Hand;
            this.b2.FlatAppearance.BorderColor = System.Drawing.Color.Red;
            this.b2.FlatAppearance.CheckedBackColor = System.Drawing.Color.Cyan;
            this.b2.Font = new System.Drawing.Font("Microsoft YaHei", 72F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.b2.Location = new System.Drawing.Point(223, 224);
            this.b2.Name = "b2";
            this.b2.Size = new System.Drawing.Size(207, 163);
            this.b2.TabIndex = 1;
            this.b2.UseVisualStyleBackColor = true;
            this.b2.Click += new System.EventHandler(this.Button_Click);
            // 
            // b3
            // 
            this.b3.Cursor = System.Windows.Forms.Cursors.Hand;
            this.b3.FlatAppearance.BorderColor = System.Drawing.Color.Red;
            this.b3.FlatAppearance.CheckedBackColor = System.Drawing.Color.Cyan;
            this.b3.Font = new System.Drawing.Font("Microsoft YaHei", 72F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.b3.Location = new System.Drawing.Point(433, 224);
            this.b3.Name = "b3";
            this.b3.Size = new System.Drawing.Size(207, 163);
            this.b3.TabIndex = 1;
            this.b3.UseVisualStyleBackColor = true;
            this.b3.Click += new System.EventHandler(this.Button_Click);
            // 
            // c1
            // 
            this.c1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.c1.FlatAppearance.BorderColor = System.Drawing.Color.Red;
            this.c1.FlatAppearance.CheckedBackColor = System.Drawing.Color.Cyan;
            this.c1.Font = new System.Drawing.Font("Microsoft YaHei", 72F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.c1.Location = new System.Drawing.Point(10, 390);
            this.c1.Name = "c1";
            this.c1.Size = new System.Drawing.Size(207, 163);
            this.c1.TabIndex = 1;
            this.c1.UseVisualStyleBackColor = true;
            this.c1.Click += new System.EventHandler(this.Button_Click);
            // 
            // c2
            // 
            this.c2.Cursor = System.Windows.Forms.Cursors.Hand;
            this.c2.FlatAppearance.BorderColor = System.Drawing.Color.Red;
            this.c2.FlatAppearance.CheckedBackColor = System.Drawing.Color.Cyan;
            this.c2.Font = new System.Drawing.Font("Microsoft YaHei", 72F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.c2.Location = new System.Drawing.Point(223, 390);
            this.c2.Name = "c2";
            this.c2.Size = new System.Drawing.Size(207, 163);
            this.c2.TabIndex = 1;
            this.c2.UseVisualStyleBackColor = true;
            this.c2.Click += new System.EventHandler(this.Button_Click);
            // 
            // c3
            // 
            this.c3.Cursor = System.Windows.Forms.Cursors.Hand;
            this.c3.FlatAppearance.BorderColor = System.Drawing.Color.Red;
            this.c3.FlatAppearance.CheckedBackColor = System.Drawing.Color.Cyan;
            this.c3.Font = new System.Drawing.Font("Microsoft YaHei", 72F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.c3.Location = new System.Drawing.Point(433, 390);
            this.c3.Name = "c3";
            this.c3.Size = new System.Drawing.Size(207, 163);
            this.c3.TabIndex = 1;
            this.c3.UseVisualStyleBackColor = true;
            this.c3.Click += new System.EventHandler(this.Button_Click);
            // 
            // TicTacToeForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.ClientSize = new System.Drawing.Size(658, 572);
            this.Controls.Add(this.c3);
            this.Controls.Add(this.b3);
            this.Controls.Add(this.a3);
            this.Controls.Add(this.c2);
            this.Controls.Add(this.c1);
            this.Controls.Add(this.b2);
            this.Controls.Add(this.b1);
            this.Controls.Add(this.a2);
            this.Controls.Add(this.a1);
            this.Controls.Add(this.menuStrip1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "TicTacToeForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Tic-Tac-Toe";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem newGameToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem aboutToolStripMenuItem;
        private System.Windows.Forms.Button a1;
        private System.Windows.Forms.Button a2;
        private System.Windows.Forms.Button a3;
        private System.Windows.Forms.Button b1;
        private System.Windows.Forms.Button b2;
        private System.Windows.Forms.Button b3;
        private System.Windows.Forms.Button c1;
        private System.Windows.Forms.Button c2;
        private System.Windows.Forms.Button c3;
    }
}

