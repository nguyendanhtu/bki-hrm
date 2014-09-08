///************************************************
/// Generated by: AnhLT
/// Date: 06/05/2014 04:13:20
/// Goal: Create Form for RPT_BO_NHIEM
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



	public class f406_bao_cao_bo_nhiem : System.Windows.Forms.Form
	{
		internal System.Windows.Forms.ImageList ImageList;
        internal System.Windows.Forms.Panel m_pnl_out_place_dm;
        internal SIS.Controls.Button.SiSButton m_cmd_exit;
        internal SIS.Controls.Button.SiSButton m_cmd_search;
        private TextBox m_txt_tim_kiem;
        internal SIS.Controls.Button.SiSButton m_cmd_xuat_excel;
        private Label m_lbl_thoidiem;
        private DateTimePicker m_dtp_thoidiem;
        private GroupBox groupBox1;
        private RadioButton m_rdb_nhom;
        private RadioButton m_rdb_ko_nhom;
        private Label m_lbl_phim_tat;
        private Panel panel1;
        private C1FlexGrid m_fg;
		private System.ComponentModel.IContainer components;

		public f406_bao_cao_bo_nhiem()
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(f406_bao_cao_bo_nhiem));
            this.ImageList = new System.Windows.Forms.ImageList(this.components);
            this.m_pnl_out_place_dm = new System.Windows.Forms.Panel();
            this.m_lbl_phim_tat = new System.Windows.Forms.Label();
            this.m_cmd_xuat_excel = new SIS.Controls.Button.SiSButton();
            this.m_cmd_exit = new SIS.Controls.Button.SiSButton();
            this.m_txt_tim_kiem = new System.Windows.Forms.TextBox();
            this.m_lbl_thoidiem = new System.Windows.Forms.Label();
            this.m_dtp_thoidiem = new System.Windows.Forms.DateTimePicker();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.m_rdb_nhom = new System.Windows.Forms.RadioButton();
            this.m_rdb_ko_nhom = new System.Windows.Forms.RadioButton();
            this.m_cmd_search = new SIS.Controls.Button.SiSButton();
            this.panel1 = new System.Windows.Forms.Panel();
            this.m_fg = new C1.Win.C1FlexGrid.C1FlexGrid();
            this.m_pnl_out_place_dm.SuspendLayout();
            this.groupBox1.SuspendLayout();
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
            this.m_pnl_out_place_dm.Location = new System.Drawing.Point(0, 625);
            this.m_pnl_out_place_dm.Name = "m_pnl_out_place_dm";
            this.m_pnl_out_place_dm.Padding = new System.Windows.Forms.Padding(4);
            this.m_pnl_out_place_dm.Size = new System.Drawing.Size(1284, 36);
            this.m_pnl_out_place_dm.TabIndex = 19;
            // 
            // m_lbl_phim_tat
            // 
            this.m_lbl_phim_tat.AutoSize = true;
            this.m_lbl_phim_tat.Location = new System.Drawing.Point(180, 12);
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
            this.m_cmd_xuat_excel.TabIndex = 12;
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
            this.m_cmd_exit.Location = new System.Drawing.Point(1192, 4);
            this.m_cmd_exit.Name = "m_cmd_exit";
            this.m_cmd_exit.Size = new System.Drawing.Size(88, 28);
            this.m_cmd_exit.TabIndex = 11;
            this.m_cmd_exit.Text = "Thoát (Esc)";
            // 
            // m_txt_tim_kiem
            // 
            this.m_txt_tim_kiem.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.m_txt_tim_kiem.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.CustomSource;
            this.m_txt_tim_kiem.Location = new System.Drawing.Point(262, 8);
            this.m_txt_tim_kiem.Name = "m_txt_tim_kiem";
            this.m_txt_tim_kiem.Size = new System.Drawing.Size(420, 20);
            this.m_txt_tim_kiem.TabIndex = 21;
            this.m_txt_tim_kiem.MouseClick += new System.Windows.Forms.MouseEventHandler(this.m_txt_tim_kiem_MouseClick);
            this.m_txt_tim_kiem.KeyDown += new System.Windows.Forms.KeyEventHandler(this.m_txt_tim_kiem_KeyDown);
            this.m_txt_tim_kiem.Leave += new System.EventHandler(this.m_txt_tim_kiem_Leave);
            // 
            // m_lbl_thoidiem
            // 
            this.m_lbl_thoidiem.AutoSize = true;
            this.m_lbl_thoidiem.Location = new System.Drawing.Point(782, 14);
            this.m_lbl_thoidiem.Name = "m_lbl_thoidiem";
            this.m_lbl_thoidiem.Size = new System.Drawing.Size(41, 13);
            this.m_lbl_thoidiem.TabIndex = 40;
            this.m_lbl_thoidiem.Text = "Tháng:";
            // 
            // m_dtp_thoidiem
            // 
            this.m_dtp_thoidiem.CustomFormat = "MM/yyyy";
            this.m_dtp_thoidiem.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.m_dtp_thoidiem.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.m_dtp_thoidiem.Location = new System.Drawing.Point(829, 8);
            this.m_dtp_thoidiem.Name = "m_dtp_thoidiem";
            this.m_dtp_thoidiem.Size = new System.Drawing.Size(102, 20);
            this.m_dtp_thoidiem.TabIndex = 39;
            this.m_dtp_thoidiem.ValueChanged += new System.EventHandler(this.m_dtp_thoidiem_ValueChanged);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.m_rdb_nhom);
            this.groupBox1.Controls.Add(this.m_rdb_ko_nhom);
            this.groupBox1.Location = new System.Drawing.Point(21, 3);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(235, 65);
            this.groupBox1.TabIndex = 41;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Hiển thị:";
            this.groupBox1.Visible = false;
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
            // m_cmd_search
            // 
            this.m_cmd_search.AdjustImageLocation = new System.Drawing.Point(0, 0);
            this.m_cmd_search.BtnShape = SIS.Controls.Button.emunType.BtnShape.Rectangle;
            this.m_cmd_search.BtnStyle = SIS.Controls.Button.emunType.XPStyle.Default;
            this.m_cmd_search.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.m_cmd_search.ImageIndex = 5;
            this.m_cmd_search.ImageList = this.ImageList;
            this.m_cmd_search.Location = new System.Drawing.Point(688, 3);
            this.m_cmd_search.Name = "m_cmd_search";
            this.m_cmd_search.Size = new System.Drawing.Size(88, 28);
            this.m_cmd_search.TabIndex = 22;
            this.m_cmd_search.Text = "Tìm kiếm";
            this.m_cmd_search.Click += new System.EventHandler(this.m_cmd_search_Click);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.m_cmd_search);
            this.panel1.Controls.Add(this.m_txt_tim_kiem);
            this.panel1.Controls.Add(this.groupBox1);
            this.panel1.Controls.Add(this.m_dtp_thoidiem);
            this.panel1.Controls.Add(this.m_lbl_thoidiem);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1284, 77);
            this.panel1.TabIndex = 43;
            // 
            // m_fg
            // 
            this.m_fg.ColumnInfo = resources.GetString("m_fg.ColumnInfo");
            this.m_fg.Dock = System.Windows.Forms.DockStyle.Fill;
            this.m_fg.Location = new System.Drawing.Point(0, 77);
            this.m_fg.Name = "m_fg";
            this.m_fg.Size = new System.Drawing.Size(1284, 548);
            this.m_fg.Styles = new C1.Win.C1FlexGrid.CellStyleCollection(resources.GetString("m_fg.Styles"));
            this.m_fg.TabIndex = 44;
            // 
            // f406_bao_cao_bo_nhiem
            // 
            this.AutoScaleBaseSize = new System.Drawing.Size(5, 13);
            this.CancelButton = this.m_cmd_exit;
            this.ClientSize = new System.Drawing.Size(1284, 661);
            this.Controls.Add(this.m_fg);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.m_pnl_out_place_dm);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "f406_bao_cao_bo_nhiem";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "F406 - Báo cáo bổ nhiệm";
            this.Load += new System.EventHandler(this.f406_bao_cao_bo_nhiem_Load);
            this.m_pnl_out_place_dm.ResumeLayout(false);
            this.m_pnl_out_place_dm.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
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
		#endregion

		#region Data Structure
        private enum e_col_Number
        {
            SL_BN_KO_QD_KT = 5
,
            SL_BO_NHIEM = 2
                ,
            SL_BN_KO_QD = 4
                ,
            SL_BN_CO_QD = 3
                , MA_DON_VI = 1
        }
		#endregion

		#region Members
		ITransferDataRow m_obj_trans;		
		DS_RPT_BO_NHIEM m_ds = new DS_RPT_BO_NHIEM();
		US_RPT_BO_NHIEM m_us = new US_RPT_BO_NHIEM();
		#endregion

		#region Private Methods
		private void format_controls(){
			CControlFormat.setFormStyle(this, new CAppContext_201());
			CControlFormat.setC1FlexFormat(m_fg);
			CGridUtils.AddSave_Excel_Handlers(m_fg);
            			CGridUtils.AddSearch_Handlers(m_fg);
                        m_fg.Tree.Column = (int)e_col_Number.MA_DON_VI;
                        m_fg.Tree.Style = TreeStyleFlags.ButtonBar;

			set_define_events();
			this.KeyPreview = true;		
		}
		private void set_initial_form_load(){						
			m_obj_trans = get_trans_object(m_fg);
            m_txt_tim_kiem.Text = "";
            load_data_2_grid();
            m_txt_tim_kiem.Text = "Nhập mã đơn vị";	
		}	
		private ITransferDataRow get_trans_object(C1.Win.C1FlexGrid.C1FlexGrid i_fg){
			Hashtable v_htb = new Hashtable();
            v_htb.Add(RPT_BO_NHIEM.SL_BN_KO_QD_KT, e_col_Number.SL_BN_KO_QD_KT);
            v_htb.Add(RPT_BO_NHIEM.SL_BO_NHIEM, e_col_Number.SL_BO_NHIEM);
            v_htb.Add(RPT_BO_NHIEM.SL_BN_KO_QD, e_col_Number.SL_BN_KO_QD);
            v_htb.Add(RPT_BO_NHIEM.SL_BN_CO_QD, e_col_Number.SL_BN_CO_QD);
            v_htb.Add(RPT_BO_NHIEM.MA_DON_VI, e_col_Number.MA_DON_VI);
									
			ITransferDataRow v_obj_trans = new CC1TransferDataRow(i_fg,v_htb,m_ds.RPT_BO_NHIEM.NewRow());
			return v_obj_trans;			
		}
		/*private void load_data_2_grid(){						
			m_ds = new DS_RPT_BO_NHIEM();
            m_us.FillDatasetByProc(m_ds, m_txt_tim_kiem.Text.Trim(), CAppContext_201.getCurrentIDPhapnhan());
			m_fg.Redraw = false;
			CGridUtils.Dataset2C1Grid(m_ds, m_fg, m_obj_trans);
            if (m_rdb_nhom.Checked == true)
            {
                m_fg.Subtotal(AggregateEnum.Count
                  , 0
                  , (int)e_col_Number.DIA_BAN    // Group theo cột này
                  , (int)e_col_Number.MA_DON_VI       // Subtotal theo cột này
                  , "{0}"
                  );
                m_fg.Subtotal(AggregateEnum.Count
                  , 1
                  , (int)e_col_Number.MA_DV_CAP_TREN   // Group theo cột này
                  , (int)e_col_Number.MA_DON_VI         // Subtotal theo cột này
                  , "{0}"
                  );
            }
			m_fg.Redraw = true;
		}*/
        private void load_data_2_grid()
        {

            US_RPT_BO_NHIEM m_v_us = new US_RPT_BO_NHIEM();
            m_ds = new DS_RPT_BO_NHIEM();
            var v_str_search = m_txt_tim_kiem.Text.Trim();

            //var v_str_search = "TEG";
            //if (m_txt_search.Text.Trim() != m_str_goi_y_tim_kiem)
                m_v_us.FillDatasetByProc(m_ds, v_str_search, CAppContext_201.getCurrentIDPhapnhan());
            //else
            //{
                //m_v_us.FillDatasetByKeyWord(m_v_ds, "", CIPConvert.ToDecimal(m_cbo_loaidv.SelectedValue), CIPConvert.ToDecimal(m_cbo_capdv.SelectedValue), m_cbo_trangthai.SelectedValue.ToString(), CAppContext_201.getCurrentIDPhapnhan());
            //}
            m_fg.Redraw = false;
            int minID_LEVEL = int.Parse(m_ds.RPT_BO_NHIEM.Compute("Min(ID_LEVEL)", "").ToString());

            DataRow[] v_arr_dr = m_ds.RPT_BO_NHIEM.Select(RPT_BO_NHIEM.ID_LEVEL + "=" + minID_LEVEL.ToString());
            if (v_arr_dr.Length == 0) return;
            CGridUtils.ClearDataInGrid(m_fg);
            m_v_us.DataRow2Me(v_arr_dr[0]);
            m_fg.Rows.Count += 1;
            int v_i_root_row = m_fg.Rows.Count - 1;
            us_object_2_grid(m_v_us, m_ds, v_i_root_row);
            m_fg.Rows[v_i_root_row].IsNode = true;
            m_fg.Rows[v_i_root_row].Node.Level = int.Parse(m_v_us.dcID_LEVEL.ToString());
            switch (m_fg.Rows[v_i_root_row].Node.Level)
            {
                case 0:
                    m_fg.Rows[v_i_root_row].Style = m_fg.Styles[CellStyleEnum.Subtotal0];
                    break;
                case 1:
                    m_fg.Rows[v_i_root_row].Style = m_fg.Styles[CellStyleEnum.Subtotal1];
                    break;
                case 2:
                    m_fg.Rows[v_i_root_row].Style = m_fg.Styles[CellStyleEnum.Subtotal2];
                    break;
                case 3:
                    m_fg.Rows[v_i_root_row].Style = m_fg.Styles[CellStyleEnum.Subtotal3];
                    break;

            }
            insert_all_child_of_node(v_i_root_row, m_ds);
            //load_custom_source_2_m_txt_tim_kiem();
            m_fg.Redraw = true;
            //set_search_format_before();
            /*Đếm số dòng dữ liệu trên Grid*/
            //m_lbl_so_luong_ban_ghi.Text = m_ds.RPT_BO_NHIEM.Count.ToString();
        }

        private void insert_all_child_of_node(int i_grid_row, DS_RPT_BO_NHIEM ip_ds_don_vi)
        {
            US_RPT_BO_NHIEM m_v_us = new US_RPT_BO_NHIEM();
            grid2us_object(m_v_us, i_grid_row);

            DataRow[] v_arr_dr_child = ip_ds_don_vi.RPT_BO_NHIEM.Select(RPT_BO_NHIEM.ID_DV_CT + "=" + m_v_us.dcID_DON_VI.ToString());
            foreach (DataRow v_dr in v_arr_dr_child)
            {
                US_RPT_BO_NHIEM m_v_us_child = new US_RPT_BO_NHIEM();
                m_v_us_child.DataRow2Me(v_dr);
                int v_i_child_row = -1;
                insert_child_node(
                    m_v_us_child
                    , ip_ds_don_vi
                    , i_grid_row
                    , ref v_i_child_row);
                insert_all_child_of_node(v_i_child_row, ip_ds_don_vi);

            }

        }
        private void insert_child_node(US_RPT_BO_NHIEM i_us_object
            , DataSet i_ds
            , int i_parent_row
            , ref int i_row_result
            )
        {

            int v_i_new_grid_row;
            //Lay nut hien tai 
            Node v_current_node = m_fg.Rows[i_parent_row].Node;
            Node v_node_4_index;
            int v_i_level;
            //Neu them kieu nut la sibling cua nut hien tai            
            v_node_4_index = v_current_node;
            v_i_level = int.Parse(i_us_object.dcID_LEVEL.ToString());
            Node v_last_child = v_node_4_index.GetNode(NodeTypeEnum.LastChild);
            while (v_last_child != null)
            {
                v_node_4_index = v_last_child;
                v_last_child = v_node_4_index.GetNode(NodeTypeEnum.LastChild);
            }
            v_i_new_grid_row = v_node_4_index.Row.Index + 1;
            m_fg.Rows.Insert(v_i_new_grid_row);
            us_object_2_grid(i_us_object, i_ds, v_i_new_grid_row);
            m_fg.Rows[v_i_new_grid_row].IsNode = true;
            m_fg.Rows[v_i_new_grid_row].Node.Level = v_i_level;

            switch (v_i_level)
            {
                case 0:
                    m_fg.Rows[v_i_new_grid_row].Style = m_fg.Styles[CellStyleEnum.Subtotal0];
                    break;
                case 1:
                    m_fg.Rows[v_i_new_grid_row].Style = m_fg.Styles[CellStyleEnum.Subtotal1];
                    break;
                case 2:
                    m_fg.Rows[v_i_new_grid_row].Style = m_fg.Styles[CellStyleEnum.Subtotal2];
                    break;
                case 3:
                    m_fg.Rows[v_i_new_grid_row].Style = m_fg.Styles[CellStyleEnum.Subtotal3];
                    break;

            }

            i_row_result = v_i_new_grid_row;
        }
        private void us_object_2_grid(US_RPT_BO_NHIEM i_us_object, DataSet i_ds
            , int i_grid_row)
        {
            if (m_fg.Rows[i_grid_row].UserData == null)
            {
                m_fg.Rows[i_grid_row].UserData = i_ds.Tables[0].NewRow();
            }
            DataRow v_dr = (DataRow)m_fg.Rows[i_grid_row].UserData;
            i_us_object.Me2DataRow(v_dr);
            m_obj_trans.DataRow2GridRow(v_dr, i_grid_row);
        }
		private void grid2us_object(US_RPT_BO_NHIEM i_us
			, int i_grid_row) {
			DataRow v_dr;
			v_dr = (DataRow) m_fg.Rows[i_grid_row].UserData;
			m_obj_trans.GridRow2DataRow(i_grid_row,v_dr);
			i_us.DataRow2Me(v_dr);
		}

	
		private void us_object2grid(US_RPT_BO_NHIEM i_us
			, int i_grid_row) {
			DataRow v_dr = (DataRow) m_fg.Rows[i_grid_row].UserData;
			i_us.Me2DataRow(v_dr);
			m_obj_trans.DataRow2GridRow(v_dr, i_grid_row);
		}


        private void format_grid()
        {
            int i;
            string[] caption = new string[5];
            for (i = 0; i <= 4; i++)
            {
                caption[i] = m_fg.Cols[i].Caption.ToString();
            }
            // Initialize the control.
            m_fg.Styles.Normal.WordWrap = true;
            // m_fg.Cols.Count = 9;
            m_fg.Rows.Insert(0);
            m_fg.Rows.Fixed = 2;

            m_fg.AllowMerging = C1.Win.C1FlexGrid.AllowMergingEnum.FixedOnly;
            // Create row headers.
            m_fg.Rows[0].AllowMerging = true;
            // Merge the four cells with same contents.
            C1.Win.C1FlexGrid.CellRange rng = m_fg.GetCellRange(0, 4, 0, 5);
            rng.Data = "Số lượng đã chốt bổ nhiệm nhưng chưa có quyết định";
            // Merge the four cells with same contents.
            //rng = m_fg.GetCellRange(0, 5, 0, 8);
            //rng.Data = "South";
            /*for ( i = 1 ; i <= 4; i++)
            {
            m_fg[1,i] = "Qtr " + i;
            m_fg[1, i + 4] = "Qtr " + i;
            } */
            // Create the column header.
            for (i = 0; i <= 3; i++)
            {
                m_fg.Cols[i].AllowMerging = true;
                rng = m_fg.GetCellRange(0,i,1,i);
                rng.Data = caption[i].ToString();
            }
            // Merge the two cells with same contents.
            
            
            // Align and autosize the cells.
            m_fg.Styles.Fixed.TextAlign =
            C1.Win.C1FlexGrid.TextAlignEnum.CenterCenter;
            //m_fg.AutoSizeCols(0,m_fg.Cols.Count-1,10);

        }
        private void load_custom_source_2_m_txt_tim_kiem()
        {
            //m_us.FillDataset(m_ds);
            int count = m_ds.Tables["RPT_BO_NHIEM"].Rows.Count;
            AutoCompleteStringCollection v_acsc_search = new AutoCompleteStringCollection();
            foreach (DataRow dr in m_ds.RPT_BO_NHIEM)
            {
                v_acsc_search.Add(dr[RPT_BO_NHIEM.MA_DON_VI].ToString());
            }
            m_txt_tim_kiem.AutoCompleteCustomSource = v_acsc_search;
        }
        private void xem_danh_sach()
        {
            if (!CGridUtils.IsThere_Any_NonFixed_Row(m_fg)) return;
            if (!CGridUtils.isValid_NonFixed_RowIndex(m_fg, m_fg.Row)) return;
            if (m_fg.Rows[m_fg.Row].IsNode) return;
            grid2us_object(m_us, m_fg.Row);
            f407_bao_cao_bo_nhiem frm = new f407_bao_cao_bo_nhiem();
            frm.display_for_so_luong_bn(m_us.strMA_DON_VI.ToString());
        }
        private void export_2_excel()
        {
            CExcelReport v_obj_excel_rpt = new CExcelReport("f406_bao_cao_so_luong_bo_nhiem.xlsx", 4, 2);
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
		private void f406_bao_cao_bo_nhiem_Load(object sender, System.EventArgs e) {
			try{
                format_grid();
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

        private void m_fg_DoubleClick(object sender, EventArgs e)
        {
            try
            {
                xem_danh_sach();
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

	}
}

