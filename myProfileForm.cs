using myKSU_v3.Library;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml;

namespace myKSU_v3
{
    public partial class myProfileForm : Form
    {
        private myHomeForm homeForm { get; set; }
        private Student student { get; set; }
        private Profile profile { get; set; }
        private AdvisorBot bot { get; set; }

        public myProfileForm(myHomeForm home, Student s, Profile p, AdvisorBot ab)
        {
            InitializeComponent();

            this.homeForm = home;  // back to home nav
            this.student = s;      // store objects
            this.profile = p;
            this.bot = ab;

            loadProfileFields();   // get & display profile fields from profile.json

            chatbot_mainPnl.Visible = false;  // set chatbot panel to hidden on load
        }

        // BACK TO HOME NAV & HELP BUTTONS
        private void charges_helpBtn_Click(object sender, EventArgs e) => MessageBox.Show("Placeholder text");
        private void charges_backBtn_Click(object sender, EventArgs e)
        {
            homeForm.Show();
            this.Hide();
        }

        // GET PROFILE FIELDS VIA DATALOADER & DISPLAY IN FORM 
        public void loadProfileFields()
        {
            // Profile obj created at login, passed to home, passed to profile, updated and saved by DataLoader
            profile_websiteText.Text = profile.url;
            profile_interestsText.Text = profile.interests;
            profile_quoteText.Text = profile.favQuote;
            profile_bioText.Text = profile.bio;
        }

        // ENABLE EDITING PROFILE FIELDS
        private void profile_editProfileBtn_Click(object sender, EventArgs e)
        {
            profile_editModeLbl.Visible = true;             // show "EDIT MODE ON" label

            profile_websiteText.ReadOnly = false;           // set textboxes to useable
            profile_interestsText.ReadOnly = false;
            profile_quoteText.ReadOnly = false;
            profile_bioText.ReadOnly = false;

            profile_websiteText.BackColor = Color.White;    // set textbox color to white
            profile_interestsText.BackColor = Color.White;
            profile_quoteText.BackColor = Color.White;
            profile_bioText.BackColor = Color.White;
        }

        // EDIT PROFILE AVATAR
        private void profile_editPicLink_Click(object sender, EventArgs e) => 
            MessageBox.Show("Local storage access diabled for prototype.");

        // SAVE EDITS TO PROFILE.JSON
        private void profile_saveBtn_Click(object sender, EventArgs e)
        {
            profile_editModeLbl.Visible = false;             // hide "EDIT MODE ON" label

            profile_websiteText.ReadOnly = true;             // reset textboxes to readonly
            profile_interestsText.ReadOnly = true;
            profile_quoteText.ReadOnly = true;
            profile_bioText.ReadOnly = true;

            profile_websiteText.BackColor = Color.WhiteSmoke;     // reset textbox color to whitesmoke
            profile_interestsText.BackColor = Color.WhiteSmoke;
            profile_quoteText.BackColor = Color.WhiteSmoke;
            profile_bioText.BackColor = Color.WhiteSmoke;

            profile.url = profile_websiteText.Text;          // get updated field values
            profile.interests = profile_interestsText.Text;
            profile.favQuote = profile_quoteText.Text;
            profile.bio = profile_bioText.Text;

            DataLoader.saveProfileData(profile);            // update profile.json
        }

        // CHATBOT LOGIC
        private void chatbot_owlPic_Click(object sender, EventArgs e) =>
            chatbot_mainPnl.Visible = !chatbot_mainPnl.Visible;                    // visibility set to opposite of current state

        private void chatbot_askBtn_Click(object sender, EventArgs e)
        {
            string userInput = chatbot_questionTextBox.Text.Trim();                // get input from textbox

            if (string.IsNullOrEmpty(userInput))
                chatbot_replyText.Text = "Hoot! You forgot to ask me a question!";  // confirm input len > 0

            string reply = bot.parseChatbotReply(userInput);                    // pass input to be parsed & keyword/regex matched
            chatbot_replyText.Text = reply;                                         // show reponse in output region
        }

        private void chatbot_helpLbl_Click(object sender, EventArgs e) =>
            chatbot_replyText.Text = "Hoot! I can answer questions about your GPA, major, class standing, and enrolled courses. I can also give other answers like the next registration add/drop deadline and info on offices like the Registrar's Office or Campus Police.";

        private void chatbot_exitLbl_Click(object sender, EventArgs e) =>
            chatbot_mainPnl.Visible = false;                                        // hide panel        
    }
}