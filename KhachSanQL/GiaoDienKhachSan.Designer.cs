namespace KhachSanQL
{
    partial class GiaoDienKhachSan
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
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
            this.dataViewPhongGD = new System.Windows.Forms.DataGridView();
            this.TENPHONG = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TRANGTHAI = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TENTANG = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TENLOAIPHONG = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabDatPhong = new System.Windows.Forms.TabPage();
            this.dateTimeCheckOut = new System.Windows.Forms.DateTimePicker();
            this.dateTimeCheckin = new System.Windows.Forms.DateTimePicker();
            this.label6 = new System.Windows.Forms.Label();
            this.cmbSanPham = new System.Windows.Forms.ComboBox();
            this.textSoNgayLuuTru = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.textSDTKhachHang = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.tabPageTaiKhoan = new System.Windows.Forms.TabPage();
            this.btnDatPhong = new System.Windows.Forms.Button();
            this.btnTraPhong = new System.Windows.Forms.Button();
            this.groupDatPhong = new System.Windows.Forms.GroupBox();
            this.cmbSoPhong = new System.Windows.Forms.ComboBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.tabKhachHang = new System.Windows.Forms.TabPage();
            this.dataViewKhachhang = new System.Windows.Forms.DataGridView();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.textHoTen = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.textSDTKH = new System.Windows.Forms.TextBox();
            this.textCCCD = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.textEmail = new System.Windows.Forms.TextBox();
            this.label12 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.textDiaChi = new System.Windows.Forms.RichTextBox();
            this.btncheckSDT = new System.Windows.Forms.Button();
            this.btnThemKH = new System.Windows.Forms.Button();
            this.IDKH = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.HOTEN = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DIENTHOAI = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CCCD = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.EMAIL = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DIACHI = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.button1 = new System.Windows.Forms.Button();
            this.btnLamMoi = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.dataViewPhongGD)).BeginInit();
            this.tabControl1.SuspendLayout();
            this.tabDatPhong.SuspendLayout();
            this.tabPageTaiKhoan.SuspendLayout();
            this.groupDatPhong.SuspendLayout();
            this.tabKhachHang.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataViewKhachhang)).BeginInit();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // dataViewPhongGD
            // 
            this.dataViewPhongGD.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataViewPhongGD.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.TENPHONG,
            this.TRANGTHAI,
            this.TENTANG,
            this.TENLOAIPHONG});
            this.dataViewPhongGD.Location = new System.Drawing.Point(3, 6);
            this.dataViewPhongGD.Name = "dataViewPhongGD";
            this.dataViewPhongGD.RowHeadersWidth = 51;
            this.dataViewPhongGD.RowTemplate.Height = 24;
            this.dataViewPhongGD.Size = new System.Drawing.Size(406, 667);
            this.dataViewPhongGD.TabIndex = 1;
            this.dataViewPhongGD.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataViewPhongGD_CellClick);
            // 
            // TENPHONG
            // 
            this.TENPHONG.DataPropertyName = "TENPHONG";
            this.TENPHONG.HeaderText = "Số Phòng";
            this.TENPHONG.MinimumWidth = 6;
            this.TENPHONG.Name = "TENPHONG";
            this.TENPHONG.Width = 50;
            // 
            // TRANGTHAI
            // 
            this.TRANGTHAI.DataPropertyName = "TRANGTHAI";
            this.TRANGTHAI.HeaderText = "Trạng Thái";
            this.TRANGTHAI.MinimumWidth = 6;
            this.TRANGTHAI.Name = "TRANGTHAI";
            this.TRANGTHAI.Width = 125;
            // 
            // TENTANG
            // 
            this.TENTANG.DataPropertyName = "TENTANG";
            this.TENTANG.HeaderText = "Tầng";
            this.TENTANG.MinimumWidth = 6;
            this.TENTANG.Name = "TENTANG";
            this.TENTANG.Width = 50;
            // 
            // TENLOAIPHONG
            // 
            this.TENLOAIPHONG.DataPropertyName = "TENLOAIPHONG";
            this.TENLOAIPHONG.HeaderText = "Loại Phòng";
            this.TENLOAIPHONG.MinimumWidth = 6;
            this.TENLOAIPHONG.Name = "TENLOAIPHONG";
            this.TENLOAIPHONG.Width = 60;
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabDatPhong);
            this.tabControl1.Controls.Add(this.tabPageTaiKhoan);
            this.tabControl1.Controls.Add(this.tabKhachHang);
            this.tabControl1.Location = new System.Drawing.Point(3, 5);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.Padding = new System.Drawing.Point(60, 3);
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(1211, 739);
            this.tabControl1.TabIndex = 2;
            // 
            // tabDatPhong
            // 
            this.tabDatPhong.Controls.Add(this.groupBox1);
            this.tabDatPhong.Controls.Add(this.groupDatPhong);
            this.tabDatPhong.Controls.Add(this.dataViewPhongGD);
            this.tabDatPhong.Location = new System.Drawing.Point(4, 25);
            this.tabDatPhong.Name = "tabDatPhong";
            this.tabDatPhong.Padding = new System.Windows.Forms.Padding(3);
            this.tabDatPhong.Size = new System.Drawing.Size(1203, 710);
            this.tabDatPhong.TabIndex = 0;
            this.tabDatPhong.Text = "Đặt Phòng";
            this.tabDatPhong.UseVisualStyleBackColor = true;
            // 
            // dateTimeCheckOut
            // 
            this.dateTimeCheckOut.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dateTimeCheckOut.Location = new System.Drawing.Point(134, 217);
            this.dateTimeCheckOut.Name = "dateTimeCheckOut";
            this.dateTimeCheckOut.Size = new System.Drawing.Size(195, 22);
            this.dateTimeCheckOut.TabIndex = 15;
            // 
            // dateTimeCheckin
            // 
            this.dateTimeCheckin.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dateTimeCheckin.Location = new System.Drawing.Point(134, 160);
            this.dateTimeCheckin.Name = "dateTimeCheckin";
            this.dateTimeCheckin.Size = new System.Drawing.Size(195, 22);
            this.dateTimeCheckin.TabIndex = 14;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(8, 332);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(54, 16);
            this.label6.TabIndex = 13;
            this.label6.Text = "Dịch vụ:";
            // 
            // cmbSanPham
            // 
            this.cmbSanPham.FormattingEnabled = true;
            this.cmbSanPham.Location = new System.Drawing.Point(134, 325);
            this.cmbSanPham.Name = "cmbSanPham";
            this.cmbSanPham.Size = new System.Drawing.Size(195, 24);
            this.cmbSanPham.TabIndex = 12;
            // 
            // textSoNgayLuuTru
            // 
            this.textSoNgayLuuTru.Location = new System.Drawing.Point(134, 267);
            this.textSoNgayLuuTru.Name = "textSoNgayLuuTru";
            this.textSoNgayLuuTru.Size = new System.Drawing.Size(195, 22);
            this.textSoNgayLuuTru.TabIndex = 11;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(8, 272);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(97, 16);
            this.label5.TabIndex = 10;
            this.label5.Text = "Số ngày lưu trú:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(8, 216);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(58, 16);
            this.label3.TabIndex = 9;
            this.label3.Text = "Ngày ra:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(8, 159);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(62, 16);
            this.label4.TabIndex = 8;
            this.label4.Text = "Ngày đặt";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(8, 103);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(111, 16);
            this.label2.TabIndex = 7;
            this.label2.Text = "SDT Khách hàng:";
            // 
            // textSDTKhachHang
            // 
            this.textSDTKhachHang.Location = new System.Drawing.Point(134, 98);
            this.textSDTKhachHang.Name = "textSDTKhachHang";
            this.textSDTKhachHang.Size = new System.Drawing.Size(195, 22);
            this.textSDTKhachHang.TabIndex = 4;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(8, 51);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(69, 16);
            this.label1.TabIndex = 3;
            this.label1.Text = "Số Phòng:";
            // 
            // tabPageTaiKhoan
            // 
            this.tabPageTaiKhoan.Controls.Add(this.pictureBox1);
            this.tabPageTaiKhoan.Controls.Add(this.button1);
            this.tabPageTaiKhoan.Controls.Add(this.label8);
            this.tabPageTaiKhoan.Controls.Add(this.label7);
            this.tabPageTaiKhoan.Location = new System.Drawing.Point(4, 25);
            this.tabPageTaiKhoan.Name = "tabPageTaiKhoan";
            this.tabPageTaiKhoan.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageTaiKhoan.Size = new System.Drawing.Size(1203, 710);
            this.tabPageTaiKhoan.TabIndex = 1;
            this.tabPageTaiKhoan.Text = "Tài khoản";
            this.tabPageTaiKhoan.UseVisualStyleBackColor = true;
            // 
            // btnDatPhong
            // 
            this.btnDatPhong.Location = new System.Drawing.Point(24, 378);
            this.btnDatPhong.Name = "btnDatPhong";
            this.btnDatPhong.Size = new System.Drawing.Size(127, 43);
            this.btnDatPhong.TabIndex = 17;
            this.btnDatPhong.Text = "Đặt Phòng";
            this.btnDatPhong.UseVisualStyleBackColor = true;
            this.btnDatPhong.Click += new System.EventHandler(this.btnDatPhong_Click);
            // 
            // btnTraPhong
            // 
            this.btnTraPhong.Location = new System.Drawing.Point(212, 378);
            this.btnTraPhong.Name = "btnTraPhong";
            this.btnTraPhong.Size = new System.Drawing.Size(127, 43);
            this.btnTraPhong.TabIndex = 18;
            this.btnTraPhong.Text = "Trả Phòng";
            this.btnTraPhong.UseVisualStyleBackColor = true;
            this.btnTraPhong.Click += new System.EventHandler(this.btnTraPhong_Click);
            // 
            // groupDatPhong
            // 
            this.groupDatPhong.Controls.Add(this.cmbSoPhong);
            this.groupDatPhong.Controls.Add(this.btnTraPhong);
            this.groupDatPhong.Controls.Add(this.cmbSanPham);
            this.groupDatPhong.Controls.Add(this.btnDatPhong);
            this.groupDatPhong.Controls.Add(this.dateTimeCheckOut);
            this.groupDatPhong.Controls.Add(this.label1);
            this.groupDatPhong.Controls.Add(this.dateTimeCheckin);
            this.groupDatPhong.Controls.Add(this.textSDTKhachHang);
            this.groupDatPhong.Controls.Add(this.label6);
            this.groupDatPhong.Controls.Add(this.label2);
            this.groupDatPhong.Controls.Add(this.label4);
            this.groupDatPhong.Controls.Add(this.textSoNgayLuuTru);
            this.groupDatPhong.Controls.Add(this.label3);
            this.groupDatPhong.Controls.Add(this.label5);
            this.groupDatPhong.Location = new System.Drawing.Point(415, 10);
            this.groupDatPhong.Name = "groupDatPhong";
            this.groupDatPhong.Size = new System.Drawing.Size(382, 456);
            this.groupDatPhong.TabIndex = 19;
            this.groupDatPhong.TabStop = false;
            this.groupDatPhong.Text = "Đặt phòng";
            // 
            // cmbSoPhong
            // 
            this.cmbSoPhong.FormattingEnabled = true;
            this.cmbSoPhong.Location = new System.Drawing.Point(134, 45);
            this.cmbSoPhong.Name = "cmbSoPhong";
            this.cmbSoPhong.Size = new System.Drawing.Size(195, 24);
            this.cmbSoPhong.TabIndex = 19;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(495, 171);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(30, 16);
            this.label7.TabIndex = 0;
            this.label7.Text = "UID";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(472, 209);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(84, 16);
            this.label8.TabIndex = 1;
            this.label8.Text = "USERNAME";
            // 
            // tabKhachHang
            // 
            this.tabKhachHang.Controls.Add(this.btnLamMoi);
            this.tabKhachHang.Controls.Add(this.dataViewKhachhang);
            this.tabKhachHang.Location = new System.Drawing.Point(4, 25);
            this.tabKhachHang.Name = "tabKhachHang";
            this.tabKhachHang.Padding = new System.Windows.Forms.Padding(3);
            this.tabKhachHang.Size = new System.Drawing.Size(1203, 679);
            this.tabKhachHang.TabIndex = 2;
            this.tabKhachHang.Text = "Khách hàng";
            this.tabKhachHang.UseVisualStyleBackColor = true;
            // 
            // dataViewKhachhang
            // 
            this.dataViewKhachhang.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataViewKhachhang.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.IDKH,
            this.HOTEN,
            this.DIENTHOAI,
            this.CCCD,
            this.EMAIL,
            this.DIACHI});
            this.dataViewKhachhang.Location = new System.Drawing.Point(7, 58);
            this.dataViewKhachhang.Name = "dataViewKhachhang";
            this.dataViewKhachhang.RowHeadersWidth = 51;
            this.dataViewKhachhang.RowTemplate.Height = 24;
            this.dataViewKhachhang.Size = new System.Drawing.Size(1193, 507);
            this.dataViewKhachhang.TabIndex = 0;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btnThemKH);
            this.groupBox1.Controls.Add(this.btncheckSDT);
            this.groupBox1.Controls.Add(this.textDiaChi);
            this.groupBox1.Controls.Add(this.label13);
            this.groupBox1.Controls.Add(this.label12);
            this.groupBox1.Controls.Add(this.textEmail);
            this.groupBox1.Controls.Add(this.label11);
            this.groupBox1.Controls.Add(this.textCCCD);
            this.groupBox1.Controls.Add(this.textSDTKH);
            this.groupBox1.Controls.Add(this.label10);
            this.groupBox1.Controls.Add(this.label9);
            this.groupBox1.Controls.Add(this.textHoTen);
            this.groupBox1.Location = new System.Drawing.Point(815, 10);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(361, 456);
            this.groupBox1.TabIndex = 20;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Khách Hàng";
            // 
            // textHoTen
            // 
            this.textHoTen.Location = new System.Drawing.Point(146, 45);
            this.textHoTen.Name = "textHoTen";
            this.textHoTen.Size = new System.Drawing.Size(195, 22);
            this.textHoTen.TabIndex = 20;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(15, 103);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(111, 16);
            this.label9.TabIndex = 20;
            this.label9.Text = "SDT Khách hàng:";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(15, 51);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(67, 16);
            this.label10.TabIndex = 20;
            this.label10.Text = "Họ và tên:";
            // 
            // textSDTKH
            // 
            this.textSDTKH.Location = new System.Drawing.Point(146, 97);
            this.textSDTKH.Name = "textSDTKH";
            this.textSDTKH.Size = new System.Drawing.Size(195, 22);
            this.textSDTKH.TabIndex = 21;
            // 
            // textCCCD
            // 
            this.textCCCD.Location = new System.Drawing.Point(146, 200);
            this.textCCCD.Name = "textCCCD";
            this.textCCCD.Size = new System.Drawing.Size(195, 22);
            this.textCCCD.TabIndex = 22;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(15, 207);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(91, 16);
            this.label11.TabIndex = 23;
            this.label11.Text = "CCCD/CMND:";
            // 
            // textEmail
            // 
            this.textEmail.Location = new System.Drawing.Point(146, 252);
            this.textEmail.Name = "textEmail";
            this.textEmail.Size = new System.Drawing.Size(195, 22);
            this.textEmail.TabIndex = 24;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(15, 255);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(44, 16);
            this.label12.TabIndex = 20;
            this.label12.Text = "Email:";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(15, 324);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(50, 16);
            this.label13.TabIndex = 25;
            this.label13.Text = "Địa chỉ:";
            // 
            // textDiaChi
            // 
            this.textDiaChi.Location = new System.Drawing.Point(146, 298);
            this.textDiaChi.Name = "textDiaChi";
            this.textDiaChi.Size = new System.Drawing.Size(195, 67);
            this.textDiaChi.TabIndex = 27;
            this.textDiaChi.Text = "";
            // 
            // btncheckSDT
            // 
            this.btncheckSDT.Location = new System.Drawing.Point(182, 143);
            this.btncheckSDT.Name = "btncheckSDT";
            this.btncheckSDT.Size = new System.Drawing.Size(113, 32);
            this.btncheckSDT.TabIndex = 28;
            this.btncheckSDT.Text = "Check";
            this.btncheckSDT.UseVisualStyleBackColor = true;
            this.btncheckSDT.Click += new System.EventHandler(this.btncheckSDT_Click);
            // 
            // btnThemKH
            // 
            this.btnThemKH.Location = new System.Drawing.Point(121, 392);
            this.btnThemKH.Name = "btnThemKH";
            this.btnThemKH.Size = new System.Drawing.Size(127, 43);
            this.btnThemKH.TabIndex = 20;
            this.btnThemKH.Text = "Thêm";
            this.btnThemKH.UseVisualStyleBackColor = true;
            this.btnThemKH.Click += new System.EventHandler(this.btnThemKH_Click);
            // 
            // IDKH
            // 
            this.IDKH.DataPropertyName = "IDKH";
            this.IDKH.HeaderText = "ID Khách Hàng";
            this.IDKH.MinimumWidth = 6;
            this.IDKH.Name = "IDKH";
            this.IDKH.Width = 125;
            // 
            // HOTEN
            // 
            this.HOTEN.DataPropertyName = "HOTEN";
            this.HOTEN.HeaderText = "Họ và Tên";
            this.HOTEN.MinimumWidth = 6;
            this.HOTEN.Name = "HOTEN";
            this.HOTEN.Width = 125;
            // 
            // DIENTHOAI
            // 
            this.DIENTHOAI.DataPropertyName = "DIENTHOAI";
            this.DIENTHOAI.HeaderText = "SDT";
            this.DIENTHOAI.MinimumWidth = 6;
            this.DIENTHOAI.Name = "DIENTHOAI";
            this.DIENTHOAI.Width = 125;
            // 
            // CCCD
            // 
            this.CCCD.DataPropertyName = "CCCD";
            this.CCCD.HeaderText = "CCCD/CMND";
            this.CCCD.MinimumWidth = 6;
            this.CCCD.Name = "CCCD";
            this.CCCD.Width = 125;
            // 
            // EMAIL
            // 
            this.EMAIL.DataPropertyName = "EMAIL";
            this.EMAIL.HeaderText = "Email";
            this.EMAIL.MinimumWidth = 6;
            this.EMAIL.Name = "EMAIL";
            this.EMAIL.Width = 125;
            // 
            // DIACHI
            // 
            this.DIACHI.DataPropertyName = "DIACHI";
            this.DIACHI.HeaderText = "Địa chỉ";
            this.DIACHI.MinimumWidth = 6;
            this.DIACHI.Name = "DIACHI";
            this.DIACHI.Width = 125;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(457, 272);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(99, 44);
            this.button1.TabIndex = 2;
            this.button1.Text = "Đăng Xuất";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // btnLamMoi
            // 
            this.btnLamMoi.Location = new System.Drawing.Point(472, 15);
            this.btnLamMoi.Name = "btnLamMoi";
            this.btnLamMoi.Size = new System.Drawing.Size(140, 31);
            this.btnLamMoi.TabIndex = 1;
            this.btnLamMoi.Text = "Làm mới";
            this.btnLamMoi.UseVisualStyleBackColor = true;
            this.btnLamMoi.Click += new System.EventHandler(this.btnLamMoi_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Location = new System.Drawing.Point(414, 39);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(194, 115);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 3;
            this.pictureBox1.TabStop = false;
            // 
            // GiaoDienKhachSan
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1213, 747);
            this.Controls.Add(this.tabControl1);
            this.Name = "GiaoDienKhachSan";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Khách sạn 1 2 3 ZO";
            this.Load += new System.EventHandler(this.GiaoDienKhachSan_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataViewPhongGD)).EndInit();
            this.tabControl1.ResumeLayout(false);
            this.tabDatPhong.ResumeLayout(false);
            this.tabPageTaiKhoan.ResumeLayout(false);
            this.tabPageTaiKhoan.PerformLayout();
            this.groupDatPhong.ResumeLayout(false);
            this.groupDatPhong.PerformLayout();
            this.tabKhachHang.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataViewKhachhang)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataViewPhongGD;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabDatPhong;
        private System.Windows.Forms.TabPage tabPageTaiKhoan;
        private System.Windows.Forms.DataGridViewTextBoxColumn TENPHONG;
        private System.Windows.Forms.DataGridViewTextBoxColumn TRANGTHAI;
        private System.Windows.Forms.DataGridViewTextBoxColumn TENTANG;
        private System.Windows.Forms.DataGridViewTextBoxColumn TENLOAIPHONG;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textSDTKhachHang;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DateTimePicker dateTimeCheckOut;
        private System.Windows.Forms.DateTimePicker dateTimeCheckin;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ComboBox cmbSanPham;
        private System.Windows.Forms.TextBox textSoNgayLuuTru;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button btnTraPhong;
        private System.Windows.Forms.Button btnDatPhong;
        private System.Windows.Forms.GroupBox groupDatPhong;
        private System.Windows.Forms.ComboBox cmbSoPhong;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TabPage tabKhachHang;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RichTextBox textDiaChi;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.TextBox textEmail;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.TextBox textCCCD;
        private System.Windows.Forms.TextBox textSDTKH;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox textHoTen;
        private System.Windows.Forms.DataGridView dataViewKhachhang;
        private System.Windows.Forms.Button btncheckSDT;
        private System.Windows.Forms.Button btnThemKH;
        private System.Windows.Forms.DataGridViewTextBoxColumn IDKH;
        private System.Windows.Forms.DataGridViewTextBoxColumn HOTEN;
        private System.Windows.Forms.DataGridViewTextBoxColumn DIENTHOAI;
        private System.Windows.Forms.DataGridViewTextBoxColumn CCCD;
        private System.Windows.Forms.DataGridViewTextBoxColumn EMAIL;
        private System.Windows.Forms.DataGridViewTextBoxColumn DIACHI;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button btnLamMoi;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}