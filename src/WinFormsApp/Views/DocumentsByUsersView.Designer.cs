namespace WinFormsApp.Views
{
    partial class DocumentsByUsersView
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
            DateSetPanel = new Panel();
            DateViewPanel = new Panel();
            FromDateTimePicker = new DateTimePicker();
            ToDateTimePicker = new DateTimePicker();
            DateFromLabel = new Label();
            DateToLabel = new Label();
            GetInforButton = new Button();
            DocumentsByUsersdataGridView = new DataGridView();
            DateSetPanel.SuspendLayout();
            DateViewPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)DocumentsByUsersdataGridView).BeginInit();
            SuspendLayout();
            // 
            // DateSetPanel
            // 
            DateSetPanel.Controls.Add(GetInforButton);
            DateSetPanel.Controls.Add(DateToLabel);
            DateSetPanel.Controls.Add(DateFromLabel);
            DateSetPanel.Controls.Add(ToDateTimePicker);
            DateSetPanel.Controls.Add(FromDateTimePicker);
            DateSetPanel.Dock = DockStyle.Top;
            DateSetPanel.Location = new Point(10, 10);
            DateSetPanel.Name = "DateSetPanel";
            DateSetPanel.Size = new Size(1095, 153);
            DateSetPanel.TabIndex = 0;
            // 
            // DateViewPanel
            // 
            DateViewPanel.Controls.Add(DocumentsByUsersdataGridView);
            DateViewPanel.Dock = DockStyle.Fill;
            DateViewPanel.Location = new Point(10, 163);
            DateViewPanel.Name = "DateViewPanel";
            DateViewPanel.Size = new Size(1095, 386);
            DateViewPanel.TabIndex = 1;
            // 
            // FromDateTimePicker
            // 
            FromDateTimePicker.Location = new Point(30, 27);
            FromDateTimePicker.MinimumSize = new Size(200, 30);
            FromDateTimePicker.Name = "FromDateTimePicker";
            FromDateTimePicker.Size = new Size(200, 30);
            FromDateTimePicker.TabIndex = 0;
            // 
            // ToDateTimePicker
            // 
            ToDateTimePicker.Location = new Point(30, 89);
            ToDateTimePicker.MinimumSize = new Size(200, 30);
            ToDateTimePicker.Name = "ToDateTimePicker";
            ToDateTimePicker.Size = new Size(200, 30);
            ToDateTimePicker.TabIndex = 1;
            // 
            // DateFromLabel
            // 
            DateFromLabel.AutoSize = true;
            DateFromLabel.Location = new Point(30, 9);
            DateFromLabel.Name = "DateFromLabel";
            DateFromLabel.Size = new Size(23, 15);
            DateFromLabel.TabIndex = 2;
            DateFromLabel.Text = "Od";
            // 
            // DateToLabel
            // 
            DateToLabel.AutoSize = true;
            DateToLabel.Location = new Point(30, 71);
            DateToLabel.Name = "DateToLabel";
            DateToLabel.Size = new Size(22, 15);
            DateToLabel.TabIndex = 3;
            DateToLabel.Text = "Do";
            // 
            // GetInforButton
            // 
            GetInforButton.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            GetInforButton.Location = new Point(948, 37);
            GetInforButton.Name = "GetInforButton";
            GetInforButton.Size = new Size(131, 49);
            GetInforButton.TabIndex = 4;
            GetInforButton.Text = "Pobierz";
            GetInforButton.UseVisualStyleBackColor = true;
            GetInforButton.Click += GetInforButton_Click;
            // 
            // DocumentsByUsersdataGridView
            // 
            DocumentsByUsersdataGridView.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            DocumentsByUsersdataGridView.Dock = DockStyle.Fill;
            DocumentsByUsersdataGridView.Location = new Point(0, 0);
            DocumentsByUsersdataGridView.Name = "DocumentsByUsersdataGridView";
            DocumentsByUsersdataGridView.Size = new Size(1095, 386);
            DocumentsByUsersdataGridView.TabIndex = 0;
            // 
            // DocumentsByUsersView
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1115, 559);
            Controls.Add(DateViewPanel);
            Controls.Add(DateSetPanel);
            Name = "DocumentsByUsersView";
            Padding = new Padding(10);
            Text = "Dokumenty wedug użytkowników";
            DateSetPanel.ResumeLayout(false);
            DateSetPanel.PerformLayout();
            DateViewPanel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)DocumentsByUsersdataGridView).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel DateSetPanel;
        private Panel DateViewPanel;
        private Button GetInforButton;
        private Label DateToLabel;
        private Label DateFromLabel;
        private DateTimePicker ToDateTimePicker;
        private DateTimePicker FromDateTimePicker;
        private DataGridView DocumentsByUsersdataGridView;
    }
}