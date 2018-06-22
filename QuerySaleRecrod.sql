
-- =============================================
-- Author:		<Author,,Name>
-- Create date: <Create Date,,>
-- Description:	<Description,,>
-- =============================================
CREATE PROCEDURE [dbo].[QuerySaleRecrod]
@alerttimes int
AS
BEGIN
SET NOCOUNT ON;
 with q as
(
select a.com_no, c.card_no, c.vip_name,   a.oper_date, 
b.item_name ,b.item_no,CONVERT(varchar, Year( d.[MaintainDate]))+'-'+CONVERT(varchar,MONTH( d.[MaintainDate])) Month1
 from t_rm_saleflow as a left join t_bd_item_info as b on a.item_no = b.item_no 
 left join t_rm_vip_info as c on a.card_no = c.card_no
 left join MaintainRecord as d on a.com_no=d.SallID
 --购买时间至今大于三个月
 where  a.oper_date<DATEADD(MONTH,-3,GETDATE())
 ),basicdata as 
 (
 --单个销售记录的维保记录
 select q.*,row_number() over(partition by q.com_no,q.item_no,q.Month1 order by q.item_no desc) RowNum from q 
 ),
 maintainence as 
 (
 select distinct basicdata.com_no , basicdata.card_no,basicdata.vip_name,basicdata.oper_date,
   basicdata.item_name ,basicdata.item_no,
   --计算保养次数
 case when  (select top 1 MaintainDate from [dbo].[MaintainRecord] where SallID=basicdata.com_no order by  MaintainDate desc) is null
  then 0 else  count(*) over(partition by basicdata.item_no,basicdata.com_no order by basicdata.item_no desc) end MaintainCount,
 (select top 1 MaintainDate from [dbo].[MaintainRecord] where SallID=basicdata.com_no order by  MaintainDate desc) LastMaintainDate
  from basicdata  
  --排除一个月保养多次的记录
  where RowNum=1
  )
  select * from maintainence where MaintainCount<=@alerttimes 
  and ((LastMaintainDate is not null and MONTH(LastMaintainDate)!=MONTH(GETDATE())) or LastMaintainDate is null)

END

GO


