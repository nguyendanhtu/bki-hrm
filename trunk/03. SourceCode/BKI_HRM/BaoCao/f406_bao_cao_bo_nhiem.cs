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
        private C1.Win.C1FlexGrid.C1FlexGrid m_fg;
        internal SIS.Controls.Button.SiSButton m_cmd_exit;
        internal SIS.Controls.Button.SiSButton m_cmd_search;
        private TextBox m_txt_tim_kiem;
        internal SIS.Controls.Button.SiSButton m_cmd_xuat_excel;
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
            this.m_cmd_exit = new SIS.Controls.Button.SiSButton();
            this.m_fg = new C1.Win.C1FlexGrid.C1FlexGrid();
            this.m_cmd_search = new SIS.Controls.Button.SiSButton();
            this.m_txt_tim_kiem = new System.Windows.Forms.TextBox();
            this.m_cmd_xuat_excel = new SIS.Controls.Button.SiSButton();
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
            this.m_pnl_out_place_dm.Location = new System.Drawing.Point(0, 425);
            this.m_pnl_out_place_dm.Name = "m_pnl_out_place_dm";
            this.m_pnl_out_place_dm.Padding = new System.Windows.Forms.Padding(4);
            this.m_pnl_out_place_dm.Size = new System.Drawing.Size(834, 36);
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
            this.m_cmd_exit.Location = new System.Drawing.Point(742, 4);
            this.m_cmd_exit.Name = "m_cmd_exit";
            this.m_cmd_exit.Size = new System.Drawing.Size(88, 28);
            this.m_cmd_exit.TabIndex = 11;
            this.m_cmd_exit.Text = "Thoát (Esc)";
            // 
            // m_fg
            // 
            this.m_fg.ColumnInfo = resources.GetString("m_fg.ColumnInfo");
            this.m_fg.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.m_fg.Location = new System.Drawing.Point(0, 52);
            this.m_fg.Name = "m_fg";
            this.m_fg.Size = new System.Drawing.Size(834, 373);
            this.m_fg.Styles = new C1.Win.C1FlexGrid.CellStyleCollection(resources.GetString("m_fg.Styles"));
            this.m_fg.TabIndex = 20;
            // 
            // m_cmd_search
            // 
            this.m_cmd_search.AdjustImageLocation = new System.Drawing.Point(0, 0);
            this.m_cmd_search.BtnShape = SIS.Controls.Button.emunType.BtnShape.Rectangle;
            this.m_cmd_search.BtnStyle = SIS.Controls.Button.emunType.XPStyle.Default;
            this.m_cmd_search.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.m_cmd_search.ImageIndex = 5;
            this.m_cmd_search.ImageList = this.ImageList;
            this.m_cmd_search.Location = new System.Drawing.Point(592, 7);
            this.m_cmd_search.Name = "m_cmd_search";
            this.m_cmd_search.Size = new System.Drawing.Size(88, 28);
            this.m_cmd_search.TabIndex = 22;
            this.m_cmd_search.Text = "Tìm kiếm";
            this.m_cmd_search.Click += new System.EventHandler(this.m_cmd_search_Click);
            // 
            // m_txt_tim_kiem
            // 
            this.m_txt_tim_kiem.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.m_txt_tim_kiem.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.CustomSource;
            this.m_txt_tim_kiem.Location = new System.Drawing.Point(124, 12);
            this.m_txt_tim_kiem.Name = "m_txt_tim_kiem";
            this.m_txt_tim_kiem.Size = new System.Drawing.Size(462, 20);
            this.m_txt_tim_kiem.TabIndex = 21;
            this.m_txt_tim_kiem.MouseClick += new System.Windows.Forms.MouseEventHandler(this.m_txt_tim_kiem_MouseClick);
            this.m_txt_tim_kiem.KeyDown += new System.Windows.Forms.KeyEventHandler(this.m_txt_tim_kiem_KeyDown);
            this.m_txt_tim_kiem.Leave += new System.EventHandler(this.m_txt_tim_kiem_Leave);
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
            // 
            // f406_bao_cao_bo_nhiem
            // 
            this.AutoScaleBaseSize = new System.Drawing.Size(5, 13);
            this.ClientSize = new System.Drawing.Size(834, 461);
            this.Controls.Add(this.m_cmd_search);
            this.Controls.Add(this.m_txt_tim_kiem);
            this.Controls.Add(this.m_fg);
            this.Controls.Add(this.m_pnl_out_place_dm);
            this.MaximumSize = new System.Drawing.Size(850, 500);
            this.MinimumSize = new System.Drawing.Size(850, 500);
            this.Name = "f406_bao_cao_bo_nhiem";
            this.Text = "f406_bao_cao_bo_nhiem";
            this.Load += new System.EventHandler(this.f406_bao_cao_bo_nhiem_Load);
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
			SL_BN_KO_QD_KT = 7
,SL_BO_NHIEM = 4
,SL_BN_KO_QD = 6
,DIA_BAN = 1
,SL_BN_CO_QD = 5
,MA_DON_VI = 3
,MA_DV_CAP_TREN = 2

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
                        m_fg.Tree.Column = (int)e_col_Number.DIA_BAN;
                        m_fg.Tree.Style = TreeStyleFlags.SimpleLeaf;

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
			v_htb.Add(RPT_BO_NHIEM.DIA_BAN, e_col_Number.DIA_BAN);
			v_htb.Add(RPT_BO_NHIEM.SL_BN_CO_QD, e_col_Number.SL_BN_CO_QD);
			v_htb.Add(RPT_BO_NHIEM.MA_DON_VI, e_col_Number.MA_DON_VI);
			v_htb.Add(RPT_BO_NHIEM.MA_DV_CAP_TREN, e_col_Number.MA_DV_CAP_TREN);
									
			ITransferDataRow v_obj_trans = new CC1TransferDataRow(i_fg,v_htb,m_ds.RPT_BO_NHIEM.NewRow());
			return v_obj_trans;			
		}
		private void load_data_2_grid(){						
			m_ds = new DS_RPT_BO_NHIEM();
            m_us.FillDatasetByProc(m_ds, m_txt_tim_kiem.Text.Trim());
			m_fg.Redraw = false;
			CGridUtils.Dataset2C1Grid(m_ds, m_fg, m_obj_trans);
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
			m_fg.Redraw = true;
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
            string[] caption = new string[6];
            for (i = 0; i <= 5; i++)
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
            C1.Win.C1FlexGrid.CellRange rng = m_fg.GetCellRange(0, 6, 0, 7);
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
            for (i = 0; i <= 5; i++)
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

	}
}

