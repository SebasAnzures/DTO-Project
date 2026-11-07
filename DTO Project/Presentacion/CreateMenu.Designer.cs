namespace DTO_Project.Presentacion
{
    partial class CreateMenu
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
            components = new System.ComponentModel.Container();
            btnBack = new Button();
            btnMoves = new Button();
            btnItem = new Button();
            btnEnemy = new Button();
            btnElement = new Button();
            dataGridView1 = new DataGridView();
            errorProvider1 = new ErrorProvider(components);
            label2 = new Label();
            lbElement = new Label();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)errorProvider1).BeginInit();
            SuspendLayout();
            // 
            // btnBack
            // 
            btnBack.Location = new Point(12, 938);
            btnBack.Name = "btnBack";
            btnBack.Size = new Size(395, 91);
            btnBack.TabIndex = 0;
            btnBack.Text = "Back to the Main Menu";
            btnBack.UseVisualStyleBackColor = true;
            btnBack.Click += btnBack_Click;
            // 
            // btnMoves
            // 
            btnMoves.Location = new Point(12, 841);
            btnMoves.Name = "btnMoves";
            btnMoves.Size = new Size(395, 91);
            btnMoves.TabIndex = 1;
            btnMoves.Text = "Move";
            btnMoves.UseVisualStyleBackColor = true;
            // 
            // btnItem
            // 
            btnItem.Location = new Point(12, 744);
            btnItem.Name = "btnItem";
            btnItem.Size = new Size(395, 91);
            btnItem.TabIndex = 2;
            btnItem.Text = "Item";
            btnItem.UseVisualStyleBackColor = true;
            // 
            // btnEnemy
            // 
            btnEnemy.Location = new Point(12, 647);
            btnEnemy.Name = "btnEnemy";
            btnEnemy.Size = new Size(395, 91);
            btnEnemy.TabIndex = 3;
            btnEnemy.Text = "Enemy";
            btnEnemy.UseVisualStyleBackColor = true;
            // 
            // btnElement
            // 
            btnElement.Location = new Point(12, 550);
            btnElement.Name = "btnElement";
            btnElement.Size = new Size(395, 91);
            btnElement.TabIndex = 4;
            btnElement.Text = "Element";
            btnElement.UseVisualStyleBackColor = true;
            // 
            // dataGridView1
            // 
            dataGridView1.AllowUserToAddRows = false;
            dataGridView1.AllowUserToDeleteRows = false;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(1212, 12);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.ReadOnly = true;
            dataGridView1.Size = new Size(680, 1017);
            dataGridView1.TabIndex = 5;
            // 
            // errorProvider1
            // 
            errorProvider1.ContainerControl = this;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 45F);
            label2.Location = new Point(413, 12);
            label2.Name = "label2";
            label2.Size = new Size(206, 81);
            label2.TabIndex = 7;
            label2.Text = "Create";
            // 
            // lbElement
            // 
            lbElement.AutoSize = true;
            lbElement.Font = new Font("Segoe UI", 19F);
            lbElement.Location = new Point(429, 93);
            lbElement.Name = "lbElement";
            lbElement.Size = new Size(108, 36);
            lbElement.TabIndex = 8;
            lbElement.Text = "Element";
            // 
            // CreateMenu
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1904, 1041);
            Controls.Add(lbElement);
            Controls.Add(label2);
            Controls.Add(dataGridView1);
            Controls.Add(btnElement);
            Controls.Add(btnEnemy);
            Controls.Add(btnItem);
            Controls.Add(btnMoves);
            Controls.Add(btnBack);
            MaximumSize = new Size(1920, 1080);
            MinimumSize = new Size(1918, 1030);
            Name = "CreateMenu";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Customize";
            WindowState = FormWindowState.Maximized;
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ((System.ComponentModel.ISupportInitialize)errorProvider1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnBack;
        private Button btnMoves;
        private Button btnItem;
        private Button btnEnemy;
        private Button btnElement;
        private DataGridView dataGridView1;
        private ErrorProvider errorProvider1;
        private Label label2;
        private Label lbElement;
    }
}