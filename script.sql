USE [sangld]
GO
/****** Object:  StoredProcedure [dbo].[DeleteCardTypeValue]    Script Date: 12/17/2014 1:44:06 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[DeleteCardTypeValue]
(
	@CardTypeID char(20)
)
	
AS
	DELETE FROM CARD_TYPE WHERE CardTypeID = @CardTypeID
	RETURN

GO
/****** Object:  StoredProcedure [dbo].[DeleteCardValue]    Script Date: 12/17/2014 1:44:06 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[DeleteCardValue]
@CardID char(20)
AS
BEGIN

DELETE CARD WHERE [CardID] = @CardID

END

GO
/****** Object:  StoredProcedure [dbo].[DeleteCoachTeamSeasonValue]    Script Date: 12/17/2014 1:44:06 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[DeleteCoachTeamSeasonValue]
@CoachID char(20),
@TeamID char(20),
@SeasonID char(20)
AS
BEGIN

DELETE COACH_TEAM_SEASON WHERE [CoachID] = @CoachID AND [TeamID] = @TeamID AND [SeasonID] = @SeasonID

END

GO
/****** Object:  StoredProcedure [dbo].[DeleteCoachValue]    Script Date: 12/17/2014 1:44:06 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[DeleteCoachValue]
@CoachID char(20)
AS
BEGIN

DELETE COACH WHERE [CoachID] = @CoachID

END

GO
/****** Object:  StoredProcedure [dbo].[DeleteRefereeValue]    Script Date: 12/17/2014 1:44:06 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[DeleteRefereeValue]
@RefereeID char(20)
AS
BEGIN

DELETE REFEREE WHERE [RefereeID] = @RefereeID

END
GO
/****** Object:  StoredProcedure [dbo].[DeleteSeasonValue]    Script Date: 12/17/2014 1:44:06 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[DeleteSeasonValue]
(
	@SeasonID char(20)
)
	
AS
	DELETE FROM SEASON WHERE SeasonID = @SeasonID
	RETURN
GO
/****** Object:  StoredProcedure [dbo].[GetAllCardTypeValue]    Script Date: 12/17/2014 1:44:06 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[GetAllCardTypeValue]
	
AS
	select* from CARD_TYPE;
	RETURN

GO
/****** Object:  StoredProcedure [dbo].[GetAllCardValue]    Script Date: 12/17/2014 1:44:06 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[GetAllCardValue]
AS
BEGIN

SELECT * FROM CARD

END

GO
/****** Object:  StoredProcedure [dbo].[GetAllCoachTeamSeasonValue]    Script Date: 12/17/2014 1:44:06 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[GetAllCoachTeamSeasonValue]
AS
BEGIN

SELECT * FROM COACH_TEAM_SEASON

END

GO
/****** Object:  StoredProcedure [dbo].[GetAllCoachValue]    Script Date: 12/17/2014 1:44:06 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[GetAllCoachValue]
AS
BEGIN

SELECT * FROM COACH

END

GO
/****** Object:  StoredProcedure [dbo].[GetAllSeasonNameValue]    Script Date: 12/17/2014 1:44:06 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROC [dbo].[GetAllSeasonNameValue]
AS
BEGIN
	SELECT SeasonName FROM SEASON 
END
GO
/****** Object:  StoredProcedure [dbo].[GetAllSeasonValue]    Script Date: 12/17/2014 1:44:06 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

CREATE PROC [dbo].[GetAllSeasonValue]
AS
BEGIN
	SELECT * FROM SEASON
END
GO
/****** Object:  StoredProcedure [dbo].[GetAllTeamValue]    Script Date: 12/17/2014 1:44:06 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROC [dbo].[GetAllTeamValue]

AS
BEGIN
	SELECT * FROM TEAM
END
GO
/****** Object:  StoredProcedure [dbo].[GetCardTypeIdByName]    Script Date: 12/17/2014 1:44:06 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[GetCardTypeIdByName]
	@CardTypeName nvarchar(20)
AS
	
	select * from CARD_TYPE where [CARD_TYPE].CardName = @CardTypeName ; --WHERE condition;
	RETURN

--GetCardTypeIdByName @CardTypeName = N'Thẻ đỏ'
GO
/****** Object:  StoredProcedure [dbo].[GetCardTypeName]    Script Date: 12/17/2014 1:44:06 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[GetCardTypeName]
	@CardID char(20)
AS
	select [CARD_TYPE].CardName from CARD_TYPE; --WHERE condition;
	RETURN
GO
/****** Object:  StoredProcedure [dbo].[GetRefereeBySeason]    Script Date: 12/17/2014 1:44:06 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[GetRefereeBySeason]
	@SeasonName nvarchar(30)	
AS
BEGIN	
	SELECT RefereeID , RefereeName, Email, PhoneNumber, BirthDate, [Address] FROM REFEREE, SEASON 
	WHERE REFEREE.SeasonID = SEASON.SeasonID AND SeasonName = @SeasonName
END
GO
/****** Object:  StoredProcedure [dbo].[GetTeamBySeasonName]    Script Date: 12/17/2014 1:44:06 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROC [dbo].[GetTeamBySeasonName]
(
	@SeasonName nvarchar(50)
)
AS
BEGIN
	SELECT TeamID, Name, Logo FROM TEAM WHERE TeamID IN (
		SELECT DISTINCT  TEAM.TeamID FROM TEAM , PLAYER_TEAM_SEASON
		WHERE TEAM.TeamID = PLAYER_TEAM_SEASON.TeamID AND PLAYER_TEAM_SEASON.SeasonID IN ( SELECT SeasonID FROM SEASON WHERE SeasonName = @SeasonName)
	)
END
GO
/****** Object:  StoredProcedure [dbo].[GetTeamBySeasonNameAndTeamName]    Script Date: 12/17/2014 1:44:06 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROC [dbo].[GetTeamBySeasonNameAndTeamName]
(
	@SeasonName nvarchar(50),
	@TeamName nvarchar(50)
)
AS
BEGIN
	SELECT TeamID, Name, Chairman, Email, EstablishedYear, CEO, TEAM.[Address], PhoneNumber, Fax, Logo, STADIUM.StadiumID, StadiumName,STADIUM.[Address], STADIUM.Tankage FROM TEAM, STADIUM WHERE TeamID IN (
		SELECT DISTINCT  TEAM.TeamID FROM TEAM , PLAYER_TEAM_SEASON
		WHERE TEAM.TeamID = PLAYER_TEAM_SEASON.TeamID AND PLAYER_TEAM_SEASON.SeasonID IN ( SELECT SeasonID FROM SEASON WHERE SeasonName = @SeasonName) AND TEAM.Name = @TeamName
	) AND TEAM.StadiumID = STADIUM.StadiumID
END
GO
/****** Object:  StoredProcedure [dbo].[InsertCardTypeValue]    Script Date: 12/17/2014 1:44:06 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[InsertCardTypeValue]
(
	@cardID char(20),
	@cardName nvarchar(30)
)
AS
DECLARE @ID int;
	INSERT INTO CARD_TYPE VALUES(@cardID, @cardName)
	--RETURN

GO
/****** Object:  StoredProcedure [dbo].[InsertCardValue]    Script Date: 12/17/2014 1:44:06 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[InsertCardValue]
@CardID char(20),
@PlayerID char(20),
@MatchID char(20),
@CardTypeID char(20),
@Time int
AS
BEGIN

    INSERT INTO CARD
        ([CardID], [PlayerID], [MatchID], [CardTypeID], [Time])
    VALUES
        (@CardID, @PlayerID, @MatchID, @CardTypeID, @Time)
END

GO
/****** Object:  StoredProcedure [dbo].[InsertCoachTeamSeasonValue]    Script Date: 12/17/2014 1:44:06 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[InsertCoachTeamSeasonValue]
@CoachID char(20),
@TeamID char(20),
@SeasonID char(20)
AS
BEGIN

    INSERT INTO COACH_TEAM_SEASON
        ([CoachID], [TeamID], [SeasonID])
    VALUES
        (@CoachID, @TeamID, @SeasonID)
END

GO
/****** Object:  StoredProcedure [dbo].[InsertCoachValue]    Script Date: 12/17/2014 1:44:06 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[InsertCoachValue]
@CoachID char(20),
@CoachName nvarchar(50),
@BirthDay int,
@Address nvarchar(200) = NULL,
@PhoneNumber char(20) = NULL
AS
BEGIN

    INSERT INTO COACH
        ([CoachID], [CoachName], [BirthDay], [Address], [PhoneNumber])
    VALUES
        (@CoachID, @CoachName, @BirthDay, @Address, @PhoneNumber)
END

GO
/****** Object:  StoredProcedure [dbo].[InsertRefereeValue]    Script Date: 12/17/2014 1:44:06 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[InsertRefereeValue]
(
	@RefereeID char(20),
	@RefereeName nvarchar(50),
	@Email char(30),
	@PhoneNumber char(20),
	@BirthDate date,
	@SeasonID char(20),
	@Address nvarchar(100)
)
AS
BEGIN
    INSERT INTO REFEREE
        ([RefereeID], [RefereeName], [Email], [PhoneNumber], [BirthDate], [SeasonID], [Address])
    VALUES
        (@RefereeID, @RefereeName, @Email, @PhoneNumber, @BirthDate, @SeasonID, @Address)
END
GO
/****** Object:  StoredProcedure [dbo].[InsertSeasonValue]    Script Date: 12/17/2014 1:44:06 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[InsertSeasonValue]
(
	@SeasonID char(20),
	@SeasonName nvarchar(50),
	@StartDate date,
	@EndDate date,
	@Sponsor nvarchar(50),
	@Expenditure bigint
)
AS
BEGIN
    INSERT INTO SEASON
        ([SeasonID], [SeasonName], [StartDate], [EndDate], [Sponsor], [Expenditure])
    VALUES
        (@SeasonID, @SeasonName, @StartDate, @EndDate, @Sponsor, @Expenditure)
END
GO
/****** Object:  StoredProcedure [dbo].[InsertTeamValue]    Script Date: 12/17/2014 1:44:06 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[InsertTeamValue]
@TeamID char(20),
@Name nvarchar(20),
@Chairman nvarchar(20),
@StadiumID char(20),
@Email char(50),
@EstablishedYear Date,
@CEO nvarchar(50),
@Address nvarchar(50),
@PhoneNumber nvarchar(20),
@Fax nchar(20),
@Logo image
AS
BEGIN

    INSERT INTO Team(TeamID, Name, Chairman, StadiumID, Email, EstablishedYear, CEO, [Address], PhoneNumber, Fax, Logo)
    VALUES
        (@TeamID, @Name, @Chairman, @StadiumID, @Email, @EstablishedYear, @CEO, @Address, @PhoneNumber, @Fax, @Logo)
END
GO
/****** Object:  StoredProcedure [dbo].[UpdateCardTypeValue]    Script Date: 12/17/2014 1:44:06 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[UpdateCardTypeValue]
(
	@cardTypeID char(20),
	@cardName nvarchar(30)
)
AS
	UPDATE CARD_TYPE SET CardName =  @cardName WHERE cardTypeID = @cardTypeID; 
	--RETURN

GO
/****** Object:  StoredProcedure [dbo].[UpdateCardValue]    Script Date: 12/17/2014 1:44:06 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[UpdateCardValue]
@CardID char(20),
@PlayerID char(20),
@MatchID char(20),
@CardTypeID char(20),
@Time int
AS
BEGIN

UPDATE CARD SET [PlayerID] = @PlayerID, [MatchID] = @MatchID, [CardTypeID] = @CardTypeID, [Time] = @Time WHERE [CardID] = @CardID

END

GO
/****** Object:  StoredProcedure [dbo].[UpdateCoachTeamSeasonValue]    Script Date: 12/17/2014 1:44:06 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[UpdateCoachTeamSeasonValue]
@CoachID char(20),
@TeamID char(20),
@SeasonID char(20)
AS
BEGIN

UPDATE COACH_TEAM_SEASON SET [CoachID] = @CoachID, [TeamID] = @TeamID, [SeasonID] = @SeasonID WHERE [CoachID] = @CoachID AND [TeamID] = @TeamID AND [SeasonID] = @SeasonID

END

GO
/****** Object:  StoredProcedure [dbo].[UpdateCoachValue]    Script Date: 12/17/2014 1:44:06 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[UpdateCoachValue]
@CoachID char(20),
@CoachName nvarchar(50),
@BirthDay int,
@Address nvarchar(200) = NULL,
@PhoneNumber char(20) = NULL
AS
BEGIN

UPDATE COACH SET [CoachName] = @CoachName, [BirthDay] = @BirthDay, [Address] = @Address, [PhoneNumber] = @PhoneNumber WHERE [CoachID] = @CoachID

END

GO
/****** Object:  StoredProcedure [dbo].[UpdateRefereeValue]    Script Date: 12/17/2014 1:44:06 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[UpdateRefereeValue]
(
	@RefereeID char(20),
	@RefereeName nvarchar(50),
	@Email char(30),
	@PhoneNumber char(20),
	@BirthDate date,
	@SeasonID char(20),
	@Address nvarchar(100)
)
AS
BEGIN
	UPDATE REFEREE SET [RefereeName] =  @RefereeName, [Email] = @Email, [PhoneNumber] = @PhoneNumber, [BirthDate] = @BirthDate, [SeasonID] = @SeasonID, [Address] = @Address WHERE [RefereeID] = @RefereeID; 
END

GO
/****** Object:  StoredProcedure [dbo].[UpdateSeasonValue]    Script Date: 12/17/2014 1:44:06 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[UpdateSeasonValue]
(
	@SeasonID char(20),
	@SeasonName nvarchar(50),
	@StartDate date,
	@EndDate date,
	@Sponsor nvarchar(50),
	@Expenditure bigint
)
AS
BEGIN
	UPDATE SEASON SET SeasonName =  @SeasonName, StartDate = @StartDate, EndDate = @EndDate, Sponsor = @Sponsor, Expenditure = @Expenditure WHERE SeasonID = @SeasonID; 
END
GO
/****** Object:  Table [dbo].[CARD]    Script Date: 12/17/2014 1:44:06 AM ******/
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
/****** Object:  Table [dbo].[CARD_TYPE]    Script Date: 12/17/2014 1:44:06 AM ******/
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
/****** Object:  Table [dbo].[COACH]    Script Date: 12/17/2014 1:44:06 AM ******/
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
/****** Object:  Table [dbo].[COACH_TEAM_SEASON]    Script Date: 12/17/2014 1:44:06 AM ******/
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
/****** Object:  Table [dbo].[GOAL]    Script Date: 12/17/2014 1:44:06 AM ******/
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
/****** Object:  Table [dbo].[MATCH]    Script Date: 12/17/2014 1:44:06 AM ******/
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
/****** Object:  Table [dbo].[NATIONAL]    Script Date: 12/17/2014 1:44:06 AM ******/
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
/****** Object:  Table [dbo].[PLAYER]    Script Date: 12/17/2014 1:44:06 AM ******/
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
/****** Object:  Table [dbo].[PLAYER_TEAM_SEASON]    Script Date: 12/17/2014 1:44:06 AM ******/
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
/****** Object:  Table [dbo].[POSITION]    Script Date: 12/17/2014 1:44:06 AM ******/
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
/****** Object:  Table [dbo].[REFEREE]    Script Date: 12/17/2014 1:44:06 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[REFEREE](
	[RefereeID] [char](20) NOT NULL,
	[RefereeName] [nvarchar](50) NULL,
	[Email] [char](30) NULL,
	[PhoneNumber] [char](20) NULL,
	[BirthDate] [date] NULL,
	[SeasonID] [char](20) NULL,
	[Address] [nvarchar](100) NOT NULL,
 CONSTRAINT [PK_REFEREE] PRIMARY KEY CLUSTERED 
(
	[RefereeID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[ROUND]    Script Date: 12/17/2014 1:44:06 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[ROUND](
	[RoundID] [char](20) NOT NULL,
	[SeasonID] [char](20) NOT NULL,
	[RoundName] [nvarchar](20) NULL,
	[MatchCount] [int] NOT NULL,
 CONSTRAINT [PK_ROUND] PRIMARY KEY CLUSTERED 
(
	[RoundID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[SEASON]    Script Date: 12/17/2014 1:44:06 AM ******/
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
/****** Object:  Table [dbo].[STADIUM]    Script Date: 12/17/2014 1:44:06 AM ******/
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
/****** Object:  Table [dbo].[STANDING]    Script Date: 12/17/2014 1:44:06 AM ******/
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
/****** Object:  Table [dbo].[SUPPORT]    Script Date: 12/17/2014 1:44:06 AM ******/
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
/****** Object:  Table [dbo].[TEAM]    Script Date: 12/17/2014 1:44:06 AM ******/
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
	[Logo] [image] NULL,
 CONSTRAINT [PK_TEAM] PRIMARY KEY CLUSTERED 
(
	[TeamID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
INSERT [dbo].[CARD_TYPE] ([CardTypeID], [CardName]) VALUES (N'C0001               ', N'Thẻ đỏ')
INSERT [dbo].[CARD_TYPE] ([CardTypeID], [CardName]) VALUES (N'C0002               ', N'Thẻ vàng')
INSERT [dbo].[CARD_TYPE] ([CardTypeID], [CardName]) VALUES (N'C0004               ', N'the hồng')
INSERT [dbo].[CARD_TYPE] ([CardTypeID], [CardName]) VALUES (N'C0005               ', N'the xanh')
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
INSERT [dbo].[PLAYER_TEAM_SEASON] ([PlayerID], [TeamID], [SeasonID]) VALUES (N'PL0001              ', N'T00001              ', N'S0001               ')
INSERT [dbo].[PLAYER_TEAM_SEASON] ([PlayerID], [TeamID], [SeasonID]) VALUES (N'PL0002              ', N'T00001              ', N'S0001               ')
INSERT [dbo].[PLAYER_TEAM_SEASON] ([PlayerID], [TeamID], [SeasonID]) VALUES (N'PL0003              ', N'T00001              ', N'S0001               ')
INSERT [dbo].[PLAYER_TEAM_SEASON] ([PlayerID], [TeamID], [SeasonID]) VALUES (N'PL0004              ', N'T00001              ', N'S0001               ')
INSERT [dbo].[PLAYER_TEAM_SEASON] ([PlayerID], [TeamID], [SeasonID]) VALUES (N'PL0005              ', N'T00001              ', N'S0001               ')
INSERT [dbo].[PLAYER_TEAM_SEASON] ([PlayerID], [TeamID], [SeasonID]) VALUES (N'PL0006              ', N'T00001              ', N'S0002               ')
INSERT [dbo].[PLAYER_TEAM_SEASON] ([PlayerID], [TeamID], [SeasonID]) VALUES (N'PL0007              ', N'T00002              ', N'S0001               ')
INSERT [dbo].[PLAYER_TEAM_SEASON] ([PlayerID], [TeamID], [SeasonID]) VALUES (N'PL0008              ', N'T00002              ', N'S0001               ')
INSERT [dbo].[PLAYER_TEAM_SEASON] ([PlayerID], [TeamID], [SeasonID]) VALUES (N'PL0009              ', N'T00002              ', N'S0001               ')
INSERT [dbo].[PLAYER_TEAM_SEASON] ([PlayerID], [TeamID], [SeasonID]) VALUES (N'PL0010              ', N'T00002              ', N'S0001               ')
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
INSERT [dbo].[REFEREE] ([RefereeID], [RefereeName], [Email], [PhoneNumber], [BirthDate], [SeasonID], [Address]) VALUES (N'R0001               ', N'Võ Minh Trí', N'email1.@gmail.com             ', N'0142353455          ', CAST(0x3AF90A00 AS Date), N'S0002               ', N'Hồ Chí Minh')
INSERT [dbo].[REFEREE] ([RefereeID], [RefereeName], [Email], [PhoneNumber], [BirthDate], [SeasonID], [Address]) VALUES (N'R0002               ', N'Phùng Đình Dũng', N'email2.@gmail.com             ', N'012345345           ', CAST(0xC4040B00 AS Date), N'S0002               ', N'Hà Nội')
INSERT [dbo].[REFEREE] ([RefereeID], [RefereeName], [Email], [PhoneNumber], [BirthDate], [SeasonID], [Address]) VALUES (N'R0003               ', N'Võ Quang Vinh', N'email3.@gmail.com             ', N'0145345345          ', CAST(0x98000B00 AS Date), N'S0002               ', N'Cần Thơ')
INSERT [dbo].[REFEREE] ([RefereeID], [RefereeName], [Email], [PhoneNumber], [BirthDate], [SeasonID], [Address]) VALUES (N'R0004               ', N'Hoàng Anh Tuấn', N'email4.@gmail.com             ', N'0985345355          ', CAST(0x4AFF0A00 AS Date), N'S0002               ', N'Vũng tàu')
INSERT [dbo].[REFEREE] ([RefereeID], [RefereeName], [Email], [PhoneNumber], [BirthDate], [SeasonID], [Address]) VALUES (N'R0005               ', N'Nguyễn Hoàng Minh', N'email5.@gmail.com             ', N'0953452626          ', CAST(0xFB070B00 AS Date), N'S0002               ', N'Gia Lai')
INSERT [dbo].[REFEREE] ([RefereeID], [RefereeName], [Email], [PhoneNumber], [BirthDate], [SeasonID], [Address]) VALUES (N'R0006               ', N'Nguyễn Ngọc Hà', N'email6.@gmail.com             ', N'0934534532          ', CAST(0xE3040B00 AS Date), N'S0002               ', N'Đăk Lăk')
INSERT [dbo].[REFEREE] ([RefereeID], [RefereeName], [Email], [PhoneNumber], [BirthDate], [SeasonID], [Address]) VALUES (N'R0007               ', N'Nguyễn Phong Vũ', N'email7.@gmail.com             ', N'0834524535          ', CAST(0x21050B00 AS Date), N'S0002               ', N'Hải Phòng')
INSERT [dbo].[REFEREE] ([RefereeID], [RefereeName], [Email], [PhoneNumber], [BirthDate], [SeasonID], [Address]) VALUES (N'R0008               ', N'Trần Thanh Liêm', N'email8.@gmail.com             ', N'0145346634          ', CAST(0x3CFE0A00 AS Date), N'S0002               ', N'Thanh Hóa')
INSERT [dbo].[REFEREE] ([RefereeID], [RefereeName], [Email], [PhoneNumber], [BirthDate], [SeasonID], [Address]) VALUES (N'R0009               ', N'Trần Thanh Liêm', N'email9.@gmail.com             ', N'016534535           ', CAST(0x8B060B00 AS Date), N'S0002               ', N'Lào Cai')
INSERT [dbo].[REFEREE] ([RefereeID], [RefereeName], [Email], [PhoneNumber], [BirthDate], [SeasonID], [Address]) VALUES (N'R0010               ', N'Hoàng Ngọc Hà', N'email10.@gmail.com            ', N'0126395734          ', CAST(0x85070B00 AS Date), N'S0002               ', N'Bình Dương')
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
INSERT [dbo].[TEAM] ([TeamID], [Name], [Chairman], [StadiumID], [Email], [EstablishedYear], [CEO], [Address], [PhoneNumber], [Fax], [Logo]) VALUES (N'T00001              ', N'dsfasdf', N'sdfsdf', N'ST0001              ', N'fsdfasdf                                          ', CAST(0x5F390B00 AS Date), N'sdfsdf', N'dfsdf', N'23423               ', N'4234                ', 0xFFD8FFE000104A46494600010101006000600000FFE103524578696600004D4D002A00000008000551000004000000010000000051010003000000010001000051020001000003000000004A5103000100000001FF0000005104000100000001FF00000000000000007233888888DC231B68A88495BCA3F29793CAC7C889B99CD7D6D555A07549572C666764A5B6B700682DE54C454F201FE4211AFDEBEBE55953A4271C891C18CAB6ABDC2A2272817BB1130C2D7948FEDBDBFEFDFDA939249D3C25EC7A75F41815519B72E2342CFAC0BE98C2AA6B9C85780803EB635D00571457716AEE8B87006C31874326369062EA6B66F8B3AFEDECECCEE2D7006123B7D2C21A642E9B9B99E43A3373AC8B3A5A2B332B2CE5433C7B76767EB496794727FEF6F6016529668A78F39F9CA2ABABC4D5C84B956B14733A498E65F1A3A0E128212D8552F65D57FEFAFADC130A62A47DFAD4D45658560B0505BFBDBD4C4646006A2F1A7741FBE4E33A9460F63A36B3352352946A534649E7514BF19A96542320F89392F3AEAAD80600FB7B7868320D2A612EFBCBCAF6C3C0579A74338453F2F8F80F5C21F8FAF9EA736EAC5B47DD1C14E9F3ED6D4B280C7035F5BCBAFDF0F0840D0A9BC9B2944026358959EC837EDF2F27428D5EAACDB9672325C82519EB2520DAEAE2F24B452B804E8E6D5158625EF3B3B03A8B5DABD0BD55393C116A318D9591E0E0DFF3F2F262997BF423204D986E9F9B9AA7BBABB3AEAF765959706D6D175119FFBBBCC0312172AA94D1CFCFB5B2B395130F9F1B17A7A4A4EF918D066D31F4F9F7A2C9B44296646016164E2B2C38905BFCB0AEF7CDCB443A3AA9A5A5CD2E22F7C5C3328F57CD150C6D7A766FA98747986AF0342DFCABA74D9066E5272179A18DF7C9C7C5DED0066A3142524F54806FF3DDDBF4B8B51D1414FADFDE827E7E5C957CF1A8A4B8B5B4F8F7F710662C5CA0789EC6AF79B0908F0B07086A2EFEF4F3006E32F4EDF16F7470A3A09F86C09D006F2FAEAAAA76B08BFD8E884A3F13FF5253005E1F76837FA29FA06660608F8A8A388655A4B0B0533C4129511D8F8167F8D2CFFFA6A6CA7D71281E1EF8FBFBFBFCFCFFF7FCEFA5A2BC1D15F7D1D0FFAFAF61512BF9D9D757AE88EDC2C0FEB4AFFFBAB6584F505C3035E52E27F154504A4F4E1E7E492F95633E9A6B4693676181766E9080EFD8D5813B1DEF2D24D8C8D0006B31FFFFFFFFFFFFFFDB004300080606070605080707070909080A0C140D0C0B0B0C1912130F141D1A1F1E1D1A1C1C20242E2720222C231C1C2837292C30313434341F27393D38323C2E333432FFDB0043010909090C0B0C180D0D1832211C213232323232323232323232323232323232323232323232323232323232323232323232323232323232323232323232323232FFC0001108003C002E03012200021101031101FFC4001F0000010501010101010100000000000000000102030405060708090A0BFFC400B5100002010303020403050504040000017D01020300041105122131410613516107227114328191A1082342B1C11552D1F02433627282090A161718191A25262728292A3435363738393A434445464748494A535455565758595A636465666768696A737475767778797A838485868788898A92939495969798999AA2A3A4A5A6A7A8A9AAB2B3B4B5B6B7B8B9BAC2C3C4C5C6C7C8C9CAD2D3D4D5D6D7D8D9DAE1E2E3E4E5E6E7E8E9EAF1F2F3F4F5F6F7F8F9FAFFC4001F0100030101010101010101010000000000000102030405060708090A0BFFC400B51100020102040403040705040400010277000102031104052131061241510761711322328108144291A1B1C109233352F0156272D10A162434E125F11718191A262728292A35363738393A434445464748494A535455565758595A636465666768696A737475767778797A82838485868788898A92939495969798999AA2A3A4A5A6A7A8A9AAB2B3B4B5B6B7B8B9BAC2C3C4C5C6C7C8C9CAD2D3D4D5D6D7D8D9DAE2E3E4E5E6E7E8E9EAF2F3F4F5F6F7F8F9FAFFDA000C03010002110311003F00E8FC13E07D1FC49A2CF7FA81BC33FDB258FF007772C83008C702AB685E1AF0F6AFAD9D3DED67404CD831EA5233A796D8F981007CDD4609A6783BC7D6BE178174FD4206FB25C5C4D279F1F2633BF1CAF71C76E6BBAF0EF87AC7CEB7D52D7587BEB549259AD95028456933B8E40C9EA783D2B9546EA3CABD4F53EB94FDA5784E6F99376D5F9FFC0FEB4397F12F827C39A0FD882A4D8B99190C975A8CA889819E4804F35A13FC3BF0AD9E88DA9DC9BE31C7079AFE4DEBB03C67E5CF5F6AD9F13EA1025DD95C416577AA5C594CC3EC9681096257073B88FBA08271D322B46CB51B4F1069A6CEF2CE4B47B888AC9677180E0742BC1EA063F315A7B3D5E8BC8C9E2BDC82E677EBABEFFE470B65F0EA298DB4F71A3CC96B7046563D56432C2A7A160460FB806B99F8ADE1AB0F085AE9B2E92F748F70EEB279B3B3820018E0D7A8CB69FF0008E5B4371AA78A2E174CB43F246E154B01D15980DCFF004EF5E43F13BC61078C2DED4DADBBC56B6B3B2C6CE7E6932A3923B74E950E2941DD6BF2358E32F8B84233DFB397EA616A0A1C40A4E32F3E3FEFE54FA0F88B56F0ADFACD6372C91B303244798E41EE3D7DFAD55D50E12DCFFD349FFF004654DA75A49A9874895484506469182AA76C9278158B94A0934795F55A58CC6D6A3CDC95149B4EFBEBB3FF0081AFAD8EC354D37585F05DE1F0BDC4571A825E35FDE5E4138175B65F9B663A8C0C6467076F1572317FA2E8BA15CEBEF05BF887498A5BFDE660F2DCA1253CB931CF3BD7279FBA7D2B99D2AD2F74DD6D655B38659E08B0FE7C9B63689BA076070E9E80E7DAA3BDB1BDD4B58BB69A058E79B134CC65F9767F0E5C9FB83B0181ED9AD9E261CB73D2FEC9C6B7C9649DB7BAB7AF7FC0CCD5F5AD57C4D7BF6BD4EE5A561F757A2463D1476ACCBFDA348017A7DA3FF65AD0D4A17B190DBCABB1F0368041054F704704566DE7FC8157FEBE3FF65AC54A524DB3CFA1428E1732A54212E795DB94BE4F45FD5F6F437EEF4D173A3CB79F680AD6D24BFBAD8497064EB9E82A86992DAB45358DE79CB0CCE8E24870591973FC278230C7F435DD78AF486F097882E8BC21B47D499990E06149FBD1E7F873C63E83DEB87BBD26E2CFF7D06644C7CDB393113FC27D4F239F7AD2CF96C70E614D52C77B79ABC24F9B4EA9BFCFA7933B9BCB8B63657565359795E1F4B55FB35D26D660EA32181FE26249F93B734B712DB4D69716135988BC3E2D42DBDD2105C30CB2B83FC4C4B1F93DEBCDCDD48C8549073ED4EFB4CCE55133B89C00A3926B1E499EF3E23C0B93BF338B4B4B6B7D6EFE2B5ED6D7D7427D4EEE2985B5BDBA3AC16B1796864C6E6E4924E3A727A76A7F8834D1A6E8F67B2E56E5676128745200CAF233DF1D2ADDA6817636DEDF468908F9CA4CDB77807907B8FF00EB5763E17F0AC9E35B892EEE95E3D2E08FCB80B03FBC6C8C903D0007F3AD9A76B753C3C9A97FB5FB796908EB7ECBA7CD9EC9A869F69AA5949677B024D04830C8C2BCA75CF87BAA684CD71A196BEB15C916CE7F7918231F2FF787B1FD3AD7AFD15D12827A9DF1A9EEF24D7347B3FD3B3F43E61D552CAE609AE2081A1BC4655920442BB78E5994F4C9F42467BD695825ADB15B6D26CAE6EB52940DA428F31410739EA17A81D01F973CE78F59F1DF85F4BD474B9752784C57D00CA5C40763F5EE7BD6AF857C3DA6E85A4402C6DC2C92C6AF24ADCBB92324935924F9B948595E1E1FED3AB8BD12EB7F5EDF2BFA1C768BF0D6EB50992F7C533EF190C2CA363B78E9BCF7FF003D2BD2E0B786D60482DE248A24185441800549456D18A8973A8E4B952B45745B7F5E6F53FFD9)
INSERT [dbo].[TEAM] ([TeamID], [Name], [Chairman], [StadiumID], [Email], [EstablishedYear], [CEO], [Address], [PhoneNumber], [Fax], [Logo]) VALUES (N'T00002              ', N'Đồng Nai', N'sdfsfgsdf', N'ST0002              ', N'sdfasdf                                           ', CAST(0x4F390B00 AS Date), N'gsfdgsdf', N'dfasdfasdf', N'234234              ', N'423423              ', 0xFFD8FFE000104A46494600010101000000000000FFEE000E41646F626500640000000001FFDB0043000202020202020202020203020202030403020203040504040404040506050505050505060607070807070609090A0A09090C0C0C0C0C0C0C0C0C0C0C0C0C0C0CFFDB004301030303050405090606090D0B090B0D0F0E0E0E0E0F0F0C0C0C0C0C0F0F0C0C0C0C0C0C0F0C0C0C0C0C0C0C0C0C0C0C0C0C0C0C0C0C0C0C0C0C0C0C0C0C0C0C0CFFC000110800FA00E303011100021101031101FFC4001E0000010403010101000000000000000000000607080904050A030201FFC4005E10000103030203040309080D090507050001020304110506000721120831415113612214718191A1C132521509B1427292A2233316D16282C2D253B3242535955718B24363739334D4751783A3445436F0E1C3D36494A4B526372838FFC4001D010001050101010100000000000000000000040506070803020109FFC4005411000102030405070707070908030101000102030011042112050631415161077191A1B1223213814252627292A2C1D182B223331443536373243415F0E1C2D293A325160883B3C34464352617F1E2543674FFDA000C03010002110311003F00BFCD1041A2083441068820D1041A20834410688231E4CB8B0995C89925A891DBE2B7DE5A5B427DD5288035F0902D31EDB6D6E2AEA0127601330D1643D436C862CA71BBCEE863ED3EC9A3B1A34B4CC79247716A2F9AB07DED237311A76FBCB1CF3EA89450E46C72B402D523A41D6537073AEE8861B21EBF3636D29753676EFF0094BC907CAF648423B4A23B2AB96E32A00F8F21D2073305327BB33E4F9E26743C14C75F23C52DB43D655E3CC80A1D30C3647F68FDD1C0E37896D8C58A787952EEF3D723DDAB2C36CFF29A6F7332ABCC4739899D07015A16D55593B90809F89455F56187C8FAE5EA0AFC148857DB762ED2893E5DA6DED5687B073CBF6858A7A08D20771EAA568213C83E79C4CF0FE0EE5FA6EF36B74FAEB3D48B82183CA379773B290B3956E45F6E2CA9252B8F26E2F258E53DA3C90B4B74FDCE932175958648BEB3B002AE811296B04C0B054DE0D30CCAD9A82127DE55BD318B8CEEB6E2E2DE52B14DC0BE5A1B6851B660DC5F4B343DDE5257C847BA35E14BAAA43255F41D8669E831DDEC1F06C613794D30F03AC042FE2133D30FBE3BD6BF50D60A21ECB63E44CA400962EF023BBD9E2E34865D3EFAF4A9AC72A91E74F94088B57F08F2ED4E860B67D45287428A93D10FA63DF68EE591F91195EDC5A6EA2A02DEB5CB7E09A779E47932813EF8D2F6F322C77D00F2197CF10DAEE03D22ADA6AA5A772D217D29B90FA63BF6856D0DC928464160C8B1A7D468B586599AC2478F3B4EA5C3FECF4BDBCC4C2BBC08E988757703B1866D61C69C1CA50AE6225F143E78FF00553D3F648868C2DCDB54271D15F22E85CB72927C099686935F70E97378B52AF42C796CEB8875770DF30D2137E916A035A24E7D42A30F6DAAFF0062BF322458EF502F2C280507E0C96A42083D8799A52850E9721C4AED4907922255344FD31BAF36A41D8A053D6236DAF70960D1041A2083441068820D1041A2083441068820D1041A208344109DBEE5F89E30DF9D92E4F69C7DAFE32E53588A0F7F02EAD3AE6E3C86FBCA0394CA1751E175758654ED2DC3EAA4ABA81862B23EAFBA7AC6F992F6E146BBBE012962D0C3F3B9A9DC1C65B2D0AFA563481CC6295BF3E7C96C4CA8385F98AB3453140DAB2947428DEE8862322FB4576E60A9C6F18C22FD7F28F98F4C723DBDA51F410642E9EEA7481CCC6D0EEA49E8F9E26541C0AC49C00D45436DEE4852CFF4074C30D90FDA27B9B38B88C6B0EC7EC0D289F2DC95ED13DE4A7BBD6F318413FB8F7B4DEE66378F7520739F9A26743C0BC2DB91A87DD70EEBA81D4A3D30C3645D5B75099225D44BDC79D6D8EE0292D5A9A62DFCA0F83919B439EFF369BDCC62A9C32BE7C96755B134A2E18E5EA317934A954B5ACA97F5C94F4447EC8338B95E9F32328CBA5DE24FDF3D729CE4A73E1756B5694D3E098A57DADB0EAF7DD54B9CD9D30E0EE3B97B041714FD3B12F3429093EEA6DE88463D975919A84BEE4823B9A6CD3E15506A4949C33C6DFEF3696C7ACA1D49BC62255FC6BCB34B308756E9F51B54B9D77046A1ECE5A1511ADCB51EE53AB007C0907EEEA5149C2070CBF115206E4249E9511D5108AFFF0050CC8045251289D45C5803DD4057D68D3BF99DD9CA8692C451E294731F8544FDCD49E8F8558435F785C70EF55D1CC903AE21188F1E3303E086432C8F55178F3B8543E18D6AAE97FB81E54CA96FD78F232081F036069F5197B01C2C5E2CB28DEB913CEE131157337E6BC70DC4D454BB3D4DDE0399A023E918F5EA4105C8AA6CA8F05C858457F18D75C6A73DE0544241F49DCD82AFAA25D30A68B8579A713378D22C7ACEA823EB9BDD11F4BC76F71947CB8E56A49E263B89511EF020FC5AE6C67EC06B45D53C91B9C491D60A7A63B55F09F35E186FA29947D665615E5EC90AE88FC172C8EDC7957226303E8BC1447E583AEC701CBB8A89A5B617BD0403F01109939AB37E046EADEAA6F7381447F7A1423398CCEEEDD0381892076952394FC2923EE699EAF857843B6B7E236772A639960F5C48B0FE3BE6062C77C1787AC8BA79DB291D11B7673A470126DCA07BD4D380FC4A03EEEA3357C1F56962A8722D3F2A4FC9136A0FF50E8901554467ACB6B07E1581F5A36ECE6165769CEE3B1CF7871B247C29AEA3555C2FC699EE250E0F5560742AEC4D2878E396EA25E22DD68FAED9239D0571BFB7E47159790FDB2F698D252416DD65F2CB80F7508292351AA9CB38B51DAE533A996B092473A67132A4CE797B13175BAC6173D454907DD5C8F443E38E7517BE38C01F52EE8DFBC90414B32E519ED0A78225F9C903DC1A6F4E2352C995F50DC7E63055E46C0711179748D1DE8013D2DCA1F5C77AFCDF3B47222EE8B0E54D83F9C5CD8263BA478054371848FC43A5CDE60A94E991F27CD2887577053027ED6BC468FAAABC3E30A3D30F9E3DF69043521B6F2BDB079A58FD2CBB4DC12E03F82CBED229FED0E973799479E8E6310FAEE02AC1269AAC1DCB44BE2493F561F4C7FAEED80BC8685C2E777C61D700E645CADCE2D2951ED1CD0CC91C3C74BDBC7A955A491CA3E69C43AB78359829E77108747AAB03A17721F5C7F7CF6732928458F7331C98F3A406E2AA7B2CBEA2AEC01979485D7F73A5EDD7D3B9DD5A79E21B5B93B19A2B5EA47401AEE123DE4CC74C3A2D3AD3E84BACBA879A5F14B8850524FB8470D2B06711D524A4C88918F4D11E60D1041A208344115B1D62752BBA7B53B836EC3704BAC4B3DBE4D823DC244A54366448F39F7E43668A7C2D2004B49A0E5F1D46719C4DEA77421B20094F472C5FBC2CC818563787AAAEB50A5A83A5205E294C82527CD91D2A3AE2BC729EA0778F294BBFAC9BA37D7633DFA58A89CA87195EEB11CB4DFE4E9912FD6D61BA8BEB3B1209E84C5D0CE57CBB83242FC061A979CBBB3F79C33E986466E516BF356F4BBB094FB84971CE653CB51F12456BEF9D3CD2648C6EAED4D32C6F5C91F5883086BB8999670E175558D996A6E6E7FBB0474C68DFCD6D8DD430C48907B8D0207C66BF16A4D49C26C4DCB5E71B6FCA567A04BA62158871F70464914ECBCEEF925B1F112AF86350F673295511E034D8EE538A52CFC03946A4F49C21A54C8BF50B51F54048E9BC62115FFEA12BD7314B48DA06A2B5296799370469DECAAF8F5409619AFDEB484A4FC3427528A5E1CE094F6F817F7AD4A5744C0E8883D7F18B33D5CD22A4373D4DA129E991574C62F917DB91A96E6CBAF7AB9CA7E13C34E26AF03C244AF30D4B65C07A3B50D02833463E665154FCF59F10A79D5D9946746C4AF321C0DF94D32B51A042DC055F8A8E63A65ACE2760ACF75C538762527AD57444930FE09665A8B56D2194ED7169EA45F30F3E2BD2DEF165DE52ECD81E477061E212894CDADF6A3D55D95912434D81E9274C2FF1496BFDD68D6ADEB321F083F5A1DD3C26C328BFEE58C308234A5B92D5D2A9FC10EA46E8D6F3685ABF5FB31C2B6FD2D025E464392C4F3D253F7BECB00C870ABD1A8F55F1071B72C0A6581E451E92AEA87EC3F256514005962BAB8FAA85211CF2684BCB1B78BB53D31E3284B97FDE8939349450AA061D8DBEE13E29132E8A6DBAF81E5A6A2F5998EB2A67F88AE7540EA44D23A2E8E889CE1D97574E47E0301A7665A1750E256AE5927C45FC51B74E61D3263A9522C1B3593670F23F452F2DC804268FA551AD4803DC1CDEFE9854FD2CE7714B3B56AF9BE78952308CCCF00175ACD3A7D1619BDCCA74FC91B4B4F52775B65C6CF0F03DADDBCDBE6572D86172E0591132729B71D4A4854A9AA7544D0F6D35F5188A92406D084F2099E7338E153905A79B5AEB6B2AAA0DD264A74A11300F98D848E98BADC8F6A36CB2E491936DFE3F7B52AA3CE976E8EE3A2BDB470A39C7BC7537728D973BC807C82324D0665C5283F77A9751C8B501CD39430B90F43BD3BDF52BF66C5A6E36EAC101DB4DC64B6013DE1B7D6F37F934D205E054A4CD20A4EE2626947C60CC4C092DE4BA9D8E2127A824F4C47BCA7ECCBC2E7A5E731BCFE644748FCCB177B7C7969F70BB1CC650F769A554E9C468FF0076AC753B892A1CC4CBA216AF89386D7FFDCB08A6727A5481E1ABC8644FC511CB29FB32B7420254E63F72B06449E6A21B8F31F84F53C4A2534A6FDEF334F2C66DCC54DA56DBA3D648079D3763813C3FC42C531534AADA955F48F212BFAB11D329E8A77EF182B3276F6F8F368A92F4161BB9B6027B4954171D23DF4E9E18E265637FBCD14F7B6AF9083D71CCF0EF2DD75B418CA127D17D173A7B1D511FEF5B7195D81E546BB5B1DB7BE9ED8F35A76239F8921083A7AA5E29612B327438D1F5933FAA4F5424A9E08E38537A916C54A76B6E0FE9003A613C6D97D8279D11A5340710E32491F0B648D3E3798701C4C48BCCAE7A972079960188DBD94335606ABC29EA5A95B36EF11CED1223D5BC8AFB10F2AA6B951F78FA42BFCB15D717F23E055A2F0A745BADB253F50CBA21452F13F346186E1AB72CF35D017FEF05EE98DAB19B5C90007E347903BD402904FC048F8B51CABE12E1AE4CB4EB8DF942C74807A626341C7EC699005432CBBBE4A6CFC24A7E18DB339CC45504882F367BCB6A4AC7C7CBA8D557086A93F7150857B40A4F45E1135A1FF50B42B0054D1B883B50A4AC732AE18DBB39558DEA5659649EE750A4FC6011A8D5570E31C63432163D4524F4120F444D6878C9962AA53A82D9FD22149E90149E985CE399FDFAC2EB6FE2999CFB33C8356D76CB83B1940FA3CA5A4EA3AFE178950DAE34EB72F554073E8893A311CBF8D8BA1DA67E7A896D6798DBD113EFA42EA0777B29DE3C5F08CAB3A9F90637738F70F3E15C034FB8A5B10DD7DB3ED0B6CBDC1481F7FA5983E20FB950942D44A4CF4F26DD315A71432460F45833D594D4E96DD49448A66048A824F641BBA0EC8B7CD4C232F41A2083441149FD7FBC1DDF86100D4C7C62DCDABDD2EC95FDC56A11984FED3F447CB1ADF824896024ED797D491F2455ADD92B917A9CD27D75B92D686D24F795500E3D9AD2F96D68A5C169D6AB129652A27704CC9B34C661CE6D395B996ADA4F694AA95A5209D6577522DD16F921456DDBFC82E8FA62C567CF94AEC89190E497BF1194A8EA2955C57C2D064CA1D70EE0123E233E889CD2F0231B29BF56EB0C27D65954BDD177E287CEC3D21EF0DE594CB383DF214134ADC2ECD35658A01E35F3AE4B6453D234C751C4FC41C1FB3D225236AD44FF005074C38B5C31CB148A02B316F155E83090A3C9D8F195D0215ACF4CB8BD8C36BCDB7736FB1A72854E404DD5EBFCC481C38B16869F6EBE8E7D466AF3CE36F092EA9B686C4013E70147E289861F92F2DB4674B8455D511E73B36D07FB55363E08DEB38C74BB8D2B964E6399E74E35CB56F1DB1C3B2C670FDF00FDC5E75DA7A7CAAEA2F5789AAA4CEA2A5E74F2903E23F244DE830BC558481458751520DAA3E22C791A4247C663313B97B33642938BF4F90EE6F364F973F32BF4EBA93E055123088C7BDC74DE2A29D1DC647D224F409087756038DD4FEF389A923630D21BE65AEFABAA3D3FC4E6E8416971B106B18DB98CA479696F15C7E0417129FDABEB6DE781F4F3D75F7F89BC2C45D4FB2903A74C73FF00D7B85B86F5517AA0FE99D5AC7BA0A53D10D9645B99B8D97A94ACA33DC82FC15DAD4CB8C871AE1DC1AE7081EF27499CA975CEFA89E5262434197F0DA01FB353348F6509079E53E9843842012A09014AE2A55389F74EB843C4CC7D6BEC7C834411B1B37F5D597FE6313F9746BD23BC394470AAFB973D957518E9F7568C7E78C1A2083441068820D10460CFB65B6EAC2A35D2DF1AE519628A8F29A43C823C0A5608D795212A122271D99A875855E6D452768241E8866725E99B6172C53CE5DF6BAC6890FF00CF976F60DBDEAF8F3C32C9AE90BB8552BBDE6C792CEA89661FC42CC14120D563921A946F8E65DE860F26FB3CF642F4970D9E75FF001A756AAA52894DCD640F0E496D38AFCBD27460C964CD8716D9F554444A5AE31626E0BB5AC53D427D76C4FA2CE888E994FD97AF2895E299FDB2656A7CABA407A12ABDC3CC8AEBC0FE269D98C571EA5FBAAC2A1B1602BAEF4785669CA35FFBEE0E1B3E930BBBD02E088E794FD9D3BE9652EAEDD628D7F61B15F3AD1728EED7D01A97ECCE1F7869E18CFB8EB1F7ACB4E8DA2683D7F2472380643AFF00B9ACA8A551D4E27C44F3807EB4471CAFA6DDDCC343CBBFE157CB4B11C12EC9976D92961207127DA1B4B8D529DFCD4D3BB1C53693FBD523A8DE992874DD8E7FFA85AAC3FE1B8AD33D3D0951F0D7CD35F5431F222B9066AA33DCBE74771295949A8AF03C0EAC5A2C45BC468854333B8E20913B0CAD1688ABF13C1DEC1F12552544BC569C0152331398361B36C587F47920C7EA3F6D55FC6BF3DA3FF696E929F97593706B2AD1E5EA31B5B8A68BF96EAB9107E34C5FB6AC08C55068820D10451975D120BFD44640D7FE52D76A647BF192E7EFF503C7CFED4AE41D51B13836DDDCBCD1DAB59F888F922B6783992FA1572FFE2EB487DD65BE4A5FF87198E7F88CE7ED57FF00C68B13CDB7133BDBDDB4D85B0E11955C310857DC29CBADED3685886F4A7DEBA4C4A5C7643494BCA210803E7D29ACD6ED438CB2D250A299A666564ED3E58D4B85607418AE29893F58CA5D522A2E26F8BE1290DA0C824CD3A4CF44463BBDEAF5903EA937FBCCFBEC8512A53F7194F4B5927B4F33CA59D372D6A599A893CB6C5814B48C52A6EB2DA503625213F5408D60012289000F01AF30A2738FDD1041A2083441068820D1041A20834411B1B37F5D597FE6313F9746BD23BC394470AAFB973D957518E9F7568C7E78C1A20834410DCE35B998F6439A66DB765E16ECCF077985CEB1BEA01D916F98D21E8B708E0D3CC656145B514FCC712A42BBAAB1EA25B6D21ED285EBD846949DFAF788F21409235C355B91D56ED86CF6E7276F373A69C4E24CC758BED9F2B58725B121C724BD1DD88A622B4EBAD2901B0B0A58E558240E29E2BA8F02A8ACA7F198178855D29D12B019CCC81F923C29D4A4C8C30596FDA61B1761CBAC764C7E1DD734C6A5A88C8B3386CBB19A80090125A8B25A43B27C55CBCB4EEE63C34EB4F932B1C694A590956A49B67E50642399AA4830E55D3AF3E9D422C91710CC139B64590DDADB69B6E3D163CA86B0AB84A6E3A9E7DE96C36DB48652B2B5731A9A500A9D224656AEED171175290493307409D801999C7B3508D4624CEE26E162BB59875EF39CCEE68B5D86C4C29E90EAA85C757FE6D86115AB8EBAAA25081C54A34D3352523954EA5A6C4D47F94CEE1AE3A29412266143649F26E965B45CE6405DAA5DC6147952AD6EA82D719C79B4AD6CA9438128279491E1AE2EA4216520CC026DDBBE3E88DA6BC47D845EE447F6BDBBCF62F6FB4E39746A9F8711D4FCBAE15426CAC7AA7AA1DB005DCC46995B1D41E6508E4EEFBC2F12CFED9B3F9093AB6F229BD80D37B047C4A874E2A0B99AEBBF5A0FC29313BFA4E73CBEA176AD7F4AE4B4FE3C5793F2EB35E182ED6247AC7E58D5FC46EDE5AAA3FA349E9498E82756046268344106882287FAD777CDEA47381FC533696FE0B7463F2EA018F1FDA97C83A846CEE10A659729B795FF00BC54575C4F5B2467D371AFFDE9D695C4BB19717BA97FE188CAF837DA6716B7D6FF00C53137F7BDCFE87D808A3FF0BB576934F4BD367B9F1D75992B4F65A1FA31D6635E6514FDB624ADB58E7421B10C3B895B48438EA14D36E8E669C5A4A52A15A5524D01151DDA43132490A3216911F20822A0823C4688FB28FDD104675AEDB3AF573B759ED8C7B55CAED299856F8C1494F98FBEB0DB68E65109155280A934D7D4A4A8803498E351508A7694EB8648402A27604899366E8D96558A647845FEE18BE59679162BF5AD7C932DD253450AFCD5A142A95A1438A569252A1C41D7A75A5B4A295891109F0DC4A9B12A74D4532C2DB56850EA3AC11AC1911AE13FAF10BA0D1041A20834411B1B37F5D597FE6313F9746BD23BC394470AAFB973D957518E9F7568C7E78C1A2083441155FF0068A6D76402E5826FAE1D3AE161BA6391DCB1DE723B438E47930DB5B85D88EADD6148586CA96E3655CC284A47DF6BAB5999FC16DF0C3AC2FBE83A8EA5032323A8CC106C8B0F24657C3F3425CA075D2CD5037D958B6F09496DA93317B405264428768DB688ADADC2D99CA53856DF6F164DB86BCB67EECAEEA5C5CE4BEFCD695687931D5E74A79E70BBCD5F57B39470D484F14A969D86D48A5212A9C805244A47D995B0E187705EA6BB13ABA0FC5A42A9BC39A8A1442FC5178485E9896F8F0DC6E9C2E3B752B6EA34BCB62DCFFEA1E356DC92338D445B422B77259425958538AE728A54A852BE1AE953C56659B9FB328DE48577C593F2471C03838FE2C9AA526A929FC3BAB68CD04DE2D89DE1DA120764282FBD28DCEC7BF913619ECD623F3A65CE05B1391882B4B40CF61B7D2E7B3978A88487294E7E3E3AEAE714594557E1FF000EAD204EF8D7BA508A8F852F54E5F56342A521210B5F8770CFB0A2995E9CAD96C879F62768B38CC3A99C6B00CDF2ABCEE762DB3D914C76E11AE3225C9B6C64D9D6E21B74B6FBCEA1A0B790809477D79788AE999FE209AA7154D474C1A2490B5CC13744E72BA05A769366C9C2EC438654F84E08314ACABBCA71B4169A09BB35B9236924950424926E81A34EA8BF5D34C5630688213F9637E762D92B5FC6DAA623F19858D72784DB572185B862AED5B4762D3D62392AC8C72DDE5FE0B47FEED3AB57876ABD815372287C6A891718917334D6EF293CEDA626CF4B92033BF1B46E93C177A8C807FD6A0A07F95ACE74C2E6232D8E2874911AA7397DB6557CEDA707E1498E87353C8C4F068820D104503757D21523A8FDCB5935F2E5C2693EE3702327E4D57B8D19D539FCB508DB1C2B45CCBB47C8A3CEE28C404B67AF914523EFA7157E593AD33983ECF2F3C3653CBE1023266513E366FA63B6AE7F19316DB765F4AADE37B3F1B7A58CB4E62D6DCE3F476CC5DF634C271B75C6051A503CF552B9B8786B3AA8D15C6C3D7AF5C4E8D128D034C3359A9AE561258F00D53BDF95EBE080AD23458256C3ED0B7D3A708DB5F1B6D36EF7262D805BA3A98C79FCBEDB22437192545C0D3DED76F90DBADF312141442A9D8B06874B45752067C26D72968BC272E706CFE53886BB93B322F143885752972F19AC32B4A4AAC94C5C712A4AB611313D2930C1655200C6AEF964FDB4D84DE8B063EDB2E64973C19E7ED77288C38B0DA5F7D88EB69C424A881CC949A1F456881D3D82B2869C03494CC11BEC944D70D47ED28A6455E2546E3848426A025C6D4A027752A50524996A27A6188772AE962F4E8FACB6BB35C116B4804E3D90C7B936951ED506AE6C85103C39B484BB46AD285279140FD611324E1B9AA9C7D9D5D3BFFAC654D9E768CBA232D1B79D3D5E4F9F8FEF664F8B14D14CB79162329F52543882245B16A4820F7F2EBEFE1E955DD71439527AD31C8E3998A9FB2FD032EEDF0AA129F85D00F4C3F3BBDBBFB31B8AAC1B0ADC0C9A3E6A94581A8973DD8B0DBE546B8D86F2C2B90CAF265B4DAE4C4949A2DE63894A829493529A2EABAC61FBA87157ACEF0066956DB7483AC7344332BE57C6B091515742D167ED4A934EE2D2A6DE68DB72F2090871B3621CB2F0903A0CE1D6E4ED6E49B633A1A6EAB8D77C72F6D99189E6D6C5F9D6ABB46ED0E477C540501F3DB51E64FA450968A9A55B044ED07411A0F245A780662A6C65B5787343A83271A5D8E34AD8A4ECD8A161E5B236D8A6C0EF466D058BA635B6F799B6A949E78B757DB4428CEA0F629B765AD94AC1EE29246BDB54150E89A5048DBA3AE136259D705C3965BA8AA6C2C6948256A1CA10144796156CF4BBBA70849959E22CDB4F638AB4B6E647975CE3C58AEAD609088DE429F5BEAA0AD103DFD75185BC2D72481B54643C9A670DABE22614E49345E255387CC650A5280DAABD74207298D2E59B1F36C18BDD331C7370310DCAB1581C8E8C91CC666B8F48B7265B9E530EC861E69B506D6BF542813C75E1EA128415A569501A6E9D13DB0AF0CCDE8AAAA452BF4CFD338E0373C5480972E89A82549245E02D96C8686CDFD7565FF98C4FE5D1A488EF0E51128AAFB973D957518E9F7568C7E78C1A20885BBD5D425E3A6BDD7B55C770204CBB6C3EE3436A3C7BFC364BCFE3D7E8814871B5213C56C496421613F38292E291CDEB27523C37094E274C434407D0741F3D27E506CE69C705B9E1AADD062106FEFDA537EB8647F53EC5DBEDCBC22347718B9DD725B6990ABAB8E52A5B8AB7105A65201002C732EA490914D48F0DC94D968FE2E6547503601BF69E88E7F8E5B6B0A6CC88D07419EED9118A775B5BA374B75BACD74C1F6C2E567B417556AB4C8C4E3AE3C52FA829EF21B2EF2B7E61155728153DBA56BC8584AD2125064345A2CE88726335E2CC3AA75BA9752B5CAF282D414ABBDDBC67354B54F44785EBACDDC1C91CB53D906DD6D85E5DB0C36ADF645CBC6BCC31224724B2C31595EA2104FAA91C06BC2F87D84AE57904C8485BA06CD11DA9339E33461618AA71016A2A549445E52B4A95B49D6637EEF5E5BACFE449CC24E03B612B2E429B5A729771A2AB805B29086D624195CE1494800106A0701AF472161657E25D55EDB313EA84A8CCD89229BF0A9A870336FD9852AE5B69176729136910A78BF693F50908BE62D9F058CA92E1764A99B3BED9716A352B5F2CC1CC49ED275D4649C3C68BE3CA3E6840E620F392BCA9C8484E6643608967B5FF0069FE12AC0663FBC5659B0B70AD4161A898FC452E0DD41A9694CA9C7488CAEC4AC3ABA0F9C926BCA192B7253BE3014E416CFA46D4FCFBA51F515425DAD3139FA76BDEE165DB6F1B3CDCC88AB36419ECE937C838B10A48B45ADE296EDD0A8B4A55CC186D2E2C9152B5A89A7608C62ED30CBFE13266940027E92BCE3CF60DC21436491330F35D59F68B65CA3F6F9F15E6E9F84823E5D352C4D246E8534CBB8EA55B083D31C9065A8F2EF939BFA09427E0401F26ACDE1A9FF0363715FD7312FE340FFC9EA8ED4B67FBB4C4BAE9B9CE4DE8D995F71C92CE3F19E6C7CBACF6B1771450FD32BEB98D458EF6F28B87FE8C7FBA11D1A6A7318A20D1041A208E7CBAAA77CCEA137517DBCB7609FC48ED27E4D57B8AF6AAD637FCD1B77873D8CB9487F464F493105AC679AFB055FE9CABE251D699CE7D8C06A47E8A5D42323F0DFED335D11DAFCFA1462707507CA8C8B6EE327B226D861AD9F7556D4B87FCBD662AFEF207A88EA8D7B91EDA6AA56DACA83FDE4BE486AB10B459AFD9359AD190E4AC61F639D2022E992C9696FB711900A94BF2DB054A269CA91D9CC45683499A4256B0146E8DBB22498A553D4D4AE3AC345E7123B280402A3B26746D3BB45B133720DF8E9DB0DC2FFE97ED96DA5D333C792E25DBE4FBB4C5DA62DF24B74E57EE0181ED5292923992DAFCB6C1A7A94034F0E5752B6DF84D20A86B9995E3BE569E4B06E8AA28726663C42B7F88E2156865D94901090EA9949F35BBDF66D9D4542F28FA5698680F5419A5B2A8C170DC0F6DE3720421163C7622DEE1D8A53F30485A95E93A49FC4DC4F71284F2247599C4A7FF005E513D6D63F53507F48F2A5EEA2E80235CE7555D4438AE63BAD766E9D886DA86DA47A02531C0D79FE2B55F9C3D1F34764F0DF2E012FC1A3CA547FA51B167A9CCC2F294C1DD6C6B1ADE1B32FD5798BEDB588F3D29245551EE3090D3AD2E9C028856BD0C4D6AB1D0958DE2DE716C705F0F68E9FB786BAED239A8B6B5291F49A59525437590ECE399145C6B03C9337D946D9CE36B6D0F333B3AD8ECE9B44D7B18B92D44C3BA44708E579A4BA9F9E8F5881470135521536E0436A5B3DA40B54855B74EA50DA27FCF11AAFA05D657B5478B92CD62C14B5554E4A054363BED2C694A8A4E836036A762937B5174C2F772EF98E6DD4BEEB2A6BF640C2ECD89DDEE726DF1650754A2EB8D26224AB9191C10C4648249E240EDE74AA6EA14A5D4B9396804913E6D9B042FCCB4F5B8132C5265FA3905CEF3884256A4C858095D9356B71C2401A26618BCA6059B3ADD3918D6CFDBE7FEAC5EEF4883B7F639CFBCEA93E7F235CFF9F52D4DA56B056798D528F9DD9A42EA52EBD7590644C920C4C70E79EC330A1518A293E2A1B2A796900689997640048165961568D30BCDCBCA719C06C77AD8EDB109970BDA5A6B74770D44191904F82AA98D1E9C1A831DE079123E7A8731F1577A9750CA4B0D68F395E911A87AA0F3C3365FC3AAB147DBC6310B15225867CD610B1DE57A4F2D3A4F9A0CB7060ACDFD7565FF0098C4FE5D1A428EF0E51135AAFB973D957518E9F7568C7E78C41B9FD6062BB2196645B5DD40B575C6EEB6894F48C2B2E660BF3615FAC4F38A5C3792A8E97169799410CBC08A73A49E6F5A824C9CBEE573697E924A047693300A55AC5BA8E91BA3817820C9515D3D4075E19167996E5569C1E42E5ED14F4311A1582FB6AB6C84480D3690EBCB665C77D402DC05490A5730E06893C075190B13BE1D6AB034AD8133BBF4A6226B82E66CBD4D4A96ABB0C2FB8099AFC5522F026C1705960B37C20F6062ED46F566F26D1BB96D46338DDAAD4FC88B2317B4478F25C96A71A4A12B4DB603AA5A7979BE720D3C4578B0E606717C19D693538838B4B8152B9792414DDD3A6739C4F30AABC2314A07DDC1F08652EB6B6C283EA0E24A56176A4B8A404905235DB3D164397BD9B65B638EECAED95CF11C6E1032B32CBADC321761A5AB84E810E6BADC3F6B5A9B69C252DA0705A453E88ECD452B7336268A76CA2A9DEF2C4EF19900D93898E51CAF8655E3756DD551B16314EAB81292DA16B402BB82D16A89B4133DA621A4C5E236F784698882CC83FE63902963DD09048D2BC33FCD98937E2D32DF523D2BF741E42A227E489063632160AF78158D52A1CD69F0EF287B410955DFA52874B6771EC4EFDBA1B650A659ADD77B35D328B4C59F11C690EB0FB0ECB6D0E36E2482085249041D20FE3B8ED255A59A87DE4A8284D2A528593EA3CC63A62D96B2C55E055357434D4CA4F82E14AD0949928249B08D0A07CA2250EEB6CE74FD8FD837AB2C871A5DBF71314CBEEAD6358847B7A9562445897242196D491056C047904FAAB780AF0A77170563B8838E280AC792B2E5D02F1BA26A006AD40E89C40309C298952A178752AE94D2A56E2C8487D4AF094B548DF0A9950EF041234EF887166EA066D82E712F766C2310817582B0EC19CDE3162E765C1C42D158740A07B0F76AC77B286605829562731EC9F9E2009CD592C807F8338391F57CF16BFB4BF68F6CCBFB6F6E7B75F20B9DAB3FB443E5BFC736A71C17090827F39115090A668B14E0BF2E87B4538E90FF0092F116AEA269736A8493CE0DA3C93882E255F46FD4B8E53365A689252826F14A76156BE58987B13946639EE0ABCF733B43F8E2B37B8C9BAE2F8B4A4F2C9B758D610CDBDA902828EBAD35E7AC771729DDA69C51869877C26CDEBA0024682AF3A5B81B0724256D448998E6337159F67CC6FCC7F1525D47E22D49F93536E19ABFC15B1B16E0F88C4E78CA3FF21715E932C9E76C4494E9F9F0CEEC6CD3E4D02726B0D4FBB2991F2EA82AC17317706C7D5F5CC6A1ABFB5C9E65AE8BFE0C748FA9B4628834410688239D9EA464FB4EFAEEEBB5AF2649706ABFEA5C2DFEF755ED676AB55EDFCB1B8F25A7C3CB94BFA8079D33885D8FF1BCC13FB759FC856B4BE7C37702AAF607D64C644E150BD9A687F584FC0A89D1D475B2E7072EC4664CB7C98B6EB860588A2CF3DE6968624862CD190E792E11CABE45821401E07B7599B11490B4922C284CBDD11ADF21D434ED1BE84281526A6A2F0044D3375445E1A44C5A27A623FE9044DA3F744106882247D83A58DD0CC305B2EE0616F63F95DA6EE83E74089756599909F0A2931A4225792D876B4F50384F11C34E2DE16F38D8711220EFB46E33D7102ADE23E17415EE50D5875A5A341520942D3E924A2F1BBBCA6564269FE9BF7F23CC6A039B4792F9EF3896D0E221A9D60151E5056FB456DA522BC495500D7238754832F0D5CD0E08CFB97D482B15AD4809F7A47C893224EE943919EDBEECFCFB474AFB316F7F216EC1279F38996E1EBE4191A00F6A9121C3CA94C5847F34DF39084F295135E53A52FA5448A5644E5A65E72B59E44E810C382BED25B5E64C5941B2E0FB20AD0C307B8948B66E3BDE5485E3390D71166E56E9D68B8CFB4DD22B906E76B92EC4B8427872B8CBEC2CB6E36A1DC52A0469AD4929241D222C661F6DF6D2EB64290A01408D0411307CA2258F4CF8FD992C6599C62B7B7320DECC6AC772FD46DAE0C222BAB9121A31FEB08D29D74A64AA3B4E2D61A6D21751EE1D3AE1ADA64A5A0CDC00DD4F44C1D72D9A62B4E20573C54CD1D4B61BA071C478AFCCA804A4DEF0D4803B016A0137D44A65E58888B6DD69C71A90971121A5A91210E82970389242C2C2A8428106A0F1AE9A62CF0428029948E896896A96ED919F66FEBAB2FF00CC627F2E8D7A47787288E355F72E7B2AEA31D3EEAD18FCF184267DB63B7DBA5694D8F70F0FB665D6C694571D8B8B09714CACF02B65CE0B6D47C50A074AA96B5FA555E65652777F2B63CA9215A6298FAD7D83DB1DB4DC0DB3C5B6AF6F9B812B3289ECD16C71644875536E3226263C74854979CE5AF353B401A528C5F1CC46B534ECD516D21056B510921294E93294C9D40459D94E9F2F516075388627481F5A5E4B6DA66A495294926ECC1000B0A8920D82C878BA3DD93CD3637A8D4D8B38C762582E57CC26E13621832D131879A449889572BA9A1AA1479540A47A2A083A61ADA9AC73104A1FA92FA021450A22E9132262EEA360D6443CE33558356E535D461B482957F886D2EA012A990959410A3DE122656020CC18D8EFCE1F2B34C6B6BB0B8B20439391EF8663676E61154B3ED9769492E107B4A524A80EFD47EA1A4BBE1215DD2F281E4BD6C4AF2AE28AC3DCAEAA409A9BC369D63952D265D313BF1FE99F6271DC3860D1F6C6C170B2B8CF957176E3058972E6AC8A2DF9325D41756EA8F12AE6E07E6D05353C38AD4DF0A4ACA6ED8909324A40D012058008CE0EA94F2D4E386F2D44951369528DA493B498A7BCBF686DFD3E75BB826138D38E1C3720BEE3F7EC721BCE29C5C56244E092C296AAA95E53ACAD29249251CB524D74E99982316C1DAAD700F1997529BDB4150047219856E22CD3137E1DE2EFD1BF5942927C1A8A67A69D41486D4A4A86FB0A4ED077089FFBACC255D32754B1D54E44E637D5B809EE5DCE33C7E256ABB79C5374AF2D26442C91B88502225B80A12F664C290B134AE9DB491B41696823E48A8BDC0D81CBF6D310C3F3CCB70645B70ECE791AB1DE112C3AE36F3ED29E8E892C255CCD79ADA4A93527876D0F0D4C29ABB30545039508AF9BA845F2DDC4F705A64B948A80B65296A9C2E0FE47FE3A9C2FF867D9973C2F16FAE5E24EE8EC5E9DCBDD9BD7A7AEECA2EF369FA4FE9CB1EB5E1F98DA769ACDFAC0E5B20CE45C66F9F3CA1F7184385D4225BAF210AE635052914EED7B398ABEA59016EA88204E521398DC0452D8951354D58EB684C8256A03700A2225969AE12C726FBB8D793B879537F42E3313F8B29E4FC9AB03860A9E1246C79CEB0627BC654FF8CB4AF4A9583F091F243C7B3523D9F36DAB944FFBBDF6C8E93F812993F26A8DC6C5CC69FDCFABEBC69AC3478B93DB1B6880FEEA51D32EA6518A20D1041A208E6E77C9F2F6EDEEE4826B5CA6FAAAFB931EFD8D57E537EBC0DAE81F146E7C10F8396D93E8D203CCD4E228639C6ED14F821D57C0D2B5A4388AABB81D4FD11F1A6324707117F34D16E2A3CCDAA2EE2EDBED608B7695B03B871AC0DD8E1D8B1A387DEF2280275A5B7DDB1C353B0AE881471A6D6B592892D2829A51F5AA91AA0D75E907F0EE4A524C89131DD162B581BC688B5A9B26D42D918DD0977C42E3DE225A55C7480F2E4B68F754A000BCD2810B02C9186C65DBB6276AF219973DD0D8AC8B1462E16F7D96AD519E6726C3AEC95A02D97E05C5D087D825C0952548582949E550009D265269A9D7375A50B347790AE43A44485A7F1EC6E9D2DE1D88B4E94A81BC41A7AA6A464A4B8D89A17D998208913689CA18719A74B97D71855E76772AC35D581E7FEAB64A898D159EDE46AE4D1207800AD21F1A8D5DE6D49F6553FAC2266709CD34C0F855CCBC3578CC941F2968FC91B090CF48F09F28996CDE48EE84A566DCF9B2B2B095A4290495242A8A49041A711C75E88A206D0E72766382159BDC4CD0BA023D21E291658741F961F0D98BAE3F1EDB962F66F652E8F621788CA879766BB9F928631711C769971D965319D520F67273389EC04574B68D49015E0B66E9B095ABB1E5B25F2C4433653542DD6462B5E80FA0DE6DAA466F545EF514557D20FAD249DF18DB4979D9AC4377306B5C4DC6CB370B20BAE470D888C59254AB6E1D6E764385286D226BCEC99ADB6B504A6BEAAB854EBE51AA9DB7D02FA946F0D13081CF6AA3A666A5C6ABF08A87154ACD3B6969449712972A9C09169EC2528694A00932B46A86B373F3187B42C5F76A36C2F45DCA2E135E91BC3BA10545B913671794EFD5501E1EBB71A328D1C2082E380D7856A96A5D14C0B4D1ED1EFA86B3E88DC3A4C48F2F614BC794DE2588B7265290299855A942252F19C4E8538B1DD9D894CA5AA498DFD4B39537B7DBD509B4211BA966E5CA52DA5294B79259B961DCAA13403CEA36F0E1C7989D73AFFB4B8F0F3C5BED26C573E9870C944D11A9C2167F7573ECE7AE9DDEDB5EEF691E410C15BEE13ED33E15D2D535FB6DCEDCF224DBEE315C534FB0F366A871B5A4829503DE34812A293316111357D86DF6D4DB890A42848A489820E9046B1126F24661750B885D370ACF09A87BD58544F69DCEB1446D2DB790DB1B0126F915A4D0090CF0125091C47AE3B8172700AC41700FB44F787A43D21BC79DCF15ED0297956B1142EA89A07952616A332C387F20B27CC57E49474776234D948379B2106A0DC221047FAF469B91DE1CA22C0ABFB973D957518E9FB568C7E78C1A208AB8EB2C7FFDABE90CF86436AFFF00576F4BF013FB73E3FE95CFAC9899113CA8B3FF005ADFFBA5C3CBBF56ACBAEBD446D746C277018DB2BD3B85DFB9F2793119988F21B97114B60B4F94A3D72526B5A8A6A2788A16AA96EE2EE1BAAB79A25792EAA8D9CBD586AE98D4B61F67ECC28A0DE295C9534DB64BCB386B1C8B738EC74E31EF37B6F28BB41EA02F2CDCB2565B432DCF7FDAE6297252D364A101C22B449A0D2200FD8CCCC87956EDB4DB1264B8D2958A29A6CB485618D94A0924A05D44933369968998B35D4AA33E45377582A0D75E3B00E76561639C7C7FA6A50D491D13CB6F6E751F5DB891E4C3FE2F2DAC540FEE1C87237CB1ACFA5E27D4D4FB76EE45B2E150AF7727AE1B5CB8115C7E7111E1BCE284B5283C90EA9408A0E14E1DBAAB6B9B70A1F21C92428F6642DD117464FC430F6EAF0943944A5D429B404BF7D4023B4B48EC4AE9BBCBAF747E75CAAF3BA2EDA093E174C41D3DFF003AD8F0F97562E544DF6DD4EDA65FD5114CD62BC1CC73F46B0743D1623B60EF9FB6BB78F7F1D8CDA57F8D0DA3A8F517EEEDFB29EA109332A6EE2B549D8F39F5CC2E74AA1963950DFB8DEC9BB79E4602818BEDD5B007ED67C81A9E70C2CC35D1B1F5F52627BC5D37EBE8D7E951307A150B2DB377CBBC604F57F473EDAAAFE0BCD9F9354A6651771BA9FD72BEB469CCB1DBCA54DBE907D48E9F752F8C4D068820D1047347BBEF87F707746424D52F6417C7127D0A94F9D40E905EC4DBDEF27EB88DCCDFD9659E4A3EA66235E2C9E6BBB03FD0BDFC991AD09C4D54B037B7A903E31194F82489E68A6DC870FF0076626CF534AAEF8E70CF68862D5107B91ED50DBFDEEB38E23FBC286C97508D51C3E1FE054E76F887DE716613983EF6EE96DD4272D58AE5D258B0BC0A5EC66721AB85B14146AA1EC72D0EB49AF7F20075E18AD7991242ACD9A4731B217E319470AC5961DA964170685A49439EFA0A547CB387D769B7D373334DCFC0B14B6DA30BB348C82F90E3CCBADB716B6332D1183817256874B4AE550652B20815F0D2EA4AE79D79080122645A1227BF56C887666C9D8661D85D4D4B8BA8586DB51095BEE14954A49044C4C5E22373BB2ADAAC3773B3DCE3721F6376B71EF57B972AD7B636D904596D2D05F2444DE67238BCE21A4A02A3B5C2A0A57506BAF556596DE5ADCEDAC93D91DD1B2F1D7C83CB0932C8C5710C2E9A8E801A5A543690A7D43ED5D329AFC06CF75254552715CA9D9119770B76739DCE7A38CA2EC059ADD44D9312B7B621D9EDEDA782111613546D3CA38731AABC55A6DA8AB71FEF1B06802C48E41161607966830649FC3A3B6AEF38A37DD59D656B3699EC124EE86F6349930A4C7990E43912644750FC494CA8A1C69D6D41485A149A14A9240208EC3A4E0906621EDC6D2E24A1601491220DA083A411B0C79294A5A94B5A8AD6B5152D64D4951352493DA49D11E809090890B832BF5C361B76F0870A9DB86032A0EE1634DD39A8CA542DD77427BC0F29D6DC34EF4D4E97B1F694CE235A64B1F555F2441F181F80C7E8AB05897D2AA65F2FDE327DE4A93E588F3A4113985660B9A5F36EF2DB1E698EBDE55D6C5203C86C9FCDC868FAAF467477B6F364A140F71D7561E532B0B4E91FCA5E586CC63096316A47291F1342C4B7A4F9AA1EB24C943921CEDDAC4AC761DC4C5726C35BF2F6FF00737D8328C31A1C4466A4C84A65403E0A89202DBA7727974A6A9A4A1D4A91DC5C9439ED1E436447B2CE26FD561CF53D59FDA69AFB4EFAC529EC39C8E224AE59C5F1E7D9EE2FB698A5DB32CBEE6CDAECB68656EBAE3AE36DADE5A525496180EAD016EB9CB44201AA8F01AB1C216A06E254A204E490546CD804626A4A7FC4BC86AF2537D4137946EA44CCA6A56A0359D5143DBA5D64EF7E5D9E6457CC3B3D56238ABF254D63F6485715B084C364F232E38DD55CAEB88016E0048E6269C35D174146E90A58AF4A8813096BB20CAD97962E6C2306728298305183BE413F68E3F35AA6662722059A043117FDD9DD5CAEF363C8F26CD1ABEDFF0019750FE3B799B7271D9305C6DC0EA171DC26A82958E60477E86B0EA2694568562214525248685A93A53A341D90F9E2D4F8069FC0C13C22A0BBBE31BB7C09054A7DE009138F0CB37437333D7613F9B65CC658F5B90B6E03B75B939254CA1C20AD282B268145209F73499EC0B0B7A5E20C4152DAC8F9A17E198CE2985850A3460ED054A772A0A672D1391D538FC85B9FB976DB7D8ED36ECB58836CC627AAEB8E4162E4E36DC09CAE6AC98E124796E1E63EB0F1D7C4E0385A400062120663EC458768B23EBD8DE2AF38E3AE270752DC4DC59350495A3D155B6A6C1618590EA4FA8A14A6F1DD053B3FA7E57FF335DFF85506DC47FB210D575DFF00F2E07FDAC226FBB8FB8B94E436CCBB24CAA35FB29B2A5A45A3229D7171E99152C385D6832F289524216A2A143C09AEBA1A4A30D164AF12F0C9994F87D926CB65E41CD1DA9CD4B2E5F6A9F044AA444C3B6C940A54273D04120EE31ACBE65B97E4D769B7EC8AEF6CBE5EEE2A0B9F769B314EC8794948402B7146A484A40F734DEBC07075A8A949AF24EB2C8F9A1F28F31E3D46CA596158421B4E84A6A0848D7609ED8DFE41BADBA99663D0B12CA3356B20C5ADCA8EAB7E3D3EE4EBD1193153C8C16DA51A0F2D2689A760D2F62968A9FEE978926C958D01D93AB46886271AA971D2EAA9F042B2ABD78BC677A73BD39E99DB3DB0A9B7F51DD42DAA1C4B7DB376E642816F6111A0C36AF0F794CB2D2421B6D08248094A40006B8270DC3529090711007E887CD03ED54BEB538E53E08A528924978CC936924CF493A62ECBA57EA56D1BF188B31AE72A042DC7B2341393D962BA90D387995CAF434B8EADE75B0DF2798A2000B34F0D7570052945B6DD4B60800BA82826CE6DB14AE60C01DC21680E3AC385609FB170381323A0CB46E8A14EA5D9F237BF7251F4724BC0F82E123536E189FD8AA06C7D5D4987CE2B09BB86AB6D0B3D17A32B027836BC49F2681A7E2289FC0753FB1AA6F3826E63B55FAD279E4634D644578B94E93FFF003CB98111D47EA5518A60D1041A208E623715EF32FF009DC826BE65C2E6E13F84EB87E5D41F064F898AB036BC8FAE237362CAF072D3C76522BFDD186370E4F35F6327C5B707C200D5F9C4F3FE08E6F5A3EB4659E0827FF266B734EFD5898FD48AB9B7E374856BE5DEBCAFF66C328A7C5ACEB88FEF2BE58D4F9084B01A3FD5CF9D44C327A4512E8D95A2F577C7E68B9D8EE722D171434F308B84470B4F21B90DA9A7421C4D149E6428A49041A13AF495A9066932309EAA919AA4786F202D3306444C4D2662635C8806D8D4871A0794389AF85456A75E2155D3B23EEA0F671D7D8F31FBA20834411217A5A52E46F2D9F1F585AADD9959EFB60BEA12484FB14CB648F316E53EF1B5212B3EE69C30BB5F09D4A041E420C41B88C027055BE3BCCADA711EDA5C4C80DE6640E588F094F2A427982F97D5E71D8AA70A8F774DD13A2676C7D6BEC7C89378728E71B1170B3BAAF36EFB2597DB321B3952BD6FA96FF21B893D9483DCDC9436E9A7D2D3933F6B4E46B6D408F654647A6462BDC547F0DC792E8B115AC2DA57EB58495B64F2A0A93E48BC9CCB06C3B70ECC71DCE719B7659622FB728DA6E91D1263F9CC925B73CB7011CC9A9A1D5914F54ED32EFB4A2956D06463152921424619A67A69E96244F996A63683027EE96F4B6B9F6D6EDD0D52184BA399B2EB4015202871151C7BB4E471AC442428BCE48E833328E7E037E888D87F854E9B3FB8EC33FB2237F035E3F8F57FE7D7EF18FBE037E8883FC2A74D9FDC7619FD911BF81A3F8F57FE7D7EF183C06FD1107F854E9B3FB8EC33FB2237F0347F1EAFFCFAFDE30780DFA220FF000A9D367F71D867F6446FE068FE3D5FF9F5FBC60F01BF4441FE153A6CFEE3B0CFEC88DFC0D1FC7ABFF3EBF78C7CFC3B7E88E683FC2A74D9FDC7619FD911BF81A3F8F621F9F5FBC60FC3B7E88E683FC2A74D9FDC7619FD911BF81A3F8F621F9F5FBC60FC3B7E88E683FC2A74D9FDC7619FD911BF81A3F8F621F9F5FBC60FC3B7E88E685561BB1BB3BB7978564382EDA63B89DF1519C86ABB5AE0331A418EEA92A5B5E62120F2A8A1248F40D70A9C52AAA5371D714A4E99124C7B4B494E800473A5D5947F66DFEDCF6470E5C9AEE7F1A6B8BFDF6A4DC30FB8AB1FA73F544583C503799C217B6851D04C2771370A2D566701A16E841FC170D355367C1771DA9F681F8531A4F85A7C4CAB45FAB50F8D423A9D8ABF3234773B7CC690AAFBA9075231A2318B824A237C7BEBEC78809A024F60EDD10472E59BBFE72F2B920D43CECC583F86B51F9750FCAC9BF8D528FD327AE71B7B391F072BD66EA650F8650D7E00CF9F93C06BF8C2103F76B427E5D5DDC5154B05236BA8F94C666E080FFC86F7A2C3A7A044C1DF7B7DCAFBD426EDC0B2DB65DE271C9E7A1B83058724BC436BE4A86DA4A9541CBE1ACF75C92AAA70244CDE3A234FE4D7DAA6CBB44B7969427C14DAA2122D13D264232F1AE9FF002354395936EA4B56CCE096D712DCCBEE4315E6E6CB71402847B65B9412F4974835E0024789A11AFAD502A579DEC246B22D3B923498E788676A60B14F868FC654284C21A502848F49D76D4A13D27646DDDDCED93C28FB2EDA6CBC5CB643069FAE3B8EEAAE0EBC470E745AE3A9B8ED03DA01513E235ECD4D3B5634DCF7AEDF8459095397B1BC47B58857A9A07F274A2E01B8BAA056AE6E48C53D4E67142C8C336E1306BC2D8311B7F9013F47948AD3DFD7CFE24E7A28F74474FF00D7B43A7C7AABDE97E2177A3F15BFD679FCA2FF00D3DED65D100D56A896A916C74FB8B8D2683F1747E3D27BCD367C847518FA3253CD7DC627589F69C4B839949F963ECEE76C25C140DDFA676217D272C5955CA2F1FF0056EA1D468FC4D31D2CF3288F9E3E7F97B1F6BEEB152AFD630DABA41063F7F5C7A5D07CC1B1F972943886159690D93E05418E6A6BEF8D47F9A57BDFCD1F3F85669D1FC418E5FC3DBF5A518775DF78F02CD76C7B69F6DAC7B4D02FB19506F17A86E3F72BEC988B1471855CE51E76D0E0F9E1B48AF88D7955700929690100D84DA552F68FC91D69B26A9D790FE2754E552906F252A01B652A1A15E122C246ABC4CB6447D0000001403B069044DE3F7441126FA556FEB1CD736C61D5110F29C0AF91DF4771722A5A98C2BDD4AD90469C70B214E2913D285745BF2457FC48059A1A7A902D6AA5A23915342B9C2A2F6B218173BB58AEB6DB35F1DC6AEB3E2B8CDBF206596A4390DD5A689790D3C14DAD48ED01408F1D58CCAD28585293780368D13DD6462A22294B737ECF6EA3717C8EE3B85B73B8E7723207E5AE73D78F6C7ACD9238E92565D2F2DD2D38AA8EE7D3E84D386AC8A2CD942EA032F37713294A5791D53E8842BA7583306709DC1FAEDEA5B61EF8D61DBE18E4BCB634421326D992475DB2FC86ABF3D999C812F8F053885F37F183B75D6A72BD057A3C4A650493AD26F27CA357925C91F1350B4192A2D5B63FAAFD9ADFB65A8D88E442DD94F97CF2B08BC04C5B9A282AA2DA0A8A1F48A1AA9952C01F3A9A8362781555019B899A7D216A7F9BCB2854DBC95E88925A678EB068820D1041A2083441068820D104732FD67B1ECFD466E6A294E6BE4B73FDA7239FBED4D3865622B47E9874A6277C4637B0FC195FF4847BAE110DDE2E7FA0ADE47705FC4B56AABE210963B51CA9FA898D25C2337B2B51F22C7F78B8EA6ACEBF32D16A73B7CC86C2ABEEB693A7E4774724639AA127963D63D71B2D7A8E1185727BD9EDD3E47679119D73F1504FC9AF2A3204C75A745F7129DA40E98E5A72370AED17770F6AD9593EEA8FFEFD453260BD8DD27EB07CB1B6388E6E659AFF00D491D42131B52DF9B9BD8D1DBCD32227F1A5323572F15152C2DB1B5E4752A33670453FE2F50AF4691DFE8C5E96EB6D6F53171C87248FB26CE31B5D8A5DEE2FCFB85D604E2C5EEF329F595BB2A6CB1196E23994A3C8DA17EA8E04F70A96AE92B0AD5E00084933983DA56F274F921FF2DE63CB0D53B4AC5CBD52F2121212A4CD96920482108BC0190D2A50B4EAD6630DF3A28EA8F2A723C8CA32AB5642FC40B111776BFCE9AA64386AB0D97A3AF97988A9A76E9B5781D6396A940F2A89F922C3A3E2DE56A20534ECADB074DC69089CB44EEA84E51A61F67EEFC1153331407C3EB191FF0009AE7FE5EAAF579FF9A157FEEDC03D17BDC4FF005E3EC7D9F7BEDFF9FC4C7A3EB093FF0009AFBFE5EA9F579FF9A3E7FEEEC07D17BDC4FF005E3EC7D9F3BE8471B9E243D1EDF2BFE0F47F97AA76A79CFCD1F3FF0077E03E83FEE27FAF1F63ECF7DF2A71BB6240F87B74AFF83D7DFF002ED4ED4F39F9A3E7FEF0C0BD07FDD4FF005E3EC7D9EBBDE471BDE220F87B6CBFF83D1FE5EA9DA9E73F3479FF00DE181FE6DFF753FD7860F78364CEC734E379DEE7E149BF0415B187DB25CC9B76738022B1DB894681AF053AA427D3A76C3B216295F6B494DDF489213CF2B7C938E2E71DF014696DFF00751FD788CD669F96E6B766AC1816253F23BC3F4F26DF0633B3A4907B145A601E51E9570F4EA7B45C2AA3A64789885413B932427DE54C9F201104C6FF00D40563AA28C3699281E93BDB57B892123CA5512DF13E813AAECC61FB75E1765C01A71214CC2BBCFF00E72A0AF16ADED4908A782D60FA34BCD3E57A0126A983AA1ACCD5D2B3D498AFEA788D99ABD7F6B5CB6D27F360225C81174FC50EB639F663EEEB2AB84BBB6F2DBEC93930D69B62ECCA9CB53AF2C84A9A79D57905B68A6BCC52144F672D35F119A5A6C9F0E8594895968E993625D30D95950DD40478B5D54E12A9AAF0B00DA905D55E54F44EECB4CE1CC87B06ADB2BA4CB5C0FB462F18BDDEDCE86EE167B8CB8CEF94E2405043D165DC94906847029D71A9CE787AC94BB4ED4C6F00F409C70A5C9D8C54369759A77948509850428A48DA0CA461F0C5F74B3CC45E623DCFAA2D9CDDBB4A3838E5E0A31DB9903C24DBE44B8F5F498DA677B17C15E134CDB3B96169E6548FC50AC64BC787FC9BC7FD9AFE6873330CDFA60DD8C6BF57F75721DBFBD46707E76D92AEF0A5790E7D38D290B6DC41F05A3915EE690B18EB746E5E61F00ED065CE3475C7BFF24636B16D0BDFD9ABE68A8CDFEE97B6EF0D79ECDBA7ADEEB064902DCBF6B4E1CF5F62A2F909483CC176E948711ED1CBDA12795D1DC5C3A9F613C42A17FECAAD6849365E9F64FB43575724247720E3A9B5344FFF0066AF9A1E1E987ED15BE63B22DF83750521EBE580A931A0EE306CAAE1078F281726D22AFB63BDC4A7CC4F6A839DA15E3194DB793E351C8136DD9F655EC9D5D4754A2349794DA8A1C0410646624411A888B506FA89D88750875BDDEC496DB890A42D3758C4107B083CFAAB1DAE61A5942D602926441B083B08898B19371A7DB4B8DD23AA4284C10851041D041024447E2FA8AD886E9CFBBB8A0AF652E91CFDC5EBC7F13A5FCE279E3B0C8B8F1D144F7B8AF9A3CFFC47EC2FF7BD8AFF0069B1FC2D1FC4A9BF389E78F5FE43C7FF00FC4F7B8AF9A3E55D48EC224731DDEC569E8B9307E20AD0713A51F944F3C032163E7FE49EF70C79FF00895D81FEF7718FFEFDAFD9D7CFE294BF9C4F3C7AFF0020660FFF0013DEE18FB47525B08E2DB69BDDBC656E3AA4A1B409ED12A528D0002BDA49D1FC5297F389E78F8720E3E012689E90F50C50CF5C6D795D476E370A735D54AFC68D195F2EA7DC3457DA5727D741F84C38710133C17045FE81D1CCE0868B1435B143FDA9707E59D56DC484DDC75EDE107E011A1F834BBD95A9B729C1FDE2A3A8AC2E47B561D89CAAD7DA6CD01DAF8F3C742BE5D3AB066DA4EE1D5192B1645CAC793B1C58E6518536BAC37C6832A73C9C5F2477B3CAB5CC5FE2B0B3AE6E99215C8616E1A9BD54D0DAB4F588E5D324572D8AE5E96C0F85691A8F64245EC769B7289E64AA3637159CB995EB4ED401CEB488D7ECB325FDC5C61948AA9DBADB5007E14E606AD9E2A9FF000F606D7D3F55519E78286ED7572B651B9D698EAEB50B8ACA0D1041A20834410688234F9064163C52CB73C8F25BAC5B1D86CCC2E55D2ED35C4B4C30D207152D6A200F94F01C75D1A696EAC2100951D0047C240B4C527752DF68AE5199C89B85EC22E562D8C38AF657F372D94DE2E454792909B2098ADA89A2554F395C29E59E1AB2306CA2DB203955252BD1F3472EDEAE5844ED4936263EBA73FB3B72ADC15319F6FECDB863165B92C4C6F140E2BEBDB895FADE64F7DCE65464AFBC1ABC7BFCB3A317CDCDD3FD95280A22CBDE68F646BEAE581BA62AB5516E363C67677A7DC39D45A2063FB6387DB51CD367B8A6A1B6A29A9E79129E573BAB3C78B8B528EA02EBD55883BDA2A7167CBCC357921580940D822226E27DA5BB0B893926161F16F3B993D9E087EDAC8856F52BC3DAA5F2288F4A1A58F0AE9FE9326D63D6B84206FB4F30F9E38AAA92345B111F24FB54374E63CF8C4F6D719B0C452BF9BAAE6FCBB93E94FED8B4A888AFEE74FECE47A748FB47144EE90F9E391AB3A8440BCE37832ECFF2FC8335BE376E6AEF92CB336E2DC48EA4301C294A68DA56E2D405123B547491EE1960EEACAD61C24FAFFCD164615C62C7F0CA46A9182D06DB4DD4CDB99969B4CF7C275ACD6E093F9D8B19E1DE00520FDD3F734DD53C24C3563ECDC7507794A8750EB89151FF00A81C69B57DB32C38370520F38528744292065D6B9452DC94AA03A7BDCA29BFC71D9EF8D41319E18625440AD821F48F46C5FB874FD124EE8B4F2E71C705C4941BAA0AA659D6BED37FDA0D1F49291BE1569E45252A4F2A92A154A850823C411AAE168521452A0411A41B08E5117236E25C485A08292260833046D04584427AF98EC6BB214F34131E781EA3FD8174EE5FECEA739433CD4608B0D3935D3136A75A37B7F2A741DC6D8ABB885C2FA3CCCDA9F664D560162F425CF55D969DCBEF2778B212562BB48B1CC55AEE692DC62BE55257FE6567B143F6A7BFE1D5979C32CD3E63A3188D010A76ECC11F9548F34FAE9D53B7CD3AA54BF0EF3AD664EC4558462A14860AA442BF20B3A169FD12BCE97665DB4EB9B9F41DD4F7759EA35DCE7068820A6BE411FBAFB04654057973EDEE76797298557F05C49D034C73784DB50DC7AA1C5EBD58F27A8DCF7FD24D61C1EE2EDF0D5ABF386A7F6BAE1BDB3D0A8C619E7B596B0456C4BE3996218AC44D6C71FD0EBA3F2B501E2689638E7B08FAB17D704953CAECEE71DFAF1D3BED5385EDAFDB7789A97716B3AC9F12A84C9D2DA433651EC8EA8CBB99137714AA1B1E73EB985EE94432C23B71647B26DF6752BB3D9B1EB9BB5FC088EABE4D71A932694771EA875C0917F10A74ED75039D423981CA8D2C537D3E58FCB4E9A387299E3AC7D3FA8A8D67C6255DCAD55BCB63FBC4C6CBA728BED9BC38146A543D91595047BB7163F63567F14CFECB4A9DAF8FAA633FF080DC5628E7A344E75C753BA86C56F068820D1041A208D65EAF569C72D173BFDFAE0C5A6CB668CECCBA5CE4AC36CB0C3292B71C5A8F00120575EDB6D4E2821226499011F099473ADD57F55595753398338B62AD4E8BB69027A23E1F89B095993779657E5B5325328A95BAE2880CB5C7CB047DF951D5B981606DE18D5F725E211DA56A48D8376D3AF921B9E74B86434458EF46DD105AB6962DB372B74A0B177DD47D097ED7697395E8B8F850A808ED4B92A87D6738841F55BEF5AA2198732AAAC9658326B59D6BFF00EBBB5EBD90A5962EDA74C385D5675A787F4F31DCC66C6CB1986E9C96438C63DE6522DB5B5A6A87EE4E20F32411C52D27D758E3EAA7D6D24C0B2E3B889BEAECB5B759DC9F9F408F4EBE1166B8AE4C4760BAA7EB76F3173EDCFC8A4D830A795E6DB2F77A696DC54B2A238596CE8280534EC70F2255DA5C59D4BEA315C3B0349698482BD6069FA6AF92DE4109836B76D3A2183EAA36EB6BF67B3F8DB55B732E7DFA7E250D1FAF9965C5F0E3926E72425C119B65A0865A4476B949094F3732C8528F2E9D703ABA8AC67C77800147B291A9235ED333D51CDD4A5264223269EA3941A2085CE2EA6EE485DBE75AD13186927CB9C5B156FF0068A5F03EE71AEAA2E2121CC2542B68EAD4D38A36B57CC97EBA1168B3CEB2E9D3A74E83E1138CE3C8561988D022A1940375FF000C4DBFD1B8E09133F30855F1A3BB68DA4EC2E0BC14A82F2E1B9DCDAEAE367E1F587C3A8E611C57AD6084D6212EA76A7B0BFEA9E61CB131CC3C04C32A815E1CEA985EA4AA6E37D3DB4F3AB9213ADBD7DC51D08750570D4AFD19254CAFF055F7A7FF006A6A72FD26059D592A6D52780D205D753EDA7CF4F38D8A1157D2D7E69E1A54043C82AA627BA49530BFD5AC7DDAFDD3E924C3876BBB44BB31E74655169FD34757CF41F48F0F4EA8FCC396AAF037FC3A81349EEAC7756376C3B526D1C96C69DCA19D30FCCF4DE3522A4A4F7DB577DB3BC6B49D4A161DC6C8C1C82C6DDDE315B60267B093ECEE7D21F415E83DDE1A78C939B9CC0EA6EB849A759ED8F44FA69DE3CE1E70DE0447B899C3D6B3451DF680156D83E1ABD31A7C25EE3E69F355B898C2C4EE6B9319CB74A244BB7FAA02BE716EB4A1F4A4F0F834EDC4ACBE8A4A94D7D3CBC17ED32D01729CC6E58ED0DF7A18382F9B5CAFA35E155731514B60BDDE2D4EEC8CEDBCD2BB0775D854487DB8AC3D25E34698415ACFA00AD3DFD5794344E56D4229DA135AD4123CBF20D27745BD8A624CE1B48ED5BE64DB492B572244E5CA740DE61338ADDDDB9B73D1215579B78BA81E0DBBC401E84914D4FF0088D969AC2174EA607614D841DEB6FCEE550333C862A6E0EE757F3035588AA33752E9700D8DBA49BA3D5428486E22159AADA2E88FA42B95C6D5F45693F011A23E113061DDFB40523FC41E4AE8FF00C4316A74FEEED30CEAF9E1B9FDBAB7D968F418C5D9D07FE2D846E72A47C711DF0E35B2363C1F747C63509E28A658DA8ED6D1D462F3E06AEF65940D8F3BD60FCB1D35ECB3BE76CFED5BBDBCF88D94FF00F82CEBB5119B0DFB23AA334E6C4DDC62B07E9DCFAE61CCD2A88FC365BD520C5D9EDD4903B5AC4AF247BBEC4E8D25AD3261CF64F544872922FE33469DAFB7F5C47335969A58A57A56D0FCB1A45C344CF1D6B7257F54C69FE34AAEE577F7ADA1F18858F4A0D07B7DB6D104579B29B270F726A15F26AC6E289EC510FD31EA1143F0AACA3C695B28CF4CE3A81D4422B783441068820D1045237DA33D4DBB91DF1FD80C2EE0538F63AF21CDC69CC2F84DB8A28B6EDF549E2DC6345383BDCA248FCDF1B2B2860A1B47E2DC1DA577370F4B94EADDCB086A5D99BA217BF672F4BECB1123F50D9D5B8392E605B7B5F6B928AF92C7143975293F7CE714324F626AB1F3D2424CDF8D927F08D1B077CFF47C9AF9B547AA66BCE31277ACFEAA91B078C45C5B0EE4B8EEF66CD16F1A849479FF0057B0B579467BAC8A95A8AFD461BA7AEE78A52A05972E607F8F70ADCB1A4E9DFEAFCE7508EAFBB7048698633A52E853C892C6F2F51EC2F27CEEF2FF00D6D070DBA9325315F78F99ED576E7AF9F2944F3796AAA1BEFE65FCC73C7733CC7E1E8FB28165E164F7276277E93C9A79B4C79CAD316A2948480948094A451291C0003B86A0F0AE2076EC7D9E3B19B9974BD64B05FBEE11955FA5BD3EE574B7CC54B65F952165C75D7634DF387ACA51242148F453528A0CDB594A908375490240112B06F12F9613AE9D2AB62066E17D985BCD8F1932700C96C7B870507F9BC2794AB45C149FC078B91C9FFB61A94D2675A572C752A41F78745BD11C154AA1A2D88532F6B2FB8B5F6E560CE212ECF79B23E63DCEC7CE85B8DBA00514B8E34A5A3B08F9AA3EEEA279AB89A9A652A9F0F17962C2E287653ECA4F78EF366E317AF0EF83431565BC43125C9858BC86D07B4B13D2B57982CD09ED1DA985432C3319A4311DA4B2CA0510DA0500D51F5756F55BA5D7D656B56924CCFF002DDA2351D061F4D87B09A7A66D2DB69D0948901FCFB49B4EB8F5D278591E6EB4DBCDADA79B4BAD3828B6D62A923D235DA9EA1DA7703AD28A569B41064479613D5D1B358CA997D095B6A12525426923783080B9D865D91EFADEC6B5F94D71763FCE284F78FDB23C41E2357565FCE3499859FE198BA45F55895680B3ABD87361162B76839A736F0EABF2854FF1BCBEA5786DDAB45AA5369F387E9193E724F6922DB40BC15B67BB3178882435EA3A8A264B15A942BF60F71D5679A32D3F8155965CB506D42FD24FC8A1A143CBA088BAF23674A5CD5402A5AECB89907113B50ADDB50AD2856B161B4184FDF19368BAC2C8184D1A5AC357148EF0AE1CDEF8F8C6A6D93EA863B853F823C7B69495B24EEB6EFD157C2A23408ACF8874272BE3B4B9969849B52C375006BBC2455F4D1F1A12749856C98ECCE8AF465D16CCA6CA6BDBC1438287DDD56787D6BB86D521F458B6D539721B52796D498BAF16C329F19A07695C929B79044F7287654390C9439043658A38B877E315CE05D4BB1DC1FB64711F1A75A0388EC22BF01FC422D0928713ECAACEA574464AE0DD4B98566AFC1B9615A5C6543D647687C48E9875B59C6364C7C38688591DA0123DED7C31F53A61E5EBEBD7DEE9EF1ED76D962593F85688DFB1ABCF86EAFF0013AB1FA26CFF002E78C6D9D51FF8961A7654D48F88FCD11BF0B35B3AC7D192E7C6127518E2BA658BA4ED693D6A8B7780ABBD9796363EBE94A0C74B3D3CBC5FD8BDA5709A9FD55B6209FC08E84FC9AE58719D337EC8EA8CFF009E51771DAD1FA65F4A89878F4B622B0CFF00504E795B1BBB6B1DBFAA7751F8D1963E5D23C47F7673D93D5129C909BD8ED10FD337F5847353981A591C1E2FB43E3275CF85C99E369DCDAFA8468DE392A5965636BAD7593F2438BD1F345DDFFDB248152327B4AA9E843E567FC9D4F38A07B5423F4AAEA4C523C31B30BC715FF4A07395474E3A89C56F068820D10446EEAB77BDAD84D99C8B308CB6CE4F3E968C2A2AF885DCE5A541B594F7A584254EABD09A77E9E302C30D7D525B3DD16ABD91F3E88E4EB971338A01E9C7686E7D436F5D830F9CFC9956F9D25DBD67D78528A9DFABD958765B8A7083F9C90B586C28FDF2EBAB5718C413875229C1A409246FD5E41A7C90DED22FAA51D20EE2E75886C5ED75EB30BAB2DDBB17C1AD694C1B547E56F9C3494B3121474F60538AE46D03BABE1AA7E8E95DAFA80DA6D52CE9E924F59873528204E2BE3A56DB15E5992DC3ACFEA52E3020645974932F6DAD5797DB8D1ADD100E4625A5321490395B011181F9A81E6FCE5822598E56F82D8C3A8C1294892C8B493AC59F16FB35426693337D5168D6BBADB2F96E8777B2DC635DAD571692FC0B9C3750FC77DA5714ADA75B2A4A927B8834D42168521452A0411A41D30AC19C67EBCC1068820D10473CDD4F7FFE84DDCFF9FAFF00906B55DE29FBD39CB1B8F879FF00F3B45FAAF94C315A4113283441068821B4CB1E9706F287E2C87639911D0496D4402524A4F0ECEE1ABF786D4D4B8960CA66A1B43810E2876920C828050B748B498C9DC66ADAEC1B31A6A28DE71A2EB2833428A41292A41B0191B02673109FB4DD9EB65C1332BCC870D25B63805A1478F01C2A3B46A6B9932E338C61E694D8A026D936DD50165A6D91EEAB688AD726672A8CBB8B26B85A95193A9120168519AAC12008EF2642C236130EE4C8ECDD6DEF470A0B6A635F9A70711C4550A1EFD0EB32E175CF60B88A1E2085B4BED0E4325A7CA26236CE3B85D3665C21DA60429B7DBEC2B54C8BCDAC722AE98C0C6E4AE45A5843BFEF1094A8CF8EF0A68D057DEA69E73E50229B16716DFDDBC03A9DE1C133F14E237C2AC55CADC01A6DEFBEA72A6163585346427F46EC22A427D8F33491D8A98DAC7B8E815FF2B56C512FF1F93483A430A1E56E72FAA2283C49BFE15C47053A0D5215E47809FD730E9EB3AC6C231E6EFE89CFC03F73418F49D221E8EBD124EEEA5DEE7AC78EAC7BF6A687EF7576F0E0FF008B548FD0A3AC463DCEA3FF0010A2DD58F8E954469C24FF0045C91E1255FE4274CBC5A1FE26D1FD10FACA8B33800A9E08F8D9507EA223A4EE99DCF3360B6A15DB4C7A327F1014FC9A43867EEADF2451DC404CB30567EB550F9697C43E18DEA61FF67D83DD773B39B1E94D7FB501BFDF690626654AE7244C387E8BF9828C7E95279AD8E6E3333FD0D4F190DFEFB5EF856278CFFB25FF004634071D952CB72DAFB7D4A877FA27603DD42EDB822BCB7D8EAFC465F5FC9A9AF134CEA2813EB2CF426298E1D0BB80E38BFD0B639D4A8E96B5168ADA0D1041A208E7E7ED1DDE0733EDEB4E016F93CF8EED3B0612909354397796943B3567D2DA7CB67D052BF1D5AD93F0FF00C3D278A7BCE5BF4468E7B4F3437D4AE6A96C89AFF665ED2358AED45DF756E11E97ADCD98A6ED8E28716ED16D716CB4127B479AFF009AB3E202351CCE75FE2D48606840B7DA3F30974C76A544933DB0C3FDA8DBB8E4EC830DD93B64AFE65656064996B485F05CA91CCD4165C48FE2DB0B7287E9A4E9D324D05D42EA542D3D94F20EF1E790F2478AA5E84C54FCD9732E4A42EE53245C54D8096D529D5BE5294809484F98554000A00353A4A427BA25C908F4C7445F676E60729E98F18B7BAF076561171B8E3EEA4905496DA7BDA63823B80664200F40D5499BA9FC2C414752C057448F48872A654D113975198EF068823C24C98D0A3489932437122446D6F4A94F2821B6DB6C152D6B5A88094A402493D9AFA9495190D30473ABBFB9058F2BDEADCBC8F1ABB45BED86F179548B5DDE13A97A3BED2996805B6B49208A8D4031CA6769EB5C43A92954F4112FE437C6DFE1BBC8772E5194282806E46467233361D8771B61A2D3544DA0D1041A2086FB3A68FF0046C8A1A7E71B27BBB943E5D5D7C1FA91FB533EC2BAD27E48CD1FEA1E88FEC352059F68827DD50FE9437FABAE33443A1864F322039096AAB9055F9BFF0056BE23E035D67BE2A60C29AB915681D9785BFAC4E9F79323CA0C6BAE0466435B85B987B866BA65767F54B991EEAEF0E4298D9DBD1ECB79BCC6028DC90D4D6BDD5550BA7BE34C18DBBF8DC1686A099A9B2B615C8992D1F0989665A63F86E64C52900921E0D552795736DD97D34DB093BC375CC6184F12B722ABE0A7EC6AC9CAEF4B273C4E8097875FCF14C678A62AE22D3253A54BA63D5F2261CAD50423581D31E4F7E85DFC057DCD07447D477843DDD7824AB72ED6E9FBFC631950F7EDB4F93573F0E552C65E1B584F414C644CE689E4E60FA35CF0E7BF118B073FD1D307849FBA84E9BF8BA9FF001060FE8BFA4627FF00E9F553C22A86C7FAD098E8F7A527FDA7A79DAD72B5E5B52DAFF6525E6FF7BA6BC24CE951C9F2C539C4945CCC5583D7079D20C485D38C41E23E7556BF2FA79DD3578DA529FC690D27E5D3762DFBAB9C9F2C4DF86C2798A8FDBFE898E7173534B4343E94947C495695F09D33C5967634AFAC98BC78F8B9600D8DB508E84ACC3F1D0A33E6F50DB78295E5BB2D5F890252BE4D4A7894675F429DCE1EA8A93210BB9571B57EA47C47E78E91751C8ACA0D1042437032F838060D97E6F7252441C4ECF32EAFA567942C45654E8457871594848F49D28A4A7350F21A4E951039CC7C51909C727CF3D7DCFB2B71F7D6A9793673792B75C3C4B93EEB2789E3E2EBBABD80453B72162503A123E6868B547963AC3C1714B760184629865B79516DC4AD112D71D607282888CA5AE73E055CBCC7DDD51154FAAA1E53874A893CE61DD224251CB96F9E7CF6E8EF0EE4678E3AB798C82FB2976CF30D4A60B0BF6786815AD02586D029ABB70CA514B4ADB5B1227CBA4F4C3538ABCA261AAD2F8F11729F6525CAF3F566F1D99CB74A38F7B65AE743BC1452289A5A75A911C2CF6B85B4B4A20760EDA5456BBCF484DE655317A444B5CB51EB85B49AE2DEF5008591E3224311187E54A7DB8D16336A764C975410DB6DA015296B528800002A49D7D009321A608A1BEB63AD593BB126E3B55B5B70722ED7C474B3905FD9250E642E36AE2841E0530D2A1C07F9DF9C7D4A0368E5BCB629007DF1F68740F43FFB7572C37BEFDEB0688AE78371996D73CD84FA9927E7A3B50AFC249E074F78BE07458B35E1D53616351D0A4FB2A168EADA21DB2FE67C4B007FC6A178B6758D285EE5A0F655D635110E25AB2F872F9199E0429078072BF9A51F74FCDF7FE1D51D98F863574337688979BF47F289F2685FD1B7D58D3F93B8DD87E27758C480A778D97BF22A3ED1B5BE454D3EB42BC104020820F10471075589494991123177254140149041D045A0F218FDD7C8F51873E0B17188EC4903D4747050ED4A876287A469D305C61FC26AD154C9ED24DA35293AD27711CC6DD50C59972F52E3F40E50D48ECAC5875A143BAB4EF49E7131A0C329361BF6F94F44909A3AC9A57B943B943D046B58E138A3189D2A2A583342C7941D693BD26C3181B1FC0AAB04AE728AA849C6CCB72879AB4FAAA168E6D2237789492C5E99456889485B2A1E269CC9F8C6A25C4AA015382B8B95AD292B1CF755F0AA27FC16C54D166569B9C92FA54D9DE48BC8F89225CB0E5B8D52EB12401F3E3BCCA8FB8A42C7CBAA0D8A8BD853CC9F35D6D63CA16857F46357D5D25CC7A9AA479CC3CD1FA2A6DC4FF4E12451ED79C1238A61A42947C391BFD956ACC0EFE0B23C8D85D240DF7DCFEAA4C52859FE27C4F9A6D4B0013BBC3680FAEA039617DAA5E349C793FF00A07BF015F735F0C7A477843CFD6F385FCF2D8EA9341FAA989A906B5A855AD06BF092356F70F17FE3AA1B58FEA18CAB9CDA964A07657B9F59C11197063FCCEE03C1F41F851A38BE9FDAE98FE8D5F5A249FE9E55FE1F5A9D8EA3A51FCD1D13F46B20C8E9BF6E49FF00348B935F89729434C38299D223CBD662B1E2B22EE64AADF70FF769893FA748AF223A756BCDFE1D77439454FD5F1EBEE7B647AFC5A6DC5FF745F27CA2277C32FF00FA3A4F68FD45473979B03F55C720701253CC7F72AA69C784A40C4DD074F8465EF262E6E3FA54704608160A813F71728903D084D660F507B7CE3C400F5D9D8E9AFD27EDF25B47E51D3FF12A6313A22745D58F2CE2AFC8ADF8B9431948D214D2BC8083F218E8FB4C315741A208819F68EE64BC5FA69BBDA18584C9CF2F36EB152B45793CEA9AFD0778288A527F0B528C9F4FE2D7851F30157C83AE13D4AA48E58A81E8CB135E65D4DED2C0F655CA8B68BB1BE5C795B2E21B6ED8CB9250B768084A4BADA120AB85481DBAB03313FE0E1EE99DA4487D232EA846C09AC47449BD3779F61DA3DC9BADA5A2F5DE3637711676476AE63B1D6DC648F75D5246AA4C39B0E54B69568BC27C93B7A21C9664931CDFEFBF4C3BA5D3ACE871F35B7227E3F3C21169CD2DBCEEDB9F70A412CAD6A014CBA0D4723807352A82A1AB830BC6A9F1104B664A1A5274F2EF1C9E586C71A5234C6174F5B0796750FB81130DC742A05AA2844ACBB27523999B6C1E6A15D3B14EB9429691F7CAE26894A88F58B62ADE1CC971769F347A47E6DA606DB2B3211D2FEDAEDBE23B4B85D9303C22D89B5D82C6CF96CA3E73AFBAAE2EC890E50171D755552D47B4F80A0D5355958ED5BA5D74CD47F9486E10E6948489085DE92C7A8A60FB49B7FF0070A164A3616D716463186CAB646BA5EAEA8728EDFDA91CC0329527E646696852168AD56B1EB7A940AB1727614C29BFC528DE5CC803D097CA756C1BE1154B867762A3B53E8471FBA208FCD023E1D10F7591931ED16E68D4292C20A81F157ADF2EB2566DAA1558BD53834171407D1ECFC91BFF0087F4268B2F50B27486524F2AFB7FD28DA6A3D1308344109AC8EC7F5B474B91C244F8FF00A227805A49E2827E31A9EE44CDDFC12A0B6F93F8773BD2B6EAB52C0E850D625B22A9E2A70FBFCCF48976980156D7749B02D04DADA8EEEF24EA331E7461BB6566D50AD2A668B91127B0E487E9C565C5042BDE1514D3AD3E6C7B1AADAC4BB636ED3B89423D1B80AD3F48C8951DA76010C3599029B2D61B872D8929E62B195B8E4AD597541A5EFB8269094EA027A4985814A798295F795A1F0F1D55E95AAE948F3A5E5D9D3178ADB45F0B579B3B764C48F44233166CCA9979BCA87092FA9B609FA35E63F20D5A9C447C51D1D0E1493F76D852B965747F4CC511C1FA638962389E3AB163CEA90DFB37AFABA3C31E430B4D55317D4793DFA177F015F735F0C7A46910EF75A522B9ADAA2BA392444C4B108CF24F6F989B434EAABEE058D5B7C3B694AC70AB5258B7CA10232D676710DE4BBB3FBCAF70A7902DC9F5446AC14FE62E43BBCD6CFE49D28E300FB7A53EA2FAC43C7FA7851FC2D70FD237F5551D0CF446B52FA70C241FBC937648F73EB1907E5D46703FDD13E5EB3100E2E89664A8E46FFDDA6258E9DE2B486A37D71C7B2DD9CDCAC7E337E6CB9F8FCD309AFA4FB2D17994FBEB401A495EDF894EB48D60C49727578A1C6691F55894BA99FB24DD3D04C7355934532ECB3129155B203E91FEACD4FC55D34F0FF114D1634CA946495CDB3F4C487C528D53C5AC2158965BA94A04D4DC9D1FECCCD5F05E8D46D1E5F3309CE2C390DBD5CB3AD13E2DCADFE0A7E13A97928FDD8053EFEADAE27E1CB7A81154D8ED53AEF1F61561E6374F24E33C706B1064D7D46175064DD6B25BFA60129F294954B7CA3AA2C4B27B4E6B8C5872DB148126D19141667C0741E3E5BC80A09553B149AD143B882350165D4BA80B4E8227106C4F0E7B0EAA7299E125B6A293CA0F51D23742875D610C42BEAF3A73CB7A9599B53895B6EF1F1AC2EC370B85DB33C81CA3B2104B4D31199891AA3CC71695BA6AA2109A54D4D126478062EDE181D708BCB20048D5AC999D9A37C7079B2E486A87D766F62F6D76231B4E39B7B606EDE1D09377BDBD476E3707523F492E49014B3C4D122884F625291A6CC47137EBDCBEF2A7B06A1C83F918E886C204843A570B7C4BA4630E6B41F8EA71A754D1EC2A65C4BA8AFB8A403A4285949988F718790E3B61CB2CB71C7326B444BF586EECAA3DCED139A4BEC3CDABB52B42C107C4781E238EBD32F2D9585A090A1A088F840361842ED26CBEDD6C7E3B2717DB8B0A6CB6C9B35EB84E5ADC5BF21F79D5123CD7DC2A5AC369A21009F55200F125557E22FD72C2DE54C812DDCDD263CA10102421D3D218F7068822B73ED29D9AFD76DA683BA16989E65FF6ADD53B715200E776CB2CA51281EF3E42C21D1E090BF1D4C726E23E05496147B2E68F6868E7D1CD09AA5134CF6450CB11A4C900C68AFC907B0B2D2DC1F920EAD1240D261BE05C692D2D4DBB19E69C41A2DB5B6A4A81F0208046B997DB1A549E71F3C764D33CA1308511B924FC90371DE75D69A0D2EAEAD281EA9FBE34D727EB5A65B538569925255A46A138514B86BF50F2190DAA6B5253DD3E710366F87E529084A503B100247B805358D56E17145674924F3DB1FA3AD3419425B4E848091C89128FAD798F7068820D10463CA6BCE614DD2A4A90A1EEA5615F269761B53F877C2E72B143DE4A93F2C35E3547F8BA55352999A08E542D2B1CD76306F92551AD72D4D0E67DF1E44748ED2B74F20A7C3A76C9F409ABC5194B963683E22CEA086C5F33E603CB0C1C44C55787E0750A684DD70065B034971E3E1A40DF693E48F7B5C14DB6045849A55947E7143BD678A8FC3A4998B18562D883B54742D5D91B102C48E6E985F9432F232FE12C50274B69ED1DAE1B567DE265BA519FA6689242F36C7097770F3AB062C1C11ADF29E32722B8ACD1B876A883CF9F25C576252DB0951E3DF41DA75DE999F19C08D5AF701A4F3432E61C5C61540E54CA6A02484EB5BAAECB691BD4A23C9330DD7519B82CEE3EE8E5191434166DF719EE3D6C8E7B5A84DA531E0B647714C66915F7757D70C30F3E1BF88284BC555D47B08D7E5367D18CA5C5AAA144D50E06954D54CDDF74FE99DED1E6B4FD384D61914B36A7242850CC78A93F8281CA3E3AEA17C55C403F8A2594FE49001F695DA3D1762DAE03E12AA5C09752A16BEE923D840B83E2BD1D1CF4AD8F2F19E9FB6CA03A8521D956B373712A143FD24F3931351F82E8D24C25BF0E950374F9ED8A3B8915C2B330D5AC680BB9FD9808EB4C483D38C4223F080A052A00A48A107B08D100328E783A8BDB37B6AB76F2EC58C728B44892AB8E3AA29A21CB7CD25C6827C43755347D293AAEF10A7552D4102C919A4F48E6F92372647C7518F60CD3CA929576E383D648BAA9FB43B5C8A885377B7BD65B9A90D92842541E82F0FA35A8E3E293C0EB4F659C699CC18605AC0248B8EA7D69495E450ED0DC77463BCED96EA328E34A69B25290A0E30B1E84E6991F4907B2ADE37C5A2743FD5D40C2109DBACFE6FB3E1D3E473DBAE8B354D9E63C7D70E7788AFABD627FCDAEA4FAAA5114DE2B85BB96AACB0E4CD32C92DAF67AAADE35FBDA0D96862548D710B0E189D0803116521350C8D2E01A1681AE7E6ED1D8EF244EEB9979990CB5223BA87D87D0971979B505216850AA54950A820835046948208988A454928252A1223488F4D7D8F3068820D1047CA9494254B5A8210804A96A34000ED24E88FA01264218FCC7A95D8CC156EB17FDC8B499AD24955B6DEE1B849AFD12DC44BA524D3EFA9A6F7F14A667BCB1E4B7AA26185640C7713916295774F9CA1713CEBBB3F24E22EE5BF68EED8DA02938CE217ABFAC7648B8391ED4C11E20A94FB9F0B63495AC5D5526ED332B70EE07E49C4D51C1AA8A64DFC4AB69E993BD533D3707328C46CC93ED3BCD9D2A4E3F8CE35676C569E6FB5DCDDF47AC95C647C5A7A6301CC555DCA50D8DAB207599F44705E0B90F0F1FB4624E3EA1A9A4FCC950F8E19ABC7DA29BED716A44745F61331E4254871962CD07914950A1491243F50470E20E9DD8C858F2E456FB48E49A88F87E5844EE3F9058FBBA2A97BDA5DC079953E886F97D70EFF04F971739B842647CD662B56F8C84FB89662240D2FF00FD6D5CBB575E67B91F3AA130CF995DBFBBC0D3F49E57CC6192BEEEC5EB27BCDC721C812E5DAF57778C8B9DC9E74798F3A40056AE542456800E03495CE10871454AAB25475F863FAD129A2E3EA68994B0C61C94368124A43A6406CEE46B539DA3EFED8AF79D1F2A749D5C1E58EED50F2A0FC8A87247FA896CF7E815E4747CA88CB6F37B6AA9E64592D78D02554F8C69B1EE126249FBB79A57BC9F90C3D537FA80C1972F169DF4725C5FF481E88D8B395D8DEED96593E0EA149F8C0234C955C38C718D0C85FB0A49E8241E8893D0F1932C5569A82D9FD22149E90143A636CC5C204AA7B3CD61EAF604AD35F82B5D46AB303AFA3FBF61C472A4CB9E52E989A61D99F09C47F75AA69C9EA4AD33F7673E88CCA69AA70FA41106BEC7C8D7BCC7B4CD8EA58AB102AEA41FBE7942893FB94D4FBA74F74B59F83A17528FBC7FB2773493357F68B90F65276C462B70EFE238A30B707D8D2CD607A550B1751E469B255EDAD3E8C6C34C9127854E1984657B879045C5F0CB248BF5EA590446607AAD375A175F70D10D369EF5AC81EFEBA32CADE55C409986DC5B17A4C2A9CD455B810D8D6759D891A54A3A80B61CCDC9CBB15D92C36F5B5D83DDE364D95E4694C7DD2CF61925890195738B25A97C098ADB80190EFF009D50E5F9A29A97E5ECBCEE2B51F84A73D9B3C6735253E8A79757A47D5062A6CC59A451349C6F1241404CFF00054AAEFAD644BC7786A32360FC9A7D7509C1B8D1E5DEEE41BE62B912DC2B79DEE48ED528FA00D686AFACA4CBD8695CAEB6D2404A769D0948DEA3A7CA6332E158757E6FC643532A79F5952D7A9234AD676252340F6523544A6DA7DBD99B859CE1FB7F676D43EB898CC571D4827C98A8F5A43CAA03C1B692A59F73595D6E3D89D6171C335B8A254794CCF900D1BA36F621514B95B052A409354ED04A06D205D40E552A53DE671D26408316D70215B60B298F0ADCC371A1C740A250D329084240F009006AC14A424003408C2CF3CB79C538B33528924ED24CC98CBD7D8E506882220757FB04E6F1610DDEB1C881DCF70D438FDA1A4D02E74557ACFC3AF7A8D399BAFDF7ABC39C9D33E3187FE25BBC9EFA746F1B3E68B4785D9D46015C5A7D52A67A415EA2BCD5F26A56EB7CD8A1DBED9117265C87290A8D2E32941B5AD242DA707029524F1ED14234D395F32BF80D5F8A81341B168F493F2293E69F21B0C68ECF192E9735E1FE0AC84B89ED34E69B8A3D68579C3908B4086908B8D867D0F34596CF61ED4AD27E2524EB4925587665A0D4EB2BE74ABAD0B4FF002988C66A4E3192F15F399A96F5E94AD3D4E36BE6E450B27874E3D6F66BB4C8898EDC0A725C3D0A09FD569EF142A382789B74B2145AF1F2D6148F009AD755063194712C0495D382FD36EEFA06F03EB2663684C5B6DE279733F002A88A1C48D97BF24F2BCB2133B094AFD65C5C7ED67531B43BB51922C193336BBD25A2E4AC62F0A4C39CD848AA8A52B5723A91DEA6D4A1E34D34D2628C548ECAA4761B0C41B31F0FB18C095F6EC95373B1C44D6833D168B533D8A0212DB83D646C46DF97E31CA7F5BAEAC732576BC7102772A93DCB91CC98E9E3DB572BE8D737F19A668DD06F2B626D870C178598EE249F10B5E0B7A6FBA6E096DBBDEF865BE203EE3FDA6594CAF3A26058FDAF15648294CC94A3769C0F884A7CA8E83E8505E9CA8F06C771291629FC241F39CECF41B7E130F8BCBF93701FFB8D7AAA9D1A5B6059C85427F5D110473EEA5B74F711C5FEB365D77BDB2A2488B3252911457E8C38FE5B23F17528A4E16A9D92ABEA94AF5502439D5FD5109D7C5CA0C3014E098634D7AEE76D7D16F3B8619493915DDF4A82E698ED77B6C80D240FDCD0FC7A9961F91B06A291453A54A1AD7DB3F159CC22198BF1473262930ED5AD293E6B726C7C32573A8C697CF4BEA24BC1E5F69255CC7EE9D4A9B6D2D26EA0048D804874440DE756F2AFB8A2A56D512A3CE6D8D9D9AD6FDF2F367B24571B6655EE7C6B7C575E243687253A9650A5948242429609A03C3BB5F1C58424A8E8009E6B63C8133136775FECF7DF0DABC2A466DED368CEA35B399CBF5A71CF6A765448C94D552421F65A2F2114F5C213CC91EB508AD237419B292ADDF0E4513D0552913B2C364775D329227A63F706E8CE1E69D2E5E3A8C677024A265B6CF7AB9B587336E6D4DA956875F4142A597F9A8B0CF3121BE15D155988B1880A3F0C48948BD3F4A5AA5BF6C096268BD388260D457C752784F1373A6FE88F2EEA170BBBE7672C8B815823CEFABF1F953A1AA50B8B8DFAB2168E579928436B21B0AE3CCAE603E6EA358C6656B0E743574AD52999194B66A3CB1DDA60AC4F4431DBFDB1D9274F7B892B6FB249CC5DD62146B95AAFB15A5B2C4C8B202873A10E125250E216850A9E29EDA1D39E1589B788301D4095A411B08FE538F0E3650646195D394738FCF4F7F8E89C7C909CE3611AEB7287FEED39E687D0E62A4FE2AAA34CB8865CC36BFF0078A7428ED9495EF2647A624B84E71C67093FB255BA81B2F1527DD55E4F44296266D39AA266476E527BD68FCDAFE51F16A0789F09A81E99A5716D1D87B69F91439CC5AB82F1F714A7926B996DF4ED4FD92FA2F20FBA215D6DCAAC32DD69325D722A491E6B4BA2154EFE5590A457DDD5738AF0E718A19A92D875035B6667DC3257303170E07C62CBF8A0092EFE1DC3E6BC2EA67ED82507CA53125B16B474DBEC09BF6559DE692D51D20AF0483668EC4A94E11C03774125E8E1BAFCE25295780D4552CD3364F8A561434A6EC95CE747343FD657662748451314C52AD0FF008A56D81FAB090A27648A93B4C68371BAA52D5866EDEED3E350F6BB087EA8B8592D0E2DC9F70E14ADD6E8AA3CF578D509A0A70351AB0B2FE48AEC55095287E1A94DB3D2E383772ED5486E314FE61CDB8465FA92E3EE9C4B134582F7669E9D5B923B208D89BCADE8310E16E5C6F939228A9329DF55B6D22894247701D8948D5CCCB18765BA132934CA2D24E951DA4E952CFF0030B2291A9AAC6339E280AAF3F52E5800EEA53B00D086D3ACE8D64930E958AC8D59E39150ECB780F697FF007A9F40F8F59DB3866D771EA804029651DC4FF495EB1F84583593B038779018CA9484121752E01E22FA908F513CEA3DA3A80BACE87FA7D9182585DDD1CB60AA365595C60D586DEFA68E41B62C85F3A9278A5C914069DA1000ED5286BDE05871653E2AC768E8DC3F9E299E2FE774E275030EA554D968CD64685B82C96F4A2D1BD53D80C4FF00D48629383441068820D104575F55BD1F1CD5F9FB93B590DB6B2B7029FC9316451B45C94055522356894BE7EF93C039DBC175E78E62D8378A4BAD0ED6B1B7937F5C5EBC36E297F0E4A68312512CE8439A4B7EAAB5946C3A53A3BBDDA85C8F187D89122CB925A24DB6E30D452F4396D2E3CA617E050E04A927D0469A707C72BB047FC4A75149F3927BAADCA4FCB611A8C5EF8EE5CC2735D18454252EA34A16822F277B6B13E6B5275830DAC8C6ECD6C756AB9DE0F93DADC542407943C0815F886AE1A1CF78CE2ED04E1F45DBF39C513E103BA77798A8F9633D627C2CCB9979F52B16C4CF85A52D2523C750D8A02F9F284007688F97B2B622B0225A20F2B2DD791D94A2E1F742493F19D0CF0D5CAF78D4E2AF852CE94B49081E554874267BE0A8E34B385530A2C0694A1B4E85BEA538AE508BC65C8572F5613332EB709FC254B71C477340F2A07B894D06AC1C2F2EE1D858FD9994A4FA529ABDE54D5D315263B9C718C70935B52B58F467751EE2649E88D7820B65D1C5A4AB954E81EA0578157657D1A7A3A62351ED1E3BF2E4C68719BF364CC79B8F19AAD399C7541084D7D2A206BE120099D0208B7FCDF6A3657A11DACC472AC9B6D21EF86EEE532BD85B9D7DA2AD316588EA79FF002D85A1D6D0D34072A3D453AB3C79D23E6D7F4D5F578F542DB4385A69227D9EF11390B769E590D90B5484B29991330F8ED2BDB4BD6F74FD94BD946D5E3D86DF6CD225D9E4BF6E8EDA3EAF96DC74488D3614A4B4DB88484B89252491C0A55CC93C5B2BC54E075A9B8EA94932369D22722088F68BAEA6D114290A4B96DB8419ADB892F5B25B2FB6F23E695C7742C287A2A9A8D5A4A4DE491B475C378B23A3DEABBA85C97A7EC7F6AB716D16D62FD8C5DEFC2DB99E3EBA21D91125C371F6D719E35F2DD6D4D129AFAAAAF2ABB6A29FC0B096F105BACA8C9413349D84195A365B0E6F3850018C567757A69BDF4F99BFFD3FCCB17C6AC39CD8F2090DE332A745B7486AE1728EF192CAA0BEEA54D38A796494253CA546A9A85027D1A1AF456A3C54294A42936C89124912B46912D705F4149918E7EB6AB096B71738C530D9D90DBF11B7DE64B68BC64B7592CC48D0622073C8794E3EB4239C201084D6AA5D06AD6AEA934CCA9C092A2058009927568E9DD0DC84DE328BB8DEDDD1E96718C0B0ED8281BD9276F2CF636ED374B55C70B67EB8023DAE4799199912633525B056FB2975C068B59153C146B5B61B4388BAF2EA8B2164CC10BECDAA16C81235190D42172D68002672E4848F5F385E3FBE1D3EE21D416DF4945FDBC41099CDDDA3B4B42A5D82E052DC8250B095A7C87821C2950AA0072B4E3A51956A57435ABA476CBD64B62C68E7167347CA8485A2F08A3DD5970820D1045C0F479D276D26E0F4D971CEB7670A7AFB3EFB73B9CEB1DCA13921AB9356E80911D2888632D2A515BACBAA0820F312381D57D9831DA9A7AF0D30B9000020CA5336DB3DC442C6594A9132222F667B13D325D2CB925EF6BB7FE66277CC72DF2AE32F6AB722DAB8178518ADA9C319952D1154B75453C894A5B72AAE15D3DD36295E85A52FB01495102FB6669B759D3679447253689587C8620F03500914A8E235268E119D0EE53EDEAE68729C63C500D527DD49A8F8B4D38A6054389A6ED53295EF23B4391424A1CF0FF81E69C53045DEA1A85B7B819A0F2A0CD079A1423228370486EFD6B43E7B04D8E395C1E9A56BF01F7B5095648AEC2D45CC1AAD481F9A73B4D9DD3975A67EB45988E276198E243598E810E1D1E333D8746F94C13C8172F56167604D8DB60A2CEE21C52855E2A3F9E3F840D0FC54D5559D178E3AFDEC4D0A481DD90FB21EC9134CCED26F45EFC366F2BB14C5182389528DAB2A3FB41F6C2805003500023AE2D57A3AE97316C818B76EB66977B565098CB43D63C3E0C86A5B519E1EB25773E42A01C4F6860F676AEBF3421C1B0A42C079641D805BEF7CD108E2A7116AA954AC36910B6A762DC50292A1AC353F34EB5EBF376C5ACEA5919B60D1041A20834410CCEE86FF00ED5ED0B2E0CC3276517608E6671B854957172A2A9FCC20D5015DCA70A53E9D22ABC458A61DB55BB35C4B32EE49C5B1E50FC2B26E6B5ABB2D8FA474CB6266774557EF57DA37975ECCBB46DCB09C26D8AAA04B68A255D9C49E1EB3C41663D7C100A8772F4BB0EC0719C6645A4780D1F3D76123D54F78F904BD689B2F0ECA5953FEE0F1AEAA1F926BEED276295397BCAFF6715BD92EE1E5394DC25DCAE97593266CD5734B9F21E5C894F1ECAB8FBA54B51A7A756160FC39C3688871F9BEE6D5F767B91A3DEBD119C778BD8B56B7F87A209A3A716043224A96F5C811F4022110A5294A2A528A94AE2A513524FA49D4F92908484A40006802C03904558E2D4E28AD64951B492664F293698FCD7A8F316F7D1C74A9B179D6CCB3BCD78B24DDD2CC630B8B6F60F709423DB19B9DBCACB71034CA473F9A9F2D5578AC5160F2776ABFCC38ED63155F864A8368B3B404D574EBB765BA25A34C2C65A494DED261EEE8F7A92C73A8F7F3ADA4C8766F1BC32D966B6227C0C66DCC21EB7BD014E88CFB12585B28405B6B5A3B1202AA780E5D36E60C1D786845421E52893299D33D208338E8CBA173128A74DF6C4ED3B6FBE1B9988628F16ECF8964D258B0282FCC5476DB5875A6B98D492C157254FD1E3AB0B0B7D55348DB8E695244F7FF00F3A611382EA881161F74EBBBA7FDE7DB1B761FD486D2DF6F77682A664494D9BCA5467273082812E2BE25C47D82B0A5553DC094D5435124657ADA2A82E51BA900EDD32D8448830A4D421424A10C36E075A90E2EDCCDD9AE9C76DD9D97DBEB8A5E6EEB7053FED17794892395FA2D2541B53C9A256E29C71CA700A4F0D3A5265C25F15158E78AE0D034244B472CB64808E6A7ECBA91211026894809E0120500F46A5322613120698D9CA9F79BBB81C9F3EE177740012B92F3D25400E0285C528E93ADC669C768A5037909F9A14314CF541934852CFAA92AEA063C53689EE9E74DB1F59FA5E4AABF0D3485CCC18735DFA9687D34FCF0F2CE52C65FFBBA37CFFB25FCD1EE6C97650A1B5C850F02D9D2639AB081FF0034D7BE2158C87980FF00C83FFD9ABE68F9165BA36282D72103B681A57C835ED39A30A568AA6BDF4FCF1E179231E469A17FFB357CD192CCCC8EDAC3F163CDBADBE2496D4D4A8AD3D21965C6D628B43884A8254950E041143A58DD7D13E45D71B51D525249EB86B7F05C429C12ED3BA91BDB58EB11A5ECE1D87C34E12D70D44C8CA035A1A7034E04F8E88FB16A29EBAF09C73A5283B59B5B1B20C1F73F1DB3DAECD679CE32C96B9DB71B33A7312595389E6500E2B95C42492AEFE3A83FF961D73112FBE52B6D4493F20239B442BFC400890D310CF757A9DDD4DEBC4AD58A6E43F66BEAECF3D13A2E508B63116EAA0DB6B6C4771F642525AAAF9C84A135501527522A1C169E89C2E333131294C94F2C8EB8E0B754B1230EEF421D3E623BF5B97900CF5A5DC313C1AD8CCF976143AB644F9329D534C36EADB52561A4842D4A095024F28ECAE9BF3462CED0309F0AC52CCA7B00D3E58F74ED859B62496E637F67BDCF75A76C4CBDBDB960979837045815B9B8EFF338116E6486FCA7017D61610EA836B71C8EA48556A79415699E88E349A61541C0B045EB8AB494F36CB640C75578455765104FA96E9E320E9C33F462973B826FD62BCC6371C4725423CBF6B8817C8A4BAD82A0875A5502C024714A87055049F06C5D18933E2244940C94361F98EA84EEB6506511E52A521495A1450B4F14AD24823DC234E8E36971250B00A4E9044C1E506069D5B2B0E36A2950B4104823908B4439D836EFE77B7B7466EF8DE413AD9399A01321BEB61E2906BCAB52383893DE95820F7EABFC5B8714152A2E52134EE7AB6A0F2A357D123922D2C2B8B35E96852E2AD22BA9F638078837A5C969D85409F5845A16CBFDA52FAFD92CFBB1674DDD1EAA1590DB5088D3871F9CEC5252CBBE92DA91F824EABFC470AC570799AA6BC4687E51BB472A8694F9401CB0F48CB997732DB8354F80F9FF0097A83299D8DB96DEDD6ACF2459F6DFEEA6DFEE8DB7EB3C1728857E69090A9515A5724A8F5EE7E33812EB7C7E92457BABA4D4D56D54266DA81FE5B22098E65BC470577C3AD654D9D44F755ECA87655E43CB0E0694C31C438DEDC57ABBCBC4C818064D8AE2B8E39CC94316C972D8BB3A8EE0B98EC6A209FF004451E9274CD5CD573B636A481B899F3CBAA2D4CA38964FA0BABAD69E75DDAB4A4B40EE4055BF4AF724561E69D19F522E2DF7AE387DD2E0A7D4B724CBB74F87354F289AA94E04BCA7544FA7B75CB03A9ABC19D2EFE15B755E92FB4A1ECC95672DD9EF8B3F1FCC396B33538A7189BB4CD812B8805B411B140A2D1BAFDDDD11A6FF00D3BEE5E3A562E9896416908241370B44B613C3C17C9CA7DED584C715949FDE68D637A4CFA14075C576E70668AA44F0EC5987372A53F814AFAB0D948C36F91D4A4869B78A490A4A174208EE217CBA7DA5E2760AF58B52DB3EB20F5A6F4325770473253DADA1B787A8E0EA5DC8D24BB65C2000A9911C8E951A256A1EA93E008A8D4AF0DC7A83122452BC870813201B40DB23232F2440B1ACA98B60C02ABA99C6924C8150EC93B0284D33DD38C1D3BC47E2C6BA04EA770DD8C3B978F6E65E9CB4627778CC5EECAEA597A4A8DCA39F21D8ED32CA164ADF694823801F9BE27510CD582BB5DE1AD91350323A0764DB3B761EB8534EE844C1832DEB8314C31397DBBA57DA483B66FE652DF957FDC6BAA10F5DE4B921D5BAB5B71C29D4374538A280B7569457D56D3A18CB4E3D70D73A577448247744B7F5C809ED814F813B82515E2E2EE3789D2653CB9374B94E797226CA70A9E79E79D515B8E38B352A529449249E27525A9AAA7A26EFBCB4B681AD44247927F247BA0C3AAB1077C2A6696EACEA424A8F468F2C6FA3E23715A0BD35D66DAC278AD6EA81501E90380F7CEA095DC4BC390BF0A912BA870E8080402794DA7C89316AE19C15C61D6CBF882DAA3685A4B8A05406F093747D25A632044C420FFBCCE7AE6E0ED4B4084FE4D07E56912B11CDF897DC53B74C93AD64157C533F008724E0FC3DC1ACAAAB76B5C1A4360847C1747F7A6242ECA617B379D5F116ACBB3C6F6EA2C82845BAF1F56266C753AA34F2E4BCB79B31ABDCA5A4A7C549D5698B54E36D5478189D43CD93A2D3715C8524265C9E5945AD4E303461FF008DCB98753D584F78090791CA95A54B2774C13E6DE8B54C77ECF2D9D6586A4DCB2EC932265F6D2E30E4691162B0B4A854292596144820D4517AE09CBCCAED5AD4AF2FFF00315DD571BF174128629D966561175448DD6903A21C981D0D74E90D094BD8ADC2E6A1DAECBBB4E2A3EE86DD6C7C5A509C02913E693E530C8FF18F32BA661E4A791B47CA0C57DEF1DF366F6AB73B2FDBEB774E98EDE61633259618B9CCBCDE03EF072334F92B4A5F20105C2381D47AB574F4EF29B0C832DEAD9CB176E55A4C6B1BC2D8AE7314750A70125296DA90928A6CECEE84EE1D93EDE6E16416FC571EE91AD97DBF5C95CB1A15A724BCC75048F9CE38B529486DB476A96B2123BCEB932E34F2C2134E093B14A85D8AE1F896154EAA97F1A5A1B4E92B65A57900902547501698DBEFEC5E96B6E217D4D65C765CDDC4659E4C82359B239326C769974E2C99721952E53883DA84213E0A524F0D3823086EADE14F48D15BC7524CD29DE544681AC990DF0C183E65C75AA756218A55A19A007B2A75A4A5E786ABADA0D97B57789D408B62BDA4E5D01E74A576544A8E3873BBCBCE7D34E5207C3AB3F0FE19D7D334149AF536EEC45EB8374EF027965105C5F8D784D63E52BC290F31B5CB9E21DF2B8A0392F4F7C64C3B7582FC92B62D52A057B1F40E56EBE835293F06906278DE3F969412F5632FFA8AB5C96F124AC7BD0E982659CA79D50574D87D4D2FE9122EB53DCA9A9B3E44C62CBC1DE4D55066A5DF06DE1C87F19351F169C30DE2E30B90AC60A3D641BC3DD323D261A31AFF004FB54D82AC3EA92E7AAE8B8AF793793CE130939B6AB8DBCFF3C88E349EE769CC83FBA151AB230ACC587E283F65792B3E8E857BA64AE88A6B1EC9F8BE067F6EA75B63D295E41FA699A7A670F674E5BFF9274E7B86D66B63868BCDB674736FCAB1C757E52274252C2E887005796EB6A014DAA878D41052A3AEB8C614DE22C784A3222D0761F9B6C47DA70A0CC44D2363FB3E37CB34BAEE8DF773AF9B6B2B25764DC32BDB8BAB8980837092145D7D993E4BC9A1715E672B4F29255DC904A751CF171AA1683096D2B09904AC5B60D5298E4B4477934B339CA2BDB7418B05AB2CB9E3185EE1CEDCAC0B1F90B46277F98DBF1D05B78254E86A3BCA211EB009529094A5CE50A09029A965115ADB0B71B0859EF0123D23F9084CB94E40CC4242D564B95EDEF22D91FDA5DE6423901152A59A2401DA493E034DD8DE64A1C1824D5288BF3BA024A8994A7A06F1A4889365AC9B89E622E0A142541B95F2A5250137A7226F19CAC3A01D10FDE31D286F8656506DBB7F7D71A58E64BFF57BED3441ECA3D212CB7F95A85D47139B3653523ABDEA9207F48C4D5BE1753535B88E2B4AD6D4A09797CC2EC486C63ECE1DEDBAF22EE96B83624A805055D2E6CA7DEE48224AC1F774C5519EB1EA8FBA6DA647BE7A491F0C2E6F07C85416BD515354A1A923C34F520FC712B76F7ECF8CCF169F0AECADE418ADCADC42A1CBC79892EC841EF0990EBD1D4077761AF86A14E6155150F97DD70059B4DC484F426E8E8B625751C5DC31AA2142C50A9D640949F72FD9BEF7884EEED59AA26E7FD34DCAF23CAFFAF37CF37EA7FAAFDA7EAAB5F379BE7F9BEDB4F2797CEF2FF355A7CDE3F3BD6D397E19E97DE9D12D039F9754563FE60C32F4FF0087372BF7E5E239A252B9DE9DD9F6B96CEED90F869744420D1041A20848645866097B8B29DCA714B1DDE2A10A765B972831E4242520952945D42BB00AD75C5C61A58EDA41E5021D28715AFA65014CF3883A05D5293E4B0C72FF00BDB905AEFD9D5FA4D86DCC59EC72EE53275B2D315B0D311E3BEF28C769084801210DD0529A9870AF0E4866A2B652F117753B928B4FC47E18B1B8D38A3A834384ADC2B530C85B8499953AB004CED37524FD3867B56CC5184CA37D6BC6AF1765B488B0D612F2825B716080A24D0048A15289F40D45319CEB85E1534B8EDE707988EDABCB2B13E52227997386B8E638038D33E1B5F9C77ECD12DA27DA57D1491BE26C6D3F411BBD9F08D3A7D90E3768782562E97F2B848524F1AB715215257C388252949F1D5795F9F317AF9A691B14E83E72BB4BE9121EE9E589BA32D64FCBB6E2150AAE7C7E4DAECB40EC2A06D1F4E7EAC4F189F66EE1913149105ACF2E08CB5402A2DD5A88CB76E4280E2854304B8A04FDF79D5F477187D6612E5612BA8796E39E928CFA0FC861D2838C870E752DD250B4D528D2DA2C59DF7C0027CA83CB100F77BA7DDCAD9A96B6730B1F9F64797E5C3C9E15645B6457B0798520A147E83894ABC011C7517A8A2A8A158519891B140F51168317B65DCE384E6664A59502A23B4D2C0BD2D73499852778BC36C461BBE1F1E4053F6C222BFDA639FD12BDCFA3F73563E59E27D45290CE21375BF4C7DE2797D31F16F315AE75E07D2570554611265DD3E19FBA5FB3ADB3CE8DC9D30824AAE3669869E64296D70524F78F023B140FC1AB956DE1D8FD1DB75E655A371DDAD2A1E42233834F62F94F119A6FD3D4A348D131BC775683E549D513D7A62EB632EDA57A1E377A2BC8F092A09731A7DDA2E30278AED8F2C9F2CF1A9655EA2BBB949E6D53D8EE53ADCBE4BD4F37A9758F3DB1BF68F5859B40D316F5362582F10406EA6ED1E29A962C66A0EC3B14761ED7A257DD8BCEDB9DCCC2F75B1C8F946117A6AED6D768892D0F524457A955312593EB36E27BC1EDED048A1D37D2D537528BED998EAE58AC31ECBD5B81D49A6AC6CA16347A2A1E924E850FFE0C8D91507BDDB5B916E5F537BC6603B1AC98CD826449397E6F7457936CB4C6F608C4ADF74D399647CC6D3EB28F80A910EAFA55BF58E4AC482264E8160FE528D4394331D360F96286F82B75C4A836D22D71D55F55891A87A4A360E5B21A3CFF00A81C576C71DB86D96C0A24DB6DB706FC9CB7711F1E55FB22501451E7145428878F2369F5CA7B796AAACAB2D656A9C63B34D36E9F429E23B4BDA1035F50D675444F35661A7C21D4D663853515C2D668D066CD3CF429D3682ADAA3324F74112220BCA9970BD4A405F348754691E3363D54D7B929EEF49F87579E1B8561D9769086E4DB604D6B51B55BD4AD7B868D4045078CE3D8C670C4125E2A79D51936DA01BA99F9ADA356F51B75A950B6B3E1ED33CB22ED47DDED4C349F513F867EF8FA3B3DDD54F9A38A0E3D3630D9A13A0B87BE7D81E68DE7B5ECC5F791F81ECD35DA9C664E39A4320FD9A7F58AF3CFAA3B1B4AA256ECF74E5B99BCD21BFD56B28818EB4BF2E5655700A62DED049A14B6A092A7543E8B69553BF9471D5634D41515AB2AB4CCDAA3B797493169664CEF84E596821D50BC0765A4017A5ABB224109E590D938B5EDA0E8C76A36C911EE37A869DC0CA50015DD2EECA5511A5F7FB3C2256DA7D05656AF023B352AA3C15862D50BCADA74790466FCD1C57C5B1825B695E033E8A09BC7DA72C27913746E3195B87D176C6676DBEEC4C795845D1D4AB967D81423B5CC7B39E22829822BDA128493E3AF4FE0D4EE1BC917143414D91C706E2B639878B8E381F68E94BA2FCC7B5DEE72A1BA2B6F77FECE8DC3C604AB961619CE6D68AA92AB5A7D9EE094F6D5C80E28A57E1F9A5A947E88D3EE1F9A71BC2A40A854B4352FBE06E577B9EF7243B2FF00C979A3EF50AC3AA4F9C891649DE3BBD0DFB515E790611916392E4C3B85BDF6DF86B2894C2DA5B4FB4A1DA1D65602D247B9AB1304CFF86624436A5165DF45CB2DF555DD3E591DD111CC7C29C6309478EC81554FA438CF6ACDAA4778728BC9F5A125A9C45690BEDB5BECAC7F2BB75C6139E5CB88EB52E1AC70A3F11C4BCD9A8E22853AADB8A3445DC2D3509EF32E057915D93D3762E3E09572538C3B42E772A995A08DA522F0F86F8F2C756F8DDEE364B8ED8722874F64BF5BA2DC6350D7F3729A4BA9F895A8134B0E20286B00F3C402BE9154752E30BEF36A524F2A491F246EB5EE1241A2083441068820D1041A2088A9D646E4A76F364AFEC467BCBBD66DFF00EDEB58068A0892857B5B9C38D12C058AFD25274D38CD4F834E40D2AB0797F9A2C8E15601FC571C6D4B1F66CFDAABE8F747BD23C80C73D366DBFCBB70723316CB68993A6DCDE220DBA2B0E4894E24704F232D82AA529C4D356053E73C3B00A06686981A879090084776F9B5535FB44F742A1DF12E1F62999712A9C5F105A68A956B2429E325F863B28937312EC812BE53C862C7766FECDCC92E3EC976DCAB8358842572ACDB5BE49B75583C4834263C724761AAC8EF4EA2988E358CE3130FBBE0B47CC6ECB3D65693E532F563EA319CA995ECC329CD6548FCB3DDC076A132EA4A772CC59D6D9F4F5B4BB4C865DC4B148FF5BB49E556493FF9DDC147BC879C1F9BAF7868207A348A970E629BB89B769B4C43730E79C5F1D24553C6E1F313D947BA34FD2BC77C3D5A5D1118344118572B6DBAF3025DAEED063DCED93DB53336DF29B4BCCBCDABB50B6D60A540F811AF2A48509113063B53D4394EE25C69452B499820C883B411A22B537E7A0C8B2933728D9358872BD67A560529CFCCB87B4FB0C859F50F836E1E5F05A4513A8CD7E000CD6C7BBF345FD9338CEB45DA7C5ED1A03A05A3F5891A7DA4DBB5274C55565588CA87366E3F945A64DA6F16C714CCA8729B5332A3383B414AC023DC3C0E916098FD76055056C197A483DD56E50EA22D1B62E1CC196708CE14290F00B49136DD4117913D6855B66D499A4EB13865EF163996773F383CD8AB3F999691C0F8057D13AD1B96337D1E3ADFD9F65D03B4D9D237A7D24EFE70231EE77E1EE21959EFB617D851EC3A91D93B02BD05EE3A74A49877B6677EF38D9EC9235F71CBD39024A795A92575723CA601AF91359A80EB7E07E727B5241E3A8A667C804ACD66152439A54DE842FD9D493EAF74EABA625B96B88D4D88532709CC892EB1A10FFE5593A0151D240F4AD207782C6873BA8BEAC32CDE298A831D8898E63E1D44C731EB59AC55CE2DA50B9921CA24C97CF280952C510901238824B4E5BC90FE28A1538924B6D0330D6852C8F397AC0DDA48D834AFC633661F93DB3478239F88AB29BAAAA54941A41B436C0B533B6648ECDE99333626275BAD73EF52541AAAAAAE6932DCA94A6BDEA3DE4F86AC9C733050E5FA605D90B2486D329AA5A9235246B3A072D915C657CA58A66EAD52589AA666EBAB994A67A4AD5A54A3A923B4ADC2D879B13C3E43F3A15931DB648BC5F6E8E263C5623B6A764C8715D88421009F786B39E61CD15D981E1E219227D96D3DD1FD657AC7C9211B072B64CC2326D2296895EBBF68FAE41446BB74211B123CB78DB16CDB07D07DBEDA98594EF5725D2E2425E8B8230BAC564F68F6E7907F3AA1DEDA0F278A960D35DB0FC00264B7ED3E8EAF2C54D9D78CCE3C554D84F653A0BA4768FEAC1EE8F58F6B604E98B25850A1DB6246816F88CC0830DB4B3121476D2D34D368144A10840094803B001A92A5212242C1141BAF2DE595AD454A266493324ED24E98C9D7D8E7068820D104355B95B29B67BB710C7CDF178D7196841444BDB43C8B8303BBCB92DD174078F2A894F8A4E925550B35224E267BF5F3C4972FE6EC53015DEA378A44ED49B5079526CF2891DF155FBE1F672E456B12EF5B672CE656E4F339F562F923DDDA48E200EC664D0787228F6041D77C3317C5B0390A673C5647E4D76CBD93A4790FD131602F1CCB19BACC599FC2551FCBB5DD51DAB16FC615FAC115A772C3B23C2AFC19B9DBE447916A92113E33CCAD990C1068B4BCC2C05A08078F0D4E3FCE187662A17A89CFB1796850B8BB26A94D3755A0F680B0C8EE86C6F2062B95312A5C529C8AAA54389578AD76BECE72515A04C81749B52549DF1D157465950CA7A7DC392B77CD958D2A558E51A93CBECAE92CA78F830E37AAD70477C4A54CF48B39BF9A1271630D145985F23BAE5D706FBC2D3EF0544A7D3B4571068820D1041A2083441068822286F1F4DAFEFCE7F67BA66D92B96CDBFC52279165C76D63F9E4B90FA92E4A79E7DC050D03CA940094A8909AD524E9A6B70CFC63A0AD52401601A4ED8B2B2AE7E4E59C3D6DD1B41552EAA6A5AFB894A6C4252916AB4954C902674187CF01DB0C0B6C2D9F54E0B8C43C7E32C0125E6525521F29EC2FC870A9D74FE128D3BB4BA9E95AA74DD6D20443F1ACC588632EF8B58F29C3AA7DD4FB29124A7C82179A510CB068820D1041A208344106882186DEEE9DF00DF2B5F977F89F5664B15A28B3E5F0D0912D8EF4A1CEC0F355ED42FD3CA524D7482BB0E6AAD3DAB15A8EBFE7899E51CF58865B766C2AF344F69B57755BC7A2AF5879411645256F4EC3E6FB31795D9332B62655A27A969B3E42C24AE04F6C7D0511EAAC0F9CDAA8A4F6F114518738CD4E18FA5C4929524CD2A4D9CC7AC7C91ABF01CCB84E6FA1521202D2449C6972244FD21AC7A2A1E42142C89B7EC5DD81CF2E0053D087171AED5B5FB29F4FC3ABD726F109AC4EED3561087F403A12E7F557EAE83E6EC8CE5C47E113D825EADC38172974A93A56CF2EB5B7EB694F9DE946BEC5607EF0E798A25882D9A3B23BD47E8A3C4FA7BB4F59BF39B180B77049750A1D946CF597B13B06956AB2D88D70F386F559A9EF10CDBA449EDB9AD5EA37B55B4F753AE6642249ED96D6E51B8B7E83866036454E9AEFACE1154B119AA80B9125E208420578A8F69E02A481ACE35353598CD5175D515B8AD24E803A9291A808D74E3B8464DC302404B2C234016A96AEB5AD5AC9E5240165E474FDD33E1DB176C4CA6928BFE75359E4BC656F228521542A62220D7CA6ABDBF7CBED51EC4A65987E18DD209E956B3F34654CEFC40ACCCAEDD3F674E93D96C1F8967CE5742756B264AE9CE201068820D1041A2083441068820D104345BA7B19B6BBC504C6CD71F6E44F6DB2DC1C8A2D18B8C6F0F2E424548078F22C291FB5D23ABA066A849C16EDD7128CB79C713CBEE5EA47484CED41B5B572A7E54C95BE10DD396C7DDF61A3E6D8B2EF8DE438ADD6E2CDD31A9A525A92DA96D169F6A435C52080DB74520D15C7827B35C30DA155205227349331FCF0EF9EF37B399954F521B2DBC94142C6949919A4A4E995AAB08B369D3125B4E710083441068820D1041A2083441068820D1041A2083441068820D1041A20834410688213597E1F8D6798FCFC5F2EB3C7BE58EE48E5930A426A2A3E6AD0A14521693C52A490A07883AE4F32879250B13061C30BC56AB0CA84D452ACA1C4E823A8EA20EB06C3AE2943A94E94F22D9598F64361F68C8B6DE5B948F76E5E67EDEA59A2589A12294A9A25D00255D8795440308C4F095D29BC9B51B7672FCF1ADB20F1229B312030FC9BAA02D4F9AE6D5227D28D2378B61B0D8DD83CC77BAFC9B4633105BAC16F5A7EBEC99D6C88905B571A0029E63AA1F35B49A9ED344D543953D354622E95289513DE52893D274987ACCD9AB0DCA5462F048323E1B480137B900B1299F79529729B22F4769767F0BD99C619C670F81E5F3F2B977BC3D454C9EF8142EBEE002BDFCA9144A47CD1DBA9BD1D1B74A8BA81CA7598C8599B3456E60AA35154AF6523BA84EC48EB3A4EB30E969544720D1041A2083441068820D1041A2083441068820D1041A2083441068820D1041A2083441068820D1041A2083441068820D1041A2083441068820D10424B3EFF00D13967F53FF54CBFFD41FD55FA257FBEFF00A1FA7E8D71A8FBB568D074E8F2EE873C17F7E67BFDF4FDDFDE69F33D6D9BE196E91BFF00E0BC53FF004EFCF93FFA6BF41FA53FEF3FFD47F19EF691611FBB27BBF47E5DFB625BC4EFFBEBDF7BA13F7BA7479BFA3F47CB125B4E715FC1A2083441068820D1041A2083441068820D1041A2083441068820D1041A208FFFD9)
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
ALTER TABLE [dbo].[REFEREE]  WITH CHECK ADD  CONSTRAINT [FK_REFEREE_SEASON] FOREIGN KEY([SeasonID])
REFERENCES [dbo].[SEASON] ([SeasonID])
GO
ALTER TABLE [dbo].[REFEREE] CHECK CONSTRAINT [FK_REFEREE_SEASON]
GO
ALTER TABLE [dbo].[ROUND]  WITH CHECK ADD  CONSTRAINT [FK_ROUND_SEASON] FOREIGN KEY([SeasonID])
REFERENCES [dbo].[SEASON] ([SeasonID])
GO
ALTER TABLE [dbo].[ROUND] CHECK CONSTRAINT [FK_ROUND_SEASON]
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
