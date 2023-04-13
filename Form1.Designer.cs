namespace FileOpration
{
    partial class Form1
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
            this.NameLabel = new System.Windows.Forms.Label();
            this.NameBox = new System.Windows.Forms.TextBox();
            this.DestinationtextBox = new System.Windows.Forms.TextBox();
            this.Destinationlabel = new System.Windows.Forms.Label();
            this.SourcePathtextBox = new System.Windows.Forms.TextBox();
            this.SourcePathlabel = new System.Windows.Forms.Label();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.selectfilebutton = new System.Windows.Forms.Button();
            this.FilelistView = new System.Windows.Forms.ListBox();
            this.CreateButton = new System.Windows.Forms.Button();
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.flowLayoutPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // NameLabel
            // 
            this.NameLabel.AutoSize = true;
            this.NameLabel.Location = new System.Drawing.Point(13, 10);
            this.NameLabel.Name = "NameLabel";
            this.NameLabel.Size = new System.Drawing.Size(35, 13);
            this.NameLabel.TabIndex = 0;
            this.NameLabel.Text = "Name";
            // 
            // NameBox
            // 
            this.NameBox.Location = new System.Drawing.Point(13, 26);
            this.NameBox.Name = "NameBox";
            this.NameBox.Size = new System.Drawing.Size(558, 20);
            this.NameBox.TabIndex = 1;
            this.NameBox.TextChanged += new System.EventHandler(this.NameBox_TextChanged);
            // 
            // DestinationtextBox
            // 
            this.DestinationtextBox.Location = new System.Drawing.Point(13, 65);
            this.DestinationtextBox.Name = "DestinationtextBox";
            this.DestinationtextBox.Size = new System.Drawing.Size(558, 20);
            this.DestinationtextBox.TabIndex = 3;
            // 
            // Destinationlabel
            // 
            this.Destinationlabel.AutoSize = true;
            this.Destinationlabel.Location = new System.Drawing.Point(13, 49);
            this.Destinationlabel.Name = "Destinationlabel";
            this.Destinationlabel.Size = new System.Drawing.Size(85, 13);
            this.Destinationlabel.TabIndex = 2;
            this.Destinationlabel.Text = "Destination Path";
            // 
            // SourcePathtextBox
            // 
            this.SourcePathtextBox.Location = new System.Drawing.Point(13, 104);
            this.SourcePathtextBox.Name = "SourcePathtextBox";
            this.SourcePathtextBox.Size = new System.Drawing.Size(558, 20);
            this.SourcePathtextBox.TabIndex = 5;
            this.SourcePathtextBox.TextChanged += new System.EventHandler(this.SourcePathtextBox_TextChanged);
            // 
            // SourcePathlabel
            // 
            this.SourcePathlabel.AutoSize = true;
            this.SourcePathlabel.Location = new System.Drawing.Point(13, 88);
            this.SourcePathlabel.Name = "SourcePathlabel";
            this.SourcePathlabel.Size = new System.Drawing.Size(66, 13);
            this.SourcePathlabel.TabIndex = 4;
            this.SourcePathlabel.Text = "Source Path";
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            this.openFileDialog1.FileOk += new System.ComponentModel.CancelEventHandler(this.openFileDialog1_FileOk);
            // 
            // selectfilebutton
            // 
            this.selectfilebutton.Location = new System.Drawing.Point(13, 130);
            this.selectfilebutton.Name = "selectfilebutton";
            this.selectfilebutton.Size = new System.Drawing.Size(558, 23);
            this.selectfilebutton.TabIndex = 6;
            this.selectfilebutton.Text = "Select File";
            this.selectfilebutton.UseVisualStyleBackColor = true;
            this.selectfilebutton.Click += new System.EventHandler(this.selectfilebutton_Click);
            // 
            // FilelistView
            // 
            this.FilelistView.AllowDrop = true;
            this.FilelistView.Location = new System.Drawing.Point(13, 159);
            this.FilelistView.Name = "FilelistView";
            this.FilelistView.Size = new System.Drawing.Size(558, 95);
            this.FilelistView.TabIndex = 7;
            this.FilelistView.DragDrop += new System.Windows.Forms.DragEventHandler(this.FileList_DragDrop);
            this.FilelistView.DragOver += new System.Windows.Forms.DragEventHandler(this.FileList_DragOver);
            // 
            // CreateButton
            // 
            this.CreateButton.Location = new System.Drawing.Point(13, 260);
            this.CreateButton.Name = "CreateButton";
            this.CreateButton.Size = new System.Drawing.Size(558, 23);
            this.CreateButton.TabIndex = 8;
            this.CreateButton.Text = "Create";
            this.CreateButton.UseVisualStyleBackColor = true;
            this.CreateButton.Click += new System.EventHandler(this.CreateButton_Click);
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.Controls.Add(this.NameLabel);
            this.flowLayoutPanel1.Controls.Add(this.NameBox);
            this.flowLayoutPanel1.Controls.Add(this.Destinationlabel);
            this.flowLayoutPanel1.Controls.Add(this.DestinationtextBox);
            this.flowLayoutPanel1.Controls.Add(this.SourcePathlabel);
            this.flowLayoutPanel1.Controls.Add(this.SourcePathtextBox);
            this.flowLayoutPanel1.Controls.Add(this.selectfilebutton);
            this.flowLayoutPanel1.Controls.Add(this.FilelistView);
            this.flowLayoutPanel1.Controls.Add(this.CreateButton);
            this.flowLayoutPanel1.Location = new System.Drawing.Point(12, 12);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Padding = new System.Windows.Forms.Padding(10);
            this.flowLayoutPanel1.Size = new System.Drawing.Size(582, 426);
            this.flowLayoutPanel1.TabIndex = 9;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(608, 471);
            this.Controls.Add(this.flowLayoutPanel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "Form1";
            this.Text = "Form1";
            this.flowLayoutPanel1.ResumeLayout(false);
            this.flowLayoutPanel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label NameLabel;
        private System.Windows.Forms.TextBox NameBox;
        private System.Windows.Forms.TextBox DestinationtextBox;
        private System.Windows.Forms.Label Destinationlabel;
        private System.Windows.Forms.TextBox SourcePathtextBox;
        private System.Windows.Forms.Label SourcePathlabel;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.Button selectfilebutton;
        private System.Windows.Forms.ListBox FilelistView;
        private System.Windows.Forms.Button CreateButton;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
    }
}

