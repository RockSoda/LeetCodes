/* Write your T-SQL query statement below */
select *
from Users
where email like '[A-Za-z0-9_]%@[A-Za-z]%.com' 
    and left(email, charindex('@', email) - 1) not like '%[^A-Za-z0-9_@]%'
    and right(email, len(email) - charindex('@', email) - 1) not like '%[^A-Za-z.]%'
    and email not like '%[^A-Za-z0-9_@.]%'
order by user_id