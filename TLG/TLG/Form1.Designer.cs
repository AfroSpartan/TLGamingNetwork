namespace TLG
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.CloseButton = new System.Windows.Forms.Panel();
            this.Minimize = new System.Windows.Forms.Panel();
            this.Maximize = new System.Windows.Forms.Panel();
            this.Banner = new TLG.MouseTransparentPanel();
            this.MGamesButton = new System.Windows.Forms.PictureBox();
            this.ProfileButton = new System.Windows.Forms.PictureBox();
            this.NewsButton = new System.Windows.Forms.PictureBox();
            this.GamesButton = new System.Windows.Forms.PictureBox();
            this.Splitter = new TLG.MouseTransparentPanel();
            this.Browser = new System.Windows.Forms.WebBrowser();
            this.Banner.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.MGamesButton)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ProfileButton)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.NewsButton)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.GamesButton)).BeginInit();
            this.SuspendLayout();
            // 
            // CloseButton
            // 
            this.CloseButton.BackColor = System.Drawing.Color.Transparent;
            this.CloseButton.BackgroundImage = global::TLG.Properties.Resources.TLG_Close_Button;
            this.CloseButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.CloseButton.Location = new System.Drawing.Point(949, -1);
            this.CloseButton.Name = "CloseButton";
            this.CloseButton.Size = new System.Drawing.Size(24, 23);
            this.CloseButton.TabIndex = 0;
            this.CloseButton.MouseClick += new System.Windows.Forms.MouseEventHandler(this.Close_Click);
            this.CloseButton.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.Close_Click);
            this.CloseButton.MouseEnter += new System.EventHandler(this.Close_Hover);
            this.CloseButton.MouseLeave += new System.EventHandler(this.Close_Leave);
            // 
            // Minimize
            // 
            this.Minimize.BackColor = System.Drawing.Color.Transparent;
            this.Minimize.BackgroundImage = global::TLG.Properties.Resources.TLG_Minimize_Button;
            this.Minimize.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.Minimize.Location = new System.Drawing.Point(903, -1);
            this.Minimize.Name = "Minimize";
            this.Minimize.Size = new System.Drawing.Size(24, 23);
            this.Minimize.TabIndex = 0;
            this.Minimize.MouseClick += new System.Windows.Forms.MouseEventHandler(this.Minimize_Click);
            this.Minimize.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.Minimize_Click);
            this.Minimize.MouseEnter += new System.EventHandler(this.Minimize_Hover);
            this.Minimize.MouseLeave += new System.EventHandler(this.Minimize_Leave);
            // 
            // Maximize
            // 
            this.Maximize.BackColor = System.Drawing.Color.Transparent;
            this.Maximize.BackgroundImage = global::TLG.Properties.Resources.TLG_Maximize_Button;
            this.Maximize.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.Maximize.Location = new System.Drawing.Point(926, -1);
            this.Maximize.Name = "Maximize";
            this.Maximize.Size = new System.Drawing.Size(24, 23);
            this.Maximize.TabIndex = 0;
            this.Maximize.MouseClick += new System.Windows.Forms.MouseEventHandler(this.Maximize_Click);
            this.Maximize.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.Maximize_Click);
            this.Maximize.MouseEnter += new System.EventHandler(this.Maximize_Hover);
            this.Maximize.MouseLeave += new System.EventHandler(this.Maximize_Leave);
            // 
            // Banner
            // 
            this.Banner.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("Banner.BackgroundImage")));
            this.Banner.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.Banner.Controls.Add(this.MGamesButton);
            this.Banner.Controls.Add(this.ProfileButton);
            this.Banner.Controls.Add(this.NewsButton);
            this.Banner.Controls.Add(this.GamesButton);
            this.Banner.Location = new System.Drawing.Point(0, 0);
            this.Banner.Name = "Banner";
            this.Banner.Size = new System.Drawing.Size(844, 74);
            this.Banner.TabIndex = 0;
            // 
            // MGamesButton
            // 
            this.MGamesButton.BackColor = System.Drawing.Color.Transparent;
            this.MGamesButton.BackgroundImage = global::TLG.Properties.Resources.TLG_My_Games_Button;
            this.MGamesButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.MGamesButton.InitialImage = global::TLG.Properties.Resources.TLG_My_Games_Button;
            this.MGamesButton.Location = new System.Drawing.Point(458, 28);
            this.MGamesButton.Name = "MGamesButton";
            this.MGamesButton.Size = new System.Drawing.Size(198, 39);
            this.MGamesButton.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.MGamesButton.TabIndex = 0;
            this.MGamesButton.TabStop = false;
            this.MGamesButton.MouseClick += new System.Windows.Forms.MouseEventHandler(this.MGames_Click);
            this.MGamesButton.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.MGames_Click);
            this.MGamesButton.MouseEnter += new System.EventHandler(this.MGames_Hover);
            this.MGamesButton.MouseLeave += new System.EventHandler(this.MGames_Leave);
            // 
            // ProfileButton
            // 
            this.ProfileButton.BackColor = System.Drawing.Color.Transparent;
            this.ProfileButton.BackgroundImage = global::TLG.Properties.Resources.TLG_Profile_Button;
            this.ProfileButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ProfileButton.InitialImage = global::TLG.Properties.Resources.TLG_Profile_Button;
            this.ProfileButton.Location = new System.Drawing.Point(662, 28);
            this.ProfileButton.Name = "ProfileButton";
            this.ProfileButton.Size = new System.Drawing.Size(166, 39);
            this.ProfileButton.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.ProfileButton.TabIndex = 0;
            this.ProfileButton.TabStop = false;
            this.ProfileButton.MouseClick += new System.Windows.Forms.MouseEventHandler(this.Profile_Click);
            this.ProfileButton.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.Profile_Click);
            this.ProfileButton.MouseEnter += new System.EventHandler(this.Profile_Hover);
            this.ProfileButton.MouseLeave += new System.EventHandler(this.Profile_Leave);
            // 
            // NewsButton
            // 
            this.NewsButton.BackColor = System.Drawing.Color.Transparent;
            this.NewsButton.BackgroundImage = global::TLG.Properties.Resources.TLG_News_Button;
            this.NewsButton.InitialImage = global::TLG.Properties.Resources.TLG_News_Button;
            this.NewsButton.Location = new System.Drawing.Point(308, 28);
            this.NewsButton.Name = "NewsButton";
            this.NewsButton.Size = new System.Drawing.Size(144, 39);
            this.NewsButton.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.NewsButton.TabIndex = 0;
            this.NewsButton.TabStop = false;
            this.NewsButton.MouseClick += new System.Windows.Forms.MouseEventHandler(this.News_Click);
            this.NewsButton.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.News_Click);
            this.NewsButton.MouseEnter += new System.EventHandler(this.News_Hover);
            this.NewsButton.MouseLeave += new System.EventHandler(this.News_Leave);
            // 
            // GamesButton
            // 
            this.GamesButton.BackColor = System.Drawing.Color.Transparent;
            this.GamesButton.BackgroundImage = global::TLG.Properties.Resources.TLG_Games_Button;
            this.GamesButton.InitialImage = global::TLG.Properties.Resources.TLG_Games_Button;
            this.GamesButton.Location = new System.Drawing.Point(158, 28);
            this.GamesButton.Name = "GamesButton";
            this.GamesButton.Size = new System.Drawing.Size(144, 39);
            this.GamesButton.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.GamesButton.TabIndex = 0;
            this.GamesButton.TabStop = false;
            this.GamesButton.MouseClick += new System.Windows.Forms.MouseEventHandler(this.Games_Click);
            this.GamesButton.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.Games_Click);
            this.GamesButton.MouseEnter += new System.EventHandler(this.Games_Hover);
            this.GamesButton.MouseLeave += new System.EventHandler(this.Games_Leave);
            // 
            // Splitter
            // 
            this.Splitter.BackColor = System.Drawing.Color.Transparent;
            this.Splitter.BackgroundImage = global::TLG.Properties.Resources.HSplitter1;
            this.Splitter.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.Splitter.Location = new System.Drawing.Point(-1, 73);
            this.Splitter.Name = "Splitter";
            this.Splitter.Size = new System.Drawing.Size(974, 5);
            this.Splitter.TabIndex = 1;
            // 
            // Browser
            // 
            this.Browser.Location = new System.Drawing.Point(12, 80);
            this.Browser.MinimumSize = new System.Drawing.Size(20, 20);
            this.Browser.Name = "Browser";
            this.Browser.Size = new System.Drawing.Size(948, 534);
            this.Browser.TabIndex = 2;
            this.Browser.Url = new System.Uri("", System.UriKind.Relative);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(121)))), ((int)(((byte)(0)))));
            this.ClientSize = new System.Drawing.Size(972, 643);
            this.Controls.Add(this.Browser);
            this.Controls.Add(this.Banner);
            this.Controls.Add(this.Splitter);
            this.Controls.Add(this.CloseButton);
            this.Controls.Add(this.Minimize);
            this.Controls.Add(this.Maximize);
            this.ForeColor = System.Drawing.Color.Silver;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Form1";
            this.Text = "TLG Network";
            this.Banner.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.MGamesButton)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ProfileButton)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.NewsButton)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.GamesButton)).EndInit();
            this.ResumeLayout(false);

        }

        private void Close_Click(object sender, System.EventArgs e)
        {
            throw new System.NotImplementedException();
        }

        #endregion

        private System.Windows.Forms.Panel CloseButton;
        private System.Windows.Forms.Panel Maximize;
        private System.Windows.Forms.Panel Minimize;
        private MouseTransparentPanel Splitter;
        private MouseTransparentPanel Banner;
        private System.Windows.Forms.PictureBox MGamesButton;
        private System.Windows.Forms.PictureBox ProfileButton;
        private System.Windows.Forms.PictureBox NewsButton;
        private System.Windows.Forms.PictureBox GamesButton;
        private System.Windows.Forms.WebBrowser Browser;
    }
}

