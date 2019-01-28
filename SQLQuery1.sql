-- command untuk membuat database
Create Database Db_Mahasiswa

-- command untuk menggunakan Db_Mahasiswa
Use Db_Mahasiswa

-- Soal No 1
-- command untuk membuat table
Create Table Jurusan(
    Id int Not Null identity (1,1),
    Kode_Jurusan char(5) Not Null,
    Nama_Jurusan varchar(50) Not Null,
    Status_Jurusan varchar(100) Not Null,
    Primary Key (Kode_Jurusan),
)
Create Table Agama(
    Id int Not Null identity (1,1),
    Kode_Agama char(5) Not Null,
    Deskripsi varchar(20) Not Null,
    Primary Key (Kode_Agama),
)
Create Table Mahasiswa(
    Id int Not Null identity (1,1),
    Kode_Mahasiswa char(5) Not Null,
    Nama_Mahasiswa varchar(100) Not Null,
    Alamat varchar(200) Not Null,
    Kode_Agama char(5) Not Null,
    Kode_Jurusan char(5) Not Null,
    Primary Key (Kode_Mahasiswa),
)
Create Table Ujian(
    Id int Not Null identity (1,1),
    Kode_Ujian char(5) Not Null,
    Nama_Ujian varchar(50) Not Null,
    Status_Ujian varchar(100) Not Null,
    Primary Key (Kode_Ujian),
)
Create Table Type_Dosen(
    Id int Not Null identity (1,1),
    Kode_Type_Dosen char(5) Not Null,
    Deskripsi varchar(20) Not Null,
    Primary Key (Kode_Type_Dosen),
)
Create Table Dosen(
    Id Int Not Null identity (1,1),
    Kode_Dosen char(5) Not Null,
    Nama_Dosen varchar(100) Not Null,
    Kode_Jurusan char(5) Not Null,
    Kode_Type_Dosen char(5) Not Null,
    Primary Key (Kode_Dosen),
)
Create Table Nilai(
    Id int Not Null identity (1,1),
    Kode_Mahasiswa char(5) Not Null,
    Kode_Ujian char(5) Not Null,
    Nilai Decimal(8,2) Not Null,
    Primary Key(Id),
)
--command untuk mengisi tabel

INSERT INTO Jurusan VALUES
('J001','Teknik Informatika','Aktif'),
('J002','Management Informatika','Aktif'),
('J003','Sistem Informasi','Aktif'),
('J004','Sistem Komputer','Aktif'),
('J005','Komputer Akuntansi','Aktif')

INSERT INTO Agama VALUES
('A001','Islam'),
('A002','Khatolik'),
('A003','Kristen'),
('A004','Hindu'),
('A005','Budha')

INSERT INTO Mahasiswa VALUES
('M001','Budi Gunawan','Jl. Mawar No 3 RT 05 Cicalengka, Bandung','A001','J001'),
('M002','Rinto Raharjo','Jl. Kebagusan No. 33 RT04 RW06 Bandung','A002','J002'),
('M003','Asep Saepudin','Jl. Sumatera No. 12 RT02 RW01, Ciamis','A001','J003'),
('M004','M. Hafif Isbullah','Jl. Jawa No 01 RT01 RW01, Jakarta Pusat','A001','J001'),
('M005','Cahyono','Jl. Niagara No. 54 RT01 RW09, Surabaya','A003','J002')

INSERT INTO Ujian VALUES
('U001','Algoritma','Aktif'),
('U002','Aljabar','Aktif'),
('U003','Statistika','Non Aktif'),
('U004','Etika Profesi','Non Aktif'),
('U005','Bahasa Inggris','Aktif')

INSERT INTO Type_Dosen VALUES
('T001','Tetap'),
('T002','Honorer'),
('T003','Expertise')

INSERT INTO Dosen VALUES
('D001','Prof. Dr. Retno Wahyuningsih','J001','T002'),
('D002','Prof. Roy M. Sutikno','J002','T001'),
('D003','Prof. Hendri A. Verburgh','J003','T002'),
('D004','Prof. Risma Suparwata','J004','T002'),
('D005','Prof. Amir Sjarifuddin Madjid, MM, MA','J005','T001')

INSERT INTO Nilai VALUES
('M004','U001','90'),
('M001','U001','80'),
('M002','U003','85'),
('M004','U002','95'),
('M005','U005','70')

-- Soal no 2 : command untuk mengubah column Nama_Dosen dengan type data VarChar dengan panjang 200 pada table Dosen
ALTER TABLE Dosen ALTER COLUMN Nama_Dosen varchar(200) NOT NULL;

-- soal no 3 :
SELECT  Kode_Mahasiswa, Nama_Mahasiswa, Nama_Jurusan, Deskripsi 'Agama'
FROM Mahasiswa
JOIN Jurusan  ON Mahasiswa.Kode_Jurusan = Jurusan.Kode_Jurusan
JOIN Agama ON Mahasiswa.Kode_Agama = Agama.Kode_Agama 
WHERE Kode_Mahasiswa LIKE 'M001'

-- soal no 4 : menampilkan data mahasiswa yang mengambil jurusan dengan Status Jurusan = Non Aktif
SELECT Kode_Mahasiswa, Nama_Mahasiswa, Alamat, Nama_Jurusan, Status_Jurusan
FROM Mahasiswa M
JOIN Jurusan ON Mahasiswa.Kode_Jurusan = Jurusan.Kode_Jurusan
WHERE Status_Jurusan = 'Non Aktif'
-- belum tahu penyelesaian errornya

-- soal 5 : menampilkan data mahasiswa dengan nilai diatas 80 untuk ujian dengan Status Ujian = Aktif
SELECT M.Kode_Mahasiswa, Alamat, Nilai, Nama_Jurusan, Status_Jurusan
FROM Mahasiswa M
JOIN Nilai N ON M.Kode_Mahasiswa = N.Kode_Mahasiswa
JOIN Jurusan J ON M.Kode_Jurusan = J.Kode_Jurusan
WHERE Nilai > 80 AND Status_Jurusan = 'Aktif'

-- soal 6 : menampilkan data jurusan yang mengandung kata 'sistem'.
SELECT * FROM Jurusan where Nama_Jurusan LIKE  '%' + 'sistem' + '%'
