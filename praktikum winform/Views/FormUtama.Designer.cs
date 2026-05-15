namespace praktikum_winform
{
    partial class FormUtama
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
            panelUtama = new Panel();
            SuspendLayout();
            // 
            // panelUtama
            // 
            panelUtama.Dock = DockStyle.Fill;
            panelUtama.Location = new Point(0, 0);
            panelUtama.Name = "panelUtama";
            panelUtama.Size = new Size(1256, 713);
            panelUtama.TabIndex = 0;
            // 
            // FormUtama
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1256, 713);
            Controls.Add(panelUtama);
            Name = "FormUtama";
            Text = "FormUtama";
            ResumeLayout(false);
        }

        #endregion

        private Panel panelUtama;
    }
}