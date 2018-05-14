namespace DataRepository
{
    using System;
    using System.Data.Entity;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Linq;

    public partial class Model1 : DbContext
    {
        public Model1()
            : base("name=Model1")
        {
        }

        public virtual DbSet<cw_t_select> cw_t_select { get; set; }
        public virtual DbSet<cw_t_sup_info> cw_t_sup_info { get; set; }
        public virtual DbSet<cw_t_system> cw_t_system { get; set; }
        public virtual DbSet<dtproperty> dtproperties { get; set; }
        public virtual DbSet<mess_t_mess_flow> mess_t_mess_flow { get; set; }
        public virtual DbSet<mess_t_mess_record> mess_t_mess_record { get; set; }
        public virtual DbSet<mess_t_sys_system> mess_t_sys_system { get; set; }
        public virtual DbSet<mess_t_vip_message> mess_t_vip_message { get; set; }
        public virtual DbSet<sys_verfile> sys_verfile { get; set; }
        public virtual DbSet<t_bd_appitem_info> t_bd_appitem_info { get; set; }
        public virtual DbSet<t_bd_auto_subno> t_bd_auto_subno { get; set; }
        public virtual DbSet<t_bd_base_code> t_bd_base_code { get; set; }
        public virtual DbSet<t_bd_basecode_type> t_bd_basecode_type { get; set; }
        public virtual DbSet<t_bd_branch_area> t_bd_branch_area { get; set; }
        public virtual DbSet<t_bd_branch_group_info> t_bd_branch_group_info { get; set; }
        public virtual DbSet<t_bd_branch_info> t_bd_branch_info { get; set; }
        public virtual DbSet<t_bd_branch_info_weixin> t_bd_branch_info_weixin { get; set; }
        public virtual DbSet<t_bd_branch_item_info> t_bd_branch_item_info { get; set; }
        public virtual DbSet<t_bd_city> t_bd_city { get; set; }
        public virtual DbSet<t_bd_deduct_condrcd> t_bd_deduct_condrcd { get; set; }
        public virtual DbSet<t_bd_export_format> t_bd_export_format { get; set; }
        public virtual DbSet<t_bd_item_barcode> t_bd_item_barcode { get; set; }
        public virtual DbSet<t_bd_item_barcode_breakpoint> t_bd_item_barcode_breakpoint { get; set; }
        public virtual DbSet<t_bd_item_brand> t_bd_item_brand { get; set; }
        public virtual DbSet<t_bd_item_brand_breakpoint> t_bd_item_brand_breakpoint { get; set; }
        public virtual DbSet<t_bd_item_cls> t_bd_item_cls { get; set; }
        public virtual DbSet<t_bd_item_cls_breakpoint> t_bd_item_cls_breakpoint { get; set; }
        public virtual DbSet<t_bd_item_cls_weixin> t_bd_item_cls_weixin { get; set; }
        public virtual DbSet<t_bd_item_combsplit> t_bd_item_combsplit { get; set; }
        public virtual DbSet<t_bd_item_combsplit_breakpoint> t_bd_item_combsplit_breakpoint { get; set; }
        public virtual DbSet<t_bd_item_contract> t_bd_item_contract { get; set; }
        public virtual DbSet<t_bd_item_info> t_bd_item_info { get; set; }
        public virtual DbSet<t_bd_item_info_breakpoint> t_bd_item_info_breakpoint { get; set; }
        public virtual DbSet<t_bd_item_info_weixin> t_bd_item_info_weixin { get; set; }
        public virtual DbSet<t_bd_item_setup> t_bd_item_setup { get; set; }
        public virtual DbSet<t_bd_item_setup1> t_bd_item_setup1 { get; set; }
        public virtual DbSet<t_bd_item_update_flow> t_bd_item_update_flow { get; set; }
        public virtual DbSet<t_bd_payment_info> t_bd_payment_info { get; set; }
        public virtual DbSet<t_bd_payment_info_breakpoint> t_bd_payment_info_breakpoint { get; set; }
        public virtual DbSet<t_bd_place_info> t_bd_place_info { get; set; }
        public virtual DbSet<t_bd_place_item_info> t_bd_place_item_info { get; set; }
        public virtual DbSet<t_bd_supcust_area> t_bd_supcust_area { get; set; }
        public virtual DbSet<t_bd_supcust_cls> t_bd_supcust_cls { get; set; }
        public virtual DbSet<t_bd_supcust_info> t_bd_supcust_info { get; set; }
        public virtual DbSet<t_bd_supcust_item> t_bd_supcust_item { get; set; }
        public virtual DbSet<t_bd_supcust_saleway> t_bd_supcust_saleway { get; set; }
        public virtual DbSet<t_cm_da_jxc_daysum> t_cm_da_jxc_daysum { get; set; }
        public virtual DbSet<t_cm_fm_charge_detail> t_cm_fm_charge_detail { get; set; }
        public virtual DbSet<t_cm_fm_charge_master> t_cm_fm_charge_master { get; set; }
        public virtual DbSet<t_cm_fm_recpay_detail> t_cm_fm_recpay_detail { get; set; }
        public virtual DbSet<t_cm_fm_recpay_flow> t_cm_fm_recpay_flow { get; set; }
        public virtual DbSet<t_cm_fm_recpay_master> t_cm_fm_recpay_master { get; set; }
        public virtual DbSet<t_cm_im_branch_stock> t_cm_im_branch_stock { get; set; }
        public virtual DbSet<t_cm_im_branch_stock_fix> t_cm_im_branch_stock_fix { get; set; }
        public virtual DbSet<t_cm_im_check_detail> t_cm_im_check_detail { get; set; }
        public virtual DbSet<t_cm_im_check_init> t_cm_im_check_init { get; set; }
        public virtual DbSet<t_cm_im_check_master> t_cm_im_check_master { get; set; }
        public virtual DbSet<t_cm_im_check_sum> t_cm_im_check_sum { get; set; }
        public virtual DbSet<t_cm_im_flow> t_cm_im_flow { get; set; }
        public virtual DbSet<t_cm_im_sheet_detail> t_cm_im_sheet_detail { get; set; }
        public virtual DbSet<t_cm_im_sheet_master> t_cm_im_sheet_master { get; set; }
        public virtual DbSet<t_cm_pc_price_flow_detail> t_cm_pc_price_flow_detail { get; set; }
        public virtual DbSet<t_cm_pc_price_flow_master> t_cm_pc_price_flow_master { get; set; }
        public virtual DbSet<t_cm_pm_sheet_detail> t_cm_pm_sheet_detail { get; set; }
        public virtual DbSet<t_cm_pm_sheet_master> t_cm_pm_sheet_master { get; set; }
        public virtual DbSet<t_cm_rm_payflow> t_cm_rm_payflow { get; set; }
        public virtual DbSet<t_cm_rm_payin_detail> t_cm_rm_payin_detail { get; set; }
        public virtual DbSet<t_cm_rm_payin_master> t_cm_rm_payin_master { get; set; }
        public virtual DbSet<t_cm_rm_protion_flow> t_cm_rm_protion_flow { get; set; }
        public virtual DbSet<t_cm_rm_saleflow> t_cm_rm_saleflow { get; set; }
        public virtual DbSet<t_cm_rm_vip_acclist> t_cm_rm_vip_acclist { get; set; }
        public virtual DbSet<t_cm_rm_vip_info_edit> t_cm_rm_vip_info_edit { get; set; }
        public virtual DbSet<t_cm_rm_vip_savelist> t_cm_rm_vip_savelist { get; set; }
        public virtual DbSet<t_cm_sys_oper_grant> t_cm_sys_oper_grant { get; set; }
        public virtual DbSet<t_cm_sys_pos_status_history> t_cm_sys_pos_status_history { get; set; }
        public virtual DbSet<t_cm_vip_sheet_detail> t_cm_vip_sheet_detail { get; set; }
        public virtual DbSet<t_cm_vip_sheet_master> t_cm_vip_sheet_master { get; set; }
        public virtual DbSet<t_cm_wm_sheet_detail> t_cm_wm_sheet_detail { get; set; }
        public virtual DbSet<t_cm_wm_sheet_master> t_cm_wm_sheet_master { get; set; }
        public virtual DbSet<t_da_clssell_aim> t_da_clssell_aim { get; set; }
        public virtual DbSet<t_da_jxc_daysum> t_da_jxc_daysum { get; set; }
        public virtual DbSet<t_da_jxc_month> t_da_jxc_month { get; set; }
        public virtual DbSet<t_da_jxc_month_anal> t_da_jxc_month_anal { get; set; }
        public virtual DbSet<t_da_jxc_week> t_da_jxc_week { get; set; }
        public virtual DbSet<t_da_sale_plan> t_da_sale_plan { get; set; }
        public virtual DbSet<t_da_saleman_daysum> t_da_saleman_daysum { get; set; }
        public virtual DbSet<t_da_saleman_deduct_flow> t_da_saleman_deduct_flow { get; set; }
        public virtual DbSet<t_da_sell_aim> t_da_sell_aim { get; set; }
        public virtual DbSet<t_da_total_daysum> t_da_total_daysum { get; set; }
        public virtual DbSet<t_da_tran_aim> t_da_tran_aim { get; set; }
        public virtual DbSet<t_da_transell_aim> t_da_transell_aim { get; set; }
        public virtual DbSet<t_dm_input_init> t_dm_input_init { get; set; }
        public virtual DbSet<t_exec_info> t_exec_info { get; set; }
        public virtual DbSet<t_fm_cash_account_info> t_fm_cash_account_info { get; set; }
        public virtual DbSet<t_fm_cash_detail> t_fm_cash_detail { get; set; }
        public virtual DbSet<t_fm_cash_master> t_fm_cash_master { get; set; }
        public virtual DbSet<t_fm_charge_detail> t_fm_charge_detail { get; set; }
        public virtual DbSet<t_fm_charge_master> t_fm_charge_master { get; set; }
        public virtual DbSet<t_fm_recpay_detail> t_fm_recpay_detail { get; set; }
        public virtual DbSet<t_fm_recpay_flow> t_fm_recpay_flow { get; set; }
        public virtual DbSet<t_fm_recpay_ly_detail> t_fm_recpay_ly_detail { get; set; }
        public virtual DbSet<t_fm_recpay_ly_master> t_fm_recpay_ly_master { get; set; }
        public virtual DbSet<t_fm_recpay_master> t_fm_recpay_master { get; set; }
        public virtual DbSet<t_im_autoplan_set> t_im_autoplan_set { get; set; }
        public virtual DbSet<t_im_batch> t_im_batch { get; set; }
        public virtual DbSet<t_im_batch_move> t_im_batch_move { get; set; }
        public virtual DbSet<t_im_batch_out> t_im_batch_out { get; set; }
        public virtual DbSet<t_im_batch_suspend> t_im_batch_suspend { get; set; }
        public virtual DbSet<t_im_branch_stock> t_im_branch_stock { get; set; }
        public virtual DbSet<t_im_check_bak> t_im_check_bak { get; set; }
        public virtual DbSet<t_im_check_bak2> t_im_check_bak2 { get; set; }
        public virtual DbSet<t_im_check_detail> t_im_check_detail { get; set; }
        public virtual DbSet<t_im_check_init> t_im_check_init { get; set; }
        public virtual DbSet<t_im_check_master> t_im_check_master { get; set; }
        public virtual DbSet<t_im_check_sum> t_im_check_sum { get; set; }
        public virtual DbSet<t_im_comb_split_detail> t_im_comb_split_detail { get; set; }
        public virtual DbSet<t_im_comb_split_master> t_im_comb_split_master { get; set; }
        public virtual DbSet<t_im_cs_flow> t_im_cs_flow { get; set; }
        public virtual DbSet<t_im_flow> t_im_flow { get; set; }
        public virtual DbSet<t_im_flow_shd> t_im_flow_shd { get; set; }
        public virtual DbSet<t_im_pdjin> t_im_pdjin { get; set; }
        public virtual DbSet<t_im_sheet_detail> t_im_sheet_detail { get; set; }
        public virtual DbSet<t_im_sheet_master> t_im_sheet_master { get; set; }
        public virtual DbSet<t_im_stock_target> t_im_stock_target { get; set; }
        public virtual DbSet<t_ms_comm_used> t_ms_comm_used { get; set; }
        public virtual DbSet<t_ms_cust_info> t_ms_cust_info { get; set; }
        public virtual DbSet<t_ms_group_info> t_ms_group_info { get; set; }
        public virtual DbSet<t_ms_mess_flow> t_ms_mess_flow { get; set; }
        public virtual DbSet<t_order_bill_weixin> t_order_bill_weixin { get; set; }
        public virtual DbSet<t_pc_branch_data> t_pc_branch_data { get; set; }
        public virtual DbSet<t_pc_branch_price> t_pc_branch_price { get; set; }
        public virtual DbSet<t_pc_branch_price_breakpoint> t_pc_branch_price_breakpoint { get; set; }
        public virtual DbSet<t_pc_league_branch_price> t_pc_league_branch_price { get; set; }
        public virtual DbSet<t_pc_price_flow_detail> t_pc_price_flow_detail { get; set; }
        public virtual DbSet<t_pc_price_flow_master> t_pc_price_flow_master { get; set; }
        public virtual DbSet<t_plan_detail_memo> t_plan_detail_memo { get; set; }
        public virtual DbSet<t_pm_process_yh> t_pm_process_yh { get; set; }
        public virtual DbSet<t_pm_sheet_detail> t_pm_sheet_detail { get; set; }
        public virtual DbSet<t_pm_sheet_master> t_pm_sheet_master { get; set; }
        public virtual DbSet<t_pu_sheet_detail> t_pu_sheet_detail { get; set; }
        public virtual DbSet<t_pu_sheet_master> t_pu_sheet_master { get; set; }
        public virtual DbSet<t_return_plan_master> t_return_plan_master { get; set; }
        public virtual DbSet<t_return_rate_change> t_return_rate_change { get; set; }
        public virtual DbSet<t_rm_balance> t_rm_balance { get; set; }
        public virtual DbSet<t_rm_balance_branch> t_rm_balance_branch { get; set; }
        public virtual DbSet<t_rm_balance_item> t_rm_balance_item { get; set; }
        public virtual DbSet<t_rm_barcode_output> t_rm_barcode_output { get; set; }
        public virtual DbSet<t_rm_casher_daysum_giv> t_rm_casher_daysum_giv { get; set; }
        public virtual DbSet<t_rm_customer_analyse> t_rm_customer_analyse { get; set; }
        public virtual DbSet<t_rm_daysum> t_rm_daysum { get; set; }
        public virtual DbSet<t_rm_deduct_payway_except> t_rm_deduct_payway_except { get; set; }
        public virtual DbSet<t_rm_flow_sum> t_rm_flow_sum { get; set; }
        public virtual DbSet<t_rm_function> t_rm_function { get; set; }
        public virtual DbSet<t_rm_gift_certificate> t_rm_gift_certificate { get; set; }
        public virtual DbSet<t_rm_operator_log> t_rm_operator_log { get; set; }
        public virtual DbSet<t_rm_order_saleflow> t_rm_order_saleflow { get; set; }
        public virtual DbSet<t_rm_payflow> t_rm_payflow { get; set; }
        public virtual DbSet<t_rm_payin_detail> t_rm_payin_detail { get; set; }
        public virtual DbSet<t_rm_payin_master> t_rm_payin_master { get; set; }
        public virtual DbSet<t_rm_plan_branch> t_rm_plan_branch { get; set; }
        public virtual DbSet<t_rm_plan_detail> t_rm_plan_detail { get; set; }
        public virtual DbSet<t_rm_plan_flow> t_rm_plan_flow { get; set; }
        public virtual DbSet<t_rm_plan_master> t_rm_plan_master { get; set; }
        public virtual DbSet<t_rm_plan_rule> t_rm_plan_rule { get; set; }
        public virtual DbSet<t_rm_pos_account> t_rm_pos_account { get; set; }
        public virtual DbSet<t_rm_protion_flow> t_rm_protion_flow { get; set; }
        public virtual DbSet<t_rm_protion_rule> t_rm_protion_rule { get; set; }
        public virtual DbSet<t_rm_salecust_info> t_rm_salecust_info { get; set; }
        public virtual DbSet<t_rm_salecust_info_temp> t_rm_salecust_info_temp { get; set; }
        public virtual DbSet<t_rm_salecust_send> t_rm_salecust_send { get; set; }
        public virtual DbSet<t_rm_saleflow> t_rm_saleflow { get; set; }
        public virtual DbSet<t_rm_saleflow_jc> t_rm_saleflow_jc { get; set; }
        public virtual DbSet<t_rm_saleflow_jc_master> t_rm_saleflow_jc_master { get; set; }
        public virtual DbSet<t_rm_saleflow_order> t_rm_saleflow_order { get; set; }
        public virtual DbSet<t_rm_saleflow_vip_source> t_rm_saleflow_vip_source { get; set; }
        public virtual DbSet<t_rm_saleman> t_rm_saleman { get; set; }
        public virtual DbSet<t_rm_saleman_breakpoint> t_rm_saleman_breakpoint { get; set; }
        public virtual DbSet<t_rm_saleman_detail> t_rm_saleman_detail { get; set; }
        public virtual DbSet<t_rm_salespe_info> t_rm_salespe_info { get; set; }
        public virtual DbSet<t_rm_saving_month> t_rm_saving_month { get; set; }
        public virtual DbSet<t_rm_spec_price> t_rm_spec_price { get; set; }
        public virtual DbSet<t_rm_spec_price_history> t_rm_spec_price_history { get; set; }
        public virtual DbSet<t_rm_tend_add_detail> t_rm_tend_add_detail { get; set; }
        public virtual DbSet<t_rm_tend_consume_detail> t_rm_tend_consume_detail { get; set; }
        public virtual DbSet<t_rm_tend_vip_conver_detail> t_rm_tend_vip_conver_detail { get; set; }
        public virtual DbSet<t_rm_tend_vip_conver_master> t_rm_tend_vip_conver_master { get; set; }
        public virtual DbSet<t_rm_tend_vip_info> t_rm_tend_vip_info { get; set; }
        public virtual DbSet<t_rm_tend_vip_type> t_rm_tend_vip_type { get; set; }
        public virtual DbSet<t_rm_vip_accessories_identity> t_rm_vip_accessories_identity { get; set; }
        public virtual DbSet<t_rm_vip_acclist> t_rm_vip_acclist { get; set; }
        public virtual DbSet<t_rm_vip_agricultural_identity> t_rm_vip_agricultural_identity { get; set; }
        public virtual DbSet<t_rm_vip_cosmetic_identity> t_rm_vip_cosmetic_identity { get; set; }
        public virtual DbSet<t_rm_vip_discount> t_rm_vip_discount { get; set; }
        public virtual DbSet<t_rm_vip_good> t_rm_vip_good { get; set; }
        public virtual DbSet<t_rm_vip_good_flow> t_rm_vip_good_flow { get; set; }
        public virtual DbSet<t_rm_vip_health_identity> t_rm_vip_health_identity { get; set; }
        public virtual DbSet<t_rm_vip_info> t_rm_vip_info { get; set; }
        public virtual DbSet<t_rm_vip_info_breakpoint> t_rm_vip_info_breakpoint { get; set; }
        public virtual DbSet<t_rm_vip_info_edit> t_rm_vip_info_edit { get; set; }
        public virtual DbSet<t_rm_vip_info_prink> t_rm_vip_info_prink { get; set; }
        public virtual DbSet<t_rm_vip_info_source> t_rm_vip_info_source { get; set; }
        public virtual DbSet<t_rm_vip_item> t_rm_vip_item { get; set; }
        public virtual DbSet<t_rm_vip_itemlist> t_rm_vip_itemlist { get; set; }
        public virtual DbSet<t_rm_vip_motherhood_identity> t_rm_vip_motherhood_identity { get; set; }
        public virtual DbSet<t_rm_vip_operlist> t_rm_vip_operlist { get; set; }
        public virtual DbSet<t_rm_vip_reference> t_rm_vip_reference { get; set; }
        public virtual DbSet<t_rm_vip_savelist> t_rm_vip_savelist { get; set; }
        public virtual DbSet<t_rm_vip_saveset> t_rm_vip_saveset { get; set; }
        public virtual DbSet<t_rm_vip_set> t_rm_vip_set { get; set; }
        public virtual DbSet<t_rm_vip_type> t_rm_vip_type { get; set; }
        public virtual DbSet<t_rm_vip_type_source> t_rm_vip_type_source { get; set; }
        public virtual DbSet<t_rm_vip_visit> t_rm_vip_visit { get; set; }
        public virtual DbSet<t_rm_vip_visit_cls> t_rm_vip_visit_cls { get; set; }
        public virtual DbSet<t_rm_vip_visit_detail> t_rm_vip_visit_detail { get; set; }
        public virtual DbSet<t_rm_vip_visit_flow> t_rm_vip_visit_flow { get; set; }
        public virtual DbSet<t_rm_vip_visit_master> t_rm_vip_visit_master { get; set; }
        public virtual DbSet<t_saleman_item_daysum> t_saleman_item_daysum { get; set; }
        public virtual DbSet<t_shd_delivery_flow> t_shd_delivery_flow { get; set; }
        public virtual DbSet<t_shd_recpay_flow> t_shd_recpay_flow { get; set; }
        public virtual DbSet<t_shd_recpay_flow_detail> t_shd_recpay_flow_detail { get; set; }
        public virtual DbSet<t_shd_sheet_detail> t_shd_sheet_detail { get; set; }
        public virtual DbSet<t_shd_sheet_detail_detail> t_shd_sheet_detail_detail { get; set; }
        public virtual DbSet<t_shd_sheet_master> t_shd_sheet_master { get; set; }
        public virtual DbSet<t_sp_mark_detail> t_sp_mark_detail { get; set; }
        public virtual DbSet<t_sp_mark_master> t_sp_mark_master { get; set; }
        public virtual DbSet<t_spid_operator> t_spid_operator { get; set; }
        public virtual DbSet<t_sys_attendance_info> t_sys_attendance_info { get; set; }
        public virtual DbSet<t_sys_attendance_spec> t_sys_attendance_spec { get; set; }
        public virtual DbSet<t_sys_branch_connect_parm> t_sys_branch_connect_parm { get; set; }
        public virtual DbSet<t_sys_branch_set> t_sys_branch_set { get; set; }
        public virtual DbSet<t_sys_branch_version> t_sys_branch_version { get; set; }
        public virtual DbSet<t_sys_cm_breakpoint> t_sys_cm_breakpoint { get; set; }
        public virtual DbSet<t_sys_cm_cmlog> t_sys_cm_cmlog { get; set; }
        public virtual DbSet<t_sys_cm_data> t_sys_cm_data { get; set; }
        public virtual DbSet<t_sys_columns> t_sys_columns { get; set; }
        public virtual DbSet<t_sys_customer> t_sys_customer { get; set; }
        public virtual DbSet<t_sys_customize_report> t_sys_customize_report { get; set; }
        public virtual DbSet<t_sys_data_grant> t_sys_data_grant { get; set; }
        public virtual DbSet<t_sys_dept> t_sys_dept { get; set; }
        public virtual DbSet<t_sys_emp> t_sys_emp { get; set; }
        public virtual DbSet<t_sys_emp_log> t_sys_emp_log { get; set; }
        public virtual DbSet<t_sys_item_refer> t_sys_item_refer { get; set; }
        public virtual DbSet<t_sys_mailmsg_info> t_sys_mailmsg_info { get; set; }
        public virtual DbSet<t_sys_mailmsg_log> t_sys_mailmsg_log { get; set; }
        public virtual DbSet<t_sys_mailmsg_oper> t_sys_mailmsg_oper { get; set; }
        public virtual DbSet<t_sys_menu> t_sys_menu { get; set; }
        public virtual DbSet<t_sys_menu_desktop> t_sys_menu_desktop { get; set; }
        public virtual DbSet<t_sys_menu_grant> t_sys_menu_grant { get; set; }
        public virtual DbSet<t_sys_menu_ver> t_sys_menu_ver { get; set; }
        public virtual DbSet<t_sys_oper_data_grant> t_sys_oper_data_grant { get; set; }
        public virtual DbSet<t_sys_oper_grant> t_sys_oper_grant { get; set; }
        public virtual DbSet<t_sys_operator> t_sys_operator { get; set; }
        public virtual DbSet<t_sys_operator_breakpoint> t_sys_operator_breakpoint { get; set; }
        public virtual DbSet<t_sys_operator_log> t_sys_operator_log { get; set; }
        public virtual DbSet<t_sys_plukey> t_sys_plukey { get; set; }
        public virtual DbSet<t_sys_pos_display> t_sys_pos_display { get; set; }
        public virtual DbSet<t_sys_pos_downfile_status> t_sys_pos_downfile_status { get; set; }
        public virtual DbSet<t_sys_pos_printer> t_sys_pos_printer { get; set; }
        public virtual DbSet<t_sys_pos_status> t_sys_pos_status { get; set; }
        public virtual DbSet<t_sys_query_conditionEx> t_sys_query_conditionEx { get; set; }
        public virtual DbSet<t_sys_reg> t_sys_reg { get; set; }
        public virtual DbSet<t_sys_report> t_sys_report { get; set; }
        public virtual DbSet<t_sys_report_import> t_sys_report_import { get; set; }
        public virtual DbSet<t_sys_saving_grant> t_sys_saving_grant { get; set; }
        public virtual DbSet<t_sys_sheet_detail_info> t_sys_sheet_detail_info { get; set; }
        public virtual DbSet<t_sys_sheet_master_info> t_sys_sheet_master_info { get; set; }
        public virtual DbSet<t_sys_sheet_no> t_sys_sheet_no { get; set; }
        public virtual DbSet<t_sys_sheet_paper_size> t_sys_sheet_paper_size { get; set; }
        public virtual DbSet<t_sys_sheetno_flow> t_sys_sheetno_flow { get; set; }
        public virtual DbSet<t_sys_system> t_sys_system { get; set; }
        public virtual DbSet<t_sys_system_mean> t_sys_system_mean { get; set; }
        public virtual DbSet<t_sys_template_sheet_std> t_sys_template_sheet_std { get; set; }
        public virtual DbSet<t_sys_updown_rdlfile> t_sys_updown_rdlfile { get; set; }
        public virtual DbSet<t_sys_zjm> t_sys_zjm { get; set; }
        public virtual DbSet<t_vip_sheet_detail> t_vip_sheet_detail { get; set; }
        public virtual DbSet<t_vip_sheet_master> t_vip_sheet_master { get; set; }
        public virtual DbSet<t_wm_return_detail> t_wm_return_detail { get; set; }
        public virtual DbSet<t_wm_return_profit> t_wm_return_profit { get; set; }
        public virtual DbSet<t_wm_sheet_detail> t_wm_sheet_detail { get; set; }
        public virtual DbSet<t_wm_sheet_master> t_wm_sheet_master { get; set; }
        public virtual DbSet<t_wx_promotion> t_wx_promotion { get; set; }
        public virtual DbSet<t_wx_shop_info> t_wx_shop_info { get; set; }
        public virtual DbSet<t_wx_vip_bindflow> t_wx_vip_bindflow { get; set; }
        public virtual DbSet<t_wx_vip_info> t_wx_vip_info { get; set; }
        public virtual DbSet<pbcatedt> pbcatedts { get; set; }
        public virtual DbSet<pbcatfmt> pbcatfmts { get; set; }
        public virtual DbSet<pbcatvld> pbcatvlds { get; set; }
        public virtual DbSet<t_im_checkrecord_detail> t_im_checkrecord_detail { get; set; }
        public virtual DbSet<t_im_checkrecord_master> t_im_checkrecord_master { get; set; }
        public virtual DbSet<t_return_plan_detail_d> t_return_plan_detail_d { get; set; }
        public virtual DbSet<t_rm_vip_good_log> t_rm_vip_good_log { get; set; }
        public virtual DbSet<t_sheet_print_errlog> t_sheet_print_errlog { get; set; }
        public virtual DbSet<t_sys_pos_status_history> t_sys_pos_status_history { get; set; }
        public virtual DbSet<t_sys_sheet_psr_info> t_sys_sheet_psr_info { get; set; }
        public virtual DbSet<t_sys_system_verlog> t_sys_system_verlog { get; set; }
        public virtual DbSet<wxsf_member_save_list> wxsf_member_save_list { get; set; }
        public virtual DbSet<wxsf_order_detail> wxsf_order_detail { get; set; }
        public virtual DbSet<wxsf_order_master> wxsf_order_master { get; set; }
        public virtual DbSet<wxsf_vip_info> wxsf_vip_info { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Entity<cw_t_select>()
                .Property(e => e.trans_no)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<cw_t_select>()
                .Property(e => e.db_no)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<cw_t_select>()
                .Property(e => e.item_code)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<cw_t_select>()
                .Property(e => e.item_desc)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<cw_t_select>()
                .Property(e => e.select_flag)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<cw_t_select>()
                .Property(e => e.title)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<cw_t_select>()
                .Property(e => e.item_value)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<cw_t_select>()
                .Property(e => e.change_flag)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<cw_t_sup_info>()
                .Property(e => e.sup_flag)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<cw_t_sup_info>()
                .Property(e => e.sup_no)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<cw_t_sup_info>()
                .Property(e => e.sup_name)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<cw_t_sup_info>()
                .Property(e => e.to_sup)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<cw_t_system>()
                .Property(e => e.sys_cls)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<cw_t_system>()
                .Property(e => e.sys_item)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<cw_t_system>()
                .Property(e => e.sys_value)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<cw_t_system>()
                .Property(e => e.memo)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<dtproperty>()
                .Property(e => e.property)
                .IsUnicode(false);

            modelBuilder.Entity<dtproperty>()
                .Property(e => e.value)
                .IsUnicode(false);

            modelBuilder.Entity<mess_t_mess_flow>()
                .Property(e => e.flow_id)
                .HasPrecision(18, 0);

            modelBuilder.Entity<mess_t_mess_flow>()
                .Property(e => e.cust_no)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<mess_t_mess_flow>()
                .Property(e => e.group_no)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<mess_t_mess_flow>()
                .Property(e => e.mobile)
                .IsUnicode(false);

            modelBuilder.Entity<mess_t_mess_flow>()
                .Property(e => e.oper_id)
                .IsUnicode(false);

            modelBuilder.Entity<mess_t_mess_flow>()
                .Property(e => e.mess)
                .IsUnicode(false);

            modelBuilder.Entity<mess_t_mess_flow>()
                .Property(e => e.region)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<mess_t_mess_flow>()
                .Property(e => e.mess_id)
                .HasPrecision(18, 0);

            modelBuilder.Entity<mess_t_mess_flow>()
                .Property(e => e.memo)
                .IsUnicode(false);

            modelBuilder.Entity<mess_t_mess_flow>()
                .Property(e => e.cust_name)
                .IsUnicode(false);

            modelBuilder.Entity<mess_t_mess_flow>()
                .Property(e => e.plan_id)
                .HasPrecision(18, 0);

            modelBuilder.Entity<mess_t_mess_flow>()
                .Property(e => e.inout_type)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<mess_t_mess_flow>()
                .Property(e => e.error)
                .IsUnicode(false);

            modelBuilder.Entity<mess_t_mess_flow>()
                .Property(e => e.branch_no)
                .IsUnicode(false);

            modelBuilder.Entity<mess_t_mess_record>()
                .Property(e => e.flow_id)
                .HasPrecision(18, 0);

            modelBuilder.Entity<mess_t_mess_record>()
                .Property(e => e.send_sup)
                .IsUnicode(false);

            modelBuilder.Entity<mess_t_mess_record>()
                .Property(e => e.other1)
                .IsUnicode(false);

            modelBuilder.Entity<mess_t_mess_record>()
                .Property(e => e.other2)
                .IsUnicode(false);

            modelBuilder.Entity<mess_t_mess_record>()
                .Property(e => e.other3)
                .IsUnicode(false);

            modelBuilder.Entity<mess_t_mess_record>()
                .Property(e => e.num1)
                .HasPrecision(16, 2);

            modelBuilder.Entity<mess_t_mess_record>()
                .Property(e => e.num2)
                .HasPrecision(16, 2);

            modelBuilder.Entity<mess_t_mess_record>()
                .Property(e => e.num3)
                .HasPrecision(16, 2);

            modelBuilder.Entity<mess_t_mess_record>()
                .Property(e => e.send_user)
                .IsUnicode(false);

            modelBuilder.Entity<mess_t_sys_system>()
                .Property(e => e.sys_var_id)
                .IsUnicode(false);

            modelBuilder.Entity<mess_t_sys_system>()
                .Property(e => e.sys_var_name)
                .IsUnicode(false);

            modelBuilder.Entity<mess_t_sys_system>()
                .Property(e => e.sys_var_value)
                .IsUnicode(false);

            modelBuilder.Entity<mess_t_vip_message>()
                .Property(e => e.flow_id)
                .HasPrecision(18, 0);

            modelBuilder.Entity<mess_t_vip_message>()
                .Property(e => e.mess_type)
                .IsUnicode(false);

            modelBuilder.Entity<mess_t_vip_message>()
                .Property(e => e.send_flag)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<mess_t_vip_message>()
                .Property(e => e.branch_no)
                .IsUnicode(false);

            modelBuilder.Entity<mess_t_vip_message>()
                .Property(e => e.card_id)
                .IsUnicode(false);

            modelBuilder.Entity<mess_t_vip_message>()
                .Property(e => e.card_type)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<mess_t_vip_message>()
                .Property(e => e.to_card_type)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<mess_t_vip_message>()
                .Property(e => e.father_card)
                .IsUnicode(false);

            modelBuilder.Entity<mess_t_vip_message>()
                .Property(e => e.giv_acc_num)
                .HasPrecision(16, 4);

            modelBuilder.Entity<mess_t_vip_message>()
                .Property(e => e.oper_type)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<mess_t_vip_message>()
                .Property(e => e.change_amt)
                .HasPrecision(16, 4);

            modelBuilder.Entity<mess_t_vip_message>()
                .Property(e => e.savelist_amt)
                .HasPrecision(16, 4);

            modelBuilder.Entity<mess_t_vip_message>()
                .Property(e => e.flow_no)
                .IsUnicode(false);

            modelBuilder.Entity<mess_t_vip_message>()
                .Property(e => e.item_no)
                .IsUnicode(false);

            modelBuilder.Entity<mess_t_vip_message>()
                .Property(e => e.acc_num)
                .HasPrecision(16, 4);

            modelBuilder.Entity<mess_t_vip_message>()
                .Property(e => e.flow_amt)
                .HasPrecision(16, 4);

            modelBuilder.Entity<mess_t_vip_message>()
                .Property(e => e.send_year)
                .IsUnicode(false);

            modelBuilder.Entity<mess_t_vip_message>()
                .Property(e => e.send_date)
                .IsUnicode(false);

            modelBuilder.Entity<mess_t_vip_message>()
                .Property(e => e.card_little)
                .IsUnicode(false);

            modelBuilder.Entity<mess_t_vip_message>()
                .Property(e => e.send_times)
                .HasPrecision(9, 0);

            modelBuilder.Entity<sys_verfile>()
                .Property(e => e.systemname)
                .IsUnicode(false);

            modelBuilder.Entity<sys_verfile>()
                .Property(e => e.version)
                .IsUnicode(false);

            modelBuilder.Entity<sys_verfile>()
                .Property(e => e.filename)
                .IsUnicode(false);

            modelBuilder.Entity<sys_verfile>()
                .Property(e => e.filepath)
                .IsUnicode(false);

            modelBuilder.Entity<sys_verfile>()
                .Property(e => e.is_branch_file)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<t_bd_appitem_info>()
                .Property(e => e.item_no)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<t_bd_appitem_info>()
                .Property(e => e.item_subno)
                .IsUnicode(false);

            modelBuilder.Entity<t_bd_appitem_info>()
                .Property(e => e.item_name)
                .IsUnicode(false);

            modelBuilder.Entity<t_bd_appitem_info>()
                .Property(e => e.item_subname)
                .IsUnicode(false);

            modelBuilder.Entity<t_bd_appitem_info>()
                .Property(e => e.item_clsno)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<t_bd_appitem_info>()
                .Property(e => e.item_brand)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<t_bd_appitem_info>()
                .Property(e => e.item_brandname)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<t_bd_appitem_info>()
                .Property(e => e.unit_no)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<t_bd_appitem_info>()
                .Property(e => e.item_size)
                .IsUnicode(false);

            modelBuilder.Entity<t_bd_appitem_info>()
                .Property(e => e.product_area)
                .IsUnicode(false);

            modelBuilder.Entity<t_bd_appitem_info>()
                .Property(e => e.price)
                .HasPrecision(16, 4);

            modelBuilder.Entity<t_bd_appitem_info>()
                .Property(e => e.base_price)
                .HasPrecision(16, 4);

            modelBuilder.Entity<t_bd_appitem_info>()
                .Property(e => e.sale_price)
                .HasPrecision(16, 4);

            modelBuilder.Entity<t_bd_appitem_info>()
                .Property(e => e.combine_sta)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<t_bd_appitem_info>()
                .Property(e => e.status)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<t_bd_appitem_info>()
                .Property(e => e.display_flag)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<t_bd_appitem_info>()
                .Property(e => e.other1)
                .IsUnicode(false);

            modelBuilder.Entity<t_bd_appitem_info>()
                .Property(e => e.other2)
                .IsUnicode(false);

            modelBuilder.Entity<t_bd_appitem_info>()
                .Property(e => e.other3)
                .IsUnicode(false);

            modelBuilder.Entity<t_bd_appitem_info>()
                .Property(e => e.num1)
                .HasPrecision(16, 4);

            modelBuilder.Entity<t_bd_appitem_info>()
                .Property(e => e.num2)
                .HasPrecision(16, 4);

            modelBuilder.Entity<t_bd_appitem_info>()
                .Property(e => e.num3)
                .HasPrecision(16, 4);

            modelBuilder.Entity<t_bd_appitem_info>()
                .Property(e => e.automin_flag)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<t_bd_appitem_info>()
                .Property(e => e.en_dis)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<t_bd_appitem_info>()
                .Property(e => e.direct)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<t_bd_appitem_info>()
                .Property(e => e.change_price)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<t_bd_appitem_info>()
                .Property(e => e.purchase_tax)
                .HasPrecision(4, 2);

            modelBuilder.Entity<t_bd_appitem_info>()
                .Property(e => e.sale_tax)
                .HasPrecision(4, 2);

            modelBuilder.Entity<t_bd_appitem_info>()
                .Property(e => e.purchase_spec)
                .HasPrecision(8, 2);

            modelBuilder.Entity<t_bd_appitem_info>()
                .Property(e => e.shipment_spec)
                .HasPrecision(8, 2);

            modelBuilder.Entity<t_bd_appitem_info>()
                .Property(e => e.item_supcust)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<t_bd_appitem_info>()
                .Property(e => e.main_supcust)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<t_bd_appitem_info>()
                .Property(e => e.lose_rate)
                .HasPrecision(6, 4);

            modelBuilder.Entity<t_bd_appitem_info>()
                .Property(e => e.item_sup_flag)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<t_bd_appitem_info>()
                .Property(e => e.item_stock)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<t_bd_appitem_info>()
                .Property(e => e.item_counter)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<t_bd_appitem_info>()
                .Property(e => e.sup_ly_rate)
                .HasPrecision(16, 4);

            modelBuilder.Entity<t_bd_appitem_info>()
                .Property(e => e.return_rate)
                .HasPrecision(16, 4);

            modelBuilder.Entity<t_bd_appitem_info>()
                .Property(e => e.abc)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<t_bd_appitem_info>()
                .Property(e => e.branch_price)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<t_bd_appitem_info>()
                .Property(e => e.item_rem)
                .IsUnicode(false);

            modelBuilder.Entity<t_bd_appitem_info>()
                .Property(e => e.vip_price)
                .HasPrecision(16, 4);

            modelBuilder.Entity<t_bd_appitem_info>()
                .Property(e => e.sale_min_price)
                .HasPrecision(16, 4);

            modelBuilder.Entity<t_bd_appitem_info>()
                .Property(e => e.base_price1)
                .HasPrecision(16, 4);

            modelBuilder.Entity<t_bd_appitem_info>()
                .Property(e => e.base_price2)
                .HasPrecision(16, 4);

            modelBuilder.Entity<t_bd_appitem_info>()
                .Property(e => e.base_price3)
                .HasPrecision(16, 4);

            modelBuilder.Entity<t_bd_appitem_info>()
                .Property(e => e.branch_no)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<t_bd_appitem_info>()
                .Property(e => e.cost_compute)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<t_bd_appitem_info>()
                .Property(e => e.com_flag)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<t_bd_appitem_info>()
                .Property(e => e.vip_acc_flag)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<t_bd_appitem_info>()
                .Property(e => e.vip_acc_num)
                .HasPrecision(16, 4);

            modelBuilder.Entity<t_bd_appitem_info>()
                .Property(e => e.approve_flag)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<t_bd_appitem_info>()
                .Property(e => e.oper_id)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<t_bd_appitem_info>()
                .Property(e => e.pro_code1)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<t_bd_appitem_info>()
                .Property(e => e.pro_code2)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<t_bd_appitem_info>()
                .Property(e => e.pro_code3)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<t_bd_appitem_info>()
                .Property(e => e.pro_code4)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<t_bd_appitem_info>()
                .Property(e => e.pro_code5)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<t_bd_appitem_info>()
                .Property(e => e.pro_code6)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<t_bd_appitem_info>()
                .Property(e => e.en_gift)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<t_bd_appitem_info>()
                .Property(e => e.app_branch_no)
                .IsUnicode(false);

            modelBuilder.Entity<t_bd_appitem_info>()
                .Property(e => e.vip_price2)
                .HasPrecision(16, 4);

            modelBuilder.Entity<t_bd_appitem_info>()
                .Property(e => e.vip_price3)
                .HasPrecision(16, 4);

            modelBuilder.Entity<t_bd_appitem_info>()
                .Property(e => e.vip_price4)
                .HasPrecision(16, 4);

            modelBuilder.Entity<t_bd_appitem_info>()
                .Property(e => e.vip_price5)
                .HasPrecision(16, 4);

            modelBuilder.Entity<t_bd_auto_subno>()
                .Property(e => e.item_clsno)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<t_bd_auto_subno>()
                .Property(e => e.auto_num)
                .HasPrecision(10, 0);

            modelBuilder.Entity<t_bd_auto_subno>()
                .Property(e => e.num1)
                .HasPrecision(16, 4);

            modelBuilder.Entity<t_bd_auto_subno>()
                .Property(e => e.num2)
                .HasPrecision(16, 4);

            modelBuilder.Entity<t_bd_auto_subno>()
                .Property(e => e.other1)
                .IsUnicode(false);

            modelBuilder.Entity<t_bd_auto_subno>()
                .Property(e => e.other2)
                .IsUnicode(false);

            modelBuilder.Entity<t_bd_base_code>()
                .Property(e => e.type_no)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<t_bd_base_code>()
                .Property(e => e.code_id)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<t_bd_base_code>()
                .Property(e => e.code_name)
                .IsUnicode(false);

            modelBuilder.Entity<t_bd_base_code>()
                .Property(e => e.english_name)
                .IsUnicode(false);

            modelBuilder.Entity<t_bd_base_code>()
                .Property(e => e.code_type)
                .IsUnicode(false);

            modelBuilder.Entity<t_bd_base_code>()
                .Property(e => e.memo)
                .IsUnicode(false);

            modelBuilder.Entity<t_bd_basecode_type>()
                .Property(e => e.type_no)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<t_bd_basecode_type>()
                .Property(e => e.type_name)
                .IsUnicode(false);

            modelBuilder.Entity<t_bd_basecode_type>()
                .Property(e => e.use_flag)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<t_bd_branch_area>()
                .Property(e => e.branch_clsno)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<t_bd_branch_area>()
                .Property(e => e.branch_clsname)
                .IsUnicode(false);

            modelBuilder.Entity<t_bd_branch_area>()
                .Property(e => e.branch_flag)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<t_bd_branch_area>()
                .Property(e => e.branch_cls_parent)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<t_bd_branch_area>()
                .Property(e => e.branch_display_flag)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<t_bd_branch_group_info>()
                .Property(e => e.group_id)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<t_bd_branch_group_info>()
                .Property(e => e.branch_no)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<t_bd_branch_group_info>()
                .Property(e => e.memo)
                .IsUnicode(false);

            modelBuilder.Entity<t_bd_branch_info>()
                .Property(e => e.branch_no)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<t_bd_branch_info>()
                .Property(e => e.branch_name)
                .IsUnicode(false);

            modelBuilder.Entity<t_bd_branch_info>()
                .Property(e => e.property)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<t_bd_branch_info>()
                .Property(e => e.branch_man)
                .IsUnicode(false);

            modelBuilder.Entity<t_bd_branch_info>()
                .Property(e => e.address)
                .IsUnicode(false);

            modelBuilder.Entity<t_bd_branch_info>()
                .Property(e => e.zip)
                .IsUnicode(false);

            modelBuilder.Entity<t_bd_branch_info>()
                .Property(e => e.branch_email)
                .IsUnicode(false);

            modelBuilder.Entity<t_bd_branch_info>()
                .Property(e => e.branch_tel)
                .IsUnicode(false);

            modelBuilder.Entity<t_bd_branch_info>()
                .Property(e => e.branch_fax)
                .IsUnicode(false);

            modelBuilder.Entity<t_bd_branch_info>()
                .Property(e => e.display_flag)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<t_bd_branch_info>()
                .Property(e => e.area)
                .HasPrecision(10, 2);

            modelBuilder.Entity<t_bd_branch_info>()
                .Property(e => e.trade_type)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<t_bd_branch_info>()
                .Property(e => e.com_grant)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<t_bd_branch_info>()
                .Property(e => e.account)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<t_bd_branch_info>()
                .Property(e => e.com_init)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<t_bd_branch_info>()
                .Property(e => e.indep_bal)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<t_bd_branch_info>()
                .Property(e => e.dc_no)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<t_bd_branch_info>()
                .Property(e => e.com_oper_up)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<t_bd_branch_info>()
                .Property(e => e.com_oper_down)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<t_bd_branch_info>()
                .Property(e => e.dec_rate)
                .HasPrecision(18, 4);

            modelBuilder.Entity<t_bd_branch_info>()
                .Property(e => e.price_ratio)
                .HasPrecision(18, 4);

            modelBuilder.Entity<t_bd_branch_info>()
                .Property(e => e.price_option)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<t_bd_branch_info>()
                .Property(e => e.vip_flag)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<t_bd_branch_info>()
                .Property(e => e.vip_quota)
                .HasPrecision(16, 4);

            modelBuilder.Entity<t_bd_branch_info>()
                .Property(e => e.vip_type)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<t_bd_branch_info>()
                .Property(e => e.acc_flag)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<t_bd_branch_info>()
                .Property(e => e.query_local_flag)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<t_bd_branch_info>()
                .Property(e => e.operator_flag)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<t_bd_branch_info>()
                .Property(e => e.branch_clsno)
                .IsUnicode(false);

            modelBuilder.Entity<t_bd_branch_info>()
                .Property(e => e.zbtg_flag)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<t_bd_branch_info>()
                .Property(e => e.version_flag)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<t_bd_branch_info>()
                .Property(e => e.num_oper)
                .IsUnicode(false);

            modelBuilder.Entity<t_bd_branch_info>()
                .Property(e => e.query_self)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<t_bd_branch_info>()
                .Property(e => e.price_reference)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<t_bd_branch_info>()
                .Property(e => e.include_spec)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<t_bd_branch_info_weixin>()
                .Property(e => e.shlef_status)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<t_bd_branch_info_weixin>()
                .Property(e => e.branch_selltype)
                .IsUnicode(false);

            modelBuilder.Entity<t_bd_branch_info_weixin>()
                .Property(e => e.com_flag)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<t_bd_branch_info_weixin>()
                .Property(e => e.pic_name)
                .IsUnicode(false);

            modelBuilder.Entity<t_bd_branch_info_weixin>()
                .Property(e => e.pic_flag)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<t_bd_branch_info_weixin>()
                .Property(e => e.latitude)
                .HasPrecision(12, 6);

            modelBuilder.Entity<t_bd_branch_info_weixin>()
                .Property(e => e.longitude)
                .HasPrecision(12, 6);

            modelBuilder.Entity<t_bd_branch_item_info>()
                .Property(e => e.branch_no)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<t_bd_branch_item_info>()
                .Property(e => e.item_no)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<t_bd_branch_item_info>()
                .Property(e => e.min_qty)
                .HasPrecision(16, 4);

            modelBuilder.Entity<t_bd_branch_item_info>()
                .Property(e => e.max_qty)
                .HasPrecision(16, 4);

            modelBuilder.Entity<t_bd_city>()
                .Property(e => e.province_no)
                .IsUnicode(false);

            modelBuilder.Entity<t_bd_city>()
                .Property(e => e.province_name)
                .IsUnicode(false);

            modelBuilder.Entity<t_bd_city>()
                .Property(e => e.city_no)
                .IsUnicode(false);

            modelBuilder.Entity<t_bd_city>()
                .Property(e => e.city_name)
                .IsUnicode(false);

            modelBuilder.Entity<t_bd_deduct_condrcd>()
                .Property(e => e.flow_id)
                .HasPrecision(16, 0);

            modelBuilder.Entity<t_bd_deduct_condrcd>()
                .Property(e => e.deduct_no)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<t_bd_deduct_condrcd>()
                .Property(e => e.oper_id)
                .IsUnicode(false);

            modelBuilder.Entity<t_bd_deduct_condrcd>()
                .Property(e => e.deduct_type)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<t_bd_deduct_condrcd>()
                .Property(e => e.deduct_priority)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<t_bd_deduct_condrcd>()
                .Property(e => e.deduct_specitem)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<t_bd_deduct_condrcd>()
                .Property(e => e.begin_date)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<t_bd_deduct_condrcd>()
                .Property(e => e.end_date)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<t_bd_export_format>()
                .Property(e => e.com_no)
                .HasPrecision(14, 0);

            modelBuilder.Entity<t_bd_export_format>()
                .Property(e => e.mod_no)
                .IsUnicode(false);

            modelBuilder.Entity<t_bd_export_format>()
                .Property(e => e.column_code)
                .IsUnicode(false);

            modelBuilder.Entity<t_bd_export_format>()
                .Property(e => e.column_name)
                .IsUnicode(false);

            modelBuilder.Entity<t_bd_export_format>()
                .Property(e => e.default_value)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<t_bd_item_barcode>()
                .Property(e => e.item_no)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<t_bd_item_barcode>()
                .Property(e => e.item_barcode)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<t_bd_item_barcode_breakpoint>()
                .Property(e => e.com_no)
                .HasPrecision(18, 0);

            modelBuilder.Entity<t_bd_item_barcode_breakpoint>()
                .Property(e => e.change_type)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<t_bd_item_barcode_breakpoint>()
                .Property(e => e.item_barcode)
                .IsUnicode(false);

            modelBuilder.Entity<t_bd_item_brand>()
                .Property(e => e.item_brandno)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<t_bd_item_brand>()
                .Property(e => e.item_brandname)
                .IsUnicode(false);

            modelBuilder.Entity<t_bd_item_brand>()
                .Property(e => e.item_flag)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<t_bd_item_brand>()
                .Property(e => e.brand_parent)
                .IsUnicode(false);

            modelBuilder.Entity<t_bd_item_brand>()
                .Property(e => e.display_flag)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<t_bd_item_brand>()
                .Property(e => e.return_rate)
                .HasPrecision(5, 4);

            modelBuilder.Entity<t_bd_item_brand>()
                .Property(e => e.comp_rate)
                .HasPrecision(16, 4);

            modelBuilder.Entity<t_bd_item_brand>()
                .Property(e => e.trans_flag)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<t_bd_item_brand_breakpoint>()
                .Property(e => e.com_no)
                .HasPrecision(18, 0);

            modelBuilder.Entity<t_bd_item_brand_breakpoint>()
                .Property(e => e.change_type)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<t_bd_item_brand_breakpoint>()
                .Property(e => e.item_brandno)
                .IsUnicode(false);

            modelBuilder.Entity<t_bd_item_cls>()
                .Property(e => e.item_clsno)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<t_bd_item_cls>()
                .Property(e => e.item_clsname)
                .IsUnicode(false);

            modelBuilder.Entity<t_bd_item_cls>()
                .Property(e => e.item_flag)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<t_bd_item_cls>()
                .Property(e => e.cls_parent)
                .IsUnicode(false);

            modelBuilder.Entity<t_bd_item_cls>()
                .Property(e => e.display_flag)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<t_bd_item_cls>()
                .Property(e => e.return_rate)
                .HasPrecision(5, 4);

            modelBuilder.Entity<t_bd_item_cls>()
                .Property(e => e.comp_rate)
                .HasPrecision(16, 4);

            modelBuilder.Entity<t_bd_item_cls>()
                .Property(e => e.trans_flag)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<t_bd_item_cls_breakpoint>()
                .Property(e => e.com_no)
                .HasPrecision(18, 0);

            modelBuilder.Entity<t_bd_item_cls_breakpoint>()
                .Property(e => e.change_type)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<t_bd_item_cls_breakpoint>()
                .Property(e => e.item_clsno)
                .IsUnicode(false);

            modelBuilder.Entity<t_bd_item_cls_weixin>()
                .Property(e => e.item_clsno)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<t_bd_item_cls_weixin>()
                .Property(e => e.item_clsname)
                .IsUnicode(false);

            modelBuilder.Entity<t_bd_item_cls_weixin>()
                .Property(e => e.shlef_status)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<t_bd_item_cls_weixin>()
                .Property(e => e.com_flag)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<t_bd_item_combsplit>()
                .Property(e => e.comb_item_no)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<t_bd_item_combsplit>()
                .Property(e => e.item_no)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<t_bd_item_combsplit>()
                .Property(e => e.item_qty)
                .HasPrecision(16, 4);

            modelBuilder.Entity<t_bd_item_combsplit>()
                .Property(e => e.memo)
                .IsUnicode(false);

            modelBuilder.Entity<t_bd_item_combsplit>()
                .Property(e => e.relation_px)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<t_bd_item_combsplit_breakpoint>()
                .Property(e => e.com_no)
                .HasPrecision(18, 0);

            modelBuilder.Entity<t_bd_item_combsplit_breakpoint>()
                .Property(e => e.change_type)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<t_bd_item_combsplit_breakpoint>()
                .Property(e => e.comb_item_no)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<t_bd_item_combsplit_breakpoint>()
                .Property(e => e.item_no)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<t_bd_item_contract>()
                .Property(e => e.branch_no)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<t_bd_item_contract>()
                .Property(e => e.item_no)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<t_bd_item_contract>()
                .Property(e => e.valid_price)
                .HasPrecision(16, 4);

            modelBuilder.Entity<t_bd_item_contract>()
                .Property(e => e.memo)
                .IsUnicode(false);

            modelBuilder.Entity<t_bd_item_info>()
                .Property(e => e.item_no)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<t_bd_item_info>()
                .Property(e => e.item_subno)
                .IsUnicode(false);

            modelBuilder.Entity<t_bd_item_info>()
                .Property(e => e.item_name)
                .IsUnicode(false);

            modelBuilder.Entity<t_bd_item_info>()
                .Property(e => e.item_subname)
                .IsUnicode(false);

            modelBuilder.Entity<t_bd_item_info>()
                .Property(e => e.item_clsno)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<t_bd_item_info>()
                .Property(e => e.item_brand)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<t_bd_item_info>()
                .Property(e => e.item_brandname)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<t_bd_item_info>()
                .Property(e => e.unit_no)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<t_bd_item_info>()
                .Property(e => e.item_size)
                .IsUnicode(false);

            modelBuilder.Entity<t_bd_item_info>()
                .Property(e => e.price)
                .HasPrecision(16, 4);

            modelBuilder.Entity<t_bd_item_info>()
                .Property(e => e.base_price)
                .HasPrecision(16, 4);

            modelBuilder.Entity<t_bd_item_info>()
                .Property(e => e.sale_price)
                .HasPrecision(16, 4);

            modelBuilder.Entity<t_bd_item_info>()
                .Property(e => e.combine_sta)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<t_bd_item_info>()
                .Property(e => e.status)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<t_bd_item_info>()
                .Property(e => e.display_flag)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<t_bd_item_info>()
                .Property(e => e.automin_flag)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<t_bd_item_info>()
                .Property(e => e.en_dis)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<t_bd_item_info>()
                .Property(e => e.change_price)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<t_bd_item_info>()
                .Property(e => e.purchase_tax)
                .HasPrecision(4, 2);

            modelBuilder.Entity<t_bd_item_info>()
                .Property(e => e.sale_tax)
                .HasPrecision(4, 2);

            modelBuilder.Entity<t_bd_item_info>()
                .Property(e => e.purchase_spec)
                .HasPrecision(8, 2);

            modelBuilder.Entity<t_bd_item_info>()
                .Property(e => e.shipment_spec)
                .HasPrecision(8, 2);

            modelBuilder.Entity<t_bd_item_info>()
                .Property(e => e.item_supcust)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<t_bd_item_info>()
                .Property(e => e.main_supcust)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<t_bd_item_info>()
                .Property(e => e.item_stock)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<t_bd_item_info>()
                .Property(e => e.abc)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<t_bd_item_info>()
                .Property(e => e.branch_price)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<t_bd_item_info>()
                .Property(e => e.item_rem)
                .IsUnicode(false);

            modelBuilder.Entity<t_bd_item_info>()
                .Property(e => e.vip_price)
                .HasPrecision(16, 4);

            modelBuilder.Entity<t_bd_item_info>()
                .Property(e => e.sale_min_price)
                .HasPrecision(16, 4);

            modelBuilder.Entity<t_bd_item_info>()
                .Property(e => e.com_flag)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<t_bd_item_info>()
                .Property(e => e.vip_acc_flag)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<t_bd_item_info>()
                .Property(e => e.vip_acc_num)
                .HasPrecision(16, 4);

            modelBuilder.Entity<t_bd_item_info>()
                .Property(e => e.dpfm_type)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<t_bd_item_info>()
                .Property(e => e.return_rate)
                .HasPrecision(16, 4);

            modelBuilder.Entity<t_bd_item_info>()
                .Property(e => e.update_date)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<t_bd_item_info>()
                .Property(e => e.pro_code1)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<t_bd_item_info>()
                .Property(e => e.pro_code2)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<t_bd_item_info>()
                .Property(e => e.pro_code3)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<t_bd_item_info>()
                .Property(e => e.pro_code4)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<t_bd_item_info>()
                .Property(e => e.pro_code5)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<t_bd_item_info>()
                .Property(e => e.pro_code6)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<t_bd_item_info>()
                .Property(e => e.item_picture)
                .IsUnicode(false);

            modelBuilder.Entity<t_bd_item_info>()
                .Property(e => e.sale_flag)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<t_bd_item_info>()
                .Property(e => e.scheme_price)
                .HasPrecision(16, 4);

            modelBuilder.Entity<t_bd_item_info>()
                .Property(e => e.vip_price2)
                .HasPrecision(16, 4);

            modelBuilder.Entity<t_bd_item_info>()
                .Property(e => e.vip_price3)
                .HasPrecision(16, 4);

            modelBuilder.Entity<t_bd_item_info>()
                .Property(e => e.vip_price4)
                .HasPrecision(16, 4);

            modelBuilder.Entity<t_bd_item_info>()
                .Property(e => e.vip_price5)
                .HasPrecision(16, 4);

            modelBuilder.Entity<t_bd_item_info>()
                .Property(e => e.valid_days)
                .HasPrecision(16, 4);

            modelBuilder.Entity<t_bd_item_info>()
                .Property(e => e.memo)
                .IsUnicode(false);

            modelBuilder.Entity<t_bd_item_info>()
                .Property(e => e.item_com)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<t_bd_item_info>()
                .Property(e => e.product_area)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<t_bd_item_info>()
                .Property(e => e.measure_flag)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<t_bd_item_info>()
                .Property(e => e.item_sup_flag)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<t_bd_item_info>()
                .Property(e => e.sup_rate)
                .HasPrecision(16, 4);

            modelBuilder.Entity<t_bd_item_info>()
                .Property(e => e.picture_type)
                .IsUnicode(false);

            modelBuilder.Entity<t_bd_item_info>()
                .Property(e => e.base_price1)
                .HasPrecision(16, 4);

            modelBuilder.Entity<t_bd_item_info>()
                .Property(e => e.base_price2)
                .HasPrecision(16, 4);

            modelBuilder.Entity<t_bd_item_info>()
                .Property(e => e.base_price3)
                .HasPrecision(16, 4);

            modelBuilder.Entity<t_bd_item_info>()
                .Property(e => e.base_price4)
                .HasPrecision(16, 4);

            modelBuilder.Entity<t_bd_item_info>()
                .Property(e => e.base_price5)
                .HasPrecision(16, 4);

            modelBuilder.Entity<t_bd_item_info>()
                .Property(e => e.base_price6)
                .HasPrecision(16, 4);

            modelBuilder.Entity<t_bd_item_info>()
                .Property(e => e.base_price7)
                .HasPrecision(16, 4);

            modelBuilder.Entity<t_bd_item_info>()
                .Property(e => e.base_price8)
                .HasPrecision(16, 4);

            modelBuilder.Entity<t_bd_item_info>()
                .Property(e => e.new_oper_id)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<t_bd_item_info>()
                .Property(e => e.modify_oper_id)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<t_bd_item_info>()
                .Property(e => e.en_gift)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<t_bd_item_info>()
                .Property(e => e.promote_flag)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<t_bd_item_info>()
                .Property(e => e.allow_flag)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<t_bd_item_info>()
                .Property(e => e.hand_flag)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<t_bd_item_info>()
                .Property(e => e.item_usage)
                .IsUnicode(false);

            modelBuilder.Entity<t_bd_item_info>()
                .Property(e => e.visit_interval)
                .IsUnicode(false);

            modelBuilder.Entity<t_bd_item_info>()
                .Property(e => e.milk_flag)
                .IsUnicode(false);

            modelBuilder.Entity<t_bd_item_info>()
                .Property(e => e.dpfm_type_orderman)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<t_bd_item_info>()
                .Property(e => e.return_rate_orderman)
                .HasPrecision(16, 4);

            modelBuilder.Entity<t_bd_item_info_breakpoint>()
                .Property(e => e.com_no)
                .HasPrecision(18, 0);

            modelBuilder.Entity<t_bd_item_info_breakpoint>()
                .Property(e => e.change_type)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<t_bd_item_info_breakpoint>()
                .Property(e => e.item_no)
                .IsUnicode(false);

            modelBuilder.Entity<t_bd_item_info_weixin>()
                .Property(e => e.item_size)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<t_bd_item_info_weixin>()
                .Property(e => e.item_no)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<t_bd_item_info_weixin>()
                .Property(e => e.item_name)
                .IsUnicode(false);

            modelBuilder.Entity<t_bd_item_info_weixin>()
                .Property(e => e.unit_name)
                .IsUnicode(false);

            modelBuilder.Entity<t_bd_item_info_weixin>()
                .Property(e => e.unit_no)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<t_bd_item_info_weixin>()
                .Property(e => e.price)
                .HasPrecision(16, 4);

            modelBuilder.Entity<t_bd_item_info_weixin>()
                .Property(e => e.suitflag)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<t_bd_item_info_weixin>()
                .Property(e => e.discount)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<t_bd_item_info_weixin>()
                .Property(e => e.item_clsno)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<t_bd_item_info_weixin>()
                .Property(e => e.item_rem)
                .IsUnicode(false);

            modelBuilder.Entity<t_bd_item_info_weixin>()
                .Property(e => e.curflag)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<t_bd_item_info_weixin>()
                .Property(e => e.picture)
                .IsFixedLength();

            modelBuilder.Entity<t_bd_item_info_weixin>()
                .Property(e => e.shlef_status)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<t_bd_item_info_weixin>()
                .Property(e => e.com_flag)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<t_bd_item_info_weixin>()
                .Property(e => e.pic_name)
                .IsUnicode(false);

            modelBuilder.Entity<t_bd_item_info_weixin>()
                .Property(e => e.pic_flag)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<t_bd_item_info_weixin>()
                .Property(e => e.spic_name)
                .IsUnicode(false);

            modelBuilder.Entity<t_bd_item_info_weixin>()
                .Property(e => e.dish_desc)
                .IsUnicode(false);

            modelBuilder.Entity<t_bd_item_setup>()
                .Property(e => e.item_no)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<t_bd_item_setup>()
                .Property(e => e.item_subno)
                .IsUnicode(false);

            modelBuilder.Entity<t_bd_item_setup>()
                .Property(e => e.item_name)
                .IsUnicode(false);

            modelBuilder.Entity<t_bd_item_setup>()
                .Property(e => e.item_subname)
                .IsUnicode(false);

            modelBuilder.Entity<t_bd_item_setup>()
                .Property(e => e.item_clsno)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<t_bd_item_setup>()
                .Property(e => e.item_brand)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<t_bd_item_setup>()
                .Property(e => e.item_brandname)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<t_bd_item_setup>()
                .Property(e => e.unit_no)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<t_bd_item_setup>()
                .Property(e => e.item_size)
                .IsUnicode(false);

            modelBuilder.Entity<t_bd_item_setup>()
                .Property(e => e.price)
                .HasPrecision(16, 4);

            modelBuilder.Entity<t_bd_item_setup>()
                .Property(e => e.base_price)
                .HasPrecision(16, 4);

            modelBuilder.Entity<t_bd_item_setup>()
                .Property(e => e.sale_price)
                .HasPrecision(16, 4);

            modelBuilder.Entity<t_bd_item_setup>()
                .Property(e => e.combine_sta)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<t_bd_item_setup>()
                .Property(e => e.status)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<t_bd_item_setup>()
                .Property(e => e.display_flag)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<t_bd_item_setup>()
                .Property(e => e.automin_flag)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<t_bd_item_setup>()
                .Property(e => e.en_dis)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<t_bd_item_setup>()
                .Property(e => e.change_price)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<t_bd_item_setup>()
                .Property(e => e.purchase_tax)
                .HasPrecision(4, 2);

            modelBuilder.Entity<t_bd_item_setup>()
                .Property(e => e.sale_tax)
                .HasPrecision(4, 2);

            modelBuilder.Entity<t_bd_item_setup>()
                .Property(e => e.purchase_spec)
                .HasPrecision(8, 2);

            modelBuilder.Entity<t_bd_item_setup>()
                .Property(e => e.shipment_spec)
                .HasPrecision(8, 2);

            modelBuilder.Entity<t_bd_item_setup>()
                .Property(e => e.item_supcust)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<t_bd_item_setup>()
                .Property(e => e.main_supcust)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<t_bd_item_setup>()
                .Property(e => e.item_stock)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<t_bd_item_setup>()
                .Property(e => e.abc)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<t_bd_item_setup>()
                .Property(e => e.branch_price)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<t_bd_item_setup>()
                .Property(e => e.item_rem)
                .IsUnicode(false);

            modelBuilder.Entity<t_bd_item_setup>()
                .Property(e => e.vip_price)
                .HasPrecision(16, 4);

            modelBuilder.Entity<t_bd_item_setup>()
                .Property(e => e.sale_min_price)
                .HasPrecision(16, 4);

            modelBuilder.Entity<t_bd_item_setup>()
                .Property(e => e.com_flag)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<t_bd_item_setup>()
                .Property(e => e.vip_acc_flag)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<t_bd_item_setup>()
                .Property(e => e.vip_acc_num)
                .HasPrecision(16, 4);

            modelBuilder.Entity<t_bd_item_setup>()
                .Property(e => e.dpfm_type)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<t_bd_item_setup>()
                .Property(e => e.return_rate)
                .HasPrecision(16, 4);

            modelBuilder.Entity<t_bd_item_setup>()
                .Property(e => e.update_date)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<t_bd_item_setup>()
                .Property(e => e.pro_code1)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<t_bd_item_setup>()
                .Property(e => e.pro_code2)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<t_bd_item_setup>()
                .Property(e => e.pro_code3)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<t_bd_item_setup>()
                .Property(e => e.pro_code4)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<t_bd_item_setup>()
                .Property(e => e.pro_code5)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<t_bd_item_setup>()
                .Property(e => e.pro_code6)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<t_bd_item_setup>()
                .Property(e => e.en_gift)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<t_bd_item_setup>()
                .Property(e => e.promote_flag)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<t_bd_item_setup1>()
                .Property(e => e.item_no)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<t_bd_item_setup1>()
                .Property(e => e.item_subno)
                .IsUnicode(false);

            modelBuilder.Entity<t_bd_item_setup1>()
                .Property(e => e.item_name)
                .IsUnicode(false);

            modelBuilder.Entity<t_bd_item_setup1>()
                .Property(e => e.item_subname)
                .IsUnicode(false);

            modelBuilder.Entity<t_bd_item_setup1>()
                .Property(e => e.item_clsno)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<t_bd_item_setup1>()
                .Property(e => e.item_brand)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<t_bd_item_setup1>()
                .Property(e => e.item_brandname)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<t_bd_item_setup1>()
                .Property(e => e.unit_no)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<t_bd_item_setup1>()
                .Property(e => e.item_size)
                .IsUnicode(false);

            modelBuilder.Entity<t_bd_item_setup1>()
                .Property(e => e.product_area)
                .IsUnicode(false);

            modelBuilder.Entity<t_bd_item_setup1>()
                .Property(e => e.price)
                .HasPrecision(16, 4);

            modelBuilder.Entity<t_bd_item_setup1>()
                .Property(e => e.base_price)
                .HasPrecision(16, 4);

            modelBuilder.Entity<t_bd_item_setup1>()
                .Property(e => e.sale_price)
                .HasPrecision(16, 4);

            modelBuilder.Entity<t_bd_item_setup1>()
                .Property(e => e.combine_sta)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<t_bd_item_setup1>()
                .Property(e => e.status)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<t_bd_item_setup1>()
                .Property(e => e.display_flag)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<t_bd_item_setup1>()
                .Property(e => e.other1)
                .IsUnicode(false);

            modelBuilder.Entity<t_bd_item_setup1>()
                .Property(e => e.other2)
                .IsUnicode(false);

            modelBuilder.Entity<t_bd_item_setup1>()
                .Property(e => e.other3)
                .IsUnicode(false);

            modelBuilder.Entity<t_bd_item_setup1>()
                .Property(e => e.num1)
                .HasPrecision(16, 4);

            modelBuilder.Entity<t_bd_item_setup1>()
                .Property(e => e.num2)
                .HasPrecision(16, 4);

            modelBuilder.Entity<t_bd_item_setup1>()
                .Property(e => e.num3)
                .HasPrecision(16, 4);

            modelBuilder.Entity<t_bd_item_setup1>()
                .Property(e => e.automin_flag)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<t_bd_item_setup1>()
                .Property(e => e.en_dis)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<t_bd_item_setup1>()
                .Property(e => e.direct)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<t_bd_item_setup1>()
                .Property(e => e.change_price)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<t_bd_item_setup1>()
                .Property(e => e.purchase_tax)
                .HasPrecision(4, 2);

            modelBuilder.Entity<t_bd_item_setup1>()
                .Property(e => e.sale_tax)
                .HasPrecision(4, 2);

            modelBuilder.Entity<t_bd_item_setup1>()
                .Property(e => e.purchase_spec)
                .HasPrecision(8, 2);

            modelBuilder.Entity<t_bd_item_setup1>()
                .Property(e => e.shipment_spec)
                .HasPrecision(8, 2);

            modelBuilder.Entity<t_bd_item_setup1>()
                .Property(e => e.item_supcust)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<t_bd_item_setup1>()
                .Property(e => e.main_supcust)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<t_bd_item_setup1>()
                .Property(e => e.lose_rate)
                .HasPrecision(6, 4);

            modelBuilder.Entity<t_bd_item_setup1>()
                .Property(e => e.item_sup_flag)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<t_bd_item_setup1>()
                .Property(e => e.item_stock)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<t_bd_item_setup1>()
                .Property(e => e.item_counter)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<t_bd_item_setup1>()
                .Property(e => e.sup_ly_rate)
                .HasPrecision(16, 4);

            modelBuilder.Entity<t_bd_item_setup1>()
                .Property(e => e.build_date)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<t_bd_item_setup1>()
                .Property(e => e.modify_date)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<t_bd_item_setup1>()
                .Property(e => e.stop_date)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<t_bd_item_setup1>()
                .Property(e => e.return_rate)
                .HasPrecision(16, 4);

            modelBuilder.Entity<t_bd_item_setup1>()
                .Property(e => e.abc)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<t_bd_item_setup1>()
                .Property(e => e.branch_price)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<t_bd_item_setup1>()
                .Property(e => e.item_rem)
                .IsUnicode(false);

            modelBuilder.Entity<t_bd_item_setup1>()
                .Property(e => e.vip_price)
                .HasPrecision(16, 4);

            modelBuilder.Entity<t_bd_item_setup1>()
                .Property(e => e.sale_min_price)
                .HasPrecision(16, 4);

            modelBuilder.Entity<t_bd_item_setup1>()
                .Property(e => e.branch_no)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<t_bd_item_setup1>()
                .Property(e => e.cost_compute)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<t_bd_item_setup1>()
                .Property(e => e.com_flag)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<t_bd_item_setup1>()
                .Property(e => e.vip_acc_flag)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<t_bd_item_setup1>()
                .Property(e => e.vip_acc_num)
                .HasPrecision(16, 4);

            modelBuilder.Entity<t_bd_item_setup1>()
                .Property(e => e.dpfm_type)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<t_bd_item_update_flow>()
                .Property(e => e.flow_no)
                .HasPrecision(6, 0);

            modelBuilder.Entity<t_bd_item_update_flow>()
                .Property(e => e.old_itemno)
                .IsUnicode(false);

            modelBuilder.Entity<t_bd_item_update_flow>()
                .Property(e => e.new_itemno)
                .IsUnicode(false);

            modelBuilder.Entity<t_bd_item_update_flow>()
                .Property(e => e.item_name)
                .IsUnicode(false);

            modelBuilder.Entity<t_bd_item_update_flow>()
                .Property(e => e.oper_id)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<t_bd_item_update_flow>()
                .Property(e => e.flag)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<t_bd_item_update_flow>()
                .Property(e => e.type)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<t_bd_item_update_flow>()
                .Property(e => e.memo)
                .IsUnicode(false);

            modelBuilder.Entity<t_bd_item_update_flow>()
                .Property(e => e.com_flag)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<t_bd_payment_info>()
                .Property(e => e.pay_way)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<t_bd_payment_info>()
                .Property(e => e.pay_flag)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<t_bd_payment_info>()
                .Property(e => e.pay_name)
                .IsUnicode(false);

            modelBuilder.Entity<t_bd_payment_info>()
                .Property(e => e.rate)
                .HasPrecision(10, 4);

            modelBuilder.Entity<t_bd_payment_info>()
                .Property(e => e.default_amt)
                .HasPrecision(16, 4);

            modelBuilder.Entity<t_bd_payment_info>()
                .Property(e => e.acc_flag)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<t_bd_payment_info>()
                .Property(e => e.jf_flag)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<t_bd_payment_info>()
                .Property(e => e.pay_memo)
                .IsUnicode(false);

            modelBuilder.Entity<t_bd_payment_info_breakpoint>()
                .Property(e => e.com_no)
                .HasPrecision(18, 0);

            modelBuilder.Entity<t_bd_payment_info_breakpoint>()
                .Property(e => e.change_type)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<t_bd_payment_info_breakpoint>()
                .Property(e => e.pay_way)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<t_bd_payment_info_breakpoint>()
                .Property(e => e.pay_flag)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<t_bd_place_info>()
                .Property(e => e.place_no)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<t_bd_place_info>()
                .Property(e => e.place_name)
                .IsUnicode(false);

            modelBuilder.Entity<t_bd_place_info>()
                .Property(e => e.branch_no)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<t_bd_place_info>()
                .Property(e => e.place_notes)
                .IsUnicode(false);

            modelBuilder.Entity<t_bd_place_info>()
                .Property(e => e.usable_flag)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<t_bd_place_info>()
                .Property(e => e.super_place_no)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<t_bd_place_item_info>()
                .Property(e => e.place_no)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<t_bd_place_item_info>()
                .Property(e => e.item_no)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<t_bd_place_item_info>()
                .Property(e => e.branch_no)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<t_bd_supcust_area>()
                .Property(e => e.supcust_clsno)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<t_bd_supcust_area>()
                .Property(e => e.supcust_clsname)
                .IsUnicode(false);

            modelBuilder.Entity<t_bd_supcust_area>()
                .Property(e => e.supcust_flag)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<t_bd_supcust_area>()
                .Property(e => e.supcust_cls_parent)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<t_bd_supcust_area>()
                .Property(e => e.supcust_display_flag)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<t_bd_supcust_area>()
                .Property(e => e.supcust_comp_rate)
                .HasPrecision(16, 4);

            modelBuilder.Entity<t_bd_supcust_cls>()
                .Property(e => e.item_no)
                .IsUnicode(false);

            modelBuilder.Entity<t_bd_supcust_cls>()
                .Property(e => e.supcust_no)
                .IsUnicode(false);

            modelBuilder.Entity<t_bd_supcust_cls>()
                .Property(e => e.use_way)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<t_bd_supcust_cls>()
                .Property(e => e.memo)
                .IsUnicode(false);

            modelBuilder.Entity<t_bd_supcust_info>()
                .Property(e => e.supcust_no)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<t_bd_supcust_info>()
                .Property(e => e.supcust_flag)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<t_bd_supcust_info>()
                .Property(e => e.sup_name)
                .IsUnicode(false);

            modelBuilder.Entity<t_bd_supcust_info>()
                .Property(e => e.region_no)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<t_bd_supcust_info>()
                .Property(e => e.sup_type)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<t_bd_supcust_info>()
                .Property(e => e.sup_man)
                .IsUnicode(false);

            modelBuilder.Entity<t_bd_supcust_info>()
                .Property(e => e.sup_addr)
                .IsUnicode(false);

            modelBuilder.Entity<t_bd_supcust_info>()
                .Property(e => e.zip)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<t_bd_supcust_info>()
                .Property(e => e.sup_email)
                .IsUnicode(false);

            modelBuilder.Entity<t_bd_supcust_info>()
                .Property(e => e.sup_tel)
                .IsUnicode(false);

            modelBuilder.Entity<t_bd_supcust_info>()
                .Property(e => e.sup_fax)
                .IsUnicode(false);

            modelBuilder.Entity<t_bd_supcust_info>()
                .Property(e => e.sup_acct_back)
                .IsUnicode(false);

            modelBuilder.Entity<t_bd_supcust_info>()
                .Property(e => e.sup_acct_no)
                .IsUnicode(false);

            modelBuilder.Entity<t_bd_supcust_info>()
                .Property(e => e.sup_tax_no)
                .IsUnicode(false);

            modelBuilder.Entity<t_bd_supcust_info>()
                .Property(e => e.display_flag)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<t_bd_supcust_info>()
                .Property(e => e.check_out_flag)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<t_bd_supcust_info>()
                .Property(e => e.check_out_date)
                .HasPrecision(2, 0);

            modelBuilder.Entity<t_bd_supcust_info>()
                .Property(e => e.check_out_day)
                .HasPrecision(3, 0);

            modelBuilder.Entity<t_bd_supcust_info>()
                .Property(e => e.credit_amt)
                .HasPrecision(16, 4);

            modelBuilder.Entity<t_bd_supcust_info>()
                .Property(e => e.sub_no)
                .IsUnicode(false);

            modelBuilder.Entity<t_bd_supcust_info>()
                .Property(e => e.pay_flag)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<t_bd_supcust_info>()
                .Property(e => e.order_flag)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<t_bd_supcust_info>()
                .Property(e => e.acc_level)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<t_bd_supcust_info>()
                .Property(e => e.reg_type)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<t_bd_supcust_info>()
                .Property(e => e.oper_id)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<t_bd_supcust_info>()
                .Property(e => e.purchase_week)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<t_bd_supcust_info>()
                .Property(e => e.sale_way)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<t_bd_supcust_info>()
                .Property(e => e.shopcard)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<t_bd_supcust_info>()
                .Property(e => e.settle_branch)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<t_bd_supcust_info>()
                .Property(e => e.com_flag)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<t_bd_supcust_info>()
                .Property(e => e.mobile)
                .IsUnicode(false);

            modelBuilder.Entity<t_bd_supcust_info>()
                .Property(e => e.discount)
                .HasPrecision(8, 4);

            modelBuilder.Entity<t_bd_supcust_info>()
                .Property(e => e.trans_flag)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<t_bd_supcust_info>()
                .Property(e => e.vip_card_id)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<t_bd_supcust_info>()
                .Property(e => e.memo)
                .IsUnicode(false);

            modelBuilder.Entity<t_bd_supcust_info>()
                .Property(e => e.receive_management)
                .IsUnicode(false);

            modelBuilder.Entity<t_bd_supcust_info>()
                .Property(e => e.mbranch_no)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<t_bd_supcust_info>()
                .Property(e => e.use_way)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<t_bd_supcust_item>()
                .Property(e => e.item_no)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<t_bd_supcust_item>()
                .Property(e => e.supcust_no)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<t_bd_supcust_item>()
                .Property(e => e.appointed_price)
                .HasPrecision(16, 4);

            modelBuilder.Entity<t_bd_supcust_item>()
                .Property(e => e.top_price)
                .HasPrecision(16, 4);

            modelBuilder.Entity<t_bd_supcust_item>()
                .Property(e => e.bottom_price)
                .HasPrecision(16, 4);

            modelBuilder.Entity<t_bd_supcust_item>()
                .Property(e => e.last_price)
                .HasPrecision(16, 4);

            modelBuilder.Entity<t_bd_supcust_item>()
                .Property(e => e.memo)
                .IsUnicode(false);

            modelBuilder.Entity<t_bd_supcust_item>()
                .Property(e => e.use_way)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<t_bd_supcust_saleway>()
                .Property(e => e.code_id)
                .IsUnicode(false);

            modelBuilder.Entity<t_bd_supcust_saleway>()
                .Property(e => e.code_name)
                .IsUnicode(false);

            modelBuilder.Entity<t_bd_supcust_saleway>()
                .Property(e => e.note)
                .IsUnicode(false);

            modelBuilder.Entity<t_cm_da_jxc_daysum>()
                .Property(e => e.item_no)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<t_cm_da_jxc_daysum>()
                .Property(e => e.oper_date)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<t_cm_da_jxc_daysum>()
                .Property(e => e.branch_no)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<t_cm_da_jxc_daysum>()
                .Property(e => e.cost_price)
                .HasPrecision(16, 4);

            modelBuilder.Entity<t_cm_da_jxc_daysum>()
                .Property(e => e.init_qty)
                .HasPrecision(16, 4);

            modelBuilder.Entity<t_cm_da_jxc_daysum>()
                .Property(e => e.init_amt)
                .HasPrecision(16, 4);

            modelBuilder.Entity<t_cm_da_jxc_daysum>()
                .Property(e => e.init_amt2)
                .HasPrecision(16, 4);

            modelBuilder.Entity<t_cm_da_jxc_daysum>()
                .Property(e => e.avg_cost_amt)
                .HasPrecision(16, 4);

            modelBuilder.Entity<t_cm_da_jxc_daysum>()
                .Property(e => e.avg_profit_amt)
                .HasPrecision(16, 4);

            modelBuilder.Entity<t_cm_da_jxc_daysum>()
                .Property(e => e.pi_qty)
                .HasPrecision(16, 4);

            modelBuilder.Entity<t_cm_da_jxc_daysum>()
                .Property(e => e.pi_amt)
                .HasPrecision(16, 4);

            modelBuilder.Entity<t_cm_da_jxc_daysum>()
                .Property(e => e.so_qty)
                .HasPrecision(16, 4);

            modelBuilder.Entity<t_cm_da_jxc_daysum>()
                .Property(e => e.so_amt)
                .HasPrecision(16, 4);

            modelBuilder.Entity<t_cm_da_jxc_daysum>()
                .Property(e => e.mi_qty)
                .HasPrecision(16, 4);

            modelBuilder.Entity<t_cm_da_jxc_daysum>()
                .Property(e => e.mi_amt)
                .HasPrecision(16, 4);

            modelBuilder.Entity<t_cm_da_jxc_daysum>()
                .Property(e => e.mo_qty)
                .HasPrecision(16, 4);

            modelBuilder.Entity<t_cm_da_jxc_daysum>()
                .Property(e => e.mo_amt)
                .HasPrecision(16, 4);

            modelBuilder.Entity<t_cm_da_jxc_daysum>()
                .Property(e => e.di_qty)
                .HasPrecision(16, 4);

            modelBuilder.Entity<t_cm_da_jxc_daysum>()
                .Property(e => e.di_amt)
                .HasPrecision(16, 4);

            modelBuilder.Entity<t_cm_da_jxc_daysum>()
                .Property(e => e.do_qty)
                .HasPrecision(16, 4);

            modelBuilder.Entity<t_cm_da_jxc_daysum>()
                .Property(e => e.do_amt)
                .HasPrecision(16, 4);

            modelBuilder.Entity<t_cm_da_jxc_daysum>()
                .Property(e => e.pos_qty)
                .HasPrecision(16, 4);

            modelBuilder.Entity<t_cm_da_jxc_daysum>()
                .Property(e => e.pos_amt)
                .HasPrecision(16, 4);

            modelBuilder.Entity<t_cm_da_jxc_daysum>()
                .Property(e => e.pos_ret_qty)
                .HasPrecision(16, 4);

            modelBuilder.Entity<t_cm_da_jxc_daysum>()
                .Property(e => e.pos_ret_amt)
                .HasPrecision(16, 4);

            modelBuilder.Entity<t_cm_da_jxc_daysum>()
                .Property(e => e.pos_send_qty)
                .HasPrecision(16, 4);

            modelBuilder.Entity<t_cm_da_jxc_daysum>()
                .Property(e => e.pos_send_amt)
                .HasPrecision(16, 4);

            modelBuilder.Entity<t_cm_da_jxc_daysum>()
                .Property(e => e.oo_qty)
                .HasPrecision(16, 4);

            modelBuilder.Entity<t_cm_da_jxc_daysum>()
                .Property(e => e.oo_amt)
                .HasPrecision(16, 4);

            modelBuilder.Entity<t_cm_da_jxc_daysum>()
                .Property(e => e.settle_qty)
                .HasPrecision(16, 4);

            modelBuilder.Entity<t_cm_da_jxc_daysum>()
                .Property(e => e.settle_amt)
                .HasPrecision(16, 4);

            modelBuilder.Entity<t_cm_da_jxc_daysum>()
                .Property(e => e.settle_amt2)
                .HasPrecision(16, 4);

            modelBuilder.Entity<t_cm_da_jxc_daysum>()
                .Property(e => e.cost_change_amt)
                .HasPrecision(16, 4);

            modelBuilder.Entity<t_cm_da_jxc_daysum>()
                .Property(e => e.pos_dct_amt)
                .HasPrecision(16, 4);

            modelBuilder.Entity<t_cm_da_jxc_daysum>()
                .Property(e => e.main_sup)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<t_cm_da_jxc_daysum>()
                .Property(e => e.dec_rate)
                .HasPrecision(16, 4);

            modelBuilder.Entity<t_cm_da_jxc_daysum>()
                .Property(e => e.so_price)
                .HasPrecision(16, 4);

            modelBuilder.Entity<t_cm_da_jxc_daysum>()
                .Property(e => e.sale_price)
                .HasPrecision(16, 4);

            modelBuilder.Entity<t_cm_da_jxc_daysum>()
                .Property(e => e.com_flag)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<t_cm_da_jxc_daysum>()
                .Property(e => e.item_sup_flag)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<t_cm_da_jxc_daysum>()
                .Property(e => e.sup_ly_rate)
                .HasPrecision(16, 4);

            modelBuilder.Entity<t_cm_da_jxc_daysum>()
                .Property(e => e.flag)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<t_cm_da_jxc_daysum>()
                .Property(e => e.flow_id)
                .HasPrecision(18, 0);

            modelBuilder.Entity<t_cm_fm_charge_detail>()
                .Property(e => e.flow_id)
                .HasPrecision(14, 0);

            modelBuilder.Entity<t_cm_fm_charge_detail>()
                .Property(e => e.sheet_no)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<t_cm_fm_charge_detail>()
                .Property(e => e.charge_no)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<t_cm_fm_charge_detail>()
                .Property(e => e.sub_amt)
                .HasPrecision(16, 4);

            modelBuilder.Entity<t_cm_fm_charge_detail>()
                .Property(e => e.remark)
                .IsUnicode(false);

            modelBuilder.Entity<t_cm_fm_charge_master>()
                .Property(e => e.sheet_no)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<t_cm_fm_charge_master>()
                .Property(e => e.supcust_no)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<t_cm_fm_charge_master>()
                .Property(e => e.acc_type)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<t_cm_fm_charge_master>()
                .Property(e => e.voucher_no)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<t_cm_fm_charge_master>()
                .Property(e => e.trans_no)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<t_cm_fm_charge_master>()
                .Property(e => e.memo)
                .IsUnicode(false);

            modelBuilder.Entity<t_cm_fm_charge_master>()
                .Property(e => e.oper_id)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<t_cm_fm_charge_master>()
                .Property(e => e.approve_flag)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<t_cm_fm_charge_master>()
                .Property(e => e.confirm_man)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<t_cm_fm_charge_master>()
                .Property(e => e.is_internal)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<t_cm_fm_charge_master>()
                .Property(e => e.sheet_amt)
                .HasPrecision(16, 4);

            modelBuilder.Entity<t_cm_fm_charge_master>()
                .Property(e => e.com_flag)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<t_cm_fm_charge_master>()
                .Property(e => e.branch_no)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<t_cm_fm_recpay_detail>()
                .Property(e => e.flow_id)
                .HasPrecision(14, 0);

            modelBuilder.Entity<t_cm_fm_recpay_detail>()
                .Property(e => e.sheet_no)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<t_cm_fm_recpay_detail>()
                .Property(e => e.voucher_no)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<t_cm_fm_recpay_detail>()
                .Property(e => e.discount)
                .HasPrecision(5, 4);

            modelBuilder.Entity<t_cm_fm_recpay_detail>()
                .Property(e => e.sheet_amt)
                .HasPrecision(16, 4);

            modelBuilder.Entity<t_cm_fm_recpay_detail>()
                .Property(e => e.coin_no)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<t_cm_fm_recpay_detail>()
                .Property(e => e.sheet_amt_native)
                .HasPrecision(16, 4);

            modelBuilder.Entity<t_cm_fm_recpay_detail>()
                .Property(e => e.memo)
                .IsUnicode(false);

            modelBuilder.Entity<t_cm_fm_recpay_detail>()
                .Property(e => e.other_amt)
                .HasPrecision(16, 4);

            modelBuilder.Entity<t_cm_fm_recpay_detail>()
                .Property(e => e.chr_selected)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<t_cm_fm_recpay_flow>()
                .Property(e => e.flow_id)
                .HasPrecision(18, 0);

            modelBuilder.Entity<t_cm_fm_recpay_flow>()
                .Property(e => e.voucher_no)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<t_cm_fm_recpay_flow>()
                .Property(e => e.trans_no)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<t_cm_fm_recpay_flow>()
                .Property(e => e.coin_no)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<t_cm_fm_recpay_flow>()
                .Property(e => e.discount)
                .HasPrecision(5, 4);

            modelBuilder.Entity<t_cm_fm_recpay_flow>()
                .Property(e => e.sheet_amt)
                .HasPrecision(16, 4);

            modelBuilder.Entity<t_cm_fm_recpay_flow>()
                .Property(e => e.should_amt)
                .HasPrecision(16, 4);

            modelBuilder.Entity<t_cm_fm_recpay_flow>()
                .Property(e => e.already_amt)
                .HasPrecision(16, 4);

            modelBuilder.Entity<t_cm_fm_recpay_flow>()
                .Property(e => e.paid_sheetno)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<t_cm_fm_recpay_flow>()
                .Property(e => e.tax_amt)
                .HasPrecision(16, 4);

            modelBuilder.Entity<t_cm_fm_recpay_flow>()
                .Property(e => e.pay_way)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<t_cm_fm_recpay_flow>()
                .Property(e => e.sale_way)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<t_cm_fm_recpay_flow>()
                .Property(e => e.pay_percent)
                .HasPrecision(5, 4);

            modelBuilder.Entity<t_cm_fm_recpay_flow>()
                .Property(e => e.settle_flag)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<t_cm_fm_recpay_flow>()
                .Property(e => e.supcust_no)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<t_cm_fm_recpay_flow>()
                .Property(e => e.memo)
                .IsUnicode(false);

            modelBuilder.Entity<t_cm_fm_recpay_flow>()
                .Property(e => e.com_flag)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<t_cm_fm_recpay_flow>()
                .Property(e => e.branch_no)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<t_cm_fm_recpay_flow>()
                .Property(e => e.acc_type)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<t_cm_fm_recpay_flow>()
                .Property(e => e.other_amt)
                .HasPrecision(16, 4);

            modelBuilder.Entity<t_cm_fm_recpay_master>()
                .Property(e => e.sheet_no)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<t_cm_fm_recpay_master>()
                .Property(e => e.trans_no)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<t_cm_fm_recpay_master>()
                .Property(e => e.supcust_no)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<t_cm_fm_recpay_master>()
                .Property(e => e.acc_type)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<t_cm_fm_recpay_master>()
                .Property(e => e.sheet_amt)
                .HasPrecision(16, 4);

            modelBuilder.Entity<t_cm_fm_recpay_master>()
                .Property(e => e.is_bysheet)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<t_cm_fm_recpay_master>()
                .Property(e => e.pay_way)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<t_cm_fm_recpay_master>()
                .Property(e => e.approve_flag)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<t_cm_fm_recpay_master>()
                .Property(e => e.oper_id)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<t_cm_fm_recpay_master>()
                .Property(e => e.confirm_man)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<t_cm_fm_recpay_master>()
                .Property(e => e.flag_post)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<t_cm_fm_recpay_master>()
                .Property(e => e.com_flag)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<t_cm_fm_recpay_master>()
                .Property(e => e.branch_no)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<t_cm_fm_recpay_master>()
                .Property(e => e.memo)
                .IsUnicode(false);

            modelBuilder.Entity<t_cm_fm_recpay_master>()
                .Property(e => e.other_amt)
                .HasPrecision(16, 4);

            modelBuilder.Entity<t_cm_im_branch_stock>()
                .Property(e => e.flow_id)
                .HasPrecision(18, 0);

            modelBuilder.Entity<t_cm_im_branch_stock>()
                .Property(e => e.item_no)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<t_cm_im_branch_stock>()
                .Property(e => e.branch_no)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<t_cm_im_branch_stock>()
                .Property(e => e.stock_qty)
                .HasPrecision(16, 4);

            modelBuilder.Entity<t_cm_im_branch_stock>()
                .Property(e => e.route_qty)
                .HasPrecision(16, 4);

            modelBuilder.Entity<t_cm_im_branch_stock>()
                .Property(e => e.avg_cost)
                .HasPrecision(16, 4);

            modelBuilder.Entity<t_cm_im_branch_stock>()
                .Property(e => e.cost_amt)
                .HasPrecision(16, 4);

            modelBuilder.Entity<t_cm_im_branch_stock>()
                .Property(e => e.last_inprice)
                .HasPrecision(16, 4);

            modelBuilder.Entity<t_cm_im_branch_stock>()
                .Property(e => e.last_baseprice)
                .HasPrecision(16, 4);

            modelBuilder.Entity<t_cm_im_branch_stock>()
                .Property(e => e.min_qty)
                .HasPrecision(16, 4);

            modelBuilder.Entity<t_cm_im_branch_stock>()
                .Property(e => e.max_qty)
                .HasPrecision(16, 4);

            modelBuilder.Entity<t_cm_im_branch_stock>()
                .Property(e => e.acc_qty)
                .HasPrecision(16, 4);

            modelBuilder.Entity<t_cm_im_branch_stock>()
                .Property(e => e.com_flag)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<t_cm_im_branch_stock_fix>()
                .Property(e => e.item_no)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<t_cm_im_branch_stock_fix>()
                .Property(e => e.branch_no)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<t_cm_im_branch_stock_fix>()
                .Property(e => e.stock_qty)
                .HasPrecision(16, 4);

            modelBuilder.Entity<t_cm_im_branch_stock_fix>()
                .Property(e => e.route_qty)
                .HasPrecision(16, 4);

            modelBuilder.Entity<t_cm_im_branch_stock_fix>()
                .Property(e => e.avg_cost)
                .HasPrecision(16, 4);

            modelBuilder.Entity<t_cm_im_branch_stock_fix>()
                .Property(e => e.cost_amt)
                .HasPrecision(16, 4);

            modelBuilder.Entity<t_cm_im_branch_stock_fix>()
                .Property(e => e.last_inprice)
                .HasPrecision(16, 4);

            modelBuilder.Entity<t_cm_im_branch_stock_fix>()
                .Property(e => e.last_baseprice)
                .HasPrecision(16, 4);

            modelBuilder.Entity<t_cm_im_branch_stock_fix>()
                .Property(e => e.min_qty)
                .HasPrecision(16, 4);

            modelBuilder.Entity<t_cm_im_branch_stock_fix>()
                .Property(e => e.max_qty)
                .HasPrecision(16, 4);

            modelBuilder.Entity<t_cm_im_branch_stock_fix>()
                .Property(e => e.acc_qty)
                .HasPrecision(16, 4);

            modelBuilder.Entity<t_cm_im_branch_stock_fix>()
                .Property(e => e.com_flag)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<t_cm_im_check_detail>()
                .Property(e => e.flow_id)
                .HasPrecision(14, 0);

            modelBuilder.Entity<t_cm_im_check_detail>()
                .Property(e => e.sheet_no)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<t_cm_im_check_detail>()
                .Property(e => e.item_no)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<t_cm_im_check_detail>()
                .Property(e => e.in_price)
                .HasPrecision(16, 4);

            modelBuilder.Entity<t_cm_im_check_detail>()
                .Property(e => e.sale_price)
                .HasPrecision(16, 4);

            modelBuilder.Entity<t_cm_im_check_detail>()
                .Property(e => e.real_qty)
                .HasPrecision(16, 4);

            modelBuilder.Entity<t_cm_im_check_detail>()
                .Property(e => e.recheck_qty)
                .HasPrecision(16, 4);

            modelBuilder.Entity<t_cm_im_check_detail>()
                .Property(e => e.memo)
                .IsUnicode(false);

            modelBuilder.Entity<t_cm_im_check_init>()
                .Property(e => e.sheet_no)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<t_cm_im_check_init>()
                .Property(e => e.oper_range)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<t_cm_im_check_init>()
                .Property(e => e.branch_no)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<t_cm_im_check_init>()
                .Property(e => e.check_cls)
                .IsUnicode(false);

            modelBuilder.Entity<t_cm_im_check_init>()
                .Property(e => e.oper_id)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<t_cm_im_check_init>()
                .Property(e => e.confirm_man)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<t_cm_im_check_init>()
                .Property(e => e.approve_flag)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<t_cm_im_check_init>()
                .Property(e => e.memo)
                .IsUnicode(false);

            modelBuilder.Entity<t_cm_im_check_init>()
                .Property(e => e.sheet_amt)
                .HasPrecision(16, 4);

            modelBuilder.Entity<t_cm_im_check_init>()
                .Property(e => e.branch_flag)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<t_cm_im_check_init>()
                .Property(e => e.com_flag)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<t_cm_im_check_init>()
                .Property(e => e.other1)
                .IsUnicode(false);

            modelBuilder.Entity<t_cm_im_check_master>()
                .Property(e => e.sheet_no)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<t_cm_im_check_master>()
                .Property(e => e.check_no)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<t_cm_im_check_master>()
                .Property(e => e.trans_no)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<t_cm_im_check_master>()
                .Property(e => e.branch_no)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<t_cm_im_check_master>()
                .Property(e => e.oper_range)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<t_cm_im_check_master>()
                .Property(e => e.dup_process)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<t_cm_im_check_master>()
                .Property(e => e.oper_id)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<t_cm_im_check_master>()
                .Property(e => e.confirm_man)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<t_cm_im_check_master>()
                .Property(e => e.approve_flag)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<t_cm_im_check_master>()
                .Property(e => e.check_cls)
                .IsUnicode(false);

            modelBuilder.Entity<t_cm_im_check_master>()
                .Property(e => e.meno)
                .IsUnicode(false);

            modelBuilder.Entity<t_cm_im_check_master>()
                .Property(e => e.sheet_amt)
                .HasPrecision(16, 4);

            modelBuilder.Entity<t_cm_im_check_master>()
                .Property(e => e.branch_flag)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<t_cm_im_check_master>()
                .Property(e => e.com_flag)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<t_cm_im_check_sum>()
                .Property(e => e.flow_id)
                .HasPrecision(18, 0);

            modelBuilder.Entity<t_cm_im_check_sum>()
                .Property(e => e.sheet_no)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<t_cm_im_check_sum>()
                .Property(e => e.branch_no)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<t_cm_im_check_sum>()
                .Property(e => e.item_no)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<t_cm_im_check_sum>()
                .Property(e => e.in_price)
                .HasPrecision(16, 4);

            modelBuilder.Entity<t_cm_im_check_sum>()
                .Property(e => e.sale_price)
                .HasPrecision(16, 4);

            modelBuilder.Entity<t_cm_im_check_sum>()
                .Property(e => e.stock_qty)
                .HasPrecision(16, 4);

            modelBuilder.Entity<t_cm_im_check_sum>()
                .Property(e => e.check_qty)
                .HasPrecision(16, 4);

            modelBuilder.Entity<t_cm_im_check_sum>()
                .Property(e => e.balance_qty)
                .HasPrecision(16, 4);

            modelBuilder.Entity<t_cm_im_check_sum>()
                .Property(e => e.process_status)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<t_cm_im_check_sum>()
                .Property(e => e.memo)
                .IsUnicode(false);

            modelBuilder.Entity<t_cm_im_flow>()
                .Property(e => e.flow_id)
                .HasPrecision(14, 0);

            modelBuilder.Entity<t_cm_im_flow>()
                .Property(e => e.voucher_no)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<t_cm_im_flow>()
                .Property(e => e.item_no)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<t_cm_im_flow>()
                .Property(e => e.real_qty)
                .HasPrecision(16, 4);

            modelBuilder.Entity<t_cm_im_flow>()
                .Property(e => e.price)
                .HasPrecision(16, 4);

            modelBuilder.Entity<t_cm_im_flow>()
                .Property(e => e.cost_price)
                .HasPrecision(16, 4);

            modelBuilder.Entity<t_cm_im_flow>()
                .Property(e => e.sale_price)
                .HasPrecision(16, 4);

            modelBuilder.Entity<t_cm_im_flow>()
                .Property(e => e.sheet_amt)
                .HasPrecision(16, 4);

            modelBuilder.Entity<t_cm_im_flow>()
                .Property(e => e.branch_no)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<t_cm_im_flow>()
                .Property(e => e.d_branch_no)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<t_cm_im_flow>()
                .Property(e => e.trans_no)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<t_cm_im_flow>()
                .Property(e => e.db_no)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<t_cm_im_flow>()
                .Property(e => e.supcust_no)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<t_cm_im_flow>()
                .Property(e => e.sale_way)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<t_cm_im_flow>()
                .Property(e => e.oper_id)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<t_cm_im_flow>()
                .Property(e => e.pre_qnty)
                .HasPrecision(16, 4);

            modelBuilder.Entity<t_cm_im_flow>()
                .Property(e => e.memo)
                .IsUnicode(false);

            modelBuilder.Entity<t_cm_im_flow>()
                .Property(e => e.com_flag)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<t_cm_im_flow>()
                .Property(e => e.sup_ly_rate)
                .HasPrecision(16, 4);

            modelBuilder.Entity<t_cm_im_flow>()
                .Property(e => e.pay_flag)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<t_cm_im_flow>()
                .Property(e => e.sup_sale_way)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<t_cm_im_flow>()
                .Property(e => e.sup_no)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<t_cm_im_flow>()
                .Property(e => e.pos_id)
                .HasPrecision(3, 0);

            modelBuilder.Entity<t_cm_im_flow>()
                .Property(e => e.dpfm_type)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<t_cm_im_flow>()
                .Property(e => e.return_rate)
                .HasPrecision(16, 4);

            modelBuilder.Entity<t_cm_im_flow>()
                .Property(e => e.cls_no)
                .IsUnicode(false);

            modelBuilder.Entity<t_cm_im_flow>()
                .Property(e => e.cls_rate)
                .HasPrecision(16, 4);

            modelBuilder.Entity<t_cm_im_flow>()
                .Property(e => e.pp_no)
                .IsUnicode(false);

            modelBuilder.Entity<t_cm_im_flow>()
                .Property(e => e.pp_rate)
                .HasPrecision(16, 4);

            modelBuilder.Entity<t_cm_im_flow>()
                .Property(e => e.order_man)
                .IsUnicode(false);

            modelBuilder.Entity<t_cm_im_sheet_detail>()
                .Property(e => e.flow_id)
                .HasPrecision(14, 0);

            modelBuilder.Entity<t_cm_im_sheet_detail>()
                .Property(e => e.sheet_no)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<t_cm_im_sheet_detail>()
                .Property(e => e.item_no)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<t_cm_im_sheet_detail>()
                .Property(e => e.order_qty)
                .HasPrecision(16, 4);

            modelBuilder.Entity<t_cm_im_sheet_detail>()
                .Property(e => e.real_qty)
                .HasPrecision(16, 4);

            modelBuilder.Entity<t_cm_im_sheet_detail>()
                .Property(e => e.large_qty)
                .HasPrecision(16, 4);

            modelBuilder.Entity<t_cm_im_sheet_detail>()
                .Property(e => e.orgi_price)
                .HasPrecision(16, 4);

            modelBuilder.Entity<t_cm_im_sheet_detail>()
                .Property(e => e.valid_price)
                .HasPrecision(16, 4);

            modelBuilder.Entity<t_cm_im_sheet_detail>()
                .Property(e => e.sub_amt)
                .HasPrecision(16, 4);

            modelBuilder.Entity<t_cm_im_sheet_detail>()
                .Property(e => e.tax)
                .HasPrecision(5, 4);

            modelBuilder.Entity<t_cm_im_sheet_detail>()
                .Property(e => e.sale_price)
                .HasPrecision(16, 4);

            modelBuilder.Entity<t_cm_im_sheet_detail>()
                .Property(e => e.memo)
                .IsUnicode(false);

            modelBuilder.Entity<t_cm_im_sheet_master>()
                .Property(e => e.sheet_no)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<t_cm_im_sheet_master>()
                .Property(e => e.trans_no)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<t_cm_im_sheet_master>()
                .Property(e => e.db_no)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<t_cm_im_sheet_master>()
                .Property(e => e.branch_no)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<t_cm_im_sheet_master>()
                .Property(e => e.d_branch_no)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<t_cm_im_sheet_master>()
                .Property(e => e.voucher_no)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<t_cm_im_sheet_master>()
                .Property(e => e.supcust_no)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<t_cm_im_sheet_master>()
                .Property(e => e.coin_no)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<t_cm_im_sheet_master>()
                .Property(e => e.pay_way)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<t_cm_im_sheet_master>()
                .Property(e => e.approve_flag)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<t_cm_im_sheet_master>()
                .Property(e => e.order_man)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<t_cm_im_sheet_master>()
                .Property(e => e.oper_id)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<t_cm_im_sheet_master>()
                .Property(e => e.confirm_man)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<t_cm_im_sheet_master>()
                .Property(e => e.trans_flag)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<t_cm_im_sheet_master>()
                .Property(e => e.acct_flag)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<t_cm_im_sheet_master>()
                .Property(e => e.sheet_amt)
                .HasPrecision(16, 4);

            modelBuilder.Entity<t_cm_im_sheet_master>()
                .Property(e => e.branch_flag)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<t_cm_im_sheet_master>()
                .Property(e => e.com_flag)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<t_cm_im_sheet_master>()
                .Property(e => e.in_flag)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<t_cm_im_sheet_master>()
                .Property(e => e.memo)
                .IsUnicode(false);

            modelBuilder.Entity<t_cm_im_sheet_master>()
                .Property(e => e.other_appr_flag)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<t_cm_im_sheet_master>()
                .Property(e => e.other_appr_man)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<t_cm_im_sheet_master>()
                .Property(e => e.com_flag1)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<t_cm_pc_price_flow_detail>()
                .Property(e => e.flow_id)
                .HasPrecision(14, 0);

            modelBuilder.Entity<t_cm_pc_price_flow_detail>()
                .Property(e => e.sheet_no)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<t_cm_pc_price_flow_detail>()
                .Property(e => e.item_no)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<t_cm_pc_price_flow_detail>()
                .Property(e => e.price_type)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<t_cm_pc_price_flow_detail>()
                .Property(e => e.begin_time)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<t_cm_pc_price_flow_detail>()
                .Property(e => e.end_time)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<t_cm_pc_price_flow_detail>()
                .Property(e => e.week)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<t_cm_pc_price_flow_detail>()
                .Property(e => e.old_price)
                .HasPrecision(16, 4);

            modelBuilder.Entity<t_cm_pc_price_flow_detail>()
                .Property(e => e.new_price)
                .HasPrecision(16, 4);

            modelBuilder.Entity<t_cm_pc_price_flow_detail>()
                .Property(e => e.discount)
                .HasPrecision(5, 4);

            modelBuilder.Entity<t_cm_pc_price_flow_detail>()
                .Property(e => e.buy_qty)
                .HasPrecision(16, 4);

            modelBuilder.Entity<t_cm_pc_price_flow_detail>()
                .Property(e => e.limited_qty)
                .HasPrecision(16, 4);

            modelBuilder.Entity<t_cm_pc_price_flow_detail>()
                .Property(e => e.stock_qty)
                .HasPrecision(16, 4);

            modelBuilder.Entity<t_cm_pc_price_flow_detail>()
                .Property(e => e.dec_rate)
                .HasPrecision(16, 4);

            modelBuilder.Entity<t_cm_pc_price_flow_detail>()
                .Property(e => e.memo)
                .IsUnicode(false);

            modelBuilder.Entity<t_cm_pc_price_flow_detail>()
                .Property(e => e.old_price2)
                .HasPrecision(16, 4);

            modelBuilder.Entity<t_cm_pc_price_flow_detail>()
                .Property(e => e.new_price2)
                .HasPrecision(16, 4);

            modelBuilder.Entity<t_cm_pc_price_flow_detail>()
                .Property(e => e.old_price3)
                .HasPrecision(16, 4);

            modelBuilder.Entity<t_cm_pc_price_flow_detail>()
                .Property(e => e.new_price3)
                .HasPrecision(16, 4);

            modelBuilder.Entity<t_cm_pc_price_flow_detail>()
                .Property(e => e.old_price4)
                .HasPrecision(16, 4);

            modelBuilder.Entity<t_cm_pc_price_flow_detail>()
                .Property(e => e.new_price4)
                .HasPrecision(16, 4);

            modelBuilder.Entity<t_cm_pc_price_flow_detail>()
                .Property(e => e.old_vip1)
                .HasPrecision(16, 4);

            modelBuilder.Entity<t_cm_pc_price_flow_detail>()
                .Property(e => e.new_vip1)
                .HasPrecision(16, 4);

            modelBuilder.Entity<t_cm_pc_price_flow_detail>()
                .Property(e => e.old_vip2)
                .HasPrecision(16, 4);

            modelBuilder.Entity<t_cm_pc_price_flow_detail>()
                .Property(e => e.new_vip2)
                .HasPrecision(16, 4);

            modelBuilder.Entity<t_cm_pc_price_flow_detail>()
                .Property(e => e.old_vip3)
                .HasPrecision(16, 4);

            modelBuilder.Entity<t_cm_pc_price_flow_detail>()
                .Property(e => e.new_vip3)
                .HasPrecision(16, 4);

            modelBuilder.Entity<t_cm_pc_price_flow_detail>()
                .Property(e => e.old_vip4)
                .HasPrecision(16, 4);

            modelBuilder.Entity<t_cm_pc_price_flow_detail>()
                .Property(e => e.new_vip4)
                .HasPrecision(16, 4);

            modelBuilder.Entity<t_cm_pc_price_flow_detail>()
                .Property(e => e.old_vip5)
                .HasPrecision(16, 4);

            modelBuilder.Entity<t_cm_pc_price_flow_detail>()
                .Property(e => e.new_vip5)
                .HasPrecision(16, 4);

            modelBuilder.Entity<t_cm_pc_price_flow_detail>()
                .Property(e => e.group_no)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<t_cm_pc_price_flow_master>()
                .Property(e => e.sheet_no)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<t_cm_pc_price_flow_master>()
                .Property(e => e.branch_no)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<t_cm_pc_price_flow_master>()
                .Property(e => e.trans_no)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<t_cm_pc_price_flow_master>()
                .Property(e => e.vip_type)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<t_cm_pc_price_flow_master>()
                .Property(e => e.oper_id)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<t_cm_pc_price_flow_master>()
                .Property(e => e.confirm_man)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<t_cm_pc_price_flow_master>()
                .Property(e => e.valid_flag)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<t_cm_pc_price_flow_master>()
                .Property(e => e.approve_flag)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<t_cm_pc_price_flow_master>()
                .Property(e => e.supcust_no)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<t_cm_pc_price_flow_master>()
                .Property(e => e.sheet_amt)
                .HasPrecision(16, 4);

            modelBuilder.Entity<t_cm_pc_price_flow_master>()
                .Property(e => e.branch_flag)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<t_cm_pc_price_flow_master>()
                .Property(e => e.week)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<t_cm_pc_price_flow_master>()
                .Property(e => e.reach_val)
                .HasPrecision(16, 2);

            modelBuilder.Entity<t_cm_pc_price_flow_master>()
                .Property(e => e.add_val)
                .HasPrecision(16, 2);

            modelBuilder.Entity<t_cm_pc_price_flow_master>()
                .Property(e => e.branch_list)
                .IsUnicode(false);

            modelBuilder.Entity<t_cm_pc_price_flow_master>()
                .Property(e => e.com_flag)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<t_cm_pc_price_flow_master>()
                .Property(e => e.memo)
                .IsUnicode(false);

            modelBuilder.Entity<t_cm_pc_price_flow_master>()
                .Property(e => e.reach_vip)
                .HasPrecision(16, 2);

            modelBuilder.Entity<t_cm_pc_price_flow_master>()
                .Property(e => e.branch_list2)
                .IsUnicode(false);

            modelBuilder.Entity<t_cm_pc_price_flow_master>()
                .Property(e => e.cls_flag)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<t_cm_pc_price_flow_master>()
                .Property(e => e.cls_list)
                .IsUnicode(false);

            modelBuilder.Entity<t_cm_pc_price_flow_master>()
                .Property(e => e.other1)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<t_cm_pc_price_flow_master>()
                .Property(e => e.other2)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<t_cm_pc_price_flow_master>()
                .Property(e => e.other3)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<t_cm_pm_sheet_detail>()
                .Property(e => e.flow_id)
                .HasPrecision(14, 0);

            modelBuilder.Entity<t_cm_pm_sheet_detail>()
                .Property(e => e.sheet_no)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<t_cm_pm_sheet_detail>()
                .Property(e => e.item_no)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<t_cm_pm_sheet_detail>()
                .Property(e => e.order_qty)
                .HasPrecision(16, 4);

            modelBuilder.Entity<t_cm_pm_sheet_detail>()
                .Property(e => e.real_qty)
                .HasPrecision(16, 4);

            modelBuilder.Entity<t_cm_pm_sheet_detail>()
                .Property(e => e.large_qty)
                .HasPrecision(16, 4);

            modelBuilder.Entity<t_cm_pm_sheet_detail>()
                .Property(e => e.orgi_price)
                .HasPrecision(16, 4);

            modelBuilder.Entity<t_cm_pm_sheet_detail>()
                .Property(e => e.valid_price)
                .HasPrecision(16, 4);

            modelBuilder.Entity<t_cm_pm_sheet_detail>()
                .Property(e => e.sub_amt)
                .HasPrecision(16, 4);

            modelBuilder.Entity<t_cm_pm_sheet_detail>()
                .Property(e => e.tax)
                .HasPrecision(5, 4);

            modelBuilder.Entity<t_cm_pm_sheet_detail>()
                .Property(e => e.send_qty)
                .HasPrecision(16, 4);

            modelBuilder.Entity<t_cm_pm_sheet_detail>()
                .Property(e => e.sale_price)
                .HasPrecision(16, 4);

            modelBuilder.Entity<t_cm_pm_sheet_detail>()
                .Property(e => e.come_num)
                .HasPrecision(16, 4);

            modelBuilder.Entity<t_cm_pm_sheet_detail>()
                .Property(e => e.memo)
                .IsUnicode(false);

            modelBuilder.Entity<t_cm_pm_sheet_detail>()
                .Property(e => e.base_price)
                .HasPrecision(16, 4);

            modelBuilder.Entity<t_cm_pm_sheet_master>()
                .Property(e => e.sheet_no)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<t_cm_pm_sheet_master>()
                .Property(e => e.trans_no)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<t_cm_pm_sheet_master>()
                .Property(e => e.db_no)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<t_cm_pm_sheet_master>()
                .Property(e => e.branch_no)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<t_cm_pm_sheet_master>()
                .Property(e => e.d_branch_no)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<t_cm_pm_sheet_master>()
                .Property(e => e.voucher_no)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<t_cm_pm_sheet_master>()
                .Property(e => e.supcust_no)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<t_cm_pm_sheet_master>()
                .Property(e => e.coin_no)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<t_cm_pm_sheet_master>()
                .Property(e => e.pay_way)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<t_cm_pm_sheet_master>()
                .Property(e => e.approve_flag)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<t_cm_pm_sheet_master>()
                .Property(e => e.order_amt)
                .HasPrecision(16, 4);

            modelBuilder.Entity<t_cm_pm_sheet_master>()
                .Property(e => e.order_status)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<t_cm_pm_sheet_master>()
                .Property(e => e.order_man)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<t_cm_pm_sheet_master>()
                .Property(e => e.oper_id)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<t_cm_pm_sheet_master>()
                .Property(e => e.confirm_man)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<t_cm_pm_sheet_master>()
                .Property(e => e.trans_flag)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<t_cm_pm_sheet_master>()
                .Property(e => e.acct_flag)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<t_cm_pm_sheet_master>()
                .Property(e => e.sheet_amt)
                .HasPrecision(16, 4);

            modelBuilder.Entity<t_cm_pm_sheet_master>()
                .Property(e => e.branch_flag)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<t_cm_pm_sheet_master>()
                .Property(e => e.com_flag)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<t_cm_pm_sheet_master>()
                .Property(e => e.in_flag)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<t_cm_pm_sheet_master>()
                .Property(e => e.memo)
                .IsUnicode(false);

            modelBuilder.Entity<t_cm_pm_sheet_master>()
                .Property(e => e.modified_id)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<t_cm_rm_payflow>()
                .Property(e => e.com_no)
                .HasPrecision(16, 0);

            modelBuilder.Entity<t_cm_rm_payflow>()
                .Property(e => e.flow_id)
                .HasPrecision(3, 0);

            modelBuilder.Entity<t_cm_rm_payflow>()
                .Property(e => e.flow_no)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<t_cm_rm_payflow>()
                .Property(e => e.sale_amount)
                .HasPrecision(16, 4);

            modelBuilder.Entity<t_cm_rm_payflow>()
                .Property(e => e.branch_no)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<t_cm_rm_payflow>()
                .Property(e => e.pay_way)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<t_cm_rm_payflow>()
                .Property(e => e.sell_way)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<t_cm_rm_payflow>()
                .Property(e => e.card_no)
                .IsUnicode(false);

            modelBuilder.Entity<t_cm_rm_payflow>()
                .Property(e => e.card_id)
                .IsUnicode(false);

            modelBuilder.Entity<t_cm_rm_payflow>()
                .Property(e => e.vip_no)
                .IsUnicode(false);

            modelBuilder.Entity<t_cm_rm_payflow>()
                .Property(e => e.coin_no)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<t_cm_rm_payflow>()
                .Property(e => e.coin_rate)
                .HasPrecision(10, 4);

            modelBuilder.Entity<t_cm_rm_payflow>()
                .Property(e => e.pay_amount)
                .HasPrecision(16, 4);

            modelBuilder.Entity<t_cm_rm_payflow>()
                .Property(e => e.oper_id)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<t_cm_rm_payflow>()
                .Property(e => e.counter_no)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<t_cm_rm_payflow>()
                .Property(e => e.sale_man)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<t_cm_rm_payflow>()
                .Property(e => e.cashier_no)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<t_cm_rm_payflow>()
                .Property(e => e.memo)
                .IsUnicode(false);

            modelBuilder.Entity<t_cm_rm_payflow>()
                .Property(e => e.voucher_no)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<t_cm_rm_payflow>()
                .Property(e => e.shift_no)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<t_cm_rm_payflow>()
                .Property(e => e.com_flag)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<t_cm_rm_payin_detail>()
                .Property(e => e.flow_id)
                .HasPrecision(14, 0);

            modelBuilder.Entity<t_cm_rm_payin_detail>()
                .Property(e => e.sheet_no)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<t_cm_rm_payin_detail>()
                .Property(e => e.pay_way)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<t_cm_rm_payin_detail>()
                .Property(e => e.par_value)
                .HasPrecision(16, 4);

            modelBuilder.Entity<t_cm_rm_payin_detail>()
                .Property(e => e.rate)
                .HasPrecision(16, 4);

            modelBuilder.Entity<t_cm_rm_payin_detail>()
                .Property(e => e.memo)
                .IsUnicode(false);

            modelBuilder.Entity<t_cm_rm_payin_detail>()
                .Property(e => e.casher_id)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<t_cm_rm_payin_master>()
                .Property(e => e.sheet_no)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<t_cm_rm_payin_master>()
                .Property(e => e.trans_no)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<t_cm_rm_payin_master>()
                .Property(e => e.branch_no)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<t_cm_rm_payin_master>()
                .Property(e => e.approve_flag)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<t_cm_rm_payin_master>()
                .Property(e => e.sheet_amt)
                .HasPrecision(16, 4);

            modelBuilder.Entity<t_cm_rm_payin_master>()
                .Property(e => e.oper_id)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<t_cm_rm_payin_master>()
                .Property(e => e.casher_id)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<t_cm_rm_payin_master>()
                .Property(e => e.cashier_name)
                .IsUnicode(false);

            modelBuilder.Entity<t_cm_rm_payin_master>()
                .Property(e => e.confirm_man)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<t_cm_rm_payin_master>()
                .Property(e => e.posid)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<t_cm_rm_payin_master>()
                .Property(e => e.cheque)
                .HasPrecision(16, 4);

            modelBuilder.Entity<t_cm_rm_payin_master>()
                .Property(e => e.ccard)
                .HasPrecision(16, 4);

            modelBuilder.Entity<t_cm_rm_payin_master>()
                .Property(e => e.fcard)
                .HasPrecision(16, 4);

            modelBuilder.Entity<t_cm_rm_payin_master>()
                .Property(e => e.gcert)
                .HasPrecision(16, 4);

            modelBuilder.Entity<t_cm_rm_payin_master>()
                .Property(e => e.oncd)
                .HasPrecision(16, 4);

            modelBuilder.Entity<t_cm_rm_payin_master>()
                .Property(e => e.opay)
                .HasPrecision(16, 4);

            modelBuilder.Entity<t_cm_rm_payin_master>()
                .Property(e => e.other1)
                .IsUnicode(false);

            modelBuilder.Entity<t_cm_rm_payin_master>()
                .Property(e => e.other2)
                .IsUnicode(false);

            modelBuilder.Entity<t_cm_rm_payin_master>()
                .Property(e => e.other3)
                .IsUnicode(false);

            modelBuilder.Entity<t_cm_rm_payin_master>()
                .Property(e => e.memo)
                .IsUnicode(false);

            modelBuilder.Entity<t_cm_rm_payin_master>()
                .Property(e => e.num1)
                .HasPrecision(16, 4);

            modelBuilder.Entity<t_cm_rm_payin_master>()
                .Property(e => e.num2)
                .HasPrecision(16, 4);

            modelBuilder.Entity<t_cm_rm_payin_master>()
                .Property(e => e.branch_flag)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<t_cm_rm_payin_master>()
                .Property(e => e.com_flag)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<t_cm_rm_protion_flow>()
                .Property(e => e.com_no)
                .HasPrecision(16, 0);

            modelBuilder.Entity<t_cm_rm_protion_flow>()
                .Property(e => e.flow_no)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<t_cm_rm_protion_flow>()
                .Property(e => e.branch_no)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<t_cm_rm_protion_flow>()
                .Property(e => e.item_no)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<t_cm_rm_protion_flow>()
                .Property(e => e.sale_qty)
                .HasPrecision(16, 2);

            modelBuilder.Entity<t_cm_rm_protion_flow>()
                .Property(e => e.source_price)
                .HasPrecision(16, 4);

            modelBuilder.Entity<t_cm_rm_protion_flow>()
                .Property(e => e.sale_price)
                .HasPrecision(16, 4);

            modelBuilder.Entity<t_cm_rm_protion_flow>()
                .Property(e => e.send_money)
                .HasPrecision(16, 4);

            modelBuilder.Entity<t_cm_rm_protion_flow>()
                .Property(e => e.special_type)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<t_cm_rm_protion_flow>()
                .Property(e => e.sheet_no)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<t_cm_rm_protion_flow>()
                .Property(e => e.pro_des)
                .IsUnicode(false);

            modelBuilder.Entity<t_cm_rm_protion_flow>()
                .Property(e => e.give_type)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<t_cm_rm_protion_flow>()
                .Property(e => e.vip_flag)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<t_cm_rm_protion_flow>()
                .Property(e => e.dec_rate)
                .HasPrecision(5, 2);

            modelBuilder.Entity<t_cm_rm_protion_flow>()
                .Property(e => e.card_id)
                .IsUnicode(false);

            modelBuilder.Entity<t_cm_rm_protion_flow>()
                .Property(e => e.card_no)
                .IsUnicode(false);

            modelBuilder.Entity<t_cm_rm_protion_flow>()
                .Property(e => e.oper_id)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<t_cm_rm_protion_flow>()
                .Property(e => e.com_flag)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<t_cm_rm_saleflow>()
                .Property(e => e.com_no)
                .HasPrecision(16, 0);

            modelBuilder.Entity<t_cm_rm_saleflow>()
                .Property(e => e.flow_id)
                .HasPrecision(3, 0);

            modelBuilder.Entity<t_cm_rm_saleflow>()
                .Property(e => e.flow_no)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<t_cm_rm_saleflow>()
                .Property(e => e.branch_no)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<t_cm_rm_saleflow>()
                .Property(e => e.item_no)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<t_cm_rm_saleflow>()
                .Property(e => e.source_price)
                .HasPrecision(16, 4);

            modelBuilder.Entity<t_cm_rm_saleflow>()
                .Property(e => e.sale_price)
                .HasPrecision(16, 4);

            modelBuilder.Entity<t_cm_rm_saleflow>()
                .Property(e => e.cost_price)
                .HasPrecision(16, 4);

            modelBuilder.Entity<t_cm_rm_saleflow>()
                .Property(e => e.sale_qnty)
                .HasPrecision(16, 4);

            modelBuilder.Entity<t_cm_rm_saleflow>()
                .Property(e => e.sale_money)
                .HasPrecision(16, 4);

            modelBuilder.Entity<t_cm_rm_saleflow>()
                .Property(e => e.sell_way)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<t_cm_rm_saleflow>()
                .Property(e => e.oper_id)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<t_cm_rm_saleflow>()
                .Property(e => e.sale_man)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<t_cm_rm_saleflow>()
                .Property(e => e.shift_no)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<t_cm_rm_saleflow>()
                .Property(e => e.com_flag)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<t_cm_rm_saleflow>()
                .Property(e => e.spec_flag)
                .IsUnicode(false);

            modelBuilder.Entity<t_cm_rm_saleflow>()
                .Property(e => e.pref_amt)
                .HasPrecision(16, 4);

            modelBuilder.Entity<t_cm_rm_saleflow>()
                .Property(e => e.in_price)
                .HasPrecision(16, 4);

            modelBuilder.Entity<t_cm_rm_saleflow>()
                .Property(e => e.acc_num)
                .HasPrecision(16, 4);

            modelBuilder.Entity<t_cm_rm_saleflow>()
                .Property(e => e.dec_rate)
                .HasPrecision(16, 4);

            modelBuilder.Entity<t_cm_rm_saleflow>()
                .Property(e => e.card_id)
                .IsUnicode(false);

            modelBuilder.Entity<t_cm_rm_saleflow>()
                .Property(e => e.card_no)
                .IsUnicode(false);

            modelBuilder.Entity<t_cm_rm_saleflow>()
                .Property(e => e.clss_rate)
                .HasPrecision(16, 4);

            modelBuilder.Entity<t_cm_rm_saleflow>()
                .Property(e => e.Brand_rate)
                .HasPrecision(16, 4);

            modelBuilder.Entity<t_cm_rm_saleflow>()
                .Property(e => e.sale_rate)
                .HasPrecision(16, 4);

            modelBuilder.Entity<t_cm_rm_saleflow>()
                .Property(e => e.sale_duty_rate)
                .HasPrecision(16, 4);

            modelBuilder.Entity<t_cm_rm_vip_acclist>()
                .Property(e => e.flow_id)
                .HasPrecision(16, 0);

            modelBuilder.Entity<t_cm_rm_vip_acclist>()
                .Property(e => e.card_id)
                .IsUnicode(false);

            modelBuilder.Entity<t_cm_rm_vip_acclist>()
                .Property(e => e.card_no)
                .IsUnicode(false);

            modelBuilder.Entity<t_cm_rm_vip_acclist>()
                .Property(e => e.card_type)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<t_cm_rm_vip_acclist>()
                .Property(e => e.branch_no)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<t_cm_rm_vip_acclist>()
                .Property(e => e.oper_type)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<t_cm_rm_vip_acclist>()
                .Property(e => e.oper_id)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<t_cm_rm_vip_acclist>()
                .Property(e => e.flow_no)
                .IsUnicode(false);

            modelBuilder.Entity<t_cm_rm_vip_acclist>()
                .Property(e => e.consum_amt)
                .HasPrecision(16, 4);

            modelBuilder.Entity<t_cm_rm_vip_acclist>()
                .Property(e => e.acc_num)
                .HasPrecision(10, 2);

            modelBuilder.Entity<t_cm_rm_vip_acclist>()
                .Property(e => e.new_cardno)
                .IsUnicode(false);

            modelBuilder.Entity<t_cm_rm_vip_acclist>()
                .Property(e => e.oper_des)
                .IsUnicode(false);

            modelBuilder.Entity<t_cm_rm_vip_acclist>()
                .Property(e => e.memo)
                .IsUnicode(false);

            modelBuilder.Entity<t_cm_rm_vip_acclist>()
                .Property(e => e.com_flag)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<t_cm_rm_vip_info_edit>()
                .Property(e => e.flow_id)
                .HasPrecision(16, 0);

            modelBuilder.Entity<t_cm_rm_vip_info_edit>()
                .Property(e => e.branch_no)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<t_cm_rm_vip_info_edit>()
                .Property(e => e.card_id)
                .IsUnicode(false);

            modelBuilder.Entity<t_cm_rm_vip_info_edit>()
                .Property(e => e.card_no)
                .IsUnicode(false);

            modelBuilder.Entity<t_cm_rm_vip_info_edit>()
                .Property(e => e.card_type)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<t_cm_rm_vip_info_edit>()
                .Property(e => e.vip_name)
                .IsUnicode(false);

            modelBuilder.Entity<t_cm_rm_vip_info_edit>()
                .Property(e => e.vip_sex)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<t_cm_rm_vip_info_edit>()
                .Property(e => e.vip_add)
                .IsUnicode(false);

            modelBuilder.Entity<t_cm_rm_vip_info_edit>()
                .Property(e => e.vip_zip)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<t_cm_rm_vip_info_edit>()
                .Property(e => e.vip_tel)
                .IsUnicode(false);

            modelBuilder.Entity<t_cm_rm_vip_info_edit>()
                .Property(e => e.vip_email)
                .IsUnicode(false);

            modelBuilder.Entity<t_cm_rm_vip_info_edit>()
                .Property(e => e.vip_tax)
                .HasPrecision(16, 4);

            modelBuilder.Entity<t_cm_rm_vip_info_edit>()
                .Property(e => e.card_status)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<t_cm_rm_vip_info_edit>()
                .Property(e => e.oper_id)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<t_cm_rm_vip_info_edit>()
                .Property(e => e.social_id)
                .IsUnicode(false);

            modelBuilder.Entity<t_cm_rm_vip_info_edit>()
                .Property(e => e.company)
                .IsUnicode(false);

            modelBuilder.Entity<t_cm_rm_vip_info_edit>()
                .Property(e => e.duty)
                .IsUnicode(false);

            modelBuilder.Entity<t_cm_rm_vip_info_edit>()
                .Property(e => e.degree)
                .IsUnicode(false);

            modelBuilder.Entity<t_cm_rm_vip_info_edit>()
                .Property(e => e.mobile)
                .IsUnicode(false);

            modelBuilder.Entity<t_cm_rm_vip_info_edit>()
                .Property(e => e.homeplace)
                .IsUnicode(false);

            modelBuilder.Entity<t_cm_rm_vip_info_edit>()
                .Property(e => e.reg_place)
                .IsUnicode(false);

            modelBuilder.Entity<t_cm_rm_vip_info_edit>()
                .Property(e => e.live_place)
                .IsUnicode(false);

            modelBuilder.Entity<t_cm_rm_vip_info_edit>()
                .Property(e => e.marriage)
                .IsUnicode(false);

            modelBuilder.Entity<t_cm_rm_vip_info_edit>()
                .Property(e => e.salary_level)
                .IsUnicode(false);

            modelBuilder.Entity<t_cm_rm_vip_info_edit>()
                .Property(e => e.nation)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<t_cm_rm_vip_info_edit>()
                .Property(e => e.height)
                .HasPrecision(3, 0);

            modelBuilder.Entity<t_cm_rm_vip_info_edit>()
                .Property(e => e.weight)
                .HasPrecision(4, 1);

            modelBuilder.Entity<t_cm_rm_vip_info_edit>()
                .Property(e => e.blood_type)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<t_cm_rm_vip_info_edit>()
                .Property(e => e.favor)
                .IsUnicode(false);

            modelBuilder.Entity<t_cm_rm_vip_info_edit>()
                .Property(e => e.pass)
                .IsUnicode(false);

            modelBuilder.Entity<t_cm_rm_vip_info_edit>()
                .Property(e => e.com_flag)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<t_cm_rm_vip_info_edit>()
                .Property(e => e.memo)
                .IsUnicode(false);

            modelBuilder.Entity<t_cm_rm_vip_info_edit>()
                .Property(e => e.father_card)
                .IsUnicode(false);

            modelBuilder.Entity<t_cm_rm_vip_info_edit>()
                .Property(e => e.approve_flag)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<t_cm_rm_vip_info_edit>()
                .Property(e => e.vip_add1)
                .IsUnicode(false);

            modelBuilder.Entity<t_cm_rm_vip_info_edit>()
                .Property(e => e.vip_add2)
                .IsUnicode(false);

            modelBuilder.Entity<t_cm_rm_vip_info_edit>()
                .Property(e => e.annex_property1)
                .IsUnicode(false);

            modelBuilder.Entity<t_cm_rm_vip_info_edit>()
                .Property(e => e.annex_property2)
                .IsUnicode(false);

            modelBuilder.Entity<t_cm_rm_vip_info_edit>()
                .Property(e => e.annex_property3)
                .IsUnicode(false);

            modelBuilder.Entity<t_cm_rm_vip_info_edit>()
                .Property(e => e.annex_property4)
                .IsUnicode(false);

            modelBuilder.Entity<t_cm_rm_vip_info_edit>()
                .Property(e => e.annex_property5)
                .IsUnicode(false);

            modelBuilder.Entity<t_cm_rm_vip_info_edit>()
                .Property(e => e.annex_property6)
                .IsUnicode(false);

            modelBuilder.Entity<t_cm_rm_vip_info_edit>()
                .Property(e => e.annex_property7)
                .IsUnicode(false);

            modelBuilder.Entity<t_cm_rm_vip_info_edit>()
                .Property(e => e.annex_property8)
                .IsUnicode(false);

            modelBuilder.Entity<t_cm_rm_vip_info_edit>()
                .Property(e => e.annex_property9)
                .IsUnicode(false);

            modelBuilder.Entity<t_cm_rm_vip_info_edit>()
                .Property(e => e.annex_property10)
                .IsUnicode(false);

            modelBuilder.Entity<t_cm_rm_vip_info_edit>()
                .Property(e => e.vip_credentials)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<t_cm_rm_vip_info_edit>()
                .Property(e => e.vip_work)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<t_cm_rm_vip_info_edit>()
                .Property(e => e.vip_intent)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<t_cm_rm_vip_savelist>()
                .Property(e => e.flow_id)
                .HasPrecision(16, 0);

            modelBuilder.Entity<t_cm_rm_vip_savelist>()
                .Property(e => e.card_id)
                .IsUnicode(false);

            modelBuilder.Entity<t_cm_rm_vip_savelist>()
                .Property(e => e.card_no)
                .IsUnicode(false);

            modelBuilder.Entity<t_cm_rm_vip_savelist>()
                .Property(e => e.card_type)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<t_cm_rm_vip_savelist>()
                .Property(e => e.branch_no)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<t_cm_rm_vip_savelist>()
                .Property(e => e.oper_type)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<t_cm_rm_vip_savelist>()
                .Property(e => e.oper_id)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<t_cm_rm_vip_savelist>()
                .Property(e => e.flow_no)
                .IsUnicode(false);

            modelBuilder.Entity<t_cm_rm_vip_savelist>()
                .Property(e => e.consum_amt)
                .HasPrecision(16, 4);

            modelBuilder.Entity<t_cm_rm_vip_savelist>()
                .Property(e => e.acc_num)
                .HasPrecision(10, 2);

            modelBuilder.Entity<t_cm_rm_vip_savelist>()
                .Property(e => e.new_cardno)
                .IsUnicode(false);

            modelBuilder.Entity<t_cm_rm_vip_savelist>()
                .Property(e => e.oper_des)
                .IsUnicode(false);

            modelBuilder.Entity<t_cm_rm_vip_savelist>()
                .Property(e => e.memo)
                .IsUnicode(false);

            modelBuilder.Entity<t_cm_rm_vip_savelist>()
                .Property(e => e.com_flag)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<t_cm_rm_vip_savelist>()
                .Property(e => e.sale_qty)
                .HasPrecision(16, 4);

            modelBuilder.Entity<t_cm_rm_vip_savelist>()
                .Property(e => e.item_no)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<t_cm_rm_vip_savelist>()
                .Property(e => e.real_amt)
                .HasPrecision(16, 4);

            modelBuilder.Entity<t_cm_sys_oper_grant>()
                .Property(e => e.oper_id)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<t_cm_sys_oper_grant>()
                .Property(e => e.func_id)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<t_cm_sys_oper_grant>()
                .Property(e => e.grant0)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<t_cm_sys_oper_grant>()
                .Property(e => e.grant1)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<t_cm_sys_oper_grant>()
                .Property(e => e.grant2)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<t_cm_sys_oper_grant>()
                .Property(e => e.grant3)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<t_cm_sys_oper_grant>()
                .Property(e => e.grant4)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<t_cm_sys_oper_grant>()
                .Property(e => e.grant5)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<t_cm_sys_oper_grant>()
                .Property(e => e.grant6)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<t_cm_sys_oper_grant>()
                .Property(e => e.grant7)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<t_cm_sys_oper_grant>()
                .Property(e => e.grant8)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<t_cm_sys_oper_grant>()
                .Property(e => e.grant9)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<t_cm_sys_oper_grant>()
                .Property(e => e.other)
                .IsUnicode(false);

            modelBuilder.Entity<t_cm_sys_pos_status_history>()
                .Property(e => e.flow_id)
                .HasPrecision(18, 0);

            modelBuilder.Entity<t_cm_sys_pos_status_history>()
                .Property(e => e.posid)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<t_cm_sys_pos_status_history>()
                .Property(e => e.posdesc)
                .IsUnicode(false);

            modelBuilder.Entity<t_cm_sys_pos_status_history>()
                .Property(e => e.hostip)
                .IsUnicode(false);

            modelBuilder.Entity<t_cm_sys_pos_status_history>()
                .Property(e => e.hostname)
                .IsUnicode(false);

            modelBuilder.Entity<t_cm_sys_pos_status_history>()
                .Property(e => e.operdate)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<t_cm_sys_pos_status_history>()
                .Property(e => e.amount)
                .HasPrecision(16, 4);

            modelBuilder.Entity<t_cm_sys_pos_status_history>()
                .Property(e => e.orderqty)
                .HasPrecision(6, 0);

            modelBuilder.Entity<t_cm_sys_pos_status_history>()
                .Property(e => e.lastcashier)
                .IsUnicode(false);

            modelBuilder.Entity<t_cm_sys_pos_status_history>()
                .Property(e => e.status)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<t_cm_sys_pos_status_history>()
                .Property(e => e.other)
                .IsUnicode(false);

            modelBuilder.Entity<t_cm_sys_pos_status_history>()
                .Property(e => e.com_flag)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<t_cm_vip_sheet_detail>()
                .Property(e => e.flow_id)
                .HasPrecision(14, 0);

            modelBuilder.Entity<t_cm_vip_sheet_detail>()
                .Property(e => e.sheet_no)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<t_cm_vip_sheet_detail>()
                .Property(e => e.item_no)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<t_cm_vip_sheet_detail>()
                .Property(e => e.orgi_price)
                .HasPrecision(16, 4);

            modelBuilder.Entity<t_cm_vip_sheet_detail>()
                .Property(e => e.valid_price)
                .HasPrecision(16, 4);

            modelBuilder.Entity<t_cm_vip_sheet_detail>()
                .Property(e => e.order_qty)
                .HasPrecision(16, 4);

            modelBuilder.Entity<t_cm_vip_sheet_detail>()
                .Property(e => e.real_qty)
                .HasPrecision(16, 4);

            modelBuilder.Entity<t_cm_vip_sheet_detail>()
                .Property(e => e.large_qty)
                .HasPrecision(16, 4);

            modelBuilder.Entity<t_cm_vip_sheet_detail>()
                .Property(e => e.sub_amt)
                .HasPrecision(16, 4);

            modelBuilder.Entity<t_cm_vip_sheet_detail>()
                .Property(e => e.tax)
                .HasPrecision(5, 4);

            modelBuilder.Entity<t_cm_vip_sheet_detail>()
                .Property(e => e.cost_price)
                .HasPrecision(16, 4);

            modelBuilder.Entity<t_cm_vip_sheet_detail>()
                .Property(e => e.send_qty)
                .HasPrecision(16, 4);

            modelBuilder.Entity<t_cm_vip_sheet_detail>()
                .Property(e => e.sale_price)
                .HasPrecision(16, 4);

            modelBuilder.Entity<t_cm_vip_sheet_detail>()
                .Property(e => e.memo)
                .IsUnicode(false);

            modelBuilder.Entity<t_cm_vip_sheet_detail>()
                .Property(e => e.come_num)
                .HasPrecision(16, 4);

            modelBuilder.Entity<t_cm_vip_sheet_master>()
                .Property(e => e.sheet_no)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<t_cm_vip_sheet_master>()
                .Property(e => e.trans_no)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<t_cm_vip_sheet_master>()
                .Property(e => e.db_no)
                .IsUnicode(false);

            modelBuilder.Entity<t_cm_vip_sheet_master>()
                .Property(e => e.voucher_no)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<t_cm_vip_sheet_master>()
                .Property(e => e.branch_no)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<t_cm_vip_sheet_master>()
                .Property(e => e.supcust_no)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<t_cm_vip_sheet_master>()
                .Property(e => e.pay_way)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<t_cm_vip_sheet_master>()
                .Property(e => e.discount)
                .HasPrecision(5, 4);

            modelBuilder.Entity<t_cm_vip_sheet_master>()
                .Property(e => e.coin_no)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<t_cm_vip_sheet_master>()
                .Property(e => e.paid_amt)
                .HasPrecision(16, 4);

            modelBuilder.Entity<t_cm_vip_sheet_master>()
                .Property(e => e.order_status)
                .IsUnicode(false);

            modelBuilder.Entity<t_cm_vip_sheet_master>()
                .Property(e => e.approve_flag)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<t_cm_vip_sheet_master>()
                .Property(e => e.oper_id)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<t_cm_vip_sheet_master>()
                .Property(e => e.order_man)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<t_cm_vip_sheet_master>()
                .Property(e => e.confirm_man)
                .IsUnicode(false);

            modelBuilder.Entity<t_cm_vip_sheet_master>()
                .Property(e => e.trans_flag)
                .IsUnicode(false);

            modelBuilder.Entity<t_cm_vip_sheet_master>()
                .Property(e => e.acct_flag)
                .IsUnicode(false);

            modelBuilder.Entity<t_cm_vip_sheet_master>()
                .Property(e => e.sheet_amt)
                .HasPrecision(16, 4);

            modelBuilder.Entity<t_cm_vip_sheet_master>()
                .Property(e => e.acc_num)
                .HasPrecision(11, 2);

            modelBuilder.Entity<t_cm_vip_sheet_master>()
                .Property(e => e.branch_flag)
                .IsUnicode(false);

            modelBuilder.Entity<t_cm_vip_sheet_master>()
                .Property(e => e.com_flag)
                .IsUnicode(false);

            modelBuilder.Entity<t_cm_vip_sheet_master>()
                .Property(e => e.memo)
                .IsUnicode(false);

            modelBuilder.Entity<t_cm_vip_sheet_master>()
                .Property(e => e.modified_id)
                .IsUnicode(false);

            modelBuilder.Entity<t_cm_vip_sheet_master>()
                .Property(e => e.delivery_man)
                .IsUnicode(false);

            modelBuilder.Entity<t_cm_vip_sheet_master>()
                .Property(e => e.card_no)
                .IsUnicode(false);

            modelBuilder.Entity<t_cm_vip_sheet_master>()
                .Property(e => e.vip_name)
                .IsUnicode(false);

            modelBuilder.Entity<t_cm_vip_sheet_master>()
                .Property(e => e.card_id)
                .IsUnicode(false);

            modelBuilder.Entity<t_cm_vip_sheet_master>()
                .Property(e => e.vip_mobile)
                .IsUnicode(false);

            modelBuilder.Entity<t_cm_vip_sheet_master>()
                .Property(e => e.vip_tel)
                .IsUnicode(false);

            modelBuilder.Entity<t_cm_vip_sheet_master>()
                .Property(e => e.vip_add)
                .IsUnicode(false);

            modelBuilder.Entity<t_cm_vip_sheet_master>()
                .Property(e => e.vip_jf)
                .HasPrecision(10, 2);

            modelBuilder.Entity<t_cm_wm_sheet_detail>()
                .Property(e => e.flow_id)
                .HasPrecision(14, 0);

            modelBuilder.Entity<t_cm_wm_sheet_detail>()
                .Property(e => e.sheet_no)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<t_cm_wm_sheet_detail>()
                .Property(e => e.item_no)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<t_cm_wm_sheet_detail>()
                .Property(e => e.orgi_price)
                .HasPrecision(16, 4);

            modelBuilder.Entity<t_cm_wm_sheet_detail>()
                .Property(e => e.valid_price)
                .HasPrecision(16, 4);

            modelBuilder.Entity<t_cm_wm_sheet_detail>()
                .Property(e => e.order_qty)
                .HasPrecision(16, 4);

            modelBuilder.Entity<t_cm_wm_sheet_detail>()
                .Property(e => e.real_qty)
                .HasPrecision(16, 4);

            modelBuilder.Entity<t_cm_wm_sheet_detail>()
                .Property(e => e.large_qty)
                .HasPrecision(16, 4);

            modelBuilder.Entity<t_cm_wm_sheet_detail>()
                .Property(e => e.sub_amt)
                .HasPrecision(16, 4);

            modelBuilder.Entity<t_cm_wm_sheet_detail>()
                .Property(e => e.tax)
                .HasPrecision(5, 4);

            modelBuilder.Entity<t_cm_wm_sheet_detail>()
                .Property(e => e.cost_price)
                .HasPrecision(16, 4);

            modelBuilder.Entity<t_cm_wm_sheet_detail>()
                .Property(e => e.send_qty)
                .HasPrecision(16, 4);

            modelBuilder.Entity<t_cm_wm_sheet_detail>()
                .Property(e => e.sale_price)
                .HasPrecision(16, 4);

            modelBuilder.Entity<t_cm_wm_sheet_detail>()
                .Property(e => e.memo)
                .IsUnicode(false);

            modelBuilder.Entity<t_cm_wm_sheet_detail>()
                .Property(e => e.num1)
                .HasPrecision(16, 4);

            modelBuilder.Entity<t_cm_wm_sheet_detail>()
                .Property(e => e.come_num)
                .HasPrecision(16, 4);

            modelBuilder.Entity<t_cm_wm_sheet_detail>()
                .Property(e => e.memo1)
                .IsUnicode(false);

            modelBuilder.Entity<t_cm_wm_sheet_master>()
                .Property(e => e.sheet_no)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<t_cm_wm_sheet_master>()
                .Property(e => e.trans_no)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<t_cm_wm_sheet_master>()
                .Property(e => e.db_no)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<t_cm_wm_sheet_master>()
                .Property(e => e.voucher_no)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<t_cm_wm_sheet_master>()
                .Property(e => e.branch_no)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<t_cm_wm_sheet_master>()
                .Property(e => e.supcust_no)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<t_cm_wm_sheet_master>()
                .Property(e => e.pay_way)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<t_cm_wm_sheet_master>()
                .Property(e => e.discount)
                .HasPrecision(5, 4);

            modelBuilder.Entity<t_cm_wm_sheet_master>()
                .Property(e => e.coin_no)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<t_cm_wm_sheet_master>()
                .Property(e => e.paid_amt)
                .HasPrecision(16, 4);

            modelBuilder.Entity<t_cm_wm_sheet_master>()
                .Property(e => e.order_status)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<t_cm_wm_sheet_master>()
                .Property(e => e.approve_flag)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<t_cm_wm_sheet_master>()
                .Property(e => e.oper_id)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<t_cm_wm_sheet_master>()
                .Property(e => e.order_man)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<t_cm_wm_sheet_master>()
                .Property(e => e.confirm_man)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<t_cm_wm_sheet_master>()
                .Property(e => e.trans_flag)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<t_cm_wm_sheet_master>()
                .Property(e => e.acct_flag)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<t_cm_wm_sheet_master>()
                .Property(e => e.sheet_amt)
                .HasPrecision(16, 4);

            modelBuilder.Entity<t_cm_wm_sheet_master>()
                .Property(e => e.branch_flag)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<t_cm_wm_sheet_master>()
                .Property(e => e.com_flag)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<t_cm_wm_sheet_master>()
                .Property(e => e.memo)
                .IsUnicode(false);

            modelBuilder.Entity<t_cm_wm_sheet_master>()
                .Property(e => e.modified_id)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<t_da_clssell_aim>()
                .Property(e => e.year_month)
                .IsUnicode(false);

            modelBuilder.Entity<t_da_clssell_aim>()
                .Property(e => e.branch_no)
                .IsUnicode(false);

            modelBuilder.Entity<t_da_clssell_aim>()
                .Property(e => e.item_cls)
                .IsUnicode(false);

            modelBuilder.Entity<t_da_clssell_aim>()
                .Property(e => e.month_aim)
                .HasPrecision(18, 4);

            modelBuilder.Entity<t_da_clssell_aim>()
                .Property(e => e.month_sell)
                .HasPrecision(18, 4);

            modelBuilder.Entity<t_da_clssell_aim>()
                .Property(e => e.flag)
                .IsUnicode(false);

            modelBuilder.Entity<t_da_clssell_aim>()
                .Property(e => e.oper_id)
                .IsUnicode(false);

            modelBuilder.Entity<t_da_jxc_daysum>()
                .Property(e => e.item_no)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<t_da_jxc_daysum>()
                .Property(e => e.oper_date)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<t_da_jxc_daysum>()
                .Property(e => e.branch_no)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<t_da_jxc_daysum>()
                .Property(e => e.cost_price)
                .HasPrecision(16, 4);

            modelBuilder.Entity<t_da_jxc_daysum>()
                .Property(e => e.init_qty)
                .HasPrecision(16, 4);

            modelBuilder.Entity<t_da_jxc_daysum>()
                .Property(e => e.init_amt)
                .HasPrecision(16, 4);

            modelBuilder.Entity<t_da_jxc_daysum>()
                .Property(e => e.init_amt2)
                .HasPrecision(16, 4);

            modelBuilder.Entity<t_da_jxc_daysum>()
                .Property(e => e.avg_cost_amt)
                .HasPrecision(16, 4);

            modelBuilder.Entity<t_da_jxc_daysum>()
                .Property(e => e.avg_profit_amt)
                .HasPrecision(16, 4);

            modelBuilder.Entity<t_da_jxc_daysum>()
                .Property(e => e.pi_qty)
                .HasPrecision(16, 4);

            modelBuilder.Entity<t_da_jxc_daysum>()
                .Property(e => e.pi_amt)
                .HasPrecision(16, 4);

            modelBuilder.Entity<t_da_jxc_daysum>()
                .Property(e => e.so_qty)
                .HasPrecision(16, 4);

            modelBuilder.Entity<t_da_jxc_daysum>()
                .Property(e => e.so_amt)
                .HasPrecision(16, 4);

            modelBuilder.Entity<t_da_jxc_daysum>()
                .Property(e => e.mi_qty)
                .HasPrecision(16, 4);

            modelBuilder.Entity<t_da_jxc_daysum>()
                .Property(e => e.mi_amt)
                .HasPrecision(16, 4);

            modelBuilder.Entity<t_da_jxc_daysum>()
                .Property(e => e.mo_qty)
                .HasPrecision(16, 4);

            modelBuilder.Entity<t_da_jxc_daysum>()
                .Property(e => e.mo_amt)
                .HasPrecision(16, 4);

            modelBuilder.Entity<t_da_jxc_daysum>()
                .Property(e => e.di_qty)
                .HasPrecision(16, 4);

            modelBuilder.Entity<t_da_jxc_daysum>()
                .Property(e => e.di_amt)
                .HasPrecision(16, 4);

            modelBuilder.Entity<t_da_jxc_daysum>()
                .Property(e => e.do_qty)
                .HasPrecision(16, 4);

            modelBuilder.Entity<t_da_jxc_daysum>()
                .Property(e => e.do_amt)
                .HasPrecision(16, 4);

            modelBuilder.Entity<t_da_jxc_daysum>()
                .Property(e => e.pos_qty)
                .HasPrecision(16, 4);

            modelBuilder.Entity<t_da_jxc_daysum>()
                .Property(e => e.pos_amt)
                .HasPrecision(16, 4);

            modelBuilder.Entity<t_da_jxc_daysum>()
                .Property(e => e.pos_ret_qty)
                .HasPrecision(16, 4);

            modelBuilder.Entity<t_da_jxc_daysum>()
                .Property(e => e.pos_ret_amt)
                .HasPrecision(16, 4);

            modelBuilder.Entity<t_da_jxc_daysum>()
                .Property(e => e.pos_send_qty)
                .HasPrecision(16, 4);

            modelBuilder.Entity<t_da_jxc_daysum>()
                .Property(e => e.pos_send_amt)
                .HasPrecision(16, 4);

            modelBuilder.Entity<t_da_jxc_daysum>()
                .Property(e => e.oo_qty)
                .HasPrecision(16, 4);

            modelBuilder.Entity<t_da_jxc_daysum>()
                .Property(e => e.oo_amt)
                .HasPrecision(16, 4);

            modelBuilder.Entity<t_da_jxc_daysum>()
                .Property(e => e.settle_qty)
                .HasPrecision(16, 4);

            modelBuilder.Entity<t_da_jxc_daysum>()
                .Property(e => e.settle_amt)
                .HasPrecision(16, 4);

            modelBuilder.Entity<t_da_jxc_daysum>()
                .Property(e => e.settle_amt2)
                .HasPrecision(16, 4);

            modelBuilder.Entity<t_da_jxc_daysum>()
                .Property(e => e.cost_change_amt)
                .HasPrecision(16, 4);

            modelBuilder.Entity<t_da_jxc_daysum>()
                .Property(e => e.pos_dct_amt)
                .HasPrecision(16, 4);

            modelBuilder.Entity<t_da_jxc_daysum>()
                .Property(e => e.main_sup)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<t_da_jxc_daysum>()
                .Property(e => e.dec_rate)
                .HasPrecision(16, 4);

            modelBuilder.Entity<t_da_jxc_daysum>()
                .Property(e => e.so_price)
                .HasPrecision(16, 4);

            modelBuilder.Entity<t_da_jxc_daysum>()
                .Property(e => e.sale_price)
                .HasPrecision(16, 4);

            modelBuilder.Entity<t_da_jxc_daysum>()
                .Property(e => e.com_flag)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<t_da_jxc_daysum>()
                .Property(e => e.item_sup_flag)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<t_da_jxc_daysum>()
                .Property(e => e.sup_ly_rate)
                .HasPrecision(16, 4);

            modelBuilder.Entity<t_da_jxc_daysum>()
                .Property(e => e.flag)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<t_da_jxc_daysum>()
                .Property(e => e.pos_cost_amt)
                .HasPrecision(16, 4);

            modelBuilder.Entity<t_da_jxc_daysum>()
                .Property(e => e.so_cost_amt)
                .HasPrecision(16, 4);

            modelBuilder.Entity<t_da_jxc_daysum>()
                .Property(e => e.costdiff_amt)
                .HasPrecision(16, 4);

            modelBuilder.Entity<t_da_jxc_daysum>()
                .Property(e => e.spec_flag)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<t_da_jxc_daysum>()
                .Property(e => e.pos_sp_qty)
                .HasPrecision(16, 4);

            modelBuilder.Entity<t_da_jxc_daysum>()
                .Property(e => e.pos_sp_amt)
                .HasPrecision(16, 4);

            modelBuilder.Entity<t_da_jxc_daysum>()
                .Property(e => e.so_sp_qty)
                .HasPrecision(16, 4);

            modelBuilder.Entity<t_da_jxc_daysum>()
                .Property(e => e.so_sp_amt)
                .HasPrecision(16, 4);

            modelBuilder.Entity<t_da_jxc_daysum>()
                .Property(e => e.io_qty)
                .HasPrecision(16, 4);

            modelBuilder.Entity<t_da_jxc_daysum>()
                .Property(e => e.io_amt)
                .HasPrecision(16, 4);

            modelBuilder.Entity<t_da_jxc_month>()
                .Property(e => e.item_no)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<t_da_jxc_month>()
                .Property(e => e.oper_date)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<t_da_jxc_month>()
                .Property(e => e.branch_no)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<t_da_jxc_month>()
                .Property(e => e.cost_price)
                .HasPrecision(16, 4);

            modelBuilder.Entity<t_da_jxc_month>()
                .Property(e => e.init_qty)
                .HasPrecision(16, 4);

            modelBuilder.Entity<t_da_jxc_month>()
                .Property(e => e.init_amt)
                .HasPrecision(16, 4);

            modelBuilder.Entity<t_da_jxc_month>()
                .Property(e => e.init_amt2)
                .HasPrecision(16, 4);

            modelBuilder.Entity<t_da_jxc_month>()
                .Property(e => e.avg_cost_amt)
                .HasPrecision(16, 4);

            modelBuilder.Entity<t_da_jxc_month>()
                .Property(e => e.avg_profit_amt)
                .HasPrecision(16, 4);

            modelBuilder.Entity<t_da_jxc_month>()
                .Property(e => e.pi_qty)
                .HasPrecision(16, 4);

            modelBuilder.Entity<t_da_jxc_month>()
                .Property(e => e.pi_amt)
                .HasPrecision(16, 4);

            modelBuilder.Entity<t_da_jxc_month>()
                .Property(e => e.so_qty)
                .HasPrecision(16, 4);

            modelBuilder.Entity<t_da_jxc_month>()
                .Property(e => e.so_amt)
                .HasPrecision(16, 4);

            modelBuilder.Entity<t_da_jxc_month>()
                .Property(e => e.pos_qty)
                .HasPrecision(16, 4);

            modelBuilder.Entity<t_da_jxc_month>()
                .Property(e => e.pos_amt)
                .HasPrecision(16, 4);

            modelBuilder.Entity<t_da_jxc_month>()
                .Property(e => e.mi_qty)
                .HasPrecision(16, 4);

            modelBuilder.Entity<t_da_jxc_month>()
                .Property(e => e.mi_amt)
                .HasPrecision(16, 4);

            modelBuilder.Entity<t_da_jxc_month>()
                .Property(e => e.mo_qty)
                .HasPrecision(16, 4);

            modelBuilder.Entity<t_da_jxc_month>()
                .Property(e => e.mo_amt)
                .HasPrecision(16, 4);

            modelBuilder.Entity<t_da_jxc_month>()
                .Property(e => e.oo_qty)
                .HasPrecision(16, 4);

            modelBuilder.Entity<t_da_jxc_month>()
                .Property(e => e.oo_amt)
                .HasPrecision(16, 4);

            modelBuilder.Entity<t_da_jxc_month>()
                .Property(e => e.settle_qty)
                .HasPrecision(16, 4);

            modelBuilder.Entity<t_da_jxc_month>()
                .Property(e => e.settle_amt)
                .HasPrecision(16, 4);

            modelBuilder.Entity<t_da_jxc_month>()
                .Property(e => e.settle_amt2)
                .HasPrecision(16, 4);

            modelBuilder.Entity<t_da_jxc_month>()
                .Property(e => e.start_date)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<t_da_jxc_month>()
                .Property(e => e.end_date)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<t_da_jxc_month>()
                .Property(e => e.cost_change_amt)
                .HasPrecision(16, 4);

            modelBuilder.Entity<t_da_jxc_month>()
                .Property(e => e.pos_dct_amt)
                .HasPrecision(16, 4);

            modelBuilder.Entity<t_da_jxc_month>()
                .Property(e => e.pos_zs_amt)
                .HasPrecision(16, 4);

            modelBuilder.Entity<t_da_jxc_month>()
                .Property(e => e.main_sup)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<t_da_jxc_month>()
                .Property(e => e.dec_rate)
                .HasPrecision(16, 4);

            modelBuilder.Entity<t_da_jxc_month>()
                .Property(e => e.so_price)
                .HasPrecision(16, 4);

            modelBuilder.Entity<t_da_jxc_month>()
                .Property(e => e.pos_price)
                .HasPrecision(16, 4);

            modelBuilder.Entity<t_da_jxc_month>()
                .Property(e => e.com_flag)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<t_da_jxc_month>()
                .Property(e => e.costdiff_amt)
                .HasPrecision(16, 4);

            modelBuilder.Entity<t_da_jxc_month_anal>()
                .Property(e => e.item_no)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<t_da_jxc_month_anal>()
                .Property(e => e.oper_date)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<t_da_jxc_month_anal>()
                .Property(e => e.branch_no)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<t_da_jxc_month_anal>()
                .Property(e => e.sale_qty)
                .HasPrecision(16, 4);

            modelBuilder.Entity<t_da_jxc_month_anal>()
                .Property(e => e.sale_amt)
                .HasPrecision(16, 4);

            modelBuilder.Entity<t_da_jxc_month_anal>()
                .Property(e => e.profit_amt)
                .HasPrecision(16, 4);

            modelBuilder.Entity<t_da_jxc_month_anal>()
                .Property(e => e.profit_rate)
                .HasPrecision(16, 4);

            modelBuilder.Entity<t_da_jxc_month_anal>()
                .Property(e => e.velocity_rate)
                .HasPrecision(16, 4);

            modelBuilder.Entity<t_da_jxc_month_anal>()
                .Property(e => e.cross_rate)
                .HasPrecision(16, 4);

            modelBuilder.Entity<t_da_jxc_month_anal>()
                .Property(e => e.qty_incre_rate)
                .HasPrecision(16, 4);

            modelBuilder.Entity<t_da_jxc_month_anal>()
                .Property(e => e.amt_incre_rate)
                .HasPrecision(16, 4);

            modelBuilder.Entity<t_da_jxc_month_anal>()
                .Property(e => e.profit_incre_rate)
                .HasPrecision(16, 4);

            modelBuilder.Entity<t_da_jxc_month_anal>()
                .Property(e => e.memo)
                .IsUnicode(false);

            modelBuilder.Entity<t_da_jxc_month_anal>()
                .Property(e => e.other1)
                .IsUnicode(false);

            modelBuilder.Entity<t_da_jxc_month_anal>()
                .Property(e => e.other2)
                .IsUnicode(false);

            modelBuilder.Entity<t_da_jxc_month_anal>()
                .Property(e => e.other3)
                .IsUnicode(false);

            modelBuilder.Entity<t_da_jxc_month_anal>()
                .Property(e => e.num1)
                .HasPrecision(16, 4);

            modelBuilder.Entity<t_da_jxc_month_anal>()
                .Property(e => e.num2)
                .HasPrecision(16, 4);

            modelBuilder.Entity<t_da_jxc_month_anal>()
                .Property(e => e.num3)
                .HasPrecision(16, 4);

            modelBuilder.Entity<t_da_jxc_month_anal>()
                .Property(e => e.com_flag)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<t_da_jxc_week>()
                .Property(e => e.item_no)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<t_da_jxc_week>()
                .Property(e => e.oper_date)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<t_da_jxc_week>()
                .Property(e => e.branch_no)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<t_da_jxc_week>()
                .Property(e => e.start_date)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<t_da_jxc_week>()
                .Property(e => e.end_date)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<t_da_jxc_week>()
                .Property(e => e.cost_price)
                .HasPrecision(16, 4);

            modelBuilder.Entity<t_da_jxc_week>()
                .Property(e => e.init_qty)
                .HasPrecision(16, 4);

            modelBuilder.Entity<t_da_jxc_week>()
                .Property(e => e.init_amt)
                .HasPrecision(16, 4);

            modelBuilder.Entity<t_da_jxc_week>()
                .Property(e => e.init_amt2)
                .HasPrecision(16, 4);

            modelBuilder.Entity<t_da_jxc_week>()
                .Property(e => e.avg_cost_amt)
                .HasPrecision(16, 4);

            modelBuilder.Entity<t_da_jxc_week>()
                .Property(e => e.avg_profit_amt)
                .HasPrecision(16, 4);

            modelBuilder.Entity<t_da_jxc_week>()
                .Property(e => e.pi_qty)
                .HasPrecision(16, 4);

            modelBuilder.Entity<t_da_jxc_week>()
                .Property(e => e.pi_amt)
                .HasPrecision(16, 4);

            modelBuilder.Entity<t_da_jxc_week>()
                .Property(e => e.so_qty)
                .HasPrecision(16, 4);

            modelBuilder.Entity<t_da_jxc_week>()
                .Property(e => e.so_amt)
                .HasPrecision(16, 4);

            modelBuilder.Entity<t_da_jxc_week>()
                .Property(e => e.mi_qty)
                .HasPrecision(16, 4);

            modelBuilder.Entity<t_da_jxc_week>()
                .Property(e => e.mi_amt)
                .HasPrecision(16, 4);

            modelBuilder.Entity<t_da_jxc_week>()
                .Property(e => e.mo_qty)
                .HasPrecision(16, 4);

            modelBuilder.Entity<t_da_jxc_week>()
                .Property(e => e.mo_amt)
                .HasPrecision(16, 4);

            modelBuilder.Entity<t_da_jxc_week>()
                .Property(e => e.di_qty)
                .HasPrecision(16, 4);

            modelBuilder.Entity<t_da_jxc_week>()
                .Property(e => e.di_amt)
                .HasPrecision(16, 4);

            modelBuilder.Entity<t_da_jxc_week>()
                .Property(e => e.do_qty)
                .HasPrecision(16, 4);

            modelBuilder.Entity<t_da_jxc_week>()
                .Property(e => e.do_amt)
                .HasPrecision(16, 4);

            modelBuilder.Entity<t_da_jxc_week>()
                .Property(e => e.pos_qty)
                .HasPrecision(16, 4);

            modelBuilder.Entity<t_da_jxc_week>()
                .Property(e => e.pos_amt)
                .HasPrecision(16, 4);

            modelBuilder.Entity<t_da_jxc_week>()
                .Property(e => e.pos_ret_qty)
                .HasPrecision(16, 4);

            modelBuilder.Entity<t_da_jxc_week>()
                .Property(e => e.pos_ret_amt)
                .HasPrecision(16, 4);

            modelBuilder.Entity<t_da_jxc_week>()
                .Property(e => e.pos_send_qty)
                .HasPrecision(16, 4);

            modelBuilder.Entity<t_da_jxc_week>()
                .Property(e => e.pos_send_amt)
                .HasPrecision(16, 4);

            modelBuilder.Entity<t_da_jxc_week>()
                .Property(e => e.oo_qty)
                .HasPrecision(16, 4);

            modelBuilder.Entity<t_da_jxc_week>()
                .Property(e => e.oo_amt)
                .HasPrecision(16, 4);

            modelBuilder.Entity<t_da_jxc_week>()
                .Property(e => e.settle_qty)
                .HasPrecision(16, 4);

            modelBuilder.Entity<t_da_jxc_week>()
                .Property(e => e.settle_amt)
                .HasPrecision(16, 4);

            modelBuilder.Entity<t_da_jxc_week>()
                .Property(e => e.settle_amt2)
                .HasPrecision(16, 4);

            modelBuilder.Entity<t_da_jxc_week>()
                .Property(e => e.cost_change_amt)
                .HasPrecision(16, 4);

            modelBuilder.Entity<t_da_jxc_week>()
                .Property(e => e.pos_dct_amt)
                .HasPrecision(16, 4);

            modelBuilder.Entity<t_da_jxc_week>()
                .Property(e => e.main_sup)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<t_da_jxc_week>()
                .Property(e => e.dec_rate)
                .HasPrecision(16, 4);

            modelBuilder.Entity<t_da_jxc_week>()
                .Property(e => e.so_price)
                .HasPrecision(16, 4);

            modelBuilder.Entity<t_da_jxc_week>()
                .Property(e => e.sale_price)
                .HasPrecision(16, 4);

            modelBuilder.Entity<t_da_jxc_week>()
                .Property(e => e.com_flag)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<t_da_jxc_week>()
                .Property(e => e.costdiff_amt)
                .HasPrecision(16, 4);

            modelBuilder.Entity<t_da_sale_plan>()
                .Property(e => e.plan_type)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<t_da_sale_plan>()
                .Property(e => e.plan_no)
                .IsUnicode(false);

            modelBuilder.Entity<t_da_sale_plan>()
                .Property(e => e.plan_name)
                .IsUnicode(false);

            modelBuilder.Entity<t_da_sale_plan>()
                .Property(e => e.time_type)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<t_da_sale_plan>()
                .Property(e => e.plan_time)
                .IsUnicode(false);

            modelBuilder.Entity<t_da_sale_plan>()
                .Property(e => e.total_money)
                .HasPrecision(18, 4);

            modelBuilder.Entity<t_da_sale_plan>()
                .Property(e => e.total_profit)
                .HasPrecision(18, 4);

            modelBuilder.Entity<t_da_sale_plan>()
                .Property(e => e.note)
                .IsUnicode(false);

            modelBuilder.Entity<t_da_saleman_daysum>()
                .Property(e => e.item_no)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<t_da_saleman_daysum>()
                .Property(e => e.oper_date)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<t_da_saleman_daysum>()
                .Property(e => e.branch_no)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<t_da_saleman_daysum>()
                .Property(e => e.sale_id)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<t_da_saleman_daysum>()
                .Property(e => e.cost_price)
                .HasPrecision(16, 4);

            modelBuilder.Entity<t_da_saleman_daysum>()
                .Property(e => e.so_qty)
                .HasPrecision(16, 4);

            modelBuilder.Entity<t_da_saleman_daysum>()
                .Property(e => e.so_amt)
                .HasPrecision(16, 4);

            modelBuilder.Entity<t_da_saleman_daysum>()
                .Property(e => e.pos_qty)
                .HasPrecision(16, 4);

            modelBuilder.Entity<t_da_saleman_daysum>()
                .Property(e => e.pos_amt)
                .HasPrecision(16, 4);

            modelBuilder.Entity<t_da_saleman_daysum>()
                .Property(e => e.pos_ret_qty)
                .HasPrecision(16, 4);

            modelBuilder.Entity<t_da_saleman_daysum>()
                .Property(e => e.pos_ret_amt)
                .HasPrecision(16, 4);

            modelBuilder.Entity<t_da_saleman_daysum>()
                .Property(e => e.pos_send_qty)
                .HasPrecision(16, 4);

            modelBuilder.Entity<t_da_saleman_daysum>()
                .Property(e => e.pos_send_amt)
                .HasPrecision(16, 4);

            modelBuilder.Entity<t_da_saleman_daysum>()
                .Property(e => e.pos_dct_amt)
                .HasPrecision(16, 4);

            modelBuilder.Entity<t_da_saleman_daysum>()
                .Property(e => e.sale_price)
                .HasPrecision(16, 4);

            modelBuilder.Entity<t_da_saleman_daysum>()
                .Property(e => e.sale_rate)
                .HasPrecision(16, 4);

            modelBuilder.Entity<t_da_saleman_daysum>()
                .Property(e => e.com_flag)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<t_da_saleman_daysum>()
                .Property(e => e.sale_rate_amt)
                .HasPrecision(16, 4);

            modelBuilder.Entity<t_da_saleman_daysum>()
                .Property(e => e.sale_ration_amt)
                .HasPrecision(16, 4);

            modelBuilder.Entity<t_da_saleman_daysum>()
                .Property(e => e.clss_rate_amt)
                .HasPrecision(16, 4);

            modelBuilder.Entity<t_da_saleman_daysum>()
                .Property(e => e.brand_rate_amt)
                .HasPrecision(16, 4);

            modelBuilder.Entity<t_da_saleman_daysum>()
                .Property(e => e.return_rate_amt)
                .HasPrecision(16, 4);

            modelBuilder.Entity<t_da_saleman_daysum>()
                .Property(e => e.duty_rate_amt)
                .HasPrecision(16, 4);

            modelBuilder.Entity<t_da_saleman_deduct_flow>()
                .Property(e => e.flow_id)
                .HasPrecision(16, 0);

            modelBuilder.Entity<t_da_saleman_deduct_flow>()
                .Property(e => e.deduct_no)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<t_da_saleman_deduct_flow>()
                .Property(e => e.branch_no)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<t_da_saleman_deduct_flow>()
                .Property(e => e.flow_no)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<t_da_saleman_deduct_flow>()
                .Property(e => e.item_no)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<t_da_saleman_deduct_flow>()
                .Property(e => e.oper_date)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<t_da_saleman_deduct_flow>()
                .Property(e => e.sale_man)
                .IsUnicode(false);

            modelBuilder.Entity<t_da_saleman_deduct_flow>()
                .Property(e => e.deduct_amt)
                .HasPrecision(16, 4);

            modelBuilder.Entity<t_da_saleman_deduct_flow>()
                .Property(e => e.deduct_type)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<t_da_saleman_deduct_flow>()
                .Property(e => e.memo)
                .IsUnicode(false);

            modelBuilder.Entity<t_da_sell_aim>()
                .Property(e => e.year_month)
                .IsUnicode(false);

            modelBuilder.Entity<t_da_sell_aim>()
                .Property(e => e.branch_no)
                .IsUnicode(false);

            modelBuilder.Entity<t_da_sell_aim>()
                .Property(e => e.month_aim)
                .HasPrecision(18, 4);

            modelBuilder.Entity<t_da_sell_aim>()
                .Property(e => e.month_sell)
                .HasPrecision(18, 4);

            modelBuilder.Entity<t_da_sell_aim>()
                .Property(e => e.flag)
                .IsUnicode(false);

            modelBuilder.Entity<t_da_total_daysum>()
                .Property(e => e.oper_date)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<t_da_total_daysum>()
                .Property(e => e.branch_no)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<t_da_total_daysum>()
                .Property(e => e.purchase_amt)
                .HasPrecision(16, 4);

            modelBuilder.Entity<t_da_total_daysum>()
                .Property(e => e.pm_rise)
                .HasPrecision(16, 4);

            modelBuilder.Entity<t_da_total_daysum>()
                .Property(e => e.sale_rise)
                .HasPrecision(16, 4);

            modelBuilder.Entity<t_da_total_daysum>()
                .Property(e => e.pos_cashamt)
                .HasPrecision(16, 4);

            modelBuilder.Entity<t_da_total_daysum>()
                .Property(e => e.pos_sumsheet)
                .HasPrecision(16, 4);

            modelBuilder.Entity<t_da_total_daysum>()
                .Property(e => e.pos_avgprice)
                .HasPrecision(16, 4);

            modelBuilder.Entity<t_da_total_daysum>()
                .Property(e => e.pos_sheetrise)
                .HasPrecision(16, 4);

            modelBuilder.Entity<t_da_total_daysum>()
                .Property(e => e.avg_profitamt)
                .HasPrecision(16, 4);

            modelBuilder.Entity<t_da_total_daysum>()
                .Property(e => e.avg_rise)
                .HasPrecision(16, 4);

            modelBuilder.Entity<t_da_total_daysum>()
                .Property(e => e.fifo_profitamt)
                .HasPrecision(16, 4);

            modelBuilder.Entity<t_da_total_daysum>()
                .Property(e => e.fifo_rise)
                .HasPrecision(16, 4);

            modelBuilder.Entity<t_da_total_daysum>()
                .Property(e => e.charge_amt)
                .HasPrecision(16, 4);

            modelBuilder.Entity<t_da_total_daysum>()
                .Property(e => e.num1)
                .HasPrecision(16, 4);

            modelBuilder.Entity<t_da_total_daysum>()
                .Property(e => e.num2)
                .HasPrecision(16, 4);

            modelBuilder.Entity<t_da_total_daysum>()
                .Property(e => e.num3)
                .HasPrecision(16, 4);

            modelBuilder.Entity<t_da_total_daysum>()
                .Property(e => e.num4)
                .HasPrecision(16, 4);

            modelBuilder.Entity<t_da_total_daysum>()
                .Property(e => e.num5)
                .HasPrecision(16, 4);

            modelBuilder.Entity<t_da_total_daysum>()
                .Property(e => e.num6)
                .HasPrecision(16, 4);

            modelBuilder.Entity<t_da_total_daysum>()
                .Property(e => e.num7)
                .HasPrecision(16, 4);

            modelBuilder.Entity<t_da_total_daysum>()
                .Property(e => e.num8)
                .HasPrecision(16, 4);

            modelBuilder.Entity<t_da_total_daysum>()
                .Property(e => e.num9)
                .HasPrecision(16, 4);

            modelBuilder.Entity<t_da_total_daysum>()
                .Property(e => e.num10)
                .HasPrecision(16, 4);

            modelBuilder.Entity<t_da_total_daysum>()
                .Property(e => e.com_flag)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<t_da_tran_aim>()
                .Property(e => e.year_month)
                .IsUnicode(false);

            modelBuilder.Entity<t_da_tran_aim>()
                .Property(e => e.branch_no)
                .IsUnicode(false);

            modelBuilder.Entity<t_da_tran_aim>()
                .Property(e => e.month_aim)
                .HasPrecision(18, 4);

            modelBuilder.Entity<t_da_tran_aim>()
                .Property(e => e.month_sell)
                .HasPrecision(18, 4);

            modelBuilder.Entity<t_da_tran_aim>()
                .Property(e => e.flag)
                .IsUnicode(false);

            modelBuilder.Entity<t_da_tran_aim>()
                .Property(e => e.oper_id)
                .IsUnicode(false);

            modelBuilder.Entity<t_da_transell_aim>()
                .Property(e => e.year_month)
                .IsUnicode(false);

            modelBuilder.Entity<t_da_transell_aim>()
                .Property(e => e.branch_no)
                .IsUnicode(false);

            modelBuilder.Entity<t_da_transell_aim>()
                .Property(e => e.item_cls)
                .IsUnicode(false);

            modelBuilder.Entity<t_da_transell_aim>()
                .Property(e => e.month_aim)
                .HasPrecision(18, 4);

            modelBuilder.Entity<t_da_transell_aim>()
                .Property(e => e.month_sell)
                .HasPrecision(18, 4);

            modelBuilder.Entity<t_da_transell_aim>()
                .Property(e => e.flag)
                .IsUnicode(false);

            modelBuilder.Entity<t_da_transell_aim>()
                .Property(e => e.oper_id)
                .IsUnicode(false);

            modelBuilder.Entity<t_dm_input_init>()
                .Property(e => e.sheet_no)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<t_dm_input_init>()
                .Property(e => e.branch_no)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<t_dm_input_init>()
                .Property(e => e.approve_flag)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<t_dm_input_init>()
                .Property(e => e.branch_flag)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<t_dm_input_init>()
                .Property(e => e.oper_range)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<t_dm_input_init>()
                .Property(e => e.com_flag)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<t_dm_input_init>()
                .Property(e => e.memo)
                .IsUnicode(false);

            modelBuilder.Entity<t_dm_input_init>()
                .Property(e => e.oper_id)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<t_dm_input_init>()
                .Property(e => e.confirm_man)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<t_exec_info>()
                .Property(e => e.exec_name)
                .IsUnicode(false);

            modelBuilder.Entity<t_fm_cash_account_info>()
                .Property(e => e.account_no)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<t_fm_cash_account_info>()
                .Property(e => e.account_name)
                .IsUnicode(false);

            modelBuilder.Entity<t_fm_cash_account_info>()
                .Property(e => e.branch_no)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<t_fm_cash_account_info>()
                .Property(e => e.memo)
                .IsUnicode(false);

            modelBuilder.Entity<t_fm_cash_detail>()
                .Property(e => e.flow_id)
                .HasPrecision(18, 0);

            modelBuilder.Entity<t_fm_cash_detail>()
                .Property(e => e.sheet_no)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<t_fm_cash_detail>()
                .Property(e => e.fee_code)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<t_fm_cash_detail>()
                .Property(e => e.fee_amount)
                .HasPrecision(16, 4);

            modelBuilder.Entity<t_fm_cash_detail>()
                .Property(e => e.memo)
                .IsUnicode(false);

            modelBuilder.Entity<t_fm_cash_detail>()
                .Property(e => e.com_flag)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<t_fm_cash_master>()
                .Property(e => e.sheet_no)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<t_fm_cash_master>()
                .Property(e => e.account_no)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<t_fm_cash_master>()
                .Property(e => e.d_account_no)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<t_fm_cash_master>()
                .Property(e => e.trans_no)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<t_fm_cash_master>()
                .Property(e => e.branch_no)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<t_fm_cash_master>()
                .Property(e => e.voucher_no)
                .IsUnicode(false);

            modelBuilder.Entity<t_fm_cash_master>()
                .Property(e => e.order_man)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<t_fm_cash_master>()
                .Property(e => e.pay_way)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<t_fm_cash_master>()
                .Property(e => e.coin_no)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<t_fm_cash_master>()
                .Property(e => e.approve_flag)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<t_fm_cash_master>()
                .Property(e => e.sheet_amount)
                .HasPrecision(16, 4);

            modelBuilder.Entity<t_fm_cash_master>()
                .Property(e => e.oper_id)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<t_fm_cash_master>()
                .Property(e => e.confirm_man)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<t_fm_cash_master>()
                .Property(e => e.memo)
                .IsUnicode(false);

            modelBuilder.Entity<t_fm_cash_master>()
                .Property(e => e.memo2)
                .IsUnicode(false);

            modelBuilder.Entity<t_fm_cash_master>()
                .Property(e => e.com_flag)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<t_fm_cash_master>()
                .Property(e => e.oper_branch)
                .IsUnicode(false);

            modelBuilder.Entity<t_fm_charge_detail>()
                .Property(e => e.flow_id)
                .HasPrecision(14, 0);

            modelBuilder.Entity<t_fm_charge_detail>()
                .Property(e => e.sheet_no)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<t_fm_charge_detail>()
                .Property(e => e.charge_no)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<t_fm_charge_detail>()
                .Property(e => e.sub_amt)
                .HasPrecision(16, 4);

            modelBuilder.Entity<t_fm_charge_detail>()
                .Property(e => e.remark)
                .IsUnicode(false);

            modelBuilder.Entity<t_fm_charge_master>()
                .Property(e => e.sheet_no)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<t_fm_charge_master>()
                .Property(e => e.supcust_no)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<t_fm_charge_master>()
                .Property(e => e.acc_type)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<t_fm_charge_master>()
                .Property(e => e.voucher_no)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<t_fm_charge_master>()
                .Property(e => e.trans_no)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<t_fm_charge_master>()
                .Property(e => e.memo)
                .IsUnicode(false);

            modelBuilder.Entity<t_fm_charge_master>()
                .Property(e => e.oper_id)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<t_fm_charge_master>()
                .Property(e => e.approve_flag)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<t_fm_charge_master>()
                .Property(e => e.confirm_man)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<t_fm_charge_master>()
                .Property(e => e.is_internal)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<t_fm_charge_master>()
                .Property(e => e.sheet_amt)
                .HasPrecision(16, 4);

            modelBuilder.Entity<t_fm_charge_master>()
                .Property(e => e.com_flag)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<t_fm_charge_master>()
                .Property(e => e.branch_no)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<t_fm_recpay_detail>()
                .Property(e => e.flow_id)
                .HasPrecision(14, 0);

            modelBuilder.Entity<t_fm_recpay_detail>()
                .Property(e => e.sheet_no)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<t_fm_recpay_detail>()
                .Property(e => e.voucher_no)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<t_fm_recpay_detail>()
                .Property(e => e.discount)
                .HasPrecision(5, 4);

            modelBuilder.Entity<t_fm_recpay_detail>()
                .Property(e => e.sheet_amt)
                .HasPrecision(16, 4);

            modelBuilder.Entity<t_fm_recpay_detail>()
                .Property(e => e.coin_no)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<t_fm_recpay_detail>()
                .Property(e => e.sheet_amt_native)
                .HasPrecision(16, 4);

            modelBuilder.Entity<t_fm_recpay_detail>()
                .Property(e => e.memo)
                .IsUnicode(false);

            modelBuilder.Entity<t_fm_recpay_detail>()
                .Property(e => e.other_amt)
                .HasPrecision(16, 4);

            modelBuilder.Entity<t_fm_recpay_detail>()
                .Property(e => e.chr_selected)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<t_fm_recpay_detail>()
                .Property(e => e.memo2)
                .IsUnicode(false);

            modelBuilder.Entity<t_fm_recpay_flow>()
                .Property(e => e.flow_id)
                .HasPrecision(18, 0);

            modelBuilder.Entity<t_fm_recpay_flow>()
                .Property(e => e.voucher_no)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<t_fm_recpay_flow>()
                .Property(e => e.trans_no)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<t_fm_recpay_flow>()
                .Property(e => e.coin_no)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<t_fm_recpay_flow>()
                .Property(e => e.discount)
                .HasPrecision(5, 4);

            modelBuilder.Entity<t_fm_recpay_flow>()
                .Property(e => e.sheet_amt)
                .HasPrecision(16, 4);

            modelBuilder.Entity<t_fm_recpay_flow>()
                .Property(e => e.should_amt)
                .HasPrecision(16, 4);

            modelBuilder.Entity<t_fm_recpay_flow>()
                .Property(e => e.already_amt)
                .HasPrecision(16, 4);

            modelBuilder.Entity<t_fm_recpay_flow>()
                .Property(e => e.paid_sheetno)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<t_fm_recpay_flow>()
                .Property(e => e.tax_amt)
                .HasPrecision(16, 4);

            modelBuilder.Entity<t_fm_recpay_flow>()
                .Property(e => e.pay_way)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<t_fm_recpay_flow>()
                .Property(e => e.sale_way)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<t_fm_recpay_flow>()
                .Property(e => e.pay_percent)
                .HasPrecision(5, 4);

            modelBuilder.Entity<t_fm_recpay_flow>()
                .Property(e => e.settle_flag)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<t_fm_recpay_flow>()
                .Property(e => e.supcust_no)
                .IsUnicode(false);

            modelBuilder.Entity<t_fm_recpay_flow>()
                .Property(e => e.memo)
                .IsUnicode(false);

            modelBuilder.Entity<t_fm_recpay_flow>()
                .Property(e => e.com_flag)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<t_fm_recpay_flow>()
                .Property(e => e.branch_no)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<t_fm_recpay_flow>()
                .Property(e => e.acc_type)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<t_fm_recpay_flow>()
                .Property(e => e.other_amt)
                .HasPrecision(16, 4);

            modelBuilder.Entity<t_fm_recpay_flow>()
                .Property(e => e.dec_amt)
                .HasPrecision(16, 4);

            modelBuilder.Entity<t_fm_recpay_ly_detail>()
                .Property(e => e.flow_id)
                .HasPrecision(14, 0);

            modelBuilder.Entity<t_fm_recpay_ly_detail>()
                .Property(e => e.item_no)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<t_fm_recpay_ly_detail>()
                .Property(e => e.branch_no)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<t_fm_recpay_ly_detail>()
                .Property(e => e.sale_qty)
                .HasPrecision(16, 4);

            modelBuilder.Entity<t_fm_recpay_ly_detail>()
                .Property(e => e.sale_amount)
                .HasPrecision(16, 4);

            modelBuilder.Entity<t_fm_recpay_ly_detail>()
                .Property(e => e.ac_amount)
                .HasPrecision(16, 4);

            modelBuilder.Entity<t_fm_recpay_ly_detail>()
                .Property(e => e.sup_ly_rate)
                .HasPrecision(16, 4);

            modelBuilder.Entity<t_fm_recpay_ly_detail>()
                .Property(e => e.sup_ly_amount)
                .HasPrecision(16, 4);

            modelBuilder.Entity<t_fm_recpay_ly_detail>()
                .Property(e => e.tax)
                .HasPrecision(16, 4);

            modelBuilder.Entity<t_fm_recpay_ly_detail>()
                .Property(e => e.num1)
                .HasPrecision(16, 4);

            modelBuilder.Entity<t_fm_recpay_ly_detail>()
                .Property(e => e.num2)
                .HasPrecision(16, 4);

            modelBuilder.Entity<t_fm_recpay_ly_detail>()
                .Property(e => e.other1)
                .IsUnicode(false);

            modelBuilder.Entity<t_fm_recpay_ly_detail>()
                .Property(e => e.other2)
                .IsUnicode(false);

            modelBuilder.Entity<t_fm_recpay_ly_detail>()
                .Property(e => e.sheet_no)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<t_fm_recpay_ly_master>()
                .Property(e => e.sup_no)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<t_fm_recpay_ly_master>()
                .Property(e => e.sum_amount)
                .HasPrecision(16, 4);

            modelBuilder.Entity<t_fm_recpay_ly_master>()
                .Property(e => e.dct_amount)
                .HasPrecision(16, 4);

            modelBuilder.Entity<t_fm_recpay_ly_master>()
                .Property(e => e.confirm_man)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<t_fm_recpay_ly_master>()
                .Property(e => e.oper_id)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<t_fm_recpay_ly_master>()
                .Property(e => e.sheet_no)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<t_fm_recpay_ly_master>()
                .Property(e => e.trans_no)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<t_fm_recpay_ly_master>()
                .Property(e => e.approve_flag)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<t_fm_recpay_ly_master>()
                .Property(e => e.num1)
                .HasPrecision(16, 4);

            modelBuilder.Entity<t_fm_recpay_ly_master>()
                .Property(e => e.num2)
                .HasPrecision(16, 4);

            modelBuilder.Entity<t_fm_recpay_ly_master>()
                .Property(e => e.other1)
                .IsUnicode(false);

            modelBuilder.Entity<t_fm_recpay_ly_master>()
                .Property(e => e.other2)
                .IsUnicode(false);

            modelBuilder.Entity<t_fm_recpay_ly_master>()
                .Property(e => e.notax_amt)
                .HasPrecision(16, 4);

            modelBuilder.Entity<t_fm_recpay_ly_master>()
                .Property(e => e.tax_amt)
                .HasPrecision(16, 4);

            modelBuilder.Entity<t_fm_recpay_ly_master>()
                .Property(e => e.withtax_amt)
                .HasPrecision(16, 4);

            modelBuilder.Entity<t_fm_recpay_ly_master>()
                .Property(e => e.get_amt)
                .HasPrecision(16, 4);

            modelBuilder.Entity<t_fm_recpay_ly_master>()
                .Property(e => e.get_amt_sub1)
                .HasPrecision(16, 4);

            modelBuilder.Entity<t_fm_recpay_ly_master>()
                .Property(e => e.get_amt_sub2)
                .HasPrecision(16, 4);

            modelBuilder.Entity<t_fm_recpay_ly_master>()
                .Property(e => e.get_amt_sub3)
                .HasPrecision(16, 4);

            modelBuilder.Entity<t_fm_recpay_ly_master>()
                .Property(e => e.sub_amt)
                .HasPrecision(16, 4);

            modelBuilder.Entity<t_fm_recpay_ly_master>()
                .Property(e => e.sheet_amt)
                .HasPrecision(16, 4);

            modelBuilder.Entity<t_fm_recpay_ly_master>()
                .Property(e => e.com_flag)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<t_fm_recpay_ly_master>()
                .Property(e => e.branch_no)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<t_fm_recpay_master>()
                .Property(e => e.sheet_no)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<t_fm_recpay_master>()
                .Property(e => e.trans_no)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<t_fm_recpay_master>()
                .Property(e => e.supcust_no)
                .IsUnicode(false);

            modelBuilder.Entity<t_fm_recpay_master>()
                .Property(e => e.acc_type)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<t_fm_recpay_master>()
                .Property(e => e.sheet_amt)
                .HasPrecision(16, 4);

            modelBuilder.Entity<t_fm_recpay_master>()
                .Property(e => e.is_bysheet)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<t_fm_recpay_master>()
                .Property(e => e.pay_way)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<t_fm_recpay_master>()
                .Property(e => e.approve_flag)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<t_fm_recpay_master>()
                .Property(e => e.oper_id)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<t_fm_recpay_master>()
                .Property(e => e.confirm_man)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<t_fm_recpay_master>()
                .Property(e => e.flag_post)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<t_fm_recpay_master>()
                .Property(e => e.com_flag)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<t_fm_recpay_master>()
                .Property(e => e.branch_no)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<t_fm_recpay_master>()
                .Property(e => e.memo)
                .IsUnicode(false);

            modelBuilder.Entity<t_fm_recpay_master>()
                .Property(e => e.other_amt)
                .HasPrecision(16, 4);

            modelBuilder.Entity<t_im_autoplan_set>()
                .Property(e => e.branch_no)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<t_im_autoplan_set>()
                .Property(e => e.item_clsno)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<t_im_autoplan_set>()
                .Property(e => e.monday)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<t_im_autoplan_set>()
                .Property(e => e.tuesday)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<t_im_autoplan_set>()
                .Property(e => e.wednesday)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<t_im_autoplan_set>()
                .Property(e => e.thursday)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<t_im_autoplan_set>()
                .Property(e => e.friday)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<t_im_autoplan_set>()
                .Property(e => e.saturday)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<t_im_autoplan_set>()
                .Property(e => e.sunday)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<t_im_batch>()
                .Property(e => e.flow_id)
                .HasPrecision(14, 0);

            modelBuilder.Entity<t_im_batch>()
                .Property(e => e.branch_no)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<t_im_batch>()
                .Property(e => e.batch_no)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<t_im_batch>()
                .Property(e => e.batch_no2)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<t_im_batch>()
                .Property(e => e.item_no)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<t_im_batch>()
                .Property(e => e.supcust_no)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<t_im_batch>()
                .Property(e => e.sale_way)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<t_im_batch>()
                .Property(e => e.trans_no)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<t_im_batch>()
                .Property(e => e.in_qty)
                .HasPrecision(16, 4);

            modelBuilder.Entity<t_im_batch>()
                .Property(e => e.in_price)
                .HasPrecision(16, 4);

            modelBuilder.Entity<t_im_batch>()
                .Property(e => e.in_amt)
                .HasPrecision(16, 4);

            modelBuilder.Entity<t_im_batch>()
                .Property(e => e.sale_qty)
                .HasPrecision(16, 4);

            modelBuilder.Entity<t_im_batch>()
                .Property(e => e.sale_amt)
                .HasPrecision(16, 4);

            modelBuilder.Entity<t_im_batch>()
                .Property(e => e.do_qty)
                .HasPrecision(16, 4);

            modelBuilder.Entity<t_im_batch>()
                .Property(e => e.do_amt)
                .HasPrecision(16, 4);

            modelBuilder.Entity<t_im_batch>()
                .Property(e => e.up_qty)
                .HasPrecision(16, 4);

            modelBuilder.Entity<t_im_batch>()
                .Property(e => e.up_amt)
                .HasPrecision(16, 4);

            modelBuilder.Entity<t_im_batch>()
                .Property(e => e.co_qty)
                .HasPrecision(16, 4);

            modelBuilder.Entity<t_im_batch>()
                .Property(e => e.co_amt)
                .HasPrecision(16, 4);

            modelBuilder.Entity<t_im_batch>()
                .Property(e => e.ro_qty)
                .HasPrecision(16, 4);

            modelBuilder.Entity<t_im_batch>()
                .Property(e => e.ro_amt)
                .HasPrecision(16, 4);

            modelBuilder.Entity<t_im_batch>()
                .Property(e => e.out_qty)
                .HasPrecision(16, 4);

            modelBuilder.Entity<t_im_batch>()
                .Property(e => e.out_amt)
                .HasPrecision(16, 4);

            modelBuilder.Entity<t_im_batch>()
                .Property(e => e.cost_amt)
                .HasPrecision(16, 4);

            modelBuilder.Entity<t_im_batch>()
                .Property(e => e.profit_amt)
                .HasPrecision(16, 4);

            modelBuilder.Entity<t_im_batch>()
                .Property(e => e.ad_qty)
                .HasPrecision(16, 4);

            modelBuilder.Entity<t_im_batch>()
                .Property(e => e.ad_price)
                .HasPrecision(16, 4);

            modelBuilder.Entity<t_im_batch>()
                .Property(e => e.settle_qty)
                .HasPrecision(16, 4);

            modelBuilder.Entity<t_im_batch>()
                .Property(e => e.settle_price)
                .HasPrecision(16, 4);

            modelBuilder.Entity<t_im_batch>()
                .Property(e => e.re_qty)
                .HasPrecision(16, 4);

            modelBuilder.Entity<t_im_batch>()
                .Property(e => e.dx_qty)
                .HasPrecision(16, 4);

            modelBuilder.Entity<t_im_batch>()
                .Property(e => e.al_qty)
                .HasPrecision(16, 4);

            modelBuilder.Entity<t_im_batch>()
                .Property(e => e.paid_flag)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<t_im_batch>()
                .Property(e => e.memo)
                .IsUnicode(false);

            modelBuilder.Entity<t_im_batch>()
                .Property(e => e.other1)
                .IsUnicode(false);

            modelBuilder.Entity<t_im_batch>()
                .Property(e => e.other2)
                .IsUnicode(false);

            modelBuilder.Entity<t_im_batch>()
                .Property(e => e.num1)
                .HasPrecision(16, 4);

            modelBuilder.Entity<t_im_batch>()
                .Property(e => e.num2)
                .HasPrecision(16, 4);

            modelBuilder.Entity<t_im_batch>()
                .Property(e => e.com_flag)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<t_im_batch_move>()
                .Property(e => e.flow_id)
                .HasPrecision(14, 0);

            modelBuilder.Entity<t_im_batch_move>()
                .Property(e => e.branch_no)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<t_im_batch_move>()
                .Property(e => e.trans_no)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<t_im_batch_move>()
                .Property(e => e.voucher_no)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<t_im_batch_move>()
                .Property(e => e.oper_date)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<t_im_batch_move>()
                .Property(e => e.item_no)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<t_im_batch_move>()
                .Property(e => e.out_qty)
                .HasPrecision(16, 4);

            modelBuilder.Entity<t_im_batch_move>()
                .Property(e => e.out_price)
                .HasPrecision(16, 4);

            modelBuilder.Entity<t_im_batch_move>()
                .Property(e => e.out_amt)
                .HasPrecision(16, 4);

            modelBuilder.Entity<t_im_batch_move>()
                .Property(e => e.batch_no)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<t_im_batch_move>()
                .Property(e => e.in_trans_no)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<t_im_batch_move>()
                .Property(e => e.supcust_no)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<t_im_batch_move>()
                .Property(e => e.sale_way)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<t_im_batch_move>()
                .Property(e => e.in_price)
                .HasPrecision(16, 4);

            modelBuilder.Entity<t_im_batch_move>()
                .Property(e => e.memo)
                .IsUnicode(false);

            modelBuilder.Entity<t_im_batch_move>()
                .Property(e => e.other1)
                .IsUnicode(false);

            modelBuilder.Entity<t_im_batch_move>()
                .Property(e => e.other2)
                .IsUnicode(false);

            modelBuilder.Entity<t_im_batch_move>()
                .Property(e => e.num1)
                .HasPrecision(16, 4);

            modelBuilder.Entity<t_im_batch_move>()
                .Property(e => e.num2)
                .HasPrecision(16, 4);

            modelBuilder.Entity<t_im_batch_move>()
                .Property(e => e.com_flag)
                .IsUnicode(false);

            modelBuilder.Entity<t_im_batch_out>()
                .Property(e => e.flow_id)
                .HasPrecision(14, 0);

            modelBuilder.Entity<t_im_batch_out>()
                .Property(e => e.branch_no)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<t_im_batch_out>()
                .Property(e => e.flow_no)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<t_im_batch_out>()
                .Property(e => e.trans_no)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<t_im_batch_out>()
                .Property(e => e.voucher_no)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<t_im_batch_out>()
                .Property(e => e.oper_date)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<t_im_batch_out>()
                .Property(e => e.item_no)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<t_im_batch_out>()
                .Property(e => e.out_qty)
                .HasPrecision(16, 4);

            modelBuilder.Entity<t_im_batch_out>()
                .Property(e => e.out_price)
                .HasPrecision(16, 4);

            modelBuilder.Entity<t_im_batch_out>()
                .Property(e => e.out_amt)
                .HasPrecision(16, 4);

            modelBuilder.Entity<t_im_batch_out>()
                .Property(e => e.batch_no)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<t_im_batch_out>()
                .Property(e => e.in_trans_no)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<t_im_batch_out>()
                .Property(e => e.supcust_no)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<t_im_batch_out>()
                .Property(e => e.sale_way)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<t_im_batch_out>()
                .Property(e => e.in_price)
                .HasPrecision(16, 4);

            modelBuilder.Entity<t_im_batch_out>()
                .Property(e => e.cost_amt)
                .HasPrecision(16, 4);

            modelBuilder.Entity<t_im_batch_out>()
                .Property(e => e.profit_amt)
                .HasPrecision(16, 4);

            modelBuilder.Entity<t_im_batch_out>()
                .Property(e => e.re_qty)
                .HasPrecision(16, 4);

            modelBuilder.Entity<t_im_batch_out>()
                .Property(e => e.dx_qty)
                .HasPrecision(16, 4);

            modelBuilder.Entity<t_im_batch_out>()
                .Property(e => e.al_qty)
                .HasPrecision(16, 4);

            modelBuilder.Entity<t_im_batch_out>()
                .Property(e => e.paid_flag)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<t_im_batch_out>()
                .Property(e => e.memo)
                .IsUnicode(false);

            modelBuilder.Entity<t_im_batch_out>()
                .Property(e => e.other1)
                .IsUnicode(false);

            modelBuilder.Entity<t_im_batch_out>()
                .Property(e => e.other2)
                .IsUnicode(false);

            modelBuilder.Entity<t_im_batch_out>()
                .Property(e => e.num1)
                .HasPrecision(16, 4);

            modelBuilder.Entity<t_im_batch_out>()
                .Property(e => e.num2)
                .HasPrecision(16, 4);

            modelBuilder.Entity<t_im_batch_out>()
                .Property(e => e.com_flag)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<t_im_batch_out>()
                .Property(e => e.diff_cost_price)
                .HasPrecision(16, 4);

            modelBuilder.Entity<t_im_batch_suspend>()
                .Property(e => e.flow_id)
                .HasPrecision(14, 0);

            modelBuilder.Entity<t_im_batch_suspend>()
                .Property(e => e.branch_no)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<t_im_batch_suspend>()
                .Property(e => e.trans_no)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<t_im_batch_suspend>()
                .Property(e => e.voucher_no)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<t_im_batch_suspend>()
                .Property(e => e.oper_date)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<t_im_batch_suspend>()
                .Property(e => e.item_no)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<t_im_batch_suspend>()
                .Property(e => e.real_qty)
                .HasPrecision(16, 4);

            modelBuilder.Entity<t_im_batch_suspend>()
                .Property(e => e.price)
                .HasPrecision(16, 4);

            modelBuilder.Entity<t_im_batch_suspend>()
                .Property(e => e.sheet_amt)
                .HasPrecision(16, 4);

            modelBuilder.Entity<t_im_batch_suspend>()
                .Property(e => e.memo)
                .IsUnicode(false);

            modelBuilder.Entity<t_im_batch_suspend>()
                .Property(e => e.other1)
                .IsUnicode(false);

            modelBuilder.Entity<t_im_batch_suspend>()
                .Property(e => e.other2)
                .IsUnicode(false);

            modelBuilder.Entity<t_im_batch_suspend>()
                .Property(e => e.num1)
                .HasPrecision(16, 4);

            modelBuilder.Entity<t_im_batch_suspend>()
                .Property(e => e.num2)
                .HasPrecision(16, 4);

            modelBuilder.Entity<t_im_batch_suspend>()
                .Property(e => e.com_flag)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<t_im_batch_suspend>()
                .Property(e => e.batch_no)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<t_im_batch_suspend>()
                .Property(e => e.in_price)
                .HasPrecision(16, 4);

            modelBuilder.Entity<t_im_batch_suspend>()
                .Property(e => e.diff_cost_price)
                .HasPrecision(16, 4);

            modelBuilder.Entity<t_im_batch_suspend>()
                .Property(e => e.flow_no)
                .HasPrecision(16, 4);

            modelBuilder.Entity<t_im_branch_stock>()
                .Property(e => e.item_no)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<t_im_branch_stock>()
                .Property(e => e.branch_no)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<t_im_branch_stock>()
                .Property(e => e.stock_qty)
                .HasPrecision(16, 4);

            modelBuilder.Entity<t_im_branch_stock>()
                .Property(e => e.route_qty)
                .HasPrecision(16, 4);

            modelBuilder.Entity<t_im_branch_stock>()
                .Property(e => e.avg_cost)
                .HasPrecision(16, 4);

            modelBuilder.Entity<t_im_branch_stock>()
                .Property(e => e.cost_amt)
                .HasPrecision(16, 4);

            modelBuilder.Entity<t_im_branch_stock>()
                .Property(e => e.last_inprice)
                .HasPrecision(16, 4);

            modelBuilder.Entity<t_im_branch_stock>()
                .Property(e => e.last_baseprice)
                .HasPrecision(16, 4);

            modelBuilder.Entity<t_im_branch_stock>()
                .Property(e => e.min_qty)
                .HasPrecision(16, 4);

            modelBuilder.Entity<t_im_branch_stock>()
                .Property(e => e.max_qty)
                .HasPrecision(16, 4);

            modelBuilder.Entity<t_im_branch_stock>()
                .Property(e => e.acc_qty)
                .HasPrecision(16, 4);

            modelBuilder.Entity<t_im_branch_stock>()
                .Property(e => e.com_flag)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<t_im_check_bak>()
                .Property(e => e.sheet_no)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<t_im_check_bak>()
                .Property(e => e.branch_no)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<t_im_check_bak>()
                .Property(e => e.item_no)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<t_im_check_bak>()
                .Property(e => e.stock_qty)
                .HasPrecision(16, 4);

            modelBuilder.Entity<t_im_check_bak>()
                .Property(e => e.cost_price)
                .HasPrecision(16, 4);

            modelBuilder.Entity<t_im_check_bak2>()
                .Property(e => e.sheet_no)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<t_im_check_bak2>()
                .Property(e => e.branch_no)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<t_im_check_bak2>()
                .Property(e => e.item_no)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<t_im_check_bak2>()
                .Property(e => e.stock_qty)
                .HasPrecision(16, 4);

            modelBuilder.Entity<t_im_check_bak2>()
                .Property(e => e.cost_price)
                .HasPrecision(16, 4);

            modelBuilder.Entity<t_im_check_detail>()
                .Property(e => e.flow_id)
                .HasPrecision(14, 0);

            modelBuilder.Entity<t_im_check_detail>()
                .Property(e => e.sheet_no)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<t_im_check_detail>()
                .Property(e => e.item_no)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<t_im_check_detail>()
                .Property(e => e.in_price)
                .HasPrecision(16, 4);

            modelBuilder.Entity<t_im_check_detail>()
                .Property(e => e.sale_price)
                .HasPrecision(16, 4);

            modelBuilder.Entity<t_im_check_detail>()
                .Property(e => e.real_qty)
                .HasPrecision(16, 4);

            modelBuilder.Entity<t_im_check_detail>()
                .Property(e => e.recheck_qty)
                .HasPrecision(16, 4);

            modelBuilder.Entity<t_im_check_detail>()
                .Property(e => e.memo)
                .IsUnicode(false);

            modelBuilder.Entity<t_im_check_init>()
                .Property(e => e.sheet_no)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<t_im_check_init>()
                .Property(e => e.oper_range)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<t_im_check_init>()
                .Property(e => e.branch_no)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<t_im_check_init>()
                .Property(e => e.check_cls)
                .IsUnicode(false);

            modelBuilder.Entity<t_im_check_init>()
                .Property(e => e.oper_id)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<t_im_check_init>()
                .Property(e => e.confirm_man)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<t_im_check_init>()
                .Property(e => e.approve_flag)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<t_im_check_init>()
                .Property(e => e.memo)
                .IsUnicode(false);

            modelBuilder.Entity<t_im_check_init>()
                .Property(e => e.sheet_amt)
                .HasPrecision(16, 4);

            modelBuilder.Entity<t_im_check_init>()
                .Property(e => e.branch_flag)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<t_im_check_init>()
                .Property(e => e.com_flag)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<t_im_check_init>()
                .Property(e => e.other1)
                .IsUnicode(false);

            modelBuilder.Entity<t_im_check_init>()
                .Property(e => e.proposer)
                .IsUnicode(false);

            modelBuilder.Entity<t_im_check_master>()
                .Property(e => e.sheet_no)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<t_im_check_master>()
                .Property(e => e.check_no)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<t_im_check_master>()
                .Property(e => e.trans_no)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<t_im_check_master>()
                .Property(e => e.branch_no)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<t_im_check_master>()
                .Property(e => e.oper_range)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<t_im_check_master>()
                .Property(e => e.dup_process)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<t_im_check_master>()
                .Property(e => e.oper_id)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<t_im_check_master>()
                .Property(e => e.confirm_man)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<t_im_check_master>()
                .Property(e => e.approve_flag)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<t_im_check_master>()
                .Property(e => e.check_cls)
                .IsUnicode(false);

            modelBuilder.Entity<t_im_check_master>()
                .Property(e => e.meno)
                .IsUnicode(false);

            modelBuilder.Entity<t_im_check_master>()
                .Property(e => e.sheet_amt)
                .HasPrecision(16, 4);

            modelBuilder.Entity<t_im_check_master>()
                .Property(e => e.branch_flag)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<t_im_check_master>()
                .Property(e => e.com_flag)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<t_im_check_master>()
                .Property(e => e.other1)
                .IsUnicode(false);

            modelBuilder.Entity<t_im_check_sum>()
                .Property(e => e.flow_id)
                .HasPrecision(18, 0);

            modelBuilder.Entity<t_im_check_sum>()
                .Property(e => e.sheet_no)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<t_im_check_sum>()
                .Property(e => e.branch_no)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<t_im_check_sum>()
                .Property(e => e.item_no)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<t_im_check_sum>()
                .Property(e => e.in_price)
                .HasPrecision(16, 4);

            modelBuilder.Entity<t_im_check_sum>()
                .Property(e => e.sale_price)
                .HasPrecision(16, 4);

            modelBuilder.Entity<t_im_check_sum>()
                .Property(e => e.stock_qty)
                .HasPrecision(16, 4);

            modelBuilder.Entity<t_im_check_sum>()
                .Property(e => e.check_qty)
                .HasPrecision(16, 4);

            modelBuilder.Entity<t_im_check_sum>()
                .Property(e => e.balance_qty)
                .HasPrecision(16, 4);

            modelBuilder.Entity<t_im_check_sum>()
                .Property(e => e.process_status)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<t_im_check_sum>()
                .Property(e => e.memo)
                .IsUnicode(false);

            modelBuilder.Entity<t_im_comb_split_detail>()
                .Property(e => e.sheet_no)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<t_im_comb_split_detail>()
                .Property(e => e.item_no)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<t_im_comb_split_detail>()
                .Property(e => e.qty)
                .HasPrecision(16, 4);

            modelBuilder.Entity<t_im_comb_split_detail>()
                .Property(e => e.price)
                .HasPrecision(16, 4);

            modelBuilder.Entity<t_im_comb_split_detail>()
                .Property(e => e.memo)
                .IsUnicode(false);

            modelBuilder.Entity<t_im_comb_split_master>()
                .Property(e => e.sheet_no)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<t_im_comb_split_master>()
                .Property(e => e.branch_no)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<t_im_comb_split_master>()
                .Property(e => e.item_no)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<t_im_comb_split_master>()
                .Property(e => e.qty)
                .HasPrecision(16, 4);

            modelBuilder.Entity<t_im_comb_split_master>()
                .Property(e => e.price)
                .HasPrecision(16, 4);

            modelBuilder.Entity<t_im_comb_split_master>()
                .Property(e => e.cs_flag)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<t_im_comb_split_master>()
                .Property(e => e.db_no)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<t_im_comb_split_master>()
                .Property(e => e.trans_no)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<t_im_comb_split_master>()
                .Property(e => e.approve_flag)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<t_im_comb_split_master>()
                .Property(e => e.confirm_man)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<t_im_comb_split_master>()
                .Property(e => e.oper_id)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<t_im_comb_split_master>()
                .Property(e => e.dept_id)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<t_im_comb_split_master>()
                .Property(e => e.memo)
                .IsUnicode(false);

            modelBuilder.Entity<t_im_comb_split_master>()
                .Property(e => e.sheet_amt)
                .HasPrecision(16, 4);

            modelBuilder.Entity<t_im_comb_split_master>()
                .Property(e => e.branch_flag)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<t_im_comb_split_master>()
                .Property(e => e.com_flag)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<t_im_cs_flow>()
                .Property(e => e.flow_id)
                .HasPrecision(18, 0);

            modelBuilder.Entity<t_im_cs_flow>()
                .Property(e => e.sheet_no)
                .IsUnicode(false);

            modelBuilder.Entity<t_im_cs_flow>()
                .Property(e => e.oper_date)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<t_im_cs_flow>()
                .Property(e => e.branch_no)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<t_im_cs_flow>()
                .Property(e => e.trans_type)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<t_im_cs_flow>()
                .Property(e => e.item_no)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<t_im_cs_flow>()
                .Property(e => e.sale_price)
                .HasPrecision(16, 4);

            modelBuilder.Entity<t_im_cs_flow>()
                .Property(e => e.qty)
                .HasPrecision(16, 4);

            modelBuilder.Entity<t_im_cs_flow>()
                .Property(e => e.cs_item_no)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<t_im_cs_flow>()
                .Property(e => e.cs_sale_price)
                .HasPrecision(16, 4);

            modelBuilder.Entity<t_im_cs_flow>()
                .Property(e => e.cs_cost_price)
                .HasPrecision(16, 4);

            modelBuilder.Entity<t_im_cs_flow>()
                .Property(e => e.cs_qty)
                .HasPrecision(16, 4);

            modelBuilder.Entity<t_im_cs_flow>()
                .Property(e => e.other1)
                .IsUnicode(false);

            modelBuilder.Entity<t_im_cs_flow>()
                .Property(e => e.other2)
                .IsUnicode(false);

            modelBuilder.Entity<t_im_cs_flow>()
                .Property(e => e.other3)
                .IsUnicode(false);

            modelBuilder.Entity<t_im_cs_flow>()
                .Property(e => e.num1)
                .HasPrecision(16, 4);

            modelBuilder.Entity<t_im_cs_flow>()
                .Property(e => e.num2)
                .HasPrecision(16, 4);

            modelBuilder.Entity<t_im_cs_flow>()
                .Property(e => e.num3)
                .HasPrecision(16, 4);

            modelBuilder.Entity<t_im_cs_flow>()
                .Property(e => e.com_flag)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<t_im_flow>()
                .Property(e => e.flow_id)
                .HasPrecision(14, 0);

            modelBuilder.Entity<t_im_flow>()
                .Property(e => e.voucher_no)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<t_im_flow>()
                .Property(e => e.item_no)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<t_im_flow>()
                .Property(e => e.real_qty)
                .HasPrecision(16, 4);

            modelBuilder.Entity<t_im_flow>()
                .Property(e => e.price)
                .HasPrecision(16, 4);

            modelBuilder.Entity<t_im_flow>()
                .Property(e => e.cost_price)
                .HasPrecision(16, 4);

            modelBuilder.Entity<t_im_flow>()
                .Property(e => e.sale_price)
                .HasPrecision(16, 4);

            modelBuilder.Entity<t_im_flow>()
                .Property(e => e.sheet_amt)
                .HasPrecision(16, 4);

            modelBuilder.Entity<t_im_flow>()
                .Property(e => e.branch_no)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<t_im_flow>()
                .Property(e => e.d_branch_no)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<t_im_flow>()
                .Property(e => e.trans_no)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<t_im_flow>()
                .Property(e => e.db_no)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<t_im_flow>()
                .Property(e => e.supcust_no)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<t_im_flow>()
                .Property(e => e.sale_way)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<t_im_flow>()
                .Property(e => e.oper_id)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<t_im_flow>()
                .Property(e => e.pre_qnty)
                .HasPrecision(16, 4);

            modelBuilder.Entity<t_im_flow>()
                .Property(e => e.memo)
                .IsUnicode(false);

            modelBuilder.Entity<t_im_flow>()
                .Property(e => e.com_flag)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<t_im_flow>()
                .Property(e => e.sup_ly_rate)
                .HasPrecision(16, 4);

            modelBuilder.Entity<t_im_flow>()
                .Property(e => e.pay_flag)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<t_im_flow>()
                .Property(e => e.sup_sale_way)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<t_im_flow>()
                .Property(e => e.sup_no)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<t_im_flow>()
                .Property(e => e.pos_id)
                .HasPrecision(3, 0);

            modelBuilder.Entity<t_im_flow>()
                .Property(e => e.dpfm_type)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<t_im_flow>()
                .Property(e => e.return_rate)
                .HasPrecision(16, 4);

            modelBuilder.Entity<t_im_flow>()
                .Property(e => e.cls_no)
                .IsUnicode(false);

            modelBuilder.Entity<t_im_flow>()
                .Property(e => e.cls_rate)
                .HasPrecision(16, 4);

            modelBuilder.Entity<t_im_flow>()
                .Property(e => e.pp_no)
                .IsUnicode(false);

            modelBuilder.Entity<t_im_flow>()
                .Property(e => e.pp_rate)
                .HasPrecision(16, 4);

            modelBuilder.Entity<t_im_flow>()
                .Property(e => e.order_man)
                .IsUnicode(false);

            modelBuilder.Entity<t_im_flow>()
                .Property(e => e.combine_sta)
                .IsUnicode(false);

            modelBuilder.Entity<t_im_flow>()
                .Property(e => e.sheet_item)
                .IsUnicode(false);

            modelBuilder.Entity<t_im_flow>()
                .Property(e => e.re_flag)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<t_im_flow>()
                .Property(e => e.sp_price)
                .HasPrecision(16, 4);

            modelBuilder.Entity<t_im_flow>()
                .Property(e => e.sp_no)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<t_im_flow_shd>()
                .Property(e => e.flow_id)
                .HasPrecision(14, 0);

            modelBuilder.Entity<t_im_flow_shd>()
                .Property(e => e.voucher_no)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<t_im_flow_shd>()
                .Property(e => e.item_no)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<t_im_flow_shd>()
                .Property(e => e.real_qty)
                .HasPrecision(16, 4);

            modelBuilder.Entity<t_im_flow_shd>()
                .Property(e => e.price)
                .HasPrecision(16, 4);

            modelBuilder.Entity<t_im_flow_shd>()
                .Property(e => e.cost_price)
                .HasPrecision(16, 4);

            modelBuilder.Entity<t_im_flow_shd>()
                .Property(e => e.sale_price)
                .HasPrecision(16, 4);

            modelBuilder.Entity<t_im_flow_shd>()
                .Property(e => e.branch_no)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<t_im_flow_shd>()
                .Property(e => e.d_branch_no)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<t_im_flow_shd>()
                .Property(e => e.trans_no)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<t_im_flow_shd>()
                .Property(e => e.db_no)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<t_im_flow_shd>()
                .Property(e => e.supcust_no)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<t_im_flow_shd>()
                .Property(e => e.sale_way)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<t_im_flow_shd>()
                .Property(e => e.oper_id)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<t_im_flow_shd>()
                .Property(e => e.pre_qnty)
                .HasPrecision(16, 4);

            modelBuilder.Entity<t_im_flow_shd>()
                .Property(e => e.memo)
                .IsUnicode(false);

            modelBuilder.Entity<t_im_flow_shd>()
                .Property(e => e.com_flag)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<t_im_flow_shd>()
                .Property(e => e.pay_flag)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<t_im_flow_shd>()
                .Property(e => e.sup_sale_way)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<t_im_flow_shd>()
                .Property(e => e.sup_no)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<t_im_flow_shd>()
                .Property(e => e.dpfm_type)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<t_im_flow_shd>()
                .Property(e => e.return_rate)
                .HasPrecision(16, 4);

            modelBuilder.Entity<t_im_flow_shd>()
                .Property(e => e.sale_flag)
                .IsUnicode(false);

            modelBuilder.Entity<t_im_flow_shd>()
                .Property(e => e.sheet_amt)
                .HasPrecision(16, 4);

            modelBuilder.Entity<t_im_flow_shd>()
                .Property(e => e.tp_flag)
                .IsUnicode(false);

            modelBuilder.Entity<t_im_pdjin>()
                .Property(e => e.sheet_no)
                .IsUnicode(false);

            modelBuilder.Entity<t_im_pdjin>()
                .Property(e => e.sup_no)
                .IsUnicode(false);

            modelBuilder.Entity<t_im_pdjin>()
                .Property(e => e.item_no)
                .IsUnicode(false);

            modelBuilder.Entity<t_im_pdjin>()
                .Property(e => e.item_name)
                .IsUnicode(false);

            modelBuilder.Entity<t_im_pdjin>()
                .Property(e => e.item_unit_no)
                .IsUnicode(false);

            modelBuilder.Entity<t_im_pdjin>()
                .Property(e => e.check_flag)
                .IsUnicode(false);

            modelBuilder.Entity<t_im_pdjin>()
                .Property(e => e.check_qty)
                .HasPrecision(8, 2);

            modelBuilder.Entity<t_im_pdjin>()
                .Property(e => e.ref_qty)
                .HasPrecision(8, 2);

            modelBuilder.Entity<t_im_pdjin>()
                .Property(e => e.sheet_flag)
                .IsUnicode(false);

            modelBuilder.Entity<t_im_pdjin>()
                .Property(e => e.item_inprice)
                .HasPrecision(8, 2);

            modelBuilder.Entity<t_im_pdjin>()
                .Property(e => e.item_saleprice)
                .HasPrecision(8, 2);

            modelBuilder.Entity<t_im_pdjin>()
                .Property(e => e.ref_sheetno)
                .IsUnicode(false);

            modelBuilder.Entity<t_im_pdjin>()
                .Property(e => e.flow_id)
                .HasPrecision(16, 0);

            modelBuilder.Entity<t_im_pdjin>()
                .Property(e => e.iPDANo)
                .IsUnicode(false);

            modelBuilder.Entity<t_im_pdjin>()
                .Property(e => e.memo)
                .IsUnicode(false);

            modelBuilder.Entity<t_im_pdjin>()
                .Property(e => e.branch_no)
                .IsUnicode(false);

            modelBuilder.Entity<t_im_pdjin>()
                .Property(e => e.item_subno)
                .IsUnicode(false);

            modelBuilder.Entity<t_im_sheet_detail>()
                .Property(e => e.flow_id)
                .HasPrecision(14, 0);

            modelBuilder.Entity<t_im_sheet_detail>()
                .Property(e => e.sheet_no)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<t_im_sheet_detail>()
                .Property(e => e.item_no)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<t_im_sheet_detail>()
                .Property(e => e.order_qty)
                .HasPrecision(16, 4);

            modelBuilder.Entity<t_im_sheet_detail>()
                .Property(e => e.real_qty)
                .HasPrecision(16, 4);

            modelBuilder.Entity<t_im_sheet_detail>()
                .Property(e => e.large_qty)
                .HasPrecision(16, 4);

            modelBuilder.Entity<t_im_sheet_detail>()
                .Property(e => e.orgi_price)
                .HasPrecision(16, 4);

            modelBuilder.Entity<t_im_sheet_detail>()
                .Property(e => e.valid_price)
                .HasPrecision(16, 4);

            modelBuilder.Entity<t_im_sheet_detail>()
                .Property(e => e.sub_amt)
                .HasPrecision(16, 4);

            modelBuilder.Entity<t_im_sheet_detail>()
                .Property(e => e.tax)
                .HasPrecision(5, 4);

            modelBuilder.Entity<t_im_sheet_detail>()
                .Property(e => e.sale_price)
                .HasPrecision(16, 4);

            modelBuilder.Entity<t_im_sheet_detail>()
                .Property(e => e.memo)
                .IsUnicode(false);

            modelBuilder.Entity<t_im_sheet_detail>()
                .Property(e => e.come_num)
                .HasPrecision(16, 4);

            modelBuilder.Entity<t_im_sheet_detail>()
                .Property(e => e.in_flag)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<t_im_sheet_master>()
                .Property(e => e.sheet_no)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<t_im_sheet_master>()
                .Property(e => e.trans_no)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<t_im_sheet_master>()
                .Property(e => e.db_no)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<t_im_sheet_master>()
                .Property(e => e.branch_no)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<t_im_sheet_master>()
                .Property(e => e.d_branch_no)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<t_im_sheet_master>()
                .Property(e => e.voucher_no)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<t_im_sheet_master>()
                .Property(e => e.supcust_no)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<t_im_sheet_master>()
                .Property(e => e.coin_no)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<t_im_sheet_master>()
                .Property(e => e.pay_way)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<t_im_sheet_master>()
                .Property(e => e.approve_flag)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<t_im_sheet_master>()
                .Property(e => e.order_man)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<t_im_sheet_master>()
                .Property(e => e.oper_id)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<t_im_sheet_master>()
                .Property(e => e.confirm_man)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<t_im_sheet_master>()
                .Property(e => e.trans_flag)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<t_im_sheet_master>()
                .Property(e => e.acct_flag)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<t_im_sheet_master>()
                .Property(e => e.sheet_amt)
                .HasPrecision(16, 4);

            modelBuilder.Entity<t_im_sheet_master>()
                .Property(e => e.branch_flag)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<t_im_sheet_master>()
                .Property(e => e.com_flag)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<t_im_sheet_master>()
                .Property(e => e.in_flag)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<t_im_sheet_master>()
                .Property(e => e.memo)
                .IsUnicode(false);

            modelBuilder.Entity<t_im_sheet_master>()
                .Property(e => e.other_appr_flag)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<t_im_sheet_master>()
                .Property(e => e.other_appr_man)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<t_im_sheet_master>()
                .Property(e => e.com_flag1)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<t_im_sheet_master>()
                .Property(e => e.order_status)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<t_im_sheet_master>()
                .Property(e => e.modified_id)
                .IsUnicode(false);

            modelBuilder.Entity<t_im_sheet_master>()
                .Property(e => e.md_flag)
                .IsUnicode(false);

            modelBuilder.Entity<t_im_stock_target>()
                .Property(e => e.branch_no)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<t_im_stock_target>()
                .Property(e => e.item_no)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<t_im_stock_target>()
                .Property(e => e.min_qty)
                .HasPrecision(16, 4);

            modelBuilder.Entity<t_im_stock_target>()
                .Property(e => e.max_qty)
                .HasPrecision(16, 4);

            modelBuilder.Entity<t_im_stock_target>()
                .Property(e => e.display_flag)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<t_ms_comm_used>()
                .Property(e => e.mess_title)
                .IsUnicode(false);

            modelBuilder.Entity<t_ms_comm_used>()
                .Property(e => e.mess_content)
                .IsUnicode(false);

            modelBuilder.Entity<t_ms_comm_used>()
                .Property(e => e.mess_type)
                .IsUnicode(false);

            modelBuilder.Entity<t_ms_cust_info>()
                .Property(e => e.group_no)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<t_ms_cust_info>()
                .Property(e => e.cust_no)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<t_ms_cust_info>()
                .Property(e => e.cust_name)
                .IsUnicode(false);

            modelBuilder.Entity<t_ms_cust_info>()
                .Property(e => e.mobile)
                .IsUnicode(false);

            modelBuilder.Entity<t_ms_cust_info>()
                .Property(e => e.sex)
                .IsUnicode(false);

            modelBuilder.Entity<t_ms_cust_info>()
                .Property(e => e.addr)
                .IsUnicode(false);

            modelBuilder.Entity<t_ms_cust_info>()
                .Property(e => e.zip)
                .IsUnicode(false);

            modelBuilder.Entity<t_ms_cust_info>()
                .Property(e => e.phone)
                .IsUnicode(false);

            modelBuilder.Entity<t_ms_cust_info>()
                .Property(e => e.e_mail)
                .IsUnicode(false);

            modelBuilder.Entity<t_ms_cust_info>()
                .Property(e => e.company)
                .IsUnicode(false);

            modelBuilder.Entity<t_ms_cust_info>()
                .Property(e => e.duty)
                .IsUnicode(false);

            modelBuilder.Entity<t_ms_cust_info>()
                .Property(e => e.region)
                .IsUnicode(false);

            modelBuilder.Entity<t_ms_cust_info>()
                .Property(e => e.id_card)
                .IsUnicode(false);

            modelBuilder.Entity<t_ms_cust_info>()
                .Property(e => e.cust_type)
                .IsUnicode(false);

            modelBuilder.Entity<t_ms_cust_info>()
                .Property(e => e.memo)
                .IsUnicode(false);

            modelBuilder.Entity<t_ms_group_info>()
                .Property(e => e.group_no)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<t_ms_group_info>()
                .Property(e => e.group_name)
                .IsUnicode(false);

            modelBuilder.Entity<t_ms_group_info>()
                .Property(e => e.type_flag)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<t_ms_group_info>()
                .Property(e => e.memo)
                .IsUnicode(false);

            modelBuilder.Entity<t_ms_mess_flow>()
                .Property(e => e.flow_id)
                .HasPrecision(18, 0);

            modelBuilder.Entity<t_ms_mess_flow>()
                .Property(e => e.cust_no)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<t_ms_mess_flow>()
                .Property(e => e.group_no)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<t_ms_mess_flow>()
                .Property(e => e.mobile)
                .IsUnicode(false);

            modelBuilder.Entity<t_ms_mess_flow>()
                .Property(e => e.oper_id)
                .IsUnicode(false);

            modelBuilder.Entity<t_ms_mess_flow>()
                .Property(e => e.mess)
                .IsUnicode(false);

            modelBuilder.Entity<t_ms_mess_flow>()
                .Property(e => e.region)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<t_ms_mess_flow>()
                .Property(e => e.mess_id)
                .HasPrecision(18, 0);

            modelBuilder.Entity<t_ms_mess_flow>()
                .Property(e => e.memo)
                .IsUnicode(false);

            modelBuilder.Entity<t_ms_mess_flow>()
                .Property(e => e.cust_name)
                .IsUnicode(false);

            modelBuilder.Entity<t_order_bill_weixin>()
                .Property(e => e.price)
                .HasPrecision(16, 4);

            modelBuilder.Entity<t_order_bill_weixin>()
                .Property(e => e.real_qty)
                .HasPrecision(16, 4);

            modelBuilder.Entity<t_order_bill_weixin>()
                .Property(e => e.IsDownload)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<t_order_bill_weixin>()
                .Property(e => e.branch_name)
                .IsUnicode(false);

            modelBuilder.Entity<t_order_bill_weixin>()
                .Property(e => e.item_name)
                .IsUnicode(false);

            modelBuilder.Entity<t_order_bill_weixin>()
                .Property(e => e.unit_name)
                .IsUnicode(false);

            modelBuilder.Entity<t_order_bill_weixin>()
                .Property(e => e.address)
                .IsUnicode(false);

            modelBuilder.Entity<t_order_bill_weixin>()
                .Property(e => e.type_name)
                .IsUnicode(false);

            modelBuilder.Entity<t_pc_branch_data>()
                .Property(e => e.flow_no)
                .HasPrecision(14, 0);

            modelBuilder.Entity<t_pc_branch_data>()
                .Property(e => e.sheet_no)
                .IsUnicode(false);

            modelBuilder.Entity<t_pc_branch_data>()
                .Property(e => e.branch_no)
                .IsUnicode(false);

            modelBuilder.Entity<t_pc_branch_price>()
                .Property(e => e.branch_no)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<t_pc_branch_price>()
                .Property(e => e.item_no)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<t_pc_branch_price>()
                .Property(e => e.price)
                .HasPrecision(16, 4);

            modelBuilder.Entity<t_pc_branch_price>()
                .Property(e => e.base_price)
                .HasPrecision(16, 4);

            modelBuilder.Entity<t_pc_branch_price>()
                .Property(e => e.sale_price)
                .HasPrecision(16, 4);

            modelBuilder.Entity<t_pc_branch_price>()
                .Property(e => e.vip_price)
                .HasPrecision(16, 4);

            modelBuilder.Entity<t_pc_branch_price>()
                .Property(e => e.com_flag)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<t_pc_branch_price>()
                .Property(e => e.scheme_price)
                .HasPrecision(16, 4);

            modelBuilder.Entity<t_pc_branch_price>()
                .Property(e => e.vip_price2)
                .HasPrecision(16, 4);

            modelBuilder.Entity<t_pc_branch_price>()
                .Property(e => e.vip_price3)
                .HasPrecision(16, 4);

            modelBuilder.Entity<t_pc_branch_price>()
                .Property(e => e.vip_price4)
                .HasPrecision(16, 4);

            modelBuilder.Entity<t_pc_branch_price>()
                .Property(e => e.vip_price5)
                .HasPrecision(16, 4);

            modelBuilder.Entity<t_pc_branch_price>()
                .Property(e => e.price_list)
                .IsUnicode(false);

            modelBuilder.Entity<t_pc_branch_price>()
                .Property(e => e.sale_flag)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<t_pc_branch_price>()
                .Property(e => e.base_price1)
                .HasPrecision(16, 4);

            modelBuilder.Entity<t_pc_branch_price>()
                .Property(e => e.base_price2)
                .HasPrecision(16, 4);

            modelBuilder.Entity<t_pc_branch_price>()
                .Property(e => e.base_price3)
                .HasPrecision(16, 4);

            modelBuilder.Entity<t_pc_branch_price>()
                .Property(e => e.base_price4)
                .HasPrecision(16, 4);

            modelBuilder.Entity<t_pc_branch_price>()
                .Property(e => e.base_price5)
                .HasPrecision(16, 4);

            modelBuilder.Entity<t_pc_branch_price>()
                .Property(e => e.base_price6)
                .HasPrecision(16, 4);

            modelBuilder.Entity<t_pc_branch_price>()
                .Property(e => e.base_price7)
                .HasPrecision(16, 4);

            modelBuilder.Entity<t_pc_branch_price>()
                .Property(e => e.base_price8)
                .HasPrecision(16, 4);

            modelBuilder.Entity<t_pc_branch_price_breakpoint>()
                .Property(e => e.com_no)
                .HasPrecision(18, 0);

            modelBuilder.Entity<t_pc_branch_price_breakpoint>()
                .Property(e => e.change_type)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<t_pc_branch_price_breakpoint>()
                .Property(e => e.branch_no)
                .IsUnicode(false);

            modelBuilder.Entity<t_pc_branch_price_breakpoint>()
                .Property(e => e.item_no)
                .IsUnicode(false);

            modelBuilder.Entity<t_pc_league_branch_price>()
                .Property(e => e.branch_no)
                .IsUnicode(false);

            modelBuilder.Entity<t_pc_league_branch_price>()
                .Property(e => e.use_way)
                .IsUnicode(false);

            modelBuilder.Entity<t_pc_league_branch_price>()
                .Property(e => e.use_no)
                .IsUnicode(false);

            modelBuilder.Entity<t_pc_league_branch_price>()
                .Property(e => e.use_name)
                .IsUnicode(false);

            modelBuilder.Entity<t_pc_league_branch_price>()
                .Property(e => e.supcust_no)
                .IsUnicode(false);

            modelBuilder.Entity<t_pc_league_branch_price>()
                .Property(e => e.app_price)
                .HasPrecision(18, 4);

            modelBuilder.Entity<t_pc_league_branch_price>()
                .Property(e => e.lower_price)
                .HasPrecision(18, 4);

            modelBuilder.Entity<t_pc_league_branch_price>()
                .Property(e => e.note)
                .IsUnicode(false);

            modelBuilder.Entity<t_pc_price_flow_detail>()
                .Property(e => e.flow_id)
                .HasPrecision(14, 0);

            modelBuilder.Entity<t_pc_price_flow_detail>()
                .Property(e => e.sheet_no)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<t_pc_price_flow_detail>()
                .Property(e => e.item_no)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<t_pc_price_flow_detail>()
                .Property(e => e.price_type)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<t_pc_price_flow_detail>()
                .Property(e => e.begin_time)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<t_pc_price_flow_detail>()
                .Property(e => e.end_time)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<t_pc_price_flow_detail>()
                .Property(e => e.week)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<t_pc_price_flow_detail>()
                .Property(e => e.old_price)
                .HasPrecision(16, 4);

            modelBuilder.Entity<t_pc_price_flow_detail>()
                .Property(e => e.new_price)
                .HasPrecision(16, 4);

            modelBuilder.Entity<t_pc_price_flow_detail>()
                .Property(e => e.discount)
                .HasPrecision(5, 4);

            modelBuilder.Entity<t_pc_price_flow_detail>()
                .Property(e => e.buy_qty)
                .HasPrecision(16, 4);

            modelBuilder.Entity<t_pc_price_flow_detail>()
                .Property(e => e.limited_qty)
                .HasPrecision(16, 4);

            modelBuilder.Entity<t_pc_price_flow_detail>()
                .Property(e => e.stock_qty)
                .HasPrecision(16, 4);

            modelBuilder.Entity<t_pc_price_flow_detail>()
                .Property(e => e.dec_rate)
                .HasPrecision(16, 4);

            modelBuilder.Entity<t_pc_price_flow_detail>()
                .Property(e => e.memo)
                .IsUnicode(false);

            modelBuilder.Entity<t_pc_price_flow_detail>()
                .Property(e => e.old_price2)
                .HasPrecision(16, 4);

            modelBuilder.Entity<t_pc_price_flow_detail>()
                .Property(e => e.new_price2)
                .HasPrecision(16, 4);

            modelBuilder.Entity<t_pc_price_flow_detail>()
                .Property(e => e.old_price3)
                .HasPrecision(16, 4);

            modelBuilder.Entity<t_pc_price_flow_detail>()
                .Property(e => e.new_price3)
                .HasPrecision(16, 4);

            modelBuilder.Entity<t_pc_price_flow_detail>()
                .Property(e => e.old_price4)
                .HasPrecision(16, 4);

            modelBuilder.Entity<t_pc_price_flow_detail>()
                .Property(e => e.new_price4)
                .HasPrecision(16, 4);

            modelBuilder.Entity<t_pc_price_flow_detail>()
                .Property(e => e.old_vip1)
                .HasPrecision(16, 4);

            modelBuilder.Entity<t_pc_price_flow_detail>()
                .Property(e => e.new_vip1)
                .HasPrecision(16, 4);

            modelBuilder.Entity<t_pc_price_flow_detail>()
                .Property(e => e.old_vip2)
                .HasPrecision(16, 4);

            modelBuilder.Entity<t_pc_price_flow_detail>()
                .Property(e => e.new_vip2)
                .HasPrecision(16, 4);

            modelBuilder.Entity<t_pc_price_flow_detail>()
                .Property(e => e.old_vip3)
                .HasPrecision(16, 4);

            modelBuilder.Entity<t_pc_price_flow_detail>()
                .Property(e => e.new_vip3)
                .HasPrecision(16, 4);

            modelBuilder.Entity<t_pc_price_flow_detail>()
                .Property(e => e.old_vip4)
                .HasPrecision(16, 4);

            modelBuilder.Entity<t_pc_price_flow_detail>()
                .Property(e => e.new_vip4)
                .HasPrecision(16, 4);

            modelBuilder.Entity<t_pc_price_flow_detail>()
                .Property(e => e.old_vip5)
                .HasPrecision(16, 4);

            modelBuilder.Entity<t_pc_price_flow_detail>()
                .Property(e => e.new_vip5)
                .HasPrecision(16, 4);

            modelBuilder.Entity<t_pc_price_flow_detail>()
                .Property(e => e.group_no)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<t_pc_price_flow_detail>()
                .Property(e => e.old_base1)
                .HasPrecision(16, 4);

            modelBuilder.Entity<t_pc_price_flow_detail>()
                .Property(e => e.new_base1)
                .HasPrecision(16, 4);

            modelBuilder.Entity<t_pc_price_flow_detail>()
                .Property(e => e.old_base2)
                .HasPrecision(16, 4);

            modelBuilder.Entity<t_pc_price_flow_detail>()
                .Property(e => e.new_base2)
                .HasPrecision(16, 4);

            modelBuilder.Entity<t_pc_price_flow_detail>()
                .Property(e => e.old_base3)
                .HasPrecision(16, 4);

            modelBuilder.Entity<t_pc_price_flow_detail>()
                .Property(e => e.new_base3)
                .HasPrecision(16, 4);

            modelBuilder.Entity<t_pc_price_flow_detail>()
                .Property(e => e.old_base4)
                .HasPrecision(16, 4);

            modelBuilder.Entity<t_pc_price_flow_detail>()
                .Property(e => e.new_base4)
                .HasPrecision(16, 4);

            modelBuilder.Entity<t_pc_price_flow_detail>()
                .Property(e => e.old_base5)
                .HasPrecision(16, 4);

            modelBuilder.Entity<t_pc_price_flow_detail>()
                .Property(e => e.new_base5)
                .HasPrecision(16, 4);

            modelBuilder.Entity<t_pc_price_flow_detail>()
                .Property(e => e.old_base6)
                .HasPrecision(16, 4);

            modelBuilder.Entity<t_pc_price_flow_detail>()
                .Property(e => e.new_base6)
                .HasPrecision(16, 4);

            modelBuilder.Entity<t_pc_price_flow_detail>()
                .Property(e => e.old_base7)
                .HasPrecision(16, 4);

            modelBuilder.Entity<t_pc_price_flow_detail>()
                .Property(e => e.new_base7)
                .HasPrecision(16, 4);

            modelBuilder.Entity<t_pc_price_flow_detail>()
                .Property(e => e.old_base8)
                .HasPrecision(16, 4);

            modelBuilder.Entity<t_pc_price_flow_detail>()
                .Property(e => e.new_base8)
                .HasPrecision(16, 4);

            modelBuilder.Entity<t_pc_price_flow_detail>()
                .Property(e => e.spec_status)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<t_pc_price_flow_detail>()
                .Property(e => e.modified_id)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<t_pc_price_flow_master>()
                .Property(e => e.sheet_no)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<t_pc_price_flow_master>()
                .Property(e => e.branch_no)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<t_pc_price_flow_master>()
                .Property(e => e.trans_no)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<t_pc_price_flow_master>()
                .Property(e => e.vip_type)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<t_pc_price_flow_master>()
                .Property(e => e.oper_id)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<t_pc_price_flow_master>()
                .Property(e => e.confirm_man)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<t_pc_price_flow_master>()
                .Property(e => e.valid_flag)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<t_pc_price_flow_master>()
                .Property(e => e.approve_flag)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<t_pc_price_flow_master>()
                .Property(e => e.supcust_no)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<t_pc_price_flow_master>()
                .Property(e => e.sheet_amt)
                .HasPrecision(16, 4);

            modelBuilder.Entity<t_pc_price_flow_master>()
                .Property(e => e.branch_flag)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<t_pc_price_flow_master>()
                .Property(e => e.week)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<t_pc_price_flow_master>()
                .Property(e => e.reach_val)
                .HasPrecision(16, 2);

            modelBuilder.Entity<t_pc_price_flow_master>()
                .Property(e => e.add_val)
                .HasPrecision(16, 2);

            modelBuilder.Entity<t_pc_price_flow_master>()
                .Property(e => e.branch_list)
                .IsUnicode(false);

            modelBuilder.Entity<t_pc_price_flow_master>()
                .Property(e => e.com_flag)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<t_pc_price_flow_master>()
                .Property(e => e.memo)
                .IsUnicode(false);

            modelBuilder.Entity<t_pc_price_flow_master>()
                .Property(e => e.reach_vip)
                .HasPrecision(16, 2);

            modelBuilder.Entity<t_pc_price_flow_master>()
                .Property(e => e.branch_list2)
                .IsUnicode(false);

            modelBuilder.Entity<t_pc_price_flow_master>()
                .Property(e => e.cls_flag)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<t_pc_price_flow_master>()
                .Property(e => e.cls_list)
                .IsUnicode(false);

            modelBuilder.Entity<t_pc_price_flow_master>()
                .Property(e => e.other1)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<t_pc_price_flow_master>()
                .Property(e => e.other2)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<t_pc_price_flow_master>()
                .Property(e => e.other3)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<t_pc_price_flow_master>()
                .Property(e => e.sheet_status)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<t_pc_price_flow_master>()
                .Property(e => e.modified_id)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<t_plan_detail_memo>()
                .Property(e => e.plan_id)
                .HasPrecision(14, 0);

            modelBuilder.Entity<t_plan_detail_memo>()
                .Property(e => e.plan_no)
                .IsUnicode(false);

            modelBuilder.Entity<t_plan_detail_memo>()
                .Property(e => e.plan_code)
                .IsUnicode(false);

            modelBuilder.Entity<t_plan_detail_memo>()
                .Property(e => e.plan_num_amt)
                .IsUnicode(false);

            modelBuilder.Entity<t_plan_detail_memo>()
                .Property(e => e.plan_discount_price)
                .HasPrecision(14, 4);

            modelBuilder.Entity<t_plan_detail_memo>()
                .Property(e => e.plan_sen_amt)
                .HasPrecision(14, 4);

            modelBuilder.Entity<t_pm_process_yh>()
                .Property(e => e.branch_no)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<t_pm_process_yh>()
                .Property(e => e.item_no)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<t_pm_process_yh>()
                .Property(e => e.yh_qty)
                .HasPrecision(16, 4);

            modelBuilder.Entity<t_pm_process_yh>()
                .Property(e => e.mo_qty)
                .HasPrecision(16, 4);

            modelBuilder.Entity<t_pm_process_yh>()
                .Property(e => e.reco_qty)
                .HasPrecision(16, 4);

            modelBuilder.Entity<t_pm_process_yh>()
                .Property(e => e.sup_no)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<t_pm_process_yh>()
                .Property(e => e.ord_qty)
                .HasPrecision(16, 4);

            modelBuilder.Entity<t_pm_process_yh>()
                .Property(e => e.memo)
                .IsUnicode(false);

            modelBuilder.Entity<t_pm_sheet_detail>()
                .Property(e => e.flow_id)
                .HasPrecision(14, 0);

            modelBuilder.Entity<t_pm_sheet_detail>()
                .Property(e => e.sheet_no)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<t_pm_sheet_detail>()
                .Property(e => e.item_no)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<t_pm_sheet_detail>()
                .Property(e => e.order_qty)
                .HasPrecision(16, 4);

            modelBuilder.Entity<t_pm_sheet_detail>()
                .Property(e => e.real_qty)
                .HasPrecision(16, 4);

            modelBuilder.Entity<t_pm_sheet_detail>()
                .Property(e => e.large_qty)
                .HasPrecision(16, 4);

            modelBuilder.Entity<t_pm_sheet_detail>()
                .Property(e => e.orgi_price)
                .HasPrecision(16, 4);

            modelBuilder.Entity<t_pm_sheet_detail>()
                .Property(e => e.valid_price)
                .HasPrecision(16, 4);

            modelBuilder.Entity<t_pm_sheet_detail>()
                .Property(e => e.sub_amt)
                .HasPrecision(16, 4);

            modelBuilder.Entity<t_pm_sheet_detail>()
                .Property(e => e.tax)
                .HasPrecision(5, 4);

            modelBuilder.Entity<t_pm_sheet_detail>()
                .Property(e => e.send_qty)
                .HasPrecision(16, 4);

            modelBuilder.Entity<t_pm_sheet_detail>()
                .Property(e => e.sale_price)
                .HasPrecision(16, 4);

            modelBuilder.Entity<t_pm_sheet_detail>()
                .Property(e => e.come_num)
                .HasPrecision(16, 4);

            modelBuilder.Entity<t_pm_sheet_detail>()
                .Property(e => e.memo)
                .IsUnicode(false);

            modelBuilder.Entity<t_pm_sheet_detail>()
                .Property(e => e.base_price)
                .HasPrecision(16, 4);

            modelBuilder.Entity<t_pm_sheet_detail>()
                .Property(e => e.dy_no)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<t_pm_sheet_master>()
                .Property(e => e.sheet_no)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<t_pm_sheet_master>()
                .Property(e => e.trans_no)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<t_pm_sheet_master>()
                .Property(e => e.db_no)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<t_pm_sheet_master>()
                .Property(e => e.branch_no)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<t_pm_sheet_master>()
                .Property(e => e.d_branch_no)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<t_pm_sheet_master>()
                .Property(e => e.voucher_no)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<t_pm_sheet_master>()
                .Property(e => e.supcust_no)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<t_pm_sheet_master>()
                .Property(e => e.coin_no)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<t_pm_sheet_master>()
                .Property(e => e.pay_way)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<t_pm_sheet_master>()
                .Property(e => e.approve_flag)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<t_pm_sheet_master>()
                .Property(e => e.order_amt)
                .HasPrecision(16, 4);

            modelBuilder.Entity<t_pm_sheet_master>()
                .Property(e => e.order_status)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<t_pm_sheet_master>()
                .Property(e => e.order_man)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<t_pm_sheet_master>()
                .Property(e => e.oper_id)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<t_pm_sheet_master>()
                .Property(e => e.confirm_man)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<t_pm_sheet_master>()
                .Property(e => e.trans_flag)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<t_pm_sheet_master>()
                .Property(e => e.acct_flag)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<t_pm_sheet_master>()
                .Property(e => e.sheet_amt)
                .HasPrecision(16, 4);

            modelBuilder.Entity<t_pm_sheet_master>()
                .Property(e => e.branch_flag)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<t_pm_sheet_master>()
                .Property(e => e.com_flag)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<t_pm_sheet_master>()
                .Property(e => e.in_flag)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<t_pm_sheet_master>()
                .Property(e => e.memo)
                .IsUnicode(false);

            modelBuilder.Entity<t_pm_sheet_master>()
                .Property(e => e.modified_id)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<t_pu_sheet_detail>()
                .Property(e => e.flow_id)
                .HasPrecision(14, 0);

            modelBuilder.Entity<t_pu_sheet_detail>()
                .Property(e => e.sheet_no)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<t_pu_sheet_detail>()
                .Property(e => e.item_no)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<t_pu_sheet_detail>()
                .Property(e => e.branch_no)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<t_pu_sheet_detail>()
                .Property(e => e.orgi_price)
                .HasPrecision(16, 4);

            modelBuilder.Entity<t_pu_sheet_detail>()
                .Property(e => e.valid_price)
                .HasPrecision(16, 4);

            modelBuilder.Entity<t_pu_sheet_detail>()
                .Property(e => e.order_qty)
                .HasPrecision(16, 4);

            modelBuilder.Entity<t_pu_sheet_detail>()
                .Property(e => e.real_qty)
                .HasPrecision(16, 4);

            modelBuilder.Entity<t_pu_sheet_detail>()
                .Property(e => e.large_qty)
                .HasPrecision(16, 4);

            modelBuilder.Entity<t_pu_sheet_detail>()
                .Property(e => e.sub_amt)
                .HasPrecision(16, 4);

            modelBuilder.Entity<t_pu_sheet_detail>()
                .Property(e => e.tax)
                .HasPrecision(5, 4);

            modelBuilder.Entity<t_pu_sheet_detail>()
                .Property(e => e.cost_price)
                .HasPrecision(16, 4);

            modelBuilder.Entity<t_pu_sheet_detail>()
                .Property(e => e.send_qty)
                .HasPrecision(16, 4);

            modelBuilder.Entity<t_pu_sheet_detail>()
                .Property(e => e.sale_price)
                .HasPrecision(16, 4);

            modelBuilder.Entity<t_pu_sheet_detail>()
                .Property(e => e.memo)
                .IsUnicode(false);

            modelBuilder.Entity<t_pu_sheet_master>()
                .Property(e => e.sheet_no)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<t_pu_sheet_master>()
                .Property(e => e.trans_no)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<t_pu_sheet_master>()
                .Property(e => e.db_no)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<t_pu_sheet_master>()
                .Property(e => e.voucher_no)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<t_pu_sheet_master>()
                .Property(e => e.branch_no)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<t_pu_sheet_master>()
                .Property(e => e.supcust_no)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<t_pu_sheet_master>()
                .Property(e => e.pay_way)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<t_pu_sheet_master>()
                .Property(e => e.discount)
                .HasPrecision(5, 4);

            modelBuilder.Entity<t_pu_sheet_master>()
                .Property(e => e.coin_no)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<t_pu_sheet_master>()
                .Property(e => e.paid_amt)
                .HasPrecision(16, 4);

            modelBuilder.Entity<t_pu_sheet_master>()
                .Property(e => e.order_status)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<t_pu_sheet_master>()
                .Property(e => e.approve_flag)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<t_pu_sheet_master>()
                .Property(e => e.oper_id)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<t_pu_sheet_master>()
                .Property(e => e.order_man)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<t_pu_sheet_master>()
                .Property(e => e.confirm_man)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<t_pu_sheet_master>()
                .Property(e => e.trans_flag)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<t_pu_sheet_master>()
                .Property(e => e.acct_flag)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<t_pu_sheet_master>()
                .Property(e => e.sheet_amt)
                .HasPrecision(16, 4);

            modelBuilder.Entity<t_pu_sheet_master>()
                .Property(e => e.branch_flag)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<t_pu_sheet_master>()
                .Property(e => e.com_flag)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<t_pu_sheet_master>()
                .Property(e => e.memo)
                .IsUnicode(false);

            modelBuilder.Entity<t_pu_sheet_master>()
                .Property(e => e.modified_id)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<t_pu_sheet_master>()
                .Property(e => e.end_flag)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<t_return_plan_master>()
                .Property(e => e.plan_no)
                .IsUnicode(false);

            modelBuilder.Entity<t_return_plan_master>()
                .Property(e => e.plan_name)
                .IsUnicode(false);

            modelBuilder.Entity<t_return_plan_master>()
                .Property(e => e.plan_memo)
                .IsUnicode(false);

            modelBuilder.Entity<t_return_plan_master>()
                .Property(e => e.oper_man)
                .IsUnicode(false);

            modelBuilder.Entity<t_return_plan_master>()
                .Property(e => e.confirm_man)
                .IsUnicode(false);

            modelBuilder.Entity<t_return_plan_master>()
                .Property(e => e.stop_man)
                .IsUnicode(false);

            modelBuilder.Entity<t_return_plan_master>()
                .Property(e => e.approve_flag)
                .IsUnicode(false);

            modelBuilder.Entity<t_return_plan_master>()
                .Property(e => e.royalty_setup)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<t_return_plan_master>()
                .Property(e => e.royalty_item)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<t_return_plan_master>()
                .Property(e => e.ret_ticket)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<t_return_plan_master>()
                .Property(e => e.ret_saving_card)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<t_return_rate_change>()
                .Property(e => e.item_no)
                .IsUnicode(false);

            modelBuilder.Entity<t_return_rate_change>()
                .Property(e => e.oper_id)
                .IsUnicode(false);

            modelBuilder.Entity<t_return_rate_change>()
                .Property(e => e.old_dpfm_type)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<t_return_rate_change>()
                .Property(e => e.old_return_rate)
                .HasPrecision(16, 4);

            modelBuilder.Entity<t_return_rate_change>()
                .Property(e => e.new_dpfm_type)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<t_return_rate_change>()
                .Property(e => e.new_return_rate)
                .HasPrecision(16, 4);

            modelBuilder.Entity<t_return_rate_change>()
                .Property(e => e.old_dpfm_type_orderman)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<t_return_rate_change>()
                .Property(e => e.old_return_rate_orderman)
                .HasPrecision(16, 4);

            modelBuilder.Entity<t_return_rate_change>()
                .Property(e => e.new_dpfm_type_orderman)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<t_return_rate_change>()
                .Property(e => e.new_return_rate_orderman)
                .HasPrecision(16, 4);

            modelBuilder.Entity<t_rm_balance>()
                .Property(e => e.flow)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<t_rm_balance>()
                .Property(e => e.partno)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<t_rm_balance>()
                .Property(e => e.id)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<t_rm_balance>()
                .Property(e => e.item_no)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<t_rm_balance>()
                .Property(e => e.weighing)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<t_rm_balance>()
                .Property(e => e.usedate)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<t_rm_balance>()
                .Property(e => e.bartype)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<t_rm_balance>()
                .Property(e => e.unit)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<t_rm_balance>()
                .Property(e => e.tare)
                .HasPrecision(14, 4);

            modelBuilder.Entity<t_rm_balance>()
                .Property(e => e.packtype)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<t_rm_balance>()
                .Property(e => e.packweight)
                .HasPrecision(14, 4);

            modelBuilder.Entity<t_rm_balance>()
                .Property(e => e.packerror)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<t_rm_balance>()
                .Property(e => e.account)
                .IsUnicode(false);

            modelBuilder.Entity<t_rm_balance>()
                .Property(e => e.other1)
                .IsUnicode(false);

            modelBuilder.Entity<t_rm_balance>()
                .Property(e => e.other2)
                .IsUnicode(false);

            modelBuilder.Entity<t_rm_balance>()
                .Property(e => e.other3)
                .IsUnicode(false);

            modelBuilder.Entity<t_rm_balance>()
                .Property(e => e.other4)
                .IsUnicode(false);

            modelBuilder.Entity<t_rm_balance>()
                .Property(e => e.other5)
                .IsUnicode(false);

            modelBuilder.Entity<t_rm_balance>()
                .Property(e => e.other6)
                .IsUnicode(false);

            modelBuilder.Entity<t_rm_balance>()
                .Property(e => e.other7)
                .IsUnicode(false);

            modelBuilder.Entity<t_rm_balance>()
                .Property(e => e.other8)
                .IsUnicode(false);

            modelBuilder.Entity<t_rm_balance_branch>()
                .Property(e => e.flow)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<t_rm_balance_branch>()
                .Property(e => e.branch_no)
                .IsUnicode(false);

            modelBuilder.Entity<t_rm_balance_branch>()
                .Property(e => e.partno)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<t_rm_balance_branch>()
                .Property(e => e.id)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<t_rm_balance_branch>()
                .Property(e => e.item_no)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<t_rm_balance_branch>()
                .Property(e => e.weighing)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<t_rm_balance_branch>()
                .Property(e => e.usedate)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<t_rm_balance_branch>()
                .Property(e => e.bartype)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<t_rm_balance_branch>()
                .Property(e => e.unit)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<t_rm_balance_branch>()
                .Property(e => e.tare)
                .HasPrecision(14, 4);

            modelBuilder.Entity<t_rm_balance_branch>()
                .Property(e => e.packtype)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<t_rm_balance_branch>()
                .Property(e => e.packweight)
                .HasPrecision(14, 4);

            modelBuilder.Entity<t_rm_balance_branch>()
                .Property(e => e.packerror)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<t_rm_balance_branch>()
                .Property(e => e.account)
                .IsUnicode(false);

            modelBuilder.Entity<t_rm_balance_branch>()
                .Property(e => e.other1)
                .IsUnicode(false);

            modelBuilder.Entity<t_rm_balance_branch>()
                .Property(e => e.other2)
                .IsUnicode(false);

            modelBuilder.Entity<t_rm_balance_branch>()
                .Property(e => e.other3)
                .IsUnicode(false);

            modelBuilder.Entity<t_rm_balance_branch>()
                .Property(e => e.other4)
                .IsUnicode(false);

            modelBuilder.Entity<t_rm_balance_branch>()
                .Property(e => e.other5)
                .IsUnicode(false);

            modelBuilder.Entity<t_rm_balance_branch>()
                .Property(e => e.other6)
                .IsUnicode(false);

            modelBuilder.Entity<t_rm_balance_branch>()
                .Property(e => e.other7)
                .IsUnicode(false);

            modelBuilder.Entity<t_rm_balance_branch>()
                .Property(e => e.other8)
                .IsUnicode(false);

            modelBuilder.Entity<t_rm_balance_item>()
                .Property(e => e.item_code)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<t_rm_balance_item>()
                .Property(e => e.item_name)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<t_rm_balance_item>()
                .Property(e => e.item_type)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<t_rm_balance_item>()
                .Property(e => e.default_value)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<t_rm_balance_item>()
                .Property(e => e.output_yesno)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<t_rm_balance_item>()
                .Property(e => e.output_radix_point)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<t_rm_balance_item>()
                .Property(e => e.split_char)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<t_rm_balance_item>()
                .Property(e => e.fill_char)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<t_rm_balance_item>()
                .Property(e => e.align_mode)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<t_rm_balance_item>()
                .Property(e => e.other1)
                .IsUnicode(false);

            modelBuilder.Entity<t_rm_balance_item>()
                .Property(e => e.other2)
                .IsUnicode(false);

            modelBuilder.Entity<t_rm_balance_item>()
                .Property(e => e.other3)
                .IsUnicode(false);

            modelBuilder.Entity<t_rm_barcode_output>()
                .Property(e => e.col_id)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<t_rm_barcode_output>()
                .Property(e => e.col_name)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<t_rm_casher_daysum_giv>()
                .Property(e => e.oper_date)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<t_rm_casher_daysum_giv>()
                .Property(e => e.oper_id)
                .IsUnicode(false);

            modelBuilder.Entity<t_rm_casher_daysum_giv>()
                .Property(e => e.branch_no)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<t_rm_casher_daysum_giv>()
                .Property(e => e.giv_amt)
                .HasPrecision(16, 4);

            modelBuilder.Entity<t_rm_casher_daysum_giv>()
                .Property(e => e.com_flag)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<t_rm_customer_analyse>()
                .Property(e => e.flow_no)
                .HasPrecision(8, 0);

            modelBuilder.Entity<t_rm_customer_analyse>()
                .Property(e => e.sheet_no)
                .IsUnicode(false);

            modelBuilder.Entity<t_rm_customer_analyse>()
                .Property(e => e.amount)
                .HasPrecision(16, 4);

            modelBuilder.Entity<t_rm_customer_analyse>()
                .Property(e => e.sex)
                .IsUnicode(false);

            modelBuilder.Entity<t_rm_customer_analyse>()
                .Property(e => e.age_leve)
                .IsUnicode(false);

            modelBuilder.Entity<t_rm_customer_analyse>()
                .Property(e => e.memo)
                .IsUnicode(false);

            modelBuilder.Entity<t_rm_daysum>()
                .Property(e => e.item_no)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<t_rm_daysum>()
                .Property(e => e.oper_date)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<t_rm_daysum>()
                .Property(e => e.branch_no)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<t_rm_daysum>()
                .Property(e => e.sale_qty)
                .HasPrecision(16, 4);

            modelBuilder.Entity<t_rm_daysum>()
                .Property(e => e.ret_qty)
                .HasPrecision(16, 4);

            modelBuilder.Entity<t_rm_daysum>()
                .Property(e => e.giv_qty)
                .HasPrecision(16, 4);

            modelBuilder.Entity<t_rm_daysum>()
                .Property(e => e.sale_amt)
                .HasPrecision(16, 4);

            modelBuilder.Entity<t_rm_daysum>()
                .Property(e => e.ret_amt)
                .HasPrecision(16, 4);

            modelBuilder.Entity<t_rm_daysum>()
                .Property(e => e.giv_amt)
                .HasPrecision(16, 4);

            modelBuilder.Entity<t_rm_daysum>()
                .Property(e => e.sale_price)
                .HasPrecision(16, 4);

            modelBuilder.Entity<t_rm_daysum>()
                .Property(e => e.pre_qty)
                .HasPrecision(16, 4);

            modelBuilder.Entity<t_rm_daysum>()
                .Property(e => e.pre_amt)
                .HasPrecision(16, 4);

            modelBuilder.Entity<t_rm_daysum>()
                .Property(e => e.dct_amount)
                .HasPrecision(16, 4);

            modelBuilder.Entity<t_rm_daysum>()
                .Property(e => e.cost_price)
                .HasPrecision(16, 4);

            modelBuilder.Entity<t_rm_daysum>()
                .Property(e => e.memo)
                .IsUnicode(false);

            modelBuilder.Entity<t_rm_daysum>()
                .Property(e => e.com_flag)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<t_rm_deduct_payway_except>()
                .Property(e => e.flow_id)
                .HasPrecision(9, 0);

            modelBuilder.Entity<t_rm_deduct_payway_except>()
                .Property(e => e.pay_way)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<t_rm_deduct_payway_except>()
                .Property(e => e.memo)
                .IsUnicode(false);

            modelBuilder.Entity<t_rm_flow_sum>()
                .Property(e => e.flow_no)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<t_rm_flow_sum>()
                .Property(e => e.sale_amount)
                .HasPrecision(16, 4);

            modelBuilder.Entity<t_rm_flow_sum>()
                .Property(e => e.branch_no)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<t_rm_flow_sum>()
                .Property(e => e.sell_way)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<t_rm_flow_sum>()
                .Property(e => e.card_id)
                .IsUnicode(false);

            modelBuilder.Entity<t_rm_flow_sum>()
                .Property(e => e.vip_no)
                .IsUnicode(false);

            modelBuilder.Entity<t_rm_flow_sum>()
                .Property(e => e.dis_amount)
                .HasPrecision(16, 4);

            modelBuilder.Entity<t_rm_flow_sum>()
                .Property(e => e.pay_amount)
                .HasPrecision(16, 4);

            modelBuilder.Entity<t_rm_flow_sum>()
                .Property(e => e.oper_id)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<t_rm_flow_sum>()
                .Property(e => e.sale_man)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<t_rm_flow_sum>()
                .Property(e => e.cashier_no)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<t_rm_flow_sum>()
                .Property(e => e.memo)
                .IsUnicode(false);

            modelBuilder.Entity<t_rm_flow_sum>()
                .Property(e => e.voucher_no)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<t_rm_flow_sum>()
                .Property(e => e.shift_no)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<t_rm_flow_sum>()
                .Property(e => e.com_flag)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<t_rm_function>()
                .Property(e => e.branch_no)
                .IsUnicode(false);

            modelBuilder.Entity<t_rm_function>()
                .Property(e => e.func_id)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<t_rm_function>()
                .Property(e => e.func_name)
                .IsUnicode(false);

            modelBuilder.Entity<t_rm_function>()
                .Property(e => e.func_udname)
                .IsUnicode(false);

            modelBuilder.Entity<t_rm_function>()
                .Property(e => e.pos_key)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<t_rm_function>()
                .Property(e => e.flag)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<t_rm_function>()
                .Property(e => e.type)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<t_rm_function>()
                .Property(e => e.memo)
                .IsUnicode(false);

            modelBuilder.Entity<t_rm_function>()
                .Property(e => e.other1)
                .IsUnicode(false);

            modelBuilder.Entity<t_rm_gift_certificate>()
                .Property(e => e.giftcert_no)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<t_rm_gift_certificate>()
                .Property(e => e.gift_type)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<t_rm_gift_certificate>()
                .Property(e => e.oper_id)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<t_rm_gift_certificate>()
                .Property(e => e.status)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<t_rm_gift_certificate>()
                .Property(e => e.send_branch)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<t_rm_gift_certificate>()
                .Property(e => e.flow_no)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<t_rm_gift_certificate>()
                .Property(e => e.pay_oper)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<t_rm_gift_certificate>()
                .Property(e => e.pay_branch)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<t_rm_gift_certificate>()
                .Property(e => e.memo)
                .IsUnicode(false);

            modelBuilder.Entity<t_rm_gift_certificate>()
                .Property(e => e.memo1)
                .IsUnicode(false);

            modelBuilder.Entity<t_rm_operator_log>()
                .Property(e => e.flow_no)
                .HasPrecision(18, 0);

            modelBuilder.Entity<t_rm_operator_log>()
                .Property(e => e.sheet_no)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<t_rm_operator_log>()
                .Property(e => e.item_no)
                .IsUnicode(false);

            modelBuilder.Entity<t_rm_operator_log>()
                .Property(e => e.cashier_no)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<t_rm_operator_log>()
                .Property(e => e.oper_type)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<t_rm_operator_log>()
                .Property(e => e.money)
                .HasPrecision(16, 4);

            modelBuilder.Entity<t_rm_operator_log>()
                .Property(e => e.shift)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<t_rm_operator_log>()
                .Property(e => e.vip_id)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<t_rm_operator_log>()
                .Property(e => e.card_no)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<t_rm_operator_log>()
                .Property(e => e.cash_no)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<t_rm_operator_log>()
                .Property(e => e.price)
                .HasPrecision(16, 4);

            modelBuilder.Entity<t_rm_operator_log>()
                .Property(e => e.process)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<t_rm_operator_log>()
                .Property(e => e.com_flag)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<t_rm_operator_log>()
                .Property(e => e.memo)
                .IsUnicode(false);

            modelBuilder.Entity<t_rm_operator_log>()
                .Property(e => e.award_grant)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<t_rm_order_saleflow>()
                .Property(e => e.com_no)
                .HasPrecision(16, 0);

            modelBuilder.Entity<t_rm_order_saleflow>()
                .Property(e => e.flow_id)
                .HasPrecision(3, 0);

            modelBuilder.Entity<t_rm_order_saleflow>()
                .Property(e => e.flow_no)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<t_rm_order_saleflow>()
                .Property(e => e.branch_no)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<t_rm_order_saleflow>()
                .Property(e => e.item_no)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<t_rm_order_saleflow>()
                .Property(e => e.source_price)
                .HasPrecision(16, 4);

            modelBuilder.Entity<t_rm_order_saleflow>()
                .Property(e => e.sale_price)
                .HasPrecision(16, 4);

            modelBuilder.Entity<t_rm_order_saleflow>()
                .Property(e => e.sale_qnty)
                .HasPrecision(16, 4);

            modelBuilder.Entity<t_rm_order_saleflow>()
                .Property(e => e.sale_money)
                .HasPrecision(16, 4);

            modelBuilder.Entity<t_rm_order_saleflow>()
                .Property(e => e.sell_way)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<t_rm_order_saleflow>()
                .Property(e => e.oper_id)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<t_rm_order_saleflow>()
                .Property(e => e.sale_man)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<t_rm_order_saleflow>()
                .Property(e => e.counter_no)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<t_rm_order_saleflow>()
                .Property(e => e.remote_flag)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<t_rm_order_saleflow>()
                .Property(e => e.shift_no)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<t_rm_order_saleflow>()
                .Property(e => e.com_flag)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<t_rm_order_saleflow>()
                .Property(e => e.spec_flag)
                .IsUnicode(false);

            modelBuilder.Entity<t_rm_order_saleflow>()
                .Property(e => e.pref_amt)
                .HasPrecision(16, 4);

            modelBuilder.Entity<t_rm_order_saleflow>()
                .Property(e => e.in_price)
                .HasPrecision(16, 4);

            modelBuilder.Entity<t_rm_order_saleflow>()
                .Property(e => e.n_stan)
                .HasPrecision(16, 4);

            modelBuilder.Entity<t_rm_order_saleflow>()
                .Property(e => e.chr_stan)
                .IsUnicode(false);

            modelBuilder.Entity<t_rm_order_saleflow>()
                .Property(e => e.cust_no)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<t_rm_order_saleflow>()
                .Property(e => e.cust_name)
                .IsUnicode(false);

            modelBuilder.Entity<t_rm_order_saleflow>()
                .Property(e => e.cust_addr)
                .IsUnicode(false);

            modelBuilder.Entity<t_rm_order_saleflow>()
                .Property(e => e.cust_tel)
                .IsUnicode(false);

            modelBuilder.Entity<t_rm_order_saleflow>()
                .Property(e => e.order_amt)
                .HasPrecision(10, 2);

            modelBuilder.Entity<t_rm_order_saleflow>()
                .Property(e => e.memo)
                .IsUnicode(false);

            modelBuilder.Entity<t_rm_order_saleflow>()
                .Property(e => e.other1)
                .IsUnicode(false);

            modelBuilder.Entity<t_rm_order_saleflow>()
                .Property(e => e.other2)
                .IsUnicode(false);

            modelBuilder.Entity<t_rm_payflow>()
                .Property(e => e.com_no)
                .HasPrecision(16, 0);

            modelBuilder.Entity<t_rm_payflow>()
                .Property(e => e.flow_id)
                .HasPrecision(3, 0);

            modelBuilder.Entity<t_rm_payflow>()
                .Property(e => e.flow_no)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<t_rm_payflow>()
                .Property(e => e.sale_amount)
                .HasPrecision(16, 4);

            modelBuilder.Entity<t_rm_payflow>()
                .Property(e => e.branch_no)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<t_rm_payflow>()
                .Property(e => e.pay_way)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<t_rm_payflow>()
                .Property(e => e.sell_way)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<t_rm_payflow>()
                .Property(e => e.card_no)
                .IsUnicode(false);

            modelBuilder.Entity<t_rm_payflow>()
                .Property(e => e.card_id)
                .IsUnicode(false);

            modelBuilder.Entity<t_rm_payflow>()
                .Property(e => e.vip_no)
                .IsUnicode(false);

            modelBuilder.Entity<t_rm_payflow>()
                .Property(e => e.coin_no)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<t_rm_payflow>()
                .Property(e => e.coin_rate)
                .HasPrecision(10, 4);

            modelBuilder.Entity<t_rm_payflow>()
                .Property(e => e.pay_amount)
                .HasPrecision(16, 4);

            modelBuilder.Entity<t_rm_payflow>()
                .Property(e => e.oper_id)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<t_rm_payflow>()
                .Property(e => e.counter_no)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<t_rm_payflow>()
                .Property(e => e.sale_man)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<t_rm_payflow>()
                .Property(e => e.cashier_no)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<t_rm_payflow>()
                .Property(e => e.memo)
                .IsUnicode(false);

            modelBuilder.Entity<t_rm_payflow>()
                .Property(e => e.voucher_no)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<t_rm_payflow>()
                .Property(e => e.shift_no)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<t_rm_payflow>()
                .Property(e => e.com_flag)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<t_rm_payflow>()
                .Property(e => e.remark)
                .IsUnicode(false);

            modelBuilder.Entity<t_rm_payflow>()
                .Property(e => e.rdm_no)
                .IsUnicode(false);

            modelBuilder.Entity<t_rm_payin_detail>()
                .Property(e => e.flow_id)
                .HasPrecision(14, 0);

            modelBuilder.Entity<t_rm_payin_detail>()
                .Property(e => e.sheet_no)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<t_rm_payin_detail>()
                .Property(e => e.pay_way)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<t_rm_payin_detail>()
                .Property(e => e.par_value)
                .HasPrecision(16, 4);

            modelBuilder.Entity<t_rm_payin_detail>()
                .Property(e => e.rate)
                .HasPrecision(16, 4);

            modelBuilder.Entity<t_rm_payin_detail>()
                .Property(e => e.memo)
                .IsUnicode(false);

            modelBuilder.Entity<t_rm_payin_detail>()
                .Property(e => e.casher_id)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<t_rm_payin_master>()
                .Property(e => e.sheet_no)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<t_rm_payin_master>()
                .Property(e => e.trans_no)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<t_rm_payin_master>()
                .Property(e => e.branch_no)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<t_rm_payin_master>()
                .Property(e => e.approve_flag)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<t_rm_payin_master>()
                .Property(e => e.sheet_amt)
                .HasPrecision(16, 4);

            modelBuilder.Entity<t_rm_payin_master>()
                .Property(e => e.oper_id)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<t_rm_payin_master>()
                .Property(e => e.casher_id)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<t_rm_payin_master>()
                .Property(e => e.cashier_name)
                .IsUnicode(false);

            modelBuilder.Entity<t_rm_payin_master>()
                .Property(e => e.confirm_man)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<t_rm_payin_master>()
                .Property(e => e.posid)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<t_rm_payin_master>()
                .Property(e => e.cheque)
                .HasPrecision(16, 4);

            modelBuilder.Entity<t_rm_payin_master>()
                .Property(e => e.ccard)
                .HasPrecision(16, 4);

            modelBuilder.Entity<t_rm_payin_master>()
                .Property(e => e.fcard)
                .HasPrecision(16, 4);

            modelBuilder.Entity<t_rm_payin_master>()
                .Property(e => e.gcert)
                .HasPrecision(16, 4);

            modelBuilder.Entity<t_rm_payin_master>()
                .Property(e => e.oncd)
                .HasPrecision(16, 4);

            modelBuilder.Entity<t_rm_payin_master>()
                .Property(e => e.opay)
                .HasPrecision(16, 4);

            modelBuilder.Entity<t_rm_payin_master>()
                .Property(e => e.other1)
                .IsUnicode(false);

            modelBuilder.Entity<t_rm_payin_master>()
                .Property(e => e.other2)
                .IsUnicode(false);

            modelBuilder.Entity<t_rm_payin_master>()
                .Property(e => e.other3)
                .IsUnicode(false);

            modelBuilder.Entity<t_rm_payin_master>()
                .Property(e => e.memo)
                .IsUnicode(false);

            modelBuilder.Entity<t_rm_payin_master>()
                .Property(e => e.num1)
                .HasPrecision(16, 4);

            modelBuilder.Entity<t_rm_payin_master>()
                .Property(e => e.num2)
                .HasPrecision(16, 4);

            modelBuilder.Entity<t_rm_payin_master>()
                .Property(e => e.branch_flag)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<t_rm_payin_master>()
                .Property(e => e.com_flag)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<t_rm_plan_branch>()
                .Property(e => e.plan_no)
                .IsUnicode(false);

            modelBuilder.Entity<t_rm_plan_branch>()
                .Property(e => e.branch_no)
                .IsUnicode(false);

            modelBuilder.Entity<t_rm_plan_detail>()
                .Property(e => e.plan_no)
                .IsUnicode(false);

            modelBuilder.Entity<t_rm_plan_detail>()
                .Property(e => e.row_id)
                .HasPrecision(18, 0);

            modelBuilder.Entity<t_rm_plan_detail>()
                .Property(e => e.rule_para)
                .IsUnicode(false);

            modelBuilder.Entity<t_rm_plan_detail>()
                .Property(e => e.rule_val)
                .IsUnicode(false);

            modelBuilder.Entity<t_rm_plan_flow>()
                .Property(e => e.plan_no)
                .IsUnicode(false);

            modelBuilder.Entity<t_rm_plan_flow>()
                .Property(e => e.plan_name)
                .IsUnicode(false);

            modelBuilder.Entity<t_rm_plan_flow>()
                .Property(e => e.plan_desc)
                .IsUnicode(false);

            modelBuilder.Entity<t_rm_plan_flow>()
                .Property(e => e.rule_no)
                .IsUnicode(false);

            modelBuilder.Entity<t_rm_plan_flow>()
                .Property(e => e.vip_type)
                .IsUnicode(false);

            modelBuilder.Entity<t_rm_plan_flow>()
                .Property(e => e.week)
                .IsUnicode(false);

            modelBuilder.Entity<t_rm_plan_flow>()
                .Property(e => e.begin_time)
                .IsUnicode(false);

            modelBuilder.Entity<t_rm_plan_flow>()
                .Property(e => e.end_time)
                .IsUnicode(false);

            modelBuilder.Entity<t_rm_plan_flow>()
                .Property(e => e.item_clsno)
                .IsUnicode(false);

            modelBuilder.Entity<t_rm_plan_flow>()
                .Property(e => e.item_brandno)
                .IsUnicode(false);

            modelBuilder.Entity<t_rm_plan_flow>()
                .Property(e => e.item_no)
                .IsUnicode(false);

            modelBuilder.Entity<t_rm_plan_flow>()
                .Property(e => e.branch_no)
                .IsUnicode(false);

            modelBuilder.Entity<t_rm_plan_flow>()
                .Property(e => e.amt)
                .HasPrecision(18, 4);

            modelBuilder.Entity<t_rm_plan_flow>()
                .Property(e => e.ex_amt)
                .HasPrecision(18, 4);

            modelBuilder.Entity<t_rm_plan_flow>()
                .Property(e => e.sale_price)
                .HasPrecision(18, 4);

            modelBuilder.Entity<t_rm_plan_flow>()
                .Property(e => e.price)
                .HasPrecision(18, 4);

            modelBuilder.Entity<t_rm_plan_flow>()
                .Property(e => e.limit)
                .HasPrecision(18, 4);

            modelBuilder.Entity<t_rm_plan_flow>()
                .Property(e => e.limit_vip)
                .HasPrecision(18, 4);

            modelBuilder.Entity<t_rm_plan_flow>()
                .Property(e => e.ex_amt1)
                .HasPrecision(16, 4);

            modelBuilder.Entity<t_rm_plan_master>()
                .Property(e => e.plan_no)
                .IsUnicode(false);

            modelBuilder.Entity<t_rm_plan_master>()
                .Property(e => e.plan_name)
                .IsUnicode(false);

            modelBuilder.Entity<t_rm_plan_master>()
                .Property(e => e.plan_memo)
                .IsUnicode(false);

            modelBuilder.Entity<t_rm_plan_master>()
                .Property(e => e.week)
                .IsUnicode(false);

            modelBuilder.Entity<t_rm_plan_master>()
                .Property(e => e.vip_type)
                .IsUnicode(false);

            modelBuilder.Entity<t_rm_plan_master>()
                .Property(e => e.oper_man)
                .IsUnicode(false);

            modelBuilder.Entity<t_rm_plan_master>()
                .Property(e => e.confirm_man)
                .IsUnicode(false);

            modelBuilder.Entity<t_rm_plan_master>()
                .Property(e => e.stop_man)
                .IsUnicode(false);

            modelBuilder.Entity<t_rm_plan_master>()
                .Property(e => e.approve_flag)
                .IsUnicode(false);

            modelBuilder.Entity<t_rm_plan_master>()
                .Property(e => e.rule_no)
                .IsUnicode(false);

            modelBuilder.Entity<t_rm_plan_master>()
                .Property(e => e.range_flag)
                .IsUnicode(false);

            modelBuilder.Entity<t_rm_plan_master>()
                .Property(e => e.oper_branch)
                .IsUnicode(false);

            modelBuilder.Entity<t_rm_plan_master>()
                .Property(e => e.multiple_flag)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<t_rm_plan_master>()
                .Property(e => e.amt)
                .HasPrecision(16, 4);

            modelBuilder.Entity<t_rm_plan_master>()
                .Property(e => e.ex_amt)
                .HasPrecision(16, 4);

            modelBuilder.Entity<t_rm_plan_master>()
                .Property(e => e.ex_amt1)
                .HasPrecision(16, 4);

            modelBuilder.Entity<t_rm_plan_rule>()
                .Property(e => e.rule_no)
                .IsUnicode(false);

            modelBuilder.Entity<t_rm_plan_rule>()
                .Property(e => e.range_flag)
                .IsUnicode(false);

            modelBuilder.Entity<t_rm_plan_rule>()
                .Property(e => e.rule_describe)
                .IsUnicode(false);

            modelBuilder.Entity<t_rm_plan_rule>()
                .Property(e => e.rule_condition)
                .IsUnicode(false);

            modelBuilder.Entity<t_rm_plan_rule>()
                .Property(e => e.rule_result)
                .IsUnicode(false);

            modelBuilder.Entity<t_rm_plan_rule>()
                .Property(e => e.plu_flag)
                .IsUnicode(false);

            modelBuilder.Entity<t_rm_pos_account>()
                .Property(e => e.flow_id)
                .HasPrecision(14, 0);

            modelBuilder.Entity<t_rm_pos_account>()
                .Property(e => e.branch_no)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<t_rm_pos_account>()
                .Property(e => e.pos_no)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<t_rm_pos_account>()
                .Property(e => e.cashier_id)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<t_rm_pos_account>()
                .Property(e => e.sale_amt)
                .HasPrecision(16, 4);

            modelBuilder.Entity<t_rm_pos_account>()
                .Property(e => e.hand_amt)
                .HasPrecision(16, 4);

            modelBuilder.Entity<t_rm_pos_account>()
                .Property(e => e.com_flag)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<t_rm_protion_flow>()
                .Property(e => e.com_no)
                .HasPrecision(16, 0);

            modelBuilder.Entity<t_rm_protion_flow>()
                .Property(e => e.flow_no)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<t_rm_protion_flow>()
                .Property(e => e.branch_no)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<t_rm_protion_flow>()
                .Property(e => e.item_no)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<t_rm_protion_flow>()
                .Property(e => e.sale_qty)
                .HasPrecision(16, 4);

            modelBuilder.Entity<t_rm_protion_flow>()
                .Property(e => e.source_price)
                .HasPrecision(16, 4);

            modelBuilder.Entity<t_rm_protion_flow>()
                .Property(e => e.sale_price)
                .HasPrecision(16, 4);

            modelBuilder.Entity<t_rm_protion_flow>()
                .Property(e => e.send_money)
                .HasPrecision(16, 4);

            modelBuilder.Entity<t_rm_protion_flow>()
                .Property(e => e.special_type)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<t_rm_protion_flow>()
                .Property(e => e.sheet_no)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<t_rm_protion_flow>()
                .Property(e => e.pro_des)
                .IsUnicode(false);

            modelBuilder.Entity<t_rm_protion_flow>()
                .Property(e => e.give_type)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<t_rm_protion_flow>()
                .Property(e => e.vip_flag)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<t_rm_protion_flow>()
                .Property(e => e.dec_rate)
                .HasPrecision(5, 2);

            modelBuilder.Entity<t_rm_protion_flow>()
                .Property(e => e.card_id)
                .IsUnicode(false);

            modelBuilder.Entity<t_rm_protion_flow>()
                .Property(e => e.card_no)
                .IsUnicode(false);

            modelBuilder.Entity<t_rm_protion_flow>()
                .Property(e => e.oper_id)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<t_rm_protion_flow>()
                .Property(e => e.com_flag)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<t_rm_protion_rule>()
                .Property(e => e.flow_no)
                .HasPrecision(16, 0);

            modelBuilder.Entity<t_rm_protion_rule>()
                .Property(e => e.branch_no)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<t_rm_protion_rule>()
                .Property(e => e.special_type)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<t_rm_protion_rule>()
                .Property(e => e.sheet_no)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<t_rm_protion_rule>()
                .Property(e => e.pro_des)
                .IsUnicode(false);

            modelBuilder.Entity<t_rm_protion_rule>()
                .Property(e => e.discount)
                .HasPrecision(16, 4);

            modelBuilder.Entity<t_rm_protion_rule>()
                .Property(e => e.limit_amt)
                .HasPrecision(16, 4);

            modelBuilder.Entity<t_rm_protion_rule>()
                .Property(e => e.limit_qty)
                .HasPrecision(16, 0);

            modelBuilder.Entity<t_rm_protion_rule>()
                .Property(e => e.give_type)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<t_rm_protion_rule>()
                .Property(e => e.dec_rate)
                .HasPrecision(5, 2);

            modelBuilder.Entity<t_rm_protion_rule>()
                .Property(e => e.oper_id)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<t_rm_protion_rule>()
                .Property(e => e.approve_flag)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<t_rm_protion_rule>()
                .Property(e => e.approve_id)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<t_rm_protion_rule>()
                .Property(e => e.modify_date)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<t_rm_protion_rule>()
                .Property(e => e.com_flag)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<t_rm_protion_rule>()
                .Property(e => e.item_clsno)
                .IsUnicode(false);

            modelBuilder.Entity<t_rm_protion_rule>()
                .Property(e => e.clspp_flag)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<t_rm_salecust_info>()
                .Property(e => e.flow_id)
                .HasPrecision(14, 0);

            modelBuilder.Entity<t_rm_salecust_info>()
                .Property(e => e.flow_no)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<t_rm_salecust_info>()
                .Property(e => e.branch_no)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<t_rm_salecust_info>()
                .Property(e => e.cust_name)
                .IsUnicode(false);

            modelBuilder.Entity<t_rm_salecust_info>()
                .Property(e => e.cust_man)
                .IsUnicode(false);

            modelBuilder.Entity<t_rm_salecust_info>()
                .Property(e => e.cust_addr)
                .IsUnicode(false);

            modelBuilder.Entity<t_rm_salecust_info>()
                .Property(e => e.cust_tel)
                .IsUnicode(false);

            modelBuilder.Entity<t_rm_salecust_info>()
                .Property(e => e.cust_other1)
                .IsUnicode(false);

            modelBuilder.Entity<t_rm_salecust_info>()
                .Property(e => e.cust_other2)
                .IsUnicode(false);

            modelBuilder.Entity<t_rm_salecust_info>()
                .Property(e => e.cust_other3)
                .IsUnicode(false);

            modelBuilder.Entity<t_rm_salecust_info>()
                .Property(e => e.item_no)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<t_rm_salecust_info>()
                .Property(e => e.sale_qty)
                .HasPrecision(16, 4);

            modelBuilder.Entity<t_rm_salecust_info>()
                .Property(e => e.sale_price)
                .HasPrecision(16, 4);

            modelBuilder.Entity<t_rm_salecust_info>()
                .Property(e => e.sale_way)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<t_rm_salecust_info>()
                .Property(e => e.pay_flag)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<t_rm_salecust_info>()
                .Property(e => e.pay_no)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<t_rm_salecust_info>()
                .Property(e => e.pay_amt)
                .HasPrecision(16, 4);

            modelBuilder.Entity<t_rm_salecust_info>()
                .Property(e => e.com_flag)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<t_rm_salecust_info_temp>()
                .Property(e => e.temp_cust_no)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<t_rm_salecust_info_temp>()
                .Property(e => e.cust_name)
                .IsUnicode(false);

            modelBuilder.Entity<t_rm_salecust_info_temp>()
                .Property(e => e.cust_man)
                .IsUnicode(false);

            modelBuilder.Entity<t_rm_salecust_info_temp>()
                .Property(e => e.cust_addr)
                .IsUnicode(false);

            modelBuilder.Entity<t_rm_salecust_info_temp>()
                .Property(e => e.cust_tel)
                .IsUnicode(false);

            modelBuilder.Entity<t_rm_salecust_info_temp>()
                .Property(e => e.cust_other1)
                .IsUnicode(false);

            modelBuilder.Entity<t_rm_salecust_info_temp>()
                .Property(e => e.cust_other2)
                .IsUnicode(false);

            modelBuilder.Entity<t_rm_salecust_info_temp>()
                .Property(e => e.cust_other3)
                .IsUnicode(false);

            modelBuilder.Entity<t_rm_salecust_send>()
                .Property(e => e.flow_no)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<t_rm_salecust_send>()
                .Property(e => e.branch_no)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<t_rm_salecust_send>()
                .Property(e => e.cust_name)
                .IsUnicode(false);

            modelBuilder.Entity<t_rm_salecust_send>()
                .Property(e => e.cust_man)
                .IsUnicode(false);

            modelBuilder.Entity<t_rm_salecust_send>()
                .Property(e => e.cust_addr)
                .IsUnicode(false);

            modelBuilder.Entity<t_rm_salecust_send>()
                .Property(e => e.cust_tel)
                .IsUnicode(false);

            modelBuilder.Entity<t_rm_salecust_send>()
                .Property(e => e.cust_other1)
                .IsUnicode(false);

            modelBuilder.Entity<t_rm_salecust_send>()
                .Property(e => e.cust_other2)
                .IsUnicode(false);

            modelBuilder.Entity<t_rm_salecust_send>()
                .Property(e => e.cust_other3)
                .IsUnicode(false);

            modelBuilder.Entity<t_rm_salecust_send>()
                .Property(e => e.take_change)
                .HasPrecision(16, 2);

            modelBuilder.Entity<t_rm_salecust_send>()
                .Property(e => e.send_oper)
                .IsUnicode(false);

            modelBuilder.Entity<t_rm_salecust_send>()
                .Property(e => e.sale_amt)
                .HasPrecision(16, 4);

            modelBuilder.Entity<t_rm_salecust_send>()
                .Property(e => e.pay_flag)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<t_rm_salecust_send>()
                .Property(e => e.oper_id)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<t_rm_saleflow>()
                .Property(e => e.com_no)
                .HasPrecision(16, 0);

            modelBuilder.Entity<t_rm_saleflow>()
                .Property(e => e.flow_id)
                .HasPrecision(3, 0);

            modelBuilder.Entity<t_rm_saleflow>()
                .Property(e => e.flow_no)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<t_rm_saleflow>()
                .Property(e => e.branch_no)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<t_rm_saleflow>()
                .Property(e => e.item_no)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<t_rm_saleflow>()
                .Property(e => e.source_price)
                .HasPrecision(16, 4);

            modelBuilder.Entity<t_rm_saleflow>()
                .Property(e => e.sale_price)
                .HasPrecision(16, 4);

            modelBuilder.Entity<t_rm_saleflow>()
                .Property(e => e.cost_price)
                .HasPrecision(16, 4);

            modelBuilder.Entity<t_rm_saleflow>()
                .Property(e => e.sale_qnty)
                .HasPrecision(16, 4);

            modelBuilder.Entity<t_rm_saleflow>()
                .Property(e => e.sale_money)
                .HasPrecision(16, 4);

            modelBuilder.Entity<t_rm_saleflow>()
                .Property(e => e.sell_way)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<t_rm_saleflow>()
                .Property(e => e.oper_id)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<t_rm_saleflow>()
                .Property(e => e.sale_man)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<t_rm_saleflow>()
                .Property(e => e.shift_no)
                .HasPrecision(16, 4);

            modelBuilder.Entity<t_rm_saleflow>()
                .Property(e => e.com_flag)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<t_rm_saleflow>()
                .Property(e => e.spec_flag)
                .IsUnicode(false);

            modelBuilder.Entity<t_rm_saleflow>()
                .Property(e => e.pref_amt)
                .HasPrecision(16, 4);

            modelBuilder.Entity<t_rm_saleflow>()
                .Property(e => e.in_price)
                .HasPrecision(16, 4);

            modelBuilder.Entity<t_rm_saleflow>()
                .Property(e => e.acc_num)
                .HasPrecision(16, 4);

            modelBuilder.Entity<t_rm_saleflow>()
                .Property(e => e.dec_rate)
                .HasPrecision(16, 4);

            modelBuilder.Entity<t_rm_saleflow>()
                .Property(e => e.card_id)
                .IsUnicode(false);

            modelBuilder.Entity<t_rm_saleflow>()
                .Property(e => e.card_no)
                .IsUnicode(false);

            modelBuilder.Entity<t_rm_saleflow>()
                .Property(e => e.clss_rate)
                .HasPrecision(16, 4);

            modelBuilder.Entity<t_rm_saleflow>()
                .Property(e => e.Brand_rate)
                .HasPrecision(16, 4);

            modelBuilder.Entity<t_rm_saleflow>()
                .Property(e => e.sale_rate)
                .HasPrecision(16, 4);

            modelBuilder.Entity<t_rm_saleflow>()
                .Property(e => e.sale_duty_rate)
                .HasPrecision(16, 4);

            modelBuilder.Entity<t_rm_saleflow>()
                .Property(e => e.plan_no)
                .IsUnicode(false);

            modelBuilder.Entity<t_rm_saleflow>()
                .Property(e => e.serials_no)
                .IsUnicode(false);

            modelBuilder.Entity<t_rm_saleflow>()
                .Property(e => e.gift_msg)
                .IsUnicode(false);

            modelBuilder.Entity<t_rm_saleflow>()
                .Property(e => e.visit_flag)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<t_rm_saleflow>()
                .Property(e => e.jc_flag)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<t_rm_saleflow>()
                .Property(e => e.jc_qty)
                .HasPrecision(16, 4);

            modelBuilder.Entity<t_rm_saleflow>()
                .Property(e => e.memo)
                .IsUnicode(false);

            modelBuilder.Entity<t_rm_saleflow>()
                .Property(e => e.ret_qty)
                .HasPrecision(16, 4);

            modelBuilder.Entity<t_rm_saleflow_jc>()
                .Property(e => e.com_no)
                .HasPrecision(16, 0);

            modelBuilder.Entity<t_rm_saleflow_jc>()
                .Property(e => e.flow_id)
                .HasPrecision(3, 0);

            modelBuilder.Entity<t_rm_saleflow_jc>()
                .Property(e => e.flow_no)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<t_rm_saleflow_jc>()
                .Property(e => e.branch_no)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<t_rm_saleflow_jc>()
                .Property(e => e.item_no)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<t_rm_saleflow_jc>()
                .Property(e => e.source_price)
                .HasPrecision(16, 4);

            modelBuilder.Entity<t_rm_saleflow_jc>()
                .Property(e => e.sale_price)
                .HasPrecision(16, 4);

            modelBuilder.Entity<t_rm_saleflow_jc>()
                .Property(e => e.cost_price)
                .HasPrecision(16, 4);

            modelBuilder.Entity<t_rm_saleflow_jc>()
                .Property(e => e.sale_qnty)
                .HasPrecision(16, 4);

            modelBuilder.Entity<t_rm_saleflow_jc>()
                .Property(e => e.sale_money)
                .HasPrecision(16, 4);

            modelBuilder.Entity<t_rm_saleflow_jc>()
                .Property(e => e.sell_way)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<t_rm_saleflow_jc>()
                .Property(e => e.oper_id)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<t_rm_saleflow_jc>()
                .Property(e => e.sale_man)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<t_rm_saleflow_jc>()
                .Property(e => e.shift_no)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<t_rm_saleflow_jc>()
                .Property(e => e.com_flag)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<t_rm_saleflow_jc>()
                .Property(e => e.spec_flag)
                .IsUnicode(false);

            modelBuilder.Entity<t_rm_saleflow_jc>()
                .Property(e => e.pref_amt)
                .HasPrecision(16, 4);

            modelBuilder.Entity<t_rm_saleflow_jc>()
                .Property(e => e.in_price)
                .HasPrecision(16, 4);

            modelBuilder.Entity<t_rm_saleflow_jc>()
                .Property(e => e.acc_num)
                .HasPrecision(16, 4);

            modelBuilder.Entity<t_rm_saleflow_jc>()
                .Property(e => e.dec_rate)
                .HasPrecision(16, 4);

            modelBuilder.Entity<t_rm_saleflow_jc>()
                .Property(e => e.card_id)
                .IsUnicode(false);

            modelBuilder.Entity<t_rm_saleflow_jc>()
                .Property(e => e.card_no)
                .IsUnicode(false);

            modelBuilder.Entity<t_rm_saleflow_jc>()
                .Property(e => e.jc_flag)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<t_rm_saleflow_jc>()
                .Property(e => e.jc_qty)
                .HasPrecision(16, 4);

            modelBuilder.Entity<t_rm_saleflow_jc>()
                .Property(e => e.ret_qty)
                .HasPrecision(16, 4);

            modelBuilder.Entity<t_rm_saleflow_jc_master>()
                .Property(e => e.com_no)
                .HasPrecision(16, 0);

            modelBuilder.Entity<t_rm_saleflow_jc_master>()
                .Property(e => e.flow_id)
                .HasPrecision(3, 0);

            modelBuilder.Entity<t_rm_saleflow_jc_master>()
                .Property(e => e.flow_no)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<t_rm_saleflow_jc_master>()
                .Property(e => e.branch_no)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<t_rm_saleflow_jc_master>()
                .Property(e => e.item_no)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<t_rm_saleflow_jc_master>()
                .Property(e => e.source_price)
                .HasPrecision(16, 4);

            modelBuilder.Entity<t_rm_saleflow_jc_master>()
                .Property(e => e.sale_price)
                .HasPrecision(16, 4);

            modelBuilder.Entity<t_rm_saleflow_jc_master>()
                .Property(e => e.in_price)
                .HasPrecision(16, 4);

            modelBuilder.Entity<t_rm_saleflow_jc_master>()
                .Property(e => e.jc_qnty)
                .HasPrecision(16, 4);

            modelBuilder.Entity<t_rm_saleflow_jc_master>()
                .Property(e => e.take_qnty)
                .HasPrecision(16, 4);

            modelBuilder.Entity<t_rm_saleflow_jc_master>()
                .Property(e => e.sale_money)
                .HasPrecision(16, 4);

            modelBuilder.Entity<t_rm_saleflow_jc_master>()
                .Property(e => e.oper_id)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<t_rm_saleflow_jc_master>()
                .Property(e => e.sale_man)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<t_rm_saleflow_jc_master>()
                .Property(e => e.dec_rate)
                .HasPrecision(16, 4);

            modelBuilder.Entity<t_rm_saleflow_jc_master>()
                .Property(e => e.card_id)
                .IsUnicode(false);

            modelBuilder.Entity<t_rm_saleflow_jc_master>()
                .Property(e => e.card_no)
                .IsUnicode(false);

            modelBuilder.Entity<t_rm_saleflow_jc_master>()
                .Property(e => e.ret_qty)
                .HasPrecision(16, 4);

            modelBuilder.Entity<t_rm_saleflow_jc_master>()
                .Property(e => e.memo)
                .IsUnicode(false);

            modelBuilder.Entity<t_rm_saleflow_order>()
                .Property(e => e.flow_no)
                .IsUnicode(false);

            modelBuilder.Entity<t_rm_saleflow_order>()
                .Property(e => e.branch_no)
                .IsUnicode(false);

            modelBuilder.Entity<t_rm_saleflow_order>()
                .Property(e => e.item_no)
                .IsUnicode(false);

            modelBuilder.Entity<t_rm_saleflow_order>()
                .Property(e => e.sale_qnty)
                .HasPrecision(15, 2);

            modelBuilder.Entity<t_rm_saleflow_order>()
                .Property(e => e.source_price)
                .HasPrecision(15, 2);

            modelBuilder.Entity<t_rm_saleflow_order>()
                .Property(e => e.sale_price)
                .HasPrecision(15, 2);

            modelBuilder.Entity<t_rm_saleflow_order>()
                .Property(e => e.sale_money)
                .HasPrecision(15, 2);

            modelBuilder.Entity<t_rm_saleflow_order>()
                .Property(e => e.sell_way)
                .IsUnicode(false);

            modelBuilder.Entity<t_rm_saleflow_order>()
                .Property(e => e.oper_id)
                .IsUnicode(false);

            modelBuilder.Entity<t_rm_saleflow_order>()
                .Property(e => e.card_id)
                .IsUnicode(false);

            modelBuilder.Entity<t_rm_saleflow_order>()
                .Property(e => e.card_no)
                .IsUnicode(false);

            modelBuilder.Entity<t_rm_saleflow_vip_source>()
                .Property(e => e.com_no)
                .HasPrecision(16, 0);

            modelBuilder.Entity<t_rm_saleflow_vip_source>()
                .Property(e => e.card_id)
                .IsUnicode(false);

            modelBuilder.Entity<t_rm_saleflow_vip_source>()
                .Property(e => e.flow_no)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<t_rm_saleflow_vip_source>()
                .Property(e => e.flow_id)
                .HasPrecision(3, 0);

            modelBuilder.Entity<t_rm_saleflow_vip_source>()
                .Property(e => e.item_no)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<t_rm_saleflow_vip_source>()
                .Property(e => e.item_name)
                .IsUnicode(false);

            modelBuilder.Entity<t_rm_saleflow_vip_source>()
                .Property(e => e.item_clsno)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<t_rm_saleflow_vip_source>()
                .Property(e => e.item_clsname)
                .IsUnicode(false);

            modelBuilder.Entity<t_rm_saleflow_vip_source>()
                .Property(e => e.item_brand)
                .IsUnicode(false);

            modelBuilder.Entity<t_rm_saleflow_vip_source>()
                .Property(e => e.item_brand_name)
                .IsUnicode(false);

            modelBuilder.Entity<t_rm_saleflow_vip_source>()
                .Property(e => e.branch_no)
                .IsUnicode(false);

            modelBuilder.Entity<t_rm_saleflow_vip_source>()
                .Property(e => e.branch_name)
                .IsUnicode(false);

            modelBuilder.Entity<t_rm_saleflow_vip_source>()
                .Property(e => e.sell_way)
                .IsUnicode(false);

            modelBuilder.Entity<t_rm_saleflow_vip_source>()
                .Property(e => e.source_price)
                .HasPrecision(16, 4);

            modelBuilder.Entity<t_rm_saleflow_vip_source>()
                .Property(e => e.sale_price)
                .HasPrecision(16, 4);

            modelBuilder.Entity<t_rm_saleflow_vip_source>()
                .Property(e => e.sale_qnty)
                .HasPrecision(16, 4);

            modelBuilder.Entity<t_rm_saleflow_vip_source>()
                .Property(e => e.sale_money)
                .HasPrecision(16, 4);

            modelBuilder.Entity<t_rm_saleman>()
                .Property(e => e.branch_no)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<t_rm_saleman>()
                .Property(e => e.sale_id)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<t_rm_saleman>()
                .Property(e => e.sale_name)
                .IsUnicode(false);

            modelBuilder.Entity<t_rm_saleman>()
                .Property(e => e.sale_status)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<t_rm_saleman>()
                .Property(e => e.memo)
                .IsUnicode(false);

            modelBuilder.Entity<t_rm_saleman>()
                .Property(e => e.return_rate)
                .HasPrecision(5, 4);

            modelBuilder.Entity<t_rm_saleman>()
                .Property(e => e.sale_duty)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<t_rm_saleman>()
                .Property(e => e.sale_duty_rate)
                .HasPrecision(5, 4);

            modelBuilder.Entity<t_rm_saleman_breakpoint>()
                .Property(e => e.com_no)
                .HasPrecision(18, 0);

            modelBuilder.Entity<t_rm_saleman_breakpoint>()
                .Property(e => e.change_type)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<t_rm_saleman_breakpoint>()
                .Property(e => e.branch_no)
                .IsUnicode(false);

            modelBuilder.Entity<t_rm_saleman_breakpoint>()
                .Property(e => e.sale_id)
                .IsUnicode(false);

            modelBuilder.Entity<t_rm_saleman_detail>()
                .Property(e => e.sale_id)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<t_rm_saleman_detail>()
                .Property(e => e.nibs_id)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<t_rm_saleman_detail>()
                .Property(e => e.memo)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<t_rm_salespe_info>()
                .Property(e => e.flow_id)
                .HasPrecision(14, 0);

            modelBuilder.Entity<t_rm_salespe_info>()
                .Property(e => e.flow_no)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<t_rm_salespe_info>()
                .Property(e => e.branch_no)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<t_rm_salespe_info>()
                .Property(e => e.pay_way)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<t_rm_salespe_info>()
                .Property(e => e.cust_name)
                .IsUnicode(false);

            modelBuilder.Entity<t_rm_salespe_info>()
                .Property(e => e.cust_man)
                .IsUnicode(false);

            modelBuilder.Entity<t_rm_salespe_info>()
                .Property(e => e.cust_addr)
                .IsUnicode(false);

            modelBuilder.Entity<t_rm_salespe_info>()
                .Property(e => e.cust_tel)
                .IsUnicode(false);

            modelBuilder.Entity<t_rm_salespe_info>()
                .Property(e => e.cust_other1)
                .IsUnicode(false);

            modelBuilder.Entity<t_rm_salespe_info>()
                .Property(e => e.cust_other2)
                .IsUnicode(false);

            modelBuilder.Entity<t_rm_salespe_info>()
                .Property(e => e.oper_id)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<t_rm_salespe_info>()
                .Property(e => e.sale_amt)
                .HasPrecision(16, 4);

            modelBuilder.Entity<t_rm_salespe_info>()
                .Property(e => e.pay_flag)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<t_rm_salespe_info>()
                .Property(e => e.pay_no)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<t_rm_salespe_info>()
                .Property(e => e.pay_amt)
                .HasPrecision(16, 4);

            modelBuilder.Entity<t_rm_salespe_info>()
                .Property(e => e.pay_oper)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<t_rm_salespe_info>()
                .Property(e => e.com_flag)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<t_rm_salespe_info>()
                .Property(e => e.temp_cust_no)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<t_rm_salespe_info>()
                .Property(e => e.payed_amt)
                .HasPrecision(16, 4);

            modelBuilder.Entity<t_rm_saving_month>()
                .Property(e => e.oper_date)
                .IsUnicode(false);

            modelBuilder.Entity<t_rm_saving_month>()
                .Property(e => e.branch_no)
                .IsUnicode(false);

            modelBuilder.Entity<t_rm_saving_month>()
                .Property(e => e.sav_amt)
                .HasPrecision(16, 4);

            modelBuilder.Entity<t_rm_saving_month>()
                .Property(e => e.pay_amt)
                .HasPrecision(16, 4);

            modelBuilder.Entity<t_rm_spec_price>()
                .Property(e => e.flow_no)
                .HasPrecision(16, 0);

            modelBuilder.Entity<t_rm_spec_price>()
                .Property(e => e.item_no)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<t_rm_spec_price>()
                .Property(e => e.branch_no)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<t_rm_spec_price>()
                .Property(e => e.special_type)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<t_rm_spec_price>()
                .Property(e => e.vip_type)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<t_rm_spec_price>()
                .Property(e => e.sheet_no)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<t_rm_spec_price>()
                .Property(e => e.pro_des)
                .IsUnicode(false);

            modelBuilder.Entity<t_rm_spec_price>()
                .Property(e => e.sort_no)
                .IsUnicode(false);

            modelBuilder.Entity<t_rm_spec_price>()
                .Property(e => e.old_price)
                .HasPrecision(16, 4);

            modelBuilder.Entity<t_rm_spec_price>()
                .Property(e => e.spe_price)
                .HasPrecision(16, 4);

            modelBuilder.Entity<t_rm_spec_price>()
                .Property(e => e.discount)
                .HasPrecision(16, 4);

            modelBuilder.Entity<t_rm_spec_price>()
                .Property(e => e.sale_qty)
                .HasPrecision(16, 4);

            modelBuilder.Entity<t_rm_spec_price>()
                .Property(e => e.limited_qty)
                .HasPrecision(16, 4);

            modelBuilder.Entity<t_rm_spec_price>()
                .Property(e => e.sold_qty)
                .HasPrecision(16, 4);

            modelBuilder.Entity<t_rm_spec_price>()
                .Property(e => e.begin_time)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<t_rm_spec_price>()
                .Property(e => e.end_time)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<t_rm_spec_price>()
                .Property(e => e.week)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<t_rm_spec_price>()
                .Property(e => e.dec_rate)
                .HasPrecision(5, 2);

            modelBuilder.Entity<t_rm_spec_price>()
                .Property(e => e.reach_val)
                .HasPrecision(16, 2);

            modelBuilder.Entity<t_rm_spec_price>()
                .Property(e => e.add_val)
                .HasPrecision(16, 2);

            modelBuilder.Entity<t_rm_spec_price>()
                .Property(e => e.gift_item)
                .IsUnicode(false);

            modelBuilder.Entity<t_rm_spec_price>()
                .Property(e => e.gift_qty)
                .IsUnicode(false);

            modelBuilder.Entity<t_rm_spec_price>()
                .Property(e => e.com_flag)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<t_rm_spec_price>()
                .Property(e => e.gift_price)
                .IsUnicode(false);

            modelBuilder.Entity<t_rm_spec_price>()
                .Property(e => e.reach_vip)
                .HasPrecision(16, 2);

            modelBuilder.Entity<t_rm_spec_price>()
                .Property(e => e.cls_flag)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<t_rm_spec_price>()
                .Property(e => e.cls_list)
                .IsUnicode(false);

            modelBuilder.Entity<t_rm_spec_price>()
                .Property(e => e.other1)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<t_rm_spec_price_history>()
                .Property(e => e.flow_no)
                .HasPrecision(16, 0);

            modelBuilder.Entity<t_rm_spec_price_history>()
                .Property(e => e.item_no)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<t_rm_spec_price_history>()
                .Property(e => e.branch_no)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<t_rm_spec_price_history>()
                .Property(e => e.special_type)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<t_rm_spec_price_history>()
                .Property(e => e.vip_type)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<t_rm_spec_price_history>()
                .Property(e => e.sheet_no)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<t_rm_spec_price_history>()
                .Property(e => e.pro_des)
                .IsUnicode(false);

            modelBuilder.Entity<t_rm_spec_price_history>()
                .Property(e => e.sort_no)
                .IsUnicode(false);

            modelBuilder.Entity<t_rm_spec_price_history>()
                .Property(e => e.old_price)
                .HasPrecision(16, 4);

            modelBuilder.Entity<t_rm_spec_price_history>()
                .Property(e => e.spe_price)
                .HasPrecision(16, 4);

            modelBuilder.Entity<t_rm_spec_price_history>()
                .Property(e => e.discount)
                .HasPrecision(16, 4);

            modelBuilder.Entity<t_rm_spec_price_history>()
                .Property(e => e.sale_qty)
                .HasPrecision(16, 4);

            modelBuilder.Entity<t_rm_spec_price_history>()
                .Property(e => e.limited_qty)
                .HasPrecision(16, 4);

            modelBuilder.Entity<t_rm_spec_price_history>()
                .Property(e => e.sold_qty)
                .HasPrecision(16, 4);

            modelBuilder.Entity<t_rm_spec_price_history>()
                .Property(e => e.begin_time)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<t_rm_spec_price_history>()
                .Property(e => e.end_time)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<t_rm_spec_price_history>()
                .Property(e => e.week)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<t_rm_spec_price_history>()
                .Property(e => e.dec_rate)
                .HasPrecision(5, 2);

            modelBuilder.Entity<t_rm_spec_price_history>()
                .Property(e => e.reach_val)
                .HasPrecision(16, 2);

            modelBuilder.Entity<t_rm_spec_price_history>()
                .Property(e => e.add_val)
                .HasPrecision(16, 2);

            modelBuilder.Entity<t_rm_spec_price_history>()
                .Property(e => e.gift_item)
                .IsUnicode(false);

            modelBuilder.Entity<t_rm_spec_price_history>()
                .Property(e => e.gift_qty)
                .IsUnicode(false);

            modelBuilder.Entity<t_rm_spec_price_history>()
                .Property(e => e.com_flag)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<t_rm_spec_price_history>()
                .Property(e => e.gift_price)
                .IsUnicode(false);

            modelBuilder.Entity<t_rm_spec_price_history>()
                .Property(e => e.reach_vip)
                .HasPrecision(16, 2);

            modelBuilder.Entity<t_rm_spec_price_history>()
                .Property(e => e.cls_flag)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<t_rm_spec_price_history>()
                .Property(e => e.cls_list)
                .IsUnicode(false);

            modelBuilder.Entity<t_rm_tend_add_detail>()
                .Property(e => e.flow_id)
                .HasPrecision(16, 0);

            modelBuilder.Entity<t_rm_tend_add_detail>()
                .Property(e => e.branch_no)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<t_rm_tend_add_detail>()
                .Property(e => e.flow_no)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<t_rm_tend_add_detail>()
                .Property(e => e.card_id)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<t_rm_tend_add_detail>()
                .Property(e => e.card_no)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<t_rm_tend_add_detail>()
                .Property(e => e.item_no)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<t_rm_tend_add_detail>()
                .Property(e => e.real_qty)
                .HasPrecision(16, 4);

            modelBuilder.Entity<t_rm_tend_add_detail>()
                .Property(e => e.sale_price)
                .HasPrecision(16, 4);

            modelBuilder.Entity<t_rm_tend_add_detail>()
                .Property(e => e.remain_qty)
                .HasPrecision(16, 4);

            modelBuilder.Entity<t_rm_tend_add_detail>()
                .Property(e => e.oper_id)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<t_rm_tend_add_detail>()
                .Property(e => e.comments)
                .IsUnicode(false);

            modelBuilder.Entity<t_rm_tend_add_detail>()
                .Property(e => e.com_flag)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<t_rm_tend_consume_detail>()
                .Property(e => e.flow_id)
                .HasPrecision(16, 0);

            modelBuilder.Entity<t_rm_tend_consume_detail>()
                .Property(e => e.branch_no)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<t_rm_tend_consume_detail>()
                .Property(e => e.flow_no)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<t_rm_tend_consume_detail>()
                .Property(e => e.card_id)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<t_rm_tend_consume_detail>()
                .Property(e => e.card_no)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<t_rm_tend_consume_detail>()
                .Property(e => e.item_no)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<t_rm_tend_consume_detail>()
                .Property(e => e.real_qty)
                .HasPrecision(16, 4);

            modelBuilder.Entity<t_rm_tend_consume_detail>()
                .Property(e => e.sale_price)
                .HasPrecision(16, 4);

            modelBuilder.Entity<t_rm_tend_consume_detail>()
                .Property(e => e.remain_qty)
                .HasPrecision(16, 4);

            modelBuilder.Entity<t_rm_tend_consume_detail>()
                .Property(e => e.remain_amt)
                .HasPrecision(16, 4);

            modelBuilder.Entity<t_rm_tend_consume_detail>()
                .Property(e => e.oper_id)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<t_rm_tend_consume_detail>()
                .Property(e => e.sale_man)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<t_rm_tend_consume_detail>()
                .Property(e => e.comments)
                .IsUnicode(false);

            modelBuilder.Entity<t_rm_tend_consume_detail>()
                .Property(e => e.com_flag)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<t_rm_tend_vip_conver_detail>()
                .Property(e => e.flow_id)
                .HasPrecision(16, 0);

            modelBuilder.Entity<t_rm_tend_vip_conver_detail>()
                .Property(e => e.sheet_no)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<t_rm_tend_vip_conver_detail>()
                .Property(e => e.item_no)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<t_rm_tend_vip_conver_detail>()
                .Property(e => e.real_qty)
                .HasPrecision(16, 4);

            modelBuilder.Entity<t_rm_tend_vip_conver_detail>()
                .Property(e => e.sale_price)
                .HasPrecision(16, 4);

            modelBuilder.Entity<t_rm_tend_vip_conver_detail>()
                .Property(e => e.remain_qty)
                .HasPrecision(16, 4);

            modelBuilder.Entity<t_rm_tend_vip_conver_detail>()
                .Property(e => e.remain_amt)
                .HasPrecision(16, 4);

            modelBuilder.Entity<t_rm_tend_vip_conver_detail>()
                .Property(e => e.num1)
                .HasPrecision(16, 4);

            modelBuilder.Entity<t_rm_tend_vip_conver_detail>()
                .Property(e => e.comments)
                .IsUnicode(false);

            modelBuilder.Entity<t_rm_tend_vip_conver_detail>()
                .Property(e => e.old_qty)
                .HasPrecision(16, 4);

            modelBuilder.Entity<t_rm_tend_vip_conver_detail>()
                .Property(e => e.old_amt)
                .HasPrecision(16, 4);

            modelBuilder.Entity<t_rm_tend_vip_conver_detail>()
                .Property(e => e.other_amt)
                .HasPrecision(16, 4);

            modelBuilder.Entity<t_rm_tend_vip_conver_detail>()
                .Property(e => e.spec_price)
                .HasPrecision(16, 4);

            modelBuilder.Entity<t_rm_tend_vip_conver_master>()
                .Property(e => e.sheet_no)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<t_rm_tend_vip_conver_master>()
                .Property(e => e.card_id)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<t_rm_tend_vip_conver_master>()
                .Property(e => e.card_no)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<t_rm_tend_vip_conver_master>()
                .Property(e => e.oper_id)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<t_rm_tend_vip_conver_master>()
                .Property(e => e.confirm_man)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<t_rm_tend_vip_conver_master>()
                .Property(e => e.ori_item_no)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<t_rm_tend_vip_conver_master>()
                .Property(e => e.ori_qty)
                .HasPrecision(16, 4);

            modelBuilder.Entity<t_rm_tend_vip_conver_master>()
                .Property(e => e.remain_qty)
                .HasPrecision(16, 4);

            modelBuilder.Entity<t_rm_tend_vip_conver_master>()
                .Property(e => e.sale_price)
                .HasPrecision(16, 4);

            modelBuilder.Entity<t_rm_tend_vip_conver_master>()
                .Property(e => e.sheet_amt)
                .HasPrecision(16, 4);

            modelBuilder.Entity<t_rm_tend_vip_conver_master>()
                .Property(e => e.approve_flag)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<t_rm_tend_vip_conver_master>()
                .Property(e => e.com_flag)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<t_rm_tend_vip_conver_master>()
                .Property(e => e.comments)
                .IsUnicode(false);

            modelBuilder.Entity<t_rm_tend_vip_conver_master>()
                .Property(e => e.branch_no)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<t_rm_tend_vip_conver_master>()
                .Property(e => e.sale_man_id)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<t_rm_tend_vip_conver_master>()
                .Property(e => e.pay_way)
                .IsUnicode(false);

            modelBuilder.Entity<t_rm_tend_vip_conver_master>()
                .Property(e => e.trans_no)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<t_rm_tend_vip_info>()
                .Property(e => e.card_id)
                .IsUnicode(false);

            modelBuilder.Entity<t_rm_tend_vip_info>()
                .Property(e => e.card_no)
                .IsUnicode(false);

            modelBuilder.Entity<t_rm_tend_vip_info>()
                .Property(e => e.item_no)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<t_rm_tend_vip_info>()
                .Property(e => e.limit_qty)
                .HasPrecision(16, 4);

            modelBuilder.Entity<t_rm_tend_vip_info>()
                .Property(e => e.real_qty)
                .HasPrecision(16, 4);

            modelBuilder.Entity<t_rm_tend_vip_info>()
                .Property(e => e.sale_price)
                .HasPrecision(16, 4);

            modelBuilder.Entity<t_rm_tend_vip_info>()
                .Property(e => e.limit_amt)
                .HasPrecision(16, 4);

            modelBuilder.Entity<t_rm_tend_vip_info>()
                .Property(e => e.comments)
                .IsUnicode(false);

            modelBuilder.Entity<t_rm_tend_vip_info>()
                .Property(e => e.com_flag)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<t_rm_tend_vip_type>()
                .Property(e => e.type_id)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<t_rm_tend_vip_type>()
                .Property(e => e.item_no)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<t_rm_tend_vip_type>()
                .Property(e => e.sale_price)
                .HasPrecision(16, 4);

            modelBuilder.Entity<t_rm_tend_vip_type>()
                .Property(e => e.comments)
                .IsUnicode(false);

            modelBuilder.Entity<t_rm_tend_vip_type>()
                .Property(e => e.com_flag)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<t_rm_vip_accessories_identity>()
                .Property(e => e.card_id)
                .IsUnicode(false);

            modelBuilder.Entity<t_rm_vip_accessories_identity>()
                .Property(e => e.novelty)
                .IsUnicode(false);

            modelBuilder.Entity<t_rm_vip_accessories_identity>()
                .Property(e => e.service)
                .IsUnicode(false);

            modelBuilder.Entity<t_rm_vip_accessories_identity>()
                .Property(e => e.is_speciality)
                .IsUnicode(false);

            modelBuilder.Entity<t_rm_vip_accessories_identity>()
                .Property(e => e.accessories_identity_1)
                .IsUnicode(false);

            modelBuilder.Entity<t_rm_vip_accessories_identity>()
                .Property(e => e.accessories_identity_2)
                .IsUnicode(false);

            modelBuilder.Entity<t_rm_vip_accessories_identity>()
                .Property(e => e.accessories_identity_3)
                .IsUnicode(false);

            modelBuilder.Entity<t_rm_vip_accessories_identity>()
                .Property(e => e.accessories_identity_4)
                .IsUnicode(false);

            modelBuilder.Entity<t_rm_vip_accessories_identity>()
                .Property(e => e.accessories_identity_5)
                .IsUnicode(false);

            modelBuilder.Entity<t_rm_vip_acclist>()
                .Property(e => e.flow_id)
                .HasPrecision(16, 0);

            modelBuilder.Entity<t_rm_vip_acclist>()
                .Property(e => e.card_id)
                .IsUnicode(false);

            modelBuilder.Entity<t_rm_vip_acclist>()
                .Property(e => e.card_no)
                .IsUnicode(false);

            modelBuilder.Entity<t_rm_vip_acclist>()
                .Property(e => e.card_type)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<t_rm_vip_acclist>()
                .Property(e => e.branch_no)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<t_rm_vip_acclist>()
                .Property(e => e.oper_type)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<t_rm_vip_acclist>()
                .Property(e => e.oper_id)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<t_rm_vip_acclist>()
                .Property(e => e.flow_no)
                .IsUnicode(false);

            modelBuilder.Entity<t_rm_vip_acclist>()
                .Property(e => e.consum_amt)
                .HasPrecision(16, 4);

            modelBuilder.Entity<t_rm_vip_acclist>()
                .Property(e => e.acc_num)
                .HasPrecision(10, 2);

            modelBuilder.Entity<t_rm_vip_acclist>()
                .Property(e => e.new_cardno)
                .IsUnicode(false);

            modelBuilder.Entity<t_rm_vip_acclist>()
                .Property(e => e.oper_des)
                .IsUnicode(false);

            modelBuilder.Entity<t_rm_vip_acclist>()
                .Property(e => e.memo)
                .IsUnicode(false);

            modelBuilder.Entity<t_rm_vip_acclist>()
                .Property(e => e.com_flag)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<t_rm_vip_agricultural_identity>()
                .Property(e => e.card_id)
                .IsUnicode(false);

            modelBuilder.Entity<t_rm_vip_agricultural_identity>()
                .Property(e => e.acreage)
                .HasPrecision(16, 4);

            modelBuilder.Entity<t_rm_vip_agricultural_identity>()
                .Property(e => e.crop1)
                .IsUnicode(false);

            modelBuilder.Entity<t_rm_vip_agricultural_identity>()
                .Property(e => e.crop2)
                .IsUnicode(false);

            modelBuilder.Entity<t_rm_vip_agricultural_identity>()
                .Property(e => e.crop3)
                .IsUnicode(false);

            modelBuilder.Entity<t_rm_vip_agricultural_identity>()
                .Property(e => e.crop4)
                .IsUnicode(false);

            modelBuilder.Entity<t_rm_vip_agricultural_identity>()
                .Property(e => e.crop5)
                .IsUnicode(false);

            modelBuilder.Entity<t_rm_vip_agricultural_identity>()
                .Property(e => e.breading)
                .HasPrecision(16, 4);

            modelBuilder.Entity<t_rm_vip_agricultural_identity>()
                .Property(e => e.species1)
                .IsUnicode(false);

            modelBuilder.Entity<t_rm_vip_agricultural_identity>()
                .Property(e => e.species2)
                .IsUnicode(false);

            modelBuilder.Entity<t_rm_vip_agricultural_identity>()
                .Property(e => e.species3)
                .IsUnicode(false);

            modelBuilder.Entity<t_rm_vip_agricultural_identity>()
                .Property(e => e.species4)
                .IsUnicode(false);

            modelBuilder.Entity<t_rm_vip_agricultural_identity>()
                .Property(e => e.species5)
                .IsUnicode(false);

            modelBuilder.Entity<t_rm_vip_cosmetic_identity>()
                .Property(e => e.card_id)
                .IsUnicode(false);

            modelBuilder.Entity<t_rm_vip_cosmetic_identity>()
                .Property(e => e.is_dermatosis)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<t_rm_vip_cosmetic_identity>()
                .Property(e => e.dermatosis_cause)
                .IsUnicode(false);

            modelBuilder.Entity<t_rm_vip_cosmetic_identity>()
                .Property(e => e.dermatosis_symptom)
                .IsUnicode(false);

            modelBuilder.Entity<t_rm_vip_cosmetic_identity>()
                .Property(e => e.is_hospital)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<t_rm_vip_cosmetic_identity>()
                .Property(e => e.bother)
                .IsUnicode(false);

            modelBuilder.Entity<t_rm_vip_cosmetic_identity>()
                .Property(e => e.attention)
                .IsUnicode(false);

            modelBuilder.Entity<t_rm_vip_cosmetic_identity>()
                .Property(e => e.cosmetic_identity_1)
                .IsUnicode(false);

            modelBuilder.Entity<t_rm_vip_cosmetic_identity>()
                .Property(e => e.cosmetic_identity_2)
                .IsUnicode(false);

            modelBuilder.Entity<t_rm_vip_cosmetic_identity>()
                .Property(e => e.cosmetic_identity_3)
                .IsUnicode(false);

            modelBuilder.Entity<t_rm_vip_cosmetic_identity>()
                .Property(e => e.cosmetic_identity_4)
                .IsUnicode(false);

            modelBuilder.Entity<t_rm_vip_cosmetic_identity>()
                .Property(e => e.cosmetic_identity_5)
                .IsUnicode(false);

            modelBuilder.Entity<t_rm_vip_discount>()
                .Property(e => e.vip_type)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<t_rm_vip_discount>()
                .Property(e => e.acc_num)
                .HasPrecision(6, 0);

            modelBuilder.Entity<t_rm_vip_discount>()
                .Property(e => e.acc_disc)
                .HasPrecision(2, 2);

            modelBuilder.Entity<t_rm_vip_discount>()
                .Property(e => e.memo)
                .IsUnicode(false);

            modelBuilder.Entity<t_rm_vip_good>()
                .Property(e => e.vg_no)
                .IsUnicode(false);

            modelBuilder.Entity<t_rm_vip_good>()
                .Property(e => e.vg_vip_num)
                .HasPrecision(20, 4);

            modelBuilder.Entity<t_rm_vip_good>()
                .Property(e => e.vg_branch_no)
                .IsUnicode(false);

            modelBuilder.Entity<t_rm_vip_good>()
                .Property(e => e.com_flag)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<t_rm_vip_good_flow>()
                .Property(e => e.flow_no)
                .HasPrecision(8, 0);

            modelBuilder.Entity<t_rm_vip_good_flow>()
                .Property(e => e.branch_no)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<t_rm_vip_good_flow>()
                .Property(e => e.card_id)
                .IsUnicode(false);

            modelBuilder.Entity<t_rm_vip_good_flow>()
                .Property(e => e.vip_no)
                .IsUnicode(false);

            modelBuilder.Entity<t_rm_vip_good_flow>()
                .Property(e => e.item_no)
                .IsUnicode(false);

            modelBuilder.Entity<t_rm_vip_good_flow>()
                .Property(e => e.vip_num)
                .HasPrecision(8, 2);

            modelBuilder.Entity<t_rm_vip_good_flow>()
                .Property(e => e.oper_id)
                .IsUnicode(false);

            modelBuilder.Entity<t_rm_vip_good_flow>()
                .Property(e => e.memo)
                .IsUnicode(false);

            modelBuilder.Entity<t_rm_vip_good_flow>()
                .Property(e => e.com_flag)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<t_rm_vip_health_identity>()
                .Property(e => e.card_id)
                .IsUnicode(false);

            modelBuilder.Entity<t_rm_vip_health_identity>()
                .Property(e => e.health_status)
                .IsUnicode(false);

            modelBuilder.Entity<t_rm_vip_health_identity>()
                .Property(e => e.now_eat_1)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<t_rm_vip_health_identity>()
                .Property(e => e.now_eat_2)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<t_rm_vip_health_identity>()
                .Property(e => e.now_eat_3)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<t_rm_vip_health_identity>()
                .Property(e => e.before_eat_1)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<t_rm_vip_health_identity>()
                .Property(e => e.before_eat_2)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<t_rm_vip_health_identity>()
                .Property(e => e.before_eat_3)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<t_rm_vip_health_identity>()
                .Property(e => e.like_buy_1)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<t_rm_vip_health_identity>()
                .Property(e => e.like_buy_2)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<t_rm_vip_health_identity>()
                .Property(e => e.like_buy_3)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<t_rm_vip_health_identity>()
                .Property(e => e.forbid_eat_1)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<t_rm_vip_health_identity>()
                .Property(e => e.forbid_eat_2)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<t_rm_vip_health_identity>()
                .Property(e => e.forbid_eat_3)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<t_rm_vip_health_identity>()
                .Property(e => e.attention)
                .IsUnicode(false);

            modelBuilder.Entity<t_rm_vip_health_identity>()
                .Property(e => e.memo_1)
                .IsUnicode(false);

            modelBuilder.Entity<t_rm_vip_health_identity>()
                .Property(e => e.memo_2)
                .IsUnicode(false);

            modelBuilder.Entity<t_rm_vip_health_identity>()
                .Property(e => e.memo_3)
                .IsUnicode(false);

            modelBuilder.Entity<t_rm_vip_health_identity>()
                .Property(e => e.memo_4)
                .IsUnicode(false);

            modelBuilder.Entity<t_rm_vip_health_identity>()
                .Property(e => e.memo_5)
                .IsUnicode(false);

            modelBuilder.Entity<t_rm_vip_info>()
                .Property(e => e.card_id)
                .IsUnicode(false);

            modelBuilder.Entity<t_rm_vip_info>()
                .Property(e => e.card_no)
                .IsUnicode(false);

            modelBuilder.Entity<t_rm_vip_info>()
                .Property(e => e.card_type)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<t_rm_vip_info>()
                .Property(e => e.vip_name)
                .IsUnicode(false);

            modelBuilder.Entity<t_rm_vip_info>()
                .Property(e => e.vip_sex)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<t_rm_vip_info>()
                .Property(e => e.vip_add)
                .IsUnicode(false);

            modelBuilder.Entity<t_rm_vip_info>()
                .Property(e => e.vip_zip)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<t_rm_vip_info>()
                .Property(e => e.vip_tel)
                .IsUnicode(false);

            modelBuilder.Entity<t_rm_vip_info>()
                .Property(e => e.vip_email)
                .IsUnicode(false);

            modelBuilder.Entity<t_rm_vip_info>()
                .Property(e => e.vip_tax)
                .HasPrecision(16, 4);

            modelBuilder.Entity<t_rm_vip_info>()
                .Property(e => e.card_status)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<t_rm_vip_info>()
                .Property(e => e.oper_id)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<t_rm_vip_info>()
                .Property(e => e.social_id)
                .IsUnicode(false);

            modelBuilder.Entity<t_rm_vip_info>()
                .Property(e => e.save_amt)
                .HasPrecision(16, 4);

            modelBuilder.Entity<t_rm_vip_info>()
                .Property(e => e.residual_amt)
                .IsUnicode(false);

            modelBuilder.Entity<t_rm_vip_info>()
                .Property(e => e.consum_amt)
                .HasPrecision(16, 4);

            modelBuilder.Entity<t_rm_vip_info>()
                .Property(e => e.company)
                .IsUnicode(false);

            modelBuilder.Entity<t_rm_vip_info>()
                .Property(e => e.duty)
                .IsUnicode(false);

            modelBuilder.Entity<t_rm_vip_info>()
                .Property(e => e.degree)
                .IsUnicode(false);

            modelBuilder.Entity<t_rm_vip_info>()
                .Property(e => e.mobile)
                .IsUnicode(false);

            modelBuilder.Entity<t_rm_vip_info>()
                .Property(e => e.homeplace)
                .IsUnicode(false);

            modelBuilder.Entity<t_rm_vip_info>()
                .Property(e => e.reg_place)
                .IsUnicode(false);

            modelBuilder.Entity<t_rm_vip_info>()
                .Property(e => e.live_place)
                .IsUnicode(false);

            modelBuilder.Entity<t_rm_vip_info>()
                .Property(e => e.marriage)
                .IsUnicode(false);

            modelBuilder.Entity<t_rm_vip_info>()
                .Property(e => e.salary_level)
                .IsUnicode(false);

            modelBuilder.Entity<t_rm_vip_info>()
                .Property(e => e.nation)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<t_rm_vip_info>()
                .Property(e => e.height)
                .HasPrecision(3, 0);

            modelBuilder.Entity<t_rm_vip_info>()
                .Property(e => e.weight)
                .HasPrecision(4, 1);

            modelBuilder.Entity<t_rm_vip_info>()
                .Property(e => e.blood_type)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<t_rm_vip_info>()
                .Property(e => e.favor)
                .IsUnicode(false);

            modelBuilder.Entity<t_rm_vip_info>()
                .Property(e => e.now_acc_num)
                .HasPrecision(10, 2);

            modelBuilder.Entity<t_rm_vip_info>()
                .Property(e => e.acc_num)
                .HasPrecision(10, 2);

            modelBuilder.Entity<t_rm_vip_info>()
                .Property(e => e.dec_num)
                .HasPrecision(10, 2);

            modelBuilder.Entity<t_rm_vip_info>()
                .Property(e => e.pass)
                .IsUnicode(false);

            modelBuilder.Entity<t_rm_vip_info>()
                .Property(e => e.com_flag)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<t_rm_vip_info>()
                .Property(e => e.photo)
                .IsUnicode(false);

            modelBuilder.Entity<t_rm_vip_info>()
                .Property(e => e.memo)
                .IsUnicode(false);

            modelBuilder.Entity<t_rm_vip_info>()
                .Property(e => e.father_card)
                .IsUnicode(false);

            modelBuilder.Entity<t_rm_vip_info>()
                .Property(e => e.item_amt)
                .HasPrecision(16, 4);

            modelBuilder.Entity<t_rm_vip_info>()
                .Property(e => e.branch_no)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<t_rm_vip_info>()
                .Property(e => e.source_card_id)
                .IsUnicode(false);

            modelBuilder.Entity<t_rm_vip_info>()
                .Property(e => e.vip_add1)
                .IsUnicode(false);

            modelBuilder.Entity<t_rm_vip_info>()
                .Property(e => e.vip_add2)
                .IsUnicode(false);

            modelBuilder.Entity<t_rm_vip_info>()
                .Property(e => e.annex_property1)
                .IsUnicode(false);

            modelBuilder.Entity<t_rm_vip_info>()
                .Property(e => e.annex_property2)
                .IsUnicode(false);

            modelBuilder.Entity<t_rm_vip_info>()
                .Property(e => e.annex_property3)
                .IsUnicode(false);

            modelBuilder.Entity<t_rm_vip_info>()
                .Property(e => e.annex_property4)
                .IsUnicode(false);

            modelBuilder.Entity<t_rm_vip_info>()
                .Property(e => e.annex_property5)
                .IsUnicode(false);

            modelBuilder.Entity<t_rm_vip_info>()
                .Property(e => e.annex_property6)
                .IsUnicode(false);

            modelBuilder.Entity<t_rm_vip_info>()
                .Property(e => e.annex_property7)
                .IsUnicode(false);

            modelBuilder.Entity<t_rm_vip_info>()
                .Property(e => e.annex_property8)
                .IsUnicode(false);

            modelBuilder.Entity<t_rm_vip_info>()
                .Property(e => e.annex_property9)
                .IsUnicode(false);

            modelBuilder.Entity<t_rm_vip_info>()
                .Property(e => e.annex_property10)
                .IsUnicode(false);

            modelBuilder.Entity<t_rm_vip_info>()
                .Property(e => e.picture_type)
                .IsUnicode(false);

            modelBuilder.Entity<t_rm_vip_info>()
                .Property(e => e.bth_flag)
                .IsUnicode(false);

            modelBuilder.Entity<t_rm_vip_info>()
                .Property(e => e.vip_credentials)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<t_rm_vip_info>()
                .Property(e => e.vip_work)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<t_rm_vip_info>()
                .Property(e => e.vip_intent)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<t_rm_vip_info>()
                .Property(e => e.pur_hobbies)
                .IsUnicode(false);

            modelBuilder.Entity<t_rm_vip_info>()
                .Property(e => e.characteristics)
                .IsUnicode(false);

            modelBuilder.Entity<t_rm_vip_info>()
                .Property(e => e.vip_trade)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<t_rm_vip_info>()
                .Property(e => e.vip_rem)
                .IsUnicode(false);

            modelBuilder.Entity<t_rm_vip_info>()
                .Property(e => e.oper_id_make)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<t_rm_vip_info>()
                .Property(e => e.oper_id_gi)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<t_rm_vip_info>()
                .Property(e => e.is_makecard)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<t_rm_vip_info>()
                .Property(e => e.IsAlive)
                .IsUnicode(false);

            modelBuilder.Entity<t_rm_vip_info>()
                .Property(e => e.send_amt)
                .HasPrecision(16, 4);

            modelBuilder.Entity<t_rm_vip_info>()
                .Property(e => e.modify_oper_id)
                .IsUnicode(false);

            modelBuilder.Entity<t_rm_vip_info>()
                .Property(e => e.openid)
                .IsUnicode(false);

            modelBuilder.Entity<t_rm_vip_info_breakpoint>()
                .Property(e => e.com_no)
                .HasPrecision(18, 0);

            modelBuilder.Entity<t_rm_vip_info_breakpoint>()
                .Property(e => e.change_type)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<t_rm_vip_info_breakpoint>()
                .Property(e => e.card_id)
                .IsUnicode(false);

            modelBuilder.Entity<t_rm_vip_info_edit>()
                .Property(e => e.flow_id)
                .HasPrecision(16, 0);

            modelBuilder.Entity<t_rm_vip_info_edit>()
                .Property(e => e.branch_no)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<t_rm_vip_info_edit>()
                .Property(e => e.card_id)
                .IsUnicode(false);

            modelBuilder.Entity<t_rm_vip_info_edit>()
                .Property(e => e.card_no)
                .IsUnicode(false);

            modelBuilder.Entity<t_rm_vip_info_edit>()
                .Property(e => e.card_type)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<t_rm_vip_info_edit>()
                .Property(e => e.vip_name)
                .IsUnicode(false);

            modelBuilder.Entity<t_rm_vip_info_edit>()
                .Property(e => e.vip_sex)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<t_rm_vip_info_edit>()
                .Property(e => e.vip_add)
                .IsUnicode(false);

            modelBuilder.Entity<t_rm_vip_info_edit>()
                .Property(e => e.vip_zip)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<t_rm_vip_info_edit>()
                .Property(e => e.vip_tel)
                .IsUnicode(false);

            modelBuilder.Entity<t_rm_vip_info_edit>()
                .Property(e => e.vip_email)
                .IsUnicode(false);

            modelBuilder.Entity<t_rm_vip_info_edit>()
                .Property(e => e.vip_tax)
                .HasPrecision(16, 4);

            modelBuilder.Entity<t_rm_vip_info_edit>()
                .Property(e => e.card_status)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<t_rm_vip_info_edit>()
                .Property(e => e.oper_id)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<t_rm_vip_info_edit>()
                .Property(e => e.social_id)
                .IsUnicode(false);

            modelBuilder.Entity<t_rm_vip_info_edit>()
                .Property(e => e.company)
                .IsUnicode(false);

            modelBuilder.Entity<t_rm_vip_info_edit>()
                .Property(e => e.duty)
                .IsUnicode(false);

            modelBuilder.Entity<t_rm_vip_info_edit>()
                .Property(e => e.degree)
                .IsUnicode(false);

            modelBuilder.Entity<t_rm_vip_info_edit>()
                .Property(e => e.mobile)
                .IsUnicode(false);

            modelBuilder.Entity<t_rm_vip_info_edit>()
                .Property(e => e.homeplace)
                .IsUnicode(false);

            modelBuilder.Entity<t_rm_vip_info_edit>()
                .Property(e => e.reg_place)
                .IsUnicode(false);

            modelBuilder.Entity<t_rm_vip_info_edit>()
                .Property(e => e.live_place)
                .IsUnicode(false);

            modelBuilder.Entity<t_rm_vip_info_edit>()
                .Property(e => e.marriage)
                .IsUnicode(false);

            modelBuilder.Entity<t_rm_vip_info_edit>()
                .Property(e => e.salary_level)
                .IsUnicode(false);

            modelBuilder.Entity<t_rm_vip_info_edit>()
                .Property(e => e.nation)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<t_rm_vip_info_edit>()
                .Property(e => e.height)
                .HasPrecision(3, 0);

            modelBuilder.Entity<t_rm_vip_info_edit>()
                .Property(e => e.weight)
                .HasPrecision(4, 1);

            modelBuilder.Entity<t_rm_vip_info_edit>()
                .Property(e => e.blood_type)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<t_rm_vip_info_edit>()
                .Property(e => e.favor)
                .IsUnicode(false);

            modelBuilder.Entity<t_rm_vip_info_edit>()
                .Property(e => e.pass)
                .IsUnicode(false);

            modelBuilder.Entity<t_rm_vip_info_edit>()
                .Property(e => e.com_flag)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<t_rm_vip_info_edit>()
                .Property(e => e.memo)
                .IsUnicode(false);

            modelBuilder.Entity<t_rm_vip_info_edit>()
                .Property(e => e.father_card)
                .IsUnicode(false);

            modelBuilder.Entity<t_rm_vip_info_edit>()
                .Property(e => e.approve_flag)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<t_rm_vip_info_edit>()
                .Property(e => e.vip_add1)
                .IsUnicode(false);

            modelBuilder.Entity<t_rm_vip_info_edit>()
                .Property(e => e.vip_add2)
                .IsUnicode(false);

            modelBuilder.Entity<t_rm_vip_info_edit>()
                .Property(e => e.annex_property1)
                .IsUnicode(false);

            modelBuilder.Entity<t_rm_vip_info_edit>()
                .Property(e => e.annex_property2)
                .IsUnicode(false);

            modelBuilder.Entity<t_rm_vip_info_edit>()
                .Property(e => e.annex_property3)
                .IsUnicode(false);

            modelBuilder.Entity<t_rm_vip_info_edit>()
                .Property(e => e.annex_property4)
                .IsUnicode(false);

            modelBuilder.Entity<t_rm_vip_info_edit>()
                .Property(e => e.annex_property5)
                .IsUnicode(false);

            modelBuilder.Entity<t_rm_vip_info_edit>()
                .Property(e => e.annex_property6)
                .IsUnicode(false);

            modelBuilder.Entity<t_rm_vip_info_edit>()
                .Property(e => e.annex_property7)
                .IsUnicode(false);

            modelBuilder.Entity<t_rm_vip_info_edit>()
                .Property(e => e.annex_property8)
                .IsUnicode(false);

            modelBuilder.Entity<t_rm_vip_info_edit>()
                .Property(e => e.annex_property9)
                .IsUnicode(false);

            modelBuilder.Entity<t_rm_vip_info_edit>()
                .Property(e => e.annex_property10)
                .IsUnicode(false);

            modelBuilder.Entity<t_rm_vip_info_edit>()
                .Property(e => e.vip_credentials)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<t_rm_vip_info_edit>()
                .Property(e => e.vip_work)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<t_rm_vip_info_edit>()
                .Property(e => e.vip_intent)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<t_rm_vip_info_prink>()
                .Property(e => e.card_id)
                .IsUnicode(false);

            modelBuilder.Entity<t_rm_vip_info_prink>()
                .Property(e => e.card_no)
                .IsUnicode(false);

            modelBuilder.Entity<t_rm_vip_info_prink>()
                .Property(e => e.prink_yes_no)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<t_rm_vip_info_prink>()
                .Property(e => e.prink_qu)
                .IsUnicode(false);

            modelBuilder.Entity<t_rm_vip_info_prink>()
                .Property(e => e.prink_symptom)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<t_rm_vip_info_prink>()
                .Property(e => e.prink_cure)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<t_rm_vip_info_prink>()
                .Property(e => e.prink_bother)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<t_rm_vip_info_prink>()
                .Property(e => e.prink_accident)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<t_rm_vip_info_source>()
                .Property(e => e.card_id)
                .IsUnicode(false);

            modelBuilder.Entity<t_rm_vip_info_source>()
                .Property(e => e.card_no)
                .IsUnicode(false);

            modelBuilder.Entity<t_rm_vip_info_source>()
                .Property(e => e.card_type)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<t_rm_vip_info_source>()
                .Property(e => e.vip_name)
                .IsUnicode(false);

            modelBuilder.Entity<t_rm_vip_info_source>()
                .Property(e => e.vip_sex)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<t_rm_vip_info_source>()
                .Property(e => e.vip_add)
                .IsUnicode(false);

            modelBuilder.Entity<t_rm_vip_info_source>()
                .Property(e => e.vip_zip)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<t_rm_vip_info_source>()
                .Property(e => e.vip_tel)
                .IsUnicode(false);

            modelBuilder.Entity<t_rm_vip_info_source>()
                .Property(e => e.vip_email)
                .IsUnicode(false);

            modelBuilder.Entity<t_rm_vip_info_source>()
                .Property(e => e.vip_tax)
                .HasPrecision(16, 4);

            modelBuilder.Entity<t_rm_vip_info_source>()
                .Property(e => e.card_status)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<t_rm_vip_info_source>()
                .Property(e => e.oper_id)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<t_rm_vip_info_source>()
                .Property(e => e.social_id)
                .IsUnicode(false);

            modelBuilder.Entity<t_rm_vip_info_source>()
                .Property(e => e.save_amt)
                .HasPrecision(16, 4);

            modelBuilder.Entity<t_rm_vip_info_source>()
                .Property(e => e.residual_amt)
                .IsUnicode(false);

            modelBuilder.Entity<t_rm_vip_info_source>()
                .Property(e => e.consum_amt)
                .HasPrecision(16, 4);

            modelBuilder.Entity<t_rm_vip_info_source>()
                .Property(e => e.company)
                .IsUnicode(false);

            modelBuilder.Entity<t_rm_vip_info_source>()
                .Property(e => e.duty)
                .IsUnicode(false);

            modelBuilder.Entity<t_rm_vip_info_source>()
                .Property(e => e.degree)
                .IsUnicode(false);

            modelBuilder.Entity<t_rm_vip_info_source>()
                .Property(e => e.mobile)
                .IsUnicode(false);

            modelBuilder.Entity<t_rm_vip_info_source>()
                .Property(e => e.homeplace)
                .IsUnicode(false);

            modelBuilder.Entity<t_rm_vip_info_source>()
                .Property(e => e.reg_place)
                .IsUnicode(false);

            modelBuilder.Entity<t_rm_vip_info_source>()
                .Property(e => e.live_place)
                .IsUnicode(false);

            modelBuilder.Entity<t_rm_vip_info_source>()
                .Property(e => e.marriage)
                .IsUnicode(false);

            modelBuilder.Entity<t_rm_vip_info_source>()
                .Property(e => e.salary_level)
                .IsUnicode(false);

            modelBuilder.Entity<t_rm_vip_info_source>()
                .Property(e => e.nation)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<t_rm_vip_info_source>()
                .Property(e => e.height)
                .HasPrecision(3, 0);

            modelBuilder.Entity<t_rm_vip_info_source>()
                .Property(e => e.weight)
                .HasPrecision(4, 1);

            modelBuilder.Entity<t_rm_vip_info_source>()
                .Property(e => e.blood_type)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<t_rm_vip_info_source>()
                .Property(e => e.favor)
                .IsUnicode(false);

            modelBuilder.Entity<t_rm_vip_info_source>()
                .Property(e => e.now_acc_num)
                .HasPrecision(10, 2);

            modelBuilder.Entity<t_rm_vip_info_source>()
                .Property(e => e.acc_num)
                .HasPrecision(10, 2);

            modelBuilder.Entity<t_rm_vip_info_source>()
                .Property(e => e.dec_num)
                .HasPrecision(10, 2);

            modelBuilder.Entity<t_rm_vip_info_source>()
                .Property(e => e.pass)
                .IsUnicode(false);

            modelBuilder.Entity<t_rm_vip_info_source>()
                .Property(e => e.com_flag)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<t_rm_vip_info_source>()
                .Property(e => e.photo)
                .IsUnicode(false);

            modelBuilder.Entity<t_rm_vip_info_source>()
                .Property(e => e.memo)
                .IsUnicode(false);

            modelBuilder.Entity<t_rm_vip_info_source>()
                .Property(e => e.father_card)
                .IsUnicode(false);

            modelBuilder.Entity<t_rm_vip_info_source>()
                .Property(e => e.item_amt)
                .HasPrecision(16, 4);

            modelBuilder.Entity<t_rm_vip_info_source>()
                .Property(e => e.branch_no)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<t_rm_vip_info_source>()
                .Property(e => e.source_card_id)
                .IsUnicode(false);

            modelBuilder.Entity<t_rm_vip_info_source>()
                .Property(e => e.vip_add1)
                .IsUnicode(false);

            modelBuilder.Entity<t_rm_vip_info_source>()
                .Property(e => e.vip_add2)
                .IsUnicode(false);

            modelBuilder.Entity<t_rm_vip_info_source>()
                .Property(e => e.annex_property1)
                .IsUnicode(false);

            modelBuilder.Entity<t_rm_vip_info_source>()
                .Property(e => e.annex_property2)
                .IsUnicode(false);

            modelBuilder.Entity<t_rm_vip_info_source>()
                .Property(e => e.annex_property3)
                .IsUnicode(false);

            modelBuilder.Entity<t_rm_vip_info_source>()
                .Property(e => e.annex_property4)
                .IsUnicode(false);

            modelBuilder.Entity<t_rm_vip_info_source>()
                .Property(e => e.annex_property5)
                .IsUnicode(false);

            modelBuilder.Entity<t_rm_vip_info_source>()
                .Property(e => e.annex_property6)
                .IsUnicode(false);

            modelBuilder.Entity<t_rm_vip_info_source>()
                .Property(e => e.annex_property7)
                .IsUnicode(false);

            modelBuilder.Entity<t_rm_vip_info_source>()
                .Property(e => e.annex_property8)
                .IsUnicode(false);

            modelBuilder.Entity<t_rm_vip_info_source>()
                .Property(e => e.annex_property9)
                .IsUnicode(false);

            modelBuilder.Entity<t_rm_vip_info_source>()
                .Property(e => e.annex_property10)
                .IsUnicode(false);

            modelBuilder.Entity<t_rm_vip_info_source>()
                .Property(e => e.picture_type)
                .IsUnicode(false);

            modelBuilder.Entity<t_rm_vip_info_source>()
                .Property(e => e.bth_flag)
                .IsUnicode(false);

            modelBuilder.Entity<t_rm_vip_info_source>()
                .Property(e => e.oper_id_gi)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<t_rm_vip_item>()
                .Property(e => e.item_no)
                .IsUnicode(false);

            modelBuilder.Entity<t_rm_vip_item>()
                .Property(e => e.memo)
                .IsUnicode(false);

            modelBuilder.Entity<t_rm_vip_item>()
                .Property(e => e.draw_status)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<t_rm_vip_itemlist>()
                .Property(e => e.flow_id)
                .HasPrecision(14, 0);

            modelBuilder.Entity<t_rm_vip_itemlist>()
                .Property(e => e.card_id)
                .IsUnicode(false);

            modelBuilder.Entity<t_rm_vip_itemlist>()
                .Property(e => e.item_no)
                .IsUnicode(false);

            modelBuilder.Entity<t_rm_vip_itemlist>()
                .Property(e => e.send_qty)
                .HasPrecision(16, 4);

            modelBuilder.Entity<t_rm_vip_itemlist>()
                .Property(e => e.draw_flag)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<t_rm_vip_itemlist>()
                .Property(e => e.branch_no)
                .IsUnicode(false);

            modelBuilder.Entity<t_rm_vip_itemlist>()
                .Property(e => e.oper_id)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<t_rm_vip_itemlist>()
                .Property(e => e.draw_branch_no)
                .IsUnicode(false);

            modelBuilder.Entity<t_rm_vip_itemlist>()
                .Property(e => e.draw_oper_id)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<t_rm_vip_motherhood_identity>()
                .Property(e => e.card_id)
                .IsUnicode(false);

            modelBuilder.Entity<t_rm_vip_motherhood_identity>()
                .Property(e => e.baby_sex)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<t_rm_vip_motherhood_identity>()
                .Property(e => e.brand_1)
                .IsUnicode(false);

            modelBuilder.Entity<t_rm_vip_motherhood_identity>()
                .Property(e => e.brand_2)
                .IsUnicode(false);

            modelBuilder.Entity<t_rm_vip_motherhood_identity>()
                .Property(e => e.motherhood_identity_1)
                .IsUnicode(false);

            modelBuilder.Entity<t_rm_vip_motherhood_identity>()
                .Property(e => e.motherhood_identity_2)
                .IsUnicode(false);

            modelBuilder.Entity<t_rm_vip_motherhood_identity>()
                .Property(e => e.motherhood_identity_3)
                .IsUnicode(false);

            modelBuilder.Entity<t_rm_vip_motherhood_identity>()
                .Property(e => e.motherhood_identity_4)
                .IsUnicode(false);

            modelBuilder.Entity<t_rm_vip_motherhood_identity>()
                .Property(e => e.motherhood_identity_5)
                .IsUnicode(false);

            modelBuilder.Entity<t_rm_vip_motherhood_identity>()
                .Property(e => e.baby_name)
                .IsUnicode(false);

            modelBuilder.Entity<t_rm_vip_motherhood_identity>()
                .Property(e => e.baby_rem)
                .IsUnicode(false);

            modelBuilder.Entity<t_rm_vip_motherhood_identity>()
                .Property(e => e.baby_property1)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<t_rm_vip_motherhood_identity>()
                .Property(e => e.baby_property2)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<t_rm_vip_motherhood_identity>()
                .Property(e => e.baby_property3)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<t_rm_vip_operlist>()
                .Property(e => e.flow_id)
                .HasPrecision(16, 0);

            modelBuilder.Entity<t_rm_vip_operlist>()
                .Property(e => e.card_id)
                .IsUnicode(false);

            modelBuilder.Entity<t_rm_vip_operlist>()
                .Property(e => e.card_no)
                .IsUnicode(false);

            modelBuilder.Entity<t_rm_vip_operlist>()
                .Property(e => e.card_type)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<t_rm_vip_operlist>()
                .Property(e => e.branch_no)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<t_rm_vip_operlist>()
                .Property(e => e.oper_type)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<t_rm_vip_operlist>()
                .Property(e => e.oper_id)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<t_rm_vip_operlist>()
                .Property(e => e.flow_no)
                .IsUnicode(false);

            modelBuilder.Entity<t_rm_vip_operlist>()
                .Property(e => e.consum_amt)
                .HasPrecision(16, 4);

            modelBuilder.Entity<t_rm_vip_operlist>()
                .Property(e => e.acc_num)
                .HasPrecision(10, 2);

            modelBuilder.Entity<t_rm_vip_operlist>()
                .Property(e => e.new_cardno)
                .IsUnicode(false);

            modelBuilder.Entity<t_rm_vip_operlist>()
                .Property(e => e.oper_des)
                .IsUnicode(false);

            modelBuilder.Entity<t_rm_vip_operlist>()
                .Property(e => e.memo)
                .IsUnicode(false);

            modelBuilder.Entity<t_rm_vip_operlist>()
                .Property(e => e.com_flag)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<t_rm_vip_reference>()
                .Property(e => e.vip_type)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<t_rm_vip_reference>()
                .Property(e => e.sys_var_id)
                .IsUnicode(false);

            modelBuilder.Entity<t_rm_vip_reference>()
                .Property(e => e.sys_var_name)
                .IsUnicode(false);

            modelBuilder.Entity<t_rm_vip_reference>()
                .Property(e => e.sys_var_value)
                .IsUnicode(false);

            modelBuilder.Entity<t_rm_vip_reference>()
                .Property(e => e.branch_no)
                .IsUnicode(false);

            modelBuilder.Entity<t_rm_vip_reference>()
                .Property(e => e.oper_id)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<t_rm_vip_reference>()
                .Property(e => e.memo)
                .IsUnicode(false);

            modelBuilder.Entity<t_rm_vip_savelist>()
                .Property(e => e.flow_id)
                .HasPrecision(16, 0);

            modelBuilder.Entity<t_rm_vip_savelist>()
                .Property(e => e.card_id)
                .IsUnicode(false);

            modelBuilder.Entity<t_rm_vip_savelist>()
                .Property(e => e.card_no)
                .IsUnicode(false);

            modelBuilder.Entity<t_rm_vip_savelist>()
                .Property(e => e.card_type)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<t_rm_vip_savelist>()
                .Property(e => e.branch_no)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<t_rm_vip_savelist>()
                .Property(e => e.oper_type)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<t_rm_vip_savelist>()
                .Property(e => e.oper_id)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<t_rm_vip_savelist>()
                .Property(e => e.flow_no)
                .IsUnicode(false);

            modelBuilder.Entity<t_rm_vip_savelist>()
                .Property(e => e.consum_amt)
                .HasPrecision(16, 4);

            modelBuilder.Entity<t_rm_vip_savelist>()
                .Property(e => e.acc_num)
                .HasPrecision(10, 2);

            modelBuilder.Entity<t_rm_vip_savelist>()
                .Property(e => e.new_cardno)
                .IsUnicode(false);

            modelBuilder.Entity<t_rm_vip_savelist>()
                .Property(e => e.oper_des)
                .IsUnicode(false);

            modelBuilder.Entity<t_rm_vip_savelist>()
                .Property(e => e.memo)
                .IsUnicode(false);

            modelBuilder.Entity<t_rm_vip_savelist>()
                .Property(e => e.com_flag)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<t_rm_vip_savelist>()
                .Property(e => e.sale_qty)
                .HasPrecision(16, 4);

            modelBuilder.Entity<t_rm_vip_savelist>()
                .Property(e => e.item_no)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<t_rm_vip_savelist>()
                .Property(e => e.real_amt)
                .HasPrecision(16, 4);

            modelBuilder.Entity<t_rm_vip_savelist>()
                .Property(e => e.payway)
                .IsUnicode(false);

            modelBuilder.Entity<t_rm_vip_savelist>()
                .Property(e => e.other2)
                .IsUnicode(false);

            modelBuilder.Entity<t_rm_vip_saveset>()
                .Property(e => e.flow_id)
                .HasPrecision(14, 0);

            modelBuilder.Entity<t_rm_vip_saveset>()
                .Property(e => e.start_amt)
                .HasPrecision(16, 4);

            modelBuilder.Entity<t_rm_vip_saveset>()
                .Property(e => e.end_amt)
                .HasPrecision(16, 4);

            modelBuilder.Entity<t_rm_vip_saveset>()
                .Property(e => e.send_amt)
                .HasPrecision(16, 4);

            modelBuilder.Entity<t_rm_vip_saveset>()
                .Property(e => e.branch_no)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<t_rm_vip_set>()
                .Property(e => e.vip_type)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<t_rm_vip_set>()
                .Property(e => e.jf_type)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<t_rm_vip_set>()
                .Property(e => e.vip_item_cls)
                .IsUnicode(false);

            modelBuilder.Entity<t_rm_vip_set>()
                .Property(e => e.low_amt)
                .HasPrecision(16, 4);

            modelBuilder.Entity<t_rm_vip_set>()
                .Property(e => e.high_amt)
                .HasPrecision(16, 4);

            modelBuilder.Entity<t_rm_vip_set>()
                .Property(e => e.vip_amt)
                .HasPrecision(16, 4);

            modelBuilder.Entity<t_rm_vip_set>()
                .Property(e => e.memo)
                .IsUnicode(false);

            modelBuilder.Entity<t_rm_vip_type>()
                .Property(e => e.type_id)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<t_rm_vip_type>()
                .Property(e => e.type_name)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<t_rm_vip_type>()
                .Property(e => e.sale_way)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<t_rm_vip_type>()
                .Property(e => e.discount)
                .HasPrecision(5, 4);

            modelBuilder.Entity<t_rm_vip_type>()
                .Property(e => e.oper_id)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<t_rm_vip_type>()
                .Property(e => e.acc_flag)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<t_rm_vip_type>()
                .Property(e => e.acc_amt)
                .HasPrecision(16, 4);

            modelBuilder.Entity<t_rm_vip_type>()
                .Property(e => e.sale_amt)
                .HasPrecision(16, 4);

            modelBuilder.Entity<t_rm_vip_type>()
                .Property(e => e.limit_times)
                .HasPrecision(16, 0);

            modelBuilder.Entity<t_rm_vip_type>()
                .Property(e => e.card_type)
                .IsUnicode(false);

            modelBuilder.Entity<t_rm_vip_type>()
                .Property(e => e.ic_type)
                .IsUnicode(false);

            modelBuilder.Entity<t_rm_vip_type>()
                .Property(e => e.saving_flag)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<t_rm_vip_type>()
                .Property(e => e.memo)
                .IsUnicode(false);

            modelBuilder.Entity<t_rm_vip_type>()
                .Property(e => e.item_flag)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<t_rm_vip_type>()
                .Property(e => e.update_acc)
                .HasPrecision(16, 4);

            modelBuilder.Entity<t_rm_vip_type>()
                .Property(e => e.update_amt)
                .HasPrecision(16, 4);

            modelBuilder.Entity<t_rm_vip_type_source>()
                .Property(e => e.type_id)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<t_rm_vip_type_source>()
                .Property(e => e.type_name)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<t_rm_vip_type_source>()
                .Property(e => e.sale_way)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<t_rm_vip_type_source>()
                .Property(e => e.discount)
                .HasPrecision(5, 4);

            modelBuilder.Entity<t_rm_vip_type_source>()
                .Property(e => e.oper_id)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<t_rm_vip_type_source>()
                .Property(e => e.acc_flag)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<t_rm_vip_type_source>()
                .Property(e => e.acc_amt)
                .HasPrecision(16, 4);

            modelBuilder.Entity<t_rm_vip_type_source>()
                .Property(e => e.sale_amt)
                .HasPrecision(16, 4);

            modelBuilder.Entity<t_rm_vip_type_source>()
                .Property(e => e.limit_times)
                .HasPrecision(16, 0);

            modelBuilder.Entity<t_rm_vip_type_source>()
                .Property(e => e.card_type)
                .IsUnicode(false);

            modelBuilder.Entity<t_rm_vip_type_source>()
                .Property(e => e.ic_type)
                .IsUnicode(false);

            modelBuilder.Entity<t_rm_vip_type_source>()
                .Property(e => e.saving_flag)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<t_rm_vip_type_source>()
                .Property(e => e.memo)
                .IsUnicode(false);

            modelBuilder.Entity<t_rm_vip_type_source>()
                .Property(e => e.item_flag)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<t_rm_vip_type_source>()
                .Property(e => e.update_acc)
                .HasPrecision(16, 4);

            modelBuilder.Entity<t_rm_vip_type_source>()
                .Property(e => e.update_amt)
                .HasPrecision(16, 4);

            modelBuilder.Entity<t_rm_vip_visit>()
                .Property(e => e.visit_id)
                .HasPrecision(10, 0);

            modelBuilder.Entity<t_rm_vip_visit>()
                .Property(e => e.card_id)
                .IsUnicode(false);

            modelBuilder.Entity<t_rm_vip_visit>()
                .Property(e => e.visit_typeno)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<t_rm_vip_visit>()
                .Property(e => e.visit_type)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<t_rm_vip_visit>()
                .Property(e => e.visit_way)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<t_rm_vip_visit>()
                .Property(e => e.item_name)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<t_rm_vip_visit>()
                .Property(e => e.buy_emporium)
                .IsUnicode(false);

            modelBuilder.Entity<t_rm_vip_visit>()
                .Property(e => e.satisfaction_degree)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<t_rm_vip_visit>()
                .Property(e => e.advice_type)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<t_rm_vip_visit>()
                .Property(e => e.visit_content)
                .IsUnicode(false);

            modelBuilder.Entity<t_rm_vip_visit>()
                .Property(e => e.visit_oper_id)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<t_rm_vip_visit>()
                .Property(e => e.com_flag)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<t_rm_vip_visit>()
                .Property(e => e.branch_no)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<t_rm_vip_visit>()
                .Property(e => e.flow_no)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<t_rm_vip_visit>()
                .Property(e => e.visit_subjectno)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<t_rm_vip_visit>()
                .Property(e => e.visit_subject)
                .IsUnicode(false);

            modelBuilder.Entity<t_rm_vip_visit>()
                .Property(e => e.visit_status)
                .IsUnicode(false);

            modelBuilder.Entity<t_rm_vip_visit_cls>()
                .Property(e => e.visit_typeno)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<t_rm_vip_visit_cls>()
                .Property(e => e.visit_type)
                .IsUnicode(false);

            modelBuilder.Entity<t_rm_vip_visit_detail>()
                .Property(e => e.visit_detailno)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<t_rm_vip_visit_detail>()
                .Property(e => e.visit_subjectno)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<t_rm_vip_visit_detail>()
                .Property(e => e.visit_detail)
                .IsUnicode(false);

            modelBuilder.Entity<t_rm_vip_visit_flow>()
                .Property(e => e.flow_id)
                .HasPrecision(16, 0);

            modelBuilder.Entity<t_rm_vip_visit_flow>()
                .Property(e => e.card_id)
                .IsUnicode(false);

            modelBuilder.Entity<t_rm_vip_visit_flow>()
                .Property(e => e.branch_no)
                .IsUnicode(false);

            modelBuilder.Entity<t_rm_vip_visit_flow>()
                .Property(e => e.flow_no)
                .IsUnicode(false);

            modelBuilder.Entity<t_rm_vip_visit_flow>()
                .Property(e => e.item_no)
                .IsUnicode(false);

            modelBuilder.Entity<t_rm_vip_visit_flow>()
                .Property(e => e.sale_qnty)
                .HasPrecision(16, 4);

            modelBuilder.Entity<t_rm_vip_visit_flow>()
                .Property(e => e.sale_money)
                .HasPrecision(16, 4);

            modelBuilder.Entity<t_rm_vip_visit_flow>()
                .Property(e => e.visit_flag)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<t_rm_vip_visit_master>()
                .Property(e => e.visit_subjectno)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<t_rm_vip_visit_master>()
                .Property(e => e.visit_subject)
                .IsUnicode(false);

            modelBuilder.Entity<t_rm_vip_visit_master>()
                .Property(e => e.visit_typeno)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<t_saleman_item_daysum>()
                .Property(e => e.item_no)
                .IsUnicode(false);

            modelBuilder.Entity<t_saleman_item_daysum>()
                .Property(e => e.branch_no)
                .IsUnicode(false);

            modelBuilder.Entity<t_saleman_item_daysum>()
                .Property(e => e.sale_id)
                .IsUnicode(false);

            modelBuilder.Entity<t_saleman_item_daysum>()
                .Property(e => e.real_qty)
                .HasPrecision(16, 4);

            modelBuilder.Entity<t_saleman_item_daysum>()
                .Property(e => e.real_amt)
                .HasPrecision(16, 4);

            modelBuilder.Entity<t_saleman_item_daysum>()
                .Property(e => e.sale_rate_amt)
                .HasPrecision(16, 4);

            modelBuilder.Entity<t_saleman_item_daysum>()
                .Property(e => e.clss_rate_amt)
                .HasPrecision(16, 4);

            modelBuilder.Entity<t_saleman_item_daysum>()
                .Property(e => e.brand_rate_amt)
                .HasPrecision(16, 4);

            modelBuilder.Entity<t_saleman_item_daysum>()
                .Property(e => e.return_rate_amt)
                .HasPrecision(16, 4);

            modelBuilder.Entity<t_saleman_item_daysum>()
                .Property(e => e.duty_rate_amt)
                .HasPrecision(16, 4);

            modelBuilder.Entity<t_shd_delivery_flow>()
                .Property(e => e.flow_id)
                .HasPrecision(18, 0);

            modelBuilder.Entity<t_shd_delivery_flow>()
                .Property(e => e.voucher_no)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<t_shd_delivery_flow>()
                .Property(e => e.supcust_no)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<t_shd_delivery_flow>()
                .Property(e => e.branch_no)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<t_shd_delivery_flow>()
                .Property(e => e.delivery_man)
                .IsUnicode(false);

            modelBuilder.Entity<t_shd_delivery_flow>()
                .Property(e => e.item_no)
                .IsUnicode(false);

            modelBuilder.Entity<t_shd_delivery_flow>()
                .Property(e => e.del_subno_flag)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<t_shd_delivery_flow>()
                .Property(e => e.del_subno)
                .IsUnicode(false);

            modelBuilder.Entity<t_shd_delivery_flow>()
                .Property(e => e.del_day_num)
                .HasPrecision(16, 4);

            modelBuilder.Entity<t_shd_delivery_flow>()
                .Property(e => e.oper_id)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<t_shd_delivery_flow>()
                .Property(e => e.com_flag)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<t_shd_delivery_flow>()
                .Property(e => e.delivery_flag)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<t_shd_delivery_flow>()
                .Property(e => e.del_time)
                .IsUnicode(false);

            modelBuilder.Entity<t_shd_delivery_flow>()
                .Property(e => e.valid_price)
                .HasPrecision(16, 4);

            modelBuilder.Entity<t_shd_delivery_flow>()
                .Property(e => e.cost_price)
                .HasPrecision(16, 4);

            modelBuilder.Entity<t_shd_delivery_flow>()
                .Property(e => e.sale_oper)
                .IsUnicode(false);

            modelBuilder.Entity<t_shd_delivery_flow>()
                .Property(e => e.tp_oper)
                .IsUnicode(false);

            modelBuilder.Entity<t_shd_delivery_flow>()
                .Property(e => e.sale_flag)
                .IsUnicode(false);

            modelBuilder.Entity<t_shd_delivery_flow>()
                .Property(e => e.tp_flag)
                .IsUnicode(false);

            modelBuilder.Entity<t_shd_recpay_flow>()
                .Property(e => e.flow_id)
                .HasPrecision(18, 0);

            modelBuilder.Entity<t_shd_recpay_flow>()
                .Property(e => e.voucher_no)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<t_shd_recpay_flow>()
                .Property(e => e.coin_no)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<t_shd_recpay_flow>()
                .Property(e => e.discount)
                .HasPrecision(5, 4);

            modelBuilder.Entity<t_shd_recpay_flow>()
                .Property(e => e.sheet_amt)
                .HasPrecision(16, 4);

            modelBuilder.Entity<t_shd_recpay_flow>()
                .Property(e => e.should_amt)
                .HasPrecision(16, 4);

            modelBuilder.Entity<t_shd_recpay_flow>()
                .Property(e => e.already_amt)
                .HasPrecision(16, 4);

            modelBuilder.Entity<t_shd_recpay_flow>()
                .Property(e => e.pay_way)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<t_shd_recpay_flow>()
                .Property(e => e.sale_way)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<t_shd_recpay_flow>()
                .Property(e => e.supcust_no)
                .IsUnicode(false);

            modelBuilder.Entity<t_shd_recpay_flow>()
                .Property(e => e.memo)
                .IsUnicode(false);

            modelBuilder.Entity<t_shd_recpay_flow>()
                .Property(e => e.com_flag)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<t_shd_recpay_flow>()
                .Property(e => e.branch_no)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<t_shd_recpay_flow>()
                .Property(e => e.acc_type)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<t_shd_recpay_flow>()
                .Property(e => e.other_amt)
                .HasPrecision(16, 4);

            modelBuilder.Entity<t_shd_recpay_flow>()
                .Property(e => e.ather_amt_f)
                .HasPrecision(16, 4);

            modelBuilder.Entity<t_shd_recpay_flow>()
                .Property(e => e.old_voucher_no)
                .IsUnicode(false);

            modelBuilder.Entity<t_shd_recpay_flow>()
                .Property(e => e.old_delivery_amt)
                .HasPrecision(16, 4);

            modelBuilder.Entity<t_shd_recpay_flow_detail>()
                .Property(e => e.flow_id)
                .HasPrecision(18, 0);

            modelBuilder.Entity<t_shd_recpay_flow_detail>()
                .Property(e => e.voucher_no)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<t_shd_recpay_flow_detail>()
                .Property(e => e.coin_no)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<t_shd_recpay_flow_detail>()
                .Property(e => e.discount)
                .HasPrecision(5, 4);

            modelBuilder.Entity<t_shd_recpay_flow_detail>()
                .Property(e => e.already_amt)
                .HasPrecision(16, 4);

            modelBuilder.Entity<t_shd_recpay_flow_detail>()
                .Property(e => e.pay_way)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<t_shd_recpay_flow_detail>()
                .Property(e => e.sale_way)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<t_shd_recpay_flow_detail>()
                .Property(e => e.supcust_no)
                .IsUnicode(false);

            modelBuilder.Entity<t_shd_recpay_flow_detail>()
                .Property(e => e.memo)
                .IsUnicode(false);

            modelBuilder.Entity<t_shd_recpay_flow_detail>()
                .Property(e => e.com_flag)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<t_shd_recpay_flow_detail>()
                .Property(e => e.branch_no)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<t_shd_recpay_flow_detail>()
                .Property(e => e.acc_type)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<t_shd_recpay_flow_detail>()
                .Property(e => e.ather_amt_f)
                .HasPrecision(16, 4);

            modelBuilder.Entity<t_shd_recpay_flow_detail>()
                .Property(e => e.oper_id)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<t_shd_sheet_detail>()
                .Property(e => e.flow_id)
                .HasPrecision(14, 0);

            modelBuilder.Entity<t_shd_sheet_detail>()
                .Property(e => e.sheet_no)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<t_shd_sheet_detail>()
                .Property(e => e.item_no)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<t_shd_sheet_detail>()
                .Property(e => e.orgi_price)
                .HasPrecision(16, 4);

            modelBuilder.Entity<t_shd_sheet_detail>()
                .Property(e => e.valid_price)
                .HasPrecision(16, 4);

            modelBuilder.Entity<t_shd_sheet_detail>()
                .Property(e => e.order_qty)
                .HasPrecision(16, 4);

            modelBuilder.Entity<t_shd_sheet_detail>()
                .Property(e => e.real_qty)
                .HasPrecision(16, 4);

            modelBuilder.Entity<t_shd_sheet_detail>()
                .Property(e => e.large_qty)
                .HasPrecision(16, 4);

            modelBuilder.Entity<t_shd_sheet_detail>()
                .Property(e => e.sub_amt)
                .HasPrecision(16, 4);

            modelBuilder.Entity<t_shd_sheet_detail>()
                .Property(e => e.tax)
                .HasPrecision(5, 4);

            modelBuilder.Entity<t_shd_sheet_detail>()
                .Property(e => e.cost_price)
                .HasPrecision(16, 4);

            modelBuilder.Entity<t_shd_sheet_detail>()
                .Property(e => e.send_qty)
                .HasPrecision(16, 4);

            modelBuilder.Entity<t_shd_sheet_detail>()
                .Property(e => e.sale_price)
                .HasPrecision(16, 4);

            modelBuilder.Entity<t_shd_sheet_detail>()
                .Property(e => e.memo)
                .IsUnicode(false);

            modelBuilder.Entity<t_shd_sheet_detail>()
                .Property(e => e.num1)
                .HasPrecision(16, 4);

            modelBuilder.Entity<t_shd_sheet_detail>()
                .Property(e => e.come_num)
                .HasPrecision(16, 4);

            modelBuilder.Entity<t_shd_sheet_detail>()
                .Property(e => e.memo1)
                .IsUnicode(false);

            modelBuilder.Entity<t_shd_sheet_detail>()
                .Property(e => e.del_day_num)
                .HasPrecision(16, 4);

            modelBuilder.Entity<t_shd_sheet_detail>()
                .Property(e => e.del_time)
                .IsUnicode(false);

            modelBuilder.Entity<t_shd_sheet_detail>()
                .Property(e => e.del_week)
                .IsUnicode(false);

            modelBuilder.Entity<t_shd_sheet_detail>()
                .Property(e => e.del_day_one)
                .IsUnicode(false);

            modelBuilder.Entity<t_shd_sheet_detail>()
                .Property(e => e.del_sum_num)
                .HasPrecision(16, 4);

            modelBuilder.Entity<t_shd_sheet_detail>()
                .Property(e => e.del_item_no)
                .HasPrecision(16, 4);

            modelBuilder.Entity<t_shd_sheet_detail>()
                .Property(e => e.del_flag)
                .IsUnicode(false);

            modelBuilder.Entity<t_shd_sheet_detail>()
                .Property(e => e.del_subno_flag)
                .IsUnicode(false);

            modelBuilder.Entity<t_shd_sheet_detail>()
                .Property(e => e.del_subno)
                .IsUnicode(false);

            modelBuilder.Entity<t_shd_sheet_detail>()
                .Property(e => e.stop_day)
                .IsUnicode(false);

            modelBuilder.Entity<t_shd_sheet_detail_detail>()
                .Property(e => e.flow_id)
                .HasPrecision(18, 0);

            modelBuilder.Entity<t_shd_sheet_detail_detail>()
                .Property(e => e.voucher_no)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<t_shd_sheet_detail_detail>()
                .Property(e => e.stop_day)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<t_shd_sheet_detail_detail>()
                .Property(e => e.oper_id)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<t_shd_sheet_detail_detail>()
                .Property(e => e.supcust_no)
                .IsUnicode(false);

            modelBuilder.Entity<t_shd_sheet_detail_detail>()
                .Property(e => e.memo)
                .IsUnicode(false);

            modelBuilder.Entity<t_shd_sheet_detail_detail>()
                .Property(e => e.com_flag)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<t_shd_sheet_detail_detail>()
                .Property(e => e.branch_no)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<t_shd_sheet_detail_detail>()
                .Property(e => e.item_no)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<t_shd_sheet_master>()
                .Property(e => e.sheet_no)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<t_shd_sheet_master>()
                .Property(e => e.trans_no)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<t_shd_sheet_master>()
                .Property(e => e.db_no)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<t_shd_sheet_master>()
                .Property(e => e.voucher_no)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<t_shd_sheet_master>()
                .Property(e => e.branch_no)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<t_shd_sheet_master>()
                .Property(e => e.supcust_no)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<t_shd_sheet_master>()
                .Property(e => e.pay_way)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<t_shd_sheet_master>()
                .Property(e => e.discount)
                .HasPrecision(5, 4);

            modelBuilder.Entity<t_shd_sheet_master>()
                .Property(e => e.coin_no)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<t_shd_sheet_master>()
                .Property(e => e.paid_amt)
                .HasPrecision(16, 4);

            modelBuilder.Entity<t_shd_sheet_master>()
                .Property(e => e.order_status)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<t_shd_sheet_master>()
                .Property(e => e.approve_flag)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<t_shd_sheet_master>()
                .Property(e => e.oper_id)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<t_shd_sheet_master>()
                .Property(e => e.order_man)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<t_shd_sheet_master>()
                .Property(e => e.confirm_man)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<t_shd_sheet_master>()
                .Property(e => e.trans_flag)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<t_shd_sheet_master>()
                .Property(e => e.acct_flag)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<t_shd_sheet_master>()
                .Property(e => e.sheet_amt)
                .HasPrecision(16, 4);

            modelBuilder.Entity<t_shd_sheet_master>()
                .Property(e => e.branch_flag)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<t_shd_sheet_master>()
                .Property(e => e.com_flag)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<t_shd_sheet_master>()
                .Property(e => e.memo)
                .IsUnicode(false);

            modelBuilder.Entity<t_shd_sheet_master>()
                .Property(e => e.modified_id)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<t_shd_sheet_master>()
                .Property(e => e.delivery_man)
                .IsUnicode(false);

            modelBuilder.Entity<t_shd_sheet_master>()
                .Property(e => e.change_flag)
                .IsUnicode(false);

            modelBuilder.Entity<t_shd_sheet_master>()
                .Property(e => e.is_sheet_khhd)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<t_sp_mark_detail>()
                .Property(e => e.flow_id)
                .HasPrecision(18, 0);

            modelBuilder.Entity<t_sp_mark_detail>()
                .Property(e => e.sheet_no)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<t_sp_mark_detail>()
                .Property(e => e.pf_code)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<t_sp_mark_detail>()
                .Property(e => e.pf_score)
                .HasPrecision(16, 4);

            modelBuilder.Entity<t_sp_mark_detail>()
                .Property(e => e.memo)
                .IsUnicode(false);

            modelBuilder.Entity<t_sp_mark_master>()
                .Property(e => e.sheet_no)
                .IsUnicode(false);

            modelBuilder.Entity<t_sp_mark_master>()
                .Property(e => e.branch_no)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<t_sp_mark_master>()
                .Property(e => e.trans_no)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<t_sp_mark_master>()
                .Property(e => e.order_man)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<t_sp_mark_master>()
                .Property(e => e.approve_flag)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<t_sp_mark_master>()
                .Property(e => e.oper_id)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<t_sp_mark_master>()
                .Property(e => e.confirm_man)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<t_sp_mark_master>()
                .Property(e => e.pf_total)
                .HasPrecision(16, 4);

            modelBuilder.Entity<t_sp_mark_master>()
                .Property(e => e.memo)
                .IsUnicode(false);

            modelBuilder.Entity<t_sp_mark_master>()
                .Property(e => e.num1)
                .HasPrecision(16, 4);

            modelBuilder.Entity<t_sp_mark_master>()
                .Property(e => e.num2)
                .HasPrecision(16, 4);

            modelBuilder.Entity<t_spid_operator>()
                .Property(e => e.oper_id)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<t_sys_attendance_info>()
                .Property(e => e.flow_id)
                .HasPrecision(9, 0);

            modelBuilder.Entity<t_sys_attendance_info>()
                .Property(e => e.branch_no)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<t_sys_attendance_info>()
                .Property(e => e.oper_id)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<t_sys_attendance_info>()
                .Property(e => e.shift_no)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<t_sys_attendance_info>()
                .Property(e => e.attd_bdate)
                .IsUnicode(false);

            modelBuilder.Entity<t_sys_attendance_info>()
                .Property(e => e.attd_edate)
                .IsUnicode(false);

            modelBuilder.Entity<t_sys_attendance_info>()
                .Property(e => e.pos_m_btime)
                .IsUnicode(false);

            modelBuilder.Entity<t_sys_attendance_info>()
                .Property(e => e.pos_m_etime)
                .IsUnicode(false);

            modelBuilder.Entity<t_sys_attendance_info>()
                .Property(e => e.spec_flag)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<t_sys_attendance_info>()
                .Property(e => e.spec_start_time)
                .IsUnicode(false);

            modelBuilder.Entity<t_sys_attendance_info>()
                .Property(e => e.spec_end_time)
                .IsUnicode(false);

            modelBuilder.Entity<t_sys_attendance_info>()
                .Property(e => e.spec_time)
                .IsUnicode(false);

            modelBuilder.Entity<t_sys_attendance_info>()
                .Property(e => e.com_flag)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<t_sys_attendance_spec>()
                .Property(e => e.flow_id)
                .HasPrecision(9, 0);

            modelBuilder.Entity<t_sys_attendance_spec>()
                .Property(e => e.branch_no)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<t_sys_attendance_spec>()
                .Property(e => e.oper_id)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<t_sys_attendance_spec>()
                .Property(e => e.attd_date)
                .IsUnicode(false);

            modelBuilder.Entity<t_sys_attendance_spec>()
                .Property(e => e.spec_flag)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<t_sys_attendance_spec>()
                .Property(e => e.spec_start_time)
                .IsUnicode(false);

            modelBuilder.Entity<t_sys_attendance_spec>()
                .Property(e => e.spec_end_time)
                .IsUnicode(false);

            modelBuilder.Entity<t_sys_attendance_spec>()
                .Property(e => e.spec_time)
                .IsUnicode(false);

            modelBuilder.Entity<t_sys_attendance_spec>()
                .Property(e => e.ch_auditflag)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<t_sys_attendance_spec>()
                .Property(e => e.ch_saveflag)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<t_sys_branch_connect_parm>()
                .Property(e => e.branch_no)
                .IsUnicode(false);

            modelBuilder.Entity<t_sys_branch_connect_parm>()
                .Property(e => e.server_name)
                .IsUnicode(false);

            modelBuilder.Entity<t_sys_branch_connect_parm>()
                .Property(e => e.database_name)
                .IsUnicode(false);

            modelBuilder.Entity<t_sys_branch_connect_parm>()
                .Property(e => e.port)
                .IsUnicode(false);

            modelBuilder.Entity<t_sys_branch_connect_parm>()
                .Property(e => e.com_flag)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<t_sys_branch_set>()
                .Property(e => e.branch_no)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<t_sys_branch_set>()
                .Property(e => e.var_id)
                .IsUnicode(false);

            modelBuilder.Entity<t_sys_branch_set>()
                .Property(e => e.var_name)
                .IsUnicode(false);

            modelBuilder.Entity<t_sys_branch_set>()
                .Property(e => e.var_value)
                .IsUnicode(false);

            modelBuilder.Entity<t_sys_branch_set>()
                .Property(e => e.var_desc)
                .IsUnicode(false);

            modelBuilder.Entity<t_sys_branch_set>()
                .Property(e => e.memo)
                .IsUnicode(false);

            modelBuilder.Entity<t_sys_branch_version>()
                .Property(e => e.branch_no)
                .IsUnicode(false);

            modelBuilder.Entity<t_sys_branch_version>()
                .Property(e => e.computer_name)
                .IsUnicode(false);

            modelBuilder.Entity<t_sys_branch_version>()
                .Property(e => e.version)
                .IsUnicode(false);

            modelBuilder.Entity<t_sys_cm_breakpoint>()
                .Property(e => e.branch_no)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<t_sys_cm_breakpoint>()
                .Property(e => e.com_table)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<t_sys_cm_breakpoint>()
                .Property(e => e.is_changed)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<t_sys_cm_breakpoint>()
                .Property(e => e.bk_sheetno)
                .IsUnicode(false);

            modelBuilder.Entity<t_sys_cm_breakpoint>()
                .Property(e => e.bk_date)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<t_sys_cm_breakpoint>()
                .Property(e => e.bk_flow)
                .HasPrecision(16, 0);

            modelBuilder.Entity<t_sys_cm_breakpoint>()
                .Property(e => e.bk_char)
                .IsUnicode(false);

            modelBuilder.Entity<t_sys_cm_breakpoint>()
                .Property(e => e.other1)
                .IsUnicode(false);

            modelBuilder.Entity<t_sys_cm_breakpoint>()
                .Property(e => e.other2)
                .IsUnicode(false);

            modelBuilder.Entity<t_sys_cm_breakpoint>()
                .Property(e => e.other3)
                .IsUnicode(false);

            modelBuilder.Entity<t_sys_cm_cmlog>()
                .Property(e => e.flow_id)
                .HasPrecision(14, 0);

            modelBuilder.Entity<t_sys_cm_cmlog>()
                .Property(e => e.branch_no)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<t_sys_cm_cmlog>()
                .Property(e => e.com_type)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<t_sys_cm_cmlog>()
                .Property(e => e.com_oper)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<t_sys_cm_cmlog>()
                .Property(e => e.flag)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<t_sys_cm_cmlog>()
                .Property(e => e.describe)
                .IsUnicode(false);

            modelBuilder.Entity<t_sys_cm_data>()
                .Property(e => e.com_no)
                .HasPrecision(16, 0);

            modelBuilder.Entity<t_sys_cm_data>()
                .Property(e => e.com_table)
                .IsUnicode(false);

            modelBuilder.Entity<t_sys_cm_data>()
                .Property(e => e.change_type)
                .IsUnicode(false);

            modelBuilder.Entity<t_sys_cm_data>()
                .Property(e => e.key1)
                .IsUnicode(false);

            modelBuilder.Entity<t_sys_cm_data>()
                .Property(e => e.key2)
                .IsUnicode(false);

            modelBuilder.Entity<t_sys_cm_data>()
                .Property(e => e.key3)
                .IsUnicode(false);

            modelBuilder.Entity<t_sys_cm_data>()
                .Property(e => e.key4)
                .IsUnicode(false);

            modelBuilder.Entity<t_sys_cm_data>()
                .Property(e => e.key5)
                .IsUnicode(false);

            modelBuilder.Entity<t_sys_cm_data>()
                .Property(e => e.key6)
                .IsUnicode(false);

            modelBuilder.Entity<t_sys_cm_data>()
                .Property(e => e.key7)
                .IsUnicode(false);

            modelBuilder.Entity<t_sys_cm_data>()
                .Property(e => e.branch_no)
                .IsUnicode(false);

            modelBuilder.Entity<t_sys_columns>()
                .Property(e => e.frm_id)
                .IsUnicode(false);

            modelBuilder.Entity<t_sys_columns>()
                .Property(e => e.oper_id)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<t_sys_columns>()
                .Property(e => e.frm_name)
                .IsUnicode(false);

            modelBuilder.Entity<t_sys_columns>()
                .Property(e => e.col_id)
                .IsUnicode(false);

            modelBuilder.Entity<t_sys_columns>()
                .Property(e => e.col_order)
                .IsUnicode(false);

            modelBuilder.Entity<t_sys_columns>()
                .Property(e => e.col_name)
                .IsUnicode(false);

            modelBuilder.Entity<t_sys_columns>()
                .Property(e => e.col_flag)
                .IsUnicode(false);

            modelBuilder.Entity<t_sys_columns>()
                .Property(e => e.col_format)
                .IsUnicode(false);

            modelBuilder.Entity<t_sys_columns>()
                .Property(e => e.col_defname)
                .IsUnicode(false);

            modelBuilder.Entity<t_sys_columns>()
                .Property(e => e.col_width)
                .IsUnicode(false);

            modelBuilder.Entity<t_sys_columns>()
                .Property(e => e.col_defwidth)
                .IsUnicode(false);

            modelBuilder.Entity<t_sys_columns>()
                .Property(e => e.col_visible)
                .IsUnicode(false);

            modelBuilder.Entity<t_sys_columns>()
                .Property(e => e.col_defvisible)
                .IsUnicode(false);

            modelBuilder.Entity<t_sys_columns>()
                .Property(e => e.col_print)
                .IsUnicode(false);

            modelBuilder.Entity<t_sys_customer>()
                .Property(e => e.name)
                .IsUnicode(false);

            modelBuilder.Entity<t_sys_customer>()
                .Property(e => e.branch_no)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<t_sys_customer>()
                .Property(e => e.man)
                .IsUnicode(false);

            modelBuilder.Entity<t_sys_customer>()
                .Property(e => e.address)
                .IsUnicode(false);

            modelBuilder.Entity<t_sys_customer>()
                .Property(e => e.zip)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<t_sys_customer>()
                .Property(e => e.email)
                .IsUnicode(false);

            modelBuilder.Entity<t_sys_customer>()
                .Property(e => e.tel)
                .IsUnicode(false);

            modelBuilder.Entity<t_sys_customer>()
                .Property(e => e.fax)
                .IsUnicode(false);

            modelBuilder.Entity<t_sys_customer>()
                .Property(e => e.acct_back)
                .IsUnicode(false);

            modelBuilder.Entity<t_sys_customer>()
                .Property(e => e.acct_no)
                .IsUnicode(false);

            modelBuilder.Entity<t_sys_customer>()
                .Property(e => e.tax_no)
                .IsUnicode(false);

            modelBuilder.Entity<t_sys_customize_report>()
                .Property(e => e.report_name)
                .IsUnicode(false);

            modelBuilder.Entity<t_sys_customize_report>()
                .Property(e => e.report_desc)
                .IsUnicode(false);

            modelBuilder.Entity<t_sys_customize_report>()
                .Property(e => e.report_code)
                .IsUnicode(false);

            modelBuilder.Entity<t_sys_customize_report>()
                .Property(e => e.report_type)
                .IsUnicode(false);

            modelBuilder.Entity<t_sys_customize_report>()
                .Property(e => e.create_oper)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<t_sys_customize_report>()
                .Property(e => e.shareable)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<t_sys_customize_report>()
                .Property(e => e.memo)
                .IsUnicode(false);

            modelBuilder.Entity<t_sys_data_grant>()
                .Property(e => e.oper_id)
                .IsUnicode(false);

            modelBuilder.Entity<t_sys_data_grant>()
                .Property(e => e.item_clsno)
                .IsUnicode(false);

            modelBuilder.Entity<t_sys_data_grant>()
                .Property(e => e.data_grant)
                .IsUnicode(false);

            modelBuilder.Entity<t_sys_data_grant>()
                .Property(e => e.other)
                .IsUnicode(false);

            modelBuilder.Entity<t_sys_data_grant>()
                .Property(e => e.grant_type)
                .IsUnicode(false);

            modelBuilder.Entity<t_sys_dept>()
                .Property(e => e.ch_deptno)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<t_sys_dept>()
                .Property(e => e.vch_deptname)
                .IsUnicode(false);

            modelBuilder.Entity<t_sys_emp>()
                .Property(e => e.vch_empno)
                .IsUnicode(false);

            modelBuilder.Entity<t_sys_emp>()
                .Property(e => e.vch_empname)
                .IsUnicode(false);

            modelBuilder.Entity<t_sys_emp>()
                .Property(e => e.ch_deptno)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<t_sys_emp>()
                .Property(e => e.branch_no)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<t_sys_emp>()
                .Property(e => e.vch_duty)
                .IsUnicode(false);

            modelBuilder.Entity<t_sys_emp>()
                .Property(e => e.vch_tel)
                .IsUnicode(false);

            modelBuilder.Entity<t_sys_emp>()
                .Property(e => e.ch_sex)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<t_sys_emp>()
                .Property(e => e.vch_id)
                .IsUnicode(false);

            modelBuilder.Entity<t_sys_emp>()
                .Property(e => e.vch_address)
                .IsUnicode(false);

            modelBuilder.Entity<t_sys_emp>()
                .Property(e => e.vch_idaddress)
                .IsUnicode(false);

            modelBuilder.Entity<t_sys_emp>()
                .Property(e => e.vch_email)
                .IsUnicode(false);

            modelBuilder.Entity<t_sys_emp>()
                .Property(e => e.contactman)
                .IsUnicode(false);

            modelBuilder.Entity<t_sys_emp>()
                .Property(e => e.contacttel)
                .IsUnicode(false);

            modelBuilder.Entity<t_sys_emp>()
                .Property(e => e.ch_state)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<t_sys_emp>()
                .Property(e => e.marriage_state)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<t_sys_emp>()
                .Property(e => e.favor)
                .IsUnicode(false);

            modelBuilder.Entity<t_sys_emp>()
                .Property(e => e.vch_memo)
                .IsUnicode(false);

            modelBuilder.Entity<t_sys_emp>()
                .Property(e => e.vch_operID)
                .IsUnicode(false);

            modelBuilder.Entity<t_sys_emp>()
                .Property(e => e.ch_waiterflag)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<t_sys_emp>()
                .Property(e => e.ch_saleflag)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<t_sys_emp>()
                .Property(e => e.ch_outflag)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<t_sys_emp>()
                .Property(e => e.ch_markflag)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<t_sys_emp>()
                .Property(e => e.ch_operflag)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<t_sys_emp>()
                .Property(e => e.vch_handtel)
                .IsUnicode(false);

            modelBuilder.Entity<t_sys_emp>()
                .Property(e => e.ch_storeflag)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<t_sys_emp>()
                .Property(e => e.ch_stockflag)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<t_sys_emp>()
                .Property(e => e.health_state)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<t_sys_emp_log>()
                .Property(e => e.vch_empno)
                .IsUnicode(false);

            modelBuilder.Entity<t_sys_emp_log>()
                .Property(e => e.vch_matter)
                .IsUnicode(false);

            modelBuilder.Entity<t_sys_emp_log>()
                .Property(e => e.vch_operID)
                .IsUnicode(false);

            modelBuilder.Entity<t_sys_item_refer>()
                .Property(e => e.item_no)
                .IsUnicode(false);

            modelBuilder.Entity<t_sys_item_refer>()
                .Property(e => e.item_name)
                .IsUnicode(false);

            modelBuilder.Entity<t_sys_item_refer>()
                .Property(e => e.item_supname)
                .IsUnicode(false);

            modelBuilder.Entity<t_sys_item_refer>()
                .Property(e => e.product_area)
                .IsUnicode(false);

            modelBuilder.Entity<t_sys_item_refer>()
                .Property(e => e.unit_no)
                .IsUnicode(false);

            modelBuilder.Entity<t_sys_item_refer>()
                .Property(e => e.item_size)
                .IsUnicode(false);

            modelBuilder.Entity<t_sys_item_refer>()
                .Property(e => e.zj_no)
                .IsUnicode(false);

            modelBuilder.Entity<t_sys_mailmsg_info>()
                .Property(e => e.flow_id)
                .HasPrecision(14, 0);

            modelBuilder.Entity<t_sys_mailmsg_info>()
                .Property(e => e.msg_from)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<t_sys_mailmsg_info>()
                .Property(e => e.msg_branch)
                .IsUnicode(false);

            modelBuilder.Entity<t_sys_mailmsg_info>()
                .Property(e => e.msg_oper)
                .IsUnicode(false);

            modelBuilder.Entity<t_sys_mailmsg_info>()
                .Property(e => e.msg_subject)
                .IsUnicode(false);

            modelBuilder.Entity<t_sys_mailmsg_info>()
                .Property(e => e.msg_detail)
                .IsUnicode(false);

            modelBuilder.Entity<t_sys_mailmsg_info>()
                .Property(e => e.msg_type)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<t_sys_mailmsg_info>()
                .Property(e => e.msg_flag)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<t_sys_mailmsg_info>()
                .Property(e => e.oper_id)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<t_sys_mailmsg_info>()
                .Property(e => e.com_flag)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<t_sys_mailmsg_log>()
                .Property(e => e.flow_id)
                .HasPrecision(14, 0);

            modelBuilder.Entity<t_sys_mailmsg_log>()
                .Property(e => e.msg_id)
                .HasPrecision(14, 0);

            modelBuilder.Entity<t_sys_mailmsg_log>()
                .Property(e => e.msg_flag)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<t_sys_mailmsg_log>()
                .Property(e => e.oper_id)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<t_sys_mailmsg_oper>()
                .Property(e => e.flow_id)
                .HasPrecision(14, 0);

            modelBuilder.Entity<t_sys_mailmsg_oper>()
                .Property(e => e.oper_id)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<t_sys_mailmsg_oper>()
                .Property(e => e.oper_type)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<t_sys_menu>()
                .Property(e => e.menu_id)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<t_sys_menu>()
                .Property(e => e.menu_name)
                .IsUnicode(false);

            modelBuilder.Entity<t_sys_menu>()
                .Property(e => e.menu_code)
                .IsUnicode(false);

            modelBuilder.Entity<t_sys_menu>()
                .Property(e => e.menu_type)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<t_sys_menu>()
                .Property(e => e.open_type)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<t_sys_menu>()
                .Property(e => e.open_parameter)
                .IsUnicode(false);

            modelBuilder.Entity<t_sys_menu>()
                .Property(e => e.branch_flag)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<t_sys_menu>()
                .Property(e => e.normal_flag)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<t_sys_menu>()
                .Property(e => e.flag1)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<t_sys_menu>()
                .Property(e => e.flag2)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<t_sys_menu>()
                .Property(e => e.flag3)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<t_sys_menu>()
                .Property(e => e.memo)
                .IsUnicode(false);

            modelBuilder.Entity<t_sys_menu>()
                .Property(e => e.net_flag)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<t_sys_menu>()
                .Property(e => e.net_menu_code)
                .IsUnicode(false);

            modelBuilder.Entity<t_sys_menu>()
                .Property(e => e.net_open_parameter)
                .IsUnicode(false);

            modelBuilder.Entity<t_sys_menu>()
                .Property(e => e.net_parent_mode)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<t_sys_menu_desktop>()
                .Property(e => e.menu_id)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<t_sys_menu_desktop>()
                .Property(e => e.menu_name)
                .IsUnicode(false);

            modelBuilder.Entity<t_sys_menu_desktop>()
                .Property(e => e.module_id)
                .IsUnicode(false);

            modelBuilder.Entity<t_sys_menu_desktop>()
                .Property(e => e.module_name)
                .IsUnicode(false);

            modelBuilder.Entity<t_sys_menu_desktop>()
                .Property(e => e.oper_id)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<t_sys_menu_grant>()
                .Property(e => e.func_id)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<t_sys_menu_grant>()
                .Property(e => e.grant0)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<t_sys_menu_grant>()
                .Property(e => e.grant1)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<t_sys_menu_grant>()
                .Property(e => e.grant2)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<t_sys_menu_grant>()
                .Property(e => e.grant3)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<t_sys_menu_grant>()
                .Property(e => e.grant4)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<t_sys_menu_grant>()
                .Property(e => e.grant5)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<t_sys_menu_grant>()
                .Property(e => e.other)
                .IsUnicode(false);

            modelBuilder.Entity<t_sys_menu_ver>()
                .Property(e => e.product_id)
                .IsUnicode(false);

            modelBuilder.Entity<t_sys_menu_ver>()
                .Property(e => e.menu_id)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<t_sys_menu_ver>()
                .Property(e => e.version_no)
                .IsUnicode(false);

            modelBuilder.Entity<t_sys_menu_ver>()
                .Property(e => e.memo)
                .IsUnicode(false);

            modelBuilder.Entity<t_sys_oper_data_grant>()
                .Property(e => e.oper_id)
                .IsUnicode(false);

            modelBuilder.Entity<t_sys_oper_data_grant>()
                .Property(e => e.item_no)
                .IsUnicode(false);

            modelBuilder.Entity<t_sys_oper_data_grant>()
                .Property(e => e.grant_type)
                .IsUnicode(false);

            modelBuilder.Entity<t_sys_oper_grant>()
                .Property(e => e.oper_id)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<t_sys_oper_grant>()
                .Property(e => e.func_id)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<t_sys_oper_grant>()
                .Property(e => e.grant0)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<t_sys_oper_grant>()
                .Property(e => e.grant1)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<t_sys_oper_grant>()
                .Property(e => e.grant2)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<t_sys_oper_grant>()
                .Property(e => e.grant3)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<t_sys_oper_grant>()
                .Property(e => e.grant4)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<t_sys_oper_grant>()
                .Property(e => e.grant5)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<t_sys_oper_grant>()
                .Property(e => e.grant6)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<t_sys_oper_grant>()
                .Property(e => e.grant7)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<t_sys_oper_grant>()
                .Property(e => e.grant8)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<t_sys_oper_grant>()
                .Property(e => e.grant9)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<t_sys_oper_grant>()
                .Property(e => e.other)
                .IsUnicode(false);

            modelBuilder.Entity<t_sys_operator>()
                .Property(e => e.oper_id)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<t_sys_operator>()
                .Property(e => e.oper_name)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<t_sys_operator>()
                .Property(e => e.oper_pw)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<t_sys_operator>()
                .Property(e => e.oper_status)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<t_sys_operator>()
                .Property(e => e.oper_type)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<t_sys_operator>()
                .Property(e => e.output_rate)
                .HasPrecision(3, 2);

            modelBuilder.Entity<t_sys_operator>()
                .Property(e => e.branch_no)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<t_sys_operator>()
                .Property(e => e.data_grant)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<t_sys_operator>()
                .Property(e => e.confirm_pw)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<t_sys_operator>()
                .Property(e => e.cash_grant)
                .IsUnicode(false);

            modelBuilder.Entity<t_sys_operator>()
                .Property(e => e.limit_discount)
                .HasPrecision(5, 4);

            modelBuilder.Entity<t_sys_operator>()
                .Property(e => e.save_discount)
                .HasPrecision(3, 2);

            modelBuilder.Entity<t_sys_operator>()
                .Property(e => e.contral_center)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<t_sys_operator>()
                .Property(e => e.price_grant)
                .IsUnicode(false);

            modelBuilder.Entity<t_sys_operator>()
                .Property(e => e.group_id)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<t_sys_operator>()
                .Property(e => e.oper_flag)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<t_sys_operator>()
                .Property(e => e.charge)
                .IsUnicode(false);

            modelBuilder.Entity<t_sys_operator>()
                .Property(e => e.area_manager)
                .IsUnicode(false);

            modelBuilder.Entity<t_sys_operator>()
                .Property(e => e.grant_type)
                .IsUnicode(false);

            modelBuilder.Entity<t_sys_operator>()
                .Property(e => e.is_hide_stock)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<t_sys_operator_breakpoint>()
                .Property(e => e.com_no)
                .HasPrecision(18, 0);

            modelBuilder.Entity<t_sys_operator_breakpoint>()
                .Property(e => e.change_type)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<t_sys_operator_breakpoint>()
                .Property(e => e.branch_no)
                .IsUnicode(false);

            modelBuilder.Entity<t_sys_operator_breakpoint>()
                .Property(e => e.oper_id)
                .IsUnicode(false);

            modelBuilder.Entity<t_sys_operator_log>()
                .Property(e => e.flow_id)
                .HasPrecision(20, 0);

            modelBuilder.Entity<t_sys_operator_log>()
                .Property(e => e.oper_id)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<t_sys_operator_log>()
                .Property(e => e.computer_name)
                .IsUnicode(false);

            modelBuilder.Entity<t_sys_operator_log>()
                .Property(e => e.trans_no)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<t_sys_operator_log>()
                .Property(e => e.description)
                .IsUnicode(false);

            modelBuilder.Entity<t_sys_operator_log>()
                .Property(e => e.memo)
                .IsUnicode(false);

            modelBuilder.Entity<t_sys_operator_log>()
                .Property(e => e.branch_no)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<t_sys_plukey>()
                .Property(e => e.branch_no)
                .IsUnicode(false);

            modelBuilder.Entity<t_sys_plukey>()
                .Property(e => e.item_no)
                .IsUnicode(false);

            modelBuilder.Entity<t_sys_plukey>()
                .Property(e => e.plu_key)
                .IsUnicode(false);

            modelBuilder.Entity<t_sys_plukey>()
                .Property(e => e.memo)
                .IsUnicode(false);

            modelBuilder.Entity<t_sys_pos_display>()
                .Property(e => e.branch_no)
                .IsUnicode(false);

            modelBuilder.Entity<t_sys_pos_display>()
                .Property(e => e.dev_name)
                .IsUnicode(false);

            modelBuilder.Entity<t_sys_pos_display>()
                .Property(e => e.port_type)
                .IsUnicode(false);

            modelBuilder.Entity<t_sys_pos_display>()
                .Property(e => e.baudrate)
                .HasPrecision(8, 0);

            modelBuilder.Entity<t_sys_pos_display>()
                .Property(e => e.parity)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<t_sys_pos_display>()
                .Property(e => e.disp_lang)
                .IsUnicode(false);

            modelBuilder.Entity<t_sys_pos_display>()
                .Property(e => e.init_cmd)
                .IsUnicode(false);

            modelBuilder.Entity<t_sys_pos_display>()
                .Property(e => e.disp_cmd_10)
                .IsUnicode(false);

            modelBuilder.Entity<t_sys_pos_display>()
                .Property(e => e.disp_cmd_11)
                .IsUnicode(false);

            modelBuilder.Entity<t_sys_pos_display>()
                .Property(e => e.disp_cmd_12)
                .IsUnicode(false);

            modelBuilder.Entity<t_sys_pos_display>()
                .Property(e => e.disp_cmd_20)
                .IsUnicode(false);

            modelBuilder.Entity<t_sys_pos_display>()
                .Property(e => e.disp_cmd_21)
                .IsUnicode(false);

            modelBuilder.Entity<t_sys_pos_display>()
                .Property(e => e.disp_cmd_22)
                .IsUnicode(false);

            modelBuilder.Entity<t_sys_pos_display>()
                .Property(e => e.disp_black)
                .IsUnicode(false);

            modelBuilder.Entity<t_sys_pos_display>()
                .Property(e => e.disp_price)
                .IsUnicode(false);

            modelBuilder.Entity<t_sys_pos_display>()
                .Property(e => e.disp_total)
                .IsUnicode(false);

            modelBuilder.Entity<t_sys_pos_display>()
                .Property(e => e.disp_paid)
                .IsUnicode(false);

            modelBuilder.Entity<t_sys_pos_display>()
                .Property(e => e.disp_chge)
                .IsUnicode(false);

            modelBuilder.Entity<t_sys_pos_display>()
                .Property(e => e.sound_cmd1)
                .IsUnicode(false);

            modelBuilder.Entity<t_sys_pos_display>()
                .Property(e => e.sound_cmd2)
                .IsUnicode(false);

            modelBuilder.Entity<t_sys_pos_display>()
                .Property(e => e.sound_cmd3)
                .IsUnicode(false);

            modelBuilder.Entity<t_sys_pos_downfile_status>()
                .Property(e => e.filename)
                .IsUnicode(false);

            modelBuilder.Entity<t_sys_pos_downfile_status>()
                .Property(e => e.posid)
                .IsUnicode(false);

            modelBuilder.Entity<t_sys_pos_downfile_status>()
                .Property(e => e.down_flag)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<t_sys_pos_printer>()
                .Property(e => e.branch_no)
                .IsUnicode(false);

            modelBuilder.Entity<t_sys_pos_printer>()
                .Property(e => e.dev_name)
                .IsUnicode(false);

            modelBuilder.Entity<t_sys_pos_printer>()
                .Property(e => e.port_type)
                .IsUnicode(false);

            modelBuilder.Entity<t_sys_pos_printer>()
                .Property(e => e.baudrate)
                .HasPrecision(8, 0);

            modelBuilder.Entity<t_sys_pos_printer>()
                .Property(e => e.parity)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<t_sys_pos_printer>()
                .Property(e => e.printer_hz)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<t_sys_pos_printer>()
                .Property(e => e.printer_init)
                .IsUnicode(false);

            modelBuilder.Entity<t_sys_pos_printer>()
                .Property(e => e.printer_big)
                .IsUnicode(false);

            modelBuilder.Entity<t_sys_pos_printer>()
                .Property(e => e.printer_cut)
                .IsUnicode(false);

            modelBuilder.Entity<t_sys_pos_status>()
                .Property(e => e.posid)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<t_sys_pos_status>()
                .Property(e => e.posdesc)
                .IsUnicode(false);

            modelBuilder.Entity<t_sys_pos_status>()
                .Property(e => e.hostip)
                .IsUnicode(false);

            modelBuilder.Entity<t_sys_pos_status>()
                .Property(e => e.hostname)
                .IsUnicode(false);

            modelBuilder.Entity<t_sys_pos_status>()
                .Property(e => e.operdate)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<t_sys_pos_status>()
                .Property(e => e.amount)
                .HasPrecision(16, 4);

            modelBuilder.Entity<t_sys_pos_status>()
                .Property(e => e.orderqty)
                .HasPrecision(6, 0);

            modelBuilder.Entity<t_sys_pos_status>()
                .Property(e => e.lastcashier)
                .IsUnicode(false);

            modelBuilder.Entity<t_sys_pos_status>()
                .Property(e => e.status)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<t_sys_pos_status>()
                .Property(e => e.other)
                .IsUnicode(false);

            modelBuilder.Entity<t_sys_pos_status>()
                .Property(e => e.com_flag)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<t_sys_query_conditionEx>()
                .Property(e => e.frm_id)
                .IsUnicode(false);

            modelBuilder.Entity<t_sys_query_conditionEx>()
                .Property(e => e.oper_id)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<t_sys_query_conditionEx>()
                .Property(e => e.col_name)
                .IsUnicode(false);

            modelBuilder.Entity<t_sys_query_conditionEx>()
                .Property(e => e.col_des)
                .IsUnicode(false);

            modelBuilder.Entity<t_sys_query_conditionEx>()
                .Property(e => e.col_type)
                .IsUnicode(false);

            modelBuilder.Entity<t_sys_query_conditionEx>()
                .Property(e => e.col_querysql)
                .IsUnicode(false);

            modelBuilder.Entity<t_sys_query_conditionEx>()
                .Property(e => e.table_name)
                .IsUnicode(false);

            modelBuilder.Entity<t_sys_query_conditionEx>()
                .Property(e => e.memo)
                .IsUnicode(false);

            modelBuilder.Entity<t_sys_reg>()
                .Property(e => e.flow_id)
                .HasPrecision(14, 0);

            modelBuilder.Entity<t_sys_reg>()
                .Property(e => e.var_id)
                .IsUnicode(false);

            modelBuilder.Entity<t_sys_reg>()
                .Property(e => e.var_value)
                .IsUnicode(false);

            modelBuilder.Entity<t_sys_reg>()
                .Property(e => e.branch_no)
                .IsUnicode(false);

            modelBuilder.Entity<t_sys_report>()
                .Property(e => e.report_name)
                .IsUnicode(false);

            modelBuilder.Entity<t_sys_report>()
                .Property(e => e.report_code)
                .IsUnicode(false);

            modelBuilder.Entity<t_sys_report>()
                .Property(e => e.report_module)
                .IsUnicode(false);

            modelBuilder.Entity<t_sys_report>()
                .Property(e => e.dw_type)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<t_sys_report>()
                .Property(e => e.modi_oper)
                .IsUnicode(false);

            modelBuilder.Entity<t_sys_report>()
                .Property(e => e.report_flag)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<t_sys_report>()
                .Property(e => e.detail_report)
                .IsUnicode(false);

            modelBuilder.Entity<t_sys_report>()
                .Property(e => e.dw_col)
                .IsUnicode(false);

            modelBuilder.Entity<t_sys_report>()
                .Property(e => e.gr_xcolumn)
                .IsUnicode(false);

            modelBuilder.Entity<t_sys_report>()
                .Property(e => e.gr_ycolumn)
                .IsUnicode(false);

            modelBuilder.Entity<t_sys_report>()
                .Property(e => e.query_condition)
                .IsUnicode(false);

            modelBuilder.Entity<t_sys_report>()
                .Property(e => e.display_condition)
                .IsUnicode(false);

            modelBuilder.Entity<t_sys_report>()
                .Property(e => e.query_day)
                .HasPrecision(3, 0);

            modelBuilder.Entity<t_sys_report>()
                .Property(e => e.compute_flag)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<t_sys_report>()
                .Property(e => e.multi_head)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<t_sys_report>()
                .Property(e => e.memo)
                .IsUnicode(false);

            modelBuilder.Entity<t_sys_report_import>()
                .Property(e => e.im_datetime)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<t_sys_report_import>()
                .Property(e => e.im_dwname)
                .IsUnicode(false);

            modelBuilder.Entity<t_sys_report_import>()
                .Property(e => e.im_model_id)
                .IsUnicode(false);

            modelBuilder.Entity<t_sys_report_import>()
                .Property(e => e.im_model_name)
                .IsUnicode(false);

            modelBuilder.Entity<t_sys_report_import>()
                .Property(e => e.im_submodel_id)
                .IsUnicode(false);

            modelBuilder.Entity<t_sys_report_import>()
                .Property(e => e.im_submodel_name)
                .IsUnicode(false);

            modelBuilder.Entity<t_sys_report_import>()
                .Property(e => e.im_menu_id)
                .IsUnicode(false);

            modelBuilder.Entity<t_sys_report_import>()
                .Property(e => e.im_menu_name)
                .IsUnicode(false);

            modelBuilder.Entity<t_sys_report_import>()
                .Property(e => e.im_flag)
                .IsUnicode(false);

            modelBuilder.Entity<t_sys_report_import>()
                .Property(e => e.im_value)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<t_sys_saving_grant>()
                .Property(e => e.branch_no)
                .IsUnicode(false);

            modelBuilder.Entity<t_sys_saving_grant>()
                .Property(e => e.grant_type)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<t_sys_saving_grant>()
                .Property(e => e.grant_amt)
                .HasPrecision(16, 4);

            modelBuilder.Entity<t_sys_sheet_detail_info>()
                .Property(e => e.main_name)
                .IsUnicode(false);

            modelBuilder.Entity<t_sys_sheet_detail_info>()
                .Property(e => e.template_name)
                .IsUnicode(false);

            modelBuilder.Entity<t_sys_sheet_detail_info>()
                .Property(e => e.dw_name)
                .IsUnicode(false);

            modelBuilder.Entity<t_sys_sheet_detail_info>()
                .Property(e => e.title_label)
                .IsUnicode(false);

            modelBuilder.Entity<t_sys_sheet_detail_info>()
                .Property(e => e.column_code)
                .IsUnicode(false);

            modelBuilder.Entity<t_sys_sheet_detail_info>()
                .Property(e => e.head_name)
                .IsUnicode(false);

            modelBuilder.Entity<t_sys_sheet_detail_info>()
                .Property(e => e.head_code)
                .IsUnicode(false);

            modelBuilder.Entity<t_sys_sheet_detail_info>()
                .Property(e => e.print_flag)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<t_sys_sheet_detail_info>()
                .Property(e => e.display_flag)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<t_sys_sheet_detail_info>()
                .Property(e => e.order_no)
                .HasPrecision(2, 0);

            modelBuilder.Entity<t_sys_sheet_detail_info>()
                .Property(e => e.masterdetail_flag)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<t_sys_sheet_detail_info>()
                .Property(e => e.modify_flag)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<t_sys_sheet_detail_info>()
                .Property(e => e.type_flag)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<t_sys_sheet_detail_info>()
                .Property(e => e.x)
                .IsUnicode(false);

            modelBuilder.Entity<t_sys_sheet_detail_info>()
                .Property(e => e.y)
                .IsUnicode(false);

            modelBuilder.Entity<t_sys_sheet_detail_info>()
                .Property(e => e.width)
                .IsUnicode(false);

            modelBuilder.Entity<t_sys_sheet_detail_info>()
                .Property(e => e.height)
                .IsUnicode(false);

            modelBuilder.Entity<t_sys_sheet_detail_info>()
                .Property(e => e.color)
                .IsUnicode(false);

            modelBuilder.Entity<t_sys_sheet_detail_info>()
                .Property(e => e.font)
                .IsUnicode(false);

            modelBuilder.Entity<t_sys_sheet_detail_info>()
                .Property(e => e.fontsize)
                .IsUnicode(false);

            modelBuilder.Entity<t_sys_sheet_detail_info>()
                .Property(e => e.other_property)
                .IsUnicode(false);

            modelBuilder.Entity<t_sys_sheet_detail_info>()
                .Property(e => e.oper_id)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<t_sys_sheet_master_info>()
                .Property(e => e.main_name)
                .IsUnicode(false);

            modelBuilder.Entity<t_sys_sheet_master_info>()
                .Property(e => e.template_name)
                .IsUnicode(false);

            modelBuilder.Entity<t_sys_sheet_master_info>()
                .Property(e => e.title_desc)
                .IsUnicode(false);

            modelBuilder.Entity<t_sys_sheet_master_info>()
                .Property(e => e.title_code)
                .IsUnicode(false);

            modelBuilder.Entity<t_sys_sheet_master_info>()
                .Property(e => e.title_text)
                .IsUnicode(false);

            modelBuilder.Entity<t_sys_sheet_master_info>()
                .Property(e => e.print_flag)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<t_sys_sheet_master_info>()
                .Property(e => e.display_flag)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<t_sys_sheet_master_info>()
                .Property(e => e.headfooter_flag)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<t_sys_sheet_master_info>()
                .Property(e => e.type_flag)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<t_sys_sheet_master_info>()
                .Property(e => e.other_property)
                .IsUnicode(false);

            modelBuilder.Entity<t_sys_sheet_master_info>()
                .Property(e => e.oper_id)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<t_sys_sheet_no>()
                .Property(e => e.sheet_id)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<t_sys_sheet_no>()
                .Property(e => e.trans_type)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<t_sys_sheet_no>()
                .Property(e => e.sheet_name)
                .IsUnicode(false);

            modelBuilder.Entity<t_sys_sheet_no>()
                .Property(e => e.in_flag)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<t_sys_sheet_no>()
                .Property(e => e.sheet_value)
                .HasPrecision(4, 0);

            modelBuilder.Entity<t_sys_sheet_no>()
                .Property(e => e.sheet_type)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<t_sys_sheet_no>()
                .Property(e => e.sheet_flag)
                .IsUnicode(false);

            modelBuilder.Entity<t_sys_sheet_no>()
                .Property(e => e.dw_code)
                .IsUnicode(false);

            modelBuilder.Entity<t_sys_sheet_no>()
                .Property(e => e.approve_flag)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<t_sys_sheet_no>()
                .Property(e => e.w_code)
                .IsUnicode(false);

            modelBuilder.Entity<t_sys_sheet_no>()
                .Property(e => e.parm)
                .IsUnicode(false);

            modelBuilder.Entity<t_sys_sheet_no>()
                .Property(e => e.master_dwo)
                .IsUnicode(false);

            modelBuilder.Entity<t_sys_sheet_no>()
                .Property(e => e.detail_dwo)
                .IsUnicode(false);

            modelBuilder.Entity<t_sys_sheet_no>()
                .Property(e => e.current_temp)
                .IsUnicode(false);

            modelBuilder.Entity<t_sys_sheet_no>()
                .Property(e => e.default_price1)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<t_sys_sheet_no>()
                .Property(e => e.default_price2)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<t_sys_sheet_no>()
                .Property(e => e.modify_price)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<t_sys_sheet_no>()
                .Property(e => e.up_rate)
                .HasPrecision(6, 4);

            modelBuilder.Entity<t_sys_sheet_no>()
                .Property(e => e.dn_rate)
                .HasPrecision(6, 4);

            modelBuilder.Entity<t_sys_sheet_no>()
                .Property(e => e.change_cost)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<t_sys_sheet_paper_size>()
                .Property(e => e.frm_id)
                .IsUnicode(false);

            modelBuilder.Entity<t_sys_sheet_paper_size>()
                .Property(e => e.oper_id)
                .IsUnicode(false);

            modelBuilder.Entity<t_sys_sheet_paper_size>()
                .Property(e => e.paper_name)
                .IsUnicode(false);

            modelBuilder.Entity<t_sys_sheet_paper_size>()
                .Property(e => e.paper_width)
                .HasPrecision(16, 2);

            modelBuilder.Entity<t_sys_sheet_paper_size>()
                .Property(e => e.paper_height)
                .HasPrecision(16, 2);

            modelBuilder.Entity<t_sys_sheet_paper_size>()
                .Property(e => e.paper_top)
                .HasPrecision(16, 2);

            modelBuilder.Entity<t_sys_sheet_paper_size>()
                .Property(e => e.paper_left)
                .HasPrecision(16, 2);

            modelBuilder.Entity<t_sys_sheet_paper_size>()
                .Property(e => e.paper_bottom)
                .HasPrecision(16, 2);

            modelBuilder.Entity<t_sys_sheet_paper_size>()
                .Property(e => e.paper_right)
                .HasPrecision(16, 2);

            modelBuilder.Entity<t_sys_sheet_paper_size>()
                .Property(e => e.memo)
                .IsUnicode(false);

            modelBuilder.Entity<t_sys_sheetno_flow>()
                .Property(e => e.sheet_id)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<t_sys_sheetno_flow>()
                .Property(e => e.branch_no)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<t_sys_sheetno_flow>()
                .Property(e => e.sheet_value)
                .HasPrecision(4, 0);

            modelBuilder.Entity<t_sys_sheetno_flow>()
                .Property(e => e.temp_value)
                .HasPrecision(4, 0);

            modelBuilder.Entity<t_sys_sheetno_flow>()
                .Property(e => e.other1)
                .IsUnicode(false);

            modelBuilder.Entity<t_sys_system>()
                .Property(e => e.sys_var_id)
                .IsUnicode(false);

            modelBuilder.Entity<t_sys_system>()
                .Property(e => e.sys_var_name)
                .IsUnicode(false);

            modelBuilder.Entity<t_sys_system>()
                .Property(e => e.sys_var_value)
                .IsUnicode(false);

            modelBuilder.Entity<t_sys_system>()
                .Property(e => e.is_changed)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<t_sys_system>()
                .Property(e => e.sys_var_desc)
                .IsUnicode(false);

            modelBuilder.Entity<t_sys_system>()
                .Property(e => e.sys_ver_flag)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<t_sys_system>()
                .Property(e => e.sys_inited)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<t_sys_system>()
                .Property(e => e.memo)
                .IsUnicode(false);

            modelBuilder.Entity<t_sys_system>()
                .Property(e => e.branch_no)
                .IsUnicode(false);

            modelBuilder.Entity<t_sys_system>()
                .Property(e => e.oper_id)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<t_sys_system_mean>()
                .Property(e => e.flow_id)
                .HasPrecision(14, 0);

            modelBuilder.Entity<t_sys_system_mean>()
                .Property(e => e.menu_name)
                .IsUnicode(false);

            modelBuilder.Entity<t_sys_system_mean>()
                .Property(e => e.control_name)
                .IsUnicode(false);

            modelBuilder.Entity<t_sys_system_mean>()
                .Property(e => e.control_ename)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<t_sys_system_mean>()
                .Property(e => e.default_value)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<t_sys_system_mean>()
                .Property(e => e.modify_value)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<t_sys_system_mean>()
                .Property(e => e.oper_id)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<t_sys_system_mean>()
                .Property(e => e.branch_no)
                .IsUnicode(false);

            modelBuilder.Entity<t_sys_system_mean>()
                .Property(e => e.other)
                .IsUnicode(false);

            modelBuilder.Entity<t_sys_template_sheet_std>()
                .Property(e => e.main_name)
                .IsUnicode(false);

            modelBuilder.Entity<t_sys_template_sheet_std>()
                .Property(e => e.obj_name)
                .IsUnicode(false);

            modelBuilder.Entity<t_sys_updown_rdlfile>()
                .Property(e => e.oper_id)
                .IsFixedLength();

            modelBuilder.Entity<t_sys_updown_rdlfile>()
                .Property(e => e.modi_id)
                .IsFixedLength();

            modelBuilder.Entity<t_sys_zjm>()
                .Property(e => e.zjm_id)
                .HasPrecision(18, 0);

            modelBuilder.Entity<t_sys_zjm>()
                .Property(e => e.z)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<t_sys_zjm>()
                .Property(e => e.n)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<t_sys_zjm>()
                .Property(e => e.wb)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<t_sys_zjm>()
                .Property(e => e.bpy)
                .IsUnicode(false);

            modelBuilder.Entity<t_sys_zjm>()
                .Property(e => e.ss)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<t_sys_zjm>()
                .Property(e => e.j1)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<t_sys_zjm>()
                .Property(e => e.j2)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<t_sys_zjm>()
                .Property(e => e.wbh)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<t_vip_sheet_detail>()
                .Property(e => e.flow_id)
                .HasPrecision(14, 0);

            modelBuilder.Entity<t_vip_sheet_detail>()
                .Property(e => e.sheet_no)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<t_vip_sheet_detail>()
                .Property(e => e.item_no)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<t_vip_sheet_detail>()
                .Property(e => e.orgi_price)
                .HasPrecision(16, 4);

            modelBuilder.Entity<t_vip_sheet_detail>()
                .Property(e => e.valid_price)
                .HasPrecision(16, 4);

            modelBuilder.Entity<t_vip_sheet_detail>()
                .Property(e => e.order_qty)
                .HasPrecision(16, 4);

            modelBuilder.Entity<t_vip_sheet_detail>()
                .Property(e => e.real_qty)
                .HasPrecision(16, 4);

            modelBuilder.Entity<t_vip_sheet_detail>()
                .Property(e => e.large_qty)
                .HasPrecision(16, 4);

            modelBuilder.Entity<t_vip_sheet_detail>()
                .Property(e => e.sub_amt)
                .HasPrecision(16, 4);

            modelBuilder.Entity<t_vip_sheet_detail>()
                .Property(e => e.tax)
                .HasPrecision(5, 4);

            modelBuilder.Entity<t_vip_sheet_detail>()
                .Property(e => e.cost_price)
                .HasPrecision(16, 4);

            modelBuilder.Entity<t_vip_sheet_detail>()
                .Property(e => e.send_qty)
                .HasPrecision(16, 4);

            modelBuilder.Entity<t_vip_sheet_detail>()
                .Property(e => e.sale_price)
                .HasPrecision(16, 4);

            modelBuilder.Entity<t_vip_sheet_detail>()
                .Property(e => e.memo)
                .IsUnicode(false);

            modelBuilder.Entity<t_vip_sheet_detail>()
                .Property(e => e.come_num)
                .HasPrecision(16, 4);

            modelBuilder.Entity<t_vip_sheet_master>()
                .Property(e => e.sheet_no)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<t_vip_sheet_master>()
                .Property(e => e.trans_no)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<t_vip_sheet_master>()
                .Property(e => e.db_no)
                .IsUnicode(false);

            modelBuilder.Entity<t_vip_sheet_master>()
                .Property(e => e.voucher_no)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<t_vip_sheet_master>()
                .Property(e => e.branch_no)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<t_vip_sheet_master>()
                .Property(e => e.supcust_no)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<t_vip_sheet_master>()
                .Property(e => e.pay_way)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<t_vip_sheet_master>()
                .Property(e => e.discount)
                .HasPrecision(5, 4);

            modelBuilder.Entity<t_vip_sheet_master>()
                .Property(e => e.coin_no)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<t_vip_sheet_master>()
                .Property(e => e.paid_amt)
                .HasPrecision(16, 4);

            modelBuilder.Entity<t_vip_sheet_master>()
                .Property(e => e.order_status)
                .IsUnicode(false);

            modelBuilder.Entity<t_vip_sheet_master>()
                .Property(e => e.approve_flag)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<t_vip_sheet_master>()
                .Property(e => e.oper_id)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<t_vip_sheet_master>()
                .Property(e => e.order_man)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<t_vip_sheet_master>()
                .Property(e => e.confirm_man)
                .IsUnicode(false);

            modelBuilder.Entity<t_vip_sheet_master>()
                .Property(e => e.trans_flag)
                .IsUnicode(false);

            modelBuilder.Entity<t_vip_sheet_master>()
                .Property(e => e.acct_flag)
                .IsUnicode(false);

            modelBuilder.Entity<t_vip_sheet_master>()
                .Property(e => e.sheet_amt)
                .HasPrecision(16, 4);

            modelBuilder.Entity<t_vip_sheet_master>()
                .Property(e => e.acc_num)
                .HasPrecision(11, 2);

            modelBuilder.Entity<t_vip_sheet_master>()
                .Property(e => e.branch_flag)
                .IsUnicode(false);

            modelBuilder.Entity<t_vip_sheet_master>()
                .Property(e => e.com_flag)
                .IsUnicode(false);

            modelBuilder.Entity<t_vip_sheet_master>()
                .Property(e => e.memo)
                .IsUnicode(false);

            modelBuilder.Entity<t_vip_sheet_master>()
                .Property(e => e.modified_id)
                .IsUnicode(false);

            modelBuilder.Entity<t_vip_sheet_master>()
                .Property(e => e.delivery_man)
                .IsUnicode(false);

            modelBuilder.Entity<t_vip_sheet_master>()
                .Property(e => e.card_no)
                .IsUnicode(false);

            modelBuilder.Entity<t_vip_sheet_master>()
                .Property(e => e.vip_name)
                .IsUnicode(false);

            modelBuilder.Entity<t_vip_sheet_master>()
                .Property(e => e.card_id)
                .IsUnicode(false);

            modelBuilder.Entity<t_vip_sheet_master>()
                .Property(e => e.vip_mobile)
                .IsUnicode(false);

            modelBuilder.Entity<t_vip_sheet_master>()
                .Property(e => e.vip_tel)
                .IsUnicode(false);

            modelBuilder.Entity<t_vip_sheet_master>()
                .Property(e => e.vip_add)
                .IsUnicode(false);

            modelBuilder.Entity<t_vip_sheet_master>()
                .Property(e => e.vip_jf)
                .HasPrecision(10, 2);

            modelBuilder.Entity<t_wm_return_detail>()
                .Property(e => e.sheet_no)
                .IsUnicode(false);

            modelBuilder.Entity<t_wm_return_detail>()
                .Property(e => e.branch_no)
                .IsUnicode(false);

            modelBuilder.Entity<t_wm_return_detail>()
                .Property(e => e.supcust_no)
                .IsUnicode(false);

            modelBuilder.Entity<t_wm_return_detail>()
                .Property(e => e.return_je)
                .HasPrecision(18, 4);

            modelBuilder.Entity<t_wm_return_detail>()
                .Property(e => e.used_je)
                .HasPrecision(18, 4);

            modelBuilder.Entity<t_wm_return_detail>()
                .Property(e => e.rest_je)
                .HasPrecision(18, 4);

            modelBuilder.Entity<t_wm_return_detail>()
                .Property(e => e.note)
                .IsUnicode(false);

            modelBuilder.Entity<t_wm_return_profit>()
                .Property(e => e.flow_id)
                .HasPrecision(14, 0);

            modelBuilder.Entity<t_wm_return_profit>()
                .Property(e => e.start_je)
                .HasPrecision(18, 4);

            modelBuilder.Entity<t_wm_return_profit>()
                .Property(e => e.end_je)
                .HasPrecision(18, 4);

            modelBuilder.Entity<t_wm_return_profit>()
                .Property(e => e.return_je)
                .HasPrecision(18, 4);

            modelBuilder.Entity<t_wm_return_profit>()
                .Property(e => e.note)
                .IsUnicode(false);

            modelBuilder.Entity<t_wm_sheet_detail>()
                .Property(e => e.flow_id)
                .HasPrecision(14, 0);

            modelBuilder.Entity<t_wm_sheet_detail>()
                .Property(e => e.sheet_no)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<t_wm_sheet_detail>()
                .Property(e => e.item_no)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<t_wm_sheet_detail>()
                .Property(e => e.orgi_price)
                .HasPrecision(16, 4);

            modelBuilder.Entity<t_wm_sheet_detail>()
                .Property(e => e.valid_price)
                .HasPrecision(16, 4);

            modelBuilder.Entity<t_wm_sheet_detail>()
                .Property(e => e.order_qty)
                .HasPrecision(16, 4);

            modelBuilder.Entity<t_wm_sheet_detail>()
                .Property(e => e.real_qty)
                .HasPrecision(16, 4);

            modelBuilder.Entity<t_wm_sheet_detail>()
                .Property(e => e.large_qty)
                .HasPrecision(16, 4);

            modelBuilder.Entity<t_wm_sheet_detail>()
                .Property(e => e.sub_amt)
                .HasPrecision(16, 4);

            modelBuilder.Entity<t_wm_sheet_detail>()
                .Property(e => e.tax)
                .HasPrecision(5, 4);

            modelBuilder.Entity<t_wm_sheet_detail>()
                .Property(e => e.cost_price)
                .HasPrecision(16, 4);

            modelBuilder.Entity<t_wm_sheet_detail>()
                .Property(e => e.send_qty)
                .HasPrecision(16, 4);

            modelBuilder.Entity<t_wm_sheet_detail>()
                .Property(e => e.sale_price)
                .HasPrecision(16, 4);

            modelBuilder.Entity<t_wm_sheet_detail>()
                .Property(e => e.memo)
                .IsUnicode(false);

            modelBuilder.Entity<t_wm_sheet_detail>()
                .Property(e => e.num1)
                .HasPrecision(16, 4);

            modelBuilder.Entity<t_wm_sheet_detail>()
                .Property(e => e.come_num)
                .HasPrecision(16, 4);

            modelBuilder.Entity<t_wm_sheet_detail>()
                .Property(e => e.memo1)
                .IsUnicode(false);

            modelBuilder.Entity<t_wm_sheet_master>()
                .Property(e => e.sheet_no)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<t_wm_sheet_master>()
                .Property(e => e.trans_no)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<t_wm_sheet_master>()
                .Property(e => e.db_no)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<t_wm_sheet_master>()
                .Property(e => e.voucher_no)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<t_wm_sheet_master>()
                .Property(e => e.branch_no)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<t_wm_sheet_master>()
                .Property(e => e.supcust_no)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<t_wm_sheet_master>()
                .Property(e => e.pay_way)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<t_wm_sheet_master>()
                .Property(e => e.discount)
                .HasPrecision(5, 4);

            modelBuilder.Entity<t_wm_sheet_master>()
                .Property(e => e.coin_no)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<t_wm_sheet_master>()
                .Property(e => e.paid_amt)
                .HasPrecision(16, 4);

            modelBuilder.Entity<t_wm_sheet_master>()
                .Property(e => e.order_status)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<t_wm_sheet_master>()
                .Property(e => e.approve_flag)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<t_wm_sheet_master>()
                .Property(e => e.oper_id)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<t_wm_sheet_master>()
                .Property(e => e.order_man)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<t_wm_sheet_master>()
                .Property(e => e.confirm_man)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<t_wm_sheet_master>()
                .Property(e => e.trans_flag)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<t_wm_sheet_master>()
                .Property(e => e.acct_flag)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<t_wm_sheet_master>()
                .Property(e => e.sheet_amt)
                .HasPrecision(16, 4);

            modelBuilder.Entity<t_wm_sheet_master>()
                .Property(e => e.branch_flag)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<t_wm_sheet_master>()
                .Property(e => e.com_flag)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<t_wm_sheet_master>()
                .Property(e => e.memo)
                .IsUnicode(false);

            modelBuilder.Entity<t_wm_sheet_master>()
                .Property(e => e.modified_id)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<t_wm_sheet_master>()
                .Property(e => e.sale_way)
                .IsUnicode(false);

            modelBuilder.Entity<t_wm_sheet_master>()
                .Property(e => e.total_money)
                .HasPrecision(16, 4);

            modelBuilder.Entity<t_wm_sheet_master>()
                .Property(e => e.sheet_dct)
                .IsUnicode(false);

            modelBuilder.Entity<t_wx_promotion>()
                .Property(e => e.descinfo)
                .IsUnicode(false);

            modelBuilder.Entity<t_wx_promotion>()
                .Property(e => e.shelf_status)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<t_wx_promotion>()
                .Property(e => e.branch_no)
                .IsUnicode(false);

            modelBuilder.Entity<t_wx_promotion>()
                .Property(e => e.shop_id)
                .IsUnicode(false);

            modelBuilder.Entity<t_wx_promotion>()
                .Property(e => e.pic_flag)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<t_wx_promotion>()
                .Property(e => e.pic_name)
                .IsUnicode(false);

            modelBuilder.Entity<t_wx_promotion>()
                .Property(e => e.net_flow)
                .HasPrecision(18, 0);

            modelBuilder.Entity<t_wx_shop_info>()
                .Property(e => e.shop_no)
                .IsUnicode(false);

            modelBuilder.Entity<t_wx_shop_info>()
                .Property(e => e.province)
                .IsUnicode(false);

            modelBuilder.Entity<t_wx_shop_info>()
                .Property(e => e.city)
                .IsUnicode(false);

            modelBuilder.Entity<t_wx_shop_info>()
                .Property(e => e.shop_name)
                .IsUnicode(false);

            modelBuilder.Entity<t_wx_shop_info>()
                .Property(e => e.shop_address)
                .IsUnicode(false);

            modelBuilder.Entity<t_wx_shop_info>()
                .Property(e => e.shop_contacts)
                .IsUnicode(false);

            modelBuilder.Entity<t_wx_shop_info>()
                .Property(e => e.shop_tel)
                .IsUnicode(false);

            modelBuilder.Entity<t_wx_shop_info>()
                .Property(e => e.shop_mobile)
                .IsUnicode(false);

            modelBuilder.Entity<t_wx_shop_info>()
                .Property(e => e.shop_qq)
                .IsUnicode(false);

            modelBuilder.Entity<t_wx_shop_info>()
                .Property(e => e.shop_email)
                .IsUnicode(false);

            modelBuilder.Entity<t_wx_vip_bindflow>()
                .Property(e => e.flow_id)
                .HasPrecision(16, 0);

            modelBuilder.Entity<t_wx_vip_bindflow>()
                .Property(e => e.card_id)
                .IsUnicode(false);

            modelBuilder.Entity<t_wx_vip_bindflow>()
                .Property(e => e.openid)
                .IsUnicode(false);

            modelBuilder.Entity<t_wx_vip_bindflow>()
                .Property(e => e.shopid)
                .IsUnicode(false);

            modelBuilder.Entity<t_wx_vip_bindflow>()
                .Property(e => e.bindtype)
                .IsUnicode(false);

            modelBuilder.Entity<t_wx_vip_bindflow>()
                .Property(e => e.wx_flow_id)
                .HasPrecision(16, 0);

            modelBuilder.Entity<t_wx_vip_info>()
                .Property(e => e.card_id)
                .IsUnicode(false);

            modelBuilder.Entity<t_wx_vip_info>()
                .Property(e => e.card_type)
                .IsUnicode(false);

            modelBuilder.Entity<t_wx_vip_info>()
                .Property(e => e.vip_name)
                .IsUnicode(false);

            modelBuilder.Entity<t_wx_vip_info>()
                .Property(e => e.vip_sex)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<t_wx_vip_info>()
                .Property(e => e.card_status)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<t_wx_vip_info>()
                .Property(e => e.vip_pass)
                .IsUnicode(false);

            modelBuilder.Entity<t_wx_vip_info>()
                .Property(e => e.acc_num)
                .HasPrecision(16, 4);

            modelBuilder.Entity<t_wx_vip_info>()
                .Property(e => e.dec_num)
                .HasPrecision(16, 4);

            modelBuilder.Entity<t_wx_vip_info>()
                .Property(e => e.openid)
                .IsUnicode(false);

            modelBuilder.Entity<t_wx_vip_info>()
                .Property(e => e.shopid)
                .IsUnicode(false);

            modelBuilder.Entity<t_wx_vip_info>()
                .Property(e => e.branch_no)
                .IsUnicode(false);

            modelBuilder.Entity<t_wx_vip_info>()
                .Property(e => e.deal_flag)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<t_wx_vip_info>()
                .Property(e => e.memo)
                .IsUnicode(false);

            modelBuilder.Entity<t_wx_vip_info>()
                .Property(e => e.mobile)
                .IsUnicode(false);

            modelBuilder.Entity<t_wx_vip_info>()
                .Property(e => e.email)
                .IsUnicode(false);

            modelBuilder.Entity<t_wx_vip_info>()
                .Property(e => e.favourableinfo)
                .IsUnicode(false);

            modelBuilder.Entity<pbcatedt>()
                .Property(e => e.pbe_name)
                .IsUnicode(false);

            modelBuilder.Entity<pbcatedt>()
                .Property(e => e.pbe_edit)
                .IsUnicode(false);

            modelBuilder.Entity<pbcatedt>()
                .Property(e => e.pbe_work)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<pbcatfmt>()
                .Property(e => e.pbf_name)
                .IsUnicode(false);

            modelBuilder.Entity<pbcatfmt>()
                .Property(e => e.pbf_frmt)
                .IsUnicode(false);

            modelBuilder.Entity<pbcatvld>()
                .Property(e => e.pbv_name)
                .IsUnicode(false);

            modelBuilder.Entity<pbcatvld>()
                .Property(e => e.pbv_vald)
                .IsUnicode(false);

            modelBuilder.Entity<pbcatvld>()
                .Property(e => e.pbv_msg)
                .IsUnicode(false);

            modelBuilder.Entity<t_im_checkrecord_detail>()
                .Property(e => e.flow_id)
                .HasPrecision(18, 0);

            modelBuilder.Entity<t_im_checkrecord_detail>()
                .Property(e => e.sheet_no)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<t_im_checkrecord_detail>()
                .Property(e => e.item_no)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<t_im_checkrecord_detail>()
                .Property(e => e.c_qty)
                .HasPrecision(16, 4);

            modelBuilder.Entity<t_im_checkrecord_detail>()
                .Property(e => e.f_qty)
                .HasPrecision(16, 4);

            modelBuilder.Entity<t_im_checkrecord_detail>()
                .Property(e => e.m_qty)
                .HasPrecision(16, 4);

            modelBuilder.Entity<t_im_checkrecord_master>()
                .Property(e => e.sheet_no)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<t_im_checkrecord_master>()
                .Property(e => e.branch_no)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<t_im_checkrecord_master>()
                .Property(e => e.shelf_no)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<t_im_checkrecord_master>()
                .Property(e => e.check_id)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<t_im_checkrecord_master>()
                .Property(e => e.oper_id)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<t_im_checkrecord_master>()
                .Property(e => e.approve_flag)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<t_im_checkrecord_master>()
                .Property(e => e.memo)
                .IsUnicode(false);

            modelBuilder.Entity<t_im_checkrecord_master>()
                .Property(e => e.num2)
                .HasPrecision(16, 4);

            modelBuilder.Entity<t_return_plan_detail_d>()
                .Property(e => e.plan_id)
                .HasPrecision(14, 0);

            modelBuilder.Entity<t_return_plan_detail_d>()
                .Property(e => e.plan_no)
                .IsUnicode(false);

            modelBuilder.Entity<t_return_plan_detail_d>()
                .Property(e => e.royalty_setup)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<t_return_plan_detail_d>()
                .Property(e => e.num_flag)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<t_return_plan_detail_d>()
                .Property(e => e.amount_flag)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<t_return_plan_detail_d>()
                .Property(e => e.rate_flag)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<t_return_plan_detail_d>()
                .Property(e => e.num_begin)
                .HasPrecision(16, 2);

            modelBuilder.Entity<t_return_plan_detail_d>()
                .Property(e => e.num_end)
                .HasPrecision(16, 2);

            modelBuilder.Entity<t_return_plan_detail_d>()
                .Property(e => e.amount_begin)
                .HasPrecision(16, 2);

            modelBuilder.Entity<t_return_plan_detail_d>()
                .Property(e => e.amount_end)
                .HasPrecision(16, 2);

            modelBuilder.Entity<t_return_plan_detail_d>()
                .Property(e => e.rate_begin)
                .HasPrecision(16, 2);

            modelBuilder.Entity<t_return_plan_detail_d>()
                .Property(e => e.rate_end)
                .HasPrecision(16, 2);

            modelBuilder.Entity<t_return_plan_detail_d>()
                .Property(e => e.royalty_flag)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<t_return_plan_detail_d>()
                .Property(e => e.ret_rate)
                .HasPrecision(10, 2);

            modelBuilder.Entity<t_return_plan_detail_d>()
                .Property(e => e.ret_amt)
                .HasPrecision(10, 2);

            modelBuilder.Entity<t_rm_vip_good_log>()
                .Property(e => e.vg_no)
                .IsUnicode(false);

            modelBuilder.Entity<t_rm_vip_good_log>()
                .Property(e => e.vg_vip_num)
                .HasPrecision(18, 4);

            modelBuilder.Entity<t_rm_vip_good_log>()
                .Property(e => e.vg_branch_no)
                .IsUnicode(false);

            modelBuilder.Entity<t_rm_vip_good_log>()
                .Property(e => e.memo)
                .IsUnicode(false);

            modelBuilder.Entity<t_sheet_print_errlog>()
                .Property(e => e.oper_id)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<t_sheet_print_errlog>()
                .Property(e => e.computer_name)
                .IsUnicode(false);

            modelBuilder.Entity<t_sheet_print_errlog>()
                .Property(e => e.trans_no)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<t_sheet_print_errlog>()
                .Property(e => e.description)
                .IsUnicode(false);

            modelBuilder.Entity<t_sheet_print_errlog>()
                .Property(e => e.memo)
                .IsUnicode(false);

            modelBuilder.Entity<t_sheet_print_errlog>()
                .Property(e => e.branch_no)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<t_sys_pos_status_history>()
                .Property(e => e.posid)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<t_sys_pos_status_history>()
                .Property(e => e.posdesc)
                .IsUnicode(false);

            modelBuilder.Entity<t_sys_pos_status_history>()
                .Property(e => e.hostip)
                .IsUnicode(false);

            modelBuilder.Entity<t_sys_pos_status_history>()
                .Property(e => e.hostname)
                .IsUnicode(false);

            modelBuilder.Entity<t_sys_pos_status_history>()
                .Property(e => e.operdate)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<t_sys_pos_status_history>()
                .Property(e => e.amount)
                .HasPrecision(16, 4);

            modelBuilder.Entity<t_sys_pos_status_history>()
                .Property(e => e.orderqty)
                .HasPrecision(6, 0);

            modelBuilder.Entity<t_sys_pos_status_history>()
                .Property(e => e.lastcashier)
                .IsUnicode(false);

            modelBuilder.Entity<t_sys_pos_status_history>()
                .Property(e => e.status)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<t_sys_pos_status_history>()
                .Property(e => e.other)
                .IsUnicode(false);

            modelBuilder.Entity<t_sys_pos_status_history>()
                .Property(e => e.com_flag)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<t_sys_sheet_psr_info>()
                .Property(e => e.main_name)
                .IsUnicode(false);

            modelBuilder.Entity<t_sys_sheet_psr_info>()
                .Property(e => e.template_name)
                .IsUnicode(false);

            modelBuilder.Entity<t_sys_sheet_psr_info>()
                .Property(e => e.template_flag)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<t_sys_sheet_psr_info>()
                .Property(e => e.object_code)
                .IsUnicode(false);

            modelBuilder.Entity<t_sys_sheet_psr_info>()
                .Property(e => e.oper_id)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<t_sys_system_verlog>()
                .Property(e => e.com_no)
                .HasPrecision(16, 0);

            modelBuilder.Entity<t_sys_system_verlog>()
                .Property(e => e.old_database_version)
                .IsUnicode(false);

            modelBuilder.Entity<t_sys_system_verlog>()
                .Property(e => e.database_version)
                .IsUnicode(false);

            modelBuilder.Entity<t_sys_system_verlog>()
                .Property(e => e.del_pc)
                .IsUnicode(false);

            modelBuilder.Entity<t_sys_system_verlog>()
                .Property(e => e.del_sqlid)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<t_sys_system_verlog>()
                .Property(e => e.login_name)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<t_sys_system_verlog>()
                .Property(e => e.del_program)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<wxsf_member_save_list>()
                .Property(e => e.oper_type)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<wxsf_member_save_list>()
                .Property(e => e.amt)
                .HasPrecision(16, 4);

            modelBuilder.Entity<wxsf_member_save_list>()
                .Property(e => e.is_proc)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<wxsf_member_save_list>()
                .Property(e => e.receipt_amt)
                .HasPrecision(16, 4);

            modelBuilder.Entity<wxsf_order_detail>()
                .Property(e => e.ordernum)
                .HasPrecision(18, 4);

            modelBuilder.Entity<wxsf_order_detail>()
                .Property(e => e.saleprice)
                .HasPrecision(18, 4);

            modelBuilder.Entity<wxsf_order_master>()
                .Property(e => e.tot_amt)
                .HasPrecision(18, 4);

            modelBuilder.Entity<wxsf_order_master>()
                .Property(e => e.total_dav)
                .HasPrecision(18, 4);

            modelBuilder.Entity<wxsf_order_master>()
                .Property(e => e.total_express)
                .HasPrecision(18, 4);

            modelBuilder.Entity<wxsf_order_master>()
                .Property(e => e.total)
                .HasPrecision(18, 4);

            modelBuilder.Entity<wxsf_order_master>()
                .Property(e => e.orderfrom)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<wxsf_order_master>()
                .Property(e => e.pay_type)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<wxsf_order_master>()
                .Property(e => e.deal_type)
                .IsUnicode(false);

            modelBuilder.Entity<wxsf_order_master>()
                .Property(e => e.dogflag)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<wxsf_order_master>()
                .Property(e => e.status)
                .IsUnicode(false);

            modelBuilder.Entity<wxsf_order_master>()
                .Property(e => e.is_proc)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<wxsf_vip_info>()
                .Property(e => e.acc_num)
                .HasPrecision(18, 4);

            modelBuilder.Entity<wxsf_vip_info>()
                .Property(e => e.dec_num)
                .HasPrecision(18, 4);

            modelBuilder.Entity<wxsf_vip_info>()
                .Property(e => e.now_acc_num)
                .HasPrecision(18, 4);

            modelBuilder.Entity<wxsf_vip_info>()
                .Property(e => e.subscribe)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<wxsf_vip_info>()
                .Property(e => e.oper_type)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<wxsf_vip_info>()
                .Property(e => e.is_proc)
                .IsFixedLength()
                .IsUnicode(false);
        }
    }
}
