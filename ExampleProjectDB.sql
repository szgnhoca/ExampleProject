USE [ExampleProjectDB]
GO
/****** Object:  Table [dbo].[Articles]    Script Date: 5.09.2019 18:33:07 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Articles](
	[ID] [int] IDENTITY(1,1) NOT NULL,
	[Title] [nvarchar](100) NOT NULL,
	[CreateDate] [datetime2](7) NOT NULL,
	[ModifiedDate] [datetime2](7) NOT NULL,
	[IsActive] [bit] NOT NULL,
	[Content] [nvarchar](max) NOT NULL,
	[AuthorID] [int] NOT NULL,
	[SubjectID] [int] NOT NULL,
 CONSTRAINT [PK_Articles] PRIMARY KEY CLUSTERED 
(
	[ID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Authors]    Script Date: 5.09.2019 18:33:08 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Authors](
	[ID] [int] IDENTITY(1,1) NOT NULL,
	[Title] [nvarchar](100) NOT NULL,
	[CreateDate] [datetime2](7) NOT NULL,
	[ModifiedDate] [datetime2](7) NOT NULL,
	[IsActive] [bit] NOT NULL,
 CONSTRAINT [PK_Authors] PRIMARY KEY CLUSTERED 
(
	[ID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Subjects]    Script Date: 5.09.2019 18:33:08 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Subjects](
	[ID] [int] IDENTITY(1,1) NOT NULL,
	[Title] [nvarchar](100) NOT NULL,
	[CreateDate] [datetime2](7) NOT NULL,
	[ModifiedDate] [datetime2](7) NOT NULL,
	[IsActive] [bit] NOT NULL,
 CONSTRAINT [PK_Subjects] PRIMARY KEY CLUSTERED 
(
	[ID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
SET IDENTITY_INSERT [dbo].[Articles] ON 

INSERT [dbo].[Articles] ([ID], [Title], [CreateDate], [ModifiedDate], [IsActive], [Content], [AuthorID], [SubjectID]) VALUES (1, N'C# Programlama Diline Giriş', CAST(N'2019-09-05T02:53:53.7296424' AS DateTime2), CAST(N'2019-09-05T02:53:53.7314311' AS DateTime2), 1, N'Lorem ipsum dolor sit amet, consectetur adipiscing elit. Vestibulum nec eros ut lacus bibendum dapibus sollicitudin vel ligula. Morbi tincidunt, nulla placerat fringilla accumsan, ipsum felis lacinia mauris, quis posuere massa elit nec leo. Donec mauris lacus, bibendum ac odio quis, cursus volutpat purus. Phasellus pharetra arcu in pretium elementum. Pellentesque consectetur nibh a eros posuere sagittis. Curabitur pretium tincidunt purus, vitae venenatis sapien finibus quis. Phasellus vel sem dolor. Pellentesque ac erat lorem.', 1, 1)
INSERT [dbo].[Articles] ([ID], [Title], [CreateDate], [ModifiedDate], [IsActive], [Content], [AuthorID], [SubjectID]) VALUES (2, N'Programlama Dilleri', CAST(N'2019-09-05T04:32:42.9399587' AS DateTime2), CAST(N'2019-09-05T04:34:01.4898121' AS DateTime2), 1, N'Orci varius natoque penatibus et magnis dis parturient montes, nascetur ridiculus mus. Fusce aliquam, dolor non sodales rhoncus, nisi nisi viverra est, et molestie purus nulla at nulla. Maecenas dapibus ante vel neque scelerisque interdum. Quisque sed nisl consequat ipsum faucibus ullamcorper. Vestibulum id felis ut nisi laoreet consectetur non a urna. Etiam a urna tortor. Maecenas tempor dictum est a porttitor. Praesent vehicula, nunc a pulvinar rhoncus, mi sapien molestie massa, eget dignissim ex justo ut enim. Sed mollis, erat ac placerat mollis, ipsum est tincidunt tellus, nec malesuada lectus magna et purus. Nam ultricies porta consectetur. Maecenas feugiat turpis magna, ac pulvinar purus dapibus id. Quisque aliquam urna ante, non congue tellus aliquet eget. Aliquam vehicula gravida lorem eu laoreet. Quisque tincidunt blandit nibh eu consectetur. Aliquam lacinia, lorem et rhoncus accumsan, nunc arcu efficitur ligula, eget venenatis libero nibh nec eros.', 1, 1)
INSERT [dbo].[Articles] ([ID], [Title], [CreateDate], [ModifiedDate], [IsActive], [Content], [AuthorID], [SubjectID]) VALUES (3, N'Algoritma', CAST(N'2019-09-05T04:36:35.3143159' AS DateTime2), CAST(N'2019-09-05T04:36:35.3143184' AS DateTime2), 1, N'Cras cursus, odio tincidunt pharetra volutpat, risus quam ornare sapien, eget bibendum arcu mauris eu ipsum. Etiam quis euismod elit, vitae porttitor ex. Fusce in tristique neque, vel venenatis libero. Nullam non est non enim aliquam ullamcorper. Vivamus eu orci odio. Morbi quis vulputate arcu. Phasellus venenatis velit ac pharetra sodales. Vestibulum sagittis mauris vitae malesuada consectetur. Aenean semper scelerisque mauris id congue. In molestie, nisl nec accumsan accumsan, lorem augue fermentum ligula, eu luctus mauris urna in odio. Nullam at mi nec neque malesuada sagittis. Nullam aliquam faucibus enim eu finibus. Sed tincidunt lectus velit, at molestie mi dignissim vel. Aliquam ac sollicitudin leo. Class aptent taciti sociosqu ad litora torquent per conubia nostra, per inceptos himenaeos.', 1, 1)
INSERT [dbo].[Articles] ([ID], [Title], [CreateDate], [ModifiedDate], [IsActive], [Content], [AuthorID], [SubjectID]) VALUES (4, N'Fotoğrafçılık', CAST(N'2019-09-05T04:45:22.5829604' AS DateTime2), CAST(N'2019-09-05T04:56:09.6583856' AS DateTime2), 1, N'Duis convallis felis sem, id ullamcorper nibh lobortis ac. Duis accumsan lorem ex. Cras commodo, ipsum luctus suscipit vestibulum, risus nisl pulvinar felis, ut iaculis libero sapien non sapien. Nunc ipsum leo, convallis eu semper id, pretium et enim. Donec eget ex eget risus lobortis cursus non in odio. Ut non mi lacinia, molestie elit eu, semper ex. Sed mattis nisi quis lacus auctor porta aliquet ut nunc. Cras at turpis aliquet, tristique risus vitae, ullamcorper leo. Etiam venenatis lorem velit, ac rutrum lacus ullamcorper molestie. Donec elit risus, suscipit condimentum facilisis quis, tincidunt sed felis. Etiam scelerisque sapien vel est ullamcorper mattis.', 2, 2)
INSERT [dbo].[Articles] ([ID], [Title], [CreateDate], [ModifiedDate], [IsActive], [Content], [AuthorID], [SubjectID]) VALUES (5, N'Temel Fotoğrafçılık', CAST(N'2019-09-05T04:45:52.8394905' AS DateTime2), CAST(N'2019-09-05T04:55:14.1264678' AS DateTime2), 1, N'Ut facilisis accumsan sapien consequat dignissim. Nunc nec neque sit amet tortor gravida dignissim feugiat sed arcu. Nam ultrices posuere sem dictum porta. Sed iaculis justo a justo sollicitudin iaculis. Integer in condimentum mi. Curabitur consectetur mattis dui, vitae dignissim arcu rutrum non. Vivamus at elementum sem. Maecenas non congue nisl. Nullam eget ligula sit amet enim lacinia bibendum. Vestibulum aliquet pretium congue. Proin velit nulla, ullamcorper vitae nulla sed, volutpat lacinia erat.', 3, 2)
INSERT [dbo].[Articles] ([ID], [Title], [CreateDate], [ModifiedDate], [IsActive], [Content], [AuthorID], [SubjectID]) VALUES (11, N'Müzik.', CAST(N'2019-09-05T18:22:19.5952020' AS DateTime2), CAST(N'2019-09-05T18:22:19.5952056' AS DateTime2), 1, N'Mauris ut ultrices lacus, in congue leo. Etiam finibus felis sollicitudin, malesuada dui sed.Mauris ut ultrices lacus, in congue leo. Etiam finibus felis sollicitudin, malesuada dui sed.', 1, 1)
SET IDENTITY_INSERT [dbo].[Articles] OFF
SET IDENTITY_INSERT [dbo].[Authors] ON 

INSERT [dbo].[Authors] ([ID], [Title], [CreateDate], [ModifiedDate], [IsActive]) VALUES (1, N'Fatih EREN', CAST(N'2019-09-05T02:53:53.7317717' AS DateTime2), CAST(N'2019-09-05T02:53:53.7317725' AS DateTime2), 1)
INSERT [dbo].[Authors] ([ID], [Title], [CreateDate], [ModifiedDate], [IsActive]) VALUES (2, N'Ali Demirlenk', CAST(N'2019-09-05T04:47:05.5170442' AS DateTime2), CAST(N'2019-09-05T04:47:05.5170460' AS DateTime2), 1)
INSERT [dbo].[Authors] ([ID], [Title], [CreateDate], [ModifiedDate], [IsActive]) VALUES (3, N'Deniz Demircanlı', CAST(N'2019-09-05T04:47:15.3067442' AS DateTime2), CAST(N'2019-09-05T04:47:15.3067461' AS DateTime2), 1)
INSERT [dbo].[Authors] ([ID], [Title], [CreateDate], [ModifiedDate], [IsActive]) VALUES (5, N'Ali Selçuk', CAST(N'2019-09-05T18:21:05.7286243' AS DateTime2), CAST(N'2019-09-05T18:21:39.6135251' AS DateTime2), 1)
SET IDENTITY_INSERT [dbo].[Authors] OFF
SET IDENTITY_INSERT [dbo].[Subjects] ON 

INSERT [dbo].[Subjects] ([ID], [Title], [CreateDate], [ModifiedDate], [IsActive]) VALUES (1, N'C#', CAST(N'2019-09-05T02:53:53.7316112' AS DateTime2), CAST(N'2019-09-05T02:53:53.7316121' AS DateTime2), 1)
INSERT [dbo].[Subjects] ([ID], [Title], [CreateDate], [ModifiedDate], [IsActive]) VALUES (2, N'Fotoğraf', CAST(N'2019-09-05T04:46:49.1824678' AS DateTime2), CAST(N'2019-09-05T04:46:49.1824724' AS DateTime2), 1)
SET IDENTITY_INSERT [dbo].[Subjects] OFF
ALTER TABLE [dbo].[Articles]  WITH CHECK ADD  CONSTRAINT [FK_Articles_Authors_AuthorID] FOREIGN KEY([AuthorID])
REFERENCES [dbo].[Authors] ([ID])
ON DELETE CASCADE
GO
ALTER TABLE [dbo].[Articles] CHECK CONSTRAINT [FK_Articles_Authors_AuthorID]
GO
ALTER TABLE [dbo].[Articles]  WITH CHECK ADD  CONSTRAINT [FK_Articles_Subjects_SubjectID] FOREIGN KEY([SubjectID])
REFERENCES [dbo].[Subjects] ([ID])
ON DELETE CASCADE
GO
ALTER TABLE [dbo].[Articles] CHECK CONSTRAINT [FK_Articles_Subjects_SubjectID]
GO
