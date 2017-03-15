using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Tuoyuys___dotnet_interface_practice
{
    public partial class Form1 : Form
    {
        BindingList<IToy> ToyBoxList;
        BindingList<IToy> ToyTypesList;

        public Form1()
        {
            InitializeComponent();

            ToyBoxList = new BindingList<IToy>();
            ToyBoxList.Add(new Car());
            ToyBoxList.Add(new Teddy());
            ToyBoxList.Add(new Chest());
            ToyBoxList.Add(new Wagon());
            toyBox.DataSource = ToyBoxList;
            ToyTypesList = new BindingList<IToy>();
            ToyTypesList.Add(new Car());
            ToyTypesList.Add(new Teddy());
            ToyTypesList.Add(new Chest());
            ToyTypesList.Add(new Wagon());
            createToyCombo.DataSource = ToyTypesList;
        }

        private void toyBox_SelectedIndexChanged(object sender, EventArgs e)
        { 
            UpdateControlsFromToy(ToyBoxList[toyBox.SelectedIndex], speedUpDown,volumeUpDown,openableCheckbox);
        }

        private void createToyCombo_SelectedIndexChanged(object sender, EventArgs e)
        {
            UpdateControlsFromToy(ToyTypesList[createToyCombo.SelectedIndex], speedCreateUpDown, volumeCreateUpDown, openableCreateCheckbox);
        }

        private void commitChangesButton_Click(object sender, EventArgs e)
        {
            UpdateToyFromControls(ToyBoxList[toyBox.SelectedIndex], speedUpDown,volumeUpDown,openableCheckbox);
            MessageBox.Show("Toy updated successfully!");
        }
        private void createToy_Click(object sender, EventArgs e)
        {
            IToy selectedToyType = ToyTypesList[createToyCombo.SelectedIndex];
            UpdateToyFromControls(selectedToyType, speedCreateUpDown, volumeCreateUpDown, openableCreateCheckbox);
            if (selectedToyType is Car)
            {
                ToyBoxList.Add(new Car(selectedToyType as Car));

            }
            if (selectedToyType is Teddy)
            {
                ToyBoxList.Add(new Teddy(selectedToyType as Teddy));

            }
            if (selectedToyType is Chest)
            {
                ToyBoxList.Add(new Chest(selectedToyType as Chest));

            }
            if (selectedToyType is Wagon)
            {
                ToyBoxList.Add(new Wagon(selectedToyType as Wagon));
            }
            MessageBox.Show("Toy created successfully!");
        }

        private void UpdateToyFromControls(IToy selectedToy, NumericUpDown speedUpDown, NumericUpDown volumeUpDown,CheckBox openableCheckbox)
        {
            if (selectedToy is IAccelerable)
            {
                (selectedToy as IAccelerable).ChangeSpeed((int)speedUpDown.Value);
            }
            if (selectedToy is IFillable)
            {
                (selectedToy as IFillable).ChangeFillLevel((int)volumeUpDown.Value);
            }
            if (selectedToy is IOpenable)
            {
                (selectedToy as IOpenable).Open(openableCheckbox.Checked);
            }
        }

        private void UpdateControlsFromToy(IToy selectedToy, NumericUpDown speedUpDown, NumericUpDown volumeUpDown, CheckBox openableCheckbox)
        {
            speedUpDown.Value = 0;
            volumeUpDown.Value = 0;
            openableCheckbox.Checked = false; //reset controls
            speedUpDown.Enabled = false;
            volumeUpDown.Enabled = false;
            openableCheckbox.Enabled = false;
            if (selectedToy is IAccelerable)
            {
                speedUpDown.Value = (selectedToy as IAccelerable).GetSpeed();
                speedUpDown.Enabled = true;
            }
            if (selectedToy is IFillable)
            {
                volumeUpDown.Value = (selectedToy as IFillable).GetFillLevel();
                volumeUpDown.Enabled = true;
            }
            if (selectedToy is IOpenable)
            {
                openableCheckbox.Checked = (selectedToy as IOpenable).GetOpen();
                openableCheckbox.Enabled = true;
            }
        }
    }
}
