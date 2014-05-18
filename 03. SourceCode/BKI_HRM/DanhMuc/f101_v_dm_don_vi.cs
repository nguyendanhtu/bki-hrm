///************************************************
/// Generated by: TrongHV
/// Date: 21/01/2014 03:36:18
/// Goal: Create Form for V_DM_DON_VI
///************************************************


using System;
using System.Data;
using System.Drawing;
using System.Collections;
using System.ComponentModel;
using System.Runtime.InteropServices;
using System.Windows.Forms;
using System.Windows.Forms.VisualStyles;
using BKI_HRM.DanhMuc;
using IP.Core.IPCommon;
using IP.Core.IPException;
using IP.Core.IPData;
using IP.Core.IPUserService;
using IP.Core.IPSystemAdmin;

using BKI_HRM.US;
using BKI_HRM.DS;
using BKI_HRM.DS.CDBNames;

using C1.Win.C1FlexGrid;
using SIS.Controls.Button;

namespace BKI_HRM {

    public class f101_v_dm_don_vi : Form {
        internal ImageList ImageList;
        internal Panel m_pnl_out_place_dm;
        internal SiSButton m_cmd_delete;
        internal SiSButton m_cmd_update;
        internal SiSButton m_cmd_insert;
        internal SiSButton m_cmd_exit;
        private Panel panel1;
        internal SiSButton m_cmd_search;
        private TextBox m_txt_search;
        private Label m_lbl_tim_kiem;
        private Label m_lbl_so_luong_ban_ghi;
        private Label label2;
        private C1FlexGrid m_fg;
        private ToolTip m_tooltip;
        internal SiSButton m_cmd_view;
        internal SiSButton m_cmd_chon_don_vi;
        private ComboBox m_cbo_trangthai;
        private ComboBox m_cbo_capdv;
        private ComboBox m_cbo_loaidv;
        private GroupBox groupBox1;
        private Label label4;
        private Label label1;
        private Label label3;
        private IContainer components;

        public f101_v_dm_don_vi() {
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
        protected override void Dispose(bool disposing) {
            if (disposing) {
                if (components != null) {
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
        private void InitializeComponent() {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(f101_v_dm_don_vi));
            this.ImageList = new System.Windows.Forms.ImageList(this.components);
            this.m_pnl_out_place_dm = new System.Windows.Forms.Panel();
            this.m_cmd_chon_don_vi = new SIS.Controls.Button.SiSButton();
            this.m_cmd_insert = new SIS.Controls.Button.SiSButton();
            this.m_cmd_update = new SIS.Controls.Button.SiSButton();
            this.m_cmd_view = new SIS.Controls.Button.SiSButton();
            this.m_cmd_delete = new SIS.Controls.Button.SiSButton();
            this.m_cmd_exit = new SIS.Controls.Button.SiSButton();
            this.m_lbl_so_luong_ban_ghi = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.m_cmd_search = new SIS.Controls.Button.SiSButton();
            this.m_txt_search = new System.Windows.Forms.TextBox();
            this.m_lbl_tim_kiem = new System.Windows.Forms.Label();
            this.m_fg = new C1.Win.C1FlexGrid.C1FlexGrid();
            this.m_tooltip = new System.Windows.Forms.ToolTip(this.components);
            this.m_cbo_trangthai = new System.Windows.Forms.ComboBox();
            this.m_cbo_loaidv = new System.Windows.Forms.ComboBox();
            this.m_cbo_capdv = new System.Windows.Forms.ComboBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.m_pnl_out_place_dm.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.m_fg)).BeginInit();
            this.groupBox1.SuspendLayout();
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
            this.m_pnl_out_place_dm.Controls.Add(this.m_cmd_chon_don_vi);
            this.m_pnl_out_place_dm.Controls.Add(this.m_cmd_insert);
            this.m_pnl_out_place_dm.Controls.Add(this.m_cmd_update);
            this.m_pnl_out_place_dm.Controls.Add(this.m_cmd_view);
            this.m_pnl_out_place_dm.Controls.Add(this.m_cmd_delete);
            this.m_pnl_out_place_dm.Controls.Add(this.m_cmd_exit);
            this.m_pnl_out_place_dm.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.m_pnl_out_place_dm.Location = new System.Drawing.Point(0, 536);
            this.m_pnl_out_place_dm.Name = "m_pnl_out_place_dm";
            this.m_pnl_out_place_dm.Padding = new System.Windows.Forms.Padding(4);
            this.m_pnl_out_place_dm.Size = new System.Drawing.Size(1189, 36);
            this.m_pnl_out_place_dm.TabIndex = 19;
            // 
            // m_cmd_chon_don_vi
            // 
            this.m_cmd_chon_don_vi.AdjustImageLocation = new System.Drawing.Point(0, 0);
            this.m_cmd_chon_don_vi.BtnShape = SIS.Controls.Button.emunType.BtnShape.Rectangle;
            this.m_cmd_chon_don_vi.BtnStyle = SIS.Controls.Button.emunType.XPStyle.Default;
            this.m_cmd_chon_don_vi.Dock = System.Windows.Forms.DockStyle.Right;
            this.m_cmd_chon_don_vi.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.m_cmd_chon_don_vi.ImageIndex = 13;
            this.m_cmd_chon_don_vi.ImageList = this.ImageList;
            this.m_cmd_chon_don_vi.Location = new System.Drawing.Point(725, 4);
            this.m_cmd_chon_don_vi.Name = "m_cmd_chon_don_vi";
            this.m_cmd_chon_don_vi.Size = new System.Drawing.Size(97, 28);
            this.m_cmd_chon_don_vi.TabIndex = 5;
            this.m_cmd_chon_don_vi.Text = "&Chọn đơn vị";
            this.m_cmd_chon_don_vi.Click += new System.EventHandler(this.m_cmd_chon_don_vi_Click);
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
            this.m_cmd_insert.Location = new System.Drawing.Point(822, 4);
            this.m_cmd_insert.Name = "m_cmd_insert";
            this.m_cmd_insert.Size = new System.Drawing.Size(88, 28);
            this.m_cmd_insert.TabIndex = 5;
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
            this.m_cmd_update.ImageList = this.ImageList;
            this.m_cmd_update.Location = new System.Drawing.Point(910, 4);
            this.m_cmd_update.Name = "m_cmd_update";
            this.m_cmd_update.Size = new System.Drawing.Size(88, 28);
            this.m_cmd_update.TabIndex = 6;
            this.m_cmd_update.Text = "&Sửa";
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
            this.m_cmd_view.TabIndex = 4;
            this.m_cmd_view.Text = "Xem";
            this.m_cmd_view.Visible = false;
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
            this.m_cmd_delete.Location = new System.Drawing.Point(998, 4);
            this.m_cmd_delete.Name = "m_cmd_delete";
            this.m_cmd_delete.Size = new System.Drawing.Size(88, 28);
            this.m_cmd_delete.TabIndex = 7;
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
            this.m_cmd_exit.Location = new System.Drawing.Point(1086, 4);
            this.m_cmd_exit.Name = "m_cmd_exit";
            this.m_cmd_exit.Size = new System.Drawing.Size(99, 28);
            this.m_cmd_exit.TabIndex = 8;
            this.m_cmd_exit.Text = "Thoát (Esc)";
            // 
            // m_lbl_so_luong_ban_ghi
            // 
            this.m_lbl_so_luong_ban_ghi.AutoSize = true;
            this.m_lbl_so_luong_ban_ghi.Location = new System.Drawing.Point(179, 47);
            this.m_lbl_so_luong_ban_ghi.Name = "m_lbl_so_luong_ban_ghi";
            this.m_lbl_so_luong_ban_ghi.Size = new System.Drawing.Size(25, 13);
            this.m_lbl_so_luong_ban_ghi.TabIndex = 28;
            this.m_lbl_so_luong_ban_ghi.Text = "000";
            this.m_lbl_so_luong_ban_ghi.Visible = false;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(4, 47);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(165, 13);
            this.label2.TabIndex = 27;
            this.label2.Text = "Số lượng đơn vị trong danh sách:";
            this.label2.Visible = false;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.groupBox1);
            this.panel1.Controls.Add(this.m_lbl_so_luong_ban_ghi);
            this.panel1.Controls.Add(this.m_cmd_search);
            this.panel1.Controls.Add(this.m_txt_search);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.m_lbl_tim_kiem);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1189, 124);
            this.panel1.TabIndex = 21;
            // 
            // m_cmd_search
            // 
            this.m_cmd_search.AdjustImageLocation = new System.Drawing.Point(0, 0);
            this.m_cmd_search.BtnShape = SIS.Controls.Button.emunType.BtnShape.Rectangle;
            this.m_cmd_search.BtnStyle = SIS.Controls.Button.emunType.XPStyle.Default;
            this.m_cmd_search.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.m_cmd_search.ImageIndex = 5;
            this.m_cmd_search.ImageList = this.ImageList;
            this.m_cmd_search.Location = new System.Drawing.Point(926, 12);
            this.m_cmd_search.Name = "m_cmd_search";
            this.m_cmd_search.Size = new System.Drawing.Size(88, 28);
            this.m_cmd_search.TabIndex = 2;
            this.m_cmd_search.Text = "Tìm kiếm";
            // 
            // m_txt_search
            // 
            this.m_txt_search.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.m_txt_search.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.CustomSource;
            this.m_txt_search.ForeColor = System.Drawing.Color.DimGray;
            this.m_txt_search.Location = new System.Drawing.Point(452, 17);
            this.m_txt_search.Name = "m_txt_search";
            this.m_txt_search.Size = new System.Drawing.Size(468, 20);
            this.m_txt_search.TabIndex = 1;
            this.m_tooltip.SetToolTip(this.m_txt_search, "Tìm kiếm theo tên đơn vị, mã đơn vị");
            // 
            // m_lbl_tim_kiem
            // 
            this.m_lbl_tim_kiem.AutoSize = true;
            this.m_lbl_tim_kiem.Location = new System.Drawing.Point(358, 20);
            this.m_lbl_tim_kiem.Name = "m_lbl_tim_kiem";
            this.m_lbl_tim_kiem.Size = new System.Drawing.Size(88, 13);
            this.m_lbl_tim_kiem.TabIndex = 24;
            this.m_lbl_tim_kiem.Text = "Từ khoá tìm kiếm";
            // 
            // m_fg
            // 
            this.m_fg.AllowEditing = false;
            this.m_fg.ColumnInfo = resources.GetString("m_fg.ColumnInfo");
            this.m_fg.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.m_fg.Location = new System.Drawing.Point(0, 121);
            this.m_fg.Name = "m_fg";
            this.m_fg.SelectionMode = C1.Win.C1FlexGrid.SelectionModeEnum.Row;
            this.m_fg.Size = new System.Drawing.Size(1189, 415);
            this.m_fg.Styles = new C1.Win.C1FlexGrid.CellStyleCollection(resources.GetString("m_fg.Styles"));
            this.m_fg.TabIndex = 29;
            this.m_tooltip.SetToolTip(this.m_fg, "Nháy đúp vào dòng đơn vị cần chỉnh sửa");
            this.m_fg.Tree.LineColor = System.Drawing.Color.Maroon;
            this.m_fg.DoubleClick += new System.EventHandler(this.m_fg_DoubleClick);
            // 
            // m_cbo_trangthai
            // 
            this.m_cbo_trangthai.FormattingEnabled = true;
            this.m_cbo_trangthai.Location = new System.Drawing.Point(84, 72);
            this.m_cbo_trangthai.Name = "m_cbo_trangthai";
            this.m_cbo_trangthai.Size = new System.Drawing.Size(197, 21);
            this.m_cbo_trangthai.TabIndex = 29;
            // 
            // m_cbo_loaidv
            // 
            this.m_cbo_loaidv.FormattingEnabled = true;
            this.m_cbo_loaidv.Location = new System.Drawing.Point(84, 45);
            this.m_cbo_loaidv.Name = "m_cbo_loaidv";
            this.m_cbo_loaidv.Size = new System.Drawing.Size(197, 21);
            this.m_cbo_loaidv.TabIndex = 30;
            // 
            // m_cbo_capdv
            // 
            this.m_cbo_capdv.FormattingEnabled = true;
            this.m_cbo_capdv.Location = new System.Drawing.Point(84, 20);
            this.m_cbo_capdv.Name = "m_cbo_capdv";
            this.m_cbo_capdv.Size = new System.Drawing.Size(197, 21);
            this.m_cbo_capdv.TabIndex = 31;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.m_cbo_capdv);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.m_cbo_trangthai);
            this.groupBox1.Controls.Add(this.m_cbo_loaidv);
            this.groupBox1.Location = new System.Drawing.Point(32, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(287, 96);
            this.groupBox1.TabIndex = 30;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "groupBox1";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(16, 48);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(63, 13);
            this.label1.TabIndex = 31;
            this.label1.Text = "Loại đơn vị:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(16, 23);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(62, 13);
            this.label3.TabIndex = 32;
            this.label3.Text = "Cấp đơn vị:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(16, 75);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(58, 13);
            this.label4.TabIndex = 33;
            this.label4.Text = "Trạng thái:";
            // 
            // f101_v_dm_don_vi
            // 
            this.AutoScaleBaseSize = new System.Drawing.Size(5, 13);
            this.ClientSize = new System.Drawing.Size(1189, 572);
            this.Controls.Add(this.m_fg);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.m_pnl_out_place_dm);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "f101_v_dm_don_vi";
            this.Text = "F101 - Danh sách đơn vị";
            this.Load += new System.EventHandler(this.f101_v_dm_don_vi_Load);
            this.m_pnl_out_place_dm.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.m_fg)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }
        #endregion

        #region Public Interface
        public void display() {
            ShowDialog();
        }
        public void select_data(ref US_DM_DON_VI op_us_dm_don_vi) {
            m_e_form_mode = DataEntryFormMode.SelectDataState;
            ShowDialog();
            op_us_dm_don_vi = m_us;

        }
        #endregion

        #region Data Structure
        private enum e_col_Number {
            TEN_DON_VI_CAP_TREN = 2
                ,
            ID_CAP_DON_VI = 6
                ,
            TEN_TIENG_ANH = 11
                ,
            ID = 4
                ,
            TEN_DON_VI = 10
                ,
            TEN_TIENG_ANH_DON_VI_CAP_TREN = 9
                ,
            MA_DON_VI = 3
                ,
            TRANG_THAI = 15
                ,
            CAP_DON_VI = 12
                ,
            MA_DON_VI_CAP_TREN = 8
                ,
            TU_NGAY = 14
                ,
            ID_DON_VI_CAP_TREN = 5
                ,
            LOAI_DON_VI = 13
                ,
            ID_LOAI_DON_VI = 7
                ,
            DIA_BAN = 1

        }
        #endregion

        #region Members
        ITransferDataRow m_obj_trans;
        DS_V_DM_DON_VI m_v_ds = new DS_V_DM_DON_VI();
        US_V_DM_DON_VI m_v_us = new US_V_DM_DON_VI();
        DS_DM_DON_VI m_ds = new DS_DM_DON_VI();
        US_DM_DON_VI m_us = new US_DM_DON_VI();
        private const String m_str_goi_y_tim_kiem = "Nhập Tên đơn vị, Mã đơn vị, Địa bàn, Cấp đơn vị...";
        DataEntryFormMode m_e_form_mode = DataEntryFormMode.ViewDataState;
        //const int TAT_CA = -1;
        const string DANG_SU_DUNG = "Y";
        const string HET_SU_DUNG = "N";
        #endregion

        #region Private Methods

        private void format_controls() {
            CControlFormat.setFormStyle(this, new CAppContext_201());
            CControlFormat.setC1FlexFormat(m_fg);
            CGridUtils.AddSave_Excel_Handlers(m_fg);
            CGridUtils.AddSearch_Handlers(m_fg);
            m_fg.Tree.Column = (int)e_col_Number.DIA_BAN;
            //m_fg.Cols[(int) e_col_Number.TEN_DON_VI_CAP_TREN].Visible = false;
               m_fg.Tree.Style = TreeStyleFlags.SimpleLeaf;
            
            KeyPreview = true;
            WinFormControls.load_data_to_cbo_tu_dien(BKI_HRM.WinFormControls.eLOAI_TU_DIEN.LOAI_DON_VI,
                WinFormControls.eTAT_CA.YES, m_cbo_loaidv);
            WinFormControls.load_data_to_cbo_tu_dien(BKI_HRM.WinFormControls.eLOAI_TU_DIEN.CAP_DON_VI,
                WinFormControls.eTAT_CA.YES, m_cbo_capdv);
            load_data_2_cbo_trang_thai();
            set_define_events();
        }
        private void set_initial_form_load() {
            switch (m_e_form_mode) {
                case DataEntryFormMode.UpdateDataState:
                    m_cmd_chon_don_vi.Visible = false;
                    break;
                case DataEntryFormMode.InsertDataState:
                    m_cmd_chon_don_vi.Visible = false;
                    break;
                case DataEntryFormMode.ViewDataState:
                    m_cmd_chon_don_vi.Visible = false;
                    break;
                case DataEntryFormMode.SelectDataState:
                    m_cmd_chon_don_vi.Visible = true;
                    m_cmd_chon_don_vi.Enabled = true;
                    m_cmd_insert.Visible = false;
                    m_cmd_update.Visible = false;
                    m_cmd_delete.Visible = false;
                    break;

            }
            m_obj_trans = get_trans_object(m_fg);
            load_data_2_grid();
        }
        private ITransferDataRow get_trans_object(C1FlexGrid i_fg) {
            Hashtable v_htb = new Hashtable();
            v_htb.Add(V_DM_DON_VI.TEN_DON_VI_CAP_TREN, e_col_Number.TEN_DON_VI_CAP_TREN);
            v_htb.Add(V_DM_DON_VI.ID_CAP_DON_VI, e_col_Number.ID_CAP_DON_VI);
            v_htb.Add(V_DM_DON_VI.TEN_TIENG_ANH, e_col_Number.TEN_TIENG_ANH);
            v_htb.Add(V_DM_DON_VI.ID, e_col_Number.ID);
            v_htb.Add(V_DM_DON_VI.TEN_DON_VI, e_col_Number.TEN_DON_VI);
            v_htb.Add(V_DM_DON_VI.TEN_TIENG_ANH_DON_VI_CAP_TREN, e_col_Number.TEN_TIENG_ANH_DON_VI_CAP_TREN);
            v_htb.Add(V_DM_DON_VI.MA_DON_VI, e_col_Number.MA_DON_VI);
            v_htb.Add(V_DM_DON_VI.TRANG_THAI, e_col_Number.TRANG_THAI);
            v_htb.Add(V_DM_DON_VI.CAP_DON_VI, e_col_Number.CAP_DON_VI);
            v_htb.Add(V_DM_DON_VI.MA_DON_VI_CAP_TREN, e_col_Number.MA_DON_VI_CAP_TREN);
            v_htb.Add(V_DM_DON_VI.TU_NGAY, e_col_Number.TU_NGAY);
            v_htb.Add(V_DM_DON_VI.ID_DON_VI_CAP_TREN, e_col_Number.ID_DON_VI_CAP_TREN);
            v_htb.Add(V_DM_DON_VI.LOAI_DON_VI, e_col_Number.LOAI_DON_VI);
            v_htb.Add(V_DM_DON_VI.ID_LOAI_DON_VI, e_col_Number.ID_LOAI_DON_VI);
            v_htb.Add(V_DM_DON_VI.DIA_BAN, e_col_Number.DIA_BAN);

            ITransferDataRow v_obj_trans = new CC1TransferDataRow(i_fg, v_htb, m_v_ds.V_DM_DON_VI.NewRow());
            return v_obj_trans;
        }
        private void load_data_2_grid() {
            m_v_ds = new DS_V_DM_DON_VI();
            var v_str_search = m_txt_search.Text.Trim();
            if (v_str_search.Equals(m_str_goi_y_tim_kiem)) {
                v_str_search = "";
            }
            m_v_us.FillDatasetByKeyWord(m_v_ds, v_str_search, CIPConvert.ToDecimal(m_cbo_loaidv.SelectedValue),CIPConvert.ToDecimal(m_cbo_capdv.SelectedValue),m_cbo_trangthai.SelectedValue.ToString());
            m_fg.Redraw = false;
            CGridUtils.Dataset2C1Grid(m_v_ds, m_fg, m_obj_trans);
            // Group (subtotal) trên grid.
            m_fg.Subtotal(AggregateEnum.Count
              , 0
              , (int)e_col_Number.DIA_BAN   // Group theo cột này
              , (int)e_col_Number.TEN_DON_VI             // Subtotal theo cột này
              , "{0}"
              );
            m_fg.Subtotal(AggregateEnum.Count
              , 1
              , (int)e_col_Number.TEN_DON_VI_CAP_TREN   // Group theo cột này
              , (int)e_col_Number.TEN_DON_VI             // Subtotal theo cột này
              , "{0}"
              );
            load_custom_source_2_m_txt_search();
            m_fg.Redraw = true;
            set_search_format_before();
            /*Đếm số dòng dữ liệu trên Grid*/
            m_lbl_so_luong_ban_ghi.Text = m_v_ds.V_DM_DON_VI.Count.ToString();
        }
        private void load_custom_source_2_m_txt_search() {
            m_txt_search.AutoCompleteMode = AutoCompleteMode.Suggest;
            m_txt_search.AutoCompleteSource = AutoCompleteSource.CustomSource;
            var v_coll = new AutoCompleteStringCollection();
            var v_rows = m_v_ds.Tables[0].Rows;
            for (var i = 0; i < v_rows.Count - 1; i++) {
                v_coll.Add(v_rows[i]["MA_DON_VI"] + "");
                v_coll.Add(v_rows[i]["TEN_DON_VI"] + "");
                v_coll.Add(v_rows[i]["TEN_DON_VI_CAP_TREN"] + "" );
                v_coll.Add(v_rows[i]["TEN_TIENG_ANH"] + "");
            }
            m_txt_search.AutoCompleteCustomSource = v_coll;
        }
        private void grid2us_object(int i_grid_row) {
            DataRow v_dr;
            v_dr = (DataRow)m_fg.Rows[i_grid_row].UserData;
            m_us = new US_DM_DON_VI((decimal)v_dr.ItemArray[0]);
        }
        private void grid2us_object(US_V_DM_DON_VI i_us, int i_grid_row) {
            DataRow v_dr;
            v_dr = (DataRow)m_fg.Rows[i_grid_row].UserData;
            m_obj_trans.GridRow2DataRow(i_grid_row, v_dr);
            i_us.DataRow2Me(v_dr);
        }
        private void select_data_2_us() {
            if (!CGridUtils.IsThere_Any_NonFixed_Row(m_fg))
                return;
            if (!CGridUtils.isValid_NonFixed_RowIndex(m_fg, m_fg.Row))
                return;

            try {
                grid2us_object(m_fg.Row);
                Close();
            } catch (Exception v_e) {
                MessageBox.Show("Dòng chọn không hợp lệ. Mời chọn dòng khác", "Cảnh báo");
            }

        }
        private void insert_v_dm_don_vi() {
            var v_fDE = new f102_v_dm_don_vi_de();
            v_fDE.display_for_insert();
            load_data_2_grid();
            //-- Focus to row edited
            //m_us.FillDataset(m_ds, "");
            WinFormControls.set_focus_for_grid(m_fg, m_us.strMA_DON_VI, (int)e_col_Number.MA_DON_VI);
        }
        private void update_v_dm_don_vi() {
            if (!CGridUtils.IsThere_Any_NonFixed_Row(m_fg)) return;
            if (!CGridUtils.isValid_NonFixed_RowIndex(m_fg, m_fg.Row)) return;
            if (m_fg.Rows[m_fg.Row].IsNode) return;
            grid2us_object(m_v_us, m_fg.Row);
            var v_f_de = new f102_v_dm_don_vi_de();
            v_f_de.display_for_update(m_v_us);
            load_data_2_grid();
        }

        private void delete_v_dm_don_vi() {
            if (!CGridUtils.IsThere_Any_NonFixed_Row(m_fg)) return;
            if (!CGridUtils.isValid_NonFixed_RowIndex(m_fg, m_fg.Row)) return;
            if (BaseMessages.askUser_DataCouldBeDeleted(8) != BaseMessages.IsDataCouldBeDeleted.CouldBeDeleted) return;
            var v_us = new US_V_DM_DON_VI();
            grid2us_object(v_us, m_fg.Row);
            try {
                v_us.BeginTransaction();
                v_us.Delete();
                v_us.CommitTransaction();
                m_fg.Rows.Remove(m_fg.Row);
            } catch (Exception v_e) {
                v_us.Rollback();
                var v_objErrHandler = new CDBExceptionHandler(v_e,
                    new CDBClientDBExceptionInterpret());
                v_objErrHandler.showErrorMessage();
            }
        }
        private void set_search_format_before() {
            if (m_txt_search.Text == "") {
                m_txt_search.Text = m_str_goi_y_tim_kiem;
                m_txt_search.ForeColor = Color.Gray;
            }
        }
        private void set_search_format_after() {
            if (m_txt_search.Text == m_str_goi_y_tim_kiem) {
                m_txt_search.Text = "";
            }
            m_txt_search.ForeColor = Color.Black;
        }
        private void xem_nhan_su()
        {
            if (!CGridUtils.IsThere_Any_NonFixed_Row(m_fg)) return;
            if (!CGridUtils.isValid_NonFixed_RowIndex(m_fg, m_fg.Row)) return;
            if (m_fg.Rows[m_fg.Row].IsNode) return;
            grid2us_object(m_v_us, m_fg.Row);
            var frm = new f104_bao_cao_nhan_su_theo_phong_ban();
            frm.display_for_dm_don_vi(m_v_us.strMA_DON_VI.ToString());
        }
        private void load_data_2_cbo_trang_thai()
        {
            DataTable v_dt = new DataTable();
            v_dt.Columns.Add("GIA_TRI");
            v_dt.Columns.Add("HIEN_THI");
           // v_dt.Rows.Add(TAT_CA, "------ Tất cả ------");
            v_dt.Rows.Add(DANG_SU_DUNG, "Đang sử dụng");
            v_dt.Rows.Add(HET_SU_DUNG, "Hết sử dụng");
            m_cbo_trangthai.DisplayMember = "HIEN_THI";
            m_cbo_trangthai.ValueMember = "GIA_TRI";
            m_cbo_trangthai.DataSource = v_dt;
        }
        #endregion

        //
        //
        //		EVENT HANLDERS
        //
        //

        private void set_define_events() {
            m_cmd_exit.Click += m_cmd_exit_Click;
            m_cmd_insert.Click += m_cmd_insert_Click;
            m_cmd_update.Click += m_cmd_update_Click;
            m_cmd_delete.Click += m_cmd_delete_Click;
            m_cmd_search.Click += m_cmd_search_Click;
            m_txt_search.KeyDown += m_txt_search_KeyDown;
            m_txt_search.MouseClick += m_txt_search_MouseClick;
            m_txt_search.Leave += m_txt_search_Leave;
            m_cbo_capdv.SelectedValueChanged += m_cbo_capdv_SelectedValueChanged;
            m_cbo_loaidv.SelectedValueChanged += m_cbo_loaidv_SelectedValueChanged;
            m_cbo_trangthai.SelectedValueChanged += m_cbo_trangthai_SelectedValueChanged;
        }

        private void f101_v_dm_don_vi_Load(object sender, EventArgs e) {
            try {
                set_initial_form_load();
            } catch (Exception v_e) {
                CSystemLog_301.ExceptionHandle(v_e);
            }

        }

        private void m_cmd_exit_Click(object sender, EventArgs e) {
            try {
                Close();
            } catch (Exception v_e) {
                CSystemLog_301.ExceptionHandle(v_e);
            }
        }

        private void m_cmd_insert_Click(object sender, EventArgs e) {
            try {
                insert_v_dm_don_vi();
            } catch (Exception v_e) {
                CSystemLog_301.ExceptionHandle(v_e);
            }
        }

        private void m_cmd_update_Click(object sender, EventArgs e) {
            try {
                update_v_dm_don_vi();
            } catch (Exception v_e) {
                CSystemLog_301.ExceptionHandle(v_e);
            }
        }

        private void m_cmd_delete_Click(object sender, EventArgs e) {
            try {
                delete_v_dm_don_vi();
            } catch (Exception v_e) {
                CSystemLog_301.ExceptionHandle(v_e);
            }
        }

        private void m_cmd_search_Click(object sender, EventArgs e) {
            try {
                load_data_2_grid();
            } catch (Exception v_e) {
                CSystemLog_301.ExceptionHandle(v_e);
            }
        }

        private void m_cmd_chon_don_vi_Click(object sender, EventArgs e) {
            try {
                select_data_2_us();
            } catch (Exception v_e) {
                CSystemLog_301.ExceptionHandle(v_e);
            }
        }

        private void m_txt_search_KeyDown(object sender, KeyEventArgs e) {
            try {
                if (e.KeyData == Keys.Enter) {
                    load_data_2_grid();
                } else {
                    set_search_format_after();
                }
            } catch (Exception v_e) {
                CSystemLog_301.ExceptionHandle(v_e);
            }
        }

        private void m_txt_search_MouseClick(object sender, MouseEventArgs e) {
            try {
                set_search_format_after();
            } catch (Exception v_e) {
                CSystemLog_301.ExceptionHandle(v_e);
            }
        }

        private void m_txt_search_Leave(object sender, EventArgs e) {
            try {
                set_search_format_before();
            } catch (Exception v_e) {
                CSystemLog_301.ExceptionHandle(v_e);
            }
        }

        private void m_fg_DoubleClick(object sender, EventArgs e)
        {
            try
            {
                xem_nhan_su();
            }
            catch (Exception v_e)
            {
                CSystemLog_301.ExceptionHandle(v_e);
            }
        }
        private void m_cbo_capdv_SelectedValueChanged(object sender, EventArgs e)
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
        private void m_cbo_loaidv_SelectedValueChanged(object sender, EventArgs e)
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
        private void m_cbo_trangthai_SelectedValueChanged(object sender, EventArgs e)
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
    }
}

