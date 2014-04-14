///************************************************
/// Generated by: TuNA
/// Date: 06-03-2014 01:22:33
/// Goal: Create Form for V_DM_QUYET_DINH
///************************************************


using System;
using System.Data;
using System.Drawing;
using System.Collections;
using System.ComponentModel;
using System.Windows.Forms;

using IP.Core.IPCommon;
using IP.Core.IPException;
using IP.Core.IPData;
using IP.Core.IPUserService;
using IP.Core.IPSystemAdmin;

using BKI_HRM.US;
using BKI_HRM.DS;
using BKI_HRM.DS.CDBNames;

using C1.Win.C1FlexGrid;
using BKI_HRM.DanhMuc;


namespace BKI_HRM
{



	public class f600_v_dm_quyet_dinh : System.Windows.Forms.Form
	{
        internal System.Windows.Forms.ImageList ImageList;
        internal System.Windows.Forms.Panel m_pnl_out_place_dm;
        internal SIS.Controls.Button.SiSButton m_cmd_delete;
        internal SIS.Controls.Button.SiSButton m_cmd_update;
        internal SIS.Controls.Button.SiSButton m_cmd_insert;
        internal SIS.Controls.Button.SiSButton m_cmd_exit;
        internal SIS.Controls.Button.SiSButton m_cmd_view;
        internal SIS.Controls.Button.SiSButton m_cmd_search;
        private TextBox m_txt_tim_kiem;
        private Label m_lbl_tim_kiem;
        private C1.Win.C1FlexGrid.C1FlexGrid m_grv_dm_quyet_dinh;
        private ToolTip m_tooltip;
        internal SIS.Controls.Button.SiSButton m_cmd_chon_quyet_dinh;

        private System.ComponentModel.IContainer components;


		public f600_v_dm_quyet_dinh()
		{
			//
			// Required for Windows Form Designer support
			//
			InitializeComponent();

			//
			// TODO: Add any constructor code after InitializeComponent call
			//
			format_controls();
		}

		/// <summary>
		/// Clean up any resources being used.
		/// </summary>
		protected override void Dispose( bool disposing )
		{
			if( disposing )
			{
				if(components != null)
				{
					components.Dispose();
				}
			}
			base.Dispose( disposing );
		}

		#region Windows Form Designer generated code
		/// <summary>
		/// Required method for Designer support - do not modify
		/// the contents of this method with the code editor.
		/// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(f600_v_dm_quyet_dinh));
            this.ImageList = new System.Windows.Forms.ImageList(this.components);
            this.m_pnl_out_place_dm = new System.Windows.Forms.Panel();
            this.m_cmd_insert = new SIS.Controls.Button.SiSButton();
            this.m_cmd_update = new SIS.Controls.Button.SiSButton();
            this.m_cmd_view = new SIS.Controls.Button.SiSButton();
            this.m_cmd_delete = new SIS.Controls.Button.SiSButton();
            this.m_cmd_exit = new SIS.Controls.Button.SiSButton();
            this.m_cmd_search = new SIS.Controls.Button.SiSButton();
            this.m_txt_tim_kiem = new System.Windows.Forms.TextBox();
            this.m_lbl_tim_kiem = new System.Windows.Forms.Label();
            this.m_grv_dm_quyet_dinh = new C1.Win.C1FlexGrid.C1FlexGrid();
            this.m_tooltip = new System.Windows.Forms.ToolTip(this.components);
            this.m_cmd_chon_quyet_dinh = new SIS.Controls.Button.SiSButton();
            this.m_pnl_out_place_dm.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.m_grv_dm_quyet_dinh)).BeginInit();
            this.SuspendLayout();
            // 
            // ImageList
            // 
            this.ImageList.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("ImageList.ImageStream")));
            this.ImageList.TransparentColor = System.Drawing.Color.Transparent;
            this.ImageList.Images.SetKeyName(0, "");
            this.ImageList.Images.SetKeyName(1, "");
            this.ImageList.Images.SetKeyName(2, "");
            this.ImageList.Images.SetKeyName(3, "");
            this.ImageList.Images.SetKeyName(4, "");
            this.ImageList.Images.SetKeyName(5, "");
            this.ImageList.Images.SetKeyName(6, "");
            this.ImageList.Images.SetKeyName(7, "");
            this.ImageList.Images.SetKeyName(8, "");
            this.ImageList.Images.SetKeyName(9, "");
            this.ImageList.Images.SetKeyName(10, "");
            this.ImageList.Images.SetKeyName(11, "");
            this.ImageList.Images.SetKeyName(12, "");
            this.ImageList.Images.SetKeyName(13, "");
            this.ImageList.Images.SetKeyName(14, "");
            this.ImageList.Images.SetKeyName(15, "");
            this.ImageList.Images.SetKeyName(16, "");
            this.ImageList.Images.SetKeyName(17, "");
            this.ImageList.Images.SetKeyName(18, "");
            this.ImageList.Images.SetKeyName(19, "");
            this.ImageList.Images.SetKeyName(20, "");
            this.ImageList.Images.SetKeyName(21, "");
            // 
            // m_pnl_out_place_dm
            // 
            this.m_pnl_out_place_dm.Controls.Add(this.m_cmd_chon_quyet_dinh);
            this.m_pnl_out_place_dm.Controls.Add(this.m_cmd_insert);
            this.m_pnl_out_place_dm.Controls.Add(this.m_cmd_update);
            this.m_pnl_out_place_dm.Controls.Add(this.m_cmd_view);
            this.m_pnl_out_place_dm.Controls.Add(this.m_cmd_delete);
            this.m_pnl_out_place_dm.Controls.Add(this.m_cmd_exit);
            this.m_pnl_out_place_dm.Location = new System.Drawing.Point(0, 428);
            this.m_pnl_out_place_dm.Name = "m_pnl_out_place_dm";
            this.m_pnl_out_place_dm.Padding = new System.Windows.Forms.Padding(4);
            this.m_pnl_out_place_dm.Size = new System.Drawing.Size(782, 36);
            this.m_pnl_out_place_dm.TabIndex = 19;
            // 
            // m_cmd_insert
            // 
            this.m_cmd_insert.AdjustImageLocation = new System.Drawing.Point(0, 0);
            this.m_cmd_insert.BtnShape = SIS.Controls.Button.emunType.BtnShape.Rectangle;
            this.m_cmd_insert.BtnStyle = SIS.Controls.Button.emunType.XPStyle.Default;
            this.m_cmd_insert.Dock = System.Windows.Forms.DockStyle.Right;
            this.m_cmd_insert.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.m_cmd_insert.ImageIndex = 2;
            this.m_cmd_insert.ImageList = this.ImageList;
            this.m_cmd_insert.Location = new System.Drawing.Point(298, 4);
            this.m_cmd_insert.Name = "m_cmd_insert";
            this.m_cmd_insert.Size = new System.Drawing.Size(120, 28);
            this.m_cmd_insert.TabIndex = 12;
            this.m_cmd_insert.Text = "&Thêm quyết định";
            // 
            // m_cmd_update
            // 
            this.m_cmd_update.AdjustImageLocation = new System.Drawing.Point(0, 0);
            this.m_cmd_update.BtnShape = SIS.Controls.Button.emunType.BtnShape.Rectangle;
            this.m_cmd_update.BtnStyle = SIS.Controls.Button.emunType.XPStyle.Default;
            this.m_cmd_update.Dock = System.Windows.Forms.DockStyle.Right;
            this.m_cmd_update.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.m_cmd_update.ImageIndex = 3;
            this.m_cmd_update.ImageList = this.ImageList;
            this.m_cmd_update.Location = new System.Drawing.Point(418, 4);
            this.m_cmd_update.Name = "m_cmd_update";
            this.m_cmd_update.Size = new System.Drawing.Size(120, 28);
            this.m_cmd_update.TabIndex = 13;
            this.m_cmd_update.Text = "&Sửa quyết định";
            // 
            // m_cmd_view
            // 
            this.m_cmd_view.AdjustImageLocation = new System.Drawing.Point(0, 0);
            this.m_cmd_view.BtnShape = SIS.Controls.Button.emunType.BtnShape.Rectangle;
            this.m_cmd_view.BtnStyle = SIS.Controls.Button.emunType.XPStyle.Default;
            this.m_cmd_view.Dock = System.Windows.Forms.DockStyle.Left;
            this.m_cmd_view.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.m_cmd_view.ImageIndex = 18;
            this.m_cmd_view.ImageList = this.ImageList;
            this.m_cmd_view.Location = new System.Drawing.Point(4, 4);
            this.m_cmd_view.Name = "m_cmd_view";
            this.m_cmd_view.Size = new System.Drawing.Size(88, 28);
            this.m_cmd_view.TabIndex = 21;
            this.m_cmd_view.Text = "Xem";
            // 
            // m_cmd_delete
            // 
            this.m_cmd_delete.AdjustImageLocation = new System.Drawing.Point(0, 0);
            this.m_cmd_delete.BtnShape = SIS.Controls.Button.emunType.BtnShape.Rectangle;
            this.m_cmd_delete.BtnStyle = SIS.Controls.Button.emunType.XPStyle.Default;
            this.m_cmd_delete.Dock = System.Windows.Forms.DockStyle.Right;
            this.m_cmd_delete.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.m_cmd_delete.ImageIndex = 4;
            this.m_cmd_delete.ImageList = this.ImageList;
            this.m_cmd_delete.Location = new System.Drawing.Point(538, 4);
            this.m_cmd_delete.Name = "m_cmd_delete";
            this.m_cmd_delete.Size = new System.Drawing.Size(120, 28);
            this.m_cmd_delete.TabIndex = 14;
            this.m_cmd_delete.Text = "&Xoá quyết định";
            // 
            // m_cmd_exit
            // 
            this.m_cmd_exit.AdjustImageLocation = new System.Drawing.Point(0, 0);
            this.m_cmd_exit.BtnShape = SIS.Controls.Button.emunType.BtnShape.Rectangle;
            this.m_cmd_exit.BtnStyle = SIS.Controls.Button.emunType.XPStyle.Default;
            this.m_cmd_exit.Dock = System.Windows.Forms.DockStyle.Right;
            this.m_cmd_exit.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.m_cmd_exit.ImageIndex = 12;
            this.m_cmd_exit.ImageList = this.ImageList;
            this.m_cmd_exit.Location = new System.Drawing.Point(658, 4);
            this.m_cmd_exit.Name = "m_cmd_exit";
            this.m_cmd_exit.Size = new System.Drawing.Size(120, 28);
            this.m_cmd_exit.TabIndex = 11;
            this.m_cmd_exit.Text = "Thoát (Esc)";
            // 
            // m_cmd_search
            // 
            this.m_cmd_search.AdjustImageLocation = new System.Drawing.Point(0, 0);
            this.m_cmd_search.BtnShape = SIS.Controls.Button.emunType.BtnShape.Rectangle;
            this.m_cmd_search.BtnStyle = SIS.Controls.Button.emunType.XPStyle.Default;
            this.m_cmd_search.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.m_cmd_search.ImageIndex = 5;
            this.m_cmd_search.ImageList = this.ImageList;
            this.m_cmd_search.Location = new System.Drawing.Point(559, 12);
            this.m_cmd_search.Name = "m_cmd_search";
            this.m_cmd_search.Size = new System.Drawing.Size(88, 28);
            this.m_cmd_search.TabIndex = 33;
            this.m_cmd_search.Text = "Tìm kiếm";
            this.m_cmd_search.Click += new System.EventHandler(this.m_cmd_search_Click);
            // 
            // m_txt_tim_kiem
            // 
            this.m_txt_tim_kiem.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.m_txt_tim_kiem.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.CustomSource;
            this.m_txt_tim_kiem.ForeColor = System.Drawing.SystemColors.GrayText;
            this.m_txt_tim_kiem.Location = new System.Drawing.Point(186, 17);
            this.m_txt_tim_kiem.Name = "m_txt_tim_kiem";
            this.m_txt_tim_kiem.Size = new System.Drawing.Size(352, 20);
            this.m_txt_tim_kiem.TabIndex = 32;
            // 
            // m_lbl_tim_kiem
            // 
            this.m_lbl_tim_kiem.AutoSize = true;
            this.m_lbl_tim_kiem.Location = new System.Drawing.Point(120, 20);
            this.m_lbl_tim_kiem.Name = "m_lbl_tim_kiem";
            this.m_lbl_tim_kiem.Size = new System.Drawing.Size(49, 13);
            this.m_lbl_tim_kiem.TabIndex = 34;
            this.m_lbl_tim_kiem.Text = "Tìm kiếm";
            // 
            // m_grv_dm_quyet_dinh
            // 
            this.m_grv_dm_quyet_dinh.ColumnInfo = resources.GetString("m_grv_dm_quyet_dinh.ColumnInfo");
            this.m_grv_dm_quyet_dinh.Location = new System.Drawing.Point(0, 50);
            this.m_grv_dm_quyet_dinh.Name = "m_grv_dm_quyet_dinh";
            this.m_grv_dm_quyet_dinh.SelectionMode = C1.Win.C1FlexGrid.SelectionModeEnum.Row;
            this.m_grv_dm_quyet_dinh.Size = new System.Drawing.Size(778, 367);
            this.m_grv_dm_quyet_dinh.Styles = new C1.Win.C1FlexGrid.CellStyleCollection(resources.GetString("m_grv_dm_quyet_dinh.Styles"));
            this.m_grv_dm_quyet_dinh.TabIndex = 20;
            this.m_grv_dm_quyet_dinh.KeyDown += new System.Windows.Forms.KeyEventHandler(this.m_grv_dm_quyet_dinh_KeyDown);
            // 
            // m_cmd_chon_quyet_dinh
            // 
            this.m_cmd_chon_quyet_dinh.AdjustImageLocation = new System.Drawing.Point(0, 0);
            this.m_cmd_chon_quyet_dinh.BtnShape = SIS.Controls.Button.emunType.BtnShape.Rectangle;
            this.m_cmd_chon_quyet_dinh.BtnStyle = SIS.Controls.Button.emunType.XPStyle.Default;
            this.m_cmd_chon_quyet_dinh.Dock = System.Windows.Forms.DockStyle.Right;
            this.m_cmd_chon_quyet_dinh.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.m_cmd_chon_quyet_dinh.ImageIndex = 13;
            this.m_cmd_chon_quyet_dinh.ImageList = this.ImageList;
            this.m_cmd_chon_quyet_dinh.Location = new System.Drawing.Point(178, 4);
            this.m_cmd_chon_quyet_dinh.Name = "m_cmd_chon_quyet_dinh";
            this.m_cmd_chon_quyet_dinh.Size = new System.Drawing.Size(120, 28);
            this.m_cmd_chon_quyet_dinh.TabIndex = 22;
            this.m_cmd_chon_quyet_dinh.Text = "&Chọn quyết định";
            this.m_cmd_chon_quyet_dinh.Visible = false;
            this.m_cmd_chon_quyet_dinh.Click += new System.EventHandler(this.m_cmd_chon_quyet_dinh_Click);
            // 
            // f600_v_dm_quyet_dinh
            // 
            this.AutoScaleBaseSize = new System.Drawing.Size(5, 13);
            this.ClientSize = new System.Drawing.Size(784, 461);
            this.Controls.Add(this.m_lbl_tim_kiem);
            this.Controls.Add(this.m_cmd_search);
            this.Controls.Add(this.m_txt_tim_kiem);
            this.Controls.Add(this.m_grv_dm_quyet_dinh);
            this.Controls.Add(this.m_pnl_out_place_dm);
            this.MaximumSize = new System.Drawing.Size(800, 500);
            this.MinimumSize = new System.Drawing.Size(800, 500);
            this.Name = "f600_v_dm_quyet_dinh";
            this.Text = "f600_v_dm_quyet_dinh";
            this.Load += new System.EventHandler(this.f600_v_dm_quyet_dinh_Load);
            this.m_pnl_out_place_dm.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.m_grv_dm_quyet_dinh)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }
        #endregion
        #region Public Interface
        public void display()
        {
            this.ShowDialog();
        }
        public void select_data(ref US_DM_QUYET_DINH op_us)
        {
            m_e_form_mode = DataEntryFormMode.SelectDataState;
            this.ShowDialog();
            op_us = m_us; 
        }
        #endregion

        #region Data Structure
        private enum e_col_Number
        {
            NGAY_HET_HIEU_LUC = 5
,
            NGAY_KY = 4
                ,
            TEN = 1
                ,
            LINK = 7
                ,
            NOI_DUNG = 6
                ,
            NGAY_CO_HIEU_LUC = 3
                , MA_QUYET_DINH = 2

        }
        #endregion

        #region Members
        ITransferDataRow m_obj_trans;
        DataEntryFormMode m_e_form_mode = DataEntryFormMode.ViewDataState;
        DS_V_DM_QUYET_DINH m_v_ds = new DS_V_DM_QUYET_DINH();
        US_V_DM_QUYET_DINH m_v_us = new US_V_DM_QUYET_DINH();
        US_DM_QUYET_DINH m_us = new US_DM_QUYET_DINH();
        DS_DM_QUYET_DINH m_ds = new DS_DM_QUYET_DINH();
        private const String m_str_tim_kiem = "Nhập loại quyết định, mã quyết định, nội dung cần tìm";

        #endregion

        #region Private Methods
        private void load_custom_source_2_m_txt_tim_kiem()
        {
            //m_us.FillDataset(m_ds);
            int count = m_v_ds.Tables["V_DM_QUYET_DINH"].Rows.Count;
            AutoCompleteStringCollection v_acsc_search = new AutoCompleteStringCollection();
            foreach (DataRow dr in m_v_ds.V_DM_QUYET_DINH)
            {
                v_acsc_search.Add(dr[V_DM_QUYET_DINH.TEN].ToString());
                v_acsc_search.Add(dr[V_DM_QUYET_DINH.MA_QUYET_DINH].ToString());
                v_acsc_search.Add(dr[V_DM_QUYET_DINH.NOI_DUNG].ToString());
            }
            m_txt_tim_kiem.AutoCompleteCustomSource = v_acsc_search;
        }
        private void format_controls()
        {
            CControlFormat.setFormStyle(this, new CAppContext_201());
            CControlFormat.setC1FlexFormat(m_grv_dm_quyet_dinh);
            CGridUtils.AddSave_Excel_Handlers(m_grv_dm_quyet_dinh);
            CGridUtils.AddSearch_Handlers(m_grv_dm_quyet_dinh);
            
            m_grv_dm_quyet_dinh.Tree.Column = (int)e_col_Number.TEN;
            m_grv_dm_quyet_dinh.Tree.Style = C1.Win.C1FlexGrid.TreeStyleFlags.SimpleLeaf;
			
            set_define_events();
            this.KeyPreview = true;
        }
        private void set_initial_form_load()
        {
            m_obj_trans = get_trans_object(m_grv_dm_quyet_dinh);
            load_data_2_grid();
            if (m_e_form_mode == DataEntryFormMode.SelectDataState)
                m_cmd_chon_quyet_dinh.Visible = true;
        }
        private ITransferDataRow get_trans_object(C1.Win.C1FlexGrid.C1FlexGrid i_fg)
        {
            Hashtable v_htb = new Hashtable();
            v_htb.Add(V_DM_QUYET_DINH.NGAY_HET_HIEU_LUC, e_col_Number.NGAY_HET_HIEU_LUC);
            v_htb.Add(V_DM_QUYET_DINH.NGAY_KY, e_col_Number.NGAY_KY);
            v_htb.Add(V_DM_QUYET_DINH.TEN, e_col_Number.TEN);
            v_htb.Add(V_DM_QUYET_DINH.LINK, e_col_Number.LINK);
            v_htb.Add(V_DM_QUYET_DINH.NOI_DUNG, e_col_Number.NOI_DUNG);
            v_htb.Add(V_DM_QUYET_DINH.NGAY_CO_HIEU_LUC, e_col_Number.NGAY_CO_HIEU_LUC);
            v_htb.Add(V_DM_QUYET_DINH.MA_QUYET_DINH, e_col_Number.MA_QUYET_DINH);

            ITransferDataRow v_obj_trans = new CC1TransferDataRow(i_fg, v_htb, m_v_ds.V_DM_QUYET_DINH.NewRow());
            return v_obj_trans;
        }
        private void load_data_2_grid()
        {
            m_v_ds = new DS_V_DM_QUYET_DINH();
            if (m_txt_tim_kiem.Text.Trim() == m_str_tim_kiem || m_txt_tim_kiem.Text.Trim()=="") m_v_us.FillDatasetSearch(m_v_ds,"");
            else m_v_us.FillDatasetSearch(m_v_ds, m_txt_tim_kiem.Text.Trim());
            //m_us.FillDataset(m_ds);
            var v_str_search = m_txt_tim_kiem.Text.Trim();
            if (v_str_search.Equals(m_str_tim_kiem))
            {
                v_str_search = "";
            }
            m_grv_dm_quyet_dinh.Redraw = false;
            CGridUtils.Dataset2C1Grid(m_v_ds, m_grv_dm_quyet_dinh, m_obj_trans);
            m_grv_dm_quyet_dinh.Subtotal(C1.Win.C1FlexGrid.AggregateEnum.Count // chỗ này dùng hàm count tức là để đếm, có thể dùng các hàm khác thay thế
              , 0
              , (int)e_col_Number.TEN // chỗ này là tên trường mà mình nhóm
              , (int)e_col_Number.MA_QUYET_DINH // chỗ này là tên trường mà mình Count
              , "{0}"
              );
           
            m_grv_dm_quyet_dinh.Redraw = true;
            set_search_format_before();
        }
        private void set_search_format_before()
        {
            if (m_txt_tim_kiem.Text == "")
            {
                m_txt_tim_kiem.Text = m_str_tim_kiem;
                m_txt_tim_kiem.ForeColor = Color.Gray;
            }
            
        }
        private void set_search_format_after()
        {
            if (m_txt_tim_kiem.Text == m_str_tim_kiem)
            {
                m_txt_tim_kiem.Text = "";
            }
            m_txt_tim_kiem.ForeColor = Color.Black;
        }
        private void grid2us_object(US_V_DM_QUYET_DINH i_us
            , int i_grid_row)
        {
            DataRow v_dr;
            v_dr = (DataRow)m_grv_dm_quyet_dinh.Rows[i_grid_row].UserData;
            m_obj_trans.GridRow2DataRow(i_grid_row, v_dr);
            i_us.DataRow2Me(v_dr);
        }


        private void us_object2grid(US_V_DM_QUYET_DINH i_us
            , int i_grid_row)
        {
            DataRow v_dr = (DataRow)m_grv_dm_quyet_dinh.Rows[i_grid_row].UserData;
            i_us.Me2DataRow(v_dr);
            m_obj_trans.DataRow2GridRow(v_dr, i_grid_row);
        }


        private void insert_v_dm_quyet_dinh()
        {
            F600_V_DM_QUYET_DINH_DE v_fDE = new F600_V_DM_QUYET_DINH_DE();
            v_fDE.display_for_insert();

            load_data_2_grid();
            v_fDE.get_us(ref m_us);
            WinFormControls.set_focus_for_grid(m_grv_dm_quyet_dinh, m_us.strMA_QUYET_DINH, 2);
            
            //m_txt_tim_kiem.Text = m_str_tim_kiem;
            
            
           
        }

        private void update_v_dm_quyet_dinh()
        {
            if (!CGridUtils.IsThere_Any_NonFixed_Row(m_grv_dm_quyet_dinh)) return;
            if (!CGridUtils.isValid_NonFixed_RowIndex(m_grv_dm_quyet_dinh, m_grv_dm_quyet_dinh.Row)) return;
            grid2us_object(m_v_us, m_grv_dm_quyet_dinh.Row);
            F600_V_DM_QUYET_DINH_DE v_fDE = new F600_V_DM_QUYET_DINH_DE();
            v_fDE.display_for_update(m_v_us);
            m_txt_tim_kiem.Text = "";
            load_data_2_grid();
            m_txt_tim_kiem.Text = m_str_tim_kiem;
        }

        private void delete_v_dm_quyet_dinh()
        {
            if (!CGridUtils.IsThere_Any_NonFixed_Row(m_grv_dm_quyet_dinh)) return;
            if (!CGridUtils.isValid_NonFixed_RowIndex(m_grv_dm_quyet_dinh, m_grv_dm_quyet_dinh.Row)) return;
            if (BaseMessages.askUser_DataCouldBeDeleted(8) != BaseMessages.IsDataCouldBeDeleted.CouldBeDeleted) return;
            US_V_DM_QUYET_DINH v_us = new US_V_DM_QUYET_DINH();
            grid2us_object(v_us, m_grv_dm_quyet_dinh.Row);
            try
            {
                v_us.BeginTransaction();
                v_us.Delete();
                v_us.CommitTransaction();
                m_grv_dm_quyet_dinh.Rows.Remove(m_grv_dm_quyet_dinh.Row);
            }
            catch (Exception v_e)
            {
                v_us.Rollback();
                CDBExceptionHandler v_objErrHandler = new CDBExceptionHandler(v_e,
                    new CDBClientDBExceptionInterpret());
                v_objErrHandler.showErrorMessage();
            }
        }

        private void view_v_dm_quyet_dinh()
        {
            if (!CGridUtils.IsThere_Any_NonFixed_Row(m_grv_dm_quyet_dinh)) return;
            if (!CGridUtils.isValid_NonFixed_RowIndex(m_grv_dm_quyet_dinh, m_grv_dm_quyet_dinh.Row)) return;
            grid2us_object(m_v_us, m_grv_dm_quyet_dinh.Row);
            F600_V_DM_QUYET_DINH_DE v_fDE = new F600_V_DM_QUYET_DINH_DE();
            v_fDE.display(m_v_us);
        }

        private void select_data_2_us()
        {
            if (!CGridUtils.IsThere_Any_NonFixed_Row(m_grv_dm_quyet_dinh)) return;
            if (!CGridUtils.isValid_NonFixed_RowIndex(m_grv_dm_quyet_dinh, m_grv_dm_quyet_dinh.Row)) return;
            grid2us_object(m_v_us, m_grv_dm_quyet_dinh.Row);
            m_us = new US_DM_QUYET_DINH(m_v_us.dcID);
            this.Close();
        }
        private void set_define_events()
        {
            m_cmd_exit.Click += new EventHandler(m_cmd_exit_Click);
            m_cmd_insert.Click += new EventHandler(m_cmd_insert_Click);
            m_cmd_update.Click += new EventHandler(m_cmd_update_Click);
            m_cmd_delete.Click += new EventHandler(m_cmd_delete_Click);
            //m_cmd_view.Click += new EventHandler(m_cmd_view_Click);
            m_txt_tim_kiem.KeyDown += m_txt_tim_kiem_KeyDown;
            m_txt_tim_kiem.MouseClick+= m_txt_tim_kiem_MouseClick;
            m_txt_tim_kiem.Leave += m_txt_tim_kiem_Leave;
        }
        #endregion

        //
        //
        //		EVENT HANLDERS
        //
        //
        private void f600_v_dm_quyet_dinh_Load(object sender, System.EventArgs e)
        {
            try
            {
                set_initial_form_load();
                load_custom_source_2_m_txt_tim_kiem();
            }
            catch (Exception v_e)
            {
                CSystemLog_301.ExceptionHandle(v_e);
            }

        }

        private void m_cmd_exit_Click(object sender, EventArgs e)
        {
            try
            {
                this.Close();
            }
            catch (Exception v_e)
            {
                CSystemLog_301.ExceptionHandle(v_e);
            }
        }

        private void m_cmd_insert_Click(object sender, EventArgs e)
        {
            try
            {
                insert_v_dm_quyet_dinh();
            }
            catch (Exception v_e)
            {
                CSystemLog_301.ExceptionHandle(v_e);
            }
        }

        private void m_cmd_update_Click(object sender, EventArgs e)
        {
            try
            {
                update_v_dm_quyet_dinh();
            }
            catch (Exception v_e)
            {
                CSystemLog_301.ExceptionHandle(v_e);
            }
        }

        private void m_cmd_delete_Click(object sender, EventArgs e)
        {
            try
            {
                delete_v_dm_quyet_dinh();
            }
            catch (Exception v_e)
            {
                CSystemLog_301.ExceptionHandle(v_e);
            }
        }

        private void m_cmd_view_Click(object sender, EventArgs e)
        {
            try
            {
                view_v_dm_quyet_dinh();
            }
            catch (Exception v_e)
            {
                CSystemLog_301.ExceptionHandle(v_e);
            }
        }

        private void m_cmd_search_Click(object sender, EventArgs e)
        {
            
            try
            {
                load_data_2_grid();
            }
            catch (Exception v_e)
            {
                
                CSystemLog_301.ExceptionHandle(v_e);
            }
        }

        private void m_txt_tim_kiem_MouseClick(object sender, MouseEventArgs e)
        {
            try
            {
                set_search_format_after();
            }
            catch (Exception v_e)
            {
                CSystemLog_301.ExceptionHandle(v_e);
            }
        }
        private void m_txt_tim_kiem_Leave(object sender, EventArgs e)
        {
            try
            {
                set_search_format_before();
            }
            catch (Exception v_e)
            {
                CSystemLog_301.ExceptionHandle(v_e);
            }
        }
        private void m_txt_tim_kiem_KeyDown(object sender, KeyEventArgs e)
        {
            try
            {
                if (e.KeyData == Keys.Enter)
                {
                    load_data_2_grid();
                }
                else
                {
                    set_search_format_after();
                }
            }
            catch (Exception v_e)
            {
                CSystemLog_301.ExceptionHandle(v_e);
            }
        }
        private void m_grv_dm_quyet_dinh_KeyDown(object sender, KeyEventArgs e)
        {
            try
            {
                switch (e.KeyCode)
                {
                    case Keys.Enter:
                        if (m_grv_dm_quyet_dinh.Focused)
                        {
                            switch (m_e_form_mode)
                            {

                                case DataEntryFormMode.ViewDataState:
                                    update_v_dm_quyet_dinh();
                                    break;
                                case DataEntryFormMode.SelectDataState:
                                    select_data_2_us();
                                    break;

                            }
                        }
                        break;
                }
            }
            catch (Exception v_e)
            {
                CSystemLog_301.ExceptionHandle(v_e);
            }
        }

        private void m_cmd_chon_quyet_dinh_Click(object sender, EventArgs e)
        {
            try
            {
                select_data_2_us();
            }
            catch (Exception v_e)
            {
                CSystemLog_301.ExceptionHandle(v_e);
            }
        }





    }
}


