/* Write your T-SQL query statement below */

with temp as (
    select id, country, state, amount, FORMAT(trans_date, 'yyyy-MM') as month
    from Transactions
)

select month,
       country,
       count(id) as trans_count,
       sum(case when state = 'approved' then 1 else 0 end) as approved_count,
       sum(amount) as trans_total_amount,
       sum(case when state = 'approved' then amount else 0 end) as approved_total_amount
from temp
group by month, country
