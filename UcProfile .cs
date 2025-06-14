using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Text;
using System.Windows.Forms;

namespace ChessGame2.Forms
{
    public partial class UcProfile : UserControl
    {
        
        public UcProfile()
        {
            InitializeComponent();
        }
        private clsProfile _profile;
        public void LoadProfile(string ProfileName)
        {
            clsProfile profile = new clsProfile(ProfileName);
            profile.LoadProfile();
            this._profile = profile;
            clsImage Avatar = profile.Avatar;
            picAvatar.Image = Avatar.Avatar;
            lblPlayerName.Text = profile.PlayerName;
            lblTotalWin.Text = profile.TotalWin.ToString ();
            lblTotalDraw.Text = profile.TotalDraw.ToString();
            lblTotalLose.Text = profile.TotalLose.ToString();
            lblRating.Text = profile.Rating.ToString();
        }
        public void LoadProfile(string ProfileName,string totalwin,string totaldraw,string totallose,string rating)
        {
            picAvatar.Image = global::ChessGame2.Properties.Resources.logoBW;
            lblPlayerName.Text = ProfileName;
            lblTotalWin.Text = totalwin;
            lblTotalDraw.Text = totaldraw;
            lblTotalLose.Text = totallose;
            lblRating.Text = rating;
        }
        public clsProfile Profile
        {
            get { return this._profile; }
            set { this._profile = value; }
        }
        private void UcProfile_Load(object sender, EventArgs e)
        {
           
            
        }

       
    }
}
