using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace CoffeeManagement
{
    public partial class CoffeeManagementForm : Form
    {
        CoffeeDBDataContext db = new CoffeeDBDataContext();
        static string ProjectPath = Directory.GetParent(Directory.GetCurrentDirectory()).Parent.FullName;//path = "./CoffeeManagement"
        
        public CoffeeManagementForm()
        {
            InitializeComponent();
            picCoffeeImage.Image = Image.FromFile(ProjectPath + "\\Data\\Images\\defaultCoffee.png");
            picCoffeeImage.SizeMode = PictureBoxSizeMode.Zoom;
        }

        private void CoffeeManagementForm_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'coffeeDBDataSet.Coffee' table. You can move, or remove it, as needed.
            this.coffeeTableAdapter.Fill(this.coffeeDBDataSet.Coffee);
            this.coffeeBindingSource.DataSource = db.Coffees;
            bindingNavigatorCoffee.BindingSource = coffeeBindingSource;

            // Modify AddingNew event to customize new item creation (instead of an empty row)
            coffeeBindingSource.AddingNew += coffeeBindingSource_AddingNew;
        }

        private void btnCloseApp_Click(object sender, EventArgs e)
        {
            int insert = db.GetChangeSet().Inserts.Count;
            int update = db.GetChangeSet().Updates.Count;
            int delete = db.GetChangeSet().Deletes.Count;
            int totalChanges = insert + update + delete;
            if(totalChanges > 0)
            {
                var result = MessageBox.Show("You have unsaved changes. Do you want to save before exiting?", "Unsaved Changes", MessageBoxButtons.YesNoCancel);
                if(result == DialogResult.Yes)
                {
                    try 
                    {
                        coffeeBindingSource.EndEdit();
                        db.SubmitChanges();
                        MessageBox.Show("Changes saved successfully.");
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Error saving changes: " + ex.Message);
                        return; // Prevent closing if save fails
                    }
                }
                else if(result == DialogResult.Cancel)
                {
                    return; // Prevent closing
                }
            }
            Application.Exit();
        }

        private void dgwCoffee_SelectionChanged(object sender, EventArgs e)
        {
            if (dgwCoffee.Focused == false || dgwCoffee.CurrentCell == null || dgwCoffee.CurrentRow == null)
            {
                return;
            }
            var selectedCoffee = dgwCoffee.CurrentRow.DataBoundItem as Coffee;
            if(selectedCoffee == null)
            {
                return;
            }
            int CurrentCoffeeIndex = dgwCoffee.CurrentRow.Index;
            string imagePath = ProjectPath + "\\Data\\Images\\" + selectedCoffee.ImageName;
            if(File.Exists(imagePath))
            {
                picCoffeeImage.Image = Image.FromFile(imagePath);
            }
            else
            {
                picCoffeeImage.Image = Image.FromFile(ProjectPath + "\\Data\\Images\\defaultCoffee.png");
            }
            picCoffeeImage.SizeMode = PictureBoxSizeMode.Zoom;
        }
        private void dgwCoffee_EditingControlShowing(object sender, DataGridViewEditingControlShowingEventArgs e)
        {
            e.Control.KeyPress -= new KeyPressEventHandler(ColumnPrice_KeyPress);
            if (dgwCoffee.CurrentCell.ColumnIndex == 3) // column Price
            {
                TextBox tb = e.Control as TextBox;
                if (tb != null)
                {
                    tb.KeyPress += new KeyPressEventHandler(ColumnPrice_KeyPress);
                }
            }
        }
        private void ColumnPrice_KeyPress(object sender, KeyPressEventArgs e)
                {
                    if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && e.KeyChar != '.')
                    {
                        e.Handled = true;
                    }
                    TextBox tb = sender as TextBox;
                    if (e.KeyChar == '.' && tb != null && tb.Text.Contains("."))
                    {
                        e.Handled = true;
                    }
                }
        public string NextID(string currentID)
        {
            int id = 0;
            if (int.TryParse(currentID, out id))
            {
                id += 1;
                return id.ToString().PadLeft(3, '0');
            }
            throw new Exception("Non-numeric string passed as argument");
        }
        private void bindingNavigatorAddNewItem_Click(object sender, EventArgs e)
        {
            // The actual addition is handled in coffeeBindingSource_AddingNew
            coffeeBindingSource.MoveLast();
            btnSave.Enabled = true;
            MessageBox.Show("New coffee item added. Please add information and save changes.");
        }
        private void coffeeBindingSource_AddingNew(object sender, AddingNewEventArgs e)
        {
            // Handled in bindingNavigatorAddNewItem_Click
            Coffee lastCoffee = new Coffee();
            string newID = "NEW";
            List<Coffee> newCoffeeList = coffeeBindingSource.Cast<Coffee>()
                        .Where(c => c != null && !string.IsNullOrEmpty(c.CoffeeID) && c.CoffeeID.Contains("NEW"))
                        .ToList();
            if (newCoffeeList.Count == 0)
            {
                newID = "NEW001";
            }
            else
            {
                lastCoffee = newCoffeeList.OrderByDescending(c => c.CoffeeID).FirstOrDefault();
                newID += NextID(lastCoffee.CoffeeID.Substring(lastCoffee.CoffeeID.Length - 3));
            }
            Coffee newCoffee = new Coffee()
            {
                CoffeeID = newID,
                CoffeeName = "New Coffee Name",
                Country = "Country Name",
                Price = 0,
                ImageName = "defaultCoffee.png"
            };
            e.NewObject = newCoffee;
        }

        private void bindingNavigatorDeleteItem_Click(object sender, EventArgs e)
        {
            var item = coffeeBindingSource.Current as Coffee;
            if (item == null)
            {
                MessageBox.Show("No coffee item selected to delete.");
                return;
            }
            btnSave.Enabled = true;
            MessageBox.Show("Deleted coffee successfully. Please save change");
        }
        private void btnSave_Click(object sender, EventArgs e)
        {
            try 
            {
                coffeeBindingSource.EndEdit();
                db.SubmitChanges();
                // Refresh DataGridView to show updated data
                dgwCoffee.Refresh();
                btnSave.Enabled = false;
                MessageBox.Show("Changes saved successfully.");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error saving changes: " + ex.Message);
            }
        }
        private void btnRefresh_Click(object sender, EventArgs e)
        {
            coffeeBindingSource.CancelEdit();
            db.Dispose();
            db = new CoffeeDBDataContext();
            coffeeBindingSource.DataSource = db.Coffees.ToList();
            MessageBox.Show("Changes reverted.");
            btnSave.Enabled = false;
        }
        private void dgwCoffee_CellValueChanged(object sender, DataGridViewCellEventArgs e)
        {
            btnSave.Enabled = true;
        }
        private void dataGridView1_CurrentCellDirtyStateChanged(object sender, EventArgs e)
        {
            if (dgwCoffee.IsCurrentCellDirty)
            {
                dgwCoffee.CommitEdit(DataGridViewDataErrorContexts.Commit);
            }
        }
    }

}
