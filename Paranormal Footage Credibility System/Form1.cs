using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Collections;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Paranormal_Footage_Credibility_System
{
    public partial class Form1 : Form
    {
        public int currentRating = 100;//all footage starts at 100 points credibility and is reduced through affirmative answers to questions

        public string[] ratingOutputs = new string[] {
            "Strenuous rigour, intense scrutiny and sources cited required to refute footage / claims.",
            "Elevated levels of scrutiny, reasonable detail required for counter-explanation or debunking.",
            "Reasonable, non-paranormal explanations are to be accepted over the paranormal.",
            "Only brief, non-paranormal explanations are required to refute footage / claims.",
            "Footage lacks credibility and is to be dismissed out of hand.",
            "Footage to be subjected to intense mockery."
        };
        public string[] quickRatings = new string[] {
            "Possibly credible footage...",
            "Possibly authentic or high-quality fake",
            "Unlikely to be 100% authentic",
            "Likely fake",
            "Absolutely fake",
            "Absolute BULLSHIT!!!"
        };

        public Dictionary<string, int> checkListDictionary = new Dictionary<string, int>();


        private void FufillCheckListValues() {//create questions to check credibilty
                                              //affirmative answers to the undernoted erode credibility according to the weighting values
                                              //dictionary TValue represents weighting
            checkListDictionary.Add("No clear reason OR flimsy reason(s) for camera operator to be recording ?", 10);
            checkListDictionary.Add("Footage is shot in portrait mode ?", 10);
            checkListDictionary.Add("Trail Camera Footage ?", 10);
            checkListDictionary.Add("CCTV Footage ?", 15);
            checkListDictionary.Add("Footage takes place at night, or with limited visibility ?", 15);
            checkListDictionary.Add("Footage uses Infra Red or similar night camera technology ?", 15);
            checkListDictionary.Add("Footage ends abruptly without explanation ?", 15);
            checkListDictionary.Add("Footage is cropped, has deliberate edits or lacks context ?", 20);
            checkListDictionary.Add("Footage comes with elaborate backstory ?", 25);
            checkListDictionary.Add("Contains the phrase \"There was no one else present at the time\" ?", 30);
            checkListDictionary.Add("Footage is from CCTV that has no clear reason to exist - e.g.CCTV in a residential home looking at nothing in particular ?", 30);
            checkListDictionary.Add("Camera operator makes no attempt to approach subject where reasonably applicable ?", 30);
            checkListDictionary.Add("Footage is unreasonably shakey and / or contains unnecessary zooms OR camera operator looks away from the subject?", 35);
            checkListDictionary.Add("Footage resolution is lower than 720p ?", 35);
            checkListDictionary.Add("Footage depicts known graphical errors / technical glitches ?", 40);
            checkListDictionary.Add("Frames Per Second of Footage is less than 10fps ?", 40);
            checkListDictionary.Add("Footage has large amount of digital compression ?", 45);
            checkListDictionary.Add("Subject of footage is indistinct and / or some distance away ?", 45);
            checkListDictionary.Add("Footage is CCTV footage recorded off a screen with a phone ?", 50);
            checkListDictionary.Add("Footage is from a Redditor ?", 30);
            checkListDictionary.Add("Footage is from a TikToker ?", 40);
            checkListDictionary.Add("Footage is from a Youtuber ?", 50);
            checkListDictionary.Add("Footage is from \"Paranormal Investigator\" Youtuber or similar ?", 60);
            checkListDictionary.Add("Footage only contains \"mysterious sounds\", with no visual phenomenon ?", 70);
        }

        private void FufillCheckedListBoxObject() {
            checkListBox1.Items.Clear();
            checkListBox1.Items.AddRange(checkListDictionary.Keys.ToArray());
        }


        public Form1()
        {
            InitializeComponent();
            FufillCheckListValues();
            FufillCheckedListBoxObject();
        }

        private void btn_clr_Click(object sender, EventArgs e)
        {
            checkListBox1.ClearSelected();
            foreach (int i in checkListBox1.CheckedIndices) {
                checkListBox1.SetItemCheckState(i, CheckState.Unchecked);
            }
            currentRating = 100;
        }

        private void checkListBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void btn_showRating_Click(object sender, EventArgs e)
        {
            currentRating = 100;
            int ratingIndex = 0;

            for (int i = 0; i < checkListBox1.Items.Count; i++) {
                if (checkListBox1.GetItemChecked(i) == true) {
                    currentRating -= checkListDictionary[checkListBox1.Items[i].ToString()];
                }
            }

            if (currentRating > 79)
            {
                ratingIndex = 0;
            }
            else if (currentRating < 80 && currentRating > 59)
            {
                ratingIndex = 1;
            }
            else if (currentRating < 60 && currentRating > 39)
            {
                ratingIndex = 2;
            }
            else if (currentRating < 40 && currentRating > 19)
            {
                ratingIndex = 3;
            }
            else if (currentRating < 20 && currentRating > -1) {
                ratingIndex = 4;
            }
            else if (currentRating < 0){
                ratingIndex = 5;
            }
            longRating.Text = ratingOutputs[ratingIndex];
            quickRating.Text = quickRatings[ratingIndex];
            scoreValue.Text = currentRating.ToString();
        }

        private void btn_reset_Click(object sender, EventArgs e)
        {
            checkListBox1.ClearSelected();
            foreach (int i in checkListBox1.CheckedIndices)
            {
                checkListBox1.SetItemCheckState(i, CheckState.Unchecked);
            }
            currentRating = 100;
            scoreValue.Text = currentRating.ToString();
            longRating.Text = "";
            quickRating.Text = "";
        }

        private void btn_about_Click(object sender, EventArgs e)
        {
            
            MessageBox.Show("The Paranormal Footage Credibility (PFC) Rating System is " +
                "a scoring system designed to rate the potential credibility of any " +
                "footage purporting to show paranormal activity (not the movie). This " +
                "system starts by assuming 100% credibility for any given footage and " +
                "converts this into a points system, 100 being the maximum or absolutely " +
                "credible footage. As elements from the checklist are selected, they are " +
                "individually weighted to represent the amount of credibility eroded by " +
                "their inclusion. This is not to say it is impossible for footage with " +
                "a low credibility score to be genuine, but instead represents if it is " +
                "probable, rather than possible. Designed and built by DDD Wares, Nov 2021.");
        }

        private void btn_tips_Click(object sender, EventArgs e)
        {
            MessageBox.Show("The Paranormal Footage Credibility Rating System is first " +
                "and foremost a tool - It should be used in conjuction with your best " +
                "judgement and common sense. Beware of \"doubling\" up on check mark options - " +
                "for instance, if camera footage uses night camera technology, you need not " +
                "select both this option and the \"takes place during night\" option, as the " +
                "former is weighted to include this factor. Generally speaking, if you are " +
                "unsure as to what to choose between two options, pick the lower one on the " +
                "list, as this will be weighted to include any prerequisites.");
        }
    } 
}
