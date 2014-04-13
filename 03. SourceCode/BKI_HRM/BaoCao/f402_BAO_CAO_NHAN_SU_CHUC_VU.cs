///************************************************
/// Generated by: AnhLT
/// Date: 04/03/2014 09:52:51
/// Goal: Create Form for V_GD_QUA_TRINH_LAM_VIEC
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

namespace BKI_HRM
{



	public class f402_BAO_CAO_NHAN_SU_CHUC_VU : System.Windows.Forms.Form
	{
		internal System.Windows.Forms.ImageList ImageList;
		internal System.Windows.Forms.Panel m_pnl_out_place_dm;
        private C1.Win.C1FlexGrid.C1FlexGrid m_fg;
        internal SIS.Controls.Button.SiSButton m_cmd_exit;
        private TextBox m_txt_tim_kiem;
        internal SIS.Controls.Button.SiSButton m_cmd_search;
        private DateTimePicker m_dtp_thoidiem;
        private Label m_lbl_thoidiem;
        private Label label1;
        private Label m_lbl_soluongns;
        internal SIS.Controls.Button.SiSButton m_cmd_xuat_excel;
		private System.ComponentModel.IContainer components;

		public f402_BAO_CAO_NHAN_SU_CHUC_VU()
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(f402_BAO_CAO_NHAN_SU_CHUC_VU));
            this.ImageList = new System.Windows.Forms.ImageList(this.components);
            this.m_pnl_out_place_dm = new System.Windows.Forms.Panel();
            this.m_cmd_xuat_excel = new SIS.Controls.Button.SiSButton();
            this.m_cmd_exit = new SIS.Controls.Button.SiSButton();
            this.m_fg = new C1.Win.C1FlexGrid.C1FlexGrid();
            this.m_txt_tim_kiem = new System.Windows.Forms.TextBox();
            this.m_cmd_search = new SIS.Controls.Button.SiSButton();
            this.m_dtp_thoidiem = new System.Windows.Forms.DateTimePicker();
            this.m_lbl_thoidiem = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.m_lbl_soluongns = new System.Windows.Forms.Label();
            this.m_pnl_out_place_dm.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.m_fg)).BeginInit();
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
            this.m_pnl_out_place_dm.Controls.Add(this.m_cmd_xuat_excel);
            this.m_pnl_out_place_dm.Controls.Add(this.m_cmd_exit);
            this.m_pnl_out_place_dm.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.m_pnl_out_place_dm.Location = new System.Drawing.Point(0, 495);
            this.m_pnl_out_place_dm.Name = "m_pnl_out_place_dm";
            this.m_pnl_out_place_dm.Padding = new System.Windows.Forms.Padding(4);
            this.m_pnl_out_place_dm.Size = new System.Drawing.Size(984, 36);
            this.m_pnl_out_place_dm.TabIndex = 19;
            // 
            // m_cmd_xuat_excel
            // 
            this.m_cmd_xuat_excel.AdjustImageLocation = new System.Drawing.Point(0, 0);
            this.m_cmd_xuat_excel.BtnShape = SIS.Controls.Button.emunType.BtnShape.Rectangle;
            this.m_cmd_xuat_excel.BtnStyle = SIS.Controls.Button.emunType.XPStyle.Default;
            this.m_cmd_xuat_excel.Dock = System.Windows.Forms.DockStyle.Left;
            this.m_cmd_xuat_excel.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.m_cmd_xuat_excel.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.m_cmd_xuat_excel.ImageIndex = 19;
            this.m_cmd_xuat_excel.ImageList = this.ImageList;
            this.m_cmd_xuat_excel.Location = new System.Drawing.Point(4, 4);
            this.m_cmd_xuat_excel.Name = "m_cmd_xuat_excel";
            this.m_cmd_xuat_excel.Size = new System.Drawing.Size(93, 28);
            this.m_cmd_xuat_excel.TabIndex = 4;
            this.m_cmd_xuat_excel.Text = "Xuất Excel";
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
            this.m_cmd_exit.Location = new System.Drawing.Point(892, 4);
            this.m_cmd_exit.Name = "m_cmd_exit";
            this.m_cmd_exit.Size = new System.Drawing.Size(88, 28);
            this.m_cmd_exit.TabIndex = 5;
            this.m_cmd_exit.Text = "Thoát (Esc)";
            // 
            // m_fg
            // 
            this.m_fg.ColumnInfo = resources.GetString("m_fg.ColumnInfo");
            this.m_fg.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.m_fg.Location = new System.Drawing.Point(0, 64);
            this.m_fg.Name = "m_fg";
            this.m_fg.Size = new System.Drawing.Size(984, 431);
            this.m_fg.Styles = new C1.Win.C1FlexGrid.CellStyleCollection(resources.GetString("m_fg.Styles"));
            this.m_fg.TabIndex = 20;
            // 
            // m_txt_tim_kiem
            // 
            this.m_txt_tim_kiem.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.m_txt_tim_kiem.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.CustomSource;
            this.m_txt_tim_kiem.Location = new System.Drawing.Point(142, 12);
            this.m_txt_tim_kiem.Name = "m_txt_tim_kiem";
            this.m_txt_tim_kiem.Size = new System.Drawing.Size(462, 20);
            this.m_txt_tim_kiem.TabIndex = 1;
            this.m_txt_tim_kiem.MouseClick += new System.Windows.Forms.MouseEventHandler(this.m_txt_tim_kiem_MouseClick);
            this.m_txt_tim_kiem.TextChanged += new System.EventHandler(this.m_txt_tim_kiem_TextChanged);
            this.m_txt_tim_kiem.KeyDown += new System.Windows.Forms.KeyEventHandler(this.m_txt_tim_kiem_KeyDown);
            this.m_txt_tim_kiem.Leave += new System.EventHandler(this.m_txt_tim_kiem_Leave);
            // 
            // m_cmd_search
            // 
            this.m_cmd_search.AdjustImageLocation = new System.Drawing.Point(0, 0);
            this.m_cmd_search.BtnShape = SIS.Controls.Button.emunType.BtnShape.Rectangle;
            this.m_cmd_search.BtnStyle = SIS.Controls.Button.emunType.XPStyle.Default;
            this.m_cmd_search.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.m_cmd_search.ImageIndex = 5;
            this.m_cmd_search.ImageList = this.ImageList;
            this.m_cmd_search.Location = new System.Drawing.Point(610, 7);
            this.m_cmd_search.Name = "m_cmd_search";
            this.m_cmd_search.Size = new System.Drawing.Size(88, 28);
            this.m_cmd_search.TabIndex = 2;
            this.m_cmd_search.Text = "Tìm kiếm";
            this.m_cmd_search.Click += new System.EventHandler(this.m_cmd_search_Click);
            // 
            // m_dtp_thoidiem
            // 
            this.m_dtp_thoidiem.CustomFormat = "dd/MM/yyyy";
            this.m_dtp_thoidiem.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.m_dtp_thoidiem.Location = new System.Drawing.Point(778, 9);
            this.m_dtp_thoidiem.Name = "m_dtp_thoidiem";
            this.m_dtp_thoidiem.Size = new System.Drawing.Size(176, 20);
            this.m_dtp_thoidiem.TabIndex = 3;
            // 
            // m_lbl_thoidiem
            // 
            this.m_lbl_thoidiem.AutoSize = true;
            this.m_lbl_thoidiem.Location = new System.Drawing.Point(715, 15);
            this.m_lbl_thoidiem.Name = "m_lbl_thoidiem";
            this.m_lbl_thoidiem.Size = new System.Drawing.Size(57, 13);
            this.m_lbl_thoidiem.TabIndex = 34;
            this.m_lbl_thoidiem.Text = "Thời điểm:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(79, 42);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(93, 13);
            this.label1.TabIndex = 35;
            this.label1.Text = "Số lượng nhân sự:";
            // 
            // m_lbl_soluongns
            // 
            this.m_lbl_soluongns.AutoSize = true;
            this.m_lbl_soluongns.Location = new System.Drawing.Point(178, 42);
            this.m_lbl_soluongns.Name = "m_lbl_soluongns";
            this.m_lbl_soluongns.Size = new System.Drawing.Size(35, 13);
            this.m_lbl_soluongns.TabIndex = 36;
            this.m_lbl_soluongns.Text = "label2";
            // 
            // f402_BAO_CAO_NHAN_SU_CHUC_VU
            // 
            this.AutoScaleBaseSize = new System.Drawing.Size(5, 13);
            this.ClientSize = new System.Drawing.Size(984, 531);
            this.Controls.Add(this.m_lbl_soluongns);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.m_lbl_thoidiem);
            this.Controls.Add(this.m_dtp_thoidiem);
            this.Controls.Add(this.m_cmd_search);
            this.Controls.Add(this.m_txt_tim_kiem);
            this.Controls.Add(this.m_fg);
            this.Controls.Add(this.m_pnl_out_place_dm);
            this.MaximumSize = new System.Drawing.Size(1000, 570);
            this.MinimumSize = new System.Drawing.Size(1000, 570);
            this.Name = "f402_BAO_CAO_NHAN_SU_CHUC_VU";
            this.Text = "F402 - Báo cáo nhân sự theo chức vụ";
            this.Load += new System.EventHandler(this.f402_BAO_CAO_NHAN_SU_CHUC_VU_Load);
            this.m_pnl_out_place_dm.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.m_fg)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

		}
		#endregion

		#region Public Interface
		public void display(){			
			this.ShowDialog();
		}
		#endregion

		#region Data Structure
		private enum e_col_Number{
			CAP_DON_VI = 8
,NGAY_BAT_DAU = 12
,TEN_CV = 2
,TEN_DON_VI = 7
,MA_NV = 3
,MA_DON_VI = 6
,NGAY_KET_THUC = 13
,MA_CV = 1
,HO_DEM = 4
,LOAI_DON_VI = 9
,TEN = 5
,LOAI_CV = 11
,DIA_BAN = 10

		}			
		#endregion

		#region Members
		ITransferDataRow m_obj_trans;		
		DS_V_GD_QUA_TRINH_LAM_VIEC m_ds = new DS_V_GD_QUA_TRINH_LAM_VIEC();
		US_V_GD_QUA_TRINH_LAM_VIEC m_us = new US_V_GD_QUA_TRINH_LAM_VIEC();
		#endregion

		#region Private Methods
		private void format_controls(){
			CControlFormat.setFormStyle(this, new CAppContext_201());
			CControlFormat.setC1FlexFormat(m_fg);
			CGridUtils.AddSave_Excel_Handlers(m_fg);
            			CGridUtils.AddSearch_Handlers(m_fg);
                        m_fg.Tree.Column = (int)e_col_Number.MA_CV;
                        m_fg.Tree.Style = C1.Win.C1FlexGrid.TreeStyleFlags.SimpleLeaf;
			set_define_events();
			this.KeyPreview = true;		
		}
		private void set_initial_form_load(){						
			m_obj_trans = get_trans_object(m_fg);
            m_txt_tim_kiem.Text = "";
			load_data_2_grid_search();
            m_txt_tim_kiem.Text = "Nhập mã chức vụ";
		}	
		private ITransferDataRow get_trans_object(C1.Win.C1FlexGrid.C1FlexGrid i_fg){
			Hashtable v_htb = new Hashtable();
			v_htb.Add(V_GD_QUA_TRINH_LAM_VIEC.CAP_DON_VI, e_col_Number.CAP_DON_VI);
			v_htb.Add(V_GD_QUA_TRINH_LAM_VIEC.NGAY_BAT_DAU, e_col_Number.NGAY_BAT_DAU);
			v_htb.Add(V_GD_QUA_TRINH_LAM_VIEC.TEN_CV, e_col_Number.TEN_CV);
			v_htb.Add(V_GD_QUA_TRINH_LAM_VIEC.TEN_DON_VI, e_col_Number.TEN_DON_VI);
			v_htb.Add(V_GD_QUA_TRINH_LAM_VIEC.MA_NV, e_col_Number.MA_NV);
			v_htb.Add(V_GD_QUA_TRINH_LAM_VIEC.MA_DON_VI, e_col_Number.MA_DON_VI);
			v_htb.Add(V_GD_QUA_TRINH_LAM_VIEC.NGAY_KET_THUC, e_col_Number.NGAY_KET_THUC);
			v_htb.Add(V_GD_QUA_TRINH_LAM_VIEC.MA_CV, e_col_Number.MA_CV);
			v_htb.Add(V_GD_QUA_TRINH_LAM_VIEC.HO_DEM, e_col_Number.HO_DEM);
			v_htb.Add(V_GD_QUA_TRINH_LAM_VIEC.LOAI_DON_VI, e_col_Number.LOAI_DON_VI);
			v_htb.Add(V_GD_QUA_TRINH_LAM_VIEC.TEN, e_col_Number.TEN);
			v_htb.Add(V_GD_QUA_TRINH_LAM_VIEC.LOAI_CV, e_col_Number.LOAI_CV);
			v_htb.Add(V_GD_QUA_TRINH_LAM_VIEC.DIA_BAN, e_col_Number.DIA_BAN);
									
			ITransferDataRow v_obj_trans = new CC1TransferDataRow(i_fg,v_htb,m_ds.V_GD_QUA_TRINH_LAM_VIEC.NewRow());
			return v_obj_trans;			
		}
		private void load_data_2_grid(){						
			m_ds = new DS_V_GD_QUA_TRINH_LAM_VIEC();			
			m_us.FillDataset(m_ds);
			m_fg.Redraw = false;
			CGridUtils.Dataset2C1Grid(m_ds, m_fg, m_obj_trans);
            m_fg.Subtotal(C1.Win.C1FlexGrid.AggregateEnum.Count
              , 0
              , (int)e_col_Number.MA_CV
              , (int)e_col_Number.TEN_CV
              , "{0}"
              );
			m_fg.Redraw = true;
		}
        private void load_data_2_grid_search()
        {
            m_obj_trans = get_trans_object(m_fg);
            m_ds.Clear();
            m_us.FillDatasetSearchChucVuThoiDiem(m_ds, m_txt_tim_kiem.Text.Trim(), m_dtp_thoidiem.Value);
            m_fg.Redraw = false;
            CGridUtils.Dataset2C1Grid(m_ds, m_fg, m_obj_trans);
            m_fg.Subtotal(C1.Win.C1FlexGrid.AggregateEnum.Count
          , 0
          , (int)e_col_Number.MA_CV
          , (int)e_col_Number.TEN_CV
          , "{0}"
          );
            m_fg.Redraw = true;
            m_lbl_soluongns.Text = m_ds.V_GD_QUA_TRINH_LAM_VIEC.Count.ToString();
        }
		private void grid2us_object(US_V_GD_QUA_TRINH_LAM_VIEC i_us
			, int i_grid_row) {
			DataRow v_dr;
			v_dr = (DataRow) m_fg.Rows[i_grid_row].UserData;
			m_obj_trans.GridRow2DataRow(i_grid_row,v_dr);
			i_us.DataRow2Me(v_dr);
		}

	
		private void us_object2grid(US_V_GD_QUA_TRINH_LAM_VIEC i_us
			, int i_grid_row) {
			DataRow v_dr = (DataRow) m_fg.Rows[i_grid_row].UserData;
			i_us.Me2DataRow(v_dr);
			m_obj_trans.DataRow2GridRow(v_dr, i_grid_row);
		}


		private void view_v_gd_qua_trinh_lam_viec(){			
			if (!CGridUtils.IsThere_Any_NonFixed_Row(m_fg)) return;
			if (!CGridUtils.isValid_NonFixed_RowIndex(m_fg, m_fg.Row)) return;
			grid2us_object(m_us, m_fg.Row);
		//	f402_BAO_CAO_NHAN_SU_CHUC_VU_DE v_fDE = new f402_BAO_CAO_NHAN_SU_CHUC_VU_DE();			
		//	v_fDE.display(m_us);
		}
		private void set_define_events(){
			m_cmd_exit.Click += new EventHandler(m_cmd_exit_Click);

		}
        private void load_custom_source_2_m_txt_tim_kiem()
        {
            //m_v_us.FillDataset(m_v_ds);
            int count = m_ds.Tables["V_GD_QUA_TRINH_LAM_VIEC"].Rows.Count;
            AutoCompleteStringCollection v_acsc_search = new AutoCompleteStringCollection();
            foreach (DataRow dr in m_ds.V_GD_QUA_TRINH_LAM_VIEC)
            {
                v_acsc_search.Add(dr[V_GD_QUA_TRINH_LAM_VIEC.MA_CV].ToString());
                v_acsc_search.Add(dr[V_GD_QUA_TRINH_LAM_VIEC.MA_CV].ToString() + " - " + dr[V_GD_QUA_TRINH_LAM_VIEC.TEN_CV].ToString());
               
            }
            m_txt_tim_kiem.AutoCompleteCustomSource = v_acsc_search;
        }
		#endregion

//
		//
		//		EVENT HANLDERS
		//
		//
		private void f402_BAO_CAO_NHAN_SU_CHUC_VU_Load(object sender, System.EventArgs e) {
			try{
				set_initial_form_load();
                load_custom_source_2_m_txt_tim_kiem();
			}
			catch (Exception v_e){
				CSystemLog_301.ExceptionHandle(v_e);
			}
		
		}

		private void m_cmd_exit_Click(object sender, EventArgs e) {
			try{
				this.Close();
			}
			catch (Exception v_e){
				CSystemLog_301.ExceptionHandle(v_e);
			}
		}

        private void m_cmd_search_Click(object sender, EventArgs e)
        {
            try
            {
                if (m_txt_tim_kiem.Text.Trim() == "Nhập mã chức vụ")
                {
                    m_txt_tim_kiem.Text = "";
                    load_data_2_grid_search();
                    m_txt_tim_kiem.Text = "Nhập mã chức vụ";
                }
                else
                    load_data_2_grid_search();
            }
            catch (Exception v_e)
            {
                CSystemLog_301.ExceptionHandle(v_e);
            }
        }

        private void m_txt_tim_kiem_MouseClick(object sender, MouseEventArgs e)
        {
            m_txt_tim_kiem.Text = "";
        }

        private void m_txt_tim_kiem_Leave(object sender, EventArgs e)
        {
            try
            {
                if (m_txt_tim_kiem.Text.Trim() == "")
                    m_txt_tim_kiem.Text = "Nhập mã chức vụ";
            }
            catch (Exception v_e)
            {
                CSystemLog_301.ExceptionHandle(v_e);
            }
        }

        private void m_txt_tim_kiem_TextChanged(object sender, EventArgs e)
        {

        }

        private void m_txt_tim_kiem_KeyDown(object sender, KeyEventArgs e)
        {
            try
            {
                if (e.KeyData == Keys.Enter)
                {
                    load_data_2_grid_search();

                }
            }
            catch (Exception v_e)
            {
                CSystemLog_301.ExceptionHandle(v_e);
            }
        }		

	}
}

