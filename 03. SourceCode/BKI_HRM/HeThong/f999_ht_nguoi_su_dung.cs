///************************************************
/// Generated by: TUND
/// Date: 03/04/2007 09:35:39
/// Goal: Create Form for HT_NGUOI_SU_DUNG
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
//using IP.Core.IPUserService;
using IP.Core.IPSystemAdmin;

using IP.Core.IPData.DBNames;
using BKI_HRM.US;
using IP.Core.IPUserService;



namespace BKI_HRM
{



    public class f999_ht_nguoi_su_dung : System.Windows.Forms.Form
    {
		internal System.Windows.Forms.Panel m_pnl_out_place_dm;
		private C1.Win.C1FlexGrid.C1FlexGrid m_fg;
		internal SIS.Controls.Button.SiSButton m_cmd_delete;
		internal SIS.Controls.Button.SiSButton m_cmd_update;
		internal SIS.Controls.Button.SiSButton m_cmd_insert;
		internal SIS.Controls.Button.SiSButton m_cmd_exit;
		private System.ComponentModel.IContainer components;

		public f999_ht_nguoi_su_dung() {
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
		protected override void Dispose( bool disposing ) {
			if( disposing ) {
				if(components != null) {
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
		private void InitializeComponent() {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(f999_ht_nguoi_su_dung));
            this.m_pnl_out_place_dm = new System.Windows.Forms.Panel();
            this.m_cmd_insert = new SIS.Controls.Button.SiSButton();
            this.m_cmd_update = new SIS.Controls.Button.SiSButton();
            this.m_cmd_delete = new SIS.Controls.Button.SiSButton();
            this.m_cmd_exit = new SIS.Controls.Button.SiSButton();
            this.m_fg = new C1.Win.C1FlexGrid.C1FlexGrid();
            this.m_pnl_out_place_dm.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.m_fg)).BeginInit();
            this.SuspendLayout();
            // 
            // m_pnl_out_place_dm
            // 
            this.m_pnl_out_place_dm.Controls.Add(this.m_cmd_insert);
            this.m_pnl_out_place_dm.Controls.Add(this.m_cmd_update);
            this.m_pnl_out_place_dm.Controls.Add(this.m_cmd_delete);
            this.m_pnl_out_place_dm.Controls.Add(this.m_cmd_exit);
            this.m_pnl_out_place_dm.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.m_pnl_out_place_dm.Location = new System.Drawing.Point(0, 502);
            this.m_pnl_out_place_dm.Name = "m_pnl_out_place_dm";
            this.m_pnl_out_place_dm.Padding = new System.Windows.Forms.Padding(4);
            this.m_pnl_out_place_dm.Size = new System.Drawing.Size(718, 36);
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
            this.m_cmd_insert.Location = new System.Drawing.Point(362, 4);
            this.m_cmd_insert.Name = "m_cmd_insert";
            this.m_cmd_insert.Size = new System.Drawing.Size(88, 28);
            this.m_cmd_insert.TabIndex = 12;
            this.m_cmd_insert.Text = "&Thêm";
            // 
            // m_cmd_update
            // 
            this.m_cmd_update.AdjustImageLocation = new System.Drawing.Point(0, 0);
            this.m_cmd_update.BtnShape = SIS.Controls.Button.emunType.BtnShape.Rectangle;
            this.m_cmd_update.BtnStyle = SIS.Controls.Button.emunType.XPStyle.Default;
            this.m_cmd_update.Dock = System.Windows.Forms.DockStyle.Right;
            this.m_cmd_update.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.m_cmd_update.ImageIndex = 3;
            this.m_cmd_update.Location = new System.Drawing.Point(450, 4);
            this.m_cmd_update.Name = "m_cmd_update";
            this.m_cmd_update.Size = new System.Drawing.Size(88, 28);
            this.m_cmd_update.TabIndex = 13;
            this.m_cmd_update.Text = "&Sửa";
            // 
            // m_cmd_delete
            // 
            this.m_cmd_delete.AdjustImageLocation = new System.Drawing.Point(0, 0);
            this.m_cmd_delete.BtnShape = SIS.Controls.Button.emunType.BtnShape.Rectangle;
            this.m_cmd_delete.BtnStyle = SIS.Controls.Button.emunType.XPStyle.Default;
            this.m_cmd_delete.Dock = System.Windows.Forms.DockStyle.Right;
            this.m_cmd_delete.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.m_cmd_delete.ImageIndex = 4;
            this.m_cmd_delete.Location = new System.Drawing.Point(538, 4);
            this.m_cmd_delete.Name = "m_cmd_delete";
            this.m_cmd_delete.Size = new System.Drawing.Size(88, 28);
            this.m_cmd_delete.TabIndex = 14;
            this.m_cmd_delete.Text = "&Xoá";
            // 
            // m_cmd_exit
            // 
            this.m_cmd_exit.AdjustImageLocation = new System.Drawing.Point(0, 0);
            this.m_cmd_exit.BtnShape = SIS.Controls.Button.emunType.BtnShape.Rectangle;
            this.m_cmd_exit.BtnStyle = SIS.Controls.Button.emunType.XPStyle.Default;
            this.m_cmd_exit.Dock = System.Windows.Forms.DockStyle.Right;
            this.m_cmd_exit.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.m_cmd_exit.ImageIndex = 11;
            this.m_cmd_exit.Location = new System.Drawing.Point(626, 4);
            this.m_cmd_exit.Name = "m_cmd_exit";
            this.m_cmd_exit.Size = new System.Drawing.Size(88, 28);
            this.m_cmd_exit.TabIndex = 11;
            this.m_cmd_exit.Text = "Trở về  (Esc)";
            // 
            // m_fg
            // 
            this.m_fg.ColumnInfo = resources.GetString("m_fg.ColumnInfo");
            this.m_fg.Dock = System.Windows.Forms.DockStyle.Fill;
            this.m_fg.Location = new System.Drawing.Point(0, 0);
            this.m_fg.Name = "m_fg";
            this.m_fg.Size = new System.Drawing.Size(718, 502);
            this.m_fg.Styles = new C1.Win.C1FlexGrid.CellStyleCollection(resources.GetString("m_fg.Styles"));
            this.m_fg.TabIndex = 20;
            // 
            // f999_ht_nguoi_su_dung
            // 
            this.AutoScaleBaseSize = new System.Drawing.Size(5, 13);
            this.ClientSize = new System.Drawing.Size(718, 538);
            this.Controls.Add(this.m_fg);
            this.Controls.Add(this.m_pnl_out_place_dm);
            this.Name = "f999_ht_nguoi_su_dung";
            this.Text = "F999 - Thong tin nguoi su dung";
            this.Load += new System.EventHandler(this.f999_ht_nguoi_su_dung_Load);
            this.m_pnl_out_place_dm.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.m_fg)).EndInit();
            this.ResumeLayout(false);

		}
		#endregion

		#region Public Interface
		public void display(){			
			this.ShowDialog();
		}
        public delegate void close_tab(bool ip_y_n);
        public close_tab close_tab_B;

		#endregion

		#region Data Structure
		private enum e_col_Number{
			TRANG_THAI = 5
				,NGUOI_TAO = 4
					 ,TEN = 2
						  ,TEN_TRUY_CAP = 1
							   ,BUILT_IN_YN = 6
									,NGAY_TAO = 3

		}			
		#endregion

		#region Members
		ITransferDataRow m_obj_trans;		
		DS_HT_NGUOI_SU_DUNG m_ds = new DS_HT_NGUOI_SU_DUNG();
		US_HT_NGUOI_SU_DUNG m_us = new US_HT_NGUOI_SU_DUNG();
		#endregion

		#region Private Methods
		private void format_controls(){
            CControlFormat.setFormStyle(this, new CAppContext_201());
			CControlFormat.setC1FlexFormat(m_fg);
			m_fg.Cols[(int)e_col_Number.TRANG_THAI].DataMap= get_mapping_col_trang_thai();
			set_define_events();
			m_fg.AllowEditing = false;
			this.KeyPreview = true;		
		}
		private void set_initial_form_load(){						
			m_obj_trans = get_trans_object(m_fg);
			load_data_2_grid();		
		}	
		private ITransferDataRow get_trans_object(C1.Win.C1FlexGrid.C1FlexGrid i_fg){
			Hashtable v_htb = new Hashtable();
			v_htb.Add(HT_NGUOI_SU_DUNG.TRANG_THAI, e_col_Number.TRANG_THAI);
			v_htb.Add(HT_NGUOI_SU_DUNG.NGUOI_TAO, e_col_Number.NGUOI_TAO);
			v_htb.Add(HT_NGUOI_SU_DUNG.TEN, e_col_Number.TEN);
			v_htb.Add(HT_NGUOI_SU_DUNG.TEN_TRUY_CAP, e_col_Number.TEN_TRUY_CAP);
			v_htb.Add(HT_NGUOI_SU_DUNG.BUILT_IN_YN, e_col_Number.BUILT_IN_YN);
			v_htb.Add(HT_NGUOI_SU_DUNG.NGAY_TAO, e_col_Number.NGAY_TAO);
									
			ITransferDataRow v_obj_trans = new CC1TransferDataRow(i_fg,v_htb,m_ds.HT_NGUOI_SU_DUNG.NewRow());
			return v_obj_trans;			
		}
		private Hashtable get_mapping_col_trang_thai(){
			Hashtable v_hst = new  Hashtable();
			v_hst.Add("0","Đang sử dụng");
			v_hst.Add("1","Đã đóng");
			return v_hst;
		}
		private void load_data_2_grid(){						
			m_ds = new DS_HT_NGUOI_SU_DUNG();			
			m_us.FillDataset(m_ds);
			m_fg.Redraw = false;
			CGridUtils.Dataset2C1Grid(m_ds, m_fg, m_obj_trans);
			m_fg.Redraw = true;
		}
		private void grid2us_object(US_HT_NGUOI_SU_DUNG i_us
			, int i_grid_row) {
			DataRow v_dr;
			v_dr = (DataRow) m_fg.Rows[i_grid_row].UserData;			
			m_obj_trans.GridRow2DataRow(i_grid_row, v_dr);	
			i_us.DataRow2Me(v_dr);
		}

	
		private void us_object2grid(US_HT_NGUOI_SU_DUNG i_us
			, int i_grid_row) {
			DataRow v_dr = (DataRow) m_fg.Rows[i_grid_row].UserData;
			i_us.Me2DataRow(v_dr);			
		}


		private void insert_ht_nguoi_su_dung(){			
			f998_ht_nguoi_su_dung_de v_fDE = new  f998_ht_nguoi_su_dung_de();								
			v_fDE.insert_new_user();
			load_data_2_grid();
		}

		private void update_ht_nguoi_su_dung(){			
			if (!CGridUtils.IsThere_Any_NonFixed_Row(m_fg)) return;
			if (!CGridUtils.isValid_NonFixed_RowIndex(m_fg, m_fg.Row)) return;			
			grid2us_object(m_us, m_fg.Row);
			f998_ht_nguoi_su_dung_de v_fDE = new f998_ht_nguoi_su_dung_de();
			v_fDE.update_new_user(m_us);
			load_data_2_grid();
		}
				
		private void delete_ht_nguoi_su_dung(){
			if (!CGridUtils.IsThere_Any_NonFixed_Row(m_fg)) return;
			if (!CGridUtils.isValid_NonFixed_RowIndex(m_fg, m_fg.Row)) return;
			if (BaseMessages.askUser_DataCouldBeDeleted(8) != BaseMessages.IsDataCouldBeDeleted.CouldBeDeleted)  return;
			US_HT_NGUOI_SU_DUNG v_us = new US_HT_NGUOI_SU_DUNG();
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

		
		private void set_define_events(){
			m_cmd_exit.Click += new EventHandler(m_cmd_exit_Click);
			m_cmd_insert.Click += new EventHandler(m_cmd_insert_Click);
			m_cmd_update.Click += new EventHandler(m_cmd_update_Click);
			m_cmd_delete.Click += new EventHandler(m_cmd_delete_Click);
			this.KeyDown +=new KeyEventHandler(f999_ht_nguoi_su_dung_KeyDown);
			m_fg.DoubleClick += new EventHandler(m_fg_DoubleClick);
		}

		#endregion

		//
		//
		//		EVENT HANLDERS
		//
		//
		private void f999_ht_nguoi_su_dung_Load(object sender, System.EventArgs e) {
			try{
				set_initial_form_load();
			}
			catch (Exception v_e){
				CSystemLog_301.ExceptionHandle(v_e);
			}
		
		}

		private void m_cmd_exit_Click(object sender, EventArgs e) {
			try{
                close_tab_B(true);
			}
			catch (Exception v_e){
				CSystemLog_301.ExceptionHandle(v_e);
			}
		}

		private void m_cmd_insert_Click(object sender, EventArgs e) {
			try{
				insert_ht_nguoi_su_dung();
			}
			catch (Exception v_e){
				CSystemLog_301.ExceptionHandle(v_e);
			}
		}

		private void m_cmd_update_Click(object sender, EventArgs e) {
			try{
				update_ht_nguoi_su_dung();
			}
			catch (Exception v_e){
				CSystemLog_301.ExceptionHandle(v_e);
			}
		}

		private void m_cmd_delete_Click(object sender, EventArgs e) {
			try{
				delete_ht_nguoi_su_dung();
			}
			catch (Exception v_e){
				CSystemLog_301.ExceptionHandle(v_e);
			}
		}	

		private void f999_ht_nguoi_su_dung_KeyDown(object sender, KeyEventArgs e) {
			try {
				switch (e.KeyCode){
					case Keys.Escape:
                        close_tab_B(true);
						break;
					case Keys.Enter:
						update_ht_nguoi_su_dung();
						break;
				}
			}
			catch (Exception v_e) {
				CSystemLog_301.ExceptionHandle(v_e);
			}
		}

		private void m_fg_DoubleClick(object sender, EventArgs e) {
			try{
				update_ht_nguoi_su_dung();
			}
			catch (Exception v_e) {
				CSystemLog_301.ExceptionHandle(v_e);
			}
		}
	}
}

