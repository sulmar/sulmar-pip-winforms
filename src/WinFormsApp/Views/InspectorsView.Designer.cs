namespace WinFormsApp.Views
{
    partial class InspectorsView
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
            searchPanel = new Panel();
            yearTextBox = new TextBox();
            YearLabel = new Label();
            getInspectorsBySearchCriteriaButton = new Button();
            resultsPanel = new Panel();
            InspectorsDataGridView = new DataGridView();
            searchPanel.SuspendLayout();
            resultsPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)InspectorsDataGridView).BeginInit();
            SuspendLayout();
            // 
            // searchPanel
            // 
            searchPanel.BackColor = SystemColors.Control;
            searchPanel.Controls.Add(yearTextBox);
            searchPanel.Controls.Add(YearLabel);
            searchPanel.Controls.Add(getInspectorsBySearchCriteriaButton);
            searchPanel.Dock = DockStyle.Top;
            searchPanel.Location = new Point(10, 10);
            searchPanel.Name = "searchPanel";
            searchPanel.Size = new Size(780, 91);
            searchPanel.TabIndex = 0;
            // 
            // yearTextBox
            // 
            yearTextBox.Location = new Point(32, 36);
            yearTextBox.Name = "yearTextBox";
            yearTextBox.Size = new Size(192, 23);
            yearTextBox.TabIndex = 2;
            // 
            // YearLabel
            // 
            YearLabel.AutoSize = true;
            YearLabel.Location = new Point(32, 15);
            YearLabel.Name = "YearLabel";
            YearLabel.Size = new Size(69, 15);
            YearLabel.TabIndex = 1;
            YearLabel.Text = "Wybierz rok";
            // 
            // getInspectorsBySearchCriteriaButton
            // 
            getInspectorsBySearchCriteriaButton.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            getInspectorsBySearchCriteriaButton.Location = new Point(607, 24);
            getInspectorsBySearchCriteriaButton.Name = "getInspectorsBySearchCriteriaButton";
            getInspectorsBySearchCriteriaButton.Size = new Size(161, 44);
            getInspectorsBySearchCriteriaButton.TabIndex = 0;
            getInspectorsBySearchCriteriaButton.Text = "&Pobierz";
            getInspectorsBySearchCriteriaButton.UseVisualStyleBackColor = true;
            // 
            // resultsPanel
            // 
            resultsPanel.BackColor = SystemColors.Control;
            resultsPanel.Controls.Add(InspectorsDataGridView);
            resultsPanel.Dock = DockStyle.Fill;
            resultsPanel.Location = new Point(10, 101);
            resultsPanel.Name = "resultsPanel";
            resultsPanel.Size = new Size(780, 339);
            resultsPanel.TabIndex = 1;
            // 
            // InspectorsDataGridView
            // 
            InspectorsDataGridView.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            InspectorsDataGridView.Dock = DockStyle.Fill;
            InspectorsDataGridView.Location = new Point(0, 0);
            InspectorsDataGridView.Name = "InspectorsDataGridView";
            InspectorsDataGridView.Size = new Size(780, 339);
            InspectorsDataGridView.TabIndex = 0;
            // 
            // InspectorsView
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(resultsPanel);
            Controls.Add(searchPanel);
            MinimumSize = new Size(500, 400);
            Name = "InspectorsView";
            Padding = new Padding(10);
            Text = "Lista inspektorów";
            searchPanel.ResumeLayout(false);
            searchPanel.PerformLayout();
            resultsPanel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)InspectorsDataGridView).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel searchPanel;
        private Panel resultsPanel;
        private Button getInspectorsBySearchCriteriaButton;
        private TextBox yearTextBox;
        private Label YearLabel;
        private DataGridView InspectorsDataGridView;
    }
}