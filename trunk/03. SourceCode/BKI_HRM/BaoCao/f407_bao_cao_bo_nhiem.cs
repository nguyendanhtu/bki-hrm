///************************************************
/// Generated by: AnhLT
/// Date: 07/05/2014 04:49:04
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
using IP.Core.IPExcelReport;

using BKI_HRM.US;
using BKI_HRM.DS;
using BKI_HRM.DS.CDBNames;

using C1.Win.C1FlexGrid;

namespace BKI_HRM
{



	public class f407_bao_cao_bo_nhiem : System.Windows.Forms.Form
	{
		internal System.Windows.Forms.ImageList ImageList;
        internal System.Windows.Forms.Panel m_pnl_out_place_dm;
        internal SIS.Controls.Button.SiSButton m_cmd_exit;
        private Label m_lbl_thoidiem;
        private DateTimePicker m_dtp_thoidiem;
        internal SIS.Controls.Button.SiSButton m_cmd_search;
        private GroupBox groupBox1;
        private RadioButton m_rdb_koqd;
        private RadioButton m_rdb_coqd;
        private TextBox m_txt_tim_kiem;
        private GroupBox groupBox2;
        private RadioButton m_rdb_nhom;
        private RadioButton m_rdb_ko_nhom;
        internal SIS.Controls.Button.SiSButton m_cmd_xuat_excel;
        private Label m_lbl_soluongns;
        private Label label1;
        private Label m_lbl_phim_tat;
        private Panel panel1;
        private C1FlexGrid m_fg;
		private System.ComponentModel.IContainer components;

		public f407_bao_cao_bo_nhiem()
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(f407_bao_cao_bo_nhiem));
            this.ImageList = new System.Windows.Forms.ImageList(this.components);
            this.m_pnl_out_place_dm = new System.Windows.Forms.Panel();
            this.m_lbl_phim_tat = new System.Windows.Forms.Label();
            this.m_cmd_xuat_excel = new SIS.Controls.Button.SiSButton();
            this.m_cmd_exit = new SIS.Controls.Button.SiSButton();
            this.m_lbl_thoidiem = new System.Windows.Forms.Label();
            this.m_dtp_thoidiem = new System.Windows.Forms.DateTimePicker();
            this.m_cmd_search = new SIS.Controls.Button.SiSButton();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.m_rdb_koqd = new System.Windows.Forms.RadioButton();
            this.m_rdb_coqd = new System.Windows.Forms.RadioButton();
            this.m_txt_tim_kiem = new System.Windows.Forms.TextBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.m_rdb_nhom = new System.Windows.Forms.RadioButton();
            this.m_rdb_ko_nhom = new System.Windows.Forms.RadioButton();
            this.m_lbl_soluongns = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.m_fg = new C1.Win.C1FlexGrid.C1FlexGrid();
            this.m_pnl_out_place_dm.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.panel1.SuspendLayout();
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
            this.m_pnl_out_place_dm.Controls.Add(this.m_lbl_phim_tat);
            this.m_pnl_out_place_dm.Controls.Add(this.m_cmd_xuat_excel);
            this.m_pnl_out_place_dm.Controls.Add(this.m_cmd_exit);
            this.m_pnl_out_place_dm.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.m_pnl_out_place_dm.Location = new System.Drawing.Point(0, 586);
            this.m_pnl_out_place_dm.Name = "m_pnl_out_place_dm";
            this.m_pnl_out_place_dm.Padding = new System.Windows.Forms.Padding(4);
            this.m_pnl_out_place_dm.Size = new System.Drawing.Size(1268, 36);
            this.m_pnl_out_place_dm.TabIndex = 19;
            // 
            // m_lbl_phim_tat
            // 
            this.m_lbl_phim_tat.AutoSize = true;
            this.m_lbl_phim_tat.Location = new System.Drawing.Point(171, 12);
            this.m_lbl_phim_tat.Name = "m_lbl_phim_tat";
            this.m_lbl_phim_tat.Size = new System.Drawing.Size(206, 13);
            this.m_lbl_phim_tat.TabIndex = 1001;
            this.m_lbl_phim_tat.Text = "Phím tắt: F6_Mở rộng-Thu gọn danh sách";
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
            this.m_cmd_xuat_excel.TabIndex = 13;
            this.m_cmd_xuat_excel.Text = "Xuất Excel";
            this.m_cmd_xuat_excel.Click += new System.EventHandler(this.m_cmd_xuat_excel_Click);
            // 
            // m_cmd_exit
            // 
            this.m_cmd_exit.AdjustImageLocation = new System.Drawing.Point(0, 0);
            this.m_cmd_exit.BtnShape = SIS.Controls.Button.emunType.BtnShape.Rectangle;
            this.m_cmd_exit.BtnStyle = SIS.Controls.Button.emunType.XPStyle.Default;
            this.m_cmd_exit.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.m_cmd_exit.Dock = System.Windows.Forms.DockStyle.Right;
            this.m_cmd_exit.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.m_cmd_exit.ImageIndex = 12;
            this.m_cmd_exit.ImageList = this.ImageList;
            this.m_cmd_exit.Location = new System.Drawing.Point(1176, 4);
            this.m_cmd_exit.Name = "m_cmd_exit";
            this.m_cmd_exit.Size = new System.Drawing.Size(88, 28);
            this.m_cmd_exit.TabIndex = 11;
            this.m_cmd_exit.Text = "Thoát (Esc)";
            // 
            // m_lbl_thoidiem
            // 
            this.m_lbl_thoidiem.AutoSize = true;
            this.m_lbl_thoidiem.Location = new System.Drawing.Point(746, 11);
            this.m_lbl_thoidiem.Name = "m_lbl_thoidiem";
            this.m_lbl_thoidiem.Size = new System.Drawing.Size(41, 13);
            this.m_lbl_thoidiem.TabIndex = 38;
            this.m_lbl_thoidiem.Text = "Tháng:";
            // 
            // m_dtp_thoidiem
            // 
            this.m_dtp_thoidiem.CustomFormat = "MM/yyyy";
            this.m_dtp_thoidiem.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.m_dtp_thoidiem.Location = new System.Drawing.Point(793, 8);
            this.m_dtp_thoidiem.Name = "m_dtp_thoidiem";
            this.m_dtp_thoidiem.Size = new System.Drawing.Size(85, 20);
            this.m_dtp_thoidiem.TabIndex = 37;
            this.m_dtp_thoidiem.ValueChanged += new System.EventHandler(this.m_dtp_thoidiem_ValueChanged);
            // 
            // m_cmd_search
            // 
            this.m_cmd_search.AdjustImageLocation = new System.Drawing.Point(0, 0);
            this.m_cmd_search.BtnShape = SIS.Controls.Button.emunType.BtnShape.Rectangle;
            this.m_cmd_search.BtnStyle = SIS.Controls.Button.emunType.XPStyle.Default;
            this.m_cmd_search.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.m_cmd_search.ImageIndex = 5;
            this.m_cmd_search.ImageList = this.ImageList;
            this.m_cmd_search.Location = new System.Drawing.Point(652, 3);
            this.m_cmd_search.Name = "m_cmd_search";
            this.m_cmd_search.Size = new System.Drawing.Size(88, 28);
            this.m_cmd_search.TabIndex = 36;
            this.m_cmd_search.Text = "Tìm kiếm";
            this.m_cmd_search.Click += new System.EventHandler(this.m_cmd_search_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.m_rdb_koqd);
            this.groupBox1.Controls.Add(this.m_rdb_coqd);
            this.groupBox1.Location = new System.Drawing.Point(884, 3);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(200, 74);
            this.groupBox1.TabIndex = 39;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Lựa chọn:";
            // 
            // m_rdb_koqd
            // 
            this.m_rdb_koqd.AutoSize = true;
            this.m_rdb_koqd.Location = new System.Drawing.Point(7, 44);
            this.m_rdb_koqd.Name = "m_rdb_koqd";
            this.m_rdb_koqd.Size = new System.Drawing.Size(155, 17);
            this.m_rdb_koqd.TabIndex = 1;
            this.m_rdb_koqd.Text = "Bổ nhiệm không quyết định";
            this.m_rdb_koqd.UseVisualStyleBackColor = true;
            this.m_rdb_koqd.CheckedChanged += new System.EventHandler(this.m_rdb_koqd_CheckedChanged);
            // 
            // m_rdb_coqd
            // 
            this.m_rdb_coqd.AutoSize = true;
            this.m_rdb_coqd.Checked = true;
            this.m_rdb_coqd.Location = new System.Drawing.Point(7, 20);
            this.m_rdb_coqd.Name = "m_rdb_coqd";
            this.m_rdb_coqd.Size = new System.Drawing.Size(137, 17);
            this.m_rdb_coqd.TabIndex = 0;
            this.m_rdb_coqd.TabStop = true;
            this.m_rdb_coqd.Text = "Bổ nhiệm có quyết định";
            this.m_rdb_coqd.UseVisualStyleBackColor = true;
            this.m_rdb_coqd.CheckedChanged += new System.EventHandler(this.m_rdb_coqd_CheckedChanged);
            // 
            // m_txt_tim_kiem
            // 
            this.m_txt_tim_kiem.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.m_txt_tim_kiem.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.CustomSource;
            this.m_txt_tim_kiem.Location = new System.Drawing.Point(235, 8);
            this.m_txt_tim_kiem.Name = "m_txt_tim_kiem";
            this.m_txt_tim_kiem.Size = new System.Drawing.Size(411, 20);
            this.m_txt_tim_kiem.TabIndex = 2;
            this.m_txt_tim_kiem.MouseClick += new System.Windows.Forms.MouseEventHandler(this.m_txt_tim_kiem_MouseClick);
            this.m_txt_tim_kiem.KeyDown += new System.Windows.Forms.KeyEventHandler(this.m_txt_tim_kiem_KeyDown);
            this.m_txt_tim_kiem.Leave += new System.EventHandler(this.m_txt_tim_kiem_Leave);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.m_rdb_nhom);
            this.groupBox2.Controls.Add(this.m_rdb_ko_nhom);
            this.groupBox2.Location = new System.Drawing.Point(7, 3);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(222, 74);
            this.groupBox2.TabIndex = 41;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Hiển thị:";
            // 
            // m_rdb_nhom
            // 
            this.m_rdb_nhom.AutoSize = true;
            this.m_rdb_nhom.Location = new System.Drawing.Point(21, 44);
            this.m_rdb_nhom.Name = "m_rdb_nhom";
            this.m_rdb_nhom.Size = new System.Drawing.Size(169, 17);
            this.m_rdb_nhom.TabIndex = 1;
            this.m_rdb_nhom.Text = "Nhóm theo địa bàn, mã đơn vị";
            this.m_rdb_nhom.UseVisualStyleBackColor = true;
            this.m_rdb_nhom.CheckedChanged += new System.EventHandler(this.m_rdb_nhom_CheckedChanged);
            // 
            // m_rdb_ko_nhom
            // 
            this.m_rdb_ko_nhom.AutoSize = true;
            this.m_rdb_ko_nhom.Checked = true;
            this.m_rdb_ko_nhom.Location = new System.Drawing.Point(21, 20);
            this.m_rdb_ko_nhom.Name = "m_rdb_ko_nhom";
            this.m_rdb_ko_nhom.Size = new System.Drawing.Size(85, 17);
            this.m_rdb_ko_nhom.TabIndex = 0;
            this.m_rdb_ko_nhom.TabStop = true;
            this.m_rdb_ko_nhom.Text = "Không nhóm";
            this.m_rdb_ko_nhom.UseVisualStyleBackColor = true;
            // 
            // m_lbl_soluongns
            // 
            this.m_lbl_soluongns.AutoSize = true;
            this.m_lbl_soluongns.Location = new System.Drawing.Point(774, 64);
            this.m_lbl_soluongns.Name = "m_lbl_soluongns";
            this.m_lbl_soluongns.Size = new System.Drawing.Size(35, 13);
            this.m_lbl_soluongns.TabIndex = 43;
            this.m_lbl_soluongns.Text = "label2";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(675, 64);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(93, 13);
            this.label1.TabIndex = 42;
            this.label1.Text = "Số lượng nhân sự:";
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.groupBox2);
            this.panel1.Controls.Add(this.m_lbl_soluongns);
            this.panel1.Controls.Add(this.m_cmd_search);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.m_dtp_thoidiem);
            this.panel1.Controls.Add(this.m_lbl_thoidiem);
            this.panel1.Controls.Add(this.m_txt_tim_kiem);
            this.panel1.Controls.Add(this.groupBox1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1268, 86);
            this.panel1.TabIndex = 44;
            // 
            // m_fg
            // 
            this.m_fg.ColumnInfo = resources.GetString("m_fg.ColumnInfo");
            this.m_fg.Dock = System.Windows.Forms.DockStyle.Fill;
            this.m_fg.Location = new System.Drawing.Point(0, 86);
            this.m_fg.Name = "m_fg";
            this.m_fg.Size = new System.Drawing.Size(1268, 500);
            this.m_fg.Styles = new C1.Win.C1FlexGrid.CellStyleCollection(resources.GetString("m_fg.Styles"));
            this.m_fg.TabIndex = 45;
            // 
            // f407_bao_cao_bo_nhiem
            // 
            this.AutoScaleBaseSize = new System.Drawing.Size(5, 13);
            this.CancelButton = this.m_cmd_exit;
            this.ClientSize = new System.Drawing.Size(1268, 622);
            this.Controls.Add(this.m_fg);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.m_pnl_out_place_dm);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "f407_bao_cao_bo_nhiem";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "F407 - Báo cáo bổ nhiệm";
            this.Load += new System.EventHandler(this.f407_bao_cao_bo_nhiem_Load);
            this.m_pnl_out_place_dm.ResumeLayout(false);
            this.m_pnl_out_place_dm.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
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
			LOAI_DON_VI = 10
,TEN_DON_VI = 3
,MA_NV = 4
,NGAY_KET_THUC = 16
,NGAY_BAT_DAU = 15
,CAP_DON_VI = 9
,TRANG_THAI_CV = 18
,LOAI_CV = 14
,MA_QUYET_DINH = 11
,DIA_BAN = 1
,TEN = 6
,NGAY_CO_HIEU_LUC = 12
,MA_DON_VI = 2
,HO_DEM = 5
,TY_LE_THAM_GIA = 19
,TEN_CV = 8
,NGAY_HET_HIEU_LUC = 13
,MA_CV = 7
,NGACH = 17

		}			
		#endregion

		#region Members
        Boolean m_form_mode = true;
        Decimal m_lua_chon = 0;
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
                        m_fg.Tree.Column = (int)e_col_Number.DIA_BAN;
                        m_fg.Tree.Style = TreeStyleFlags.SimpleLeaf;
			set_define_events();
			this.KeyPreview = true;		
		}
		private void set_initial_form_load(){						
			m_obj_trans = get_trans_object(m_fg);
            if (m_form_mode == true)
            {
                m_txt_tim_kiem.Text = "";
                load_data_2_grid();
                m_txt_tim_kiem.Text = "Nhập mã đơn vị";
            }
            else
                load_data_2_grid();
		}	
		private ITransferDataRow get_trans_object(C1.Win.C1FlexGrid.C1FlexGrid i_fg){
			Hashtable v_htb = new Hashtable();
			v_htb.Add(V_GD_QUA_TRINH_LAM_VIEC.LOAI_DON_VI, e_col_Number.LOAI_DON_VI);
			v_htb.Add(V_GD_QUA_TRINH_LAM_VIEC.TEN_DON_VI, e_col_Number.TEN_DON_VI);
			v_htb.Add(V_GD_QUA_TRINH_LAM_VIEC.MA_NV, e_col_Number.MA_NV);
			v_htb.Add(V_GD_QUA_TRINH_LAM_VIEC.NGAY_KET_THUC, e_col_Number.NGAY_KET_THUC);
			v_htb.Add(V_GD_QUA_TRINH_LAM_VIEC.NGAY_BAT_DAU, e_col_Number.NGAY_BAT_DAU);
			v_htb.Add(V_GD_QUA_TRINH_LAM_VIEC.CAP_DON_VI, e_col_Number.CAP_DON_VI);
			v_htb.Add(V_GD_QUA_TRINH_LAM_VIEC.TRANG_THAI_CV, e_col_Number.TRANG_THAI_CV);
			v_htb.Add(V_GD_QUA_TRINH_LAM_VIEC.LOAI_CV, e_col_Number.LOAI_CV);
			v_htb.Add(V_GD_QUA_TRINH_LAM_VIEC.MA_QUYET_DINH, e_col_Number.MA_QUYET_DINH);
			v_htb.Add(V_GD_QUA_TRINH_LAM_VIEC.DIA_BAN, e_col_Number.DIA_BAN);
			v_htb.Add(V_GD_QUA_TRINH_LAM_VIEC.TEN, e_col_Number.TEN);
			v_htb.Add(V_GD_QUA_TRINH_LAM_VIEC.NGAY_CO_HIEU_LUC, e_col_Number.NGAY_CO_HIEU_LUC);
			v_htb.Add(V_GD_QUA_TRINH_LAM_VIEC.MA_DON_VI, e_col_Number.MA_DON_VI);
			v_htb.Add(V_GD_QUA_TRINH_LAM_VIEC.HO_DEM, e_col_Number.HO_DEM);
			v_htb.Add(V_GD_QUA_TRINH_LAM_VIEC.TY_LE_THAM_GIA, e_col_Number.TY_LE_THAM_GIA);
			v_htb.Add(V_GD_QUA_TRINH_LAM_VIEC.TEN_CV, e_col_Number.TEN_CV);
			v_htb.Add(V_GD_QUA_TRINH_LAM_VIEC.NGAY_HET_HIEU_LUC, e_col_Number.NGAY_HET_HIEU_LUC);
			v_htb.Add(V_GD_QUA_TRINH_LAM_VIEC.MA_CV, e_col_Number.MA_CV);
			v_htb.Add(V_GD_QUA_TRINH_LAM_VIEC.NGACH, e_col_Number.NGACH);
									
			ITransferDataRow v_obj_trans = new CC1TransferDataRow(i_fg,v_htb,m_ds.V_GD_QUA_TRINH_LAM_VIEC.NewRow());
			return v_obj_trans;			
		}
		private void load_data_2_grid(){						
			m_ds = new DS_V_GD_QUA_TRINH_LAM_VIEC();
            m_us.FillDatasetBonhiem(m_ds,m_txt_tim_kiem.Text.Trim(),m_dtp_thoidiem.Value,m_lua_chon,CAppContext_201.getCurrentIDPhapnhan());
			m_fg.Redraw = false;
			CGridUtils.Dataset2C1Grid(m_ds, m_fg, m_obj_trans);
            if (m_rdb_nhom.Checked == true)
            {
                m_fg.Subtotal(AggregateEnum.Count
                 , 0
                 , (int)e_col_Number.DIA_BAN    // Group theo cột này
                 , (int)e_col_Number.MA_NV         // Subtotal theo cột này
                 , "{0}"
                 );
                m_fg.Subtotal(AggregateEnum.Count
                  , 1
                  , (int)e_col_Number.MA_DON_VI    // Group theo cột này
                  , (int)e_col_Number.MA_NV         // Subtotal theo cột này
                  , "{0}"
                  );
            }
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
        private void load_custom_source_2_m_txt_tim_kiem()
        {
            m_us.FillDataset(m_ds,"WHERE ID_PHAP_NHAN =" + CAppContext_201.getCurrentIDPhapnhan().ToString());
            int count = m_ds.Tables["V_GD_QUA_TRINH_LAM_VIEC"].Rows.Count;
            AutoCompleteStringCollection v_acsc_search = new AutoCompleteStringCollection();
            foreach (DataRow dr in m_ds.V_GD_QUA_TRINH_LAM_VIEC)
            {
                v_acsc_search.Add(dr[V_GD_QUA_TRINH_LAM_VIEC.MA_DON_VI].ToString());
                v_acsc_search.Add(dr[V_GD_QUA_TRINH_LAM_VIEC.TEN_DON_VI].ToString());
                //v_acsc_search.Add(dr[V_GD_QUA_TRINH_LAM_VIEC.MA_CV].ToString());
            }
            m_txt_tim_kiem.AutoCompleteCustomSource = v_acsc_search;
        }

        public void display_for_so_luong_bn(String v_str_ma_dv)
        {
            m_form_mode = false;
            m_txt_tim_kiem.Text = v_str_ma_dv;
            this.ShowDialog();
        }
        private void export_2_excel()
        {
            CExcelReport v_obj_excel_rpt = new CExcelReport("f407_bao_cao_danh_sach_bo_nhiem.xlsx", 3, 2);
            v_obj_excel_rpt.AddFindAndReplaceItem("<thoi_diem>", m_dtp_thoidiem.Value.Month);
            v_obj_excel_rpt.FindAndReplace(false);
            v_obj_excel_rpt.Export2ExcelWithoutFixedRows(m_fg, 1, m_fg.Cols.Count - 1, true);
        }
		private void set_define_events(){
			m_cmd_exit.Click += new EventHandler(m_cmd_exit_Click);
			
		}
		#endregion

//
		//
		//		EVENT HANLDERS
		//
		//
		private void f407_bao_cao_bo_nhiem_Load(object sender, System.EventArgs e) {
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
                close_tab_B(true);
			}
			catch (Exception v_e){
				CSystemLog_301.ExceptionHandle(v_e);
			}
        }

        private void m_rdb_coqd_CheckedChanged(object sender, EventArgs e)
        {
            try
            {
                if (m_rdb_coqd.Checked)
                    m_lua_chon = 0;
                else
                    m_lua_chon = 1;
                if (m_txt_tim_kiem.Text.Trim() == "Nhập mã đơn vị")
                {
                    m_txt_tim_kiem.Text = "";
                    load_data_2_grid();
                    m_txt_tim_kiem.Text = "Nhập mã đơn vị";
                }
                else
                    load_data_2_grid();
            }
            catch (Exception v_e)
            {
                CSystemLog_301.ExceptionHandle(v_e);
            }
        }

        private void m_rdb_koqd_CheckedChanged(object sender, EventArgs e)
        {
            try
            {
                    //load_data_2_grid();
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
                if (m_txt_tim_kiem.Text.Trim() == "Nhập mã đơn vị")
                {
                    m_txt_tim_kiem.Text = "";
                    load_data_2_grid();
                    m_txt_tim_kiem.Text = "Nhập mã đơn vị";
                }
                else
                    load_data_2_grid();
            }
            catch (Exception v_e)
            {
                CSystemLog_301.ExceptionHandle(v_e);
            }
        }

        private void m_dtp_thoidiem_ValueChanged(object sender, EventArgs e)
        {
            try
            {
                if (m_txt_tim_kiem.Text.Trim() == "Nhập mã đơn vị")
                {
                    m_txt_tim_kiem.Text = "";
                    load_data_2_grid();
                    m_txt_tim_kiem.Text = "Nhập mã đơn vị";
                }
                else
                    load_data_2_grid();

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
                    m_txt_tim_kiem.Text = "Nhập mã đơn vị";
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
            }
            catch (Exception v_e)
            {
                CSystemLog_301.ExceptionHandle(v_e);
            }
        }

        private void m_rdb_nhom_CheckedChanged(object sender, EventArgs e)
        {
            try
            {
                if (m_txt_tim_kiem.Text.Trim() == "Nhập mã đơn vị")
                {
                    m_txt_tim_kiem.Text = "";
                    load_data_2_grid();
                    m_txt_tim_kiem.Text = "Nhập mã đơn vị";
                }
                else
                    load_data_2_grid();
            }
            catch (Exception v_e)
            {
                CSystemLog_301.ExceptionHandle(v_e);
            }
        }

        private void m_cmd_xuat_excel_Click(object sender, EventArgs e)
        {
            try
            {
                export_2_excel();
            }
            catch (Exception v_e)
            {
                CSystemLog_301.ExceptionHandle(v_e);
            }
        }

	}
}

