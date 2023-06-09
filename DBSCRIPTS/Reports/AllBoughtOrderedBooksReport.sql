-- Raport wyświetlający sumy zamówionych i kupionych książek
Select cl.ClientId,
MAX(cl.ClientFirstName) as ClientFirstName,
MAX(cl.ClientLastName) as ClientLastName,
SUM(sod.Price) as PriceTotal,
sos.StatusName 
from Clients cl
left join SalesOrderHeader soh on cl.ClientId = soh.ClientId
left join SalesOrderDetail sod on sod.SalesOrderHeaderId = soh.SalesOrderHeaderId
left join SalesOrderStatus sos on soh.SalesOrderStatusId = sos.SalesOrderStatus
where sod.Price is not null
group by cl.ClientId, sos.StatusName
order by ClientId