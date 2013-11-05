using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TLG
{
    public partial class Form1 : Form
    {
        private bool closeHover = false;
        private bool minHover = false;
        private bool maxHover = false;
        private bool profileHover = false;
        private bool gamesHover = false;
        private bool mGamesHover = false;
        private bool newsHover = false;
        private bool maximized = false;

        private Uri gamesUrl = new Uri(Application.StartupPath.ToString() + "\\Games.html");
        private Uri newsUrl = new Uri(Application.StartupPath.ToString() + "\\News.html");
        private Uri profileUrl = new Uri(Application.StartupPath.ToString() + "\\Profile.html");
        private Uri mGamesUrl = new Uri(Application.StartupPath.ToString() + "\\My Games.html");

        public Form1()
        {
            this.Draggable(true);
            InitializeComponent();
            this.Banner.SendToBack();
            this.CloseButton.BringToFront();
            this.Maximize.BringToFront();
            this.Minimize.BringToFront();
            this.CloseButton.BackColor = Color.Transparent;
            this.Maximize.BackColor = Color.Transparent;
            this.Minimize.BackColor = Color.Transparent;
            this.GamesButton.BringToFront();
            this.NewsButton.BringToFront();
            this.MGamesButton.BringToFront();
            this.ProfileButton.BringToFront();
            try
            {
                this.Splitter.BackgroundImage = Image.FromFile(Application.StartupPath.ToString() + "\\Graphics\\HSplitter.png");
                this.CloseButton.BackgroundImage = Image.FromFile(Application.StartupPath.ToString() + "\\Graphics\\TLG Close Button.png");
                this.Minimize.BackgroundImage = Image.FromFile(Application.StartupPath.ToString() + "\\Graphics\\TLG Minimize Button.png");
                this.Maximize.BackgroundImage = Image.FromFile(Application.StartupPath.ToString() + "\\Graphics\\TLG Maximize Button.png");
                this.ProfileButton.BackgroundImage = Image.FromFile(Application.StartupPath.ToString() + "\\Graphics\\TLG Profile Button.png");
                this.MGamesButton.BackgroundImage = Image.FromFile(Application.StartupPath.ToString() + "\\Graphics\\TLG My Games Button.png");
                this.NewsButton.BackgroundImage = Image.FromFile(Application.StartupPath.ToString() + "\\Graphics\\TLG News Button.png");
                this.GamesButton.BackgroundImage = Image.FromFile(Application.StartupPath.ToString() + "\\Graphics\\TLG Games Button.png");
                this.Banner.BackgroundImage = Image.FromFile(Application.StartupPath.ToString() + "\\Graphics\\BannerA.png");
            }
            catch (Exception e)
            {
                MessageBox.Show(e.ToString(), "Missing Graphics");
            }
            this.Browser.Url = gamesUrl;
        }

        #region "Close Button"
        private void Close_Click(object sender, MouseEventArgs e)
        {
            this.Close();
        }
        private void Close_Hover(object sender, EventArgs e)
        {
            if (closeHover == false)
            {
                closeHover = true;
                //this.CloseButton.BackColor = Color.Transparent;
                this.CloseButton.BackgroundImage = Image.FromFile(Application.StartupPath.ToString() + "\\Graphics\\TLG Close Button Hover.png");
            }
        }
        private void Close_Leave(object sender, EventArgs e)
        {
            if (closeHover == true)
            {
                closeHover = false;
                //this.CloseButton.BackColor = this.BackColor;
                this.CloseButton.BackgroundImage = Image.FromFile(Application.StartupPath.ToString() + "\\Graphics\\TLG Close Button.png");
            }
        }
        #endregion

        #region "Maximize Button"
        private void Maximize_Click(object sender, MouseEventArgs e)
        {
            if (maximized == false)
            {
                maximized = true;
                this.WindowState = FormWindowState.Maximized;
            }
            else
            {
                maximized = false;
                this.WindowState = FormWindowState.Normal;
            }

        }
        private void Maximize_Hover(object sender, EventArgs e)
        {
            if (maxHover == false)
            {
                maxHover = true;
                //this.Maximize.BackColor = Color.LightGray;
                this.Maximize.BackgroundImage = Image.FromFile(Application.StartupPath.ToString() + "\\Graphics\\TLG Maximize Button Hover.png");
            }
        }
        private void Maximize_Leave(object sender, EventArgs e)
        {
            if (maxHover == true)
            {
                maxHover = false;
                //this.Maximize.BackColor = this.BackColor;
                this.Maximize.BackgroundImage = Image.FromFile(Application.StartupPath.ToString() + "\\Graphics\\TLG Maximize Button.png");
            }
        }
        #endregion

        #region "Minimize Button"
        private void Minimize_Click(object sender, MouseEventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }
        private void Minimize_Hover(object sender, EventArgs e)
        {
            if (minHover == false)
            {
                minHover = true;
                //this.Minimize.BackColor = Color.LightGray;
                this.Minimize.BackgroundImage = Image.FromFile(Application.StartupPath.ToString() + "\\Graphics\\TLG Minimize Button Hover.png");
            }
        }
        private void Minimize_Leave(object sender, EventArgs e)
        {
            if (minHover == true)
            {
                minHover = false;
                //this.Minimize.BackColor = this.BackColor;
                this.Minimize.BackgroundImage = Image.FromFile(Application.StartupPath.ToString() + "\\Graphics\\TLG Minimize Button.png");
            }
        }
#endregion

        #region "Games Button"
        private void Games_Click(object sender, MouseEventArgs e)
        {
            this.Browser.Url = gamesUrl;
        }
        private void Games_Hover(object sender, EventArgs e)
        {
            if (gamesHover == false)
            {
                gamesHover = true;
                this.GamesButton.BackgroundImage = Image.FromFile(Application.StartupPath.ToString() + "\\Graphics\\TLG Games Button Hover.png");
            }
        }
        private void Games_Leave(object sender, EventArgs e)
        {
            if (gamesHover == true)
            {
                gamesHover = false;
                this.GamesButton.BackgroundImage = Image.FromFile(Application.StartupPath.ToString() + "\\Graphics\\TLG Games Button.png");
            }
        }
        #endregion

        #region "News Button"
        private void News_Click(object sender, MouseEventArgs e)
        {
            this.Browser.Url = newsUrl;
        }
        private void News_Hover(object sender, EventArgs e)
        {
            if (newsHover == false)
            {
                newsHover = true;
                this.NewsButton.BackgroundImage = Image.FromFile(Application.StartupPath.ToString() + "\\Graphics\\TLG News Button Hover.png");
            }
        }
        private void News_Leave(object sender, EventArgs e)
        {
            if (newsHover == true)
            {
                newsHover = false;
                this.NewsButton.BackgroundImage = Image.FromFile(Application.StartupPath.ToString() + "\\Graphics\\TLG News Button.png");
            }
        }
        #endregion

        #region "My Games Button"
        private void MGames_Click(object sender, MouseEventArgs e)
        {
            this.Browser.Url = mGamesUrl;
        }
        private void MGames_Hover(object sender, EventArgs e)
        {
            if (mGamesHover == false)
            {
                mGamesHover = true;
                this.MGamesButton.BackgroundImage = Image.FromFile(Application.StartupPath.ToString() + "\\Graphics\\TLG My Games Button Hover.png");
            }
        }
        private void MGames_Leave(object sender, EventArgs e)
        {
            if (mGamesHover == true)
            {
                mGamesHover = false;
                this.MGamesButton.BackgroundImage = Image.FromFile(Application.StartupPath.ToString() + "\\Graphics\\TLG My Games Button.png");
            }
        }
        #endregion

        #region "Profile Button"
        private void Profile_Click(object sender, MouseEventArgs e)
        {
            this.Browser.Url = profileUrl;
        }
        private void Profile_Hover(object sender, EventArgs e)
        {
            if (profileHover == false)
            {
                profileHover = true;
                this.ProfileButton.BackgroundImage = Image.FromFile(Application.StartupPath.ToString() + "\\Graphics\\TLG Profile Button Hover.png");
            }
        }
        private void Profile_Leave(object sender, EventArgs e)
        {
            if (profileHover == true)
            {
                profileHover = false;
                this.ProfileButton.BackgroundImage = Image.FromFile(Application.StartupPath.ToString() + "\\Graphics\\TLG Profile Button.png");
            }
        }
        #endregion





    }
}
