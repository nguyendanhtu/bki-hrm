USE [BKI_HRM]
GO
/****** Object:  StoredProcedure [dbo].[pr_DM_QUYET_DINH_Insert]    Script Date: 02/28/2014 03:15:12 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[pr_DM_QUYET_DINH_Insert]
	@MA_QUYET_DINH nvarchar(50),
	@ID_LOAI_QD numeric(18, 0),
	@NGAY_CO_HIEU_LUC datetime,
	@NGAY_KY datetime,
	@NGAY_HET_HIEU_LUC datetime,
	@NOI_DUNG nvarchar(250),
	@LINK nvarchar(250),
	@ID numeric(18, 0) OUTPUT
AS
INSERT [dbo].[DM_QUYET_DINH]
(
	[MA_QUYET_DINH],
	[ID_LOAI_QD],
	[NGAY_CO_HIEU_LUC],
	[NGAY_KY],
	[NGAY_HET_HIEU_LUC],
	[NOI_DUNG],
	[LINK]
)
VALUES
(
	@MA_QUYET_DINH,
	@ID_LOAI_QD,
	@NGAY_CO_HIEU_LUC,
	@NGAY_KY,
	@NGAY_HET_HIEU_LUC,
	@NOI_DUNG,
	@LINK
)
SELECT @ID=SCOPE_IDENTITY()
