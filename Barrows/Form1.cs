using System;
using System.Drawing;
using System.Windows.Forms;
using Microsoft.VisualBasic;

namespace Barrows
{
    public partial class Barrows : Form
    {
        public Barrows()
        {
            InitializeComponent();
        }

        //## Item Clicked ################################################################################################
        //Items code for labels / counters
        public void CountHandler(bool First, int Counter, Label CountLabel, PictureBox Image)
        {
            CountLabel.Visible = true;                  // Show the counter
            CountLabel.Parent = Image;                  // Makes the label a parent of the image
            CountLabel.BackColor = Color.Transparent;   // Makes the label background transparent
            CountLabel.Location = new Point(20, 28);    // Set the location of the counter
            CountLabel.BringToFront();

            if (First == true)
            {
                //You will enter this on the first time you click on the item
                First = false;                          // Set first time to false
                Counter = 1;                            // Set count to 1
                CountLabel.Text = Counter.ToString();   // Show the counter value (1)
            }
            else
            {
                //You will enter this every time you click the item's after the first
                CountLabel.Text = Counter.ToString();   //Update the counter with the correct variable
            }
        }

        /*Example
        This is an example of the following functions, explaining the layout
        [item] is where the name for the specific item would be

        //These two are needed for each instance
        bool [item]First = false;
        int [item]Counter = 0;

        private void [item]_Click(object sender, EventArgs e)
        {
            if ([item]First == true)
            {
                //This true option is only used on the first time entering the loop
                //This is where the object is changed to non-transparent version.
                [item]Counter = 1;
                [item]First = false;                                            //So we wont enter this part again
                CountHandler([item]First, [item]Counter, [item]Count, [item]);  //Goes into the loop to make any changes to item
                [item].BackgroundImage = Properties.Resources.[item];           //This changes the item to non-transparent version
            }
            else
            {
                CountHandler([item]First, [item]Counter, [item]Count, [item]); //Goes into the loop to make any changes to item
            }
        }
        */

        // Ahrims
        bool AHoodFirst;
        int AHoodCounter;
        private void AHood_Click(object sender, EventArgs e)
        {
            if (AHoodFirst == true)
            {
                AHoodFirst = false;
                AHood.BackgroundImage = Properties.Resources.AHood;
                CountHandler(true, AHoodCounter, AHoodCount, AHood);
            }
            else
            {
                AHood.BackgroundImage = Properties.Resources.AHood;
                AHoodCounter++;
                CountHandler(AHoodFirst, AHoodCounter, AHoodCount, AHood);
            }
        }

        bool AStaffFirst;
        int AStaffCounter;
        private void AStaff_Click(object sender, EventArgs e)
        {
            if (AStaffFirst == true)
            {
                AStaffFirst = false;
                CountHandler(true, 1, AStaffCount, AStaff);
                AStaff.BackgroundImage = Properties.Resources.AStaff;
            }
            else
            {
                AStaff.BackgroundImage = Properties.Resources.AStaff;
                AStaffCounter++;
                CountHandler(AStaffFirst, AStaffCounter, AStaffCount, AStaff);
            }
        }

        bool ATopFirst;
        int ATopCounter;
        private void ATop_Click(object sender, EventArgs e)
        {
            if (ATopFirst == true)
            {
                ATopCounter = 1;
                ATopFirst = false;
                CountHandler(true, 1, ATopCount, ATop);
                ATop.BackgroundImage = Properties.Resources.ATop;
            }
            else
            {
                ATop.BackgroundImage = Properties.Resources.ATop;
                ATopCounter++;
                CountHandler(ATopFirst, ATopCounter, ATopCount, ATop);
            }
        }

        bool ASkirtFirst;
        int ASkirtCounter;
        private void ASkirt_Click(object sender, EventArgs e)
        {
            if (ASkirtFirst == true)
            {
                ASkirtCounter = 1;
                ASkirtFirst = false;
                CountHandler(true, 1, ASkirtCount, ASkirt);
                ASkirt.BackgroundImage = Properties.Resources.ASkirt;
            }
            else
            {
                ASkirt.BackgroundImage = Properties.Resources.ASkirt;
                ASkirtCounter++;
                CountHandler(ASkirtFirst, ASkirtCounter, ASkirtCount, ASkirt);
            }
        }

        // Dharoks
        bool DHelmFirst;
        int DHelmCounter;
        private void DHelm_Click(object sender, EventArgs e)
        {
            if (DHelmFirst == true)
            {
                DHelmCounter = 1;
                DHelmFirst = false;
                CountHandler(true, 1, DHelmCount, DHelm);
                DHelm.BackgroundImage = Properties.Resources.DHelm;
            }
            else
            {
                DHelm.BackgroundImage = Properties.Resources.DHelm;
                DHelmCounter++;
                CountHandler(DHelmFirst, DHelmCounter, DHelmCount, DHelm);
            }
        }

        bool DAxeFirst;
        int DAxeCounter;
        private void DAxe_Click(object sender, EventArgs e)
        {
            if (DAxeFirst == true)
            {
                DAxeCounter = 1;
                DAxeFirst = false;
                CountHandler(true, 1, DAxeCount, DAxe);
                DAxe.BackgroundImage = Properties.Resources.DAxe;
            }
            else
            {
                DAxe.BackgroundImage = Properties.Resources.DAxe;
                DAxeCounter++;
                CountHandler(DAxeFirst, DAxeCounter, DAxeCount, DAxe);
            }
        }

        bool DPlateFirst;
        int DPlateCounter;
        private void DPlate_Click(object sender, EventArgs e)
        {
            if (DPlateFirst == true)
            {
                DPlateCounter = 1;
                DPlateFirst = false;
                CountHandler(true, 1, DPlateCount, DPlate);
                DPlate.BackgroundImage = Properties.Resources.DPlate;
            }
            else
            {
                DPlate.BackgroundImage = Properties.Resources.DPlate;
                DPlateCounter++;
                CountHandler(DPlateFirst, DPlateCounter, DPlateCount, DPlate);
            }
        }

        bool DLegsFirst;
        int DLegsCounter;
        private void DLegs_Click(object sender, EventArgs e)
        {
            if (DLegsFirst == true)
            {
                DLegsCounter = 1;
                DLegsFirst = false;
                CountHandler(true, 1, DLegsCount, DLegs);
                DLegs.BackgroundImage = Properties.Resources.DLegs;
            }
            else
            {
                DLegs.BackgroundImage = Properties.Resources.DLegs;
                DLegsCounter++;
                CountHandler(DLegsFirst, DLegsCounter, DLegsCount, DLegs);
            }
        }

        // Guthans
        bool GPlateFirst;
        int GPlateCounter;
        private void GPlate_Click(object sender, EventArgs e)
        {
            if (GPlateFirst == true)
            {
                GPlateCounter = 1;
                GPlateFirst = false;
                CountHandler(true, 1, GPlateCount, GPlate);
                GPlate.BackgroundImage = Properties.Resources.GPlate;
            }
            else
            {
                GPlate.BackgroundImage = Properties.Resources.GPlate;
                GPlateCounter++;
                CountHandler(GPlateFirst, GPlateCounter, GPlateCount, GPlate);
            }
        }

        bool GSpearFirst;
        int GSpearCounter;
        private void GSpear_Click(object sender, EventArgs e)
        {
            if (GSpearFirst == true)
            {
                GSpearCounter = 1;
                GSpearFirst = false;
                CountHandler(true, 1, GSpearCount, GSpear);
                GSpear.BackgroundImage = Properties.Resources.GSpear;
            }
            else
            {
                GSpear.BackgroundImage = Properties.Resources.GSpear;
                GSpearCounter++;
                CountHandler(GSpearFirst, GSpearCounter, GSpearCount, GSpear);
            }
        }

        bool GSkirtFirst;
        int GSkirtCounter;
        private void GSkirt_Click(object sender, EventArgs e)
        {
            if (GSkirtFirst == true)
            {
                GSkirtCounter = 1;
                GSkirtFirst = false;
                CountHandler(true, 1, GSkirtCount, GSkirt);
                GSkirt.BackgroundImage = Properties.Resources.GSkirt;
            }
            else
            {
                GSkirt.BackgroundImage = Properties.Resources.GSkirt;
                GSkirtCounter++;
                CountHandler(GSkirtFirst, GSkirtCounter, GSkirtCount, GSkirt);
            }
        }

        bool GHelmFirst;
        int GHelmCounter;
        private void GHelm_Click(object sender, EventArgs e)
        {
            if (GHelmFirst == true)
            {
                GHelmCounter = 1;
                GHelmFirst = false;
                CountHandler(true, 1, GHelmCount, GHelm);
                GHelm.BackgroundImage = Properties.Resources.GHelm;
            }
            else
            {
                GHelm.BackgroundImage = Properties.Resources.GHelm;
                GHelmCounter++;
                CountHandler(GHelmFirst, GHelmCounter, GHelmCount, GHelm);
            }
        }

        // Karils
        bool KBowFirst;
        int KBowCounter;
        private void KBow_Click(object sender, EventArgs e)
        {
            if (KBowFirst == true)
            {
                KBowCounter = 1;
                KBowFirst = false;
                CountHandler(true, 1, KBowCount, KBow);
                KBow.BackgroundImage = Properties.Resources.KBow;
            }
            else
            {
                KBow.BackgroundImage = Properties.Resources.KBow;
                KBowCounter++;
                CountHandler(false, KBowCounter, KBowCount, KBow);
            }
        }

        bool KCoifFirst;
        int KCoifCounter;
        private void KCoif_Click(object sender, EventArgs e)
        {
            if (KCoifFirst == true)
            {
                KCoifCounter = 1;
                KCoifFirst = false;
                CountHandler(true, 1, KCoifCount, KCoif);
                KCoif.BackgroundImage = Properties.Resources.KCoif;
            }
            else
            {
                KCoif.BackgroundImage = Properties.Resources.KCoif;
                KCoifCounter++;
                CountHandler(false, KCoifCounter, KCoifCount, KCoif);
            }
        }

        bool KTopFirst;
        int KTopCounter;
        private void KTop_Click(object sender, EventArgs e)
        {
            if (KTopFirst == true)
            {
                KTopCounter = 1;
                KTopFirst = false;
                CountHandler(true, 1, KTopCount, KTop);
                KTop.BackgroundImage = Properties.Resources.KTop;
            }
            else
            {
                KTop.BackgroundImage = Properties.Resources.KTop;
                KTopCounter++;
                CountHandler(false, KTopCounter, KTopCount, KTop);
            }
        }

        bool KSkirtFirst;
        int KSkirtCounter;
        private void KSkirt_Click(object sender, EventArgs e)
        {
            if (KSkirtFirst == true)
            {
                KSkirtCounter = 1;
                KSkirtFirst = false;
                CountHandler(true, 1, KSkirtCount, KSkirt);
                KSkirt.BackgroundImage = Properties.Resources.KSkirt;
            }
            else
            {
                KSkirt.BackgroundImage = Properties.Resources.KSkirt;
                KSkirtCounter++;
                CountHandler(false, KSkirtCounter, KSkirtCount, KSkirt);
            }
        }

        // Torags
        bool THelmFirst;
        int THelmCounter;
        private void THelm_Click(object sender, EventArgs e)
        {
            if (THelmFirst == true)
            {
                THelmCounter = 1;
                THelmFirst = false;
                CountHandler(true, 1, THelmCount, THelm);
                THelm.BackgroundImage = Properties.Resources.THelm;
            }
            else
            {
                THelm.BackgroundImage = Properties.Resources.THelm;
                THelmCounter++;
                CountHandler(false, THelmCounter, THelmCount, THelm);
            }
        }

        bool THammersFirst;
        int THammersCounter;
        private void THammers_Click(object sender, EventArgs e)
        {
            if (THammersFirst == true)
            {
                THammersCounter = 1;
                THammersFirst = false;
                CountHandler(true, 1, THammerCount, THammers);
                THammers.BackgroundImage = Properties.Resources.THammer;
            }
            else
            {
                THammers.BackgroundImage = Properties.Resources.THammer;
                THammersCounter++;
                CountHandler(false, THammersCounter, THammerCount, THammers);
            }
        }

        bool TPlateFirst;
        int TPlateCounter;
        private void TPlate_Click(object sender, EventArgs e)
        {
            if (TPlateFirst == true)
            {
                TPlateCounter = 1;
                TPlateFirst = false;
                CountHandler(true, 1, TPlateCount, TPlate);
                TPlate.BackgroundImage = Properties.Resources.TPlate;
            }
            else
            {
                TPlate.BackgroundImage = Properties.Resources.TPlate;
                TPlateCounter++;
                CountHandler(false, TPlateCounter, TPlateCount, TPlate);
            }
        }

        bool TLegsFirst;
        int TLegsCounter;
        private void TLegs_Click(object sender, EventArgs e)
        {
            if (TLegsFirst == true)
            {
                TLegsCounter = 1;
                TLegsFirst = false;
                CountHandler(true, 1, TLegsCount, TLegs);
                TLegs.BackgroundImage = Properties.Resources.TLegs;
            }
            else
            {
                TLegs.BackgroundImage = Properties.Resources.TLegs;
                TLegsCounter++;
                CountHandler(false, TLegsCounter, TLegsCount, TLegs);
            }
        }

        // Veracs
        bool VHelmFirst;
        int VHelmCounter;
        private void VHelm_Click(object sender, EventArgs e)
        {
            if (VHelmFirst == true)
            {
                VHelmCounter = 1;
                VHelmFirst = false;
                CountHandler(true, 1, VHelmCount, VHelm);
                VHelm.BackgroundImage = Properties.Resources.VHelm;
            }
            else
            {
                VHelm.BackgroundImage = Properties.Resources.VHelm;
                VHelmCounter++;
                CountHandler(false, VHelmCounter, VHelmCount, VHelm);
            }
        }

        bool VFlailFirst;
        int VFlailCounter;
        private void VFlail_Click(object sender, EventArgs e)
        {
            if (VFlailFirst == true)
            {
                VFlailCounter = 1;
                VFlailFirst = false;
                CountHandler(true, 1, VFlailCount, VFlail);
                VFlail.BackgroundImage = Properties.Resources.VFlail;
            }
            else
            {
                VFlail.BackgroundImage = Properties.Resources.VFlail;
                VFlailCounter++;
                CountHandler(false, VFlailCounter, VFlailCount, VFlail);
            }
        }

        bool VTopFirst;
        int VTopCounter;
        private void VTop_Click(object sender, EventArgs e)
        {
            if (VTopFirst == true)
            {
                VTopCounter = 1;
                VTopFirst = false;
                CountHandler(true, 1, VTopCount, VTop);
                VTop.BackgroundImage = Properties.Resources.VTop;
            }
            else
            {
                VTop.BackgroundImage = Properties.Resources.VTop;
                VTopCounter++;
                CountHandler(false, VTopCounter, VTopCount, VTop);
            }
        }

        bool VSkirtFirst;
        int VSkirtCounter;
        private void VSkirt_Click(object sender, EventArgs e)
        {
            if (VSkirtFirst == true)
            {
                VSkirtCounter = 1;
                VSkirtFirst = false;
                CountHandler(true, 1, VSkirtCount, VSkirt);
                VSkirt.BackgroundImage = Properties.Resources.VSkirt;
            }
            else
            {
                VSkirt.BackgroundImage = Properties.Resources.VSkirt;
                VSkirtCounter++;
                CountHandler(false, VSkirtCounter, VSkirtCount, VSkirt);
            }
        }

        //## Load / Save Settings ########################################################################################

        public void LoadSettings(int Counter, Label CountLabel, PictureBox Item, string LoadCount)
        {
            if (Counter > 0)
            {
                CountLabel.Visible = true;
                CountLabel.Parent = Item;
                CountLabel.BackColor = Color.Transparent;
                CountLabel.Location = new Point(20, 28);
                CountLabel.BringToFront();
                CountLabel.Text = LoadCount;
            }
            else
            {
                CountLabel.Visible = false;
            }
        }

        public void LoadAhrim()
        {
            AHoodCounter = Properties.Settings.Default.AHoodC;
            if (AHoodCounter > 0) AHood.BackgroundImage = Properties.Resources.AHood;
            LoadSettings(AHoodCounter, AHoodCount, AHood, Properties.Settings.Default.AHoodL);

            AStaffCounter = Properties.Settings.Default.AStaffC;
            if (AStaffCounter > 0) AStaff.BackgroundImage = Properties.Resources.AStaff;
            LoadSettings(AStaffCounter, AStaffCount, AStaff, Properties.Settings.Default.AStaffL);

            ATopCounter = Properties.Settings.Default.ATopC;
            if (ATopCounter > 0) ATop.BackgroundImage = Properties.Resources.ATop;
            LoadSettings(ATopCounter, ATopCount, ATop, Properties.Settings.Default.ATopL);

            ASkirtCounter = Properties.Settings.Default.ASkirtC;
            if (ASkirtCounter > 0) ASkirt.BackgroundImage = Properties.Resources.ASkirt;
            LoadSettings(ASkirtCounter, ASkirtCount, ASkirt, Properties.Settings.Default.ASkirtL);

        }

        public void LoadDharok()
        {
            DHelmCounter = Properties.Settings.Default.DHelmC;
            if (DHelmCounter > 0) DHelm.BackgroundImage = Properties.Resources.DHelm;
            LoadSettings(DHelmCounter, DHelmCount, DHelm, Properties.Settings.Default.DHelmL);

            DAxeCounter = Properties.Settings.Default.DAxeC;
            if (DAxeCounter > 0) DAxe.BackgroundImage = Properties.Resources.DAxe;
            LoadSettings(DAxeCounter, DAxeCount, DAxe, Properties.Settings.Default.DAxeL);

            DPlateCounter = Properties.Settings.Default.DPlateC;
            if (DPlateCounter > 0) DPlate.BackgroundImage = Properties.Resources.DPlate;
            LoadSettings(DPlateCounter, DPlateCount, DPlate, Properties.Settings.Default.DPlateL);

            DLegsCounter = Properties.Settings.Default.DLegsC;
            if (DLegsCounter > 0) DLegs.BackgroundImage = Properties.Resources.DLegs;
            LoadSettings(DLegsCounter, DLegsCount, DLegs, Properties.Settings.Default.DLegsL);

        }

        public void LoadGuthan()
        {
            GHelmCounter = Properties.Settings.Default.GHelmC;
            if (GHelmCounter > 0) GHelm.BackgroundImage = Properties.Resources.GHelm;
            LoadSettings(GHelmCounter, GHelmCount, GHelm, Properties.Settings.Default.GHelmL);

            GSpearCounter = Properties.Settings.Default.GSpearC;
            if (GSpearCounter > 0) GSpear.BackgroundImage = Properties.Resources.GSpear;
            LoadSettings(GSpearCounter, GSpearCount, GSpear, Properties.Settings.Default.GSpearL);

            GPlateCounter = Properties.Settings.Default.GPlateC;
            if (GPlateCounter > 0) GPlate.BackgroundImage = Properties.Resources.GPlate;
            LoadSettings(GPlateCounter, GPlateCount, GPlate, Properties.Settings.Default.GPlateL);

            GSkirtCounter = Properties.Settings.Default.GSkirtC;
            if (GSkirtCounter > 0) GSkirt.BackgroundImage = Properties.Resources.GSkirt;
            LoadSettings(GSkirtCounter, GSkirtCount, GSkirt, Properties.Settings.Default.GSkirtL);

        }

        public void LoadKaril()
        {
            KCoifCounter = Properties.Settings.Default.KCoifC;
            if (KCoifCounter > 0) KCoif.BackgroundImage = Properties.Resources.KCoif;
            LoadSettings(KCoifCounter, KCoifCount, KCoif, Properties.Settings.Default.KCoifL);

            KBowCounter = Properties.Settings.Default.KBowC;
            if (KBowCounter > 0) KBow.BackgroundImage = Properties.Resources.KBow;
            LoadSettings(KBowCounter, KBowCount, KBow, Properties.Settings.Default.KBowL);

            KTopCounter = Properties.Settings.Default.KTopC;
            if (KTopCounter > 0) KTop.BackgroundImage = Properties.Resources.KTop;
            LoadSettings(KTopCounter, KTopCount, KTop, Properties.Settings.Default.KTopL);

            KSkirtCounter = Properties.Settings.Default.KSkirtC;
            if (KSkirtCounter > 0) KSkirt.BackgroundImage = Properties.Resources.KSkirt;
            LoadSettings(KSkirtCounter, KSkirtCount, KSkirt, Properties.Settings.Default.KSkirtL);

        }

        public void LoadTorag()
        {
            THelmCounter = Properties.Settings.Default.THelmC;
            if (THelmCounter > 0) THelm.BackgroundImage = Properties.Resources.THelm;
            LoadSettings(THelmCounter, THelmCount, THelm, Properties.Settings.Default.THelmL);

            THammersCounter = Properties.Settings.Default.THammerC;
            if (THammersCounter > 0) THammers.BackgroundImage = Properties.Resources.THammer;
            LoadSettings(THammersCounter, THammerCount, THammers, Properties.Settings.Default.THammerL);

            TPlateCounter = Properties.Settings.Default.TPlateC;
            if (TPlateCounter > 0) TPlate.BackgroundImage = Properties.Resources.TPlate;
            LoadSettings(TPlateCounter, TPlateCount, TPlate, Properties.Settings.Default.TPlateL);

            TLegsCounter = Properties.Settings.Default.TLegsC;
            if (TLegsCounter > 0) TLegs.BackgroundImage = Properties.Resources.TLegs;
            LoadSettings(TLegsCounter, TLegsCount, TLegs, Properties.Settings.Default.TLegsL);

        }

        public void LoadVerac()
        {
            VHelmCounter = Properties.Settings.Default.VHelmC;
            if (VHelmCounter > 0) VHelm.BackgroundImage = Properties.Resources.VHelm;
            LoadSettings(VHelmCounter, VHelmCount, VHelm, Properties.Settings.Default.VHelmL);

            VFlailCounter = Properties.Settings.Default.VFlailC;
            if (VFlailCounter > 0) VFlail.BackgroundImage = Properties.Resources.VFlail;
            LoadSettings(VFlailCounter, VFlailCount, VFlail, Properties.Settings.Default.VFlailL);

            VTopCounter = Properties.Settings.Default.VTopC;
            if (VTopCounter > 0) VTop.BackgroundImage = Properties.Resources.VTop;
            LoadSettings(VTopCounter, VTopCount, VTop, Properties.Settings.Default.VTopL);

            VSkirtCounter = Properties.Settings.Default.VSkirtC;
            if (VSkirtCounter > 0) VSkirt.BackgroundImage = Properties.Resources.VSkirt;
            LoadSettings(VSkirtCounter, VSkirtCount, VSkirt, Properties.Settings.Default.VSkirtL);

        }

        public void LoadOther()
        {
            if (ChestCount.Text != "0" && ChestCount.Text != "") {
                ChestCount.Visible = true;                      //  }
                ChestCount.Parent = Chest;                      //  }
                ChestCount.BackColor = Color.Transparent;       //  }   Easier to put here, means that it loads all pretty
                ChestCount.Location = new Point(0, 20);         //  }
                ChestCount.BringToFront();                      //  }
                ChestCount.Text = Properties.Settings.Default.ChestL;
            } 
            DryTB.Text = Properties.Settings.Default.DryL;
            LastItemTB.Text = Properties.Settings.Default.LastItemL;
        }

        //Save these when you update any
        private void Barrows_FormClosed(object sender, FormClosedEventArgs e)
        {
            // Ahrims
            Properties.Settings.Default.AHoodL  = AHoodCount.Text;
            Properties.Settings.Default.AHoodC  = AHoodCounter;
            Properties.Settings.Default.AStaffL = AStaffCount.Text;
            Properties.Settings.Default.AStaffC = AStaffCounter;
            Properties.Settings.Default.ATopL   = ATopCount.Text;
            Properties.Settings.Default.ATopC   = ATopCounter;
            Properties.Settings.Default.ASkirtL = ASkirtCount.Text;
            Properties.Settings.Default.ASkirtC = ASkirtCounter;

            // Dharoks
            Properties.Settings.Default.DHelmL  = DHelmCount.Text;
            Properties.Settings.Default.DHelmC  = DHelmCounter;
            Properties.Settings.Default.DAxeL   = DAxeCount.Text;
            Properties.Settings.Default.DAxeC   = DAxeCounter;
            Properties.Settings.Default.DPlateL = DPlateCount.Text;
            Properties.Settings.Default.DPlateC = DPlateCounter;
            Properties.Settings.Default.DLegsL  = DLegsCount.Text;
            Properties.Settings.Default.DLegsC  = DLegsCounter;

            // Guthans
            Properties.Settings.Default.GHelmL  = GHelmCount.Text;
            Properties.Settings.Default.GHelmC  = GHelmCounter;
            Properties.Settings.Default.GSkirtL = GSkirtCount.Text;
            Properties.Settings.Default.GSkirtC = GSkirtCounter;
            Properties.Settings.Default.GSpearL = GSpearCount.Text;
            Properties.Settings.Default.GSpearC = GSpearCounter;
            Properties.Settings.Default.GPlateL = GPlateCount.Text;
            Properties.Settings.Default.GPlateC = GPlateCounter;

            // Karils
            Properties.Settings.Default.KCoifL  = KCoifCount.Text;
            Properties.Settings.Default.KCoifC  = KCoifCounter;
            Properties.Settings.Default.KBowL   = KBowCount.Text;
            Properties.Settings.Default.KBowC   = KBowCounter;
            Properties.Settings.Default.KTopL   = KTopCount.Text;
            Properties.Settings.Default.KTopC   = KTopCounter;
            Properties.Settings.Default.KSkirtL = KSkirtCount.Text;
            Properties.Settings.Default.KSkirtC = KSkirtCounter;

            // Torags
            Properties.Settings.Default.THelmL  = THelmCount.Text;
            Properties.Settings.Default.THelmC  = THelmCounter;
            Properties.Settings.Default.THammerL = THammerCount.Text;
            Properties.Settings.Default.THammerC = THammersCounter;
            Properties.Settings.Default.TPlateL = TPlateCount.Text;
            Properties.Settings.Default.TPlateC = TPlateCounter;
            Properties.Settings.Default.TLegsL  = TLegsCount.Text;
            Properties.Settings.Default.TLegsC  = TLegsCounter;

            // Veracs
            Properties.Settings.Default.VHelmL  = VHelmCount.Text;
            Properties.Settings.Default.VHelmC  = VHelmCounter;
            Properties.Settings.Default.VFlailL = VFlailCount.Text;
            Properties.Settings.Default.VFlailC = VFlailCounter;
            Properties.Settings.Default.VTopL   = VTopCount.Text;
            Properties.Settings.Default.VTopC   = VTopCounter;
            Properties.Settings.Default.VSkirtL = VSkirtCount.Text;
            Properties.Settings.Default.VSkirtC = VSkirtCounter;

            // Other
            if (ChestCount.Text == "0" || ChestCount.Text == "")
            {
                Properties.Settings.Default.ChestL = "";
            }
            else
            {
                Properties.Settings.Default.ChestL = ChestCount.Text;
            }
            Properties.Settings.Default.DryL    = DryTB.Text;
            Properties.Settings.Default.LastItemL = LastItemTB.Text;

            Properties.Settings.Default.Save();
        }

        //Load these when you open
        private void Barrows_Load(object sender, EventArgs e)
        {
            // Load the brothers
            LoadAhrim();
            LoadDharok();
            LoadGuthan();
            LoadKaril();
            LoadTorag();
            LoadVerac();
            // Load other
            LoadOther();
        }

        // Plus button
        int DryCounter = 0;
        private void Plus_Click(object sender, EventArgs e)
        {
            DryCounter = Convert.ToInt32("0"+DryTB.Text);   // Convert whats currently in TB to int. '0' + "" = int
            DryCounter += 1;                                // Add one to the counter
            DryTB.Text = DryCounter.ToString();             // Update the Text in the TB
        }

        // Minus button
        private void Minus_Click(object sender, EventArgs e)
        {
            DryCounter = Convert.ToInt32("0" + DryTB.Text); // Convert whats currently in TB to int. '0' + "" = int
            if (DryCounter > 0)                             // If number is bigger than 0
            {
                DryCounter -= 1;                            // Cant minus if lower than 0
            }
            else
            {
                DryCounter = 0;                             // If number is smaller than 0, reset to 0
            }
            DryTB.Text = DryCounter.ToString();             // Update the Text in the TB
        }

        //## Right click menu code #######################################################################################

        //Chest
        private void Chest_MouseDown(object sender, MouseEventArgs e)
        {
            switch (e.Button)
            {
                case MouseButtons.Right:
                    {
                        ChestRC.Show(this, new Point(780, 60));//places the menu at the pointer position
                    }
                    break;
            }
        }

        private void Custom_Click(object sender, EventArgs e)
        {
            ChestCount.Text = Interaction.InputBox("", "Number of Chests", "0");
            ChestCounter = Convert.ToInt32("" + ChestCount.Text);
            ChestCount.Text = ChestCounter.ToString();
            if (ChestCounter > 0)
            {
                ChestCount.Visible = true;
            }
            else
            {
                ChestCounter = 0;
                ChestCount.Visible = false;
            }
        }

        int ChestCounter;
        private void Chest_Click(object sender, EventArgs e)
        {
            ChestCount.Visible = true;
            ChestCount.Parent = Chest;
            ChestCount.BackColor = Color.Transparent;
            ChestCount.Location = new Point(0, 20);
            ChestCount.BringToFront();

            ChestCounter = Convert.ToInt32("0" + ChestCount.Text);
            ChestCounter += 1;
            ChestCount.Text = ChestCounter.ToString();
        }

        // Ahrims
        private void AHood_MouseDown(object sender, MouseEventArgs e)
        {
            switch (e.Button)
            {
                case MouseButtons.Right:
                    {
                        AHoodRC.Show(this, new Point(54, 43));//places the menu at the pointer position
                    }
                    break;
            }
        }

        private void AStaff_MouseDown(object sender, MouseEventArgs e)
        {
            switch (e.Button)
            {
                case MouseButtons.Right:
                    {
                        AStaffRC.Show(this, new Point(90, 43));//places the menu at the pointer position
                    }
                    break;
            }
        }

        private void ATop_MouseDown(object sender, MouseEventArgs e)
        {
            switch (e.Button)
            {
                case MouseButtons.Right:
                    {
                        ATopRC.Show(this, new Point(54, 100));//places the menu at the pointer position
                    }
                    break;
            }
        }

        private void ASkirt_MouseDown(object sender, MouseEventArgs e)
        {
            switch (e.Button)
            {
                case MouseButtons.Right:
                    {
                        ASkirtRC.Show(this, new Point(90, 100));//places the menu at the pointer position
                    }
                    break;
            }
        }

        private void AHoodM1_Click(object sender, EventArgs e)
        {
            AHoodCounter -= 2;

            if (AHoodCounter <= 0)                                      // If counter is now 0 or below
            {
                AHoodCounter = 0;                                       // Reset to 0 (if not already)                  
                AHoodCount.Visible = false;                             // Hide counter
                AHood.BackgroundImage = Properties.Resources.AHoodT;    // Change back to transparent
            } else
            {
                AHoodCount.Text = AHoodCounter.ToString();              //If not 0, redisplay count
            }
        }

        private void AHoodCustom_Click(object sender, EventArgs e)
        {
            AHoodCount.Text = Interaction.InputBox("", "Number of Ahrim Hood's", "0");
            AHoodCounter = Convert.ToInt32("0" + AHoodCount.Text);
            AHoodCount.Text = AHoodCounter.ToString();
            if (AHoodCounter > 0)
            {
                AHoodCount.Visible = true;
            } else
            {
                AHoodCounter = 0;
                AHoodCount.Visible = false;
                AHood.BackgroundImage = Properties.Resources.AHoodT;
            }
        }

        private void AStaffM1_Click(object sender, EventArgs e)
        {
            AStaffCounter -= 2;

            if (AStaffCounter <= 0)                                      // If counter is now 0 or below
            {
                AStaffCounter = 0;                                       // Reset to 0 (if not already)                  
                AStaffCount.Visible = false;                             // Hide counter
                AStaff.BackgroundImage = Properties.Resources.AStaffT;    // Change back to transparent
            }
            else
            {
                AStaffCount.Text = AStaffCounter.ToString();              //If not 0, redisplay count
            }
        }

        private void AStaffCustom_Click(object sender, EventArgs e)
        {
            AStaffCount.Text = Interaction.InputBox("", "Number of Ahrim Staff's", "0");
            AStaffCounter = Convert.ToInt32("0" + AStaffCount.Text);
            AStaffCount.Text = AStaffCounter.ToString();
            if (AStaffCounter > 0)
            {
                AStaffCount.Visible = true;
            }
            else
            {
                AStaffCounter = 0;
                AStaffCount.Visible = false;
                AStaff.BackgroundImage = Properties.Resources.AStaffT;
            }
        }

        private void ATopM1_Click(object sender, EventArgs e)
        {
            ATopCounter -= 2;

            if (ATopCounter <= 0)                                       // If counter is now 0 or below
            {
                ATopCounter = 0;                                        // Reset to 0 (if not already)                  
                ATopCount.Visible = false;                              // Hide counter
                ATop.BackgroundImage = Properties.Resources.ATopT;      // Change back to transparent
            }
            else
            {
                ATopCount.Text = ATopCounter.ToString();                //If not 0, redisplay count
            }
        }

        private void ATopCustom_Click(object sender, EventArgs e)
        {
            ATopCount.Text = Interaction.InputBox("", "Number of Ahrim Top's", "0");
            ATopCounter = Convert.ToInt32("0" + ATopCount.Text);
            ATopCount.Text = ATopCounter.ToString();
            if (ATopCounter > 0)
            {
                ATopCount.Visible = true;
            }
            else
            {
                ATopCounter = 0;
                ATopCount.Visible = false;
                ATop.BackgroundImage = Properties.Resources.ATopT;
            }
        }

        private void ASkirtM1_Click(object sender, EventArgs e)
        {
            ASkirtCounter -= 2;

            if (ASkirtCounter <= 0)                                       // If counter is now 0 or below
            {
                ASkirtCounter = 0;                                        // Reset to 0 (if not already)                  
                ASkirtCount.Visible = false;                              // Hide counter
                ASkirt.BackgroundImage = Properties.Resources.ASkirtT;      // Change back to transparent
            }
            else
            {
                ASkirtCount.Text = ASkirtCounter.ToString();                //If not 0, redisplay count
            }
        }

        private void ASkirtCustom_Click(object sender, EventArgs e)
        {
            ASkirtCount.Text = Interaction.InputBox("", "Number of Ahrim Skirt's", "0");
            ASkirtCounter = Convert.ToInt32("0" + ASkirtCount.Text);
            ASkirtCount.Text = ASkirtCounter.ToString();
            if (ASkirtCounter > 0)
            {
                ASkirtCount.Visible = true;
            }
            else
            {
                ASkirtCounter = 0;
                ASkirtCount.Visible = false;
                ASkirt.BackgroundImage = Properties.Resources.ASkirtT;
            }
        }

        // Dharoks
        private void DHelm_MouseDown(object sender, MouseEventArgs e)
        {
            switch (e.Button)
            {
                case MouseButtons.Right:
                    {
                        DHelmRC.Show(this, new Point(157, 43));//places the menu at the pointer position
                    }
                    break;
            }
        }

        private void DAxe_MouseDown(object sender, MouseEventArgs e)
        {
            switch (e.Button)
            {
                case MouseButtons.Right:
                    {
                        DAxeRC.Show(this, new Point(213, 43));//places the menu at the pointer position
                    }
                    break;
            }
        }

        private void DPlate_MouseDown(object sender, MouseEventArgs e)
        {
            switch (e.Button)
            {
                case MouseButtons.Right:
                    {
                        DPlateRC.Show(this, new Point(157, 100)); //places the menu at the pointer position
                    }
                    break;
            }
        }

        private void DLegs_MouseDown(object sender, MouseEventArgs e)
        {
            switch (e.Button)
            {
                case MouseButtons.Right:
                    {
                        DLegsRC.Show(this, new Point(213, 100)); //places the menu at the pointer position
                    }
                    break;
            }
        }

        private void DHelmM1_Click(object sender, EventArgs e)
        {
            DHelmCounter -= 2;

            if (DHelmCounter <= 0)                                          // If counter is now 0 or below
            {
                DHelmCounter = 0;                                           // Reset to 0 (if not already)                  
                DHelmCount.Visible = false;                                 // Hide counter
                DHelm.BackgroundImage = Properties.Resources.DHelmT;        // Change back to transparent
            }
            else
            {
                DHelmCount.Text = DHelmCounter.ToString();                  //If not 0, redisplay count
            }
        }

        private void DHelmCustom_Click(object sender, EventArgs e)
        {
            DHelmCount.Text = Interaction.InputBox("", "Number of Dharok Helm's", "0");
            DHelmCounter = Convert.ToInt32("0" + DHelmCount.Text);
            DHelmCount.Text = DHelmCounter.ToString();
            if (DHelmCounter > 0)
            {
                DHelmCount.Visible = true;
            }
            else
            {
                DHelmCounter = 0;
                DHelmCount.Visible = false;
                DHelm.BackgroundImage = Properties.Resources.DHelmT;
            }
        }

        private void DAxeM1_Click(object sender, EventArgs e)
        {
            DAxeCounter -= 2;

            if (DAxeCounter <= 0)                                       // If counter is now 0 or below
            {
                DAxeCounter = 0;                                        // Reset to 0 (if not already)                  
                DAxeCount.Visible = false;                              // Hide counter
                DAxe.BackgroundImage = Properties.Resources.DAxeT;      // Change back to transparent
            }
            else
            {
                DAxeCount.Text = DAxeCounter.ToString();                //If not 0, redisplay count
            }
        }

        private void DAxeCustom_Click(object sender, EventArgs e)
        {
            DAxeCount.Text = Interaction.InputBox("", "Number of Dharok Axe's", "0");
            DAxeCounter = Convert.ToInt32("0" + DAxeCount.Text);
            DAxeCount.Text = DAxeCounter.ToString();
            if (DAxeCounter > 0)
            {
                DAxeCount.Visible = true;
            }
            else
            {
                DAxeCounter = 0;
                DAxeCount.Visible = false;
                DAxe.BackgroundImage = Properties.Resources.DAxeT;
            }
        }

        private void DPlateM1_Click(object sender, EventArgs e)
        {
            DPlateCounter -= 2;

            if (DPlateCounter <= 0)                                         // If counter is now 0 or below
            {
                DPlateCounter = 0;                                          // Reset to 0 (if not already)                  
                DPlateCount.Visible = false;                                // Hide counter
                DPlate.BackgroundImage = Properties.Resources.DPlateT;      // Change back to transparent
            }
            else
            {
                DPlateCount.Text = DPlateCounter.ToString();                //If not 0, redisplay count
            }
        }

        private void DPlateCustom_Click(object sender, EventArgs e)
        {
            DPlateCount.Text = Interaction.InputBox("", "Number of Dharok Plate's", "0");
            DPlateCounter = Convert.ToInt32("0" + DPlateCount.Text);
            DPlateCount.Text = DPlateCounter.ToString();
            if (DPlateCounter > 0)
            {
                DPlateCount.Visible = true;
            }
            else
            {
                DPlateCounter = 0;
                DPlateCount.Visible = false;
                DPlate.BackgroundImage = Properties.Resources.DPlateT;
            }
        }

        private void DLegsM1_Click(object sender, EventArgs e)
        {
            DLegsCounter -= 2;

            if (DLegsCounter <= 0)                                       // If counter is now 0 or below
            {
                DLegsCounter = 0;                                        // Reset to 0 (if not already)                  
                DLegsCount.Visible = false;                              // Hide counter
                DLegs.BackgroundImage = Properties.Resources.DLegsT;      // Change back to transparent
            }
            else
            {
                DLegsCount.Text = DLegsCounter.ToString();                //If not 0, redisplay count
            }
        }

        private void DLegsCustom_Click(object sender, EventArgs e)
        {
            DLegsCount.Text = Interaction.InputBox("", "Number of Dharok Legs's", "0");
            DLegsCounter = Convert.ToInt32("0" + DLegsCount.Text);
            DLegsCount.Text = DLegsCounter.ToString();
            if (DLegsCounter > 0)
            {
                DLegsCount.Visible = true;
            }
            else
            {
                DLegsCounter = 0;
                DLegsCount.Visible = false;
                DLegs.BackgroundImage = Properties.Resources.DLegsT;
            }
        }

        // Guthans
        private void GHelm_MouseDown(object sender, MouseEventArgs e)
        {
            switch (e.Button)
            {
                case MouseButtons.Right:
                    {
                        GHelmRC.Show(this, new Point(290, 43)); //places the menu at the pointer position
                    }
                    break;
            }
        }

        private void GSpear_MouseDown(object sender, MouseEventArgs e)
        {
            switch (e.Button)
            {
                case MouseButtons.Right:
                    {
                        GSpearRC.Show(this, new Point(340, 43)); //places the menu at the pointer position
                    }
                    break;
            }
        }

        private void GPlate_MouseDown(object sender, MouseEventArgs e)
        {
            switch (e.Button)
            {
                case MouseButtons.Right:
                    {
                        GPlateRC.Show(this, new Point(290, 100)); //places the menu at the pointer position
                    }
                    break;
            }
        }

        private void GSkirt_MouseDown(object sender, MouseEventArgs e)
        {
            switch (e.Button)
            {
                case MouseButtons.Right:
                    {
                        GSkirtRC.Show(this, new Point(340, 100)); //places the menu at the pointer position
                    }
                    break;
            }
        }

        private void GHelmM1_Click(object sender, EventArgs e)
        {
            GHelmCounter -= 2;

            if (GHelmCounter <= 0)                                       // If counter is now 0 or below
            {
                GHelmCounter = 0;                                        // Reset to 0 (if not already)                  
                GHelmCount.Visible = false;                              // Hide counter
                GHelm.BackgroundImage = Properties.Resources.GHelmT;      // Change back to transparent
            }
            else
            {
                GHelmCount.Text = GHelmCounter.ToString();                //If not 0, redisplay count
            }
        }

        private void GHelmCustom_Click(object sender, EventArgs e)
        {
            GHelmCount.Text = Interaction.InputBox("", "Number of Guthans Helm's", "0");
            GHelmCounter = Convert.ToInt32("0" + GHelmCount.Text);
            GHelmCount.Text = GHelmCounter.ToString();
            if (GHelmCounter > 0)
            {
                GHelmCount.Visible = true;
            }
            else
            {
                GHelmCounter = 0;
                GHelmCount.Visible = false;
                GHelm.BackgroundImage = Properties.Resources.GHelmT;
            }
        }

        private void GSpearM1_Click(object sender, EventArgs e)
        {
            GSpearCounter -= 2;

            if (GSpearCounter <= 0)                                       // If counter is now 0 or below
            {
                GSpearCounter = 0;                                        // Reset to 0 (if not already)                  
                GSpearCount.Visible = false;                              // Hide counter
                GSpear.BackgroundImage = Properties.Resources.GSpearT;      // Change back to transparent
            }
            else
            {
                GSpearCount.Text = GSpearCounter.ToString();                //If not 0, redisplay count
            }
        }

        private void GSpearCustom_Click(object sender, EventArgs e)
        {
            GSpearCount.Text = Interaction.InputBox("", "Number of Guthans Spear's", "0");
            GSpearCounter = Convert.ToInt32("0" + GSpearCount.Text);
            GSpearCount.Text = GSpearCounter.ToString();
            if (GSpearCounter > 0)
            {
                GSpearCount.Visible = true;
            }
            else
            {
                GSpearCounter = 0;
                GSpearCount.Visible = false;
                GSpear.BackgroundImage = Properties.Resources.GSpearT;
            }
        }

        private void GPlateM1_Click(object sender, EventArgs e)
        {
            GPlateCounter -= 2;

            if (GPlateCounter <= 0)                                       // If counter is now 0 or below
            {
                GPlateCounter = 0;                                        // Reset to 0 (if not already)                  
                GPlateCount.Visible = false;                              // Hide counter
                GPlate.BackgroundImage = Properties.Resources.GPlateT;      // Change back to transparent
            }
            else
            {
                GPlateCount.Text = GPlateCounter.ToString();                //If not 0, redisplay count
            }
        }

        private void GPlateCustom_Click(object sender, EventArgs e)
        {
            GPlateCount.Text = Interaction.InputBox("", "Number of Guthans Plate's", "0");
            GPlateCounter = Convert.ToInt32("0" + GPlateCount.Text);
            GPlateCount.Text = GPlateCounter.ToString();
            if (GPlateCounter > 0)
            {
                GPlateCount.Visible = true;
            }
            else
            {
                GPlateCounter = 0;
                GPlateCount.Visible = false;
                GPlate.BackgroundImage = Properties.Resources.GPlateT;
            }
        }

        private void GSkirtM1_Click(object sender, EventArgs e)
        {
            GSkirtCounter -= 2;

            if (GSkirtCounter <= 0)                                       // If counter is now 0 or below
            {
                GSkirtCounter = 0;                                        // Reset to 0 (if not already)                  
                GSkirtCount.Visible = false;                              // Hide counter
                GSkirt.BackgroundImage = Properties.Resources.GSkirtT;      // Change back to transparent
            }
            else
            {
                GSkirtCount.Text = GSkirtCounter.ToString();                //If not 0, redisplay count
            }
        }

        private void GSkirtCustom_Click(object sender, EventArgs e)
        {
            GSkirtCount.Text = Interaction.InputBox("", "Number of Guthans Skirt's", "0");
            GSkirtCounter = Convert.ToInt32("0" + GSkirtCount.Text);
            GSkirtCount.Text = GSkirtCounter.ToString();
            if (GSkirtCounter > 0)
            {
                GSkirtCount.Visible = true;
            }
            else
            {
                GSkirtCounter = 0;
                GSkirtCount.Visible = false;
                GSkirt.BackgroundImage = Properties.Resources.GSkirtT;
            }
        }
       
        // Karils
        private void KCoif_MouseDown(object sender, MouseEventArgs e)
        {
            switch (e.Button)
            {
                case MouseButtons.Right:
                    {
                        KCoifRC.Show(this, new Point(410, 43)); //places the menu at the pointer position
                    }
                    break;
            }
        }

        private void KBow_MouseDown(object sender, MouseEventArgs e)
        {
            switch (e.Button)
            {
                case MouseButtons.Right:
                    {
                        KBowRC.Show(this, new Point(460, 43)); //places the menu at the pointer position
                    }
                    break;
            }
        }

        private void KTop_MouseDown(object sender, MouseEventArgs e)
        {
            switch (e.Button)
            {
                case MouseButtons.Right:
                    {
                        KTopRC.Show(this, new Point(410, 100)); //places the menu at the pointer position
                    }
                    break;
            }
        }

        private void KSkirt_MouseDown(object sender, MouseEventArgs e)
        {
            switch (e.Button)
            {
                case MouseButtons.Right:
                    {
                        KSkirtRC.Show(this, new Point(460, 100)); //places the menu at the pointer position
                    }
                    break;
            }
        }

        private void KCoifM1_Click(object sender, EventArgs e)
        {
            KCoifCounter -= 2;

            if (KCoifCounter <= 0)                                          // If counter is now 0 or below
            {
                KCoifCounter = 0;                                           // Reset to 0 (if not already)                  
                KCoifCount.Visible = false;                                 // Hide counter
                KCoif.BackgroundImage = Properties.Resources.KCoifT;        // Change back to transparent
            }
            else
            {
                KCoifCount.Text = KCoifCounter.ToString();                  //If not 0, redisplay count
            }
        }

        private void KCoifCustom_Click(object sender, EventArgs e)
        {
            KCoifCount.Text = Interaction.InputBox("", "Number of Karils Coifs's", "0");
            KCoifCounter = Convert.ToInt32("0" + KCoifCount.Text);
            KCoifCount.Text = KCoifCounter.ToString();
            if (KCoifCounter > 0)
            {
                KCoifCount.Visible = true;
            }
            else
            {
                KCoifCounter = 0;
                KCoifCount.Visible = false;
                KCoif.BackgroundImage = Properties.Resources.KCoifT;
            }
        }

        private void KBowM1_Click(object sender, EventArgs e)
        {
            KBowCounter -= 2;

            if (KBowCounter <= 0)                                       // If counter is now 0 or below
            {
                KBowCounter = 0;                                        // Reset to 0 (if not already)                  
                KBowCount.Visible = false;                              // Hide counter
                KBow.BackgroundImage = Properties.Resources.KBowT;      // Change back to transparent
            }
            else
            {
                KBowCount.Text = KBowCounter.ToString();                //If not 0, redisplay count
            }
        }

        private void KBowCustom_Click(object sender, EventArgs e)
        {
            KBowCount.Text = Interaction.InputBox("", "Number of Karils Bow's", "0");
            KBowCounter = Convert.ToInt32("0" + KBowCount.Text);
            KBowCount.Text = KBowCounter.ToString();
            if (KBowCounter > 0)
            {
                KBowCount.Visible = true;
            }
            else
            {
                KBowCounter = 0;
                KBowCount.Visible = false;
                KBow.BackgroundImage = Properties.Resources.KBowT;
            }
        }

        private void KTopM1_Click(object sender, EventArgs e)
        {
            KTopCounter -= 2;

            if (KTopCounter <= 0)                                       // If counter is now 0 or below
            {
                KTopCounter = 0;                                        // Reset to 0 (if not already)                  
                KTopCount.Visible = false;                              // Hide counter
                KTop.BackgroundImage = Properties.Resources.KTopT;      // Change back to transparent
            }
            else
            {
                KTopCount.Text = KTopCounter.ToString();                //If not 0, redisplay count
            }
        }

        private void KTopCustom_Click(object sender, EventArgs e)
        {
            KTopCount.Text = Interaction.InputBox("", "Number of Karils Top's", "0");
            KTopCounter = Convert.ToInt32("0" + KTopCount.Text);
            KTopCount.Text = KTopCounter.ToString();
            if (KTopCounter > 0)
            {
                KTopCount.Visible = true;
            }
            else
            {
                KTopCounter = 0;
                KTopCount.Visible = false;
                KTop.BackgroundImage = Properties.Resources.KTopT;
            }
        }

        private void KSkirtM1_Click(object sender, EventArgs e)
        {
            KSkirtCounter -= 2;

            if (KSkirtCounter <= 0)                                       // If counter is now 0 or below
            {
                KSkirtCounter = 0;                                        // Reset to 0 (if not already)                  
                KSkirtCount.Visible = false;                              // Hide counter
                KSkirt.BackgroundImage = Properties.Resources.KSkirtT;      // Change back to transparent
            }
            else
            {
                KSkirtCount.Text = KSkirtCounter.ToString();                //If not 0, redisplay count
            }
        }

        private void KSkirtCustom_Click(object sender, EventArgs e)
        {
            KSkirtCount.Text = Interaction.InputBox("", "Number of Karils Skirt's", "0");
            KSkirtCounter = Convert.ToInt32("0" + KSkirtCount.Text);
            KSkirtCount.Text = KSkirtCounter.ToString();
            if (KSkirtCounter > 0)
            {
                KSkirtCount.Visible = true;
            }
            else
            {
                KSkirtCounter = 0;
                KSkirtCount.Visible = false;
                KSkirt.BackgroundImage = Properties.Resources.KSkirtT;
            }
        }

        // Torags
        private void THelm_MouseDown(object sender, MouseEventArgs e)
        {
            switch (e.Button)
            {
                case MouseButtons.Right:
                    {
                        THelmRC.Show(this, new Point(520, 43)); //places the menu at the pointer position
                    }
                    break;
            }
        }

        private void THammers_MouseDown(object sender, MouseEventArgs e)
        {
            switch (e.Button)
            {
                case MouseButtons.Right:
                    {
                        THammerRC.Show(this, new Point(575, 43)); //places the menu at the pointer position
                    }
                    break;
            }
        }

        private void TPlate_MouseDown(object sender, MouseEventArgs e)
        {
            switch (e.Button)
            {
                case MouseButtons.Right:
                    {
                        TPlateRC.Show(this, new Point(520, 100)); //places the menu at the pointer position
                    }
                    break;
            }
        }

        private void TLegs_MouseDown(object sender, MouseEventArgs e)
        {
            switch (e.Button)
            {
                case MouseButtons.Right:
                    {
                        TLegsRC.Show(this, new Point(575, 100)); //places the menu at the pointer position
                    }
                    break;
            }
        }

        private void THelmM1_Click(object sender, EventArgs e)
        {
            THelmCounter -= 2;

            if (THelmCounter <= 0)                                          // If counter is now 0 or below
            {
                THelmCounter = 0;                                           // Reset to 0 (if not already)                  
                THelmCount.Visible = false;                                 // Hide counter
                THelm.BackgroundImage = Properties.Resources.THelmT;        // Change back to transparent
            }
            else
            {
                THelmCount.Text = THelmCounter.ToString();                  //If not 0, redisplay count
            }
        }

        private void THelmCustom_Click(object sender, EventArgs e)
        {
            THelmCount.Text = Interaction.InputBox("", "Number of Torags Helm's", "0");
            THelmCounter = Convert.ToInt32("0" + THelmCount.Text);
            THelmCount.Text = THelmCounter.ToString();
            if (THelmCounter > 0)
            {
                THelmCount.Visible = true;
            }
            else
            {
                THelmCounter = 0;
                THelmCount.Visible = false;
                THelm.BackgroundImage = Properties.Resources.THelmT;
            }
        }

        private void THammerM1_Click(object sender, EventArgs e)
        {
            THammersCounter -= 2;

            if (THammersCounter <= 0)                                           // If counter is now 0 or below
            {   
                THammersCounter = 0;                                            // Reset to 0 (if not already)                  
                THammerCount.Visible = false;                                   // Hide counter
                THammers.BackgroundImage = Properties.Resources.THammerT;       // Change back to transparent
            }
            else
            {
                THammerCount.Text = THammersCounter.ToString();                 //If not 0, redisplay count
            }
        }

        private void THammerCustom_Click(object sender, EventArgs e)
        {
            THammerCount.Text = Interaction.InputBox("", "Number of Torags Hammer's", "0");
            THammersCounter = Convert.ToInt32("0" + THammerCount.Text);
            THammerCount.Text = THammersCounter.ToString();
            if (THammersCounter > 0)
            {
                THammerCount.Visible = true;
            }
            else
            {
                THammersCounter = 0;
                THammerCount.Visible = false;
                THammers.BackgroundImage = Properties.Resources.THammerT;
            }
        }

        private void TPlateM1_Click(object sender, EventArgs e)
        {
            TPlateCounter -= 2;

            if (TPlateCounter <= 0)                                         // If counter is now 0 or below
            {
                TPlateCounter = 0;                                          // Reset to 0 (if not already)                  
                TPlateCount.Visible = false;                                // Hide counter
                TPlate.BackgroundImage = Properties.Resources.TPlateT;      // Change back to transparent
            }
            else
            {
                TPlateCount.Text = TPlateCounter.ToString();                //If not 0, redisplay count
            }
        }

        private void TPlateCustom_Click(object sender, EventArgs e)
        {
            TPlateCount.Text = Interaction.InputBox("", "Number of Torags Plate's", "0");
            TPlateCounter = Convert.ToInt32("0" + TPlateCount.Text);
            TPlateCount.Text = TPlateCounter.ToString();
            if (TPlateCounter > 0)
            {
                TPlateCount.Visible = true;
            }
            else
            {
                TPlateCounter = 0;
                TPlateCount.Visible = false;
                TPlate.BackgroundImage = Properties.Resources.TPlateT;
            }
        }

        private void TLegsM1_Click(object sender, EventArgs e)
        {
            TLegsCounter -= 2;

            if (TLegsCounter <= 0)                                          // If counter is now 0 or below
            {
                TLegsCounter = 0;                                           // Reset to 0 (if not already)                  
                TLegsCount.Visible = false;                                 // Hide counter
                TLegs.BackgroundImage = Properties.Resources.TLegsT;        // Change back to transparent
            }
            else
            {
                TLegsCount.Text = TLegsCounter.ToString();                  //If not 0, redisplay count
            }
        }

        private void TLegsCustom_Click(object sender, EventArgs e)
        {
            TLegsCount.Text = Interaction.InputBox("", "Number of Torags Legs's", "0");
            TLegsCounter = Convert.ToInt32("0" + TLegsCount.Text);
            TLegsCount.Text = TLegsCounter.ToString();
            if (TLegsCounter > 0)
            {
                TLegsCount.Visible = true;
            }
            else
            {
                TLegsCounter = 0;
                TLegsCount.Visible = false;
                TLegs.BackgroundImage = Properties.Resources.TLegsT;
            }
        }

        // Veracs
        private void VHelm_MouseDown(object sender, MouseEventArgs e)
        {
            switch (e.Button)
            {
                case MouseButtons.Right:
                    {
                        VHelmRC.Show(this, new Point(640, 43)); //places the menu at the pointer position
                    }
                    break;
            }
        }

        private void VFlail_MouseDown(object sender, MouseEventArgs e)
        {
            switch (e.Button)
            {
                case MouseButtons.Right:
                    {
                        VFlailRC.Show(this, new Point(700, 43)); //places the menu at the pointer position
                    }
                    break;
            }
        }

        private void VTop_MouseDown(object sender, MouseEventArgs e)
        {
            switch (e.Button)
            {
                case MouseButtons.Right:
                    {
                        VTopRC.Show(this, new Point(640, 100)); //places the menu at the pointer position
                    }
                    break;
            }
        }

        private void VSkirt_MouseDown(object sender, MouseEventArgs e)
        {
            switch (e.Button)
            {
                case MouseButtons.Right:
                    {
                        VSkirtRC.Show(this, new Point(700, 100)); //places the menu at the pointer position
                    }
                    break;
            }
        }

        private void VHelmM1_Click(object sender, EventArgs e)
        {
            VHelmCounter -= 2;

            if (VHelmCounter <= 0)                                          // If counter is now 0 or below
            {
                VHelmCounter = 0;                                           // Reset to 0 (if not already)                  
                VHelmCount.Visible = false;                                 // Hide counter
                VHelm.BackgroundImage = Properties.Resources.VHelmT;        // Change back to transparent
            }
            else
            {
                VHelmCount.Text = VHelmCounter.ToString();                  //If not 0, redisplay count
            }
        }

        private void VHelmCustom_Click(object sender, EventArgs e)
        {
            VHelmCount.Text = Interaction.InputBox("", "Number of Veracs Helm's", "0");
            VHelmCounter = Convert.ToInt32("0" + VHelmCount.Text);
            VHelmCount.Text = VHelmCounter.ToString();
            if (VHelmCounter > 0)
            {
                VHelmCount.Visible = true;
            }
            else
            {
                VHelmCounter = 0;
                VHelmCount.Visible = false;
                VHelm.BackgroundImage = Properties.Resources.VHelmT;
            }
        }

        private void VFlailM1_Click(object sender, EventArgs e)
        {
            VFlailCounter -= 2;

            if (VFlailCounter <= 0)                                          // If counter is now 0 or below
            {
                VFlailCounter = 0;                                           // Reset to 0 (if not already)                  
                VFlailCount.Visible = false;                                 // Hide counter
                VFlail.BackgroundImage = Properties.Resources.VFlailT;        // Change back to transparent
            }
            else
            {
                VFlailCount.Text = VFlailCounter.ToString();                  //If not 0, redisplay count
            }
        }

        private void VFlailCustom_Click(object sender, EventArgs e)
        {
            VFlailCount.Text = Interaction.InputBox("", "Number of Veracs Flail's", "0");
            VFlailCounter = Convert.ToInt32("0" + VFlailCount.Text);
            VFlailCount.Text = VFlailCounter.ToString();
            if (VFlailCounter > 0)
            {
                VFlailCount.Visible = true;
            }
            else
            {
                VFlailCounter = 0;
                VFlailCount.Visible = false;
                VFlail.BackgroundImage = Properties.Resources.VFlailT;
            }
        }

        private void VTopM1_Click(object sender, EventArgs e)
        {
            VTopCounter -= 2;

            if (VTopCounter <= 0)                                           // If counter is now 0 or below
            {
                VTopCounter = 0;                                            // Reset to 0 (if not already)                  
                VTopCount.Visible = false;                                  // Hide counter
                VTop.BackgroundImage = Properties.Resources.VTopT;          // Change back to transparent
            }
            else
            {
                VTopCount.Text = VTopCounter.ToString();                    //If not 0, redisplay count
            }
        }

        private void VTopCustom_Click(object sender, EventArgs e)
        {
            VTopCount.Text = Interaction.InputBox("", "Number of Veracs Top's", "0");
            VTopCounter = Convert.ToInt32("0" + VTopCount.Text);
            VTopCount.Text = VTopCounter.ToString();
            if (VTopCounter > 0)
            {
                VTopCount.Visible = true;
            }
            else
            {
                VTopCounter = 0;
                VTopCount.Visible = false;
                VTop.BackgroundImage = Properties.Resources.VTopT;
            }
        }

        private void VSkirtM1_Click(object sender, EventArgs e)
        {
            VSkirtCounter -= 2;

            if (VSkirtCounter <= 0)                                          // If counter is now 0 or below
            {
                VSkirtCounter = 0;                                           // Reset to 0 (if not already)                  
                VSkirtCount.Visible = false;                                 // Hide counter
                VSkirt.BackgroundImage = Properties.Resources.VSkirtT;        // Change back to transparent
            }
            else
            {
                VSkirtCount.Text = VSkirtCounter.ToString();                  //If not 0, redisplay count
            }
        }

        private void VSkirtCustom_Click(object sender, EventArgs e)
        {
            VSkirtCount.Text = Interaction.InputBox("", "Number of Veracs Skirt's", "0");
            VSkirtCounter = Convert.ToInt32("0" + VSkirtCount.Text);
            VSkirtCount.Text = VSkirtCounter.ToString();
            if (VSkirtCounter > 0)
            {
                VSkirtCount.Visible = true;
            }
            else
            {
                VSkirtCounter = 0;
                VSkirtCount.Visible = false;
                VSkirt.BackgroundImage = Properties.Resources.VSkirtT;
            }
        }
    }
}
