using MaterialSkin.Controls;
using System;
using System.Data;
using System.Windows.Forms;
using WindowsFormsApp4.Notifications;
using WindowsFormsApp4.Repository;

namespace WindowsFormsApp4
{
	public partial class FrmMainMenu : MaterialForm
	{
		string _ConnectionString;
        RegionRepository RegionRepository = new RegionRepository();
		BranchRepository BranchRepository = new BranchRepository();
		PopupNotifierClass PopupNotifierClass = new PopupNotifierClass();
		readonly Branch Branchs = new Branch();
		readonly Region Regions = new Region();
        public FrmMainMenu()
		{
			InitializeComponent();

			_ConnectionString = $@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename={Application.StartupPath}\Database1.mdf;Integrated Security=True";

			/* What you need to do:
			 * Design and develop a small application where the user enters the name of a geographical region  DONE
			 *  into a text box, and clicks Load. (Assume the user will only enter these valid region names: Auckland and Hamilton.) DONE
			 *  The names of all the retail branches belonging to that region will be displayed in a grid.
			 *  
			 * Design the UI with:
			 * A label with caption "Region"
			 * A entry field for identifying the region name (one of Auckland or Hamilton).
			 * A grid for displaying the names of branches in the region.
			 * A Load button.
			 * 
			 * Behaviour of the UI:
			 * The user identifies the region in the region entry field.
			 * The user clicks the Load button.			 
			 * The names of the branches in the selected region are displayed in a DataGrid control.
			 * 
			 * There is a Region class and a Branch class in this project. Both have a Name property.
			 * The Region class contains a List<Branch> objects, being the branches belonging to that region.
			 * Load the data from the database into those classes as needed to achieve the solution.
			 * Write appropriate WinForms code to get that data on screen.
			 *
			 * Email steve@ontempo.co.nz with questions!
			*/

		}

        private void Form1_Load(object sender, EventArgs e)
        {
			this.MatTxtRegion.Select();
        }

        private void materialCard1_Paint(object sender, PaintEventArgs e)
        {

        }


		void FilterData()
		{

                try
                {
                    if (this.BranchRepository.dSet.Tables.Count > 0)
                    {
                        DataView dv = new DataView(this.BranchRepository.dSet.Tables[0]);

                        dv.RowFilter = "region = '" + this.MatTxtRegion.Text + "'  ";
                        this.GunaDgvViewing.DataSource = dv;
                       this.lblTotalrecords.Text = this.GunaDgvViewing.RowCount.ToString();
                    }
                }
                catch (SyntaxErrorException)
                {
                    MessageBox.Show("Invalid character found!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    return;
                }
                catch (EvaluateException)
                {
                    MessageBox.Show("Invalid character found 2.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    return;
                }
            }
        

		private void MatBtnLoadData_Click(object sender, EventArgs e)
		{
			if (this.MatTxtRegion.Text == String.Empty)
			{
				this.PopupNotifierClass.FillTheRequiredFields();
				this.MatTxtRegion.Select();
				return;
			}
            this.RegionRepository.CheckDataifExist(this.MatTxtRegion.Text.Trim());

            if (this.RegionRepository.dSet.Tables[0].Rows.Count > 0)
            {
				this.GunaDgvViewing.Visible = true;
				this.MatCardViewing.Visible = true;
				this.LblTotal.Visible = true;
				this.lblTotalrecords.Visible = true;

		   this.BranchRepository.GetBranch("branch");
				this.FilterData();
				this.MatTxtRegion.Text = String.Empty;
            }
            else
            {
				this.PopupNotifierClass.DataNotExist(this.MatTxtRegion.Text);
				this.MatTxtRegion.Text = String.Empty;
				this.MatTxtRegion.Select();
				return;
            }



        }

		private void GunaDgvViewing_CurrentCellChanged(object sender, EventArgs e)
		{
            if (this.GunaDgvViewing.RowCount > 0)
            {
                if (this.GunaDgvViewing.CurrentRow != null)
                {
                    if (this.GunaDgvViewing.CurrentRow.Cells["name"].Value != null)
                    {
                        this.Branchs.Id = Convert.ToInt32(this.GunaDgvViewing.CurrentRow.Cells["id"].Value.ToString());
                        this.Branchs.Name = this.GunaDgvViewing.CurrentRow.Cells["name"].Value.ToString();           
                    }

                }
            }


        }
	}
}
