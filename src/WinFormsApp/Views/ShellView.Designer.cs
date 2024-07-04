namespace WinFormsApp.Views
{
    partial class ShellView
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
            PanelToolbar = new Panel();
            ShowInspectorsButton = new Button();
            ShowDocumentsButton = new Button();
            PanelToolbar.SuspendLayout();
            SuspendLayout();
            // 
            // PanelToolbar
            // 
            PanelToolbar.Controls.Add(ShowDocumentsButton);
            PanelToolbar.Controls.Add(ShowInspectorsButton);
            PanelToolbar.Dock = DockStyle.Top;
            PanelToolbar.Location = new Point(0, 0);
            PanelToolbar.Name = "PanelToolbar";
            PanelToolbar.Size = new Size(800, 100);
            PanelToolbar.TabIndex = 0;
            // 
            // ShowInspectorsButton
            // 
            ShowInspectorsButton.Location = new Point(41, 24);
            ShowInspectorsButton.Name = "ShowInspectorsButton";
            ShowInspectorsButton.Size = new Size(129, 57);
            ShowInspectorsButton.TabIndex = 0;
            ShowInspectorsButton.Text = "Inspektorzy";
            ShowInspectorsButton.UseVisualStyleBackColor = true;
            ShowInspectorsButton.Click += ShowInspectorsButton_Click;
            // 
            // ShowDocumentsButton
            // 
            ShowDocumentsButton.Location = new Point(189, 24);
            ShowDocumentsButton.Name = "ShowDocumentsButton";
            ShowDocumentsButton.Size = new Size(129, 57);
            ShowDocumentsButton.TabIndex = 1;
            ShowDocumentsButton.Text = "Dokumenty";
            ShowDocumentsButton.UseVisualStyleBackColor = true;
            ShowDocumentsButton.Click += ShowDocumentsButton_Click;
            // 
            // ShellView
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(PanelToolbar);
            Name = "ShellView";
            Text = "ShellView";
            PanelToolbar.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private Panel PanelToolbar;
        private Button ShowDocumentsButton;
        private Button ShowInspectorsButton;
    }
}