--agent-product table
select a.user_id agent_id,
       a.first_name agent_name,
       a.customer_code, 
       a.date_created creation_date,
       a.w_prd_code product_code,
       a.w_prd_desc product_desc,
       a.account_no,
       a.acc_branch, 
       a.status,
       a.ref_num,
       a.rm_code,
       b.last_txn_dt, 
       b.channel,
       c.bm_name,
       decode(a.status,
              'A',
              'ACTIVATED',
              'B',
              'BLOCKED',
              'L',
              'BLOCKED',
              'F',
              'NOT ACTIVATED',
              'NOT ACTIVATED') STATUS               
   from unionceva.agent_customer_master@cevadb a
   left outer join
    (select user_id,channel,max(txn_dttm)last_txn_dt  from
    (select distinct user_id,channel,txn_dttm
    FROM unionceva.Wallet_fin_txn@cevadb 
    where reversal_flag = 'N'
    and substr(txn_ref_no, 1, 1) <> 'R'---AGENTFUND--trans_type
    union
    select distinct userid,channel, trans_date
    from unionceva.WALLET_AGNCORE_TXNTBL@cevadb
    where resp_code <> '00')
    group by user_id,channel)b
    on(a.user_id = b.user_id)
    left outer join
        new_branch_map c
on  (a.acc_branch = c.br_code)


