-- Raport wszystkich wypo¿yczonych ksi¹¿ek
Select cl.ClientId,
MAX(cl.ClientFirstName) as ClientFirstName,
MAX(cl.ClientLastName) as ClientLastName,
rh.RentDate as RentDate,
SUM(rd.PenaltyFee) as PenaltyTotal,
rs.StatusName 
from Clients cl
left join RentHeader rh on cl.ClientId = rh.ClientId
left join RentDetail rd on rd.RentHeaderId = rh.RentHeaderId
left join RentStatus rs on rs.RentStatusId = rh.RentStatusId
where rd.PenaltyFee is not null and PenaltyFee = 0
group by cl.ClientId, rs.StatusName, rh.RentDate
order by ClientId
