namespace TheOfficeQuoteGuessingGameDesktop
{
    partial class Form1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            GenerateButton = new Button();
            TextBox = new TextBox();
            SeasonBox = new TextBox();
            EpisodeBox = new TextBox();
            SeasonLabel = new Label();
            EpisodeLabel = new Label();
            SuspendLayout();
            // 
            // GenerateButton
            // 
            GenerateButton.Font = new Font("Times New Roman", 14.25F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            GenerateButton.Location = new Point(327, 495);
            GenerateButton.Name = "GenerateButton";
            GenerateButton.Size = new Size(105, 35);
            GenerateButton.TabIndex = 0;
            GenerateButton.Text = "Generate";
            GenerateButton.UseVisualStyleBackColor = true;
            GenerateButton.Click += GenerateButton_Click;
            // 
            // TextBox
            // 
            TextBox.Location = new Point(184, 293);
            TextBox.Multiline = true;
            TextBox.Name = "TextBox";
            TextBox.Size = new Size(413, 137);
            TextBox.TabIndex = 1;
           
            // 
            // SeasonBox
            // 
            SeasonBox.Location = new Point(235, 453);
            SeasonBox.Name = "SeasonBox";
            SeasonBox.Size = new Size(100, 23);
            SeasonBox.TabIndex = 2;
            // 
            // EpisodeBox
            // 
            EpisodeBox.Location = new Point(431, 453);
            EpisodeBox.Name = "EpisodeBox";
            EpisodeBox.Size = new Size(100, 23);
            EpisodeBox.TabIndex = 3;
            // 
            // SeasonLabel
            // 
            SeasonLabel.AutoSize = true;
            SeasonLabel.Font = new Font("Times New Roman", 11.25F, FontStyle.Bold, GraphicsUnit.Point);
            SeasonLabel.Location = new Point(257, 433);
            SeasonLabel.Name = "SeasonLabel";
            SeasonLabel.Size = new Size(54, 17);
            SeasonLabel.TabIndex = 4;
            SeasonLabel.Text = "Season";
            // 
            // EpisodeLabel
            // 
            EpisodeLabel.AutoSize = true;
            EpisodeLabel.Font = new Font("Times New Roman", 11.25F, FontStyle.Bold, GraphicsUnit.Point);
            EpisodeLabel.Location = new Point(447, 433);
            EpisodeLabel.Name = "EpisodeLabel";
            EpisodeLabel.Size = new Size(61, 17);
            EpisodeLabel.TabIndex = 5;
            EpisodeLabel.Text = "Episode";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(807, 555);
            Controls.Add(EpisodeLabel);
            Controls.Add(SeasonLabel);
            Controls.Add(EpisodeBox);
            Controls.Add(SeasonBox);
            Controls.Add(TextBox);
            Controls.Add(GenerateButton);
            Name = "Form1";
            Text = "The Office Quote Guessing Game";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button GenerateButton;
        private TextBox TextBox;
        private TextBox SeasonBox;
        private TextBox EpisodeBox;
        private Label SeasonLabel;
        private Label EpisodeLabel;
    }
}