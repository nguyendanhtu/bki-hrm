///************************************************
/// Generated by: THAIPH
/// Date: 13/04/2014 10:41:11
/// Goal: Create Form for V_DM_NHAN_SU_DU_AN
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
using IP.Core.IPExcelReport;

namespace BKI_HRM
{



    public class f501_v_dm_nhan_su_du_an : System.Windows.Forms.Form
    {
        internal System.Windows.Forms.Panel m_pnl_out_place_dm;
        private C1.Win.C1FlexGrid.C1FlexGrid m_fg;
        internal SIS.Controls.Button.SiSButton m_cmd_delete;
        internal SIS.Controls.Button.SiSButton m_cmd_update;
        internal SIS.Controls.Button.SiSButton m_cmd_insert;
        internal SIS.Controls.Button.SiSButton m_cmd_exit;
        internal SIS.Controls.Button.SiSButton m_cmd_view;
        private TextBox m_txt_tim_kiem;
        internal SIS.Controls.Button.SiSButton m_cmd_search;
        private Label m_lbl_tim_kiem;
        private Label label2;
        private Panel panel1;
        private GroupBox groupBox1;
        private DateTimePicker m_dat_den_ngay;
        private DateTimePicker m_dat_tu_ngay;
        private ComboBox m_cbo_tim_kiem_theo_ngay;
        private Label label6;
        private Label label7;
        private Label label8;
        private Label m_lbl_count_record;
        private Label m_lbl_phim_tat;
        private System.ComponentModel.IContainer components;

        public f501_v_dm_nhan_su_du_an()
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(f501_v_dm_nhan_su_du_an));
            this.m_pnl_out_place_dm = new System.Windows.Forms.Panel();
            this.m_lbl_phim_tat = new System.Windows.Forms.Label();
            this.m_cmd_insert = new SIS.Controls.Button.SiSButton();
            this.m_cmd_update = new SIS.Controls.Button.SiSButton();
            this.m_cmd_view = new SIS.Controls.Button.SiSButton();
            this.m_cmd_delete = new SIS.Controls.Button.SiSButton();
            this.m_cmd_exit = new SIS.Controls.Button.SiSButton();
            this.m_fg = new C1.Win.C1FlexGrid.C1FlexGrid();
            this.m_txt_tim_kiem = new System.Windows.Forms.TextBox();
            this.m_cmd_search = new SIS.Controls.Button.SiSButton();
            this.m_lbl_tim_kiem = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.m_lbl_count_record = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.m_dat_den_ngay = new System.Windows.Forms.DateTimePicker();
            this.m_dat_tu_ngay = new System.Windows.Forms.DateTimePicker();
            this.m_cbo_tim_kiem_theo_ngay = new System.Windows.Forms.ComboBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.m_pnl_out_place_dm.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.m_fg)).BeginInit();
            this.panel1.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // m_pnl_out_place_dm
            // 
            this.m_pnl_out_place_dm.Controls.Add(this.m_lbl_phim_tat);
            this.m_pnl_out_place_dm.Controls.Add(this.m_cmd_insert);
            this.m_pnl_out_place_dm.Controls.Add(this.m_cmd_update);
            this.m_pnl_out_place_dm.Controls.Add(this.m_cmd_view);
            this.m_pnl_out_place_dm.Controls.Add(this.m_cmd_delete);
            this.m_pnl_out_place_dm.Controls.Add(this.m_cmd_exit);
            this.m_pnl_out_place_dm.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.m_pnl_out_place_dm.Location = new System.Drawing.Point(0, 482);
            this.m_pnl_out_place_dm.Name = "m_pnl_out_place_dm";
            this.m_pnl_out_place_dm.Padding = new System.Windows.Forms.Padding(4);
            this.m_pnl_out_place_dm.Size = new System.Drawing.Size(1230, 36);
            this.m_pnl_out_place_dm.TabIndex = 19;
            // 
            // m_lbl_phim_tat
            // 
            this.m_lbl_phim_tat.AutoSize = true;
            this.m_lbl_phim_tat.Location = new System.Drawing.Point(156, 12);
            this.m_lbl_phim_tat.Name = "m_lbl_phim_tat";
            this.m_lbl_phim_tat.Size = new System.Drawing.Size(206, 13);
            this.m_lbl_phim_tat.TabIndex = 1001;
            this.m_lbl_phim_tat.Text = "Phím tắt: F6_Mở rộng-Thu gọn danh sách";
            // 
            // m_cmd_insert
            // 
            this.m_cmd_insert.AdjustImageLocation = new System.Drawing.Point(0, 0);
            this.m_cmd_insert.BtnShape = SIS.Controls.Button.emunType.BtnShape.Rectangle;
            this.m_cmd_insert.BtnStyle = SIS.Controls.Button.emunType.XPStyle.Default;
            this.m_cmd_insert.Dock = System.Windows.Forms.DockStyle.Right;
            this.m_cmd_insert.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.m_cmd_insert.ImageIndex = 2;
            this.m_cmd_insert.Location = new System.Drawing.Point(874, 4);
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
            this.m_cmd_update.Location = new System.Drawing.Point(962, 4);
            this.m_cmd_update.Name = "m_cmd_update";
            this.m_cmd_update.Size = new System.Drawing.Size(88, 28);
            this.m_cmd_update.TabIndex = 13;
            this.m_cmd_update.Text = "&Sửa";
            // 
            // m_cmd_view
            // 
            this.m_cmd_view.AdjustImageLocation = new System.Drawing.Point(0, 0);
            this.m_cmd_view.BtnShape = SIS.Controls.Button.emunType.BtnShape.Rectangle;
            this.m_cmd_view.BtnStyle = SIS.Controls.Button.emunType.XPStyle.Default;
            this.m_cmd_view.Dock = System.Windows.Forms.DockStyle.Left;
            this.m_cmd_view.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.m_cmd_view.ImageIndex = 19;
            this.m_cmd_view.Location = new System.Drawing.Point(4, 4);
            this.m_cmd_view.Name = "m_cmd_view";
            this.m_cmd_view.Size = new System.Drawing.Size(88, 28);
            this.m_cmd_view.TabIndex = 21;
            this.m_cmd_view.Text = "Xuất excel";
            // 
            // m_cmd_delete
            // 
            this.m_cmd_delete.AdjustImageLocation = new System.Drawing.Point(0, 0);
            this.m_cmd_delete.BtnShape = SIS.Controls.Button.emunType.BtnShape.Rectangle;
            this.m_cmd_delete.BtnStyle = SIS.Controls.Button.emunType.XPStyle.Default;
            this.m_cmd_delete.Dock = System.Windows.Forms.DockStyle.Right;
            this.m_cmd_delete.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.m_cmd_delete.ImageIndex = 4;
            this.m_cmd_delete.Location = new System.Drawing.Point(1050, 4);
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
            this.m_cmd_exit.Location = new System.Drawing.Point(1138, 4);
            this.m_cmd_exit.Name = "m_cmd_exit";
            this.m_cmd_exit.Size = new System.Drawing.Size(88, 28);
            this.m_cmd_exit.TabIndex = 11;
            this.m_cmd_exit.Text = "Thoát (Esc)";
            // 
            // m_fg
            // 
            this.m_fg.ColumnInfo = resources.GetString("m_fg.ColumnInfo");
            this.m_fg.Dock = System.Windows.Forms.DockStyle.Fill;
            this.m_fg.Location = new System.Drawing.Point(0, 152);
            this.m_fg.Name = "m_fg";
            this.m_fg.Size = new System.Drawing.Size(1230, 330);
            this.m_fg.Styles = new C1.Win.C1FlexGrid.CellStyleCollection(resources.GetString("m_fg.Styles"));
            this.m_fg.TabIndex = 20;
            // 
            // m_txt_tim_kiem
            // 
            this.m_txt_tim_kiem.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.m_txt_tim_kiem.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.CustomSource;
            this.m_txt_tim_kiem.Location = new System.Drawing.Point(92, 27);
            this.m_txt_tim_kiem.Name = "m_txt_tim_kiem";
            this.m_txt_tim_kiem.Size = new System.Drawing.Size(632, 20);
            this.m_txt_tim_kiem.TabIndex = 44;
            this.m_txt_tim_kiem.MouseClick += new System.Windows.Forms.MouseEventHandler(this.m_txt_tim_kiem_MouseClick);
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
            this.m_cmd_search.Location = new System.Drawing.Point(730, 26);
            this.m_cmd_search.Name = "m_cmd_search";
            this.m_cmd_search.Size = new System.Drawing.Size(88, 28);
            this.m_cmd_search.TabIndex = 45;
            this.m_cmd_search.Text = "Tìm kiếm";
            this.m_cmd_search.Click += new System.EventHandler(this.m_cmd_search_Click);
            // 
            // m_lbl_tim_kiem
            // 
            this.m_lbl_tim_kiem.AutoSize = true;
            this.m_lbl_tim_kiem.Location = new System.Drawing.Point(37, 30);
            this.m_lbl_tim_kiem.Name = "m_lbl_tim_kiem";
            this.m_lbl_tim_kiem.Size = new System.Drawing.Size(49, 13);
            this.m_lbl_tim_kiem.TabIndex = 46;
            this.m_lbl_tim_kiem.Text = "Tìm kiếm";
            // 
            // label2
            // 
            this.label2.Dock = System.Windows.Forms.DockStyle.Top;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Maroon;
            this.label2.Location = new System.Drawing.Point(0, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(1230, 41);
            this.label2.TabIndex = 51;
            this.label2.Text = "Tra cứu nhân sự dự án";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.m_lbl_count_record);
            this.panel1.Controls.Add(this.groupBox1);
            this.panel1.Controls.Add(this.m_txt_tim_kiem);
            this.panel1.Controls.Add(this.m_lbl_tim_kiem);
            this.panel1.Controls.Add(this.m_cmd_search);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 41);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1230, 111);
            this.panel1.TabIndex = 52;
            // 
            // m_lbl_count_record
            // 
            this.m_lbl_count_record.AutoSize = true;
            this.m_lbl_count_record.ForeColor = System.Drawing.Color.Maroon;
            this.m_lbl_count_record.Location = new System.Drawing.Point(47, 61);
            this.m_lbl_count_record.Name = "m_lbl_count_record";
            this.m_lbl_count_record.Size = new System.Drawing.Size(0, 13);
            this.m_lbl_count_record.TabIndex = 48;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.m_dat_den_ngay);
            this.groupBox1.Controls.Add(this.m_dat_tu_ngay);
            this.groupBox1.Controls.Add(this.m_cbo_tim_kiem_theo_ngay);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.label8);
            this.groupBox1.Location = new System.Drawing.Point(843, 5);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(299, 100);
            this.groupBox1.TabIndex = 47;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Tìm kiếm theo ngày tháng";
            // 
            // m_dat_den_ngay
            // 
            this.m_dat_den_ngay.CustomFormat = "dd/MM/yyyy";
            this.m_dat_den_ngay.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.m_dat_den_ngay.Location = new System.Drawing.Point(98, 76);
            this.m_dat_den_ngay.Name = "m_dat_den_ngay";
            this.m_dat_den_ngay.Size = new System.Drawing.Size(118, 20);
            this.m_dat_den_ngay.TabIndex = 42;
            this.m_dat_den_ngay.ValueChanged += new System.EventHandler(this.m_dat_den_ngay_ValueChanged);
            // 
            // m_dat_tu_ngay
            // 
            this.m_dat_tu_ngay.CustomFormat = "dd/MM/yyyy";
            this.m_dat_tu_ngay.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.m_dat_tu_ngay.Location = new System.Drawing.Point(98, 50);
            this.m_dat_tu_ngay.Name = "m_dat_tu_ngay";
            this.m_dat_tu_ngay.Size = new System.Drawing.Size(118, 20);
            this.m_dat_tu_ngay.TabIndex = 41;
            this.m_dat_tu_ngay.Value = new System.DateTime(2005, 1, 1, 0, 0, 0, 0);
            this.m_dat_tu_ngay.ValueChanged += new System.EventHandler(this.m_dat_tu_ngay_ValueChanged);
            // 
            // m_cbo_tim_kiem_theo_ngay
            // 
            this.m_cbo_tim_kiem_theo_ngay.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.m_cbo_tim_kiem_theo_ngay.FormattingEnabled = true;
            this.m_cbo_tim_kiem_theo_ngay.Items.AddRange(new object[] {
            "-------- Không tìm kiếm -------",
            "Thời điểm tham gia",
            "Thời điểm kết thúc"});
            this.m_cbo_tim_kiem_theo_ngay.Location = new System.Drawing.Point(98, 21);
            this.m_cbo_tim_kiem_theo_ngay.Name = "m_cbo_tim_kiem_theo_ngay";
            this.m_cbo_tim_kiem_theo_ngay.Size = new System.Drawing.Size(190, 21);
            this.m_cbo_tim_kiem_theo_ngay.TabIndex = 1;
            this.m_cbo_tim_kiem_theo_ngay.SelectedIndexChanged += new System.EventHandler(this.m_cbo_tim_kiem_theo_ngay_SelectedIndexChanged);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(17, 25);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(73, 13);
            this.label6.TabIndex = 0;
            this.label6.Text = "Tìm kiếm theo";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(44, 55);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(46, 13);
            this.label7.TabIndex = 35;
            this.label7.Text = "Từ ngày";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(39, 81);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(53, 13);
            this.label8.TabIndex = 36;
            this.label8.Text = "Đến ngày";
            // 
            // f501_v_dm_nhan_su_du_an
            // 
            this.AutoScaleBaseSize = new System.Drawing.Size(5, 13);
            this.ClientSize = new System.Drawing.Size(1230, 518);
            this.Controls.Add(this.m_fg);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.m_pnl_out_place_dm);
            this.Name = "f501_v_dm_nhan_su_du_an";
            this.Text = "F501 - Tra cứu nhân sự dự án";
            this.Load += new System.EventHandler(this.f501_v_dm_nhan_su_du_an_Load);
            this.m_pnl_out_place_dm.ResumeLayout(false);
            this.m_pnl_out_place_dm.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.m_fg)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

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
            MA_DU_AN = 1,
            MA_NV = 2,
            HO_DEM = 3,
            TEN = 4,
            VI_TRI = 5,
            TRANG_THAI_LAO_DONG = 6,
            THOI_DIEM_TG = 7,
            THOI_DIEM_KT = 8,
            THOI_GIAN_TG = 9,
            DANH_HIEU = 10,
            MO_TA = 11,
            MA_QUYET_DINH = 12,
        }
        #endregion

        #region Members
        ITransferDataRow m_obj_trans;
        DS_V_DM_NHAN_SU_DU_AN m_ds = new DS_V_DM_NHAN_SU_DU_AN();
        US_V_DM_NHAN_SU_DU_AN m_us = new US_V_DM_NHAN_SU_DU_AN();
        private const string M_STR_SUGGESTION = "Nhập mã dự án, tên dự án, họ tên, vị trí";
        #endregion

        #region Private Methods
        private void format_controls()
        {
            CControlFormat.setFormStyle(this, new CAppContext_201());
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
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
            m_cbo_tim_kiem_theo_ngay.SelectedIndex = 0;
        }
        private ITransferDataRow get_trans_object(C1.Win.C1FlexGrid.C1FlexGrid i_fg)
        {
            Hashtable v_htb = new Hashtable();
            v_htb.Add(V_DM_NHAN_SU_DU_AN.MA_DU_AN, e_col_Number.MA_DU_AN);
            v_htb.Add(V_DM_NHAN_SU_DU_AN.THOI_GIAN_TG, e_col_Number.THOI_GIAN_TG);
            v_htb.Add(V_DM_NHAN_SU_DU_AN.DANH_HIEU, e_col_Number.DANH_HIEU);
            v_htb.Add(V_DM_NHAN_SU_DU_AN.MA_NV, e_col_Number.MA_NV);
            v_htb.Add(V_DM_NHAN_SU_DU_AN.VI_TRI, e_col_Number.VI_TRI);
            v_htb.Add(V_DM_NHAN_SU_DU_AN.HO_DEM, e_col_Number.HO_DEM);
            v_htb.Add(V_DM_NHAN_SU_DU_AN.TEN, e_col_Number.TEN);
            v_htb.Add(V_DM_NHAN_SU_DU_AN.TRANG_THAI_LAO_DONG, e_col_Number.TRANG_THAI_LAO_DONG);
            v_htb.Add(V_DM_NHAN_SU_DU_AN.THOI_DIEM_TG, e_col_Number.THOI_DIEM_TG);
            v_htb.Add(V_DM_NHAN_SU_DU_AN.MO_TA, e_col_Number.MO_TA);
            v_htb.Add(V_DM_NHAN_SU_DU_AN.THOI_DIEM_KT, e_col_Number.THOI_DIEM_KT);
            v_htb.Add(V_DM_NHAN_SU_DU_AN.MA_QUYET_DINH, e_col_Number.MA_QUYET_DINH);

            ITransferDataRow v_obj_trans = new CC1TransferDataRow(i_fg, v_htb, m_ds.V_DM_NHAN_SU_DU_AN.NewRow());
            return v_obj_trans;
        }
        private void load_data_2_grid()
        {
            m_ds = new DS_V_DM_NHAN_SU_DU_AN();
            var v_str_search = m_txt_tim_kiem.Text.Trim();
            if (v_str_search == M_STR_SUGGESTION)
                v_str_search = "";

            m_us.FillDatasetTuNgayDenNgay(
                m_ds,
                v_str_search,
                DateTime.Parse(m_dat_tu_ngay.Value.ToShortDateString()),
                DateTime.Parse(m_dat_den_ngay.Value.ToShortDateString()),
                m_cbo_tim_kiem_theo_ngay.SelectedIndex,
                CAppContext_201.getCurrentIDPhapnhan());

            m_fg.Redraw = false;
            CGridUtils.Dataset2C1Grid(m_ds, m_fg, m_obj_trans);
            m_fg.Subtotal(C1.Win.C1FlexGrid.AggregateEnum.Count // chỗ này dùng hàm count tức là để đếm, có thể dùng các hàm khác thay thế
             , 0
             , (int)e_col_Number.MA_DU_AN // chỗ này là tên trường mà mình nhóm
             , (int)e_col_Number.TEN // chỗ này là tên trường mà mình Count
             , "{0}"
             );
            m_fg.Cols[(int)e_col_Number.MA_DU_AN].Visible = false;
            m_fg.Redraw = true;
            m_lbl_count_record.Text = string.Format("Có {0} bản ghi", m_ds.Tables[0].Rows.Count);
        }
        private void grid2us_object(US_V_DM_NHAN_SU_DU_AN i_us
            , int i_grid_row)
        {
            DataRow v_dr;
            v_dr = (DataRow)m_fg.Rows[i_grid_row].UserData;
            m_obj_trans.GridRow2DataRow(i_grid_row, v_dr);
            i_us.DataRow2Me(v_dr);
        }


        private void us_object2grid(US_V_DM_NHAN_SU_DU_AN i_us
            , int i_grid_row)
        {
            DataRow v_dr = (DataRow)m_fg.Rows[i_grid_row].UserData;
            i_us.Me2DataRow(v_dr);
            m_obj_trans.DataRow2GridRow(v_dr, i_grid_row);
        }


        private void insert_v_dm_nhan_su_du_an()
        {
            //	f501_v_dm_nhan_su_du_an_DE v_fDE = new  f501_v_dm_nhan_su_du_an_DE();								
            //	v_fDE.display();
            load_data_2_grid();
        }

        private void update_v_dm_nhan_su_du_an()
        {
            if (!CGridUtils.IsThere_Any_NonFixed_Row(m_fg)) return;
            if (!CGridUtils.isValid_NonFixed_RowIndex(m_fg, m_fg.Row)) return;
            grid2us_object(m_us, m_fg.Row);
            //	f501_v_dm_nhan_su_du_an_DE v_fDE = new f501_v_dm_nhan_su_du_an_DE();
            //	v_fDE.display(m_us);
            load_data_2_grid();
        }

        private void delete_v_dm_nhan_su_du_an()
        {
            if (!CGridUtils.IsThere_Any_NonFixed_Row(m_fg)) return;
            if (!CGridUtils.isValid_NonFixed_RowIndex(m_fg, m_fg.Row)) return;
            if (BaseMessages.askUser_DataCouldBeDeleted(8) != BaseMessages.IsDataCouldBeDeleted.CouldBeDeleted) return;
            US_V_DM_NHAN_SU_DU_AN v_us = new US_V_DM_NHAN_SU_DU_AN();
            grid2us_object(v_us, m_fg.Row);
            try
            {
                v_us.BeginTransaction();
                v_us.Delete();
                v_us.CommitTransaction();
                m_fg.Rows.Remove(m_fg.Row);
            }
            catch (Exception v_e)
            {
                v_us.Rollback();
                CDBExceptionHandler v_objErrHandler = new CDBExceptionHandler(v_e,
                    new CDBClientDBExceptionInterpret());
                v_objErrHandler.showErrorMessage();
            }
        }

        private void view_v_dm_nhan_su_du_an()
        {
            if (!CGridUtils.IsThere_Any_NonFixed_Row(m_fg)) return;
            if (!CGridUtils.isValid_NonFixed_RowIndex(m_fg, m_fg.Row)) return;
            grid2us_object(m_us, m_fg.Row);
            //	f501_v_dm_nhan_su_du_an_DE v_fDE = new f501_v_dm_nhan_su_du_an_DE();			
            //	v_fDE.display(m_us);
        }

        private void auto_suggest_text()
        {
            DS_V_DM_NHAN_SU_DU_AN v_ds_dm_ns_da = new DS_V_DM_NHAN_SU_DU_AN();
            US_V_DM_NHAN_SU_DU_AN v_us_dm_ns_da = new US_V_DM_NHAN_SU_DU_AN();
            v_us_dm_ns_da.FillDatasetTuNgayDenNgay(
                    v_ds_dm_ns_da,
                    "",
                    DateTime.Parse(m_dat_tu_ngay.Value.ToShortDateString()),
                    DateTime.Parse(m_dat_den_ngay.Value.ToShortDateString()),
                    0,
                    CAppContext_201.getCurrentIDPhapnhan());
            var v_acsc_search = new AutoCompleteStringCollection();
            foreach (DataRow dr in v_ds_dm_ns_da.V_DM_NHAN_SU_DU_AN)
            {
                v_acsc_search.Add(dr[V_DM_NHAN_SU_DU_AN.HO_DEM] + " " + dr[V_DM_NHAN_SU_DU_AN.TEN]);
                v_acsc_search.Add(dr[V_DM_NHAN_SU_DU_AN.TEN].ToString());
                v_acsc_search.Add(dr[V_DM_NHAN_SU_DU_AN.HO_DEM].ToString());
                v_acsc_search.Add(dr[V_DM_NHAN_SU_DU_AN.MA_DU_AN].ToString());
                v_acsc_search.Add(dr[V_DM_NHAN_SU_DU_AN.TEN_DU_AN].ToString());
                v_acsc_search.Add(dr[V_DM_NHAN_SU_DU_AN.VI_TRI].ToString());
            }
            m_txt_tim_kiem.AutoCompleteCustomSource = v_acsc_search;
        }

        private void set_define_events()
        {
            m_cmd_exit.Click += new EventHandler(m_cmd_exit_Click);
            m_cmd_insert.Click += new EventHandler(m_cmd_insert_Click);
            m_cmd_update.Click += new EventHandler(m_cmd_update_Click);
            m_cmd_delete.Click += new EventHandler(m_cmd_delete_Click);
            m_cmd_view.Click += new EventHandler(m_cmd_view_Click);
        }

        private void export_2_excel()
        {
            CExcelReport v_obj_excel_rpt = new CExcelReport("f501_bao_cao_nhan_su_du_an_tu_ngay_den_ngay.xlsx", 6, 1);
            v_obj_excel_rpt.AddFindAndReplaceItem("<tu_ngay>", m_dat_tu_ngay.Value.Date);
            v_obj_excel_rpt.AddFindAndReplaceItem("<den_ngay>", m_dat_den_ngay.Value.Date);
            v_obj_excel_rpt.FindAndReplace(false);
            v_obj_excel_rpt.Export2ExcelWithoutFixedRows(m_fg, 1, m_fg.Cols.Count - 1, true);
        }
        #endregion

        #region Event
        private void f501_v_dm_nhan_su_du_an_Load(object sender, System.EventArgs e)
        {
            try
            {
                m_txt_tim_kiem.ForeColor = Color.Gray;
                m_txt_tim_kiem.Text = M_STR_SUGGESTION;
                set_initial_form_load();
                auto_suggest_text();
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
                insert_v_dm_nhan_su_du_an();
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
                update_v_dm_nhan_su_du_an();
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
                delete_v_dm_nhan_su_du_an();
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
                export_2_excel();
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

        private void m_cbo_tim_kiem_theo_ngay_SelectedIndexChanged(object sender, EventArgs e)
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

        private void m_dat_tu_ngay_ValueChanged(object sender, EventArgs e)
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

        private void m_dat_den_ngay_ValueChanged(object sender, EventArgs e)
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
                m_txt_tim_kiem.Text = "";
                m_txt_tim_kiem.ForeColor = Color.Black;
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
                    m_txt_tim_kiem.Text = M_STR_SUGGESTION;
                    m_txt_tim_kiem.ForeColor = Color.Gray;
                }

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
        #endregion
    }
}

