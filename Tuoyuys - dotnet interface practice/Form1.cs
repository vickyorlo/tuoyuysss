using System;
using System.Collections.Generic;
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
        List<IToy> ToyBoxList;
        List<IToy> ToyTypesList;
        IToy selectedToy;
        IToy selectedToyType;

        public Form1()
        {
            InitializeComponent();

            ToyBoxList = new List<IToy>();
            ToyBoxList.Add(new Car());
            ToyBoxList.Add(new Teddy());
            ToyBoxList.Add(new Chest());
            ToyBoxList.Add(new Wagon());
            toyBox.DataSource = ToyBoxList;
            ToyTypesList = new List<IToy>();
            ToyTypesList.Add(new Car());
            ToyTypesList.Add(new Teddy());
            ToyTypesList.Add(new Chest());
            ToyTypesList.Add(new Wagon());
            createToyCombo.DataSource = ToyTypesList;


        }

        private void toyBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            speedUpDown.Enabled = false;
            volumeUpDown.Enabled = false;
            openableCheckbox.Enabled = false;
            selectedToy = ToyBoxList[toyBox.SelectedIndex];
            if(selectedToy is IAccelerable)
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

        private void commitChangesButton_Click(object sender, EventArgs e)
        {
            if(speedUpDown.Enabled == true)
            {
                (selectedToy as IAccelerable).ChangeSpeed((int)speedUpDown.Value);
            }
            if (volumeUpDown.Enabled == true)
            {
                (selectedToy as IFillable).ChangeFillLevel((int)volumeUpDown.Value);
            }
            if (openableCheckbox.Enabled == true)
            {
                (selectedToy as IOpenable).Open(openableCheckbox.Checked);
            }
            MessageBox.Show("Toy updated successfully!");
        }

        private void createToyCombo_SelectedIndexChanged(object sender, EventArgs e)
        {
            speedCreateUpDown.Enabled = false;
            volumeCreateUpDown.Enabled = false;
            openableCreateCheckbox.Enabled = false;
            selectedToyType = ToyTypesList[createToyCombo.SelectedIndex];
            if (selectedToyType is IAccelerable)
            {
                speedCreateUpDown.Value = (selectedToyType as IAccelerable).GetSpeed();
                speedCreateUpDown.Enabled = true;
            }
            if (selectedToyType is IFillable)
            {
                volumeCreateUpDown.Value = (selectedToyType as IFillable).GetFillLevel();
                volumeCreateUpDown.Enabled = true;
            }
            if (selectedToyType is IOpenable)
            {
                openableCreateCheckbox.Checked = (selectedToyType as IOpenable).GetOpen();
                openableCreateCheckbox.Enabled = true;
            }
        }

        private void createToy_Click(object sender, EventArgs e)
        {
            if (speedUpDown.Enabled == true)
            {
                (selectedToyType as IAccelerable).ChangeSpeed((int)speedCreateUpDown.Value);
            }
            if (volumeUpDown.Enabled == true)
            {
                (selectedToyType as IFillable).ChangeFillLevel((int)volumeCreateUpDown.Value);
            }
            if (openableCheckbox.Enabled == true)
            {
                (selectedToyType as IOpenable).Open(openableCreateCheckbox.Checked);
            }
            ToyBoxList.Add(new IToy(selectedToyType));
            MessageBox.Show("Toy updated successfully!");
        }
    }
}
