
namespace WindowsFormsApp4
{
	partial class FrmMainMenu
	{
		/// <summary>
		/// Required designer variable.
		/// </summary>
		private System.ComponentModel.IContainer components = null;

		/// <summary>
		/// Clean up any resources being used.
		/// </summary>
		/// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
		protected override void Dispose(bool disposing)
		{
			if (disposing && (components != null))
			{
				components.Dispose();
			}
			base.Dispose(disposing);
		}

		#region Windows Form Designer generated code

		/// <summary>
		/// Required method for Designer support - do not modify
		/// the contents of this method with the code editor.
		/// </summary>
		private void InitializeComponent()
		{
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            this.materialContextMenuStrip1 = new MaterialSkin.Controls.MaterialContextMenuStrip();
            this.MatCardViewing = new MaterialSkin.Controls.MaterialCard();
            this.GunaDgvViewing = new Guna.UI2.WinForms.Guna2DataGridView();
            this.item_type_id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.item_type_desc = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.it_added_at = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.it_added_by = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.it_updated_at = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.it_updated_by = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.unit_id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.unit_desc = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pm_added_at = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pm_added_by = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pm_updated_at = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pm_updated_by = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn7 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn8 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn9 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn10 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn11 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn12 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn13 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn14 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn15 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn16 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn17 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn18 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.MatTxtRegion = new MaterialSkin.Controls.MaterialTextBox();
            this.MatBtnLoadData = new MaterialSkin.Controls.MaterialButton();
            this.LblRegion = new MaterialSkin.Controls.MaterialLabel();
            this.LblTotal = new System.Windows.Forms.Label();
            this.lblTotalrecords = new System.Windows.Forms.Label();
            this.Id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Name = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Region = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.MatCardViewing.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.GunaDgvViewing)).BeginInit();
            this.SuspendLayout();
            // 
            // materialContextMenuStrip1
            // 
            this.materialContextMenuStrip1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.materialContextMenuStrip1.Depth = 0;
            this.materialContextMenuStrip1.ImageScalingSize = new System.Drawing.Size(24, 24);
            this.materialContextMenuStrip1.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialContextMenuStrip1.Name = "materialContextMenuStrip1";
            this.materialContextMenuStrip1.Size = new System.Drawing.Size(61, 4);
            // 
            // MatCardViewing
            // 
            this.MatCardViewing.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.MatCardViewing.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.MatCardViewing.Controls.Add(this.GunaDgvViewing);
            this.MatCardViewing.Depth = 0;
            this.MatCardViewing.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.MatCardViewing.Location = new System.Drawing.Point(73, 277);
            this.MatCardViewing.Margin = new System.Windows.Forms.Padding(12, 11, 12, 11);
            this.MatCardViewing.MouseState = MaterialSkin.MouseState.HOVER;
            this.MatCardViewing.Name = "MatCardViewing";
            this.MatCardViewing.Padding = new System.Windows.Forms.Padding(12, 11, 12, 11);
            this.MatCardViewing.Size = new System.Drawing.Size(816, 389);
            this.MatCardViewing.TabIndex = 1;
            this.MatCardViewing.Visible = false;
            this.MatCardViewing.Paint += new System.Windows.Forms.PaintEventHandler(this.materialCard1_Paint);
            // 
            // GunaDgvViewing
            // 
            this.GunaDgvViewing.AllowUserToAddRows = false;
            this.GunaDgvViewing.AllowUserToDeleteRows = false;
            this.GunaDgvViewing.AllowUserToResizeRows = false;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.White;
            this.GunaDgvViewing.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.GunaDgvViewing.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.GunaDgvViewing.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(245)))), ((int)(((byte)(250)))));
            this.GunaDgvViewing.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.GunaDgvViewing.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.Raised;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(232)))), ((int)(((byte)(234)))), ((int)(((byte)(237)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(245)))), ((int)(((byte)(250)))));
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.GunaDgvViewing.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.GunaDgvViewing.ColumnHeadersHeight = 35;
            this.GunaDgvViewing.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.GunaDgvViewing.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Id,
            this.Name,
            this.Region});
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.DarkSlateGray;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.GunaDgvViewing.DefaultCellStyle = dataGridViewCellStyle3;
            this.GunaDgvViewing.Dock = System.Windows.Forms.DockStyle.Fill;
            this.GunaDgvViewing.EnableHeadersVisualStyles = false;
            this.GunaDgvViewing.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(239)))), ((int)(((byte)(241)))), ((int)(((byte)(243)))));
            this.GunaDgvViewing.Location = new System.Drawing.Point(12, 11);
            this.GunaDgvViewing.Margin = new System.Windows.Forms.Padding(4);
            this.GunaDgvViewing.MultiSelect = false;
            this.GunaDgvViewing.Name = "GunaDgvViewing";
            this.GunaDgvViewing.ReadOnly = true;
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle4.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(245)))), ((int)(((byte)(250)))));
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.GunaDgvViewing.RowHeadersDefaultCellStyle = dataGridViewCellStyle4;
            this.GunaDgvViewing.RowHeadersVisible = false;
            this.GunaDgvViewing.RowHeadersWidth = 102;
            this.GunaDgvViewing.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.GunaDgvViewing.RowTemplate.DividerHeight = 5;
            this.GunaDgvViewing.RowTemplate.Height = 40;
            this.GunaDgvViewing.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.GunaDgvViewing.Size = new System.Drawing.Size(792, 367);
            this.GunaDgvViewing.TabIndex = 594;
            this.GunaDgvViewing.Theme = Guna.UI2.WinForms.Enums.DataGridViewPresetThemes.LightGrid;
            this.GunaDgvViewing.ThemeStyle.AlternatingRowsStyle.BackColor = System.Drawing.Color.White;
            this.GunaDgvViewing.ThemeStyle.AlternatingRowsStyle.Font = null;
            this.GunaDgvViewing.ThemeStyle.AlternatingRowsStyle.ForeColor = System.Drawing.Color.Empty;
            this.GunaDgvViewing.ThemeStyle.AlternatingRowsStyle.SelectionBackColor = System.Drawing.Color.Empty;
            this.GunaDgvViewing.ThemeStyle.AlternatingRowsStyle.SelectionForeColor = System.Drawing.Color.Empty;
            this.GunaDgvViewing.ThemeStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(245)))), ((int)(((byte)(250)))));
            this.GunaDgvViewing.ThemeStyle.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(239)))), ((int)(((byte)(241)))), ((int)(((byte)(243)))));
            this.GunaDgvViewing.ThemeStyle.HeaderStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(232)))), ((int)(((byte)(234)))), ((int)(((byte)(237)))));
            this.GunaDgvViewing.ThemeStyle.HeaderStyle.BorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Raised;
            this.GunaDgvViewing.ThemeStyle.HeaderStyle.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.GunaDgvViewing.ThemeStyle.HeaderStyle.ForeColor = System.Drawing.Color.Black;
            this.GunaDgvViewing.ThemeStyle.HeaderStyle.HeaightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.GunaDgvViewing.ThemeStyle.HeaderStyle.Height = 35;
            this.GunaDgvViewing.ThemeStyle.ReadOnly = true;
            this.GunaDgvViewing.ThemeStyle.RowsStyle.BackColor = System.Drawing.Color.White;
            this.GunaDgvViewing.ThemeStyle.RowsStyle.BorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.Raised;
            this.GunaDgvViewing.ThemeStyle.RowsStyle.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.GunaDgvViewing.ThemeStyle.RowsStyle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.GunaDgvViewing.ThemeStyle.RowsStyle.Height = 40;
            this.GunaDgvViewing.ThemeStyle.RowsStyle.SelectionBackColor = System.Drawing.Color.DarkSlateGray;
            this.GunaDgvViewing.ThemeStyle.RowsStyle.SelectionForeColor = System.Drawing.SystemColors.Window;
            this.GunaDgvViewing.CurrentCellChanged += new System.EventHandler(this.GunaDgvViewing_CurrentCellChanged);
            // 
            // item_type_id
            // 
            this.item_type_id.DataPropertyName = "item_type_id";
            this.item_type_id.FillWeight = 40.60914F;
            this.item_type_id.HeaderText = "ID";
            this.item_type_id.MinimumWidth = 12;
            this.item_type_id.Name = "item_type_id";
            this.item_type_id.ReadOnly = true;
            this.item_type_id.Width = 150;
            // 
            // item_type_desc
            // 
            this.item_type_desc.DataPropertyName = "item_type_desc";
            this.item_type_desc.FillWeight = 99.49239F;
            this.item_type_desc.HeaderText = "ITEM CLASS";
            this.item_type_desc.MinimumWidth = 12;
            this.item_type_desc.Name = "item_type_desc";
            this.item_type_desc.ReadOnly = true;
            this.item_type_desc.Width = 150;
            // 
            // it_added_at
            // 
            this.it_added_at.DataPropertyName = "it_added_at";
            this.it_added_at.FillWeight = 99.49239F;
            this.it_added_at.HeaderText = "CREATED DATE";
            this.it_added_at.MinimumWidth = 12;
            this.it_added_at.Name = "it_added_at";
            this.it_added_at.ReadOnly = true;
            this.it_added_at.Width = 150;
            // 
            // it_added_by
            // 
            this.it_added_by.DataPropertyName = "it_added_by";
            this.it_added_by.FillWeight = 99.49239F;
            this.it_added_by.HeaderText = "CREATED BY";
            this.it_added_by.MinimumWidth = 12;
            this.it_added_by.Name = "it_added_by";
            this.it_added_by.ReadOnly = true;
            this.it_added_by.Width = 150;
            // 
            // it_updated_at
            // 
            this.it_updated_at.DataPropertyName = "it_updated_at";
            this.it_updated_at.FillWeight = 99.49239F;
            this.it_updated_at.HeaderText = "UPDATED DATE";
            this.it_updated_at.MinimumWidth = 12;
            this.it_updated_at.Name = "it_updated_at";
            this.it_updated_at.ReadOnly = true;
            this.it_updated_at.Width = 150;
            // 
            // it_updated_by
            // 
            this.it_updated_by.DataPropertyName = "it_updated_by";
            this.it_updated_by.HeaderText = "UPDATED BY";
            this.it_updated_by.MinimumWidth = 12;
            this.it_updated_by.Name = "it_updated_by";
            this.it_updated_by.ReadOnly = true;
            this.it_updated_by.Width = 150;
            // 
            // unit_id
            // 
            this.unit_id.DataPropertyName = "unit_id";
            this.unit_id.FillWeight = 40.60914F;
            this.unit_id.HeaderText = "ID";
            this.unit_id.MinimumWidth = 12;
            this.unit_id.Name = "unit_id";
            this.unit_id.ReadOnly = true;
            this.unit_id.Width = 150;
            // 
            // unit_desc
            // 
            this.unit_desc.DataPropertyName = "unit_desc";
            this.unit_desc.FillWeight = 99.49239F;
            this.unit_desc.HeaderText = "ITEM CLASS";
            this.unit_desc.MinimumWidth = 12;
            this.unit_desc.Name = "unit_desc";
            this.unit_desc.ReadOnly = true;
            this.unit_desc.Width = 150;
            // 
            // pm_added_at
            // 
            this.pm_added_at.DataPropertyName = "pm_added_at";
            this.pm_added_at.FillWeight = 99.49239F;
            this.pm_added_at.HeaderText = "CREATED DATE";
            this.pm_added_at.MinimumWidth = 12;
            this.pm_added_at.Name = "pm_added_at";
            this.pm_added_at.ReadOnly = true;
            this.pm_added_at.Width = 150;
            // 
            // pm_added_by
            // 
            this.pm_added_by.DataPropertyName = "pm_added_by";
            this.pm_added_by.FillWeight = 99.49239F;
            this.pm_added_by.HeaderText = "CREATED BY";
            this.pm_added_by.MinimumWidth = 12;
            this.pm_added_by.Name = "pm_added_by";
            this.pm_added_by.ReadOnly = true;
            this.pm_added_by.Width = 150;
            // 
            // pm_updated_at
            // 
            this.pm_updated_at.DataPropertyName = "pm_updated_at";
            this.pm_updated_at.FillWeight = 99.49239F;
            this.pm_updated_at.HeaderText = "UPDATED DATE";
            this.pm_updated_at.MinimumWidth = 12;
            this.pm_updated_at.Name = "pm_updated_at";
            this.pm_updated_at.ReadOnly = true;
            this.pm_updated_at.Width = 150;
            // 
            // pm_updated_by
            // 
            this.pm_updated_by.DataPropertyName = "pm_updated_by";
            this.pm_updated_by.HeaderText = "UPDATED BY";
            this.pm_updated_by.MinimumWidth = 12;
            this.pm_updated_by.Name = "pm_updated_by";
            this.pm_updated_by.ReadOnly = true;
            this.pm_updated_by.Width = 150;
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.DataPropertyName = "unit_id";
            this.dataGridViewTextBoxColumn1.FillWeight = 40.60914F;
            this.dataGridViewTextBoxColumn1.HeaderText = "ID";
            this.dataGridViewTextBoxColumn1.MinimumWidth = 12;
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            this.dataGridViewTextBoxColumn1.ReadOnly = true;
            this.dataGridViewTextBoxColumn1.Width = 150;
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.DataPropertyName = "unit_desc";
            this.dataGridViewTextBoxColumn2.FillWeight = 99.49239F;
            this.dataGridViewTextBoxColumn2.HeaderText = "ITEM CLASS";
            this.dataGridViewTextBoxColumn2.MinimumWidth = 12;
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            this.dataGridViewTextBoxColumn2.ReadOnly = true;
            this.dataGridViewTextBoxColumn2.Width = 150;
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.DataPropertyName = "pm_added_at";
            this.dataGridViewTextBoxColumn3.FillWeight = 99.49239F;
            this.dataGridViewTextBoxColumn3.HeaderText = "CREATED DATE";
            this.dataGridViewTextBoxColumn3.MinimumWidth = 12;
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            this.dataGridViewTextBoxColumn3.ReadOnly = true;
            this.dataGridViewTextBoxColumn3.Width = 150;
            // 
            // dataGridViewTextBoxColumn4
            // 
            this.dataGridViewTextBoxColumn4.DataPropertyName = "pm_added_by";
            this.dataGridViewTextBoxColumn4.FillWeight = 99.49239F;
            this.dataGridViewTextBoxColumn4.HeaderText = "CREATED BY";
            this.dataGridViewTextBoxColumn4.MinimumWidth = 12;
            this.dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
            this.dataGridViewTextBoxColumn4.ReadOnly = true;
            this.dataGridViewTextBoxColumn4.Width = 150;
            // 
            // dataGridViewTextBoxColumn5
            // 
            this.dataGridViewTextBoxColumn5.DataPropertyName = "pm_updated_at";
            this.dataGridViewTextBoxColumn5.FillWeight = 99.49239F;
            this.dataGridViewTextBoxColumn5.HeaderText = "UPDATED DATE";
            this.dataGridViewTextBoxColumn5.MinimumWidth = 12;
            this.dataGridViewTextBoxColumn5.Name = "dataGridViewTextBoxColumn5";
            this.dataGridViewTextBoxColumn5.ReadOnly = true;
            this.dataGridViewTextBoxColumn5.Width = 150;
            // 
            // dataGridViewTextBoxColumn6
            // 
            this.dataGridViewTextBoxColumn6.DataPropertyName = "pm_updated_by";
            this.dataGridViewTextBoxColumn6.HeaderText = "UPDATED BY";
            this.dataGridViewTextBoxColumn6.MinimumWidth = 12;
            this.dataGridViewTextBoxColumn6.Name = "dataGridViewTextBoxColumn6";
            this.dataGridViewTextBoxColumn6.ReadOnly = true;
            this.dataGridViewTextBoxColumn6.Width = 150;
            // 
            // dataGridViewTextBoxColumn7
            // 
            this.dataGridViewTextBoxColumn7.DataPropertyName = "unit_id";
            this.dataGridViewTextBoxColumn7.FillWeight = 40.60914F;
            this.dataGridViewTextBoxColumn7.HeaderText = "ID";
            this.dataGridViewTextBoxColumn7.MinimumWidth = 12;
            this.dataGridViewTextBoxColumn7.Name = "dataGridViewTextBoxColumn7";
            this.dataGridViewTextBoxColumn7.ReadOnly = true;
            this.dataGridViewTextBoxColumn7.Width = 150;
            // 
            // dataGridViewTextBoxColumn8
            // 
            this.dataGridViewTextBoxColumn8.DataPropertyName = "unit_desc";
            this.dataGridViewTextBoxColumn8.FillWeight = 99.49239F;
            this.dataGridViewTextBoxColumn8.HeaderText = "ITEM CLASS";
            this.dataGridViewTextBoxColumn8.MinimumWidth = 12;
            this.dataGridViewTextBoxColumn8.Name = "dataGridViewTextBoxColumn8";
            this.dataGridViewTextBoxColumn8.ReadOnly = true;
            this.dataGridViewTextBoxColumn8.Width = 150;
            // 
            // dataGridViewTextBoxColumn9
            // 
            this.dataGridViewTextBoxColumn9.DataPropertyName = "pm_added_at";
            this.dataGridViewTextBoxColumn9.FillWeight = 99.49239F;
            this.dataGridViewTextBoxColumn9.HeaderText = "CREATED DATE";
            this.dataGridViewTextBoxColumn9.MinimumWidth = 12;
            this.dataGridViewTextBoxColumn9.Name = "dataGridViewTextBoxColumn9";
            this.dataGridViewTextBoxColumn9.ReadOnly = true;
            this.dataGridViewTextBoxColumn9.Width = 150;
            // 
            // dataGridViewTextBoxColumn10
            // 
            this.dataGridViewTextBoxColumn10.DataPropertyName = "pm_added_by";
            this.dataGridViewTextBoxColumn10.FillWeight = 99.49239F;
            this.dataGridViewTextBoxColumn10.HeaderText = "CREATED BY";
            this.dataGridViewTextBoxColumn10.MinimumWidth = 12;
            this.dataGridViewTextBoxColumn10.Name = "dataGridViewTextBoxColumn10";
            this.dataGridViewTextBoxColumn10.ReadOnly = true;
            this.dataGridViewTextBoxColumn10.Width = 150;
            // 
            // dataGridViewTextBoxColumn11
            // 
            this.dataGridViewTextBoxColumn11.DataPropertyName = "pm_updated_at";
            this.dataGridViewTextBoxColumn11.FillWeight = 99.49239F;
            this.dataGridViewTextBoxColumn11.HeaderText = "UPDATED DATE";
            this.dataGridViewTextBoxColumn11.MinimumWidth = 12;
            this.dataGridViewTextBoxColumn11.Name = "dataGridViewTextBoxColumn11";
            this.dataGridViewTextBoxColumn11.ReadOnly = true;
            this.dataGridViewTextBoxColumn11.Width = 150;
            // 
            // dataGridViewTextBoxColumn12
            // 
            this.dataGridViewTextBoxColumn12.DataPropertyName = "pm_updated_by";
            this.dataGridViewTextBoxColumn12.HeaderText = "UPDATED BY";
            this.dataGridViewTextBoxColumn12.MinimumWidth = 12;
            this.dataGridViewTextBoxColumn12.Name = "dataGridViewTextBoxColumn12";
            this.dataGridViewTextBoxColumn12.ReadOnly = true;
            this.dataGridViewTextBoxColumn12.Width = 150;
            // 
            // dataGridViewTextBoxColumn13
            // 
            this.dataGridViewTextBoxColumn13.DataPropertyName = "unit_id";
            this.dataGridViewTextBoxColumn13.FillWeight = 40.60914F;
            this.dataGridViewTextBoxColumn13.HeaderText = "ID";
            this.dataGridViewTextBoxColumn13.MinimumWidth = 12;
            this.dataGridViewTextBoxColumn13.Name = "dataGridViewTextBoxColumn13";
            this.dataGridViewTextBoxColumn13.ReadOnly = true;
            this.dataGridViewTextBoxColumn13.Width = 150;
            // 
            // dataGridViewTextBoxColumn14
            // 
            this.dataGridViewTextBoxColumn14.DataPropertyName = "unit_desc";
            this.dataGridViewTextBoxColumn14.FillWeight = 99.49239F;
            this.dataGridViewTextBoxColumn14.HeaderText = "ITEM CLASS";
            this.dataGridViewTextBoxColumn14.MinimumWidth = 12;
            this.dataGridViewTextBoxColumn14.Name = "dataGridViewTextBoxColumn14";
            this.dataGridViewTextBoxColumn14.ReadOnly = true;
            this.dataGridViewTextBoxColumn14.Width = 150;
            // 
            // dataGridViewTextBoxColumn15
            // 
            this.dataGridViewTextBoxColumn15.DataPropertyName = "pm_added_at";
            this.dataGridViewTextBoxColumn15.FillWeight = 99.49239F;
            this.dataGridViewTextBoxColumn15.HeaderText = "CREATED DATE";
            this.dataGridViewTextBoxColumn15.MinimumWidth = 12;
            this.dataGridViewTextBoxColumn15.Name = "dataGridViewTextBoxColumn15";
            this.dataGridViewTextBoxColumn15.ReadOnly = true;
            this.dataGridViewTextBoxColumn15.Width = 150;
            // 
            // dataGridViewTextBoxColumn16
            // 
            this.dataGridViewTextBoxColumn16.DataPropertyName = "pm_added_by";
            this.dataGridViewTextBoxColumn16.FillWeight = 99.49239F;
            this.dataGridViewTextBoxColumn16.HeaderText = "CREATED BY";
            this.dataGridViewTextBoxColumn16.MinimumWidth = 12;
            this.dataGridViewTextBoxColumn16.Name = "dataGridViewTextBoxColumn16";
            this.dataGridViewTextBoxColumn16.ReadOnly = true;
            this.dataGridViewTextBoxColumn16.Width = 150;
            // 
            // dataGridViewTextBoxColumn17
            // 
            this.dataGridViewTextBoxColumn17.DataPropertyName = "pm_updated_at";
            this.dataGridViewTextBoxColumn17.FillWeight = 99.49239F;
            this.dataGridViewTextBoxColumn17.HeaderText = "UPDATED DATE";
            this.dataGridViewTextBoxColumn17.MinimumWidth = 12;
            this.dataGridViewTextBoxColumn17.Name = "dataGridViewTextBoxColumn17";
            this.dataGridViewTextBoxColumn17.ReadOnly = true;
            this.dataGridViewTextBoxColumn17.Width = 150;
            // 
            // dataGridViewTextBoxColumn18
            // 
            this.dataGridViewTextBoxColumn18.DataPropertyName = "pm_updated_by";
            this.dataGridViewTextBoxColumn18.HeaderText = "UPDATED BY";
            this.dataGridViewTextBoxColumn18.MinimumWidth = 12;
            this.dataGridViewTextBoxColumn18.Name = "dataGridViewTextBoxColumn18";
            this.dataGridViewTextBoxColumn18.ReadOnly = true;
            this.dataGridViewTextBoxColumn18.Width = 150;
            // 
            // MatTxtRegion
            // 
            this.MatTxtRegion.AnimateReadOnly = false;
            this.MatTxtRegion.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.MatTxtRegion.Depth = 0;
            this.MatTxtRegion.Font = new System.Drawing.Font("Roboto", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.MatTxtRegion.Hint = "Region";
            this.MatTxtRegion.LeadingIcon = null;
            this.MatTxtRegion.Location = new System.Drawing.Point(73, 152);
            this.MatTxtRegion.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.MatTxtRegion.MaxLength = 50;
            this.MatTxtRegion.MouseState = MaterialSkin.MouseState.OUT;
            this.MatTxtRegion.Multiline = false;
            this.MatTxtRegion.Name = "MatTxtRegion";
            this.MatTxtRegion.Size = new System.Drawing.Size(333, 50);
            this.MatTxtRegion.TabIndex = 2;
            this.MatTxtRegion.Text = "";
            this.MatTxtRegion.TrailingIcon = null;
            // 
            // MatBtnLoadData
            // 
            this.MatBtnLoadData.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.MatBtnLoadData.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.MatBtnLoadData.Depth = 0;
            this.MatBtnLoadData.HighEmphasis = true;
            this.MatBtnLoadData.Icon = null;
            this.MatBtnLoadData.Location = new System.Drawing.Point(121, 224);
            this.MatBtnLoadData.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.MatBtnLoadData.MouseState = MaterialSkin.MouseState.HOVER;
            this.MatBtnLoadData.Name = "MatBtnLoadData";
            this.MatBtnLoadData.NoAccentTextColor = System.Drawing.Color.Empty;
            this.MatBtnLoadData.Size = new System.Drawing.Size(100, 36);
            this.MatBtnLoadData.TabIndex = 3;
            this.MatBtnLoadData.Text = "Load Data";
            this.MatBtnLoadData.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.MatBtnLoadData.UseAccentColor = false;
            this.MatBtnLoadData.UseVisualStyleBackColor = true;
            this.MatBtnLoadData.Click += new System.EventHandler(this.MatBtnLoadData_Click);
            // 
            // LblRegion
            // 
            this.LblRegion.AutoSize = true;
            this.LblRegion.Depth = 0;
            this.LblRegion.Font = new System.Drawing.Font("Roboto", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.LblRegion.Location = new System.Drawing.Point(73, 128);
            this.LblRegion.MouseState = MaterialSkin.MouseState.HOVER;
            this.LblRegion.Name = "LblRegion";
            this.LblRegion.Size = new System.Drawing.Size(50, 19);
            this.LblRegion.TabIndex = 4;
            this.LblRegion.Text = "Region";
            // 
            // LblTotal
            // 
            this.LblTotal.AutoSize = true;
            this.LblTotal.Location = new System.Drawing.Point(788, 696);
            this.LblTotal.Name = "LblTotal";
            this.LblTotal.Size = new System.Drawing.Size(41, 16);
            this.LblTotal.TabIndex = 5;
            this.LblTotal.Text = "Total:";
            this.LblTotal.Visible = false;
            // 
            // lblTotalrecords
            // 
            this.lblTotalrecords.AutoSize = true;
            this.lblTotalrecords.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTotalrecords.Location = new System.Drawing.Point(851, 696);
            this.lblTotalrecords.Name = "lblTotalrecords";
            this.lblTotalrecords.Size = new System.Drawing.Size(43, 16);
            this.lblTotalrecords.TabIndex = 6;
            this.lblTotalrecords.Text = "Total";
            this.lblTotalrecords.Visible = false;
            // 
            // Id
            // 
            this.Id.DataPropertyName = "Id";
            this.Id.FillWeight = 40.60914F;
            this.Id.HeaderText = "ID";
            this.Id.MinimumWidth = 12;
            this.Id.Name = "Id";
            this.Id.ReadOnly = true;
            // 
            // Name
            // 
            this.Name.DataPropertyName = "Name";
            this.Name.FillWeight = 99.49239F;
            this.Name.HeaderText = "NAME";
            this.Name.MinimumWidth = 12;
            this.Name.Name = "Name";
            this.Name.ReadOnly = true;
            // 
            // Region
            // 
            this.Region.DataPropertyName = "Region";
            this.Region.FillWeight = 99.49239F;
            this.Region.HeaderText = "REGION";
            this.Region.MinimumWidth = 12;
            this.Region.Name = "Region";
            this.Region.ReadOnly = true;
            // 
            // FrmMainMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(974, 766);
            this.Controls.Add(this.lblTotalrecords);
            this.Controls.Add(this.LblTotal);
            this.Controls.Add(this.LblRegion);
            this.Controls.Add(this.MatBtnLoadData);
            this.Controls.Add(this.MatTxtRegion);
            this.Controls.Add(this.MatCardViewing);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            //this.Name = "FrmMainMenu";
            this.Padding = new System.Windows.Forms.Padding(3, 51, 3, 2);
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Load += new System.EventHandler(this.Form1_Load);
            this.MatCardViewing.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.GunaDgvViewing)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

		}

        #endregion

        private MaterialSkin.Controls.MaterialContextMenuStrip materialContextMenuStrip1;
        private MaterialSkin.Controls.MaterialCard MatCardViewing;
        private System.Windows.Forms.DataGridViewTextBoxColumn item_type_id;
        private System.Windows.Forms.DataGridViewTextBoxColumn item_type_desc;
        private System.Windows.Forms.DataGridViewTextBoxColumn it_added_at;
        private System.Windows.Forms.DataGridViewTextBoxColumn it_added_by;
        private System.Windows.Forms.DataGridViewTextBoxColumn it_updated_at;
        private System.Windows.Forms.DataGridViewTextBoxColumn it_updated_by;
        private System.Windows.Forms.DataGridViewTextBoxColumn unit_id;
        private System.Windows.Forms.DataGridViewTextBoxColumn unit_desc;
        private System.Windows.Forms.DataGridViewTextBoxColumn pm_added_at;
        private System.Windows.Forms.DataGridViewTextBoxColumn pm_added_by;
        private System.Windows.Forms.DataGridViewTextBoxColumn pm_updated_at;
        private System.Windows.Forms.DataGridViewTextBoxColumn pm_updated_by;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn5;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn6;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn7;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn8;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn9;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn10;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn11;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn12;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn13;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn14;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn15;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn16;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn17;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn18;
        private Guna.UI2.WinForms.Guna2DataGridView GunaDgvViewing;
        private MaterialSkin.Controls.MaterialTextBox MatTxtRegion;
        private MaterialSkin.Controls.MaterialButton MatBtnLoadData;
        private MaterialSkin.Controls.MaterialLabel LblRegion;
        private System.Windows.Forms.Label LblTotal;
        private System.Windows.Forms.Label lblTotalrecords;
        private System.Windows.Forms.DataGridViewTextBoxColumn Id;
        private System.Windows.Forms.DataGridViewTextBoxColumn Name;
        private System.Windows.Forms.DataGridViewTextBoxColumn Region;
    }
}

