USE [E-OkulProjesi]
GO
/****** Object:  Table [dbo].[Tbl_Admin]    Script Date: 10/13/2023 5:41:26 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Tbl_Admin](
	[AdminId] [smallint] IDENTITY(1,1) NOT NULL,
	[AdminTC] [char](11) NULL,
	[AdminAd] [nvarchar](20) NULL,
	[AdminSoyad] [nvarchar](15) NULL,
	[AdminSifre] [nvarchar](30) NULL
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Tbl_Devamsizlik]    Script Date: 10/13/2023 5:41:26 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Tbl_Devamsizlik](
	[DevamsizlikId] [smallint] IDENTITY(1,1) NOT NULL,
	[DevamsizlikTC] [char](11) NULL,
	[DevamsizlikTarihi] [date] NULL,
	[DevamsizlikTuru] [nvarchar](5) NULL
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Tbl_Duyuru]    Script Date: 10/13/2023 5:41:26 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Tbl_Duyuru](
	[DuyuruId] [smallint] IDENTITY(1,1) NOT NULL,
	[DuyuruTC] [char](11) NULL,
	[DuyuruyuYapan] [nvarchar](35) NULL,
	[DuyuruBaslik] [nvarchar](50) NULL,
	[DuyuruAciklama] [nvarchar](300) NULL
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Tbl_Ogrenci]    Script Date: 10/13/2023 5:41:26 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Tbl_Ogrenci](
	[OgrenciId] [smallint] IDENTITY(1,1) NOT NULL,
	[OgrenciNo] [smallint] NULL,
	[OgrenciAd] [nvarchar](20) NULL,
	[OgrenciSoyad] [nvarchar](15) NULL,
	[OgrenciSinif] [varchar](4) NULL,
	[OgrenciCinsiyet] [nchar](10) NULL,
	[OgrenciTC] [char](11) NULL
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Tbl_Ogretmen]    Script Date: 10/13/2023 5:41:26 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Tbl_Ogretmen](
	[OgretmenId] [smallint] IDENTITY(1,1) NOT NULL,
	[OgretmenAd] [nvarchar](20) NULL,
	[OgretmenSoyad] [nvarchar](15) NULL,
	[OgretmenBrans] [nvarchar](30) NULL,
	[OgretmenCinsiyet] [nchar](5) NULL,
	[OgretmenTC] [char](11) NULL,
	[OgretmenSifre] [nvarchar](30) NULL
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Tbl_Sonuc]    Script Date: 10/13/2023 5:41:26 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Tbl_Sonuc](
	[Sonuc Id] [smallint] IDENTITY(1,1) NOT NULL,
	[Sonuc TC] [char](11) NULL,
	[Ders] [nvarchar](30) NULL,
	[1.Donem 1.Sinav] [float] NULL,
	[1.Donem 1.Sozlu] [float] NULL,
	[1.Donem 2.Sinav] [float] NULL,
	[1.Donem 2.Sozlu] [float] NULL,
	[1.Donem Ortalamasi] [float] NULL,
	[2.Donem 1.Sinav] [float] NULL,
	[2.Donem 1.Sozlu] [float] NULL,
	[2.Donem 2.Sinav] [float] NULL,
	[2.Donem 2.Sozlu] [float] NULL,
	[2.Donem Ortalamasi] [float] NULL
) ON [PRIMARY]
GO
SET IDENTITY_INSERT [dbo].[Tbl_Admin] ON 
GO
INSERT [dbo].[Tbl_Admin] ([AdminId], [AdminTC], [AdminAd], [AdminSoyad], [AdminSifre]) VALUES (1, N'12345678910', N'Admin', N'Admin', N'Admin123')
GO
SET IDENTITY_INSERT [dbo].[Tbl_Admin] OFF
GO
SET IDENTITY_INSERT [dbo].[Tbl_Devamsizlik] ON 
GO
INSERT [dbo].[Tbl_Devamsizlik] ([DevamsizlikId], [DevamsizlikTC], [DevamsizlikTarihi], [DevamsizlikTuru]) VALUES (128, N'11111111111', CAST(N'2023-11-23' AS Date), N'Tam')
GO
INSERT [dbo].[Tbl_Devamsizlik] ([DevamsizlikId], [DevamsizlikTC], [DevamsizlikTarihi], [DevamsizlikTuru]) VALUES (129, N'11111111111', CAST(N'2023-11-24' AS Date), N'Yarım')
GO
SET IDENTITY_INSERT [dbo].[Tbl_Devamsizlik] OFF
GO
SET IDENTITY_INSERT [dbo].[Tbl_Duyuru] ON 
GO
INSERT [dbo].[Tbl_Duyuru] ([DuyuruId], [DuyuruTC], [DuyuruyuYapan], [DuyuruBaslik], [DuyuruAciklama]) VALUES (25, N'99999999999', N'Ersin Kara', N'Yarın Ders Yok', N'14/10/2023 tarihli dersimiz acil bir işim çıktığı için iptal olmuştur. Telafisi yapılacaktır.')
GO
SET IDENTITY_INSERT [dbo].[Tbl_Duyuru] OFF
GO
SET IDENTITY_INSERT [dbo].[Tbl_Ogrenci] ON 
GO
INSERT [dbo].[Tbl_Ogrenci] ([OgrenciId], [OgrenciNo], [OgrenciAd], [OgrenciSoyad], [OgrenciSinif], [OgrenciCinsiyet], [OgrenciTC]) VALUES (119, 1, N'Enes Burak', N'Dikici', N'12-B', N'Erkek     ', N'11111111111')
GO
SET IDENTITY_INSERT [dbo].[Tbl_Ogrenci] OFF
GO
SET IDENTITY_INSERT [dbo].[Tbl_Ogretmen] ON 
GO
INSERT [dbo].[Tbl_Ogretmen] ([OgretmenId], [OgretmenAd], [OgretmenSoyad], [OgretmenBrans], [OgretmenCinsiyet], [OgretmenTC], [OgretmenSifre]) VALUES (114, N'Ersin', N'Kara', N'Matematik', N'Erkek', N'99999999999', N'9999')
GO
SET IDENTITY_INSERT [dbo].[Tbl_Ogretmen] OFF
GO
SET IDENTITY_INSERT [dbo].[Tbl_Sonuc] ON 
GO
INSERT [dbo].[Tbl_Sonuc] ([Sonuc Id], [Sonuc TC], [Ders], [1.Donem 1.Sinav], [1.Donem 1.Sozlu], [1.Donem 2.Sinav], [1.Donem 2.Sozlu], [1.Donem Ortalamasi], [2.Donem 1.Sinav], [2.Donem 1.Sozlu], [2.Donem 2.Sinav], [2.Donem 2.Sozlu], [2.Donem Ortalamasi]) VALUES (453, N'11111111111', N'Turk Dili ve Edebiyati', NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL)
GO
INSERT [dbo].[Tbl_Sonuc] ([Sonuc Id], [Sonuc TC], [Ders], [1.Donem 1.Sinav], [1.Donem 1.Sozlu], [1.Donem 2.Sinav], [1.Donem 2.Sozlu], [1.Donem Ortalamasi], [2.Donem 1.Sinav], [2.Donem 1.Sozlu], [2.Donem 2.Sinav], [2.Donem 2.Sozlu], [2.Donem Ortalamasi]) VALUES (456, N'11111111111', N'Cografya', NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL)
GO
INSERT [dbo].[Tbl_Sonuc] ([Sonuc Id], [Sonuc TC], [Ders], [1.Donem 1.Sinav], [1.Donem 1.Sozlu], [1.Donem 2.Sinav], [1.Donem 2.Sozlu], [1.Donem Ortalamasi], [2.Donem 1.Sinav], [2.Donem 1.Sozlu], [2.Donem 2.Sinav], [2.Donem 2.Sozlu], [2.Donem Ortalamasi]) VALUES (458, N'11111111111', N'Din Kulturu', NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL)
GO
INSERT [dbo].[Tbl_Sonuc] ([Sonuc Id], [Sonuc TC], [Ders], [1.Donem 1.Sinav], [1.Donem 1.Sozlu], [1.Donem 2.Sinav], [1.Donem 2.Sozlu], [1.Donem Ortalamasi], [2.Donem 1.Sinav], [2.Donem 1.Sozlu], [2.Donem 2.Sinav], [2.Donem 2.Sozlu], [2.Donem Ortalamasi]) VALUES (459, N'11111111111', N'Ingilizce', NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL)
GO
INSERT [dbo].[Tbl_Sonuc] ([Sonuc Id], [Sonuc TC], [Ders], [1.Donem 1.Sinav], [1.Donem 1.Sozlu], [1.Donem 2.Sinav], [1.Donem 2.Sozlu], [1.Donem Ortalamasi], [2.Donem 1.Sinav], [2.Donem 1.Sozlu], [2.Donem 2.Sinav], [2.Donem 2.Sozlu], [2.Donem Ortalamasi]) VALUES (461, N'11111111111', N'Fizik', NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL)
GO
INSERT [dbo].[Tbl_Sonuc] ([Sonuc Id], [Sonuc TC], [Ders], [1.Donem 1.Sinav], [1.Donem 1.Sozlu], [1.Donem 2.Sinav], [1.Donem 2.Sozlu], [1.Donem Ortalamasi], [2.Donem 1.Sinav], [2.Donem 1.Sozlu], [2.Donem 2.Sinav], [2.Donem 2.Sozlu], [2.Donem Ortalamasi]) VALUES (463, N'11111111111', N'Beden Egitimi', NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL)
GO
INSERT [dbo].[Tbl_Sonuc] ([Sonuc Id], [Sonuc TC], [Ders], [1.Donem 1.Sinav], [1.Donem 1.Sozlu], [1.Donem 2.Sinav], [1.Donem 2.Sozlu], [1.Donem Ortalamasi], [2.Donem 1.Sinav], [2.Donem 1.Sozlu], [2.Donem 2.Sinav], [2.Donem 2.Sozlu], [2.Donem Ortalamasi]) VALUES (465, N'11111111111', N'Gorsel Sanatlar', NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL)
GO
INSERT [dbo].[Tbl_Sonuc] ([Sonuc Id], [Sonuc TC], [Ders], [1.Donem 1.Sinav], [1.Donem 1.Sozlu], [1.Donem 2.Sinav], [1.Donem 2.Sozlu], [1.Donem Ortalamasi], [2.Donem 1.Sinav], [2.Donem 1.Sozlu], [2.Donem 2.Sinav], [2.Donem 2.Sozlu], [2.Donem Ortalamasi]) VALUES (455, N'11111111111', N'Tarih', NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL)
GO
INSERT [dbo].[Tbl_Sonuc] ([Sonuc Id], [Sonuc TC], [Ders], [1.Donem 1.Sinav], [1.Donem 1.Sozlu], [1.Donem 2.Sinav], [1.Donem 2.Sozlu], [1.Donem Ortalamasi], [2.Donem 1.Sinav], [2.Donem 1.Sozlu], [2.Donem 2.Sinav], [2.Donem 2.Sozlu], [2.Donem Ortalamasi]) VALUES (460, N'11111111111', N'Biyoloji', NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL)
GO
INSERT [dbo].[Tbl_Sonuc] ([Sonuc Id], [Sonuc TC], [Ders], [1.Donem 1.Sinav], [1.Donem 1.Sozlu], [1.Donem 2.Sinav], [1.Donem 2.Sozlu], [1.Donem Ortalamasi], [2.Donem 1.Sinav], [2.Donem 1.Sozlu], [2.Donem 2.Sinav], [2.Donem 2.Sozlu], [2.Donem Ortalamasi]) VALUES (466, N'11111111111', N'Rehberlik', NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL)
GO
INSERT [dbo].[Tbl_Sonuc] ([Sonuc Id], [Sonuc TC], [Ders], [1.Donem 1.Sinav], [1.Donem 1.Sozlu], [1.Donem 2.Sinav], [1.Donem 2.Sozlu], [1.Donem Ortalamasi], [2.Donem 1.Sinav], [2.Donem 1.Sozlu], [2.Donem 2.Sinav], [2.Donem 2.Sozlu], [2.Donem Ortalamasi]) VALUES (464, N'11111111111', N'Muzik', NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL)
GO
INSERT [dbo].[Tbl_Sonuc] ([Sonuc Id], [Sonuc TC], [Ders], [1.Donem 1.Sinav], [1.Donem 1.Sozlu], [1.Donem 2.Sinav], [1.Donem 2.Sozlu], [1.Donem Ortalamasi], [2.Donem 1.Sinav], [2.Donem 1.Sozlu], [2.Donem 2.Sinav], [2.Donem 2.Sozlu], [2.Donem Ortalamasi]) VALUES (457, N'11111111111', N'Felsefe', NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL)
GO
INSERT [dbo].[Tbl_Sonuc] ([Sonuc Id], [Sonuc TC], [Ders], [1.Donem 1.Sinav], [1.Donem 1.Sozlu], [1.Donem 2.Sinav], [1.Donem 2.Sozlu], [1.Donem Ortalamasi], [2.Donem 1.Sinav], [2.Donem 1.Sozlu], [2.Donem 2.Sinav], [2.Donem 2.Sozlu], [2.Donem Ortalamasi]) VALUES (462, N'11111111111', N'Kimya', NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL)
GO
INSERT [dbo].[Tbl_Sonuc] ([Sonuc Id], [Sonuc TC], [Ders], [1.Donem 1.Sinav], [1.Donem 1.Sozlu], [1.Donem 2.Sinav], [1.Donem 2.Sozlu], [1.Donem Ortalamasi], [2.Donem 1.Sinav], [2.Donem 1.Sozlu], [2.Donem 2.Sinav], [2.Donem 2.Sozlu], [2.Donem Ortalamasi]) VALUES (454, N'11111111111', N'Matematik', NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL)
GO
SET IDENTITY_INSERT [dbo].[Tbl_Sonuc] OFF
GO
