create database ManageUniversity;
go
use ManageUniversity;
go
---Table
create table Khoa
(
	Ten NVARCHAR (100) NOT NULL Primary Key,
)
create table Nganh
(
	Ten NVARCHAR(100) NOT NULL Primary key,
	TenKhoa NVARCHAR(100) References Khoa(Ten),
	SoNam INT,
)
go
create table PhongHoc
(
	Ten NVARCHAR(100) NOT NULL Primary Key,
	SiSoToiDa INT NOT NULL,
)
go
create table Nguoi
(
	ID NVARCHAR(100) Primary Key,
	SDT NVARCHAR(100),
	Ten NVARCHAR (100),
	DiaChi NVARCHAR (100),
	Email NVARCHAR(100),
	NgaySinh DateTime,
);
go

create table GiangVien
(
	ID NVARCHAR(100) primary key,
	TenKhoa NVARCHAR(100),
);
go

create table Lop 
(
	Ten NVARCHAR(100) NOT NULL Primary Key,
	MaCoVan NVARCHAR(100),
	SiSoToiDa INT NOT NULL,
	TenNganh NVARCHAR(100),
);
go

create table SinhVien
(
	ID NVARCHAR(100) Primary key,
	HocKi INT default 1,
	Nam INT default 1,
	TenNganh NVARCHAR(100),
);
go

create table MonHoc 
(
	Ten NVARCHAR (100) NOT NULL Primary key,
	BatBuoc Bit Default 0,
	SoTC INT Default 0,
	SoTiet INT Default 0,
	Phi float default 0,
	HocKi INT,
	Nam INT,
);
go

create table MonHocThuocNganh
(
	TenMH NVARCHAR(100) NOT NULL,
	TenNganh NVARCHAR(100) NOT NULL,
	Primary key (TenMH, TenNganh)
)
go

create table DangKyPhong
(
	TenPH NVARCHAR(100) NOT NULL,
	MaLop INT NOT NULL,
	NgayBatDau DATETIME NOT NULL,
	NgayKetThuc DATETIME NOT NULL,
	TietDau INT,
	TietCuoi INT,
	Thu NVARCHAR(100),
	NgayDK DATETIME,
	Primary key (TenPH, NgayBatDau, NgayKetThuc, TietDau, TietCuoi, Thu)
)
go

create table LichSuDangKyPhongCu
(
	MaSV NVARCHAR(100),
	HocKi INT,
	Nam INT,
	TenMH NVARCHAR(100),
	MaGV NVARCHAR(100),
	TenPH NVARCHAR(100) NOT NULL,
	MaLop INT NOT NULL,
	NgayBatDau DATETIME NOT NULL,
	NgayKetThuc DATETIME NOT NULL,
	TietDau INT,
	TietCuoi INT,
	Thu NVARCHAR(100),
	NgayDK DATETIME,
	Primary key (TenPH, NgayBatDau, NgayKetThuc, TietDau, TietCuoi, Thu)
)
go
go

create table DangKyMon
(
	MaSV NVARCHAR(100) NOT NULL,
	MaLop INT NOT NULL,
	HocKi INT NOT NULL,
	Nam INT NOT NULL,
	NgayDK DATETIME,
	Primary Key (MaSV, MaLop),
);
go


create table PhanCongGiangDay
(
	MaLop INT Primary Key,
	TenMH NVARCHAR(100),
	MaGV NVARCHAR(100),
	SiSoToiDa INT,
	Ngay DATETIME,
)
go



create table PhanBoSinhVien
(
	MaSV NVARCHAR(100) NOT NULL Primary key,
	TenLop NVARCHAR(100) NOT NULL,
	Ngay DATETIME,
)
go

create table GhiDiem
(
	MaSV NVARCHAR(100) NOT NULL,
	MaLop INT NOT NULL,
	KTDK FLOAT,
	KTHP FLOAT,
	TiLeKTDK INT,
	HocKi INT, 
	Nam INT,
);
go

create table DangKyTaiKhoan
(
	TenTK NVARCHAR(100) Primary Key,
	ID NVARCHAR(100),
	AnhDaiDien IMAGE,
	DuoiFileAnh NVARCHAR(100),
	MatKhau VARCHAR(100),
	NgayDK DATETIME,
);

go
create table KhaoSat
(
	MaSV NVARCHAR(100) NOT NULL,
	MaLop INT NOT NULL,
	HocKi INT NOT NULL,
	Nam INT NOT NULL,
	NoiDung NVARCHAR(100) NOT NULL,
	NgayKS DATETIME,
	Primary key (MaLop, MaSV),
);
go


create trigger Trigger_XoaLop on Lop
for delete as
begin
	Declare @TenLop NVARCHAR(100);
	Select @TenLop = Ten from deleted;
	delete PhanBoSinhVien where TenLop = @TenLop;
end

create trigger Trigger_CapNhatLop on Lop
for update as
begin
	Declare @oldTenLop NVARCHAR(100);
	Declare @newTenLop NVARCHAR(100);
	Select @oldTenLop = Ten from deleted;
	Select @newTenLop = Ten from inserted;
	if (@oldTenLop != @newTenLop) 
	begin
		update PhanBoSinhVien set TenLop = @newTenLop where TenLop = @oldTenLop;
	end
end

alter trigger Trigger_XoaKhoa on Khoa
for delete as
begin
	Declare @TenKhoa NVARCHAR(100);
	Select @TenKhoa = Ten from deleted;
	Delete Nganh where TenKhoa = @TenKhoa;
	Delete GiangVien where TenKhoa = @TenKhoa;
end

create trigger Trigger_CapNhatKhoa on Khoa
for update as
begin
	Declare @oldTenKhoa NVARCHAR(100);
	Declare @newTenKhoa NVARCHAR(100);
	Select @oldTenKhoa = Ten from deleted;
	Select @newTenKhoa = Ten from inserted;
	if (@oldTenKhoa != @newTenKhoa)
	begin
		update Nganh set TenKhoa = @newTenKhoa where TenKhoa = @oldTenKhoa;
		update GiangVien set TenKhoa = @newTenKhoa where TenKhoa = @oldTenKhoa;
	end
end

alter trigger Trigger_XoaNganh on Nganh
for delete as
begin
	Declare @TenNganh NVARCHAR(100);
	Select @TenNganh = Ten from deleted;
	Delete SinhVien where TenNganh = @TenNganh;
	Delete Lop where TenNganh = @TenNganh
	Delete MonHoc where exists (Select * from MonHocThuocNganh where TenNganh = @TenNganh and TenMH = Ten);
end
create trigger Trigger_CapNhatNganh on Nganh
for update as
begin
	Declare @oldTenNganh NVARCHAR(100);
	Declare @newTenNganh NVARCHAR(100);
	Select @oldTenNganh = Ten from deleted;
	Select @newTenNganh = Ten from inserted;
	if (@oldTenNganh != @newTenNganh)
	begin
		Update Lop set TenNganh = @newTenNganh where TenNganh = @oldTenNganh;
		update MonHoc set Ten = @newTenNganh where Ten = @oldTenNganh;
		Update SinhVien set TenNganh = @newTenNganh where TenNganh = @oldTenNganh;
		Update MonHocThuocNganh set TenNganh = @newTenNganh where TenNganh = @oldTenNganh;
	end
end

--Trigger môn học
create trigger Trigger_XoaMon on MonHoc
for delete as
begin
	Declare @TenMH NVARCHAR(100);
	Select @TenMH = Ten from deleted
	Delete MonHocThuocNganh where TenMH = @TenMH;
	delete PhanCongGiangDay where TenMH = @TenMH;
end

create trigger Trigger_CapNhatMonHoc on MonHoc
for update as
begin
	Declare @oldTenMH NVARCHAR(100);
	Declare @newTenMH NVARCHAR(100);
	Select @oldTenMH = Ten from deleted;
	Select @newTenMH = Ten from inserted;
	if (@oldTenMH != @newTenMH)
	begin
		Update MonHocThuocNganh Set TenMH = @newTenMH where TenMH = @oldTenMH;
		update PhanCongGiangDay Set TenMH = @newTenMH where TenMH = @oldTenMH;
	end
end

create trigger Trigger_XoaPhong on PhongHoc
for delete as
begin
	Declare @TenPH NVARCHAR(100);
	Select @TenPH = Ten from deleted
	Delete DangKyPhong where TenPH = @TenPH;
end

--Cập nhật phòng học
create trigger Trigger_CapNhatPhongHoc on PhongHoc
for update as
begin
	Declare @oldTenPH NVARCHAR(100);
	Declare @newTenPH NVARCHAR(100);
	Select @oldTenPH = Ten from deleted;
	Select @newTenPH = Ten from inserted;
	if (@oldTenPH != @newTenPH)
	begin
		Update DangKyPhong Set TenPH = @newTenPH where TenPH = @oldTenPH;
	end
end

alter trigger Trigger_XoaGV on GiangVien
for delete as
begin
	Declare @ID NVARCHAR(100);
	Select @ID = ID from deleted
	Delete DangKyTaiKhoan where ID = @ID;
	Delete Nguoi where ID = @ID;
	delete PhanCongGiangDay where MaGV = @ID;
end

create trigger Trigger_CapNhatGV on GiangVien
for update as
begin
	Declare @OldMaGV NVARCHAR(100);
	Declare @NewMaGV NVARCHAR(100);
	Select @OldMaGV = ID from deleted;
	select @NewMaGV = ID from inserted;
	if (@OldMaGV != @NewMaGV)
	begin
		update Lop Set MaCoVan = @NewMaGV where MaCoVan = @OldMaGV;
		update PhanCongGiangDay Set MaGV = @NewMaGV where MaGV = @OldMaGV
		update DangKyTaiKhoan Set ID = @NewMaGV where ID = @OldMaGV;
	end
end

create trigger Trigger_XoaSV on SinhVien
for delete as
begin
	Declare @ID NVARCHAR(100);
	Select @ID = ID from deleted
	Delete DangKyTaiKhoan where ID = @ID;
	Delete Nguoi where ID = @ID;
	Delete GhiDiem where MaSV = @ID;
	delete DangKyMon where MaSV = @ID;
	Declare @IDGD NVARCHAR(100);
	Select @IDGD = MaGD from MoiQuanHe;
	delete MoiQuanHe where MaSV = @ID
	delete Nguoi where ID = @IDGD;
	delete PhanBoSinhVien where MaSV = @ID;
end

alter trigger Trigger_CapNhatSV on SinhVien
for update as
begin
	Declare @OldMaSV NVARCHAR(100);
	Declare @NewMaSV NVARCHAR(100);
	Declare @OldHocKi INT;
	Declare @OldNam INT;
	Declare @NewHocKi INT;
	Declare @NewNam INT;
	Select @OldMaSV = ID, @OldHocKi = HocKi, @OldNam = Nam  from deleted;
	select @NewMaSV = ID, @NewHocKi = HocKi, @NewNam = Nam from inserted;
	if (@OldMaSV != @NewMaSV) 
	begin
		update PhanBoSinhVien Set MaSV = @NewMaSV where MaSV = @OldMaSV;
		update MoiQuanHe Set MaSV  = @NewMaSV where MaSV = @OldMaSV;
		update DangKyMon Set MaSV = @NewMaSV where MaSV = @OldMaSV;
		update GhiDiem Set MaSV = @NewMaSV where MaSV = @OldMaSV;
		update DangKyTaiKhoan Set ID = @NewMaSV where ID = @OldMaSV;
		update KhaoSat Set MaSV = @NewMaSV where MaSV = @OldMaSV;
		update LichSuDangKyPhongCu Set MaSV = @NewMaSV where MaSV = @OldMaSV;
	end
	Declare @Percent INT = 50;
	Select @Percent = TiLeKTDK from GhiDiem;
	Insert into GhiDiem Select MaSV, MaLop, 0, 0, @Percent, HocKi, Nam  from DangKyMon where MaSV = @NewMaSV and ((HocKi < @NewHocKi and Nam = @NewNam) or (Nam < @NewNam)) and not exists(Select * from GhiDiem where MaSV = @NewMaSV and ((HocKi < @NewHocKi and Nam = @NewNam) or (Nam < @NewNam)))
	Delete GhiDiem where MaSV = @NewMaSV and ((Nam = @NewNam and HocKi > @NewHocKi) or (Nam > @NewNam))
	Delete KhaoSat where MaSV = @NewMaSV and ((Nam = @NewNam and HocKi > @NewHocKi) or (Nam > @NewNam))
	if (@OldNam = @NewNam)
	begin
		if (@OldHocKi < @NewHocKi)
		begin
			Insert into LichSuDangKyPhongCu Select @NewMaSV, @OldHocKi, @OldNam, TenMH, MaGV, TenPH, DangKyPhong.MaLop, NgayBatDau, NgayKetThuc, TietDau, TietCuoi, Thu, NgayDK from DangKyPhong, PhanCongGiangDay where DangKyPhong.MaLop = PhanCongGiangDay.MaLop and Exists(Select * from DangKyMon where DangKyMon.MaLop = DangKyPhong.MaLop and HocKi = @OldHocKi and Nam = @OldNam)
		end
		else if (@OldHocKi >= @NewHocKi)
		begin
			Delete LichSuDangKyPhongCu where MaSV = @NewMaSV and Nam = @OldNam and HocKi >= @NewHocKi
		end
	end
	else if (@OldNam > @NewNam)
	begin
		Delete LichSuDangKyPhongCu where MaSV = @NewMaSV and ((Nam = @NewNam and HocKi > @NewHocKi) or Nam > @NewNam)
	end
	else
	begin
		Insert into LichSuDangKyPhongCu Select @NewMaSV, @OldHocKi, @OldNam, TenMH, MaGV, TenPH, DangKyPhong.MaLop, NgayBatDau, NgayKetThuc, TietDau, TietCuoi, Thu, NgayDK from DangKyPhong, PhanCongGiangDay where DangKyPhong.MaLop = PhanCongGiangDay.MaLop and Exists(Select * from DangKyMon where DangKyMon.MaLop = DangKyPhong.MaLop and HocKi = @OldHocKi and Nam = @OldNam)
	end
end
create table LichSuDangKyPhongCu
(
	MaSV NVARCHAR(100),
	HocKi INT,
	Nam INT,
	TenMH NVARCHAR(100),
	MaGV NVARCHAR(100),
	TenPH NVARCHAR(100) NOT NULL,
	MaLop INT NOT NULL,
	NgayBatDau DATETIME NOT NULL,
	NgayKetThuc DATETIME NOT NULL,
	TietDau INT,
	TietCuoi INT,
	Thu NVARCHAR(100),
	NgayDK DATETIME,
	Primary key (TenPH, NgayBatDau, NgayKetThuc, TietDau, TietCuoi, Thu)
)
go
select * from LichSuDangKyPhongCu

create trigger Trigger_XoaQuanTri on Nguoi
for delete as
begin
	Declare @ID NVARCHAR(100);
	Select @ID = ID from deleted
	Delete DangKyTaiKhoan where ID = @ID;
end

create trigger Trigger_DangKyMon on DangKyMon
for insert as
begin
	Declare @MaLop INT;
	Declare @MaSV NVARCHAR(100);
	Declare @HocKi INT;
	Declare @Nam INT;
	Select @MaLop = MaLop, @MaSV = MaSV, @HocKi = HocKi, @Nam = Nam from inserted;
	Update DangKyMon Set NgayDK = GETDATE() where MaLop = @MaLop and MaSV = @MaSV and HocKi = @HocKi and Nam = @Nam;
end

alter trigger Trigger_XoaDangKyMon on DangKyMon
for delete as
begin
	Declare @MaLop INT;
	Declare @MaSV NVARCHAR(100);
	Declare @HocKi NVARCHAR(100);
	Declare @Nam NVARCHAR(100);
	Select @MaLop = MaLop, @MaSV = MaSV, @HocKi = HocKi, @Nam = Nam from deleted;
	delete GhiDiem where MaLop = @MaLop and MaSV = @MaSV and HocKi = @HocKi and Nam = @Nam;
end

create trigger Trigger_DangKyPhong on DangKyPhong
for insert as
begin
	Declare @MaLop INT;
	Declare @TenPH NVARCHAR(100);
	Declare @MaGV NVARCHAR(100);
	Declare @TenMH NVARCHAR(100);
	Select @MaLop = MaLop, @TenPH = TenPH from inserted;
	Update DangKyPhong Set NgayDK = GETDATE() where TenPH = @TenPH and MaLop = @MaLop
end

alter trigger Trigger_XoaDangKyPhong on DangKyPhong
for delete as
begin
	Declare @MaLop INT;
	Select @MaLop = MaLop from deleted;
	Delete DangKyMon where MaLop = @MaLop;
	Delete GhiDiem where MaLop = @MaLop;
end 

create trigger Trigger_DangKyTaiKhoan on DangKyTaiKhoan
for insert as
begin
	Declare @TenTK NVARCHAR(100);
	Select @TenTK = TenTK from inserted;
	Update DangKyTaiKhoan Set NgayDK = GETDATE();
end

create trigger Trigger_GuiKhaoSat on KhaoSat
for insert as
begin
	Declare @MaLop INT;
	Declare @MaSV NVARCHAR(100);
	Declare @HocKi INT;
	Declare @Nam INT;
	Select @MaLop = MaLop, @MaSV = MaSV, @HocKi = HocKi, @Nam = Nam from inserted;
	Update KhaoSat Set NgayKS = GETDATE() where @MaLop = MaLop and @MaSV = MaSV and @HocKi = HocKi and @Nam = Nam;
end

create trigger Trigger_CapNhatKhaoSat on KhaoSat
for update as
begin
	Declare @MaLop INT;
	Declare @MaSV NVARCHAR(100);
	Declare @HocKi INT;
	Declare @Nam INT;
	Select @MaLop = MaLop, @MaSV = MaSV, @HocKi = HocKi, @Nam = Nam from inserted;
	Update KhaoSat Set NgayKS = GETDATE() where @MaLop = MaLop and @MaSV = MaSV and @HocKi = HocKi and @Nam = Nam;
end

--Khi thêm Phân công cố vấn giảng dạy lớp thì cập nhật thời gian phân công là thời điểm đó
create trigger Trigger_PhanCongGiangDay on PhanCongGiangDay
for insert as
begin
	Declare @Count INT;
	Select @Count = Count(*) from PhanCongGiangDay;
	Update PhanCongGiangDay Set MaLop = @Count, Ngay = GETDATE() where MaLop = -1;
end

alter trigger Trigger_XoaPhanCongGiangDay on PhanCongGiangDay
for delete as
begin
	Declare @MaLop INT;
	Declare @Count INT;
	Select @MaLop = MaLop from deleted;
	Select @Count = Count(*) + 1 from PhanCongGiangDay
	delete DangKyPhong where MaLop = @MaLop;
	delete DangKyMon where MaLop = @MaLop;
	while (@MaLop < @Count)	
	begin
		Update PhanCongGiangDay Set MaLop = @MaLop Where MaLop = @MaLop + 1;
		Set @MaLop = @MaLop + 1
	end
end

--Khi thêm phân bổ sinh viên vào lớp thì cập nhật thời gian phân bổ là thời điểm đó
create trigger Trigger_PhanBoSinhVien on PhanBoSinhVien
for insert as
begin
	Declare @MaSV NVARCHAR(100);
	Select @MaSV = MaSV from inserted;
	Update PhanBoSinhVien Set Ngay = GETDATE() where MaSV = @MaSV;
end

create trigger Trigger_XoaGhiDiem on GhiDiem
for delete as
begin
	Declare @MaLop NVARCHAR(100);
	Declare @MaSV NVARCHAR(100);
	Declare @HocKi INT;
	Declare @Nam INT;
	Select @MaSV = MaSV, @MaLop = MaLop, @HocKi = HocKi, @Nam = Nam from deleted;
	delete KhaoSat where MaLop = @MaLop and MaSV = @MaSV and HocKi = @HocKi and Nam = @Nam;
end


--Lấy danh sách giảng viên
create function Func_LayDanhSachGV ()
RETURNS @tb TABLE (ID INT, Ten NVARCHAR(100), LoaiTK NVARCHAR(100))
AS
BEGIN
	INSERT INTO @tb SELECT Nguoi.ID, Ten, N'Giảng viên' FROM Nguoi WHERE EXISTS (SELECT * FROM GiangVien WHERE GiangVien.ID = Nguoi.ID);
	RETURN;
END

--Lấy danh sách sinh viên
create function Func_LayDanhSachSV ()
RETURNS @tb TABLE (ID INT, Ten NVARCHAR(100), LoaiTK NVARCHAR(100))
AS
BEGIN
	INSERT INTO @tb SELECT Nguoi.ID, Ten, N'Sinh viên' FROM Nguoi WHERE EXISTS (SELECT * FROM SinhVien WHERE SinhVien.ID = Nguoi.ID);
	RETURN;
END


select * from PhanCongGiangDay

select * from Khoa;
select * from Nganh;
select * from PhongHoc;
select * from Nguoi;
select * from GiangVien;
select * from lop;
select * from SinhVien;
select * FROM MonHoc;
Select * from MonHocThuocNganh
select * from MoiQuanHe;
select * from DangKyPhong;
select * from DangKyMon;
select * from PhanCongGiangDay;
select * from PhanBoSinhVien;
select * from GhiDiem;
select * from DangKyTaiKhoan;
select * from KhaoSat;

delete DangKyPhong;
delete PhanCongGiangDay

delete PhanBoSinhVien

delete DangKyMon where MaSV = 'SV-001'

select * from Nguoi order by ID desc

delete GhiDiem
Insert into KhaoSat (MaSV, MaLop, HocKi, Nam, NoiDung) values ('A', 1, 2, 3, '1-2-3')

delete KhaoSat

delete MonHoc

delete MonHocThuocNganh