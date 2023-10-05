namespace WinFormsApp1
{
    partial class Demo
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
            btnCount = new Button();
            txtCount = new TextBox();
            lbOutput = new Label();
            btnShow = new Button();
            SuspendLayout();
            // 
            // btnCount
            // 
            btnCount.Location = new Point(296, 175);
            btnCount.Name = "btnCount";
            btnCount.Size = new Size(94, 29);
            btnCount.TabIndex = 0;
            btnCount.Text = "Count";
            btnCount.UseVisualStyleBackColor = true;
            btnCount.Click += btnCount_Click;
            // 
            // txtCount
            // 
            txtCount.Location = new Point(151, 175);
            txtCount.Name = "txtCount";
            txtCount.Size = new Size(125, 27);
            txtCount.TabIndex = 1;
            // 
            // lbOutput
            // 
            lbOutput.AutoSize = true;
            lbOutput.Font = new Font("Segoe UI", 19.8000011F, FontStyle.Bold, GraphicsUnit.Point);
            lbOutput.Location = new Point(154, 217);
            lbOutput.Name = "lbOutput";
            lbOutput.Size = new Size(135, 46);
            lbOutput.TabIndex = 2;
            lbOutput.Text = "Output";
            // 
            // btnShow
            // 
            btnShow.Location = new Point(485, 175);
            btnShow.Name = "btnShow";
            btnShow.Size = new Size(94, 29);
            btnShow.TabIndex = 3;
            btnShow.Text = "Show";
            btnShow.UseVisualStyleBackColor = true;
            btnShow.Click += btnShow_Click;
            // 
            // Demo
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(btnShow);
            Controls.Add(lbOutput);
            Controls.Add(txtCount);
            Controls.Add(btnCount);
            Name = "Demo";
            Text = "Demo";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnCount;
        private TextBox txtCount;
        private Label lbOutput;
        private Button btnShow;
    }
}