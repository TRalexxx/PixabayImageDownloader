namespace PixabayDownloader
{
    partial class PixabayImageDownloader
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
            label1 = new Label();
            TBSearchWords = new TextBox();
            label2 = new Label();
            TBSaveFolder = new TextBox();
            BtnChooseFolder = new Button();
            NUDImagesNumber = new NumericUpDown();
            label3 = new Label();
            BtnDownload = new Button();
            ((System.ComponentModel.ISupportInitialize)NUDImagesNumber).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(12, 9);
            label1.Name = "label1";
            label1.Size = new Size(145, 15);
            label1.TabIndex = 0;
            label1.Text = "Enter image search words:";
            // 
            // TBSearchWords
            // 
            TBSearchWords.Location = new Point(12, 27);
            TBSearchWords.Name = "TBSearchWords";
            TBSearchWords.Size = new Size(509, 23);
            TBSearchWords.TabIndex = 1;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(12, 53);
            label2.Name = "label2";
            label2.Size = new Size(110, 15);
            label2.TabIndex = 2;
            label2.Text = "Choose save folder:";
            // 
            // TBSaveFolder
            // 
            TBSaveFolder.Location = new Point(12, 71);
            TBSaveFolder.Name = "TBSaveFolder";
            TBSaveFolder.Size = new Size(410, 23);
            TBSaveFolder.TabIndex = 3;
            // 
            // BtnChooseFolder
            // 
            BtnChooseFolder.Location = new Point(428, 71);
            BtnChooseFolder.Name = "BtnChooseFolder";
            BtnChooseFolder.Size = new Size(93, 23);
            BtnChooseFolder.TabIndex = 4;
            BtnChooseFolder.Text = "Choose folder";
            BtnChooseFolder.UseVisualStyleBackColor = true;
            BtnChooseFolder.Click += BtnChooseFolder_Click;
            // 
            // NUDImagesNumber
            // 
            NUDImagesNumber.Location = new Point(224, 100);
            NUDImagesNumber.Minimum = new decimal(new int[] { 3, 0, 0, 0 });
            NUDImagesNumber.Name = "NUDImagesNumber";
            NUDImagesNumber.Size = new Size(74, 23);
            NUDImagesNumber.TabIndex = 5;
            NUDImagesNumber.Value = new decimal(new int[] { 3, 0, 0, 0 });
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(12, 102);
            label3.Name = "label3";
            label3.Size = new Size(206, 15);
            label3.TabIndex = 6;
            label3.Text = "Choose how many images download:";
            // 
            // BtnDownload
            // 
            BtnDownload.Location = new Point(446, 102);
            BtnDownload.Name = "BtnDownload";
            BtnDownload.Size = new Size(75, 23);
            BtnDownload.TabIndex = 7;
            BtnDownload.Text = "Download";
            BtnDownload.UseVisualStyleBackColor = true;
            BtnDownload.Click += BtnDownload_Click;
            // 
            // PixabayImageDownloader
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(567, 159);
            Controls.Add(BtnDownload);
            Controls.Add(label3);
            Controls.Add(NUDImagesNumber);
            Controls.Add(BtnChooseFolder);
            Controls.Add(TBSaveFolder);
            Controls.Add(label2);
            Controls.Add(TBSearchWords);
            Controls.Add(label1);
            Name = "PixabayImageDownloader";
            Text = "PixabayImageDownloader";
            ((System.ComponentModel.ISupportInitialize)NUDImagesNumber).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private TextBox TBSearchWords;
        private Label label2;
        private TextBox TBSaveFolder;
        private Button BtnChooseFolder;
        private NumericUpDown NUDImagesNumber;
        private Label label3;
        private Button BtnDownload;
    }
}