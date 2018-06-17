CREATE TABLE [dbo].[Note]
(
	[MaNote] CHAR(10) NOT NULL PRIMARY KEY, 
    [TieuDe] VARCHAR(50) NULL, 
    [NoiDung] NCHAR(1000) NULL, 
    [ThoiGianTao] DATE NULL, 
    [LoaiTag] NCHAR(10) NULL, 
    [Font] NCHAR(10) NULL, 
    [ThoiGianThongBao] DATETIME NULL, 
    [NgayChinhSuaGanNhat] DATE NULL, 
    [Path] CHAR(1000) NULL
)
