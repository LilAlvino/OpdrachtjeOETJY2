namespace Betabit.Spaces.App
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
            this.SpacesListBox = new System.Windows.Forms.ListBox();
            this.ReservationsGridView = new System.Windows.Forms.DataGridView();
            this.button1 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.ReservationsGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // SpacesListBox
            // 
            this.SpacesListBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.SpacesListBox.FormattingEnabled = true;
            this.SpacesListBox.ItemHeight = 15;
            this.SpacesListBox.Location = new System.Drawing.Point(23, 13);
            this.SpacesListBox.Name = "SpacesListBox";
            this.SpacesListBox.Size = new System.Drawing.Size(150, 334);
            this.SpacesListBox.TabIndex = 0;
            this.SpacesListBox.SelectedIndexChanged += new System.EventHandler(this.OnSpaceSelected);
            // 
            // ReservationsGridView
            // 
            this.ReservationsGridView.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.ReservationsGridView.Location = new System.Drawing.Point(193, 13);
            this.ReservationsGridView.Name = "ReservationsGridView";
            this.ReservationsGridView.Size = new System.Drawing.Size(298, 302);
            this.ReservationsGridView.TabIndex = 1;
            this.ReservationsGridView.Columns.Add("SpaceCode", "Space");
            this.ReservationsGridView.Columns.Add("Reserver", "Reserver");
            this.ReservationsGridView.Columns.Add("Start", "StartTime");
            this.ReservationsGridView.Columns.Add("End", "EndTime");
            this.ReservationsGridView.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
            // 
            // button1
            // 
            this.button1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.button1.Location = new System.Drawing.Point(302, 332);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(189, 29);
            this.button1.TabIndex = 2;
            this.button1.Text = "Nieuwe boeking";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // MainForm
            // 
            this.ClientSize = new System.Drawing.Size(503, 376);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.SpacesListBox);
            this.Controls.Add(this.ReservationsGridView);
            this.Name = "MainForm";
            ((System.ComponentModel.ISupportInitialize)(this.ReservationsGridView)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListBox SpacesListBox;
        private System.Windows.Forms.DataGridView ReservationsGridView;
        private System.Windows.Forms.Button button1;
    }
}

