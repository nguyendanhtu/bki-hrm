USE [BKI_HRM]
GO
/****** Object:  StoredProcedure [dbo].[pr_V_GD_QUA_TRINH_LAM_VIEC_By_Ma_nhan_vien]    Script Date: 02/21/2014 20:04:26 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE   Procedure [dbo].[pr_V_GD_QUA_TRINH_LAM_VIEC_By_Ma_nhan_vien]
@MA_NHAN_VIEN NVARCHAR(200)

AS
	SELECT * FROM V_GD_QUA_TRINH_LAM_VIEC gqtlv
	WHERE 	
		gqtlv.MA_NV = @MA_NHAN_VIEN
