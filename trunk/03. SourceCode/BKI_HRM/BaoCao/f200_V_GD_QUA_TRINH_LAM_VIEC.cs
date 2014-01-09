///************************************************
/// Generated by: AnhHT
/// Date: 09/01/2014 04:09:33
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

using BKI_HRM.DS;
using BKI_HRM.US;
using BKI_HRM.DS.CDBNames;

using C1.Win.C1FlexGrid;

namespace BKI_HRM
{



	public class f200_V_GD_QUA_TRINH_LAM_VIEC : System.Windows.Forms.Form
	{
		internal System.Windows.Forms.ImageList ImageList;
		internal System.Windows.Forms.Panel m_pnl_out_place_dm;
        private C1.Win.C1FlexGrid.C1FlexGrid m_fg;
        internal SIS.Controls.Button.SiSButton m_cmd_exit;
        private ComboBox m_cbo_trang_thai;
        private Label m_lbl_ma_nhan_vien;
        private Label m_lbl_trang_thai;
        private TextBox m_txt_ma_nhan_vien;
        private BindingSource m_bds_trang_thai;
		private System.ComponentModel.IContainer components;

		public f200_V_GD_QUA_TRINH_LAM_VIEC()
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(f200_V_GD_QUA_TRINH_LAM_VIEC));
            this.ImageList = new System.Windows.Forms.ImageList(this.components);
            this.m_pnl_out_place_dm = new System.Windows.Forms.Panel();
            this.m_cmd_exit = new SIS.Controls.Button.SiSButton();
            this.m_fg = new C1.Win.C1FlexGrid.C1FlexGrid();
            this.m_cbo_trang_thai = new System.Windows.Forms.ComboBox();
            this.m_lbl_ma_nhan_vien = new System.Windows.Forms.Label();
            this.m_lbl_trang_thai = new System.Windows.Forms.Label();
            this.m_txt_ma_nhan_vien = new System.Windows.Forms.TextBox();
            this.m_bds_trang_thai = new System.Windows.Forms.BindingSource(this.components);
            this.m_pnl_out_place_dm.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.m_fg)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.m_bds_trang_thai)).BeginInit();
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
            this.m_pnl_out_place_dm.Controls.Add(this.m_cmd_exit);
            this.m_pnl_out_place_dm.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.m_pnl_out_place_dm.Location = new System.Drawing.Point(0, 373);
            this.m_pnl_out_place_dm.Name = "m_pnl_out_place_dm";
            this.m_pnl_out_place_dm.Padding = new System.Windows.Forms.Padding(4);
            this.m_pnl_out_place_dm.Size = new System.Drawing.Size(828, 36);
            this.m_pnl_out_place_dm.TabIndex = 19;
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
            this.m_cmd_exit.Location = new System.Drawing.Point(736, 4);
            this.m_cmd_exit.Name = "m_cmd_exit";
            this.m_cmd_exit.Size = new System.Drawing.Size(88, 28);
            this.m_cmd_exit.TabIndex = 11;
            this.m_cmd_exit.Text = "Thoát (Esc)";
            // 
            // m_fg
            // 
            this.m_fg.ColumnInfo = resources.GetString("m_fg.ColumnInfo");
            this.m_fg.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.m_fg.Location = new System.Drawing.Point(0, 100);
            this.m_fg.Name = "m_fg";
            this.m_fg.Size = new System.Drawing.Size(828, 273);
            this.m_fg.Styles = new C1.Win.C1FlexGrid.CellStyleCollection(resources.GetString("m_fg.Styles"));
            this.m_fg.TabIndex = 20;
            // 
            // m_cbo_trang_thai
            // 
            this.m_cbo_trang_thai.FormattingEnabled = true;
            this.m_cbo_trang_thai.Location = new System.Drawing.Point(547, 39);
            this.m_cbo_trang_thai.Name = "m_cbo_trang_thai";
            this.m_cbo_trang_thai.Size = new System.Drawing.Size(158, 21);
            this.m_cbo_trang_thai.TabIndex = 21;
            // 
            // m_lbl_ma_nhan_vien
            // 
            this.m_lbl_ma_nhan_vien.AutoSize = true;
            this.m_lbl_ma_nhan_vien.Location = new System.Drawing.Point(53, 43);
            this.m_lbl_ma_nhan_vien.Name = "m_lbl_ma_nhan_vien";
            this.m_lbl_ma_nhan_vien.Size = new System.Drawing.Size(72, 13);
            this.m_lbl_ma_nhan_vien.TabIndex = 22;
            this.m_lbl_ma_nhan_vien.Text = "Mã nhân viên";
            // 
            // m_lbl_trang_thai
            // 
            this.m_lbl_trang_thai.AutoSize = true;
            this.m_lbl_trang_thai.Location = new System.Drawing.Point(479, 44);
            this.m_lbl_trang_thai.Name = "m_lbl_trang_thai";
            this.m_lbl_trang_thai.Size = new System.Drawing.Size(55, 13);
            this.m_lbl_trang_thai.TabIndex = 23;
            this.m_lbl_trang_thai.Text = "Trạng thái";
            // 
            // m_txt_ma_nhan_vien
            // 
            this.m_txt_ma_nhan_vien.Location = new System.Drawing.Point(139, 40);
            this.m_txt_ma_nhan_vien.Name = "m_txt_ma_nhan_vien";
            this.m_txt_ma_nhan_vien.Size = new System.Drawing.Size(133, 20);
            this.m_txt_ma_nhan_vien.TabIndex = 24;
            // 
            // f200_V_GD_QUA_TRINH_LAM_VIEC
            // 
            this.AutoScaleBaseSize = new System.Drawing.Size(5, 13);
            this.ClientSize = new System.Drawing.Size(828, 409);
            this.Controls.Add(this.m_txt_ma_nhan_vien);
            this.Controls.Add(this.m_lbl_trang_thai);
            this.Controls.Add(this.m_lbl_ma_nhan_vien);
            this.Controls.Add(this.m_cbo_trang_thai);
            this.Controls.Add(this.m_fg);
            this.Controls.Add(this.m_pnl_out_place_dm);
            this.Name = "f200_V_GD_QUA_TRINH_LAM_VIEC";
            this.Text = "f200_V_GD_QUA_TRINH_LAM_VIEC";
            this.Load += new System.EventHandler(this.f200_V_GD_QUA_TRINH_LAM_VIEC_Load);
            this.m_pnl_out_place_dm.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.m_fg)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.m_bds_trang_thai)).EndInit();
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
			TEN_CV = 5
,MA_NV = 1
,MA_DON_VI = 6
,Expr1 = 9
,MA_CV = 4
,HO_DEM = 2
,TEN = 3
,MA_QUYET_DINH = 7
,NGAY_CO_HIEU_LUC = 8

		}			
		#endregion

		#region Members
		ITransferDataRow m_obj_trans;		
		DS_V_GD_QUA_TRINH_LAM_VIEC m_ds = new DS_V_GD_QUA_TRINH_LAM_VIEC();
		US_V_GD_QUA_TRINH_LAM_VIEC m_us = new US_V_GD_QUA_TRINH_LAM_VIEC();
        BKI_HRM.DS.DS_CM_DM_TU_DIEN m_ds_dm_tu_dien = new BKI_HRM.DS.DS_CM_DM_TU_DIEN();
		#endregion

		#region Private Methods
		private void format_controls(){
			CControlFormat.setFormStyle(this);
			CControlFormat.setC1FlexFormat(m_fg);
			set_define_events();
			this.KeyPreview = true;		
		}
		private void set_initial_form_load(){						
			m_obj_trans = get_trans_object(m_fg);
			load_data_2_grid();		
		}	
		private ITransferDataRow get_trans_object(C1.Win.C1FlexGrid.C1FlexGrid i_fg){
			Hashtable v_htb = new Hashtable();
			v_htb.Add(V_GD_QUA_TRINH_LAM_VIEC.TEN_CV, e_col_Number.TEN_CV);
			v_htb.Add(V_GD_QUA_TRINH_LAM_VIEC.MA_NV, e_col_Number.MA_NV);
			v_htb.Add(V_GD_QUA_TRINH_LAM_VIEC.MA_DON_VI, e_col_Number.MA_DON_VI);
			v_htb.Add(V_GD_QUA_TRINH_LAM_VIEC.Expr1, e_col_Number.Expr1);
			v_htb.Add(V_GD_QUA_TRINH_LAM_VIEC.MA_CV, e_col_Number.MA_CV);
			v_htb.Add(V_GD_QUA_TRINH_LAM_VIEC.HO_DEM, e_col_Number.HO_DEM);
			v_htb.Add(V_GD_QUA_TRINH_LAM_VIEC.TEN, e_col_Number.TEN);
			v_htb.Add(V_GD_QUA_TRINH_LAM_VIEC.MA_QUYET_DINH, e_col_Number.MA_QUYET_DINH);
			v_htb.Add(V_GD_QUA_TRINH_LAM_VIEC.NGAY_CO_HIEU_LUC, e_col_Number.NGAY_CO_HIEU_LUC);
									
			ITransferDataRow v_obj_trans = new CC1TransferDataRow(i_fg,v_htb,m_ds.V_GD_QUA_TRINH_LAM_VIEC.NewRow());
			return v_obj_trans;			
		}
		private void load_data_2_grid(){						
			m_ds = new DS_V_GD_QUA_TRINH_LAM_VIEC();			
			m_us.FillDataset(m_ds);
			m_fg.Redraw = false;
			CGridUtils.Dataset2C1Grid(m_ds, m_fg, m_obj_trans);
			m_fg.Redraw = true;
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

        private void load_data_2_cbo_trang_thai(){
            m_bds_trang_thai.DataSource = m_ds_dm_tu_dien;
            m_cbo_trang_thai.DataSource = m_bds_trang_thai.DataSource;
            m_cbo_trang_thai.DisplayMember = "";
            m_cbo_trang_thai.ValueMember = "";
        }
		private void insert_v_gd_qua_trinh_lam_viec(){			
		//	f200_V_GD_QUA_TRINH_LAM_VIEC_DE v_fDE = new  f200_V_GD_QUA_TRINH_LAM_VIEC_DE();								
		//	v_fDE.display();
			load_data_2_grid();
		}

		private void update_v_gd_qua_trinh_lam_viec(){			
			if (!CGridUtils.IsThere_Any_NonFixed_Row(m_fg)) return;
			if (!CGridUtils.isValid_NonFixed_RowIndex(m_fg, m_fg.Row)) return;			
			grid2us_object(m_us, m_fg.Row);
		//	f200_V_GD_QUA_TRINH_LAM_VIEC_DE v_fDE = new f200_V_GD_QUA_TRINH_LAM_VIEC_DE();
		//	v_fDE.display(m_us);
			load_data_2_grid();
		}
				
		private void delete_v_gd_qua_trinh_lam_viec(){
			if (!CGridUtils.IsThere_Any_NonFixed_Row(m_fg)) return;
			if (!CGridUtils.isValid_NonFixed_RowIndex(m_fg, m_fg.Row)) return;
			if (BaseMessages.askUser_DataCouldBeDeleted(8) != BaseMessages.IsDataCouldBeDeleted.CouldBeDeleted)  return;
			US_V_GD_QUA_TRINH_LAM_VIEC v_us = new US_V_GD_QUA_TRINH_LAM_VIEC();
			grid2us_object(v_us, m_fg.Row);
			try {			
				v_us.BeginTransaction();    											
				v_us.Delete();                      								
				v_us.CommitTransaction();
				m_fg.Rows.Remove(m_fg.Row);				
			}
			catch (Exception v_e) {
				v_us.Rollback();
				CDBExceptionHandler v_objErrHandler = new CDBExceptionHandler(v_e,
					new CDBClientDBExceptionInterpret());
				v_objErrHandler.showErrorMessage();
			}
		}

		private void view_v_gd_qua_trinh_lam_viec(){			
			if (!CGridUtils.IsThere_Any_NonFixed_Row(m_fg)) return;
			if (!CGridUtils.isValid_NonFixed_RowIndex(m_fg, m_fg.Row)) return;
			grid2us_object(m_us, m_fg.Row);
		//	f200_V_GD_QUA_TRINH_LAM_VIEC_DE v_fDE = new f200_V_GD_QUA_TRINH_LAM_VIEC_DE();			
		//	v_fDE.display(m_us);
		}
		private void set_define_events(){
			m_cmd_exit.Click += new EventHandler(m_cmd_exit_Click);
//			m_cmd_insert.Click += new EventHandler(m_cmd_insert_Click);
	//		m_cmd_update.Click += new EventHandler(m_cmd_update_Click);
		//	m_cmd_delete.Click += new EventHandler(m_cmd_delete_Click);
			//m_cmd_view.Click += new EventHandler(m_cmd_view_Click);
		}
		#endregion

//
		//
		//		EVENT HANLDERS
		//
		//
		private void f200_V_GD_QUA_TRINH_LAM_VIEC_Load(object sender, System.EventArgs e) {
			try{
				set_initial_form_load();
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

		private void m_cmd_insert_Click(object sender, EventArgs e) {
			try{
				insert_v_gd_qua_trinh_lam_viec();
			}
			catch (Exception v_e){
				CSystemLog_301.ExceptionHandle(v_e);
			}
		}

		private void m_cmd_update_Click(object sender, EventArgs e) {
			try{
				update_v_gd_qua_trinh_lam_viec();
			}
			catch (Exception v_e){
				CSystemLog_301.ExceptionHandle(v_e);
			}
		}

		private void m_cmd_delete_Click(object sender, EventArgs e) {
			try{
				delete_v_gd_qua_trinh_lam_viec();
			}
			catch (Exception v_e){
				CSystemLog_301.ExceptionHandle(v_e);
			}
		}

		private void m_cmd_view_Click(object sender, EventArgs e) {
			try{
				view_v_gd_qua_trinh_lam_viec();
			}
			catch (Exception v_e){
				CSystemLog_301.ExceptionHandle(v_e);
			}
        }

	}
}

