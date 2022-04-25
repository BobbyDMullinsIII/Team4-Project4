/////////////////////////////////////////////////////////////////////////////////////////////////////////////////////
//
//	Solution/Project:  Team4_Project4/Team4_Project4
//	File Name:         CacheConfigForm.cs
//	Description:       CacheConfigForm class for program cache config GUI
//	Course:            CSCI-4717-201 - Comp Architecture
//	Authors:           Zachary Lykins, lykinsz@etsu.edu            
//	                   Bobby Mullins, mullinsbd@etsu.edu
//	                   Christopher Poteet, poteetc1@etsu.edu
//	                   William Simmons, simmonswa@etsu.edu
//                     Isaiah Jayne, jaynei@etsu.edu
//	Created:           Monday, April 18, 2022
//	Copyright:         Team 4
//
/////////////////////////////////////////////////////////////////////////////////////////////////////////////////////

using System;
using System.Windows.Forms;

namespace Team4_Project4
{
    public partial class CacheConfigForm : Form
    {
        //CacheConfigForm Constructor
        #region CacheConfigForm Constructor
        public CacheConfigForm()
        {
            InitializeComponent();

            //Retrieves all values needed from GUIForm
            hitCyclesNumericUpDown.Value = ProgramController.guiForm.hitCycles;
            missCyclesNumericUpDown.Value = ProgramController.guiForm.missCycles;
            entriesComboBox.Text = Convert.ToString(ProgramController.guiForm.cacheEntries);
            lineSizeComboBox.Text = Convert.ToString(ProgramController.guiForm.cacheLineSize);

            if (ProgramController.guiForm.cacheType == 2)
            {
                twoSetAssocRadiobutton.Checked = true;
                fourSetAssocRadiobutton.Checked = false;
            }
            else if (ProgramController.guiForm.cacheType == 4)
            {
                twoSetAssocRadiobutton.Checked = false;
                fourSetAssocRadiobutton.Checked = true;
            }
        }
        #endregion

        //Buttons
        #region Close Button
        /// <summary>
        /// Closes CacheConfigForm
        /// </summary>
        /// <param name="sender">object that raised the event (auto-generated, unused here)</param>
        /// <param name="e">arguments for event (auto-generated, unused here)</param>
        private void closeButton_Click(object sender, EventArgs e)
        {
            Close();
        }
        #endregion

        #region Save Buttony
        /// <summary>
        /// Saves cache config values within CacheConfigForm to GUIForm
        /// </summary>
        /// <param name="sender">object that raised the event (auto-generated, unused here)</param>
        /// <param name="e">arguments for event (auto-generated, unused here)</param>
        private void saveButton_Click(object sender, EventArgs e)
        {
            ProgramController.guiForm.hitCycles = (int)hitCyclesNumericUpDown.Value;
            ProgramController.guiForm.missCycles = (int)missCyclesNumericUpDown.Value;
            ProgramController.guiForm.cacheEntries = Convert.ToInt32(entriesComboBox.Text);
            ProgramController.guiForm.cacheLineSize = Convert.ToInt32(lineSizeComboBox.Text);

            if (twoSetAssocRadiobutton.Checked == true)
            {
                ProgramController.guiForm.cacheType = 2;
            }
            else if (fourSetAssocRadiobutton.Checked == true)
            {
                ProgramController.guiForm.cacheType = 4;
            }
        }
        #endregion

        #region Reset Button
        /// <summary>
        /// Resets cache configuration
        /// </summary>
        /// <param name="sender">object that raised the event (auto-generated, unused here)</param>
        /// <param name="e">arguments for event (auto-generated, unused here)</param>
        private void resetToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //Resets all values within controls back to default when program opened
            hitCyclesNumericUpDown.Value = 1;
            missCyclesNumericUpDown.Value = 50;
            entriesComboBox.Text = 8.ToString();
            lineSizeComboBox.Text = 4.ToString();

            twoSetAssocRadiobutton.Checked = false;
            fourSetAssocRadiobutton.Checked = true;

        }
        #endregion

        //Event handlers to prevent user from typing inside boxes
        #region KeyPress Event Handlers
        /// <summary>
        /// Event handler to prevent text from being types into entriesComboBox
        /// </summary>
        /// <param name="sender">object that raised the event (auto-generated, unused here)</param>
        /// <param name="e">arguments for event (auto-generated, unused here)</param>
        private void entriesComboBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = true;
        }

        /// <summary>
        /// Event handler to prevent text from being types into lineSizeComboBox
        /// </summary>
        /// <param name="sender">object that raised the event (auto-generated, unused here)</param>
        /// <param name="e">arguments for event (auto-generated, unused here)</param>
        private void lineSizeComboBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = true;
        }

        /// <summary>
        /// Event handler to prevent text from being types into hitCyclesNumericUpDown
        /// </summary>
        /// <param name="sender">object that raised the event (auto-generated, unused here)</param>
        /// <param name="e">arguments for event (auto-generated, unused here)</param>
        private void hitCyclesNumericUpDown_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = true;
        }

        /// <summary>
        /// Event handler to prevent text from being types into missCyclesNumericUpDown
        /// </summary>
        /// <param name="sender">object that raised the event (auto-generated, unused here)</param>
        /// <param name="e">arguments for event (auto-generated, unused here)</param>
        private void missCyclesNumericUpDown_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = true;
        }
        #endregion

    }//end CacheConfigForm class

}//end Team4_Project4 namespace
