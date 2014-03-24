///************************************************
/// Generated by: AnhHT
/// Date: 05/03/2014 04:34:01
/// Goal: Create Form for V_GD_HOP_DONG_LAO_DONG
///************************************************


using System;
using System.Data;
using System.Drawing;
using System.Collections;
using System.ComponentModel;
using System.IO;
using System.Text.RegularExpressions;
using System.Windows.Forms;
using BKI_HRM.NghiepVu;
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



    public class f701_v_hop_dong_lao_dong : System.Windows.Forms.Form
    {
        internal System.Windows.Forms.ImageList ImageList;
        internal System.Windows.Forms.Panel m_pnl_out_place_dm;
        private C1.Win.C1FlexGrid.C1FlexGrid m_fg;
        internal SIS.Controls.Button.SiSButton m_cmd_delete;
        internal SIS.Controls.Button.SiSButton m_cmd_update;
        internal SIS.Controls.Button.SiSButton m_cmd_insert;
        internal SIS.Controls.Button.SiSButton m_cmd_exit;
        internal SIS.Controls.Button.SiSButton m_cmd_tim_kiem;
        private TextBox m_txt_tim_kiem;
        private Label label1;
        internal SIS.Controls.Button.SiSButton m_cmd_xuat_excel;
        private Label m_lbl_count_record;
        private System.ComponentModel.IContainer components;

        public f701_v_hop_dong_lao_dong()
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
        protected override void Dispose(bool disposing)
        {
            if (disposing)
            {
                if (components != null)
                {
                    components.Dispose();
                }
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(f701_v_hop_dong_lao_dong));
            this.ImageList = new System.Windows.Forms.ImageList(this.components);
            this.m_pnl_out_place_dm = new System.Windows.Forms.Panel();
            this.m_cmd_xuat_excel = new SIS.Controls.Button.SiSButton();
            this.m_cmd_insert = new SIS.Controls.Button.SiSButton();
            this.m_cmd_update = new SIS.Controls.Button.SiSButton();
            this.m_cmd_delete = new SIS.Controls.Button.SiSButton();
            this.m_cmd_exit = new SIS.Controls.Button.SiSButton();
            this.m_fg = new C1.Win.C1FlexGrid.C1FlexGrid();
            this.m_cmd_tim_kiem = new SIS.Controls.Button.SiSButton();
            this.m_txt_tim_kiem = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.m_lbl_count_record = new System.Windows.Forms.Label();
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
            this.m_pnl_out_place_dm.Controls.Add(this.m_cmd_insert);
            this.m_pnl_out_place_dm.Controls.Add(this.m_cmd_update);
            this.m_pnl_out_place_dm.Controls.Add(this.m_cmd_delete);
            this.m_pnl_out_place_dm.Controls.Add(this.m_cmd_exit);
            this.m_pnl_out_place_dm.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.m_pnl_out_place_dm.Location = new System.Drawing.Point(0, 555);
            this.m_pnl_out_place_dm.Name = "m_pnl_out_place_dm";
            this.m_pnl_out_place_dm.Padding = new System.Windows.Forms.Padding(4);
            this.m_pnl_out_place_dm.Size = new System.Drawing.Size(1355, 36);
            this.m_pnl_out_place_dm.TabIndex = 19;
            // 
            // m_cmd_xuat_excel
            // 
            this.m_cmd_xuat_excel.AdjustImageLocation = new System.Drawing.Point(0, 0);
            this.m_cmd_xuat_excel.BtnShape = SIS.Controls.Button.emunType.BtnShape.Rectangle;
            this.m_cmd_xuat_excel.BtnStyle = SIS.Controls.Button.emunType.XPStyle.Default;
            this.m_cmd_xuat_excel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.m_cmd_xuat_excel.Dock = System.Windows.Forms.DockStyle.Left;
            this.m_cmd_xuat_excel.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.m_cmd_xuat_excel.ForeColor = System.Drawing.Color.Maroon;
            this.m_cmd_xuat_excel.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.m_cmd_xuat_excel.ImageIndex = 19;
            this.m_cmd_xuat_excel.ImageList = this.ImageList;
            this.m_cmd_xuat_excel.Location = new System.Drawing.Point(4, 4);
            this.m_cmd_xuat_excel.Name = "m_cmd_xuat_excel";
            this.m_cmd_xuat_excel.Size = new System.Drawing.Size(113, 28);
            this.m_cmd_xuat_excel.TabIndex = 39;
            this.m_cmd_xuat_excel.Text = "Xuất Excel";
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
            this.m_cmd_insert.Location = new System.Drawing.Point(892, 4);
            this.m_cmd_insert.Name = "m_cmd_insert";
            this.m_cmd_insert.Size = new System.Drawing.Size(128, 28);
            this.m_cmd_insert.TabIndex = 12;
            this.m_cmd_insert.Text = "&Lập hợp đồng";
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
            this.m_cmd_update.Location = new System.Drawing.Point(1020, 4);
            this.m_cmd_update.Name = "m_cmd_update";
            this.m_cmd_update.Size = new System.Drawing.Size(155, 28);
            this.m_cmd_update.TabIndex = 13;
            this.m_cmd_update.Text = "&Cập nhật hợp đồng";
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
            this.m_cmd_delete.Location = new System.Drawing.Point(1175, 4);
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
            this.m_cmd_exit.ImageIndex = 12;
            this.m_cmd_exit.ImageList = this.ImageList;
            this.m_cmd_exit.Location = new System.Drawing.Point(1263, 4);
            this.m_cmd_exit.Name = "m_cmd_exit";
            this.m_cmd_exit.Size = new System.Drawing.Size(88, 28);
            this.m_cmd_exit.TabIndex = 11;
            this.m_cmd_exit.Text = "Thoát (Esc)";
            // 
            // m_fg
            // 
            this.m_fg.ColumnInfo = resources.GetString("m_fg.ColumnInfo");
            this.m_fg.Location = new System.Drawing.Point(0, 106);
            this.m_fg.Name = "m_fg";
            this.m_fg.Size = new System.Drawing.Size(1355, 447);
            this.m_fg.Styles = new C1.Win.C1FlexGrid.CellStyleCollection(resources.GetString("m_fg.Styles"));
            this.m_fg.TabIndex = 20;
            // 
            // m_cmd_tim_kiem
            // 
            this.m_cmd_tim_kiem.AdjustImageLocation = new System.Drawing.Point(0, 0);
            this.m_cmd_tim_kiem.BtnShape = SIS.Controls.Button.emunType.BtnShape.Rectangle;
            this.m_cmd_tim_kiem.BtnStyle = SIS.Controls.Button.emunType.XPStyle.Default;
            this.m_cmd_tim_kiem.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.m_cmd_tim_kiem.ImageIndex = 5;
            this.m_cmd_tim_kiem.ImageList = this.ImageList;
            this.m_cmd_tim_kiem.Location = new System.Drawing.Point(1160, 17);
            this.m_cmd_tim_kiem.Name = "m_cmd_tim_kiem";
            this.m_cmd_tim_kiem.Size = new System.Drawing.Size(101, 28);
            this.m_cmd_tim_kiem.TabIndex = 29;
            this.m_cmd_tim_kiem.Text = "&Tìm kiếm";
            this.m_cmd_tim_kiem.Click += new System.EventHandler(this.m_cmd_tim_kiem_Click);
            // 
            // m_txt_tim_kiem
            // 
            this.m_txt_tim_kiem.ForeColor = System.Drawing.Color.Gray;
            this.m_txt_tim_kiem.Location = new System.Drawing.Point(226, 22);
            this.m_txt_tim_kiem.Name = "m_txt_tim_kiem";
            this.m_txt_tim_kiem.Size = new System.Drawing.Size(928, 20);
            this.m_txt_tim_kiem.TabIndex = 28;
            this.m_txt_tim_kiem.Text = "Nhập Mã nhân viên, Họ đệm, Tên, Mã hợp đồng, Loại hợp đồng, Ngày tháng, Trạng thá" +
    "i";
            this.m_txt_tim_kiem.MouseClick += new System.Windows.Forms.MouseEventHandler(this.m_txt_tim_kiem_MouseClick);
            this.m_txt_tim_kiem.TextChanged += new System.EventHandler(this.m_txt_tim_kiem_TextChanged);
            this.m_txt_tim_kiem.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.m_txt_tim_kiem_KeyPress);
            this.m_txt_tim_kiem.Leave += new System.EventHandler(this.m_txt_tim_kiem_Leave);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(122, 25);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(88, 13);
            this.label1.TabIndex = 27;
            this.label1.Text = "Từ khoá tìm kiếm";
            // 
            // m_lbl_count_record
            // 
            this.m_lbl_count_record.AutoSize = true;
            this.m_lbl_count_record.Location = new System.Drawing.Point(41, 66);
            this.m_lbl_count_record.Name = "m_lbl_count_record";
            this.m_lbl_count_record.Size = new System.Drawing.Size(0, 13);
            this.m_lbl_count_record.TabIndex = 34;
            // 
            // f701_v_hop_dong_lao_dong
            // 
            this.AutoScaleBaseSize = new System.Drawing.Size(5, 13);
            this.ClientSize = new System.Drawing.Size(1355, 591);
            this.Controls.Add(this.m_lbl_count_record);
            this.Controls.Add(this.m_cmd_tim_kiem);
            this.Controls.Add(this.m_txt_tim_kiem);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.m_fg);
            this.Controls.Add(this.m_pnl_out_place_dm);
            this.Name = "f701_v_hop_dong_lao_dong";
            this.Text = "f701 Danh mục hợp đồng lao động";
            this.Load += new System.EventHandler(this.f701_v_hop_dong_lao_dong_Load);
            this.m_pnl_out_place_dm.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.m_fg)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }
        #endregion

        #region Public Interface
        public void display()
        {
            this.ShowDialog();
        }
        #endregion

        #region Data Structure
        private enum e_col_Number
        {
            MA_NV = 1,
            HO_DEM = 2,
            TEN = 3,
            MA_HOP_DONG = 4,
            LOAI_HOP_DONG = 5,
            NGAY_KY_HOP_DONG = 6,
            NGAY_CO_HIEU_LUC = 7,
            NGAY_HET_HAN = 8,
            TEN_PHAP_NHAN = 9,
            TRANG_THAI_HOP_DONG = 10,
            LINK = 11,
            NGUOI_KY = 12,
            CHUC_VU_NGUOI_KY = 13
        }
        #endregion

        #region Members
        ITransferDataRow m_obj_trans;
        DS_V_GD_HOP_DONG_LAO_DONG m_ds = new DS_V_GD_HOP_DONG_LAO_DONG();
        US_V_GD_HOP_DONG_LAO_DONG m_us = new US_V_GD_HOP_DONG_LAO_DONG();
        private US_GD_HOP_DONG m_us_gd_hop_dong;

        private string m_str_suggest = "Nhập Mã nhân viên, Họ đệm, Tên, Mã hợp đồng, Loại hợp đồng, Ngày tháng, Trạng thái";
        #endregion

        #region Private Methods
        private void format_controls()
        {
            CControlFormat.setFormStyle(this, new CAppContext_201());
            CControlFormat.setC1FlexFormat(m_fg);
            CGridUtils.AddSave_Excel_Handlers(m_fg);
            CGridUtils.AddSearch_Handlers(m_fg);
            m_fg.Tree.Column = (int)e_col_Number.MA_NV;
            m_fg.Tree.Style = C1.Win.C1FlexGrid.TreeStyleFlags.SimpleLeaf;
            set_define_events();
            this.KeyPreview = true;
        }

        private void set_initial_form_load()
        {
            m_obj_trans = get_trans_object(m_fg);
            load_data_2_grid();
        }

        private ITransferDataRow get_trans_object(C1.Win.C1FlexGrid.C1FlexGrid i_fg)
        {
            Hashtable v_htb = new Hashtable();
            v_htb.Add(V_GD_HOP_DONG_LAO_DONG.TRANG_THAI_HOP_DONG, e_col_Number.TRANG_THAI_HOP_DONG);
            v_htb.Add(V_GD_HOP_DONG_LAO_DONG.CHUC_VU_NGUOI_KY, e_col_Number.CHUC_VU_NGUOI_KY);
            v_htb.Add(V_GD_HOP_DONG_LAO_DONG.NGAY_HET_HAN, e_col_Number.NGAY_HET_HAN);
            v_htb.Add(V_GD_HOP_DONG_LAO_DONG.MA_NV, e_col_Number.MA_NV);
            v_htb.Add(V_GD_HOP_DONG_LAO_DONG.NGUOI_KY, e_col_Number.NGUOI_KY);
            v_htb.Add(V_GD_HOP_DONG_LAO_DONG.NGAY_KY_HOP_DONG, e_col_Number.NGAY_KY_HOP_DONG);
            v_htb.Add(V_GD_HOP_DONG_LAO_DONG.LOAI_HOP_DONG, e_col_Number.LOAI_HOP_DONG);
            v_htb.Add(V_GD_HOP_DONG_LAO_DONG.TEN, e_col_Number.TEN);
            v_htb.Add(V_GD_HOP_DONG_LAO_DONG.MA_HOP_DONG, e_col_Number.MA_HOP_DONG);
            v_htb.Add(V_GD_HOP_DONG_LAO_DONG.HO_DEM, e_col_Number.HO_DEM);
            v_htb.Add(V_GD_HOP_DONG_LAO_DONG.NGAY_CO_HIEU_LUC, e_col_Number.NGAY_CO_HIEU_LUC);
            v_htb.Add(V_GD_HOP_DONG_LAO_DONG.TEN_PHAP_NHAN, e_col_Number.TEN_PHAP_NHAN);
            v_htb.Add(V_GD_HOP_DONG_LAO_DONG.LINK, e_col_Number.LINK);

            ITransferDataRow v_obj_trans = new CC1TransferDataRow(i_fg, v_htb, m_ds.V_GD_HOP_DONG_LAO_DONG.NewRow());
            return v_obj_trans;
        }

        private void load_data_2_grid()
        {
            m_ds = new DS_V_GD_HOP_DONG_LAO_DONG();
            var v_str_search = m_txt_tim_kiem.Text.Trim();
            var v_str_month = Regex.Match(v_str_search, @"\d+").Value;
            if (!v_str_month.Equals(""))
                v_str_search = v_str_month;

            if (v_str_search == m_str_suggest)
                m_us.FillDatasetSearchAll(m_ds, "");
            m_us.FillDatasetSearchAll(m_ds, v_str_search);

            m_lbl_count_record.Text = string.Format("Có {0} Hợp Đồng Lao Động.", m_ds.Tables[0].Rows.Count);
            m_fg.Redraw = false;
            CGridUtils.Dataset2C1Grid(m_ds, m_fg, m_obj_trans);
            m_fg.Subtotal(C1.Win.C1FlexGrid.AggregateEnum.None // chỗ này dùng hàm count tức là để đếm, có thể dùng các hàm khác thay thế
             , 0
             , (int)e_col_Number.MA_NV // chỗ này là tên trường mà mình nhóm
             , (int)e_col_Number.TEN_PHAP_NHAN // chỗ này là tên trường mà mình Count
             , "{0}"
             );
            m_fg.Redraw = true;
            m_fg.Focus();
        }

        private void grid2us_object(int i_grid_row)
        {
            DataRow v_dr = (DataRow)m_fg.Rows[i_grid_row].UserData;
            if (v_dr == null)
            {
                return;
            }
            DS_GD_HOP_DONG v_ds = new DS_GD_HOP_DONG();
            US_GD_HOP_DONG v_us = new US_GD_HOP_DONG();
            v_us.FillDatasetSearchByMaHopDong(v_ds, v_dr.ItemArray[3].ToString());

            m_us_gd_hop_dong = new US_GD_HOP_DONG((decimal)v_ds.Tables[0].Rows[0]["ID"]);
            //m_obj_trans.GridRow2DataRow(i_grid_row,v_dr);
            //i_us.DataRow2Me(v_dr);
        }

        private void us_object2grid(US_V_GD_HOP_DONG_LAO_DONG i_us, int i_grid_row)
        {
            DataRow v_dr = (DataRow)m_fg.Rows[i_grid_row].UserData;
            i_us.Me2DataRow(v_dr);
            m_obj_trans.DataRow2GridRow(v_dr, i_grid_row);
        }

        private void insert_v_gd_hop_dong_lao_dong()
        {
            f701_v_gd_hop_dong_lao_dong_DE v_fDE = new f701_v_gd_hop_dong_lao_dong_DE();
            v_fDE.display_for_insert();
            load_data_2_grid();
        }

        private void update_v_gd_hop_dong_lao_dong()
        {
            if (!CGridUtils.IsThere_Any_NonFixed_Row(m_fg)) return;
            if (!CGridUtils.isValid_NonFixed_RowIndex(m_fg, m_fg.Row)) return;
            grid2us_object(m_fg.Row);
            f701_v_gd_hop_dong_lao_dong_DE v_fDE = new f701_v_gd_hop_dong_lao_dong_DE();
            v_fDE.display_for_update(m_us_gd_hop_dong);
            load_data_2_grid();
        }

        private void delete_v_gd_hop_dong_lao_dong()
        {
            if (BaseMessages.MsgBox_Confirm("Bạn có chắc chắn muốn xoá Hợp Đồng này không ? ") == false)
                return;
            if (!CGridUtils.IsThere_Any_NonFixed_Row(m_fg)) return;
            if (!CGridUtils.isValid_NonFixed_RowIndex(m_fg, m_fg.Row)) return;
            //if (BaseMessages.askUser_DataCouldBeDeleted(8) != BaseMessages.IsDataCouldBeDeleted.CouldBeDeleted) return;
            //US_V_GD_HOP_DONG_LAO_DONG v_us = new US_V_GD_HOP_DONG_LAO_DONG();
            grid2us_object(m_fg.Row);
            try
            {
                m_us_gd_hop_dong.BeginTransaction();
                m_us_gd_hop_dong.Delete();
                if (File.Exists(m_us_gd_hop_dong.strLINK))
                {
                    File.Delete(m_us_gd_hop_dong.strLINK);
                }
                m_us_gd_hop_dong.CommitTransaction();
                m_fg.Rows.Remove(m_fg.Row);
                BaseMessages.MsgBox_Infor("Xoá thành công!");
            }
            catch (Exception v_e)
            {
                m_us_gd_hop_dong.Rollback();
                CDBExceptionHandler v_objErrHandler = new CDBExceptionHandler(v_e,
                    new CDBClientDBExceptionInterpret());
                v_objErrHandler.showErrorMessage();
            }
        }

        private void view_v_gd_hop_dong_lao_dong()
        {
            if (!CGridUtils.IsThere_Any_NonFixed_Row(m_fg)) return;
            if (!CGridUtils.isValid_NonFixed_RowIndex(m_fg, m_fg.Row)) return;
            grid2us_object(m_fg.Row);
            //	F701_V_GD_HOP_DONG_LAO_DONG_DE v_fDE = new F701_V_GD_HOP_DONG_LAO_DONG_DE();			
            //	v_fDE.display(m_us);
        }

        private bool view_hop_dong_saved()
        {
            if (!CGridUtils.IsThere_Any_NonFixed_Row(m_fg)) return true;
            if (!CGridUtils.isValid_NonFixed_RowIndex(m_fg, m_fg.Row)) return true;
            grid2us_object(m_fg.Row);
            if (m_us_gd_hop_dong == null)
                return true;
            if (m_us_gd_hop_dong.strLINK == "")
                return true;
            if (m_fg.Col == 11)
            {
                f701_v_gd_hop_dong_lao_dong_View frm = new f701_v_gd_hop_dong_lao_dong_View();
                frm.display_for_view(m_us_gd_hop_dong);
                load_data_2_grid();
            }
            return false;
        }
        private void toggle_group(object sender, EventArgs e)
        {
            if (m_fg.Rows[m_fg.Row].IsNode) CGridUtils.grid_Double_Click(sender, e);
            else update_v_gd_hop_dong_lao_dong();
        }
        #endregion

        #region Event
        private void set_define_events()
        {
            m_cmd_exit.Click += new EventHandler(m_cmd_exit_Click);
            m_cmd_insert.Click += new EventHandler(m_cmd_insert_Click);
            m_cmd_update.Click += new EventHandler(m_cmd_update_Click);
            m_cmd_delete.Click += new EventHandler(m_cmd_delete_Click);
            m_fg.Click += new EventHandler(m_fg_Click);
            m_fg.DoubleClick += new EventHandler(m_fg_DoubleClick);
        }
        void m_fg_DoubleClick(object sender, EventArgs e)
        {
            try
            {
                toggle_group(sender,e);
            }
            catch (Exception v_e)
            {
                CSystemLog_301.ExceptionHandle(v_e);
            }
        }

        void m_fg_Click(object sender, EventArgs e)
        {
            try
            {
                if (view_hop_dong_saved()) return;
            }
            catch (Exception v_e)
            {
                CSystemLog_301.ExceptionHandle(v_e);
            }
        }
        private void f701_v_hop_dong_lao_dong_Load(object sender, System.EventArgs e)
        {
            try
            {
                m_txt_tim_kiem.ForeColor = Color.Gray;
                set_initial_form_load();
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
                insert_v_gd_hop_dong_lao_dong();
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
                update_v_gd_hop_dong_lao_dong();
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
                delete_v_gd_hop_dong_lao_dong();
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
                view_v_gd_hop_dong_lao_dong();
            }
            catch (Exception v_e)
            {
                CSystemLog_301.ExceptionHandle(v_e);
            }
        }
        private void m_txt_tim_kiem_KeyPress(object sender, KeyPressEventArgs e)
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
        private void m_cmd_tim_kiem_Click(object sender, EventArgs e)
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
        private void m_txt_tim_kiem_Leave(object sender, EventArgs e)
        {
            try
            {
                if (m_txt_tim_kiem.Text == "")
                {
                    m_txt_tim_kiem.Text = m_str_suggest;
                    m_txt_tim_kiem.ForeColor = Color.Gray;
                }

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
                m_txt_tim_kiem.Text = "";
                m_txt_tim_kiem.ForeColor = Color.Black;
            }
            catch (Exception v_e)
            {
                CSystemLog_301.ExceptionHandle(v_e);
            }
        }
        private void m_txt_tim_kiem_TextChanged(object sender, EventArgs e)
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
        #endregion
    }
}

