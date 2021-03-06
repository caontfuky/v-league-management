USE [v-luage-management]
GO
/****** Object:  Table [dbo].[CARD]    Script Date: 12/8/2014 11:43:24 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[CARD](
	[CardID] [char](20) NOT NULL,
	[PlayerID] [char](20) NOT NULL,
	[MatchID] [char](20) NOT NULL,
	[CardTypeID] [char](20) NOT NULL,
	[Time] [int] NOT NULL,
 CONSTRAINT [PK_CARD] PRIMARY KEY CLUSTERED 
(
	[CardID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[CARD_TYPE]    Script Date: 12/8/2014 11:43:24 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[CARD_TYPE](
	[CardTypeID] [char](20) NOT NULL,
	[CardName] [nvarchar](20) NOT NULL,
 CONSTRAINT [PK_CARD_TYPE] PRIMARY KEY CLUSTERED 
(
	[CardTypeID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[COACH]    Script Date: 12/8/2014 11:43:24 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[COACH](
	[CoachID] [char](20) NOT NULL,
	[CoachName] [nvarchar](50) NOT NULL,
	[BirthDay] [int] NOT NULL,
	[Address] [nvarchar](200) NULL,
	[PhoneNumber] [char](20) NULL,
 CONSTRAINT [PK_COACH] PRIMARY KEY CLUSTERED 
(
	[CoachID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[COACH_TEAM_SEASON]    Script Date: 12/8/2014 11:43:24 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[COACH_TEAM_SEASON](
	[CoachID] [char](20) NOT NULL,
	[TeamID] [char](20) NOT NULL,
	[SeasonID] [char](20) NOT NULL,
 CONSTRAINT [PK_COACH_TEAM_SEASON] PRIMARY KEY CLUSTERED 
(
	[CoachID] ASC,
	[TeamID] ASC,
	[SeasonID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[GOAL]    Script Date: 12/8/2014 11:43:24 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[GOAL](
	[GoalID] [char](20) NOT NULL,
	[PlayerID] [char](20) NOT NULL,
	[MatchID] [char](20) NOT NULL,
	[Time] [int] NOT NULL,
 CONSTRAINT [PK_GOAL] PRIMARY KEY CLUSTERED 
(
	[GoalID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[MATCH]    Script Date: 12/8/2014 11:43:24 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[MATCH](
	[MatchID] [char](20) NOT NULL,
	[HomeTeam] [char](20) NOT NULL,
	[VisitingTeam] [char](20) NOT NULL,
	[StadiumID] [char](20) NOT NULL,
	[StartDate] [datetime] NOT NULL,
	[RefereeID] [char](20) NOT NULL,
	[RoundID] [char](20) NOT NULL,
 CONSTRAINT [PK_MATCH] PRIMARY KEY CLUSTERED 
(
	[MatchID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[NATIONAL]    Script Date: 12/8/2014 11:43:24 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[NATIONAL](
	[NationalID] [char](20) NOT NULL,
	[NationalName] [nvarchar](50) NOT NULL,
 CONSTRAINT [PK_NATIONAL] PRIMARY KEY CLUSTERED 
(
	[NationalID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[PLAYER]    Script Date: 12/8/2014 11:43:24 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[PLAYER](
	[PlayerID] [char](20) NOT NULL,
	[FullName] [nvarchar](50) NOT NULL,
	[BirthDay] [date] NOT NULL,
	[PositionID] [char](20) NOT NULL,
	[NationalID] [char](20) NOT NULL,
	[NumberOfCloth] [int] NOT NULL,
	[Height] [int] NOT NULL,
	[Weight] [int] NOT NULL,
 CONSTRAINT [PK_PLAYER] PRIMARY KEY CLUSTERED 
(
	[PlayerID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[PLAYER_TEAM_SEASON]    Script Date: 12/8/2014 11:43:24 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[PLAYER_TEAM_SEASON](
	[PlayerID] [char](20) NOT NULL,
	[TeamID] [char](20) NOT NULL,
	[SeasonID] [char](20) NOT NULL,
 CONSTRAINT [PK_PLAYER_TEAM_SEASON] PRIMARY KEY CLUSTERED 
(
	[PlayerID] ASC,
	[TeamID] ASC,
	[SeasonID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[POSITION]    Script Date: 12/8/2014 11:43:24 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[POSITION](
	[PositionID] [char](20) NOT NULL,
	[PositionName] [nvarchar](30) NOT NULL,
 CONSTRAINT [PK_POSITION] PRIMARY KEY CLUSTERED 
(
	[PositionID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[REFEREE]    Script Date: 12/8/2014 11:43:24 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[REFEREE](
	[RefereeID] [char](20) NOT NULL,
	[RefereeName] [nvarchar](50) NOT NULL,
 CONSTRAINT [PK_REFEREE] PRIMARY KEY CLUSTERED 
(
	[RefereeID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[ROUND]    Script Date: 12/8/2014 11:43:24 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[ROUND](
	[RoundID] [char](20) NOT NULL,
	[FixtureID] [char](20) NOT NULL,
	[MatchCount] [int] NOT NULL,
 CONSTRAINT [PK_ROUND] PRIMARY KEY CLUSTERED 
(
	[RoundID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[SEASON]    Script Date: 12/8/2014 11:43:24 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[SEASON](
	[SeasonID] [char](20) NOT NULL,
	[SeasonName] [nvarchar](50) NOT NULL,
	[StartDate] [date] NOT NULL,
	[EndDate] [date] NOT NULL,
	[Sponsor] [nvarchar](50) NOT NULL,
	[Expenditure] [bigint] NOT NULL,
 CONSTRAINT [PK_SEASON] PRIMARY KEY CLUSTERED 
(
	[SeasonID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[SEASON_FIXTURES]    Script Date: 12/8/2014 11:43:24 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[SEASON_FIXTURES](
	[FixtureID] [char](20) NOT NULL,
	[SeasonID] [char](20) NOT NULL,
	[RoundCount] [int] NOT NULL,
 CONSTRAINT [PK_SEASON_FIXTURES] PRIMARY KEY CLUSTERED 
(
	[FixtureID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[STADIUM]    Script Date: 12/8/2014 11:43:24 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[STADIUM](
	[StadiumID] [char](20) NOT NULL,
	[StadiumName] [nchar](50) NOT NULL,
	[Tankage] [int] NOT NULL,
	[Address] [nvarchar](200) NULL,
 CONSTRAINT [PK_STADIUM] PRIMARY KEY CLUSTERED 
(
	[StadiumID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[STANDING]    Script Date: 12/8/2014 11:43:24 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[STANDING](
	[SeasonID] [char](20) NOT NULL,
	[TeamID] [char](20) NOT NULL,
	[TotalMatch] [int] NOT NULL,
	[TotalMatchWon] [int] NOT NULL,
	[TotalMatchLost] [int] NOT NULL,
	[TotalMatchDrawn] [int] NOT NULL,
	[GoalsFor] [int] NOT NULL,
	[GoalsAgainst] [int] NOT NULL,
	[GoalsDifference] [int] NOT NULL,
	[Point] [int] NOT NULL,
 CONSTRAINT [PK_STANDING] PRIMARY KEY CLUSTERED 
(
	[SeasonID] ASC,
	[TeamID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[SUPPORT]    Script Date: 12/8/2014 11:43:24 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[SUPPORT](
	[Name] [char](20) NOT NULL,
	[Value] [int] NOT NULL
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[TEAM]    Script Date: 12/8/2014 11:43:24 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[TEAM](
	[TeamID] [char](20) NOT NULL,
	[Name] [nvarchar](20) NOT NULL,
	[Chairman] [nvarchar](50) NOT NULL,
	[StadiumID] [char](20) NOT NULL,
	[Email] [char](50) NOT NULL,
	[EstablishedYear] [date] NULL,
	[CEO] [nvarchar](50) NOT NULL,
	[Address] [nvarchar](200) NOT NULL,
	[PhoneNumber] [nchar](20) NULL,
	[Fax] [nchar](20) NULL,
 CONSTRAINT [PK_TEAM] PRIMARY KEY CLUSTERED 
(
	[TeamID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
INSERT [dbo].[CARD_TYPE] ([CardTypeID], [CardName]) VALUES (N'C0001               ', N'Thẻ đỏ')
INSERT [dbo].[CARD_TYPE] ([CardTypeID], [CardName]) VALUES (N'C0002               ', N'Thẻ vàng')
INSERT [dbo].[COACH] ([CoachID], [CoachName], [BirthDay], [Address], [PhoneNumber]) VALUES (N'CH0001              ', N'Lê Huỳnh Đức', 1972, N'Đà Nẵng', N'                    ')
INSERT [dbo].[COACH] ([CoachID], [CoachName], [BirthDay], [Address], [PhoneNumber]) VALUES (N'CH0002              ', N'Triệu Quang Hà', 1973, N'Thanh Hóa', NULL)
INSERT [dbo].[COACH] ([CoachID], [CoachName], [BirthDay], [Address], [PhoneNumber]) VALUES (N'CH0003              ', N'Đỗ Mạnh Dũng', 1970, N'Hà Tây', NULL)
INSERT [dbo].[COACH] ([CoachID], [CoachName], [BirthDay], [Address], [PhoneNumber]) VALUES (N'CH0004              ', N'Nguyễn Phúc Nguyên Chương', 1974, N'TP Hồ Chí Minh', NULL)
INSERT [dbo].[COACH] ([CoachID], [CoachName], [BirthDay], [Address], [PhoneNumber]) VALUES (N'CH0005              ', N'Văn Sỹ Hùng', 1970, N'Thanh Hóa', NULL)
INSERT [dbo].[COACH] ([CoachID], [CoachName], [BirthDay], [Address], [PhoneNumber]) VALUES (N'CH0006              ', N'Nguyễn Hữu Thắng', 1972, N'Hà Tĩnh', NULL)
INSERT [dbo].[COACH] ([CoachID], [CoachName], [BirthDay], [Address], [PhoneNumber]) VALUES (N'CH0007              ', N'Vũ Công Tuyền', 1969, N'Thái Bình', NULL)
INSERT [dbo].[COACH] ([CoachID], [CoachName], [BirthDay], [Address], [PhoneNumber]) VALUES (N'CH0008              ', N'Nguyễn Văn Hùng', 1980, N'DakNong', N'01657598798         ')
INSERT [dbo].[COACH] ([CoachID], [CoachName], [BirthDay], [Address], [PhoneNumber]) VALUES (N'CH0009              ', N'Lê Đức Sang', 1979, N'Quảng Nam', N'0978071865          ')
INSERT [dbo].[COACH] ([CoachID], [CoachName], [BirthDay], [Address], [PhoneNumber]) VALUES (N'CH0010              ', N'Sơ Tuấn Hoàng', 1979, N'Quảng Nam', NULL)
INSERT [dbo].[NATIONAL] ([NationalID], [NationalName]) VALUES (N'N0001               ', N'Việt Nam')
INSERT [dbo].[NATIONAL] ([NationalID], [NationalName]) VALUES (N'N0002               ', N'England')
INSERT [dbo].[NATIONAL] ([NationalID], [NationalName]) VALUES (N'N0003               ', N'Argentina')
INSERT [dbo].[NATIONAL] ([NationalID], [NationalName]) VALUES (N'N0004               ', N'Andorra')
INSERT [dbo].[NATIONAL] ([NationalID], [NationalName]) VALUES (N'N0005               ', N'Armenia')
INSERT [dbo].[NATIONAL] ([NationalID], [NationalName]) VALUES (N'N0006               ', N'Germany')
INSERT [dbo].[NATIONAL] ([NationalID], [NationalName]) VALUES (N'N0007               ', N'Ecuador')
INSERT [dbo].[NATIONAL] ([NationalID], [NationalName]) VALUES (N'N0008               ', N'Ghana')
INSERT [dbo].[NATIONAL] ([NationalID], [NationalName]) VALUES (N'N0009               ', N'South Korea')
INSERT [dbo].[NATIONAL] ([NationalID], [NationalName]) VALUES (N'N0010               ', N'Indonesia')
INSERT [dbo].[NATIONAL] ([NationalID], [NationalName]) VALUES (N'N0011               ', N'Jamaica')
INSERT [dbo].[NATIONAL] ([NationalID], [NationalName]) VALUES (N'N0012               ', N'Laos')
INSERT [dbo].[NATIONAL] ([NationalID], [NationalName]) VALUES (N'N0013               ', N'Malaysia')
INSERT [dbo].[NATIONAL] ([NationalID], [NationalName]) VALUES (N'N0014               ', N'Mexico')
INSERT [dbo].[NATIONAL] ([NationalID], [NationalName]) VALUES (N'N0015               ', N'American')
INSERT [dbo].[PLAYER] ([PlayerID], [FullName], [BirthDay], [PositionID], [NationalID], [NumberOfCloth], [Height], [Weight]) VALUES (N'PL0001              ', N'Dương Hồng Sơn', CAST(0x26130B00 AS Date), N'P0001               ', N'N0001               ', 1, 175, 75)
INSERT [dbo].[PLAYER] ([PlayerID], [FullName], [BirthDay], [PositionID], [NationalID], [NumberOfCloth], [Height], [Weight]) VALUES (N'PL0002              ', N'Nguyễn Văn Dũng', CAST(0xE1040B00 AS Date), N'P0002               ', N'N0001               ', 4, 174, 68)
INSERT [dbo].[PLAYER] ([PlayerID], [FullName], [BirthDay], [PositionID], [NationalID], [NumberOfCloth], [Height], [Weight]) VALUES (N'PL0003              ', N'Nguyễn Văn Biển', CAST(0x3D160B00 AS Date), N'P0003               ', N'N0001               ', 5, 173, 70)
INSERT [dbo].[PLAYER] ([PlayerID], [FullName], [BirthDay], [PositionID], [NationalID], [NumberOfCloth], [Height], [Weight]) VALUES (N'PL0004              ', N'Bùi Văn Hiếu', CAST(0x3D160B00 AS Date), N'P0004               ', N'N0001               ', 6, 173, 70)
INSERT [dbo].[PLAYER] ([PlayerID], [FullName], [BirthDay], [PositionID], [NationalID], [NumberOfCloth], [Height], [Weight]) VALUES (N'PL0005              ', N'Hector Hughtun Kerin Vaghaun', CAST(0x3D160B00 AS Date), N'P0005               ', N'N0006               ', 7, 173, 70)
INSERT [dbo].[PLAYER] ([PlayerID], [FullName], [BirthDay], [PositionID], [NationalID], [NumberOfCloth], [Height], [Weight]) VALUES (N'PL0006              ', N'Cao Sỹ Cường', CAST(0xF5110B00 AS Date), N'P0006               ', N'N0001               ', 8, 160, 68)
INSERT [dbo].[PLAYER] ([PlayerID], [FullName], [BirthDay], [PositionID], [NationalID], [NumberOfCloth], [Height], [Weight]) VALUES (N'PL0007              ', N'Phạm Thành Lương', CAST(0xD6140B00 AS Date), N'P0007               ', N'N0001               ', 11, 167, 65)
INSERT [dbo].[PLAYER] ([PlayerID], [FullName], [BirthDay], [PositionID], [NationalID], [NumberOfCloth], [Height], [Weight]) VALUES (N'PL0008              ', N'Nguyễn Văn Quyết', CAST(0xD6140B00 AS Date), N'P0007               ', N'N0001               ', 10, 172, 65)
INSERT [dbo].[PLAYER] ([PlayerID], [FullName], [BirthDay], [PositionID], [NationalID], [NumberOfCloth], [Height], [Weight]) VALUES (N'PL0009              ', N'Nguyễn Hồng Tiến', CAST(0xD6140B00 AS Date), N'P0007               ', N'N0001               ', 14, 172, 65)
INSERT [dbo].[PLAYER] ([PlayerID], [FullName], [BirthDay], [PositionID], [NationalID], [NumberOfCloth], [Height], [Weight]) VALUES (N'PL0010              ', N'Phan Đỗ Nhật Tân', CAST(0x1E190B00 AS Date), N'P0008               ', N'N0001               ', 16, 168, 70)
INSERT [dbo].[POSITION] ([PositionID], [PositionName]) VALUES (N'P0001               ', N'Thủ môn')
INSERT [dbo].[POSITION] ([PositionID], [PositionName]) VALUES (N'P0002               ', N'Trung vệ')
INSERT [dbo].[POSITION] ([PositionID], [PositionName]) VALUES (N'P0003               ', N'Hậu vệ cánh trái')
INSERT [dbo].[POSITION] ([PositionID], [PositionName]) VALUES (N'P0004               ', N'Hậu vệ quét')
INSERT [dbo].[POSITION] ([PositionID], [PositionName]) VALUES (N'P0005               ', N'Hậu vệ tự do')
INSERT [dbo].[POSITION] ([PositionID], [PositionName]) VALUES (N'P0006               ', N'Tiền vệ phòng ngự')
INSERT [dbo].[POSITION] ([PositionID], [PositionName]) VALUES (N'P0007               ', N'Tiền vệ trung tâm')
INSERT [dbo].[POSITION] ([PositionID], [PositionName]) VALUES (N'P0008               ', N'Tiền vệ cánh trái')
INSERT [dbo].[POSITION] ([PositionID], [PositionName]) VALUES (N'P0009               ', N'Tiền vệ tấn công')
INSERT [dbo].[POSITION] ([PositionID], [PositionName]) VALUES (N'P0010               ', N'Tiền đạo trung tâm')
INSERT [dbo].[POSITION] ([PositionID], [PositionName]) VALUES (N'P0011               ', N'Tiền đạo cánh trái')
INSERT [dbo].[POSITION] ([PositionID], [PositionName]) VALUES (N'P0012               ', N'Tiền đạo toàn năng')
INSERT [dbo].[POSITION] ([PositionID], [PositionName]) VALUES (N'P0013               ', N'Tiền đạo hộ công')
INSERT [dbo].[POSITION] ([PositionID], [PositionName]) VALUES (N'P0014               ', N'Hậu vệ cánh phải')
INSERT [dbo].[POSITION] ([PositionID], [PositionName]) VALUES (N'P0015               ', N'Tiền vệ cánh phải')
INSERT [dbo].[POSITION] ([PositionID], [PositionName]) VALUES (N'P0016               ', N'Tiền đạo cánh phải')
INSERT [dbo].[REFEREE] ([RefereeID], [RefereeName]) VALUES (N'R0001               ', N'Võ Minh Trí')
INSERT [dbo].[REFEREE] ([RefereeID], [RefereeName]) VALUES (N'R0002               ', N'Phùng Đình Dũng')
INSERT [dbo].[REFEREE] ([RefereeID], [RefereeName]) VALUES (N'R0003               ', N'Võ Quang Vinh')
INSERT [dbo].[REFEREE] ([RefereeID], [RefereeName]) VALUES (N'R0004               ', N'Hoàng Anh Tuấn')
INSERT [dbo].[REFEREE] ([RefereeID], [RefereeName]) VALUES (N'R0005               ', N'Nguyễn Hoàng Minh')
INSERT [dbo].[REFEREE] ([RefereeID], [RefereeName]) VALUES (N'R0006               ', N'Nguyễn Ngọc Hà')
INSERT [dbo].[REFEREE] ([RefereeID], [RefereeName]) VALUES (N'R0007               ', N'Nguyễn Phong Vũ')
INSERT [dbo].[REFEREE] ([RefereeID], [RefereeName]) VALUES (N'R0008               ', N'Trần Thanh Liêm')
INSERT [dbo].[REFEREE] ([RefereeID], [RefereeName]) VALUES (N'R0009               ', N'Nguyễn Trường Xuân')
INSERT [dbo].[REFEREE] ([RefereeID], [RefereeName]) VALUES (N'R0010               ', N'Hoàng Ngọc Hà')
INSERT [dbo].[SEASON] ([SeasonID], [SeasonName], [StartDate], [EndDate], [Sponsor], [Expenditure]) VALUES (N'S0001               ', N'Eximbank 2013', CAST(0xA9360B00 AS Date), CAST(0x7C370B00 AS Date), N'Eximbank', 30000000000)
INSERT [dbo].[SEASON] ([SeasonID], [SeasonName], [StartDate], [EndDate], [Sponsor], [Expenditure]) VALUES (N'S0002               ', N'Eximbank 2014', CAST(0x04380B00 AS Date), CAST(0xF2380B00 AS Date), N'Eximbank', 35000000000)
INSERT [dbo].[STADIUM] ([StadiumID], [StadiumName], [Tankage], [Address]) VALUES (N'ST0001              ', N'Hàng Đẫy                                          ', 18000, N'Trịnh Hoài Đức, Hà Nội')
INSERT [dbo].[STADIUM] ([StadiumID], [StadiumName], [Tankage], [Address]) VALUES (N'ST0002              ', N'Long An                                           ', 20000, N'Số 44B đường Trương Định - Thành phố Tân An, Long An')
INSERT [dbo].[STADIUM] ([StadiumID], [StadiumName], [Tankage], [Address]) VALUES (N'ST0003              ', N'Cẩm Phả                                           ', 10000, N'TP. Cẩm Phản, Tỉnh Quảng Ninh')
INSERT [dbo].[STADIUM] ([StadiumID], [StadiumName], [Tankage], [Address]) VALUES (N'ST0004              ', N'Thanh Hóa                                         ', 14000, N'37-39 Lê Quý Đôn, Phường Ba Đình, TP Thanh Hóa')
INSERT [dbo].[STADIUM] ([StadiumID], [StadiumName], [Tankage], [Address]) VALUES (N'ST0005              ', N'Pleiku                                            ', 12000, N'22 Quang Trung, P. Tây Sơn, T.p Pleiku, Tỉnh Gia Lai')
INSERT [dbo].[STADIUM] ([StadiumID], [StadiumName], [Tankage], [Address]) VALUES (N'ST0006              ', N'Chi Lăng                                          ', 30000, N'38 Ngô Gia Tự, P. Hải Châu 2, Q. Hải Châu, TP Đà Nẵng')
INSERT [dbo].[STADIUM] ([StadiumID], [StadiumName], [Tankage], [Address]) VALUES (N'ST0007              ', N'Bình Dương                                        ', 20000, N'Đường 30/4, Thị Xã Thủ Dầu Một, Bình Dương')
INSERT [dbo].[STADIUM] ([StadiumID], [StadiumName], [Tankage], [Address]) VALUES (N'ST0008              ', N'Lạch Tray                                         ', 30000, N'Số 17 Lạch Tray, Quận Ngô Quyền, Tp Hải Phòng')
INSERT [dbo].[STADIUM] ([StadiumID], [StadiumName], [Tankage], [Address]) VALUES (N'ST0009              ', N'Đồng Nai                                          ', 22000, N'Đường Đồng Khởi, Phường Tân Hiệp, TP Biên Hòa, Đồng Na')
INSERT [dbo].[STADIUM] ([StadiumID], [StadiumName], [Tankage], [Address]) VALUES (N'ST0010              ', N'Quảng Nam                                         ', 15000, N'Tổ 8 phường Hòa Hương, TP Tam Kỳ, Tỉnh Quảng Nam')
ALTER TABLE [dbo].[CARD]  WITH CHECK ADD  CONSTRAINT [FK_CARD_CARD_TYPE] FOREIGN KEY([CardTypeID])
REFERENCES [dbo].[CARD_TYPE] ([CardTypeID])
GO
ALTER TABLE [dbo].[CARD] CHECK CONSTRAINT [FK_CARD_CARD_TYPE]
GO
ALTER TABLE [dbo].[CARD]  WITH CHECK ADD  CONSTRAINT [FK_CARD_MATCH] FOREIGN KEY([MatchID])
REFERENCES [dbo].[MATCH] ([MatchID])
GO
ALTER TABLE [dbo].[CARD] CHECK CONSTRAINT [FK_CARD_MATCH]
GO
ALTER TABLE [dbo].[CARD]  WITH CHECK ADD  CONSTRAINT [FK_CARD_PLAYER] FOREIGN KEY([PlayerID])
REFERENCES [dbo].[PLAYER] ([PlayerID])
GO
ALTER TABLE [dbo].[CARD] CHECK CONSTRAINT [FK_CARD_PLAYER]
GO
ALTER TABLE [dbo].[COACH_TEAM_SEASON]  WITH CHECK ADD  CONSTRAINT [FK_COACH_TEAM_SEASON_COACH] FOREIGN KEY([CoachID])
REFERENCES [dbo].[COACH] ([CoachID])
GO
ALTER TABLE [dbo].[COACH_TEAM_SEASON] CHECK CONSTRAINT [FK_COACH_TEAM_SEASON_COACH]
GO
ALTER TABLE [dbo].[COACH_TEAM_SEASON]  WITH CHECK ADD  CONSTRAINT [FK_COACH_TEAM_SEASON_SEASON] FOREIGN KEY([SeasonID])
REFERENCES [dbo].[SEASON] ([SeasonID])
GO
ALTER TABLE [dbo].[COACH_TEAM_SEASON] CHECK CONSTRAINT [FK_COACH_TEAM_SEASON_SEASON]
GO
ALTER TABLE [dbo].[COACH_TEAM_SEASON]  WITH CHECK ADD  CONSTRAINT [FK_COACH_TEAM_SEASON_TEAM] FOREIGN KEY([TeamID])
REFERENCES [dbo].[TEAM] ([TeamID])
GO
ALTER TABLE [dbo].[COACH_TEAM_SEASON] CHECK CONSTRAINT [FK_COACH_TEAM_SEASON_TEAM]
GO
ALTER TABLE [dbo].[GOAL]  WITH CHECK ADD  CONSTRAINT [FK_GOAL_MATCH] FOREIGN KEY([MatchID])
REFERENCES [dbo].[MATCH] ([MatchID])
GO
ALTER TABLE [dbo].[GOAL] CHECK CONSTRAINT [FK_GOAL_MATCH]
GO
ALTER TABLE [dbo].[GOAL]  WITH CHECK ADD  CONSTRAINT [FK_GOAL_PLAYER] FOREIGN KEY([PlayerID])
REFERENCES [dbo].[PLAYER] ([PlayerID])
GO
ALTER TABLE [dbo].[GOAL] CHECK CONSTRAINT [FK_GOAL_PLAYER]
GO
ALTER TABLE [dbo].[MATCH]  WITH CHECK ADD  CONSTRAINT [FK_MATCH_REFEREE] FOREIGN KEY([RefereeID])
REFERENCES [dbo].[REFEREE] ([RefereeID])
GO
ALTER TABLE [dbo].[MATCH] CHECK CONSTRAINT [FK_MATCH_REFEREE]
GO
ALTER TABLE [dbo].[MATCH]  WITH CHECK ADD  CONSTRAINT [FK_MATCH_ROUND] FOREIGN KEY([RoundID])
REFERENCES [dbo].[ROUND] ([RoundID])
GO
ALTER TABLE [dbo].[MATCH] CHECK CONSTRAINT [FK_MATCH_ROUND]
GO
ALTER TABLE [dbo].[PLAYER]  WITH CHECK ADD  CONSTRAINT [FK_PLAYER_NATIONAL] FOREIGN KEY([NationalID])
REFERENCES [dbo].[NATIONAL] ([NationalID])
GO
ALTER TABLE [dbo].[PLAYER] CHECK CONSTRAINT [FK_PLAYER_NATIONAL]
GO
ALTER TABLE [dbo].[PLAYER]  WITH CHECK ADD  CONSTRAINT [FK_PLAYER_POSITION] FOREIGN KEY([PositionID])
REFERENCES [dbo].[POSITION] ([PositionID])
GO
ALTER TABLE [dbo].[PLAYER] CHECK CONSTRAINT [FK_PLAYER_POSITION]
GO
ALTER TABLE [dbo].[PLAYER_TEAM_SEASON]  WITH CHECK ADD  CONSTRAINT [FK_PLAYER_TEAM_SEASON_PLAYER] FOREIGN KEY([PlayerID])
REFERENCES [dbo].[PLAYER] ([PlayerID])
GO
ALTER TABLE [dbo].[PLAYER_TEAM_SEASON] CHECK CONSTRAINT [FK_PLAYER_TEAM_SEASON_PLAYER]
GO
ALTER TABLE [dbo].[PLAYER_TEAM_SEASON]  WITH CHECK ADD  CONSTRAINT [FK_PLAYER_TEAM_SEASON_SEASON] FOREIGN KEY([SeasonID])
REFERENCES [dbo].[SEASON] ([SeasonID])
GO
ALTER TABLE [dbo].[PLAYER_TEAM_SEASON] CHECK CONSTRAINT [FK_PLAYER_TEAM_SEASON_SEASON]
GO
ALTER TABLE [dbo].[PLAYER_TEAM_SEASON]  WITH CHECK ADD  CONSTRAINT [FK_PLAYER_TEAM_SEASON_TEAM] FOREIGN KEY([TeamID])
REFERENCES [dbo].[TEAM] ([TeamID])
GO
ALTER TABLE [dbo].[PLAYER_TEAM_SEASON] CHECK CONSTRAINT [FK_PLAYER_TEAM_SEASON_TEAM]
GO
ALTER TABLE [dbo].[ROUND]  WITH CHECK ADD  CONSTRAINT [FK_ROUND_SEASON_FIXTURES] FOREIGN KEY([FixtureID])
REFERENCES [dbo].[SEASON_FIXTURES] ([FixtureID])
GO
ALTER TABLE [dbo].[ROUND] CHECK CONSTRAINT [FK_ROUND_SEASON_FIXTURES]
GO
ALTER TABLE [dbo].[SEASON_FIXTURES]  WITH CHECK ADD  CONSTRAINT [FK_SEASON_FIXTURES_SEASON] FOREIGN KEY([SeasonID])
REFERENCES [dbo].[SEASON] ([SeasonID])
GO
ALTER TABLE [dbo].[SEASON_FIXTURES] CHECK CONSTRAINT [FK_SEASON_FIXTURES_SEASON]
GO
ALTER TABLE [dbo].[STANDING]  WITH CHECK ADD  CONSTRAINT [FK_STANDING_SEASON] FOREIGN KEY([SeasonID])
REFERENCES [dbo].[SEASON] ([SeasonID])
GO
ALTER TABLE [dbo].[STANDING] CHECK CONSTRAINT [FK_STANDING_SEASON]
GO
ALTER TABLE [dbo].[STANDING]  WITH CHECK ADD  CONSTRAINT [FK_STANDING_TEAM] FOREIGN KEY([TeamID])
REFERENCES [dbo].[TEAM] ([TeamID])
GO
ALTER TABLE [dbo].[STANDING] CHECK CONSTRAINT [FK_STANDING_TEAM]
GO
ALTER TABLE [dbo].[TEAM]  WITH CHECK ADD  CONSTRAINT [FK_TEAM_STADIUM] FOREIGN KEY([StadiumID])
REFERENCES [dbo].[STADIUM] ([StadiumID])
GO
ALTER TABLE [dbo].[TEAM] CHECK CONSTRAINT [FK_TEAM_STADIUM]
GO
