USE [BKI_HRM]
GO
/****** Object:  StoredProcedure [dbo].[pr_V_GD_CHI_TIET_CAP_BAC_search]    Script Date: 09/13/2014 01:08:36 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
ALTER  Procedure [dbo].[pr_V_GD_CHI_TIET_CAP_BAC_search]
@ip_str_search NVARCHAR(250)
AS
	SELECT	*
	FROM	V_GD_CHI_TIET_CAP_BAC V
	WHERE 	
		(
			@ip_str_search							LIKE	''
		OR	V.MA_NV									LIKE	'%'+@ip_str_search+'%'
		OR	V.HO_DEM								LIKE	'%'+@ip_str_search+'%'
		OR	V.TEN									LIKE	'%'+@ip_str_search+'%'
		OR	V.TRANG_THAI_CB							LIKE	'%'+@ip_str_search+'%'
		OR	V.MA_CAP								LIKE	'%'+@ip_str_search+'%'
		OR	V.MA_BAC								LIKE	'%'+@ip_str_search+'%'
		OR	V.MA_QUYET_DINH							LIKE	'%'+@ip_str_search+'%'
		OR	V.HO_DEM+' '+V.TEN						LIKE	'%'+@ip_str_search+'%'
		)
	ORDER BY  MA_NV,TRANG_THAI_CB desc, MA_CAP, NGAY_BAT_DAU DESC 
	
	
