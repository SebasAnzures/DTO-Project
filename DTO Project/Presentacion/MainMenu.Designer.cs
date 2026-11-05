namespace DTO_Project
{
    partial class MainMenu
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            btnExit = new Button();
            btnCustomize = new Button();
            btnStart = new Button();
            SuspendLayout();
            // 
            // btnExit
            // 
            btnExit.Location = new Point(12, 875);
            btnExit.Name = "btnExit";
            btnExit.Size = new Size(723, 154);
            btnExit.TabIndex = 0;
            btnExit.Text = "Exit";
            btnExit.UseVisualStyleBackColor = true;
            btnExit.Click += btnExit_Click;
            // 
            // btnCustomize
            // 
            btnCustomize.Location = new Point(12, 715);
            btnCustomize.Name = "btnCustomize";
            btnCustomize.Size = new Size(723, 154);
            btnCustomize.TabIndex = 1;
            btnCustomize.Text = "Customize";
            btnCustomize.UseVisualStyleBackColor = true;
            // 
            // btnStart
            // 
            btnStart.Location = new Point(12, 555);
            btnStart.Name = "btnStart";
            btnStart.Size = new Size(723, 154);
            btnStart.TabIndex = 2;
            btnStart.Text = "Start";
            btnStart.UseVisualStyleBackColor = true;
            // 
            // MainMenu
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1904, 1041);
            Controls.Add(btnStart);
            Controls.Add(btnCustomize);
            Controls.Add(btnExit);
            MaximumSize = new Size(1920, 1080);
            MinimumSize = new Size(1918, 1030);
            Name = "MainMenu";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "DTO (Dungeons & Towers Overlord)";
            WindowState = FormWindowState.Maximized;
            ResumeLayout(false);
        }

        #endregion

        private Button btnExit;
        private Button btnCustomize;
        private Button btnStart;
    }
}
