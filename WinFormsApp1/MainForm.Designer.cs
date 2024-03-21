namespace WinFormsApp1
{
    partial class MainForm
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
            btnProcess = new Button();
            SuspendLayout();
            // 
            // btnProcess
            // 
            btnProcess.Location = new Point(297, 386);
            btnProcess.Name = "btnProcess";
            btnProcess.Size = new Size(150, 46);
            btnProcess.TabIndex = 0;
            btnProcess.Text = "ProcessButton";
            btnProcess.UseVisualStyleBackColor = true;
            btnProcess.Click += ProcessButton_Click;
            // 
            // MainForm
            // 
            AutoScaleDimensions = new SizeF(13F, 32F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(btnProcess);
            Name = "MainForm";
            Text = "Form1";
            Paint += MainForm_Paint;
            MouseClick += MainForm_MouseClick;
            MouseMove += MainForm_MouseMove;
            ResumeLayout(false);
        }

        #endregion

        private Button btnProcess;
    }
}
