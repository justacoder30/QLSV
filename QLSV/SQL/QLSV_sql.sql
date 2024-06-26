use QLSinhVien

--insert tblGiaoVien
select *from tblGiaoVien

insert into tblGiaoVien (ho, tendem, ten, gioitinh, ngaysinh, dienthoai, email, diachi) 
values
	(N'Nguyễn',N'Thị' , N'Mai', 1, '1988-01-01', '01223456897', 'thimai@gmail.com', N'123, Láng Hạ, Đống Đa, Hà Nội'),
	(N'Trần', N'Quang', N'Huy', 0, '1985-05-15', '0987654321', 'quanghuy85@gmail.com', N'45, Kim Mã, Ba Đình, Hà Nội'),
    (N'Lê', N'Thị', N'Lan', 1, '1990-07-20', '0912345678', 'lanle90@gmail.com', N'12, Phạm Ngọc Thạch, Đống Đa, Hà Nội'),
    (N'Phạm', N'Văn', N'Nam', 0, '1979-02-28', '0908765432', 'nampham79@gmail.com', N'56, Hoàng Quốc Việt, Cầu Giấy, Hà Nội'),
    (N'Đỗ', N'Thị', N'Hạnh', 1, '1982-11-11', '0934567890', 'hanhdo82@gmail.com', N'78, Lê Văn Lương, Thanh Xuân, Hà Nội'),
    (N'Bùi', N'Thanh', N'Tuấn', 0, '1988-04-04', '0981234567', 'tuanbui88@gmail.com', N'23, Trần Duy Hưng, Cầu Giấy, Hà Nội'),
    (N'Hoàng', N'Thúy', N'Minh', 1, '1992-09-09', '0976543210', 'minhhoang92@gmail.com', N'34, Thái Hà, Đống Đa, Hà Nội'),
    (N'Vũ', N'Tuấn', N'Kiệt', 0, '1983-06-06', '0965432109', 'kietvu83@gmail.com', N'89, Nguyễn Chí Thanh, Ba Đình, Hà Nội'),
    (N'Đặng', N'Thị', N'Phượng', 1, '1986-03-30', '0954321098', 'phuongdang86@gmail.com', N'65, Đội Cấn, Ba Đình, Hà Nội'),
    (N'Nguyễn', N'Văn', N'Trung', 0, '1991-12-12', '0943210987', 'trungnguyen91@gmail.com', N'123, Phạm Hùng, Từ Liêm, Hà Nội'),
    (N'Trần', N'Thị', N'Thu', 1, '1984-08-08', '0932109876', 'thutran84@gmail.com', N'87, Giải Phóng, Hoàng Mai, Hà Nội');

--insert tblMonHoc
select *from tblMonHoc

insert into tblMonHoc (tenmonhoc, sotinchi)
values 
    (N'Giáo dục thể chất (Chạy)', 1),
    (N'Toán 1', 3),
    (N'Triết học Mác - Lênin', 3),
    (N'Nhập môn ngành Công nghệ thông tin', 1),
    (N'Tin học đại cương A (LT+TH)', 3),
    (N'Pháp luật đại cương', 2),
    (N'Hệ điều hành', 3),
    (N'Toán 2', 2),
    (N'Kiến trúc máy tính', 3),
    (N'Kinh tế chính trị Mác - Lênin', 2),
    (N'Sinh hoạt Cuối tuần', 0),
    (N'Nhập môn lập trình', 3),
    (N'Tư duy phản biện', 3),
    (N'Giáo dục Quốc phòng - An ninh 1 (Đường lối quốc phòng của Đảng Cộng sản Việt Nam)', 3),
    (N'Giáo dục Quốc phòng - An ninh 2 (Công tác quốc phòng và an ninh)', 2),
    (N'Giáo dục Quốc phòng - An ninh 3 (Quân sự chung)', 1),
    (N'Giáo dục Quốc phòng - An ninh 4 (Kỹ thuật chiến đấu bộ binh và chiến thuật)', 2),
    (N'Cấu trúc dữ liệu và giải thuật', 3),
    (N'Cơ sở dữ liệu', 3),
    (N'Vật lý đại cương 1', 3),
    (N'Thực hành Vật lý đại cương 1', 1),
    (N'Chủ nghĩa xã hội khoa học', 2),
    (N'Kỹ thuật lập trình (2LT + 1LT)', 3),
    (N'Ngôn ngữ học thuật', 2),
    (N'Thường thức mỹ thuật', 2),
    (N'Giáo dục thể chất (Bóng đá)', 1),
    (N'Hệ quản trị cơ sở dữ liệu', 3),
    (N'Xác suất - Thống kê', 3),
    (N'Lịch sử Đảng Cộng sản Việt Nam', 2),
    (N'Lập trình hướng đối tượng', 3),
    (N'Kỹ thuật đồ họa', 3),
    (N'Thiết kế Web', 3),
    (N'Tiếng Anh chuyên ngành (CN thông tin)', 3);

--insert tblMonHoc

--tạo 1 sequence tự động tăng
create sequence sinhvienSeq
	start with 130000 --bắt đầu từ 130000 
	increment by 1; --mỗi lần tăng lên 1 đơn vị
	
	select next value for sinhvienSeq


select *from tblSinhVien

insert into tblSinhVien(
	masinhvien,
	ho,tendem,ten,
	ngaysinh,
	gioitinh,
	quequan,
	diachi,
	dienthoai,
	email
)
values 
	('64'+ cast(next value for sinhvienSeq as varchar(30)),N'Trần',N'Phan',N'Tú','2004-01-01',1,N'Hải Phòng',N'87, Giải Phóng, Hoàng Mai, Hà Nội','0322211125','tu.tp.64cntt@ntu.edu.vn'),
	('65' + cast(next value for sinhvienSeq as varchar(30)), N'Nguyễn', N'Thị', N'Lan', '2005-02-14', 1, N'Hà Nội', N'123, Trần Phú, Nha Trang, Khánh Hòa', '0356789123', 'lan.nt.65cntt@ntu.edu.vn'),
    ('63' + cast(next value for sinhvienSeq as varchar(30)), N'Lê', N'Văn', N'Quang', '2003-03-25', 0, N'Đà Nẵng', N'456, Lê Hồng Phong, Nha Trang, Khánh Hòa', '0376543210', 'quang.lv.63cntt@ntu.edu.vn'),
    ('64' + cast(next value for sinhvienSeq as varchar(30)), N'Phạm', N'Hữu', N'Nam', '2004-04-10', 0, N'Khánh Hòa', N'789, Nguyễn Trãi, Nha Trang, Khánh Hòa', '0388765432', 'nam.ph.64cntt@ntu.edu.vn'),
    ('62' + cast(next value for sinhvienSeq as varchar(30)), N'Hoàng', N'Minh', N'Anh', '2002-05-30', 1, N'Nghệ An', N'321, Hùng Vương, Nha Trang, Khánh Hòa', '0391234567', 'anh.hm.62cntt@ntu.edu.vn'),
    ('61' + cast(next value for sinhvienSeq as varchar(30)), N'Vũ', N'Thị', N'Trinh', '2001-06-18', 1, N'Bình Định', N'654, Trần Quang Khải, Nha Trang, Khánh Hòa', '0345678901', 'trinh.vt.61cntt@ntu.edu.vn'),
    ('60' + cast(next value for sinhvienSeq as varchar(30)), N'Doãn', N'Thị', N'Bích', '2000-07-22', 1, N'Quảng Ninh', N'987, Lê Quý Đôn, Nha Trang, Khánh Hòa', '0365432189', 'bich.dt.60cntt@ntu.edu.vn'),
    ('59' + cast(next value for sinhvienSeq as varchar(30)), N'Bùi', N'Xuân', N'Trung', '1999-08-05', 0, N'Bắc Ninh', N'159, Phan Chu Trinh, Nha Trang, Khánh Hòa', '0312345678', 'trung.bx.59cntt@ntu.edu.vn'),
    ('65' + cast(next value for sinhvienSeq as varchar(30)), N'Tạ', N'Thị', N'Quỳnh', '2005-09-09', 1, N'Thái Nguyên', N'753, Hùng Vương, Nha Trang, Khánh Hòa', '0321987654', 'quynh.tt.65cntt@ntu.edu.vn'),
	('63' + cast(next value for sinhvienSeq as varchar(30)), N'Đặng', N'Thế', N'Tùng', '2003-10-12', 0, N'Phú Yên', N'258, Lê Lợi, Nha Trang, Khánh Hòa', '0332198765', 'tung.dt.63cntt@ntu.edu.vn');

select *from TaiKhoan

insert into TaiKhoan values('admin','admin')
/**********************************/
--Kết nối CSDL từ C#

--Tạo PROCEDURE để lấy toàn bộ sinh viên
go;

CREATE PROCEDURE SelectAllSinhVien
AS
	select 
		masinhvien,
		case
			when LEN(tendem) > 0 then  --nếu độ dài tên đệm > 0 : có tên đệm
				CONCAT(ho,' ',tendem,' ',ten)--nối lại bằng ' '
			else CONCAT(ho,' ',ten) -- không có thì ' ' 
		end as hoten,
		CONVERT(varchar(10),ngaysinh,103) as ngaysinh,--định dạng ngày dd/mm/yyyy
		case
			when gioitinh = 0 then N'Nam'
			else N'Nữ'
		end as gioitinh,
		quequan,
		diachi,
		dienthoai,
		email
	from tblSinhVien
	order by ten;--sắp xếp tăng dần

GO;

EXEC SelectAllSinhVien

--DROP PROCEDURE SelectAllSinhVien


/**********************************/
--Thêm, sửa, hiển thị, tìm kiếm thông tin sinh viên

--tạo stored proc để thêm một sinh viên vào bảng tblSinhVien
go;


CREATE PROCEDURE ThemMoiSV
    -- Khai báo danh sách tham số truyền vào
    @Ho nvarchar(10),
    @TenDem nvarchar(20),
    @Ten nvarchar(10),
    @Ngaysinh date,
    @GioiTinh tinyint,
    @Quequan nvarchar(150),
    @DiaChi nvarchar(150),
    @Dienthoai varchar(30),
    @Email varchar(150)
    -- Kết thúc Khai báo danh sách tham số truyền vào
AS
BEGIN
    -- Tính toán năm nhập học dựa trên ngày sinh
    DECLARE @NamSinh int = YEAR(@Ngaysinh);
    DECLARE @NamNhapHoc char(2);

    -- Tạo giá trị dựa trên năm sinh
    IF @NamSinh BETWEEN 1980 AND 2099
    BEGIN
        SET @NamNhapHoc = CASE
            WHEN @NamSinh = 1980 THEN '50'
            WHEN @NamSinh = 1991 THEN '51'
            WHEN @NamSinh = 1992 THEN '52'
            WHEN @NamSinh = 1993 THEN '53'
            WHEN @NamSinh = 1994 THEN '54'
            WHEN @NamSinh = 1995 THEN '55'
            WHEN @NamSinh = 1996 THEN '56'
            WHEN @NamSinh = 1997 THEN '57'
            WHEN @NamSinh = 1998 THEN '58'
            WHEN @NamSinh = 1999 THEN '59'
            WHEN @NamSinh = 2000 THEN '60'
            WHEN @NamSinh = 2001 THEN '61'
            WHEN @NamSinh = 2002 THEN '62'
            WHEN @NamSinh = 2003 THEN '63'
            WHEN @NamSinh = 2004 THEN '64'
            WHEN @NamSinh = 2005 THEN '65'
            ELSE CAST(@NamSinh - 1940 AS CHAR(2)) -- Tính toán cho các năm ngoài quy định trên
        END;
    END
    ELSE
    BEGIN
        RAISERROR('Năm sinh không hợp lệ.', 16, 1);
        RETURN 0;
    END;
    
    -- Thêm dữ liệu mới
    INSERT INTO tblSinhVien
    (
        masinhvien,
        ho, tendem, ten,
        ngaysinh, gioitinh,
        quequan, diachi,
        dienthoai, email
    )
    VALUES
    (
        @NamNhapHoc + CAST(NEXT VALUE FOR sinhvienSeq AS VARCHAR(30)),
        @Ho, @TenDem, @Ten,
        @Ngaysinh,
        @GioiTinh,
        @Quequan, @DiaChi,
        @Dienthoai, @Email
    );
    -- Kết thúc thêm dữ liệu mới

    -- Kiểm tra xem đã insert thành công hay chưa
    IF @@ROWCOUNT > 0
    BEGIN
        RETURN 1;
    END
    ELSE
    BEGIN 
        RETURN 0;
    END;
END;

--DROP PROCEDURE ThemMoiSV
EXEC ThemMoiSV N'Nguyễn',N'Văn',N'Linh','2004-01-01', 1, N'Hải Phòng', N'87, Giải Phóng, Hoàng Mai, Hà Nội', '0322211125', 'loc.nv.64cntt@ntu.edu.vn';
--EXEC ThemMoiSV N'Nguyễn',N'Văn',N'Lươn','1999-01-01', 1, N'Hải Phòng', N'87, Giải Phóng, Hoàng Mai, Hà Nội', '0322211125', 'loc.nv.64cntt@ntu.edu.vn';


select *from tblSinhVien

go;


--Tạo proc update thông tin sinh viên
--DROP PROCEDURE updateSV
CREATE PROCEDURE updateSV
	--Khai báo 
	@masinhvien varchar(50),
	@ho nvarchar(10),
	@tendem nvarchar(20),
	@ten nvarchar(10),
	@ngaysinh date,
	@gioitinh tinyint,
	@quequan nvarchar(150),
	@diachi nvarchar(150),
	@dienthoai varchar(30),
	@email varchar(150)
	--kthuc
AS
BEGIN
	UPDATE tblSinhVien
	SET
		ho =@ho,
		tendem=@tendem,
		ten = @ten,
		ngaysinh= @ngaysinh,
		gioitinh= @gioitinh,
		quequan= @quequan,
		diachi= @diachi,
		dienthoai= @dienthoai,
		email= @email
		WHERE masinhvien = @masinhvien;
		IF @@ROWCOUNT > 0 BEGIN RETURN 1 END
		ELSE BEGIN RETURN 0 END
END


select *from tblSinhVien
EXEC updateSV '65130010', N'Trần', N'Thị', N'Quỳnh', '2005-09-09', 1, N'Thái Nguyên', N'753, Hùng Vương, Nha Trang, Khánh Hòa', '0321987654', 'quynh.tt.65cntt@ntu.edu.vn'

go;

--Tạo proc select  thông tin chi tiết của 1 sinh viên

--DROP PROCEDURE selectSV
CREATE PROCEDURE selectSV
	@masinhvien varchar(50)
AS
BEGIN
	SELECT
		ho,tendem,ten,convert(varchar(10),ngaysinh,103) as ngaysinh,
		/*
		case
			when gioitinh = 0 then 'Nam' else N'Nữ'
		end as gioitinh,
		*/

		gioitinh,

		quequan,diachi,dienthoai,email
		FROM tblSinhVien
		WHERE masinhvien = @masinhvien;
END


select *from tblSinhVien
EXEC selectSV '59130009'

GO;


/**********************************/
--Thêm mới hoặc cập nhật sinh viên
--backup
Backup database QLSinhVien to disk = 'C:\Users\Zero\Documents\HQTCSDL\QLSinhVien.bak'
--Restore 
Restore database QLSinhVien from disk = 'C:\Users\Zero\Documents\HQTCSDL\QLSinhVien.bak' with replace


/**********************************/
-- Chức năng tìm kiếm sử dụng Stored procedure

